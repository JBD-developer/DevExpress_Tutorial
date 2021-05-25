using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev006_01
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
        TestEntities test;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            panel.Enabled = false;
            test = new TestEntities();
            customerTestBindingSource.DataSource = test.CustomerTest.ToList();
        }

        /// <summary>
        /// Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            switch (((SimpleButton)sender).Name)
            {
                case "btnNew":
                    try
                    {
                        panel.Enabled = true;
                        txtCustomerID.Focus();
                        CustomerTest customerTest = new CustomerTest();
                        test.CustomerTest.Add(customerTest);
                        customerTestBindingSource.Add(customerTest);
                        customerTestBindingSource.MoveLast();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        customerTestBindingSource.ResetBindings(false);
                    }
                    break;

                case "btnEdit":
                    panel.Enabled = true;
                    txtCustomerID.Focus();
                    break;

                case "btnDelete":
                    break;

                case "btnCancel":
                    panel.Enabled = true;
                    customerTestBindingSource.ResetBindings(false);
                    foreach (DbEntityEntry entry in test.ChangeTracker.Entries())
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
                    try
                    {
                        customerTestBindingSource.EndEdit();
                        test.SaveChangesAsync();
                        panel.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        customerTestBindingSource.ResetBindings(false);
                    }
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// Search Textbox KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridView.DataSource = customerTestBindingSource;
                }
                else
                {
                    var query = from o in customerTestBindingSource.DataSource as List<CustomerTest>
                                where o.CustomerID == txtSearch.Text || o.Fullname.Contains(txtSearch.Text) || o.Email == txtSearch.Text || o.Address.Contains(txtSearch.Text)
                                select o;
                    dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Meaasge",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    test.CustomerTest.Remove(customerTestBindingSource.Current as CustomerTest);
                    customerTestBindingSource.RemoveCurrent();
                }
            }
        }
    }
}