using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.ChangeSoft.Common.Control.PagerGridView
{
    public class ColumnInfoVo
    {
        private string columnname;

        public string Columnname
        {
            get { return columnname; }
            set { columnname = value; }
        }
        private int columndisplayindex;

        public int Columndisplayindex
        {
            get { return columndisplayindex; }
            set { columndisplayindex = value; }
        }
        private string columnheadertext;

        public string Columnheadertext
        {
            get { return columnheadertext; }
            set { columnheadertext = value; }
        }
        private int columnwidth;

        public int Columnwidth
        {
            get { return columnwidth; }
            set { columnwidth = value; }
        }
        private bool columnvisible;

        public bool Columnvisible
        {
            get { return columnvisible; }
            set { columnvisible = value; }
        }

        public override String ToString()
        {
            return this.columnheadertext;
        }
    }
}
