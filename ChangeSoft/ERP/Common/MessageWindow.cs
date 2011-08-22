using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.ChangeSoft.Common
{
    public partial class MessageWindow :DockContent
    {
        public MessageWindow()
        {
            InitializeComponent();
            AddMessage();
        }
        public void AddMessage()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = (Image)Properties.Resources.ResourceManager.GetObject("MessageWindowWarning");
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = 1;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = "出错啊啊";
        }
    }
}
