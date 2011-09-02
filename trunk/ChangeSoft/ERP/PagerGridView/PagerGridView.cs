using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Com.ChangeSoft.Common.Control.PagerGridView
{
    public partial class PagerGridView : UserControl
    {

        private PagerHelper pagerhelper;

 

        public PagerGridView()
        {
            InitializeComponent();
           
        }
        public object DataSource
        {
            get { return this.dataGridView1.DataSource; }
            set
            {
                this.dataGridView1.DataSource = value;
            }
        }
        public string DataMember
        {
            get { return this.dataGridView1.DataMember; }
            set
            {
                this.dataGridView1.DataMember = value;
            }
        }

        public void SetColumnAlias(string key, string name)
        {
            this.dataGridView1.Columns[key].HeaderText = name;

        }

        public PagerHelper Pagerhelper
        {
            get { return pagerhelper; }
            set { pagerhelper = value; }
        }
        public void LoadData()
        {
            this.dataGridView1.DataSource=pagerhelper.GetDataSet();
            this.dataGridView1.DataMember = pagerhelper.Tablename;

        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            

        }

       
    }
}
