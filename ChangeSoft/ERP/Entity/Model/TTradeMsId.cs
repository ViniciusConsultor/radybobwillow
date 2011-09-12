using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class TTradeMsId
    {

        #region Private Members

        private string iCompanyCd;
        private string iDlCd; 

        #endregion

        #region Constuctor(s)

        public TTradeMsId()
        {
            this.iCompanyCd = String.Empty;
            this.iDlCd = String.Empty;
        }
        public TTradeMsId(string iCompanyCd, string iDlCd)
        {
            this.iCompanyCd = iCompanyCd;
            this.iDlCd = iDlCd;
        }
        #endregion // End of Class Constuctor(s)

        #region Public Properties



        [KeyProperty(Column= "I_COMPANY_CD", Length = 8)]
        public virtual string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        [KeyProperty(Column = "I_DL_CD", Length = 8)]
        public virtual string IDlCd
        {
            get { return iDlCd; }
            set { iDlCd = value; }
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
            TTradeMsId castObj = (TTradeMsId)obj;
            return (castObj != null) &&
                (this.iCompanyCd == castObj.iCompanyCd) &&
                (this.iDlCd == castObj.iDlCd);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * iCompanyCd.GetHashCode();
            hash = 27 * hash * iDlCd.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Local implementation of ToString based on class members
        /// </summary>
        public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
            sbuffer.Append("{");

            sbuffer.AppendFormat("CompanyCd = {0}, ", iCompanyCd);
            sbuffer.AppendFormat("DlCd = {0}, ", iDlCd);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
