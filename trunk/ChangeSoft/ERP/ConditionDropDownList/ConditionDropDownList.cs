using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Com.ChangeSoft.Common;
using System.Diagnostics;

namespace Com.ChangeSoft.Common.Control.ConditionDropDownList
{
    public partial class ConditionDropDownList : UserControl
    {
        private string conditionname;

        private int defaultselectedindex;


        public ConditionDropDownList()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (IsDesignMode())
                return;
            this.comboBox1.Items.Clear();

            IList<ConditionVo> result = new List<ConditionVo>();
            result = (IList<ConditionVo>)ConditionUtils.Conditions[this.conditionname];
            foreach (ConditionVo vo in result)
            {
                this.comboBox1.Items.Add(vo);
            }
            this.comboBox1.SelectedIndex = this.defaultselectedindex;

        }

        public string Conditionname
        {
            get { return conditionname; }
            set { conditionname = value; }
        }


        public int Defaultselectedindex
        {
            get { return defaultselectedindex; }
            set { defaultselectedindex = value; }
        }


        public static bool IsDesignMode()
        {

            bool returnFlag = false;



            #if DEBUG

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {

                returnFlag = true;

            }

            else if (Process.GetCurrentProcess().ProcessName == "devenv")
            {

                returnFlag = true;

            }

            #endif



            return returnFlag;

        }

    }
}
