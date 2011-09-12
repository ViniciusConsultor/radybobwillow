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
    class TPersonMsDaoOracleImp:ActiveRecordBase,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ITPersonMsDao
    {
        public TPersonMs getPersonByUserId(string userId)
        {
            TPersonMs person = null;

            ISession ss = holder.CreateSession(typeof(TPersonMsDaoOracleImp));

            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                ScalarQuery<TPersonMs> q = new ScalarQuery<TPersonMs>(typeof(TPersonMs), @"
                                                from TPersonMs where IUserId=:IUserId");
                q.SetParameter("IUserId", userId);
                person = q.Execute();
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
            }



            return person;
        }
    }
}
