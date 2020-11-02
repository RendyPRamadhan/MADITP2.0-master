using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;

namespace MADITP2._0.DataAccess.AR
{
    class ARMasterCollectorDA
    {
        private static clsGlobal Helper;

        public ARMasterCollectorDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }
        public DataTable Read(EnumFilter enReadType, ARMasterCollectorBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_MASTER_COLLECTOR] '','','','','','','','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_MASTER_COLLECTOR] '{Model.collector_id}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.collector_name}','{Model.default_area_code}','{Model.collector_active_flag}','{Model.group_head_id}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_MASTER_COLLECTOR] '{Model.collector_id}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.collector_name}','{Model.default_area_code}','{Model.collector_active_flag}','{Model.group_head_id}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_MASTER_COLLECTOR] '{Model.collector_id}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.collector_name}','{Model.default_area_code}','{Model.collector_active_flag}','{Model.group_head_id}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
        public DataSet Read_DS(EnumFilter enReadType, ARMasterCollectorBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_MASTER_COLLECTOR] '','','','','','','','','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_MASTER_COLLECTOR] '{Model.collector_id}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.collector_name}','{Model.default_area_code}','{Model.collector_active_flag}','{Model.group_head_id}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_MASTER_COLLECTOR] '{Model.collector_id}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.collector_name}','{Model.default_area_code}','{Model.collector_active_flag}','{Model.group_head_id}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_MASTER_COLLECTOR] '{Model.collector_id}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.collector_name}','{Model.default_area_code}','{Model.collector_active_flag}','{Model.group_head_id}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
        public int CMD(ARMasterCollectorBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@collector_id", VALUE= Model.collector_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@collector_name", VALUE= Model.collector_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_entity_id", VALUE= Model.entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_branch_id", VALUE= Model.branch_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_division_id", VALUE= Model.division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_collector_active_flag", VALUE= Model.collector_active_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_default_area_code", VALUE= Model.default_area_code },

                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_collector_level", VALUE= Model.collector_level },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_group_head_id", VALUE= Model.group_head_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_incentive_amount_kw1", VALUE= Model.incentive_amount_kw1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_incentive_amount_kw2", VALUE= Model.incentive_amount_kw2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_incentive_amount_kw3", VALUE= Model.incentive_amount_kw3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_penalty_amount_kw", VALUE= Model.penalty_amount_kw },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_remarks", VALUE= Model.remarks },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_bank_name", VALUE= Model.bank_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cm_bank_account_number", VALUE= Model.bank_account_number },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_AR_CMD_MASTER_COLLECTOR]", sqlParameter);
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
            { sql = "SELECT RTRIM(ec_entity_id) AS cm_entity_id,  ec_entity FROM ENTITY_CODES WHERE ec_entity_id <> '0' ORDER BY ec_entity ASC"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT RTRIM(ec_entity_id) AS cm_entity_id, CASE WHEN ec_entity_id = '0' THEN '(Select All Entity)' ELSE ec_entity END AS ec_entity FROM ENTITY_CODES ORDER BY ec_entity ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }
            return result;
        }

        public DataTable GetList_Branch(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT RTRIM(bc_branch_id) AS cm_branch_id, bc_branch FROM BRANCH_CODES WHERE bc_branch_id <> '0' ORDER BY bc_branch ASC"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT RTRIM(bc_branch_id) AS cm_branch_id, CASE WHEN bc_branch_id = '0' THEN '(Select All Branch)' ELSE bc_branch END AS bc_branch FROM BRANCH_CODES ORDER BY bc_branch ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }
            return result;
        }

        public DataTable GetList_Division(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT RTRIM(dc_division_id) AS cm_division_id, dc_division FROM DIVISION_CODES WHERE dc_division_id <> '0' ORDER BY dc_division ASC"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT RTRIM(dc_division_id) AS cm_division_id, CASE WHEN dc_division_id = '0' THEN '(Select All Division)' ELSE dc_division END AS dc_division FROM DIVISION_CODES ORDER BY dc_division ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }
            return result;
        }

        public DataTable GetList_Area(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT RTRIM(ac_area_id) AS ac_area_id, ac_area_description FROM VW_LIST_AREA  WHERE ac_area_id <> '' ORDER BY ac_area_description asc"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT RTRIM(ac_area_id) AS ac_area_id, ac_area_description FROM VW_LIST_AREA ORDER BY ac_area_description asc"; }

            
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }
            return result;
        }

        public DataTable GetList_GroupHead(string Event)
        {
            string sql = "";

            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT RTRIM(cm_collector_id) AS cm_collector_id, cm_collector_name FROM VW_LIST_GROUPHEAD WHERE cm_collector_id <> '0' ORDER BY cm_collector_name asc"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT RTRIM(cm_collector_id) AS cm_collector_id, cm_collector_name FROM VW_LIST_GROUPHEAD ORDER BY cm_collector_name asc"; }


            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }
            return result;
        }
    }
}
