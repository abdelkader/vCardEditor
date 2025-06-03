using System;
using System.Windows.Forms;
using vCardEditor.Libs.TinyJson;
using vCardEditor.Repository;
using vCardEditor.View;
using VCFEditor.Presenter;
using VCFEditor.Repository;

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

            var embedded = LocalizationLoader.LoadEmbedded();
            var localizationProvider = new JsonLocalizationProvider(embedded);

            FileHandler fileHandler = new FileHandler();
            MainForm mainForm = new MainForm();
            new MainPresenter(mainForm, new ContactRepository(fileHandler), localizationProvider);

            Application.Run(mainForm);
        }
    }
}
