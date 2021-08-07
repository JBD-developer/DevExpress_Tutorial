using System;
using System.Text;
using System.Drawing;

using DevExpress.BarCodes;
using DevExpress.XtraEditors;

namespace Dev009_2
{
    public partial class Form : XtraForm
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            switch (((SimpleButton)sender).Name)
            {
                case "btnCreate":
                    LF_QRcodeCreate();
                    break;

                case "btnClear":
                    break;
                
                case "btnSave":
                    break;
                    
                default:
                    break;
            }
        }
        private void LF_QRcodeCreate()
        {
            pieQRcodePreview.Image = null;
            BarCode barCode = new BarCode();
            barCode.Symbology = Symbology.QRCode;
            barCode.CodeText = txtQRCode.Text;
            barCode.BackColor = Color.White;
            barCode.ForeColor = Color.Black;
            barCode.RotationAngle = 0;
            barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
            barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte;
            barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
            barCode.Options.QRCode.ShowCodeText = false;
            barCode.DpiX = 170;
            barCode.DpiY = 170;
            barCode.Module = 2f;
            this.pieQRcodePreview.Image = barCode.BarCodeImage;
        }


    }
}