using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.ERP.Company;
using Com.GainWinSoft.ERP.ProductPlan;
using Com.GainWinSoft.ERP.Material;
using System.Windows.Forms;
using Com.GainWinSoft.ERP.Factory;
using Com.GainWinSoft.ERP.ExchangeRate;
using Com.GainWinSoft.Common;
using log4net;

namespace Com.GainWinSoft.ERP
{
    public class MenuTransfer : Form
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(MenuTransfer));

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
            Cursor = Cursors.WaitCursor;

            DockContent frm = this.FindDocument(title);
            if (frm == null)
            {
                IRepositoryFactory factory = ComponentLocator.Instance().Resolve<IRepositoryFactory>();

                IBaseContent frmNewConent = null;
                try
                {
                    frmNewConent = factory.Create(path);
                    //BaseContent frmNewConent = (BaseContent)ComponentLocator.Instance().Resolve(path, typeof(BaseContent));
                    frmNewConent.DockTitle = title;
                    frmNewConent.Parentdockpanel = parentpanel;
                    frmNewConent.ShowContent(false);
                }
                catch (Exception ex)
                {
                    log.Info(ex.Message);
                }

                //ComponentLocator.Instance().Release(frmNewConent);

            }
            else
            {
                frm.Show(parentpanel);
                frm.BringToFront();
            }

//            #region ***ExchangeRade 利率管理***
//            if ("FExchangeRate".Equals(path))
//            {
//                DockContent frm = this.FindDocument(title);
//                if (frm == null)
//                {
//                    FrmExchangeRate frmExchangeRate = new FrmExchangeRate(parentpanel);
//                    frmExchangeRate.DockTitle = title;
//                    frmExchangeRate.ShowContent(false);
//                }
//                else
//                {
//                    frm.Show(parentpanel);
//                    frm.BringToFront();
//                }
//            }
//            #endregion
//
//            if ("FCompany".Equals(path))
//            {
//                DockContent frm = this.FindDocument(title);
//                if (frm == null)
//                {
//                    FrmCompany frmcompany = new FrmCompany(parentpanel);
//                    frmcompany.DockTitle = title;
//                    frmcompany.ShowContent(false);
//                }
//                else
//                {
//                    frm.Show(parentpanel);
//                    frm.BringToFront();
//                }
//
//                //DockContent frm = this.FindDocument(e.Node.Text);  // FindDocument(e.Node.Text);
//                //if (frm == null)
//                //{
//                //    FrmCompany frmcompany = new FrmCompany(baseform);
//                //    frmcompany.Show(baseform.dockPanel, DockState.Document);
//                //    frmcompany.BringToFront();
//                //    baseform.Show(this.dockpanel);
//
//                //}
//                //else
//                //{
//                //    frm.Show(this.dockpanel);
//                //    frm.BringToFront();
//                //}
//            }
//            if ("FQuotationEntry".Equals(path))
//            {
//                DockContent frm = this.FindDocument(title);
//                if (frm == null)
//                {
//
//                    FrmProductPlan frmproductplan = new FrmProductPlan(parentpanel);
//                    frmproductplan.DockTitle = title;
//                    frmproductplan.ShowContent(false);
//                }
//                else
//                {
//                    frm.Show(parentpanel);
//                    frm.BringToFront();
//                }
//
//
//            }
//
//            #region 物料管理
//            if ("FMaterial".Equals(path))
//            {
//
//                DockContent frm = this.FindDocument(title);  // FindDocument(e.Node.Text);
//                if (frm == null)
//                {
//                    FrmMaterialSearch frmMaterialSearch = new FrmMaterialSearch(parentpanel);
//                    frmMaterialSearch.DockTitle = title;
//                    frmMaterialSearch.ShowContent(false);
//                }
//                else
//                {
//                    frm.Show(parentpanel);
//                    frm.BringToFront();
//                }
//
//
//            }
//            #endregion
//
//            if ("FFactory".Equals(path))
//            {
//                DockContent frm = this.FindDocument(title);  // FindDocument(e.Node.Text);
//                if (frm == null)
//                {
//                    FrmFactory frmFactory = new FrmFactory(parentpanel);
//                    frmFactory.DockTitle = title;
//                    frmFactory.ShowContent(false);
//                }
//                else
//                {
//                    frm.Show(parentpanel);
//                    frm.BringToFront();
//                }
//            }
//


            Cursor = Cursors.Default;

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
