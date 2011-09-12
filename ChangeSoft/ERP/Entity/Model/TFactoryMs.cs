using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_FACTORY_MS' Schema
/*
 * 'TFactoryMs' class maps to 'T_FACTORY_MS' table.
 * 	 I_FAC_CD                | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_COMPANY_CD            | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_BASE_CD               | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_COUNTRY_CD            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_TIMEZONE_CD           | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_LANGUAGE_CD           | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_SECTION_CD            | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_FAC_ARG_DESC          | Type:VARCHAR2  | Len:60    | Nullable:T | PK:F | FK:F
 * 	 I_FAC_DESC              | Type:VARCHAR2  | Len:120   | Nullable:T | PK:F | FK:F
 * 	 I_FAC_DESC_KANA         | Type:VARCHAR2  | Len:30    | Nullable:T | PK:F | FK:F
 * 	 I_MAIL_NO               | Type:VARCHAR2  | Len:10    | Nullable:T | PK:F | FK:F
 * 	 I_ADDRESS1              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADDRESS2              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADDRESS3              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_TEL                   | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_FAX_NO                | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_TAX_CHARGED_CLS       | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_EG_CHG_CLS            | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PLAN_CYC_CLS          | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_WK_TIME               | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_RATE_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PO_CREATE_PERIOD      | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_MRP_PERIOD            | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_PO_CREATE_CLS         | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_ALC_PERIOD            | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_CLS             | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PO_SLC_CLS            | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SAFE_STOCK_CLS        | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_MRP_CLS               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_LINK_FLG              | Type:VARCHAR2  | Len:1     | Nullable:F | PK:F | FK:F
 * 	 I_SHIP_INV_CLS          | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_ACP_INV_CLS           | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_AMT_RECALC_CLS        | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_DATA_SAVE_PATH        | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_LOGIN_USER            | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_LOGIN_PSWD            | Type:VARCHAR2  | Len:30    | Nullable:T | PK:F | FK:F
 * 	 I_DATA_SAVE_PATH_PS     | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_LOGIN_USER_PS         | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_LOGIN_PSWD_PS         | Type:VARCHAR2  | Len:30    | Nullable:T | PK:F | FK:F
 * 	 I_PLAN_CRT_CLS          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_RSLT_CST_CALC_CLS     | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_RESERVE1              | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_RESERVE2              | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_RESERVE3              | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 I_SYS1_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SYS2_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SYS3_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_USR1_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_USR2_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_USR3_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_INQ_ITEM              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_OBJECT_ID             | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/13 2:15:04
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_FACTORY_MS")]
	public class TFactoryMs : ActiveRecordBase	{

		#region Private Members

		private string iFacCd; 
		private string iCompanyCd; 
		private string iBaseCd; 
		private string iCountryCd; 
		private string iTimezoneCd; 
		private string iLanguageCd; 
		private string iSectionCd; 
		private string iFacArgDesc; 
		private string iFacDesc; 
		private string iFacDescKana; 
		private string iMailNo; 
		private string iAddress1; 
		private string iAddress2; 
		private string iAddress3; 
		private string iTel; 
		private string iFaxNo; 
		private string iTaxChargedCls; 
		private string iEgChgCls; 
		private string iPlanCycCls; 
		private decimal iWkTime; 
		private string iRateCls; 
		private decimal iPoCreatePeriod; 
		private decimal iMrpPeriod; 
		private string iPoCreateCls; 
		private decimal iAlcPeriod; 
		private string iSalesCls; 
		private string iPoSlcCls; 
		private string iSafeStockCls; 
		private string iMrpCls; 
		private string iLinkFlg; 
		private string iShipInvCls; 
		private string iAcpInvCls; 
		private string iAmtRecalcCls; 
		private string iDataSavePath; 
		private string iLoginUser; 
		private string iLoginPswd; 
		private string iDataSavePathPs; 
		private string iLoginUserPs; 
		private string iLoginPswdPs; 
		private string iPlanCrtCls; 
		private string iRsltCstCalcCls; 
		private string iReserve1; 
		private string iReserve2; 
		private string iReserve3; 
		private string iSys1Cls; 
		private string iSys2Cls; 
		private string iSys3Cls; 
		private string iUsr1Cls; 
		private string iUsr2Cls; 
		private string iUsr3Cls; 
		private string iInqItem; 
		private decimal iObjectId; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TFactoryMs()
		{
			iFacCd = String.Empty; 
			iCompanyCd = String.Empty; 
			iBaseCd = String.Empty; 
			iCountryCd = String.Empty; 
			iTimezoneCd = String.Empty; 
			iLanguageCd = String.Empty; 
			iSectionCd = String.Empty; 
			iFacArgDesc = String.Empty; 
			iFacDesc = String.Empty; 
			iFacDescKana = String.Empty; 
			iMailNo = String.Empty; 
			iAddress1 = String.Empty; 
			iAddress2 = String.Empty; 
			iAddress3 = String.Empty; 
			iTel = String.Empty; 
			iFaxNo = String.Empty; 
			iTaxChargedCls = String.Empty; 
			iEgChgCls = String.Empty; 
			iPlanCycCls = String.Empty; 
			iWkTime = 0; 
			iRateCls = String.Empty; 
			iPoCreatePeriod = 0; 
			iMrpPeriod = 0; 
			iPoCreateCls = String.Empty; 
			iAlcPeriod = 0; 
			iSalesCls = String.Empty; 
			iPoSlcCls = String.Empty; 
			iSafeStockCls = String.Empty; 
			iMrpCls = String.Empty; 
			iLinkFlg = String.Empty; 
			iShipInvCls = String.Empty; 
			iAcpInvCls = String.Empty; 
			iAmtRecalcCls = String.Empty; 
			iDataSavePath = String.Empty; 
			iLoginUser = String.Empty; 
			iLoginPswd = String.Empty; 
			iDataSavePathPs = String.Empty; 
			iLoginUserPs = String.Empty; 
			iLoginPswdPs = String.Empty; 
			iPlanCrtCls = String.Empty; 
			iRsltCstCalcCls = String.Empty; 
			iReserve1 = String.Empty; 
			iReserve2 = String.Empty; 
			iReserve3 = String.Empty; 
			iSys1Cls = String.Empty; 
			iSys2Cls = String.Empty; 
			iSys3Cls = String.Empty; 
			iUsr1Cls = String.Empty; 
			iUsr2Cls = String.Empty; 
			iUsr3Cls = String.Empty; 
			iInqItem = String.Empty; 
			iObjectId = 0; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iUpdTimestamp = String.Empty; 

		}

		public TFactoryMs(
			string i_fac_cd, 
			string i_company_cd, 
			string i_country_cd, 
			string i_timezone_cd, 
			string i_language_cd, 
			string i_eg_chg_cls, 
			string i_plan_cyc_cls, 
			decimal i_wk_time, 
			string i_rate_cls, 
			decimal i_po_create_period, 
			decimal i_mrp_period, 
			string i_po_create_cls, 
			decimal i_alc_period, 
			string i_sales_cls, 
			string i_po_slc_cls, 
			string i_safe_stock_cls, 
			string i_mrp_cls, 
			string i_link_flg, 
			string i_ship_inv_cls, 
			string i_acp_inv_cls, 
			string i_amt_recalc_cls, 
			string i_sys1_cls, 
			string i_sys2_cls, 
			string i_sys3_cls, 
			string i_usr1_cls, 
			string i_usr2_cls, 
			string i_usr3_cls, 
			DateTime i_entry_date, 
			DateTime i_upd_date, 
			string i_upd_timestamp)
			: this()
		{
			iFacCd = i_fac_cd;
			iCompanyCd = i_company_cd;
			iBaseCd = String.Empty;
			iCountryCd = i_country_cd;
			iTimezoneCd = i_timezone_cd;
			iLanguageCd = i_language_cd;
			iSectionCd = String.Empty;
			iFacArgDesc = String.Empty;
			iFacDesc = String.Empty;
			iFacDescKana = String.Empty;
			iMailNo = String.Empty;
			iAddress1 = String.Empty;
			iAddress2 = String.Empty;
			iAddress3 = String.Empty;
			iTel = String.Empty;
			iFaxNo = String.Empty;
			iTaxChargedCls = String.Empty;
			iEgChgCls = i_eg_chg_cls;
			iPlanCycCls = i_plan_cyc_cls;
			iWkTime = i_wk_time;
			iRateCls = i_rate_cls;
			iPoCreatePeriod = i_po_create_period;
			iMrpPeriod = i_mrp_period;
			iPoCreateCls = i_po_create_cls;
			iAlcPeriod = i_alc_period;
			iSalesCls = i_sales_cls;
			iPoSlcCls = i_po_slc_cls;
			iSafeStockCls = i_safe_stock_cls;
			iMrpCls = i_mrp_cls;
			iLinkFlg = i_link_flg;
			iShipInvCls = i_ship_inv_cls;
			iAcpInvCls = i_acp_inv_cls;
			iAmtRecalcCls = i_amt_recalc_cls;
			iDataSavePath = String.Empty;
			iLoginUser = String.Empty;
			iLoginPswd = String.Empty;
			iDataSavePathPs = String.Empty;
			iLoginUserPs = String.Empty;
			iLoginPswdPs = String.Empty;
			iPlanCrtCls = String.Empty;
			iRsltCstCalcCls = String.Empty;
			iReserve1 = String.Empty;
			iReserve2 = String.Empty;
			iReserve3 = String.Empty;
			iSys1Cls = i_sys1_cls;
			iSys2Cls = i_sys2_cls;
			iSys3Cls = i_sys3_cls;
			iUsr1Cls = i_usr1_cls;
			iUsr2Cls = i_usr2_cls;
			iUsr3Cls = i_usr3_cls;
			iInqItem = String.Empty;
			iObjectId = 0;
			iEntryDate = i_entry_date;
			iUpdDate = i_upd_date;
			iUpdTimestamp = i_upd_timestamp;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties
			
		[PrimaryKey(PrimaryKeyType.Assigned ,"I_FAC_CD", Length=8)]
		public virtual string IFacCd
		{
			get { return iFacCd; }
			set { iFacCd = value; }
		}

		[Property(Column="I_COMPANY_CD", NotNull=true, Length=8)]
		public virtual string ICompanyCd
		{
			get { return iCompanyCd; }
			set { iCompanyCd = value; }
		}

		[Property(Column="I_BASE_CD", Length=8)]
		public virtual string IBaseCd
		{
			get { return iBaseCd; }
			set { iBaseCd = value; }
		}

		[Property(Column="I_COUNTRY_CD", NotNull=true, Length=6)]
		public virtual string ICountryCd
		{
			get { return iCountryCd; }
			set { iCountryCd = value; }
		}

		[Property(Column="I_TIMEZONE_CD", NotNull=true, Length=6)]
		public virtual string ITimezoneCd
		{
			get { return iTimezoneCd; }
			set { iTimezoneCd = value; }
		}

		[Property(Column="I_LANGUAGE_CD", NotNull=true, Length=6)]
		public virtual string ILanguageCd
		{
			get { return iLanguageCd; }
			set { iLanguageCd = value; }
		}

		[Property(Column="I_SECTION_CD", Length=8)]
		public virtual string ISectionCd
		{
			get { return iSectionCd; }
			set { iSectionCd = value; }
		}

		[Property(Column="I_FAC_ARG_DESC", Length=60)]
		public virtual string IFacArgDesc
		{
			get { return iFacArgDesc; }
			set { iFacArgDesc = value; }
		}

		[Property(Column="I_FAC_DESC", Length=120)]
		public virtual string IFacDesc
		{
			get { return iFacDesc; }
			set { iFacDesc = value; }
		}

		[Property(Column="I_FAC_DESC_KANA", Length=30)]
		public virtual string IFacDescKana
		{
			get { return iFacDescKana; }
			set { iFacDescKana = value; }
		}

		[Property(Column="I_MAIL_NO", Length=10)]
		public virtual string IMailNo
		{
			get { return iMailNo; }
			set { iMailNo = value; }
		}

		[Property(Column="I_ADDRESS1", Length=80)]
		public virtual string IAddress1
		{
			get { return iAddress1; }
			set { iAddress1 = value; }
		}

		[Property(Column="I_ADDRESS2", Length=80)]
		public virtual string IAddress2
		{
			get { return iAddress2; }
			set { iAddress2 = value; }
		}

		[Property(Column="I_ADDRESS3", Length=80)]
		public virtual string IAddress3
		{
			get { return iAddress3; }
			set { iAddress3 = value; }
		}

		[Property(Column="I_TEL", Length=20)]
		public virtual string ITel
		{
			get { return iTel; }
			set { iTel = value; }
		}

		[Property(Column="I_FAX_NO", Length=20)]
		public virtual string IFaxNo
		{
			get { return iFaxNo; }
			set { iFaxNo = value; }
		}

		[Property(Column="I_TAX_CHARGED_CLS", Length=2)]
		public virtual string ITaxChargedCls
		{
			get { return iTaxChargedCls; }
			set { iTaxChargedCls = value; }
		}

		[Property(Column="I_EG_CHG_CLS", NotNull=true, Length=2)]
		public virtual string IEgChgCls
		{
			get { return iEgChgCls; }
			set { iEgChgCls = value; }
		}

		[Property(Column="I_PLAN_CYC_CLS", NotNull=true, Length=2)]
		public virtual string IPlanCycCls
		{
			get { return iPlanCycCls; }
			set { iPlanCycCls = value; }
		}

		[Property(Column="I_WK_TIME", NotNull=true)]
		public virtual decimal IWkTime
		{
			get { return iWkTime; }
			set { iWkTime = value; }
		}

		[Property(Column="I_RATE_CLS", NotNull=true, Length=2)]
		public virtual string IRateCls
		{
			get { return iRateCls; }
			set { iRateCls = value; }
		}

		[Property(Column="I_PO_CREATE_PERIOD", NotNull=true)]
		public virtual decimal IPoCreatePeriod
		{
			get { return iPoCreatePeriod; }
			set { iPoCreatePeriod = value; }
		}

		[Property(Column="I_MRP_PERIOD", NotNull=true)]
		public virtual decimal IMrpPeriod
		{
			get { return iMrpPeriod; }
			set { iMrpPeriod = value; }
		}

		[Property(Column="I_PO_CREATE_CLS", NotNull=true, Length=2)]
		public virtual string IPoCreateCls
		{
			get { return iPoCreateCls; }
			set { iPoCreateCls = value; }
		}

		[Property(Column="I_ALC_PERIOD", NotNull=true)]
		public virtual decimal IAlcPeriod
		{
			get { return iAlcPeriod; }
			set { iAlcPeriod = value; }
		}

		[Property(Column="I_SALES_CLS", NotNull=true, Length=2)]
		public virtual string ISalesCls
		{
			get { return iSalesCls; }
			set { iSalesCls = value; }
		}

		[Property(Column="I_PO_SLC_CLS", NotNull=true, Length=2)]
		public virtual string IPoSlcCls
		{
			get { return iPoSlcCls; }
			set { iPoSlcCls = value; }
		}

		[Property(Column="I_SAFE_STOCK_CLS", NotNull=true, Length=2)]
		public virtual string ISafeStockCls
		{
			get { return iSafeStockCls; }
			set { iSafeStockCls = value; }
		}

		[Property(Column="I_MRP_CLS", NotNull=true, Length=2)]
		public virtual string IMrpCls
		{
			get { return iMrpCls; }
			set { iMrpCls = value; }
		}

		[Property(Column="I_LINK_FLG", NotNull=true, Length=1)]
		public virtual string ILinkFlg
		{
			get { return iLinkFlg; }
			set { iLinkFlg = value; }
		}

		[Property(Column="I_SHIP_INV_CLS", NotNull=true, Length=2)]
		public virtual string IShipInvCls
		{
			get { return iShipInvCls; }
			set { iShipInvCls = value; }
		}

		[Property(Column="I_ACP_INV_CLS", NotNull=true, Length=2)]
		public virtual string IAcpInvCls
		{
			get { return iAcpInvCls; }
			set { iAcpInvCls = value; }
		}

		[Property(Column="I_AMT_RECALC_CLS", NotNull=true, Length=2)]
		public virtual string IAmtRecalcCls
		{
			get { return iAmtRecalcCls; }
			set { iAmtRecalcCls = value; }
		}

		[Property(Column="I_DATA_SAVE_PATH", Length=256)]
		public virtual string IDataSavePath
		{
			get { return iDataSavePath; }
			set { iDataSavePath = value; }
		}

		[Property(Column="I_LOGIN_USER", Length=20)]
		public virtual string ILoginUser
		{
			get { return iLoginUser; }
			set { iLoginUser = value; }
		}

		[Property(Column="I_LOGIN_PSWD", Length=30)]
		public virtual string ILoginPswd
		{
			get { return iLoginPswd; }
			set { iLoginPswd = value; }
		}

		[Property(Column="I_DATA_SAVE_PATH_PS", Length=256)]
		public virtual string IDataSavePathPs
		{
			get { return iDataSavePathPs; }
			set { iDataSavePathPs = value; }
		}

		[Property(Column="I_LOGIN_USER_PS", Length=20)]
		public virtual string ILoginUserPs
		{
			get { return iLoginUserPs; }
			set { iLoginUserPs = value; }
		}

		[Property(Column="I_LOGIN_PSWD_PS", Length=30)]
		public virtual string ILoginPswdPs
		{
			get { return iLoginPswdPs; }
			set { iLoginPswdPs = value; }
		}

		[Property(Column="I_PLAN_CRT_CLS", Length=2)]
		public virtual string IPlanCrtCls
		{
			get { return iPlanCrtCls; }
			set { iPlanCrtCls = value; }
		}

		[Property(Column="I_RSLT_CST_CALC_CLS", Length=2)]
		public virtual string IRsltCstCalcCls
		{
			get { return iRsltCstCalcCls; }
			set { iRsltCstCalcCls = value; }
		}

		[Property(Column="I_RESERVE1", Length=20)]
		public virtual string IReserve1
		{
			get { return iReserve1; }
			set { iReserve1 = value; }
		}

		[Property(Column="I_RESERVE2", Length=20)]
		public virtual string IReserve2
		{
			get { return iReserve2; }
			set { iReserve2 = value; }
		}

		[Property(Column="I_RESERVE3", Length=20)]
		public virtual string IReserve3
		{
			get { return iReserve3; }
			set { iReserve3 = value; }
		}

		[Property(Column="I_SYS1_CLS", NotNull=true, Length=2)]
		public virtual string ISys1Cls
		{
			get { return iSys1Cls; }
			set { iSys1Cls = value; }
		}

		[Property(Column="I_SYS2_CLS", NotNull=true, Length=2)]
		public virtual string ISys2Cls
		{
			get { return iSys2Cls; }
			set { iSys2Cls = value; }
		}

		[Property(Column="I_SYS3_CLS", NotNull=true, Length=2)]
		public virtual string ISys3Cls
		{
			get { return iSys3Cls; }
			set { iSys3Cls = value; }
		}

		[Property(Column="I_USR1_CLS", NotNull=true, Length=2)]
		public virtual string IUsr1Cls
		{
			get { return iUsr1Cls; }
			set { iUsr1Cls = value; }
		}

		[Property(Column="I_USR2_CLS", NotNull=true, Length=2)]
		public virtual string IUsr2Cls
		{
			get { return iUsr2Cls; }
			set { iUsr2Cls = value; }
		}

		[Property(Column="I_USR3_CLS", NotNull=true, Length=2)]
		public virtual string IUsr3Cls
		{
			get { return iUsr3Cls; }
			set { iUsr3Cls = value; }
		}

		[Property(Column="I_INQ_ITEM", Length=1)]
		public virtual string IInqItem
		{
			get { return iInqItem; }
			set { iInqItem = value; }
		}

		[Property(Column="I_OBJECT_ID")]
		public virtual decimal IObjectId
		{
			get { return iObjectId; }
			set { iObjectId = value; }
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
			TFactoryMs castObj = (TFactoryMs)obj; 
			return ( castObj != null ) &&
				( this.iFacCd == castObj.IFacCd );
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * iFacCd.GetHashCode();
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
			sbuffer.AppendFormat("ICompanyCd = {0}, ",iCompanyCd);
			sbuffer.AppendFormat("IBaseCd = {0}, ",iBaseCd);
			sbuffer.AppendFormat("ICountryCd = {0}, ",iCountryCd);
			sbuffer.AppendFormat("ITimezoneCd = {0}, ",iTimezoneCd);
			sbuffer.AppendFormat("ILanguageCd = {0}, ",iLanguageCd);
			sbuffer.AppendFormat("ISectionCd = {0}, ",iSectionCd);
			sbuffer.AppendFormat("IFacArgDesc = {0}, ",iFacArgDesc);
			sbuffer.AppendFormat("IFacDesc = {0}, ",iFacDesc);
			sbuffer.AppendFormat("IFacDescKana = {0}, ",iFacDescKana);
			sbuffer.AppendFormat("IMailNo = {0}, ",iMailNo);
			sbuffer.AppendFormat("IAddress1 = {0}, ",iAddress1);
			sbuffer.AppendFormat("IAddress2 = {0}, ",iAddress2);
			sbuffer.AppendFormat("IAddress3 = {0}, ",iAddress3);
			sbuffer.AppendFormat("ITel = {0}, ",iTel);
			sbuffer.AppendFormat("IFaxNo = {0}, ",iFaxNo);
			sbuffer.AppendFormat("ITaxChargedCls = {0}, ",iTaxChargedCls);
			sbuffer.AppendFormat("IEgChgCls = {0}, ",iEgChgCls);
			sbuffer.AppendFormat("IPlanCycCls = {0}, ",iPlanCycCls);
			sbuffer.AppendFormat("IWkTime = {0}, ",iWkTime);
			sbuffer.AppendFormat("IRateCls = {0}, ",iRateCls);
			sbuffer.AppendFormat("IPoCreatePeriod = {0}, ",iPoCreatePeriod);
			sbuffer.AppendFormat("IMrpPeriod = {0}, ",iMrpPeriod);
			sbuffer.AppendFormat("IPoCreateCls = {0}, ",iPoCreateCls);
			sbuffer.AppendFormat("IAlcPeriod = {0}, ",iAlcPeriod);
			sbuffer.AppendFormat("ISalesCls = {0}, ",iSalesCls);
			sbuffer.AppendFormat("IPoSlcCls = {0}, ",iPoSlcCls);
			sbuffer.AppendFormat("ISafeStockCls = {0}, ",iSafeStockCls);
			sbuffer.AppendFormat("IMrpCls = {0}, ",iMrpCls);
			sbuffer.AppendFormat("ILinkFlg = {0}, ",iLinkFlg);
			sbuffer.AppendFormat("IShipInvCls = {0}, ",iShipInvCls);
			sbuffer.AppendFormat("IAcpInvCls = {0}, ",iAcpInvCls);
			sbuffer.AppendFormat("IAmtRecalcCls = {0}, ",iAmtRecalcCls);
			sbuffer.AppendFormat("IDataSavePath = {0}, ",iDataSavePath);
			sbuffer.AppendFormat("ILoginUser = {0}, ",iLoginUser);
			sbuffer.AppendFormat("ILoginPswd = {0}, ",iLoginPswd);
			sbuffer.AppendFormat("IDataSavePathPs = {0}, ",iDataSavePathPs);
			sbuffer.AppendFormat("ILoginUserPs = {0}, ",iLoginUserPs);
			sbuffer.AppendFormat("ILoginPswdPs = {0}, ",iLoginPswdPs);
			sbuffer.AppendFormat("IPlanCrtCls = {0}, ",iPlanCrtCls);
			sbuffer.AppendFormat("IRsltCstCalcCls = {0}, ",iRsltCstCalcCls);
			sbuffer.AppendFormat("IReserve1 = {0}, ",iReserve1);
			sbuffer.AppendFormat("IReserve2 = {0}, ",iReserve2);
			sbuffer.AppendFormat("IReserve3 = {0}, ",iReserve3);
			sbuffer.AppendFormat("ISys1Cls = {0}, ",iSys1Cls);
			sbuffer.AppendFormat("ISys2Cls = {0}, ",iSys2Cls);
			sbuffer.AppendFormat("ISys3Cls = {0}, ",iSys3Cls);
			sbuffer.AppendFormat("IUsr1Cls = {0}, ",iUsr1Cls);
			sbuffer.AppendFormat("IUsr2Cls = {0}, ",iUsr2Cls);
			sbuffer.AppendFormat("IUsr3Cls = {0}, ",iUsr3Cls);
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
