using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'M_ROLE' Schema
/*
 * 'MRole' class maps to 'M_ROLE' table.
 * 	 ROLEID                  | Type:NUMBER    | Len:0     | Nullable:F | PK:T | FK:F
 * 	 ROLENAME                | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 CREATEDATETIME          | Type:TIMESTAMP | Len:0     | Nullable:T | PK:F | FK:F
 * 	 CREATEUSERID            | Type:NVARCHAR2 | Len:20    | Nullable:T | PK:F | FK:F
 * 	 UPDATEDATETIME          | Type:TIMESTAMP | Len:0     | Nullable:T | PK:F | FK:F
 * 	 UPDATEUSERID            | Type:VARCHAR2  | Len:20    | Nullable:T | PK:F | FK:F
 * 	 DELETEFLAG              | Type:NVARCHAR2 | Len:1     | Nullable:T | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/9 0:15:42
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("M_ROLE")]
	public class MRole : ActiveRecordBase	{

		#region Private Members

		private decimal roleid; 
		private string rolename; 
		private DateTime createdatetime; 
		private string createuserid; 
		private DateTime updatedatetime; 
		private string updateuserid; 
		private string deleteflag; 
		
		#endregion

		#region Constuctor(s)
		
		public MRole()
		{
			roleid = 0; 
			rolename = String.Empty; 
			createdatetime = DateTime.MinValue; 
			createuserid = String.Empty; 
			updatedatetime = DateTime.MinValue; 
			updateuserid = String.Empty; 
			deleteflag = String.Empty; 

		}

		public MRole(
			decimal roleid)
			: this()
		{
			roleid = roleid;
			rolename = String.Empty;
			createdatetime = DateTime.MinValue;
			createuserid = String.Empty;
			updatedatetime = DateTime.MinValue;
			updateuserid = String.Empty;
			deleteflag = String.Empty;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties
			
		[PrimaryKey(PrimaryKeyType.Identity ,"ROLEID")]
		public virtual decimal Roleid
		{
			get { return roleid; }
			set { roleid = value; }
		}

		[Property(Column="ROLENAME", Length=20)]
		public virtual string Rolename
		{
			get { return rolename; }
			set { rolename = value; }
		}

		[Property(Column="CREATEDATETIME")]
		public virtual DateTime Createdatetime
		{
			get { return createdatetime; }
			set { createdatetime = value; }
		}

		[Property(Column="CREATEUSERID", Length=20)]
		public virtual string Createuserid
		{
			get { return createuserid; }
			set { createuserid = value; }
		}

		[Property(Column="UPDATEDATETIME")]
		public virtual DateTime Updatedatetime
		{
			get { return updatedatetime; }
			set { updatedatetime = value; }
		}

		[Property(Column="UPDATEUSERID", Length=20)]
		public virtual string Updateuserid
		{
			get { return updateuserid; }
			set { updateuserid = value; }
		}

		[Property(Column="DELETEFLAG", Length=1)]
		public virtual string Deleteflag
		{
			get { return deleteflag; }
			set { deleteflag = value; }
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
			MRole castObj = (MRole)obj; 
			return ( castObj != null ) &&
				( this.roleid == castObj.Roleid );
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * roleid.GetHashCode();
			return hash; 
		}
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			
			sbuffer.AppendFormat("Roleid = {0}, ",roleid);
			sbuffer.AppendFormat("Rolename = {0}, ",rolename);
			sbuffer.AppendFormat("Createdatetime = {0}, ",createdatetime);
			sbuffer.AppendFormat("Createuserid = {0}, ",createuserid);
			sbuffer.AppendFormat("Updatedatetime = {0}, ",updatedatetime);
			sbuffer.AppendFormat("Updateuserid = {0}, ",updateuserid);
			sbuffer.AppendFormat("Deleteflag = {0}, ",deleteflag);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}
