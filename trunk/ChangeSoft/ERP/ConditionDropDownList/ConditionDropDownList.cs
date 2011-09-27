using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Com.GainWinSoft.Common;
using System.Diagnostics;

namespace Com.GainWinSoft.Common.Control.ConditionDropDownList
{
    public partial class ConditionDropDownList : UserControl
    {
        private string conditionname;

        private int defaultselectedindex;

        private bool autoaddblankitem;


        private string selectedvalue;

        private string selectedname;

        private int selectedindex=-1;


        public delegate void OnSelectChangedEventHandler(object sender, EventArgs e);
        public event OnSelectChangedEventHandler SelectedIndexChanged;

        protected virtual void OnSelectChanged(Object sender, EventArgs e)
        {//事件触发方法  
            ComboBox c = (ComboBox)sender;
            this.selectedname = ((ConditionVo)c.SelectedItem).ConditionName;
            this.selectedvalue = ((ConditionVo)c.SelectedItem).ConditionValue;
            this.selectedindex = c.SelectedIndex;
            if (SelectedIndexChanged != null)
            {//判断事件是否为空  
                SelectedIndexChanged(this, e);//触发事件  
            }
        } 


        public ConditionDropDownList()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (IsDesignMode())
                return;
            this.comboBox1.Items.Clear();
            if (autoaddblankitem)
            {
                ConditionVo vo = new ConditionVo();
                vo.ConditionValue = " ";
                vo.ConditionName = " ";
                this.comboBox1.Items.Add(vo);
            }
            IList<ConditionVo> result = new List<ConditionVo>();
            result = (IList<ConditionVo>)ConditionUtils.Conditions[this.conditionname];
            foreach (ConditionVo vo in result)
            {
                this.comboBox1.Items.Add(vo);
            }
            this.comboBox1.SelectedIndex = this.defaultselectedindex;
            this.comboBox1.SelectedIndexChanged += new EventHandler(OnSelectChanged);

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

        public string Selectedvalue
        {
            get { return selectedvalue; }
            set { selectedvalue = value; }
        }


        public string Selectedname
        {
            get { return selectedname; }
            set { selectedname = value; }
        }

        public int Selectedindex
        {
            get { return selectedindex; }
            set { selectedindex = value; }
        }

        public bool Autoaddblankitem
        {
            get { return autoaddblankitem; }
            set { autoaddblankitem = value; }
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
