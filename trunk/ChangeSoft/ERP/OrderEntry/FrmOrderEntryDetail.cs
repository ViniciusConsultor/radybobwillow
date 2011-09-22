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

namespace Com.GainWinSoft.ERP.OrderEntry
{
    public partial class FrmOrderEntryDetail : BaseContent
    {
        public FrmOrderEntryDetail(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }
    }
}
