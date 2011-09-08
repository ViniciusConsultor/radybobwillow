using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_CLS_DETAIL_MS' Schema
/*
 * 'TClsDetailMs' class maps to 'T_CLS_DETAIL_MS' table.
 * 	 I_CLS_CD                | Type:VARCHAR2  | Len:3     | Nullable:F | PK:T | FK:F
 * 	 I_CLS_DETAIL_CD         | Type:VARCHAR2  | Len:2     | Nullable:F | PK:T | FK:F
 * 	 I_LANGUAGE_CD           | Type:VARCHAR2  | Len:6     | Nullable:F | PK:T | FK:F
 * 	 I_CLS_DETAIL_DESC       | Type:VARCHAR2  | Len:48    | Nullable:T | PK:F | FK:F
 * 	 I_INQ_ITEM              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/6 21:54:48
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_CLS_DETAIL_MS")]
	public class TClsDetailMs : ActiveRecordBase	{

		#region Private Members
        private TClsDetailMsId id;

		private string iClsDetailDesc; 
		private string iInqItem; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TClsDetailMs()
		{
            id = new TClsDetailMsId() ;
			iClsDetailDesc = String.Empty; 
			iInqItem = String.Empty; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iUpdTimestamp = String.Empty; 

		}

        //public TClsDetailMs(
        //    string i_cls_cd, 
        //    string i_cls_detail_cd, 
        //    string i_language_cd, 
        //    DateTime i_entry_date, 
        //    DateTime i_upd_date, 
        //    string i_upd_timestamp)
        //    : this()
        //{
        //    iClsCd = i_cls_cd;
        //    iClsDetailCd = i_cls_detail_cd;
        //    iLanguageCd = i_language_cd;
        //    iClsDetailDesc = String.Empty;
        //    iInqItem = String.Empty;
        //    iEntryDate = i_entry_date;
        //    iUpdDate = i_upd_date;
        //    iUpdTimestamp = i_upd_timestamp;
        //}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties

        [CompositeKey]
        public TClsDetailMsId Id
        {
            get { return id; }
            set { id = value; }
        }

		[Property(Column="I_CLS_DETAIL_DESC", Length=48)]
		public virtual string IClsDetailDesc
		{
			get { return iClsDetailDesc; }
			set { iClsDetailDesc = value; }
		}

		[Property(Column="I_INQ_ITEM", Length=1)]
		public virtual string IInqItem
		{
			get { return iInqItem; }
			set { iInqItem = value; }
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
			TClsDetailMs castObj = (TClsDetailMs)obj; 
			return ( castObj != null ) &&
				( this.id == castObj.id ) ;
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
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
			
			sbuffer.AppendFormat("IClsCd = {0}, ",id.IClsCd);
			sbuffer.AppendFormat("IClsDetailCd = {0}, ",id.IClsDetailCd);
			sbuffer.AppendFormat("ILanguageCd = {0}, ",id.ILanguageCd);
			sbuffer.AppendFormat("IClsDetailDesc = {0}, ",iClsDetailDesc);
			sbuffer.AppendFormat("IInqItem = {0}, ",iInqItem);
			sbuffer.AppendFormat("IEntryDate = {0}, ",iEntryDate);
			sbuffer.AppendFormat("IUpdDate = {0}, ",iUpdDate);
			sbuffer.AppendFormat("IUpdTimestamp = {0}, ",iUpdTimestamp);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}
