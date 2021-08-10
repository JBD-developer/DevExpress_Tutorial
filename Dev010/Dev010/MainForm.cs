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
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace Dev010
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            switch (((SimpleButton)sender).Name)
            {
                case "btnStart":
                    LF_WaitForm();
                    break;

                default:
                    break;
            }
        }
        private void LF_WaitForm()
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, true);
            for (int i = 0; i < 100; i++)
            {
                SplashScreenManager.Default.SetWaitFormDescription(i.ToString() + "%");

                Thread.Sleep(25);
            }
            SplashScreenManager.CloseForm(false);
        }
    }
}