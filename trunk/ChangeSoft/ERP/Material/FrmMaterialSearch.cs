using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.Common.Control.PagerGridView;
using System.Data.SqlClient;
using Com.GainWinSoft.Common.Office2007Renderer;
using System.Resources;
using WeifenLuo.WinFormsUI.Docking;
using Noogen.Validation;
using log4net;
using Com.GainWinSoft.ERP.CodeRef;
using Com.GainWinSoft.Common.Vo;
using Com.GainWinSoft.ERP.Material.Action;
using Com.GainWinSoft.ERP.Material.FormVo;

namespace Com.GainWinSoft.ERP.Material
{
    public partial class FrmMaterialSearch : BaseContent
    {
        private ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmMaterialSearch));
        private static readonly ILog log = LogManager.GetLogger(typeof(FrmMaterialSearch));
        private LoginUserInfoVo uservo;
        
        private int currentGroup = 1;
        private int firstGroup = 1;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_parentdockpanel"></param>
        public FrmMaterialSearch(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
            ToolStripManager.Renderer = new Office2007Renderer();

            this.btnFactoryHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.btnCustomerHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.btnMakerHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.btnItemTypeHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");

        }
        /// <summary>
        /// 画面跳转到编辑画面
        /// </summary>
        private void TransferTo()
        {

            FrmMaterialEdit frmMaterialEdit = new FrmMaterialEdit(this.baseform.Parentdockpanel, this.baseform);
            ResourceManager fr = new ResourceManager(typeof(FrmMaterialEdit));
            frmMaterialEdit.DockTitle = frmMaterialEdit.Text;
            frmMaterialEdit.ShowContent(false);

        }


        private void FrmMaterialSearch_pagerGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.FrmMaterialSearch_pagerGridView1.SelectedRowIndex.ToString()+":"+this.FrmMaterialSearch_pagerGridView1.SelecteRows.ToString());
        }


        private void btnItemTypeHelper_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefClsDetail cr = new CodeRef.CodeRefClsDetail("79");
            cr.AddValueControl(this.txtItemType);
            cr.AddNameControl(this.lblItemType);
            cr.ShowDialog(this);
            this.txtItemType.Focus();

        }

        private void btnMakerHelper_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefClsDetail cr = new CodeRef.CodeRefClsDetail("72");
            cr.AddValueControl(this.txtMakerCd);
            cr.AddNameControl(this.lblMakerNm);
            cr.ShowDialog(this);
            this.txtMakerCd.Focus();
        }



        private void commonToolStrip1_ExitClick(object sender, EventArgs e)
        {
            this.CloseContent();
        }

        private void btnFactoryHelper_Click(object sender, EventArgs e)
        {

            CodeRef.CodeRefFactory cr = new CodeRef.CodeRefFactory(uservo.CompanyCondition.ICompanyCd);
            cr.AddValueControl(this.txtFactoryCd);
            cr.AddNameControl(this.lblFactoryNm);
            cr.ShowDialog(this);
            this.txtFactoryCd.Focus();

        }

        private void FrmMaterialSearch_Load(object sender, EventArgs e)
        {
            IAction_MaterialSearch action = ComponentLocator.Instance().Resolve<IAction_MaterialSearch>();
            action.Init_GridView(this.FrmMaterialSearch_pagerGridView1);

            uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);

            if (uservo.Factory != null)
            {
                FactoryVo factoryvo = uservo.Factory;
                this.txtFactoryCd.Text = factoryvo.IFacCd;
                this.lblFactoryNm.Text = factoryvo.IFacDesc;
                this.tlpG1.Enabled = false;
                this.tlpG2.Enabled = true;
                this.tlpG3.Enabled = false;
                this.txtCustomerCd.Focus();
                this.firstGroup = 2;
                this.currentGroup = 2;
            }
            else
            {
                this.tlpG1.Enabled = true;
                this.txtFactoryCd.Focus();
                this.firstGroup = 1;
                this.currentGroup = 1;
            }
            SetCommonToolstrip();
            SetGroupLayout();

        }

        /// <summary>
        /// 控制组的状态
        /// </summary>
        public void SetGroupLayout()
        {
            if (currentGroup == 1)
            {
                this.tlpG1.Enabled = true;
                this.tlpG2.Enabled = false;
                this.tlpG3.Enabled = false;

            }

            if (currentGroup == 2)
            {
                this.tlpG1.Enabled = false;
                this.tlpG2.Enabled = true;
                this.tlpG3.Enabled = false;

            }
            if (currentGroup == 3)
            {
                this.tlpG1.Enabled = false;
                this.tlpG2.Enabled = false;
                this.tlpG3.Enabled = true;

            }

        }
        /// <summary>
        /// 根据组迁移不同，控制CommonToolStrip的状态
        /// </summary>
        public void SetCommonToolstrip()
        {
            if (currentGroup == firstGroup)
            {
                this.commonToolStrip1.GobackEnabled = false;
                this.commonToolStrip1.UpdateEnabled = false;
                this.commonToolStrip1.DeleteEnabled = false;
                this.commonToolStrip1.OkEnabled = true;
            }
            if (currentGroup == 3)
            {
                this.commonToolStrip1.UpdateEnabled = true;
                this.commonToolStrip1.DeleteEnabled = true;
                this.commonToolStrip1.GobackEnabled = true;
                this.commonToolStrip1.OkEnabled = false;
            }
            if (currentGroup == 2 && firstGroup == 1)
            {
                this.commonToolStrip1.UpdateEnabled = false;
                this.commonToolStrip1.DeleteEnabled = false;
                this.commonToolStrip1.GobackEnabled = true;
                this.commonToolStrip1.OkEnabled = true;

            }

        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            Data_Inquiry();

        }

        private void Data_Inquiry()
        {
            //IList<MessageVo> re = new List<MessageVo>();
            //MessageVo v = new MessageVo();
            //v.MessageType = "Warning";
            //v.ResultMessage = "ddddddddddd";
            //re.Add(v);
            //this.baseform.msgwindow.Messagelist = re;
            //this.baseform.msgwindow.ShowMessage();
            this.Cursor = Cursors.WaitCursor;
            CardVo cardvo = new CardVo();
            cardvo.IFacCd = this.txtFactoryCd.Text;

            IAction_MaterialSearch action = ComponentLocator.Instance().Resolve<IAction_MaterialSearch>();
            action.GetPmMsDetail(this.FrmMaterialSearch_pagerGridView1, cardvo);
            this.FrmMaterialSearch_pagerGridView1.Focus();

            this.Cursor = Cursors.Default;
        }

        private void btnCustomerHelper_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefTradeForMaterial cr = new CodeRef.CodeRefTradeForMaterial(uservo.CompanyCondition.ICompanyCd);
            cr.AddValueControl(this.txtCustomerCd);
            cr.AddNameControl(this.lblCustomer);
            cr.ShowDialog(this);
            this.txtCustomerCd.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void commonToolStrip1_GobackClick(object sender, EventArgs e)
        {
            if (currentGroup == 3)
            {
                IAction_MaterialSearch action = ComponentLocator.Instance().Resolve<IAction_MaterialSearch>();
                action.Init_GridView(this.FrmMaterialSearch_pagerGridView1);
            }
            currentGroup--;
            this.SetCommonToolstrip();
            this.SetGroupLayout();

        }

        /// <summary>
        /// OK按钮按下的时候根据当前不同的组做不同的事
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commonToolStrip1_OkClick(object sender, EventArgs e)
        {
            if (currentGroup == 1)
            {
                //check group1

            }
            if (currentGroup == 2)
            {
                //check group2

                Data_Inquiry();
            }

            currentGroup++;
            this.SetCommonToolstrip();
            this.SetGroupLayout();
        }
    }
}
