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
using Castle.ActiveRecord.Queries;
using Com.ChangeSoft.Common;
using System.Collections;
using NHibernate.Transform;

namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public class CFunctionAllPagerDaoOracleImp:ActiveRecordBase, Com.ChangeSoft.ERP.Entity.Dao.ICPagerDao
    {
        public DataSet GetDataSet(string key,SearchCondition condition,int pagesize,int pageindex)
        {

            TransactionScope transaction = new TransactionScope();
            DataSet ds = new DataSet();
            IList<CFunctionPager> result =new List<CFunctionPager>();

            ISession ss = holder.CreateSession(typeof(CFunctionAllPagerDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                //IDbCommand command = ss.Connection.CreateCommand();


                //command.CommandText = @"SELECT * FROM (" + sql + ")";
                //foreach (SqlParameter para in paralist)
                //{
                //    OracleParameter op = new OracleParameter(para.ParameterName, para.Value);
                //    command.Parameters.Add((OracleParameter)op);
                //}

                //command.CommandType = CommandType.Text;

                
                //tran.Enlist(command);
                //IDataReader rdr = command.ExecuteReader();
                //command.Dispose();
                //DataTable dt = new DataTable();
                //dt.TableName = tablename;
                //dt.Load(rdr, LoadOption.Upsert);

                //ds.Tables.Add(dt);
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                //select b.* from
               //(select a.*, rownum as rowIndex from(select * from M_FUNCTION Where (1=1)  AND LANGID  =  'zh-CN') a) b
               //where b.rowIndex > 5 and b.rowIndex <= 10
                StringBuilder sb = new StringBuilder();
                sb.Append("select b.* from (select a.*, rownum as rowIndex from (");
                sb.Append("select * from M_FUNCTION ");
                sb.Append(condition.BuildParameterConditionSql());
                sb.Append(" order by catalogid,functionid,functionindex ");
                sb.Append(" ) a");
                sb.Append(" ) b");
                sb.Append(" where b.rowIndex >" + pageindex * pagesize);
                sb.Append(" and b.rowIndex <=" + (pageindex * pagesize + pagesize));




                string query = sb.ToString();
                                          

                ISQLQuery q = ss.CreateSQLQuery(query);
                q.AddScalar("langid", NHibernateUtil.String);
                q.AddScalar("functionid", NHibernateUtil.Int32);
                q.AddScalar("functionname", NHibernateUtil.String);
                q.AddScalar("functionpath", NHibernateUtil.String);
                q.AddScalar("catalogid", NHibernateUtil.Int32);
                q.AddScalar("functionindex", NHibernateUtil.Int32);
                q.AddScalar("functionimage", NHibernateUtil.String);

                foreach (DictionaryEntry de in condition.ConditionTable)
                {
                    SearchInfo searchInfo = (SearchInfo)de.Value;
                    q.SetParameter(string.Format("{0}",searchInfo.FieldName), searchInfo.FieldValue);
                }

                result = q.SetResultTransformer(Transformers.AliasToBean<CFunctionPager>()).List<CFunctionPager>();
                
                
                //转换成datatable
                DataTable dt = DataTableUtils.ToDataTable(result);
                dt.TableName = key;
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
        public int GetCount(string key, SearchCondition condition)
        {

            TransactionScope transaction = new TransactionScope();
            int intCount = 0;

            ISession ss = holder.CreateSession(typeof(CFunctionAllPagerDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                string query = @"select count(FUNCTIONID) as CNT from M_FUNCTION
                                        "+condition.BuildParameterConditionSql();
                ISQLQuery q= ss.CreateSQLQuery(query);
                q.AddScalar("CNT", NHibernateUtil.Int32);
                foreach (DictionaryEntry de in condition.ConditionTable)
                {
                    SearchInfo searchInfo = (SearchInfo)de.Value;
                    q.SetParameter(string.Format("{0}", searchInfo.FieldName), searchInfo.FieldValue);
                }

                intCount = (int)q.UniqueResult();
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
