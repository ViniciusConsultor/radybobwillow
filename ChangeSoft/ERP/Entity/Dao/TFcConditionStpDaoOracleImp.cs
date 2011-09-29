using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Com.GainWinSoft.Common;
using NHibernate;
using Castle.ActiveRecord.Queries;
using System.Data.Common;
using NHibernate.Transform;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    class TFcConditionStpDaoOracleImp : ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ITFcConditionStpDao
    {
        public Boolean Insert(TFcConditionStp facStpVo)
        {
            Boolean rtnVal = false;

            ISession ss = holder.CreateSession(typeof(TFcConditionStpDaoOracleImp));

            ITransaction tran = ss.BeginTransaction();
            try
            {
                facStpVo.CreateAndFlush();
                tran.Commit();
                rtnVal = true;
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

            return rtnVal;
        }
    }
}
