using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Com.GainWinSoft.Common;
using System.Data.Common;
using NHibernate;
using Castle.ActiveRecord.Queries;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    class TTradeMsDaoOracleImp:ActiveRecordBase,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ITTradeMsDao
    {
        public TTradeMs getTradeByCd(string companyCd,string dlCd)
        {
            TTradeMs tradems= null;

            ISession ss = holder.CreateSession(typeof(TTradeMsDaoOracleImp));

            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("from TTradeMs where Id.ICompanyCd=:ICompanyCd");
                sb.AppendLine(" and Id.IDlCd=:IDlCd");
                ScalarQuery<TTradeMs> q = new ScalarQuery<TTradeMs>(typeof(TTradeMs), sb.ToString());


                q.SetParameter("ICompanyCd", companyCd);
                q.SetParameter("IDlCd", dlCd);
                tradems = q.Execute();
                //FindByPrimaryKey找不到数据的时候是抛出ActiveRecordException，不太好处理
                //termms = (TTermMs)FindByPrimaryKey(typeof(TTermMs), userid);

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



            return tradems;
        }
    }
}
