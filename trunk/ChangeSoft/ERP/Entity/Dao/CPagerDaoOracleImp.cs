using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using System.Data;
using NHibernate;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public class CPagerDaoOracleImp:ActiveRecordBase, Com.ChangeSoft.ERP.Entity.Dao.ICPagerDao
    {
        public DataSet GetDataSet(string tablename,string sql,IList<SqlParameter> paralist,int pagesize,int pageindex)
        {

            TransactionScope transaction = new TransactionScope();
            DataSet ds = new DataSet();

            ISession ss = holder.CreateSession(typeof(CPagerDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                IDbCommand command = ss.Connection.CreateCommand();


                command.CommandText = @"SELECT * FROM (" + sql + ")";
                foreach (SqlParameter para in paralist)
                {
                    command.Parameters.Add((OracleParameter)para);
                }

                command.CommandType = CommandType.Text;

                
                tran.Enlist(command);
                IDataReader rdr = command.ExecuteReader();
                command.Dispose();
                DataTable dt = new DataTable();
                dt.TableName = tablename;
                dt.Load(rdr, LoadOption.Upsert);

                ds.Tables.Add(dt);
                transaction.VoteCommit();
            }
            catch (Castle.ActiveRecord.Framework.ActiveRecordException ex)
            {
                transaction.VoteRollBack();
                throw new ApplicationException(ex.Message, ex);
            }
            catch (DbException ex)
            {
                transaction.VoteRollBack();
                throw new ApplicationException(ex.Message, ex);
            }
            finally
            {
                transaction.Dispose();
            }

            return ds;

        }
        public int GetCount(string tablename, string sql, IList<SqlParameter> paralist)
        {

            TransactionScope transaction = new TransactionScope();
            int intCount = 0;

            ISession ss = holder.CreateSession(typeof(CPagerDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                IDbCommand command = ss.Connection.CreateCommand();

                //                command.CommandText = @"select LANGID,FUNCTIONID,FUNCTIONNAME,
                //                                        FUNCTIONPATH,CATALOGID,FUNCTIONINDEX,FUNCTIONIMAGE 
                //                                        FROM M_FUNCTION WHERE 1=1 ";
                command.CommandText = @"SELECT COUNT(*) FROM (" + sql + ")";
                
                foreach (SqlParameter para in paralist)
                {
                    command.Parameters.Add((OracleParameter)para);
                }

                command.CommandType = CommandType.Text;


                tran.Enlist(command);

                intCount = (int)command.ExecuteScalar();

                transaction.VoteCommit();
            }
            catch (Castle.ActiveRecord.Framework.ActiveRecordException ex)
            {
                transaction.VoteRollBack();
                throw new ApplicationException(ex.Message, ex);
            }
            catch (DbException ex)
            {
                transaction.VoteRollBack();
                throw new ApplicationException(ex.Message, ex);
            }
            finally
            {
                transaction.Dispose();
            }

            return intCount;

        }
    }
}
