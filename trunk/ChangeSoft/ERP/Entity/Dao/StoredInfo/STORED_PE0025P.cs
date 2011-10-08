

using System;
using System.Data.Common;
using System.Data;
using System.Collections.Generic;
using Com.GainWinSoft.ERP.Entity.Dao.StoredInfo;


namespace Com.GainWinSoft.ERP.Entity.Dao.StoredInfo
{
	/// <summary>
	/// [ストアド共通部品] ストアド情報を保持するクラス
	/// ストアド論理名：ストアドレート情報設定
	/// </summary>
	[Serializable]
	public sealed class STORED_PE0025P : IStoredParameterInfo
	{

		#region フィールド

		/// <summary>
		/// ストアド名
		/// </summary>
		public static readonly string STORED_NAME = "PE0025P.TOP_RTN";
		
		#endregion

		#region コンストラクタ

			/// <summary>
			/// コンストラクタ
			/// </summary>
			public STORED_PE0025P()
			{
                this._i_return_num = new ParameterInfo("i_return_num", 10, ParameterDirection.ReturnValue, DbType.Decimal, false, 0);
                this._i_journal_no = new ParameterInfo("i_journal_no", 10, ParameterDirection.Input, DbType.Decimal, false, 0);
                this._i_company_cd = new ParameterInfo("i_company_cd", 8, ParameterDirection.Input, DbType.String, false, 0);
                this._i_err_cd = new ParameterInfo("i_err_cd", 6, ParameterDirection.Output, DbType.String, false, 0);
                this._i_err_item = new ParameterInfo("i_err_item", 25, ParameterDirection.Output, DbType.String, false, 0);

			}

		#endregion

		#region プロパティ


		#region パラメータ ストアド戻り値

		/// <summary>
		/// パラメータ 「ストアド戻り値」
		/// </summary>
            private ParameterInfo _i_return_num = null;

		/// <summary>
		/// パラメータ 「ストアド戻り値」を取得します。
		/// 属性 : Decimal
		/// パラメータサイズ : 10
		/// 出力タイプ : ReturnValue
		/// </summary>
            public ParameterInfo I_return_num
		{
			get
			{
				return this._i_return_num;
			}
		}

		#endregion


		#region パラメータ ジャーナル番号

		/// <summary>
		/// パラメータ 「ジャーナル番号」
		/// </summary>
            private ParameterInfo _i_journal_no = null;

		/// <summary>
		/// パラメータ 「ジャーナル番号」を取得します。
		/// 属性 : Decimal
		/// パラメータサイズ : 10
		/// 出力タイプ : Input
		/// </summary>
            public ParameterInfo I_journal_no
		{
			get
			{
				return this._i_journal_no;
			}
		}

		#endregion


		#region パラメータ 会社番号

		/// <summary>
		/// パラメータ 「会社番号」
		/// </summary>
            private ParameterInfo _i_company_cd = null;

		/// <summary>
		/// パラメータ 「会社番号」を取得します。
		/// 属性 : Varchar2
		/// パラメータサイズ : 8
		/// 出力タイプ : Input
		/// </summary>
            public ParameterInfo I_company_cd
		{
			get
			{
				return this._i_company_cd;
			}
		}

		#endregion


		#region パラメータ エラー番号Ｃ

		/// <summary>
		/// パラメータ 「エラー番号Ｃ」
		/// </summary>
            private ParameterInfo _i_err_cd = null;

		/// <summary>
		/// パラメータ 「エラー番号Ｃ」を取得します。
		/// 属性 : Varchar2
		/// パラメータサイズ : 6
		/// 出力タイプ : Output
		/// </summary>
            public ParameterInfo I_err_cd
		{
			get
			{
				return this._i_err_cd;
			}
		}

		#endregion


		#region パラメータ エラー項目

		/// <summary>
		/// パラメータ 「エラー項目」
		/// </summary>
            private ParameterInfo _i_err_item = null;

		/// <summary>
		/// パラメータ 「エラー項目」を取得します。
		/// 属性 : Varchar2
		/// パラメータサイズ : 25
		/// 出力タイプ : Output
		/// </summary>
            public ParameterInfo I_err_item
		{
			get
			{
				return this._i_err_item;
			}
		}

		#endregion



		#endregion

		/// <summary>
		/// プロシージャ名を取得します。
		/// </summary>
		public string StoredName
		{
			get { return STORED_NAME; }
		}

		/// <summary>
		/// このストアドで保持するパラメータのリストを取得します。
		/// </summary>
        public List<ParameterInfo> ParameterList
		{
			get
			{
                List<ParameterInfo> paramlist = new List<ParameterInfo>();
				paramlist.Add(this._i_return_num);
				paramlist.Add(this._i_journal_no);
				paramlist.Add(this._i_company_cd);
				paramlist.Add(this._i_err_cd);
				paramlist.Add(this._i_err_item);
				return paramlist;
			}
		}
	}
}