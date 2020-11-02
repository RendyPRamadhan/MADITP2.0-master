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
    class SOReportCOGSDA
    {
        private static clsGlobal Helper;

        public SOReportCOGSDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }
        public DataTable Read(EnumFilter enReadType, SOReportCOGSBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_COGS] '','','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_COGS] '{Model.principal}','{Model.kode_product}','{Model.periode}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_COGS] '{Model.principal}','{Model.kode_product}','{Model.periode}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_COGS] '{Model.principal}','{Model.kode_product}','{Model.periode}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
        public DataSet Read_DS(EnumFilter enReadType, SOReportCOGSBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_COGS] '','','','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_COGS] '{Model.principal}','{Model.kode_product}','{Model.periode}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_COGS] '{Model.principal}','{Model.kode_product}','{Model.periode}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_COGS] '{Model.principal}','{Model.kode_product}','{Model.periode}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }
       
        public DataTable GetList_Principal(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = ""; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT CASE WHEN gp_product_group_id = '' THEN '0' ELSE RTRIM(gp_product_group_id) END AS gp_product_group_id, gp_group_description FROM VW_LIST_PRODUCT_GROUP ORDER BY gp_product_group_id ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }
            return result;
        }

        public DataTable GetList_Product(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = ""; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT RTRIM(product_id) AS product_id, product_description FROM VW_LIST_PRODUCT WHERE product_id<> '' ORDER BY product_description ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }
            return result;
        }

      
    }
}
