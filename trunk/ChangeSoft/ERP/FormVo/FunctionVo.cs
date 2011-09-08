using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.ERP.FormVo
{
    public class FunctionVo
    {
        #region Private Members

        private string langid;
        private int functionid;
        private string functionname;

        private string functionpath;
        private int catalogid;
        private int functionindex;

        private string functionimage;


        #endregion



        public string Langid
        {
            get { return langid; }
            set { langid = value; }
        }

        public int Functionid
        {
            get { return functionid; }
            set { functionid = value; }
        }
        public string Functionname
        {
            get { return functionname; }
            set { functionname = value; }
        }

        public string Functionpath
        {
            get { return functionpath; }
            set { functionpath = value; }
        }
        public int Functionindex
        {
            get { return functionindex; }
            set { functionindex = value; }
        }
        public string Functionimage
        {
            get { return functionimage; }
            set { functionimage = value; }
        }


        public int Catalogid
        {
            get { return catalogid; }
            set { catalogid = value; }
        }


    }
}
