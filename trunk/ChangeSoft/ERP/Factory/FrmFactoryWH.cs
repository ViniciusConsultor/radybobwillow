using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.Common;

namespace Com.GainWinSoft.ERP.Factory
{
    public partial class FrmFactoryWH : BaseContent
    {
        public FrmFactoryWH(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }

        #region 私有函数

        #region 工具栏控制相关
        /// <summary>
        /// 工具栏按钮显示控制
        /// <param name="strMode">画面模式</param>
        /// </summary>
        private void SetToolBar(string strMode)
        {
            InitToolBar();
            this.commonToolStrip1.Update();
        }

        /// <summary>
        /// 工具栏按钮初期化
        /// </summary>
        private void InitToolBar()
        {
            #region 初期化
            this.commonToolStrip1.AddEnabled = false;
            this.commonToolStrip1.AddVisible = false;
            this.commonToolStrip1.DeleteEnabled = false;
            this.commonToolStrip1.DeleteVisible = false;
            this.commonToolStrip1.UpdateEnabled = false;
            this.commonToolStrip1.UpdateVisible = false;
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
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
            this.commonToolStrip1.ExitEnabled = false;
            this.commonToolStrip1.ExitVisible = false;
            this.commonToolStrip1.Line4Visible = false;

            this.commonToolStrip1.HelpEnabled = false;
            this.commonToolStrip1.HelpVisible = false;
            #endregion
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

        #region 画面控件显示相关
        /// <summary>
        /// 根据模式，控制画面上的显示项目
        /// <param name="strMode">画面模式</param>
        /// </summary>
        private void SetLayout(string strMode)
        {
            this.ClearG1();
            this.ClearG2();
        }

        /// <summary>
        /// 清空G1部分画面项目的显示内容
        /// </summary>
        private void ClearG1()
        {
            #region G1项目
            this.txtFactory.Text = "";
            this.lblFactoryNM.Text = "";
            #endregion
        }

        /// <summary>
        /// 清空G2部分画面项目的显示内容
        /// </summary>
        private void ClearG2()
        {
            #region G2项目
            this.txtAccStockIn.Text = "";
            this.lblAccStockInNM.Text = "";
            this.txtAccStockOut.Text = "";
            this.lblAccStockOutNM.Text = "";
            this.txtDefectStock.Text = "";
            this.lblDefectStockNM.Text = "";
            this.txtServiceStock.Text = "";
            this.lblServiceStockNM.Text = "";
            this.txtSurplusStock.Text = "";
            this.lblSurplusStockNM.Text = "";
            this.txtInspectStock.Text = "";
            this.lblInspectStockNM.Text = "";
            #endregion
        }

        /// <summary>
        /// G1->G2，控制画面上的显示项目
        /// </summary>
        private void SetLayoutG1G2()
        {
            this.tpG1.Enabled = false;
            this.tpG2.Enabled = true;
            //this.tpG2.Visible = true;
        }

        /// <summary>
        /// G2->G1，控制画面上的显示项目
        /// </summary>
        private void SetLayoutG2G1()
        {
            this.ClearG2();
            this.tpG1.Enabled = true;
            this.tpG2.Enabled = false;
            //this.tpG2.Visible = false;
        }
        #endregion

        #endregion
    }
}
