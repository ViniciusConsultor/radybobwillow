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
    }
}
