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

namespace Com.GainWinSoft.ERP.TableDropDownList
{
    public partial class TableDropDownList : UserControl
    {
        private string tableNm;
        public string TableNm
        {
            get { return tableNm; }
            set { tableNm = value; }
        }

        private string valueColumn;
        public string ValueColumn
        {
            get { return valueColumn; }
            set { valueColumn = value; }
        }

        private string nameColumn;
        public string NameColumn
        {
            get { return nameColumn; }
            set { nameColumn = value; }
        }

        private Boolean languageFlg = false;
        public Boolean LanguageFlg
        {
            get { return languageFlg; }
            set { languageFlg = value; }
        }

        private string languageColumn;
        public string LanguageColumn
        {
            get { return languageColumn; }
            set { languageColumn = value; }
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
            set
            {
                selectedvalue = value;
                int i = 0;
                foreach (ConditionVo vo in this.comboBox1.Items)
                {
                    if (vo.ConditionValue.Equals(selectedvalue))
                    {
                        this.comboBox1.SelectedIndex = i;
                    }
                    i++;
                }
            }
        }

        private string selectedname;
        public string Selectedname
        {
            get { return selectedname; }
            set { selectedname = value; }
        }

        private int selectedIndex = -1;
        public int SelectedIndex
        {
            get
            {
                selectedIndex = this.comboBox1.SelectedIndex;
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
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
            this.selectedIndex = c.SelectedIndex;
            if (SelectedIndexChanged != null)
            {//判断事件是否为空  
                SelectedIndexChanged(this, e);//触发事件  
            }
        }

        public TableDropDownList()
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

        private void TableDropDownList_Load(object sender, EventArgs e)
        {
            if (IsDesignMode())
                return;

            ICTableDropDownListNoARDao d = ComponentLocator.Instance().Resolve<ICTableDropDownListNoARDao>();
            IList<CTableDropDownListNoAR> list = new List<CTableDropDownListNoAR>();
            if (this.languageFlg)
            {
                list = d.GetDetail(LangUtils.GetCurrentLanguage(), this.languageColumn, this.tableNm, this.valueColumn, this.nameColumn);
            }
            else
            {
                list = d.GetDetail(this.tableNm, this.valueColumn, this.nameColumn);
            }

            this.comboBox1.Items.Clear();
            if (autoaddblankitem)
            {
                ConditionVo vo = new ConditionVo();
                vo.ConditionValue = "";
                vo.ConditionName = "";
                this.comboBox1.Items.Add(vo);
            }

            foreach (CTableDropDownListNoAR detail in list)
            {
                ConditionVo conditionvo = new ConditionVo();
                conditionvo.ConditionValue = detail.ICd;
                conditionvo.ConditionName = detail.IName;
                this.comboBox1.Items.Add(conditionvo);
            }

            this.comboBox1.SelectedIndexChanged += new EventHandler(OnSelectChanged);
            this.comboBox1.SelectedIndex = this.defaultselectedindex;
        }
    }
}
