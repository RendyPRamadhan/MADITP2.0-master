using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.AR
{
    public class ARPrintSlipKuitansiProcessDA
    {
        private static clsGlobal Helper;
        public ARPrintSlipKuitansiProcessDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter enReadType, ARPrintSlipKuitansiProcessBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [dbo].[SP_AR_SELECT_PRINT_KUITANSI_PROCESS] '{Model.ak_entity_id}','{Model.ak_branch_id}','{Model.ak_division_id}','{Model.cm_collector_name}','{Model.ak_item_number}','{Model.ak_processing_date_from}','{Model.ak_processing_date_to}',{Page},{PerPage},0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [dbo].[SP_AR_SELECT_PRINT_KUITANSI_PROCESS] '{Model.ak_entity_id}','{Model.ak_branch_id}','{Model.ak_division_id}','{Model.cm_collector_name}','{Model.ak_item_number}','{Model.ak_processing_date_from}','{Model.ak_processing_date_to}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [dbo].[SP_AR_SELECT_PRINT_KUITANSI_PROCESS] '{Model.ak_entity_id}','{Model.ak_branch_id}','{Model.ak_division_id}','{Model.cm_collector_name}','{Model.ak_item_number}','{Model.ak_processing_date_from}','{Model.ak_processing_date_to}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public DataTable ReadCollectionMaster()
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"SELECT cm_collector_id,cm_collector_name FROM AR_COLLECTOR_MASTER order by cm_collector_name");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;

        }

        public DataTable GetDivision()
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

        public DataTable ReadDataCustomer(string scm_customer_id)
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"EXEC [dbo].[SP_AR_GET_DATA_CUSTOMER] '{scm_customer_id}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
    }
}
