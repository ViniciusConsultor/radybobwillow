using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.GainWinSoft.ERP.WorksheetInquiry
{
    public partial class FrmWorksheetInquiry : Com.GainWinSoft.Common.BaseContent
    {
        public FrmWorksheetInquiry(DockPanel _parentdockpanel, BaseForm _owner)
            : base(_parentdockpanel, _owner)
        {
            InitializeComponent();
        }
    }
}
