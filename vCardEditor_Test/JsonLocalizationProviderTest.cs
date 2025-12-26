using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using vCardEditor.Libs.TinyJson;
using vCardEditor.Repository;

namespace vCardEditor_Test
{
    [TestClass]
    public class JsonLocalizationProviderTest
    {
        [TestMethod]
        public void CorrectJsonLoaded_Test()
        {
            var fileHandler = Substitute.For<IFileHandler>();
            fileHandler.LoadJsonFromAssembly(Arg.Any<string>()).Returns(JsonEntries.JsonValid);
            var JsonParser = new TinyJsonParser();

            var embeddedlang = new LocalizationLoader(JsonParser, fileHandler).LoadEmbedded();

            Assert.IsTrue(embeddedlang.version == "1.0", "Json version incorrect");
            Assert.IsTrue(embeddedlang.languages.Count == 3, "Number of json entries invalid");

        }
    }
}
