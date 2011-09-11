using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Collections;

namespace Com.GainWinSoft.Common
{
    public partial class BaseCodeForm : DockContent
    {
        public const string CODE_REF_VALUE_COLUMN = "CODE_REF_VALUE_COLUMN";
        public const string CODE_REF_NAME_COLUMN = "CODE_REF_NAME_COLUMN";
        public const string CODE_REF_PREPARATION_COLUMN_LIST = "CODE_REF_PREPARATION_COLUMN_LIST";



        private Hashtable controllist = new Hashtable();

        public BaseCodeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void AddValueControl(Control c)
        {
            controllist.Add(CODE_REF_VALUE_COLUMN, c);
        }

        public void AddNameControl(Control c)
        {
            controllist.Add(CODE_REF_NAME_COLUMN, c);
        }
        public void AddColumnControlList(IList<Control> list)
        {
            controllist.Add(CODE_REF_PREPARATION_COLUMN_LIST, list);
        }

        public void RemoveControl(string key)
        {
            controllist.Remove(key);
        }
        public void RemoveAllControl()
        {
            controllist.Clear();
        }
        //public Control GetControl(string key)
        //{
        //    return (Control)controllist[key];
        //}

        public void SetValue(string value)
        {
            Control c = (Control)controllist[CODE_REF_VALUE_COLUMN];
            if (c is Label)
            {
                ((Label)c).Text = value;
            }
            else if (c is TextBox)
            {
                ((TextBox)c).Text = value;
            }
            else
            {
                c.Text = value;
            }

        }

        public void SetName(string value)
        {
            Control c = (Control)controllist[CODE_REF_NAME_COLUMN];
            if (c is Label)
            {
                ((Label)c).Text = value;
            }
            else if (c is TextBox)
            {
                ((TextBox)c).Text = value;
            }
            else
            {
                c.Text = value;
            }
        }

        public void SetFocus()
        {
            Control c = (Control)controllist[CODE_REF_VALUE_COLUMN];
            c.Focus();
        }

        public void SetPreparation(IList<string> valuelist)
        {
            IList<Control> list = (IList<Control>)controllist[BaseCodeForm.CODE_REF_PREPARATION_COLUMN_LIST];

            int cnt = 0;
            foreach (Control c in list)
            {
                if (c is Label)
                {
                    ((Label)c).Text = valuelist[cnt];
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Text = valuelist[cnt];
                }
                else
                {
                    c.Text = valuelist[cnt];
                }
                cnt++;
            }
        }

    }
}
