using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev012
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
        public Form()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void LF_MessageBox()
        {
            XtraMessageBoxArgs messageBox = new XtraMessageBoxArgs();
            int iTimeCount = 2000;
            messageBox.AutoCloseOptions.Delay = iTimeCount;
            messageBox.Caption = "확인";
            messageBox.Text = (iTimeCount / 1000).ToString() + "초 후 자동으로 닫힙니다";
            messageBox.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };

            XtraMessageBox.Show(messageBox).ToString();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            switch (((SimpleButton)sender).Name)
            {
                case "btnMessage":
                    LF_MessageBox();
                    break;

                case "btnExit":
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        
    }
}