using System;
using System.Collections.Generic;
using Com.GainWinSoft.Common;
namespace Com.GainWinSoft.ERP.Entity.Dao.StoredInfo
{
    /// <summary>
    /// 概要：
    /// ストアド情報保持クラス（継承クラス）のインターフェイス
    /// </summary>
    public interface IStoredParameterInfo
    {
        /// <summary>
        /// ストアド名を取得します。
        /// </summary>
        string StoredName { get;}

        /// <summary>
        /// パラメータリストを取得します。
        /// </summary>
        List<ParameterInfo> ParameterList { get; }
    }
}
