using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Dev007
{
    public partial class Form1 : Form
    {
        TestEntities _test;
        CustomerTest _customer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (((SimpleButton)sender).Name)
                {
                    case "btnBrowse":
                        LF_ImageFile();
                        break;

                    case "btnNew":
                        panelMain.Enabled = true;
                        txtCustomerID.Focus();
                        _customer = new CustomerTest();
                        _test.CustomerTest.Add(_customer);
                        customerTestBindingSource.Add(_customer);
                        customerTestBindingSource.MoveLast();
                        break;

                    case "btnEdit":
                        panelMain.Enabled = true;
                        txtCustomerID.Focus();

                        break;

                    case "btnCancel":
                        panelMain.Enabled = false;
                        txtCustomerID.Focus();
                        foreach (DbEntityEntry entry in _test.ChangeTracker.Entries())
                        {
                            switch (entry.State)
                            {
                                case EntityState.Added:
                                    entry.State = EntityState.Detached;
                                    break;
                                case EntityState.Modified:
                                    entry.State = EntityState.Unchanged;
                                    break;
                                case EntityState.Deleted:
                                    entry.Reload();
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    case "btnSave":
                        customerTestBindingSource.EndEdit();
                        _test.SaveChangesAsync();
                        panelMain.Enabled = false ;
                       
                        break;
                    default:
                        
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Searh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    gdvMain.DataSource = customerTestBindingSource;
                }
                else
                {
                    var query = from o in customerTestBindingSource.DataSource as List<CustomerTest>
                                where o.CustomerID == txtSearch.Text || o.Fullname.Contains(txtSearch.Text) || o.Email.Contains(txtEmail.Text) || o.Address.Contains(mmeAddress.Text)
                                select o;
                    gdvMain.DataSource = query.ToList();
                }
            }
        }

        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are You sure want to delete this record? ", "Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
                {
                    _test.CustomerTest.Remove(customerTestBindingSource.Current as CustomerTest);
                    customerTestBindingSource.RemoveCurrent();
                }
            }
        }

        private void LF_ImageFile()
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                    if (ofd.ShowDialog() ==DialogResult.OK)
                    {
                        pictureEdit1.Image = Image.FromFile(ofd.FileName);
                    }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMain.Enabled = false;
            _test = new TestEntities();
            customerTestBindingSource.DataSource = _test.CustomerTest.ToList();
        }
    }
}
