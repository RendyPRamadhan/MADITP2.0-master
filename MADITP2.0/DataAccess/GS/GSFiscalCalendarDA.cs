using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.DataAccess.GS
{
    public class GSFiscalCalendarDA
    {
        private static clsGlobal Helper;
        public GSFiscalCalendarDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter enReadType, GSFiscalCalendarBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_FISCAL_CALENDAR] '{Model.group_id}','{Model.fiscal_year}','{Model.entity_id}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_FISCAL_CALENDAR] '{Model.group_id}','{Model.fiscal_year}','{Model.entity_id}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_FISCAL_CALENDAR] '{Model.group_id}','{Model.fiscal_year}','{Model.entity_id}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public int Post(GSFiscalCalendarBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@group_id", VALUE= Model.group_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@fiscal_year", VALUE= Model.fiscal_year},
                    new SqlParameterHelper(){PARAMETR_NAME = "@period", VALUE= Model.period},
                    new SqlParameterHelper(){PARAMETR_NAME = "@begining_date", VALUE= Model.begining_date},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ending_date", VALUE= Model.ending_date},
                    new SqlParameterHelper(){PARAMETR_NAME = "@no_of_days", VALUE= Model.no_of_days},
                    new SqlParameterHelper(){PARAMETR_NAME = "@period_status", VALUE= Model.period_status},
                    new SqlParameterHelper(){PARAMETR_NAME = "@actual_closed", VALUE= Model.actual_closed},
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity_id", VALUE= Model.entity_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@save_struktur", VALUE= Model.save_struktur},
                    new SqlParameterHelper(){PARAMETR_NAME = "@save_level", VALUE= Model.save_level}
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_INSERT_FISCAL_CALENDAR]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Put(GSFiscalCalendarBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper(){PARAMETR_NAME = "@group_id", VALUE= Model.group_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@fiscal_year", VALUE= Model.fiscal_year},
                    new SqlParameterHelper(){PARAMETR_NAME = "@period", VALUE= Model.period},
                    new SqlParameterHelper(){PARAMETR_NAME = "@begining_date", VALUE= Model.begining_date},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ending_date", VALUE= Model.ending_date},
                    new SqlParameterHelper(){PARAMETR_NAME = "@no_of_days", VALUE= Model.no_of_days},
                    new SqlParameterHelper(){PARAMETR_NAME = "@period_status", VALUE= Model.period_status},
                    new SqlParameterHelper(){PARAMETR_NAME = "@actual_closed", VALUE= Model.actual_closed},
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity_id", VALUE= Model.entity_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@save_struktur", VALUE= Model.save_struktur},
                    new SqlParameterHelper(){PARAMETR_NAME = "@save_level", VALUE= Model.save_level}
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_UPDATE_FISCAL_CALENDAR]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(GSFiscalCalendarBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@group_id", VALUE= Model.group_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@fiscal_year", VALUE= Model.fiscal_year}
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_DELETE_FISCAL_CALENDAR]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}