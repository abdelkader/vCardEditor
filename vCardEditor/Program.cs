using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using vCardEditor.View;
using VCFEditor.Presenter;
using VCFEditor;
using VCFEditor.Repository;
using vCardEditor.Repository;

namespace vCardEditor
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var fileHandler = new FileHandler();
            var mainForm = new MainForm();
            new MainPresenter(mainForm, new ContactRepository(fileHandler));

            Application.Run(mainForm);
        }
    }
}
