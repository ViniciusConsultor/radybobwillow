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
        private IList<ConditionVo> langItemlist;
        private MenuWindow menuWindow;
        ToolStripMenuItem menu_system;
        ToolStripMenuItem menu_function;
        ToolStripMenuItem menu_window;
        ToolStripMenuItem menu_help;
        Hashtable openedform=new Hashtable();
        IList<string> windowlist = new List<string>();

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
            SplashScreen.UdpateStatusText(MessageUtils.GetMessage("I0001"));
            ToolStripManager.Renderer = new Office2007Renderer();
            rm = new System.Resources.ResourceManager(typeof(MainForm));
            
            //get all condition
            String d = LangUtils.GetDefaultLanguage();
            ConditionUtils.GetAllConditionsList(d);
            Thread.CurrentThread.CurrentUICulture = (System.Globalization.CultureInfo)new System.Globalization.CultureInfo(d);
            init_ToolStripComboBox();
            
            //castle windsor initial
            ComponentLocator.Instance();

            IAction_MainForm af = ComponentLocator.Instance().Resolve<IAction_MainForm>();
            IList<FunctionAllVo> flist = af.GetFunctionDataList();


            SplashScreen.UdpateStatusText(MessageUtils.GetMessage("I0002"));
            init_MenuStrip(flist);
            init_MenuWindow(flist);
            
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
            SplashScreen.UdpateStatusText(MessageUtils.GetMessage("I0003"));

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
            //Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InvariantCulture;

        }

        private void init_MenuWindow(IList<FunctionAllVo> flist)
        {

            menuWindow = new MenuWindow(this.dockPanel,flist);
            menuWindow.Show(this.dockPanel, DockState.DockLeft);

        }

        private void init_ToolStripComboBox()
        {
            langItemlist = LangUtils.GetLanguageList();

            this.toolStripComboBox_Language.Items.Clear();
            foreach (ConditionVo vo in langItemlist)
            {
                this.toolStripComboBox_Language.Items.Add(vo);
            }
        }

        private void init_MenuStrip(IList<FunctionAllVo> flist)
        {
            menu_system = new ToolStripMenuItem();
            menu_system.Name = "Menu_System";
            menu_system.Text = rm.GetString("Menu.System");
            ToolStripMenuItem submenu_system_setting = new ToolStripMenuItem();
            submenu_system_setting.Name = "SubMenu_System_Setting";
            submenu_system_setting.Text = rm.GetString("SubMenu.System.Setting");

            ToolStripSeparator line1 = new ToolStripSeparator();
            
            ToolStripMenuItem submenu_system_exit = new ToolStripMenuItem();
            submenu_system_exit.Name = "SubMenu_System_Exit";
            submenu_system_exit.Text = rm.GetString("SubMenu.System.Exit");

            menu_system.DropDownItems.AddRange(new ToolStripItem[]{
                submenu_system_setting,line1,submenu_system_exit
            });
            

            menu_function = new ToolStripMenuItem();
            menu_function.Name = "Menu_Function";
            menu_function.Text = rm.GetString("Menu.Function");


            menu_window = new ToolStripMenuItem();
            menu_window.Name = "Menu_Window";
            menu_window.Text = rm.GetString("Menu.Window");
            menu_window.Click += new EventHandler(Menu_Window_Click);

            //ToolStripSeparator line2 = new ToolStripSeparator();

            ToolStripMenuItem submenu_window_listwindow = new ToolStripMenuItem();
            submenu_window_listwindow.Name = "SubMenu_Window_ListWindow";
            submenu_window_listwindow.Text = rm.GetString("SubMenu.Window.ListWindow");

            menu_window.DropDownItems.AddRange(new ToolStripItem[] {submenu_window_listwindow });

            menu_help = new ToolStripMenuItem();
            menu_help.Name = "Menu_Help";
            menu_help.Text = rm.GetString("Menu.Help");

            ToolStripMenuItem submenu_help_contents = new ToolStripMenuItem();
            submenu_help_contents.Name = "SubMenu_Help_Contents";
            submenu_help_contents.Text = rm.GetString("SubMenu.Help.Contents");

            ToolStripSeparator line3 = new ToolStripSeparator();

            ToolStripMenuItem submenu_help_about = new ToolStripMenuItem();
            submenu_help_about.Name = "SubMenu_Help_About";
            submenu_help_about.Text = rm.GetString("SubMenu.Help.About");

            menu_help.DropDownItems.AddRange(new ToolStripItem[] {submenu_help_contents,line3,submenu_help_about });

            this.menuStrip1.Items.AddRange(new ToolStripItem[] {menu_system,menu_function,menu_window,menu_help });


            //生成功能菜单
            foreach (FunctionAllVo functionvo in flist)
            {
                ToolStripMenuItem submenu_functioncatalog = new ToolStripMenuItem();
                submenu_functioncatalog.Name = "submenu_" + functionvo.Catalogid.ToString() + "_" + functionvo.Catalogname;
                submenu_functioncatalog.Text = functionvo.Catalogname;
                foreach (FunctionVo vo in functionvo.Functionlist)
                {
                    ToolStripMenuItem submenu_function = new ToolStripMenuItem();
                    submenu_function.Name = "submenu_" + vo.Functionid + "_" + vo.Functionname;
                    submenu_function.Text = vo.Functionname;
                    submenu_function.Tag = vo.Functionpath;
                    submenu_function.Click += new EventHandler(SubMenu_Function_Click);
                    submenu_functioncatalog.DropDownItems.Add(submenu_function);
                }
                menu_function.DropDownItems.Add(submenu_functioncatalog);
            }

        }

        private void Menu_Window_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int count = menu_window.DropDownItems.Count;
            for (int i = 0; i < count-1; i++)
            {
                menu_window.DropDownItems.RemoveAt(0);
            }

            int max = dockPanel.DocumentsCount;
            if (max >= 5)
            {
                max = 4;
            }

            foreach (DockContent content in dockPanel.Documents)
            { 
                if (cnt < 5)
                {
                    ToolStripMenuItem submenu_window = new ToolStripMenuItem();
                    submenu_window.Name = content.DockHandler.TabText;
                    submenu_window.Text = (max-cnt).ToString() + " " + content.DockHandler.TabText;
                    submenu_window.Tag = content.DockHandler.TabText;
                    submenu_window.Click += new EventHandler(SubMenu_Window_Click);
                    menu_window.DropDownItems.Insert(0, submenu_window);
                }
                cnt++;
                windowlist.Add(content.DockHandler.TabText);
            }
        }

        private void SubMenu_Window_Click(object sender, EventArgs e)
        {
            DockContent frm = ShowContent(((ToolStripMenuItem)sender).Tag.ToString());

        }

        private void SubMenu_Function_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = ((ToolStripMenuItem)sender);
            string path = tm.Tag.ToString();
            string title = tm.Text;
            DockPanel parentpanel = this.dockPanel;

            MenuTransfer m = new MenuTransfer(path, title, parentpanel);
            m.Parse();

        }

        private DockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as DockContent;
                    }
                }

                return null;
            }
            else
            {
                foreach (DockContent content in dockPanel.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }

        private DockContent ShowContent(string caption)
        {
            DockContent frm = FindDocument(caption);
            //if (frm == null)
            //{
            //    frm = ChildWinManagement.LoadMdiForm(Portal.gc.MainDialog, formType) as DockContent;
            //}

            frm.Show(this.dockPanel);
            frm.BringToFront();
            return frm;
        }

    }
}
