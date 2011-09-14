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
    class TWhPrcsMsDaoOracleImp : ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ITWhPrcsMsDao
    {
        public IList<TWhPrcsMsNoAR> getAllWhPrcsByCdNm(string facCd, string strWhere, string whCd, string whDesc)
        {
            IList<TWhPrcsMsNoAR> result = new List<TWhPrcsMsNoAR>();
            ISession ss = holder.CreateSession(typeof(TFactoryMsDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(" SELECT ");
                sb.Append("      I_FAC_CD AS iFacCd ");
                sb.Append("     ,I_WH_PRCS_CD AS iWhPrcsCd ");
                sb.Append("     ,I_WH_PRCS_CLS AS iWhPrcsCls ");
                sb.Append("     ,I_WH_PRCS_ARG_DESC AS iWhPrcsArgDesc ");
                sb.Append("     ,I_WH_PRCS_DESC AS iWhPrcsDesc ");
                sb.Append("     ,I_WH_PRCS_DESC_KANA AS iWhPrcsDescKana ");
                sb.Append("     ,I_MAIL_NO AS iMailNo ");
                sb.Append("     ,I_COUNTRY_CD AS iCountryCd ");
                sb.Append("     ,I_ADDRESS1 AS iAddress1 ");
                sb.Append("     ,I_ADDRESS2 AS iAddress2 ");
                sb.Append("     ,I_ADDRESS3 AS iAddress3 ");
                sb.Append("     ,I_TEL AS iTel ");
                sb.Append("     ,I_FAX_NO AS iFaxNo ");
                sb.Append("     ,I_WH_CLS AS iWhCls ");
                sb.Append("     ,I_ALC_CLS AS iAlcCls ");
                sb.Append("     ,I_SECTION_CD AS iShangkbn ");
                sb.Append("     ,I_TEL AS iSectionCd ");
                sb.Append(" FROM T_WH_PRCS_MS ");
                sb.Append(" WHERE 0 = 0 ");
                sb.Append("     AND I_FAC_CD LIKE %:facCd% ");
                if (!string.IsNullOrEmpty(whCd))
                {
                    sb.Append("     AND I_WH_PRCS_CD LIKE %:whCd%");
                }
                if (!string.IsNullOrEmpty(whDesc))
                {
                    sb.Append("     AND I_WH_PRCS_DESC LIKE %:whDesc%");
                }
                if (!string.IsNullOrEmpty(strWhere))
                {
                    sb.Append("     ").Append(strWhere);
                }
                sb.Append(" ORDER BY I_WH_PRCS_CD");

                ISQLQuery querycatalogfunction = ss.CreateSQLQuery(sb.ToString());
                querycatalogfunction.AddScalar("iFacCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iWhPrcsCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iWhPrcsCls", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iWhPrcsArgDesc", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iWhPrcsDesc", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iWhPrcsDescKana", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iMailNo", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iCountryCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iAddress1", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iAddress2", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iAddress3", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iTel", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iFaxNo", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iWhCls", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iAlcCls", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iShangkbn", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iSectionCd", NHibernateUtil.String);

                querycatalogfunction.SetParameter("facCd", facCd);
                if (!string.IsNullOrEmpty(whCd))
                {
                    querycatalogfunction.SetParameter("whCd", whCd);
                }
                if (!string.IsNullOrEmpty(whDesc))
                {
                    querycatalogfunction.SetParameter("whDesc", whDesc);
                }

                result = querycatalogfunction.SetResultTransformer(Transformers.AliasToBean<TWhPrcsMsNoAR>()).List<TWhPrcsMsNoAR>();
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
