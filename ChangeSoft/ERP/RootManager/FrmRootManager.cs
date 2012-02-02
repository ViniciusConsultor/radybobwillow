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

 namespace Com.GainWinSoft.ERP.RootManager
{
     public partial class FrmRootManager : BaseContent
    {
         public FrmRootManager(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }

         private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
         {

         }

    }
}
