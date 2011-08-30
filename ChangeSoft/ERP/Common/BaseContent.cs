using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Com.ChangeSoft.Common
{
    public partial class BaseContent : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        protected BaseForm baseform;

        public BaseContent()
        {
            InitializeComponent();
        }

        public BaseContent(BaseForm _baseform)
        {
            this.baseform = _baseform;
            InitializeComponent();
        }
        public virtual void Language_Change()
        {
        }
    }
}
