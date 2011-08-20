using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using NHibernate;
using System.Data.Common;

namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public class TestDaoOracleImp : ActiveRecordBase, Com.ChangeSoft.ERP.Entity.Dao.ITestDao,Com.ChangeSoft.Common.IBaseDao
    {

        public int Count()
        {
            int re = 0;
            TransactionScope transaction = new TransactionScope();

            ISession ss = holder.CreateSession(typeof(Test));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                Test t = new Test();

                t.Userid = 13;
                t.Username = "fff";
                t.Loginid = "fff";
                t.CreateAndFlush();
                transaction.VoteCommit();
                //SessionScope.Current.Flush();
            }
            catch (Castle.ActiveRecord.Framework.ActiveRecordException ex)
            {
                transaction.VoteRollBack();
                throw new ApplicationException(ex.Message,ex);
            }
            catch (DbException ex)
            {
                transaction.VoteRollBack();
                throw new ApplicationException(ex.Message,ex);
            }
            finally
            {
                transaction.Dispose();
            }
            re = ActiveRecordBase.Count(typeof(Test));


            return re;

        }
    }
}
