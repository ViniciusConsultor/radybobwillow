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
    public class CClsDetailBelongToClsMsDaoOracleImp : ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICClsDetailBelongToClsMsDao
    {
        public IList<CClsDetailBelongToClsMs> GetClsMsAllList(string iClsCd,string iLanguageCd)
        {
            IList<CClsDetailBelongToClsMs> result = new List<CClsDetailBelongToClsMs>();

            TransactionScope transaction = new TransactionScope();

            ISession ss = holder.CreateSession(typeof(CClsDetailBelongToClsMsDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                SimpleQuery<CClsDetailBelongToClsMs> q = new SimpleQuery<CClsDetailBelongToClsMs>(typeof(CClsDetailBelongToClsMs), @"
                                                                from CClsDetailBelongToClsMs where Id.IClsCd=:iClsCd and Id.ILanguageCd=:iLanguageCd");
                q.SetParameter("iClsCd", iClsCd);
                q.SetParameter("iLanguageCd", iLanguageCd);

                //string sql = "select c.* from CClsDetailBelongToClsMs c inner join TClsMs t on (t.IClsCd = c.Id.IClsCdwhere) where c.Id.IClsCd=:iClsCd and c.Id.ILanguageCd=:iLanguageCd";

                //SimpleQuery<CClsDetailBelongToClsMs> q = new SimpleQuery<CClsDetailBelongToClsMs>(typeof(CClsDetailBelongToClsMs), sql);

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
