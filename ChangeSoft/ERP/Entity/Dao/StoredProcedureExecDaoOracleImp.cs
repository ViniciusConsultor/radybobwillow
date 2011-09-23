using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord;
using NHibernate;
using NHibernate.Cfg;
using System.Data.Common;
using System.Data;
using Oracle.DataAccess.Client;
using Com.GainWinSoft.Common;


namespace Com.GainWinSoft.ERP.Entity.Dao
{

    public class StoredProcedureExecDaoOracleImp : ActiveRecordBase, Com.GainWinSoft.ERP.Entity.Dao.IStoredProcedureExecDao
    {

        public decimal StoredProcedureExecReturnNumber(string procedureName,StoredProcedureCondition parameters)
        {
            ISession ss = holder.CreateSession(typeof(StoredProcedureExecDaoOracleImp));
            decimal returnvalue = 0;

            ITransaction tran = ss.BeginTransaction();
            try
            {

                IDbConnection c = ss.Connection;

                IDbCommand command = ss.Connection.CreateCommand();
                ((OracleCommand)command).BindByName = true;//用名称参数必须为true，要不oracle以参数数组的下标来设置参数了

                tran.Enlist(command);//注意此处要把command添加到事务中

                command.CommandType = CommandType.StoredProcedure;

                string sql = procedureName;
                //把参数传递给command
                parameters.SetStoredProcedureParametersWithRetrunNumber(command);


                command.CommandText = sql;

                command.ExecuteNonQuery();


                returnvalue = (decimal)((OracleParameter)command.Parameters["RETURN_VALUE"]).Value;

                parameters.SetStoreProcedureOutputParametersValue(command);


                tran.Commit();

            }
            catch (Castle.ActiveRecord.Framework.ActiveRecordException ex)
            {
                tran.Rollback();
                throw new ApplicationException(ex.Message, ex);
            }
            catch (DbException ex)
            {
                tran.Rollback();
                throw new ApplicationException(ex.Message, ex);
            }
            finally
            {
                tran.Dispose();
                holder.ReleaseSession(ss);
            }
            return returnvalue;
        }




        #region 另外一种方法，没有成功
        //
//        /// <summary>
//        /// 使用存储过程填充实体类,邹健,2008 1 24
//        /// </summary>
//        /// <typeparam name="T">实体类</typeparam>
//        /// <param name="spname">存储过程名</param>
//        /// <param name="idict">参数字典</param>
//        /// <returns>一个实体类Ilist</returns>
//        public static IList<T> GetList<T>(string spname, IDictionary<String, Object> idict)
//        {
//            Type type = typeof(T);
//            //Chsword.DoDataBase d = new Chsword.DoDataBase();
//            StringBuilder sp = new StringBuilder();
//            foreach (string key in idict.Keys)
//            {
//                sp.AppendFormat(":{0},", key);
//            }
//            if (sp.Length != 0)
//                sp.Length--;
//            string map = String.Format(@"<sql-query name='{0}'>
//                <return class='{1}'/>
//                exec {0} {2}
//                </sql-query>",
//             spname,
//             type.Name,
//             sp.ToString()
//             );
//
//
//
//            StoredProcedureExecOracleImp.CreateQueryMapping(type, map);//创建一个SQL-Query
//            //ISessionFactoryHolder holder = ActiveRecordMediator.GetSessionFactoryHolder();
//
//            ISession session = holder.CreateSession(type);
//            IQuery query = session.GetNamedQuery(spname);
//
//            foreach (string key in idict.Keys)
//            {
//                query = query.SetParameter(key, idict[key]);
//            }
//            return query.List<T>();
//        }
//        /// <summary>
//        /// 创建一个Sql-Query
//        /// </summary>
//        /// <param name="type">类型,做为Key</param>
//        /// <param name="xml">Sql-Query结点</param>
//        public static void CreateQueryMapping(Type type, string xml) {
//            //ISessionFactoryHolder holder = ActiveRecordMediator.GetSessionFactoryHolder();
//            Configuration config = holder.GetConfiguration(holder.GetRootType(type));
//
//            //    xml = ;
//            config.AddXmlString(
//                string.Format("<hibernate-mapping xmlns='{0}' assembly='{1}' namespace='{2}'>{3}</hibernate-mapping>",
//                                "urn:nhibernate-configuration-2.2",
//                             type.Assembly.FullName,
//                             type.Namespace,//命名空间
//                             xml//内容即<Sql-Query />
//                        )
//                    );
//            //return config.NamedSQLQueries.Count.ToString();
        //        }
        #endregion
    }
}
