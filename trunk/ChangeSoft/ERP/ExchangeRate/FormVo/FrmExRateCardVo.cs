using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.ERP.ExchangeRate.FormVo
{
    [Serializable]
    public class FrmExRateCardVo
    {
        private string iFacCd;
        private string vFacdesc;
        private string iDlCd;  //iItemType2
        private string vDlDesc;                    //vItemtype2desc;  
        private string iItemCls;  //物料种类
        private string vItemclsdesc;
        private string iItemType;

        private string vItemtypedesc;

        private string iItemCd;
        private string iDispItemCd;
        private string iDispItemRev;

        private string iItemDesc;
        private string iItemRev;
        private string iMakerCd;        //制造商
        private string vMakerdesc;
        private string iModel;          //型号
        private string iDrwNo;          //图号
        private string iSpec;            //样式
        private string iSeiban;         //序列号
        private string iQryMtrl;        //材质
        private string iMntCls;         //维护分类

        private string iMntclsdesc;






        public string IFacCd
        {
            get { return iFacCd; }
            set { iFacCd = value; }
        }

        public string VFacdesc
        {
            get { return vFacdesc; }
            set { vFacdesc = value; }
        }

        public string IDlCd
        {
            get { return iDlCd; }
            set { iDlCd = value; }
        }

        public string VDlDesc
        {
            get { return vDlDesc; }
            set { vDlDesc = value; }
        }

        public string IItemCls
        {
            get { return iItemCls; }
            set { iItemCls = value; }
        }

        public string VItemclsdesc
        {
            get { return vItemclsdesc; }
            set { vItemclsdesc = value; }
        }

        public string IItemType
        {
            get { return iItemType; }
            set { iItemType = value; }
        }

        public string VItemtypedesc
        {
            get { return vItemtypedesc; }
            set { vItemtypedesc = value; }
        }

        public string IItemCd
        {
            get { return iItemCd; }
            set { iItemCd = value; }
        }

        public string IItemDesc
        {
            get { return iItemDesc; }
            set { iItemDesc = value; }
        }

        public string IItemRev
        {
            get { return iItemRev; }
            set { iItemRev = value; }
        }

        public string IMakerCd
        {
            get { return iMakerCd; }
            set { iMakerCd = value; }
        }

        public string VMakerdesc
        {
            get { return vMakerdesc; }
            set { vMakerdesc = value; }
        }

        public string IModel
        {
            get { return iModel; }
            set { iModel = value; }
        }

        public string IDrwNo
        {
            get { return iDrwNo; }
            set { iDrwNo = value; }
        }

        public string ISpec
        {
            get { return iSpec; }
            set { iSpec = value; }
        }

        public string ISeiban
        {
            get { return iSeiban; }
            set { iSeiban = value; }
        }

        public string IQryMtrl
        {
            get { return iQryMtrl; }
            set { iQryMtrl = value; }
        }

        public string IMntCls
        {
            get { return iMntCls; }
            set { iMntCls = value; }
        }

        public string IMntclsdesc
        {
            get { return iMntclsdesc; }
            set { iMntclsdesc = value; }
        }



        public string IDispItemCd
        {
            get { return iDispItemCd; }
            set { iDispItemCd = value; }
        }

        public string IDispItemRev
        {
            get { return iDispItemRev; }
            set { iDispItemRev = value; }
        }
    }
}
