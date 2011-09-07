using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.ChangeSoft.Common;
using Castle.ActiveRecord;
using Com.ChangeSoft.ERP.Entity;
using NHibernate;
using System.Data.Common;
using Castle.ActiveRecord.Queries;
using System.Data;
using System.Data.SqlClient;

namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public class CClsMsAllDaoOracleImp : ActiveRecordBase, IBaseDao, Com.ChangeSoft.ERP.Entity.Dao.ICClsMsAllDao
    {
        public IList<CClsMsAll> GetClsMsAllList(string iClsCd,string iLanguageCd)
        {
            IList<CClsMsAll> result = new List<CClsMsAll>();

            TransactionScope transaction = new TransactionScope();

            ISession ss = holder.CreateSession(typeof(CClsMsAllDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                SimpleQuery<CClsMsAll> q = new SimpleQuery<CClsMsAll>(typeof(CClsMsAll), @"
                                                                from CClsMsAll where Id.IClsCd=:iClsCd and Id.ILanguageCd=:iLanguageCd");
                q.SetParameter("iClsCd", iClsCd);
                q.SetParameter("iLanguageCd", iLanguageCd);

                //string sql = "select c.* from CClsMsAll c inner join TClsMs t on (t.IClsCd = c.Id.IClsCdwhere) where c.Id.IClsCd=:iClsCd and c.Id.ILanguageCd=:iLanguageCd";

                //SimpleQuery<CClsMsAll> q = new SimpleQuery<CClsMsAll>(typeof(CClsMsAll), sql);

                //q.SetParameter("iClsCd", iClsCd);
                //q.SetParameter("iLanguageCd",iLanguageCd);

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
