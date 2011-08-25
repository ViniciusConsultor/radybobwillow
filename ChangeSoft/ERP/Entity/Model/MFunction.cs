using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'M_FUNCTION' Schema
/*
 * 'MFunction' class maps to 'M_FUNCTION' table.
 * 	 LANGID                  | Type:NVARCHAR2 | Len:10    | Nullable:F | PK:T | FK:F
 * 	 FUNCTIONID              | Type:NUMBER    | Len:0     | Nullable:F | PK:T | FK:F
 * 	 FUNCTIONNAME            | Type:NVARCHAR2 | Len:100   | Nullable:T | PK:F | FK:F
 * 	 FUNCTIONPATH            | Type:NVARCHAR2 | Len:100   | Nullable:T | PK:F | FK:F
 * 	 CATALOGID               | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/8/24 20:15:02
/// </summary>
namespace Com.ChangeSoft.ERP.Entity
{
	[Serializable , ActiveRecord("M_FUNCTION")]
	public class MFunction : ActiveRecordBase	{

		#region Private Members

        private MFunctionID id;

        private string functionname; 
		private string functionpath; 
		private int catalogid;
        private int functionindex;
        private string functionimage;

  		
		#endregion

		#region Constuctor(s)
		
		public MFunction()
		{
            id = new MFunctionID();
			functionname = String.Empty; 
			functionpath = String.Empty;
            functionname = String.Empty;
            functionpath = String.Empty;
            functionindex = 0;
            functionimage = String.Empty;

			catalogid = 0; 

		}

		public MFunction(
			string langid, 
			int functionid, 
			int _catalogid)
			: this()
		{
            id = new MFunctionID();
            id.Langid = langid;
            id.Functionid = functionid;
			functionname = String.Empty;
			functionpath = String.Empty;
            functionindex = 0;
            functionimage = String.Empty;
			catalogid =_catalogid;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties

        [CompositeKey]
        public MFunctionID Id
        {
            get { return id; }
            set { id = value; }
        } 


		[Property(Column="FUNCTIONNAME", Length=100)]
		public virtual string Functionname
		{
			get { return functionname; }
			set { functionname = value; }
		}

		[Property(Column="FUNCTIONPATH", Length=100)]
		public virtual string Functionpath
		{
			get { return functionpath; }
			set { functionpath = value; }
		}

		[Property(Column="CATALOGID", NotNull=true)]
		public virtual int Catalogid
		{
			get { return catalogid; }
			set { catalogid = value; }
		}

        [Property(Column = "FUNCTIONINDEX", NotNull = false)]
        public int Functionindex
        {
            get { return functionindex; }
            set { functionindex = value; }
        }
        [Property(Column="FUNCTIONIMAGE",Length=100)]
        public string Functionimage
        {
            get { return functionimage; }
            set { functionimage = value; }
        }


		#endregion 

			
		#region Equals, HashCode and ToString overrides
		
		/// <summary>
		/// Local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			MFunction castObj = (MFunction)obj; 
			return ( castObj != null ) &&
				( this.id == castObj.id );
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * id.GetHashCode();
			return hash; 
		}
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			
			sbuffer.AppendFormat("Langid = {0}, ",id.Langid);
			sbuffer.AppendFormat("Functionid = {0}, ",id.Functionid);
			sbuffer.AppendFormat("Functionname = {0}, ",functionname);
			sbuffer.AppendFormat("Functionpath = {0}, ",functionpath);
			sbuffer.AppendFormat("Catalogid = {0}, ",catalogid);
            sbuffer.AppendFormat("Functionimage = {0},", functionimage);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}
