using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;

namespace MADITP2._0.DataAccess.SO
{
   
    class SOMasterSubBrand1DA
    {
        private static clsGlobal Helper;

        public SOMasterSubBrand1DA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, SOMasterSubBrand1BL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_SUBBRAND1] '','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_SUBBRAND1] '{Model.brand_id}','{Model.subbrand1_description}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_SUBBRAND1] '{Model.brand_id}','{Model.subbrand1_description}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_SUBBRAND1] '{Model.brand_id}','{Model.subbrand1_description}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public DataSet Read_DS(EnumFilter enReadType, SOMasterSubBrand1BL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_SUBBRAND1] '','','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_SUBBRAND1] '{Model.brand_id}','{Model.subbrand1_description}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_SUBBRAND1] '{Model.brand_id}','{Model.subbrand1_description}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_SUBBRAND1] '{Model.brand_id}','{Model.subbrand1_description}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(SOMasterSubBrand1BL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@brand_id", VALUE= Model.brand_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@subbrand1_id", VALUE= Model.subbrand1_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@brand_desc", VALUE= Model.subbrand1_description },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_SO_CMD_SUBBRAND1]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetList_Brand(string Event)
        {
            string sql = "";

            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT [mb_brand_id], [mb_brand_description] FROM [VW_LIST_PRODUCT_BRAND]"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT [mb_brand_id], /*CASE WHEN[mb_brand_id] = 0 THEN '(ALL)' ELSE [mb_brand_description] END AS*/ mb_brand_description FROM [VW_LIST_PRODUCT_BRAND]"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }
    }

   
}
