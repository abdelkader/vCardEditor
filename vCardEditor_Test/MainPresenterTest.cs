using Microsoft.VisualStudio.TestTools.UnitTesting;
using VCFEditor.View;
using VCFEditor.Presenter;
using VCFEditor.Model;
using VCFEditor.Repository;
using vCardEditor.Repository;
using NSubstitute;
using vCardEditor.View;
using System;
using AutoFixture;
using Thought.vCards;
using System.Collections.Generic;
using vCardEditor;

namespace vCardEditor_Test
{
    [TestClass]
    public class MainPresenterTest
    {
        [TestMethod]
        public void NewFileOpened_OpenInvalidExtension_Test()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);
            view.NewFileOpened += Raise.EventWith(new EventArg<string>("filename.aaa"));

            view.Received().DisplayMessage(Arg.Any<string>(), Arg.Any<string>());
        }


        [TestMethod]
        public void NewFileOpened_OpenNewFile_Test()
        {
           
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.GetExtension(Arg.Any<string>()).Returns(".vcf");
            var view = Substitute.For<IMainView>();


            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            view.NewFileOpened += Raise.EventWith(new EventArg<string>("filename.vcf"));

            view.Received().DisplayContacts(Arg.Is<SortableBindingList<Contact>>(x=>x.Count == 1));
            view.Received().DisplayContacts(Arg.Is<SortableBindingList<Contact>>(x => x[0].card.FormattedName == "Jean Dupont1"));

        }


        [TestMethod]
        public void NewFileOpened_OpenNewOneWhileAnotherOneIsDirty_Test()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfThreeEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.GetExtension(Arg.Any<string>()).Returns(".vcf");
            var view = Substitute.For<IMainView>();
            view.AskMessage(Arg.Any<string>(), Arg.Any<string>()).Returns(true);

            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            view.NewFileOpened += Raise.EventWith(new EventArg<string>("filename.vcf"));
            repo.Contacts[1].isDirty = true;
            fileHandler.FileExist(Arg.Any<string>()).Returns(false);
            view.NewFileOpened += Raise.EventWith(new EventArg<string>("filename2.vcf"));
           
            view.Received().AskMessage(Arg.Any<string>(), Arg.Any<string>());

        }

        [TestMethod]
        public void SaveFile_FirstTime()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfThreeEntry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.GetExtension(Arg.Any<string>()).Returns(".vcf");
            var view = Substitute.For<IMainView>();


            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            view.NewFileOpened += Raise.EventWith(new EventArg<string>("aaa.vcf"));

            view.SaveContactsSelected += Raise.Event();

            fileHandler.Received().MoveFile("aaa.vcf", "aaa.vcf.old0");
        }



        [TestMethod]
        public void SaveFile_ExistAlready_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfThreeEntry);
            fileHandler.FileExist("aaa.vcf.old0").Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.GetExtension(Arg.Any<string>()).Returns(".vcf");
            var view = Substitute.For<IMainView>();


            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            view.NewFileOpened += Raise.EventWith(new EventArg<string>("aaa.vcf"));

            view.SaveContactsSelected += Raise.Event();

            fileHandler.Received().MoveFile("aaa.vcf", "aaa.vcf.old1");
        }


        [TestMethod]
        public void DeleteContact_ShouldDelete_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfThreeEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            repo.GetExtension(Arg.Any<string>()).Returns(".vcf");
            var view = Substitute.For<IMainView>();

            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            view.NewFileOpened += Raise.EventWith(new EventArg<string>("aaa.vcf"));
            
            //Mouse click on second row.
            repo.Contacts[1].isSelected = true;

            //Delete the second one.
            view.DeleteContact += Raise.Event();
           
            Assert.AreEqual(repo.Contacts.Count, 2);
            Assert.AreEqual(repo.Contacts[1].card.FormattedName, "Jean Dupont3");
        }


        [TestMethod]
        public void CopyTextToClipboardHandler_ShouldCopyvCard()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            view.SelectedContactIndex.Returns(0);
            
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            repo.LoadContacts("aaa.vcf");
            view.CopyTextToClipboardEvent += Raise.Event();

            view.Received().SendTextToClipBoard(Arg.Any<string>());
            view.Received().DisplayMessage("vCard copied to clipboard!", "Information");
            
        }

        [TestMethod]
        public void AddressRemovedHandler_ShouldRemove_Test()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntryWithTwoAddress);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            view.SelectedContactIndex.Returns(0);
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            var contact = repo.LoadContacts("aaa.vcf");

            view.AddressRemoved += Raise.EventWith(new EventArg<int>(0));

            Assert.AreEqual(1, repo.Contacts[0].card.DeliveryAddresses.Count);

        }

        [TestMethod]
        public void AddressAddedHandler_ShouldAddAddress_Test()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntryWithTwoAddress);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            view.SelectedContactIndex.Returns(0);
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            var contact = repo.LoadContacts("aaa.vcf");

            var fixture = new Fixture { RepeatCount = 2 };
            var lstvCardDeliveryAddressTypes = fixture.Create <List<vCardDeliveryAddressTypes>>();

            view.AddressAdded += Raise.EventWith(new EventArg<List<vCardDeliveryAddressTypes>>(lstvCardDeliveryAddressTypes));

            Assert.AreEqual(2 + 1, repo.Contacts[0].card.DeliveryAddresses.Count);
            Assert.AreEqual(2, repo.Contacts[0].card.DeliveryAddresses[2].AddressType.Count);


        }

        [TestMethod]
        public void AddressModifiedHandler_ShouldModifyAddress_Test()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntryWithTwoAddress);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            view.SelectedContactIndex.Returns(0);
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);

            var contact = repo.LoadContacts("aaa.vcf");

            var fixture = new Fixture { RepeatCount = 2 };
            var lstvCardDeliveryAddressTypes = fixture.Create<List<vCardDeliveryAddressTypes>>();

            view.AddressModified += Raise.EventWith(new EventArg<List<vCardDeliveryAddressTypes>>(lstvCardDeliveryAddressTypes));

            Assert.AreEqual(1, repo.Contacts[0].card.DeliveryAddresses.Count);
            Assert.AreEqual(2, repo.Contacts[0].card.DeliveryAddresses[0].AddressType.Count);

        }

        [TestMethod]
        public void ExportImage_ShouldExportArrayByte_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfwithInternalPhoto);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            view.SelectedContactIndex.Returns(0);
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);
            _ = repo.LoadContacts("aaa.vcf");
            
            view.ExportImage += Raise.Event();

            fileHandler.Received().WriteBytesToFile(Arg.Any<string>(), Arg.Any<Byte[]>());

        }

        [TestMethod]
        public void ModifyImage_ShouldModify_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfwithInternalPhoto);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            view.SelectedContactIndex.Returns(0);
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);
            var contact = repo.LoadContacts("aaa.vcf");

            view.ModifyImage += Raise.EventWith(new EventArg<string>(""));

            Assert.AreEqual(0, repo.Contacts[0].card.Photos.Count);
            Assert.IsTrue(repo.Contacts[0].isDirty);
        }

        [TestMethod]
        public void AddContact_ShouldCreateEmtptyContactFile_Test()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);
            view.AddContact += Raise.Event();

            view.Received().DisplayContacts(Arg.Any<SortableBindingList<Contact>>());
            Assert.IsTrue(repo.Contacts.Count == 1);
        }

        [TestMethod]
        public void SaveSplittedFile_ShouldCall3TimesFileSaving_Test()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfFourEntry);
            fileHandler.FileExist(Arg.Any<string>()).Returns(true);

            var repo = Substitute.For<ContactRepository>(fileHandler);
            
            repo.LoadContacts("aaa.vcf");
            repo.Contacts[3].isDeleted = true;

            var view = Substitute.For<IMainView>();
            view.DisplayOpenFolderDialog().Returns("aaa");
            var localization = Substitute.For<ILocalizationProvider>();
            _ = new MainPresenter(view, repo, localization);
            view.SplitFileEvent += Raise.Event();

            //Should save only 3 files.
            fileHandler.Received(3).WriteAllText(Arg.Any<string>(), Arg.Any<string>());
            
        }

    }
}
