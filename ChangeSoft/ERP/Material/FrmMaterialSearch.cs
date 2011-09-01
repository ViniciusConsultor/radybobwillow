using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.ChangeSoft.Common;
using WHC.Pager.Entity;

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

            this.winGridViewPager1.PagerInfo.PageSize = 30;//页面大小
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}
