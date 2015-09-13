using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VCFEditor;
using VCFEditor.View;
using Moq;
using VCFEditor.Presenter;

namespace vCardEditor_Test
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class MainPresenterTest
    {
       
        [TestMethod]
        public void NewFileOpenedTest()
        {
            var repo = new Mock<IContactRepository>();
            var view = new Mock<IMainView>();

            var presenter = new MainPresenter(view.Object, repo.Object);
        }

        
    }
}
