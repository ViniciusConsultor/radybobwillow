using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.Common.Vo
{
    public class RoleUserVo
    {
        private int roleid;

        public int Roleid
        {
            get { return roleid; }
            set { roleid = value; }
        }
        private string userid;

        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        private string rolename;

        public string Rolename
        {
            get { return rolename; }
            set { rolename = value; }
        } 


    }
}
