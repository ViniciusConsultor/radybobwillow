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
using Com.GainWinSoft.Common;
using System.Collections;
using NHibernate.Transform;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public class CFunctionPagerNoARDaoOracleImp : ActiveRecordBase, IBaseDao,  Com.GainWinSoft.ERP.Entity.Dao.ICPagerDao
    {
        public DataSet GetDataSet(string tablename,SearchCondition condition,int pagesize,int pageindex)
        {

            DataSet ds = new DataSet();
            IList<CFunctionPagerNoAR> result = new List<CFunctionPagerNoAR>();

            ISession ss = holder.CreateSession(typeof(CFunctionPagerNoARDaoOracleImp));
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
                sb.Append("select b.LANGID grid_langid,");
                sb.Append("b.FUNCTIONID grid_functionid,");
                sb.Append("b.FUNCTIONNAME grid_functionname,");
                sb.Append("b.FUNCTIONPATH grid_functionpath,");
                sb.Append("b.CATALOGID grid_catalogid,");
                sb.Append("b.FUNCTIONINDEX grid_functionindex,");
                sb.Append("b.FUNCTIONIMAGE grid_functionimage");
                sb.Append(" from (select a.*, rownum as rowIndex from (");
                sb.Append("select * from M_FUNCTION ");
                sb.Append(condition.BuildParameterConditionSql(true));
                sb.Append(" order by catalogid,functionid,functionindex ");
                sb.Append(" ) a");
                sb.Append(" ) b");
                sb.Append(" where b.rowIndex >" + pageindex * pagesize);
                sb.Append(" and b.rowIndex <=" + (pageindex * pagesize + pagesize));




                string query = sb.ToString();
                                          

                ISQLQuery q = ss.CreateSQLQuery(query);
                q.AddScalar("grid_langid", NHibernateUtil.String);
                q.AddScalar("grid_functionid", NHibernateUtil.Int32);
                q.AddScalar("grid_functionname", NHibernateUtil.String);
                q.AddScalar("grid_functionpath", NHibernateUtil.String);
                q.AddScalar("grid_catalogid", NHibernateUtil.Int32);
                q.AddScalar("grid_functionindex", NHibernateUtil.Int32);
                q.AddScalar("grid_functionimage", NHibernateUtil.String);

                foreach (DictionaryEntry de in condition.ConditionTable)
                {
                    SearchInfo searchInfo = (SearchInfo)de.Value;
                    q.SetParameter(string.Format("{0}",searchInfo.FieldName), searchInfo.FieldValue);
                }

                result = q.SetResultTransformer(Transformers.AliasToBean<CFunctionPagerNoAR>()).List<CFunctionPagerNoAR>();
                
                
                //转换成datatable
                DataTable dt = DataTableUtils.ToDataTable(result);
                dt.TableName = tablename;
                ds.Tables.Add(dt);

                
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
            }

            return ds;

        }
        public int GetCount(string key, SearchCondition condition)
        {

            int intCount = 0;

            ISession ss = holder.CreateSession(typeof(CFunctionPagerNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                string query = @"select count(FUNCTIONID) as CNT from M_FUNCTION
                                        "+condition.BuildParameterConditionSql(true);
                ISQLQuery q= ss.CreateSQLQuery(query);
                q.AddScalar("CNT", NHibernateUtil.Int32);
                foreach (DictionaryEntry de in condition.ConditionTable)
                {
                    SearchInfo searchInfo = (SearchInfo)de.Value;
                    q.SetParameter(string.Format("{0}", searchInfo.FieldName), searchInfo.FieldValue);
                }

                intCount = (int)q.UniqueResult();
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
            }

            return intCount;

        }
    }
}
