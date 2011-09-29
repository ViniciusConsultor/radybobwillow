using System;
using System.Collections.Generic;
using System.Text;

namespace Com.GainWinSoft.Common
{
    public static class Constant
    {
        public const string MODE_ADD = "ADD";
        public const string MODE_UPD = "UPD";
        public const string MODE_DEL = "DEL";
        public const string MODE_REF = "REF";

        public const string I_PRCS_CLS_C = "01";
        public const string I_PRCS_CLS_U = "02";
        public const string I_PRCS_CLS_D = "03";

        // 摘要:
        //     廃却区分 4E
        public const string ABAND = "4E";
        //
        // 摘要:
        //     内訳区分 BX
        public const string ACCOUNT = "BX";
        //
        // 摘要:
        //     受入検査区分 32
        public const string ACPINS = "32";
        //
        // 摘要:
        //     受入伝票区分 04
        public const string ACPSLP = "04";
        //
        // 摘要:
        //     受入検収区分 48
        public const string ACPVOU = "48";
        //
        // 摘要:
        //     勘定科目 69
        public const string ACT = "69";
        //
        // 摘要:
        //     実績原価集計区分 BU
        public const string ACTCOSTCUM = "BU";
        //
        // 摘要:
        //     対処分類区分 DE
        public const string ACTIONTYPECLS = "DE";
        //
        // 摘要:
        //     調整理由 76
        public const string ADJREASON = "76";
        //
        // 摘要:
        //     引当区分 BP
        public const string ALLOC = "BP";
        //
        // 摘要:
        //     代替適用有無区分 DJ
        public const string ALTAPPLYCLS = "DJ";
        //
        // 摘要:
        //     金額端数処理区分 20
        public const string AMTFRC = "20";
        //
        // 摘要:
        //     債権債務区分 AB
        public const string APAR = "AB";
        //
        // 摘要:
        //     資産科目 70
        public const string ASSET = "70";
        //
        // 摘要:
        //     部品表種別 57
        public const string BOMTYPE = "57";
        //
        // 摘要:
        //     コアコアアクティビティ識別区分 R04
        public const string CACTSKBKBN = "R04";
        //
        // 摘要:
        //     原因分類区分 DD
        public const string CAUSETYPECLS = "DD";
        //
        // 摘要:
        //     中国ＲｏＨＳ区分 AR
        public const string CHINAROHS = "AR";
        //
        // 摘要:
        //     有償無償区分 4J
        public const string CHRGOR = "4J";
        //
        // 摘要:
        //     有償支給区分 17
        public const string CHRGSPLY = "17";
        //
        // 摘要:
        //     有償区分 DI
        public const string CONTRACTCLS = "DI";
        //
        // 摘要:
        //     連携ステータス BL
        public const string COOPSTAT = "BL";
        //
        // 摘要:
        //     連携連携種別 BM
        public const string COOPTYPE = "BM";
        //
        // 摘要:
        //     費目区分 CT
        public const string COST = "CT";
        //
        // 摘要:
        //     作成処理区分 4N
        public const string CRT = "4N";
        //
        // 摘要:
        //     原価情報区分 51
        public const string CSTINF = "51";
        //
        // 摘要:
        //     管理区分 33
        public const string CTRL = "33";
        //
        // 摘要:
        //     現在庫区分 4M
        public const string CURSOTCK = "4M";
        //
        // 摘要:
        //     データ種別区分 AK
        public const string DATA = "AK";
        //
        // 摘要:
        //     データID D4
        public const string DATAID = "D4";
        //
        // 摘要:
        //     日付型 4A
        public const string DATE = "4A";
        //
        // 摘要:
        //     日付書式区分 BI
        public const string DATEFORMAT = "BI";
        //
        // 摘要:
        //     赤黒区分 AA
        public const string DEBCRE = "AA";
        //
        // 摘要:
        //     納入区分 4P
        public const string DEL = "4P";
        //
        // 摘要:
        //     納入日程作成 9M
        public const string DELSCH = "9M";
        //
        // 摘要:
        //     納品書発行区分 5G
        public const string DELSLP = "5G";
        //
        // 摘要:
        //     部品展開区分 41
        public const string DEVELOP = "41";
        //
        // 摘要:
        //     装置種別 AC
        public const string DEVICE = "AC";
        //
        // 摘要:
        //     取引先分類 24
        public const string DLTYPE = "24";
        //
        // 摘要:
        //     出荷伝票発行区分 23
        public const string DOSHIPSPLY = "23";
        //
        // 摘要:
        //     ドライバ区分 BW
        public const string DRIVER = "BW";
        //
        // 摘要:
        //     有効期限区分 BB
        public const string EFFENDDATE = "BB";
        //
        // 摘要:
        //     日付設変区分 4C
        public const string EGCHG = "4C";
        //
        // 摘要:
        //     日付設計変更区分 9F
        public const string EGCHGD = "9F";
        //
        // 摘要:
        //     エンティティID D1
        public const string ENTITYID = "D1";
        //
        // 摘要:
        //     見積区分 BA
        public const string EST = "BA";
        //
        // 摘要:
        //     評価区分 CA
        public const string EVALU = "CA";
        //
        // 摘要:
        //     工場払出単価基準 A5
        public const string FCUP = "A5";
        //
        // 摘要:
        //     倉入区分 9P
        public const string FGIN = "9P";
        //
        // 摘要:
        //     確定区分 9Q
        public const string FIX = "9Q";
        //
        // 摘要:
        //     フォーマットID D5
        public const string FORMATID = "D5";
        //
        // 摘要:
        //     フォームID D2
        public const string FORMID = "D2";
        //
        // 摘要:
        //     端数処理区分 16
        public const string FRC = "16";
        //
        // 摘要:
        //     配賦識別区分 R60
        public const string HFSKKBN = "R60";
        //
        // 摘要:
        //     IMEモードID D6
        public const string IMEID = "D6";
        //
        // 摘要:
        //     指示内容 63
        public const string INDCONT = "63";
        //
        // 摘要:
        //     独立需要区分 BE
        public const string INDDEM = "BE";
        //
        // 摘要:
        //     情報区分 92
        public const string INF = "92";
        //
        // 摘要:
        //     入出庫区分 43
        public const string INOUT = "43";
        //
        // 摘要:
        //     検査パターン 73
        public const string INSPTN = "73";
        //
        // 摘要:
        //     検査伝票区分 BO
        public const string INSSLIP = "BO";
        //
        // 摘要:
        //     品目区分 31
        public const string ITEM = "31";
        //
        // 摘要:
        //     品目発生元区分 AJ
        public const string ITEM_ORIGIN = "AJ";
        //
        // 摘要:
        //     品目登録区分 AU
        public const string ITEMENTRY = "AU";
        //
        // 摘要:
        //     品番使用許可フラグ ";
        public const string ITEMHCD = "5D";
        //
        // 摘要:
        //     品目分類 65
        public const string ITEMKIND = "65";
        //
        // 摘要:
        //     品目分類１ 79
        public const string ITEMTYPE1 = "79";
        //
        // 摘要:
        //     品目分類２ 80
        public const string ITEMTYPE2 = "80";
        //
        // 摘要:
        //     品目分類３ 81
        public const string ITEMTYPE3 = "81";
        //
        // 摘要:
        //     品目分類４ 82
        public const string ITEMTYPE4 = "82";
        //
        // 摘要:
        //     品目分類５ 83
        public const string ITEMTYPE5 = "83";
        //
        // 摘要:
        //     品目分類６ 84
        public const string ITEMTYPE6 = "84";
        //
        // 摘要:
        //     判定区分 CC
        public const string JUDGE = "CC";
        //
        // 摘要:
        //     国内海外区分 R28
        public const string KOKNGKBN = "R28";
        //
        // 摘要:
        //     ロット管理区分 58
        public const string LOTCTRL = "58";
        //
        // 摘要:
        //     主エンティティ DL
        public const string MAINENTITY = "DL";
        //
        // 摘要:
        //     主要支援区分 R05
        public const string MAINSUBKBN = "R05";
        //
        // 摘要:
        //     メーカコード 72
        public const string MAKER = "72";
        //
        // 摘要:
        //     保守区分 D9
        public const string MNTCLS = "D9";
        //
        // 摘要:
        //     金型実績計上区分 4H
        public const string MOLDRSLT = "4H";
        //
        // 摘要:
        //     金型使用区分 96
        public const string MOLDUSE = "96";
        //
        // 摘要:
        //     複数工場区分 4B
        public const string MULTIFAC = "4B";
        //
        // 摘要:
        //     複数品目区分 4F
        public const string MULTIITEM = "4F";
        //
        // 摘要:
        //     名称ID D3
        public const string NAMEID = "D3";
        //
        // 摘要:
        //     新規設計 AD
        public const string NEWSP = "AD";
        //
        // 摘要:
        //     数値書式区分 BJ
        public const string NUMFORMAT = "BJ";
        //
        // 摘要:
        //     作業区分 BK
        public const string OPERATE = "BK";
        //
        // 摘要:
        //     個別手配区分 AT
        public const string ORDERPO = "AT";
        //
        // 摘要:
        //     その他費用区分 BO
        public const string OTHERCOST = "BO";
        //
        // 摘要:
        //     資産元区分 9C
        public const string OWNFLM = "9C";
        //
        // 摘要:
        //     支払方法区分 BD
        public const string PAYMETHOD = "BD";
        //
        // 摘要:
        //     期間単位 DA
        public const string PERIODUNITCD = "DA";
        //
        // 摘要:
        //     要員区分 BV
        public const string PERSONEL = "BV";
        //
        // 摘要:
        //     生産計画完納区分 47
        public const string PLANCOMP = "47";
        //
        // 摘要:
        //     生産計画作成区分 BS
        public const string PLANCREATE = "BS";
        //
        // 摘要:
        //     計画分割区分 9U
        public const string PLANDVD = "9U";
        //
        // 摘要:
        //     生産計画区分 03
        public const string PLANSLP = "03";
        //
        // 摘要:
        //     手配区分 36
        public const string PO = "36";
        //
        // 摘要:
        //     手配完納区分 11
        public const string POCOMP = "11";
        //
        // 摘要:
        //     手配確定方法 9I
        public const string POFIX = "9I";
        //
        // 摘要:
        //     注文書発行区分 55
        public const string POISSUE = "55";
        //
        // 摘要:
        //     注文書選択区分 9K
        public const string POSLC = "9K";
        //
        // 摘要:
        //     手配状態区分 AL
        public const string POSTATE = "AL";
        //
        // 摘要:
        //     手配警告区分 BF
        public const string POWARNING = "BF";
        //
        // 摘要:
        //     処理区分 44
        public const string PRCS = "44";
        //
        // 摘要:
        //     作業手順設定区分 38
        public const string PRCSSET = "38";
        //
        // 摘要:
        //     作業内容 64
        public const string PRODCONT = "64";
        //
        // 摘要:
        //     着手可否区分 AN
        public const string PRODONSET = "AN";
        //
        // 摘要:
        //     作業状況区分 AM
        public const string PRODSTATE = "AM";
        //
        // 摘要:
        //     プロジェクト状態区分 BY
        public const string PROJSTAT = "BY";
        //
        // 摘要:
        //     構成区分 56
        public const string PS = "56";
        //
        // 摘要:
        //     レート区分
        public const string RATE = "9A";
        //
        // 摘要:
        //     ＲＥＡＣＨ区分 AG
        public const string REACH = "AG";
        //
        // 摘要:
        //     関連区分 DG
        public const string RELATIONCLS = "DG";
        //
        // 摘要:
        //     関連エンティティ DM
        public const string RELATIONENTITY = "DM";
        //
        // 摘要:
        //     紐付データ種別 BN
        public const string RELATTYPE = "BN";
        //
        // 摘要:
        //     所要量完納区分 12
        public const string REQCOMP = "12";
        //
        // 摘要:
        //     不良区分 29
        public const string RJT = "29";
        //
        // 摘要:
        //     不良理由 66
        public const string RJTREASON = "66";
        //
        // 摘要:
        //     ＲｏＨＳ区分 AF
        public const string ROHS = "AF";
        //
        // 摘要:
        //     安全在庫確保方式 4D
        public const string SAFESTOCK = "4D";
        //
        // 摘要:
        //     売上伝票区分 07
        public const string SALESLP = "07";
        //
        // 摘要:
        //     売上検収区分 9J
        public const string SALVOU = "9J";
        //
        // 摘要:
        //     セキュリティ設定状況 4Q
        public const string SECURE = "4Q";
        //
        // 摘要:
        //     製番在庫引当区分 4G
        public const string SEIBANALC = "4G";
        //
        // 摘要:
        //     製番展開対象区分 AO
        public const string SEIBANEXPAND = "AO";
        //
        // 摘要:
        //     製番手配区分 AQ
        public const string SEIBANPO = "AQ";
        //
        // 摘要:
        //     製番種別区分 AP
        public const string SEIBANTYPE = "AP";
        //
        // 摘要:
        //     製番種別１ AW
        public const string SEIBANTYPE1 = "AW";
        //
        // 摘要:
        //     製番種別２ AX
        public const string SEIBANTYPE2 = "AX";
        //
        // 摘要:
        //     製番種別３ AY
        public const string SEIBANTYPE3 = "AY";
        //
        // 摘要:
        //     社内外区分 R29
        public const string SHANGKBN = "R29";
        //
        // 摘要:
        //     出荷方法区分 4K
        public const string SHIPMETH = "4K";
        //
        // 摘要:
        //     出荷伝票区分 02
        public const string SHIPSLP = "02";
        //
        // 摘要:
        //     出荷種別 4L
        public const string SHIPTYPE = "4L";
        //
        // 摘要:
        //     ＳＭＴ区分 AE
        public const string SMT = "AE";
        //
        // 摘要:
        //     受注在庫引当区分 35
        public const string SOALC = "35";
        //
        // 摘要:
        //     受注完納区分 10
        public const string SOCOMP = "10";
        //
        // 摘要:
        //     ソフトウェア種別 DF
        public const string SOFTCLS = "DF";
        //
        // 摘要:
        //     倉庫分類 R33
        public const string SOKOBNR = "R33";
        //
        // 摘要:
        //     受注ランク区分 BC
        public const string SORANK = "BC";
        //
        // 摘要:
        //     受注伝票区分 01
        public const string SOSLP = "01";
        //
        // 摘要:
        //     受注種別 A8
        public const string SOTYPE = "A8";
        //
        // 摘要:
        //     支給出庫区分 37
        public const string SPLY = "37";
        //
        // 摘要:
        //     有償支給計上区分 AS
        public const string SPLYAPP = "AS";
        //
        // 摘要:
        //     支給実績作成元区分 AV
        public const string SPLYRSRLCRT = "AV";
        //
        // 摘要:
        //     支給伝票区分 05
        public const string SPLYSLP = "05";
        //
        // 摘要:
        //     設計変更フラグ 5E
        public const string SPMOD = "5E";
        //
        // 摘要:
        //     号機社内外区分 DC
        public const string SRLCOMCLS = "DC";
        //
        // 摘要:
        //     号機採番要否区分 DB
        public const string SRLSEQCLS = "DB";
        //
        // 摘要:
        //     号機状態区分 DH
        public const string SRLSTATUSCLS = "DH";
        //
        // 摘要:
        //     在庫区分 9N
        public const string STOCK = "9N";
        //
        // 摘要:
        //     在庫調整区分 42
        public const string STOCKADJ = "42";
        //
        // 摘要:
        //     在庫判別区分 9H
        public const string STOCKTYPE = "9H";
        //
        // 摘要:
        //     下請法対象区分 BT
        public const string SUBCON = "BT";
        //
        // 摘要:
        //     システム使用区分１ B1
        public const string SYSUSE1 = "B1";
        //
        // 摘要:
        //     システム使用区分２ B2
        public const string SYSUSE2 = "B2";
        //
        // 摘要:
        //     システム使用区分３ B3
        public const string SYSUSE3 = "B3";
        //
        // 摘要:
        //     タブID D7
        public const string TABID = "D7";
        //
        // 摘要:
        //     タスク状態区分 BZ
        public const string TASKSTAT = "BZ";
        //
        // 摘要:
        //     消費税区分 15
        public const string TAX = "15";
        //
        // 摘要:
        //     課税業者区分 18
        public const string TAXCHRG = "18";
        //
        // 摘要:
        //     消費税端数処理区分 22
        public const string TAXFRC = "22";
        //
        // 摘要:
        //     消費税計算単位区分 21
        public const string TAXREF = "21";
        //
        // 摘要:
        //     積上方式区分 T29
        public const string TMHSKKBN = "T29";
        //
        // 摘要:
        //     仮単価区分 40
        public const string TMPUP = "40";
        //
        // 摘要:
        //     直制区分 R44
        public const string TYOKU = "R44";
        //
        // 摘要:
        //     単価区分 38
        public const string UP = "39";
        //
        // 摘要:
        //     更新区分ID D8
        public const string UPDID = "D8";
        //
        // 摘要:
        //     単価計上区分 19
        public const string UPREF = "19";
        //
        // 摘要:
        //     出来高出庫区分 59
        public const string USEDEL = "59";
        //
        // 摘要:
        //     耐用寿命単位区分 DK
        public const string USEFULIFECLS = "DK";
        //
        // 摘要:
        //     ユーザ使用区分１ B4
        public const string USER1 = "B4";
        //
        // 摘要:
        //     ユーザ使用区分２ B5
        public const string USER2 = "B5";
        //
        // 摘要:
        //     ユーザ使用区分３ B6
        public const string USER3 = "B6";
        //
        // 摘要:
        //     検収実績作成元区分 AZ
        public const string VOURSRLCRT = "AZ";
        //
        // 摘要:
        //     倉庫区分 BR
        public const string WH = "BR";
        //
        // 摘要:
        //     倉庫工程区分 BQ
        public const string WHPRCS = "BQ";
        //
        // 摘要:
        //     倉庫工程作成区分 CB
        public const string WHPRCSCREATE = "CB";
        //
        // 摘要:
        //     稼動区分 30
        public const string WORK = "30";


        #region 採番種別
        /// <summary>
        /// 採番種別を表します。
        /// </summary>
        [Serializable]
        public enum NumberingTypes
        {
            #region 1～100
            /// <summary>
            ///製造番号
            ///</summary>
            SEIBAN = 1,

            #region 削除
            ///// <summary>
            /////受注番号
            /////</summary>
            //JUCHU = 2,
            #endregion

            /// <summary>
            ///出荷番号
            ///</summary>
            SYUKKA = 3,

            /// <summary>
            ///手配番号
            ///</summary>
            TEHAI = 4,

            /// <summary>
            ///受入番号
            ///</summary>
            UKEIRE = 5,

            /// <summary>
            ///支給実績番号
            ///</summary>
            SIKYU = 6,

            /// <summary>
            ///内示受注番号
            ///</summary>
            NAIJI = 7,

            /// <summary>
            ///製番手配番号
            ///</summary>
            SEIPO = 8,

            #region 削除10
            ///// <summary>
            /////出荷伝票番号
            /////</summary>
            //ETC001 = 10,
            #endregion

            /// <summary>
            ///不良実績番号
            ///</summary>
            ETC002 = 11,

            #region 削除14,15
            ///// <summary>
            /////支給伝票番号
            /////</summary>
            //ETC005 = 14,

            ///// <summary>
            /////納品書番号
            /////</summary>
            //ETC006 = 15,
            #endregion

            /// <summary>
            ///所要量番号
            ///</summary>
            REQTR = 30,

            /// <summary>
            ///在庫調整実績番号
            ///</summary>
            ADJSTK = 55,

            #region 削除60,61,62
            ///// <summary>
            /////取消注文書伝票番号
            /////</summary>
            //CANSLP = 60,

            ///// <summary>
            /////返品伝票番号
            /////</summary>
            //RTNSLP = 61,

            ///// <summary>
            /////注文書伝票番号
            /////</summary>
            //CHUMON = 62,
            #endregion

            /// <summary>
            ///作業指図書伝票番号
            ///</summary>
            SASIZU = 63,

            /// <summary>
            ///金型入出庫実績番号
            ///</summary>
            MOLDIO = 80,

            /// <summary>
            ///金型使用実績番号
            ///</summary>
            MOLDSHOT = 81,

            /// <summary>
            ///仕入検収番号
            ///</summary>
            VOU = 82,

            /// <summary>
            ///売上検収番号
            ///</summary>
            SVOU = 83,

            /// <summary>
            /// 製番振替番号
            /// </summary>
            STRN = 84,

            /// <summary>
            /// 見込製番
            /// </summary>
            FSBAN = 85,

            /// <summary>
            /// 見込所要量番号
            /// </summary>
            FREQTR = 86,

            /// <summary>
            /// 積送受入番号
            /// </summary>
            DELACP = 87,

            /// <summary>
            /// 号機番号
            /// </summary>
            SRL = 88,

            //-------[3.0.0907.1701] 2009.07.17 FNS)takizawa add str
            /// <summary>
            /// 保守内容番号
            /// </summary>
            MNTCON = 91,
            //-------[3.0.0907.1701] 2009.07.17 FNS)takizawa add end

            #endregion

            #region 101～200
            #region 削除101
            ///// <summary>
            /////日付情報更新ジャーナル
            /////</summary>
            //JNL101 = 101,
            #endregion

            #region 削除102,103
            ///// <summary>
            /////区分明細更新ジャーナル
            /////</summary>
            //JNL102 = 102,

            ///// <summary>
            /////名称情報更新ジャーナル
            /////</summary>
            //JNL103 = 103,
            #endregion

            /// <summary>
            ///採番条件更新ジャーナル
            ///</summary>
            JNL104 = 104,

            /// <summary>
            ///自社稼働日更新ジャーナル
            ///</summary>
            JNL105 = 105,

            /// <summary>
            ///カレンダー工場日更新ジャーナル
            ///</summary>
            JNL106 = 106,

            #region 削除107,108,109
            ///// <summary>
            /////自社条件更新ジャーナル
            /////</summary>
            //JNL107 = 107,

            ///// <summary>
            /////取引先更新ｼﾞｬｰﾅﾙ
            /////</summary>
            //JNL108 = 108,

            ///// <summary>
            /////税率情報更新ジャーナル
            /////</summary>
            //JNL109 = 109,
            #endregion

            /// <summary>
            ///品目更新ｼﾞｬｰﾅﾙ
            ///</summary>
            JNL110 = 110,

            /// <summary>
            ///指示工程更新ｼﾞｬｰﾅﾙ
            ///</summary>
            JNL111 = 111,

            /// <summary>
            ///作業手順更新ｼﾞｬｰﾅﾙ
            ///</summary>
            JNL112 = 112,

            /// <summary>
            ///構成更新ｼﾞｬｰﾅﾙ
            ///</summary>
            JNL113 = 113,

            #region 削除114
            ///// <summary>
            /////他社品番情報更新ジャーナル
            /////</summary>
            //JNL114 = 114,
            #endregion

            /// <summary>
            ///単価更新ｼﾞｬｰﾅﾙ
            ///</summary>
            JNL115 = 115,

            /// <summary>
            ///数量別単価更新ｼﾞｬｰﾅﾙ
            ///</summary>
            JNL116 = 116,

            #region 削除117,118,119
            ///// <summary>
            /////担当者更新ジャーナル
            /////</summary>
            //JNL117 = 117,

            ///// <summary>
            /////単位情報更新ジャーナル
            /////</summary>
            //JNL118 = 118,

            ///// <summary>
            /////セキュリティ情報設定ジャーナル
            /////</summary>
            //JNL119 = 119,
            #endregion

            /// <summary>
            ///金型マスタ更新ジャーナル
            ///</summary>
            JNL120 = 120,

            /// <summary>
            ///金型関連マスタ更新ジャーナル
            ///</summary>
            JNL121 = 121,

            #region 削除122,123,124
            ///// <summary>
            /////プリンタ情報更新ジャーナル
            /////</summary>
            //JNL122 = 122,

            ///// <summary>
            /////
            /////</summary>
            //JNL123 = 123,

            ///// <summary>
            /////
            /////</summary>
            //JNL124 = 124,
            #endregion

            /// <summary>
            ///内示受注更新ジャーナル
            ///</summary>
            JNL125 = 125,

            /// <summary>
            ///受注更新ジャーナル
            ///</summary>
            JNL126 = 126,

            /// <summary>
            ///出荷更新ジャーナル
            ///</summary>
            JNL127 = 127,

            /// <summary>
            ///出荷返品更新ジャーナル
            ///</summary>
            JNL128 = 128,

            /// <summary>
            ///生産計画更新ジャーナル
            ///</summary>
            JNL129 = 129,

            /// <summary>
            ///手配更新ジャーナル
            ///</summary>
            JNL130 = 130,

            /// <summary>
            ///手配変更更新ジャーナル
            ///</summary>
            JNL131 = 131,

            /// <summary>
            ///在庫移動更新ジャーナル
            ///</summary>
            JNL132 = 132,

            /// <summary>
            ///支給出庫更新ジャーナル
            ///</summary>
            JNL133 = 133,

            /// <summary>
            ///受入更新ジャーナル
            ///</summary>
            JNL134 = 134,

            /// <summary>
            ///作業実績更新ジャーナル
            ///</summary>
            JNL135 = 135,

            /// <summary>
            ///不良実績更新ジャーナル
            ///</summary>
            JNL136 = 136,

            /// <summary>
            ///計画外受入更新ジャーナル
            ///</summary>
            JNL137 = 137,

            /// <summary>
            ///在庫調整更新ジャーナル
            ///</summary>
            JNL138 = 138,

            /// <summary>
            ///棚卸条件更新ｼﾞｬｰﾅﾙ
            ///</summary>
            JNL139 = 139,

            /// <summary>
            ///棚卸更新ｼﾞｬｰﾅﾙ
            ///</summary>
            JNL140 = 140,

            /// <summary>
            ///金型入出庫更新ジャーナル
            ///</summary>
            JNL141 = 141,

            /// <summary>
            ///金型実績更新ジャーナル
            ///</summary>
            JNL142 = 142,

            /// <summary>
            ///製番管理更新ジャーナル
            ///</summary>
            JNL143 = 143,

            #region 削除144,145,146,147
            // 20080401 FNS)takizawa add start 
            ///// <summary>
            /////受注ヘッダジャーナル
            /////</summary>
            //JNL144 = 144,
            ///// <summary>
            /////受注明細ジャーナル
            /////</summary>
            //JNL145 = 145,
            ///// <summary>
            /////見積ジャーナル
            /////</summary>
            //JNL146 = 146,
            ///// <summary>
            /////個別受注製番更新ジャーナル
            /////</summary>
            //JNL147 = 147,
            // 20080401 FNS)takizawa add end
            #endregion

            /// <summary>
            ///仕入検収情報更新ジャーナル
            ///</summary>
            JNL145 = 145,

            /// <summary>
            ///受注明細情報更新ジャーナル
            ///</summary>
            JNL146 = 146,

            /// <summary>
            ///個別受注製番情報更新ジャーナル
            ///</summary>
            JNL147 = 147,

            /// <summary>
            ///見積情報更新ジャーナル
            ///</summary>
            JNL148 = 148,

            /// <summary>
            ///見積品目情報更新ジャーナル
            ///</summary>
            JNL149 = 149,

            /// <summary>
            ///見積品目構成情報更新ジャーナル
            ///</summary>
            JNL150 = 150,

            /// <summary>
            ///見積品目費目情報更新ジャーナル
            ///</summary>
            JNL151 = 151,

            /// <summary>
            ///製番別手配構成情報更新ジャーナル
            ///</summary>
            JNL152 = 152,

            /// <summary>
            ///製番別手配工程情報更新ジャーナル
            ///</summary>
            JNL153 = 153,

            /// <summary>
            ///実行予算情報更新ジャーナル
            ///</summary>
            JNL154 = 154,

            /// <summary>
            ///実行予算原価更新ジャーナル
            ///</summary>
            JNL155 = 155,

            /// <summary>
            ///売上検収情報更新ジャーナル
            ///</summary>
            JNL156 = 156,

            /// <summary>
            /// 見積明細原価更新ジャーナル
            /// </summary>
            JNL157 = 157,

            /// <summary>
            /// 都度指示工程更新ジャーナル
            /// </summary>
            JNL158 = 158,

            /// <summary>
            /// 都度作業指示更新ジャーナル
            /// </summary>
            JNL159 = 159,

            /// <summary>
            /// 言語別品目名称更新ジャーナル
            /// </summary>
            JNL160 = 160,

            /// <summary>
            /// 倉庫工程更新ジャーナル
            /// </summary>
            JNL162 = 162,

            /// <summary>
            /// 機械更新ジャーナル
            /// </summary>
            JNL163 = 163,

            /// <summary>
            /// 見込生産計画更新ジャーナル
            /// </summary>
            JNL164 = 164,

            /// <summary>
            /// 受入検査更新ジャーナル
            /// </summary>
            JNL165 = 165,

            /// <summary>
            /// 号機更新ジャーナル
            /// </summary>
            JNL166 = 166,

            /// <summary>
            /// 保守作業更新ジャーナル
            /// </summary>
            JNL167 = 167,

            /// <summary>
            /// 保守部品更新ジャーナル
            /// </summary>
            JNL168 = 168,

            /// <summary>
            /// ソフトウェア情報更新ジャーナル
            /// </summary>
            JNL169 = 169,

            //-------[3.0.0907.1701] 2009.07.17 FNS)takizawa add str
            /// <summary>
            /// 保守内容情報更新ジャーナル
            /// </summary>
            JNL170 = 170,
            //-------[3.0.0907.1701] 2009.07.17 FNS)takizawa add end

            #endregion

            #region 201～300
            /// <summary>
            ///受入実績情報履歴番号
            ///</summary>
            ADT201 = 201,

            /// <summary>
            ///カレンダ情報履歴番号
            ///</summary>
            ADT202 = 202,

            #region 削除 203,204,205
            ///// <summary>
            /////区分情報履歴番号
            /////</summary>
            //ADT203 = 203,

            ///// <summary>
            /////区分明細情報履歴番号
            /////</summary>
            //ADT204 = 204,

            ///// <summary>
            /////自社条件履歴番号
            /////</summary>
            //ADT205 = 205,
            #endregion

            #region 削除206
            ///// <summary>
            /////日付条件履歴番号
            /////</summary>
            //ADT206 = 206,
            #endregion

            /// <summary>
            ///受払情報履歴番号
            ///</summary>
            ADT207 = 207,

            #region 削除208
            ///// <summary>
            /////名称情報履歴番号
            /////</summary>
            //ADT208 = 208,
            #endregion

            /// <summary>
            ///工場在庫情報履歴番号
            ///</summary>
            ADT210 = 210,

            /// <summary>
            ///内示受注明細情報履歴番号
            ///</summary>
            ADT211 = 211,

            /// <summary>
            ///内示受注ヘッダ情報履歴番号
            ///</summary>
            ADT212 = 212,

            /// <summary>
            ///製番管理情報履歴番号
            ///</summary>
            ADT213 = 213,

            /// <summary>
            ///金型マスタ履歴番号
            ///</summary>
            ADT214 = 214,

            /// <summary>
            ///金型関連マスタ履歴番号
            ///</summary>
            ADT215 = 215,

            /// <summary>
            ///金型使用実績情報履歴番号
            ///</summary>
            ADT216 = 216,

            /// <summary>
            ///金型入出庫実績情報履歴番号
            ///</summary>
            ADT217 = 217,

            /// <summary>
            ///採番条件履歴番号
            ///</summary>
            ADT218 = 218,

            /// <summary>
            ///指示工程情報履歴番号
            ///</summary>
            ADT219 = 219,

            #region 削除 220
            ///// <summary>
            /////担当者情報履歴番号
            /////</summary>
            //ADT220 = 220,
            #endregion

            /// <summary>
            ///生産計画情報履歴番号
            ///</summary>
            ADT221 = 221,

            /// <summary>
            ///品目情報履歴番号
            ///</summary>
            ADT222 = 222,

            /// <summary>
            ///手配残情報履歴番号
            ///</summary>
            ADT223 = 223,

            /// <summary>
            ///作業手順情報履歴番号
            ///</summary>
            ADT224 = 224,

            /// <summary>
            ///操作管理履歴情報番号
            ///</summary>
            ADT225 = 225,

            /// <summary>
            ///構成情報履歴番号
            ///</summary>
            ADT226 = 226,

            /// <summary>
            ///数量別単価情報履歴番号
            ///</summary>
            ADT227 = 227,

            /// <summary>
            ///所要量情報履歴番号
            ///</summary>
            ADT228 = 228,

            /// <summary>
            ///不良実績情報履歴番号
            ///</summary>
            ADT229 = 229,

            #region 削除 230
            ///// <summary>
            /////セキュリティ情報履歴番号
            /////</summary>
            //ADT230 = 230,
            #endregion

            /// <summary>
            ///出荷実績情報履歴番号
            ///</summary>
            ADT231 = 231,

            /// <summary>
            ///受注引当明細情報履歴番号
            ///</summary>
            ADT232 = 232,

            /// <summary>
            ///受注残情報履歴番号
            ///</summary>
            ADT233 = 233,

            /// <summary>
            ///支給出庫実績情報履歴番号
            ///</summary>
            ADT234 = 234,

            /// <summary>
            ///在庫調整実績情報履歴番号
            ///</summary>
            ADT235 = 235,

            /// <summary>
            ///棚卸情報履歴番号
            ///</summary>
            ADT236 = 236,

            /// <summary>
            ///棚卸条件情報履歴番号
            ///</summary>
            ADT237 = 237,

            #region 削除 238～242
            ///// <summary>
            /////税率情報履歴番号
            /////</summary>
            //ADT238 = 238,

            ///// <summary>
            /////プリンタ情報履歴番号
            /////</summary>
            //ADT239 = 239,

            ///// <summary>
            /////取引先情報履歴番号
            /////</summary>
            //ADT240 = 240,

            ///// <summary>
            /////他社品番情報履歴番号
            /////</summary>
            //ADT241 = 241,

            ///// <summary>
            /////単位情報履歴番号
            /////</summary>
            //ADT242 = 242,
            #endregion

            /// <summary>
            ///単価情報履歴番号
            ///</summary>
            ADT243 = 243,

            /// <summary>
            ///仕入検収情報履歴
            ///</summary>
            ADT247 = 247,

            /// <summary>
            ///受注明細情報履歴番号
            ///</summary>
            ADT248 = 248,

            /// <summary>
            ///見積情報履歴番号
            ///</summary>
            ADT249 = 249,

            /// <summary>
            ///見積品目情報履歴番号
            ///</summary>
            ADT250 = 250,

            /// <summary>
            ///見積品目構成情報履歴番号
            ///</summary>
            ADT251 = 251,

            /// <summary>
            ///見積品目費目方法履歴番号
            ///</summary>
            ADT252 = 252,

            /// <summary>
            ///個別受注製番情報履歴番号
            ///</summary>
            ADT253 = 253,

            /// <summary>
            ///製番別手配構成情報履歴番号
            ///</summary>
            ADT254 = 254,

            /// <summary>
            ///製番別手配構成情報番号
            ///</summary>
            ADT255 = 255,

            /// <summary>
            ///実行予算情報履歴番号
            ///</summary>
            ADT256 = 256,

            /// <summary>
            ///実行予算原価履歴番号
            ///</summary>
            ADT257 = 257,

            /// <summary>
            ///売上検収情報履歴
            ///</summary>
            ADT258 = 258,

            /// <summary>
            ///見積明細原価情報履歴番号
            ///</summary>
            ADT259 = 259,

            /// <summary>
            ///出荷返品情報履歴番号
            ///</summary>
            ADT260 = 260,

            /// <summary>
            ///製番振替情報履歴番号
            ///</summary>
            ADT261 = 261,

            /// <summary>
            ///都度指示工程情報履歴番号
            ///</summary>
            ADT262 = 262,

            /// <summary>
            ///都度作業手順情報履歴番号
            ///</summary>
            ADT263 = 263,

            /// <summary>
            ///都度品目追加RTCM情報履歴番号
            ///</summary>
            ADT264 = 264,

            /// <summary>
            ///言語別品目名称履歴
            ///</summary>
            ADT266 = 266,

            /// <summary>
            ///倉庫工程履歴
            ///</summary>
            ADT268 = 268,

            /// <summary>
            ///機械履歴
            ///</summary>
            ADT269 = 269,

            /// <summary>
            ///見込生産計画履歴
            ///</summary>
            ADT270 = 270,

            /// <summary>
            ///見込所要量履歴
            ///</summary>
            ADT271 = 271,

            /// <summary>
            ///連携エラー履歴
            ///</summary>
            ADT272 = 272,

            /// <summary>
            ///積送受入履歴
            ///</summary>
            ADT273 = 273,

            /// <summary>
            ///バッチ排他履歴
            ///</summary>
            ADT274 = 274,

            /// <summary>
            ///号機履歴
            ///</summary>
            ADT275 = 275,

            /// <summary>
            ///保守作業履歴
            ///</summary>
            ADT276 = 276,

            /// <summary>
            ///保守部品履歴
            ///</summary>
            ADT277 = 277,

            /// <summary>
            ///ソフトウェア情報履歴
            ///</summary>
            ADT278 = 278,

            //-------[3.0.0907.1701] 2009.07.17 FNS)takizawa add str
            /// <summary>
            /// 保守内容履歴
            /// </summary>
            ADT279 = 279,
            //-------[3.0.0907.1701] 2009.07.17 FNS)takizawa add end

            #endregion

            #region 501～600
            /// <summary>
            /// 拡張用採番条件01
            /// </summary>
            ADD501 = 501,

            /// <summary>
            /// 拡張用採番条件02
            /// </summary>
            ADD502 = 502,

            /// <summary>
            /// 拡張用採番条件03
            /// </summary>
            ADD503 = 503,

            /// <summary>
            /// 拡張用採番条件04
            /// </summary>
            ADD504 = 504,

            /// <summary>
            /// 拡張用採番条件05
            /// </summary>
            ADD505 = 505,

            /// <summary>
            /// 拡張用採番条件06
            /// </summary>
            ADD506 = 506,

            /// <summary>
            /// 拡張用採番条件07
            /// </summary>
            ADD507 = 507,

            /// <summary>
            /// 拡張用採番条件08
            /// </summary>
            ADD508 = 508,

            /// <summary>
            /// 拡張用採番条件09
            /// </summary>
            ADD509 = 509,

            /// <summary>
            /// 拡張用採番条件10
            /// </summary>
            ADD510 = 510,

            /// <summary>
            /// 拡張用採番条件11
            /// </summary>
            ADD511 = 511,

            /// <summary>
            /// 拡張用採番条件12
            /// </summary>
            ADD512 = 512,

            /// <summary>
            /// 拡張用採番条件13
            /// </summary>
            ADD513 = 513,

            /// <summary>
            /// 拡張用採番条件14
            /// </summary>
            ADD514 = 514,

            /// <summary>
            /// 拡張用採番条件15
            /// </summary>
            ADD515 = 515,

            /// <summary>
            /// 拡張用採番条件16
            /// </summary>
            ADD516 = 516,

            /// <summary>
            /// 拡張用採番条件17
            /// </summary>
            ADD517 = 517,

            /// <summary>
            /// 拡張用採番条件18
            /// </summary>
            ADD518 = 518,

            /// <summary>
            /// 拡張用採番条件19
            /// </summary>
            ADD519 = 519,

            /// <summary>
            /// 拡張用採番条件20
            /// </summary>
            ADD520 = 520,
            #endregion

            #region 601～700
            /// <summary>
            /// 見積番号
            /// </summary>
            ESTNO = 601,

            /// <summary>
            /// 受注番号
            /// </summary>
            JUCHU = 602,

            /// <summary>
            /// 出荷伝票番号
            /// </summary>
            ETC001 = 603,

            /// <summary>
            /// 支給伝票番号
            /// </summary>
            ETC005 = 604,

            /// <summary>
            /// 納品書番号
            /// </summary>
            ETC006 = 605,

            /// <summary>
            /// 取消注文書伝票番号
            /// </summary>
            CANSLP = 606,

            /// <summary>
            /// 返品伝票番号
            /// </summary>
            RTNSLP = 607,

            /// <summary>
            /// 注文書伝票番号
            /// </summary>
            CHUMON = 608,
            #endregion

            #region 701～800
            /// <summary>
            /// 取引先更新ジャーナル
            /// </summary>
            JNL701 = 701,

            /// <summary>
            /// 税率情報更新ジャーナル
            /// </summary>
            JNL702 = 702,

            /// <summary>
            /// 他社品番情報更新ジャーナル
            /// </summary>
            JNL703 = 703,

            /// <summary>
            /// 担当者更新ジャーナル
            /// </summary>
            JNL704 = 704,

            /// <summary>
            /// レート更新ジャーナル
            /// </summary>
            JNL705 = 705,

            /// <summary>
            /// 部門更新ジャーナル
            /// </summary>
            JNL708 = 708,

            /// <summary>
            /// 作業日報更新ジャーナル
            /// </summary>
            JNL709 = 709,

            /// <summary>
            /// プロジェクト更新ジャーナル
            /// </summary>
            JNL710 = 710,

            /// <summary>
            /// タスク更新ジャーナル
            /// </summary>
            JNL711 = 711,

            /// <summary>
            /// タスク詳細更新ジャーナル
            /// </summary>
            JNL712 = 712,

            /// <summary>
            /// タスク詳細費目更新ジャーナル
            /// </summary>
            JNL713 = 713,

            /// <summary>
            /// 勘定科目更新ジャーナル
            /// </summary>
            JNL714 = 714,

            /// <summary>
            /// 賃率更新ジャーナル
            /// </summary>
            JNL715 = 715,

            /// <summary>
            ///工場条件更新ジャーナル
            ///</summary>
            //JNL144 = 144,
            JNL716 = 716,

            /// <summary>
            /// 言語別工場名称更新ジャーナル
            /// </summary>
            JNL717 = 717,

            /// <summary>
            /// 取引先更新ジャーナル追加RTCM
            /// </summary>
            JNL718 = 718,

            /// <summary>
            /// 請求先更新ジャーナル
            /// </summary>
            JNL719 = 719,

            /// <summary>
            /// 支払先更新ジャーナル
            /// </summary>
            JNL720 = 720,

            /// <summary>
            ///日付情報更新ジャーナル
            ///</summary>
            JNL721 = 721,

            /// <summary>
            /// 取引先情報履歴番号
            /// </summary>
            //ADT959 = 959,
            ADT751 = 751,

            /// <summary>
            /// 税率情報履歴番号
            /// </summary>
            //ADT957 = 957,
            ADT752 = 752,

            /// <summary>
            /// 他社品番情報履歴番号
            /// </summary>
            //ADT960 = 960,
            ADT753 = 753,

            /// <summary>
            /// 単位情報履歴番号
            /// </summary>
            //ADT961 = 961,
            ADT754 = 754,

            /// <summary>
            /// レート情報履歴番号
            /// </summary>
            //ADT964 = 964,
            ADT755 = 755,

            /// <summary>
            /// 部門履歴
            /// </summary>
            ADT758 = 758,

            /// <summary>
            /// 作業日報履歴
            /// </summary>
            ADT759 = 759,

            /// <summary>
            /// プロジェクト履歴
            /// </summary>
            ADT760 = 760,

            /// <summary>
            /// タスク詳細履歴
            /// </summary>
            ADT762 = 762,

            /// <summary>
            /// タスク詳細費目履歴
            /// </summary>
            ADT763 = 763,

            /// <summary>
            /// 勘定科目履歴
            /// </summary>
            ADT764 = 764,

            /// <summary>
            /// 賃率履歴
            /// </summary>
            ADT765 = 765,

            /// <summary>
            /// 会社採番条件履歴
            /// </summary>
            ADT766 = 766,


            /// <summary>
            ///工場条件情報履歴番号
            ///</summary>
            //ADT209 = 209,
            ADT767 = 767,

            /// <summary>
            /// 言語別工場名称履歴
            /// </summary>
            ADT768 = 768,

            /// <summary>
            /// 倉庫条件履歴番号
            /// </summary>
            ADT769 = 769,

            /// <summary>
            /// 取引先情報追加RTCM履歴番号
            /// </summary>
            ADT770 = 770,

            /// <summary>
            /// 請求先情報履歴番号
            /// </summary>
            ADT771 = 771,

            /// <summary>
            /// 支払先情報履歴番号
            /// </summary>
            ADT772 = 772,

            /// <summary>
            ///日付条件履歴番号
            ///</summary>
            ADT206 = 206,
            #endregion

            #region 801～900
            /// <summary>
            /// 拡張用全社採番条件01
            /// </summary>
            ADD851 = 851,

            /// <summary>
            /// 拡張用全社採番条件02
            /// </summary>
            ADD852 = 852,

            /// <summary>
            /// 拡張用全社採番条件03
            /// </summary>
            ADD853 = 853,

            /// <summary>
            /// 拡張用全社採番条件04
            /// </summary>
            ADD854 = 854,

            /// <summary>
            /// 拡張用全社採番条件05
            /// </summary>
            ADD855 = 855,

            /// <summary>
            /// 拡張用全社採番条件06
            /// </summary>
            ADD856 = 856,

            /// <summary>
            /// 拡張用全社採番条件07
            /// </summary>
            ADD857 = 857,

            /// <summary>
            /// 拡張用全社採番条件08
            /// </summary>
            ADD858 = 858,

            /// <summary>
            /// 拡張用全社採番条件09
            /// </summary>
            ADD859 = 859,

            /// <summary>
            /// 拡張用全社採番条件10
            /// </summary>
            ADD860 = 860,

            /// <summary>
            /// 拡張用全社採番条件11
            /// </summary>
            ADD861 = 861,

            /// <summary>
            /// 拡張用全社採番条件12
            /// </summary>
            ADD862 = 862,

            /// <summary>
            /// 拡張用全社採番条件13
            /// </summary>
            ADD863 = 863,

            /// <summary>
            /// 拡張用全社採番条件14
            /// </summary>
            ADD864 = 864,

            /// <summary>
            /// 拡張用全社採番条件15
            /// </summary>
            ADD865 = 865,

            /// <summary>
            /// 拡張用全社採番条件16
            /// </summary>
            ADD866 = 866,

            /// <summary>
            /// 拡張用全社採番条件17
            /// </summary>
            ADD867 = 867,

            /// <summary>
            /// 拡張用全社採番条件18
            /// </summary>
            ADD868 = 868,

            /// <summary>
            /// 拡張用全社採番条件19
            /// </summary>
            ADD869 = 869,

            /// <summary>
            /// 拡張用全社採番条件20
            /// </summary>
            ADD870 = 870,
            #endregion

            #region 901～999
            /// <summary>
            /// 区分明細更新ジャーナル
            /// </summary>
            JNL901 = 901,

            /// <summary>
            /// 名称情報更新ジャーナル
            /// </summary>
            JNL902 = 902,

            #region 削除 903,904
            //// 20080718 FNS)takizawa add start 
            ///// <summary>
            ///// 都度品目　処理品番
            ///// </summary>
            //JNL903 = 903,

            ///// <summary>
            ///// 都度品目　ジャーナル番号
            ///// </summary>
            //JNL904 = 904
            //// 20080718 FNS)takizawa add end
            #endregion

            /// <summary>
            /// 会社条件更新ジャーナル
            /// </summary>
            JNL903 = 903,

            /// <summary>
            /// 単位情報更新ジャーナル
            /// </summary>
            JNL908 = 908,

            /// <summary>
            /// セキュリティ情報設定ジャーナル
            /// </summary>
            JNL909 = 909,

            /// <summary>
            /// 通貨更新ジャーナル
            /// </summary>
            JNL910 = 910,


            /// <summary>
            /// プリンタ情報更新ジャーナル
            /// </summary>
            JNL912 = 912,

            /// <summary>
            /// データリンク情報更新ジャーナル
            /// </summary>
            JNL913 = 913,

            //-------[2.0.0904.2401] 2009.04.24 Fsol)imatomi add str
            /// <summary>
            /// 会社条件情報設定 ジャーナル
            /// </summary>
            JNL914 = 914,

            /// <summary>
            /// 言語別会社名称設定 ジャーナル
            /// </summary>
            JNL915 = 915,
            //-------[2.0.0904.2401] 2009.04.24 Fsol)imatomi add end

            /// <summary>
            /// ユーザ項目定義情報更新ジャーナル
            /// </summary>
            JNL916 = 916,

            /// <summary>
            /// 画面タブ関連情報更新ジャーナル
            /// </summary>
            JNL917 = 917,

            /// <summary>
            /// タブユーザ項目関連情報更新ジャーナル
            /// </summary>
            JNL918 = 918,

            /// <summary>
            /// ユーザ項目値情報更新ジャーナル
            /// </summary>
            JNL919 = 919,

            /// <summary>
            /// 区分情報履歴番号
            /// </summary>
            ADT951 = 951,

            /// <summary>
            /// 区分明細情報履歴番号
            /// </summary>
            ADT952 = 952,

            /// <summary>
            /// 自社条件履歴番号
            /// </summary>
            ADT953 = 953,

            /// <summary>
            /// 名称情報履歴番号
            /// </summary>
            ADT954 = 954,

            /// <summary>
            /// 担当者情報履歴番号
            /// </summary>
            ADT955 = 955,

            /// <summary>
            /// セキュリティ情報履歴番号
            /// </summary>
            ADT956 = 956,

            /// <summary>
            /// プリンタ情報履歴番号
            /// </summary>
            ADT958 = 958,

            /// <summary>
            /// タスク履歴
            /// </summary>
            ADT961 = 961,

            /// <summary>
            /// 他社品番情報履歴番号
            /// </summary>
            ADT962 = 962,

            /// <summary>
            /// 通貨情報履歴番号
            /// </summary>
            ADT963 = 963,

            /// <summary>
            /// 全社採番条件履歴
            /// </summary>
            ADT965 = 965,

            /// <summary>
            /// データリンク情報履歴更新
            /// </summary>
            ADT966 = 966,

            /// <summary>
            /// 会社条件履歴番号
            /// </summary>
            ADT967 = 967,

            /// <summary>
            /// 言語別会社名称履歴
            /// </summary>
            ADT968 = 968,

            /// <summary>
            /// ユーザ項目定義情報履歴
            /// </summary>
            ADT969 = 969,

            /// <summary>
            /// 画面タブ関連情報履歴
            /// </summary>
            ADT970 = 970,

            /// <summary>
            /// タブユーザ項目関連情報履歴
            /// </summary>
            ADT971 = 971,

            /// <summary>
            /// ユーザ項目値情報履歴
            /// </summary>
            ADT972 = 972,

            //-------[2.0.0908.3101] 2009.08.31 Fsol)imatomi add str
            /// <summary>
            /// バッチ排他履歴
            /// </summary>
            ADT973 = 973,
            //-------[2.0.0908.3101] 2009.08.31 Fsol)imatomi add end

            #endregion

            #region 1000～
            ////2008.5.12 fns)h-suzuki add
            /// <summary>
            ///見積構成ＩＤ
            ///</summary>
            PE0111 = 1000,
            //2008.5.12 fns)h-suzuki add
            /// <summary>
            ///製番手配構成ＩＤ
            ///</summary>
            PE0306 = 2000,
            #endregion

        }
        #endregion
    }
}
