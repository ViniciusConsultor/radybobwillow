using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Collections;

namespace Com.ChangeSoft.Common
{
    public   partial class BaseForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {

        private Hashtable SessionContext = new Hashtable();
        public MessageWindow msgwindow;
        public BaseForm()
        {
      
            InitializeComponent();
            msgwindow = new MessageWindow();
            msgwindow.Show(this.dockPanel, DockState.DockBottomAutoHide);
            msgwindow.BringToFront();
            msgwindow.Hide();
        }

        public Object getSession(string key)
        {
            Object result = SessionContext[key];
            return result;
        }

        public void setSession(string key, Object data)
        {
            SessionContext.Add(key, data);
        }
        
    }


}
