using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;
using System.Collections;

namespace Com.GainWinSoft.ERP.Material
{
    public partial class FrmMaterialEdit : Com.GainWinSoft.Common.BaseContent
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

        private void FrmMaterialEdit_Load(object sender, EventArgs e)
        {
            Hashtable ht = (Hashtable)SessionUtils.GetSession(this.Name);
            ht.Add("ddd", "ddd");

        }

    }
}
