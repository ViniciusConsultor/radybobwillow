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
using WeifenLuo.WinFormsUI.Docking;
using Noogen.Validation;

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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ResourceManager fr = new ResourceManager(typeof(FrmMaterialEdit));
            int dc = baseform.Pane.Contents.IndexOf(baseform.Pane.ActiveContent);

            DockContent frm = baseform.FindParentDocument((string)fr.GetObject("$this.Text"));
            if (frm == null)
            {
                BaseForm b = new BaseForm();
                b.Parentdockpanel = this.baseform.Parentdockpanel;
                b.TopLevel = false;
                b.Text = (string)fr.GetObject("$this.Text");
              

                FrmMaterialEdit frmMaterialEdit = new FrmMaterialEdit(this.baseform,b);

                if (dc == baseform.Pane.Contents.Count- 1)
                {
                    frmMaterialEdit.Show(b.dockPanel);
                    b.Show(b.Parentdockpanel);
                }
                else
                {
                    frmMaterialEdit.Show(b.dockPanel);
                    b.Show(baseform.Pane, baseform.Pane.Contents[dc + 1]);
                }
                frmMaterialEdit.BringToFront();


            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
            //如果画面跳转后自己画面要关闭的话，用下面两句话，关闭自画面
            //IDockContent content = (IDockContent)baseform.Pane.Contents[dc];
            //content.DockHandler.Close();
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

        private void conditionDropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.conditionDropDownList1.Selectedindex.ToString() + ":" + this.conditionDropDownList1.Selectedvalue + ":" + this.conditionDropDownList1.Selectedname);
        }
    }
}
