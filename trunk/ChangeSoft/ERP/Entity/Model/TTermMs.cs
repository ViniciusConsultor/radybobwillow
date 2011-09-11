using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_TERM_MS' Schema
/*
 * 'TTermMs' class maps to 'T_TERM_MS' table.
 * 	 I_USER_ID               | Type:VARCHAR2  | Len:10    | Nullable:F | PK:T | FK:F
 * 	 I_FAC_CD                | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_PERSON_CD             | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_DEFALT                | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_DO                    | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_WO                    | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_PO_1                  | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_PO_D                  | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SALES_SLIP            | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_INS                   | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_IMAGE_P               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_IMAGE_L               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_ACP_SLIP              | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_STT_CARD              | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SPLY_SLIP             | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_PACKING               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_BLEND_SLIP            | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_DEBIT                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM1               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM2               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM3               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM4               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM5               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM6               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM7               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM8               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SYSTEM9               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE1                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE2                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE3                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE4                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE5                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE6                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE7                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE8                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_FREE9                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_TERM_NO               | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_INV_B                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_INV_A                 | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_INVOICE               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_EST_SLIP              | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_ORT_DEFALT            | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_DO                | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_WO                | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_PO_1           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_PO_D           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_INV_A             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_INV_B             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SALES_SLIP        | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_INS               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_IMAGE_P           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_IMAGE_L           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_ACP_SLIP          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_STT_CARD          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SPLY_SLIP         | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_PACKING           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_INVOICE           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_EST_SLIP          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_BLEND_SLIP        | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_DEBIT             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM1           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM2           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM3           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM4           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM5           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM6           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM7           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM8           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SYSTEM9           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE1             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE2             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE3             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE4             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE5             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE6             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE7             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE8             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_FREE9             | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_SM_LABEL              | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_EST                | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_PO_1               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_PO_D               | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_CANCEL_PO          | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_SALES_SLIP         | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_SHIP_SLIP          | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_INVOICE            | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_AR_DEBIT           | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_AR_CREDIT          | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_DEBIT              | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_AP_DEBIT           | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_AP_CREDIT          | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_INV_A              | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_INV_B              | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_SM_STT_CARD           | Type:VARCHAR2  | Len:256   | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_LABEL          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_EST            | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_PO_1              | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_PO_D              | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_CANCEL_PO      | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_SALES_SLIP     | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_SHIP_SLIP      | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_INVOICE        | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_AR_DEBIT       | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_AR_CREDIT      | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_DEBIT          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_AP_DEBIT       | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_AP_CREDIT      | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_INV_A          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_INV_B          | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ORT_SM_STT_CARD       | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/11 21:33:57
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_TERM_MS", DynamicUpdate = true, Lazy = true)]
	public class TTermMs : ActiveRecordBase	{

		#region Private Members

		private string iUserId; 
		private string iFacCd; 
		private string iPersonCd; 
		private string iDefalt; 
		private string iDo; 
		private string iWo; 
		private string iPo1; 
		private string iPoD; 
		private string iSalesSlip; 
		private string iIns; 
		private string iImageP; 
		private string iImageL; 
		private string iAcpSlip; 
		private string iSttCard; 
		private string iSplySlip; 
		private string iPacking; 
		private string iBlendSlip; 
		private string iDebit; 
		private string iSystem1; 
		private string iSystem2; 
		private string iSystem3; 
		private string iSystem4; 
		private string iSystem5; 
		private string iSystem6; 
		private string iSystem7; 
		private string iSystem8; 
		private string iSystem9; 
		private string iFree1; 
		private string iFree2; 
		private string iFree3; 
		private string iFree4; 
		private string iFree5; 
		private string iFree6; 
		private string iFree7; 
		private string iFree8; 
		private string iFree9; 
		private decimal iTermNo; 
		private string iInvB; 
		private string iInvA; 
		private string iInvoice; 
		private string iEstSlip; 
		private string iOrtDefalt; 
		private string iOrtDo; 
		private string iOrtWo; 
		private string iOrtSmPo1; 
		private string iOrtSmPoD; 
		private string iOrtInvA; 
		private string iOrtInvB; 
		private string iOrtSalesSlip; 
		private string iOrtIns; 
		private string iOrtImageP; 
		private string iOrtImageL; 
		private string iOrtAcpSlip; 
		private string iOrtSttCard; 
		private string iOrtSplySlip; 
		private string iOrtPacking; 
		private string iOrtInvoice; 
		private string iOrtEstSlip; 
		private string iOrtBlendSlip; 
		private string iOrtDebit; 
		private string iOrtSystem1; 
		private string iOrtSystem2; 
		private string iOrtSystem3; 
		private string iOrtSystem4; 
		private string iOrtSystem5; 
		private string iOrtSystem6; 
		private string iOrtSystem7; 
		private string iOrtSystem8; 
		private string iOrtSystem9; 
		private string iOrtFree1; 
		private string iOrtFree2; 
		private string iOrtFree3; 
		private string iOrtFree4; 
		private string iOrtFree5; 
		private string iOrtFree6; 
		private string iOrtFree7; 
		private string iOrtFree8; 
		private string iOrtFree9; 
		private string iSmLabel; 
		private string iSmEst; 
		private string iSmPo1; 
		private string iSmPoD; 
		private string iSmCancelPo; 
		private string iSmSalesSlip; 
		private string iSmShipSlip; 
		private string iSmInvoice; 
		private string iSmArDebit; 
		private string iSmArCredit; 
		private string iSmDebit; 
		private string iSmApDebit; 
		private string iSmApCredit; 
		private string iSmInvA; 
		private string iSmInvB; 
		private string iSmSttCard; 
		private string iOrtSmLabel; 
		private string iOrtSmEst; 
		private string iOrtPo1; 
		private string iOrtPoD; 
		private string iOrtSmCancelPo; 
		private string iOrtSmSalesSlip; 
		private string iOrtSmShipSlip; 
		private string iOrtSmInvoice; 
		private string iOrtSmArDebit; 
		private string iOrtSmArCredit; 
		private string iOrtSmDebit; 
		private string iOrtSmApDebit; 
		private string iOrtSmApCredit; 
		private string iOrtSmInvA; 
		private string iOrtSmInvB; 
		private string iOrtSmSttCard; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TTermMs()
		{
			iUserId = String.Empty; 
			iFacCd = String.Empty; 
			iPersonCd = String.Empty; 
			iDefalt = String.Empty; 
			iDo = String.Empty; 
			iWo = String.Empty; 
			iPo1 = String.Empty; 
			iPoD = String.Empty; 
			iSalesSlip = String.Empty; 
			iIns = String.Empty; 
			iImageP = String.Empty; 
			iImageL = String.Empty; 
			iAcpSlip = String.Empty; 
			iSttCard = String.Empty; 
			iSplySlip = String.Empty; 
			iPacking = String.Empty; 
			iBlendSlip = String.Empty; 
			iDebit = String.Empty; 
			iSystem1 = String.Empty; 
			iSystem2 = String.Empty; 
			iSystem3 = String.Empty; 
			iSystem4 = String.Empty; 
			iSystem5 = String.Empty; 
			iSystem6 = String.Empty; 
			iSystem7 = String.Empty; 
			iSystem8 = String.Empty; 
			iSystem9 = String.Empty; 
			iFree1 = String.Empty; 
			iFree2 = String.Empty; 
			iFree3 = String.Empty; 
			iFree4 = String.Empty; 
			iFree5 = String.Empty; 
			iFree6 = String.Empty; 
			iFree7 = String.Empty; 
			iFree8 = String.Empty; 
			iFree9 = String.Empty; 
			iTermNo = 0; 
			iInvB = String.Empty; 
			iInvA = String.Empty; 
			iInvoice = String.Empty; 
			iEstSlip = String.Empty; 
			iOrtDefalt = String.Empty; 
			iOrtDo = String.Empty; 
			iOrtWo = String.Empty; 
			iOrtSmPo1 = String.Empty; 
			iOrtSmPoD = String.Empty; 
			iOrtInvA = String.Empty; 
			iOrtInvB = String.Empty; 
			iOrtSalesSlip = String.Empty; 
			iOrtIns = String.Empty; 
			iOrtImageP = String.Empty; 
			iOrtImageL = String.Empty; 
			iOrtAcpSlip = String.Empty; 
			iOrtSttCard = String.Empty; 
			iOrtSplySlip = String.Empty; 
			iOrtPacking = String.Empty; 
			iOrtInvoice = String.Empty; 
			iOrtEstSlip = String.Empty; 
			iOrtBlendSlip = String.Empty; 
			iOrtDebit = String.Empty; 
			iOrtSystem1 = String.Empty; 
			iOrtSystem2 = String.Empty; 
			iOrtSystem3 = String.Empty; 
			iOrtSystem4 = String.Empty; 
			iOrtSystem5 = String.Empty; 
			iOrtSystem6 = String.Empty; 
			iOrtSystem7 = String.Empty; 
			iOrtSystem8 = String.Empty; 
			iOrtSystem9 = String.Empty; 
			iOrtFree1 = String.Empty; 
			iOrtFree2 = String.Empty; 
			iOrtFree3 = String.Empty; 
			iOrtFree4 = String.Empty; 
			iOrtFree5 = String.Empty; 
			iOrtFree6 = String.Empty; 
			iOrtFree7 = String.Empty; 
			iOrtFree8 = String.Empty; 
			iOrtFree9 = String.Empty; 
			iSmLabel = String.Empty; 
			iSmEst = String.Empty; 
			iSmPo1 = String.Empty; 
			iSmPoD = String.Empty; 
			iSmCancelPo = String.Empty; 
			iSmSalesSlip = String.Empty; 
			iSmShipSlip = String.Empty; 
			iSmInvoice = String.Empty; 
			iSmArDebit = String.Empty; 
			iSmArCredit = String.Empty; 
			iSmDebit = String.Empty; 
			iSmApDebit = String.Empty; 
			iSmApCredit = String.Empty; 
			iSmInvA = String.Empty; 
			iSmInvB = String.Empty; 
			iSmSttCard = String.Empty; 
			iOrtSmLabel = String.Empty; 
			iOrtSmEst = String.Empty; 
			iOrtPo1 = String.Empty; 
			iOrtPoD = String.Empty; 
			iOrtSmCancelPo = String.Empty; 
			iOrtSmSalesSlip = String.Empty; 
			iOrtSmShipSlip = String.Empty; 
			iOrtSmInvoice = String.Empty; 
			iOrtSmArDebit = String.Empty; 
			iOrtSmArCredit = String.Empty; 
			iOrtSmDebit = String.Empty; 
			iOrtSmApDebit = String.Empty; 
			iOrtSmApCredit = String.Empty; 
			iOrtSmInvA = String.Empty; 
			iOrtSmInvB = String.Empty; 
			iOrtSmSttCard = String.Empty; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iUpdTimestamp = String.Empty; 

		}

		public TTermMs(
			string i_user_id, 
			string i_fac_cd, 
			DateTime i_entry_date, 
			DateTime i_upd_date, 
			string i_upd_timestamp)
			: this()
		{
			iUserId = i_user_id;
			iFacCd = i_fac_cd;
			iPersonCd = String.Empty;
			iDefalt = String.Empty;
			iDo = String.Empty;
			iWo = String.Empty;
			iPo1 = String.Empty;
			iPoD = String.Empty;
			iSalesSlip = String.Empty;
			iIns = String.Empty;
			iImageP = String.Empty;
			iImageL = String.Empty;
			iAcpSlip = String.Empty;
			iSttCard = String.Empty;
			iSplySlip = String.Empty;
			iPacking = String.Empty;
			iBlendSlip = String.Empty;
			iDebit = String.Empty;
			iSystem1 = String.Empty;
			iSystem2 = String.Empty;
			iSystem3 = String.Empty;
			iSystem4 = String.Empty;
			iSystem5 = String.Empty;
			iSystem6 = String.Empty;
			iSystem7 = String.Empty;
			iSystem8 = String.Empty;
			iSystem9 = String.Empty;
			iFree1 = String.Empty;
			iFree2 = String.Empty;
			iFree3 = String.Empty;
			iFree4 = String.Empty;
			iFree5 = String.Empty;
			iFree6 = String.Empty;
			iFree7 = String.Empty;
			iFree8 = String.Empty;
			iFree9 = String.Empty;
			iTermNo = 0;
			iInvB = String.Empty;
			iInvA = String.Empty;
			iInvoice = String.Empty;
			iEstSlip = String.Empty;
			iOrtDefalt = String.Empty;
			iOrtDo = String.Empty;
			iOrtWo = String.Empty;
			iOrtSmPo1 = String.Empty;
			iOrtSmPoD = String.Empty;
			iOrtInvA = String.Empty;
			iOrtInvB = String.Empty;
			iOrtSalesSlip = String.Empty;
			iOrtIns = String.Empty;
			iOrtImageP = String.Empty;
			iOrtImageL = String.Empty;
			iOrtAcpSlip = String.Empty;
			iOrtSttCard = String.Empty;
			iOrtSplySlip = String.Empty;
			iOrtPacking = String.Empty;
			iOrtInvoice = String.Empty;
			iOrtEstSlip = String.Empty;
			iOrtBlendSlip = String.Empty;
			iOrtDebit = String.Empty;
			iOrtSystem1 = String.Empty;
			iOrtSystem2 = String.Empty;
			iOrtSystem3 = String.Empty;
			iOrtSystem4 = String.Empty;
			iOrtSystem5 = String.Empty;
			iOrtSystem6 = String.Empty;
			iOrtSystem7 = String.Empty;
			iOrtSystem8 = String.Empty;
			iOrtSystem9 = String.Empty;
			iOrtFree1 = String.Empty;
			iOrtFree2 = String.Empty;
			iOrtFree3 = String.Empty;
			iOrtFree4 = String.Empty;
			iOrtFree5 = String.Empty;
			iOrtFree6 = String.Empty;
			iOrtFree7 = String.Empty;
			iOrtFree8 = String.Empty;
			iOrtFree9 = String.Empty;
			iSmLabel = String.Empty;
			iSmEst = String.Empty;
			iSmPo1 = String.Empty;
			iSmPoD = String.Empty;
			iSmCancelPo = String.Empty;
			iSmSalesSlip = String.Empty;
			iSmShipSlip = String.Empty;
			iSmInvoice = String.Empty;
			iSmArDebit = String.Empty;
			iSmArCredit = String.Empty;
			iSmDebit = String.Empty;
			iSmApDebit = String.Empty;
			iSmApCredit = String.Empty;
			iSmInvA = String.Empty;
			iSmInvB = String.Empty;
			iSmSttCard = String.Empty;
			iOrtSmLabel = String.Empty;
			iOrtSmEst = String.Empty;
			iOrtPo1 = String.Empty;
			iOrtPoD = String.Empty;
			iOrtSmCancelPo = String.Empty;
			iOrtSmSalesSlip = String.Empty;
			iOrtSmShipSlip = String.Empty;
			iOrtSmInvoice = String.Empty;
			iOrtSmArDebit = String.Empty;
			iOrtSmArCredit = String.Empty;
			iOrtSmDebit = String.Empty;
			iOrtSmApDebit = String.Empty;
			iOrtSmApCredit = String.Empty;
			iOrtSmInvA = String.Empty;
			iOrtSmInvB = String.Empty;
			iOrtSmSttCard = String.Empty;
			iEntryDate = i_entry_date;
			iUpdDate = i_upd_date;
			iUpdTimestamp = i_upd_timestamp;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties
			
		[PrimaryKey(PrimaryKeyType.Identity ,"I_USER_ID", Length=10)]
		public virtual string IUserId
		{
			get { return iUserId; }
			set { iUserId = value; }
		}

		[Property(Column="I_FAC_CD", NotNull=true, Length=8)]
		public virtual string IFacCd
		{
			get { return iFacCd; }
			set { iFacCd = value; }
		}

		[Property(Column="I_PERSON_CD", Length=6)]
		public virtual string IPersonCd
		{
			get { return iPersonCd; }
			set { iPersonCd = value; }
		}

		[Property(Column="I_DEFALT", Length=256)]
		public virtual string IDefalt
		{
			get { return iDefalt; }
			set { iDefalt = value; }
		}

		[Property(Column="I_DO", Length=256)]
		public virtual string IDo
		{
			get { return iDo; }
			set { iDo = value; }
		}

		[Property(Column="I_WO", Length=256)]
		public virtual string IWo
		{
			get { return iWo; }
			set { iWo = value; }
		}

		[Property(Column="I_PO_1", Length=256)]
		public virtual string IPo1
		{
			get { return iPo1; }
			set { iPo1 = value; }
		}

		[Property(Column="I_PO_D", Length=256)]
		public virtual string IPoD
		{
			get { return iPoD; }
			set { iPoD = value; }
		}

		[Property(Column="I_SALES_SLIP", Length=256)]
		public virtual string ISalesSlip
		{
			get { return iSalesSlip; }
			set { iSalesSlip = value; }
		}

		[Property(Column="I_INS", Length=256)]
		public virtual string IIns
		{
			get { return iIns; }
			set { iIns = value; }
		}

		[Property(Column="I_IMAGE_P", Length=256)]
		public virtual string IImageP
		{
			get { return iImageP; }
			set { iImageP = value; }
		}

		[Property(Column="I_IMAGE_L", Length=256)]
		public virtual string IImageL
		{
			get { return iImageL; }
			set { iImageL = value; }
		}

		[Property(Column="I_ACP_SLIP", Length=256)]
		public virtual string IAcpSlip
		{
			get { return iAcpSlip; }
			set { iAcpSlip = value; }
		}

		[Property(Column="I_STT_CARD", Length=256)]
		public virtual string ISttCard
		{
			get { return iSttCard; }
			set { iSttCard = value; }
		}

		[Property(Column="I_SPLY_SLIP", Length=256)]
		public virtual string ISplySlip
		{
			get { return iSplySlip; }
			set { iSplySlip = value; }
		}

		[Property(Column="I_PACKING", Length=256)]
		public virtual string IPacking
		{
			get { return iPacking; }
			set { iPacking = value; }
		}

		[Property(Column="I_BLEND_SLIP", Length=256)]
		public virtual string IBlendSlip
		{
			get { return iBlendSlip; }
			set { iBlendSlip = value; }
		}

		[Property(Column="I_DEBIT", Length=256)]
		public virtual string IDebit
		{
			get { return iDebit; }
			set { iDebit = value; }
		}

		[Property(Column="I_SYSTEM1", Length=256)]
		public virtual string ISystem1
		{
			get { return iSystem1; }
			set { iSystem1 = value; }
		}

		[Property(Column="I_SYSTEM2", Length=256)]
		public virtual string ISystem2
		{
			get { return iSystem2; }
			set { iSystem2 = value; }
		}

		[Property(Column="I_SYSTEM3", Length=256)]
		public virtual string ISystem3
		{
			get { return iSystem3; }
			set { iSystem3 = value; }
		}

		[Property(Column="I_SYSTEM4", Length=256)]
		public virtual string ISystem4
		{
			get { return iSystem4; }
			set { iSystem4 = value; }
		}

		[Property(Column="I_SYSTEM5", Length=256)]
		public virtual string ISystem5
		{
			get { return iSystem5; }
			set { iSystem5 = value; }
		}

		[Property(Column="I_SYSTEM6", Length=256)]
		public virtual string ISystem6
		{
			get { return iSystem6; }
			set { iSystem6 = value; }
		}

		[Property(Column="I_SYSTEM7", Length=256)]
		public virtual string ISystem7
		{
			get { return iSystem7; }
			set { iSystem7 = value; }
		}

		[Property(Column="I_SYSTEM8", Length=256)]
		public virtual string ISystem8
		{
			get { return iSystem8; }
			set { iSystem8 = value; }
		}

		[Property(Column="I_SYSTEM9", Length=256)]
		public virtual string ISystem9
		{
			get { return iSystem9; }
			set { iSystem9 = value; }
		}

		[Property(Column="I_FREE1", Length=256)]
		public virtual string IFree1
		{
			get { return iFree1; }
			set { iFree1 = value; }
		}

		[Property(Column="I_FREE2", Length=256)]
		public virtual string IFree2
		{
			get { return iFree2; }
			set { iFree2 = value; }
		}

		[Property(Column="I_FREE3", Length=256)]
		public virtual string IFree3
		{
			get { return iFree3; }
			set { iFree3 = value; }
		}

		[Property(Column="I_FREE4", Length=256)]
		public virtual string IFree4
		{
			get { return iFree4; }
			set { iFree4 = value; }
		}

		[Property(Column="I_FREE5", Length=256)]
		public virtual string IFree5
		{
			get { return iFree5; }
			set { iFree5 = value; }
		}

		[Property(Column="I_FREE6", Length=256)]
		public virtual string IFree6
		{
			get { return iFree6; }
			set { iFree6 = value; }
		}

		[Property(Column="I_FREE7", Length=256)]
		public virtual string IFree7
		{
			get { return iFree7; }
			set { iFree7 = value; }
		}

		[Property(Column="I_FREE8", Length=256)]
		public virtual string IFree8
		{
			get { return iFree8; }
			set { iFree8 = value; }
		}

		[Property(Column="I_FREE9", Length=256)]
		public virtual string IFree9
		{
			get { return iFree9; }
			set { iFree9 = value; }
		}

		[Property(Column="I_TERM_NO")]
		public virtual decimal ITermNo
		{
			get { return iTermNo; }
			set { iTermNo = value; }
		}

		[Property(Column="I_INV_B", Length=256)]
		public virtual string IInvB
		{
			get { return iInvB; }
			set { iInvB = value; }
		}

		[Property(Column="I_INV_A", Length=256)]
		public virtual string IInvA
		{
			get { return iInvA; }
			set { iInvA = value; }
		}

		[Property(Column="I_INVOICE", Length=256)]
		public virtual string IInvoice
		{
			get { return iInvoice; }
			set { iInvoice = value; }
		}

		[Property(Column="I_EST_SLIP", Length=256)]
		public virtual string IEstSlip
		{
			get { return iEstSlip; }
			set { iEstSlip = value; }
		}

		[Property(Column="I_ORT_DEFALT", Length=2)]
		public virtual string IOrtDefalt
		{
			get { return iOrtDefalt; }
			set { iOrtDefalt = value; }
		}

		[Property(Column="I_ORT_DO", Length=2)]
		public virtual string IOrtDo
		{
			get { return iOrtDo; }
			set { iOrtDo = value; }
		}

		[Property(Column="I_ORT_WO", Length=2)]
		public virtual string IOrtWo
		{
			get { return iOrtWo; }
			set { iOrtWo = value; }
		}

		[Property(Column="I_ORT_SM_PO_1", Length=2)]
		public virtual string IOrtSmPo1
		{
			get { return iOrtSmPo1; }
			set { iOrtSmPo1 = value; }
		}

		[Property(Column="I_ORT_SM_PO_D", Length=2)]
		public virtual string IOrtSmPoD
		{
			get { return iOrtSmPoD; }
			set { iOrtSmPoD = value; }
		}

		[Property(Column="I_ORT_INV_A", Length=2)]
		public virtual string IOrtInvA
		{
			get { return iOrtInvA; }
			set { iOrtInvA = value; }
		}

		[Property(Column="I_ORT_INV_B", Length=2)]
		public virtual string IOrtInvB
		{
			get { return iOrtInvB; }
			set { iOrtInvB = value; }
		}

		[Property(Column="I_ORT_SALES_SLIP", Length=2)]
		public virtual string IOrtSalesSlip
		{
			get { return iOrtSalesSlip; }
			set { iOrtSalesSlip = value; }
		}

		[Property(Column="I_ORT_INS", Length=2)]
		public virtual string IOrtIns
		{
			get { return iOrtIns; }
			set { iOrtIns = value; }
		}

		[Property(Column="I_ORT_IMAGE_P", Length=2)]
		public virtual string IOrtImageP
		{
			get { return iOrtImageP; }
			set { iOrtImageP = value; }
		}

		[Property(Column="I_ORT_IMAGE_L", Length=2)]
		public virtual string IOrtImageL
		{
			get { return iOrtImageL; }
			set { iOrtImageL = value; }
		}

		[Property(Column="I_ORT_ACP_SLIP", Length=2)]
		public virtual string IOrtAcpSlip
		{
			get { return iOrtAcpSlip; }
			set { iOrtAcpSlip = value; }
		}

		[Property(Column="I_ORT_STT_CARD", Length=2)]
		public virtual string IOrtSttCard
		{
			get { return iOrtSttCard; }
			set { iOrtSttCard = value; }
		}

		[Property(Column="I_ORT_SPLY_SLIP", Length=2)]
		public virtual string IOrtSplySlip
		{
			get { return iOrtSplySlip; }
			set { iOrtSplySlip = value; }
		}

		[Property(Column="I_ORT_PACKING", Length=2)]
		public virtual string IOrtPacking
		{
			get { return iOrtPacking; }
			set { iOrtPacking = value; }
		}

		[Property(Column="I_ORT_INVOICE", Length=2)]
		public virtual string IOrtInvoice
		{
			get { return iOrtInvoice; }
			set { iOrtInvoice = value; }
		}

		[Property(Column="I_ORT_EST_SLIP", Length=2)]
		public virtual string IOrtEstSlip
		{
			get { return iOrtEstSlip; }
			set { iOrtEstSlip = value; }
		}

		[Property(Column="I_ORT_BLEND_SLIP", Length=2)]
		public virtual string IOrtBlendSlip
		{
			get { return iOrtBlendSlip; }
			set { iOrtBlendSlip = value; }
		}

		[Property(Column="I_ORT_DEBIT", Length=2)]
		public virtual string IOrtDebit
		{
			get { return iOrtDebit; }
			set { iOrtDebit = value; }
		}

		[Property(Column="I_ORT_SYSTEM1", Length=2)]
		public virtual string IOrtSystem1
		{
			get { return iOrtSystem1; }
			set { iOrtSystem1 = value; }
		}

		[Property(Column="I_ORT_SYSTEM2", Length=2)]
		public virtual string IOrtSystem2
		{
			get { return iOrtSystem2; }
			set { iOrtSystem2 = value; }
		}

		[Property(Column="I_ORT_SYSTEM3", Length=2)]
		public virtual string IOrtSystem3
		{
			get { return iOrtSystem3; }
			set { iOrtSystem3 = value; }
		}

		[Property(Column="I_ORT_SYSTEM4", Length=2)]
		public virtual string IOrtSystem4
		{
			get { return iOrtSystem4; }
			set { iOrtSystem4 = value; }
		}

		[Property(Column="I_ORT_SYSTEM5", Length=2)]
		public virtual string IOrtSystem5
		{
			get { return iOrtSystem5; }
			set { iOrtSystem5 = value; }
		}

		[Property(Column="I_ORT_SYSTEM6", Length=2)]
		public virtual string IOrtSystem6
		{
			get { return iOrtSystem6; }
			set { iOrtSystem6 = value; }
		}

		[Property(Column="I_ORT_SYSTEM7", Length=2)]
		public virtual string IOrtSystem7
		{
			get { return iOrtSystem7; }
			set { iOrtSystem7 = value; }
		}

		[Property(Column="I_ORT_SYSTEM8", Length=2)]
		public virtual string IOrtSystem8
		{
			get { return iOrtSystem8; }
			set { iOrtSystem8 = value; }
		}

		[Property(Column="I_ORT_SYSTEM9", Length=2)]
		public virtual string IOrtSystem9
		{
			get { return iOrtSystem9; }
			set { iOrtSystem9 = value; }
		}

		[Property(Column="I_ORT_FREE1", Length=2)]
		public virtual string IOrtFree1
		{
			get { return iOrtFree1; }
			set { iOrtFree1 = value; }
		}

		[Property(Column="I_ORT_FREE2", Length=2)]
		public virtual string IOrtFree2
		{
			get { return iOrtFree2; }
			set { iOrtFree2 = value; }
		}

		[Property(Column="I_ORT_FREE3", Length=2)]
		public virtual string IOrtFree3
		{
			get { return iOrtFree3; }
			set { iOrtFree3 = value; }
		}

		[Property(Column="I_ORT_FREE4", Length=2)]
		public virtual string IOrtFree4
		{
			get { return iOrtFree4; }
			set { iOrtFree4 = value; }
		}

		[Property(Column="I_ORT_FREE5", Length=2)]
		public virtual string IOrtFree5
		{
			get { return iOrtFree5; }
			set { iOrtFree5 = value; }
		}

		[Property(Column="I_ORT_FREE6", Length=2)]
		public virtual string IOrtFree6
		{
			get { return iOrtFree6; }
			set { iOrtFree6 = value; }
		}

		[Property(Column="I_ORT_FREE7", Length=2)]
		public virtual string IOrtFree7
		{
			get { return iOrtFree7; }
			set { iOrtFree7 = value; }
		}

		[Property(Column="I_ORT_FREE8", Length=2)]
		public virtual string IOrtFree8
		{
			get { return iOrtFree8; }
			set { iOrtFree8 = value; }
		}

		[Property(Column="I_ORT_FREE9", Length=2)]
		public virtual string IOrtFree9
		{
			get { return iOrtFree9; }
			set { iOrtFree9 = value; }
		}

		[Property(Column="I_SM_LABEL", Length=256)]
		public virtual string ISmLabel
		{
			get { return iSmLabel; }
			set { iSmLabel = value; }
		}

		[Property(Column="I_SM_EST", Length=256)]
		public virtual string ISmEst
		{
			get { return iSmEst; }
			set { iSmEst = value; }
		}

		[Property(Column="I_SM_PO_1", Length=256)]
		public virtual string ISmPo1
		{
			get { return iSmPo1; }
			set { iSmPo1 = value; }
		}

		[Property(Column="I_SM_PO_D", Length=256)]
		public virtual string ISmPoD
		{
			get { return iSmPoD; }
			set { iSmPoD = value; }
		}

		[Property(Column="I_SM_CANCEL_PO", Length=256)]
		public virtual string ISmCancelPo
		{
			get { return iSmCancelPo; }
			set { iSmCancelPo = value; }
		}

		[Property(Column="I_SM_SALES_SLIP", Length=256)]
		public virtual string ISmSalesSlip
		{
			get { return iSmSalesSlip; }
			set { iSmSalesSlip = value; }
		}

		[Property(Column="I_SM_SHIP_SLIP", Length=256)]
		public virtual string ISmShipSlip
		{
			get { return iSmShipSlip; }
			set { iSmShipSlip = value; }
		}

		[Property(Column="I_SM_INVOICE", Length=256)]
		public virtual string ISmInvoice
		{
			get { return iSmInvoice; }
			set { iSmInvoice = value; }
		}

		[Property(Column="I_SM_AR_DEBIT", Length=256)]
		public virtual string ISmArDebit
		{
			get { return iSmArDebit; }
			set { iSmArDebit = value; }
		}

		[Property(Column="I_SM_AR_CREDIT", Length=256)]
		public virtual string ISmArCredit
		{
			get { return iSmArCredit; }
			set { iSmArCredit = value; }
		}

		[Property(Column="I_SM_DEBIT", Length=256)]
		public virtual string ISmDebit
		{
			get { return iSmDebit; }
			set { iSmDebit = value; }
		}

		[Property(Column="I_SM_AP_DEBIT", Length=256)]
		public virtual string ISmApDebit
		{
			get { return iSmApDebit; }
			set { iSmApDebit = value; }
		}

		[Property(Column="I_SM_AP_CREDIT", Length=256)]
		public virtual string ISmApCredit
		{
			get { return iSmApCredit; }
			set { iSmApCredit = value; }
		}

		[Property(Column="I_SM_INV_A", Length=256)]
		public virtual string ISmInvA
		{
			get { return iSmInvA; }
			set { iSmInvA = value; }
		}

		[Property(Column="I_SM_INV_B", Length=256)]
		public virtual string ISmInvB
		{
			get { return iSmInvB; }
			set { iSmInvB = value; }
		}

		[Property(Column="I_SM_STT_CARD", Length=256)]
		public virtual string ISmSttCard
		{
			get { return iSmSttCard; }
			set { iSmSttCard = value; }
		}

		[Property(Column="I_ORT_SM_LABEL", Length=2)]
		public virtual string IOrtSmLabel
		{
			get { return iOrtSmLabel; }
			set { iOrtSmLabel = value; }
		}

		[Property(Column="I_ORT_SM_EST", Length=2)]
		public virtual string IOrtSmEst
		{
			get { return iOrtSmEst; }
			set { iOrtSmEst = value; }
		}

		[Property(Column="I_ORT_PO_1", Length=2)]
		public virtual string IOrtPo1
		{
			get { return iOrtPo1; }
			set { iOrtPo1 = value; }
		}

		[Property(Column="I_ORT_PO_D", Length=2)]
		public virtual string IOrtPoD
		{
			get { return iOrtPoD; }
			set { iOrtPoD = value; }
		}

		[Property(Column="I_ORT_SM_CANCEL_PO", Length=2)]
		public virtual string IOrtSmCancelPo
		{
			get { return iOrtSmCancelPo; }
			set { iOrtSmCancelPo = value; }
		}

		[Property(Column="I_ORT_SM_SALES_SLIP", Length=2)]
		public virtual string IOrtSmSalesSlip
		{
			get { return iOrtSmSalesSlip; }
			set { iOrtSmSalesSlip = value; }
		}

		[Property(Column="I_ORT_SM_SHIP_SLIP", Length=2)]
		public virtual string IOrtSmShipSlip
		{
			get { return iOrtSmShipSlip; }
			set { iOrtSmShipSlip = value; }
		}

		[Property(Column="I_ORT_SM_INVOICE", Length=2)]
		public virtual string IOrtSmInvoice
		{
			get { return iOrtSmInvoice; }
			set { iOrtSmInvoice = value; }
		}

		[Property(Column="I_ORT_SM_AR_DEBIT", Length=2)]
		public virtual string IOrtSmArDebit
		{
			get { return iOrtSmArDebit; }
			set { iOrtSmArDebit = value; }
		}

		[Property(Column="I_ORT_SM_AR_CREDIT", Length=2)]
		public virtual string IOrtSmArCredit
		{
			get { return iOrtSmArCredit; }
			set { iOrtSmArCredit = value; }
		}

		[Property(Column="I_ORT_SM_DEBIT", Length=2)]
		public virtual string IOrtSmDebit
		{
			get { return iOrtSmDebit; }
			set { iOrtSmDebit = value; }
		}

		[Property(Column="I_ORT_SM_AP_DEBIT", Length=2)]
		public virtual string IOrtSmApDebit
		{
			get { return iOrtSmApDebit; }
			set { iOrtSmApDebit = value; }
		}

		[Property(Column="I_ORT_SM_AP_CREDIT", Length=2)]
		public virtual string IOrtSmApCredit
		{
			get { return iOrtSmApCredit; }
			set { iOrtSmApCredit = value; }
		}

		[Property(Column="I_ORT_SM_INV_A", Length=2)]
		public virtual string IOrtSmInvA
		{
			get { return iOrtSmInvA; }
			set { iOrtSmInvA = value; }
		}

		[Property(Column="I_ORT_SM_INV_B", Length=2)]
		public virtual string IOrtSmInvB
		{
			get { return iOrtSmInvB; }
			set { iOrtSmInvB = value; }
		}

		[Property(Column="I_ORT_SM_STT_CARD", Length=2)]
		public virtual string IOrtSmSttCard
		{
			get { return iOrtSmSttCard; }
			set { iOrtSmSttCard = value; }
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
			TTermMs castObj = (TTermMs)obj; 
			return ( castObj != null ) &&
				( this.iUserId == castObj.IUserId );
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * iUserId.GetHashCode();
			return hash; 
		}
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			
			sbuffer.AppendFormat("IUserId = {0}, ",iUserId);
			sbuffer.AppendFormat("IFacCd = {0}, ",iFacCd);
			sbuffer.AppendFormat("IPersonCd = {0}, ",iPersonCd);
			sbuffer.AppendFormat("IDefalt = {0}, ",iDefalt);
			sbuffer.AppendFormat("IDo = {0}, ",iDo);
			sbuffer.AppendFormat("IWo = {0}, ",iWo);
			sbuffer.AppendFormat("IPo1 = {0}, ",iPo1);
			sbuffer.AppendFormat("IPoD = {0}, ",iPoD);
			sbuffer.AppendFormat("ISalesSlip = {0}, ",iSalesSlip);
			sbuffer.AppendFormat("IIns = {0}, ",iIns);
			sbuffer.AppendFormat("IImageP = {0}, ",iImageP);
			sbuffer.AppendFormat("IImageL = {0}, ",iImageL);
			sbuffer.AppendFormat("IAcpSlip = {0}, ",iAcpSlip);
			sbuffer.AppendFormat("ISttCard = {0}, ",iSttCard);
			sbuffer.AppendFormat("ISplySlip = {0}, ",iSplySlip);
			sbuffer.AppendFormat("IPacking = {0}, ",iPacking);
			sbuffer.AppendFormat("IBlendSlip = {0}, ",iBlendSlip);
			sbuffer.AppendFormat("IDebit = {0}, ",iDebit);
			sbuffer.AppendFormat("ISystem1 = {0}, ",iSystem1);
			sbuffer.AppendFormat("ISystem2 = {0}, ",iSystem2);
			sbuffer.AppendFormat("ISystem3 = {0}, ",iSystem3);
			sbuffer.AppendFormat("ISystem4 = {0}, ",iSystem4);
			sbuffer.AppendFormat("ISystem5 = {0}, ",iSystem5);
			sbuffer.AppendFormat("ISystem6 = {0}, ",iSystem6);
			sbuffer.AppendFormat("ISystem7 = {0}, ",iSystem7);
			sbuffer.AppendFormat("ISystem8 = {0}, ",iSystem8);
			sbuffer.AppendFormat("ISystem9 = {0}, ",iSystem9);
			sbuffer.AppendFormat("IFree1 = {0}, ",iFree1);
			sbuffer.AppendFormat("IFree2 = {0}, ",iFree2);
			sbuffer.AppendFormat("IFree3 = {0}, ",iFree3);
			sbuffer.AppendFormat("IFree4 = {0}, ",iFree4);
			sbuffer.AppendFormat("IFree5 = {0}, ",iFree5);
			sbuffer.AppendFormat("IFree6 = {0}, ",iFree6);
			sbuffer.AppendFormat("IFree7 = {0}, ",iFree7);
			sbuffer.AppendFormat("IFree8 = {0}, ",iFree8);
			sbuffer.AppendFormat("IFree9 = {0}, ",iFree9);
			sbuffer.AppendFormat("ITermNo = {0}, ",iTermNo);
			sbuffer.AppendFormat("IInvB = {0}, ",iInvB);
			sbuffer.AppendFormat("IInvA = {0}, ",iInvA);
			sbuffer.AppendFormat("IInvoice = {0}, ",iInvoice);
			sbuffer.AppendFormat("IEstSlip = {0}, ",iEstSlip);
			sbuffer.AppendFormat("IOrtDefalt = {0}, ",iOrtDefalt);
			sbuffer.AppendFormat("IOrtDo = {0}, ",iOrtDo);
			sbuffer.AppendFormat("IOrtWo = {0}, ",iOrtWo);
			sbuffer.AppendFormat("IOrtSmPo1 = {0}, ",iOrtSmPo1);
			sbuffer.AppendFormat("IOrtSmPoD = {0}, ",iOrtSmPoD);
			sbuffer.AppendFormat("IOrtInvA = {0}, ",iOrtInvA);
			sbuffer.AppendFormat("IOrtInvB = {0}, ",iOrtInvB);
			sbuffer.AppendFormat("IOrtSalesSlip = {0}, ",iOrtSalesSlip);
			sbuffer.AppendFormat("IOrtIns = {0}, ",iOrtIns);
			sbuffer.AppendFormat("IOrtImageP = {0}, ",iOrtImageP);
			sbuffer.AppendFormat("IOrtImageL = {0}, ",iOrtImageL);
			sbuffer.AppendFormat("IOrtAcpSlip = {0}, ",iOrtAcpSlip);
			sbuffer.AppendFormat("IOrtSttCard = {0}, ",iOrtSttCard);
			sbuffer.AppendFormat("IOrtSplySlip = {0}, ",iOrtSplySlip);
			sbuffer.AppendFormat("IOrtPacking = {0}, ",iOrtPacking);
			sbuffer.AppendFormat("IOrtInvoice = {0}, ",iOrtInvoice);
			sbuffer.AppendFormat("IOrtEstSlip = {0}, ",iOrtEstSlip);
			sbuffer.AppendFormat("IOrtBlendSlip = {0}, ",iOrtBlendSlip);
			sbuffer.AppendFormat("IOrtDebit = {0}, ",iOrtDebit);
			sbuffer.AppendFormat("IOrtSystem1 = {0}, ",iOrtSystem1);
			sbuffer.AppendFormat("IOrtSystem2 = {0}, ",iOrtSystem2);
			sbuffer.AppendFormat("IOrtSystem3 = {0}, ",iOrtSystem3);
			sbuffer.AppendFormat("IOrtSystem4 = {0}, ",iOrtSystem4);
			sbuffer.AppendFormat("IOrtSystem5 = {0}, ",iOrtSystem5);
			sbuffer.AppendFormat("IOrtSystem6 = {0}, ",iOrtSystem6);
			sbuffer.AppendFormat("IOrtSystem7 = {0}, ",iOrtSystem7);
			sbuffer.AppendFormat("IOrtSystem8 = {0}, ",iOrtSystem8);
			sbuffer.AppendFormat("IOrtSystem9 = {0}, ",iOrtSystem9);
			sbuffer.AppendFormat("IOrtFree1 = {0}, ",iOrtFree1);
			sbuffer.AppendFormat("IOrtFree2 = {0}, ",iOrtFree2);
			sbuffer.AppendFormat("IOrtFree3 = {0}, ",iOrtFree3);
			sbuffer.AppendFormat("IOrtFree4 = {0}, ",iOrtFree4);
			sbuffer.AppendFormat("IOrtFree5 = {0}, ",iOrtFree5);
			sbuffer.AppendFormat("IOrtFree6 = {0}, ",iOrtFree6);
			sbuffer.AppendFormat("IOrtFree7 = {0}, ",iOrtFree7);
			sbuffer.AppendFormat("IOrtFree8 = {0}, ",iOrtFree8);
			sbuffer.AppendFormat("IOrtFree9 = {0}, ",iOrtFree9);
			sbuffer.AppendFormat("ISmLabel = {0}, ",iSmLabel);
			sbuffer.AppendFormat("ISmEst = {0}, ",iSmEst);
			sbuffer.AppendFormat("ISmPo1 = {0}, ",iSmPo1);
			sbuffer.AppendFormat("ISmPoD = {0}, ",iSmPoD);
			sbuffer.AppendFormat("ISmCancelPo = {0}, ",iSmCancelPo);
			sbuffer.AppendFormat("ISmSalesSlip = {0}, ",iSmSalesSlip);
			sbuffer.AppendFormat("ISmShipSlip = {0}, ",iSmShipSlip);
			sbuffer.AppendFormat("ISmInvoice = {0}, ",iSmInvoice);
			sbuffer.AppendFormat("ISmArDebit = {0}, ",iSmArDebit);
			sbuffer.AppendFormat("ISmArCredit = {0}, ",iSmArCredit);
			sbuffer.AppendFormat("ISmDebit = {0}, ",iSmDebit);
			sbuffer.AppendFormat("ISmApDebit = {0}, ",iSmApDebit);
			sbuffer.AppendFormat("ISmApCredit = {0}, ",iSmApCredit);
			sbuffer.AppendFormat("ISmInvA = {0}, ",iSmInvA);
			sbuffer.AppendFormat("ISmInvB = {0}, ",iSmInvB);
			sbuffer.AppendFormat("ISmSttCard = {0}, ",iSmSttCard);
			sbuffer.AppendFormat("IOrtSmLabel = {0}, ",iOrtSmLabel);
			sbuffer.AppendFormat("IOrtSmEst = {0}, ",iOrtSmEst);
			sbuffer.AppendFormat("IOrtPo1 = {0}, ",iOrtPo1);
			sbuffer.AppendFormat("IOrtPoD = {0}, ",iOrtPoD);
			sbuffer.AppendFormat("IOrtSmCancelPo = {0}, ",iOrtSmCancelPo);
			sbuffer.AppendFormat("IOrtSmSalesSlip = {0}, ",iOrtSmSalesSlip);
			sbuffer.AppendFormat("IOrtSmShipSlip = {0}, ",iOrtSmShipSlip);
			sbuffer.AppendFormat("IOrtSmInvoice = {0}, ",iOrtSmInvoice);
			sbuffer.AppendFormat("IOrtSmArDebit = {0}, ",iOrtSmArDebit);
			sbuffer.AppendFormat("IOrtSmArCredit = {0}, ",iOrtSmArCredit);
			sbuffer.AppendFormat("IOrtSmDebit = {0}, ",iOrtSmDebit);
			sbuffer.AppendFormat("IOrtSmApDebit = {0}, ",iOrtSmApDebit);
			sbuffer.AppendFormat("IOrtSmApCredit = {0}, ",iOrtSmApCredit);
			sbuffer.AppendFormat("IOrtSmInvA = {0}, ",iOrtSmInvA);
			sbuffer.AppendFormat("IOrtSmInvB = {0}, ",iOrtSmInvB);
			sbuffer.AppendFormat("IOrtSmSttCard = {0}, ",iOrtSmSttCard);
			sbuffer.AppendFormat("IEntryDate = {0}, ",iEntryDate);
			sbuffer.AppendFormat("IUpdDate = {0}, ",iUpdDate);
			sbuffer.AppendFormat("IUpdTimestamp = {0}, ",iUpdTimestamp);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}
