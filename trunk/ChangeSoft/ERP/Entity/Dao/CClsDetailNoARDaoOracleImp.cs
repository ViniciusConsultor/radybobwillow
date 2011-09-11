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
    class CClsDetailNoARDaoOracleImp:ActiveRecordBase,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICClsDetailNoARDao
    {
        public IList<CClsDetailNoAR> GetClsDetail(string langId,string clsCd)
        {

            TransactionScope transaction = new TransactionScope();
            IList<CClsDetailNoAR> result = new List<CClsDetailNoAR>();

            ISession ss = holder.CreateSession(typeof(CClsDetailNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {

                IList<TClsMs> clsmslist = new List<TClsMs>();
                //get role by userid
                SimpleQuery<TClsMs> queryclsms = new SimpleQuery<TClsMs>(typeof(TClsMs), @"
                                                from TClsMs where IClsCd=:clsCd");
                queryclsms.SetParameter("clsCd", clsCd);

                clsmslist = queryclsms.Execute();

                if (clsmslist.Count <= 0)
                {
               
                    throw new ApplicationException(MessageUtils.GetMessage("E0001"));
                }

                TClsMs clsms = clsmslist[0];

                StringBuilder sb = new StringBuilder();
                //select f.catalogid,f.functionid,f.functionimage,f.functionindex,f.functionname,f.functionpath,f.langid,c.catalogimage,c.catalogname from (M_FUNCTION f inner join (select functionid from m_role_function 
                //where roleid=1 group by functionid) r on (f.functionid=r.functionid)) left join
                //m_functioncatalog c on (f.catalogid=c.catalogid and f.langid=c.langid)
                //where f.langid='zh-CN'
                //order by f.catalogid,f.functionindex

                if ("1".Equals(clsms.IClsCls))
                {
                    sb.Append(" select d.i_cls_cd as iClsCd,");
                    sb.Append(" d.i_language_cd as iLanguageCd,");
                    sb.Append(" d.i_cls_detail_cd as iClsDetailCd,");
                    sb.Append(" d.i_cls_detail_desc as iClsDetailDesc,");
                    sb.Append(" d.i_inq_item as iInqItem,");
                    sb.Append(" '' as iClsNameDesc");
                    sb.Append(" from t_cls_detail_ms d");
                    sb.Append(" where d.i_cls_cd=:clsCd");
                    sb.Append(" and d.i_language_cd=:langId");
                }
                else if("2".Equals(clsms.IClsCls))
                {
                    sb.Append(" select d.i_cls_cd as iClsCd ,");
                    sb.Append(" d.i_language_cd as iLanguageCd ,");
                    sb.Append(" d.i_name_cd as iClsDetailCd,");
                    sb.Append(" d.i_name_desc as iClsDetailDesc,");
                    sb.Append(" d.i_inq_item as iInqItem,");
                    sb.Append(" d.i_name_kana as iClsNameDesc");
                    sb.Append(" from t_desc_ms d");
                    sb.Append(" where d.i_cls_cd=:clsCd");
                    sb.Append(" and d.i_language_cd=:langId");

                }


                ISQLQuery querycatalogfunction = ss.CreateSQLQuery(sb.ToString());
                querycatalogfunction.AddScalar("iClsCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iLanguageCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iClsDetailCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iClsDetailDesc", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iInqItem", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iClsNameDesc", NHibernateUtil.String);


                querycatalogfunction.SetParameter("langId", langId);
                querycatalogfunction.SetParameter("clsCd", clsms.IClsCd);

                result = querycatalogfunction.SetResultTransformer(Transformers.AliasToBean<CClsDetailNoAR>()).List<CClsDetailNoAR>();


                transaction.VoteCommit();
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
