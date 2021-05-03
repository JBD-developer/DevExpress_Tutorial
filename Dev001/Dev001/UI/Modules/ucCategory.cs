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
using System.Data.SqlClient;

namespace Dev001.UI.Modules
{
    public partial class ucCategory : DevExpress.DXperience.Demos.TutorialControlBase
    {
        private string currentDirecctory = Environment.CurrentDirectory;
        private string connectionStr = string.Format("Data Source={0}, {1}; Initial Catalog={2}; User ID={3}; Password={4}", "127.0.0.1", 1433, "Northwind", "scott", "tiger");
        public ucCategory()
        {
            InitializeComponent();
        }

        private void ucCategory_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            con.Open();

            DataSet ds = new DataSet();
            string sql = "SELECT * FROM CATEGORIES";
            SqlDataAdapter clsSqlDataAdapter = new SqlDataAdapter(sql, con);
            clsSqlDataAdapter.Fill(ds);
            con.Close();
            gridControl1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
