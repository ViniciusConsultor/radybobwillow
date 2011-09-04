using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Com.ChangeSoft.Common.Control.ConditionRadioButton
{
    public partial class ConditionRadioButton : UserControl
    {
        private string conditionname;

        private int defaultselectedindex;

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
            int cnt = result.Count;
            if (cnt > 0)
            {
                this.tpGB.ColumnCount = cnt;
                int iCnt = 0;
                float iWidth = (float)Math.Round((decimal)(this.tpGB.Width / cnt), 1);
                foreach (ConditionVo vo in result)
                {
                    RadioButton radNew = new RadioButton();
                    radNew.Name = vo.ConditionName + "-" + vo.ConditionValue;
                    radNew.Text = vo.ConditionName;
                    radNew.Anchor = AnchorStyles.Right;
                    if (iCnt == 0)
                    {
                        this.tpGB.ColumnStyles[0].Width = iWidth;
                    }
                    else
                    {
                        this.tpGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, iWidth));
                    }
                    this.tpGB.Controls.Add(radNew, iCnt, 0);
                    iCnt++;
                }
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
