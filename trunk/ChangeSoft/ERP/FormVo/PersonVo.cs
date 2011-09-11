using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.ERP.FormVo
{
    public class PersonVo
    {
        
		#region Private Members

        private string iCompanyCd;
        private string iPersonCd; 


		private string iPersonDesc; 
		private string iPersonDescKana; 
		private string iJobCls; 
		private string iUserId; 
		private string iSectionCd; 
		private string iPersonEngDesc; 
		private string iPersonCls; 
		private string iInqItem; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
	
		#endregion // End of Class Constuctor(s)
		
		#region Public Properties



        public virtual string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        public virtual string IPersonCd
        {
            get { return iPersonCd; }
            set { iPersonCd = value; }
        }


		public virtual string IPersonDesc
		{
			get { return iPersonDesc; }
			set { iPersonDesc = value; }
		}

		public virtual string IPersonDescKana
		{
			get { return iPersonDescKana; }
			set { iPersonDescKana = value; }
		}

		public virtual string IJobCls
		{
			get { return iJobCls; }
			set { iJobCls = value; }
		}

		public virtual string IUserId
		{
			get { return iUserId; }
			set { iUserId = value; }
		}

		public virtual string ISectionCd
		{
			get { return iSectionCd; }
			set { iSectionCd = value; }
		}

		public virtual string IPersonEngDesc
		{
			get { return iPersonEngDesc; }
			set { iPersonEngDesc = value; }
		}

		public virtual string IPersonCls
		{
			get { return iPersonCls; }
			set { iPersonCls = value; }
		}

		public virtual string IInqItem
		{
			get { return iInqItem; }
			set { iInqItem = value; }
		}

		public virtual DateTime IEntryDate
		{
			get { return iEntryDate; }
			set { iEntryDate = value; }
		}

		public virtual DateTime IUpdDate
		{
			get { return iUpdDate; }
			set { iUpdDate = value; }
		}

		public virtual string IUpdTimestamp
		{
			get { return iUpdTimestamp; }
			set { iUpdTimestamp = value; }
		}


		#endregion 
    }
}
