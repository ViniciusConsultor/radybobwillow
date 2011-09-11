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

            ISession ss = holder.CreateSession(typeof(Test));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                Test t = new Test();

                t.Userid = 13;
                t.Username = "fff";
                t.Loginid = "fff";
                t.CreateAndFlush();
                tran.Commit();
                //SessionScope.Current.Flush();
            }
            catch (Castle.ActiveRecord.Framework.ActiveRecordException ex)
            {
                tran.Rollback();
                throw new ApplicationException(ex.Message,ex);
            }
            catch (DbException ex)
            {
                tran.Rollback();
                throw new ApplicationException(ex.Message,ex);
            }
            finally
            {
                tran.Dispose();
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
