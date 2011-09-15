using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;



#region 'T_RATE_MS' Schema
/*
 * 'TRateMs' class maps to 'T_RATE_MS' table.
 * 	 I_COMPANY_CD            | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_RATE_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:T | FK:F
 * 	 I_DL_CURR_CD            | Type:VARCHAR2  | Len:4     | Nullable:F | PK:T | FK:F
 * 	 I_EFF_END_DATE          | Type:NUMBER    | Len:0     | Nullable:F | PK:T | FK:F
 * 	 I_RATE                  | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_CNV_METHOD            | Type:VARCHAR2  | Len:1     | Nullable:F | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/09/14 11:03:50
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_RATE_MS", DynamicUpdate = true, Lazy = true)]
	public class TRateMs : ActiveRecordBase	{

		#region Private Members
     /*
		private string iCompanyCd; 
		private string iRateCls; 
		private string iDlCurrCd; 
		private decimal iEffEndDate; 
*/

        private TRateMsID id;

        private decimal iRate; 
		private string iCnvMethod; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TRateMs()
		{
            //iCompanyCd = String.Empty; 
            //iRateCls = String.Empty; 
            //iDlCurrCd = String.Empty; 
            //iEffEndDate = 0;
            id = new TRateMsID();
			iRate = 0; 
			iCnvMethod = String.Empty; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iUpdTimestamp = String.Empty; 

		}

		public TRateMs(
            string i_company_cd,
            string i_rate_cls,
            string i_dl_curr_cd,
            decimal i_eff_end_date, 
			decimal i_rate, 
			string i_cnv_method, 
			DateTime i_entry_date, 
			DateTime i_upd_date, 
			string i_upd_timestamp)
			: this()
		{
            //iCompanyCd = i_company_cd;
            //iRateCls = i_rate_cls;
            //iDlCurrCd = i_dl_curr_cd;
            //iEffEndDate = i_eff_end_date;
            id = new TRateMsID(i_company_cd, i_rate_cls, i_dl_curr_cd, i_eff_end_date);
			iRate = i_rate;
			iCnvMethod = i_cnv_method;
			iEntryDate = i_entry_date;
			iUpdDate = i_upd_date;
			iUpdTimestamp = i_upd_timestamp;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties
/*			
		[PrimaryKey(PrimaryKeyType.Identity ,"I_COMPANY_CD", Length=8)]
		public virtual string ICompanyCd
		{
			get { return iCompanyCd; }
			set { iCompanyCd = value; }
		}

		[PrimaryKey(PrimaryKeyType.Identity ,"I_RATE_CLS", Length=2)]
		public virtual string IRateCls
		{
			get { return iRateCls; }
			set { iRateCls = value; }
		}

		[PrimaryKey(PrimaryKeyType.Identity ,"I_DL_CURR_CD", Length=4)]
		public virtual string IDlCurrCd
		{
			get { return iDlCurrCd; }
			set { iDlCurrCd = value; }
		}

		[PrimaryKey(PrimaryKeyType.Identity ,"I_EFF_END_DATE")]
		public virtual decimal IEffEndDate
		{
			get { return iEffEndDate; }
			set { iEffEndDate = value; }
		}
 * 
  */

        [CompositeKey]
        public TRateMsID Id
        {
            get { return id; }
            set { id = value; }
        }
        
        [Property(Column="I_RATE", NotNull=true)]
		public virtual decimal IRate
		{
			get { return iRate; }
			set { iRate = value; }
		}

		[Property(Column="I_CNV_METHOD", NotNull=true, Length=1)]
		public virtual string ICnvMethod
		{
			get { return iCnvMethod; }
			set { iCnvMethod = value; }
		}

		[Property(Column="I_ENTRY_DATE", NotNull=true)]
		public virtual DateTime IEntryDate
		{
			get { return iEntryDate; }
			set { iEntryDate = value; }
		}

		[Property(Column="I_UPD_DATE", NotNull=true)]
		public virtual DateTime IUpdDate
		{
			get { return iUpdDate; }
			set { iUpdDate = value; }
		}

		[Property(Column="I_UPD_TIMESTAMP", NotNull=true, Length=17)]
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
			TRateMs castObj = (TRateMs)obj; 
			return ( castObj != null ) &&
                (this.id == castObj.id);
                /*
				( this.iCompanyCd == castObj.ICompanyCd ) &&
				( this.iRateCls == castObj.IRateCls ) &&
				( this.iDlCurrCd == castObj.IDlCurrCd ) &&
				( this.iEffEndDate == castObj.IEffEndDate );*/


		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57;
            /*
			hash = 27 * hash * iCompanyCd.GetHashCode();
			hash = 27 * hash * iRateCls.GetHashCode();
			hash = 27 * hash * iDlCurrCd.GetHashCode();
			hash = 27 * hash * iEffEndDate.GetHashCode();   */

            hash = 27 * hash * id.GetHashCode();


			return hash; 
		}
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			 /*
			sbuffer.AppendFormat("ICompanyCd = {0}, ",iCompanyCd);
			sbuffer.AppendFormat("IRateCls = {0}, ",iRateCls);
			sbuffer.AppendFormat("IDlCurrCd = {0}, ",iDlCurrCd);
			sbuffer.AppendFormat("IEffEndDate = {0}, ",iEffEndDate); */

			sbuffer.AppendFormat("ICompanyCd = {0}, ",id.ICompanyCd);
			sbuffer.AppendFormat("IRateCls = {0}, ",id.IRateCls);
			sbuffer.AppendFormat("IDlCurrCd = {0}, ",id.IDlCurrCd);
			sbuffer.AppendFormat("IEffEndDate = {0}, ",id.IEffEndDate); 

			sbuffer.AppendFormat("IRate = {0}, ",iRate);
			sbuffer.AppendFormat("ICnvMethod = {0}, ",iCnvMethod);
			sbuffer.AppendFormat("IEntryDate = {0}, ",iEntryDate);
			sbuffer.AppendFormat("IUpdDate = {0}, ",iUpdDate);
			sbuffer.AppendFormat("IUpdTimestamp = {0}, ",iUpdTimestamp);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}