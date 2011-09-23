using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Com.GainWinSoft.Common.Control.XDateTimePicker
{


    public partial class XDateTimePicker : UserControl
    {

        private string text = "";
        private DateTime value;

        public XDateTimePicker()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultvalue">yyyy/MM/dd形式的</param>
        public void SetDefaultValue(string defaultvalue)
        {
            if ("".Equals(defaultvalue) || defaultvalue == null)
            {
                this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
                this.dateTimePicker1.CustomFormat = "       ";
                //this.dateTimePicker1.Text = "";
                //this.dateTimePicker1.Value = this.dateTimePicker1.MinDate;

            }
            else
            {
                DateTime dt;
                DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy/MM/dd";
                dt = Convert.ToDateTime(defaultvalue, dtFormat);

                this.dateTimePicker1.Format = DateTimePickerFormat.Long;
                this.dateTimePicker1.CustomFormat = null;
                this.dateTimePicker1.Value = dt;


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "       ";
            //this.dateTimePicker1.Text = "";
            //this.dateTimePicker1.Value = this.dateTimePicker1.MinDate;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            this.dateTimePicker1.Format = DateTimePickerFormat.Long;
            this.dateTimePicker1.CustomFormat = null;

        }

        public override string Text
        {
            get
            {
                text = this.dateTimePicker1.Text.Trim();
                return text;
            }
            set
            {
                text = value;
                this.dateTimePicker1.Text = value;
            }
        }

        public System.DateTime Value
        {
            get
            {
                this.value = this.dateTimePicker1.Value;
                return this.value;
            }
            set
            {
                this.value = value;
                this.dateTimePicker1.Value = value;
            }
        }
    }
}
