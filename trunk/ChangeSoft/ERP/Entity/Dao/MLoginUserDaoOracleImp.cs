﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Com.GainWinSoft.Common;
using System.Collections;
using Castle.ActiveRecord.Queries;
using NHibernate;
using System.Data.Common;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public class MLoginUserDaoOracleImp :ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.IMLoginUserDao{
        public IList<MLoginUser> GetLoginUserInfo(string userid, string password)
        {
            IList<MLoginUser> result = new List<MLoginUser>();

            TransactionScope transaction = new TransactionScope();

            ISession ss = holder.CreateSession(typeof(MLoginUserDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                SimpleQuery<MLoginUser> q = new SimpleQuery<MLoginUser>(typeof(MLoginUser), @"
                                                from MLoginUser where Userid=:userid and Password=:password");
                q.SetParameter("userid", userid);
                q.SetParameter("password", password);
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