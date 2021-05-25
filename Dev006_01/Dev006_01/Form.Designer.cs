
namespace Dev006_01
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(331, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(169, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(412, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(88, 439);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.Btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.customerTestBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(20, 236);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(466, 197);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtAddress);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtFullname);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtCustomerID);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(16, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(466, 166);
            this.panel.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTestBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(100, 100);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(349, 43);
            this.txtAddress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address : ";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTestBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(100, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email : ";
            // 
            // txtFullname
            // 
            this.txtFullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTestBindingSource, "Fullname", true));
            this.txtFullname.Location = new System.Drawing.Point(100, 44);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(349, 22);
            this.txtFullname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Full Name : ";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTestBindingSource, "CustomerID", true));
            this.txtCustomerID.Location = new System.Drawing.Point(100, 16);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(123, 22);
            this.txtCustomerID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "CustomerID : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(116, 199);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(349, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search  : ";
            // 
            // customerTestBindingSource
            // 
            this.customerTestBindingSource.DataSource = typeof(Dev006_01.CustomerTest);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.Btn_Click);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 474);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource customerTestBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}