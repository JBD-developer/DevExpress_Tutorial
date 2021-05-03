
namespace Dev001
{
    partial class fdmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fdmMain));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementInvoice = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCategories = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCustomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCategories = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.itemNav = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(642, 562);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementInvoice,
            this.accordionControlCategories});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 562);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementInvoice
            // 
            this.accordionControlElementInvoice.Expanded = true;
            this.accordionControlElementInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementInvoice.ImageOptions.Image")));
            this.accordionControlElementInvoice.Name = "accordionControlElementInvoice";
            this.accordionControlElementInvoice.Text = "New Invoice";
            this.accordionControlElementInvoice.Click += new System.EventHandler(this.accordionControlElementInvoice_Click);
            // 
            // accordionControlCategories
            // 
            this.accordionControlCategories.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCustomers,
            this.accordionControlElementProducts,
            this.accordionControlElementCategories});
            this.accordionControlCategories.Expanded = true;
            this.accordionControlCategories.Name = "accordionControlCategories";
            this.accordionControlCategories.Text = "Categories";
            // 
            // accordionControlElementCustomers
            // 
            this.accordionControlElementCustomers.Name = "accordionControlElementCustomers";
            this.accordionControlElementCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCustomers.Text = "Customer";
            this.accordionControlElementCustomers.Click += new System.EventHandler(this.accordionControlElementCustomers_Click);
            // 
            // accordionControlElementProducts
            // 
            this.accordionControlElementProducts.Name = "accordionControlElementProducts";
            this.accordionControlElementProducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementProducts.Text = "Products";
            this.accordionControlElementProducts.Click += new System.EventHandler(this.accordionControlElementProducts_Click);
            // 
            // accordionControlElementCategories
            // 
            this.accordionControlElementCategories.Name = "accordionControlElementCategories";
            this.accordionControlElementCategories.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCategories.Text = "Categories";
            this.accordionControlElementCategories.Click += new System.EventHandler(this.accordionControlElementCategories_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(902, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.itemNav);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // itemNav
            // 
            this.itemNav.Caption = "???";
            this.itemNav.Id = 0;
            this.itemNav.Name = "itemNav";
            // 
            // fdmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 593);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "fdmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Fluent Design Form";
            this.Load += new System.EventHandler(this.fdmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementInvoice;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCategories;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCustomers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProducts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCategories;
        private DevExpress.XtraBars.BarStaticItem itemNav;
    }
}