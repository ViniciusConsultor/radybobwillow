﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using System.Data;
using Castle.ActiveRecord;
using Com.GainWinSoft.Common;
using System.Collections;
using NHibernate.Transform;
using System.Data.Common;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
using Com.GainWinSoft.Common.Vo;

namespace Com.GainWinSoft.ERP.Entity.Dao
{
    class TrateMsPagerNoARDaoOracleImp : ActiveRecordBase, Com.GainWinSoft.ERP.Entity.Dao.ICPagerDao
    {
        #region ICPagerDao 成员

        public int GetCount(string key, Com.GainWinSoft.Common.SearchCondition condition)
        {

            int intCount = 0;

            ISession ss = holder.CreateSession(typeof(CTPmMsPagerNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {

                StringBuilder sb = new StringBuilder();
                

                StringBuilder sql = CreateSelectSQL(condition);

                sb.AppendLine("select count(*) as CNT from (");
                sb.AppendLine(sql.ToString());
                sb.AppendLine(" ) a");

//                ISQLQuery q = ss.CreateSQLQuery(sb.ToString());
//                q.AddScalar("CNT", NHibernateUtil.Int32);
//
//                condition.SetParameterValue(q);
//                intCount = (int)q.UniqueResult();

                IDbCommand command = ss.Connection.CreateCommand();
                ((OracleCommand)command).BindByName = true;

                command.CommandText = sb.ToString();

                command.CommandType = CommandType.Text;
                condition.SetCommandParameterValue(command);



                tran.Enlist(command);

                intCount = Convert.ToInt32(command.ExecuteScalar());

//                IDataReader d = command.ExecuteReader();
//                while (d.Read())
//                {
//                    intCount = Convert.ToInt32(d.GetValue(0));
//                }
                command.Dispose();


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

            return intCount;
        }

        public System.Data.DataSet GetDataSet(string tablename, Com.GainWinSoft.Common.SearchCondition condition, int pagesize, int pageindex)
        {
            
            DataSet ds = new DataSet();
            IList<CTPmMsPagerNoAR> result = new List<CTPmMsPagerNoAR>();

            ISession ss = holder.CreateSession(typeof(CTPmMsPagerNoARDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();

            try
            {
                StringBuilder sb = new StringBuilder();


                StringBuilder sql = CreateSelectSQL(condition);
                
                sb.AppendLine("select b.*");
                sb.AppendLine(" from (select a.*, rownum as rowIndex from (");
                sb.AppendLine(sql.ToString());
                sb.AppendLine(" ) a");
                sb.AppendLine(" ) b");
                sb.AppendLine(" where b.rowIndex >" + pageindex * pagesize);
                sb.AppendLine(" and b.rowIndex <=" + (pageindex * pagesize + pagesize));



//                ISQLQuery query = ss.CreateSQLQuery(sb.ToString());
//
//                AddScalar(query);
//
//
//                condition.SetParameterValue(query);
//
//
//                result = query.SetResultTransformer(Transformers.AliasToBean<CTPmMsPagerNoAR>()).List<CTPmMsPagerNoAR>();
//
//                //转换成datatable
//                DataTable dt = DataTableUtils.ToDataTable(result);
//                dt.TableName = tablename;
//                ds.Tables.Add(dt);



                IDbCommand command = ss.Connection.CreateCommand();
                ((OracleCommand)command).BindByName = true;

                command.CommandText = sb.ToString();

                command.CommandType = CommandType.Text;
                condition.SetCommandParameterValue(command);



                tran.Enlist(command);
                IDataReader rdr = command.ExecuteReader();
                DataTable dt = new DataTable();

                dt.TableName = tablename;
                dt.Load(rdr, LoadOption.Upsert);



                DataTable newdt = new DataTable();

                string[] columnlist = new string[] { "I_COMPANY_CD", "I_RATE_CLS", "I_CLS_DETAIL_DESC", "I_DL_CURR_CD"
                                , "I_CURR_DESC", "I_EFF_END_DATE", "I_RATE", "I_CNV_METHOD", "I_CNV_METHOD_DESC" };
                foreach(string key in columnlist)
                {
                    DataColumn col = new DataColumn();
                    col.ColumnName = key;
                    newdt.Columns.Add(col);
                }
                foreach (DataRow row in dt.Rows)
                {
                    newdt.ImportRow(row);
                }
                newdt.TableName = tablename;
                ds.Tables.Add(newdt);
                command.Dispose();

//                IDbCommand command = ss.Connection.CreateCommand();
//                ((OracleCommand)command).BindByName = true;
//
//                IDbDataParameter para = command.CreateParameter();
//                para.ParameterName = "langCd";
//                para.DbType = DbType.String;
//                para.Value = "zh-CN";
//                para.Direction = ParameterDirection.Input;
//
//                command.Parameters.Add(para);
//
//                para = command.CreateParameter();
//                para.ParameterName = "companyCd";
//                para.DbType = DbType.String;
//                para.Value = "01";
//                para.Direction = ParameterDirection.Input;
//                command.Parameters.Add(para);
//
//                para = command.CreateParameter();
//                para.ParameterName = "IITEMENTRYCLS";
//                para.DbType = DbType.String;
//                para.Value = "00";
//                para.Direction = ParameterDirection.Input;
//                command.Parameters.Add(para);
//
//                para = command.CreateParameter();
//                para.ParameterName = "IFACCD";
//                para.DbType = DbType.String;
//                para.Value = "FAC01";
//                para.Direction = ParameterDirection.Input;
//                command.Parameters.Add(para);
//
//                sb = new StringBuilder();
//
//                sb.AppendLine(" select T_PM_MS.*, VTL_CLS_01.I_CLS_DETAIL_DESC,VTL_CLS_02.I_CLS_DETAIL_DESC  from T_PM_MS ");
//
//                sb.Append("     LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_01 ON ( VTL_CLS_01.I_CLS_CD = '").Append(Constant.ITEM).AppendLine("' AND VTL_CLS_01.I_CLS_DETAIL_CD = T_PM_MS.I_ITEM_CLS ");//品目区分名
//                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
//                sb.Append("           AND VTL_CLS_01.I_LANGUAGE_CD = ").Append(":langCd").AppendLine(")");
//                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end
//
//                sb.Append("     LEFT JOIN T_CLS_DETAIL_MS VTL_CLS_02 ON ( VTL_CLS_02.I_CLS_CD = '").Append(Constant.CTRL).AppendLine("' AND VTL_CLS_02.I_CLS_DETAIL_CD = T_PM_MS.I_CTRL_CLS ");//管理区分名
//                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add str
//                sb.Append("           AND VTL_CLS_02.I_LANGUAGE_CD = ").Append(":langCd").AppendLine(")");
//                //-------[2.0.0906.0801] 2009.06.08 Fsol)imatomi add end
//
//                sb.AppendLine(" where  I_FAC_CD=:IFACCD");
//
//                command.CommandText = sb.ToString();
//
//                command.CommandType = CommandType.Text;
//
//
//
//                tran.Enlist(command);
//                IDataReader rdr = command.ExecuteReader();
//                DataTable dt = new DataTable();
//                dt.TableName = tablename;
//                dt.Load(rdr, LoadOption.Upsert);
//
//                ds.Tables.Add(dt);
//                command.Dispose();



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
            return ds;

        }

        #endregion





        private StringBuilder CreateSelectSQL(SearchCondition condition)
        {

            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" SELECT ");
            sql.AppendLine("        T_RATE_MS.I_RATE_CLS ");                // レート区分
            sql.AppendLine("       ,T_RATE_MS.I_COMPANY_CD ");
            sql.AppendLine("       ,T_CLS_DETAIL_MS.I_CLS_DETAIL_DESC ");   // レート区分名
            sql.AppendLine("       ,T_RATE_MS.I_DL_CURR_CD ");              // 取引通貨
            sql.AppendLine("       ,T_CURR_MS.I_CURR_DESC ");               // 通貨名
            sql.AppendLine("       ,DECODE(T_RATE_MS.I_EFF_END_DATE,99999999,99991231,T_RATE_MS.I_EFF_END_DATE) I_EFF_END_DATE ");            // 有効期限
            sql.AppendLine("       ,T_RATE_MS.I_RATE ");                    // レート
            sql.AppendLine("       ,T_RATE_MS.I_CNV_METHOD ");              // 換算方式
            sql.AppendLine("       ,''  as I_CNV_METHOD_DESC");              // 換算方式
            sql.AppendLine("       ,T_RATE_MS.I_UPD_TIMESTAMP ");           // 更新タイプスタンプ

            sql.AppendLine("       ,T_RATE_MS.I_EFF_END_DATE I_EFF_END_DATE_NUM ");//有効期限(データ)
            sql.AppendLine("  FROM ");
            sql.AppendLine("       T_RATE_MS LEFT JOIN T_CURR_MS ON T_RATE_MS.I_DL_CURR_CD = T_CURR_MS.I_CURR_CD");
            sql.Append("               AND T_RATE_MS.I_COMPANY_CD = ").Append(":I_COMPANY_CD");
            sql.AppendLine("       LEFT JOIN T_CLS_DETAIL_MS ON T_RATE_MS.I_RATE_CLS = T_CLS_DETAIL_MS.I_CLS_DETAIL_CD");
            sql.AppendLine("            AND T_CLS_DETAIL_MS.I_CLS_CD = ").AppendLine(CommonUtil.AddSquote(Constant.RATE));
            sql.AppendLine("            AND T_CLS_DETAIL_MS.I_LANGUAGE_CD = ").Append(":I_LANGUAGE_CD");
           

            sql.AppendLine(condition.BuildParameterConditionSql(true));

            sql.AppendLine(" ORDER BY T_RATE_MS.I_RATE_CLS, T_RATE_MS.I_DL_CURR_CD, T_RATE_MS.I_EFF_END_DATE ");
            return sql;
        }

    }
}
