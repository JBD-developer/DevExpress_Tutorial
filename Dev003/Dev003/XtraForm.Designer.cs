
namespace Dev003
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Dev003.MainSplashScreen), true, true);
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.ltc = new DevExpress.XtraLayout.LayoutControl();
            this.txtJob = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtAge = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ltg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ltgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lti_txtId = new DevExpress.XtraLayout.LayoutControlItem();
            this.lti_txtAge = new DevExpress.XtraLayout.LayoutControlItem();
            this.lti_txtName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lti_txtAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ltgSub = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lti_txtJob = new DevExpress.XtraLayout.LayoutControlItem();
            this.lti_txtPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.lti_btnSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.esi01 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ltc)).BeginInit();
            this.ltc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esi01)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 100;
            // 
            // ltc
            // 
            this.ltc.Controls.Add(this.txtJob);
            this.ltc.Controls.Add(this.txtPhone);
            this.ltc.Controls.Add(this.txtAddress);
            this.ltc.Controls.Add(this.txtAge);
            this.ltc.Controls.Add(this.txtName);
            this.ltc.Controls.Add(this.txtId);
            this.ltc.Controls.Add(this.btnSave);
            this.ltc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltc.Location = new System.Drawing.Point(0, 0);
            this.ltc.Name = "ltc";
            this.ltc.Root = this.ltg;
            this.ltc.Size = new System.Drawing.Size(798, 257);
            this.ltc.TabIndex = 0;
            this.ltc.Text = "layoutControl1";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(467, 149);
            this.txtJob.Name = "txtJob";
            this.txtJob.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtJob.Properties.Appearance.Options.UseFont = true;
            this.txtJob.Size = new System.Drawing.Size(326, 28);
            this.txtJob.StyleController = this.ltc;
            this.txtJob.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(68, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(332, 28);
            this.txtPhone.StyleController = this.ltc;
            this.txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(68, 90);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(725, 28);
            this.txtAddress.StyleController = this.ltc;
            this.txtAddress.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(68, 58);
            this.txtAge.Name = "txtAge";
            this.txtAge.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtAge.Properties.Appearance.Options.UseFont = true;
            this.txtAge.Size = new System.Drawing.Size(329, 28);
            this.txtAge.StyleController = this.ltc;
            this.txtAge.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(464, 26);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(329, 28);
            this.txtName.StyleController = this.ltc;
            this.txtName.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(68, 26);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(329, 28);
            this.txtId.StyleController = this.ltc;
            this.txtId.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(5, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(788, 26);
            this.btnSave.StyleController = this.ltc;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            // 
            // ltg
            // 
            this.ltg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.ltg.GroupBordersVisible = false;
            this.ltg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ltgMain,
            this.ltgSub});
            this.ltg.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.ltg.Name = "ltg";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition1.Width = 798D;
            this.ltg.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 123D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition2.Height = 89D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition3.Height = 45D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.ltg.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.ltg.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ltg.Size = new System.Drawing.Size(798, 257);
            this.ltg.TextVisible = false;
            // 
            // ltgMain
            // 
            this.ltgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lti_txtId,
            this.lti_txtAge,
            this.lti_txtName,
            this.esi01,
            this.lti_txtAddress});
            this.ltgMain.Location = new System.Drawing.Point(0, 0);
            this.ltgMain.Name = "ltgMain";
            this.ltgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ltgMain.Size = new System.Drawing.Size(798, 123);
            this.ltgMain.Text = "Main Information";
            // 
            // lti_txtId
            // 
            this.lti_txtId.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtId.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtId.Control = this.txtId;
            this.lti_txtId.Location = new System.Drawing.Point(0, 0);
            this.lti_txtId.Name = "lti_txtId";
            this.lti_txtId.Size = new System.Drawing.Size(396, 32);
            this.lti_txtId.Text = "ID";
            this.lti_txtId.TextSize = new System.Drawing.Size(60, 21);
            // 
            // lti_txtAge
            // 
            this.lti_txtAge.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtAge.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtAge.Control = this.txtAge;
            this.lti_txtAge.Location = new System.Drawing.Point(0, 32);
            this.lti_txtAge.Name = "lti_txtAge";
            this.lti_txtAge.Size = new System.Drawing.Size(396, 32);
            this.lti_txtAge.Text = "Age";
            this.lti_txtAge.TextSize = new System.Drawing.Size(60, 21);
            // 
            // lti_txtName
            // 
            this.lti_txtName.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtName.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtName.Control = this.txtName;
            this.lti_txtName.Location = new System.Drawing.Point(396, 0);
            this.lti_txtName.Name = "lti_txtName";
            this.lti_txtName.OptionsTableLayoutItem.RowIndex = 1;
            this.lti_txtName.Size = new System.Drawing.Size(396, 32);
            this.lti_txtName.Text = "Name";
            this.lti_txtName.TextSize = new System.Drawing.Size(60, 21);
            // 
            // lti_txtAddress
            // 
            this.lti_txtAddress.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtAddress.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtAddress.Control = this.txtAddress;
            this.lti_txtAddress.Location = new System.Drawing.Point(0, 64);
            this.lti_txtAddress.Name = "lti_txtAddress";
            this.lti_txtAddress.Size = new System.Drawing.Size(792, 32);
            this.lti_txtAddress.Text = "Address";
            this.lti_txtAddress.TextSize = new System.Drawing.Size(60, 21);
            // 
            // ltgSub
            // 
            this.ltgSub.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lti_txtJob,
            this.lti_txtPhone,
            this.lti_btnSave});
            this.ltgSub.Location = new System.Drawing.Point(0, 123);
            this.ltgSub.Name = "ltgSub";
            this.ltgSub.OptionsTableLayoutItem.RowIndex = 1;
            this.ltgSub.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ltgSub.Size = new System.Drawing.Size(798, 89);
            this.ltgSub.Text = "Sub Information";
            // 
            // lti_txtJob
            // 
            this.lti_txtJob.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtJob.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtJob.Control = this.txtJob;
            this.lti_txtJob.Location = new System.Drawing.Point(399, 0);
            this.lti_txtJob.Name = "lti_txtJob";
            this.lti_txtJob.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtJob.OptionsPrint.AppearanceItem.Options.UseFont = true;
            this.lti_txtJob.Size = new System.Drawing.Size(393, 32);
            this.lti_txtJob.Text = "Job";
            this.lti_txtJob.TextSize = new System.Drawing.Size(60, 21);
            // 
            // lti_txtPhone
            // 
            this.lti_txtPhone.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtPhone.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtPhone.Control = this.txtPhone;
            this.lti_txtPhone.Location = new System.Drawing.Point(0, 0);
            this.lti_txtPhone.Name = "lti_txtPhone";
            this.lti_txtPhone.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtPhone.OptionsPrint.AppearanceItem.Options.UseFont = true;
            this.lti_txtPhone.Size = new System.Drawing.Size(399, 32);
            this.lti_txtPhone.Text = "Phone";
            this.lti_txtPhone.TextSize = new System.Drawing.Size(60, 21);
            // 
            // lti_btnSave
            // 
            this.lti_btnSave.Control = this.btnSave;
            this.lti_btnSave.Location = new System.Drawing.Point(0, 32);
            this.lti_btnSave.Name = "lti_btnSave";
            this.lti_btnSave.OptionsTableLayoutItem.RowIndex = 2;
            this.lti_btnSave.Size = new System.Drawing.Size(792, 30);
            this.lti_btnSave.TextSize = new System.Drawing.Size(0, 0);
            this.lti_btnSave.TextVisible = false;
            // 
            // esi01
            // 
            this.esi01.AllowHotTrack = false;
            this.esi01.Location = new System.Drawing.Point(396, 32);
            this.esi01.Name = "esi01";
            this.esi01.Size = new System.Drawing.Size(396, 32);
            this.esi01.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 257);
            this.Controls.Add(this.ltc);
            this.Name = "Main";
            this.Text = "XtraForm";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ltc)).EndInit();
            this.ltc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtJob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esi01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl ltc;
        private DevExpress.XtraLayout.LayoutControlGroup ltg;
        private DevExpress.XtraEditors.TextEdit txtJob;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtAge;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlGroup ltgMain;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtId;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtAge;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtName;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtAddress;
        private DevExpress.XtraLayout.LayoutControlGroup ltgSub;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtJob;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtPhone;
        private DevExpress.XtraLayout.LayoutControlItem lti_btnSave;
        private DevExpress.XtraLayout.EmptySpaceItem esi01;
    }
}