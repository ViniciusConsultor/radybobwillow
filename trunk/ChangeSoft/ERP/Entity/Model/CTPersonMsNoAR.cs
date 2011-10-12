using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_PERSON_MS' Schema
/*
 * 'TPersonMs' class maps to 'T_PERSON_MS' table.
 * 	 I_COMPANY_CD            | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_PERSON_CD             | Type:VARCHAR2  | Len:6     | Nullable:F | PK:T | FK:F
 * 	 I_PERSON_DESC           | Type:VARCHAR2  | Len:32    | Nullable:T | PK:F | FK:F
 * 	 I_PERSON_DESC_KANA      | Type:VARCHAR2  | Len:32    | Nullable:T | PK:F | FK:F
 * 	 I_JOB_CLS               | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_USER_ID               | Type:VARCHAR2  | Len:10    | Nullable:T | PK:F | FK:F
 * 	 I_SECTION_CD            | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_PERSON_ENG_DESC       | Type:VARCHAR2  | Len:60    | Nullable:T | PK:F | FK:F
 * 	 I_PERSON_CLS            | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_INQ_ITEM              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/11 21:33:50
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class CTPersonMsNoAR
    {

        #region Private Members

        private string iCompanyCd;
        private string iPersonCd;

        private string iPersonDesc;
        private string iPersonDescKana;
        private string iJobCls;
        private string iUserId;
        private string iSectionCd;
        private string iSectionNm;
        private string iPersonEngDesc;
        private string iPersonCls;
        private string iInqItem;
        private DateTime iEntryDate;
        private DateTime iUpdDate;
        private string iUpdTimestamp;

        #endregion

        #region Constuctor(s)

        public CTPersonMsNoAR()
        {

            iCompanyCd = String.Empty;
            iPersonCd = String.Empty;
            iPersonDesc = String.Empty;
            iPersonDescKana = String.Empty;
            iJobCls = String.Empty;
            iUserId = String.Empty;
            iSectionCd = String.Empty;
            iPersonEngDesc = String.Empty;
            iPersonCls = String.Empty;
            iInqItem = String.Empty;
            iEntryDate = DateTime.MinValue;
            iUpdDate = DateTime.MinValue;
            iUpdTimestamp = String.Empty;

        }


        #endregion // End of Class Constuctor(s)

        #region Public Properties

        public string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        public string IPersonCd
        {
            get { return iPersonCd; }
            set { iPersonCd = value; }
        }

        public string IPersonDesc
        {
            get { return iPersonDesc; }
            set { iPersonDesc = value; }
        }

        public string IPersonDescKana
        {
            get { return iPersonDescKana; }
            set { iPersonDescKana = value; }
        }

        public string IJobCls
        {
            get { return iJobCls; }
            set { iJobCls = value; }
        }

        public string IUserId
        {
            get { return iUserId; }
            set { iUserId = value; }
        }

        public string ISectionCd
        {
            get { return iSectionCd; }
            set { iSectionCd = value; }
        }

        public string ISectionNm
        {
            get { return iSectionNm; }
            set { iSectionNm = value; }
        }

        public string IPersonEngDesc
        {
            get { return iPersonEngDesc; }
            set { iPersonEngDesc = value; }
        }

        public string IPersonCls
        {
            get { return iPersonCls; }
            set { iPersonCls = value; }
        }

        public string IInqItem
        {
            get { return iInqItem; }
            set { iInqItem = value; }
        }

        public System.DateTime IEntryDate
        {
            get { return iEntryDate; }
            set { iEntryDate = value; }
        }

        public System.DateTime IUpdDate
        {
            get { return iUpdDate; }
            set { iUpdDate = value; }
        }

        public string IUpdTimestamp
        {
            get { return iUpdTimestamp; }
            set { iUpdTimestamp = value; }
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
            CTPersonMsNoAR castObj = (CTPersonMsNoAR)obj;
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

            sbuffer.AppendFormat("ICompanyCd = {0}, ", this.iCompanyCd);
            sbuffer.AppendFormat("IPersonCd = {0}, ", this.iPersonCd);
            sbuffer.AppendFormat("IPersonDesc = {0}, ", iPersonDesc);
            sbuffer.AppendFormat("IPersonDescKana = {0}, ", iPersonDescKana);
            sbuffer.AppendFormat("IJobCls = {0}, ", iJobCls);
            sbuffer.AppendFormat("IUserId = {0}, ", iUserId);
            sbuffer.AppendFormat("ISectionCd = {0}, ", iSectionCd);
            sbuffer.AppendFormat("ISectionCd = {0}, ", iSectionNm);
            sbuffer.AppendFormat("IPersonEngDesc = {0}, ", iPersonEngDesc);
            sbuffer.AppendFormat("IPersonCls = {0}, ", iPersonCls);
            sbuffer.AppendFormat("IInqItem = {0}, ", iInqItem);
            sbuffer.AppendFormat("IEntryDate = {0}, ", iEntryDate);
            sbuffer.AppendFormat("IUpdDate = {0}, ", iUpdDate);
            sbuffer.AppendFormat("IUpdTimestamp = {0}, ", iUpdTimestamp);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion

    }
}