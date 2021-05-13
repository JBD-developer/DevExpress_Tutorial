using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev004
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static int mail = 0; 
        public Main()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            badge1.Properties.Text = (++mail).ToString();
            badge1.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            badge1.Visible = false;
            timer1.Start();
        }

        private void barBtnMail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mail == 0)
                return;
                badge1.Properties.Text = (--mail).ToString();
            if (mail == 0)
                badge1.Visible = false; 
            XtraForm1 frm = new XtraForm1();
            frm.MdiParent = this;
            frm.Show();



        }
    }
}