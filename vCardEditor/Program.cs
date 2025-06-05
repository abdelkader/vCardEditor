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
            FileHandler fileHandler = new FileHandler();

            var embeddedlang = new LocalizationLoader(new TinyJsonParser(), fileHandler).LoadEmbedded();

            MainForm mainForm = new MainForm();
            new MainPresenter(mainForm,
                              new ContactRepository(fileHandler), 
                              new JsonLocalizationProvider(embeddedlang));

            Application.Run(mainForm);
        }
    }
}
