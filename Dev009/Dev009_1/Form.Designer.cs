
namespace Dev009_1
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator2 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.ltc = new DevExpress.XtraLayout.LayoutControl();
            this.ltg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtQRCode = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bccQRCode = new DevExpress.XtraEditors.BarCodeControl();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ltc)).BeginInit();
            this.ltc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ltg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQRCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // ltc
            // 
            this.ltc.Controls.Add(this.btnClear);
            this.ltc.Controls.Add(this.panel1);
            this.ltc.Controls.Add(this.btnSave);
            this.ltc.Controls.Add(this.btnCreate);
            this.ltc.Controls.Add(this.txtQRCode);
            this.ltc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltc.Location = new System.Drawing.Point(0, 0);
            this.ltc.Name = "ltc";
            this.ltc.Root = this.ltg;
            this.ltc.Size = new System.Drawing.Size(467, 447);
            this.ltc.TabIndex = 0;
            this.ltc.Text = "layoutControl1";
            // 
            // ltg
            // 
            this.ltg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.ltg.GroupBordersVisible = false;
            this.ltg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.ltg.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.ltg.Name = "ltg";
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            this.ltg.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition2});
            rowDefinition3.Height = 91D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition4.Height = 354D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.ltg.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition3,
            rowDefinition4});
            this.ltg.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.ltg.Size = new System.Drawing.Size(467, 447);
            this.ltg.TextVisible = false;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(110, 28);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtQRCode.Properties.Appearance.Options.UseFont = true;
            this.txtQRCode.Size = new System.Drawing.Size(350, 28);
            this.txtQRCode.StyleController = this.ltc;
            this.txtQRCode.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.txtQRCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(457, 32);
            this.layoutControlItem1.Text = "QRCode ";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(98, 20);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlGroup1.Size = new System.Drawing.Size(465, 91);
            this.layoutControlGroup1.Text = "QRcode Information";
            // 
            // btnCreate
            // 
            this.btnCreate.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Appearance.Options.UseFont = true;
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.Location = new System.Drawing.Point(230, 60);
            this.btnCreate.MaximumSize = new System.Drawing.Size(113, 25);
            this.btnCreate.MinimumSize = new System.Drawing.Size(113, 25);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(113, 25);
            this.btnCreate.StyleController = this.ltc;
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.Button_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCreate;
            this.layoutControlItem2.Location = new System.Drawing.Point(223, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(117, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(347, 60);
            this.btnSave.MaximumSize = new System.Drawing.Size(113, 25);
            this.btnSave.MinimumSize = new System.Drawing.Size(113, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 25);
            this.btnSave.StyleController = this.ltc;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.Button_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(340, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(117, 30);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 91);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlGroup2.Size = new System.Drawing.Size(465, 354);
            this.layoutControlGroup2.Text = "QRcode Preview";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bccQRCode);
            this.panel1.Location = new System.Drawing.Point(7, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 321);
            this.panel1.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.panel1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(457, 325);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // bccQRCode
            // 
            this.bccQRCode.AutoModule = true;
            this.bccQRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bccQRCode.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bccQRCode.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bccQRCode.Location = new System.Drawing.Point(0, 0);
            this.bccQRCode.Name = "bccQRCode";
            this.bccQRCode.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.bccQRCode.Size = new System.Drawing.Size(453, 321);
            qrCodeGenerator2.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.bccQRCode.Symbology = qrCodeGenerator2;
            this.bccQRCode.TabIndex = 0;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 32);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(106, 30);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(113, 60);
            this.btnClear.MaximumSize = new System.Drawing.Size(113, 25);
            this.btnClear.MinimumSize = new System.Drawing.Size(113, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 25);
            this.btnClear.StyleController = this.ltc;
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnClear;
            this.layoutControlItem5.Location = new System.Drawing.Point(106, 32);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(117, 30);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 447);
            this.Controls.Add(this.ltc);
            this.Name = "Form";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ltc)).EndInit();
            this.ltc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ltg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQRCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl ltc;
        private DevExpress.XtraLayout.LayoutControlGroup ltg;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.TextEdit txtQRCode;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.BarCodeControl bccQRCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}