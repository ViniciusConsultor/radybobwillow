using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.ChangeSoft.Common;
using Com.ChangeSoft.ERP.Entity.Dao;
using Com.ChangeSoft.Common.Control.PagerGridView;
using System.Data.SqlClient;
using Com.ChangeSoft.Common.Office2007Renderer;
using System.Resources;

namespace Com.ChangeSoft.ERP.Material
{
    public partial class FrmMaterialSearch : BaseContent
    {
        ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmMaterialSearch));

        public FrmMaterialSearch(BaseForm _baseform):base(_baseform)
        {
            InitializeComponent();
            ToolStripManager.Renderer = new Office2007Renderer();
            this.toolStripButton1.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("Add");
            this.toolStripButton2.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("Edit");
            this.toolStripButton3.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("Delete");

            this.button1.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button2.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button4.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");

            SearchCondition condition = new SearchCondition();
            condition.AddCondition("LANGID", LangUtils.GetCurrentLanguage(), SqlOperator.Equal);

            this.FrmMaterialSearch_pagerGridView1.Pagerhelper = new PagerHelper("CFunctionAllPagerDao", condition, 1, 5);
            this.FrmMaterialSearch_pagerGridView1.LoadData();

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

           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void pagerGridView1_Load(object sender, EventArgs e)
        {

        }
    }
}
