using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class TDescMsId
    {

        #region Private Members

        private string iClsCd;

        private string iNameCd;

        private string iLanguageCd; 


        #endregion

        #region Constuctor(s)


        #endregion // End of Class Constuctor(s)

        #region Public Properties

        //[KeyProperty(Column = "LANGID")]
        //public string IClsCd
        //{
        //    get { return iClsCd; }
        //    set { iClsCd = value; }
        //}

        //[KeyProperty(Column = "CATALOGID")]
        //public virtual int Catalogid
        //{
        //    get { return catalogid; }
        //    set { catalogid = value; }
        //}
        [KeyProperty(Column= "I_CLS_CD", Length = 3)]
        public virtual string IClsCd
        {
            get { return iClsCd; }
            set { iClsCd = value; }
        }

        [KeyProperty(Column= "I_NAME_CD", Length = 6)]
        public virtual string INameCd
        {
            get { return iNameCd; }
            set { iNameCd = value; }
        }

        [KeyProperty(Column="I_LANGUAGE_CD", Length = 6)]
        public virtual string ILanguageCd
        {
            get { return iLanguageCd; }
            set { iLanguageCd = value; }
        }


        #endregion


        #region Equals, HashCode and ToString overrides

        /// <summary>
        /// Local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            TDescMsId castObj = (TDescMsId)obj;
            return (castObj != null) &&
                (this.iClsCd == castObj.iClsCd) &&
                (this.iLanguageCd == castObj.iLanguageCd) &&
                (this.iNameCd == castObj.iNameCd);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * iClsCd.GetHashCode();
            hash = 27 * hash * iLanguageCd.GetHashCode();
            hash = 27 * hash * iNameCd.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Local implementation of ToString based on class members
        /// </summary>
        public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
            sbuffer.Append("{");

            sbuffer.AppendFormat("Langid = {0}, ", iClsCd);
            sbuffer.AppendFormat("Catalogid = {0}, ", iLanguageCd);
            sbuffer.AppendFormat("Catalogid = {0}, ", iNameCd);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
