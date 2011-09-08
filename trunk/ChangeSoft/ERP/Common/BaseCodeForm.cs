using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.GainWinSoft.Common
{
    public partial class BaseCodeForm : DockContent
    {
        public BaseCodeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
