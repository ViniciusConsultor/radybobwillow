using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using WeifenLuo.WinFormsUI.Docking;
using System.Collections;

namespace Com.GainWinSoft.Common
{
    public partial class BaseContent : WeifenLuo.WinFormsUI.Docking.DockContent, Com.GainWinSoft.Common.IBaseContent
    {
        protected BaseForm baseform;

        protected BaseForm tempowner;
        private DockPanel parentdockpanel;

        private string title;


        public BaseContent()
        {
            InitializeComponent();
            
        }

        public BaseContent(DockPanel parentdockpanel)
        {
            this.parentdockpanel = parentdockpanel;
            InitializeComponent();
        }


        public BaseContent(DockPanel parentdockpanel, BaseForm _owner)
        {
            this.parentdockpanel = parentdockpanel;
            tempowner = _owner;

            InitializeComponent();
        }


        public string DockTitle
        {
            get { return title; }
            set
            {
                title = value;
            }
        }

        public void ShowContentAtFirst(bool closeowner)
        {
            int dc = 0;

            DockContent frm = this.FindParentDocument(this.title);
            if (frm == null)
            {

                BaseForm b = new BaseForm();
                b.Parentdockpanel = parentdockpanel;
                b.TopLevel = false;
                b.Text = this.title;
                b.SessionKey = this.Name;
                SessionUtils.SetSession(this.Name, new Hashtable());
                if (tempowner != null)
                {
                    tempowner.ChildContent = b;
                }
                b.OwnerForm = tempowner;
                this.baseform = b;
                //display at the first
                this.Show(this.baseform.dockPanel);
                if (this.parentdockpanel.DocumentsCount == 0)
                {
                    this.baseform.Show(this.baseform.Parentdockpanel);
                }
                else
                {
                    this.baseform.Show(this.baseform.Parentdockpanel.Panes[1], this.baseform.Parentdockpanel.Panes[1].Contents[0]);
                }



                //                if (this.owner == null)
                //                {
                //                    this.Show(this.baseform.dockPanel);
                //                    this.baseform.Show(this.baseform.Parentdockpanel);
                //                }
                //                else
                //                {
                //                    this.Show(this.baseform.dockPanel);
                //                    dc = owner.Pane.Contents.IndexOf(owner.Pane.ActiveContent);
                //                    if ((dc == owner.Pane.Contents.Count - 1))
                //                    {
                //                        this.baseform.Show(this.baseform.Parentdockpanel);
                //                    }
                //                    else
                //                    {
                //                        this.baseform.Show(owner.Pane, owner.Pane.Contents[dc + 1]);
                //                    }
                //                }
                this.BringToFront();


            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }

            //如果画面跳转后自己画面要关闭的话，用下面两句话，关闭自画面
            if (closeowner)
            {
                IDockContent content = (IDockContent)baseform.Pane.Contents[dc];
                content.DockHandler.Close();
            }
        }

        public void ShowContent(bool closeowner)
        {
            int dc = 0;

            DockContent frm = this.FindParentDocument(this.title);
            if (frm == null)
            {

                BaseForm b = new BaseForm();
                b.Parentdockpanel = parentdockpanel;
                b.TopLevel = false;
                b.Text = this.title;
                b.SessionKey = this.Name;
                SessionUtils.SetSession(this.Name, new Hashtable());
                if (tempowner != null)
                {
                    tempowner.ChildContent = b;
                } 
                b.OwnerForm = tempowner;
                this.baseform = b;

                if (this.baseform.OwnerForm == null)
                {
                    this.Show(this.baseform.dockPanel);
                    this.baseform.Show(this.baseform.Parentdockpanel);
                }
                else
                {
                    this.Show(this.baseform.dockPanel);
                    dc = ((BaseForm)this.baseform.OwnerForm).Pane.Contents.IndexOf(((BaseForm)this.baseform.OwnerForm).Pane.ActiveContent);
                    if ((dc == ((BaseForm)this.baseform.OwnerForm).Pane.Contents.Count - 1))
                    {
                        this.baseform.Show(this.baseform.Parentdockpanel);
                    }
                    else
                    {
                        this.baseform.Show(((BaseForm)this.baseform.OwnerForm).Pane, ((BaseForm)this.baseform.OwnerForm).Pane.Contents[dc + 1]);
                    }
                }
                this.BringToFront();


            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }

            //如果画面跳转后自己画面要关闭的话，用下面两句话，关闭自画面
            if (closeowner)
            {
                IDockContent content = (IDockContent)baseform.Pane.Contents[dc];
                content.DockHandler.Close();
                baseform.Close();
                baseform.Dispose();
            }
        }

        public void CloseContent()
        {
            if (baseform.Pane.ActiveContent is IDockContent)
            {

                if (baseform.ChildContent != null)
                {
                    MessageBox.Show(MessageUtils.GetMessage("E0002",baseform.ChildContent.Text), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                IDockContent content = (IDockContent)baseform.Pane.ActiveContent;

                content.DockHandler.Close();
                if (((BaseForm)this.baseform.OwnerForm) != null)
                {
                    ((BaseForm)this.baseform.OwnerForm).ChildContent = null;
                    ((BaseForm)this.baseform.OwnerForm).Show();
                    ((BaseForm)this.baseform.OwnerForm).BringToFront();
                }
                baseform.Close();
                baseform.Dispose();

            }
        }

        private DockContent FindParentDocument(string text)
        {
            if (this.parentdockpanel.DocumentStyle == DocumentStyle.SystemMdi)
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

        public virtual void Language_Change()
        {
        }



        public WeifenLuo.WinFormsUI.Docking.DockPanel Parentdockpanel
        {
            get { return parentdockpanel; }
            set { parentdockpanel = value; }
        }

        private void BaseContent_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
