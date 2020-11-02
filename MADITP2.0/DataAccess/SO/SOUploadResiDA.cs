using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
namespace MADITP2._0.DataAccess.SO
{
    class SOUploadResiDA
    {
        private static clsGlobal Helper;

        public SOUploadResiDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }
        public DataTable Read(EnumFilter enReadType, SOUploadResiBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_VOUCHER_TYPE] '','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_VOUCHER_TYPE] '{Model.NOKP}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_VOUCHER_TYPE] '{Model.NOKP}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_CB_SELECT_VOUCHER_TYPE] '{Model.NOKP}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
        public int CMD(SOUploadResiBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@NOKP", VALUE= Model.NOKP },
                    new SqlParameterHelper(){PARAMETR_NAME = "@NOSEQ", VALUE= Model.NOSEQ },
                     new SqlParameterHelper(){PARAMETR_NAME = "@NOSHP", VALUE= Model.NOSHP },
                    new SqlParameterHelper(){PARAMETR_NAME = "@RESI", VALUE= Model.RESI },
                    new SqlParameterHelper(){PARAMETR_NAME = "@EKSPEDISI",  VALUE= Model.EKSPEDISI },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_CB_CMD_UPLOAD_RESI]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

   
}
