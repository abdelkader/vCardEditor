using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VCFEditor;
using VCFEditor.View;
using VCFEditor.Presenter;
using VCFEditor.Model;
using System.ComponentModel;
using VCFEditor.Repository;
using vCardEditor.Repository;
using NSubstitute;

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


            var presenter = new MainPresenter(view, repo);
            view.NewFileOpened += Raise.EventWith(new EventArg<string>("aaa"));

            view.Received().DisplayMessage(Arg.Any<string>(), Arg.Any<string>());
        }


        [TestMethod]
        public void NewFileOpened_OpenNewFile_Test()
        {
           
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfOneEntry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();

            
            var presenter = new MainPresenter(view, repo);
            view.NewFileOpened += Raise.EventWith(new EventArg<string>("aaa.vcf"));

            view.Received().DisplayContacts(Arg.Is<BindingList<Contact>>(x=>x.Count == 1));
            view.Received().DisplayContacts(Arg.Is<BindingList<Contact>>(x => x[0].card.FormattedName == "Jean Dupont1"));

        }


        [TestMethod]
        public void NewFileOpened_OpenNewOneWhileAnotherOneIsDirty_Test()
        {

            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfThreeEntry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();
            view.AskMessage(Arg.Any<string>(), Arg.Any<string>()).Returns(true);

            var presenter = new MainPresenter(view, repo);
            view.NewFileOpened += Raise.EventWith(new EventArg<string>("aaa.vcf"));
            repo.Contacts[1].isDirty = true;

            view.NewFileOpened += Raise.EventWith(new EventArg<string>("bbb.vcf"));
           
            view.Received().AskMessage(Arg.Any<string>(), Arg.Any<string>());

        }
        

        [TestMethod]
        public void DeleteTest()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfThreeEntry);
            var repo = Substitute.For<ContactRepository>(fileHandler);
            var view = Substitute.For<IMainView>();

           
            var presenter = new MainPresenter(view, repo);
            view.NewFileOpened += Raise.EventWith(new EventArg<string>("aaa.vcf"));
            
            //Mouse click on second row.
            repo.Contacts[1].isSelected = true;

            //Delete the second one.
            view.DeleteContact += Raise.Event();
           
            Assert.AreEqual(repo.Contacts.Count, 2);
            Assert.AreEqual(repo.Contacts[1].card.FormattedName, "Jean Dupont3");
        }




       

    }
}
