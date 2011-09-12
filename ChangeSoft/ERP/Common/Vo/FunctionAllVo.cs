using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.Common.Vo
{
    public class FunctionAllVo
    {
        private string langid;

        public string Langid
        {
            get { return langid; }
            set { langid = value; }
        }
        private int catalogid;

        public int Catalogid
        {
            get { return catalogid; }
            set { catalogid = value; }
        }
        private string catalogname;

        public string Catalogname
        {
            get { return catalogname; }
            set { catalogname = value; }
        }
        private string catalogimage;

        public string Catalogimage
        {
            get { return catalogimage; }
            set { catalogimage = value; }
        }

        private IList<FunctionVo> functionlist = new List<FunctionVo>();

        public IList<FunctionVo> Functionlist
        {
            get { return functionlist; }
            set { functionlist = value; }
        } 


    }
}
