using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_PM_MS_ADD_RTCM' Schema
/*
 * 'TPmMsAddRtcm' class maps to 'T_PM_MS_ADD_RTCM' table.
 * 	 I_FAC_CD                | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_ITEM_CD               | Type:VARCHAR2  | Len:25    | Nullable:F | PK:T | FK:F
 * 	 I_HINSYOSAI1            | Type:VARCHAR2  | Len:40    | Nullable:T | PK:F | FK:F
 * 	 I_HINSYOSAI2            | Type:VARCHAR2  | Len:40    | Nullable:T | PK:F | FK:F
 * 	 I_HINSYOSAI3            | Type:VARCHAR2  | Len:40    | Nullable:T | PK:F | FK:F
 * 	 I_HINSYOSAI4            | Type:VARCHAR2  | Len:40    | Nullable:T | PK:F | FK:F
 * 	 I_HINSYOSAI5            | Type:VARCHAR2  | Len:40    | Nullable:T | PK:F | FK:F
 * 	 I_HKHINNO1              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HKHINNO2              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HKHINNO3              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINZKS1               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HINZKS2               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HINZKS3               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ZRYOBNR               | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_CSTHSKKBN             | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_CSTKSKBN              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_KGSANKBN              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_SKRKEJKBN             | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_TMHSKKBN              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_TMZRYOBNR             | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_TMCSTMKNO             | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_SZCRTKBN              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_HDTKZCH_BNSHI         | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HDTKZCH_BNBO          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HDKMTNICD             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_LOT_SESANRYO          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_DAY_SESANRYO          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_YIELD_RATE            | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_FUKUKBN               | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_SGENKBN               | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_TENFUYKBN             | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_DAIKOTEPTN            | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_DHHIGPTN              | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNSHI1        | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNBO1         | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTIKZTICD1           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNSHI2        | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNBO2         | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTIKZTICD2           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNSHI3        | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNBO3         | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTIKZTICD3           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNSHI4        | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNBO4         | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTIKZTICD4           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNSHI5        | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTKZCH_BNBO5         | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ZKTIKZTICD5           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU01              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU02              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU03              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU04              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU05              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU06              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU07              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU08              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU09              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINKSU10              | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR01              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR02              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR03              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR04              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR05              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR06              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR07              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR08              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR09              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_HINBNR10              | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_JOHHTKBN              | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HFTKBN1               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HFTKBN2               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HFTKBN3               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HFTKBN4               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HFTKBN5               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_SYTSUKAKBN            | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_TNGMHFKBN             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_TNHKSHFKBN            | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/17 23:15:10
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_PM_MS_ADD_RTCM", DynamicUpdate = true, Lazy = true)]
	public class TPmMsAddRtcm : ActiveRecordBase	{

		#region Private Members

        private TPmMsId id;
		private string iHinsyosai1; 
		private string iHinsyosai2; 
		private string iHinsyosai3; 
		private string iHinsyosai4; 
		private string iHinsyosai5; 
		private string iHkhinno1; 
		private string iHkhinno2; 
		private string iHkhinno3; 
		private string iHinzks1; 
		private string iHinzks2; 
		private string iHinzks3; 
		private string iZryobnr; 
		private string iCsthskkbn; 
		private string iCstkskbn; 
		private string iKgsankbn; 
		private string iSkrkejkbn; 
		private string iTmhskkbn; 
		private string iTmzryobnr; 
		private decimal iTmcstmkno; 
		private string iSzcrtkbn; 
		private decimal iHdtkzchBnshi; 
		private decimal iHdtkzchBnbo; 
		private string iHdkmtnicd; 
		private decimal iLotSesanryo; 
		private decimal iDaySesanryo; 
		private decimal iYieldRate; 
		private string iFukukbn; 
		private string iSgenkbn; 
		private string iTenfuykbn; 
		private string iDaikoteptn; 
		private string iDhhigptn; 
		private decimal iZktkzchBnshi1; 
		private decimal iZktkzchBnbo1; 
		private string iZktikzticd1; 
		private decimal iZktkzchBnshi2; 
		private decimal iZktkzchBnbo2; 
		private string iZktikzticd2; 
		private decimal iZktkzchBnshi3; 
		private decimal iZktkzchBnbo3; 
		private string iZktikzticd3; 
		private decimal iZktkzchBnshi4; 
		private decimal iZktkzchBnbo4; 
		private string iZktikzticd4; 
		private decimal iZktkzchBnshi5; 
		private decimal iZktkzchBnbo5; 
		private string iZktikzticd5; 
		private decimal iHinksu01; 
		private decimal iHinksu02; 
		private decimal iHinksu03; 
		private decimal iHinksu04; 
		private decimal iHinksu05; 
		private decimal iHinksu06; 
		private decimal iHinksu07; 
		private decimal iHinksu08; 
		private decimal iHinksu09; 
		private decimal iHinksu10; 
		private string iHinbnr01; 
		private string iHinbnr02; 
		private string iHinbnr03; 
		private string iHinbnr04; 
		private string iHinbnr05; 
		private string iHinbnr06; 
		private string iHinbnr07; 
		private string iHinbnr08; 
		private string iHinbnr09; 
		private string iHinbnr10; 
		private string iJohhtkbn; 
		private string iHftkbn1; 
		private string iHftkbn2; 
		private string iHftkbn3; 
		private string iHftkbn4; 
		private string iHftkbn5; 
		private string iSytsukakbn; 
		private string iTngmhfkbn; 
		private string iTnhkshfkbn; 
		
		#endregion

		#region Constuctor(s)
		
		public TPmMsAddRtcm()
		{
            id = new TPmMsId();
			id.IFacCd = String.Empty; 
			id.IItemCd = String.Empty; 
			iHinsyosai1 = String.Empty; 
			iHinsyosai2 = String.Empty; 
			iHinsyosai3 = String.Empty; 
			iHinsyosai4 = String.Empty; 
			iHinsyosai5 = String.Empty; 
			iHkhinno1 = String.Empty; 
			iHkhinno2 = String.Empty; 
			iHkhinno3 = String.Empty; 
			iHinzks1 = String.Empty; 
			iHinzks2 = String.Empty; 
			iHinzks3 = String.Empty; 
			iZryobnr = String.Empty; 
			iCsthskkbn = String.Empty; 
			iCstkskbn = String.Empty; 
			iKgsankbn = String.Empty; 
			iSkrkejkbn = String.Empty; 
			iTmhskkbn = String.Empty; 
			iTmzryobnr = String.Empty; 
			iTmcstmkno = 0; 
			iSzcrtkbn = String.Empty; 
			iHdtkzchBnshi = 0; 
			iHdtkzchBnbo = 0; 
			iHdkmtnicd = String.Empty; 
			iLotSesanryo = 0; 
			iDaySesanryo = 0; 
			iYieldRate = 0; 
			iFukukbn = String.Empty; 
			iSgenkbn = String.Empty; 
			iTenfuykbn = String.Empty; 
			iDaikoteptn = String.Empty; 
			iDhhigptn = String.Empty; 
			iZktkzchBnshi1 = 0; 
			iZktkzchBnbo1 = 0; 
			iZktikzticd1 = String.Empty; 
			iZktkzchBnshi2 = 0; 
			iZktkzchBnbo2 = 0; 
			iZktikzticd2 = String.Empty; 
			iZktkzchBnshi3 = 0; 
			iZktkzchBnbo3 = 0; 
			iZktikzticd3 = String.Empty; 
			iZktkzchBnshi4 = 0; 
			iZktkzchBnbo4 = 0; 
			iZktikzticd4 = String.Empty; 
			iZktkzchBnshi5 = 0; 
			iZktkzchBnbo5 = 0; 
			iZktikzticd5 = String.Empty; 
			iHinksu01 = 0; 
			iHinksu02 = 0; 
			iHinksu03 = 0; 
			iHinksu04 = 0; 
			iHinksu05 = 0; 
			iHinksu06 = 0; 
			iHinksu07 = 0; 
			iHinksu08 = 0; 
			iHinksu09 = 0; 
			iHinksu10 = 0; 
			iHinbnr01 = String.Empty; 
			iHinbnr02 = String.Empty; 
			iHinbnr03 = String.Empty; 
			iHinbnr04 = String.Empty; 
			iHinbnr05 = String.Empty; 
			iHinbnr06 = String.Empty; 
			iHinbnr07 = String.Empty; 
			iHinbnr08 = String.Empty; 
			iHinbnr09 = String.Empty; 
			iHinbnr10 = String.Empty; 
			iJohhtkbn = String.Empty; 
			iHftkbn1 = String.Empty; 
			iHftkbn2 = String.Empty; 
			iHftkbn3 = String.Empty; 
			iHftkbn4 = String.Empty; 
			iHftkbn5 = String.Empty; 
			iSytsukakbn = String.Empty; 
			iTngmhfkbn = String.Empty; 
			iTnhkshfkbn = String.Empty; 

		}

		public TPmMsAddRtcm(
			string i_fac_cd, 
			string i_item_cd)
			: this()
		{
            id = new TPmMsId();
			id.IFacCd = i_fac_cd;
			id.IItemCd = i_item_cd;
			iHinsyosai1 = String.Empty;
			iHinsyosai2 = String.Empty;
			iHinsyosai3 = String.Empty;
			iHinsyosai4 = String.Empty;
			iHinsyosai5 = String.Empty;
			iHkhinno1 = String.Empty;
			iHkhinno2 = String.Empty;
			iHkhinno3 = String.Empty;
			iHinzks1 = String.Empty;
			iHinzks2 = String.Empty;
			iHinzks3 = String.Empty;
			iZryobnr = String.Empty;
			iCsthskkbn = String.Empty;
			iCstkskbn = String.Empty;
			iKgsankbn = String.Empty;
			iSkrkejkbn = String.Empty;
			iTmhskkbn = String.Empty;
			iTmzryobnr = String.Empty;
			iTmcstmkno = 0;
			iSzcrtkbn = String.Empty;
			iHdtkzchBnshi = 0;
			iHdtkzchBnbo = 0;
			iHdkmtnicd = String.Empty;
			iLotSesanryo = 0;
			iDaySesanryo = 0;
			iYieldRate = 0;
			iFukukbn = String.Empty;
			iSgenkbn = String.Empty;
			iTenfuykbn = String.Empty;
			iDaikoteptn = String.Empty;
			iDhhigptn = String.Empty;
			iZktkzchBnshi1 = 0;
			iZktkzchBnbo1 = 0;
			iZktikzticd1 = String.Empty;
			iZktkzchBnshi2 = 0;
			iZktkzchBnbo2 = 0;
			iZktikzticd2 = String.Empty;
			iZktkzchBnshi3 = 0;
			iZktkzchBnbo3 = 0;
			iZktikzticd3 = String.Empty;
			iZktkzchBnshi4 = 0;
			iZktkzchBnbo4 = 0;
			iZktikzticd4 = String.Empty;
			iZktkzchBnshi5 = 0;
			iZktkzchBnbo5 = 0;
			iZktikzticd5 = String.Empty;
			iHinksu01 = 0;
			iHinksu02 = 0;
			iHinksu03 = 0;
			iHinksu04 = 0;
			iHinksu05 = 0;
			iHinksu06 = 0;
			iHinksu07 = 0;
			iHinksu08 = 0;
			iHinksu09 = 0;
			iHinksu10 = 0;
			iHinbnr01 = String.Empty;
			iHinbnr02 = String.Empty;
			iHinbnr03 = String.Empty;
			iHinbnr04 = String.Empty;
			iHinbnr05 = String.Empty;
			iHinbnr06 = String.Empty;
			iHinbnr07 = String.Empty;
			iHinbnr08 = String.Empty;
			iHinbnr09 = String.Empty;
			iHinbnr10 = String.Empty;
			iJohhtkbn = String.Empty;
			iHftkbn1 = String.Empty;
			iHftkbn2 = String.Empty;
			iHftkbn3 = String.Empty;
			iHftkbn4 = String.Empty;
			iHftkbn5 = String.Empty;
			iSytsukakbn = String.Empty;
			iTngmhfkbn = String.Empty;
			iTnhkshfkbn = String.Empty;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties

        [CompositeKey]
        public Com.GainWinSoft.ERP.Entity.TPmMsId Id
        {
            get { return id; }
            set { id = value; }
        }

		[Property(Column="I_HINSYOSAI1", Length=40)]
		public virtual string IHinsyosai1
		{
			get { return iHinsyosai1; }
			set { iHinsyosai1 = value; }
		}

		[Property(Column="I_HINSYOSAI2", Length=40)]
		public virtual string IHinsyosai2
		{
			get { return iHinsyosai2; }
			set { iHinsyosai2 = value; }
		}

		[Property(Column="I_HINSYOSAI3", Length=40)]
		public virtual string IHinsyosai3
		{
			get { return iHinsyosai3; }
			set { iHinsyosai3 = value; }
		}

		[Property(Column="I_HINSYOSAI4", Length=40)]
		public virtual string IHinsyosai4
		{
			get { return iHinsyosai4; }
			set { iHinsyosai4 = value; }
		}

		[Property(Column="I_HINSYOSAI5", Length=40)]
		public virtual string IHinsyosai5
		{
			get { return iHinsyosai5; }
			set { iHinsyosai5 = value; }
		}

		[Property(Column="I_HKHINNO1", Length=25)]
		public virtual string IHkhinno1
		{
			get { return iHkhinno1; }
			set { iHkhinno1 = value; }
		}

		[Property(Column="I_HKHINNO2", Length=25)]
		public virtual string IHkhinno2
		{
			get { return iHkhinno2; }
			set { iHkhinno2 = value; }
		}

		[Property(Column="I_HKHINNO3", Length=25)]
		public virtual string IHkhinno3
		{
			get { return iHkhinno3; }
			set { iHkhinno3 = value; }
		}

		[Property(Column="I_HINZKS1", Length=2)]
		public virtual string IHinzks1
		{
			get { return iHinzks1; }
			set { iHinzks1 = value; }
		}

		[Property(Column="I_HINZKS2", Length=2)]
		public virtual string IHinzks2
		{
			get { return iHinzks2; }
			set { iHinzks2 = value; }
		}

		[Property(Column="I_HINZKS3", Length=2)]
		public virtual string IHinzks3
		{
			get { return iHinzks3; }
			set { iHinzks3 = value; }
		}

		[Property(Column="I_ZRYOBNR", Length=6)]
		public virtual string IZryobnr
		{
			get { return iZryobnr; }
			set { iZryobnr = value; }
		}

		[Property(Column="I_CSTHSKKBN", Length=1)]
		public virtual string ICsthskkbn
		{
			get { return iCsthskkbn; }
			set { iCsthskkbn = value; }
		}

		[Property(Column="I_CSTKSKBN", Length=1)]
		public virtual string ICstkskbn
		{
			get { return iCstkskbn; }
			set { iCstkskbn = value; }
		}

		[Property(Column="I_KGSANKBN", Length=1)]
		public virtual string IKgsankbn
		{
			get { return iKgsankbn; }
			set { iKgsankbn = value; }
		}

		[Property(Column="I_SKRKEJKBN", Length=1)]
		public virtual string ISkrkejkbn
		{
			get { return iSkrkejkbn; }
			set { iSkrkejkbn = value; }
		}

		[Property(Column="I_TMHSKKBN", Length=1)]
		public virtual string ITmhskkbn
		{
			get { return iTmhskkbn; }
			set { iTmhskkbn = value; }
		}

		[Property(Column="I_TMZRYOBNR", Length=6)]
		public virtual string ITmzryobnr
		{
			get { return iTmzryobnr; }
			set { iTmzryobnr = value; }
		}

		[Property(Column="I_TMCSTMKNO")]
		public virtual decimal ITmcstmkno
		{
			get { return iTmcstmkno; }
			set { iTmcstmkno = value; }
		}

		[Property(Column="I_SZCRTKBN", Length=1)]
		public virtual string ISzcrtkbn
		{
			get { return iSzcrtkbn; }
			set { iSzcrtkbn = value; }
		}

		[Property(Column="I_HDTKZCH_BNSHI")]
		public virtual decimal IHdtkzchBnshi
		{
			get { return iHdtkzchBnshi; }
			set { iHdtkzchBnshi = value; }
		}

		[Property(Column="I_HDTKZCH_BNBO")]
		public virtual decimal IHdtkzchBnbo
		{
			get { return iHdtkzchBnbo; }
			set { iHdtkzchBnbo = value; }
		}

		[Property(Column="I_HDKMTNICD", Length=2)]
		public virtual string IHdkmtnicd
		{
			get { return iHdkmtnicd; }
			set { iHdkmtnicd = value; }
		}

		[Property(Column="I_LOT_SESANRYO")]
		public virtual decimal ILotSesanryo
		{
			get { return iLotSesanryo; }
			set { iLotSesanryo = value; }
		}

		[Property(Column="I_DAY_SESANRYO")]
		public virtual decimal IDaySesanryo
		{
			get { return iDaySesanryo; }
			set { iDaySesanryo = value; }
		}

		[Property(Column="I_YIELD_RATE")]
		public virtual decimal IYieldRate
		{
			get { return iYieldRate; }
			set { iYieldRate = value; }
		}

		[Property(Column="I_FUKUKBN", Length=1)]
		public virtual string IFukukbn
		{
			get { return iFukukbn; }
			set { iFukukbn = value; }
		}

		[Property(Column="I_SGENKBN", Length=1)]
		public virtual string ISgenkbn
		{
			get { return iSgenkbn; }
			set { iSgenkbn = value; }
		}

		[Property(Column="I_TENFUYKBN", Length=1)]
		public virtual string ITenfuykbn
		{
			get { return iTenfuykbn; }
			set { iTenfuykbn = value; }
		}

		[Property(Column="I_DAIKOTEPTN", Length=2)]
		public virtual string IDaikoteptn
		{
			get { return iDaikoteptn; }
			set { iDaikoteptn = value; }
		}

		[Property(Column="I_DHHIGPTN", Length=2)]
		public virtual string IDhhigptn
		{
			get { return iDhhigptn; }
			set { iDhhigptn = value; }
		}

		[Property(Column="I_ZKTKZCH_BNSHI1")]
		public virtual decimal IZktkzchBnshi1
		{
			get { return iZktkzchBnshi1; }
			set { iZktkzchBnshi1 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNBO1")]
		public virtual decimal IZktkzchBnbo1
		{
			get { return iZktkzchBnbo1; }
			set { iZktkzchBnbo1 = value; }
		}

		[Property(Column="I_ZKTIKZTICD1", Length=2)]
		public virtual string IZktikzticd1
		{
			get { return iZktikzticd1; }
			set { iZktikzticd1 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNSHI2")]
		public virtual decimal IZktkzchBnshi2
		{
			get { return iZktkzchBnshi2; }
			set { iZktkzchBnshi2 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNBO2")]
		public virtual decimal IZktkzchBnbo2
		{
			get { return iZktkzchBnbo2; }
			set { iZktkzchBnbo2 = value; }
		}

		[Property(Column="I_ZKTIKZTICD2", Length=2)]
		public virtual string IZktikzticd2
		{
			get { return iZktikzticd2; }
			set { iZktikzticd2 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNSHI3")]
		public virtual decimal IZktkzchBnshi3
		{
			get { return iZktkzchBnshi3; }
			set { iZktkzchBnshi3 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNBO3")]
		public virtual decimal IZktkzchBnbo3
		{
			get { return iZktkzchBnbo3; }
			set { iZktkzchBnbo3 = value; }
		}

		[Property(Column="I_ZKTIKZTICD3", Length=2)]
		public virtual string IZktikzticd3
		{
			get { return iZktikzticd3; }
			set { iZktikzticd3 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNSHI4")]
		public virtual decimal IZktkzchBnshi4
		{
			get { return iZktkzchBnshi4; }
			set { iZktkzchBnshi4 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNBO4")]
		public virtual decimal IZktkzchBnbo4
		{
			get { return iZktkzchBnbo4; }
			set { iZktkzchBnbo4 = value; }
		}

		[Property(Column="I_ZKTIKZTICD4", Length=2)]
		public virtual string IZktikzticd4
		{
			get { return iZktikzticd4; }
			set { iZktikzticd4 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNSHI5")]
		public virtual decimal IZktkzchBnshi5
		{
			get { return iZktkzchBnshi5; }
			set { iZktkzchBnshi5 = value; }
		}

		[Property(Column="I_ZKTKZCH_BNBO5")]
		public virtual decimal IZktkzchBnbo5
		{
			get { return iZktkzchBnbo5; }
			set { iZktkzchBnbo5 = value; }
		}

		[Property(Column="I_ZKTIKZTICD5", Length=2)]
		public virtual string IZktikzticd5
		{
			get { return iZktikzticd5; }
			set { iZktikzticd5 = value; }
		}

		[Property(Column="I_HINKSU01")]
		public virtual decimal IHinksu01
		{
			get { return iHinksu01; }
			set { iHinksu01 = value; }
		}

		[Property(Column="I_HINKSU02")]
		public virtual decimal IHinksu02
		{
			get { return iHinksu02; }
			set { iHinksu02 = value; }
		}

		[Property(Column="I_HINKSU03")]
		public virtual decimal IHinksu03
		{
			get { return iHinksu03; }
			set { iHinksu03 = value; }
		}

		[Property(Column="I_HINKSU04")]
		public virtual decimal IHinksu04
		{
			get { return iHinksu04; }
			set { iHinksu04 = value; }
		}

		[Property(Column="I_HINKSU05")]
		public virtual decimal IHinksu05
		{
			get { return iHinksu05; }
			set { iHinksu05 = value; }
		}

		[Property(Column="I_HINKSU06")]
		public virtual decimal IHinksu06
		{
			get { return iHinksu06; }
			set { iHinksu06 = value; }
		}

		[Property(Column="I_HINKSU07")]
		public virtual decimal IHinksu07
		{
			get { return iHinksu07; }
			set { iHinksu07 = value; }
		}

		[Property(Column="I_HINKSU08")]
		public virtual decimal IHinksu08
		{
			get { return iHinksu08; }
			set { iHinksu08 = value; }
		}

		[Property(Column="I_HINKSU09")]
		public virtual decimal IHinksu09
		{
			get { return iHinksu09; }
			set { iHinksu09 = value; }
		}

		[Property(Column="I_HINKSU10")]
		public virtual decimal IHinksu10
		{
			get { return iHinksu10; }
			set { iHinksu10 = value; }
		}

		[Property(Column="I_HINBNR01", Length=25)]
		public virtual string IHinbnr01
		{
			get { return iHinbnr01; }
			set { iHinbnr01 = value; }
		}

		[Property(Column="I_HINBNR02", Length=25)]
		public virtual string IHinbnr02
		{
			get { return iHinbnr02; }
			set { iHinbnr02 = value; }
		}

		[Property(Column="I_HINBNR03", Length=25)]
		public virtual string IHinbnr03
		{
			get { return iHinbnr03; }
			set { iHinbnr03 = value; }
		}

		[Property(Column="I_HINBNR04", Length=25)]
		public virtual string IHinbnr04
		{
			get { return iHinbnr04; }
			set { iHinbnr04 = value; }
		}

		[Property(Column="I_HINBNR05", Length=25)]
		public virtual string IHinbnr05
		{
			get { return iHinbnr05; }
			set { iHinbnr05 = value; }
		}

		[Property(Column="I_HINBNR06", Length=25)]
		public virtual string IHinbnr06
		{
			get { return iHinbnr06; }
			set { iHinbnr06 = value; }
		}

		[Property(Column="I_HINBNR07", Length=25)]
		public virtual string IHinbnr07
		{
			get { return iHinbnr07; }
			set { iHinbnr07 = value; }
		}

		[Property(Column="I_HINBNR08", Length=25)]
		public virtual string IHinbnr08
		{
			get { return iHinbnr08; }
			set { iHinbnr08 = value; }
		}

		[Property(Column="I_HINBNR09", Length=25)]
		public virtual string IHinbnr09
		{
			get { return iHinbnr09; }
			set { iHinbnr09 = value; }
		}

		[Property(Column="I_HINBNR10", Length=25)]
		public virtual string IHinbnr10
		{
			get { return iHinbnr10; }
			set { iHinbnr10 = value; }
		}

		[Property(Column="I_JOHHTKBN", Length=2)]
		public virtual string IJohhtkbn
		{
			get { return iJohhtkbn; }
			set { iJohhtkbn = value; }
		}

		[Property(Column="I_HFTKBN1", Length=2)]
		public virtual string IHftkbn1
		{
			get { return iHftkbn1; }
			set { iHftkbn1 = value; }
		}

		[Property(Column="I_HFTKBN2", Length=2)]
		public virtual string IHftkbn2
		{
			get { return iHftkbn2; }
			set { iHftkbn2 = value; }
		}

		[Property(Column="I_HFTKBN3", Length=2)]
		public virtual string IHftkbn3
		{
			get { return iHftkbn3; }
			set { iHftkbn3 = value; }
		}

		[Property(Column="I_HFTKBN4", Length=2)]
		public virtual string IHftkbn4
		{
			get { return iHftkbn4; }
			set { iHftkbn4 = value; }
		}

		[Property(Column="I_HFTKBN5", Length=2)]
		public virtual string IHftkbn5
		{
			get { return iHftkbn5; }
			set { iHftkbn5 = value; }
		}

		[Property(Column="I_SYTSUKAKBN", Length=2)]
		public virtual string ISytsukakbn
		{
			get { return iSytsukakbn; }
			set { iSytsukakbn = value; }
		}

		[Property(Column="I_TNGMHFKBN", Length=2)]
		public virtual string ITngmhfkbn
		{
			get { return iTngmhfkbn; }
			set { iTngmhfkbn = value; }
		}

		[Property(Column="I_TNHKSHFKBN", Length=2)]
		public virtual string ITnhkshfkbn
		{
			get { return iTnhkshfkbn; }
			set { iTnhkshfkbn = value; }
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
			TPmMsAddRtcm castObj = (TPmMsAddRtcm)obj; 
			return ( castObj != null ) &&
				( this.id == castObj.id );
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
			
			sbuffer.AppendFormat("IFacCd = {0}, ",id.IFacCd);
			sbuffer.AppendFormat("IItemCd = {0}, ",id.IItemCd);
			sbuffer.AppendFormat("IHinsyosai1 = {0}, ",iHinsyosai1);
			sbuffer.AppendFormat("IHinsyosai2 = {0}, ",iHinsyosai2);
			sbuffer.AppendFormat("IHinsyosai3 = {0}, ",iHinsyosai3);
			sbuffer.AppendFormat("IHinsyosai4 = {0}, ",iHinsyosai4);
			sbuffer.AppendFormat("IHinsyosai5 = {0}, ",iHinsyosai5);
			sbuffer.AppendFormat("IHkhinno1 = {0}, ",iHkhinno1);
			sbuffer.AppendFormat("IHkhinno2 = {0}, ",iHkhinno2);
			sbuffer.AppendFormat("IHkhinno3 = {0}, ",iHkhinno3);
			sbuffer.AppendFormat("IHinzks1 = {0}, ",iHinzks1);
			sbuffer.AppendFormat("IHinzks2 = {0}, ",iHinzks2);
			sbuffer.AppendFormat("IHinzks3 = {0}, ",iHinzks3);
			sbuffer.AppendFormat("IZryobnr = {0}, ",iZryobnr);
			sbuffer.AppendFormat("ICsthskkbn = {0}, ",iCsthskkbn);
			sbuffer.AppendFormat("ICstkskbn = {0}, ",iCstkskbn);
			sbuffer.AppendFormat("IKgsankbn = {0}, ",iKgsankbn);
			sbuffer.AppendFormat("ISkrkejkbn = {0}, ",iSkrkejkbn);
			sbuffer.AppendFormat("ITmhskkbn = {0}, ",iTmhskkbn);
			sbuffer.AppendFormat("ITmzryobnr = {0}, ",iTmzryobnr);
			sbuffer.AppendFormat("ITmcstmkno = {0}, ",iTmcstmkno);
			sbuffer.AppendFormat("ISzcrtkbn = {0}, ",iSzcrtkbn);
			sbuffer.AppendFormat("IHdtkzchBnshi = {0}, ",iHdtkzchBnshi);
			sbuffer.AppendFormat("IHdtkzchBnbo = {0}, ",iHdtkzchBnbo);
			sbuffer.AppendFormat("IHdkmtnicd = {0}, ",iHdkmtnicd);
			sbuffer.AppendFormat("ILotSesanryo = {0}, ",iLotSesanryo);
			sbuffer.AppendFormat("IDaySesanryo = {0}, ",iDaySesanryo);
			sbuffer.AppendFormat("IYieldRate = {0}, ",iYieldRate);
			sbuffer.AppendFormat("IFukukbn = {0}, ",iFukukbn);
			sbuffer.AppendFormat("ISgenkbn = {0}, ",iSgenkbn);
			sbuffer.AppendFormat("ITenfuykbn = {0}, ",iTenfuykbn);
			sbuffer.AppendFormat("IDaikoteptn = {0}, ",iDaikoteptn);
			sbuffer.AppendFormat("IDhhigptn = {0}, ",iDhhigptn);
			sbuffer.AppendFormat("IZktkzchBnshi1 = {0}, ",iZktkzchBnshi1);
			sbuffer.AppendFormat("IZktkzchBnbo1 = {0}, ",iZktkzchBnbo1);
			sbuffer.AppendFormat("IZktikzticd1 = {0}, ",iZktikzticd1);
			sbuffer.AppendFormat("IZktkzchBnshi2 = {0}, ",iZktkzchBnshi2);
			sbuffer.AppendFormat("IZktkzchBnbo2 = {0}, ",iZktkzchBnbo2);
			sbuffer.AppendFormat("IZktikzticd2 = {0}, ",iZktikzticd2);
			sbuffer.AppendFormat("IZktkzchBnshi3 = {0}, ",iZktkzchBnshi3);
			sbuffer.AppendFormat("IZktkzchBnbo3 = {0}, ",iZktkzchBnbo3);
			sbuffer.AppendFormat("IZktikzticd3 = {0}, ",iZktikzticd3);
			sbuffer.AppendFormat("IZktkzchBnshi4 = {0}, ",iZktkzchBnshi4);
			sbuffer.AppendFormat("IZktkzchBnbo4 = {0}, ",iZktkzchBnbo4);
			sbuffer.AppendFormat("IZktikzticd4 = {0}, ",iZktikzticd4);
			sbuffer.AppendFormat("IZktkzchBnshi5 = {0}, ",iZktkzchBnshi5);
			sbuffer.AppendFormat("IZktkzchBnbo5 = {0}, ",iZktkzchBnbo5);
			sbuffer.AppendFormat("IZktikzticd5 = {0}, ",iZktikzticd5);
			sbuffer.AppendFormat("IHinksu01 = {0}, ",iHinksu01);
			sbuffer.AppendFormat("IHinksu02 = {0}, ",iHinksu02);
			sbuffer.AppendFormat("IHinksu03 = {0}, ",iHinksu03);
			sbuffer.AppendFormat("IHinksu04 = {0}, ",iHinksu04);
			sbuffer.AppendFormat("IHinksu05 = {0}, ",iHinksu05);
			sbuffer.AppendFormat("IHinksu06 = {0}, ",iHinksu06);
			sbuffer.AppendFormat("IHinksu07 = {0}, ",iHinksu07);
			sbuffer.AppendFormat("IHinksu08 = {0}, ",iHinksu08);
			sbuffer.AppendFormat("IHinksu09 = {0}, ",iHinksu09);
			sbuffer.AppendFormat("IHinksu10 = {0}, ",iHinksu10);
			sbuffer.AppendFormat("IHinbnr01 = {0}, ",iHinbnr01);
			sbuffer.AppendFormat("IHinbnr02 = {0}, ",iHinbnr02);
			sbuffer.AppendFormat("IHinbnr03 = {0}, ",iHinbnr03);
			sbuffer.AppendFormat("IHinbnr04 = {0}, ",iHinbnr04);
			sbuffer.AppendFormat("IHinbnr05 = {0}, ",iHinbnr05);
			sbuffer.AppendFormat("IHinbnr06 = {0}, ",iHinbnr06);
			sbuffer.AppendFormat("IHinbnr07 = {0}, ",iHinbnr07);
			sbuffer.AppendFormat("IHinbnr08 = {0}, ",iHinbnr08);
			sbuffer.AppendFormat("IHinbnr09 = {0}, ",iHinbnr09);
			sbuffer.AppendFormat("IHinbnr10 = {0}, ",iHinbnr10);
			sbuffer.AppendFormat("IJohhtkbn = {0}, ",iJohhtkbn);
			sbuffer.AppendFormat("IHftkbn1 = {0}, ",iHftkbn1);
			sbuffer.AppendFormat("IHftkbn2 = {0}, ",iHftkbn2);
			sbuffer.AppendFormat("IHftkbn3 = {0}, ",iHftkbn3);
			sbuffer.AppendFormat("IHftkbn4 = {0}, ",iHftkbn4);
			sbuffer.AppendFormat("IHftkbn5 = {0}, ",iHftkbn5);
			sbuffer.AppendFormat("ISytsukakbn = {0}, ",iSytsukakbn);
			sbuffer.AppendFormat("ITngmhfkbn = {0}, ",iTngmhfkbn);
			sbuffer.AppendFormat("ITnhkshfkbn = {0}, ",iTnhkshfkbn);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}
