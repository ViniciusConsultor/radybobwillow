﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Com.GainWinSoft.ERP.FormVo;

namespace Com.GainWinSoft.ERP 
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm frmLogin = new LoginForm();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }

        }

    }
}
