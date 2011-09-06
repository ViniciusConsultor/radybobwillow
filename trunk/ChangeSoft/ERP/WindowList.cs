using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.ChangeSoft.ERP
{
    public partial class WindowList : Form
    {
        private DockPanel dockPanel;
        public WindowList(DockPanel _dockPanel)
        {
            this.dockPanel = _dockPanel;
            InitializeComponent();
        }

        private void WindowList_Load(object sender, EventArgs e)
        {
            foreach (DockContent content in dockPanel.Documents)
            {
                this.listBox1.Items.Add(content.DockHandler.TabText);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
             ShowContent(this.listBox1.SelectedItem.ToString());
             this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DockContent content = FindDocument(this.listBox1.SelectedItem.ToString());
            content.DockHandler.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as DockContent;
                    }
                }

                return null;
            }
            else
            {
                foreach (DockContent content in dockPanel.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }

        private DockContent ShowContent(string caption)
        {
            DockContent frm = FindDocument(caption);
            //if (frm == null)
            //{
            //    frm = ChildWinManagement.LoadMdiForm(Portal.gc.MainDialog, formType) as DockContent;
            //}

            frm.Show(this.dockPanel);
            frm.BringToFront();
            return frm;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItems.Count == 0)
                return;
            ShowContent(this.listBox1.SelectedItem.ToString());
            this.Close();
        }
    }
}
