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
    /// �̔ԃ}�X�^���(�p���N���X)
    /// </summary>
    [Serializable]
    internal class STORED_SAIBAN_RTN_CHAR : IStoredParameterInfo
    {
        #region �t�B�[���h
        /// <summary>
        /// �X�g�A�h��
        /// </summary>
        public static readonly string SOTRED_NAME = "SAIBAN_RTN_CHAR";
        #endregion

        #region �R���X�g���N�^
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public STORED_SAIBAN_RTN_CHAR()
        {
            this._function_return = new ParameterInfo("RETURN", 10, ParameterDirection.ReturnValue, DbType.String,false,0);
            this._para_no = new ParameterInfo("PARA_NO", 3, ParameterDirection.Input, DbType.Decimal,false,0);
            this._para_today = new ParameterInfo("PARA_TODAY", 10, ParameterDirection.Input, DbType.Date,false,0);
            this._para_facode = new ParameterInfo("PARA_FACODE", 10, ParameterDirection.Input, DbType.String,false,0);
        }

        #endregion

        #region �v���p�e�B

        #region �t�@���N�V�����Ԃ�l

        /// <summary>
        /// ���ʃp�����[�^
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

        #region �p�����[�^ �uPARA_NO�v

        /// <summary>
        /// �p�����[�^ PARA_NO
        /// </summary>
        private ParameterInfo _para_no;

        /// <summary>
        /// �p�����[�^ PARA_NO ���擾���܂��B
        /// </summary>
        public ParameterInfo Para_no
        {
            get
            {
                return this._para_no;
            }
        }

        #endregion

        #region �p�����[�^ �uPARA_TODAY�v

        /// <summary>
        /// �p�����[�^ PARA_TODAY
        /// </summary>
        private ParameterInfo _para_today;

        /// <summary>
        /// �p�����[�^�uPARA_TODAY�v
        /// </summary>
        public ParameterInfo Para_today
        {
            get
            {
                return this._para_today;
            }
        }

        #endregion

        #region �p�����[�^ �uPARA_FACODE�v
        /// <summary>
        /// �p�����[�^ PARA_FACODE
        /// </summary>
        private ParameterInfo _para_facode;
        /// <summary>
        /// �p�����[�^ PARA_FACODE�@���擾���܂��B
        /// </summary>
        public ParameterInfo Para_facode
        {
            get
            {
                return this._para_facode;
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
    /// �̔ԃ}�X�^���(�p���N���X),��Ѝ̔ԗp
    /// </summary>
    internal class STORED_SAIBAN_RTN_COM : IStoredParameterInfo
    {
        #region �t�B�[���h
        /// <summary>
        /// �X�g�A�h��
        /// </summary>
        public static readonly string SOTRED_NAME = "SAIBAN_RTN_COM";
        #endregion

        #region �R���X�g���N�^
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public STORED_SAIBAN_RTN_COM()
        {
            this._function_return = new ParameterInfo("RETURN", 10, ParameterDirection.ReturnValue, DbType.String,false,0);
            this._para_no = new ParameterInfo("PARA_NO", 3, ParameterDirection.Input, DbType.Decimal,false,0);
            this._para_today = new ParameterInfo("PARA_TODAY", 10, ParameterDirection.Input, DbType.Date,false,0);
            this._para_com_cd = new ParameterInfo("PARA_COM_CD", 10, ParameterDirection.Input, DbType.String,false,0);
        }

        #endregion

        #region �v���p�e�B

        #region �t�@���N�V�����Ԃ�l

        /// <summary>
        /// ���ʃp�����[�^
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

        #region �p�����[�^ �uPARA_NO�v

        /// <summary>
        /// �p�����[�^ PARA_NO
        /// </summary>
        private ParameterInfo _para_no;

        /// <summary>
        /// �p�����[�^ PARA_NO ���擾���܂��B
        /// </summary>
        public ParameterInfo Para_no
        {
            get
            {
                return this._para_no;
            }
        }

        #endregion

        #region �p�����[�^ �uPARA_TODAY�v

        /// <summary>
        /// �p�����[�^ PARA_TODAY
        /// </summary>
        private ParameterInfo _para_today;

        /// <summary>
        /// �p�����[�^�uPARA_TODAY�v
        /// </summary>
        public ParameterInfo Para_today
        {
            get
            {
                return this._para_today;
            }
        }

        #endregion

        #region �p�����[�^ �uPARA_COM_CD�v
        /// <summary>
        /// �p�����[�^ PARA_COM_CD
        /// </summary>
        private ParameterInfo _para_com_cd;
        /// <summary>
        /// �p�����[�^ PARA_COM_CD�@���擾���܂��B
        /// </summary>
        public ParameterInfo Para_com_cd
        {
            get
            {
                return this._para_com_cd;
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