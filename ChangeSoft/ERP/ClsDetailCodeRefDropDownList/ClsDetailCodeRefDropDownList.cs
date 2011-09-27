using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Entity;

namespace ClsDetailCodeRefDropDownList
{
    public partial class ClsDetailCodeRefDropDownList : UserControl
    {

        private string clsCd;

        public string ClsCd
        {
            get { return clsCd; }
            set { clsCd = value; }
        }

        private bool showNameDesc = false;

        public bool ShowNameDesc
        {
            get { return showNameDesc; }
            set { showNameDesc = value; }
        }


        private int defaultselectedindex;



        public int Defaultselectedindex
        {
            get { return defaultselectedindex; }
            set { defaultselectedindex = value; }
        }

        private bool autoaddblankitem;

        public bool Autoaddblankitem
        {
            get { return autoaddblankitem; }
            set { autoaddblankitem = value; }
        }


        private string selectedvalue;

        public string Selectedvalue
        {
            get { return selectedvalue; }
            set { selectedvalue = value; }
        }

        private string selectedname;

        public string Selectedname
        {
            get { return selectedname; }
            set { selectedname = value; }
        }

        private int selectedindex = -1;

        public int Selectedindex
        {
            get { return selectedindex; }
            set
            {
                selectedindex = value;
                this.comboBox1.SelectedIndex = value;
            }
        }

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

        public ClsDetailCodeRefDropDownList()
        {
            InitializeComponent();
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

        private void ClsDetailCodeRefDropDownList_Load(object sender, EventArgs e)
        {
            if (IsDesignMode())
                return;

            ICClsDetailNoARDao d = ComponentLocator.Instance().Resolve<ICClsDetailNoARDao>();
            IList<CClsDetailNoAR> list = d.GetClsDetailList(LangUtils.GetCurrentLanguage(), this.clsCd);

            this.comboBox1.Items.Clear();
            if (autoaddblankitem)
            {
                ConditionVo vo = new ConditionVo();
                vo.ConditionValue = " ";
                vo.ConditionName = " ";
                this.comboBox1.Items.Add(vo);
            }
            //IList<ConditionVo> result = new List<ConditionVo>();
            foreach (CClsDetailNoAR clsdetail in list)
            {
                ConditionVo conditionvo = new ConditionVo();
                conditionvo.ConditionValue = clsdetail.IClsDetailCd;
                if (showNameDesc)
                {
                    conditionvo.ConditionName = clsdetail.IClsNameDesc;
                }
                else
                {
                    conditionvo.ConditionName = clsdetail.IClsDetailDesc;
                }
                this.comboBox1.Items.Add(conditionvo);

            }


            this.comboBox1.SelectedIndex = this.defaultselectedindex;
            this.comboBox1.SelectedIndexChanged += new EventHandler(OnSelectChanged);

        }

    }
}
