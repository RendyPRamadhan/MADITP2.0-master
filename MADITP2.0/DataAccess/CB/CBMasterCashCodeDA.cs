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
    class CBMasterCashCodeDA
    {
        private static clsGlobal Helper;

        public CBMasterCashCodeDA(clsGlobal _Helper)
        {
            //TEST GITHUB
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, CBMasterCashCodeBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CASH_CODE] '','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CASH_CODE] '{Model.cash_id}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CASH_CODE] '{Model.cash_id}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CASH_CODE] '{Model.cash_id}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public DataSet Read_DS(EnumFilter enReadType, CBMasterCashCodeBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CASH_CODE] '','{tcode},0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CASH_CODE] '{Model.cash_id}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CASH_CODE] '{Model.cash_id}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CASH_CODE] '{Model.cash_id}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(CBMasterCashCodeBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_cash_id_1", VALUE= Model.cash_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_description_2", VALUE= Model.description },
                     new SqlParameterHelper(){PARAMETR_NAME = "@cb_code_type_3", VALUE= Model.code_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_report_sequence_number_4", VALUE= Model.sequence_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_user_define_5",  VALUE= Model.user_define },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_user_id_6", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_CASH_CODE]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CMD_TESTGITHUB(CBMasterCashCodeBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_cash_id_1", VALUE= Model.cash_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_description_2", VALUE= Model.description },
                     new SqlParameterHelper(){PARAMETR_NAME = "@cb_code_type_3", VALUE= Model.code_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_report_sequence_number_4", VALUE= Model.sequence_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_user_define_5",  VALUE= Model.user_define },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cb_user_id_6", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_CASH_CODE]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
