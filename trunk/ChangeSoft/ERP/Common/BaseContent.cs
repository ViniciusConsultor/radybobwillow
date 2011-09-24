using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.GainWinSoft.Common
{
    public partial class BaseContent : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        protected BaseForm baseform;

        private BaseForm owner;

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
            this.owner = _owner;

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
                this.baseform = b;

                if (this.owner == null)
                {
                    this.Show(this.baseform.dockPanel);
                    this.baseform.Show(this.baseform.Parentdockpanel);
                }
                else
                {
                    this.Show(this.baseform.dockPanel);
                    dc = owner.Pane.Contents.IndexOf(owner.Pane.ActiveContent);
                    if ((dc == owner.Pane.Contents.Count - 1))
                    {
                        this.baseform.Show(this.baseform.Parentdockpanel);
                    }
                    else
                    {
                        this.baseform.Show(owner.Pane, owner.Pane.Contents[dc + 1]);
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
            }
        }

        public void CloseContent()
        {
            if (baseform.Pane.ActiveContent is IDockContent)
            {
                IDockContent content = (IDockContent)baseform.Pane.ActiveContent;
                content.DockHandler.Close();
                if (owner != null)
                {
                    this.owner.Show();
                    this.owner.BringToFront();
                }
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



        public Com.GainWinSoft.Common.BaseForm Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public WeifenLuo.WinFormsUI.Docking.DockPanel Parentdockpanel
        {
            get { return parentdockpanel; }
            set { parentdockpanel = value; }
        }
    }
}
