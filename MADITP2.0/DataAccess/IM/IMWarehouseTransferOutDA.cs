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
using System.Windows;

namespace MADITP2._0.DataAccess.IM
{
    class IMWarehouseTransferOutDA
    {
        clsGlobal Helper = null;
        clsAlert clsAlert;

        public IMWarehouseTransferOutDA(clsGlobal helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                clsAlert = new clsAlert();
            }
        }

        public DataTable Read(EnumFilter filter, IMWarehouseTransferOutBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
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
                        result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_TXN_WH_TRANSFER_OUT]('GETDATA','{clsBL.st_gl_txn_type}', '{clsBL.st_txn_reference}','{clsBL.st_from_warehouse_id}', '{clsBL.st_to_warehouse_id}', '{_Offset}', '{fetchLimit}')");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"SELECT COUNT(*) AS TotalRows FROM [FUNCTION_IM_GET_TXN_WH_TRANSFER_OUT]('GETCOUNT','{clsBL.st_gl_txn_type}', '{clsBL.st_txn_reference}','{clsBL.st_from_warehouse_id}', '{clsBL.st_to_warehouse_id}', '{_Offset}', '{fetchLimit}')");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ReadDetail(EnumFilter filter, IMWarehouseTransferOutBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
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
                        result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_TXN_DETAIL_WH_TRANSFER_OUT]('GETDATA', '{clsBL.st_txn_reference}', '{_Offset}', '{fetchLimit}')");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"SELECT COUNT(*) AS TotalRows FROM [FUNCTION_IM_GET_TXN_DETAIL_WH_TRANSFER_OUT]('GETCOUNT', '{clsBL.st_txn_reference}', '{_Offset}', '{fetchLimit}')");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public bool Post(List<IMWarehouseTransferOutBL> ArrayclsBL, bool _IsSendEmail, string _EmailTo, string _TransTypeSeqNo)
        {
            bool _isSucessAll = false;
            bool _isSucessStock = false;
            bool _isSucessEmail = false;

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
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_PROCESS_IM_STOCK_TXN_TRANSFER_OUT]", conn, Transaction);
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
                            adapter.SelectCommand.ExecuteNonQuery();
                        }

                        _isSucessStock = true;

                        if(_IsSendEmail == true)
                        {
                            //IP_EMAIL_TRT
                            adapter.SelectCommand = new SqlCommand("[dbo].[IP_EMAIL_TRT]", conn, Transaction);
                            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                            adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                            adapter.SelectCommand.Parameters.Clear();
                            adapter.SelectCommand.Parameters.AddWithValue("@emailTo", _EmailTo);
                            adapter.SelectCommand.Parameters.AddWithValue("@Ref", _TransTypeSeqNo);
                            adapter.SelectCommand.ExecuteNonQuery();

                            _isSucessEmail = true;
                        }
                        else
                        {
                            _isSucessEmail = true;
                        }

                        if (_isSucessStock == true && _isSucessEmail == true)
                        {
                            Transaction.Commit();
                            _isSucessAll = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                _isSucessAll = false;
            }

            return _isSucessAll;
        }

        public bool updateSeqNo(string _sType, string _SeqNo)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@sn_id_1", VALUE = _sType },
                    new SqlParameterHelper(){PARAMETR_NAME = "@sn_last_number_2", VALUE = _SeqNo }
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_EDIT_IM_SEQUENCE]", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 1)
                {
                    _isSucess = true;
                }
            }
            catch (Exception)
            {
                _isSucess = false;
            }

            return _isSucess;
        }

        public List<ComboBoxViewModel> GetTransferTxnTypeToComboBox(string _UserID, bool _isAll)
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

        public DataTable GetUserWH(string _UserID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"select User_PIM FROM [FUNCTION_IM_GET_USER_WH]('{ _UserID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public List<ComboBoxViewModel> GetWarehouseWHToComboBox(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_WAREHOUSE_WH]() ORDER BY wh_warehouse_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["wh_warehouse_id"] + " - " + dr["wh_warehouse_description"]}",
                              ValueMember = $"{dr["wh_warehouse_id"]}"
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

        public List<ComboBoxViewModel> GetWarehouseToComboBox(string _UserID, bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT wh_warehouse_id, wh_warehouse_description FROM [FUNCTION_IM_GET_WAREHOUSE]('{ _UserID }') ORDER BY wh_warehouse_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["wh_warehouse_id"] + " - " + dr["wh_warehouse_description"]}",
                              ValueMember = $"{dr["wh_warehouse_id"]}"
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

        public List<ComboBoxViewModel> GetWarehouseEditorToComboBox(string _UserID, bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT wh_warehouse_id, wh_warehouse_description, wh_transit_warehouse_id FROM [FUNCTION_IM_GET_WAREHOUSE_EDITOR]('{ _UserID }') ORDER BY wh_warehouse_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["wh_warehouse_description"]}",
                              ValueMember = $"{dr["wh_warehouse_id"]}"
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

        public DataTable GetWarehouseEditorByID(string _WarehouseID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_WAREHOUSE_EDITOR_BY_ID]('{ _WarehouseID }')");
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

        public List<ComboBoxViewModel> GetWarehouseByIDEditor(string _WarehouseID, string _TransType, bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_WAREHOUSE_BY_WHID]('{ _TransType }', '{ _WarehouseID }') ORDER BY wh_warehouse_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["wh_warehouse_description"]}",
                              ValueMember = $"{dr["wh_warehouse_id"]}"
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

        public DataTable GetSNIDDetail(string _SNID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_SN_ID]('{ _SNID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetProductByID(string _ProductID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_PRODUCT_MASTER_BY_ID]('{ _ProductID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetCostSTDByPID(string _ProductID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_COST_STD_BY_PID]('{ _ProductID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetQtyProduct(string _ProductID, string _WarehouseID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_IM_GET_QTY_PRODUCT]('{ _ProductID }', '{ _WarehouseID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetContactPerson(string _WarehouseID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT wh_contact_person FROM [FUNCTION_IM_GET_CONTACT_PERSON]('{ _WarehouseID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetEntityBranchDesc(string _Reference)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT ec_entity, bc_branch, bc_remark, dc_division FROM [FUNCTION_IM_GET_ENTITY_BRANCH_DESC]('{ _Reference }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetEntityBranchDescOpt(string _UserID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT ec_entity, usr_branch_id, bc_branch, bc_remark FROM [FUNCTION_IM_GET_ENTITY_BRANCH_DESC_OPT]('{ _UserID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetEmailAddress(string _WarehouseFrom, string _WarehouseTo)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"sp_WHID_EMAIL_ADDRESS '{ _WarehouseFrom }', '{ _WarehouseTo }'");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }
    }
}
