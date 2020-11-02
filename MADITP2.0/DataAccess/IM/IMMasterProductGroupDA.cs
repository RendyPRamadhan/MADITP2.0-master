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
    class IMMasterProductGroupDA
    {
        private static clsGlobal Helper;

        public IMMasterProductGroupDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }
        public DataTable Read(EnumFilter enReadType, IMMasterProductGroupBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
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
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_GROUP_PRODUCT] '','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_GROUP_PRODUCT] '{Model.group_id}','{Model.description}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_GROUP_PRODUCT] '{Model.group_id}','{Model.description}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_GROUP_PRODUCT] '{Model.group_id}','{Model.description}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(IMMasterProductGroupBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@group_product_id", VALUE= Model.group_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@group_product_desc", VALUE= Model.description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@gl_account", VALUE= Model.glAccount },
                    new SqlParameterHelper(){PARAMETR_NAME = "@udf1", VALUE= Model.userdefinefield1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@udf2", VALUE= Model.userdefinefield2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@udf3", VALUE= Model.userdefinefield3 }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_IM_CMD_GROUP_PRODUCT]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
