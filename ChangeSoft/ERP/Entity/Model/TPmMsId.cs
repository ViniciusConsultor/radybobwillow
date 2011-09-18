using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class TPmMsId
    {

        #region Private Members

        private string iFacCd;
        private string iItemCd; 

        #endregion

        #region Constuctor(s)

        public TPmMsId()
        {
            this.iFacCd = String.Empty;
            this.iItemCd = String.Empty;
        }
        public TPmMsId(string iFacCd, string iItemCd)
        {
            this.iFacCd = iFacCd;
            this.iItemCd = iItemCd;
        }
        #endregion // End of Class Constuctor(s)

        #region Public Properties

        [KeyProperty(Column= "I_FAC_CD", Length = 8)]
        public virtual string IFacCd
        {
            get { return iFacCd; }
            set { iFacCd = value; }
        }

        [KeyProperty(Column = "I_ITEM_CD", Length = 25)]
        public virtual string IItemCd
        {
            get { return iItemCd; }
            set { iItemCd = value; }
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
            TPmMsId castObj = (TPmMsId)obj;
            return (castObj != null) &&
                (this.iFacCd == castObj.iFacCd) &&
                (this.iItemCd == castObj.iItemCd);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * iFacCd.GetHashCode();
            hash = 27 * hash * iItemCd.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Local implementation of ToString based on class members
        /// </summary>
        public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
            sbuffer.Append("{");

            sbuffer.AppendFormat("FacCd = {0}, ", iFacCd);
            sbuffer.AppendFormat("ItemCd = {0}, ", iItemCd);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
