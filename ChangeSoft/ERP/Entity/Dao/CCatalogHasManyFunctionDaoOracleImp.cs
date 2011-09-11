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
    public class CCatalogHasManyFunctionDaoOracleImp : CCatalogHasManyFunction,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICCatalogHasManyFunctionDao
    {
        public IList<CCatalogHasManyFunction> GetFunctionAllList(String langid)
        {
            IList<CCatalogHasManyFunction> result = new List<CCatalogHasManyFunction>();


            ISession ss = holder.CreateSession(typeof(CCatalogHasManyFunctionDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                SimpleQuery<CCatalogHasManyFunction> q = new SimpleQuery<CCatalogHasManyFunction>(typeof(CCatalogHasManyFunction), @"
                                                from CCatalogHasManyFunction where Id.Langid=? Order by Id.Catalogid", langid);
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

            return result;

        }
  
    }
}
