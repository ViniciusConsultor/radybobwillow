using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;
using log4net;

namespace Com.GainWinSoft.Common.Control.PagerGridView
{
    public partial class PagerGridView : UserControl
    {

        private PagerHelper pagerhelper;

        private static readonly ILog log = LogManager.GetLogger(typeof(PagerGridView));

        private IList<ColumnInfoVo> columninfolist;

        public delegate void OnSelectionChangedEventHandler(object sender, EventArgs e);
        public event OnSelectionChangedEventHandler SelectionChanged;


        public event EventHandler DoubleClick;
        public event EventHandler Click;

        public PagerGridView()
        {
            InitializeComponent();

        }

        protected virtual void OnSelectionChanged(Object sender, EventArgs e)
        {//事件触发方法  
            if (SelectionChanged != null)
            {//判断事件是否为空  
                log.Debug("OnSelectionChanged");
                SelectionChanged(this, e);//触发事件  
            }
        }

        protected virtual void OnDoubleClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (DoubleClick != null)
            {//判断事件是否为空  

                DoubleClick(this, e);//触发事件  
            }
        }

        protected virtual void OnClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (Click != null)
            {//判断事件是否为空  

                Click(this, e);//触发事件  
            }
        }


        public IList<ColumnInfoVo> Columninfolist
        {
            get { return columninfolist; }
            set { columninfolist = value; }
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

        public int RowCount
        {
            get { return this.dataGridView1.RowCount; }
        }

        public DataGridViewSelectedRowCollection SelecteRows
        {
            get { return this.dataGridView1.SelectedRows; }
        }

        public int SelectedRowIndex
        {
            get {
                int index = -1;
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    index = this.dataGridView1.SelectedRows[0].Index;
                }
                return index;
            }
        }

        public void SetSelectedRow(int index)
        {
            this.dataGridView1.Rows[index].Selected = true;
        }

        public void SetColumnAlias(string key, string name)
        {
            this.dataGridView1.Columns[key].HeaderText = name;

        }

        public void SetDisplayColumns(string filename, IList<ColumnInfoVo> defaultcolumns)
        {

            //先判断本地有没有保存的文件

            string filepath = "temp\\"+this.Name+".xml";
            if (System.IO.File.Exists(filepath))
            {
                //foreach (DataGridViewColumn dc in this.dataGridView1.Columns)
                //{
                //    dc.Visible = false;
                //}
                //解析xml
                ParseXml(filepath);

            }
            else
            {

                if (defaultcolumns != null)
                {
                    foreach (DataGridViewColumn dc in this.dataGridView1.Columns)
                    {
                        dc.Visible = false;
                    }
                    foreach (ColumnInfoVo vo in defaultcolumns)
                    {

                        this.dataGridView1.Columns[vo.Columnname].Visible = true;
                    }
                }
            }


        }

        private void ParseXml(string filepath)
        {
            XmlReader reader = new XmlTextReader(filepath);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);

            XmlNode root = doc.DocumentElement;
            XmlNodeList columnlist = root.SelectNodes("Column");
            foreach (XmlNode columnnode in columnlist)
            {
                ColumnInfoVo vo = new ColumnInfoVo();
                string headertext = columnnode.SelectSingleNode("ColumnHeaderText").InnerText;
                string displayindex = columnnode.SelectSingleNode("ColumnDisplayIndex").InnerText;
                string columnname = columnnode.SelectSingleNode("ColumnName").InnerText;
                string columnwidth = columnnode.SelectSingleNode("ColumnWidth").InnerText;
                string columnvisible = columnnode.SelectSingleNode("ColumnVisible").InnerText;
                vo.Columnheadertext = headertext;
                vo.Columndisplayindex = Convert.ToInt32(displayindex);
                vo.Columnname = columnname;
                vo.Columnwidth = Convert.ToInt32(columnwidth);
                vo.Columnvisible = Convert.ToBoolean(columnvisible);

                SetColumnAttribute(vo);
            }

            reader.Close();
        }

        public PagerHelper Pagerhelper
        {
            get { return pagerhelper; }
            set { pagerhelper = value; }
        }

        public void InitGridView(DataTable defaultdataTable)
        {
            this.dataGridView1.DataSource = defaultdataTable;
            this.lblStatus.Text = "";
            this.lblTotalRecords.Text = "";
            this.lblCurrentPageFirst.Text = "";
            this.lblCurrentPageLast.Text = "";

        }


        public void LoadData()
        {

            //this.dataGridView1.SelectionChanged -= new EventHandler(OnSelectionChanged);
            //this.dataGridView1.Click -= new EventHandler(OnClick);
            //this.dataGridView1.DoubleClick -= new EventHandler(OnDoubleClick);

            this.dataGridView1.DataSource = pagerhelper.GetDataSet();
            this.dataGridView1.DataMember = pagerhelper.Key;
            
            //this.dataGridView1.SelectionChanged += new EventHandler(OnSelectionChanged);
            
            log.Debug("Loaddata");


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
            }
            else if (this.pagerhelper.CurrentPage == 1)
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

        private void ColumnsSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            IList<ColumnInfoVo> clist = new List<ColumnInfoVo>();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                ColumnInfoVo vo = new ColumnInfoVo();
                vo.Columnheadertext = col.HeaderText;
                vo.Columndisplayindex = col.DisplayIndex;
                vo.Columnname = col.Name;
                vo.Columnwidth = col.Width;
                vo.Columnvisible = col.Visible;
                clist.Add(vo);

            }
            FrmColumnsSetting f = new FrmColumnsSetting(clist);
            DialogResult r = f.ShowDialog(this);
            if (r.CompareTo(DialogResult.OK) == 0)
            {
                string filepath = "temp\\" + this.Name + ".xml";
                if (System.IO.File.Exists(filepath))
                {

                    File.Delete(filepath);
                    CreateXml(clist, filepath);
                }
                else
                {
                    //创建列显示定义XML文件
                    CreateXml(clist, filepath);



                }
            }



        }

        private void CreateXml(IList<ColumnInfoVo> clist, string filepath)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            XmlElement root = doc.CreateElement("PagerGridView");
            doc.AppendChild(root);
            foreach (ColumnInfoVo vo in clist)
            {
                SetColumnAttribute(vo);

                XmlNode node = doc.CreateElement("Column");
                XmlElement element1 = doc.CreateElement("ColumnHeaderText");
                element1.InnerText = vo.Columnheadertext;
                node.AppendChild(element1);

                XmlElement element2 = doc.CreateElement("ColumnDisplayIndex");
                element2.InnerText = vo.Columndisplayindex.ToString();
                node.AppendChild(element2);

                XmlElement element3 = doc.CreateElement("ColumnName");
                element3.InnerText = vo.Columnname;
                node.AppendChild(element3);

                XmlElement element4 = doc.CreateElement("ColumnWidth");
                element4.InnerText = vo.Columnwidth.ToString();
                node.AppendChild(element4);

                XmlElement element5 = doc.CreateElement("ColumnVisible");
                element5.InnerText = vo.Columnvisible.ToString();
                node.AppendChild(element5);

                root.AppendChild(node);

            }
            if (!Directory.Exists("temp"))
            {
                Directory.CreateDirectory("temp");
            }
            doc.Save(filepath);
        }

        private void SetColumnAttribute(ColumnInfoVo vo)
        {
            dataGridView1.Columns[vo.Columnname].Visible = vo.Columnvisible;
            dataGridView1.Columns[vo.Columnname].Width = vo.Columnwidth;
            dataGridView1.Columns[vo.Columnname].DisplayIndex = vo.Columndisplayindex;
            dataGridView1.Columns[vo.Columnname].HeaderText = vo.Columnheadertext;
        }

        private void PagerGridView_Load(object sender, EventArgs e)
        {
            
            
            if (IsDesignMode())
                return;

            this.dataGridView1.SelectionChanged += new EventHandler(OnSelectionChanged);
            this.dataGridView1.Click += new EventHandler(OnClick);
            this.dataGridView1.DoubleClick += new EventHandler(OnDoubleClick);

        }


        public static bool IsDesignMode()
        {

            bool returnFlag = false;



#if DEBUG

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {

                returnFlag = true;

            }

            else if (Process.GetCurrentProcess().ProcessName == "devenv")
            {

                returnFlag = true;

            }

#endif



            return returnFlag;

        }




    }
}
