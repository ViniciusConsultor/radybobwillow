using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Com.GainWinSoft.Common;
using NHibernate;
using Com.GainWinSoft.ERP.Entity;
using NHibernate.Transform;
using System.Data.Common;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    class CCodeRefTradeForMaterialNoARDaoOracleImp:ActiveRecordBase,IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICCodeRefTradeForMaterialNoARDao
    {
        public IList<CCodeRefTradeForMaterialNoAR> GetCodeRefTradeForMaterial(string langId, string companyCd,string dlCd,string dlDesc)
        {

            IList<CCodeRefTradeForMaterialNoAR> result = new List<CCodeRefTradeForMaterialNoAR>();

            ISession ss = holder.CreateSession(typeof(CCodeRefTradeForMaterialNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                StringBuilder sb = new StringBuilder();
      
                sb.Append(" select" );
                sb.Append(" t.i_company_cd as iCompanyCd,");
                sb.Append(" t.i_dl_cd as iDlCd,");
                sb.Append(" t.i_dl_desc as iDlDesc ,");
                sb.Append(" t.i_dl_arg_desc as iDlArgDesc,");
                sb.Append(" t.i_dl_desc_kana as iDlDescKana,");
                sb.Append(" t.i_dl_type as iDlType,");
                sb.Append(" c.i_cls_detail_desc as iDlTypeName");
                sb.Append(" from t_trade_ms t left join t_cls_detail_ms c ");
                sb.Append(" on (c.i_language_cd=:langId and c.i_cls_cd='24' and t.i_dl_type = c.i_cls_detail_cd)");

                sb.Append(" where t.i_company_cd=:companyCd");
                if (dlCd != string.Empty)
                {
                    sb.Append(" and  t.i_dl_cd like %:dlCd%");
                }
                if (dlDesc != string.Empty)
                {
                    sb.Append(" and  t.i_dl_desc like %:dlDesc%");
                }
                sb.Append(" order by t.i_dl_cd");

                ISQLQuery query = ss.CreateSQLQuery(sb.ToString());
                query.AddScalar("iCompanyCd", NHibernateUtil.String);
                query.AddScalar("iDlCd", NHibernateUtil.String);
                query.AddScalar("iDlDesc", NHibernateUtil.String);
                query.AddScalar("iDlArgDesc", NHibernateUtil.String);
                query.AddScalar("iDlDescKana", NHibernateUtil.String);
                query.AddScalar("iDlType", NHibernateUtil.String);
                query.AddScalar("iDlTypeName", NHibernateUtil.String);


                query.SetParameter("langId", langId);
                query.SetParameter("companyCd", companyCd);
                if (dlCd != string.Empty)
                {
                    query.SetParameter("dlCd", dlCd);
                }
                if (dlDesc != string.Empty)
                {
                    query.SetParameter("dlDesc", dlDesc);
                }

                result = query.SetResultTransformer(Transformers.AliasToBean<CCodeRefTradeForMaterialNoAR>()).List<CCodeRefTradeForMaterialNoAR>();


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
