using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using vCardEditor.Repository;

namespace vCardEditor.View
{
    partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Accesseurs d'attribut de l'assembly

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private async void updateButton_Click(object sender, EventArgs e)
        {
            string url = ConfigRepository.Instance.VersionUrl;

            try
            {
                using (var client = new System.Net.WebClient())
                {
                    string result = await client.DownloadStringTaskAsync(url);
                    if (result.Length > 0)
                    {
                        using (var reader = new StringReader(result))
                        {
                            string InternetVersion = reader.ReadLine();
                            string AssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                            Version v1 = new Version(InternetVersion);
                            Version v2 = new Version(AssemblyVersion);

                            if (v1.CompareTo(v2) > 0)
                                MessageBox.Show(String.Format("New version {0} found!", result));
                            else
                                MessageBox.Show("You have the latest version!");
                        }

                    }
                
                }

            }
            catch (WebException )
            {
                MessageBox.Show("Could not download version information from GitHub.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception )
            {
                MessageBox.Show("Error processing version information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
