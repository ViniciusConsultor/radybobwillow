/* 
 * �X�g�A�h���@�p���t�@�C���N���X
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
    /// �T�[�o�[���t�擾(�p���N���X)
    /// </summary>
    [Serializable]
    internal class STORED_GET_SYSDATE : IStoredParameterInfo
    {
        #region �t�B�[���h
        /// <summary>
        /// �X�g�A�h��:GET_SYSDATE
        /// </summary>
        public static readonly string SOTRED_NAME = "GET_SYSDATE";
        #endregion

        #region �R���X�g���N�^
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public STORED_GET_SYSDATE()
        {
            this._function_return = new ParameterInfo("_function_return", 19, ParameterDirection.ReturnValue, DbType.String,false,0);
        }

        #endregion

        #region �v���p�e�B

        #region �t�@���N�V�����Ԃ�l

        /// <summary>
        /// ���ʃp�����[�^:���t
        /// </summary>
        private ParameterInfo _function_return;

        /// <summary>
        /// ���ʃp�����[�^���擾���܂��B
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

        #region IStoredParameterInfo �����o

        /// <summary>
        /// �X�g�A�h�����擾���܂��B
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