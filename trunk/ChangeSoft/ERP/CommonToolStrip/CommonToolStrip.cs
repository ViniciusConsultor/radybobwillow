using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.Common.Control.CommonToolStrip.Properties;
using System.Resources;

namespace Com.GainWinSoft.Common.Control.CommonToolStrip
{
    public partial class CommonToolStrip : UserControl
    {

        private ToolStripButton item_add = new ToolStripButton();
        private ToolStripButton item_update = new ToolStripButton();
        private ToolStripButton item_delete = new ToolStripButton();
        private ToolStripButton item_save = new ToolStripButton();
        private ToolStripSeparator item_separator1 = new ToolStripSeparator();
        private ToolStripButton item_copy = new ToolStripButton();

        private ToolStripSeparator item_separator2 = new ToolStripSeparator();

        private ToolStripButton item_report = new ToolStripButton();
        private ToolStripButton item_csv = new ToolStripButton();
        private ToolStripSeparator item_separator3 = new ToolStripSeparator();

        private ToolStripButton item_goback = new ToolStripButton();
        private ToolStripButton item_ok = new ToolStripButton(); ToolStripButton item_exit = new ToolStripButton();

        private ToolStripButton item_help = new ToolStripButton();
        private ToolStripSeparator item_separator4 = new ToolStripSeparator();

        private ResourceManager rm = new ResourceManager(typeof(CommonToolStrip));

        private bool displaytext = false;

        private bool _addEnabled;

        public bool AddEnabled
        {
            get
            {
                _addEnabled = item_add.Enabled;
                return _addEnabled;
            }
            set
            {
                _addEnabled = value;
                item_add.Enabled = value;
            }
        }
        private bool _updateEnabled;

        public bool UpdateEnabled
        {
            get
            {
                _updateEnabled = item_update.Enabled;
                return _updateEnabled;
            }
            set
            {
                _updateEnabled = value;
                item_update.Enabled = value;
            }
        }
        private bool _deleteEnabled;

        public bool DeleteEnabled
        {
            get
            {
                _deleteEnabled = item_delete.Enabled;
                return _deleteEnabled;
            }
            set
            {
                _deleteEnabled = value;
                item_delete.Enabled = value;
            }
        }
        private bool _saveEnabled;

        public bool SaveEnabled
        {
            get
            {
                _saveEnabled = item_save.Enabled;
                return _saveEnabled;
            }
            set
            {
                _saveEnabled = value;
                item_save.Enabled = value;
            }
        }
        private bool _copyEnabled;

        public bool CopyEnabled
        {
            get
            {
                _copyEnabled = item_copy.Enabled;
                return _copyEnabled;
            }
            set
            {
                _copyEnabled = value;
                item_copy.Enabled = value;
            }
        }
        private bool _reportEnabled;

        public bool ReportEnabled
        {
            get
            {
                _reportEnabled = item_report.Enabled;
                return _reportEnabled;
            }
            set
            {
                _reportEnabled = value;
                item_report.Enabled = value;
            }
        }
        private bool _csvEnabled;

        public bool CsvEnabled
        {
            get
            {
                _csvEnabled = item_csv.Enabled;
                return _csvEnabled;
            }
            set
            {
                _csvEnabled = value;
                item_csv.Enabled = value;
            }
        }
        private bool _gobackEnabled;

        public bool GobackEnabled
        {
            get
            {
                _gobackEnabled = item_goback.Enabled;
                return _gobackEnabled;
            }
            set
            {
                _gobackEnabled = value;
                item_goback.Enabled = value;
            }
        }
        private bool _okEnabled;

        public bool OkEnabled
        {
            get
            {
                _okEnabled = item_ok.Enabled;
                return _okEnabled;
            }
            set
            {
                _okEnabled = value;
                item_ok.Enabled = value;
            }
        }
        private bool _exitEnabled;

        public bool ExitEnabled
        {
            get
            {
                _exitEnabled = item_exit.Enabled;
                return _exitEnabled;
            }
            set
            {
                _exitEnabled = value;
                item_exit.Enabled = value;
            }
        }
        private bool _helpEnabled;

        public bool HelpEnabled
        {
            get
            {
                _helpEnabled = item_help.Enabled;
                return _helpEnabled;
            }
            set
            {
                _helpEnabled = value;
                item_help.Enabled = value;
            }
        }



        private bool _addVisible;

        public bool AddVisible
        {
            get
            {
                _addVisible = item_add.Visible;
                return _addVisible;
            }
            set
            {
                _addVisible = value;
                item_add.Visible = value;
            }
        }
        private bool _updateVisible;

        public bool UpdateVisible
        {
            get
            {
                _updateVisible = item_update.Visible;
                return _updateVisible;
            }
            set
            {
                _updateVisible = value;
                item_update.Visible = value;
            }
        }
        private bool _deleteVisible;

        public bool DeleteVisible
        {
            get
            {
                _deleteVisible = item_delete.Visible;
                return _deleteVisible;
            }
            set
            {
                _deleteVisible = value;
                item_delete.Visible = value;
            }
        }
        private bool _saveVisible;

        public bool SaveVisible
        {
            get
            {
                _saveVisible = item_save.Visible;
                return _saveVisible;
            }
            set
            {
                _saveVisible = value;
                item_save.Visible = value;
            }
        }
        private bool _copyVisible;

        public bool CopyVisible
        {
            get
            {
                _copyVisible = item_copy.Visible;
                return _copyVisible;
            }
            set
            {
                _copyVisible = value;
                item_copy.Visible = value;
            }
        }
        private bool _reportVisible;

        public bool ReportVisible
        {
            get
            {
                _reportVisible = item_report.Visible;
                return _reportVisible;
            }
            set
            {
                _reportVisible = value;
                item_report.Visible = value;
            }
        }
        private bool _csvVisible;

        public bool CsvVisible
        {
            get
            {
                _csvVisible = item_csv.Visible;
                return _csvVisible;
            }
            set
            {
                _csvVisible = value;
                item_csv.Visible = value;
            }
        }
        private bool _gobackVisible;

        public bool GobackVisible
        {
            get
            {
                _gobackVisible = item_goback.Visible;
                return _gobackVisible;
            }
            set
            {
                _gobackVisible = value;
                item_goback.Visible = value;
            }
        }
        private bool _okVisible;

        public bool OkVisible
        {
            get
            {
                _okVisible = item_ok.Visible;
                return _okVisible;
            }
            set
            {
                _okVisible = value;
                item_ok.Visible = value;
            }
        }
        private bool _exitVisible;

        public bool ExitVisible
        {
            get
            {
                _exitVisible = item_exit.Visible;
                return _exitVisible;
            }
            set
            {
                _exitVisible = value;
                item_exit.Visible = value;
            }
        }
        private bool _helpVisible;

        public bool HelpVisible
        {
            get
            {
                _helpVisible = item_help.Visible;
                return _helpVisible;
            }
            set
            {
                _helpVisible = value;
                item_help.Visible = value;
            }
        }

        private bool _line1Visible = true;

        public bool Line1Visible
        {
            get { _line1Visible = this.item_separator1.Visible;
                return _line1Visible; }
            set { _line1Visible = value;
            item_separator1.Visible = value;
            }
        }
        private bool _line2Visible = true;
        public bool Line2Visible
        {
            get
            {
                _line2Visible = this.item_separator2.Visible;
                return _line2Visible;
            }
            set
            {
                _line2Visible = value;
                item_separator2.Visible = value;
            }
        }       
        
        private bool _line3Visible = true;

        public bool Line3Visible
        {
            get
            {
                _line3Visible = this.item_separator3.Visible;
                return _line3Visible;
            }
            set
            {
                _line3Visible = value;
                item_separator3.Visible = value;
            }
        }
        private bool _line4Visible = true;

        public bool Line4Visible
        {
            get
            {
                _line4Visible = this.item_separator4.Visible;
                return _line4Visible;
            }
            set
            {
                _line4Visible = value;
                item_separator4.Visible = value;
            }
        }

        public event EventHandler AddClick;
        public event EventHandler UpdateClick;
        public event EventHandler DeleteClick;
        public event EventHandler SaveClick;
        public event EventHandler CopyClick;
        public event EventHandler ReportClick;
        public event EventHandler CsvClick;
        public event EventHandler GobackClick;
        public event EventHandler OkClick;
        public event EventHandler ExitClick;
        public event EventHandler HelpClick;

        protected virtual void OnAddClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (AddClick != null)
            {//判断事件是否为空  

                AddClick(this, e);//触发事件  
            }
        }
        protected virtual void OnUpdateClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (UpdateClick != null)
            {//判断事件是否为空  

                UpdateClick(this, e);//触发事件  
            }
        }

        protected virtual void OnDeleteClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (DeleteClick != null)
            {//判断事件是否为空  

                DeleteClick(this, e);//触发事件  
            }
        }

        protected virtual void OnSaveClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (SaveClick != null)
            {//判断事件是否为空  

                SaveClick(this, e);//触发事件  
            }
        }

        protected virtual void OnCopyClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (CopyClick != null)
            {//判断事件是否为空  

                CopyClick(this, e);//触发事件  
            }
        }

        protected virtual void OnReportClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (ReportClick != null)
            {//判断事件是否为空  

                ReportClick(this, e);//触发事件  
            }
        }

        protected virtual void OnCsvClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (CsvClick != null)
            {//判断事件是否为空  

                CsvClick(this, e);//触发事件  
            }
        }

        protected virtual void OnGobackClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (GobackClick != null)
            {//判断事件是否为空  

                GobackClick(this, e);//触发事件  
            }
        }

        protected virtual void OnOkClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (OkClick != null)
            {//判断事件是否为空  

                OkClick(this, e);//触发事件  
            }
        }

        protected virtual void OnExitClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (ExitClick != null)
            {//判断事件是否为空  

                ExitClick(this, e);//触发事件  
            }
        }

        protected virtual void OnHelpClick(Object sender, EventArgs e)
        {//事件触发方法  
            if (HelpClick != null)
            {//判断事件是否为空  

                HelpClick(this, e);//触发事件  
            }
        } 

        public bool Displaytext
        {
            get { return displaytext; }
            set { displaytext = value; }
        }

        public CommonToolStrip()
        {
            InitializeComponent();
            ToolStripManager.Renderer = new Office2007Renderer.Office2007Renderer();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {


            item_add.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Add_24");

            item_add.Text = rm.GetString("Add");
            item_add.ToolTipText = rm.GetString("Add");
            item_add.ImageScaling = ToolStripItemImageScaling.None;

            item_update.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Update_24");
            item_update.Text = rm.GetString("Update");
            item_update.ToolTipText = rm.GetString("Update");
            item_update.ImageScaling = ToolStripItemImageScaling.None;

            item_delete.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Delete_24");
            item_delete.Text = rm.GetString("Delete");
            item_delete.ToolTipText = rm.GetString("Delete");
            item_delete.ImageScaling = ToolStripItemImageScaling.None;


            item_save.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Save_24");
            item_save.Text = rm.GetString("Save");
            item_save.ToolTipText = rm.GetString("Save");
            item_save.ImageScaling = ToolStripItemImageScaling.None;


            item_copy.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Copy_24");
            item_copy.Text = rm.GetString("Copy");
            item_copy.ToolTipText = rm.GetString("Copy");
            item_copy.ImageScaling = ToolStripItemImageScaling.None;

            item_report.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Report_24");
            item_report.Text = rm.GetString("Report");
            item_report.ToolTipText = rm.GetString("Report");
            item_report.ImageScaling = ToolStripItemImageScaling.None;

            item_csv.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Csv_24");
            item_csv.Text = rm.GetString("Csv");
            item_csv.ToolTipText = rm.GetString("Csv");
            item_csv.ImageScaling = ToolStripItemImageScaling.None;
            item_goback.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Goback_24");
            item_goback.Text = rm.GetString("Goback");
            item_goback.ToolTipText = rm.GetString("Goback");
            item_goback.ImageScaling = ToolStripItemImageScaling.None;



            item_ok.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Ok_24");
            item_ok.Text = rm.GetString("Ok");
            item_ok.ToolTipText = rm.GetString("Ok");
            item_ok.ImageScaling = ToolStripItemImageScaling.None;

            item_exit.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Exit_24");
            item_exit.Text = rm.GetString("Exit");
            item_exit.ToolTipText = rm.GetString("Exit");
            item_exit.ImageScaling = ToolStripItemImageScaling.None;


            item_help.Image = (Image)Com.GainWinSoft.Common.Control.CommonToolStrip.Properties.Resources.ResourceManager.GetObject("Help_24");
            item_help.Text = rm.GetString("Help");
            item_help.Alignment = ToolStripItemAlignment.Right;
            item_help.ToolTipText = rm.GetString("Help");
            item_help.ImageScaling = ToolStripItemImageScaling.None;
            item_separator4.Alignment = ToolStripItemAlignment.Right;

            this.toolStrip1.Items.Add(item_add);
            this.toolStrip1.Items.Add(item_update);
            this.toolStrip1.Items.Add(item_delete);
            this.toolStrip1.Items.Add(item_save);
            this.toolStrip1.Items.Add(item_separator1);
            this.toolStrip1.Items.Add(item_copy);
            this.toolStrip1.Items.Add(item_separator2);
            this.toolStrip1.Items.Add(item_report);
            this.toolStrip1.Items.Add(item_csv);
            this.toolStrip1.Items.Add(item_separator3);
            this.toolStrip1.Items.Add(item_goback);
            this.toolStrip1.Items.Add(item_ok);
            this.toolStrip1.Items.Add(item_exit);
            this.toolStrip1.Items.Add(item_help);
            this.toolStrip1.Items.Add(item_separator4);

            //item_add.Visible = false;
            //item_delete.Visible = false;
            //item_update.Visible = false;
            //item_save.Visible = false;
            //item_separator1.Visible = false;
            //item_copy.Visible = false;
            //item_separator2.Visible = false;
            //item_report.Visible = false;
            //item_csv.Visible = false;
            //item_separator3.Visible = false;
            //item_goback.Visible = false;
            //item_ok.Visible = false;
            //item_exit.Visible = false;
            //item_separator4.Visible = false;
            //item_help.Visible = false;



            item_add.Click += new EventHandler(OnAddClick);
            item_update.Click += new EventHandler(OnUpdateClick);
            item_delete.Click += new EventHandler(OnDeleteClick);
            item_save.Click += new EventHandler(OnSaveClick);
            item_copy.Click += new EventHandler(OnCopyClick);
            item_report.Click += new EventHandler(OnReportClick);
            item_csv.Click += new EventHandler(OnCsvClick);
            item_goback.Click += new EventHandler(OnGobackClick);
            item_ok.Click += new EventHandler(OnOkClick);
            item_exit.Click += new EventHandler(OnExitClick);
            item_help.Click += new EventHandler(OnHelpClick);
            DisplayText();


        }



        private void DisplayText()
        {
            if (displaytext)
            {
                item_add.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_add.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_update.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_update.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_delete.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_save.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_save.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_copy.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_copy.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_report.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_report.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_csv.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_csv.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_goback.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_goback.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_ok.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_ok.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_exit.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_exit.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_help.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item_help.TextImageRelation = TextImageRelation.ImageBeforeText;


            }
            else
            {
                item_add.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_add.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_update.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_update.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_delete.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_save.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_save.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_copy.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_copy.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_report.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_report.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_csv.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_csv.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_goback.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_goback.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_ok.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_ok.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_exit.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_exit.TextImageRelation = TextImageRelation.ImageBeforeText;
                item_help.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item_help.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Checked)
            {
                this.displaytext = true;
                DisplayText();
            }
            else
            {
                this.displaytext = false;
                DisplayText();
            }
        }
    }
}
