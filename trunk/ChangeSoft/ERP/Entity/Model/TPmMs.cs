using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_PM_MS' Schema
/*
 * 'TPmMs' class maps to 'T_PM_MS' table.
 * 	 I_FAC_CD                | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_ITEM_CD               | Type:VARCHAR2  | Len:25    | Nullable:F | PK:T | FK:F
 * 	 I_DISP_ITEM_CD          | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_ITEM_DESC             | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ITEM_REV              | Type:VARCHAR2  | Len:5     | Nullable:T | PK:F | FK:F
 * 	 I_DISP_ITEM_REV         | Type:VARCHAR2  | Len:5     | Nullable:T | PK:F | FK:F
 * 	 I_MODEL                 | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_DRW_NO                | Type:VARCHAR2  | Len:50    | Nullable:F | PK:F | FK:F
 * 	 I_SPEC                  | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_SEIBAN                | Type:VARCHAR2  | Len:23    | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE             | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE1            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE2            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_TYPE3            | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_PERSON_CD       | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_CTRL_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_ITEM_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SO_ALC_CLS            | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PS_CLS                | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_LOT_METHOD            | Type:VARCHAR2  | Len:3     | Nullable:F | PK:F | FK:F
 * 	 I_FPR_PERIOD            | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_LOT_QTY               | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_LOT_CTRL_CLS          | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_STOCK_CLS             | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_DEL_SCH_CLS           | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_OS_ALC_CLS            | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PLAN_DVD_CLS          | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_MIN_LOT_QTY           | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_SAFE_STOCK_QTY        | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_USE_DEL_CLS           | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_STD_UNIT_CD           | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_START_SEQ             | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_END_SEQ               | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_CNV_UNIT_CD           | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_CNV_RATE_BUNSI        | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_CNV_RATE_BUNBO        | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_INV_SO_DATE           | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_SHIP_LOCATION         | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_NET_WEIGHT            | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_NET_WEIGHT_UNIT       | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_GROSS_WEIGHT          | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_GROSS_WEIGHT_UNIT     | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_M3                    | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_LOW_LEVEL             | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_SUM_LT                | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_PLAN_QTY              | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_MAKER_CD              | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_QRY_MTRL              | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_SIZE1                 | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_SIZE2                 | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_SIZE3                 | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_GRAVITY               | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_PROD_FAC_CD           | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_FG_IN_CLS             | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_PROC_SUM_LT           | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_HCDFLG                | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SPFLG                 | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SPEXC                 | Type:VARCHAR2  | Len:100   | Nullable:T | PK:F | FK:F
 * 	 I_PMRKEY                | Type:VARCHAR2  | Len:25    | Nullable:F | PK:F | FK:F
 * 	 I_PMRVER                | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_SPNAME                | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_SPDATE                | Type:DATE      | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_STATUS                | Type:VARCHAR2  | Len:48    | Nullable:T | PK:F | FK:F
 * 	 I_SEPHIN                | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_RYUHIN                | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_SAKUSEI               | Type:VARCHAR2  | Len:30    | Nullable:T | PK:F | FK:F
 * 	 I_CTRL_SECTION          | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_SALES_SECTION         | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_PURCHASE_SECTION      | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_ITEM_ENTRY_CLS        | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_SMT_CLS               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_ROHS_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_REACH_CLS             | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_CHINA_ROHS_CLS        | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_BIN_END_DATE          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_MNT_CLS               | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_SRL_SEQ_CLS           | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_PART_CHG_PERIOD       | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_PART_CHG_PERIOD_UNIT_CD| Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_FIX_MNT_PERIOD        | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_FIX_MNT_PERIOD_UNIT_CD| Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_GUAR_PERIOD           | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_GUAR_PERIOD_UNIT_CD   | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_USEFUL_LIFE           | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_USEFUL_LIFE_UNIT_CLS  | Type:VARCHAR2  | Len:2     | Nullable:T | PK:F | FK:F
 * 	 I_CAP_ITEM_TYPE         | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_INQ_ITEM              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_OBJECT_ID             | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/17 23:14:56
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable, ActiveRecord("T_PM_MS")]
    public class TPmMs : ActiveRecordBase
    {

        #region Private Members

        private TPmMsId id;
        private string iDispItemCd;
        private string iItemDesc;
        private string iItemRev;
        private string iDispItemRev;
        private string iModel;
        private string iDrwNo;
        private string iSpec;
        private string iSeiban;
        private string iItemType;
        private string iItemType1;
        private string iItemType2;
        private string iItemType3;
        private string iSalesPersonCd;
        private string iCtrlCls;
        private string iItemCls;
        private string iSoAlcCls;
        private string iPsCls;
        private string iLotMethod;
        private decimal iFprPeriod;
        private decimal iLotQty;
        private string iLotCtrlCls;
        private string iStockCls;
        private string iDelSchCls;
        private string iOsAlcCls;
        private string iPlanDvdCls;
        private decimal iMinLotQty;
        private decimal iSafeStockQty;
        private string iUseDelCls;
        private string iStdUnitCd;
        private decimal iStartSeq;
        private decimal iEndSeq;
        private string iCnvUnitCd;
        private decimal iCnvRateBunsi;
        private decimal iCnvRateBunbo;
        private decimal iInvSoDate;
        private string iShipLocation;
        private decimal iNetWeight;
        private string iNetWeightUnit;
        private decimal iGrossWeight;
        private string iGrossWeightUnit;
        private decimal iM3;
        private decimal iLowLevel;
        private decimal iSumLt;
        private decimal iPlanQty;
        private string iMakerCd;
        private string iQryMtrl;
        private decimal iSize1;
        private decimal iSize2;
        private decimal iSize3;
        private decimal iGravity;
        private string iProdFacCd;
        private string iFgInCls;
        private decimal iProcSumLt;
        private string iHcdflg;
        private string iSpflg;
        private string iSpexc;
        private string iPmrkey;
        private decimal iPmrver;
        private string iSpname;
        private DateTime iSpdate;
        private string iStatus;
        private string iSephin;
        private string iRyuhin;
        private string iSakusei;
        private string iCtrlSection;
        private string iSalesSection;
        private string iPurchaseSection;
        private string iItemEntryCls;
        private string iSmtCls;
        private string iRohsCls;
        private string iReachCls;
        private string iChinaRohsCls;
        private decimal iBinEndDate;
        private string iMntCls;
        private string iSrlSeqCls;
        private decimal iPartChgPeriod;
        private string iPartChgPeriodUnitCd;
        private decimal iFixMntPeriod;
        private string iFixMntPeriodUnitCd;
        private decimal iGuarPeriod;
        private string iGuarPeriodUnitCd;
        private decimal iUsefulLife;
        private string iUsefulLifeUnitCls;
        private string iCapItemType;
        private string iInqItem;
        private decimal iObjectId;
        private DateTime iEntryDate;
        private DateTime iUpdDate;
        private string iUpdTimestamp;

        #endregion

        #region Constuctor(s)

        public TPmMs()
        {
            id = new TPmMsId();
            id.IFacCd = String.Empty;
            id.IItemCd = String.Empty;
            iDispItemCd = String.Empty;
            iItemDesc = String.Empty;
            iItemRev = String.Empty;
            iDispItemRev = String.Empty;
            iModel = String.Empty;
            iDrwNo = String.Empty;
            iSpec = String.Empty;
            iSeiban = String.Empty;
            iItemType = String.Empty;
            iItemType1 = String.Empty;
            iItemType2 = String.Empty;
            iItemType3 = String.Empty;
            iSalesPersonCd = String.Empty;
            iCtrlCls = String.Empty;
            iItemCls = String.Empty;
            iSoAlcCls = String.Empty;
            iPsCls = String.Empty;
            iLotMethod = String.Empty;
            iFprPeriod = 0;
            iLotQty = 0;
            iLotCtrlCls = String.Empty;
            iStockCls = String.Empty;
            iDelSchCls = String.Empty;
            iOsAlcCls = String.Empty;
            iPlanDvdCls = String.Empty;
            iMinLotQty = 0;
            iSafeStockQty = 0;
            iUseDelCls = String.Empty;
            iStdUnitCd = String.Empty;
            iStartSeq = 0;
            iEndSeq = 0;
            iCnvUnitCd = String.Empty;
            iCnvRateBunsi = 0;
            iCnvRateBunbo = 0;
            iInvSoDate = 0;
            iShipLocation = String.Empty;
            iNetWeight = 0;
            iNetWeightUnit = String.Empty;
            iGrossWeight = 0;
            iGrossWeightUnit = String.Empty;
            iM3 = 0;
            iLowLevel = 0;
            iSumLt = 0;
            iPlanQty = 0;
            iMakerCd = String.Empty;
            iQryMtrl = String.Empty;
            iSize1 = 0;
            iSize2 = 0;
            iSize3 = 0;
            iGravity = 0;
            iProdFacCd = String.Empty;
            iFgInCls = String.Empty;
            iProcSumLt = 0;
            iHcdflg = String.Empty;
            iSpflg = String.Empty;
            iSpexc = String.Empty;
            iPmrkey = String.Empty;
            iPmrver = 0;
            iSpname = String.Empty;
            iSpdate = DateTime.MinValue;
            iStatus = String.Empty;
            iSephin = String.Empty;
            iRyuhin = String.Empty;
            iSakusei = String.Empty;
            iCtrlSection = String.Empty;
            iSalesSection = String.Empty;
            iPurchaseSection = String.Empty;
            iItemEntryCls = String.Empty;
            iSmtCls = String.Empty;
            iRohsCls = String.Empty;
            iReachCls = String.Empty;
            iChinaRohsCls = String.Empty;
            iBinEndDate = 0;
            iMntCls = String.Empty;
            iSrlSeqCls = String.Empty;
            iPartChgPeriod = 0;
            iPartChgPeriodUnitCd = String.Empty;
            iFixMntPeriod = 0;
            iFixMntPeriodUnitCd = String.Empty;
            iGuarPeriod = 0;
            iGuarPeriodUnitCd = String.Empty;
            iUsefulLife = 0;
            iUsefulLifeUnitCls = String.Empty;
            iCapItemType = String.Empty;
            iInqItem = String.Empty;
            iObjectId = 0;
            iEntryDate = DateTime.MinValue;
            iUpdDate = DateTime.MinValue;
            iUpdTimestamp = String.Empty;

        }

        public TPmMs(
            string i_fac_cd,
            string i_item_cd,
            string i_drw_no,
            string i_seiban,
            string i_item_type,
            string i_item_type1,
            string i_item_type2,
            string i_item_type3,
            string i_sales_person_cd,
            string i_ctrl_cls,
            string i_item_cls,
            string i_so_alc_cls,
            string i_ps_cls,
            string i_lot_method,
            decimal i_fpr_period,
            decimal i_lot_qty,
            string i_lot_ctrl_cls,
            string i_stock_cls,
            string i_del_sch_cls,
            string i_os_alc_cls,
            string i_plan_dvd_cls,
            decimal i_min_lot_qty,
            decimal i_safe_stock_qty,
            string i_use_del_cls,
            string i_std_unit_cd,
            decimal i_start_seq,
            decimal i_end_seq,
            string i_cnv_unit_cd,
            decimal i_cnv_rate_bunsi,
            decimal i_cnv_rate_bunbo,
            string i_ship_location,
            decimal i_net_weight,
            string i_net_weight_unit,
            decimal i_gross_weight,
            string i_gross_weight_unit,
            decimal i_m3,
            decimal i_low_level,
            decimal i_sum_lt,
            decimal i_plan_qty,
            string i_maker_cd,
            decimal i_size1,
            decimal i_size2,
            decimal i_size3,
            string i_prod_fac_cd,
            string i_fg_in_cls,
            decimal i_proc_sum_lt,
            string i_hcdflg,
            string i_spflg,
            string i_pmrkey,
            decimal i_pmrver,
            string i_spname,
            string i_ctrl_section,
            string i_item_entry_cls,
            string i_smt_cls,
            string i_rohs_cls,
            string i_reach_cls,
            string i_china_rohs_cls,
            DateTime i_entry_date,
            DateTime i_upd_date,
            string i_upd_timestamp)
            : this()
        {
            id = new TPmMsId();
            id.IFacCd = i_fac_cd;
            id.IItemCd = i_item_cd;
            iDispItemCd = String.Empty;
            iItemDesc = String.Empty;
            iItemRev = String.Empty;
            iDispItemRev = String.Empty;
            iModel = String.Empty;
            iDrwNo = i_drw_no;
            iSpec = String.Empty;
            iSeiban = i_seiban;
            iItemType = i_item_type;
            iItemType1 = i_item_type1;
            iItemType2 = i_item_type2;
            iItemType3 = i_item_type3;
            iSalesPersonCd = i_sales_person_cd;
            iCtrlCls = i_ctrl_cls;
            iItemCls = i_item_cls;
            iSoAlcCls = i_so_alc_cls;
            iPsCls = i_ps_cls;
            iLotMethod = i_lot_method;
            iFprPeriod = i_fpr_period;
            iLotQty = i_lot_qty;
            iLotCtrlCls = i_lot_ctrl_cls;
            iStockCls = i_stock_cls;
            iDelSchCls = i_del_sch_cls;
            iOsAlcCls = i_os_alc_cls;
            iPlanDvdCls = i_plan_dvd_cls;
            iMinLotQty = i_min_lot_qty;
            iSafeStockQty = i_safe_stock_qty;
            iUseDelCls = i_use_del_cls;
            iStdUnitCd = i_std_unit_cd;
            iStartSeq = i_start_seq;
            iEndSeq = i_end_seq;
            iCnvUnitCd = i_cnv_unit_cd;
            iCnvRateBunsi = i_cnv_rate_bunsi;
            iCnvRateBunbo = i_cnv_rate_bunbo;
            iInvSoDate = 0;
            iShipLocation = i_ship_location;
            iNetWeight = i_net_weight;
            iNetWeightUnit = i_net_weight_unit;
            iGrossWeight = i_gross_weight;
            iGrossWeightUnit = i_gross_weight_unit;
            iM3 = i_m3;
            iLowLevel = i_low_level;
            iSumLt = i_sum_lt;
            iPlanQty = i_plan_qty;
            iMakerCd = i_maker_cd;
            iQryMtrl = String.Empty;
            iSize1 = i_size1;
            iSize2 = i_size2;
            iSize3 = i_size3;
            iGravity = 0;
            iProdFacCd = i_prod_fac_cd;
            iFgInCls = i_fg_in_cls;
            iProcSumLt = i_proc_sum_lt;
            iHcdflg = i_hcdflg;
            iSpflg = i_spflg;
            iSpexc = String.Empty;
            iPmrkey = i_pmrkey;
            iPmrver = i_pmrver;
            iSpname = i_spname;
            iSpdate = DateTime.MinValue;
            iStatus = String.Empty;
            iSephin = String.Empty;
            iRyuhin = String.Empty;
            iSakusei = String.Empty;
            iCtrlSection = i_ctrl_section;
            iSalesSection = String.Empty;
            iPurchaseSection = String.Empty;
            iItemEntryCls = i_item_entry_cls;
            iSmtCls = i_smt_cls;
            iRohsCls = i_rohs_cls;
            iReachCls = i_reach_cls;
            iChinaRohsCls = i_china_rohs_cls;
            iBinEndDate = 0;
            iMntCls = String.Empty;
            iSrlSeqCls = String.Empty;
            iPartChgPeriod = 0;
            iPartChgPeriodUnitCd = String.Empty;
            iFixMntPeriod = 0;
            iFixMntPeriodUnitCd = String.Empty;
            iGuarPeriod = 0;
            iGuarPeriodUnitCd = String.Empty;
            iUsefulLife = 0;
            iUsefulLifeUnitCls = String.Empty;
            iCapItemType = String.Empty;
            iInqItem = String.Empty;
            iObjectId = 0;
            iEntryDate = i_entry_date;
            iUpdDate = i_upd_date;
            iUpdTimestamp = i_upd_timestamp;
        }

        #endregion // End of Class Constuctor(s)

        #region Public Properties



        [CompositeKey]
        public Com.GainWinSoft.ERP.Entity.TPmMsId Id
        {
            get { return id; }
            set { id = value; }
        }

        [Property(Column = "I_DISP_ITEM_CD", Length = 25)]
        public virtual string IDispItemCd
        {
            get { return iDispItemCd; }
            set { iDispItemCd = value; }
        }

        [Property(Column = "I_ITEM_DESC", Length = 80)]
        public virtual string IItemDesc
        {
            get { return iItemDesc; }
            set { iItemDesc = value; }
        }

        [Property(Column = "I_ITEM_REV", Length = 5)]
        public virtual string IItemRev
        {
            get { return iItemRev; }
            set { iItemRev = value; }
        }

        [Property(Column = "I_DISP_ITEM_REV", Length = 5)]
        public virtual string IDispItemRev
        {
            get { return iDispItemRev; }
            set { iDispItemRev = value; }
        }

        [Property(Column = "I_MODEL", Length = 80)]
        public virtual string IModel
        {
            get { return iModel; }
            set { iModel = value; }
        }

        [Property(Column = "I_DRW_NO", NotNull = true, Length = 50)]
        public virtual string IDrwNo
        {
            get { return iDrwNo; }
            set { iDrwNo = value; }
        }

        [Property(Column = "I_SPEC", Length = 80)]
        public virtual string ISpec
        {
            get { return iSpec; }
            set { iSpec = value; }
        }

        [Property(Column = "I_SEIBAN", NotNull = true, Length = 23)]
        public virtual string ISeiban
        {
            get { return iSeiban; }
            set { iSeiban = value; }
        }

        [Property(Column = "I_ITEM_TYPE", NotNull = true, Length = 6)]
        public virtual string IItemType
        {
            get { return iItemType; }
            set { iItemType = value; }
        }

        [Property(Column = "I_ITEM_TYPE1", NotNull = true, Length = 6)]
        public virtual string IItemType1
        {
            get { return iItemType1; }
            set { iItemType1 = value; }
        }

        [Property(Column = "I_ITEM_TYPE2", NotNull = true, Length = 8)]
        public virtual string IItemType2
        {
            get { return iItemType2; }
            set { iItemType2 = value; }
        }

        [Property(Column = "I_ITEM_TYPE3", NotNull = true, Length = 6)]
        public virtual string IItemType3
        {
            get { return iItemType3; }
            set { iItemType3 = value; }
        }

        [Property(Column = "I_SALES_PERSON_CD", NotNull = true, Length = 6)]
        public virtual string ISalesPersonCd
        {
            get { return iSalesPersonCd; }
            set { iSalesPersonCd = value; }
        }

        [Property(Column = "I_CTRL_CLS", NotNull = true, Length = 2)]
        public virtual string ICtrlCls
        {
            get { return iCtrlCls; }
            set { iCtrlCls = value; }
        }

        [Property(Column = "I_ITEM_CLS", NotNull = true, Length = 2)]
        public virtual string IItemCls
        {
            get { return iItemCls; }
            set { iItemCls = value; }
        }

        [Property(Column = "I_SO_ALC_CLS", NotNull = true, Length = 2)]
        public virtual string ISoAlcCls
        {
            get { return iSoAlcCls; }
            set { iSoAlcCls = value; }
        }

        [Property(Column = "I_PS_CLS", NotNull = true, Length = 2)]
        public virtual string IPsCls
        {
            get { return iPsCls; }
            set { iPsCls = value; }
        }

        [Property(Column = "I_LOT_METHOD", NotNull = true, Length = 3)]
        public virtual string ILotMethod
        {
            get { return iLotMethod; }
            set { iLotMethod = value; }
        }

        [Property(Column = "I_FPR_PERIOD", NotNull = true)]
        public virtual decimal IFprPeriod
        {
            get { return iFprPeriod; }
            set { iFprPeriod = value; }
        }

        [Property(Column = "I_LOT_QTY", NotNull = true)]
        public virtual decimal ILotQty
        {
            get { return iLotQty; }
            set { iLotQty = value; }
        }

        [Property(Column = "I_LOT_CTRL_CLS", NotNull = true, Length = 2)]
        public virtual string ILotCtrlCls
        {
            get { return iLotCtrlCls; }
            set { iLotCtrlCls = value; }
        }

        [Property(Column = "I_STOCK_CLS", NotNull = true, Length = 2)]
        public virtual string IStockCls
        {
            get { return iStockCls; }
            set { iStockCls = value; }
        }

        [Property(Column = "I_DEL_SCH_CLS", NotNull = true, Length = 2)]
        public virtual string IDelSchCls
        {
            get { return iDelSchCls; }
            set { iDelSchCls = value; }
        }

        [Property(Column = "I_OS_ALC_CLS", NotNull = true, Length = 2)]
        public virtual string IOsAlcCls
        {
            get { return iOsAlcCls; }
            set { iOsAlcCls = value; }
        }

        [Property(Column = "I_PLAN_DVD_CLS", NotNull = true, Length = 2)]
        public virtual string IPlanDvdCls
        {
            get { return iPlanDvdCls; }
            set { iPlanDvdCls = value; }
        }

        [Property(Column = "I_MIN_LOT_QTY", NotNull = true)]
        public virtual decimal IMinLotQty
        {
            get { return iMinLotQty; }
            set { iMinLotQty = value; }
        }

        [Property(Column = "I_SAFE_STOCK_QTY", NotNull = true)]
        public virtual decimal ISafeStockQty
        {
            get { return iSafeStockQty; }
            set { iSafeStockQty = value; }
        }

        [Property(Column = "I_USE_DEL_CLS", NotNull = true, Length = 2)]
        public virtual string IUseDelCls
        {
            get { return iUseDelCls; }
            set { iUseDelCls = value; }
        }

        [Property(Column = "I_STD_UNIT_CD", NotNull = true, Length = 2)]
        public virtual string IStdUnitCd
        {
            get { return iStdUnitCd; }
            set { iStdUnitCd = value; }
        }

        [Property(Column = "I_START_SEQ", NotNull = true)]
        public virtual decimal IStartSeq
        {
            get { return iStartSeq; }
            set { iStartSeq = value; }
        }

        [Property(Column = "I_END_SEQ", NotNull = true)]
        public virtual decimal IEndSeq
        {
            get { return iEndSeq; }
            set { iEndSeq = value; }
        }

        [Property(Column = "I_CNV_UNIT_CD", NotNull = true, Length = 2)]
        public virtual string ICnvUnitCd
        {
            get { return iCnvUnitCd; }
            set { iCnvUnitCd = value; }
        }

        [Property(Column = "I_CNV_RATE_BUNSI", NotNull = true)]
        public virtual decimal ICnvRateBunsi
        {
            get { return iCnvRateBunsi; }
            set { iCnvRateBunsi = value; }
        }

        [Property(Column = "I_CNV_RATE_BUNBO", NotNull = true)]
        public virtual decimal ICnvRateBunbo
        {
            get { return iCnvRateBunbo; }
            set { iCnvRateBunbo = value; }
        }

        [Property(Column = "I_INV_SO_DATE")]
        public virtual decimal IInvSoDate
        {
            get { return iInvSoDate; }
            set { iInvSoDate = value; }
        }

        [Property(Column = "I_SHIP_LOCATION", NotNull = true, Length = 8)]
        public virtual string IShipLocation
        {
            get { return iShipLocation; }
            set { iShipLocation = value; }
        }

        [Property(Column = "I_NET_WEIGHT", NotNull = true)]
        public virtual decimal INetWeight
        {
            get { return iNetWeight; }
            set { iNetWeight = value; }
        }

        [Property(Column = "I_NET_WEIGHT_UNIT", NotNull = true, Length = 2)]
        public virtual string INetWeightUnit
        {
            get { return iNetWeightUnit; }
            set { iNetWeightUnit = value; }
        }

        [Property(Column = "I_GROSS_WEIGHT", NotNull = true)]
        public virtual decimal IGrossWeight
        {
            get { return iGrossWeight; }
            set { iGrossWeight = value; }
        }

        [Property(Column = "I_GROSS_WEIGHT_UNIT", NotNull = true, Length = 2)]
        public virtual string IGrossWeightUnit
        {
            get { return iGrossWeightUnit; }
            set { iGrossWeightUnit = value; }
        }

        [Property(Column = "I_M3", NotNull = true)]
        public virtual decimal IM3
        {
            get { return iM3; }
            set { iM3 = value; }
        }

        [Property(Column = "I_LOW_LEVEL", NotNull = true)]
        public virtual decimal ILowLevel
        {
            get { return iLowLevel; }
            set { iLowLevel = value; }
        }

        [Property(Column = "I_SUM_LT", NotNull = true)]
        public virtual decimal ISumLt
        {
            get { return iSumLt; }
            set { iSumLt = value; }
        }

        [Property(Column = "I_PLAN_QTY", NotNull = true)]
        public virtual decimal IPlanQty
        {
            get { return iPlanQty; }
            set { iPlanQty = value; }
        }

        [Property(Column = "I_MAKER_CD", NotNull = true, Length = 6)]
        public virtual string IMakerCd
        {
            get { return iMakerCd; }
            set { iMakerCd = value; }
        }

        [Property(Column = "I_QRY_MTRL", Length = 80)]
        public virtual string IQryMtrl
        {
            get { return iQryMtrl; }
            set { iQryMtrl = value; }
        }

        [Property(Column = "I_SIZE1", NotNull = true)]
        public virtual decimal ISize1
        {
            get { return iSize1; }
            set { iSize1 = value; }
        }

        [Property(Column = "I_SIZE2", NotNull = true)]
        public virtual decimal ISize2
        {
            get { return iSize2; }
            set { iSize2 = value; }
        }

        [Property(Column = "I_SIZE3", NotNull = true)]
        public virtual decimal ISize3
        {
            get { return iSize3; }
            set { iSize3 = value; }
        }

        [Property(Column = "I_GRAVITY")]
        public virtual decimal IGravity
        {
            get { return iGravity; }
            set { iGravity = value; }
        }

        [Property(Column = "I_PROD_FAC_CD", NotNull = true, Length = 8)]
        public virtual string IProdFacCd
        {
            get { return iProdFacCd; }
            set { iProdFacCd = value; }
        }

        [Property(Column = "I_FG_IN_CLS", NotNull = true, Length = 2)]
        public virtual string IFgInCls
        {
            get { return iFgInCls; }
            set { iFgInCls = value; }
        }

        [Property(Column = "I_PROC_SUM_LT", NotNull = true)]
        public virtual decimal IProcSumLt
        {
            get { return iProcSumLt; }
            set { iProcSumLt = value; }
        }

        [Property(Column = "I_HCDFLG", NotNull = true, Length = 2)]
        public virtual string IHcdflg
        {
            get { return iHcdflg; }
            set { iHcdflg = value; }
        }

        [Property(Column = "I_SPFLG", NotNull = true, Length = 2)]
        public virtual string ISpflg
        {
            get { return iSpflg; }
            set { iSpflg = value; }
        }

        [Property(Column = "I_SPEXC", Length = 100)]
        public virtual string ISpexc
        {
            get { return iSpexc; }
            set { iSpexc = value; }
        }

        [Property(Column = "I_PMRKEY", NotNull = true, Length = 25)]
        public virtual string IPmrkey
        {
            get { return iPmrkey; }
            set { iPmrkey = value; }
        }

        [Property(Column = "I_PMRVER", NotNull = true)]
        public virtual decimal IPmrver
        {
            get { return iPmrver; }
            set { iPmrver = value; }
        }

        [Property(Column = "I_SPNAME", NotNull = true, Length = 6)]
        public virtual string ISpname
        {
            get { return iSpname; }
            set { iSpname = value; }
        }

        [Property(Column = "I_SPDATE")]
        public virtual DateTime ISpdate
        {
            get { return iSpdate; }
            set { iSpdate = value; }
        }

        [Property(Column = "I_STATUS", Length = 48)]
        public virtual string IStatus
        {
            get { return iStatus; }
            set { iStatus = value; }
        }

        [Property(Column = "I_SEPHIN", Length = 25)]
        public virtual string ISephin
        {
            get { return iSephin; }
            set { iSephin = value; }
        }

        [Property(Column = "I_RYUHIN", Length = 25)]
        public virtual string IRyuhin
        {
            get { return iRyuhin; }
            set { iRyuhin = value; }
        }

        [Property(Column = "I_SAKUSEI", Length = 30)]
        public virtual string ISakusei
        {
            get { return iSakusei; }
            set { iSakusei = value; }
        }

        [Property(Column = "I_CTRL_SECTION", NotNull = true, Length = 8)]
        public virtual string ICtrlSection
        {
            get { return iCtrlSection; }
            set { iCtrlSection = value; }
        }

        [Property(Column = "I_SALES_SECTION", Length = 8)]
        public virtual string ISalesSection
        {
            get { return iSalesSection; }
            set { iSalesSection = value; }
        }

        [Property(Column = "I_PURCHASE_SECTION", Length = 8)]
        public virtual string IPurchaseSection
        {
            get { return iPurchaseSection; }
            set { iPurchaseSection = value; }
        }

        [Property(Column = "I_ITEM_ENTRY_CLS", NotNull = true, Length = 2)]
        public virtual string IItemEntryCls
        {
            get { return iItemEntryCls; }
            set { iItemEntryCls = value; }
        }

        [Property(Column = "I_SMT_CLS", NotNull = true, Length = 2)]
        public virtual string ISmtCls
        {
            get { return iSmtCls; }
            set { iSmtCls = value; }
        }

        [Property(Column = "I_ROHS_CLS", NotNull = true, Length = 2)]
        public virtual string IRohsCls
        {
            get { return iRohsCls; }
            set { iRohsCls = value; }
        }

        [Property(Column = "I_REACH_CLS", NotNull = true, Length = 2)]
        public virtual string IReachCls
        {
            get { return iReachCls; }
            set { iReachCls = value; }
        }

        [Property(Column = "I_CHINA_ROHS_CLS", NotNull = true, Length = 2)]
        public virtual string IChinaRohsCls
        {
            get { return iChinaRohsCls; }
            set { iChinaRohsCls = value; }
        }

        [Property(Column = "I_BIN_END_DATE")]
        public virtual decimal IBinEndDate
        {
            get { return iBinEndDate; }
            set { iBinEndDate = value; }
        }

        [Property(Column = "I_MNT_CLS", Length = 2)]
        public virtual string IMntCls
        {
            get { return iMntCls; }
            set { iMntCls = value; }
        }

        [Property(Column = "I_SRL_SEQ_CLS", Length = 2)]
        public virtual string ISrlSeqCls
        {
            get { return iSrlSeqCls; }
            set { iSrlSeqCls = value; }
        }

        [Property(Column = "I_PART_CHG_PERIOD")]
        public virtual decimal IPartChgPeriod
        {
            get { return iPartChgPeriod; }
            set { iPartChgPeriod = value; }
        }

        [Property(Column = "I_PART_CHG_PERIOD_UNIT_CD", Length = 2)]
        public virtual string IPartChgPeriodUnitCd
        {
            get { return iPartChgPeriodUnitCd; }
            set { iPartChgPeriodUnitCd = value; }
        }

        [Property(Column = "I_FIX_MNT_PERIOD")]
        public virtual decimal IFixMntPeriod
        {
            get { return iFixMntPeriod; }
            set { iFixMntPeriod = value; }
        }

        [Property(Column = "I_FIX_MNT_PERIOD_UNIT_CD", Length = 2)]
        public virtual string IFixMntPeriodUnitCd
        {
            get { return iFixMntPeriodUnitCd; }
            set { iFixMntPeriodUnitCd = value; }
        }

        [Property(Column = "I_GUAR_PERIOD")]
        public virtual decimal IGuarPeriod
        {
            get { return iGuarPeriod; }
            set { iGuarPeriod = value; }
        }

        [Property(Column = "I_GUAR_PERIOD_UNIT_CD", Length = 2)]
        public virtual string IGuarPeriodUnitCd
        {
            get { return iGuarPeriodUnitCd; }
            set { iGuarPeriodUnitCd = value; }
        }

        [Property(Column = "I_USEFUL_LIFE")]
        public virtual decimal IUsefulLife
        {
            get { return iUsefulLife; }
            set { iUsefulLife = value; }
        }

        [Property(Column = "I_USEFUL_LIFE_UNIT_CLS", Length = 2)]
        public virtual string IUsefulLifeUnitCls
        {
            get { return iUsefulLifeUnitCls; }
            set { iUsefulLifeUnitCls = value; }
        }

        [Property(Column = "I_CAP_ITEM_TYPE", Length = 6)]
        public virtual string ICapItemType
        {
            get { return iCapItemType; }
            set { iCapItemType = value; }
        }

        [Property(Column = "I_INQ_ITEM", Length = 1)]
        public virtual string IInqItem
        {
            get { return iInqItem; }
            set { iInqItem = value; }
        }

        [Property(Column = "I_OBJECT_ID")]
        public virtual decimal IObjectId
        {
            get { return iObjectId; }
            set { iObjectId = value; }
        }

        [Property(Column = "I_ENTRY_DATE", NotNull = true)]
        public virtual DateTime IEntryDate
        {
            get { return iEntryDate; }
            set { iEntryDate = value; }
        }

        [Property(Column = "I_UPD_DATE", NotNull = true)]
        public virtual DateTime IUpdDate
        {
            get { return iUpdDate; }
            set { iUpdDate = value; }
        }

        [Property(Column = "I_UPD_TIMESTAMP", NotNull = true, Length = 17)]
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
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            TPmMs castObj = (TPmMs)obj;
            return (castObj != null) &&
                (this.id == castObj.id);
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

            sbuffer.AppendFormat("IFacCd = {0}, ", id.IFacCd);
            sbuffer.AppendFormat("IItemCd = {0}, ", id.IItemCd);
            sbuffer.AppendFormat("IDispItemCd = {0}, ", iDispItemCd);
            sbuffer.AppendFormat("IItemDesc = {0}, ", iItemDesc);
            sbuffer.AppendFormat("IItemRev = {0}, ", iItemRev);
            sbuffer.AppendFormat("IDispItemRev = {0}, ", iDispItemRev);
            sbuffer.AppendFormat("IModel = {0}, ", iModel);
            sbuffer.AppendFormat("IDrwNo = {0}, ", iDrwNo);
            sbuffer.AppendFormat("ISpec = {0}, ", iSpec);
            sbuffer.AppendFormat("ISeiban = {0}, ", iSeiban);
            sbuffer.AppendFormat("IItemType = {0}, ", iItemType);
            sbuffer.AppendFormat("IItemType1 = {0}, ", iItemType1);
            sbuffer.AppendFormat("IItemType2 = {0}, ", iItemType2);
            sbuffer.AppendFormat("IItemType3 = {0}, ", iItemType3);
            sbuffer.AppendFormat("ISalesPersonCd = {0}, ", iSalesPersonCd);
            sbuffer.AppendFormat("ICtrlCls = {0}, ", iCtrlCls);
            sbuffer.AppendFormat("IItemCls = {0}, ", iItemCls);
            sbuffer.AppendFormat("ISoAlcCls = {0}, ", iSoAlcCls);
            sbuffer.AppendFormat("IPsCls = {0}, ", iPsCls);
            sbuffer.AppendFormat("ILotMethod = {0}, ", iLotMethod);
            sbuffer.AppendFormat("IFprPeriod = {0}, ", iFprPeriod);
            sbuffer.AppendFormat("ILotQty = {0}, ", iLotQty);
            sbuffer.AppendFormat("ILotCtrlCls = {0}, ", iLotCtrlCls);
            sbuffer.AppendFormat("IStockCls = {0}, ", iStockCls);
            sbuffer.AppendFormat("IDelSchCls = {0}, ", iDelSchCls);
            sbuffer.AppendFormat("IOsAlcCls = {0}, ", iOsAlcCls);
            sbuffer.AppendFormat("IPlanDvdCls = {0}, ", iPlanDvdCls);
            sbuffer.AppendFormat("IMinLotQty = {0}, ", iMinLotQty);
            sbuffer.AppendFormat("ISafeStockQty = {0}, ", iSafeStockQty);
            sbuffer.AppendFormat("IUseDelCls = {0}, ", iUseDelCls);
            sbuffer.AppendFormat("IStdUnitCd = {0}, ", iStdUnitCd);
            sbuffer.AppendFormat("IStartSeq = {0}, ", iStartSeq);
            sbuffer.AppendFormat("IEndSeq = {0}, ", iEndSeq);
            sbuffer.AppendFormat("ICnvUnitCd = {0}, ", iCnvUnitCd);
            sbuffer.AppendFormat("ICnvRateBunsi = {0}, ", iCnvRateBunsi);
            sbuffer.AppendFormat("ICnvRateBunbo = {0}, ", iCnvRateBunbo);
            sbuffer.AppendFormat("IInvSoDate = {0}, ", iInvSoDate);
            sbuffer.AppendFormat("IShipLocation = {0}, ", iShipLocation);
            sbuffer.AppendFormat("INetWeight = {0}, ", iNetWeight);
            sbuffer.AppendFormat("INetWeightUnit = {0}, ", iNetWeightUnit);
            sbuffer.AppendFormat("IGrossWeight = {0}, ", iGrossWeight);
            sbuffer.AppendFormat("IGrossWeightUnit = {0}, ", iGrossWeightUnit);
            sbuffer.AppendFormat("IM3 = {0}, ", iM3);
            sbuffer.AppendFormat("ILowLevel = {0}, ", iLowLevel);
            sbuffer.AppendFormat("ISumLt = {0}, ", iSumLt);
            sbuffer.AppendFormat("IPlanQty = {0}, ", iPlanQty);
            sbuffer.AppendFormat("IMakerCd = {0}, ", iMakerCd);
            sbuffer.AppendFormat("IQryMtrl = {0}, ", iQryMtrl);
            sbuffer.AppendFormat("ISize1 = {0}, ", iSize1);
            sbuffer.AppendFormat("ISize2 = {0}, ", iSize2);
            sbuffer.AppendFormat("ISize3 = {0}, ", iSize3);
            sbuffer.AppendFormat("IGravity = {0}, ", iGravity);
            sbuffer.AppendFormat("IProdFacCd = {0}, ", iProdFacCd);
            sbuffer.AppendFormat("IFgInCls = {0}, ", iFgInCls);
            sbuffer.AppendFormat("IProcSumLt = {0}, ", iProcSumLt);
            sbuffer.AppendFormat("IHcdflg = {0}, ", iHcdflg);
            sbuffer.AppendFormat("ISpflg = {0}, ", iSpflg);
            sbuffer.AppendFormat("ISpexc = {0}, ", iSpexc);
            sbuffer.AppendFormat("IPmrkey = {0}, ", iPmrkey);
            sbuffer.AppendFormat("IPmrver = {0}, ", iPmrver);
            sbuffer.AppendFormat("ISpname = {0}, ", iSpname);
            sbuffer.AppendFormat("ISpdate = {0}, ", iSpdate);
            sbuffer.AppendFormat("IStatus = {0}, ", iStatus);
            sbuffer.AppendFormat("ISephin = {0}, ", iSephin);
            sbuffer.AppendFormat("IRyuhin = {0}, ", iRyuhin);
            sbuffer.AppendFormat("ISakusei = {0}, ", iSakusei);
            sbuffer.AppendFormat("ICtrlSection = {0}, ", iCtrlSection);
            sbuffer.AppendFormat("ISalesSection = {0}, ", iSalesSection);
            sbuffer.AppendFormat("IPurchaseSection = {0}, ", iPurchaseSection);
            sbuffer.AppendFormat("IItemEntryCls = {0}, ", iItemEntryCls);
            sbuffer.AppendFormat("ISmtCls = {0}, ", iSmtCls);
            sbuffer.AppendFormat("IRohsCls = {0}, ", iRohsCls);
            sbuffer.AppendFormat("IReachCls = {0}, ", iReachCls);
            sbuffer.AppendFormat("IChinaRohsCls = {0}, ", iChinaRohsCls);
            sbuffer.AppendFormat("IBinEndDate = {0}, ", iBinEndDate);
            sbuffer.AppendFormat("IMntCls = {0}, ", iMntCls);
            sbuffer.AppendFormat("ISrlSeqCls = {0}, ", iSrlSeqCls);
            sbuffer.AppendFormat("IPartChgPeriod = {0}, ", iPartChgPeriod);
            sbuffer.AppendFormat("IPartChgPeriodUnitCd = {0}, ", iPartChgPeriodUnitCd);
            sbuffer.AppendFormat("IFixMntPeriod = {0}, ", iFixMntPeriod);
            sbuffer.AppendFormat("IFixMntPeriodUnitCd = {0}, ", iFixMntPeriodUnitCd);
            sbuffer.AppendFormat("IGuarPeriod = {0}, ", iGuarPeriod);
            sbuffer.AppendFormat("IGuarPeriodUnitCd = {0}, ", iGuarPeriodUnitCd);
            sbuffer.AppendFormat("IUsefulLife = {0}, ", iUsefulLife);
            sbuffer.AppendFormat("IUsefulLifeUnitCls = {0}, ", iUsefulLifeUnitCls);
            sbuffer.AppendFormat("ICapItemType = {0}, ", iCapItemType);
            sbuffer.AppendFormat("IInqItem = {0}, ", iInqItem);
            sbuffer.AppendFormat("IObjectId = {0}, ", iObjectId);
            sbuffer.AppendFormat("IEntryDate = {0}, ", iEntryDate);
            sbuffer.AppendFormat("IUpdDate = {0}, ", iUpdDate);
            sbuffer.AppendFormat("IUpdTimestamp = {0}, ", iUpdTimestamp);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion

    }
}
