using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.GainWinSoft.ERP;
using Noogen.Validation;
using Com.GainWinSoft.ERP.Entity;
using Com.GainWinSoft.Common;
using System.Windows.Forms;


namespace Com.GainWinSoft.ERP.ExchangeRate
{

    public partial class FrmExchangeRate
    {



        /// <summary>
        /// Group3各种Check
        /// </summary>
        private Boolean CheckG3()
        {
            Boolean rtnValue = true;

            if (!this.vdpG3.Validate())
            {
                IList<MessageVo> re = this.vdpG3.ValidationMessages(true);
                this.DialogResult = DialogResult.Abort;

                this.baseform.msgwindow.Messagelist = re;
                this.baseform.msgwindow.ShowMessage();
                rtnValue = false;
            }

            return rtnValue;
        }



        /// <summary>
        /// Group2各种Check
        /// </summary>
        private  void CheckG2(object sender, CustomValidationEventArgs e)
        {

            e.IsValid = true;
            if (pgvRateMs.RowCount == 0 || pgvRateMs.SelectedRowIndex < 0)
            {
                e.IsValid = false;
            }
        }
    }
}
