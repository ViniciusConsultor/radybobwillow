using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class MFunctioncatalogID
    {

        #region Private Members

        private string langid;
        private int catalogid;

        #endregion

        #region Constuctor(s)


        #endregion // End of Class Constuctor(s)

        #region Public Properties

        [KeyProperty(Column = "LANGID")]
        public virtual string Langid
        {
            get { return langid; }
            set { langid = value; }
        }

        [KeyProperty(Column = "CATALOGID")]
        public virtual int Catalogid
        {
            get { return catalogid; }
            set { catalogid = value; }
        }



        #endregion


        #region Equals, HashCode and ToString overrides

        /// <summary>
        /// Local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            MFunctioncatalogID castObj = (MFunctioncatalogID)obj;
            return (castObj != null) &&
                (this.langid == castObj.Langid) &&
                (this.catalogid == castObj.Catalogid);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * langid.GetHashCode();
            hash = 27 * hash * catalogid.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Local implementation of ToString based on class members
        /// </summary>
        public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
            sbuffer.Append("{");

            sbuffer.AppendFormat("Langid = {0}, ", langid);
            sbuffer.AppendFormat("Catalogid = {0}, ", catalogid);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
