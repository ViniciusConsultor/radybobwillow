using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.GainWinSoft.Common;
using Castle.ActiveRecord;
using Com.GainWinSoft.ERP.Entity;
using NHibernate;
using System.Data.Common;
using Castle.ActiveRecord.Queries;
using System.Data;
using System.Data.SqlClient;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public class CFunctionAllDaoOracleImp : CFunctionAll,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICFunctionAllDao
    {
        public IList<CFunctionAll> GetFunctionAllList(String langid)
        {
            IList<CFunctionAll> result = new List<CFunctionAll>();

            TransactionScope transaction = new TransactionScope();

            ISession ss = holder.CreateSession(typeof(CFunctionAllDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                SimpleQuery<CFunctionAll> q = new SimpleQuery<CFunctionAll>(typeof(CFunctionAll), @"
                                                from CFunctionAll where Id.Langid=? Order by Id.Catalogid", langid);
                result = q.Execute();
                //                string query = @"
                //                        select LANGID,CATALOGID,CATALOGNAME from M_FUNCTIONCATALOG
                //                        where 
                //                            LANGID = :key";
                //                result = ss.CreateSQLQuery(query)
                //                            .AddEntity(typeof(MFunctioncatalog))
                //                            .SetParameter("key", langid)
                //                            .List<MFunctioncatalog>();


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

            return result;

        }
  
    }
}
