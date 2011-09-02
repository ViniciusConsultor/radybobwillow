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

namespace Com.ChangeSoft.ERP.Material
{
    public partial class FrmMaterialSearch : BaseContent
    {
        public FrmMaterialSearch(BaseForm _baseform):base(_baseform)
        {
            InitializeComponent();
            this.toolStripButton1.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("Add");
            this.toolStripButton2.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("Edit");
            this.toolStripButton3.Image = (Image)Com.ChangeSoft.Common.ResourcesUtils.GetResource("Delete");



            SearchCondition condition = new SearchCondition();
            condition.AddCondition("LANGID",LangUtils.GetCurrentLanguage(),SqlOperator.Equal);

            this.pagerGridView1.Pagerhelper = new PagerHelper("CFunctionAllPagerDao",condition,1,5);
            this.pagerGridView1.LoadData();
            this.pagerGridView1.SetColumnAlias("LANGID", "语言");
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}
