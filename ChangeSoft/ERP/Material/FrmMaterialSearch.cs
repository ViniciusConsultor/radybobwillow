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

namespace Com.GainWinSoft.ERP.Material
{
    public partial class FrmMaterialSearch : BaseContent
    {
        ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmMaterialSearch));
        private static readonly ILog log = LogManager.GetLogger(typeof(FrmMaterialSearch));

        public FrmMaterialSearch(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
            ToolStripManager.Renderer = new Office2007Renderer();

            this.btnFactoryHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button2.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button4.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");

            SearchCondition condition = new SearchCondition();
            condition.AddCondition("LANGID", LangUtils.GetCurrentLanguage(), SqlOperator.Equal);

            this.FrmMaterialSearch_pagerGridView1.Pagerhelper = new PagerHelper("CFunctionPagerNoARDao", condition, 1, 5);
            this.FrmMaterialSearch_pagerGridView1.LoadData();
            log.Debug("Search Init");
            //设置列名
            foreach (string key in this.FrmMaterialSearch_pagerGridView1.Pagerhelper.Columns)
            {
                this.FrmMaterialSearch_pagerGridView1.SetColumnAlias(key, (string)rm.GetObject(key));
            }
            
            //设置可视列
            IList<ColumnInfoVo> clist = new List<ColumnInfoVo>();
            ColumnInfoVo columnvo = new ColumnInfoVo();
            columnvo.Columnname="Grid_functionid";
            columnvo.Columnwidth=100;
            clist.Add(columnvo);
            columnvo=new ColumnInfoVo();
            columnvo.Columnname="Grid_functionname";
            columnvo.Columnwidth=200;
            clist.Add(columnvo);

            this.FrmMaterialSearch_pagerGridView1.SetDisplayColumns(this.FrmMaterialSearch_pagerGridView1.Name,null);
            //this.tableLayoutPanel1.Enabled = false;
            //commonToolStrip1.AddEnabled = false;
            //commonToolStrip1.UpdateEnabled = false;
            //commonToolStrip1.DeleteEnabled = false;
            //commonToolStrip1.SaveEnabled = false;
            //commonToolStrip1.CopyEnabled = false;
            //commonToolStrip1.ReportEnabled = false;
            //commonToolStrip1.CsvEnabled = false;
            //commonToolStrip1.GobackEnabled = false;
            //commonToolStrip1.OkEnabled = false;
            //commonToolStrip1.ExitEnabled = false;
            //commonToolStrip1.HelpEnabled = false;
            //commonToolStrip1.AddVisible = false;
            //commonToolStrip1.UpdateVisible = false;
            //commonToolStrip1.DeleteVisible = false;
            //commonToolStrip1.SaveVisible = false;
            //commonToolStrip1.CopyVisible = false;
            //commonToolStrip1.ReportVisible = false;
            //commonToolStrip1.CsvVisible = false;
            //commonToolStrip1.GobackVisible = false;
            //commonToolStrip1.OkVisible = false;
            //commonToolStrip1.ExitVisible = false;
            //commonToolStrip1.HelpVisible = false;
            //commonToolStrip1.Line1Visible = false;
            //commonToolStrip1.Line2Visible = false;
            //commonToolStrip1.Line3Visible = false;
            //commonToolStrip1.Line4Visible = false;




           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void pagerGridView1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TransferTo();
        }

        private void TransferTo()
        {

            FrmMaterialEdit frmMaterialEdit = new FrmMaterialEdit(this.baseform.Parentdockpanel, this.baseform);
            ResourceManager fr = new ResourceManager(typeof(FrmMaterialEdit));
            frmMaterialEdit.DockTitle = frmMaterialEdit.Text;
            frmMaterialEdit.ShowContent(false);
 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IList<MessageVo> re = new List<MessageVo>();
            MessageVo v = new MessageVo();
            v.MessageType = "Warning";
            v.ResultMessage = "ddddddddddd";
            re.Add(v);
            this.baseform.msgwindow.Messagelist = re;
            this.baseform.msgwindow.ShowMessage();
        }


        private void FrmMaterialSearch_pagerGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.FrmMaterialSearch_pagerGridView1.SelectedRowIndex.ToString()+":"+this.FrmMaterialSearch_pagerGridView1.SelecteRows.ToString());
        }

        private void commonToolStrip1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString() );
        }
    }
}
