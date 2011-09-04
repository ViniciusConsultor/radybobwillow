using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.ChangeSoft.Common;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.ChangeSoft.ERP.Material
{
    public partial class FrmMaterialEdit : Com.ChangeSoft.Common.BaseContent
    {
        private BaseForm owner;
        public FrmMaterialEdit(BaseForm _owner, BaseForm _baseform):base(_baseform)
        {
            this.owner = _owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baseform.Pane.ActiveContent is IDockContent)
            {
                IDockContent content = (IDockContent)baseform.Pane.ActiveContent;
                content.DockHandler.Close();
                this.owner.Show();
                this.owner.BringToFront();
            }
        }

        private void conditionRadioButton1_RadioChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.conditionRadioButton1.Checkedvalue + ":" + this.conditionRadioButton1.Checkedname);
        }
    }
}
