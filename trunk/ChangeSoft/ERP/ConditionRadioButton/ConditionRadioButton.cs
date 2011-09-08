using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Com.GainWinSoft.Common.Control.ConditionRadioButton
{
    public partial class ConditionRadioButton : UserControl
    {
        private string conditionname;

        private int defaultselectedindex;

        private string checkedvalue = "";
        private string checkedname = "";

        public delegate void OnCheckedChangeEventHandler(object sender, EventArgs e);
        public event OnCheckedChangeEventHandler RadioChanged;

        public string Checkedvalue
        {
            get { return checkedvalue; }
            set { checkedvalue = value; }
        }

        public string Checkedname
        {
            get { return checkedname; }
            set { checkedname = value; }
        }

        protected virtual void OnRadioChanged(Object sender, EventArgs e)
        {//事件触发方法  
            if (RadioChanged != null)
            {//判断事件是否为空  
                RadioButton r = (RadioButton)sender;
                if (r.Checked)
                {
                    this.checkedvalue = (string)r.Tag;
                    this.checkedname = r.Text;
                }
                RadioChanged(this, e);//触发事件  
            }
        } 

        public ConditionRadioButton()
        {
            InitializeComponent();
        }

        private void ConditionRadioButton_Load(object sender, EventArgs e)
        {
            if (IsDesignMode())
                return;

            IList<ConditionVo> result = new List<ConditionVo>();
            result = (IList<ConditionVo>)ConditionUtils.Conditions[this.conditionname];
            foreach (ConditionVo vo in result)
            {
                RadioButton radNew = new RadioButton();
                radNew.Name = vo.ConditionName + "-" + vo.ConditionValue;
                radNew.Tag = vo.ConditionValue;
                radNew.Text = vo.ConditionName;
                radNew.Click += new EventHandler(OnRadioChanged);
                this.flowLayoutPanel1.Controls.Add(radNew);
                
            }

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
