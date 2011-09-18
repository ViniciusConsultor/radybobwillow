using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using NHibernate;
using NHibernate.Transform;
using Com.GainWinSoft.Common;
using System.Data.Common;
using Castle.ActiveRecord.Queries;
using System.Collections;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    class CTPmMsNoARDaoOracleImp : ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICTPmMsNoARDao
    {
        public IList<CTPmMsNoAR> GetPmMsDetail(SearchCondition condition, bool allFactory)
        {

            IList<CTPmMsNoAR> result = new List<CTPmMsNoAR>();

            ISession ss = holder.CreateSession(typeof(CTPmMsNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {




                StringBuilder sql = new StringBuilder();
                //select f.catalogid,f.functionid,f.functionimage,f.functionindex,f.functionname,f.functionpath,f.langid,c.catalogimage,c.catalogname from (M_FUNCTION f inner join (select functionid from m_role_function 
                //where roleid=1 group by functionid) r on (f.functionid=r.functionid)) left join
                //m_functioncatalog c on (f.catalogid=c.catalogid and f.langid=c.langid)
                //where f.langid='zh-CN'
                //order by f.catalogid,f.functionindex

                sql.AppendLine(" SELECT ");
                sql.AppendLine(" T_PM_MS.I_FAC_CD iFacCd, ");//工場番号
                sql.AppendLine(" T_PM_MS.I_ITEM_CD iItemCd, ");//品目番号
                sql.AppendLine(" T_PM_MS.I_DISP_ITEM_CD iDispItemCd, ");//表示品目番号
                sql.AppendLine(" T_PM_MS.I_ITEM_DESC iItemDesc, ");//品目名
                sql.AppendLine(" T_PM_MS.I_ITEM_REV iItemRev, ");//品目版数
                sql.AppendLine(" T_PM_MS.I_DISP_ITEM_REV iDispItemRev, ");//表示品目版数
                sql.AppendLine(" TRIM(T_PM_MS.I_MODEL) iModel, ");//型式
                sql.AppendLine(" TRIM(T_PM_MS.I_DRW_NO) iDrwNo , ");//図番
                sql.AppendLine(" TRIM(T_PM_MS.I_SPEC) iSpec, ");//仕様
                sql.AppendLine(" TRIM(T_PM_MS.I_SEIBAN) iSeiban, ");//製番
                sql.AppendLine(" TRIM(T_PM_MS.I_ITEM_TYPE) iItemType, ");//品目分類
                sql.AppendLine(" TRIM(T_PM_MS.I_ITEM_TYPE1) iItemType1, ");//取扱品目分類1
                sql.AppendLine(" TRIM(T_PM_MS.I_ITEM_TYPE2) iDlCd, ");//取扱品目分類2
                sql.AppendLine(" TRIM(T_PM_MS.I_ITEM_TYPE3) iItemType3, ");//取扱品目分類3
                sql.AppendLine(" T_PM_MS.I_SALES_PERSON_CD iSalesPersonCd, ");//売上担当者
                sql.AppendLine(" T_PM_MS.I_CTRL_CLS iCtrlCls, ");//管理区分
                sql.AppendLine(" T_PM_MS.I_ITEM_CLS iItemCls, ");//品目区分
                sql.AppendLine(" T_PM_MS.I_SO_ALC_CLS iSoAlcCls, ");//受注在庫引当区分
                sql.AppendLine(" T_PM_MS.I_PS_CLS iPsCls, ");//構成区分
                sql.AppendLine(" TRIM(T_PM_MS.I_LOT_METHOD) iLotMethod, ");//ロット方式
                sql.AppendLine(" T_PM_MS.I_FPR_PERIOD iFprPeriod, ");//FPR期間
                sql.AppendLine(" T_PM_MS.I_LOT_QTY iLotQty, ");//ロット決定値
                sql.AppendLine(" T_PM_MS.I_LOT_CTRL_CLS iLotCtrlCls, ");//ロット管理区分
                sql.AppendLine(" T_PM_MS.I_STOCK_CLS iStockCls, ");//在庫区分
                sql.AppendLine(" T_PM_MS.I_DEL_SCH_CLS iDelSchCls, ");//納入日程作成区分
                sql.AppendLine(" T_PM_MS.I_OS_ALC_CLS iOsAlcCls, ");//製番在庫引当区分
                sql.AppendLine(" T_PM_MS.I_PLAN_DVD_CLS iPlanDvdCls, ");//計画分割区分
                sql.AppendLine(" T_PM_MS.I_MIN_LOT_QTY iMinLotQty, ");//最低ロット数
                sql.AppendLine(" T_PM_MS.I_SAFE_STOCK_QTY iSafeStockQty, ");//安全在庫数
                sql.AppendLine(" T_PM_MS.I_USE_DEL_CLS iUseDelCls, ");//出来高出庫区分
                sql.AppendLine(" T_PM_MS.I_STD_UNIT_CD iStdUnitCd, ");//基本単位
                sql.AppendLine(" T_PM_MS.I_START_SEQ iStartSeq, ");//開始順序
                sql.AppendLine(" T_PM_MS.I_END_SEQ iEndSeq, ");//終了順序
                sql.AppendLine(" T_PM_MS.I_CNV_UNIT_CD iCnvUnitCd, ");//変換単位
                sql.AppendLine(" T_PM_MS.I_CNV_RATE_BUNSI iCnvRateBunsi, ");//変換率分子
                sql.AppendLine(" T_PM_MS.I_CNV_RATE_BUNBO iCnvRateBunbo, ");//変換率分母
                sql.AppendLine(" T_PM_MS.I_INV_SO_DATE iInvSoDate, ");//無効受注日
                sql.AppendLine(" T_PM_MS.I_SHIP_LOCATION iShipLocation, ");//出荷在庫場所
                sql.AppendLine(" T_PM_MS.I_NET_WEIGHT iNetWeight, ");//品目重量
                sql.AppendLine(" T_PM_MS.I_NET_WEIGHT_UNIT iNetWeightUnit, ");//品目重量単位
                sql.AppendLine(" T_PM_MS.I_GROSS_WEIGHT iGrossWeight, ");//梱包後重量
                sql.AppendLine(" T_PM_MS.I_GROSS_WEIGHT_UNIT iGrossWeightUnit, ");//梱包後重量単位
                sql.AppendLine(" T_PM_MS.I_M3 iM3, ");//梱包後容積
                sql.AppendLine(" T_PM_MS.I_LOW_LEVEL iLowLevel, ");//ローレベル
                sql.AppendLine(" T_PM_MS.I_SUM_LT iSumLt, ");//累計LT
                sql.AppendLine(" T_PM_MS.I_PLAN_QTY iPlanQty, ");//計画数
                sql.AppendLine(" T_PM_MS.I_MAKER_CD iMakerCd, ");//メーカコード
                sql.AppendLine(" T_PM_MS.I_QRY_MTRL iQryMtrl, ");//材質
                sql.AppendLine(" T_PM_MS.I_SIZE1 iSize1, ");//寸法1
                sql.AppendLine(" T_PM_MS.I_SIZE2 iSize2, ");//寸法2
                sql.AppendLine(" T_PM_MS.I_SIZE3 iSize3, ");//寸法3
                sql.AppendLine(" T_PM_MS.I_GRAVITY iGravity, ");//比重
                sql.AppendLine(" T_PM_MS.I_PROD_FAC_CD iProdFacCd, ");//生産工場
                sql.AppendLine(" T_PM_MS.I_FG_IN_CLS iFgInCls, ");//倉入区分
                sql.AppendLine(" T_PM_MS.I_PROC_SUM_LT iProcSumLt, ");//工程合計LT
                sql.AppendLine(" T_PM_MS.I_HCDFLG iHcdflg, ");//使用許可フラグ
                sql.AppendLine(" T_PM_MS.I_SPFLG iSpflg, ");//設計変更フラグ
                sql.AppendLine(" T_PM_MS.I_SPEXC iSpexc, ");//設計変更理由
                sql.AppendLine(" T_PM_MS.I_PMRKEY iPmrkey, ");//PM履歴品番
                sql.AppendLine(" T_PM_MS.I_PMRVER iPmrver, ");//PM履歴バージョン
                sql.AppendLine(" T_PM_MS.I_SPNAME iSpname, ");//設計変更者
                sql.AppendLine(" T_PM_MS.I_SPDATE iSpdate, ");//設変日
                sql.AppendLine(" T_PM_MS.I_STATUS iStatus, ");//設変状況名
                sql.AppendLine(" T_PM_MS.I_SEPHIN iSephin, ");//設計変更元品目番号
                sql.AppendLine(" T_PM_MS.I_RYUHIN iRyuhin, ");//流用元品目番号
                sql.AppendLine(" T_PM_MS.I_SAKUSEI iSakusei, ");//図面作成者名
                sql.AppendLine(" T_PM_MS.I_CTRL_SECTION iCtrlSection, ");//管理部門
                sql.AppendLine(" T_PM_MS.I_SALES_SECTION iSalesSection, ");//管理部門
                sql.AppendLine(" T_PM_MS.I_PURCHASE_SECTION iPurchaseSection, ");//管理部門

                sql.AppendLine(" T_PM_MS.I_ITEM_ENTRY_CLS iItemEntryCls, ");//品目登録区分
                sql.AppendLine(" T_PM_MS.I_SMT_CLS iSmtCls, ");//SMT区分
                sql.AppendLine(" T_PM_MS.I_ROHS_CLS iRohsCls, ");//Rohs区分
                sql.AppendLine(" T_PM_MS.I_REACH_CLS iReachCls, ");//REACH区分
                sql.AppendLine(" T_PM_MS.I_CHINA_ROHS_CLS iChinaRohsCls, ");//中国Rohs区分

                //-------[3.0.0907.0801] 2009.07.08 Fns)k.ito add str 【V3(保守管理)対応】
                sql.AppendLine(" T_PM_MS.I_BIN_END_DATE iBinEndDate, ");//保管期限
                sql.AppendLine(" T_PM_MS.I_PART_CHG_PERIOD iPartChgPeriod, ");//部品交換期間
                sql.AppendLine(" T_PM_MS.I_PART_CHG_PERIOD_UNIT_CD iPartChgPeriodUnitCd, ");//部品交換期間単位
                sql.AppendLine(" T_PM_MS.I_FIX_MNT_PERIOD iFixMntPeriod, ");//定期保守期間
                sql.AppendLine(" T_PM_MS.I_FIX_MNT_PERIOD_UNIT_CD iFixMntPeriodUnitCd, ");//定期保守期間単位
                sql.AppendLine(" T_PM_MS.I_GUAR_PERIOD iGuarPeriod, ");//保証期間
                sql.AppendLine(" T_PM_MS.I_GUAR_PERIOD_UNIT_CD iGuarPeriodUnitCd, ");//保証期間単位
                sql.AppendLine(" T_PM_MS.I_MNT_CLS iMntCls, ");//保守区分
                sql.AppendLine(" T_PM_MS.I_SRL_SEQ_CLS iSrlSeqCls, ");//号機採番要否区分
                sql.AppendLine(" T_PM_MS.I_USEFUL_LIFE iUsefulLife, ");//耐用寿命
                sql.AppendLine(" T_PM_MS.I_USEFUL_LIFE_UNIT_CLS iUsefulLifeUnitCls, ");//耐用寿命単位区分
                //-------[3.0.0908.0601] 2009.07.08 Fns)k.ito add end 【V3(保守管理)対応】

                sql.AppendLine(" T_PM_MS.I_CAP_ITEM_TYPE iCapItemType, ");

                sql.AppendLine(" T_PM_MS.I_INQ_ITEM iInqItem, ");//照会項目
                sql.AppendLine(" T_PM_MS.I_OBJECT_ID iObjectId, ");//オブジェクトＩＤ
                sql.AppendLine(" T_PM_MS.I_ENTRY_DATE iEntryDate, ");//登録日
                sql.AppendLine(" T_PM_MS.I_UPD_DATE iUpdDate, ");//更新日
                sql.AppendLine(" T_PM_MS.I_UPD_TIMESTAMP iUpdTimestamp, ");//更新タイムスタンプ
                //sql.AppendLine(" T_PM_MS_ADD_RTCM.*, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINSYOSAI1 iHinsyosai1, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINSYOSAI2 iHinsyosai2, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINSYOSAI3 iHinsyosai3, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINSYOSAI4 iHinsyosai4, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINSYOSAI5 iHinsyosai5, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HKHINNO1 iHkhinno1, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HKHINNO2 iHkhinno2, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HKHINNO3 iHkhinno3, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINZKS1 iHinzks1, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINZKS2 iHinzks2, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINZKS3 iHinzks3, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZRYOBNR iZryobnr, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_CSTHSKKBN iCsthskkbn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_CSTKSKBN iCstkskbn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_KGSANKBN iKgsankbn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_SKRKEJKBN iSkrkejkbn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_TMHSKKBN iTmhskkbn, ");//品目情報追加RTCM
                //sql.AppendLine(" T_PM_MS_ADD_RTCM.I_TMZRYOBNR iTmzryobnr, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_TMCSTMKNO iTmcstmkno, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_SZCRTKBN iSzcrtkbn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HDTKZCH_BNSHI iHdtkzchBnshi, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HDTKZCH_BNBO iHdtkzchBnbo, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HDKMTNICD iHdkmtnicd, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_LOT_SESANRYO iLotSesanryo, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_DAY_SESANRYO iDaySesanryo, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_YIELD_RATE iYieldRate, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_FUKUKBN iFukukbn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_SGENKBN iSgenkbn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_TENFUYKBN iTenfuykbn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_DAIKOTEPTN iDaikoteptn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_DHHIGPTN iDhhigptn, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNSHI1 iZktkzchBnshi1, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNBO1 iZktkzchBnbo1, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTIKZTICD1 iZktikzticd1, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNBO2 iZktkzchBnbo2, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNSHI2 iZktkzchBnshi2, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTIKZTICD2 iZktikzticd2, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNSHI3 iZktkzchBnshi3, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNBO3 iZktkzchBnbo3, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTIKZTICD3 iZktikzticd3, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNSHI4 iZktkzchBnshi4, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNBO4 iZktkzchBnbo4, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNSHI5 iZktkzchBnshi5, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTKZCH_BNBO5 iZktkzchBnbo5, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_ZKTIKZTICD5 iZktikzticd5, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINKSU01 iHinksu01, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINKSU02 iHinksu02, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINKSU03 iHinksu03, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINKSU04 iHinksu04, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINKSU05 iHinksu05, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINKSU06 iHinksu06, ");//品目情報追加RTCM
                sql.AppendLine(" T_PM_MS_ADD_RTCM.I_HINKSU07 iHinksu07, ");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINKSU08 iHinksu08 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINKSU09 iHinksu09 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINKSU10 iHinksu10 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR01 iHinbnr01 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR02 iHinbnr02 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR03 iHinbnr03 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR04 iHinbnr04 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR05 iHinbnr05 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR06 iHinbnr06 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR07 iHinbnr07 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR08 iHinbnr08 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR09 iHinbnr09 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HINBNR10 iHinbnr10 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_JOHHTKBN iJohhtkbn ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HFTKBN1 iHftkbn1 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HFTKBN2 iHftkbn2 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HFTKBN3 iHftkbn3 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HFTKBN4 iHftkbn4 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_HFTKBN5 iHftkbn5 ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_SYTSUKAKBN iSytsukakbn ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_TNGMHFKBN iTngmhfkbn ,");//品目情報追加RTCM
                sql.AppendLine("T_PM_MS_ADD_RTCM.I_TNHKSHFKBN iTnhkshfkbn ,");//品目情報追加RTCM







                sql.AppendLine(" VTL_CLS_01.I_CLS_DETAIL_DESC vItemclsdesc, ");//品目区分名
                sql.AppendLine(" VTL_CLS_02.I_CLS_DETAIL_DESC vCtrlclsdesc, ");//管理区分名
                sql.AppendLine(" VTL_CLS_03.I_CLS_DETAIL_DESC vLotctrlclsdesc, ");//ロット管理区分名
                sql.AppendLine(" VTL_CLS_04.I_CLS_DETAIL_DESC vUsedelclsdesc, ");//出来高出庫区分名
                sql.AppendLine(" VTL_CLS_05.I_CLS_DETAIL_DESC vSoalcclsdesc, ");//受注在庫引当区分名
                sql.AppendLine(" VTL_CLS_06.I_CLS_DETAIL_DESC vPsclsdesc, ");//構成区分名
                sql.AppendLine(" VTL_CLS_07.I_CLS_DETAIL_DESC vSmtclsdesc, ");//SMT区分名
                sql.AppendLine(" VTL_CLS_08.I_CLS_DETAIL_DESC vRohsclsdesc, ");//Rohs区分名
                sql.AppendLine(" VTL_CLS_09.I_CLS_DETAIL_DESC vReachclsdesc, ");//REACH区分名
                sql.AppendLine(" VTL_CLS_10.I_CLS_DETAIL_DESC vChinarohsclsdesc, ");//中国Rohs区分名
                sql.AppendLine(" VTL_CLS_11.I_CLS_DETAIL_DESC vOsalcclsdesc, ");//製番在庫引当区分名
                sql.AppendLine(" VTL_CLS_12.I_CLS_DETAIL_DESC vCsthskkbndesc, ");//原価方式区分名
                sql.AppendLine(" VTL_CLS_13.I_CLS_DETAIL_DESC vCstkskbndesc, ");//原価計算区分名
                sql.AppendLine(" VTL_CLS_14.I_CLS_DETAIL_DESC vKgsankbndesc, ");//金額算出区分名
                sql.AppendLine(" VTL_CLS_15.I_CLS_DETAIL_DESC vSkrkejkbndesc, ");//仕掛計上区分名
                sql.AppendLine(" VTL_CLS_16.I_CLS_DETAIL_DESC vTmhskkbndesc, ");//積上方式区分名
                sql.AppendLine(" VTL_CLS_17.I_CLS_DETAIL_DESC vSzcrtkbndesc, ");//消費実績作成区分名
                sql.AppendLine(" VTL_CLS_18.I_CLS_DETAIL_DESC vFukukbndesc, ");//副産物区分名
                sql.AppendLine(" VTL_CLS_19.I_CLS_DETAIL_DESC vSgenkbndesc, ");//主原料区分名
                sql.AppendLine(" VTL_CLS_20.I_CLS_DETAIL_DESC vTenfuykbndesc, ");//展開不要区分名
                sql.AppendLine(" VTL_CLS_21.I_CLS_DETAIL_DESC vJohhtkbndesc, ");//上位品目配賦対象区分名
                sql.AppendLine(" VTL_CLS_22.I_CLS_DETAIL_DESC vHftkbndesc1, ");//配賦対象区分名1
                sql.AppendLine(" VTL_CLS_23.I_CLS_DETAIL_DESC vHftkbndesc2, ");//配賦対象区分名2
                sql.AppendLine(" VTL_CLS_24.I_CLS_DETAIL_DESC vHftkbndesc3, ");//配賦対象区分名3
                sql.AppendLine(" VTL_CLS_25.I_CLS_DETAIL_DESC vHftkbndesc4, ");//配賦対象区分名4
                sql.AppendLine(" VTL_CLS_26.I_CLS_DETAIL_DESC vHftkbndesc5, ");//配賦対象区分名5
                sql.AppendLine(" VTL_DESC_01.I_NAME_DESC vItemtypedesc, ");//品目分類名
                sql.AppendLine(" VTL_DESC_02.I_NAME_DESC vItemtype1desc, ");//品目分類1名
                sql.AppendLine(" T_TRADE_MS.I_DL_DESC vDlDesc, ");//品目分類2名
                sql.AppendLine(" VTL_DESC_04.I_NAME_DESC vItemtype3desc, ");//品目分類3名
                sql.AppendLine(" VTL_DESC_05.I_NAME_DESC vMakerdesc, ");//メーカ名
                sql.AppendLine(" VTL_DESC_06.I_NAME_DESC vZryobnrdesc, ");//材料分類名
                //-------[2.0.[]0907.1101] 2009.07.11 Fsol)imatomi del str
                //sql.AppendLine(" VTL_DESC_07.I_NAME_DESC vTmzryobnrdesc, ");//積上材料分類名
                //-------[2.0.[]0907.1101] 2009.07.11 Fsol)imatomi del end
                sql.AppendLine(" VTL_DESC_08.I_NAME_DESC vHinbnr01desc, ");//品目分類名01
                sql.AppendLine(" VTL_DESC_09.I_NAME_DESC vHinbnr02desc, ");//品目分類名02
                sql.AppendLine(" VTL_DESC_10.I_NAME_DESC vHinbnr03desc, ");//品目分類名03
                sql.AppendLine(" VTL_DESC_11.I_NAME_DESC vHinbnr04desc, ");//品目分類名04
                sql.AppendLine(" VTL_DESC_12.I_NAME_DESC vHinbnr05desc, ");//品目分類名05
                sql.AppendLine(" VTL_DESC_13.I_NAME_DESC vHinbnr06desc, ");//品目分類名06
                sql.AppendLine(" VTL_DESC_14.I_NAME_DESC vHinbnr07desc, ");//品目分類名07
                sql.AppendLine(" VTL_DESC_15.I_NAME_DESC vHinbnr08desc, ");//品目分類名08
                sql.AppendLine(" VTL_DESC_16.I_NAME_DESC vHinbnr09desc, ");//品目分類名09
                sql.AppendLine(" VTL_DESC_17.I_NAME_DESC vHinbnr10desc, ");//品目分類名10
                sql.AppendLine(" VTL_UNIT_01.I_UNIT_DESC vHdkmtnicddesc, ");//払出換算前単位名
                sql.AppendLine(" VTL_UNIT_02.I_UNIT_DESC vZktikzticd1desc, ");//在庫単位換算単位名1
                sql.AppendLine(" VTL_UNIT_03.I_UNIT_DESC vZktikzticd2desc, ");//在庫単位換算単位名2
                sql.AppendLine(" VTL_UNIT_04.I_UNIT_DESC vZktikzticd3desc, ");//在庫単位換算単位名3
                sql.AppendLine(" VTL_UNIT_05.I_UNIT_DESC vZktikzticd4desc, ");//在庫単位換算単位名4
                sql.AppendLine(" VTL_UNIT_06.I_UNIT_DESC vZktikzticd5desc, ");//在庫単位換算単位名5
                //-------[2.0.0906.0901] 2009.06.09 Fsol)imatomi mod str
                //sql.AppendLine(" VTL_TRADE_01.I_DL_ARG_DESC V_CTRL_SECTION_DESC, ");//管理部門名
                //sql.AppendLine(" VTL_TRADE_02.I_DL_ARG_DESC V_STOCK_LOCATION_DESC, ");//在庫場所名
                //sql.AppendLine(" VTL_TRADE_03.I_DL_ARG_DESC V_FAC_DESC, ");//工場番号名
                //sql.AppendLine(" VTL_PERSON_01.I_PERSON_DESC V_PERSON_DESC, ");//売上担当者名

                sql.AppendLine(" VTL_SEC_01.I_SECTION_ARG_DESC vCtrlsectiondesc, ");//管理部門名
                sql.AppendLine(" VTL_WH_01.I_WH_PRCS_ARG_DESC vStocklocationdesc, ");//在庫場所名
                sql.AppendLine(" VTL_FC_CON.I_FAC_ARG_DESC vFacdesc, ");//工場番号名
                sql.AppendLine(" VTL_PERSON_01.I_PERSON_DESC vPersondesc, ");//売上担当者名
                //-------[2.0.0906.0901] 2009.06.09 Fsol)imatomi mod end
                sql.AppendLine(" T_UNIT_MS_01.I_UNIT_DESC iStdunitdesc, ");//基本単位名
                sql.AppendLine(" T_UNIT_MS_02.I_UNIT_DESC iCnvunitdesc, ");//変換単位名
                sql.AppendLine(" T_UNIT_MS_03.I_UNIT_DESC iNetweightunitdesc, ");//品目重量単位名

                //-------[3.0.0907.0801] 2009.07.08 Fns)k.ito add str 【V3(保守管理)対応】
                sql.AppendLine(" VTL_CLS_27.I_CLS_DETAIL_DESC iPartchgperiodunitdesc, ");//部品交換期間単位
                sql.AppendLine(" VTL_CLS_28.I_CLS_DETAIL_DESC iFixmntperiodunitdesc, ");//定期保守期間単位
                sql.AppendLine(" VTL_CLS_29.I_CLS_DETAIL_DESC iGuarperiodunitdesc, ");//保証期間単位
                sql.AppendLine(" VTL_CLS_30.I_CLS_DETAIL_DESC iMntclsdesc, ");//保守区分
                sql.AppendLine(" VTL_CLS_31.I_CLS_DETAIL_DESC iSrlseqclsdesc, ");//号機採番要否区分
                sql.AppendLine(" VTL_CLS_32.I_CLS_DETAIL_DESC iUsefullifeunitclsdesc ");//耐用寿命単位区分
                //-------[3.0.0908.0601] 2009.07.08 Fns)k.ito add end 【V3(保守管理)対応】

                sql.AppendLine(" FROM T_PM_MS ");

                sql.AppendLine(" LEFT JOIN T_PM_MS_ADD_RTCM ON ( T_PM_MS.I_FAC_CD = T_PM_MS_ADD_RTCM.I_FAC_CD ");
                sql.AppendLine("                               AND T_PM_MS.I_ITEM_CD = T_PM_MS_ADD_RTCM.I_ITEM_CD ) ");//品目情報追加RTCM
                //-------[2.0.0906.0901] 2009.06.09 Fsol)imatomi add str
                sql.AppendLine(" LEFT JOIN T_PM_MS_ADD ON ( T_PM_MS.I_FAC_CD = T_PM_MS_ADD.I_FAC_CD  ");
                sql.AppendLine("                           AND T_PM_MS.I_ITEM_CD = T_PM_MS_ADD.I_ITEM_CD ) ");//品目情報追加
                //-------[2.0.0906.0901] 2009.06.09 Fsol)imatomi add end

                sql.Append("     LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_01 ON ( VTL_CLS_01.I_CLS_CD = '").Append(Constant.ITEM).AppendLine("' AND VTL_CLS_01.I_CLS_DETAIL_CD = T_PM_MS.I_ITEM_CLS ");//品目区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_01.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append("     LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_02 ON ( VTL_CLS_02.I_CLS_CD = '").Append(Constant.CTRL).AppendLine("' AND VTL_CLS_02.I_CLS_DETAIL_CD = T_PM_MS.I_CTRL_CLS ");//管理区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_02.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append("     LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_03 ON ( VTL_CLS_03.I_CLS_CD = '").Append(Constant.LOTCTRL).AppendLine("' AND VTL_CLS_03.I_CLS_DETAIL_CD = T_PM_MS.I_LOT_CTRL_CLS ");//ロット管理区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_03.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append("     LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_04 ON ( VTL_CLS_04.I_CLS_CD = '").Append(Constant.USEDEL).AppendLine("' AND VTL_CLS_04.I_CLS_DETAIL_CD = T_PM_MS.I_USE_DEL_CLS ");//出来高出庫区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_04.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_05 ON ( VTL_CLS_05.I_CLS_CD = '").Append(Constant.SOALC).AppendLine("' AND VTL_CLS_05.I_CLS_DETAIL_CD = T_PM_MS.I_SO_ALC_CLS ");//受注在庫引当区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_05.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_06 ON ( VTL_CLS_06.I_CLS_CD = '").Append(Constant.PS).AppendLine("' AND VTL_CLS_06.I_CLS_DETAIL_CD = T_PM_MS.I_PS_CLS ");//構成区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_06.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_07 ON ( VTL_CLS_07.I_CLS_CD = '").Append(Constant.SMT).AppendLine("' AND VTL_CLS_07.I_CLS_DETAIL_CD = T_PM_MS.I_SMT_CLS ");//SMT区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_07.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_08 ON ( VTL_CLS_08.I_CLS_CD = '").Append(Constant.ROHS).AppendLine("' AND VTL_CLS_08.I_CLS_DETAIL_CD = T_PM_MS.I_ROHS_CLS ");//Rohs区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_08.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_09 ON ( VTL_CLS_09.I_CLS_CD = '").Append(Constant.REACH).AppendLine("' AND VTL_CLS_09.I_CLS_DETAIL_CD = T_PM_MS.I_REACH_CLS ");//REACH区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_09.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_10 ON ( VTL_CLS_10.I_CLS_CD = '").Append(Constant.CHINAROHS).AppendLine("' AND VTL_CLS_10.I_CLS_DETAIL_CD = T_PM_MS.I_CHINA_ROHS_CLS ");//中国Rohs区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_10.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_11 ON ( VTL_CLS_11.I_CLS_CD = '").Append(Constant.SEIBANALC).AppendLine("' AND VTL_CLS_11.I_CLS_DETAIL_CD = T_PM_MS.I_OS_ALC_CLS ");//製番在庫引当区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_11.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_12 ON ( VTL_CLS_12.I_CLS_CD = '").Append("R07").AppendLine("' AND VTL_CLS_12.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_CSTHSKKBN ");//原価方式区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_12.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_13 ON ( VTL_CLS_13.I_CLS_CD = '").Append("R50").AppendLine("' AND VTL_CLS_13.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_CSTKSKBN ");//原価計算区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_13.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_14 ON ( VTL_CLS_14.I_CLS_CD = '").Append("R24").AppendLine("' AND VTL_CLS_14.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_KGSANKBN ");//金額算出区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_14.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_15 ON ( VTL_CLS_15.I_CLS_CD = '").Append("R25").AppendLine("' AND VTL_CLS_15.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_SKRKEJKBN ");//仕掛計上区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_15.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_16 ON ( VTL_CLS_16.I_CLS_CD = '").Append("T29").AppendLine("' AND VTL_CLS_16.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_TMHSKKBN ");//積上方式区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_16.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_17 ON ( VTL_CLS_17.I_CLS_CD = '").Append("T31").AppendLine("' AND VTL_CLS_17.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_SZCRTKBN ");//消費実績作成区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_17.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_18 ON ( VTL_CLS_18.I_CLS_CD = '").Append("T32").AppendLine("' AND VTL_CLS_18.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_FUKUKBN ");//副産物区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_18.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_19 ON ( VTL_CLS_19.I_CLS_CD = '").Append("T33").AppendLine("' AND VTL_CLS_19.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_SGENKBN ");//主原料区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_19.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_20 ON ( VTL_CLS_20.I_CLS_CD = '").Append("R26").AppendLine("' AND VTL_CLS_20.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_TENFUYKBN ");//展開不要区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_20.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_21 ON ( VTL_CLS_21.I_CLS_CD = '").Append("T40").AppendLine("' AND VTL_CLS_21.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_JOHHTKBN ");//上位品目配賦対象区分名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_21.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_22 ON ( VTL_CLS_22.I_CLS_CD = '").Append("T40").AppendLine("' AND VTL_CLS_22.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_HFTKBN1 ");//配賦対象区分名1
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_22.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_23 ON ( VTL_CLS_23.I_CLS_CD = '").Append("T40").AppendLine("' AND VTL_CLS_23.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_HFTKBN2 ");//配賦対象区分名2
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_23.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_24 ON ( VTL_CLS_24.I_CLS_CD = '").Append("T40").AppendLine("' AND VTL_CLS_24.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_HFTKBN3 ");//配賦対象区分名3
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_24.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_25 ON ( VTL_CLS_25.I_CLS_CD = '").Append("T40").AppendLine("' AND VTL_CLS_25.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_HFTKBN4 ");//配賦対象区分名4
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_25.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_26 ON ( VTL_CLS_26.I_CLS_CD = '").Append("T40").AppendLine("' AND VTL_CLS_26.I_CLS_DETAIL_CD = T_PM_MS_ADD_RTCM.I_HFTKBN5 ");//配賦対象区分名5
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_CLS_26.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_01 ON ( VTL_DESC_01.I_CLS_CD = '").Append("65").AppendLine("' AND VTL_DESC_01.I_NAME_CD = T_PM_MS.I_ITEM_TYPE ");//品目分類名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_01.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_02 ON ( VTL_DESC_02.I_CLS_CD = '").Append("79").AppendLine("' AND VTL_DESC_02.I_NAME_CD = T_PM_MS.I_ITEM_TYPE1 ");//品目分類1名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_02.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                //sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_03 ON ( VTL_DESC_03.I_CLS_CD = '").Append("80").AppendLine("' AND VTL_DESC_03.I_NAME_CD = T_PM_MS.I_ITEM_TYPE2 ");//品目分類2名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                //sql.Append("           AND VTL_DESC_03.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                //modified  2011.09.16 I_ITEM_TYPE2 as 客户代码
                sql.Append(" LEFT JOIN T_TRADE_MS  ON ( T_TRADE_MS.I_COMPANY_CD = ").Append(":companyCd").AppendLine("' AND T_TRADE_MS.I_DL_CD = T_PM_MS.I_ITEM_TYPE2) ");//品目分類2名



                //modified 2011.09.16 I_ITEM_TYPE3 as 课税区分
                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_DESC_04 ON ( VTL_DESC_04.I_CLS_CD = '").Append("18").AppendLine("' AND VTL_DESC_04.I_CLS_DETAIL_CD = T_PM_MS.I_ITEM_TYPE3 ");//品目分類3名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_04.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_05 ON ( VTL_DESC_05.I_CLS_CD = '").Append(Constant.MAKER).AppendLine("' AND VTL_DESC_05.I_NAME_CD = T_PM_MS.I_MAKER_CD ");//メーカ名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_05.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_06 ON ( VTL_DESC_06.I_CLS_CD = '").Append("R02").AppendLine("' AND VTL_DESC_06.I_NAME_CD = T_PM_MS_ADD_RTCM.I_ZRYOBNR ");//材料分類名
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_06.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                //-------[2.0.0907.1101] 2009.07.11 Fsol)imatomi del str
                //sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_07 ON ( VTL_DESC_07.I_CLS_CD = '").Append("R02").AppendLine("' AND VTL_DESC_07.I_NAME_CD = T_PM_MS_ADD_RTCM.I_TMZRYOBNR ");//積上材料分類名
                ////-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                //sql.Append("           AND VTL_DESC_07.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                ////-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end
                //-------[2.0.0907.1101] 2009.07.11 Fsol)imatomi del end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_08 ON ( VTL_DESC_08.I_CLS_CD = '").Append("S39").AppendLine("' AND VTL_DESC_08.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR01 ");//品目分類名01
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_08.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_09 ON ( VTL_DESC_09.I_CLS_CD = '").Append("S40").AppendLine("' AND VTL_DESC_09.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR02 ");//品目分類名02
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_09.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_10 ON ( VTL_DESC_10.I_CLS_CD = '").Append("S41").AppendLine("' AND VTL_DESC_10.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR03 ");//品目分類名03
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_10.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_11 ON ( VTL_DESC_11.I_CLS_CD = '").Append("S42").AppendLine("' AND VTL_DESC_11.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR04 ");//品目分類名04
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_11.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_12 ON ( VTL_DESC_12.I_CLS_CD = '").Append("S43").AppendLine("' AND VTL_DESC_12.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR05 ");//品目分類名05
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_12.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_13 ON ( VTL_DESC_13.I_CLS_CD = '").Append("S44").AppendLine("' AND VTL_DESC_13.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR06 ");//品目分類名06
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_13.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_14 ON ( VTL_DESC_14.I_CLS_CD = '").Append("S45").AppendLine("' AND VTL_DESC_14.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR07 ");//品目分類名07
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_14.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_15 ON ( VTL_DESC_15.I_CLS_CD = '").Append("S46").AppendLine("' AND VTL_DESC_15.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR08 ");//品目分類名08
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_15.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_16 ON ( VTL_DESC_16.I_CLS_CD = '").Append("S47").AppendLine("' AND VTL_DESC_16.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR09 ");//品目分類名09
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_16.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.Append(" LEFT JOIN T_DESC_MS VTL_DESC_17 ON ( VTL_DESC_17.I_CLS_CD = '").Append("S48").AppendLine("' AND VTL_DESC_17.I_NAME_CD = T_PM_MS_ADD_RTCM.I_HINBNR10 ");//品目分類名10
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
                sql.Append("           AND VTL_DESC_17.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end

                sql.AppendLine(" LEFT JOIN T_UNIT_MS VTL_UNIT_01 ON ( VTL_UNIT_01.I_UNIT_CD = T_PM_MS_ADD_RTCM.I_HDKMTNICD ) ");//払出換算前単位名
                sql.AppendLine(" LEFT JOIN T_UNIT_MS VTL_UNIT_02 ON ( VTL_UNIT_02.I_UNIT_CD = T_PM_MS_ADD_RTCM.I_ZKTIKZTICD1 ) ");//在庫単位換算単位名1
                sql.AppendLine(" LEFT JOIN T_UNIT_MS VTL_UNIT_03 ON ( VTL_UNIT_03.I_UNIT_CD = T_PM_MS_ADD_RTCM.I_ZKTIKZTICD2 ) ");//在庫単位換算単位名2
                sql.AppendLine(" LEFT JOIN T_UNIT_MS VTL_UNIT_04 ON ( VTL_UNIT_04.I_UNIT_CD = T_PM_MS_ADD_RTCM.I_ZKTIKZTICD3 ) ");//在庫単位換算単位名3
                sql.AppendLine(" LEFT JOIN T_UNIT_MS VTL_UNIT_05 ON ( VTL_UNIT_05.I_UNIT_CD = T_PM_MS_ADD_RTCM.I_ZKTIKZTICD4 ) ");//在庫単位換算単位名4
                sql.AppendLine(" LEFT JOIN T_UNIT_MS VTL_UNIT_06 ON ( VTL_UNIT_06.I_UNIT_CD = T_PM_MS_ADD_RTCM.I_ZKTIKZTICD5 ) ");//在庫単位換算単位名5
                sql.AppendLine(" LEFT JOIN T_UNIT_MS T_UNIT_MS_01 ON ( T_UNIT_MS_01.I_UNIT_CD = T_PM_MS.I_STD_UNIT_CD ) ");//基本単位名
                sql.AppendLine(" LEFT JOIN T_UNIT_MS T_UNIT_MS_02 ON ( T_UNIT_MS_02.I_UNIT_CD = T_PM_MS.I_CNV_UNIT_CD ) ");//変換単位名
                sql.AppendLine(" LEFT JOIN T_UNIT_MS T_UNIT_MS_03 ON ( T_UNIT_MS_03.I_UNIT_CD = T_PM_MS.I_NET_WEIGHT_UNIT ) ");//品目重量単位名

                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi mod str
                //sql.AppendLine(" LEFT JOIN T_TRADE_MS VTL_TRADE_01 ON ( VTL_TRADE_01.I_DL_CD = T_PM_MS.I_CTRL_SECTION ) ");//管理部門名
                //sql.AppendLine(" LEFT JOIN T_TRADE_MS VTL_TRADE_02 ON ( VTL_TRADE_02.I_DL_CD = T_PM_MS.I_SHIP_LOCATION ) ");//在庫場所名
                //sql.AppendLine(" LEFT JOIN T_TRADE_MS VTL_TRADE_03 ON ( VTL_TRADE_03.I_DL_CD = T_PM_MS.I_FAC_CD ) ");//工場番号名
                //sql.AppendLine(" LEFT JOIN T_PERSON_MS VTL_PERSON_01 ON ( VTL_PERSON_01.I_PERSON_CD = T_PM_MS.I_SALES_PERSON_CD ) ");//売上担当者名

                sql.AppendLine(" LEFT JOIN T_SECTION_MS VTL_SEC_01 ON ( T_PM_MS.I_CTRL_SECTION = VTL_SEC_01.I_SECTION_CD ");//管理部門名
                sql.Append("           AND VTL_SEC_01.I_COMPANY_CD = ").Append(":companyCd").AppendLine(")");

                sql.AppendLine(" LEFT JOIN T_WH_PRCS_MS VTL_WH_01 ON ( T_PM_MS.I_SHIP_LOCATION = VTL_WH_01.I_WH_PRCS_CD ");//在庫場所名
                sql.AppendLine("       AND T_PM_MS.I_FAC_CD = VTL_WH_01.I_FAC_CD ) ");

                sql.AppendLine(" LEFT JOIN T_FACTORY_MS VTL_FC_CON ON ( T_PM_MS.I_FAC_CD = VTL_FC_CON.I_FAC_CD) ");//工場番号名

                sql.AppendLine(" LEFT JOIN T_PERSON_MS VTL_PERSON_01 ON ( VTL_PERSON_01.I_PERSON_CD = T_PM_MS.I_SALES_PERSON_CD ");//売上担当者名
                sql.Append("          AND VTL_PERSON_01.I_COMPANY_CD = ").Append(":companyCd").AppendLine(")");

                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi mod end

                //-------[3.0.0907.0801] 2009.07.08 Fns)k.ito add str 【V3(保守管理)対応】
                //部品交換期間単位
                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_27 ON ( VTL_CLS_27.I_CLS_CD = '").Append("DA").AppendLine("' AND VTL_CLS_27.I_CLS_DETAIL_CD = T_PM_MS.I_PART_CHG_PERIOD_UNIT_CD ");
                sql.Append("           AND VTL_CLS_27.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //定期保守期間単位
                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_28 ON ( VTL_CLS_28.I_CLS_CD = '").Append("DA").AppendLine("' AND VTL_CLS_28.I_CLS_DETAIL_CD = T_PM_MS.I_FIX_MNT_PERIOD_UNIT_CD ");
                sql.Append("           AND VTL_CLS_28.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //保証期間単位
                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_29 ON ( VTL_CLS_29.I_CLS_CD = '").Append("DA").AppendLine("' AND VTL_CLS_29.I_CLS_DETAIL_CD = T_PM_MS.I_GUAR_PERIOD_UNIT_CD ");
                sql.Append("           AND VTL_CLS_29.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //保守区分
                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_30 ON ( VTL_CLS_30.I_CLS_CD = '").Append("D9").AppendLine("' AND VTL_CLS_30.I_CLS_DETAIL_CD = T_PM_MS.I_MNT_CLS ");
                sql.Append("           AND VTL_CLS_30.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //号機採番要否区分
                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_31 ON ( VTL_CLS_31.I_CLS_CD = '").Append("DB").AppendLine("' AND VTL_CLS_31.I_CLS_DETAIL_CD = T_PM_MS.I_SRL_SEQ_CLS ");
                sql.Append("           AND VTL_CLS_31.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //耐用寿命単位区分
                sql.Append(" LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_32 ON ( VTL_CLS_32.I_CLS_CD = '").Append("DK").AppendLine("' AND VTL_CLS_32.I_CLS_DETAIL_CD = T_PM_MS.I_USEFUL_LIFE_UNIT_CLS ");
                sql.Append("           AND VTL_CLS_32.I_LANGUAGE_CD = ").Append(":langId").AppendLine(")");
                //-------[3.0.0908.0601] 2009.07.08 Fns)k.ito add end 【V3(保守管理)対応】
                //------------------------------------------------------------------------------------------------------------------------------------
                //SelectSqlSupporter sqlSup = new SelectSqlSupporter(sql);
                //sqlSup.SetWhereParameter("00", " T_PM_MS.I_ITEM_ENTRY_CLS = ");//品目登録区分
                //sqlSup.SetWhereParameter(card.C1_FAC_CD, " T_PM_MS.I_FAC_CD = ");//工場番号
                //sqlSup.SetWhereParameter(card.C2_ITEM_TYPE, " T_PM_MS.I_ITEM_TYPE = ");//品目分類
                //sqlSup.SetWhereParameter(card.C2_ITEM_CLS.Trim(), " T_PM_MS.I_ITEM_CLS = ");//品目区分
                //sqlSup.SetWhereParameter(card.C2_DISP_ITEM_CD, " T_PM_MS.I_DISP_ITEM_CD = ");//表示品目番号
                //sqlSup.SetWhereParameter(card.C2_ITEM_DISP_REV, " T_PM_MS.I_DISP_ITEM_REV = ");//表示品目版数
                //sqlSup.SetWhereParameter(card.C2_ITEM_DESC, " T_PM_MS.I_ITEM_DESC = ");//品目名
                //sqlSup.SetWhereParameter(card.C2_MODEL, " T_PM_MS.I_MODEL = ");//型式
                //sqlSup.SetWhereParameter(card.C2_SPEC, " T_PM_MS.I_SPEC = ");//仕様
                //sqlSup.SetWhereParameter(card.C2_DRW_NO, " T_PM_MS.I_MODEL = ");//図番
                //sqlSup.SetWhereParameter(card.C2_SEIBAN, " T_PM_MS.I_SEIBAN = ");//製番
                //sqlSup.SetWhereParameter(card.C2_MAKER_CD, " T_PM_MS.I_MAKER_CD = ");//メーカコード
                //sqlSup.SetWhereParameter(card.C2_QRY_MTRL, " T_PM_MS.I_QRY_MTRL = ");//材質
                //-------[3.0.0907.0801] 2009.07.08 Fns)k.ito add str 【V3(保守管理)対応】
                //sqlSup.SetWhereParameter(card.C2_MNT_CLS.Trim(), " T_PM_MS.I_MNT_CLS = ");//保守区分
                //-------[3.0.0908.0601] 2009.07.08 Fns)k.ito add end 【V3(保守管理)対応】

                sql.AppendLine(condition.BuildParameterConditionSql(true));

                // 工場番号未指定の場合,自社のデータのみを表示する
                if (allFactory)
                {
                    sql.Append("     AND T_PM_MS.I_FAC_CD IN( SELECT I_FAC_CD FROM T_FACTORY_MS WHERE I_COMPANY_CD = ").AppendLine(":companyCd").AppendLine(")");
                }

                //------------------------------------------------------------------------------------------------------------------------------------
                sql.AppendLine(" ORDER BY ");
                sql.AppendLine(" T_PM_MS.I_FAC_CD ASC, ");//工場番号
                sql.AppendLine(" T_PM_MS.I_DISP_ITEM_CD ASC, ");//表示品目番号
                sql.AppendLine(" T_PM_MS.I_DISP_ITEM_REV ASC ");//表示品目版数
                //------------------------------------------------------------------------------------------------------------------------------------


                ISQLQuery query = ss.CreateSQLQuery(sql.ToString());

                query.AddScalar("iFacCd", NHibernateUtil.String);
                query.AddScalar("iItemCd", NHibernateUtil.String);
                query.AddScalar("iDispItemCd", NHibernateUtil.String);
                query.AddScalar("iItemDesc", NHibernateUtil.String);
                query.AddScalar("iItemRev", NHibernateUtil.String);
                query.AddScalar("iDispItemRev", NHibernateUtil.String);
                query.AddScalar("iModel", NHibernateUtil.String);
                query.AddScalar("iDrwNo", NHibernateUtil.String);
                query.AddScalar("iSpec", NHibernateUtil.String);
                query.AddScalar("iSeiban", NHibernateUtil.String);
                query.AddScalar("iItemType", NHibernateUtil.String);
                query.AddScalar("iItemType1", NHibernateUtil.String);

                query.AddScalar("iDlCd", NHibernateUtil.String);

                query.AddScalar("iItemType3", NHibernateUtil.String);
                query.AddScalar("iSalesPersonCd", NHibernateUtil.String);
                query.AddScalar("iCtrlCls", NHibernateUtil.String);
                query.AddScalar("iItemCls", NHibernateUtil.String);
                query.AddScalar("iSoAlcCls", NHibernateUtil.String);
                query.AddScalar("iPsCls", NHibernateUtil.String);
                query.AddScalar("iLotMethod", NHibernateUtil.String);
                query.AddScalar("iFprPeriod", NHibernateUtil.Decimal);
                query.AddScalar("iLotQty", NHibernateUtil.Decimal);
                query.AddScalar("iLotCtrlCls", NHibernateUtil.String);
                query.AddScalar("iStockCls", NHibernateUtil.String);
                query.AddScalar("iDelSchCls", NHibernateUtil.String);
                query.AddScalar("iOsAlcCls", NHibernateUtil.String);
                query.AddScalar("iPlanDvdCls", NHibernateUtil.String);
                query.AddScalar("iMinLotQty", NHibernateUtil.Decimal);
                query.AddScalar("iSafeStockQty", NHibernateUtil.Decimal);
                query.AddScalar("iUseDelCls", NHibernateUtil.String);
                query.AddScalar("iStdUnitCd", NHibernateUtil.String);
                query.AddScalar("iStartSeq", NHibernateUtil.Decimal);
                query.AddScalar("iEndSeq", NHibernateUtil.Decimal);
                query.AddScalar("iCnvUnitCd", NHibernateUtil.String);
                query.AddScalar("iCnvRateBunsi", NHibernateUtil.Decimal);
                query.AddScalar("iCnvRateBunbo", NHibernateUtil.Decimal);
                query.AddScalar("iInvSoDate", NHibernateUtil.Decimal);
                query.AddScalar("iShipLocation", NHibernateUtil.String);
                query.AddScalar("iNetWeight", NHibernateUtil.Decimal);
                query.AddScalar("iNetWeightUnit", NHibernateUtil.String);
                query.AddScalar("iGrossWeight", NHibernateUtil.Decimal);
                query.AddScalar("iGrossWeightUnit", NHibernateUtil.String);
                query.AddScalar("iM3", NHibernateUtil.Decimal);
                query.AddScalar("iLowLevel", NHibernateUtil.Decimal);
                query.AddScalar("iSumLt", NHibernateUtil.Decimal);
                query.AddScalar("iPlanQty", NHibernateUtil.Decimal);
                query.AddScalar("iMakerCd", NHibernateUtil.String);
                query.AddScalar("iQryMtrl", NHibernateUtil.String);
                query.AddScalar("iSize1", NHibernateUtil.Decimal);
                query.AddScalar("iSize2", NHibernateUtil.Decimal);
                query.AddScalar("iSize3", NHibernateUtil.Decimal);
                query.AddScalar("iGravity", NHibernateUtil.Decimal);
                query.AddScalar("iProdFacCd", NHibernateUtil.String);
                query.AddScalar("iFgInCls", NHibernateUtil.String);
                query.AddScalar("iProcSumLt", NHibernateUtil.Decimal);
                query.AddScalar("iHcdflg", NHibernateUtil.String);
                query.AddScalar("iSpflg", NHibernateUtil.String);
                query.AddScalar("iSpexc", NHibernateUtil.String);
                query.AddScalar("iPmrkey", NHibernateUtil.String);
                query.AddScalar("iPmrver", NHibernateUtil.Decimal);
                query.AddScalar("iSpname", NHibernateUtil.String);
                query.AddScalar("iSpdate", NHibernateUtil.DateTime);
                query.AddScalar("iStatus", NHibernateUtil.String);
                query.AddScalar("iSephin", NHibernateUtil.String);
                query.AddScalar("iRyuhin", NHibernateUtil.String);
                query.AddScalar("iSakusei", NHibernateUtil.String);
                query.AddScalar("iCtrlSection", NHibernateUtil.String);
                query.AddScalar("iSalesSection", NHibernateUtil.String);
                query.AddScalar("iPurchaseSection", NHibernateUtil.String);
                query.AddScalar("iItemEntryCls", NHibernateUtil.String);
                query.AddScalar("iSmtCls", NHibernateUtil.String);
                query.AddScalar("iRohsCls", NHibernateUtil.String);
                query.AddScalar("iReachCls", NHibernateUtil.String);
                query.AddScalar("iChinaRohsCls", NHibernateUtil.String);
                query.AddScalar("iBinEndDate", NHibernateUtil.Decimal);
                query.AddScalar("iMntCls", NHibernateUtil.String);
                query.AddScalar("iSrlSeqCls", NHibernateUtil.String);
                query.AddScalar("iPartChgPeriod", NHibernateUtil.Decimal);
                query.AddScalar("iPartChgPeriodUnitCd", NHibernateUtil.String);
                query.AddScalar("iFixMntPeriod", NHibernateUtil.Decimal);
                query.AddScalar("iFixMntPeriodUnitCd", NHibernateUtil.String);
                query.AddScalar("iGuarPeriod", NHibernateUtil.Decimal);
                query.AddScalar("iGuarPeriodUnitCd", NHibernateUtil.String);
                query.AddScalar("iUsefulLife", NHibernateUtil.Decimal);
                query.AddScalar("iUsefulLifeUnitCls", NHibernateUtil.String);
                query.AddScalar("iCapItemType", NHibernateUtil.String);
                query.AddScalar("iInqItem", NHibernateUtil.String);
                query.AddScalar("iObjectId", NHibernateUtil.Decimal);
                query.AddScalar("iEntryDate", NHibernateUtil.DateTime);
                query.AddScalar("iUpdDate", NHibernateUtil.DateTime);
                query.AddScalar("iUpdTimestamp", NHibernateUtil.String);


                query.AddScalar("iHinsyosai1", NHibernateUtil.String);
                query.AddScalar("iHinsyosai2", NHibernateUtil.String);
                query.AddScalar("iHinsyosai3", NHibernateUtil.String);
                query.AddScalar("iHinsyosai4", NHibernateUtil.String);
                query.AddScalar("iHinsyosai5", NHibernateUtil.String);
                query.AddScalar("iHkhinno1", NHibernateUtil.String);
                query.AddScalar("iHkhinno2", NHibernateUtil.String);
                query.AddScalar("iHkhinno3", NHibernateUtil.String);
                query.AddScalar("iHinzks1", NHibernateUtil.String);
                query.AddScalar("iHinzks2", NHibernateUtil.String);
                query.AddScalar("iHinzks3", NHibernateUtil.String);
                query.AddScalar("iZryobnr", NHibernateUtil.String);
                query.AddScalar("iCsthskkbn", NHibernateUtil.String);
                query.AddScalar("iCstkskbn", NHibernateUtil.String);
                query.AddScalar("iKgsankbn", NHibernateUtil.String);
                query.AddScalar("iSkrkejkbn", NHibernateUtil.String);
                query.AddScalar("iTmhskkbn", NHibernateUtil.String);
                query.AddScalar("iTmzryobnr", NHibernateUtil.String);
                query.AddScalar("iTmcstmkno", NHibernateUtil.Decimal);
                query.AddScalar("iSzcrtkbn", NHibernateUtil.String);
                query.AddScalar("iHdtkzchBnshi", NHibernateUtil.Decimal);
                query.AddScalar("iHdtkzchBnbo", NHibernateUtil.Decimal);
                query.AddScalar("iHdkmtnicd", NHibernateUtil.String);
                query.AddScalar("iLotSesanryo", NHibernateUtil.Decimal);
                query.AddScalar("iDaySesanryo", NHibernateUtil.Decimal);
                query.AddScalar("iYieldRate", NHibernateUtil.Decimal);
                query.AddScalar("iFukukbn", NHibernateUtil.String);
                query.AddScalar("iSgenkbn", NHibernateUtil.String);
                query.AddScalar("iTenfuykbn", NHibernateUtil.String);
                query.AddScalar("iDaikoteptn", NHibernateUtil.String);
                query.AddScalar("iDhhigptn", NHibernateUtil.String);
                query.AddScalar("iZktkzchBnshi1", NHibernateUtil.Decimal);
                query.AddScalar("iZktkzchBnbo1", NHibernateUtil.Decimal);
                query.AddScalar("iZktikzticd1", NHibernateUtil.String);
                query.AddScalar("iZktkzchBnshi2", NHibernateUtil.Decimal);
                query.AddScalar("iZktkzchBnbo2", NHibernateUtil.Decimal);
                query.AddScalar("iZktikzticd2", NHibernateUtil.String);
                query.AddScalar("iZktkzchBnshi3", NHibernateUtil.Decimal);
                query.AddScalar("iZktkzchBnbo3", NHibernateUtil.Decimal);
                query.AddScalar("iZktikzticd3", NHibernateUtil.String);
                query.AddScalar("iZktkzchBnshi4", NHibernateUtil.Decimal);
                query.AddScalar("iZktkzchBnbo4", NHibernateUtil.Decimal);
                query.AddScalar("iZktikzticd4", NHibernateUtil.String);
                query.AddScalar("iZktkzchBnshi5", NHibernateUtil.Decimal);
                query.AddScalar("iZktkzchBnbo5", NHibernateUtil.Decimal);
                query.AddScalar("iZktikzticd5", NHibernateUtil.String);
                query.AddScalar("iHinksu01", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu02", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu03", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu04", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu05", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu06", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu07", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu08", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu09", NHibernateUtil.Decimal);
                query.AddScalar("iHinksu10", NHibernateUtil.Decimal);
                query.AddScalar("iHinbnr01", NHibernateUtil.String);
                query.AddScalar("iHinbnr02", NHibernateUtil.String);
                query.AddScalar("iHinbnr03", NHibernateUtil.String);
                query.AddScalar("iHinbnr04", NHibernateUtil.String);
                query.AddScalar("iHinbnr05", NHibernateUtil.String);
                query.AddScalar("iHinbnr06", NHibernateUtil.String);
                query.AddScalar("iHinbnr07", NHibernateUtil.String);
                query.AddScalar("iHinbnr08", NHibernateUtil.String);
                query.AddScalar("iHinbnr09", NHibernateUtil.String);
                query.AddScalar("iHinbnr10", NHibernateUtil.String);
                query.AddScalar("iJohhtkbn", NHibernateUtil.String);
                query.AddScalar("iHftkbn1", NHibernateUtil.String);
                query.AddScalar("iHftkbn2", NHibernateUtil.String);
                query.AddScalar("iHftkbn3", NHibernateUtil.String);
                query.AddScalar("iHftkbn4", NHibernateUtil.String);
                query.AddScalar("iHftkbn5", NHibernateUtil.String);
                query.AddScalar("iSytsukakbn", NHibernateUtil.String);
                query.AddScalar("iTngmhfkbn", NHibernateUtil.String);
                query.AddScalar("iTnhkshfkbn", NHibernateUtil.String);



                query.AddScalar("vItemclsdesc", NHibernateUtil.String);
                query.AddScalar("vCtrlclsdesc", NHibernateUtil.String);
                query.AddScalar("vLotctrlclsdesc", NHibernateUtil.String);
                query.AddScalar("vUsedelclsdesc", NHibernateUtil.String);
                query.AddScalar("vSoalcclsdesc", NHibernateUtil.String);
                query.AddScalar("vPsclsdesc", NHibernateUtil.String);
                query.AddScalar("vSmtclsdesc", NHibernateUtil.String);
                query.AddScalar("vRohsclsdesc", NHibernateUtil.String);
                query.AddScalar("vReachclsdesc", NHibernateUtil.String);
                query.AddScalar("vChinarohsclsdesc", NHibernateUtil.String);
                query.AddScalar("vOsalcclsdesc", NHibernateUtil.String);
                query.AddScalar("vCsthskkbndesc", NHibernateUtil.String);
                query.AddScalar("vCstkskbndesc", NHibernateUtil.String);
                query.AddScalar("vKgsankbndesc", NHibernateUtil.String);
                query.AddScalar("vSkrkejkbndesc", NHibernateUtil.String);
                query.AddScalar("vTmhskkbndesc", NHibernateUtil.String);
                query.AddScalar("vSzcrtkbndesc", NHibernateUtil.String);
                query.AddScalar("vFukukbndesc", NHibernateUtil.String);
                query.AddScalar("vSgenkbndesc", NHibernateUtil.String);
                query.AddScalar("vTenfuykbndesc", NHibernateUtil.String);
                query.AddScalar("vJohhtkbndesc", NHibernateUtil.String);
                query.AddScalar("vHftkbndesc1", NHibernateUtil.String);
                query.AddScalar("vHftkbndesc2", NHibernateUtil.String);
                query.AddScalar("vHftkbndesc3", NHibernateUtil.String);
                query.AddScalar("vHftkbndesc4", NHibernateUtil.String);
                query.AddScalar("vHftkbndesc5", NHibernateUtil.String);
                query.AddScalar("vItemtypedesc", NHibernateUtil.String);
                query.AddScalar("vItemtype1desc", NHibernateUtil.String);

                query.AddScalar("vDlDesc", NHibernateUtil.String);

                query.AddScalar("vItemtype3desc", NHibernateUtil.String);
                query.AddScalar("vMakerdesc", NHibernateUtil.String);
                query.AddScalar("vZryobnrdesc", NHibernateUtil.String);
                query.AddScalar("vTmzryobnrdesc", NHibernateUtil.String);
                query.AddScalar("vHinbnr01desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr02desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr03desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr04desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr05desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr06desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr07desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr08desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr09desc", NHibernateUtil.String);
                query.AddScalar("vHinbnr10desc", NHibernateUtil.String);
                query.AddScalar("vHdkmtnicddesc", NHibernateUtil.String);
                query.AddScalar("vZktikzticd1desc", NHibernateUtil.String);
                query.AddScalar("vZktikzticd2desc", NHibernateUtil.String);
                query.AddScalar("vZktikzticd3desc", NHibernateUtil.String);
                query.AddScalar("vZktikzticd4desc", NHibernateUtil.String);
                query.AddScalar("vZktikzticd5desc", NHibernateUtil.String);
                query.AddScalar("vCtrlsectiondesc", NHibernateUtil.String);
                query.AddScalar("vStocklocationdesc", NHibernateUtil.String);
                query.AddScalar("vFacdesc", NHibernateUtil.String);
                query.AddScalar("vPersondesc", NHibernateUtil.String);
                query.AddScalar("iStdunitdesc", NHibernateUtil.String);
                query.AddScalar("iCnvunitdesc", NHibernateUtil.String);
                query.AddScalar("iNetweightunitdesc", NHibernateUtil.String);
                query.AddScalar("iPartchgperiodunitdesc", NHibernateUtil.String);
                query.AddScalar("iFixmntperiodunitdesc", NHibernateUtil.String);
                query.AddScalar("iGuarperiodunitdesc", NHibernateUtil.String);
                query.AddScalar("iMntclsdesc", NHibernateUtil.String);
                query.AddScalar("iSrlseqclsdesc", NHibernateUtil.String);
                query.AddScalar("iUsefullifeunitclsdesc", NHibernateUtil.String);


                foreach (DictionaryEntry de in condition.ConditionTable)
                {
                    SearchInfo searchInfo = (SearchInfo)de.Value;
                    query.SetParameter(string.Format("{0}", searchInfo.FieldName), searchInfo.FieldValue);
                }



                result = query.SetResultTransformer(Transformers.AliasToBean<CTPmMsNoAR>()).List<CTPmMsNoAR>();


                tran.Commit();
            }
            catch (Castle.ActiveRecord.Framework.ActiveRecordException ex)
            {
                tran.Rollback();
                throw new ApplicationException(ex.Message, ex);
            }
            catch (DbException ex)
            {
                tran.Rollback();
                throw new ApplicationException(ex.Message, ex);
            }
            finally
            {
                tran.Dispose();
            }

            return result;

        }
    }
}
