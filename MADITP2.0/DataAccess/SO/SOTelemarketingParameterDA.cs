using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;

namespace MADITP2._0.DataAccess.SO
{
    public class SOTelemarketingParameterDA
    {
        private static clsGlobal Helper;

        public SOTelemarketingParameterDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }
        public DataTable Read(EnumFilter enReadType, SOTelemarketingParameterBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_PARAMETER] '{Model.id}','{Model.parameter_id}','{Model.parameter_code}','{Model.parameter_category}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_PARAMETER] '{Model.id}','','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_PARAMETER] '{Model.id}','{Model.parameter_id}','{Model.parameter_code}','{Model.parameter_category}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_PARAMETER] '{Model.id}','{Model.parameter_id}','{Model.parameter_code}','{Model.parameter_category}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public int Post(SOTelemarketingParameterBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_code", VALUE= Model.parameter_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_id", VALUE= Model.parameter_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_category", VALUE= Model.parameter_category },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_desc", VALUE= Model.parameter_desc },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_drop", VALUE= Model.parameter_drop },
                    new SqlParameterHelper(){PARAMETR_NAME = "@create_by", VALUE= Model.create_by },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_desc_pfx", VALUE= Model.parameter_desc_pfx }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_SO_INSERT_TELEMARKETING_PARAMETER]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Put(SOTelemarketingParameterBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE= Model.id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_code", VALUE= Model.parameter_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_id", VALUE= Model.parameter_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_category", VALUE= Model.parameter_category },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_desc", VALUE= Model.parameter_desc },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_drop", VALUE= Model.parameter_drop },
                    new SqlParameterHelper(){PARAMETR_NAME = "@parameter_desc_pfx", VALUE= Model.parameter_desc_pfx }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_SO_UPDATE_TELEMARKETING_PARAMETER]", sqlParameter);
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
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE= id }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_SO_DELETE_TELEMARKETING_PARAMETER]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}