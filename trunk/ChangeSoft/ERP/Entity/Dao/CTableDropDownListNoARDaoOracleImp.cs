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
    class CTableDropDownListNoARDaoOracleImp : ActiveRecordBase, IBaseDao, Com.GainWinSoft.ERP.Entity.Dao.ICTableDropDownListNoARDao
    {
        public IList<CTableDropDownListNoAR> GetDetail(string langId, string langColumn, string talbeNm, string valueColumn, string nameColumn)
        {
            IList<CTableDropDownListNoAR> result = new List<CTableDropDownListNoAR>();

            ISession ss = holder.CreateSession(typeof(CTableDropDownListNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" SELECT ");
                sb.Append(" ").Append(valueColumn).Append(" AS iCd, ");
                sb.Append(" ").Append(nameColumn).Append(" AS iName ");
                sb.Append(" FROM ").Append(talbeNm).Append(" ");
                sb.Append(" WHERE 0 = 0 ");
                sb.Append(" AND ").Append(langColumn).Append("=:langId ");

                ISQLQuery querycatalogfunction = ss.CreateSQLQuery(sb.ToString());
                querycatalogfunction.AddScalar("iCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iName", NHibernateUtil.String);

                querycatalogfunction.SetParameter("langId", langId);

                result = querycatalogfunction.SetResultTransformer(Transformers.AliasToBean<CTableDropDownListNoAR>()).List<CTableDropDownListNoAR>();

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

        public IList<CTableDropDownListNoAR> GetDetail(string talbeNm, string valueColumn, string nameColumn)
        {
            IList<CTableDropDownListNoAR> result = new List<CTableDropDownListNoAR>();

            ISession ss = holder.CreateSession(typeof(CTableDropDownListNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" SELECT ");
                sb.Append(" ").Append(valueColumn).Append(" AS iCd, ");
                sb.Append(" ").Append(nameColumn).Append(" AS iName ");
                sb.Append(" FROM ").Append(talbeNm).Append(" ");
                sb.Append(" WHERE 0 = 0 ");

                ISQLQuery querycatalogfunction = ss.CreateSQLQuery(sb.ToString());
                querycatalogfunction.AddScalar("iCd", NHibernateUtil.String);
                querycatalogfunction.AddScalar("iName", NHibernateUtil.String);

                result = querycatalogfunction.SetResultTransformer(Transformers.AliasToBean<CTableDropDownListNoAR>()).List<CTableDropDownListNoAR>();

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
