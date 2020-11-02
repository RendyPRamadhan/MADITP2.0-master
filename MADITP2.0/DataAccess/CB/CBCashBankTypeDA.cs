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
    class CBCashBankTypeDA
    {
        private static clsGlobal Helper;

        public CBCashBankTypeDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, CBCashBankTypeBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_TYPE] '','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_TYPE] '{Model.bank_type_id}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_TYPE] '{Model.bank_type_id}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_TYPE] '{Model.bank_type_id}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public DataSet Read_DS(EnumFilter enReadType, CBCashBankTypeBL Model,string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_TYPE] '',{tcode},0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_TYPE] '{Model.bank_type_id}',{tcode},0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_TYPE] '{Model.bank_type_id}',{tcode},{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_TYPE] '{Model.bank_type_id}',{tcode},{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(CBCashBankTypeBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@TypeID", VALUE= Model.bank_type_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@TypeDesc", VALUE= Model.bank_type },
                     new SqlParameterHelper(){PARAMETR_NAME = "@allow_manual_txn_entr", VALUE= Model.allow_manual_txn_entry },
                    new SqlParameterHelper(){PARAMETR_NAME = "@allow_ap", VALUE= Model.allow_ap },
                    new SqlParameterHelper(){PARAMETR_NAME = "@allow_ar",  VALUE= Model.allow_ar },
                    new SqlParameterHelper(){PARAMETR_NAME = "@UserID", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_BANK_TYPE]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
