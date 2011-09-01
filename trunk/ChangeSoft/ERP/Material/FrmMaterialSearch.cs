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
using Com.ChangeSoft.Control.PagerGridView;
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

            string sql = @"select LANGID,FUNCTIONID,FUNCTIONNAME,
                                                        FUNCTIONPATH,CATALOGID,FUNCTIONINDEX,FUNCTIONIMAGE 
                                                        FROM M_FUNCTION WHERE LANGID=@LANGID";
            IList<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@LANGID", LangUtils.GetCurrentLanguage());
            paralist.Add(para);
            this.pagerGridView1.Pagerhelper = new PagerHelper(sql,"FUNCTION",paralist,0,10);
            this.pagerGridView1.LoadData();
            this.pagerGridView1.SetColumnAlias("LANGID", "语言");
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}
