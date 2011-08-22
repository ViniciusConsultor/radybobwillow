using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.ChangeSoft.ERP.Company.CheckMethod
{
    public static class Check_Company
    {
        //
        // The custom validation method.
        //
        public static  void vr_CustomValidationMethod(object sender,
                         Noogen.Validation.CustomValidationEventArgs e)
        {
            e.IsValid =
                 e.Value.ToString().Equals("2011年8月22日");
            e.ErrorMessage = "%ControlName% is not today";
        }
    }
}
