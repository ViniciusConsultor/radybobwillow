using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class TWhPrcsMsId
    {

        #region Private Members

        private string iFacCd;
        private string iWhPrcsCd; 

        #endregion

        #region Constuctor(s)


        #endregion // End of Class Constuctor(s)

        #region Public Properties

        [KeyProperty(Column = "I_FAC_CD", Length = 8)]
        public virtual string IFacCd
        {
            get { return iFacCd; }
            set { iFacCd = value; }
        }

        [KeyProperty(Column = "I_WH_PRCS_CD", Length = 8)]
        public virtual string IWhPrcsCd
        {
            get { return iWhPrcsCd; }
            set { iWhPrcsCd = value; }
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
            TWhPrcsMsId castObj = (TWhPrcsMsId)obj;
            return (castObj != null) &&
                (this.iFacCd == castObj.iFacCd) &&
                (this.iWhPrcsCd == castObj.iWhPrcsCd);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * iFacCd.GetHashCode();
            hash = 27 * hash * iWhPrcsCd.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Local implementation of ToString based on class members
        /// </summary>
        public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
            sbuffer.Append("{");

            sbuffer.AppendFormat("IFacCd = {0}, ", iFacCd);
            sbuffer.AppendFormat("IWhPrcsCd = {0}, ", iWhPrcsCd);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
