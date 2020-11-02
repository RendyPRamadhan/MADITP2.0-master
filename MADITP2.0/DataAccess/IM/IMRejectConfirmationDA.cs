using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.IM
{
    class IMRejectConfirmationDA
    {
        clsGlobal Helper = null;
        clsAlert clsAlert;

        public IMRejectConfirmationDA(clsGlobal helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                clsAlert = new clsAlert();
            }
        }

        public DataTable ReadHeader(EnumFilter filter, IMTransferConfirmationBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _IsDate = false, DateTime? _FromDate = null, DateTime? _ToDate = null)
        {
            DataTable result = new DataTable();
            int _Offset;
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_WITH_PAGING:
                        _Offset = fetchLimit * (currentPage - 1);
                        //NB : CHECK USER GROUP DAN BRANCHFLAG
                        result = Helper.ExecuteQuery($"[sp_IM_GET_CONFIRMATION_TRANSFER_HEADER] 'GETDATA','{clsBL.st_gl_txn_type}', '{clsBL.st_from_warehouse_id}', '{clsBL.st_to_warehouse_id}', '{ _IsDate }', '{ _FromDate }', '{ _ToDate }', '{ clsBL.st_txn_reference }', '{_Offset}', '{fetchLimit}' ");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_IM_GET_CONFIRMATION_TRANSFER_HEADER] 'GETCOUNT','{clsBL.st_gl_txn_type}','{clsBL.st_from_warehouse_id}', '{clsBL.st_to_warehouse_id}', '{ _IsDate }', '{ _FromDate }', '{ _ToDate }', '{ clsBL.st_txn_reference }', '{_Offset}', '{fetchLimit}' ");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ReadDetail(EnumFilter filter, IMTransferConfirmationBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            DataTable result = new DataTable();
            int _Offset;
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_WITH_PAGING:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_IM_GET_CONFIRMATION_TRANSFER_DETAIL] 'GETDATA', '{clsBL.st_txn_reference}', '{_Offset}', '{fetchLimit}' ");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_IM_GET_CONFIRMATION_TRANSFER_DETAIL] 'GETCOUNT', '{clsBL.st_txn_reference}', '{_Offset}', '{fetchLimit}' ");
                        break;
                    case EnumFilter.GET_ALL:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_IM_GET_CONFIRMATION_TRANSFER_DETAIL] 'GETALL', '{clsBL.st_txn_reference}', '{_Offset}', '{fetchLimit}' ");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public bool Post(List<IMTransferConfirmationBL> ArrayclsBL)
        {
            bool _isSucess = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsGlobal.ConnectionString))
                {
                    conn.Open();
                    SqlTransaction Transaction;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        Transaction = conn.BeginTransaction();

                        //PROCESS_IM_STOCK_TXN_TRANSFER
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_PROCESS_IM_STOCK_TXN_TRANSFER_REJECT_CONFIRMATION]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;

                        for (int j = 0; j <= ArrayclsBL.Count - 1; j++)
                        {
                            adapter.SelectCommand.Parameters.Clear();
                            adapter.SelectCommand.Parameters.AddWithValue("@st_warehouse_id", ArrayclsBL[j].st_warehouse_id);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_txn_type_code", ArrayclsBL[j].st_txn_type_code);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_transfer_status", ArrayclsBL[j].st_transfer_status);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_txn_quantity", ArrayclsBL[j].st_txn_quantity);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_txn_cost_value", ArrayclsBL[j].st_txn_cost_value);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_product_id", ArrayclsBL[j].st_product_id);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_txn_type_index", ArrayclsBL[j].st_txn_type_index);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_txn_date", ArrayclsBL[j].st_txn_date);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_txn_reference", ArrayclsBL[j].st_txn_reference);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_txn_description", ArrayclsBL[j].st_txn_description);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_from_warehouse_id", ArrayclsBL[j].st_from_warehouse_id);
                            adapter.SelectCommand.Parameters.AddWithValue("@st_to_warehouse_id", ArrayclsBL[j].st_to_warehouse_id);
                            adapter.SelectCommand.Parameters.AddWithValue("@User_id", ArrayclsBL[j].st_user_id);
                            adapter.SelectCommand.Parameters.AddWithValue("@sIMTranWithTransit", ArrayclsBL[j].transitSts);
                            adapter.SelectCommand.Parameters.AddWithValue("@sTxn_type_out_from_org_wh", ArrayclsBL[j].type);
                            adapter.SelectCommand.ExecuteNonQuery();
                        }

                        Transaction.Commit();
                        _isSucess = true;
                    }
                }
            }
            catch (Exception)
            {
                _isSucess = false;
            }

            return _isSucess;
        }

        public List<ComboBoxViewModel> GetTxnTypeToComboBox(string _UserID, bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_TRANSFER_TXN_TYPE]('{ _UserID }')");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["ttt_transfer_txn_type_code"]}",
                              ValueMember = $"{dr["ttt_transfer_txn_type_description"]}"
                          }).Where(x => x.ValueMember.Trim() != "0").ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "0" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetWarehouseFromToComboBox(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_WH_FROM_CONFIRMATION_TRANSFER]() ORDER BY wh_warehouse_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["wh_warehouse_id"]}",
                              ValueMember = $"{dr["wh_warehouse_description"]}"
                          }).Where(x => x.ValueMember.Trim() != "0").ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "0" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetWarehouseToToComboBox(bool _isAll, string _UserID)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_WH_TO_CONFIRMATION_TRANSFER]('{ _UserID }') ORDER BY ws_warehouse_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["ws_warehouse_id"]}",
                              ValueMember = $"{dr["wh_warehouse_description"]}"
                          }).Where(x => x.ValueMember.Trim() != "0").ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "0" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetDateOpenIM()
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT gfc_period, gfc_ending_date FROM [FUNCTION_IM_GET_ENDING_DATE_FISCAL_CALENDER_SALES_ORDER_RELEASE]()");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetSystemDate()
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT SystemDate as gfc_ending_date FROM [FUNCTION_GET_SYSTEM_DATE]()");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetTransitWHID(string _WarehouseID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT wh_transit_warehouse_id FROM [FUNCTION_IM_GET_TRANSIT_WH_CONFIRMATION_TRANSFER]('{ _WarehouseID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetTransferTxnTypeByID(string _TransType)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_TRANSFER_TXN_TYPE_BY_ID]('{ _TransType }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }
    }
}
