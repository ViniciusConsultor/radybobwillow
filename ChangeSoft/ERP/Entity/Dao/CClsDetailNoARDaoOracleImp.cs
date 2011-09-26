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
        #region ICClsDetailNoARDao 成员

        /// <summary>
        /// 根据ClsCd取得DetailList
        /// </summary>
        /// <param name="langId"></param>
        /// <param name="clsCd"></param>
        /// <returns></returns>
        public IList<CClsDetailNoAR> GetClsDetailList(string langId,string clsCd)
        {

            IList<CClsDetailNoAR> result = new List<CClsDetailNoAR>();

            ISession ss = holder.CreateSession(typeof(CClsDetailNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {

                //IList<TClsMs> clsmslist = new List<TClsMs>();
                TClsMs clsms = null;
                //get role by userid
                ScalarQuery<TClsMs> queryclsms = new ScalarQuery<TClsMs>(typeof(TClsMs), @"
                                                from TClsMs where IClsCd=:clsCd");
                queryclsms.SetParameter("clsCd", clsCd);

                clsms = queryclsms.Execute();

                if (clsms==null)
                {
               
                    throw new ApplicationException(MessageUtils.GetMessage("E0001"));
                }

                

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



        public CClsDetailNoAR GetClsDetail(string langId, string clsCd, string detailCd)
        {

            CClsDetailNoAR result = null;

            ISession ss = holder.CreateSession(typeof(CClsDetailNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {

                //IList<TClsMs> clsmslist = new List<TClsMs>();
                TClsMs clsms = null;
                //get role by userid
                ScalarQuery<TClsMs> queryclsms = new ScalarQuery<TClsMs>(typeof(TClsMs), @"
                                                from TClsMs where IClsCd=:clsCd");
                queryclsms.SetParameter("clsCd", clsCd);

                clsms = queryclsms.Execute();

                if (clsms == null)
                {

                    throw new ApplicationException(MessageUtils.GetMessage("E0001"));
                }



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
                    sb.Append(" and d.i_cls_detail_cd=:detailCd");
                }
                else if ("2".Equals(clsms.IClsCls))
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
                    sb.Append(" and d.i_name_cd=:detailCd");

                }


                ISQLQuery querydetail = ss.CreateSQLQuery(sb.ToString());
                querydetail.AddScalar("iClsCd", NHibernateUtil.String);
                querydetail.AddScalar("iLanguageCd", NHibernateUtil.String);
                querydetail.AddScalar("iClsDetailCd", NHibernateUtil.String);
                querydetail.AddScalar("iClsDetailDesc", NHibernateUtil.String);
                querydetail.AddScalar("iInqItem", NHibernateUtil.String);
                querydetail.AddScalar("iClsNameDesc", NHibernateUtil.String);


                querydetail.SetParameter("langId", langId);
                querydetail.SetParameter("clsCd", clsms.IClsCd);
                querydetail.SetParameter("detailCd", detailCd);

                IList<CClsDetailNoAR> temp = querydetail.SetResultTransformer(Transformers.AliasToBean<CClsDetailNoAR>()).List<CClsDetailNoAR>();

                if (temp.Count > 0)
                {
                    result = temp[0];
                } 

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

        #endregion
    }
}
