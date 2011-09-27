using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class TFcConditionStpId
    {

        #region Private Members

        private decimal iJournalNo;
        private string iCompanyCd; 

        #endregion

        #region Constuctor(s)


        #endregion // End of Class Constuctor(s)

        #region Public Properties

        [KeyProperty(Column = "I_JOURNAL_NO")]
        public virtual decimal IJournalNo
        {
            get { return iJournalNo; }
            set { iJournalNo = value; }
        }

        [KeyProperty(Column = "I_COMPANY_CD", Length = 8)]
        public virtual string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
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
            TFcConditionStpId castObj = (TFcConditionStpId)obj;
            return (castObj != null) &&
                (this.iJournalNo == castObj.IJournalNo) &&
                (this.iCompanyCd == castObj.ICompanyCd);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * iJournalNo.GetHashCode();
            hash = 27 * hash * iCompanyCd.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Local implementation of ToString based on class members
        /// </summary>
        public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
            sbuffer.Append("{");

            sbuffer.AppendFormat("IFacCd = {0}, ", iJournalNo);
            sbuffer.AppendFormat("IWhPrcsCd = {0}, ", iCompanyCd);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
