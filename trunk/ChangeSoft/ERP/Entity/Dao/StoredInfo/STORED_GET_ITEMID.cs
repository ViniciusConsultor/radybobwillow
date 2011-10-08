using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Com.GainWinSoft.ERP.Entity.Dao.StoredInfo
{
    [Serializable]
    internal class STORED_GET_ITEMID : IStoredParameterInfo
    {
        #region �t�B�[���h
        /// <summary>
        /// �X�g�A�h��:GET_ITEMID
        /// </summary>
        public static readonly string SOTRED_NAME = "GET_ITEMID";
        #endregion

        #region �R���X�g���N�^
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public STORED_GET_ITEMID()
        {
            this._function_return = new ParameterInfo("_function_return",28, ParameterDirection.ReturnValue, DbType.String , false,0);
        }

        #endregion

        #region �v���p�e�B

        #region �t�@���N�V�����Ԃ�l

        /// <summary>
        /// ���ʃp�����[�^:�\��ID
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
