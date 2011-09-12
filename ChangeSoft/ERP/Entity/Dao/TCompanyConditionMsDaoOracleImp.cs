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
    class TCompanyConditionMsDaoOracleImp:ActiveRecordBase,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ITCompanyConditionMsDao
    {
        public TCompanyConditionMs getCompanyCondition(string companyCd)
        {
            TCompanyConditionMs companyconditionms = null;

            ISession ss = holder.CreateSession(typeof(TPersonMsDaoOracleImp));

            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                ScalarQuery<TCompanyConditionMs> q = new ScalarQuery<TCompanyConditionMs>(typeof(TCompanyConditionMs), @"
                                                from TCompanyConditionMs where ICompanyCd=:ICompanyCd");
                q.SetParameter("ICompanyCd", companyCd);
                companyconditionms = q.Execute();
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



            return companyconditionms;
        }
    }
}
