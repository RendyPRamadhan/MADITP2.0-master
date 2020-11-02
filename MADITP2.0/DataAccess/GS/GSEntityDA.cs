using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace MADITP2._0.DataAccess.GS
{
    public class GSEntityDA
    {
        private static clsGlobal Helper;
        public GSEntityDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter Filter, GSEntityBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            DataTable result = new DataTable();
            try
            {
                switch (Filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_ENTITY] '{Model.entity_id}','{Model.entity}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_ENTITY] '{Model.entity_id}','',{Page},{PerPage},0,0");
                        break;
                    case EnumFilter.GET_SEARCH_NAME:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_ENTITY] '{Model.entity_id}','{Model.entity}',{Page},{PerPage},0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_ENTITY] '{Model.entity_id}','{Model.entity}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_ENTITY] '{Model.entity_id}','{Model.entity}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Post(GSEntityBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity_id", VALUE= Model.entity_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity", VALUE= Model.entity },
                    new SqlParameterHelper(){PARAMETR_NAME = "@address_1", VALUE= Model.address_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@address_2", VALUE= Model.address_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@address_3", VALUE= Model.address_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@city", VALUE= Model.city },
                    new SqlParameterHelper(){PARAMETR_NAME = "@postal_code", VALUE= Model.postal_code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@phone", VALUE= Model.phone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@fax", VALUE= Model.fax },
                    new SqlParameterHelper(){PARAMETR_NAME = "@email", VALUE= Model.email },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ptc1", VALUE= Model.ptc1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@title1", VALUE= Model.title1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ptc2", VALUE= Model.ptc2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@title2", VALUE= Model.title2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@npwp", VALUE= Model.npwp },
                    new SqlParameterHelper(){PARAMETR_NAME = "@user_defined1", VALUE= Model.user_defined1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@user_defined2", VALUE= Model.user_defined2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@no_pengukuhan", VALUE= Model.no_pengukuhan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@tgl_pengukuhan", VALUE= Model.tgl_pengukuhan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@tax_invoice_no", VALUE= Model.tax_invoice_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@remark", VALUE= Model.remark },
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch_flag", VALUE= Model.branch_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@division_flag", VALUE= Model.division_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@department_flag", VALUE= Model.department_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@filler_flag", VALUE= Model.filler_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity_default",VALUE = Model.entity_default }
                };

                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_INSERT_ENTITY]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Put(GSEntityBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity_id", VALUE= Model.entity_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity", VALUE= Model.entity },
                    new SqlParameterHelper(){PARAMETR_NAME = "@address_1", VALUE= Model.address_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@address_2", VALUE= Model.address_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@address_3", VALUE= Model.address_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@city", VALUE= Model.city },
                    new SqlParameterHelper(){PARAMETR_NAME = "@postal_code", VALUE= Model.postal_code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@phone", VALUE= Model.phone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@fax", VALUE= Model.fax },
                    new SqlParameterHelper(){PARAMETR_NAME = "@email", VALUE= Model.email },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ptc1", VALUE= Model.ptc1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@title1", VALUE= Model.title1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ptc2", VALUE= Model.ptc2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@title2", VALUE= Model.title2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@npwp", VALUE= Model.npwp },
                    new SqlParameterHelper(){PARAMETR_NAME = "@user_defined1", VALUE= Model.user_defined1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@user_defined2", VALUE= Model.user_defined2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@no_pengukuhan", VALUE= Model.no_pengukuhan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@tgl_pengukuhan", VALUE= Model.tgl_pengukuhan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@tax_invoice_no", VALUE= Model.tax_invoice_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@remark", VALUE= Model.remark },
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch_flag", VALUE= Model.branch_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@division_flag", VALUE= Model.division_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@department_flag", VALUE= Model.department_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@filler_flag", VALUE= Model.filler_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity_default",VALUE = Model.entity_default }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_UPDATE_ENTITY]", sqlParameter);
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
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity_id", VALUE= id },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_DELETE_ENTITY]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}