using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vCardEditor.Repository;
using VCFEditor.Repository;

namespace vCardEditor_Test
{
    [TestClass]
    public class ContactRepositoryTest
    {
        [TestMethod]
        public void NewFileOpened_Utf8Entry_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.ReadAllLines(Arg.Any<string>()).Returns(Entries.vcfUtf8Entry);
            var repo = Substitute.For<ContactRepository>(fileHandler);

            Assert.AreEqual(repo.LoadContacts("name")[0].Name, "Oum Alaâ");
        }
    }
}
