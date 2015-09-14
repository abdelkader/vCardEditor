using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VCFEditor;
using VCFEditor.View;
using Moq;
using VCFEditor.Presenter;
using VCFEditor.Model;
using System.ComponentModel;
using VCFEditor.Repository;
using vCardEditor.Repository;

namespace vCardEditor_Test
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class MainPresenterTest
    {
        #region vCard Entries
        public string[] vcfOneEntry
        {
            get
            {
                string s = @"BEGIN:VCARD\n" +
                        "VERSION:2.1\n" +
                        "FN:Jean Dupont1\n" +
                        "N:Dupont;Jean\n" +
                        "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                        "LABEL;QUOTED-PRINTABLE;WORK;PREF:Rue Th. Decuyper 6A=Bruxelles 1200=Belgique\n" +
                        "TEL;CELL:+1234 56789\n" +
                        "EMAIL;INTERNET:jean.dupont@example.com\n" +
                        "END:VCARD";
                return s.Split('\n');
            }
        }

        public string[] vcfThreeEntry
        {
            get
            {
                string s = "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont1\n" +
                            "N:Dupont;Jean\n" +
                            "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                            "TEL;CELL:+1234 56789\n" +
                            "EMAIL;INTERNET:jean.dupont@example.com\n" +
                            "END:VCARD\n" +
                            "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont1\n" +
                            "N:Dupont;Jean\n" +
                            "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                            "TEL;CELL:+1234 56789\n" +
                            "EMAIL;INTERNET:jean.dupont@example.com\n" +
                            "END:VCARD\n" +
                            "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont3\n" +
                            "N:Dupont;Jean\n" +
                            "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                            "TEL;CELL:+1234 56789\n" +
                            "EMAIL;INTERNET:jean.dupont@example.com\n" +
                            "END:VCARD";
                return s.Split('\n');
            }
        }
        #endregion

        [TestMethod]
        public void NewFileOpenedTest()
        {
            var handler = new Mock<IFileHandler>();
            var repo = new Mock<ContactRepository>(handler.Object);
            var view = new Mock<IMainView>();
            handler.Setup(x => x.ReadAllLines("filename"))
                    .Returns(vcfOneEntry);


            var presenter = new MainPresenter(view.Object, repo.Object);
            view.Raise(m => m.NewFileOpened += null, new EventArg<string>("filename"));

            view.Verify(m => m.DisplayContacts(It.Is<BindingList<Contact>>(x => x.Count == 1)));
            view.Verify(m => m.DisplayContacts(It.Is<BindingList<Contact>>(x => x[0].card.FormattedName == "Jean Dupont1")));
        }

        [TestMethod]
        public void DeleteTest()
        {
            var handler = new Mock<IFileHandler>();
            var repo = new Mock<ContactRepository>(handler.Object);
            var view = new Mock<IMainView>();
            handler.Setup(x => x.ReadAllLines("filename"))
                    .Returns(vcfThreeEntry);


            var presenter = new MainPresenter(view.Object, repo.Object);
            view.Raise(m => m.NewFileOpened += null, new EventArg<string>("filename"));

            //Mouse click on second row.
            repo.Object.Contacts[1].isSelected = true;

            //Delete the second one.
            view.Raise(m => m.DeleteContact += null, null, null);


            Assert.AreEqual(repo.Object.Contacts.Count, 2);
            Assert.AreEqual(repo.Object.Contacts[1].card.FormattedName, "Jean Dupont3");
        }



    }
}
