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

namespace Dev009_1
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
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
                    break;
                case"btnClear":
                    break;
                default:
                    break;
            }
        }

        private void LF_QRCodeCreate()
        {
            if (string.IsNullOrEmpty(txtQRCode.Text))
            {
                return;
            }
            bccQRCode.Text = txtQRCode.Text;
        }


    }
}