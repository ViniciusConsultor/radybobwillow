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
            this.dataGridView1.DataMember = pagerhelper.Key;

            this.lblStatus.Text = pagerhelper.CurrentPage.ToString() + " / " + pagerhelper.Totalpages.ToString();
            this.lblTotalRecords.Text = pagerhelper.Totalrecords.ToString();

            this.pagerhelper.CurrentPageFirst = (this.pagerhelper.CurrentPage - 1) * this.pagerhelper.PagerSize + 1;
            this.pagerhelper.CurrentPageLast = (this.pagerhelper.CurrentPage - 1) * this.pagerhelper.PagerSize + this.pagerhelper.PagerSize;

            this.lblCurrentPageFirst.Text = pagerhelper.CurrentPageFirst.ToString();
            this.lblCurrentPageLast.Text = pagerhelper.CurrentPageLast.ToString();
            if (this.pagerhelper.CurrentPage == 1 && this.pagerhelper.Totalpages == 1)
            {
                this.btnPrevious.Enabled = false;
                this.btnFirst.Enabled = false;
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }else if (this.pagerhelper.CurrentPage == 1)
            {
                this.btnPrevious.Enabled = false;
                this.btnFirst.Enabled = false;
                this.btnNext.Enabled = true;
                this.btnLast.Enabled = true;

            }
            else if (this.pagerhelper.CurrentPage == this.pagerhelper.Totalpages)
            {
                this.btnPrevious.Enabled = true;
                this.btnFirst.Enabled = true;
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;

            }
            else
            {
                this.btnPrevious.Enabled = true;
                this.btnFirst.Enabled = true;
                this.btnNext.Enabled = true;
                this.btnLast.Enabled = true;

            }

        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            goFirst();

        }



        private void goFirst()
        {
            this.pagerhelper.CurrentPage = 1;

            this.pagerhelper.Totalrecords = this.pagerhelper.GetCount();
            this.pagerhelper.Totalpages = this.pagerhelper.Totalrecords / this.pagerhelper.PagerSize;
            // Adjust page count if the last page contains partial page.
            if (this.pagerhelper.Totalrecords % this.pagerhelper.PagerSize > 0)
                this.pagerhelper.Totalpages++;

            LoadData();
        }

        private void goPrevious()
        {

            this.pagerhelper.CurrentPage--;

            if (this.pagerhelper.CurrentPage < 1)
                this.pagerhelper.CurrentPage = 1;

            this.pagerhelper.Totalrecords = this.pagerhelper.GetCount();
            this.pagerhelper.Totalpages = this.pagerhelper.Totalrecords / this.pagerhelper.PagerSize;
            // Adjust page count if the last page contains partial page.
            if (this.pagerhelper.Totalrecords % this.pagerhelper.PagerSize > 0)
                this.pagerhelper.Totalpages++;

            LoadData();
        }

        private void goNext()
        {
            this.pagerhelper.CurrentPage++;

            this.pagerhelper.Totalrecords = this.pagerhelper.GetCount();
            this.pagerhelper.Totalpages = this.pagerhelper.Totalrecords / this.pagerhelper.PagerSize;
            // Adjust page count if the last page contains partial page.
            if (this.pagerhelper.Totalrecords % this.pagerhelper.PagerSize > 0)
                this.pagerhelper.Totalpages++;

            if (this.pagerhelper.CurrentPage > (this.pagerhelper.Totalpages))
                this.pagerhelper.CurrentPage = this.pagerhelper.Totalpages;

            LoadData();
        }

        private void goLast()
        {
            this.pagerhelper.Totalrecords = this.pagerhelper.GetCount();
            this.pagerhelper.Totalpages = this.pagerhelper.Totalrecords / this.pagerhelper.PagerSize;
            // Adjust page count if the last page contains partial page.
            if (this.pagerhelper.Totalrecords % this.pagerhelper.PagerSize > 0)
                this.pagerhelper.Totalpages++;

            this.pagerhelper.CurrentPage = this.pagerhelper.Totalpages;

            LoadData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            goPrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            goNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            goLast();
        }


       
    }
}
