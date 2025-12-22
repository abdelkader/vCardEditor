using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Thought.vCards;
using vCardEditor.Repository;
using vCardEditor.View;
using VCFEditor.Model;
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
            
            repo.LoadContacts("file.vcf");
            
            Assert.IsTrue(repo.Contacts.Count == 0);
        }

        [TestMethod]
        public void NewFileOpened_IncorrectVCF_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfIncorrect);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);

            repo.LoadContacts("file.vcf");

            Assert.IsTrue(repo.Contacts.Count == 0);
        }

        [TestMethod]
        public void NewFileOpened_Utf8Entry_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfUtf8Entry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var contacts = repo.LoadContacts("file.vcf");

            Assert.AreEqual(repo.Contacts[0].Name, "Oum Alaâ");
        }

        [TestMethod]
        public void NewFileOpened_Address_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var contacts = repo.LoadContacts("file.vcf");
            Assert.IsTrue(repo.Contacts[0].card.DeliveryAddresses.FirstOrDefault().AddressType.Contains(vCardDeliveryAddressTypes.Work));
        }

        [TestMethod]
        public void NewFileOpened_SaveDirtyCellPhone_NotNullWithNotNull_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfFourEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);

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
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);

            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.LoadContacts("file.vcf");
            repo.Contacts[0].isDirty = true;

            repo.SaveDirtyVCard(0, new vCard());


            var card = repo.Contacts[0].card;
            Assert.AreEqual(card.Phones.Count, 0);
        }

        [TestMethod]
        public void NewFileOpened_SaveDirtyCellPhone_NullWithNotNull_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfFourEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
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
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
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
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.LoadContacts("file.vcf");
            repo.Contacts[0].isDirty = true;

            repo.SaveDirtyVCard(0, new vCard());

            var card = repo.Contacts[0].card;
            Assert.IsNull(card.Phones.GetFirstChoice(vCardPhoneTypes.Cellular));
        }

        [TestMethod]
        public void AddEmptyContact_ContactNotNull_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);

            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.LoadContacts("file.vcf");

            repo.AddEmptyContact();

            
            Assert.IsTrue(repo.Contacts.Count > 0);
        }

        [TestMethod]
        public void AddEmptyContact_ContactIsNull_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            var repo = Substitute.For<ContactRepository>(fileHandler);

            repo.AddEmptyContact();

            Assert.IsTrue(repo.Contacts.Count == 1);
        }

        [TestMethod]
        public void ExportToCsv_WritesExpectedCsv()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            var repo = new ContactRepository(fileHandler);

            var card1 = new vCard
            {
                FormattedName = "John Doe",
                GivenName = "John",
                FamilyName = "Doe",
                Organization = "Acme Co",
                BirthDate = new DateTime(1980, 1, 1)
            };
            card1.EmailAddresses.Add(new vCardEmailAddress("john@example.com", vCardEmailAddressType.Internet));
            card1.Phones.Add(new vCardPhone("12345", vCardPhoneTypes.Cellular));
            var contact1 = new Contact(card1);

            var card2 = new vCard
            {
                FormattedName = "Marie, \"La\"",
                GivenName = "Marie",
                FamilyName = "ONeil"
            };
            var contact2 = new Contact(card2);

            repo.Contacts = new SortableBindingList<Contact>(new List<Contact> { contact1, contact2 });

            string expectedPath = "out.csv";
            repo.ExportToCsv(expectedPath, repo.Contacts);

            fileHandler.Received(1).WriteAllText(expectedPath, Arg.Is<string>(s =>
                s.Contains("FormattedName,GivenName,FamilyName,Email,Cellular,Organization,BirthDate")
                && s.Contains("John Doe")
                && s.Contains("john@example.com")
                && s.Contains("12345")
                && s.Contains("\"Marie, \"\"La\"\"\"")
            ));
        }

        [TestMethod]
        public void ExportToJson_WritesExpectedJson()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            var repo = new ContactRepository(fileHandler);

            var card1 = new vCard
            {
                FormattedName = "John Doe",
                GivenName = "John",
                FamilyName = "Doe",
                Organization = "Acme Co",
                BirthDate = new DateTime(1980, 1, 1)
            };
            card1.EmailAddresses.Add(new vCardEmailAddress("john@example.com", vCardEmailAddressType.Internet));
            card1.Phones.Add(new vCardPhone("12345", vCardPhoneTypes.Cellular));
            var contact1 = new Contact(card1);

           
            var card2 = new vCard
            {
                FormattedName = "Marie, \"La\"",
                GivenName = "Marie",
                FamilyName = "ONeil"
            };
            var contact2 = new Contact(card2);

            repo.Contacts = new SortableBindingList<Contact>(new List<Contact> { contact1, contact2 });

            string expectedPath = "out.json";
            repo.ExportToJson(expectedPath, repo.Contacts);

            fileHandler.Received(1).WriteAllText(expectedPath, Arg.Is<string>(s =>
                s.Contains("[") 
                && s.Contains("\"FormattedName\":")
                && s.Contains("\"John Doe\"")
                && s.Contains("\\\"La\\\"")
            ));
        }


        [TestMethod]
        public void ImportFromCsv_ParsesQuotedAndSimpleFields()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.OpenRead(Arg.Any<string>()).Returns(ci =>
            {
                var bytes = Encoding.UTF8.GetBytes( Entries.vcfCSVTwoEntry);
                return new MemoryStream(bytes);
            });
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);

            var repo = Substitute.For<ContactRepository>(fileHandler);
                
            var contacts = repo.ImportFromCsv("file.vcf");

            Assert.IsNotNull(contacts);
            Assert.AreEqual(2, contacts.Count);

            var c1 = contacts[0].card;
            Assert.AreEqual("John Doe", c1.FormattedName);
            Assert.AreEqual("john@example.com", c1.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet).Address);
            Assert.AreEqual("12345", c1.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber);

            var c2 = contacts[1].card;
            Assert.AreEqual("Marie, \"La\"", c2.FormattedName);
            Assert.AreEqual("Marie", c2.GivenName);
            

        }

        [TestMethod]
        public void ImportFromJson_ParsesJsonArray()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfJSONTwoEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);

            var repo = Substitute.For<ContactRepository>(fileHandler);

         
            var contacts = repo.ImportFromJson("file.json");

            Assert.IsNotNull(contacts);
            Assert.AreEqual(2, contacts.Count);

            var c1 = contacts[0].card;
            Assert.AreEqual("John Doe", c1.FormattedName);
            Assert.AreEqual("john@example.com", c1.EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet).Address);
            Assert.AreEqual("12345", c1.Phones.GetFirstChoice(vCardPhoneTypes.Cellular).FullNumber);

            var c2 = contacts[1].card;
            Assert.AreEqual("Marie, \"La\"", c2.FormattedName);
            Assert.AreEqual("Marie", c2.GivenName);
        }
    }
}
