using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.Common.Vo;
using Com.GainWinSoft.ERP.Entity;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Drawing;
using System.Resources;
using System.Reflection;

namespace Com.GainWinSoft.ERP.ReportCenter.Action
{
    public class Action_RdlcPmMs : Com.GainWinSoft.ERP.ReportCenter.Action.IAction_Report
    {
        public ReportDataSource ReportData_Load(string datasetName, SearchCondition condition)
        {
            ICTPmMsNoARDao d = ComponentLocator.Instance().Resolve<ICTPmMsNoARDao>();
            LoginUserInfoVo uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);

            SearchCondition condition1 = new SearchCondition();
            condition1.AddCondition("companyCd", uservo.CompanyCondition.ICompanyCd);
            condition1.AddCondition("langCd", LangUtils.GetCurrentLanguage());

            condition1.SetAddtionalCondition("ALLFACTORY", false);

            IList<CTPmMsNoAR> list = d.GetPmMsDetail(condition1);
            DataSet ds = new DataSet();
            DataTable dt = DataTableUtils.ToDataTable(list);
            DataColumn col = new DataColumn();
            col.DataType = typeof(byte[]);
            col.ColumnName = "BarCode";
            dt.Columns.Add(col);

            dt.TableName = "TPmMs";
            ds.Tables.Add(dt);



            foreach (DataRow row in dt.Rows)
            {


                int W = Convert.ToInt32(200);
                int H = Convert.ToInt32(40);
                BarcodeLib.AlignmentPositions Align = BarcodeLib.AlignmentPositions.CENTER;
                BarcodeLib.TYPE type = BarcodeLib.TYPE.CODE39;
                BarcodeLib.Barcode b = new BarcodeLib.Barcode();
                b.IncludeLabel = true;
                b.Alignment = Align;
                b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;
                b.LabelFont = new Font("宋体", 6);
                b.Encode(type, row["IDrwNo"].ToString(), Color.Black, Color.White, W, H);
                row["BarCode"] = b.GetImageData(BarcodeLib.SaveTypes.PNG);

            }

            ReportDataSource result = new ReportDataSource(datasetName, ds.Tables["TPmMs"]);
            return result;

        }

        public IList<ReportParameter> SetReportParameter(SearchCondition condition)
        {
            IList<ReportParameter> plist = new List<ReportParameter>();
            ResourceManager rm = new System.Resources.ResourceManager("Com.GainWinSoft.ERP.ReportCenter.Rdlc.RdlcPmMs", Assembly.GetAssembly(typeof(FrmReportViewer)));
            ReportParameter rp = new ReportParameter("lblRowNo", rm.GetString("lblRowNo"));
            plist.Add(rp);
            rp = new ReportParameter("lblIFacCd", rm.GetString("lblIFacCd"));
            plist.Add(rp);
            rp = new ReportParameter("lblIItemCd", rm.GetString("lblIItemCd"));
            plist.Add(rp);
            rp = new ReportParameter("lblIItemDesc", rm.GetString("lblIItemDesc"));
            plist.Add(rp);
            rp = new ReportParameter("lblBarCode", rm.GetString("lblBarCode"));
            plist.Add(rp);

            rp = new ReportParameter("lblReportName", rm.GetString("ReportName"));
            plist.Add(rp);

            return plist;
        }
    }
}
