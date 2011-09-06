using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using Com.ChangeSoft.ERP.Company;
using Com.ChangeSoft.ERP.ProductPlan;
using Com.ChangeSoft.ERP.Material;
using System.Windows.Forms;

namespace Com.ChangeSoft.ERP
{
    public class MenuTransfer : Form
    {
        private string path;
        private string title;
        private DockPanel parentpanel;

        public MenuTransfer(string path, string title, DockPanel parentpanel)
        {
            this.path = path;
            this.title = title;
            this.parentpanel = parentpanel;
        }
        public void Parse()
        {
            if ("FCompany".Equals(path))
            {
                DockContent frm = this.FindDocument(title);
                if (frm == null)
                {
                    FrmCompany frmcompany = new FrmCompany(parentpanel);
                    frmcompany.DockTitle = title;
                    frmcompany.ShowContent(false);
                }
                else
                {
                    frm.Show(parentpanel);
                    frm.BringToFront();
                }

                //DockContent frm = this.FindDocument(e.Node.Text);  // FindDocument(e.Node.Text);
                //if (frm == null)
                //{
                //    FrmCompany frmcompany = new FrmCompany(baseform);
                //    frmcompany.Show(baseform.dockPanel, DockState.Document);
                //    frmcompany.BringToFront();
                //    baseform.Show(this.dockpanel);

                //}
                //else
                //{
                //    frm.Show(this.dockpanel);
                //    frm.BringToFront();
                //}
            }
            if ("FQuotationEntry".Equals(path))
            {
                DockContent frm = this.FindDocument(title);
                if (frm == null)
                {

                    FrmProductPlan frmproductplan = new FrmProductPlan(parentpanel);
                    frmproductplan.DockTitle = title;
                    frmproductplan.ShowContent(false);
                }
                else
                {
                    frm.Show(parentpanel);
                    frm.BringToFront();
                }
                //DockContent frm = this.FindDocument(e.Node.Text);  // FindDocument(e.Node.Text);
                //if (frm == null)
                //{
                //    FrmProductPlan frmproductplan = new FrmProductPlan(baseform);

                //    frmproductplan.Show(baseform.dockPanel, DockState.Document);
                //    baseform.Show(this.dockpanel);
                //}
                //else
                //{
                //    frm.Show(this.dockpanel);
                //    frm.BringToFront();
                //}

            }
            if ("FMaterial".Equals(path))
            {

                DockContent frm = this.FindDocument(title);  // FindDocument(e.Node.Text);
                if (frm == null)
                {
                    FrmMaterialSearch frmMaterialSearch = new FrmMaterialSearch(parentpanel);
                    frmMaterialSearch.DockTitle = title;
                    frmMaterialSearch.ShowContent(false);
                }
                else
                {
                    frm.Show(parentpanel);
                    frm.BringToFront();
                }
                //DockContent frm = this.FindDocument(e.Node.Text);  // FindDocument(e.Node.Text);
                //if (frm == null)
                //{
                //    FrmMaterialSearch frmMaterialSearch = new FrmMaterialSearch(baseform);

                //    frmMaterialSearch.Show(baseform.dockPanel, DockState.Document);
                //    baseform.Show(this.dockpanel);
                //}
                //else
                //{
                //    frm.Show(this.dockpanel);
                //    frm.BringToFront();
                //}

            }
            //if ("FFactory".Equals(e.Node.Tag.ToString()))
            //{
            //    DockContent frm = this.FindDocument(e.Node.Text);  // FindDocument(e.Node.Text);
            //    if (frm == null)
            //    {
            //        FrmFactory frmFactory = new FrmFactory(baseform);

            //        frmFactory.Show(baseform.dockPanel, DockState.Document);
            //        baseform.Show(this.dockpanel);
            //    }
            //    else
            //    {
            //        frm.Show(this.dockpanel);
            //        frm.BringToFront();
            //    }

            //}

        }

        private DockContent FindDocument(string text)
        {
            if (parentpanel.DocumentStyle == DocumentStyle.SystemMdi)
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
                foreach (DockContent content in parentpanel.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }

        private DockContent ShowContent(string caption, Type formType)
        {
            DockContent frm = FindDocument(caption);
            //if (frm == null)
            //{
            //    frm = ChildWinManagement.LoadMdiForm(Portal.gc.MainDialog, formType) as DockContent;
            //}

            frm.Show(parentpanel);
            frm.BringToFront();
            return frm;
        }
    }
}
