using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dev010
{
    public partial class WaitForm1 : WaitForm
    {
        public WaitForm1()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        public override void SetCaption(string p_sCaption)
        {
            base.SetCaption(p_sCaption);
            this.progressPanel1.Caption = p_sCaption;
        }

        public override void SetDescription(string p_sDescription)
        {
            base.SetDescription(p_sDescription);
            this.progressPanel1.Description = p_sDescription;
        }

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }
    }
}