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
using Com.GainWinSoft.Common;
using System.Threading;
using Noogen.Validation;
using Com.GainWinSoft.ERP.Action;
using Com.GainWinSoft.ERP.FormVo;

namespace Com.GainWinSoft.ERP
{
    public partial class LoginForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoginForm));
        private bool hasCheckError = false;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MainForm mf = new MainForm();
            //mf.Show();
            //this.Hide();
            log.Debug("OK button click");
            this.Check_Init();

            if (!this.validationProvider1.Validate())
            {
                IList<MessageVo> re = this.validationProvider1.ValidationMessages(
                      true);

                this.DialogResult = DialogResult.Abort;
                
                return;
            }
            else
            {
                this.validationProvider1.ValidationMessages(false);

                //验证用户代码和密码正确与否
                IAction_LoginForm ac = ComponentLocator.Instance().Resolve<IAction_LoginForm>();
                IList<LoginUserInfoVo> loginuserinfolist =  ac.GetLoginUserList(this.txtUserId.Text, this.txtPassword.Text);
                if (loginuserinfolist.Count==0)
                {
                    hasCheckError = true;
                    if (!this.validationProvider2.Validate())
                    {
                        IList<MessageVo> re = this.validationProvider2.ValidationMessages(true);

                        this.DialogResult = DialogResult.Abort;

                        return;
                    }
                }
                else
                {
                    this.validationProvider2.ValidationMessages(false);
                }



            }



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
            Assembly asm1 = Assembly.Load("Com.GainWinSoft.ERP.Entity");
            ActiveRecordStarter.Initialize(
               asm1,
              source);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }

    }
}
