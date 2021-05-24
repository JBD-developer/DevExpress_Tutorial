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

namespace Dev006
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ltgMain.Enabled = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            switch (((SimpleButton)sender).Name)
            {
                case "btnNew":
                    ltgMain.Enabled = true;
                    txtCustomerId.Focus();
                    Customer customer = new Customer();
                    break;

                case "btnSave": 
                    break;

                case "btnEdit": 
                    break;

                case "btnCancel": 
                    break;
                default:
                    break;
            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtKeyword.Text))
                {
                    gdcMain.DataSource = customerBindingSource;
                }
                else
                {
                    var query = from o in customerBindingSource.DataSource as List<Customer>
                                where o.CustomerID == txtKeyword.Text||o.ContactName.Contains(txtContactName.Text)
                                select o ;
                    gdcMain.DataSource = query.ToList();
                }
            }
        }
    }
}