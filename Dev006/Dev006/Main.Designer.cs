
namespace Dev006
{
    partial class Main
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.ltc = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.gdcMain = new DevExpress.XtraGrid.GridControl();
            this.gdvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerId = new DevExpress.XtraEditors.TextEdit();
            this.txtKeyword = new DevExpress.XtraEditors.TextEdit();
            this.ltg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ltgSearch = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lti_txtKeyword = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ltgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lti_txtCustomerId = new DevExpress.XtraLayout.LayoutControlItem();
            this.lti_txtFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lti_txtEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.lti_txtAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ltgSub = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ltc)).BeginInit();
            this.ltc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtKeyword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtCustomerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ltc
            // 
            this.ltc.Controls.Add(this.btnSave);
            this.ltc.Controls.Add(this.btnEdit);
            this.ltc.Controls.Add(this.btnCancel);
            this.ltc.Controls.Add(this.btnNew);
            this.ltc.Controls.Add(this.gdcMain);
            this.ltc.Controls.Add(this.txtAddress);
            this.ltc.Controls.Add(this.txtEmail);
            this.ltc.Controls.Add(this.txtFullName);
            this.ltc.Controls.Add(this.txtCustomerId);
            this.ltc.Controls.Add(this.txtKeyword);
            this.ltc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltc.Location = new System.Drawing.Point(0, 0);
            this.ltc.Name = "ltc";
            this.ltc.Root = this.ltg;
            this.ltc.Size = new System.Drawing.Size(677, 669);
            this.ltc.TabIndex = 0;
            this.ltc.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(568, 623);
            this.btnSave.MaximumSize = new System.Drawing.Size(85, 22);
            this.btnSave.MinimumSize = new System.Drawing.Size(85, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 22);
            //this.btnSave.StyleController = this.ltc;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(390, 623);
            this.btnEdit.MaximumSize = new System.Drawing.Size(85, 22);
            this.btnEdit.MinimumSize = new System.Drawing.Size(85, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 22);
            this.btnEdit.StyleController = this.ltc;
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(479, 623);
            this.btnCancel.MaximumSize = new System.Drawing.Size(85, 22);
            this.btnCancel.MinimumSize = new System.Drawing.Size(85, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 22);
            this.btnCancel.StyleController = this.ltc;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(301, 623);
            this.btnNew.MaximumSize = new System.Drawing.Size(85, 22);
            this.btnNew.MinimumSize = new System.Drawing.Size(85, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 22);
            this.btnNew.StyleController = this.ltc;
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.Btn_Click);
            // 
            // gdcMain
            // 
            this.gdcMain.Location = new System.Drawing.Point(24, 255);
            this.gdcMain.MainView = this.gdvMain;
            this.gdcMain.Name = "gdcMain";
            this.gdcMain.Size = new System.Drawing.Size(629, 364);
            this.gdcMain.TabIndex = 9;
            this.gdcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvMain});
            // 
            // gdvMain
            // 
            this.gdvMain.GridControl = this.gdcMain;
            this.gdvMain.Name = "gdvMain";
            this.gdvMain.OptionsView.ColumnAutoWidth = false;
            this.gdvMain.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gdvMain.OptionsView.ShowGroupPanel = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 186);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(550, 20);
            this.txtAddress.StyleController = this.ltc;
            this.txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(550, 20);
            this.txtEmail.StyleController = this.ltc;
            this.txtEmail.TabIndex = 7;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(103, 138);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(550, 20);
            this.txtFullName.StyleController = this.ltc;
            this.txtFullName.TabIndex = 6;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(103, 114);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(550, 20);
            this.txtCustomerId.StyleController = this.ltc;
            this.txtCustomerId.TabIndex = 5;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(103, 45);
            this.txtKeyword.MaximumSize = new System.Drawing.Size(300, 20);
            this.txtKeyword.MinimumSize = new System.Drawing.Size(300, 20);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(300, 20);
            this.txtKeyword.StyleController = this.ltc;
            this.txtKeyword.TabIndex = 4;
            // 
            // ltg
            // 
            this.ltg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.ltg.GroupBordersVisible = false;
            this.ltg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ltgSearch,
            this.ltgMain,
            this.ltgSub});
            this.ltg.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.ltg.Name = "ltg";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.ltg.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 69D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition2.Height = 141D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition3.Height = 439D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.ltg.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.ltg.Size = new System.Drawing.Size(677, 669);
            this.ltg.TextVisible = false;
            // 
            // ltgSearch
            // 
            this.ltgSearch.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lti_txtKeyword,
            this.emptySpaceItem2});
            this.ltgSearch.Location = new System.Drawing.Point(0, 0);
            this.ltgSearch.Name = "ltgSearch";
            this.ltgSearch.Size = new System.Drawing.Size(657, 69);
            this.ltgSearch.Text = "Search";
            // 
            // lti_txtKeyword
            // 
            this.lti_txtKeyword.Control = this.txtKeyword;
            this.lti_txtKeyword.Location = new System.Drawing.Point(0, 0);
            this.lti_txtKeyword.Name = "lti_txtKeyword";
            this.lti_txtKeyword.Size = new System.Drawing.Size(383, 24);
            this.lti_txtKeyword.Text = "Keyword";
            this.lti_txtKeyword.TextSize = new System.Drawing.Size(76, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(383, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(250, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ltgMain
            // 
            this.ltgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lti_txtCustomerId,
            this.lti_txtFullName,
            this.lti_txtEmail,
            this.lti_txtAddress});
            this.ltgMain.Location = new System.Drawing.Point(0, 69);
            this.ltgMain.Name = "ltgMain";
            this.ltgMain.OptionsTableLayoutItem.RowIndex = 1;
            this.ltgMain.Size = new System.Drawing.Size(657, 141);
            this.ltgMain.Text = "Information";
            // 
            // lti_txtCustomerId
            // 
            this.lti_txtCustomerId.Control = this.txtCustomerId;
            this.lti_txtCustomerId.Location = new System.Drawing.Point(0, 0);
            this.lti_txtCustomerId.Name = "lti_txtCustomerId";
            this.lti_txtCustomerId.OptionsTableLayoutItem.RowIndex = 1;
            this.lti_txtCustomerId.Size = new System.Drawing.Size(633, 24);
            this.lti_txtCustomerId.Text = "CustomerID : ";
            this.lti_txtCustomerId.TextSize = new System.Drawing.Size(76, 14);
            // 
            // lti_txtFullName
            // 
            this.lti_txtFullName.Control = this.txtFullName;
            this.lti_txtFullName.Location = new System.Drawing.Point(0, 24);
            this.lti_txtFullName.Name = "lti_txtFullName";
            this.lti_txtFullName.Size = new System.Drawing.Size(633, 24);
            this.lti_txtFullName.Text = "Full Name : ";
            this.lti_txtFullName.TextSize = new System.Drawing.Size(76, 14);
            // 
            // lti_txtEmail
            // 
            this.lti_txtEmail.Control = this.txtEmail;
            this.lti_txtEmail.Location = new System.Drawing.Point(0, 48);
            this.lti_txtEmail.Name = "lti_txtEmail";
            this.lti_txtEmail.Size = new System.Drawing.Size(633, 24);
            this.lti_txtEmail.Text = "Email : ";
            this.lti_txtEmail.TextSize = new System.Drawing.Size(76, 14);
            // 
            // lti_txtAddress
            // 
            this.lti_txtAddress.Control = this.txtAddress;
            this.lti_txtAddress.Location = new System.Drawing.Point(0, 72);
            this.lti_txtAddress.Name = "lti_txtAddress";
            this.lti_txtAddress.Size = new System.Drawing.Size(633, 24);
            this.lti_txtAddress.Text = "Address : ";
            this.lti_txtAddress.TextSize = new System.Drawing.Size(76, 14);
            // 
            // ltgSub
            // 
            this.ltgSub.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.ltgSub.Location = new System.Drawing.Point(0, 210);
            this.ltgSub.Name = "ltgSub";
            this.ltgSub.OptionsTableLayoutItem.RowIndex = 2;
            this.ltgSub.Size = new System.Drawing.Size(657, 439);
            this.ltgSub.Text = "List";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gdcMain;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(633, 368);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnNew;
            this.layoutControlItem1.Location = new System.Drawing.Point(277, 368);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(89, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(455, 368);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(89, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(366, 368);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(89, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(544, 368);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(89, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 368);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(277, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 669);
            this.Controls.Add(this.ltc);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ltc)).EndInit();
            this.ltc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtKeyword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtCustomerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl ltc;
        private DevExpress.XtraLayout.LayoutControlGroup ltg;
        private DevExpress.XtraGrid.GridControl gdcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMain;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.TextEdit txtCustomerId;
        private DevExpress.XtraEditors.TextEdit txtKeyword;
        private DevExpress.XtraLayout.LayoutControlGroup ltgSearch;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtKeyword;
        private DevExpress.XtraLayout.LayoutControlGroup ltgMain;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtCustomerId;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtFullName;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtAddress;
        private DevExpress.XtraLayout.LayoutControlGroup ltgSub;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}