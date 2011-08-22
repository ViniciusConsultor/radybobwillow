using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.ChangeSoft.ERP.FormVo
{
    public class FunctionVo
    {
        #region Private Members

        private string langid;

        private int catalogid;
        private string catalogname;
        private string catalogimage;

   

        #endregion



        public string Langid
        {
            get { return langid; }
            set { langid = value; }
        }

        public int Catalogid
        {
            get { return catalogid; }
            set { catalogid = value; }
        }

        public string Catalogname
        {
            get { return catalogname; }
            set { catalogname = value; }
        }

        public string Catalogimage
        {
            get { return catalogimage; }
            set { catalogimage = value; }
        }

    }
}
