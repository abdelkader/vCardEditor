using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace vCardEditor.View
{
    public partial class QRDialog : Form
    {
        public QRDialog()
        {
            InitializeComponent();
        }

        private void RenderQrCode()
        {

            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)0;

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode("BEGIN:VCARD\r\nVERSION:3.0\r\nN:Chlef université;sarah;;;\r\nFN:sarah Chlef université\r\nADR;TYPE=HOME:;;sdad;;das;;\r\nEMAIL;TYPE=INTERNET:sibri02@yahoo.fr\r\nNOTE:I am proficient in Tiger-Crane Style\\,\\nand I am more than proficient in the exquisite art of the Samurai sword.\r\nNOTE:eee\r\nORG:Google\\;GMail Team\\;Spam Detection Squad\r\nTEL;TYPE=CELL;TYPE=OTHER;TYPE=VOICE:+213560348275\r\nTEL;TYPE=OTHER;TYPE=FAX:+2131122\r\nEND:VCARD\r\n", eccLevel))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, GetPrimaryColor(), GetBackgroundColor(), null, 1);

                pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
                //Set the SizeMode to center the image.
                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private Color GetPrimaryColor()
        {
            return Color.Black;
        }

        private Color GetBackgroundColor()
        {
            return Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Bitmap Image|*.bmp|PNG Image|*.png|JPeg Image|*.jpg|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                using (FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile())
                {
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.

                    ImageFormat imageFormat = null;
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            imageFormat = ImageFormat.Bmp;
                            break;
                        case 2:
                            imageFormat = ImageFormat.Png;
                            break;
                        case 3:
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case 4:
                            imageFormat = ImageFormat.Gif;
                            break;
                        default:
                            throw new NotSupportedException("File extension is not supported");
                    }

                    pictureBoxQRCode.BackgroundImage.Save(fs, imageFormat);
                }
            }
        }
    }
}
