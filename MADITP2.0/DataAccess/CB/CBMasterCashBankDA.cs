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
    class CBMasterCashBankDA
    {
        private static clsGlobal Helper;

        public CBMasterCashBankDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, CBMasterCashBankBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_MASTER_CASHBANK] '',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_MASTER_CASHBANK] '{Model.bam_bank_id}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_MASTER_CASHBANK] '{Model.bam_bank_id}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_MASTER_CASHBANK] '{Model.bam_bank_id}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public DataTable Read_Detail(EnumFilter enReadType, CBMasterCashBankBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_MASTER_CASHBANK_DETAIL] '','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_MASTER_CASHBANK_DETAIL] '{Model.bam_fiscal_year}','{Model.bam_bank_id}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_MASTER_CASHBANK_DETAIL] '{Model.bam_fiscal_year}','{Model.bam_bank_id}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_MASTER_CASHBANK_DETAIL] '{Model.bam_fiscal_year}','{Model.bam_bank_id}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(CBMasterCashBankBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@bank_id", VALUE= Model.bm_bank_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@bank", VALUE= Model.bm_bank },
                    new SqlParameterHelper(){PARAMETR_NAME = "@name_key", VALUE= Model.bm_name_key },
                     new SqlParameterHelper(){PARAMETR_NAME = "@bank_group_id", VALUE= Model.bm_bank_group_id },
                      new SqlParameterHelper(){PARAMETR_NAME = "@bank_type", VALUE= Model.bm_name_key },
                       new SqlParameterHelper(){PARAMETR_NAME = "@default_entity", VALUE= Model.bm_default_entity },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_address1", VALUE= Model.bm_bank_address1 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_address2", VALUE= Model.bm_bank_address2 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_address3", VALUE= Model.bm_bank_address3 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_area_code", VALUE= Model.bm_bank_area_code },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_city", VALUE= Model.bm_bank_city },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_postal_code", VALUE= Model.bm_bank_postal_code },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_province", VALUE= Model.bm_bank_province },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_phone", VALUE= Model.bm_bank_phone },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_fax", VALUE= Model.bm_bank_fax },
                       new SqlParameterHelper(){PARAMETR_NAME = "@email_address", VALUE= Model.bm_email_address },
                       new SqlParameterHelper(){PARAMETR_NAME = "@contact_person1", VALUE= Model.bm_contact_person1 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@title1", VALUE= Model.bm_title1 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@contact_person2", VALUE= Model.bm_contact_person2 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@title2", VALUE= Model.bm_title2 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@gl_entity", VALUE= Model.bm_gl_entity },
                       new SqlParameterHelper(){PARAMETR_NAME = "@active_flag", VALUE= Model.bm_active_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@userid", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_MASTER_CASHBANK]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CMD_Detail(CBMasterCashBankBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@bam_fiscal_year_1", VALUE= Model.bm_bank_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_id_2", VALUE= Model.bm_bank },
                    new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_sub_id_3", VALUE= Model.bm_name_key },
                     new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_account_no_4", VALUE= Model.bm_bank_group_id },
                      new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_account_5", VALUE= Model.bm_name_key },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_Entity", VALUE= Model.bm_default_entity },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_Branch", VALUE= Model.bm_bank_address1 },
                       new SqlParameterHelper(){PARAMETR_NAME = "bank_address2", VALUE= Model.bm_bank_address2 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bank_address3", VALUE= Model.bm_bank_address3 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_Division", VALUE= Model.bm_bank_area_code },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_Department", VALUE= Model.bm_bank_city },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_Major1", VALUE= Model.bm_bank_postal_code },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_Major2", VALUE= Model.bm_bank_province },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_Minor", VALUE= Model.bm_bank_phone },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_Analysis", VALUE= Model.bm_bank_fax },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_bank_filler", VALUE= Model.bm_email_address },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_allow_manual_txn_entry_7", VALUE= Model.bm_contact_person1 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_allow_ap_8", VALUE= Model.bm_title1 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_allow_ar_9", VALUE= Model.bm_contact_person2 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_cash_flow_statement_required_10", VALUE= Model.bm_title2 },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_currency_code_11", VALUE= Model.bm_gl_entity },
                       new SqlParameterHelper(){PARAMETR_NAME = "@bam_active_flag_12", VALUE= Model.bm_active_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@userid", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_MASTER_CASHBANK_BANK_ACCOUNT]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetList_BankGroup(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "select bg_group_id, bg_group from VW_LIST_BANK_GROUP WHERE bg_group_id <> '0' ORDER BY bg_group ASC"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "select bg_group_id, bg_group from VW_LIST_BANK_GROUP WHERE bg_group_id <> '' ORDER BY bg_group ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_BankType(string Event)
        {

            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "select bt_bank_type_id, bt_bank_type from CB_BANK_TYPE"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "select bt_bank_type_id, bt_bank_type from CB_BANK_TYPE"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }
    }
}
