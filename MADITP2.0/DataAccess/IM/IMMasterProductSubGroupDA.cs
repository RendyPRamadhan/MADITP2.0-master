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
using MADITP2._0.Enums;
using MADITP2._0.Global;

namespace MADITP2._0.DataAccess.IM
{
    class IMMasterProductSubGroupDA
    {

        private static clsGlobal Helper;

        public IMMasterProductSubGroupDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }
        public DataTable Read(EnumFilter enReadType, IMMasterProductSubGroupBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_SUBGROUP_PRODUCT] '','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_SUBGROUP_PRODUCT] '{Model.group_id}','{Model.subgroup_id}','{Model.description}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_SUBGROUP_PRODUCT] '{Model.group_id}','{Model.subgroup_id}','{Model.description}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_SUBGROUP_PRODUCT] '{Model.group_id}','{Model.subgroup_id}','{Model.description}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(IMMasterProductSubGroupBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@group_product_id", VALUE= Model.group_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@subgroup_product_id", VALUE= Model.subgroup_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@subgroup_product_desc", VALUE= Model.description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gl_account", VALUE= Model.glAccount },
                    new SqlParameterHelper(){PARAMETR_NAME = "@udf1", VALUE= Model.userdefinefield1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@udf2", VALUE= Model.userdefinefield2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@udf3", VALUE= Model.userdefinefield3 }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_IM_CMD_SUBGROUP_PRODUCT]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public DataTable GetList_ProductGroup(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT  gp_product_group_id, gp_group_description FROM VW_LIST_PRODUCT_GROUP WHERE gp_product_group_id <> ''"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT [gp_product_group_id], CASE WHEN[gp_product_group_id] = '' THEN '(ALL)' ELSE [gp_group_description] END AS gp_group_description FROM [VW_LIST_PRODUCT_GROUP]"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }
    }
}
