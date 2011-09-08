using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Noogen.Validation;

namespace Com.GainWinSoft.Common
{
    public partial class MessageWindow :DockContent
    {
        private IList<MessageVo> _messagelist;

        public IList<MessageVo> Messagelist
        {
            get { return _messagelist; }
            set { _messagelist = value; }
        }

        public MessageWindow()
        {
            
            InitializeComponent();
            //ShowMessage();
        }
        public void ShowMessage()
        {

            dataGridView1.Rows.Clear();
            if (_messagelist == null)
            {
                return;
            }
            foreach (MessageVo messagevo in _messagelist)
            {
                dataGridView1.Rows.Add();
                if ("Warning".Equals(messagevo.MessageType))
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = (Image)Properties.Resources.ResourceManager.GetObject("MessageWindowWarning");
                }
                else
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = (Image)Properties.Resources.ResourceManager.GetObject("MessageWindowError");
                }
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = dataGridView1.Rows.Count;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = messagevo.ResultMessage;
            }
            this.Show();
            this.BringToFront();
        }
    }
}
