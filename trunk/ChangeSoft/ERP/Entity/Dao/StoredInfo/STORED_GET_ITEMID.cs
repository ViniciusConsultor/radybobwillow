using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Com.GainWinSoft.ERP.Entity.Dao.StoredInfo
{
    [Serializable]
    internal class STORED_GET_ITEMID : IStoredParameterInfo
    {
        #region フィールド
        /// <summary>
        /// ストアド名:GET_ITEMID
        /// </summary>
        public static readonly string SOTRED_NAME = "GET_ITEMID";
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public STORED_GET_ITEMID()
        {
            this._function_return = new ParameterInfo("_function_return",28, ParameterDirection.ReturnValue, DbType.String , false,0);
        }

        #endregion

        #region プロパティ

        #region ファンクション返り値

        /// <summary>
        /// 結果パラメータ:構成ID
        /// </summary>
        private ParameterInfo _function_return;

        /// <summary>
        /// 結果パラメータを取得します。
        /// </summary>
        public ParameterInfo Function_return
        {
            get
            {
                return this._function_return;
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

        public List<ParameterInfo> ParameterList
        {
            get
            {
                List<ParameterInfo> paramlist = new List<ParameterInfo>();
                paramlist.Add(this._function_return);
                return paramlist;
            }
        }

        #endregion
    }
}
