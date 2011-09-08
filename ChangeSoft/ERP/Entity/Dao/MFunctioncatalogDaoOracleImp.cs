using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Com.GainWinSoft.Common;
using System.Collections;
using Castle.ActiveRecord.Queries;
using NHibernate;
using System.Data.Common;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public class MFunctioncatalogDaoOracleImp :ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.IMFunctioncatalogDao{
        public IList<MFunctioncatalog> GetFunctionCatalogList(String langid)
        {
            IList<MFunctioncatalog> result = new List<MFunctioncatalog>();

            TransactionScope transaction = new TransactionScope();

            ISession ss = holder.CreateSession(typeof(MFunctioncatalogDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                SimpleQuery<MFunctioncatalog> q = new SimpleQuery<MFunctioncatalog>(typeof(MFunctioncatalog), @"
                                                from MFunctioncatalog where Id.Langid=?", langid);
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
