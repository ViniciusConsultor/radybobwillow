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
    class TFactoryMsDaoOracleImp:ActiveRecordBase,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ITFactoryMsDao
    {
        public TFactoryMs getFactoryByCd(string facCd)
        {
            TFactoryMs factory = null;

            ISession ss = holder.CreateSession(typeof(TFactoryMsDaoOracleImp));

            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                ScalarQuery<TFactoryMs> q = new ScalarQuery<TFactoryMs>(typeof(TFactoryMs), @"
                                                from TFactoryMs where IFacCd=:IFacCd");
                q.SetParameter("IFacCd", facCd);
                factory = q.Execute();
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



            return factory;
        }
    }
}
