using Dev001.UI.Modules;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev001
{
    public partial class fdmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public fdmMain()
        {
            InitializeComponent();
        }

        async Task LoadModelAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer1.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;

                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer1.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer1.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            control[0].BringToFront();
                        }));  
                }
            });
        }

        private void fdmMain_Load(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Add(new ucNewInvoice() {Dock = DockStyle.Fill});
            this.itemNav.Caption = $"{accordionControlElementInvoice.Text}";
        }

        private async void accordionControlElementInvoice_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementInvoice.Text}";
            if (ModulesInfo.GetItem("ucNewInvoice") == null)
                ModulesInfo.Add(new ModuleInfo("ucNewInvoice", "Dev001.UI.Modules.ucNewInvoice"));
            await LoadModelAsync(ModulesInfo.GetItem("ucNewInvoice"));
        }

        private async void accordionControlElementCustomers_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlCategories.Text}/{accordionControlElementCustomers.Text}";
            if (ModulesInfo.GetItem("ucCustomer") == null)
                ModulesInfo.Add(new ModuleInfo("ucCustomer", "Dev001.UI.Modules.ucCustomer"));
            await LoadModelAsync(ModulesInfo.GetItem("ucCustomer"));
        }

        private async void accordionControlElementProducts_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlCategories.Text}/{accordionControlElementProducts.Text}";
            if (ModulesInfo.GetItem("ucProduct") == null)
                ModulesInfo.Add(new ModuleInfo("ucProduct", "Dev001.UI.Modules.ucCustomer"));
            await LoadModelAsync(ModulesInfo.GetItem("ucProduct"));

        }

        private async void accordionControlElementCategories_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlCategories.Text}/{accordionControlElementCategories.Text}";
            if (ModulesInfo.GetItem("ucCategory") == null)
                ModulesInfo.Add(new ModuleInfo("ucCategory", "Dev001.UI.Modules.ucCategory"));
            await LoadModelAsync(ModulesInfo.GetItem("ucCategory"));
        }
    }
}
