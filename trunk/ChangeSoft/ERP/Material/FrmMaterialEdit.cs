using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.ChangeSoft.Common;

namespace Com.ChangeSoft.ERP.Material
{
    public partial class FrmMaterialEdit : Com.ChangeSoft.Common.BaseContent
    {
        public FrmMaterialEdit(BaseForm _baseform):base(_baseform)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
