using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev002
{
    public partial class XtraForm : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm()
        {
            InitializeComponent();
        }

        private void XtraForm_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);
            if (File.Exists(fileName))
            {
                ltc.RestoreLayoutFromXml(fileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}