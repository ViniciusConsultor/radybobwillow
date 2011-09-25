using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class TSectionMsId
    {

        #region Private Members

        private string iCompanyCd;
        private string iSectionCd; 

        #endregion

        #region Constuctor(s)


        #endregion // End of Class Constuctor(s)

        #region Public Properties

        [KeyProperty(Column = "I_COMPANY_CD", Length = 8)]
        public virtual string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        [KeyProperty(Column = "I_SECTION_CD", Length = 8)]
        public virtual string ISectionCd
        {
            get { return iSectionCd; }
            set { iSectionCd = value; }
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
            TSectionMsId castObj = (TSectionMsId)obj;
            return (castObj != null) &&
                (this.iCompanyCd == castObj.iCompanyCd) &&
                (this.iSectionCd == castObj.iSectionCd);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * iCompanyCd.GetHashCode();
            hash = 27 * hash * iSectionCd.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Local implementation of ToString based on class members
        /// </summary>
        public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
            sbuffer.Append("{");

            sbuffer.AppendFormat("ICompanyCd = {0}, ", iCompanyCd);
            sbuffer.AppendFormat("ISectionCd = {0}, ", iSectionCd);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
