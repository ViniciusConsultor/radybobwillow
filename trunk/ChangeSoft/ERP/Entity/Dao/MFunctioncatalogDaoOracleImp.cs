using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Com.ChangeSoft.Common;
using System.Collections;
using Castle.ActiveRecord.Queries;

namespace Com.ChangeSoft.ERP.Entity.Dao
{
    class MFunctioncatalogDaoOracleImp :Com.ChangeSoft.ERP.Entity.MFunctioncatalog    , IBaseDao, Com.ChangeSoft.ERP.Entity.Dao.IMFunctioncatalogDao{
        public IList<MFunctioncatalog> GetFunctionCatalogList(String langid)
        {
            IList<MFunctioncatalog> result = new List<MFunctioncatalog>();

            //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
            SimpleQuery<MFunctioncatalog> q = new SimpleQuery<MFunctioncatalog>(typeof(MFunctioncatalog), @"
                                from MFunctioncatalog where Id.Langid=?", langid);
            result = q.Execute();

            

            //                       string query = @"
            //select  from MFunctioncatalog
            //from word, synonym
            //where 
            //    synonym.word = word.id and
            //    word.key = :key";

            //            result =  (IList<MFunctioncatalog>) ActiveRecordMediator<MFunctioncatalog>.Execute(
            //                delegate(ISession session, object instance)
            //                {
            //                    return session.CreateSQLQuery(query, "synonym", typeof(MFunctioncatalog))
            //                        .SetParameter("key", langid)
            //                        .SetMaxResult(10)
            //                        .List<MFunctioncatalog>();
            //                }, new MFunctioncatalog());

            return result;

        }
    }
}
