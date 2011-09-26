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
    public   partial class BaseForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {

        private DockPanel parentdockpanel;

        private DockContent ownerForm;


        public MessageWindow msgwindow;

        private DockContent childContent;

        private string sessionKey;



        public BaseForm()
        {
            InitializeComponent();
            msgwindow = new MessageWindow();
            msgwindow.Show(this.dockPanel, DockState.DockBottomAutoHide);
            msgwindow.BringToFront();
            msgwindow.Hide();
        }


        public string SessionKey
        {
            get { return sessionKey; }
            set { sessionKey = value; }
        }

        public DockContent OwnerForm
        {
            get { return ownerForm; }
            set { ownerForm = value; }
        }

        public DockContent ChildContent
        {
            get { return childContent; }
            set { childContent = value; }
        }

        public DockPanel Parentdockpanel
        {
            get { return parentdockpanel; }
            set { parentdockpanel = value; }
        }


        public DockContent FindParentDocument(string text)
        {
            if (parentdockpanel.DocumentStyle == DocumentStyle.SystemMdi)
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
                foreach (DockContent content in parentdockpanel.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }

        public DockContent FindChildDocument(string text)
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

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (this.childContent != null)
            {
                MessageBox.Show(MessageUtils.GetMessage("E0002", this.childContent.Text), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
            else
            {
                if (((BaseForm)this.OwnerForm) != null)
                {
                    ((BaseForm)this.OwnerForm).childContent = null;
                }
                SessionUtils.RemoveSession(this.SessionKey);
                e.Cancel = false;
                return;

            }
        }
    }


}
