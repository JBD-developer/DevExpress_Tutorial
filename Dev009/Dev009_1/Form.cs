using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace Dev009_1
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
        private Image _saveImage;
        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            switch (((SimpleButton)sender).Name)
            { 
                case "btnCreate":
                    LF_QRCodeCreate();
                    break;
                case "btnSave":
                    LF_QRCodeImageSave();
                    break;
                case"btnClear":
                    LF_Clear();
                    break;
                    
                default:
                    break;
            }
        }
        
        /// <summary>
        /// Create QRcode
        /// </summary>
        private void LF_QRCodeCreate()
        {
            if (string.IsNullOrEmpty(txtQRCode.Text))
            {
                return;
            }
            bccQRCode.Text = txtQRCode.Text;
        }

        /// <summary>
        /// Save QRcode
        /// </summary>
        private void LF_QRCodeImageSave()
        {
            try
            {
                string sImageFormat = cbxImageFormat.SelectedText;
                if (string.IsNullOrEmpty(sImageFormat))
                {
                    return;
                }
                Console.WriteLine(sImageFormat);

                switch (sImageFormat)
                {
                    case"BMP":
                        _saveImage = bccQRCode.ExportToImage(System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case"GIF":
                        _saveImage = bccQRCode.ExportToImage(System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case"JPEG":
                        _saveImage = bccQRCode.ExportToImage(System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case"PNG":
                        _saveImage = bccQRCode.ExportToImage(System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
                _saveImage.Save("QrCode."+ sImageFormat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void LF_Clear()
        {
            txtQRCode.Text = string.Empty;
            cbxImageFormat.SelectedText = string.Empty;
        }
    }
}