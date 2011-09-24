using System;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.ReportCenter.Action
{
    interface IAction_Report
    {
        Microsoft.Reporting.WinForms.ReportDataSource ReportData_Load(string datasetName, Com.GainWinSoft.Common.SearchCondition condition);
        IList<Microsoft.Reporting.WinForms.ReportParameter> SetReportParameter(Com.GainWinSoft.Common.SearchCondition condition);
    }
}
