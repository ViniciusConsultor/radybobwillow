/* 
 * ストアド情報　継承ファイルクラス
 *
 * All Rights Reserved, Copyright (c) FUJITSU SYSTEM SOLUTIONS LIMITED 2007
 * FUJITSU SYSTEM SOLUTIONS LIMITED CONFIDENTIAL
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Com.GainWinSoft.ERP.Entity.Dao.StoredInfo;
using Com.GainWinSoft.Common;

namespace Com.GainWinSoft.ERP.Entity.Dao.StoredInfo
{
    /// <summary>
    /// 採番マスタ情報(継承クラス)
    /// </summary>
    [Serializable]
    internal class STORED_SAIBAN_RTN_CHAR : IStoredProcedureInfo
    {
        #region フィールド
        /// <summary>
        /// ストアド名
        /// </summary>
        public static readonly string SOTRED_NAME = "SAIBAN_RTN_CHAR";
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public STORED_SAIBAN_RTN_CHAR()
        {
            this._function_return = new StoredProcedureParameterInfo("RETURN",DbType.String, 10, ParameterDirection.ReturnValue);
            this._para_no = new StoredProcedureParameterInfo("PARA_NO",DbType.Decimal, 3, ParameterDirection.Input);
            this._para_today = new StoredProcedureParameterInfo("PARA_TODAY",DbType.Date, 10, ParameterDirection.Input);
            this._para_facode = new StoredProcedureParameterInfo("PARA_FACODE",DbType.String, 10, ParameterDirection.Input);
        }

        #endregion

        #region プロパティ

        #region ファンクション返り値

        /// <summary>
        /// 結果パラメータ
        /// </summary>
        private StoredProcedureParameterInfo _function_return;

        /// <summary>
        /// 結果パラメータを取得します。
        /// </summary>
        public StoredProcedureParameterInfo Function_return
        {
            get
            {
                return this._function_return;
            }
        }

        #endregion

        #region パラメータ 「PARA_NO」

        /// <summary>
        /// パラメータ PARA_NO
        /// </summary>
        private StoredProcedureParameterInfo _para_no;

        /// <summary>
        /// パラメータ PARA_NO を取得します。
        /// </summary>
        public StoredProcedureParameterInfo Para_no
        {
            get
            {
                return this._para_no;
            }
        }

        #endregion

        #region パラメータ 「PARA_TODAY」

        /// <summary>
        /// パラメータ PARA_TODAY
        /// </summary>
        private StoredProcedureParameterInfo _para_today;

        /// <summary>
        /// パラメータ「PARA_TODAY」
        /// </summary>
        public StoredProcedureParameterInfo Para_today
        {
            get
            {
                return this._para_today;
            }
        }

        #endregion

        #region パラメータ 「PARA_FACODE」
        /// <summary>
        /// パラメータ PARA_FACODE
        /// </summary>
        private StoredProcedureParameterInfo _para_facode;
        /// <summary>
        /// パラメータ PARA_FACODE　を取得します。
        /// </summary>
        public StoredProcedureParameterInfo Para_facode
        {
            get
            {
                return this._para_facode;
            }
        }
        #endregion

        #endregion

        #region IStoredParameterInfo メンバ

        /// <summary>
        /// ストアド名を取得します。
        /// </summary>
        public string StoredName
        {
            get
            {
                return SOTRED_NAME;
            }
        }

        public List<StoredProcedureParameterInfo> ParameterList
        {
            get
            {
                List<StoredProcedureParameterInfo> paramlist = new List<StoredProcedureParameterInfo>();
                paramlist.Add(this._function_return);
                paramlist.Add(this._para_no);
                paramlist.Add(this._para_today);
                paramlist.Add(this._para_facode);

                return paramlist;
            }
        }

        #endregion
    }

    //-------[2.0.0905.1801] 2009.05.18 Fsol)imatomi add str
    /// <summary>
    /// 採番マスタ情報(継承クラス),会社採番用
    /// </summary>
    internal class STORED_SAIBAN_RTN_COM : IStoredProcedureInfo
    {
        #region フィールド
        /// <summary>
        /// ストアド名
        /// </summary>
        public static readonly string SOTRED_NAME = "SAIBAN_RTN_COM";
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public STORED_SAIBAN_RTN_COM()
        {
            this._function_return = new StoredProcedureParameterInfo("RETURN",DbType.String, 10, ParameterDirection.ReturnValue);
            this._para_no = new StoredProcedureParameterInfo("PARA_NO",DbType.Decimal, 3, ParameterDirection.Input);
            this._para_today = new StoredProcedureParameterInfo("PARA_TODAY",DbType.Date, 10, ParameterDirection.Input);
            this._para_com_cd = new StoredProcedureParameterInfo("PARA_COM_CD",DbType.String, 10, ParameterDirection.Input);
        }

        #endregion

        #region プロパティ

        #region ファンクション返り値

        /// <summary>
        /// 結果パラメータ
        /// </summary>
        private StoredProcedureParameterInfo _function_return;

        /// <summary>
        /// 結果パラメータを取得します。
        /// </summary>
        public StoredProcedureParameterInfo Function_return
        {
            get
            {
                return this._function_return;
            }
        }

        #endregion

        #region パラメータ 「PARA_NO」

        /// <summary>
        /// パラメータ PARA_NO
        /// </summary>
        private StoredProcedureParameterInfo _para_no;

        /// <summary>
        /// パラメータ PARA_NO を取得します。
        /// </summary>
        public StoredProcedureParameterInfo Para_no
        {
            get
            {
                return this._para_no;
            }
        }

        #endregion

        #region パラメータ 「PARA_TODAY」

        /// <summary>
        /// パラメータ PARA_TODAY
        /// </summary>
        private StoredProcedureParameterInfo _para_today;

        /// <summary>
        /// パラメータ「PARA_TODAY」
        /// </summary>
        public StoredProcedureParameterInfo Para_today
        {
            get
            {
                return this._para_today;
            }
        }

        #endregion

        #region パラメータ 「PARA_COM_CD」
        /// <summary>
        /// パラメータ PARA_COM_CD
        /// </summary>
        private StoredProcedureParameterInfo _para_com_cd;
        /// <summary>
        /// パラメータ PARA_COM_CD　を取得します。
        /// </summary>
        public StoredProcedureParameterInfo Para_com_cd
        {
            get
            {
                return this._para_com_cd;
            }
        }
        #endregion

        #endregion

        #region IStoredParameterInfo メンバ

        /// <summary>
        /// ストアド名を取得します。
        /// </summary>
        public string StoredName
        {
            get
            {
                return SOTRED_NAME;
            }
        }

        public List<StoredProcedureParameterInfo> ParameterList
        {
            get
            {
                List<StoredProcedureParameterInfo> paramlist = new List<StoredProcedureParameterInfo>();
                paramlist.Add(this._function_return);
                paramlist.Add(this._para_no);
                paramlist.Add(this._para_today);
                paramlist.Add(this._para_com_cd);

                return paramlist;
            }
        }

        #endregion
    }
    //-------[2.0.0905.1801] 2009.05.18 Fsol)imatomi add end
}