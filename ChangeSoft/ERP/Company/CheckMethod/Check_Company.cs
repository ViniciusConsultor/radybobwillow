using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.ChangeSoft.ERP.Company
{
    public partial class FrmCompany
    {
        //
        // The custom validation method.
        //
        public  void vr_CustomValidationMethod(object sender,
                         Noogen.Validation.CustomValidationEventArgs e)
        {
            e.IsValid =
                 e.Value.ToString().Equals("2011年8月22日");
            e.ErrorMessage = "%ControlName% is not today";
        }
    }
}
