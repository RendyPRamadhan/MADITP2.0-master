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
    class IMTukarBarangDA
    {
        private static clsGlobal Helper;

        public IMTukarBarangDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter Filter, IMTukarBarangBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            DataTable result = new DataTable();
            try
            {
                switch (Filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_TUKAR_BARANG] '{Model.warehouse_id}','{Model.product_id}','{Model.txn_date_from}','{Model.txn_date_to}',{Page},{PerPage},0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_TUKAR_BARANG] '{Model.warehouse_id}','{Model.product_id}','{Model.txn_date_from}','{Model.txn_date_to}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_IM_SELECT_TUKAR_BARANG] '{Model.warehouse_id}','{Model.product_id}','{Model.txn_date_from}','{Model.txn_date_to}',{Page},{PerPage},0,1");
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

        public string IsUserTbrRbt(string UserID)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@user", VALUE = UserID }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[sp_CHECK_USER_TBR_RBT]", sqlParameter);
                return $"{result[0].Rows[0].ItemArray.ElementAt(0)}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Post(DataTable Data,string SequenceIDIn,string SequenceIDOut,string WarehouseIDIn, string WarehouseIDOut)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Data", VALUE = Data },
                    new SqlParameterHelper(){PARAMETR_NAME = "@sequence_id_in", VALUE = SequenceIDIn },
                    new SqlParameterHelper(){PARAMETR_NAME = "@sequence_id_out", VALUE = SequenceIDOut },
                    new SqlParameterHelper(){PARAMETR_NAME = "@warehouse_id_in", VALUE = WarehouseIDIn },
                    new SqlParameterHelper(){PARAMETR_NAME = "@warehouse_id_out", VALUE = WarehouseIDOut },

                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_INSERT_IM_TUKAR_BARANG]", sqlParameter);
                return $"{result[0].Rows[0].ItemArray.ElementAt(0)}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ReadGSGenHarcoded()
        {
            DataTable result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"select gh_function_code,gh_function_desc from GS_GEN_HARDCODED where gh_sys='H' and gh_function_name='TUKAR_BARANG_TXN_CODE'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public DataTable GetTxnType(string TxnType)
        {
            DataTable result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[sp_GET_TXN_TUKAR_BARANG] '{TxnType}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}