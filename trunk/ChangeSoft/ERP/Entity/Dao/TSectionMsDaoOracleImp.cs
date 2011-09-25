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
    class TSectionMsDaoOracleImp : ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ITSectionMsDao
    {
        public TSectionMs getSectionByCd(string companyCd, string secCd)
        {
            TSectionMs section = null;

            ISession ss = holder.CreateSession(typeof(TSectionMsDaoOracleImp));

            ITransaction tran = ss.BeginTransaction();
            try
            {
                ScalarQuery<TSectionMs> q = new ScalarQuery<TSectionMs>(typeof(TSectionMs), @"
                                                from TSectionMs where Id.ICompanyCd=:ICompanyCd
                                                and Id.ISectionCd=:ISectionCd ");
                q.SetParameter("ICompanyCd", companyCd);
                q.SetParameter("ISectionCd", secCd);
                section = q.Execute();
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

            return section;
        }

        public IList<TSectionMsNoAR> getAllSectionByCdNm(string companyCd, string secCd, string secNm)
        {
            IList<TSectionMsNoAR> result = new List<TSectionMsNoAR>();
            ISession ss = holder.CreateSession(typeof(TSectionMsDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(" SELECT ");
                sb.Append("      I_COMPANY_CD AS iCompanyCd ");
                sb.Append("     ,I_SECTION_CD AS iSectionCd ");
                sb.Append("     ,I_SECTION_ARG_DESC AS iSectionArgDesc ");
                sb.Append("     ,I_SECTION_DESC AS iSectionDesc ");
                sb.Append("     ,I_SECTION_KANA AS iSectionKana ");
                sb.Append("     ,I_RESERVE1 AS iReserve1 ");
                sb.Append("     ,I_RESERVE2 AS iReserve2 ");
                sb.Append("     ,I_RESERVE3 AS iReserve3 ");
                sb.Append("     ,I_INQ_ITEM AS iInqItem ");
                sb.Append("     ,I_OBJECT_ID AS iObjectId ");
                sb.Append(" FROM T_SECTION_MS ");
                sb.Append(" WHERE 0 = 0 ");
                sb.Append("     AND I_COMPANY_CD=:companyCd");
                if (!string.IsNullOrEmpty(secCd))
                {
                    sb.Append("     AND I_SECTION_CD LIKE %:secCd%");
                }
                if (!string.IsNullOrEmpty(secNm))
                {
                    sb.Append("     AND I_SECTION_DESC LIKE %:secNm%");
                }
                sb.Append(" ORDER BY I_SECTION_CD");

                ISQLQuery querycatalogfunction = ss.CreateSQLQuery(sb.ToString());
                querycatalogfunction.AddScalar("iCompanyCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iSectionCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iSectionArgDesc", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iSectionDesc", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iSectionKana", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iReserve1", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iReserve2", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iReserve3", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iInqItem", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iObjectId", NHibernateUtil.Decimal);

                querycatalogfunction.SetParameter("companyCd", companyCd);
                if (!string.IsNullOrEmpty(secCd))
                {
                    querycatalogfunction.SetParameter("secCd", secCd);
                }
                if (!string.IsNullOrEmpty(secNm))
                {
                    querycatalogfunction.SetParameter("secNm", secNm);
                }

                result = querycatalogfunction.SetResultTransformer(Transformers.AliasToBean<TSectionMsNoAR>()).List<TSectionMsNoAR>();
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
