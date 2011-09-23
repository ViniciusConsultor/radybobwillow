using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using NHibernate;
using NHibernate.Transform;
using Com.GainWinSoft.Common;
using System.Data.Common;
using Castle.ActiveRecord.Queries;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    class CCatalogFunctionNoARDaoOracleImp:ActiveRecordBase,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICCatalogFunctionNoARDao
    {
        public IList<CCatalogFunctionNoAR> GetCatalogFunctionByUserId(string langid,string userid)
        {

            IList<CCatalogFunctionNoAR> result = new List<CCatalogFunctionNoAR>();

            ISession ss = holder.CreateSession(typeof(CCatalogFunctionNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {

                IList<MRoleUser> mroleuserlist = new List<MRoleUser>();
                //get role by userid
                SimpleQuery<MRoleUser> queryroleuser = new SimpleQuery<MRoleUser>(typeof(MRoleUser), @"
                                                from MRoleUser where Id.Userid=:userid");
                queryroleuser.SetParameter("userid", userid);

                mroleuserlist = queryroleuser.Execute();

                if (mroleuserlist.Count <= 0){
               
                    throw new ApplicationException(MessageUtils.GetMessage("E0001"));
                }

                StringBuilder sb = new StringBuilder();
                //select f.catalogid,f.functionid,f.functionimage,f.functionindex,f.functionname,f.functionpath,f.langid,c.catalogimage,c.catalogname from (M_FUNCTION f inner join (select functionid from m_role_function 
                //where roleid=1 group by functionid) r on (f.functionid=r.functionid)) left join
                //m_functioncatalog c on (f.catalogid=c.catalogid and f.langid=c.langid)
                //where f.langid='zh-CN'
                //order by f.catalogid,f.functionindex
                sb.Append(" select f.catalogid,");
                sb.Append(" f.functionid,");
                sb.Append(" f.functionimage,");
                sb.Append(" f.functionindex,");
                sb.Append(" f.functionname,");
                sb.Append(" f.functionpath,");
                sb.Append(" f.langid,");
                sb.Append(" c.catalogimage,");
                sb.Append(" c.catalogname ");
                sb.Append(" from (m_function f ");
                sb.Append(" inner join ");
                sb.Append(" (select functionid from m_role_function ");
                sb.Append(" where ");
                int cnt = 0;
                foreach (MRoleUser mroleuservo in mroleuserlist)
                {
                    if (cnt == 0)
                    {
                        sb.Append("roleid = :roleid" + cnt);
                    }
                    else
                    {
                        sb.Append("or roleid = :roleid" + cnt);
                    }
                    cnt++;
                }

                sb.Append(" group by functionid) r ");
                sb.Append(" on (f.functionid=r.functionid)) ");
                sb.Append(" left join");
                sb.Append(" m_functioncatalog c ");
                sb.Append(" on (f.catalogid=c.catalogid and f.langid=c.langid)");
                sb.Append(" where f.langid=:langid");
                sb.Append(" order by f.catalogid,f.functionindex");


                ISQLQuery querycatalogfunction = ss.CreateSQLQuery(sb.ToString());
                querycatalogfunction.AddScalar("langid", NHibernateUtil.String);
                querycatalogfunction.AddScalar("functionid", NHibernateUtil.Int32);
                querycatalogfunction.AddScalar("functionname", NHibernateUtil.String);
                querycatalogfunction.AddScalar("functionpath", NHibernateUtil.String);
                querycatalogfunction.AddScalar("catalogid", NHibernateUtil.Int32);
                querycatalogfunction.AddScalar("functionindex", NHibernateUtil.Int32);
                querycatalogfunction.AddScalar("functionimage", NHibernateUtil.String);
                querycatalogfunction.AddScalar("catalogimage", NHibernateUtil.String);
                querycatalogfunction.AddScalar("catalogname", NHibernateUtil.String);

                cnt = 0;
                foreach (MRoleUser mroleuservo in mroleuserlist)
                {
                    querycatalogfunction.SetParameter("roleid" + cnt, mroleuservo.Id.Roleid);
                    cnt++;
                }
                querycatalogfunction.SetParameter("langid", langid);

                result = querycatalogfunction.SetResultTransformer(Transformers.AliasToBean<CCatalogFunctionNoAR>()).List<CCatalogFunctionNoAR>();


                tran.Commit();
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

            return result;

        }
    }
}
