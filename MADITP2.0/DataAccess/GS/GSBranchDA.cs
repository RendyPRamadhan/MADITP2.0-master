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
    public class GSBranchDA
    {
        private static clsGlobal Helper;
        public GSBranchDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter enReadType, GSBranchBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_BRANCH] '{Model.branch_id}','{Model.initial}','{Model.branch}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_BRANCH] '{Model.branch_id}','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_NAME:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_BRANCH] '{Model.branch_id}','{Model.initial}','{Model.branch}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_BRANCH] '{Model.branch_id}','{Model.initial}','{Model.branch}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_BRANCH] '{Model.branch_id}','{Model.initial}','{Model.branch}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public int Post(GSBranchBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch_id", VALUE= Model.branch_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@initial", VALUE= Model.initial},
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch", VALUE= Model.branch},
                    new SqlParameterHelper(){PARAMETR_NAME = "@address", VALUE= Model.address},
                    new SqlParameterHelper(){PARAMETR_NAME = "@address2", VALUE= Model.address2},
                    new SqlParameterHelper(){PARAMETR_NAME = "@address3", VALUE= Model.address3},
                    new SqlParameterHelper(){PARAMETR_NAME = "@phone", VALUE= Model.phone},
                    new SqlParameterHelper(){PARAMETR_NAME = "@fax", VALUE= Model.fax},
                    new SqlParameterHelper(){PARAMETR_NAME = "@email", VALUE= Model.email},
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch_manager", VALUE= Model.branch_manager},
                    new SqlParameterHelper(){PARAMETR_NAME = "@admin_head", VALUE= Model.admin_head },
                    new SqlParameterHelper(){PARAMETR_NAME = "@person_contact1", VALUE= Model.person_contact1},
                    new SqlParameterHelper(){PARAMETR_NAME = "@person_contact1_title", VALUE= Model.person_contact1_title },
                    new SqlParameterHelper(){PARAMETR_NAME = "@person_contact2", VALUE= Model.person_contact2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@person_contact2_title", VALUE= Model.person_contact2_title },
                    new SqlParameterHelper(){PARAMETR_NAME = "@taxid_npwp", VALUE= Model.taxid_npwp},
                    new SqlParameterHelper(){PARAMETR_NAME = "@koordinator_cc", VALUE= Model.koordinator_cc},
                    new SqlParameterHelper(){PARAMETR_NAME = "@admin_cc", VALUE= Model.admin_cc},
                    new SqlParameterHelper(){PARAMETR_NAME = "@tax_inv_no", VALUE= Model.tax_inv_no},
                    new SqlParameterHelper(){PARAMETR_NAME = "@no_pengukuhan_pkp", VALUE= Model.no_pengukuhan_pkp},
                    new SqlParameterHelper(){PARAMETR_NAME = "@tgl_pengukuhan_pkp ", VALUE= Model.tgl_pengukuhan_pkp},
                    new SqlParameterHelper(){PARAMETR_NAME = "@last_sequence ", VALUE= Model.last_sequence},
                    new SqlParameterHelper(){PARAMETR_NAME = "@remark", VALUE= Model.remark },
                    new SqlParameterHelper(){PARAMETR_NAME = "@rpt_desc", VALUE= Model.rpt_desc},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_entity_id", VALUE= Model.ar_entity_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_branch_id", VALUE= Model.ar_branch_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_division_id", VALUE= Model.ar_division_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_department_id", VALUE= Model.ar_department_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_major1 ", VALUE= Model.ar_major1},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_major2 ", VALUE= Model.ar_major2},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_minor", VALUE= Model.ar_minor},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_analisys", VALUE= Model.ar_analisys},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_filler", VALUE= Model.ar_filler},
                    new SqlParameterHelper(){PARAMETR_NAME = "@default_branch", VALUE= Model.default_branch},
                    new SqlParameterHelper(){PARAMETR_NAME = "@cs_name", VALUE= Model.cs_name},
                    new SqlParameterHelper(){PARAMETR_NAME = "@cs_phone", VALUE= Model.cs_phone},
                    new SqlParameterHelper(){PARAMETR_NAME = "@billing_name", VALUE= Model.billing_name},
                    new SqlParameterHelper(){PARAMETR_NAME = "@billing_phone", VALUE= Model.billing_phone},
                    new SqlParameterHelper(){PARAMETR_NAME = "@sap_code2 ", VALUE= Model.sap_code2},
                    new SqlParameterHelper(){PARAMETR_NAME = "@admin_warehouse", VALUE= Model.admin_warehouse},
                    new SqlParameterHelper(){PARAMETR_NAME = "@va_bmi", VALUE= Model.va_bmi},
                    new SqlParameterHelper(){PARAMETR_NAME = "@va_bca", VALUE=Model.va_bca },
                    new SqlParameterHelper(){PARAMETR_NAME = "@initial_no ", VALUE= Model.initial_no},
                    new SqlParameterHelper(){PARAMETR_NAME = "@pup_flag ", VALUE= Model.pup_flag},
                    new SqlParameterHelper(){PARAMETR_NAME = "@area", VALUE= Model.area },
                    new SqlParameterHelper(){PARAMETR_NAME = "@provinsi", VALUE= Model.provinsi},
                    new SqlParameterHelper(){PARAMETR_NAME = "@city", VALUE= Model.city},
                    new SqlParameterHelper(){PARAMETR_NAME = "@sap_code", VALUE=  Model.sap_code}
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_INSERT_BRANCH]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Put(GSBranchBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch_id", VALUE= Model.branch_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@initial", VALUE= Model.initial},
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch", VALUE= Model.branch},
                    new SqlParameterHelper(){PARAMETR_NAME = "@address", VALUE= Model.address},
                    new SqlParameterHelper(){PARAMETR_NAME = "@address2", VALUE= Model.address2},
                    new SqlParameterHelper(){PARAMETR_NAME = "@address3", VALUE= Model.address3},
                    new SqlParameterHelper(){PARAMETR_NAME = "@phone", VALUE= Model.phone},
                    new SqlParameterHelper(){PARAMETR_NAME = "@fax", VALUE= Model.fax},
                    new SqlParameterHelper(){PARAMETR_NAME = "@email", VALUE= Model.email},
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch_manager", VALUE= Model.branch_manager},
                    new SqlParameterHelper(){PARAMETR_NAME = "@admin_head", VALUE= Model.admin_head },
                    new SqlParameterHelper(){PARAMETR_NAME = "@person_contact1", VALUE= Model.person_contact1},
                    new SqlParameterHelper(){PARAMETR_NAME = "@person_contact1_title", VALUE= Model.person_contact1_title },
                    new SqlParameterHelper(){PARAMETR_NAME = "@person_contact2", VALUE= Model.person_contact2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@person_contact2_title", VALUE= Model.person_contact2_title },
                    new SqlParameterHelper(){PARAMETR_NAME = "@taxid_npwp", VALUE= Model.taxid_npwp},
                    new SqlParameterHelper(){PARAMETR_NAME = "@koordinator_cc", VALUE= Model.koordinator_cc},
                    new SqlParameterHelper(){PARAMETR_NAME = "@admin_cc", VALUE= Model.admin_cc},
                    new SqlParameterHelper(){PARAMETR_NAME = "@tax_inv_no", VALUE= Model.tax_inv_no},
                    new SqlParameterHelper(){PARAMETR_NAME = "@no_pengukuhan_pkp", VALUE= Model.no_pengukuhan_pkp},
                    new SqlParameterHelper(){PARAMETR_NAME = "@tgl_pengukuhan_pkp ", VALUE= Model.tgl_pengukuhan_pkp},
                    new SqlParameterHelper(){PARAMETR_NAME = "@last_sequence ", VALUE= Model.last_sequence},
                    new SqlParameterHelper(){PARAMETR_NAME = "@remark", VALUE= Model.remark },
                    new SqlParameterHelper(){PARAMETR_NAME = "@rpt_desc", VALUE= Model.rpt_desc},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_entity_id", VALUE= Model.ar_entity_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_branch_id", VALUE= Model.ar_branch_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_division_id", VALUE= Model.ar_division_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_department_id", VALUE= Model.ar_department_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_major1 ", VALUE= Model.ar_major1},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_major2 ", VALUE= Model.ar_major2},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_minor", VALUE= Model.ar_minor},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_analisys", VALUE= Model.ar_analisys},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ar_filler", VALUE= Model.ar_filler},
                    new SqlParameterHelper(){PARAMETR_NAME = "@default_branch", VALUE= Model.default_branch},
                    new SqlParameterHelper(){PARAMETR_NAME = "@cs_name", VALUE= Model.cs_name},
                    new SqlParameterHelper(){PARAMETR_NAME = "@cs_phone", VALUE= Model.cs_phone},
                    new SqlParameterHelper(){PARAMETR_NAME = "@billing_name", VALUE= Model.billing_name},
                    new SqlParameterHelper(){PARAMETR_NAME = "@billing_phone", VALUE= Model.billing_phone},
                    new SqlParameterHelper(){PARAMETR_NAME = "@sap_code2 ", VALUE= Model.sap_code2},
                    new SqlParameterHelper(){PARAMETR_NAME = "@admin_warehouse", VALUE= Model.admin_warehouse},
                    new SqlParameterHelper(){PARAMETR_NAME = "@va_bmi", VALUE= Model.va_bmi},
                    new SqlParameterHelper(){PARAMETR_NAME = "@va_bca", VALUE=Model.va_bca },
                    new SqlParameterHelper(){PARAMETR_NAME = "@initial_no ", VALUE= Model.initial_no},
                    new SqlParameterHelper(){PARAMETR_NAME = "@pup_flag ", VALUE= Model.pup_flag},
                    new SqlParameterHelper(){PARAMETR_NAME = "@area", VALUE= Model.area },
                    new SqlParameterHelper(){PARAMETR_NAME = "@provinsi", VALUE= Model.provinsi},
                    new SqlParameterHelper(){PARAMETR_NAME = "@city", VALUE= Model.city},
                    new SqlParameterHelper(){PARAMETR_NAME = "@sap_code", VALUE=  Model.sap_code}
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_UPDATE_BRANCH]", sqlParameter);
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
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch_id", VALUE= id },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_DELETE_BRANCH]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}