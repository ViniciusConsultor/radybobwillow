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
using log4net;
using System.Resources;
using Com.GainWinSoft.Common.Vo;

namespace Com.GainWinSoft.ERP.Material
{   
    /// <summary>
    /// SMT REACH ROHS 中国ROHS,品目分类1,品目分类3 几个字段没有使用,用默认值插入,
    /// 品目分类2变成客户代码。
    /// 
    /// </summary>
    public partial class FrmMaterialEdit : Com.GainWinSoft.Common.BaseContent
    {

        private ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmMaterialEdit));
        private static readonly ILog log = LogManager.GetLogger(typeof(FrmMaterialEdit));
        private LoginUserInfoVo uservo;

        //当前所在组
        private int currentGroup = 1;
        //画面打开时默认的组
        private int firstGroup = 1;

        private bool tabChangeEnabled = false;


        public FrmMaterialEdit(DockPanel _parentdockpanel, BaseForm _owner):base(_parentdockpanel,_owner)
        {
            
            InitializeComponent();
        }

        /// <summary>
        /// 画面打开
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMaterialEdit_Load(object sender, EventArgs e)
        {
            
            uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);
            SetCommonToolstrip();
            FormUtils.ClearStarControl(this.tlpTabpage1);

        }


        /// <summary>
        /// 防止Tab通过鼠标点击来切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlPM_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!tabChangeEnabled)
            {
                e.Cancel = true;
            }
            else
            {
                tabChangeEnabled = !tabChangeEnabled;
            }
        }

        private void commonToolStrip_OkClick(object sender, EventArgs e)
        {
            tabChangeEnabled = true;

            currentGroup++;
            if (currentGroup > 3)
            {
                currentGroup = 3;
            }
            tabControlPM.SelectedIndex = currentGroup - 1;
            SetCommonToolstrip();
        }

        private void commonToolStrip_GobackClick(object sender, EventArgs e)
        {
            tabChangeEnabled = true;
            currentGroup--;
            if (currentGroup < 1)
            {
                currentGroup = 1;
            }
            tabControlPM.SelectedIndex = currentGroup - 1;
            SetCommonToolstrip();
        }


        /// <summary>
        /// 根据组迁移不同，控制CommonToolStrip的状态
        /// </summary>
        private void SetCommonToolstrip()
        {
            if (currentGroup == 1)
            {
                this.commonToolStrip.GobackEnabled = false;
                this.commonToolStrip.OkEnabled = true;

            }
            if (currentGroup == 2)
            {
                this.commonToolStrip.GobackEnabled = true;
                this.commonToolStrip.OkEnabled = true;

            }
            if (currentGroup == 3)
            {
                this.commonToolStrip.GobackEnabled = true;
                this.commonToolStrip.OkEnabled = false;

            }
        }
        /// <summary>
        /// 客户辅助按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomerHelper_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefTradeForMaterial cr = new CodeRef.CodeRefTradeForMaterial(uservo.CompanyCondition.ICompanyCd);
            cr.AddValueControl(this.atxtCustomerCd);
            cr.AddNameControl(this.lblCustomerNm);
            cr.ShowDialog(this);
            this.atxtCustomerCd.Focus();
        }

        private void btnSalesPersonHelper_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefPerson cr = new CodeRef.CodeRefPerson(uservo.CompanyCondition.ICompanyCd);
            cr.AddValueControl(this.atxtSalesPersonCd);
            cr.AddNameControl(this.lblSalesPersonNm);
            cr.ShowDialog(this);
            this.atxtSalesPersonCd.Focus();

        }
    }
}
