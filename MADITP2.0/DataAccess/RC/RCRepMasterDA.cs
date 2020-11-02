using System;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.Enums;
using MADITP2._0.businessLogic.RC;

namespace MADITP2._0.DataAccess.RC
{
    class RCRepMasterDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        DataTable dt;
        string query;
        string reason;

        public string Reason { get => reason; set => reason = value; }

        public RCRepMasterDA(clsGlobal helper, clsAlert alert)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                Alert = alert;
                dt = new DataTable();
            }
        }

        public DataTable SearchData(RCRepMasterBL Entity)
        {
            try
            {
                query = "SELECT * FROM RC_REP_MASTER WHERE rm_rep_id LIKE '%" + Entity.repId + "%'";
                if (Entity.npwpFlag != null)
                {
                    query = query + " AND rm_flag_npwp = '" + Entity.npwpFlag + "'";
                }
                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public void UpdateAccount(RCRepMasterBL Entity)
        {
            try
            {
                query = "UPDATE RC_REP_MASTER SET rm_account_name = '" + Entity.accountName +
                    "', rm_acc_number = '" + Entity.accountNumber +
                    "', rm_bank_id = '" + Entity.bankId +
                    "' WHERE rm_rep_id = '" + Entity.repId +
                    "'";
                Helper.BeginTrans();
                Helper.ExecuteTrans(query);
                Helper.CommitTrans();
                Alert.PushAlert("Update Success", clsAlert.Type.Success);
            }
            catch (Exception)
            {
                Helper.RollbackTrans();
                Alert.PushAlert("Update Failed", clsAlert.Type.Error);
            }
        }

        public void UpdateNpwp(RCRepMasterBL Entity)
        {
            try
            {
                query = "UPDATE RC_REP_MASTER SET rm_nama_NPWP = '" + Entity.npwpName +
                    "', rm_npwp = '" + Entity.npwpNumber +
                    "', rm_flag_npwp = '" + Entity.npwpFlag +
                    "' WHERE rm_rep_id = '" + Entity.repId +
                    "'";
                Helper.BeginTrans();
                Helper.ExecuteTrans(query);
                Helper.CommitTrans();
                Alert.PushAlert("Update Success", clsAlert.Type.Success);
            }
            catch (Exception)
            {
                Helper.RollbackTrans();
                Alert.PushAlert("Update Failed", clsAlert.Type.Error);
            }
        }

        public List<ComboBoxViewModel> GetBank()
        {
            var dt = new DataTable();
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT * FROM VW_BANK_NICEPAY_EPC";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["bank_code"]} - {dr["bank_name"]}",
                             ValueMember = $"{dr["bank_code"]}"
                         }).ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "Select Bank", ValueMember = "" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public bool Post(RCRepMasterBL Item) 
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@repId", VALUE = Item.repId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch", VALUE = Item.branch },
                    new SqlParameterHelper(){PARAMETR_NAME = "@name", VALUE = Item.name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@recruiterId", VALUE = Item.recruiterId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@managerId", VALUE = Item.managerId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@managerName", VALUE = Item.managerName },
                    new SqlParameterHelper(){PARAMETR_NAME = "@joinDate", VALUE = Item.joinDate },
                    new SqlParameterHelper(){PARAMETR_NAME = "@bankId", VALUE = Item.bankId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@accountName", VALUE = Item.accountName },
                    new SqlParameterHelper(){PARAMETR_NAME = "@accountNumber", VALUE = Item.accountNumber },
                    new SqlParameterHelper(){PARAMETR_NAME = "@npwpName", VALUE = Item.npwpName },
                    new SqlParameterHelper(){PARAMETR_NAME = "@npwpNumber", VALUE = Item.npwpNumber },
                    new SqlParameterHelper(){PARAMETR_NAME = "@npwpFlag", VALUE = Item.npwpFlag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entity_id", VALUE = Item.Entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Division_id", VALUE = Item.Division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Registration_id", VALUE = Item.Registration_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Short_name", VALUE = Item.Short_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Sex", VALUE = Item.Sex },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Marital_status", VALUE = Item.Marital_status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Psk_date", VALUE = Item.Psk_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Home_address_1", VALUE = Item.Home_address_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Home_address_2", VALUE = Item.Home_address_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Home_address_3", VALUE = Item.Home_address_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Phone_home", VALUE = Item.Phone_home },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Kelurahan", VALUE = Item.Kelurahan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rt", VALUE = Item.Rt },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rw", VALUE = Item.Rw },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Zipcode", VALUE = Item.Zipcode },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_name", VALUE = Item.Company_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_address_1", VALUE = Item.Company_address_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_address_2", VALUE = Item.Company_address_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_address_3", VALUE = Item.Company_address_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_phone", VALUE = Item.Company_phone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Birth_place", VALUE = Item.Birth_place },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Birth_date", VALUE = Item.Birth_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Religion_id", VALUE = Item.Religion_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Citizenship", VALUE = Item.Citizenship },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Identity_no", VALUE = Item.Identity_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Last_formal_education", VALUE = Item.Last_formal_education },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Graduated_flag", VALUE = Item.Graduated_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Year_graduated", VALUE = Item.Year_graduated },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Language_1", VALUE = Item.Language_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Language_2", VALUE = Item.Language_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Language_3", VALUE = Item.Language_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Last_position", VALUE = Item.Last_position },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_id", VALUE = Item.Customer_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@GroupID", VALUE = Item.GroupID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Status", VALUE = Item.Status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Current_position", VALUE = Item.Current_position },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Date_position_change", VALUE = Item.Date_position_change },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Last_position_level", VALUE = Item.Last_position_level },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Num_rep_recruited", VALUE = Item.Num_rep_recruited },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entry_date", VALUE = Item.Entry_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entry_user", VALUE = Item.Entry_user },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Cwh_deducted", VALUE = Item.Cwh_deducted },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Cwh_cummulated", VALUE = Item.Cwh_cummulated },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Active_flag", VALUE = Item.Active_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_type_id", VALUE = Item.Rep_type_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_txn_flag", VALUE = Item.Rep_txn_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Maried_date", VALUE = Item.Maried_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Nabas_date", VALUE = Item.Nabas_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Team", VALUE = Item.Team },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Passwd", VALUE = Item.Passwd },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Oct_date", VALUE = Item.Oct_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id_link", VALUE = Item.Id_link },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Cmp_num", VALUE = Item.Cmp_num },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Principal", VALUE = Item.Principal },
                    new SqlParameterHelper(){PARAMETR_NAME = "@OCT_ID", VALUE = Item.OCT_ID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Status_position", VALUE = Item.Status_position },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Approve", VALUE = Item.Approve },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Lulus", VALUE = Item.Lulus },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Bank", VALUE = Item.Bank },
                    new SqlParameterHelper(){PARAMETR_NAME = "@City", VALUE = Item.City },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Provice", VALUE = Item.Province },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Kecamatan", VALUE = Item.Kecamatan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@No_wa", VALUE = Item.No_wa },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Flag", VALUE = Item.Flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Mobile_phone_new", VALUE = Item.Mobile_phone_new },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Subdistrik_id", VALUE = Item.Subdistrik_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Mobile_phone", VALUE = Item.Mobile_phone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Create_npwp", VALUE = Item.Create_npwp },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Non_active_date", VALUE = Item.Non_active_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Email_address", VALUE = Item.Email_address },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Date_pkk", VALUE = Item.Date_pkk }
                };

                var result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_REP_MASTER", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Save data failed";
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Reason = e.Message.ToString();
                return false;
            }

            return true;
        }

        public bool Put(string RepId, RCRepMasterBL Item) 
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@repId", VALUE = RepId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch", VALUE = Item.branch },
                    new SqlParameterHelper(){PARAMETR_NAME = "@name", VALUE = Item.name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@recruiterId", VALUE = Item.recruiterId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@managerId", VALUE = Item.managerId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@managerName", VALUE = Item.managerName },
                    new SqlParameterHelper(){PARAMETR_NAME = "@joinDate", VALUE = Item.joinDate },
                    new SqlParameterHelper(){PARAMETR_NAME = "@bankId", VALUE = Item.bankId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@accountName", VALUE = Item.accountName },
                    new SqlParameterHelper(){PARAMETR_NAME = "@accountNumber", VALUE = Item.accountNumber },
                    new SqlParameterHelper(){PARAMETR_NAME = "@npwpName", VALUE = Item.npwpName },
                    new SqlParameterHelper(){PARAMETR_NAME = "@npwpNumber", VALUE = Item.npwpNumber },
                    new SqlParameterHelper(){PARAMETR_NAME = "@npwpFlag", VALUE = Item.npwpFlag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entity_id", VALUE = Item.Entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Division_id", VALUE = Item.Division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Registration_id", VALUE = Item.Registration_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Short_name", VALUE = Item.Short_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Sex", VALUE = Item.Sex },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Marital_status", VALUE = Item.Marital_status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Psk_date", VALUE = Item.Psk_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Home_address_1", VALUE = Item.Home_address_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Home_address_2", VALUE = Item.Home_address_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Home_address_3", VALUE = Item.Home_address_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Phone_home", VALUE = Item.Phone_home },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Kelurahan", VALUE = Item.Kelurahan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rt", VALUE = Item.Rt },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rw", VALUE = Item.Rw },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Zipcode", VALUE = Item.Zipcode },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_name", VALUE = Item.Company_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_address_1", VALUE = Item.Company_address_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_address_2", VALUE = Item.Company_address_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_address_3", VALUE = Item.Company_address_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Company_phone", VALUE = Item.Company_phone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Birth_place", VALUE = Item.Birth_place },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Birth_date", VALUE = Item.Birth_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Religion_id", VALUE = Item.Religion_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Citizenship", VALUE = Item.Citizenship },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Identity_no", VALUE = Item.Identity_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Last_formal_education", VALUE = Item.Last_formal_education },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Graduated_flag", VALUE = Item.Graduated_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Year_graduated", VALUE = Item.Year_graduated },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Language_1", VALUE = Item.Language_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Language_2", VALUE = Item.Language_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Language_3", VALUE = Item.Language_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Last_position", VALUE = Item.Last_position },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_id", VALUE = Item.Customer_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@GroupID", VALUE = Item.GroupID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Status", VALUE = Item.Status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Current_position", VALUE = Item.Current_position },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Date_position_change", VALUE = Item.Date_position_change },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Last_position_level", VALUE = Item.Last_position_level },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Num_rep_recruited", VALUE = Item.Num_rep_recruited },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entry_date", VALUE = Item.Entry_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entry_user", VALUE = Item.Entry_user },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Cwh_deducted", VALUE = Item.Cwh_deducted },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Cwh_cummulated", VALUE = Item.Cwh_cummulated },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Active_flag", VALUE = Item.Active_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_type_id", VALUE = Item.Rep_type_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_txn_flag", VALUE = Item.Rep_txn_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Maried_date", VALUE = Item.Maried_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Nabas_date", VALUE = Item.Nabas_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Team", VALUE = Item.Team },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Passwd", VALUE = Item.Passwd },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Oct_date", VALUE = Item.Oct_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id_link", VALUE = Item.Id_link },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Cmp_num", VALUE = Item.Cmp_num },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Principal", VALUE = Item.Principal },
                    new SqlParameterHelper(){PARAMETR_NAME = "@OCT_ID", VALUE = Item.OCT_ID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Status_position", VALUE = Item.Status_position },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Approve", VALUE = Item.Approve },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Lulus", VALUE = Item.Lulus },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Bank", VALUE = Item.Bank },
                    new SqlParameterHelper(){PARAMETR_NAME = "@City", VALUE = Item.City },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Provice", VALUE = Item.Province },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Kecamatan", VALUE = Item.Kecamatan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@No_wa", VALUE = Item.No_wa },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Flag", VALUE = Item.Flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Mobile_phone_new", VALUE = Item.Mobile_phone_new },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Subdistrik_id", VALUE = Item.Subdistrik_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Mobile_phone", VALUE = Item.Mobile_phone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Create_npwp", VALUE = Item.Create_npwp },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Non_active_date", VALUE = Item.Non_active_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Email_address", VALUE = Item.Email_address },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Date_pkk", VALUE = Item.Date_pkk }
                };

                var result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_REP_MASTER", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Update data failed";
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Reason = e.Message.ToString();
                return false;
            }

            return true;
        }

        public bool Delete(string RepId) 
        {
            RepId = Helper.CastToString(RepId);
            string sql = $"DELETE FROM RC_REP_MASTER WHERE trim(rm_rep_id) = '{RepId}';";
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

        public List<RCRepMasterBL> Read(
            EnumFilter Filter, 
            int Offset = 0, 
            int Perpage = (int) EnumFetchData.DefaultLimit, 
            string Search = "",
            string RepLevel = "",
            string RecruterId = "",
            string ManagerId = "",
            string EntityId = "",
            string BranchId = "",
            string DivisionId = "",
            string Gender = "",
            string ActiveFlag = "",
            int? MaritalStatus= null,
            string filterStartJoinDate = "",
            string filterEndJoinDate = ""
        ){
            DataTable result = new DataTable();
            if (Filter == EnumFilter.GET_ALL)
            {
                Offset = -1;
                Perpage = -1;
            }

            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = Offset },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Perpage", VALUE = Perpage },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search },
                    new SqlParameterHelper(){PARAMETR_NAME = "@RepLevel", VALUE = RepLevel},
                    new SqlParameterHelper(){PARAMETR_NAME = "@RecruterId", VALUE = RecruterId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ManagerId", VALUE = ManagerId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@EntityId", VALUE = EntityId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@BranchId", VALUE = BranchId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@DivisionId", VALUE = DivisionId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gender", VALUE = Gender },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ActiveFlag", VALUE = ActiveFlag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@MaritalStatus", VALUE = MaritalStatus },
                    new SqlParameterHelper(){PARAMETR_NAME = "@filterStartJoinDate", VALUE = filterStartJoinDate },
                    new SqlParameterHelper(){PARAMETR_NAME = "@filterEndJoinDate", VALUE = filterEndJoinDate },
                };

                result = Helper.ExecuteQuery($"SELECT * from FUNCTION_RC_REP_MASTER_GET_ALL(@Offset, @Perpage, @Search, @RepLevel, @RecruterId, @ManagerId, @EntityId, @BranchId, @DivisionId, @Gender, @ActiveFlag, @MaritalStatus, @filterStartJoinDate, @filterEndJoinDate)", 
                    sqlParameter);
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            if (result.Rows.Count == 0)
            {
                return new List<RCRepMasterBL>();
            }

            return Helper.ConvertDataTableToList<RCRepMasterBL>(result);
        }

        public int CountRows(
            string Search = "",
            string RepLevel = "",
            string RecruterId = "",
            string ManagerId = "",
            string EntityId = "",
            string BranchId = "",
            string DivisionId = "",
            string Gender = "",
            string ActiveFlag = "",
            int? MaritalStatus = null,
            string filterStartJoinDate = "",
            string filterEndJoinDate = ""
        )
        {
            DataTable result = new DataTable();
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search },
                    new SqlParameterHelper(){PARAMETR_NAME = "@RepLevel", VALUE = RepLevel },
                    new SqlParameterHelper(){PARAMETR_NAME = "@RecruterId", VALUE = RecruterId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ManagerId", VALUE = ManagerId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@EntityId", VALUE = EntityId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@BranchId", VALUE = BranchId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@DivisionId", VALUE = DivisionId },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gender", VALUE = Gender },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ActiveFlag", VALUE = ActiveFlag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@MaritalStatus", VALUE = MaritalStatus },
                    new SqlParameterHelper(){PARAMETR_NAME = "@filterStartJoinDate", VALUE = filterStartJoinDate },
                    new SqlParameterHelper(){PARAMETR_NAME = "@filterEndJoinDate", VALUE = filterEndJoinDate },
                };

                result = Helper.ExecuteQuery($"SELECT count(repId) as jumlah from FUNCTION_RC_REP_MASTER_GET_ALL(-1, -1, @Search, @RepLevel, @RecruterId, @ManagerId, @EntityId, @BranchId, @DivisionId, @Gender, @ActiveFlag, @MaritalStatus, @filterStartJoinDate, @filterEndJoinDate)", sqlParameter);
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            if(result.Rows.Count == 0)
            {
                return 0;
            }

            return Helper.CastToInt(result.Rows[0]["jumlah"]);
        }

        public RCRepMasterBL Find(string RepID) 
        {
            DataTable result = new DataTable();
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@RepID", VALUE = RepID }
                };

                result = Helper.ExecuteQuery($"SELECT * from FUNCTION_RC_REP_MASTER_GET(@RepID)",
                    sqlParameter);
            }
            catch (Exception e)
            {
               Console.WriteLine(e.StackTrace);
               Reason = e.Message;
            }

            if(result.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<RCRepMasterBL>(result);
        }
    }
}
