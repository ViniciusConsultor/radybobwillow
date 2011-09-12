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

        public IList<TFactoryMs> getAllFactoryByCdNm(string companyCd, string facCd, string facNm)
        {
            IList<TFactoryMs> result = new List<TFactoryMs>();
            ISession ss = holder.CreateSession(typeof(TFactoryMsDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(" SELECT ");
                sb.Append("      I_FAC_CD AS iFacCd ");
                sb.Append("     ,I_COMPANY_CD AS iCompanyCd ");
                sb.Append("     ,I_BASE_CD AS iBaseCd ");
                sb.Append("     ,I_COUNTRY_CD AS iCountryCd ");
                sb.Append("     ,I_TIMEZONE_CD AS iTimezoneCd ");
                sb.Append("     ,I_LANGUAGE_CD AS iLanguageCd ");
                sb.Append("     ,I_SECTION_CD AS iSectionCd ");
                sb.Append("     ,I_FAC_ARG_DESC AS iFacArgDesc ");
                sb.Append("     ,I_FAC_DESC AS iFacDesc ");
                sb.Append("     ,I_FAC_DESC_KANA AS iFacDescKana ");
                sb.Append("     ,I_MAIL_NO AS iMailNo ");
                sb.Append("     ,I_ADDRESS1 AS iAddress1 ");
                sb.Append("     ,I_ADDRESS2 AS iAddress2 ");
                sb.Append("     ,I_ADDRESS3 AS iAddress3 ");
                sb.Append("     ,I_TEL AS iTel ");
                sb.Append(" FROM T_FACTORY_MS ");
                sb.Append(" WHERE 0 = 0 ");
                sb.Append("     AND I_COMPANY_CD=:companyCd");
                if (!string.IsNullOrEmpty(facCd))
                {
                    sb.Append("     AND I_FAC_CD LIKE %:facCd%");
                }
                if (!string.IsNullOrEmpty(facNm))
                {
                    sb.Append("     AND I_FAC_DESC LIKE %:facNm%");
                }
                sb.Append(" ORDER BY I_FAC_CD");

                ISQLQuery querycatalogfunction = ss.CreateSQLQuery(sb.ToString());
                querycatalogfunction.AddScalar("iFacCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iCompanyCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iBaseCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iCountryCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iTimezoneCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iLanguageCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iSectionCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iFacArgDesc", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iFacDesc", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iFacDescKana", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iMailNo", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iAddress1", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iAddress2", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iAddress3", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iTel", NHibernateUtil.String);

                querycatalogfunction.SetParameter("companyCd", companyCd);
                if (!string.IsNullOrEmpty(facCd))
                {
                    querycatalogfunction.SetParameter("facCd", facCd);
                }
                if (!string.IsNullOrEmpty(facNm))
                {
                    querycatalogfunction.SetParameter("facNm", facNm);
                }

                result = querycatalogfunction.SetResultTransformer(Transformers.AliasToBean<TFactoryMs>()).List<TFactoryMs>();
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
            }

            return result;
        }
    }
}
