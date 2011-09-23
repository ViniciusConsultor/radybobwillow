using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using log4net;
using Com.GainWinSoft.ERP.Company.Action;
using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;
using Noogen.Validation;
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.ERP.Entity;

namespace Com.GainWinSoft.ERP.Company
{
    public partial class FrmCompany : BaseContent
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(FrmCompany));

        

        public FrmCompany(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {

            log.Info("FrmCompany init start");
            InitializeComponent();

            ValidationRule rule1 = new ValidationRule();
            rule1.IsRequired = true;
            rule1.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", "aaaaaa");
            validationProvider1.SetValidationRule(this.textBox1, rule1);

            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "       "; 

            log.Info("FrmCompany init end");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
//            Noogen.Validation.ValidationRule vr = new Noogen.Validation.ValidationRule();
//            vr.CustomValidationMethod +=
//             new Noogen.Validation.CustomValidationEventHandler(vr_CustomValidationMethod);
//            vr.CustomErrorMessage = MessageUtils.GetMessage("W0002","bbbbb","ccccc");
//            this.validationProvider1.SetValidationRule(this.dateTimePicker1, vr);
//
//
//            if (!this.validationProvider1.Validate())
//            {
//                IList<MessageVo> re = this.validationProvider1.ValidationMessages(
//                      true);
//                this.baseform.msgwindow.Messagelist = re;
//                this.baseform.msgwindow.ShowMessage();
//                
//                return;
//            }
//            else
//            {
//                this.validationProvider1.ValidationMessages(false);
//                baseform.msgwindow.Hide();
//            }

            log.Debug("OK click");
            try
            {
                //通过Windsor组件容器获得Action的实例。
                //IAction_FrmCompany a = ComponentLocator.Instance().Resolve<IAction_FrmCompany>();
                //ITDescMsDao d = ComponentLocator.Instance().Resolve<ITDescMsDao>();
                //IList<TDescMs> l  = d.GetTDescMsList("63", "zh-CN");
                //StoredProcedureExecDaoOracleImp dd = new StoredProcedureExecDaoOracleImp();
                IStoredProcedureExecDao dd = ComponentLocator.Instance().Resolve<IStoredProcedureExecDao>();

                StoredProcedureCondition condition = new StoredProcedureCondition();
                condition.AddCondition("I_JOURNAL_NO", 1000002,ParameterDirection.Input);
                condition.AddCondition("I_COMPANY_CD", "00", ParameterDirection.Input);
                condition.AddCondition("I_ERR_CD", DbType.String,6,ParameterDirection.Output);
                condition.AddCondition("I_ERR_ITEM", DbType.String,100,ParameterDirection.Output);
                decimal returnvalue = dd.StoredProcedureExecReturnNumber("PE0025P.TOP_RTN", condition);
                string ierrcd = (string)condition.GetStoredProcedureOutputValue("I_ERR_CD");
                string ierritem = (string)condition.GetStoredProcedureOutputValue("I_ERR_ITEM");

                if (returnvalue != 0)
                {
                    IList<MessageVo> msglist = new List<MessageVo>();
                    MessageVo vo = new MessageVo();
                    vo.MessageType = "Warning";
                    vo.ResultMessage = MessageUtils.GetMessage("W0005", ierrcd, ierritem);
                    msglist.Add(vo);
                    this.baseform.msgwindow.Messagelist = msglist;
                    this.baseform.msgwindow.ShowMessage();
                }

                //  ICTPmMsNoARDao d = ComponentLocator.Instance().Resolve<ICTPmMsNoARDao>();
//                SearchCondition condition = new SearchCondition();
//                condition.AddCondition("T_PM_MS.I_ITEM_ENTRY_CLS","I_ITEM_ENTRY_CLS","00",SqlOperator.Equal);
//                //condition.AddCondition("T_PM_MS.I_FAC_CD","F
//
//                IList<CTPmMsNoAR> l = d.GetPmMsDetail(condition);
//                //调用Action类的方法
//                MessageBox.Show(l.Count.ToString());
//                //NewMethod();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
  
            this.dateTimePicker1.Format=DateTimePickerFormat.Long; 
            this.dateTimePicker1.CustomFormat=null; 

             

        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            this.xDateTimePicker1.SetDefaultValue("2011/08/12");
        }





    }
}
