using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.ChangeSoft.Common
{
    public   partial class BaseForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {

        public MessageWindow msgwindow;
        public BaseForm()
        {
      
            InitializeComponent();
            msgwindow = new MessageWindow();
            msgwindow.Show(this.dockPanel, DockState.DockBottomAutoHide);
            msgwindow.BringToFront();
            msgwindow.Hide();
        }


        
    }


}
