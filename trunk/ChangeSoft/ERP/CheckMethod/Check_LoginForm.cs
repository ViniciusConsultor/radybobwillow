using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Noogen.Validation;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Action;
using Com.GainWinSoft.ERP.FormVo;

namespace Com.GainWinSoft.ERP
{
    public partial class LoginForm
    {
        public void Check_Init()
        {
            ValidationRule ruleUserId = new ValidationRule();
            ruleUserId.IsRequired = true;
            ruleUserId.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblUserId.Text);
            validationProvider1.SetValidationRule(this.txtUserId, ruleUserId);

            ValidationRule rulePassword = new ValidationRule();
            rulePassword.IsRequired = true;
            rulePassword.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblPassword.Text);
            validationProvider1.SetValidationRule(this.txtPassword, rulePassword);

            Noogen.Validation.ValidationRule ruleLoginCheck = new Noogen.Validation.ValidationRule();
            ruleLoginCheck.CustomValidationMethod +=
             new Noogen.Validation.CustomValidationEventHandler(vr_CustomLoginValidationMethod);
            ruleLoginCheck.CustomErrorMessage = MessageUtils.GetMessage("W0003");
            validationProvider2.SetValidationRule(this.txtUserId, ruleLoginCheck);

        }

        public void vr_CustomLoginValidationMethod(object sender,
                         Noogen.Validation.CustomValidationEventArgs e)
        {
                 IAction_LoginForm ac = ComponentLocator.Instance().Resolve<IAction_LoginForm>();
                LoginUserInfoVo loginuserinfo =  ac.GetLoginUserList(this.txtUserId.Text, this.txtPassword.Text);
                if (loginuserinfo==null)
                {
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                    SessionUtils.SetSession(SessionUtils.COMMON_LOGIN_USER_INFO, loginuserinfo);
                }
            
        }
    }
}
