using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.GainWinSoft.ERP.Factory
{
    public partial class FrmFactory : BaseContent
    {
        /// <summary>
        /// 画面操作模式
        /// </summary>
        private string strMode = "";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        public FrmFactory(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
            Initialize();
        }

        #region 方法
        /// <summary>
        /// 初期化处理
        /// </summary>
        private void Initialize()
        {
            if (string.IsNullOrEmpty(strMode))
            {
                strMode = Constant.MODE_ADD;
            }

            SetToolBar(strMode);
        }
        #endregion

        #region 私有函数

        #region 工具栏控制相关
        /// <summary>
        /// 工具栏按钮显示控制
        /// <param name="strMode">画面模式</param>
        /// </summary>
        private void SetToolBar(string strMode)
        {
            InitToolBar();

            switch (strMode)
            {
                case Constant.MODE_ADD:
                    SetToolBarAdd();
                    break;
                case Constant.MODE_DEL:
                    SetToolBarDel();
                    break;
                case Constant.MODE_UPD:
                    SetToolBarUpd();
                    break;
            }
        }

        /// <summary>
        /// 工具栏按钮初期化
        /// </summary>
        private void InitToolBar()
        {
            #region 初期化
            this.commonToolStrip1.AddEnabled = true;
            this.commonToolStrip1.AddVisible = true;
            this.commonToolStrip1.DeleteEnabled = true;
            this.commonToolStrip1.DeleteVisible = true;
            this.commonToolStrip1.UpdateEnabled = true;
            this.commonToolStrip1.UpdateVisible = true;
            this.commonToolStrip1.SaveEnabled = false;
            this.commonToolStrip1.SaveVisible = false;
            this.commonToolStrip1.Line1Visible = false;

            this.commonToolStrip1.CopyEnabled = false;
            this.commonToolStrip1.CopyVisible = false;
            this.commonToolStrip1.Line2Visible = false;

            this.commonToolStrip1.ReportEnabled = false;
            this.commonToolStrip1.ReportVisible = false;
            this.commonToolStrip1.CsvEnabled = false;
            this.commonToolStrip1.CsvVisible = false;
            this.commonToolStrip1.Line3Visible = false;

            this.commonToolStrip1.GobackEnabled = false;
            this.commonToolStrip1.GobackVisible = false;
            this.commonToolStrip1.OkEnabled = false;
            this.commonToolStrip1.OkVisible = false;
            this.commonToolStrip1.ExitEnabled = false;
            this.commonToolStrip1.ExitVisible = false;
            this.commonToolStrip1.Line4Visible = false;

            this.commonToolStrip1.HelpEnabled = false;
            this.commonToolStrip1.HelpVisible = false;
            #endregion
        }

        /// <summary>
        /// 追加模式工具栏按钮控制
        /// </summary>
        private void SetToolBarAdd()
        {
            this.commonToolStrip1.SaveEnabled = true;
            this.commonToolStrip1.SaveVisible = true;
            this.commonToolStrip1.Line1Visible = false;
        }

        /// <summary>
        /// 删除模式工具栏按钮控制
        /// </summary>
        private void SetToolBarDel()
        {
            this.commonToolStrip1.Line1Visible = true;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }

        /// <summary>
        /// 修正模式工具栏按钮控制
        /// </summary>
        private void SetToolBarUpd()
        {
            this.commonToolStrip1.Line1Visible = true;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }

        /// <summary>
        /// G1->G2工具栏按钮控制
        /// </summary>
        private void SetToolBarG1G2()
        {
            this.commonToolStrip1.SaveEnabled = true;
            this.commonToolStrip1.SaveVisible = true;
            this.commonToolStrip1.GobackEnabled = true;
            this.commonToolStrip1.GobackVisible = true;
            this.commonToolStrip1.OkEnabled = false;
            this.commonToolStrip1.OkVisible = false;
        }

        /// <summary>
        /// G2->G1工具栏按钮控制
        /// </summary>
        private void SetToolBarG2G1()
        {
            this.commonToolStrip1.SaveEnabled = false;
            this.commonToolStrip1.SaveVisible = false;
            this.commonToolStrip1.GobackEnabled = false;
            this.commonToolStrip1.GobackVisible = false;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }
        #endregion

        #endregion
    }
}
