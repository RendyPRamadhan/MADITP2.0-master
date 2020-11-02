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
    class CBMasterCurrencyCodeDA
    {
        private static clsGlobal Helper;
        private static CBMasterCurrencyCodeBL Model;
        public CBMasterCurrencyCodeDA(clsGlobal _Helper)
        {
            Helper = _Helper;
            Model = new CBMasterCurrencyCodeBL();
        }

        public DataTable Read(EnumFilter enReadType, CBMasterCurrencyCodeBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CURRENCY] '','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CURRENCY] '{Model.currency_code}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CURRENCY] '{Model.currency_code}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CURRENCY] '{Model.currency_code}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public DataSet Read_DS(EnumFilter enReadType, CBMasterCurrencyCodeBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CURRENCY] '','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CURRENCY] '{Model.currency_code}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CURRENCY] '{Model.currency_code}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_CURRENCY] '{Model.currency_code}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(CBMasterCurrencyCodeBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@currCode", VALUE= Model.currency_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Curr", VALUE= Model.currency },
                     new SqlParameterHelper(){PARAMETR_NAME = "@CurrType", VALUE= Model.currency_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@UppRatetoHome", VALUE= Model.upp_rate_to_home },
                    new SqlParameterHelper(){PARAMETR_NAME = "@LowRatetoHome", VALUE= Model.low_rate_to_home },
                    new SqlParameterHelper(){PARAMETR_NAME = "@MdlRatetoHome", VALUE= Model.mdl_rate_to_home },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Remarks", VALUE= Model.remarks },
                    new SqlParameterHelper(){PARAMETR_NAME = "@UserID", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_CURRENCY]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CBMasterCurrencyCodeBL CMD_DS(CBMasterCurrencyCodeBL Model, string SQLQuery)
        {
           // DataTable result = new DataTable();
            var Result = new DataTable();
            DataTableCollection DTC;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@currCode", VALUE= Model.currency_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Curr", VALUE= Model.currency },
                     new SqlParameterHelper(){PARAMETR_NAME = "@CurrType", VALUE= Model.currency_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@UppRatetoHome", VALUE= Model.upp_rate_to_home },
                    new SqlParameterHelper(){PARAMETR_NAME = "@LowRatetoHome", VALUE= Model.low_rate_to_home },
                    new SqlParameterHelper(){PARAMETR_NAME = "@MdlRatetoHome", VALUE= Model.mdl_rate_to_home },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Remarks", VALUE= Model.remarks },
                    new SqlParameterHelper(){PARAMETR_NAME = "@UserID", VALUE= clsLogin.USERID },
                };
                //DTC = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_SO_CMD_CURRENCY]", sqlParameter);
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_CURRENCY]", sqlParameter);

                Model = new CBMasterCurrencyCodeBL();

                Model.issuccess = Convert.ToInt32(result[0].Rows[0].ItemArray.ElementAt(0));
                Model.currency_code = result[0].Rows[0].ItemArray.ElementAt(1).ToString();

                return Model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
