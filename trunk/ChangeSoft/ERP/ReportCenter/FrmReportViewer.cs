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
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.ERP.Entity;
using Com.GainWinSoft.Common.Vo;
using Microsoft.Reporting.WinForms;
using System.Collections;
using Com.GainWinSoft.ERP.ReportCenter.Action;

namespace Com.GainWinSoft.ERP.ReportCenter
{
    public partial class FrmReportViewer : Com.GainWinSoft.Common.BaseContent
    {

        private string reportname = "";
        private string datasetName = "";
        private SearchCondition condition;

        public FrmReportViewer(DockPanel parentdockpanel)
            : base(parentdockpanel)
        {
            InitializeComponent();
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {
            IAction_Report action = (IAction_Report)ComponentLocator.Instance().Resolve(reportname, typeof(IAction_Report));
            ReportDataSource rs = action.ReportData_Load(this.datasetName, this.condition);

            this.reportViewer.LocalReport.DataSources.Add(rs);
            this.reportViewer.LocalReport.ReportEmbeddedResource = this.reportname;

            this.reportViewer.LocalReport.SetParameters(action.SetReportParameter(this.condition));

            this.reportViewer.RefreshReport();



        }



        public string Reportname
        {
            get { return reportname; }
            set { reportname = value; }
        }

        public string DatasetName
        {
            get { return datasetName; }
            set { datasetName = value; }
        }

        public Com.GainWinSoft.Common.SearchCondition Condition
        {
            get { return condition; }
            set { condition = value; }
        }
    }
}
