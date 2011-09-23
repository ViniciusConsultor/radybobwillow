using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Com.GainWinSoft.Common;
using NHibernate;
using Castle.ActiveRecord.Queries;
using System.Data.Common;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    class TTermMsDaoOracleImp:ActiveRecordBase,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ITTermMsDao
    {
        public TTermMs getTermbyUserId(string userid)
        {
            TTermMs termms = null;

            ISession ss = holder.CreateSession(typeof(TTermMsDaoOracleImp));

            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                ScalarQuery<TTermMs> q = new ScalarQuery<TTermMs>(typeof(TTermMs), @"
                                                from TTermMs where IUserId=:userId");
                q.SetParameter("userId", userid);
                termms = q.Execute();
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



            return termms;
        }
    }
}
