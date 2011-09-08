using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.GainWinSoft.Common.Control.PagerGridView
{
    public partial class FrmColumnsSetting : DockContent
    {
        private IList<ColumnInfoVo> clist;
        public FrmColumnsSetting(IList<ColumnInfoVo> _clist)
        {
            clist = _clist;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ColumnInfoVo item in clist)
            {
                item.Columnvisible = false;
            }
            foreach (ColumnInfoVo item in this.checkedListBox1.CheckedItems)
            {
                item.Columnvisible = true;
            }
            this.Close();
        }

        private void FrmColumnsSetting_Load(object sender, EventArgs e)
        {

            foreach (ColumnInfoVo vo in clist)
            {

                this.checkedListBox1.Items.Add(vo,vo.Columnvisible);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            if (this.checkBox1.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);//全选

                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);//全不选

                }
            }
 
        }
    }
}
