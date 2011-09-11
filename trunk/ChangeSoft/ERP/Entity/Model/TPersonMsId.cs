using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class TPersonMsId
    {

        #region Private Members

        private string iCompanyCd;
        private string iPersonCd; 

        #endregion

        #region Constuctor(s)

        public TPersonMsId()
        {
            this.iCompanyCd = String.Empty;
            this.iPersonCd = String.Empty;
        }
        public TPersonMsId(string iCompanyCd, string iPersonCd)
        {
            this.iCompanyCd = iCompanyCd;
            this.iPersonCd = iPersonCd;
        }
        #endregion // End of Class Constuctor(s)

        #region Public Properties



        [KeyProperty(Column= "I_COMPANY_CD", Length = 8)]
        public virtual string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        [KeyProperty(Column = "I_PERSON_CD", Length = 6)]
        public virtual string IPersonCd
        {
            get { return iPersonCd; }
            set { iPersonCd = value; }
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
            TPersonMsId castObj = (TPersonMsId)obj;
            return (castObj != null) &&
                (this.iCompanyCd == castObj.iCompanyCd) &&
                (this.iPersonCd == castObj.iPersonCd);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * iCompanyCd.GetHashCode();
            hash = 27 * hash * iPersonCd.GetHashCode();
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
            sbuffer.AppendFormat("PersonCd = {0}, ", iPersonCd);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
