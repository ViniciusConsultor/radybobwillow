using System;
using System.Collections;

using System.Data;

using Oracle.DataAccess.Client;

namespace Com.GainWinSoft.Common
{
    public class StoredProcedureCondition
    {
        private Hashtable conditionTable = new Hashtable();
        
        public Hashtable ConditionTable
        {
            get { return this.conditionTable; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public StoredProcedureCondition AddCondition(string parameterName,DbType dbType,Int32 size, ParameterDirection direction)
        {
            this.conditionTable.Add(System.Guid.NewGuid()/*fielName*/, new StoredProcedureParameterInfo(parameterName,dbType,size, direction));
            return this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="parameterValue"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public StoredProcedureCondition AddCondition(string parameterName, object parameterValue,ParameterDirection direction)
        {
            this.conditionTable.Add(System.Guid.NewGuid()/*fielName*/, new StoredProcedureParameterInfo(parameterName, parameterValue,direction));
            return this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="parameterValue"></param>
        /// <param name="dbType"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public StoredProcedureCondition AddCondition(string parameterName, object parameterValue,DbType dbType,Int32 size, ParameterDirection direction)
        {
            this.conditionTable.Add(System.Guid.NewGuid()/*fielName*/, new StoredProcedureParameterInfo(parameterName, parameterValue,dbType,size, direction));
            return this;
        }


        
        /// <summary>
        ///
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public IDbCommand SetStoredProcedureParametersWithRetrunNumber(IDbCommand command)
        {


            foreach (DictionaryEntry de in this.conditionTable)
            {
                StoredProcedureParameterInfo info = (StoredProcedureParameterInfo)de.Value;

                //忽视参数表内的returnValue
                if (info.Direction == ParameterDirection.ReturnValue)
                {
                    continue;
                }

                IDbDataParameter para = command.CreateParameter();
                para.ParameterName = info.ParameterName;
                para.DbType = info.DbType;
                para.Direction = info.Direction;
                if (info.Direction == ParameterDirection.Output || info.Direction == ParameterDirection.InputOutput)
                {
                    para.Size = info.Size;
                }
                if (info.Direction == ParameterDirection.Input || info.Direction == ParameterDirection.InputOutput)
                {
                    para.Value = info.ParameterValue;
                }

                command.Parameters.Add(para);

            }
            IDbDataParameter returnparameter = command.CreateParameter();
            returnparameter.ParameterName = "RETURN_VALUE";
            returnparameter.DbType = DbType.Decimal;
            returnparameter.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(returnparameter);
            return command;
        }

        public void SetStoreProcedureOutputParametersValue(IDbCommand command)
        {
            foreach (DictionaryEntry de in this.conditionTable)
            {
                StoredProcedureParameterInfo info = (StoredProcedureParameterInfo)de.Value;
                if (info.Direction == ParameterDirection.Output || info.Direction == ParameterDirection.InputOutput)
                {
                    info.ParameterValue = ((OracleParameter)command.Parameters[info.ParameterName]).Value;
                }
            }
        }

        public object GetStoredProcedureOutputValue(string parameterName)
        {
            object value = null;
            foreach (DictionaryEntry de in this.conditionTable)
            {
                StoredProcedureParameterInfo info = (StoredProcedureParameterInfo)de.Value;
                if (parameterName.Equals(info.ParameterName))
                {
                    value = info.ParameterValue;
                    break;
                }
            }
            return value;
        }

    }

    /// <summary>
    /// 查询信息实体类
    /// </summary>
    public class StoredProcedureParameterInfo
    {
        public StoredProcedureParameterInfo() { }


        /// <summary>
        /// 通常为Output参数时使用。
        /// 
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="dbType"></param>
        /// <param name="direction"></param>
        public StoredProcedureParameterInfo(string parameterName, DbType dbType, Int32 size, ParameterDirection direction)
        {
            this.parameterName = parameterName;

            this.dbType = dbType;
            this.direction = direction;
            this.size = size;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">参数名称</param>
        /// <param name="fieldValue">参数的值</param>
        /// <param name="excludeIfEmpty">参数方向 Input Output ReturnValue</param>
        /// <param name="groupName">分组的名称，如需构造一个括号内的条件 ( Test = "AA1" OR Test = "AA2"), 定义一个组名集中条件</param>
        public StoredProcedureParameterInfo(string parameterName, object parameterValue, ParameterDirection direction)
        {
            this.parameterName = parameterName;
            this.parameterValue = parameterValue;
            if (parameterValue != null)
            {
                this.dbType = this.GetParameterDbType(parameterValue);
            }
            //this.size = size;
            this.direction = direction;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">参数名称</param>
        /// <param name="fieldValue">参数的值</param>
        /// <param name="excludeIfEmpty">参数方向 Input Output ReturnValue</param>
        /// <param name="groupName">分组的名称，如需构造一个括号内的条件 ( Test = "AA1" OR Test = "AA2"), 定义一个组名集中条件</param>
        public StoredProcedureParameterInfo(string parameterName, object parameterValue, Int32 size, ParameterDirection direction)
        {
            this.parameterName = parameterName;
            this.parameterValue = parameterValue;
            if (parameterValue != null)
            {
                this.dbType = this.GetParameterDbType(parameterValue);
            }
            this.size = size;
            this.direction = direction;

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">参数名称</param>
        /// <param name="fieldValue">参数的值</param>
        /// <param name="sqlOperator">参数类型</param>
        /// <param name="excludeIfEmpty">参数方向 Input Output ReturnValue</param>
        /// <param name="groupName">分组的名称，如需构造一个括号内的条件 ( Test = "AA1" OR Test = "AA2"), 定义一个组名集中条件</param>
        public StoredProcedureParameterInfo(string parameterName, object parameterValue, DbType dbType, Int32 size, ParameterDirection direction)
        {
            this.parameterName = parameterName;
            this.parameterValue = parameterValue;
            this.dbType = dbType;
            this.direction = direction;
            this.size = size;

        }

        private string parameterName;
        private object parameterValue;
        private DbType dbType;
        private ParameterDirection direction;
        private Int32 size;
        private bool isArray;
        private Int32 arrayLength;





        public string ParameterName
        {
            get { return parameterName; }
            set { parameterName = value; }
        }

        public object ParameterValue
        {
            get { return parameterValue; }
            set { parameterValue = value; }
        }

        public System.Data.DbType DbType
        {
            get { return dbType; }
            set { dbType = value; }
        }

        public System.Data.ParameterDirection Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }



        public bool IsArray
        {
            get { return isArray; }
            set { isArray = value; }
        }

        public int ArrayLength
        {
            get { return arrayLength; }
            set { arrayLength = value; }
        }

        #region 辅助函数
        /// <summary>
        /// 根据传入对象的值类型获取其对应的DbType类型
        /// </summary>
        /// <param name="fieldValue">对象的值</param>
        /// <returns>DbType类型</returns>
        private DbType GetParameterDbType(object parameterValue)
        {
            DbType type = DbType.String;

            switch (parameterValue.GetType().ToString())
            {
                case "System.Int16":
                    type = DbType.Int16;
                    break;
                case "System.UInt16":
                    type = DbType.UInt16;
                    break;
                case "System.Single":
                    type = DbType.Single;
                    break;
                case "System.UInt32":
                    type = DbType.UInt32;
                    break;
                case "System.Int32":
                    type = DbType.Int32;
                    break;
                case "System.UInt64":
                    type = DbType.UInt64;
                    break;
                case "System.Int64":
                    type = DbType.Int64;
                    break;
                case "System.String":
                    type = DbType.String;
                    break;
                case "System.Double":
                    type = DbType.Double;
                    break;
                case "System.Decimal":
                    type = DbType.Decimal;
                    break;
                case "System.Byte":
                    type = DbType.Byte;
                    break;
                case "System.Boolean":
                    type = DbType.Boolean;
                    break;
                case "System.DateTime":
                    type = DbType.DateTime;
                    break;
                case "System.Guid":
                    type = DbType.Guid;
                    break;
                default:
                    break;
            }
            return type;
        }
        #endregion


    }

}
