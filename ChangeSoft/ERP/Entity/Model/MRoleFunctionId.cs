using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class MRoleFunctionID
    {

        #region Private Members

        private int roleid;
        private int functionid; 


        #endregion

        #region Constuctor(s)


        #endregion // End of Class Constuctor(s)

        #region Public Properties


        [KeyProperty(Column = "ROLEID")]
        public virtual int Roleid
        {
            get { return roleid; }
            set { roleid = value; }
        }

        [KeyProperty(Column = "FUNCTIONID")]
        public virtual int Functionid
        {
            get { return functionid; }
            set { functionid = value; }
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
            MRoleFunctionID castObj = (MRoleFunctionID)obj;
            return (castObj != null) &&
                (this.roleid == castObj.roleid) &&
                (this.functionid == castObj.functionid);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * roleid.GetHashCode();
            hash = 27 * hash * functionid.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Local implementation of ToString based on class members
        /// </summary>
        public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
            sbuffer.Append("{");

            sbuffer.AppendFormat("Roleid = {0}, ", roleid);
            sbuffer.AppendFormat("Functionid = {0}, ", functionid);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion
    }
}
