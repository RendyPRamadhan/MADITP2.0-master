using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;

namespace MADITP2._0.DataAccess.IM
{
    class IMWarehouseSecurityDA
    {
        private clsGlobal Helper;
        private string mReason;

        public string Reason { get => mReason; set => mReason = value; }

        public IMWarehouseSecurityDA(clsGlobal helper)
        {
            Helper = helper;
            Reason = null;
        }

        public Boolean Post(IMWarehouseSecurityBL item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_user_id", VALUE = item.User_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_warehouse_id", VALUE = item.Warehouse_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_input_txn_allow", VALUE = item.Input_txn_allow },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_transfer_txn_allow", VALUE = item.Transfer_txn_allow },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_initial_physical", VALUE = item.Initial_physical },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_realese_physical", VALUE = item.Realese_physical },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_shipment_entry", VALUE = item.Shipment_entry },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_receipt_entry", VALUE = item.Receipt_entry }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_IM_WAREHOUSE_SECURITY", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Not found warehouse_id!";
                    return false;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return false;
            }

            return true;
        }

        public Boolean Put(int Id, IMWarehouseSecurityBL item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_id", VALUE = Id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_user_id", VALUE = item.User_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_warehouse_id", VALUE = item.Warehouse_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_input_txn_allow", VALUE = item.Input_txn_allow },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_transfer_txn_allow", VALUE = item.Transfer_txn_allow },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_initial_physical", VALUE = item.Initial_physical },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_realese_physical", VALUE = item.Realese_physical },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_shipment_entry", VALUE = item.Shipment_entry },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ws_receipt_entry", VALUE = item.Receipt_entry }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_IM_WAREHOUSE_SECURITY", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Not found warehouse_id!";
                    return false;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return false;
            }

            return true;
        }

        public Boolean Delete(int Id)
        {
            string sql = $"DELETE FROM IM_WAREHOUSE_SECURITY WHERE ws_id = '{Id}';";
            try
            {
                Helper.BeginTrans();
                Helper.ExecuteTrans(sql);
                Helper.CommitTrans();
            }
            catch (Exception e)
            {
                Helper.RollbackTrans();
                Console.WriteLine(e.StackTrace);
                Reason = e.Message.ToString();
                return false;
            }

            return true;
        }

        public List<IMWarehouseSecurityBL> Read(EnumFilter filter, int offset = 0, int perpage = (int)EnumFetchData.DefaultLimit, IMWarehouseSecurityBL security = null, string search = null) 
        {
            DataTable dt = new DataTable();
            string filterSecurity = "";
            if (security != null && !string.IsNullOrEmpty(security.User_id))
            {
                filterSecurity = security.User_id;
            }

            if (search == null)
            {
                search = "";
            }

            List<IMWarehouseSecurityBL> result = new List<IMWarehouseSecurityBL>();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_WAREHOUSE_SECURITY_GET_ALL(-1, -1, '{filterSecurity}', '{search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_WAREHOUSE_SECURITY_GET_ALL({offset}, {perpage}, '{filterSecurity}', '{search}')");
                        break;
                }
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message.ToString());
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                result = Helper.ConvertDataTableToList<IMWarehouseSecurityBL>(dt);
            }

            return result;
        }

        public int CountRows(IMWarehouseSecurityBL security = null, string search = null)
        {
            string filterSecurity = "";
            if (security != null && !string.IsNullOrEmpty(security.User_id))
            {
                filterSecurity = security.User_id;
            }

            if (search == null)
            {
                search = "";
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Id) as jumlah from FUNCTION_IM_WAREHOUSE_SECURITY_GET_ALL(-1, -1, '{filterSecurity}', '{search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }

        public IMWarehouseSecurityBL GetSecurity(int Id)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_WAREHOUSE_SECURITY_GET({Id})");
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<IMWarehouseSecurityBL>(dt);
        }
    }
}
