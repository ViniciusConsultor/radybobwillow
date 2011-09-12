using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.ERP.Entity
{
    public class CCodeRefTradeForMaterialNoAR
    {
        #region Private Members

        private string iCompanyCd;
        private string iDlCd;
        private string iDlArgDesc;
        private string iDlDesc;
        private string iDlDescKana;
        private string iDlType;
        private string iDlTypeName;



        #endregion




        public string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        public string IDlCd
        {
            get { return iDlCd; }
            set { iDlCd = value; }
        }

        public string IDlArgDesc
        {
            get { return iDlArgDesc; }
            set { iDlArgDesc = value; }
        }

        public string IDlDesc
        {
            get { return iDlDesc; }
            set { iDlDesc = value; }
        }

        public string IDlDescKana
        {
            get { return iDlDescKana; }
            set { iDlDescKana = value; }
        }

        public string IDlType
        {
            get { return iDlType; }
            set { iDlType = value; }
        }

        public string IDlTypeName
        {
            get { return iDlTypeName; }
            set { iDlTypeName = value; }
        }
    }
}
