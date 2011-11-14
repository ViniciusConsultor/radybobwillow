using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.ERP.ExchangeRate.FormVo;
using Com.GainWinSoft.ERP.ExchangeRate.Action;
using Com.GainWinSoft.Common.Vo;
using log4net;
using System.Resources;
using Noogen.Validation;


namespace Com.GainWinSoft.ERP.DeliveryEntry
{
    public partial class FrmDeliveryEntry : BaseContent
    {
        public FrmDeliveryEntry(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }
    }
}
