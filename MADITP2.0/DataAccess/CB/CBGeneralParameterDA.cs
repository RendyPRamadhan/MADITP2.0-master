using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MADITP2._0.BusinessLogic.CB;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
namespace MADITP2._0.DataAccess.CB
{
    class CBGeneralParameterDA
    {
        private static clsGlobal Helper;

        public CBGeneralParameterDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, CBGeneralParameterBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            //int PerPage = (int)EnumFetchData.DefaultLimit;
            //string Search = null;

            DataTable result = new DataTable();
            string Province = null;
            string sql = null;
            int offset = (Page - 1) * PerPage;
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_GENERAL_PARAMETER] '','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_GENERAL_PARAMETER] '{Model.entity_id}','{Model.batch_source}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_GENERAL_PARAMETER] '{Model.entity_id}','{Model.batch_source}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_GENERAL_PARAMETER] '{Model.entity_id}','{Model.batch_source}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public DataSet Read_DS(EnumFilter enReadType, CBGeneralParameterBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            DataSet result = new DataSet();
            string Province = null;
            string sql = null;
            int offset = (Page - 1) * PerPage;
            var Result = new DataSet();


            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_GENERAL_PARAMETER] '','','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_GENERAL_PARAMETER] '{Model.entity_id}','{Model.batch_source}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_GENERAL_PARAMETER] '{Model.entity_id}','{Model.batch_source}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_GENERAL_PARAMETER] '{Model.entity_id}','{Model.batch_source}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(CBGeneralParameterBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_entity_id_1", VALUE= Model.entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_batch_source_2", VALUE= Model.batch_source },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_cash_sales_3", VALUE= Model.cash_sales },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_collection_4", VALUE= Model.collection },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_dp_uangmuka_5",  VALUE= Model.dp_uangmuka },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_transfer_6", VALUE= Model.transfer },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_othes_7", VALUE= Model.others },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_mpayable_import_8", VALUE= Model.mpayable_import },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_mpayable_local_9", VALUE= Model.mpayable_local },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_fasset_payable_10",  VALUE= Model.fasset_payable },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_ap_non_trade_11", VALUE= Model.ap_non_trade },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_sales_commission_12", VALUE= Model.sales_commission },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gp_cashcode_incentive_collector_13", VALUE= Model.incentive_collector },
                    //new SqlParameterHelper(){PARAMETR_NAME = "@UserID", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_GENERAL_PARAMETER]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetList_Entity(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "select ec_entity_id, ec_entity from VW_LIST_ENTITY WHERE ec_entity_id <> '0' ORDER BY ec_entity_id ASC"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "select ec_entity_id, ec_entity from VW_LIST_ENTITY WHERE ec_entity_id <> '' ORDER BY ec_entity_id ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_BatchSource(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "select bsc_batch_source, bsc_batch_source_description from VW_LIST_BATCH_SOURCE WHERE bsc_batch_source <> '0' ORDER BY bsc_batch_source ASC"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "select bsc_batch_source, bsc_batch_source_description from VW_LIST_BATCH_SOURCE WHERE bsc_batch_source <> '' ORDER BY bsc_batch_source ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }
    }
}
