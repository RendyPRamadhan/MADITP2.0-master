using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;

namespace MADITP2._0.DataAccess.GS
{
    public class GSModuleDA
    {
        private static clsGlobal Helper;
        public GSModuleDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter enReadType, GSModuleBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_MODULE] '{Model.module_id}','{Model.description}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_MODULE] '{Model.module_id}','{Model.description}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_MODULE] '{Model.module_id}','{Model.description}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_MODULE] '{Model.module_id}','{Model.description}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public int Post(GSModuleBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@module_id", VALUE= Model.module_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@description", VALUE= Model.description }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_INSERT_MODULE]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Put(GSModuleBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@module_id", VALUE= Model.module_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@description", VALUE= Model.description }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_UPDATE_MODULE]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(string id)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@module_id", VALUE= id }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_DELETE_MODULE]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}