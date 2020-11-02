using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace MADITP2._0.DataAccess.AR
{
    public class ARListKuitansiSlipUnprocessAllDA
    {
        private static clsGlobal Helper;
        public ARListKuitansiSlipUnprocessAllDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter enReadType, ARListKuitansiSlipUnprocessAllBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [dbo].[SP_AR_SELECT_LIST_KUITANSI_SLIP_UNPROCESS_ALL] '{Model.seq_number}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.invoice}','{Model.kp}',{Page},{PerPage},0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [dbo].[SP_AR_SELECT_LIST_KUITANSI_SLIP_UNPROCESS_ALL] '{Model.seq_number}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.invoice}','{Model.kp}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [dbo].[SP_AR_SELECT_LIST_KUITANSI_SLIP_UNPROCESS_ALL] '{Model.seq_number}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.invoice}','{Model.kp}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public int CheckGenerateKW(ARListKuitansiSlipUnprocessAllBL Model, string Period)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper(){PARAMETR_NAME = "@date", VALUE= Period },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cbg", VALUE= Model.branch_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@div", VALUE= Model.division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@seq", VALUE= Model.seq_number }
                };
                var result = Helper.ExecuteStoreProcedure("SP_AR_CHECK_GENERATE_KW", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTableCollection Post(DataTable Data)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Data", VALUE = Data }
                };
                return Helper.ExecuteStoreProcedure("SP_AR_INSERT_KUITANSI_SLIP_UNPROCESS_ALL", sqlParameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable GetDivision()
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"SELECT dc_division_id, dc_division FROM DIVISION_CODES");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
    }
}