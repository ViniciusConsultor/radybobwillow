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
using System.Collections;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    class CTPersonMsNoARDaoOracleImp : ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICTPersonMsNoARDao
    {
        public IList<CTPersonMsNoAR> GetPersonMsList(string companyCd,string sectionCd,string personCd,string personNm)
        {

            IList<CTPersonMsNoAR> result = null;

            ISession ss = holder.CreateSession(typeof(CTPersonMsNoAR));
            ITransaction tran = ss.BeginTransaction();

            try
            {




                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT ");
                sql.AppendLine("a.I_COMPANY_CD iCompanyCd, ");
                sql.AppendLine(" a.I_PERSON_CD iPersonCd, ");
                sql.AppendLine(" a.I_PERSON_DESC iPersonDesc, ");
                sql.AppendLine(" a.I_PERSON_DESC_KANA iPersonDescKana, ");
                sql.AppendLine("  a.I_JOB_CLS iJobCls, ");
                sql.AppendLine("  a.I_USER_ID iUserId, ");
                sql.AppendLine("  a.I_SECTION_CD iSectionCd, ");
                sql.AppendLine("  a.I_PERSON_ENG_DESC iPersonEngDesc, ");
                sql.AppendLine(" a.I_PERSON_CLS iPersonCls, ");
                sql.AppendLine("  a.I_INQ_ITEM iInqItem, ");
                sql.AppendLine("  a.I_ENTRY_DATE iEntryDate, ");
                sql.AppendLine(" a.I_UPD_DATE iUpdDate, ");
                sql.AppendLine("  a.I_UPD_TIMESTAMP iUpdTimestamp, ");
                sql.AppendLine("  b.I_SECTION_ARG_DESC iSectionNm ");
                sql.AppendLine(" FROM ");
                sql.AppendLine("  T_PERSON_MS a left join  T_SECTION_MS b on (  a.I_COMPANY_CD = b.I_COMPANY_CD AND  ");
                sql.AppendLine("  b.I_SECTION_CD = a.I_SECTION_CD) ");
                sql.AppendLine(" WHERE ");
                sql.AppendLine(" a.I_COMPANY_CD =:companyCd" );
                if (!string.IsNullOrEmpty(sectionCd))
                {
                    sql.AppendLine(" AND a.I_SECTION_CD = :sectionCd ");
                }
                if (!string.IsNullOrEmpty(personCd))
                {
                    sql.AppendLine(" AND a.I_PERSON_CD LIKE ").Append(":personCd ");
                }

                if (!string.IsNullOrEmpty(personNm))
                {
                    sql.AppendLine(" AND a.I_PERSON_DESC LIKE ").Append(":personNm");
                }



                ISQLQuery query = ss.CreateSQLQuery(sql.ToString());

                AddScalar(query);

                query.SetParameter("companyCd",companyCd);
                if (!string.IsNullOrEmpty(sectionCd))
                {
                    query.SetParameter("sectionCd", sectionCd);
                }
                if (!string.IsNullOrEmpty(personCd))
                {
                    query.SetParameter("personCd", "%" + personCd + "%");
                }

                if (!string.IsNullOrEmpty(personNm))
                {
                    query.SetParameter("personNm", "%" + personNm + "%");
                }




                result = query.SetResultTransformer(Transformers.AliasToBean<CTPersonMsNoAR>()).List<CTPersonMsNoAR>();


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

        private void AddScalar(ISQLQuery query)
        {
            /*
                private string iCompanyCd;
                private string iPersonCd;
                private string iPersonDesc;
                private string iPersonDescKana;
                private string iJobCls;
                private string iUserId;
                private string iSectionCd;
                private string iSectionNm;
                private string iPersonEngDesc;
                private string iPersonCls;
                private string iInqItem;
                private DateTime iEntryDate;
                private DateTime iUpdDate;
                private string iUpdTimestamp;
            */

            query.AddScalar("iCompanyCd", NHibernateUtil.String);
            query.AddScalar("iPersonCd", NHibernateUtil.String);
            query.AddScalar("iPersonDesc", NHibernateUtil.String);
            query.AddScalar("iPersonDescKana", NHibernateUtil.String);
            query.AddScalar("iJobCls", NHibernateUtil.String);
            query.AddScalar("iUserId", NHibernateUtil.String);
            query.AddScalar("iSectionCd", NHibernateUtil.String);
            query.AddScalar("iSectionNm", NHibernateUtil.String);
            query.AddScalar("iPersonEngDesc", NHibernateUtil.String);
            query.AddScalar("iPersonCls", NHibernateUtil.String);
            query.AddScalar("iInqItem", NHibernateUtil.String);
            query.AddScalar("iEntryDate", NHibernateUtil.DateTime);
            query.AddScalar("iUpdDate", NHibernateUtil.DateTime);
            query.AddScalar("iUpdTimestamp", NHibernateUtil.String);

        }


    }
}
