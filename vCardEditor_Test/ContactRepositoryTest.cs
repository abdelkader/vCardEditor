using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thought.vCards;
using vCardEditor.Repository;
using VCFEditor.Repository;

namespace vCardEditor_Test
{
    [TestClass]
    public class ContactRepositoryTest
    {
        [TestMethod]
        public void NewFileOpened_EmtpyVCF_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfEmtpy);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            
            var contacts = repo.LoadContacts("file.vcf");
            
            Assert.IsTrue(contacts.Count == 0);
        }

        [TestMethod]
        public void NewFileOpened_Utf8Entry_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfUtf8Entry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var contacts = repo.LoadContacts("file.vcf");

            Assert.AreEqual(contacts[0].Name, "Oum Alaâ");
        }

        [TestMethod]
        public void NewFileOpened_Address_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var contacts = repo.LoadContacts("file.vcf");
            Assert.IsTrue(contacts[0].card.DeliveryAddresses.FirstOrDefault().AddressType.Contains(vCardDeliveryAddressTypes.Work));
        }

        [TestMethod]
        public void NewFileOpened_SaveDirtyCellPhone_NotNullWithNotNull_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfFourEntry);
            
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.LoadContacts("file.vcf");
            repo.Contacts[0].isDirty=true;
            
            string phone = "0011223344";
            var newCard = new vCard();
            newCard.Phones.Add(new vCardPhone(phone, vCardPhoneTypes.Cellular));
            
            repo.SaveDirtyVCard(0, newCard);


            var card = repo.Contacts[0].card;
            Assert.AreEqual(card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber, phone);
        }

        [TestMethod]
        public void NewFileOpened_SaveDirtyCellPhone_NotNullWithNull_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfFourEntry);

            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.LoadContacts("file.vcf");
            repo.Contacts[0].isDirty = true;

            repo.SaveDirtyVCard(0, new vCard());


            var card = repo.Contacts[0].card;
            Assert.AreEqual(card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber, string.Empty);
        }

        [TestMethod]
        public void NewFileOpened_SaveDirtyCellPhone_NullWithNotNull_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfFourEntry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.LoadContacts("file.vcf");
            repo.Contacts[2].isDirty = true;

            string phone = "0011223344";
            var newCard = new vCard();
            newCard.Phones.Add(new vCardPhone(phone, vCardPhoneTypes.Cellular));
            repo.SaveDirtyVCard(2, newCard);

            var card = repo.Contacts[2].card;
            Assert.AreEqual(card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber, phone);
        }

        [TestMethod]
        public void NewFileOpened_SaveDirtyCellPhone_NullWithNull_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfFourEntry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.LoadContacts("file.vcf");
            repo.Contacts[3].isDirty = true;
          
            repo.SaveDirtyVCard(3, new vCard());

            var card = repo.Contacts[2].card;
            Assert.IsNull(card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular));
        }


        [TestMethod]
        public void NewFileOpened_v21_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfWikiv21);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.LoadContacts("file.vcf");
            repo.Contacts[0].isDirty = true;

            repo.SaveDirtyVCard(0, new vCard());

            var card = repo.Contacts[0].card;
            Assert.IsNull(card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular));
        }
    }
}
