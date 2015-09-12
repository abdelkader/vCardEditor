using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using vCardEditor.View;
using VCFEditor.Presenter;
using VCFEditor;

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

            var mainForm = new MainForm();
            var presenter = new MainPresenter(mainForm, new ContactRepository());

            Application.Run(mainForm);
        }
    }
}
