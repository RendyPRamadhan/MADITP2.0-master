using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MADITP2._0.businessLogic.SO;
using MADITP2._0.Global;
using MADITP2._0.Enums;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using MADITP2._0.login;
using System.Data.SqlClient;
using MADITP2._0.BusinessLogic.SO;

namespace MADITP2._0.DataAccess.SO
{
    class SOVerificationProcessDA
    {
        clsGlobal Helper = null;
        clsAlert clsAlert;

        public SOVerificationProcessDA(clsGlobal helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                clsAlert = new clsAlert();
            }
        }

        public DataTable ReadVsa(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _StateCboEntity = true, bool _StateCboBranch = true, string _UserID = "")
        {
            int _Offset;
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_WITH_PAGING:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_VERIFICATOR_SCHEDULE_ASSIGNMENT] '{"GETDATA"}','{clsBL.entity_id}', '{clsBL.branch_id}', '{clsBL.verificator_id}', '{clsBL.so_kp_no}', '{_StateCboEntity}', '{_StateCboBranch}', '{_Offset}', '{fetchLimit}', '{_UserID}'");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_VERIFICATOR_SCHEDULE_ASSIGNMENT] '{"GETCOUNT"}','{clsBL.entity_id}', '{clsBL.branch_id}', '{clsBL.verificator_id}', '{clsBL.so_kp_no}', '{_StateCboEntity}', '{_StateCboBranch}', '{_Offset}', '{fetchLimit}', '{_UserID}'");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert = new clsAlert();
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ReadKp(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            int _Offset;
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_WITH_PAGING:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_VERIFICATOR_SCHEDULE_ASSIGNMENT_KP] '{"GETDATA"}', '{clsBL.verificator_id}', '{clsBL.so_kp_no}', '{_Offset}', '{fetchLimit}'");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_VERIFICATOR_SCHEDULE_ASSIGNMENT_KP] '{"GETCOUNT"}', '{clsBL.verificator_id}', '{clsBL.so_kp_no}', '{_Offset}', '{fetchLimit}'");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert = new clsAlert();
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ReadVs(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _StateCboEntity = true, bool _StateCboBranch = true, bool _StateCboDivision = true, string _UserID = "", bool _IsKPDate = true, bool _IsAssignDate = true)
        {
            int _Offset;
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_WITH_PAGING:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_VERIFICATION_STATUS_KP] '{"GETDATA"}','{clsBL.entity_id}', '{_StateCboEntity}', '{clsBL.branch_id}', '{_StateCboBranch}', '{clsBL.division_id}', '{_StateCboDivision}', '{clsBL.so_kp_no}', '{clsBL.verificator_id}', '{clsBL.verification_status}', '{clsBL.dp_status}', '{clsBL.type_of_activity}', '{_UserID}', '{clsBL.customer_id}', '{clsBL.customer_name}', '{_IsKPDate}', '{clsBL.so_kp_date_from.ToString("yyyy-MM-dd")}' , '{clsBL.so_kp_date_until.ToString("yyyy-MM-dd")}', '{_IsAssignDate}', '{clsBL.assignment_date.ToString("yyyy-MM-dd")}', {_Offset}, {fetchLimit}");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_VERIFICATION_STATUS_KP] '{"GETCOUNT"}','{clsBL.entity_id}', '{_StateCboEntity}', '{clsBL.branch_id}', '{_StateCboBranch}', '{clsBL.division_id}', '{_StateCboDivision}', '{clsBL.so_kp_no}', '{clsBL.verificator_id}', '{clsBL.verification_status}', '{clsBL.dp_status}', '{clsBL.type_of_activity}', '{_UserID}', '{clsBL.customer_id}', '{clsBL.customer_name}', '{_IsKPDate}', '{clsBL.so_kp_date_from.ToString("yyyy-MM-dd")}' , '{clsBL.so_kp_date_until.ToString("yyyy-MM-dd")}', '{_IsAssignDate}', '{clsBL.assignment_date.ToString("yyyy-MM-dd")}', {_Offset}, {fetchLimit}");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert = new clsAlert();
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ReadActivity(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            int _Offset;
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_WITH_PAGING:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_VERIFICATION_STATUS_ACTIVITY] '{"GETDATA"}','{clsBL.so_kp_no}', '{clsBL.verificator_id}', '{clsBL.type_of_activity}', {_Offset}, {fetchLimit}");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_VERIFICATION_STATUS_ACTIVITY] '{"GETCOUNT"}','{clsBL.so_kp_no}', '{clsBL.verificator_id}', '{clsBL.type_of_activity}', {_Offset}, {fetchLimit}");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert = new clsAlert();
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ReadSor(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _StateCboEntity = true, bool _StateCboBranch = true, bool _StateCboDivision = true, string _UserID = "", bool _IsAssignDate = true)
        {
            int _Offset;
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_WITH_PAGING:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_SALES_ORDER_RELEASE] '{"GETDATA"}','{clsBL.entity_id}', '{_StateCboEntity}', '{clsBL.branch_id}', '{_StateCboBranch}', '{clsBL.division_id}', '{_StateCboDivision}', '{clsBL.so_kp_no}', '{clsBL.verificator_id}', '{clsBL.verification_status}', '{_UserID}', '{clsBL.customer_name}', '{_IsAssignDate}', '{clsBL.assignment_date.ToString("yyyy-MM-dd")}', {_Offset}, {fetchLimit}");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"[sp_SO_GET_SALES_ORDER_RELEASE] '{"GETCOUNT"}','{clsBL.entity_id}', '{_StateCboEntity}', '{clsBL.branch_id}', '{_StateCboBranch}', '{clsBL.division_id}', '{_StateCboDivision}', '{clsBL.so_kp_no}', '{clsBL.verificator_id}', '{clsBL.verification_status}', '{_UserID}', '{clsBL.customer_name}', '{_IsAssignDate}', '{clsBL.assignment_date.ToString("yyyy-MM-dd")}', {_Offset}, {fetchLimit}");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert = new clsAlert();
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ValidateSOKPNumberVSA(string _KPNumber)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_VALIDATE_KP_NO_VERIFICATOR_SCHEDULE_ASSIGNMET]('{ _KPNumber }') ");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetSOKPNumberDetailVSA(string _DataType, string _KPNumber, string _VerificatirEntityID, string _VerificatorName, String _VerificatorBranchID)
        {
            var dt = new DataTable();
            try
            {
                    dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_DISPLAY_KP_NO_VERIFICATOR_SCHEDULE_ASSIGNMET]('{ _DataType }', '{ _KPNumber }', '{ _VerificatirEntityID }', '{ _VerificatorName }', '{ _VerificatorBranchID }') ");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public List<ComboBoxViewModel> GetSOKPNumberToComboBoxVSEditor(string _DataType, string _VerificatirEntityID)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_KP_NO_BY_VER_ID_VERIFICATION_STATUS]('{ _DataType }', '{ _VerificatirEntityID }') ");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["svs_so_kp_num"]}",
                              ValueMember = $"{dr["svs_so_kp_num"]}"
                          }).ToList();
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetSOKPNumberDetailVsEditor(string _KPNumber, string _VerificatirEntityID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_KP_NO_DETAIL_VERIFICATION_STATUS]('{ _KPNumber }', '{ _VerificatirEntityID }') ");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetQualificationHeader()
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT sqh_qualifier, sqh_coefficient_value, sqh_Point_Range, sqh_value, sqh_total_value FROM [FUNCTION_SO_GET_QUALIFIER_HEADER_VERIFICATION_STATUS]()");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetQualificationDetail()
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_QUALIFIER_DETAIL_VERIFICATION_STATUS]()");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetQualifierValue(string _VerID, string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_QUALIFIER_VALUE_VERIFICATION_STATUS]('{_VerID}', '{_KPNo}')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetQualificationActivity(string _VerID, string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_QUALIFICATION_ACTIVITY_VERIFICATION_STATUS]('{_VerID}', '{_KPNo}')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetMemoVisitingActivity(string _VerID, string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_REMARKS_VERIFICATION_STATUS]('{_VerID}', '{_KPNo}')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetNotesVisitingActivity(string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_NOTES_KP_HEADER_VERIFICATION_STATUS]('{_KPNo}')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetVerificationCustomer(string _CustID)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_QUALIFIER_CUSTOMER_VERIFICATION_STATUS]('{ _CustID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetReasonCodesToComboBox()
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_REASON_CODES]()");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["rc_reason"]}",
                              ValueMember = $"{dr["rc_reason_id"]}"
                          }).ToList();
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetCollectorToComboBox(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT cm_collector_id, cm_collector_name FROM [FUNCTION_SO_GET_COLLECTOR_SALES_ORDER_RELEASE]() ORDER BY cm_collector_name ");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["cm_collector_name"]}",
                              ValueMember = $"{dr["cm_collector_id"]}"
                          }).ToList();
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

        public bool Post(SOVerificationProcessBL clsBL)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    //new SqlParameterHelper(){PARAMETR_NAME = "@flag", VALUE = "NEW" },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VerificatorID", VALUE = clsBL.verificator_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@KpNumber", VALUE= clsBL.so_kp_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@AssignDate", VALUE = clsBL.assignment_date },
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_ADD_SO_VERIFICATION_ASSIGN]", sqlParameter);
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

        public bool Put(string _VerificatorIDOld, SOVerificationProcessBL clsBL)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@VerificatorIDOld", VALUE = _VerificatorIDOld },
                    new SqlParameterHelper(){PARAMETR_NAME = "@KPNumber", VALUE= clsBL.so_kp_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@AssignDate", VALUE = clsBL.assignment_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VerificatorIDNew", VALUE = clsBL.verificator_id }
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_EDIT_SO_VERIFICATION_ASSIGN]", sqlParameter);
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

        public bool PostVS(DataGridView grdQualifierDetail, DataGridView grdVisitingActivity, DataGridView grdQualifierHeader, SOVerificationProcessBL clsBL, string _VisaAuto)
        {
            bool _isSucessAll = false;
            bool _isSucessSUVerCust = false;
            bool _isSucessUpdateVisa1 = false;
            bool _isSucessDeleteVerActivity = false;
            bool _isSucessReSaveVerActivity = false;
            bool _isSucessUpdateVisa2 = false;
            bool _IsSucessStatusQualifier = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsGlobal.ConnectionString))
                {
                    conn.Open();
                    SqlTransaction Transaction;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        Transaction = conn.BeginTransaction();

                        //SAVE OR UPDATE SO_VERIFICATION_CUSTOMER
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_ADD_UPDATE_SO_VERIFICATION_CUSTOMER]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;

                        foreach (DataGridViewRow row in grdQualifierDetail.Rows)
                        {
                            adapter.SelectCommand.Parameters.Clear();
                            adapter.SelectCommand.Parameters.AddWithValue("@CustID", clsBL.customer_id);
                            adapter.SelectCommand.Parameters.AddWithValue("@GroupID", row.Cells["sqh_qualifier_id"].Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@DetailID", row.Cells["sqd_qualifier_index_num"].Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@Remarks", row.Cells["grdDesc"].Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@Status", (Convert.ToBoolean(row.Cells["grdStatus"].Value) == true) ? "Y" : "N");
                            adapter.SelectCommand.Parameters.AddWithValue("@Value", row.Cells["grdValue"].Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@EntryBy", clsLogin.USERID);
                            adapter.SelectCommand.ExecuteNonQuery();
                        }
                        _isSucessSUVerCust = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //UPDATE VISA AUTO SO_CUSTOMER_MASTER
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_UPDATE_SO_CUSTOMER_MASTER]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@CustID", clsBL.customer_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@VisaAuto", _VisaAuto);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _isSucessUpdateVisa1 = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //DELETE SO_VERIFICATION_ACTIVITY
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_DELETE_SO_VERIFICATION_ACTIVITY]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@EntityID", clsBL.entity_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@BranchID", clsBL.branch_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@DivisionID", clsBL.division_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _isSucessDeleteVerActivity = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //RE-SAVE SO_VERIFICATION_ACTIVITY
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_ADD_SO_VERIFICATION_ACTIVITY]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;

                        foreach (DataGridViewRow row in grdVisitingActivity.Rows)
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["grdChbDelete"];
                            if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                            {
                                adapter.SelectCommand.Parameters.Clear();
                                adapter.SelectCommand.Parameters.AddWithValue("@DataType", "ADD");
                                adapter.SelectCommand.Parameters.AddWithValue("@EntityID", clsBL.entity_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@BranchID", clsBL.branch_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@DivisionID", clsBL.division_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                                adapter.SelectCommand.Parameters.AddWithValue("@ActivityDate", row.Cells["grdDtDate"].Value);
                                adapter.SelectCommand.Parameters.AddWithValue("@ActivityTime", Convert.ToDateTime(row.Cells["grdDtTime"].Value).ToString("HH:mm"));
                                adapter.SelectCommand.Parameters.AddWithValue("@TypeOfActivity", row.Cells["grdCboActivity"].Value);
                                adapter.SelectCommand.Parameters.AddWithValue("@Comment", row.Cells["grdTxtComment"].Value);
                                adapter.SelectCommand.ExecuteNonQuery();
                            }
                        }

                        _isSucessReSaveVerActivity = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //UPDATE VISA AUTO SO_CUSTOMER_MASTER BASED ON SO_INVOICE_HEADER
                        DataTable dt = Helper.ExecuteQuery($"Select * from [FUNCTION_SO_GET_CUSTOMER_ID_FROM_SIH_VERIFICATION_STATUS]('{clsBL.so_kp_no}')");

                        if(dt.Rows.Count > 0)
                        {
                            foreach(DataRow dr in dt.Rows)
                            {
                                adapter.SelectCommand = new SqlCommand("[dbo].[sp_UPDATE_SO_CUSTOMER_MASTER]", conn, Transaction);
                                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                                adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                                adapter.SelectCommand.Parameters.Clear();
                                adapter.SelectCommand.Parameters.AddWithValue("@CustID", dr["sih_customer_id"].ToString());
                                adapter.SelectCommand.Parameters.AddWithValue("@VisaAuto", _VisaAuto);
                                adapter.SelectCommand.ExecuteNonQuery();
                            }
                        }

                        _isSucessUpdateVisa2 = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //SAVE SO_VERIFICATION_STATUS_QUALIFIER
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_ADD_SO_VERIFICATION_STATUS_QUALIFIER]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierHartaValue", grdQualifierHeader.Rows[0].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierKarakterValue", grdQualifierHeader.Rows[1].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierStatusValue", grdQualifierHeader.Rows[2].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierLokasiValue", grdQualifierHeader.Rows[3].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierKondisiValue", grdQualifierHeader.Rows[4].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierTotalValue", clsBL.qualifier_total_value);
                        adapter.SelectCommand.Parameters.AddWithValue("@RemarkActivity", clsBL.remark_activity);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _IsSucessStatusQualifier = true;

                        if(_isSucessSUVerCust == true && _isSucessUpdateVisa1 == true && _isSucessDeleteVerActivity == true && _isSucessReSaveVerActivity == true && _isSucessUpdateVisa2 == true && _IsSucessStatusQualifier == true)
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

        public bool PutVS(DataGridView grdVisitingActivity, SOVerificationProcessBL clsBL, string _VisaAuto)
        {
            bool _isSucessAll = false;
            bool _isSucessUpdateRemark = false;
            bool _isSucessUpdateVisa1 = false;
            bool _isSucessDeleteVerActivity = false;
            bool _isSucessReSaveVerActivity = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsGlobal.ConnectionString))
                {
                    conn.Open();
                    SqlTransaction Transaction;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        Transaction = conn.BeginTransaction();

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //UPDATE REMARK SO_VERIFICATION_STATUS
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_UPDATE_REMARK_SO_VERIFICATION_STATUS]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                        adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@RemarkActivity", clsBL.remark_activity);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _isSucessUpdateRemark = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //UPDATE VISA AUTO SO_CUSTOMER_MASTER
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_UPDATE_SO_CUSTOMER_MASTER]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@CustID", clsBL.customer_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@VisaAuto", _VisaAuto);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _isSucessUpdateVisa1 = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //DELETE SO_VERIFICATION_ACTIVITY
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_DELETE_SO_VERIFICATION_ACTIVITY]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@EntityID", clsBL.entity_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@BranchID", clsBL.branch_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@DivisionID", clsBL.division_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _isSucessDeleteVerActivity = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //RE-SAVE SO_VERIFICATION_ACTIVITY
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_ADD_SO_VERIFICATION_ACTIVITY]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;

                        foreach (DataGridViewRow row in grdVisitingActivity.Rows)
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["grdChbDelete"];
                            if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                            {
                                adapter.SelectCommand.Parameters.Clear();
                                adapter.SelectCommand.Parameters.AddWithValue("@DataType", "EDIT");
                                adapter.SelectCommand.Parameters.AddWithValue("@EntityID", clsBL.entity_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@BranchID", clsBL.branch_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@DivisionID", clsBL.division_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                                adapter.SelectCommand.Parameters.AddWithValue("@ActivityDate", row.Cells["grdDtDate"].Value);
                                adapter.SelectCommand.Parameters.AddWithValue("@ActivityTime", Convert.ToDateTime(row.Cells["grdDtTime"].Value).ToString("HH:mm"));
                                adapter.SelectCommand.Parameters.AddWithValue("@TypeOfActivity", row.Cells["grdCboActivity"].Value);
                                adapter.SelectCommand.Parameters.AddWithValue("@Comment", row.Cells["grdTxtComment"].Value);
                                adapter.SelectCommand.ExecuteNonQuery();
                            }
                        }

                        _isSucessReSaveVerActivity = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        if (_isSucessUpdateRemark == true && _isSucessUpdateVisa1 == true && _isSucessDeleteVerActivity == true && _isSucessReSaveVerActivity == true)
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

        public bool PutReleaseVS(DataGridView grdQualifierDetail, DataGridView grdVisitingActivity, DataGridView grdQualifierHeader, SOVerificationProcessBL clsBL, string _VisaAuto)
        {
            bool _isSucessAll = false;
            bool _isSucessSUVerCust = false;
            bool _isSucessUpdateVisa1 = false;
            bool _isSucessDeleteVerActivity = false;
            bool _isSucessReSaveVerActivity = false;
            bool _isSucessUpdateVisa2 = false;
            bool _IsSucessStatusQualifier = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsGlobal.ConnectionString))
                {
                    conn.Open();
                    SqlTransaction Transaction;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        Transaction = conn.BeginTransaction();

                        //SAVE OR UPDATE SO_VERIFICATION_CUSTOMER
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_ADD_UPDATE_SO_VERIFICATION_CUSTOMER]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;

                        foreach (DataGridViewRow row in grdQualifierDetail.Rows)
                        {
                            adapter.SelectCommand.Parameters.Clear();
                            adapter.SelectCommand.Parameters.AddWithValue("@CustID", clsBL.customer_id);
                            adapter.SelectCommand.Parameters.AddWithValue("@GroupID", row.Cells["sqh_qualifier_id"].Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@DetailID", row.Cells["sqd_qualifier_index_num"].Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@Remarks", row.Cells["grdDesc"].Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@Status", (Convert.ToBoolean(row.Cells["grdStatus"].Value) == true) ? "Y" : "N");
                            adapter.SelectCommand.Parameters.AddWithValue("@Value", row.Cells["grdValue"].Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@EntryBy", clsLogin.USERID);
                            adapter.SelectCommand.ExecuteNonQuery();
                        }
                        _isSucessSUVerCust = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //UPDATE VISA AUTO SO_CUSTOMER_MASTER
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_UPDATE_SO_CUSTOMER_MASTER]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@CustID", clsBL.customer_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@VisaAuto", _VisaAuto);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _isSucessUpdateVisa1 = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //DELETE SO_VERIFICATION_ACTIVITY
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_DELETE_SO_VERIFICATION_ACTIVITY]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@EntityID", clsBL.entity_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@BranchID", clsBL.branch_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@DivisionID", clsBL.division_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _isSucessDeleteVerActivity = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //RE-SAVE SO_VERIFICATION_ACTIVITY
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_ADD_SO_VERIFICATION_ACTIVITY]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;

                        foreach (DataGridViewRow row in grdVisitingActivity.Rows)
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["grdChbDelete"];
                            if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                            {
                                adapter.SelectCommand.Parameters.Clear();
                                adapter.SelectCommand.Parameters.AddWithValue("@DataType", "ADD");
                                adapter.SelectCommand.Parameters.AddWithValue("@EntityID", clsBL.entity_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@BranchID", clsBL.branch_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@DivisionID", clsBL.division_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                                adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                                adapter.SelectCommand.Parameters.AddWithValue("@ActivityDate", row.Cells["grdDtDate"].Value);
                                adapter.SelectCommand.Parameters.AddWithValue("@ActivityTime", Convert.ToDateTime(row.Cells["grdDtTime"].Value).ToString("HH:mm"));
                                adapter.SelectCommand.Parameters.AddWithValue("@TypeOfActivity", row.Cells["grdCboActivity"].Value);
                                adapter.SelectCommand.Parameters.AddWithValue("@Comment", row.Cells["grdTxtComment"].Value);
                                adapter.SelectCommand.ExecuteNonQuery();
                            }
                        }

                        _isSucessReSaveVerActivity = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //UPDATE VISA AUTO SO_CUSTOMER_MASTER BASED ON SO_INVOICE_HEADER
                        DataTable dt = Helper.ExecuteQuery($"Select * from [FUNCTION_SO_GET_CUSTOMER_ID_FROM_SIH_VERIFICATION_STATUS]('{clsBL.so_kp_no}')");

                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                adapter.SelectCommand = new SqlCommand("[dbo].[sp_UPDATE_SO_CUSTOMER_MASTER]", conn, Transaction);
                                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                                adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                                adapter.SelectCommand.Parameters.Clear();
                                adapter.SelectCommand.Parameters.AddWithValue("@CustID", dr["sih_customer_id"].ToString());
                                adapter.SelectCommand.Parameters.AddWithValue("@VisaAuto", _VisaAuto);
                                adapter.SelectCommand.ExecuteNonQuery();
                            }
                        }

                        _isSucessUpdateVisa2 = true;

                        //--------------------------------------------------------------------------------------------------------------------------------

                        //EDIT SO_VERIFICATION_STATUS_QUALIFIER
                        adapter.SelectCommand = new SqlCommand("[dbo].[sp_EDIT_SO_VERIFICATION_STATUS_QUALIFIER]", conn, Transaction);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandTimeout = Helper.SqlCommandTimeOut;
                        adapter.SelectCommand.Parameters.Clear();
                        adapter.SelectCommand.Parameters.AddWithValue("@VerificatorID", clsBL.verificator_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@KPNo", clsBL.so_kp_no);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierHartaValue", grdQualifierHeader.Rows[0].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierKarakterValue", grdQualifierHeader.Rows[1].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierStatusValue", grdQualifierHeader.Rows[2].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierLokasiValue", grdQualifierHeader.Rows[3].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierKondisiValue", grdQualifierHeader.Rows[4].Cells["grdRCValue"].Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@QualifierTotalValue", clsBL.qualifier_total_value);
                        adapter.SelectCommand.Parameters.AddWithValue("@RemarkActivity", clsBL.remark_activity);
                        adapter.SelectCommand.ExecuteNonQuery();

                        _IsSucessStatusQualifier = true;

                        if (_isSucessSUVerCust == true && _isSucessUpdateVisa1 == true && _isSucessDeleteVerActivity == true && _isSucessReSaveVerActivity == true && _isSucessUpdateVisa2 == true && _IsSucessStatusQualifier == true)
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

        public bool PostSOR(SOVerificationProcessBL clsBL, DateTime _DeliveryDate, string _CollID, string _FlagEdit, string _UserID, string _HomePhone, string _MobilePhone, string _EmpPhone)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@VerID", VALUE = clsBL.verificator_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@KpNum", VALUE = clsBL.so_kp_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VBilAddr", VALUE= clsBL.billing_address_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VDelAddr", VALUE = clsBL.delivery_address_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VDueDate", VALUE = clsBL.dateofbilling },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VDeliveryDate", VALUE = _DeliveryDate },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VStat", VALUE = clsBL.customer_data_status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Vdatevisit", VALUE = clsBL.dateofvisit },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svs_status_release", VALUE = clsBL.status_release },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svs_remark", VALUE = clsBL.remark },
                    new SqlParameterHelper(){PARAMETR_NAME = "@CustID", VALUE = clsBL.customer_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@CollectorID", VALUE = _CollID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@FlagEdit", VALUE = _FlagEdit },
                    new SqlParameterHelper(){PARAMETR_NAME = "@User_id", VALUE = _UserID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Vscm_home_phone_num", VALUE = _HomePhone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Vscm_mobile_phone_num", VALUE = _MobilePhone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Vscm_employer_phone", VALUE = _EmpPhone },
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_RELEASE_VERIFICATION_STATUS]", sqlParameter);
                if ((int)result[2].Rows[0].ItemArray.ElementAt(0) == 1)
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

        public bool DeleteVs(SOVerificationProcessBL clsBO, bool _stillRelease)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@StillRelease", VALUE = _stillRelease },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VerificatorID", VALUE = clsBO.verificator_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@KPNo", VALUE = clsBO.so_kp_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Reason", VALUE = clsBO.cancellation_reason }
                };
                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_CANCEL_SO_VERIFICATION_STATUS]", sqlParameter);
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

        public bool DeleteSor(SOVerificationProcessBL clsBO, bool _stillRelease)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@StillRelease", VALUE = _stillRelease },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VerificatorID", VALUE = clsBO.verificator_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@KPNo", VALUE = clsBO.so_kp_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Reason", VALUE = clsBO.cancellation_reason }
                };
                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_CANCEL_SO_VERIFICATION_STATUS_RELEASE]", sqlParameter);
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

        public bool UpdateRemarks(SOVerificationProcessBL clsBO)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@VerID", VALUE = clsBO.verificator_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@KPNo", VALUE = clsBO.so_kp_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@RemarkActivity", VALUE = clsBO.remark_activity }
                };
                var result = Helper.ExecuteStoreProcedure("[sp_SO_UPDATE_REMARKS_VERIFICATION_STATUS]", sqlParameter);
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

        public bool UpdateCustomerAddressHome(SOMasterCustomerBL clsBL)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@CustomerName", VALUE = clsBL.Customer_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Address1", VALUE = clsBL.Address1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Address2", VALUE = clsBL.Address2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Address3", VALUE = clsBL.Address3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@RT", VALUE = clsBL.Rt },
                    new SqlParameterHelper(){PARAMETR_NAME = "@RW", VALUE = clsBL.Rw },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Kelurahan", VALUE = clsBL.Kelurahan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@KecamatanID", VALUE = clsBL.Area_Code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ZipCode", VALUE = clsBL.Zipcode },
                    new SqlParameterHelper(){PARAMETR_NAME = "@CustomerID", VALUE = clsBL.Customer_Id }
                };
                var result = Helper.ExecuteStoreProcedure("[sp_UPDATE_CUSTOMER_ADDRES_SOR_HOME]", sqlParameter);
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

        public bool UpdateCustomerAddressOffice(SOMasterCustomerBL clsBL)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@CustomerName", VALUE = clsBL.Customer_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Address1", VALUE = clsBL.Address1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Address2", VALUE = clsBL.Address2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Address3", VALUE = clsBL.Address3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ZipCode", VALUE = clsBL.Zipcode },
                    new SqlParameterHelper(){PARAMETR_NAME = "@City", VALUE = clsBL.Employer_City },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Province", VALUE = clsBL.Employer_Province },
                    new SqlParameterHelper(){PARAMETR_NAME = "@LastEmpName", VALUE = clsBL.Last_Employer_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@CustomerID", VALUE = clsBL.Customer_Id }
                };
                var result = Helper.ExecuteStoreProcedure("[sp_UPDATE_CUSTOMER_ADDRES_SOR_OFFICE]", sqlParameter);
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

        public int UpdateCustomerAddressOther(SOMasterCustomerBL clsBL, string _Kecamatan)
        {
            int _isSucess = 0;

            var sqlParameter = new List<SqlParameterHelper>() {
                new SqlParameterHelper(){PARAMETR_NAME = "@CustomerName", VALUE = clsBL.Customer_Name },
                new SqlParameterHelper(){PARAMETR_NAME = "@Address1", VALUE = clsBL.Address1 },
                new SqlParameterHelper(){PARAMETR_NAME = "@Address2", VALUE = clsBL.Address2 },
                new SqlParameterHelper(){PARAMETR_NAME = "@Address3", VALUE = clsBL.Address3 },
                new SqlParameterHelper(){PARAMETR_NAME = "@RT", VALUE = clsBL.Rt },
                new SqlParameterHelper(){PARAMETR_NAME = "@RW", VALUE = clsBL.Rw },
                new SqlParameterHelper(){PARAMETR_NAME = "@Kelurahan", VALUE = clsBL.Kelurahan },
                new SqlParameterHelper(){PARAMETR_NAME = "@KecamatanID", VALUE = clsBL.Area_Code },
                new SqlParameterHelper(){PARAMETR_NAME = "@Kecamatan", VALUE = _Kecamatan},
                new SqlParameterHelper(){PARAMETR_NAME = "@ZipCode", VALUE = clsBL.Zipcode },
                new SqlParameterHelper(){PARAMETR_NAME = "@City", VALUE = clsBL.Employer_City },
                new SqlParameterHelper(){PARAMETR_NAME = "@Province", VALUE = clsBL.Employer_Province },
                new SqlParameterHelper(){PARAMETR_NAME = "@CustomerID", VALUE = clsBL.Customer_Id }
            };
            var result = Helper.ExecuteStoreProcedure("[sp_UPDATE_CUSTOMER_ADDRES_SOR_OTHER]", sqlParameter);
            return _isSucess = (int)result[0].Rows[0].ItemArray.ElementAt(0);
        }

        public int UpdateCustomerAddressOtherDelivery(SOMasterCustomerBL clsBL, string _Kecamatan)
        {
            int _isSucess = 0;

            var sqlParameter = new List<SqlParameterHelper>() {
                new SqlParameterHelper(){PARAMETR_NAME = "@CustomerName", VALUE = clsBL.Customer_Name },
                new SqlParameterHelper(){PARAMETR_NAME = "@Address1", VALUE = clsBL.Address1 },
                new SqlParameterHelper(){PARAMETR_NAME = "@Address2", VALUE = clsBL.Address2 },
                new SqlParameterHelper(){PARAMETR_NAME = "@Address3", VALUE = clsBL.Address3 },
                new SqlParameterHelper(){PARAMETR_NAME = "@RT", VALUE = clsBL.Rt },
                new SqlParameterHelper(){PARAMETR_NAME = "@RW", VALUE = clsBL.Rw },
                new SqlParameterHelper(){PARAMETR_NAME = "@Kelurahan", VALUE = clsBL.Kelurahan },
                new SqlParameterHelper(){PARAMETR_NAME = "@KecamatanID", VALUE = clsBL.Area_Code },
                new SqlParameterHelper(){PARAMETR_NAME = "@Kecamatan", VALUE = _Kecamatan},
                new SqlParameterHelper(){PARAMETR_NAME = "@ZipCode", VALUE = clsBL.Zipcode },
                new SqlParameterHelper(){PARAMETR_NAME = "@City", VALUE = clsBL.Employer_City },
                new SqlParameterHelper(){PARAMETR_NAME = "@Province", VALUE = clsBL.Employer_Province },
                new SqlParameterHelper(){PARAMETR_NAME = "@CustomerID", VALUE = clsBL.Customer_Id }
            };
            var result = Helper.ExecuteStoreProcedure("[sp_UPDATE_CUSTOMER_ADDRES_SOR_OTHER_DELIVERY]", sqlParameter);
            return _isSucess = (int)result[0].Rows[0].ItemArray.ElementAt(0);
        }

        public bool TransferRemarks(SOVerificationProcessBL clsBO)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@KPNo", VALUE = clsBO.so_kp_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@RemarkActivity", VALUE = clsBO.remark_activity }
                };
                var result = Helper.ExecuteStoreProcedure("[sp_SO_TRANSFER_REMARKS_VERIFICATION_STATUS]", sqlParameter);
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

        public DataTable GetKPHeaderByKPNo(string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_KP_HEADER_BY_KP_NO_VERIFICATION_STATUS]('{ _KPNo }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetEndingDateCalenderFiscal()
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT gfc_period, gfc_ending_date FROM [FUNCTION_SO_GET_ENDING_DATE_FISCAL_CALENDER_SALES_ORDER_RELEASE]()");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetStatusKPNoSalesOrderRelease(string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_STATUS_KP_NO_SALES_ORDER_RELEASE]('{ _KPNo }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetKPNoDetailSalesOrderRelease(string _KPNo, string _VerificationStatus)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"[sp_SO_GET_KP_NO_DETAIL_SALES_ORDER_RELEASE] '{ _KPNo }', '{ _VerificationStatus }'");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetItemNoFromARKuitansi(string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_ITEM_NO_AR_KUITANSI_SALES_ORDER_RELEASE]('{ _KPNo }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable ValidateKPNoSOR(string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_VALIDATE_KP_NO_SALES_ORDER_RELEASE]('{ _KPNo }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetKelurahanToComboBox(bool _isAll, string _ZipCode)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_KELURAHAN]('{ _ZipCode }')");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["kelurahan"]}",
                              ValueMember = $"{dr["kelurahan"]}"
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
    }
}
