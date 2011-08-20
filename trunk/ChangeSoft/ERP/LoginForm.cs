using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord.Framework.Config;
using System.Reflection;
using log4net.Config;
using log4net;
using Com.ChangeSoft.Common;
using System.Threading;

namespace Com.ChangeSoft.ERP
{
    public partial class LoginForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoginForm));

        public LoginForm()
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            log.Info("LoginForm init start");
            String d = LangUtils.GetDefaultLanguage();
            Thread.CurrentThread.CurrentUICulture = (System.Globalization.CultureInfo)new System.Globalization.CultureInfo(d);
            InitializeComponent();
            InitialiseAR();
            log.Info("LoginForm init end");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MainForm mf = new MainForm();
            //mf.Show();
            //this.Hide();
            log.Debug("OK button click");
            bool result = true;
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                return;

            }

        }
        public void InitialiseAR()
        {
            ActiveRecordStarter.ResetInitializationFlag();
            IConfigurationSource source = new
              XmlConfigurationSource("ActiveRecordConfig.xml");
            Assembly asm1 = Assembly.Load("Com.ChangeSoft.ERP.Entity");
            ActiveRecordStarter.Initialize(
               asm1,
              source);
        }

    }
}
