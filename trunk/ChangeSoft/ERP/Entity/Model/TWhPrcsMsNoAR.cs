using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_WH_PRCS_MS' Schema
/*
 * 'TWhPrcsMs' class maps to 'T_WH_PRCS_MS' table.
 * 	 I_FAC_CD                | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_WH_PRCS_CD            | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_WH_PRCS_CLS           | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_WH_PRCS_ARG_DESC      | Type:VARCHAR2  | Len:60    | Nullable:T | PK:F | FK:F
 * 	 I_WH_PRCS_DESC          | Type:VARCHAR2  | Len:120   | Nullable:T | PK:F | FK:F
 * 	 I_WH_PRCS_DESC_KANA     | Type:VARCHAR2  | Len:30    | Nullable:T | PK:F | FK:F
 * 	 I_MAIL_NO               | Type:VARCHAR2  | Len:10    | Nullable:T | PK:F | FK:F
 * 	 I_COUNTRY_CD            | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_ADDRESS1              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADDRESS2              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADDRESS3              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_TEL                   | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_FAX_NO                | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_WH_CLS                | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_ALC_CLS               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SHANGKBN              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_SECTION_CD            | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_RESERVE1              | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_RESERVE2              | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_RESERVE3              | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_INQ_ITEM              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_OBJECT_ID             | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/09/13 15:38:53
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	public class TWhPrcsMsNoAR : ActiveRecordBase	{

		#region Private Members

        private string iFacCd;
        private string iWhPrcsCd; 
		private string iWhPrcsCls; 
		private string iWhPrcsArgDesc; 
		private string iWhPrcsDesc; 
		private string iWhPrcsDescKana; 
		private string iMailNo; 
		private string iCountryCd; 
		private string iAddress1; 
		private string iAddress2; 
		private string iAddress3; 
		private string iTel; 
		private string iFaxNo; 
		private string iWhCls; 
		private string iAlcCls; 
		private string iShangkbn; 
		private string iSectionCd; 
		private string iReserve1; 
		private string iReserve2; 
		private string iReserve3; 
		private string iInqItem; 
		private decimal iObjectId; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TWhPrcsMsNoAR()
		{
			iFacCd = String.Empty; 
			iWhPrcsCd = String.Empty; 
			iWhPrcsCls = String.Empty; 
			iWhPrcsArgDesc = String.Empty; 
			iWhPrcsDesc = String.Empty; 
			iWhPrcsDescKana = String.Empty; 
			iMailNo = String.Empty; 
			iCountryCd = String.Empty; 
			iAddress1 = String.Empty; 
			iAddress2 = String.Empty; 
			iAddress3 = String.Empty; 
			iTel = String.Empty; 
			iFaxNo = String.Empty; 
			iWhCls = String.Empty; 
			iAlcCls = String.Empty; 
			iShangkbn = String.Empty; 
			iSectionCd = String.Empty; 
			iReserve1 = String.Empty; 
			iReserve2 = String.Empty; 
			iReserve3 = String.Empty; 
			iInqItem = String.Empty; 
			iObjectId = 0; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iUpdTimestamp = String.Empty; 

		}

        public TWhPrcsMsNoAR(
			string i_fac_cd, 
			string i_wh_prcs_cd, 
			string i_wh_prcs_cls, 
			string i_wh_cls, 
			string i_alc_cls, 
			string i_section_cd, 
			DateTime i_entry_date, 
			DateTime i_upd_date, 
			string i_upd_timestamp)
			: this()
		{
            iFacCd = i_fac_cd;
            iWhPrcsCd = i_wh_prcs_cd;
			iWhPrcsCls = i_wh_prcs_cls;
			iWhPrcsArgDesc = String.Empty;
			iWhPrcsDesc = String.Empty;
			iWhPrcsDescKana = String.Empty;
			iMailNo = String.Empty;
			iCountryCd = String.Empty;
			iAddress1 = String.Empty;
			iAddress2 = String.Empty;
			iAddress3 = String.Empty;
			iTel = String.Empty;
			iFaxNo = String.Empty;
			iWhCls = i_wh_cls;
			iAlcCls = i_alc_cls;
			iShangkbn = String.Empty;
			iSectionCd = i_section_cd;
			iReserve1 = String.Empty;
			iReserve2 = String.Empty;
			iReserve3 = String.Empty;
			iInqItem = String.Empty;
			iObjectId = 0;
			iEntryDate = i_entry_date;
			iUpdDate = i_upd_date;
			iUpdTimestamp = i_upd_timestamp;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties

        public virtual string IFacCd
        {
            get { return iFacCd; }
            set { iFacCd = value; }
        }

        public virtual string IWhPrcsCd
        {
            get { return iWhPrcsCd; }
            set { iWhPrcsCd = value; }
        }

		public virtual string IWhPrcsCls
		{
			get { return iWhPrcsCls; }
			set { iWhPrcsCls = value; }
		}

		public virtual string IWhPrcsArgDesc
		{
			get { return iWhPrcsArgDesc; }
			set { iWhPrcsArgDesc = value; }
		}

		public virtual string IWhPrcsDesc
		{
			get { return iWhPrcsDesc; }
			set { iWhPrcsDesc = value; }
		}

		public virtual string IWhPrcsDescKana
		{
			get { return iWhPrcsDescKana; }
			set { iWhPrcsDescKana = value; }
		}

		public virtual string IMailNo
		{
			get { return iMailNo; }
			set { iMailNo = value; }
		}

		public virtual string ICountryCd
		{
			get { return iCountryCd; }
			set { iCountryCd = value; }
		}

		public virtual string IAddress1
		{
			get { return iAddress1; }
			set { iAddress1 = value; }
		}

		public virtual string IAddress2
		{
			get { return iAddress2; }
			set { iAddress2 = value; }
		}

		public virtual string IAddress3
		{
			get { return iAddress3; }
			set { iAddress3 = value; }
		}

		public virtual string ITel
		{
			get { return iTel; }
			set { iTel = value; }
		}

		public virtual string IFaxNo
		{
			get { return iFaxNo; }
			set { iFaxNo = value; }
		}

		public virtual string IWhCls
		{
			get { return iWhCls; }
			set { iWhCls = value; }
		}

		public virtual string IAlcCls
		{
			get { return iAlcCls; }
			set { iAlcCls = value; }
		}

		public virtual string IShangkbn
		{
			get { return iShangkbn; }
			set { iShangkbn = value; }
		}

		public virtual string ISectionCd
		{
			get { return iSectionCd; }
			set { iSectionCd = value; }
		}

		public virtual string IReserve1
		{
			get { return iReserve1; }
			set { iReserve1 = value; }
		}

		public virtual string IReserve2
		{
			get { return iReserve2; }
			set { iReserve2 = value; }
		}

		public virtual string IReserve3
		{
			get { return iReserve3; }
			set { iReserve3 = value; }
		}

		public virtual string IInqItem
		{
			get { return iInqItem; }
			set { iInqItem = value; }
		}

		public virtual decimal IObjectId
		{
			get { return iObjectId; }
			set { iObjectId = value; }
		}

		public virtual DateTime IEntryDate
		{
			get { return iEntryDate; }
			set { iEntryDate = value; }
		}

		public virtual DateTime IUpdDate
		{
			get { return iUpdDate; }
			set { iUpdDate = value; }
		}

		public virtual string IUpdTimestamp
		{
			get { return iUpdTimestamp; }
			set { iUpdTimestamp = value; }
		}


		#endregion 

			
		#region Equals, HashCode and ToString overrides
		
		/// <summary>
		/// Local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
            TWhPrcsMsNoAR castObj = (TWhPrcsMsNoAR)obj; 
			return ( castObj != null ) &&
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
			
			sbuffer.AppendFormat("IFacCd = {0}, ",iFacCd);
			sbuffer.AppendFormat("IWhPrcsCd = {0}, ",iWhPrcsCd);
			sbuffer.AppendFormat("IWhPrcsCls = {0}, ",iWhPrcsCls);
			sbuffer.AppendFormat("IWhPrcsArgDesc = {0}, ",iWhPrcsArgDesc);
			sbuffer.AppendFormat("IWhPrcsDesc = {0}, ",iWhPrcsDesc);
			sbuffer.AppendFormat("IWhPrcsDescKana = {0}, ",iWhPrcsDescKana);
			sbuffer.AppendFormat("IMailNo = {0}, ",iMailNo);
			sbuffer.AppendFormat("ICountryCd = {0}, ",iCountryCd);
			sbuffer.AppendFormat("IAddress1 = {0}, ",iAddress1);
			sbuffer.AppendFormat("IAddress2 = {0}, ",iAddress2);
			sbuffer.AppendFormat("IAddress3 = {0}, ",iAddress3);
			sbuffer.AppendFormat("ITel = {0}, ",iTel);
			sbuffer.AppendFormat("IFaxNo = {0}, ",iFaxNo);
			sbuffer.AppendFormat("IWhCls = {0}, ",iWhCls);
			sbuffer.AppendFormat("IAlcCls = {0}, ",iAlcCls);
			sbuffer.AppendFormat("IShangkbn = {0}, ",iShangkbn);
			sbuffer.AppendFormat("ISectionCd = {0}, ",iSectionCd);
			sbuffer.AppendFormat("IReserve1 = {0}, ",iReserve1);
			sbuffer.AppendFormat("IReserve2 = {0}, ",iReserve2);
			sbuffer.AppendFormat("IReserve3 = {0}, ",iReserve3);
			sbuffer.AppendFormat("IInqItem = {0}, ",iInqItem);
			sbuffer.AppendFormat("IObjectId = {0}, ",iObjectId);
			sbuffer.AppendFormat("IEntryDate = {0}, ",iEntryDate);
			sbuffer.AppendFormat("IUpdDate = {0}, ",iUpdDate);
			sbuffer.AppendFormat("IUpdTimestamp = {0}, ",iUpdTimestamp);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}