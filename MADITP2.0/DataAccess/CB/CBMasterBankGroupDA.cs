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
    class CBMasterBankGroupDA
    {
        private static clsGlobal Helper;

        public CBMasterBankGroupDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, CBMasterBankGroupBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_GROUP] '','','','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_GROUP] '{Model.group_id}','{Model.groups}','{Model.user_define1}','{Model.user_define2}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_GROUP] '{Model.group_id}','{Model.groups}','{Model.user_define1}','{Model.user_define2}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_GROUP] '{Model.group_id}','{Model.groups}','{Model.user_define1}','{Model.user_define2}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
        public DataSet Read_DS(EnumFilter enReadType, CBMasterBankGroupBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_GROUP] '','','','','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_GROUP] '{Model.group_id}','{Model.groups}','{Model.user_define1}','{Model.user_define2}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_GROUP] '{Model.group_id}','{Model.groups}','{Model.user_define1}','{Model.user_define2}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_BANK_GROUP] '{Model.group_id}','{Model.groups}','{Model.user_define1}','{Model.user_define2}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
        public int CMD(CBMasterBankGroupBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@groupid", VALUE= Model.group_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@group", VALUE= Model.groups },
                     new SqlParameterHelper(){PARAMETR_NAME = "@user_define1", VALUE= Model.user_define1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@user_define2", VALUE= Model.user_define2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@userid", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_BANK_GROUP]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
