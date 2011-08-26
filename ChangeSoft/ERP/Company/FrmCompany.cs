using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using log4net;
using Com.ChangeSoft.ERP.Company.Action;
using Com.ChangeSoft.Common;
using Com.ChangeSoft.ERP.Company.CheckMethod;
using WeifenLuo.WinFormsUI.Docking;
using Noogen.Validation;

namespace Com.ChangeSoft.ERP.Company
{
    public partial class FrmCompany : Com.ChangeSoft.Common.BaseForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(FrmCompany));


        public FrmCompany()
        {
            log.Info("FrmCompany init start");
            
            InitializeComponent();

            ValidationRule rule1 = new ValidationRule();
            rule1.IsRequired = true;
            rule1.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001","aaaaaa");
            validationProvider1.SetValidationRule(this.textBox1, rule1);



            log.Info("FrmCompany init end");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Noogen.Validation.ValidationRule vr = new Noogen.Validation.ValidationRule();
            vr.CustomValidationMethod +=
             new Noogen.Validation.CustomValidationEventHandler(Check_Company.vr_CustomValidationMethod);
            vr.CustomErrorMessage = MessageUtils.GetMessage("W0002","bbbbb","ccccc");
            this.validationProvider1.SetValidationRule(this.dateTimePicker1, vr);


            if (!this.validationProvider1.Validate())
            {
                IList<MessageVo> re = this.validationProvider1.ValidationMessages(
                      true);
                msgwindow.Messagelist = re;
                msgwindow.ShowMessage();
                
                return;
            }
            else
            {
                this.validationProvider1.ValidationMessages(false);
                msgwindow.Hide();
            }

            log.Debug("OK click");
            try
            {
                //通过Windsor组件容器获得Action的实例。
                IAction_FrmCompany a = ComponentLocator.Instance().Resolve<IAction_FrmCompany>();
                //调用Action类的方法
                MessageBox.Show(a.NewMethod().ToString());
                //NewMethod();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }




        public override void Language_Change()
        {
            throw new NotImplementedException();
        }

    }
}
