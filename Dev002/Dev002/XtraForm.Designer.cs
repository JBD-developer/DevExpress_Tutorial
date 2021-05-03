
namespace Dev002
{
    partial class XtraForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.ltc = new DevExpress.XtraLayout.LayoutControl();
            this.ltg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.lti_txtCustomerID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ltgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.lti_txtCustomerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCustomerEmail = new DevExpress.XtraEditors.TextEdit();
            this.lti_txtCustomerEMail = new DevExpress.XtraLayout.LayoutControlItem();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lti_memRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.esi01 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ltc)).BeginInit();
            this.ltc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ltg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtCustomerEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_memRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esi01)).BeginInit();
            this.SuspendLayout();
            // 
            // ltc
            // 
            this.ltc.Controls.Add(this.btnSave);
            this.ltc.Controls.Add(this.memRemark);
            this.ltc.Controls.Add(this.txtCustomerEmail);
            this.ltc.Controls.Add(this.txtCustomerName);
            this.ltc.Controls.Add(this.txtCustomerID);
            this.ltc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltc.Location = new System.Drawing.Point(0, 0);
            this.ltc.Name = "ltc";
            this.ltc.Root = this.ltg;
            this.ltc.Size = new System.Drawing.Size(784, 561);
            this.ltc.TabIndex = 0;
            this.ltc.Text = "layoutControl1";
            // 
            // ltg
            // 
            this.ltg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.ltg.GroupBordersVisible = false;
            this.ltg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ltgMain});
            this.ltg.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.ltg.Name = "ltg";
            this.ltg.OptionsItemText.TextToControlDistance = 5;
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.ltg.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 561D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.ltg.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.ltg.Size = new System.Drawing.Size(784, 561);
            this.ltg.TextVisible = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(150, 34);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtCustomerID.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerID.Size = new System.Drawing.Size(625, 30);
            this.txtCustomerID.StyleController = this.ltc;
            this.txtCustomerID.TabIndex = 4;
            // 
            // lti_txtCustomerID
            // 
            this.lti_txtCustomerID.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtCustomerID.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtCustomerID.Control = this.txtCustomerID;
            this.lti_txtCustomerID.Location = new System.Drawing.Point(0, 0);
            this.lti_txtCustomerID.Name = "lti_txtCustomerID";
            this.lti_txtCustomerID.Size = new System.Drawing.Size(776, 40);
            this.lti_txtCustomerID.Text = "Customer ID : ";
            this.lti_txtCustomerID.TextSize = new System.Drawing.Size(136, 21);
            // 
            // ltgMain
            // 
            this.ltgMain.AppearanceGroup.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.ltgMain.AppearanceGroup.Options.UseFont = true;
            this.ltgMain.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.ltgMain.AppearanceItemCaption.Options.UseFont = true;
            this.ltgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lti_txtCustomerID,
            this.lti_txtCustomerName,
            this.lti_memRemark,
            this.lti_txtCustomerEMail,
            this.layoutControlItem2,
            this.esi01});
            this.ltgMain.Location = new System.Drawing.Point(0, 0);
            this.ltgMain.Name = "ltgMain";
            this.ltgMain.OptionsItemText.TextToControlDistance = 5;
            this.ltgMain.Size = new System.Drawing.Size(784, 561);
            this.ltgMain.Text = "Information";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(150, 74);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtCustomerName.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerName.Size = new System.Drawing.Size(625, 30);
            this.txtCustomerName.StyleController = this.ltc;
            this.txtCustomerName.TabIndex = 5;
            // 
            // lti_txtCustomerName
            // 
            this.lti_txtCustomerName.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtCustomerName.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtCustomerName.Control = this.txtCustomerName;
            this.lti_txtCustomerName.Location = new System.Drawing.Point(0, 40);
            this.lti_txtCustomerName.Name = "lti_txtCustomerName";
            this.lti_txtCustomerName.Size = new System.Drawing.Size(776, 40);
            this.lti_txtCustomerName.Text = "Customer Name : ";
            this.lti_txtCustomerName.TextSize = new System.Drawing.Size(136, 21);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(150, 114);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtCustomerEmail.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(625, 30);
            this.txtCustomerEmail.StyleController = this.ltc;
            this.txtCustomerEmail.TabIndex = 6;
            // 
            // lti_txtCustomerEMail
            // 
            this.lti_txtCustomerEMail.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_txtCustomerEMail.AppearanceItemCaption.Options.UseFont = true;
            this.lti_txtCustomerEMail.Control = this.txtCustomerEmail;
            this.lti_txtCustomerEMail.Location = new System.Drawing.Point(0, 80);
            this.lti_txtCustomerEMail.Name = "lti_txtCustomerEMail";
            this.lti_txtCustomerEMail.Size = new System.Drawing.Size(776, 40);
            this.lti_txtCustomerEMail.Text = "Customer EMail : ";
            this.lti_txtCustomerEMail.TextSize = new System.Drawing.Size(136, 21);
            // 
            // memRemark
            // 
            this.memRemark.Location = new System.Drawing.Point(150, 154);
            this.memRemark.Name = "memRemark";
            this.memRemark.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.memRemark.Properties.Appearance.Options.UseFont = true;
            this.memRemark.Size = new System.Drawing.Size(625, 360);
            this.memRemark.StyleController = this.ltc;
            this.memRemark.TabIndex = 7;
            // 
            // lti_memRemark
            // 
            this.lti_memRemark.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lti_memRemark.AppearanceItemCaption.Options.UseFont = true;
            this.lti_memRemark.Control = this.memRemark;
            this.lti_memRemark.Location = new System.Drawing.Point(0, 120);
            this.lti_memRemark.Name = "lti_memRemark";
            this.lti_memRemark.Size = new System.Drawing.Size(776, 370);
            this.lti_memRemark.Text = "Memo";
            this.lti_memRemark.TextSize = new System.Drawing.Size(136, 21);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(660, 524);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 28);
            this.btnSave.StyleController = this.ltc;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(651, 490);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(125, 38);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // esi01
            // 
            this.esi01.AllowHotTrack = false;
            this.esi01.Location = new System.Drawing.Point(0, 490);
            this.esi01.Name = "esi01";
            this.esi01.Size = new System.Drawing.Size(651, 38);
            this.esi01.TextSize = new System.Drawing.Size(0, 0);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            // 
            // XtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ltc);
            this.Name = "XtraForm";
            this.Text = "XtraForm";
            this.Load += new System.EventHandler(this.XtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ltc)).EndInit();
            this.ltc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ltg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_txtCustomerEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lti_memRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esi01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl ltc;
        private DevExpress.XtraLayout.LayoutControlGroup ltg;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtCustomerID;
        private DevExpress.XtraLayout.LayoutControlGroup ltgMain;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtCustomerName;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtCustomerID;
        private DevExpress.XtraEditors.TextEdit txtCustomerEmail;
        private DevExpress.XtraLayout.LayoutControlItem lti_txtCustomerEMail;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit memRemark;
        private DevExpress.XtraLayout.LayoutControlItem lti_memRemark;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem esi01;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}