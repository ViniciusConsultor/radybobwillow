using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using NHibernate;
using System.Data.Common;
using Castle.ActiveRecord.Queries;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public class TestDaoOracleImp : ActiveRecordBase, Com.GainWinSoft.ERP.Entity.Dao.ITestDao,Com.GainWinSoft.Common.IBaseDao
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

        public Test[] GetAll(int uid)
        {
            SimpleQuery<Test> q = new SimpleQuery<Test>(typeof(Test), @"
                                from Test where Userid= ?", uid);
            return q.Execute();

        }
    }
}
