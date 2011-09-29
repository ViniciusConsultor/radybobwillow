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
    /// <summary>
    /// SMT REACH ROHS 中国ROHS,品目分类1,品目分类3 几个字段没有使用,用默认值插入,
    /// 品目分类2变成客户代码。
    /// 
    /// </summary>
    public partial class FrmMaterialEdit : Com.GainWinSoft.Common.BaseContent
    {
        public FrmMaterialEdit(DockPanel _parentdockpanel, BaseForm _owner):base(_parentdockpanel,_owner)
        {
            
            InitializeComponent();
        }

        private void FrmMaterialEdit_Load(object sender, EventArgs e)
        {
            Hashtable ht = (Hashtable)SessionUtils.GetSession(this.Name);
            ht.Add("ddd", "ddd");

            FormUtils.ClearStarControl(this.tlpTabpage1);

        }

        private void numericTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void xdtpBinEndDate_Load(object sender, EventArgs e)
        {

        }

    }
}
