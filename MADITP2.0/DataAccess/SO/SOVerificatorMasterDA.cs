using MADITP2._0.businessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.DataAccess.SO
{
    class SOVerificatorMasterDA
    {
        clsGlobal Helper = null;
        clsAlert clsAlert;

        public SOVerificatorMasterDA(clsGlobal helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                clsAlert = new clsAlert();
            }
        }

        public DataTable Read(EnumFilter filter, SOVerificatorMasterBL clsBO, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            DataTable result = new DataTable();
            int _Offset;
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_VERIFICATOR_MASTER_ALL]('', '', '')");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_VERIFICATOR_MASTER_ALL]('{clsBO.verificator_id}', '', '')");
                        break;
                    case EnumFilter.GET_SEARCH_NAME:
                        result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_VERIFICATOR_MASTER_ALL]('', '{clsBO.verificator_name}', '')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        _Offset = fetchLimit * (currentPage - 1);
                        //NB : CHECK USER GROUP DAN BRANCHFLAG
                        result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_VERIFICATOR_MASTER]('GETDATA','{clsBO.verificator_id}', '{clsBO.verificator_name}', '{_Offset}', '{fetchLimit}')");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        _Offset = fetchLimit * (currentPage - 1);
                        result = Helper.ExecuteQuery($"SELECT COUNT(*) AS TotalRows FROM [FUNCTION_SO_GET_VERIFICATOR_MASTER]('GETCOUNT','{clsBO.verificator_id}', '{clsBO.verificator_name}', '{_Offset}', '{fetchLimit}')");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public bool Post(SOVerificatorMasterBL clsBO)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@flag", VALUE = "NEW" },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_entity_id", VALUE = clsBO.entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_branch_id", VALUE= clsBO.branch_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_division_id", VALUE = clsBO.division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_verificator_id", VALUE = clsBO.verificator_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_verificator_name", VALUE = clsBO.verificator_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_short_name", VALUE = clsBO.short_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_nik_num", VALUE = clsBO.nik_num },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_verificator_level", VALUE = clsBO.verificator_level },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_max_value_for_verification", VALUE = clsBO.max_value_for_verification },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_max_num_of_kp", VALUE = clsBO.max_num_of_kp },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_default_area_id", VALUE = clsBO.default_area_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_supervisor_id", VALUE = clsBO.supervisor_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_user_id", VALUE = clsLogin.USERID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_active_flag", VALUE = clsBO.active_flag } 
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_SO_ADD_UPDATE_VERIFICATOR_MASTER]", sqlParameter);
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

        public bool Put(SOVerificatorMasterBL clsBO)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@flag", VALUE = "EDIT" },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_entity_id", VALUE = clsBO.entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_branch_id", VALUE= clsBO.branch_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_division_id", VALUE = clsBO.division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_verificator_id", VALUE = clsBO.verificator_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_verificator_name", VALUE = clsBO.verificator_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_short_name", VALUE = clsBO.short_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_nik_num", VALUE = clsBO.nik_num },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_verificator_level", VALUE = clsBO.verificator_level },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_max_value_for_verification", VALUE = clsBO.max_value_for_verification },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_max_num_of_kp", VALUE = clsBO.max_num_of_kp },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_default_area_id", VALUE = clsBO.default_area_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_supervisor_id", VALUE = clsBO.supervisor_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_user_id", VALUE = clsLogin.USERID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_active_flag", VALUE = clsBO.active_flag }
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_SO_ADD_UPDATE_VERIFICATOR_MASTER]", sqlParameter);
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

        public bool Delete(SOVerificatorMasterBL clsBO)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@svm_verificator_id", VALUE= clsBO.verificator_id }
                };
                var result = Helper.ExecuteStoreProcedure("sp_SO_DELETE_VERIFICATOR_MASTER", sqlParameter);
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

        public List<ComboBoxViewModel> GetVerificatorToComboBox(SOVerificatorMasterBL clsBO, bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT svm_verificator_id, TRIM(svm_verificator_name) + ' - ' + TRIM(svm_verificator_id) as svm_verificator_name FROM [FUNCTION_SO_GET_VERIFICATOR_MASTER_ALL]('', '', '{ clsBO.active_flag }') ORDER BY svm_verificator_name ");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["svm_verificator_name"]}",
                              ValueMember = $"{dr["svm_verificator_id"]}"
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

        public List<ComboBoxViewModel> GetVerificatorToComboBoxByUserProperty(bool _isAll, string _UserEntity, string _UserBranch, string _VerificatorName)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT svm_verificator_id, TRIM(svm_verificator_name) + ' - ' + TRIM(svm_verificator_id) as svm_verificator_name from [FUNCTION_SO_GET_VERIFICATOR_MASTER_BY_USER_PROPERTY]('{_UserEntity}', '{_UserBranch}', '{_VerificatorName}') order by svm_verificator_name");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["svm_verificator_name"]}",
                              ValueMember = $"{dr["svm_verificator_id"]}"
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

        public List<ComboBoxViewModel> GetSupervisorToComboBox()
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery("SELECT svm_supervisor_id FROM [FUNCTION_SO_GET_SUPERVISOR]() ORDER BY svm_verificator_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["svm_supervisor_id"]}",
                              ValueMember = $"{dr["svm_supervisor_id"]}"
                          }).ToList();
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetPropertyUser()
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery("select        a.usr_fullname, a.usr_desc, a.usr_group_id, a.usr_entity_id, b.ec_entity, a.usr_branch_id, a.usr_division_id " +
                                        " from          USERS a with(nolock)" +
                                        " inner join    ENTITY_CODES b with(nolock) on a.usr_entity_id = b.ec_entity_id" +
                                        " where         a.usr_user_id = '" + clsLogin.USERID + "' ");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public List<ComboBoxViewModel> GetEntity(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery("SELECT ec_entity_id, ec_entity FROM ENTITY_CODES ORDER BY ec_entity");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["ec_entity"]}",
                              ValueMember = $"{dr["ec_entity_id"]}"
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

        public List<ComboBoxViewModel> GetBranch(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery("EXEC sp_FILTER_BRANCH '" + clsLogin.USERID + "' ");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["bc_branch"]}",
                              ValueMember = $"{dr["bc_branch_id"]}"
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

        public List<ComboBoxViewModel> GetDivision(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery("SELECT dc_division_id, dc_division from DIVISION_CODES order by dc_division");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["dc_division"]}",
                              ValueMember = $"{dr["dc_division_id"]}"
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

        public DataTable GetCustomer(string _ParamCust)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"Select top 25 * from [FUNCTION_GET_CUSTOMER_POPUP]('{ _ParamCust.ToUpper() }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetZipCodes(string _ParamZipCode)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"Select top 25 * from [FUNCTION_GET_ZIPCODES_POPUP]('{ _ParamZipCode.ToUpper() }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }
    }
}
