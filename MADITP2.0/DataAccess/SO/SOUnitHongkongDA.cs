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

namespace MADITP2._0.DataAccess.SO
{
    class SOUnitHongkongDA
    {
        private static clsGlobal Helper;

        public SOUnitHongkongDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, SOUnitHongkongBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_UNIT_HONGKONG] '','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_UNIT_HONGKONG] '{Model.division_id}','{Model.product_id}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_UNIT_HONGKONG] '{Model.division_id}','{Model.product_id}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_UNIT_HONGKONG] '{Model.division_id}','{Model.product_id}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
        public DataSet Read_DS(EnumFilter enReadType, SOUnitHongkongBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_UNIT_HONGKONG] '','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_UNIT_HONGKONG] '{Model.division_id}','{Model.product_id}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_UNIT_HONGKONG] '{Model.division_id}','{Model.product_id}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_UNIT_HONGKONG] '{Model.division_id}','{Model.product_id}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
        public int CMD(SOUnitHongkongBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@division_id", VALUE= Model.division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@product_id", VALUE= Model.product_id },
                      new SqlParameterHelper(){PARAMETR_NAME = "@hks_buku", VALUE= Model.buku },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_SO_CMD_UNIT_HONGKONG]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetList_Division(string Event)
        {
            string sql = "";
            /*if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT dc_division_id, dc_division FROM DIVISION_CODES WHERE dc_division_id <> 0 ORDER BY dc_division asc"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT dc_division_id, dc_division FROM DIVISION_CODES ORDER BY dc_division asc"; }
            */
            //string sql = "";
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
    }
}
