using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace MADITP2._0.DataAccess.IM
{
    class IMOtherStockTransactionEntryDA
    {
        private static clsGlobal Helper;

        public IMOtherStockTransactionEntryDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter Filter, IMOtherStockTransactionEntryBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            DataTable result = new DataTable();
            try
            {
                switch (Filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_OTHER_STOCK_TRANSACTION_ENTRY] '{Model.warehouse_id}','{Model.txn_type_id}','{Model.product_id}','{Model.group_id}','{Model.sub_group_id}','{Model.range_date_from}','{Model.range_date_to}',{Page},{PerPage},0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_OTHER_STOCK_TRANSACTION_ENTRY] '{Model.warehouse_id}','{Model.txn_type_id}','{Model.product_id}','{Model.group_id}','{Model.sub_group_id}','{Model.range_date_from}','{Model.range_date_to}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_OTHER_STOCK_TRANSACTION_ENTRY] '{Model.warehouse_id}','{Model.txn_type_id}','{Model.product_id}','{Model.group_id}','{Model.sub_group_id}','{Model.range_date_from}','{Model.range_date_to}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public string IsUserWarehouse(string UserID)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@user", VALUE = UserID }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[sp_USER_WH]", sqlParameter);
                return $"{result[0].Rows[0].ItemArray.ElementAt(0)}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetTxnTypeByUserID(string UserID)
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"EXEC sp_USER_PIM '{UserID}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public DataTable GetProductByID(string Digital, string ProductID)
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"SELECT pm_product_id AS product_id,pm_product_description AS product_description, pm_product_type AS product_type FROM IM_PRODUCT_MASTER WHERE pm_active_flag='A' and isnull(pm_digital,'N')='{Digital}' AND pm_product_id = '{ProductID}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public DataTable GetUnitCostByProductID(string ProductID)
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"SELECT cs_standard_unit_cost AS unit_cost FROM IM_COST_STD WHERE cs_product_id = '{ProductID}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
        public DataTable GetStockBalanceByProductIDAndWarehouseID(string ProductID, string WarehouseID)
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"SELECT sb_qty_onhand AS qty_on_hand,sb_qty_onhand-(sb_qty_reserve_for_transfer+sb_qty_reserve_for_sales_order+sb_qty_on_shipment) AS qty_available FROM IM_STOCK_BALANCE WHERE sb_product_id='{ProductID}' AND sb_warehouse_id='{WarehouseID}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public DataTableCollection Post(DataTable Data, string SequenceID)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Data", VALUE = Data },
                    new SqlParameterHelper(){PARAMETR_NAME = "@sequence_id", VALUE = SequenceID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_INSERT_IM_OTHER_STOCK_TRANSACTION_ENTRY]", sqlParameter);
             
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetMasterProduct(string TextSearch)
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"SELECT pm_product_id, pm_product_description FROM IM_PRODUCT_MASTER WHERE(LEN('{TextSearch}') = 0 OR(LEN('{TextSearch}') > 0 AND LOWER(pm_product_id)  LIKE + '%' + LOWER('{TextSearch}') + '%'))OR(LEN('{TextSearch}') = 0 OR(LEN('{TextSearch}') > 0 AND LOWER(pm_product_description) LIKE + '%' + LOWER('{TextSearch}') + '%'))");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
    }
}
