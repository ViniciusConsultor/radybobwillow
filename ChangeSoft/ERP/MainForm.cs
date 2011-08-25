using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Com.ChangeSoft.ERP.Company;
using Com.ChangeSoft.Common.Office2007Renderer;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord.Framework.Config;
using System.Reflection;
using System.Threading;
using NHibernate.Mapping;
using Com.ChangeSoft.Common;
using System.Collections;
using Castle.Windsor;
using Com.ChangeSoft.ERP.Action;
using Com.ChangeSoft.ERP.FormVo;

namespace Com.ChangeSoft.ERP
{
    public partial class MainForm : Form
    {

        private System.Resources.ResourceManager rm;
        private IList langItemlist;
        private MenuWindow menuWindow;
        public MainForm()
        {

            this.Hide();
            Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();
            InitializeComponent();

        }

        public void CloseAllDocuments()
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
            }
            else
            {
                IDockContent[] documents = dockPanel.DocumentsToArray();
                foreach (IDockContent content in documents)
                {
                    content.DockHandler.Close();
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SplashScreen.UdpateStatusText("Loading Items!!!");
            ToolStripManager.Renderer = new Office2007Renderer();
            rm = new System.Resources.ResourceManager(typeof(MainForm));
            
            //get all condition
            String d = LangUtils.GetDefaultLanguage();
            ConditionUtils.GetAllConditionsList(d);
            Thread.CurrentThread.CurrentUICulture = (System.Globalization.CultureInfo)new System.Globalization.CultureInfo(d);
            init_ToolStripComboBox();
            
            //castle windsor initial
            ComponentLocator.Instance();

            init_Menu();
            
            //Thread.Sleep(1000);
            //SplashScreen.UdpateStatusTextWithStatus("Success Message", TypeOfMessage.Success);
            //Thread.Sleep(1000);
            //SplashScreen.UdpateStatusTextWithStatus("Warning Message", TypeOfMessage.Warning);

            //Thread.Sleep(1000);
            //SplashScreen.UdpateStatusTextWithStatus("Error Message", TypeOfMessage.Error);
            //Thread.Sleep(1000);
            //SplashScreen.UdpateStatusText("Testing Default Message Color");
            //Thread.Sleep(1000);
            //SplashScreen.UdpateStatusText("Items Loaded..");
            //Thread.Sleep(500);

            this.Show();
            SplashScreen.CloseSplashScreen();
            this.Activate();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentUICulture = (System.Globalization.CultureInfo)new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InvariantCulture;

        }

        private void init_Menu()
        {
            IAction_MainForm af = ComponentLocator.Instance().Resolve<IAction_MainForm>();
            IList<FunctionAllVo> flist = af.GetFunctionDataList();

            menuWindow = new MenuWindow(this.dockPanel,flist);
            menuWindow.Show(this.dockPanel, DockState.DockLeft);

        }

        private void init_ToolStripComboBox()
        {
            langItemlist = LangUtils.GetLanguageList();

            this.toolStripComboBox_Language.Items.Clear();
            foreach (ConditionVo vo in langItemlist)
            {
                this.toolStripComboBox_Language.Items.Add(vo.ConditionName);
            }
        }

    }
}
