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
    class SOMasterCategoryProductDA
    {
        private static clsGlobal Helper;

        public SOMasterCategoryProductDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, SOMasterCategoryProductBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_CATEGORY_PRODUCT] 0,'','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_CATEGORY_PRODUCT] '{Model.category_product_id}','{Model.category_product_description}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_CATEGORY_PRODUCT] '{Model.category_product_id}','{Model.category_product_description}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_CATEGORY_PRODUCT] '{Model.category_product_id}','{Model.category_product_description}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public DataSet Read_DS(EnumFilter enReadType, SOMasterCategoryProductBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_CATEGORY_PRODUCT] 0,'','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_CATEGORY_PRODUCT] '{Model.category_product_id}','{Model.category_product_description}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_CATEGORY_PRODUCT] '{Model.category_product_id}','{Model.category_product_description}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_CATEGORY_PRODUCT] '{Model.category_product_id}','{Model.category_product_description}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(SOMasterCategoryProductBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ID", VALUE= Model.category_product_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Description", VALUE= Model.category_product_description },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_SO_CMD_CATEGORY_PRODUCT]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
