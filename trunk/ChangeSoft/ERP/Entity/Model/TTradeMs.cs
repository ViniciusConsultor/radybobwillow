using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_TRADE_MS' Schema
/*
 * 'TTradeMs' class maps to 'T_TRADE_MS' table.
 * 	 I_COMPANY_CD            | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_DL_CD                 | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_DL_ARG_DESC           | Type:VARCHAR2  | Len:60    | Nullable:T | PK:F | FK:F
 * 	 I_DL_DESC               | Type:VARCHAR2  | Len:120   | Nullable:T | PK:F | FK:F
 * 	 I_DL_DESC_KANA          | Type:VARCHAR2  | Len:30    | Nullable:T | PK:F | FK:F
 * 	 I_DL_TYPE               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_MAIL_NO               | Type:VARCHAR2  | Len:10    | Nullable:F | PK:F | FK:F
 * 	 I_ADDRESS1              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADDRESS2              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADDRESS3              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_TEL                   | Type:VARCHAR2  | Len:20    | Nullable:F | PK:F | FK:F
 * 	 I_FAX_NO                | Type:VARCHAR2  | Len:20    | Nullable:F | PK:F | FK:F
 * 	 I_MAILADR               | Type:VARCHAR2  | Len:100   | Nullable:T | PK:F | FK:F
 * 	 I_MAILFLG               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SEKJFLG               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_DXFFLG                | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_DL_CURR_CD            | Type:VARCHAR2  | Len:4     | Nullable:T | PK:F | FK:F
 * 	 I_TRANSFER_LT           | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_DO_ISSUE_CLS          | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_CHARGED_SPLY_CLS      | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_TAX_CHARGED_CLS       | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_UP_CLS          | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_FRC_CLS         | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_TAX_CALC_CLS    | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_TAX_FRC_CLS     | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_TAX_CLS         | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_SALES_SLIP_ISSUE_CLS  | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_TRADE_UP_CLS    | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_CLS             | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_SECTION         | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_AR_TYPE               | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_HOLD_SO_ADD_CLS       | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HOLD_SO_CHG_CLS       | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_HOLD_SO_DEL_CLS       | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_VALI_TRADE_ITEM_CLS   | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_VALI_UP_CLS           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_SEND_ASN_CLS          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_PUR_UP_CLS            | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PUR_FRC_CLS           | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PUR_TAX_CALC_CLS      | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PUR_TAX_FRC_CLS       | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PUR_TAX_CLS           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_PO_ISSUE_CLS          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_PUR_TRADE_UP_CLS      | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_VOU_CLS               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_VALI_ASN_CLS          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_PURCHASE_SECTION      | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_AP_TYPE               | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_ITEM_TYPE1            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE2            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE3            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE4            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE5            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE6            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_SPLY_APP_CLS          | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_COUNTRY_CD            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_LANGUAGE_CD           | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_SHANGKBN              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_SUBCON_OBJ_CLS        | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_OBJ_FAC_CD            | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_INV_DEST_CD           | Type:VARCHAR2  | Len:12    | Nullable:T | PK:F | FK:F
 * 	 I_PAY_DEST_CD           | Type:VARCHAR2  | Len:12    | Nullable:T | PK:F | FK:F
 * 	 I_INQ_ITEM              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_OBJECT_ID             | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/12 15:41:41
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_TRADE_MS")]
	public class TTradeMs : ActiveRecordBase	{

		#region Private Members

        private TTradeMsId id;

        private string iDlArgDesc; 
		private string iDlDesc; 
		private string iDlDescKana; 
		private string iDlType; 
		private string iMailNo; 
		private string iAddress1; 
		private string iAddress2; 
		private string iAddress3; 
		private string iTel; 
		private string iFaxNo; 
		private string iMailadr; 
		private string iMailflg; 
		private string iSekjflg; 
		private string iDxfflg; 
		private string iDlCurrCd; 
		private decimal iTransferLt; 
		private string iDoIssueCls; 
		private string iChargedSplyCls; 
		private string iTaxChargedCls; 
		private string iSalesUpCls; 
		private string iSalesFrcCls; 
		private string iSalesTaxCalcCls; 
		private string iSalesTaxFrcCls; 
		private string iSalesTaxCls; 
		private string iSalesSlipIssueCls; 
		private string iSalesTradeUpCls; 
		private string iSalesCls; 
		private string iSalesSection; 
		private string iArType; 
		private string iHoldSoAddCls; 
		private string iHoldSoChgCls; 
		private string iHoldSoDelCls; 
		private string iValiTradeItemCls; 
		private string iValiUpCls; 
		private string iSendAsnCls; 
		private string iPurUpCls; 
		private string iPurFrcCls; 
		private string iPurTaxCalcCls; 
		private string iPurTaxFrcCls; 
		private string iPurTaxCls; 
		private string iPoIssueCls; 
		private string iPurTradeUpCls; 
		private string iVouCls; 
		private string iValiAsnCls; 
		private string iPurchaseSection; 
		private string iApType; 
		private string iItemType1; 
		private string iItemType2; 
		private string iItemType3; 
		private string iItemType4; 
		private string iItemType5; 
		private string iItemType6; 
		private string iSplyAppCls; 
		private string iCountryCd; 
		private string iLanguageCd; 
		private string iShangkbn; 
		private string iSubconObjCls; 
		private string iObjFacCd; 
		private string iInvDestCd; 
		private string iPayDestCd; 
		private string iInqItem; 
		private decimal iObjectId; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TTradeMs()
		{
            id = new TTradeMsId();
			iDlArgDesc = String.Empty; 
			iDlDesc = String.Empty; 
			iDlDescKana = String.Empty; 
			iDlType = String.Empty; 
			iMailNo = String.Empty; 
			iAddress1 = String.Empty; 
			iAddress2 = String.Empty; 
			iAddress3 = String.Empty; 
			iTel = String.Empty; 
			iFaxNo = String.Empty; 
			iMailadr = String.Empty; 
			iMailflg = String.Empty; 
			iSekjflg = String.Empty; 
			iDxfflg = String.Empty; 
			iDlCurrCd = String.Empty; 
			iTransferLt = 0; 
			iDoIssueCls = String.Empty; 
			iChargedSplyCls = String.Empty; 
			iTaxChargedCls = String.Empty; 
			iSalesUpCls = String.Empty; 
			iSalesFrcCls = String.Empty; 
			iSalesTaxCalcCls = String.Empty; 
			iSalesTaxFrcCls = String.Empty; 
			iSalesTaxCls = String.Empty; 
			iSalesSlipIssueCls = String.Empty; 
			iSalesTradeUpCls = String.Empty; 
			iSalesCls = String.Empty; 
			iSalesSection = String.Empty; 
			iArType = String.Empty; 
			iHoldSoAddCls = String.Empty; 
			iHoldSoChgCls = String.Empty; 
			iHoldSoDelCls = String.Empty; 
			iValiTradeItemCls = String.Empty; 
			iValiUpCls = String.Empty; 
			iSendAsnCls = String.Empty; 
			iPurUpCls = String.Empty; 
			iPurFrcCls = String.Empty; 
			iPurTaxCalcCls = String.Empty; 
			iPurTaxFrcCls = String.Empty; 
			iPurTaxCls = String.Empty; 
			iPoIssueCls = String.Empty; 
			iPurTradeUpCls = String.Empty; 
			iVouCls = String.Empty; 
			iValiAsnCls = String.Empty; 
			iPurchaseSection = String.Empty; 
			iApType = String.Empty; 
			iItemType1 = String.Empty; 
			iItemType2 = String.Empty; 
			iItemType3 = String.Empty; 
			iItemType4 = String.Empty; 
			iItemType5 = String.Empty; 
			iItemType6 = String.Empty; 
			iSplyAppCls = String.Empty; 
			iCountryCd = String.Empty; 
			iLanguageCd = String.Empty; 
			iShangkbn = String.Empty; 
			iSubconObjCls = String.Empty; 
			iObjFacCd = String.Empty; 
			iInvDestCd = String.Empty; 
			iPayDestCd = String.Empty; 
			iInqItem = String.Empty; 
			iObjectId = 0; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iUpdTimestamp = String.Empty; 

		}

		public TTradeMs(
			string i_company_cd, 
			string i_dl_cd, 
			string i_dl_type, 
			string i_mail_no, 
			string i_tel, 
			string i_fax_no, 
			string i_mailflg, 
			string i_sekjflg, 
			string i_dxfflg, 
			decimal i_transfer_lt, 
			string i_do_issue_cls, 
			string i_charged_sply_cls, 
			string i_tax_charged_cls, 
			string i_sales_up_cls, 
			string i_sales_frc_cls, 
			string i_sales_tax_calc_cls, 
			string i_sales_tax_frc_cls, 
			string i_sales_slip_issue_cls, 
			string i_sales_trade_up_cls, 
			string i_sales_cls, 
			string i_pur_up_cls, 
			string i_pur_frc_cls, 
			string i_pur_tax_calc_cls, 
			string i_pur_tax_frc_cls, 
			string i_pur_trade_up_cls, 
			string i_vou_cls, 
			string i_item_type1, 
			string i_item_type2, 
			string i_item_type3, 
			string i_item_type4, 
			string i_item_type5, 
			string i_item_type6, 
			string i_sply_app_cls, 
			string i_country_cd, 
			string i_language_cd, 
			DateTime i_entry_date, 
			DateTime i_upd_date, 
			string i_upd_timestamp)
			: this()
		{
            id = new TTradeMsId(i_company_cd, i_dl_cd);
			iDlArgDesc = String.Empty;
			iDlDesc = String.Empty;
			iDlDescKana = String.Empty;
			iDlType = i_dl_type;
			iMailNo = i_mail_no;
			iAddress1 = String.Empty;
			iAddress2 = String.Empty;
			iAddress3 = String.Empty;
			iTel = i_tel;
			iFaxNo = i_fax_no;
			iMailadr = String.Empty;
			iMailflg = i_mailflg;
			iSekjflg = i_sekjflg;
			iDxfflg = i_dxfflg;
			iDlCurrCd = String.Empty;
			iTransferLt = i_transfer_lt;
			iDoIssueCls = i_do_issue_cls;
			iChargedSplyCls = i_charged_sply_cls;
			iTaxChargedCls = i_tax_charged_cls;
			iSalesUpCls = i_sales_up_cls;
			iSalesFrcCls = i_sales_frc_cls;
			iSalesTaxCalcCls = i_sales_tax_calc_cls;
			iSalesTaxFrcCls = i_sales_tax_frc_cls;
			iSalesTaxCls = String.Empty;
			iSalesSlipIssueCls = i_sales_slip_issue_cls;
			iSalesTradeUpCls = i_sales_trade_up_cls;
			iSalesCls = i_sales_cls;
			iSalesSection = String.Empty;
			iArType = String.Empty;
			iHoldSoAddCls = String.Empty;
			iHoldSoChgCls = String.Empty;
			iHoldSoDelCls = String.Empty;
			iValiTradeItemCls = String.Empty;
			iValiUpCls = String.Empty;
			iSendAsnCls = String.Empty;
			iPurUpCls = i_pur_up_cls;
			iPurFrcCls = i_pur_frc_cls;
			iPurTaxCalcCls = i_pur_tax_calc_cls;
			iPurTaxFrcCls = i_pur_tax_frc_cls;
			iPurTaxCls = String.Empty;
			iPoIssueCls = String.Empty;
			iPurTradeUpCls = i_pur_trade_up_cls;
			iVouCls = i_vou_cls;
			iValiAsnCls = String.Empty;
			iPurchaseSection = String.Empty;
			iApType = String.Empty;
			iItemType1 = i_item_type1;
			iItemType2 = i_item_type2;
			iItemType3 = i_item_type3;
			iItemType4 = i_item_type4;
			iItemType5 = i_item_type5;
			iItemType6 = i_item_type6;
			iSplyAppCls = i_sply_app_cls;
			iCountryCd = i_country_cd;
			iLanguageCd = i_language_cd;
			iShangkbn = String.Empty;
			iSubconObjCls = String.Empty;
			iObjFacCd = String.Empty;
			iInvDestCd = String.Empty;
			iPayDestCd = String.Empty;
			iInqItem = String.Empty;
			iObjectId = 0;
			iEntryDate = i_entry_date;
			iUpdDate = i_upd_date;
			iUpdTimestamp = i_upd_timestamp;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties

        [CompositeKey]
        public TTradeMsId Id
        {
            get { return id; }
            set { id = value; }
        }

		[Property(Column="I_DL_ARG_DESC", Length=60)]
		public virtual string IDlArgDesc
		{
			get { return iDlArgDesc; }
			set { iDlArgDesc = value; }
		}

		[Property(Column="I_DL_DESC", Length=120)]
		public virtual string IDlDesc
		{
			get { return iDlDesc; }
			set { iDlDesc = value; }
		}

		[Property(Column="I_DL_DESC_KANA", Length=30)]
		public virtual string IDlDescKana
		{
			get { return iDlDescKana; }
			set { iDlDescKana = value; }
		}

		[Property(Column="I_DL_TYPE", NotNull=true, Length=2)]
		public virtual string IDlType
		{
			get { return iDlType; }
			set { iDlType = value; }
		}

		[Property(Column="I_MAIL_NO", NotNull=true, Length=10)]
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

		[Property(Column="I_TEL", NotNull=true, Length=20)]
		public virtual string ITel
		{
			get { return iTel; }
			set { iTel = value; }
		}

		[Property(Column="I_FAX_NO", NotNull=true, Length=20)]
		public virtual string IFaxNo
		{
			get { return iFaxNo; }
			set { iFaxNo = value; }
		}

		[Property(Column="I_MAILADR", Length=100)]
		public virtual string IMailadr
		{
			get { return iMailadr; }
			set { iMailadr = value; }
		}

		[Property(Column="I_MAILFLG", NotNull=true, Length=2)]
		public virtual string IMailflg
		{
			get { return iMailflg; }
			set { iMailflg = value; }
		}

		[Property(Column="I_SEKJFLG", NotNull=true, Length=2)]
		public virtual string ISekjflg
		{
			get { return iSekjflg; }
			set { iSekjflg = value; }
		}

		[Property(Column="I_DXFFLG", NotNull=true, Length=2)]
		public virtual string IDxfflg
		{
			get { return iDxfflg; }
			set { iDxfflg = value; }
		}

		[Property(Column="I_DL_CURR_CD", Length=4)]
		public virtual string IDlCurrCd
		{
			get { return iDlCurrCd; }
			set { iDlCurrCd = value; }
		}

		[Property(Column="I_TRANSFER_LT", NotNull=true)]
		public virtual decimal ITransferLt
		{
			get { return iTransferLt; }
			set { iTransferLt = value; }
		}

		[Property(Column="I_DO_ISSUE_CLS", NotNull=true, Length=2)]
		public virtual string IDoIssueCls
		{
			get { return iDoIssueCls; }
			set { iDoIssueCls = value; }
		}

		[Property(Column="I_CHARGED_SPLY_CLS", NotNull=true, Length=2)]
		public virtual string IChargedSplyCls
		{
			get { return iChargedSplyCls; }
			set { iChargedSplyCls = value; }
		}

		[Property(Column="I_TAX_CHARGED_CLS", NotNull=true, Length=2)]
		public virtual string ITaxChargedCls
		{
			get { return iTaxChargedCls; }
			set { iTaxChargedCls = value; }
		}

		[Property(Column="I_SALES_UP_CLS", NotNull=true, Length=2)]
		public virtual string ISalesUpCls
		{
			get { return iSalesUpCls; }
			set { iSalesUpCls = value; }
		}

		[Property(Column="I_SALES_FRC_CLS", NotNull=true, Length=2)]
		public virtual string ISalesFrcCls
		{
			get { return iSalesFrcCls; }
			set { iSalesFrcCls = value; }
		}

		[Property(Column="I_SALES_TAX_CALC_CLS", NotNull=true, Length=2)]
		public virtual string ISalesTaxCalcCls
		{
			get { return iSalesTaxCalcCls; }
			set { iSalesTaxCalcCls = value; }
		}

		[Property(Column="I_SALES_TAX_FRC_CLS", NotNull=true, Length=2)]
		public virtual string ISalesTaxFrcCls
		{
			get { return iSalesTaxFrcCls; }
			set { iSalesTaxFrcCls = value; }
		}

		[Property(Column="I_SALES_TAX_CLS", Length=2)]
		public virtual string ISalesTaxCls
		{
			get { return iSalesTaxCls; }
			set { iSalesTaxCls = value; }
		}

		[Property(Column="I_SALES_SLIP_ISSUE_CLS", NotNull=true, Length=2)]
		public virtual string ISalesSlipIssueCls
		{
			get { return iSalesSlipIssueCls; }
			set { iSalesSlipIssueCls = value; }
		}

		[Property(Column="I_SALES_TRADE_UP_CLS", NotNull=true, Length=2)]
		public virtual string ISalesTradeUpCls
		{
			get { return iSalesTradeUpCls; }
			set { iSalesTradeUpCls = value; }
		}

		[Property(Column="I_SALES_CLS", NotNull=true, Length=2)]
		public virtual string ISalesCls
		{
			get { return iSalesCls; }
			set { iSalesCls = value; }
		}

		[Property(Column="I_SALES_SECTION", Length=8)]
		public virtual string ISalesSection
		{
			get { return iSalesSection; }
			set { iSalesSection = value; }
		}

		[Property(Column="I_AR_TYPE", Length=6)]
		public virtual string IArType
		{
			get { return iArType; }
			set { iArType = value; }
		}

		[Property(Column="I_HOLD_SO_ADD_CLS", Length=2)]
		public virtual string IHoldSoAddCls
		{
			get { return iHoldSoAddCls; }
			set { iHoldSoAddCls = value; }
		}

		[Property(Column="I_HOLD_SO_CHG_CLS", Length=2)]
		public virtual string IHoldSoChgCls
		{
			get { return iHoldSoChgCls; }
			set { iHoldSoChgCls = value; }
		}

		[Property(Column="I_HOLD_SO_DEL_CLS", Length=2)]
		public virtual string IHoldSoDelCls
		{
			get { return iHoldSoDelCls; }
			set { iHoldSoDelCls = value; }
		}

		[Property(Column="I_VALI_TRADE_ITEM_CLS", Length=2)]
		public virtual string IValiTradeItemCls
		{
			get { return iValiTradeItemCls; }
			set { iValiTradeItemCls = value; }
		}

		[Property(Column="I_VALI_UP_CLS", Length=2)]
		public virtual string IValiUpCls
		{
			get { return iValiUpCls; }
			set { iValiUpCls = value; }
		}

		[Property(Column="I_SEND_ASN_CLS", Length=2)]
		public virtual string ISendAsnCls
		{
			get { return iSendAsnCls; }
			set { iSendAsnCls = value; }
		}

		[Property(Column="I_PUR_UP_CLS", NotNull=true, Length=2)]
		public virtual string IPurUpCls
		{
			get { return iPurUpCls; }
			set { iPurUpCls = value; }
		}

		[Property(Column="I_PUR_FRC_CLS", NotNull=true, Length=2)]
		public virtual string IPurFrcCls
		{
			get { return iPurFrcCls; }
			set { iPurFrcCls = value; }
		}

		[Property(Column="I_PUR_TAX_CALC_CLS", NotNull=true, Length=2)]
		public virtual string IPurTaxCalcCls
		{
			get { return iPurTaxCalcCls; }
			set { iPurTaxCalcCls = value; }
		}

		[Property(Column="I_PUR_TAX_FRC_CLS", NotNull=true, Length=2)]
		public virtual string IPurTaxFrcCls
		{
			get { return iPurTaxFrcCls; }
			set { iPurTaxFrcCls = value; }
		}

		[Property(Column="I_PUR_TAX_CLS", Length=2)]
		public virtual string IPurTaxCls
		{
			get { return iPurTaxCls; }
			set { iPurTaxCls = value; }
		}

		[Property(Column="I_PO_ISSUE_CLS", Length=2)]
		public virtual string IPoIssueCls
		{
			get { return iPoIssueCls; }
			set { iPoIssueCls = value; }
		}

		[Property(Column="I_PUR_TRADE_UP_CLS", NotNull=true, Length=2)]
		public virtual string IPurTradeUpCls
		{
			get { return iPurTradeUpCls; }
			set { iPurTradeUpCls = value; }
		}

		[Property(Column="I_VOU_CLS", NotNull=true, Length=2)]
		public virtual string IVouCls
		{
			get { return iVouCls; }
			set { iVouCls = value; }
		}

		[Property(Column="I_VALI_ASN_CLS", Length=2)]
		public virtual string IValiAsnCls
		{
			get { return iValiAsnCls; }
			set { iValiAsnCls = value; }
		}

		[Property(Column="I_PURCHASE_SECTION", Length=8)]
		public virtual string IPurchaseSection
		{
			get { return iPurchaseSection; }
			set { iPurchaseSection = value; }
		}

		[Property(Column="I_AP_TYPE", Length=6)]
		public virtual string IApType
		{
			get { return iApType; }
			set { iApType = value; }
		}

		[Property(Column="I_ITEM_TYPE1", NotNull=true, Length=6)]
		public virtual string IItemType1
		{
			get { return iItemType1; }
			set { iItemType1 = value; }
		}

		[Property(Column="I_ITEM_TYPE2", NotNull=true, Length=6)]
		public virtual string IItemType2
		{
			get { return iItemType2; }
			set { iItemType2 = value; }
		}

		[Property(Column="I_ITEM_TYPE3", NotNull=true, Length=6)]
		public virtual string IItemType3
		{
			get { return iItemType3; }
			set { iItemType3 = value; }
		}

		[Property(Column="I_ITEM_TYPE4", NotNull=true, Length=6)]
		public virtual string IItemType4
		{
			get { return iItemType4; }
			set { iItemType4 = value; }
		}

		[Property(Column="I_ITEM_TYPE5", NotNull=true, Length=6)]
		public virtual string IItemType5
		{
			get { return iItemType5; }
			set { iItemType5 = value; }
		}

		[Property(Column="I_ITEM_TYPE6", NotNull=true, Length=6)]
		public virtual string IItemType6
		{
			get { return iItemType6; }
			set { iItemType6 = value; }
		}

		[Property(Column="I_SPLY_APP_CLS", NotNull=true, Length=2)]
		public virtual string ISplyAppCls
		{
			get { return iSplyAppCls; }
			set { iSplyAppCls = value; }
		}

		[Property(Column="I_COUNTRY_CD", NotNull=true, Length=6)]
		public virtual string ICountryCd
		{
			get { return iCountryCd; }
			set { iCountryCd = value; }
		}

		[Property(Column="I_LANGUAGE_CD", NotNull=true, Length=6)]
		public virtual string ILanguageCd
		{
			get { return iLanguageCd; }
			set { iLanguageCd = value; }
		}

		[Property(Column="I_SHANGKBN", Length=1)]
		public virtual string IShangkbn
		{
			get { return iShangkbn; }
			set { iShangkbn = value; }
		}

		[Property(Column="I_SUBCON_OBJ_CLS", Length=2)]
		public virtual string ISubconObjCls
		{
			get { return iSubconObjCls; }
			set { iSubconObjCls = value; }
		}

		[Property(Column="I_OBJ_FAC_CD", Length=8)]
		public virtual string IObjFacCd
		{
			get { return iObjFacCd; }
			set { iObjFacCd = value; }
		}

		[Property(Column="I_INV_DEST_CD", Length=12)]
		public virtual string IInvDestCd
		{
			get { return iInvDestCd; }
			set { iInvDestCd = value; }
		}

		[Property(Column="I_PAY_DEST_CD", Length=12)]
		public virtual string IPayDestCd
		{
			get { return iPayDestCd; }
			set { iPayDestCd = value; }
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
			TTradeMs castObj = (TTradeMs)obj; 
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
			
			sbuffer.AppendFormat("ICompanyCd = {0}, ",Id.ICompanyCd);
			sbuffer.AppendFormat("IDlCd = {0}, ",Id.IDlCd);
			sbuffer.AppendFormat("IDlArgDesc = {0}, ",iDlArgDesc);
			sbuffer.AppendFormat("IDlDesc = {0}, ",iDlDesc);
			sbuffer.AppendFormat("IDlDescKana = {0}, ",iDlDescKana);
			sbuffer.AppendFormat("IDlType = {0}, ",iDlType);
			sbuffer.AppendFormat("IMailNo = {0}, ",iMailNo);
			sbuffer.AppendFormat("IAddress1 = {0}, ",iAddress1);
			sbuffer.AppendFormat("IAddress2 = {0}, ",iAddress2);
			sbuffer.AppendFormat("IAddress3 = {0}, ",iAddress3);
			sbuffer.AppendFormat("ITel = {0}, ",iTel);
			sbuffer.AppendFormat("IFaxNo = {0}, ",iFaxNo);
			sbuffer.AppendFormat("IMailadr = {0}, ",iMailadr);
			sbuffer.AppendFormat("IMailflg = {0}, ",iMailflg);
			sbuffer.AppendFormat("ISekjflg = {0}, ",iSekjflg);
			sbuffer.AppendFormat("IDxfflg = {0}, ",iDxfflg);
			sbuffer.AppendFormat("IDlCurrCd = {0}, ",iDlCurrCd);
			sbuffer.AppendFormat("ITransferLt = {0}, ",iTransferLt);
			sbuffer.AppendFormat("IDoIssueCls = {0}, ",iDoIssueCls);
			sbuffer.AppendFormat("IChargedSplyCls = {0}, ",iChargedSplyCls);
			sbuffer.AppendFormat("ITaxChargedCls = {0}, ",iTaxChargedCls);
			sbuffer.AppendFormat("ISalesUpCls = {0}, ",iSalesUpCls);
			sbuffer.AppendFormat("ISalesFrcCls = {0}, ",iSalesFrcCls);
			sbuffer.AppendFormat("ISalesTaxCalcCls = {0}, ",iSalesTaxCalcCls);
			sbuffer.AppendFormat("ISalesTaxFrcCls = {0}, ",iSalesTaxFrcCls);
			sbuffer.AppendFormat("ISalesTaxCls = {0}, ",iSalesTaxCls);
			sbuffer.AppendFormat("ISalesSlipIssueCls = {0}, ",iSalesSlipIssueCls);
			sbuffer.AppendFormat("ISalesTradeUpCls = {0}, ",iSalesTradeUpCls);
			sbuffer.AppendFormat("ISalesCls = {0}, ",iSalesCls);
			sbuffer.AppendFormat("ISalesSection = {0}, ",iSalesSection);
			sbuffer.AppendFormat("IArType = {0}, ",iArType);
			sbuffer.AppendFormat("IHoldSoAddCls = {0}, ",iHoldSoAddCls);
			sbuffer.AppendFormat("IHoldSoChgCls = {0}, ",iHoldSoChgCls);
			sbuffer.AppendFormat("IHoldSoDelCls = {0}, ",iHoldSoDelCls);
			sbuffer.AppendFormat("IValiTradeItemCls = {0}, ",iValiTradeItemCls);
			sbuffer.AppendFormat("IValiUpCls = {0}, ",iValiUpCls);
			sbuffer.AppendFormat("ISendAsnCls = {0}, ",iSendAsnCls);
			sbuffer.AppendFormat("IPurUpCls = {0}, ",iPurUpCls);
			sbuffer.AppendFormat("IPurFrcCls = {0}, ",iPurFrcCls);
			sbuffer.AppendFormat("IPurTaxCalcCls = {0}, ",iPurTaxCalcCls);
			sbuffer.AppendFormat("IPurTaxFrcCls = {0}, ",iPurTaxFrcCls);
			sbuffer.AppendFormat("IPurTaxCls = {0}, ",iPurTaxCls);
			sbuffer.AppendFormat("IPoIssueCls = {0}, ",iPoIssueCls);
			sbuffer.AppendFormat("IPurTradeUpCls = {0}, ",iPurTradeUpCls);
			sbuffer.AppendFormat("IVouCls = {0}, ",iVouCls);
			sbuffer.AppendFormat("IValiAsnCls = {0}, ",iValiAsnCls);
			sbuffer.AppendFormat("IPurchaseSection = {0}, ",iPurchaseSection);
			sbuffer.AppendFormat("IApType = {0}, ",iApType);
			sbuffer.AppendFormat("IItemType1 = {0}, ",iItemType1);
			sbuffer.AppendFormat("IItemType2 = {0}, ",iItemType2);
			sbuffer.AppendFormat("IItemType3 = {0}, ",iItemType3);
			sbuffer.AppendFormat("IItemType4 = {0}, ",iItemType4);
			sbuffer.AppendFormat("IItemType5 = {0}, ",iItemType5);
			sbuffer.AppendFormat("IItemType6 = {0}, ",iItemType6);
			sbuffer.AppendFormat("ISplyAppCls = {0}, ",iSplyAppCls);
			sbuffer.AppendFormat("ICountryCd = {0}, ",iCountryCd);
			sbuffer.AppendFormat("ILanguageCd = {0}, ",iLanguageCd);
			sbuffer.AppendFormat("IShangkbn = {0}, ",iShangkbn);
			sbuffer.AppendFormat("ISubconObjCls = {0}, ",iSubconObjCls);
			sbuffer.AppendFormat("IObjFacCd = {0}, ",iObjFacCd);
			sbuffer.AppendFormat("IInvDestCd = {0}, ",iInvDestCd);
			sbuffer.AppendFormat("IPayDestCd = {0}, ",iPayDestCd);
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
