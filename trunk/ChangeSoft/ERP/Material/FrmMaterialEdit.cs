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
        public FrmMaterialEdit(DockPanel _parentdockpanel, BaseForm _owner):base(_parentdockpanel,_owner)
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CloseContent();
        }

        private void conditionRadioButton1_RadioChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.conditionRadioButton1.Checkedvalue + ":" + this.conditionRadioButton1.Checkedname);
        }
    }
}
