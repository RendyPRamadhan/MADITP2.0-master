using System;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.login;

namespace MADITP2._0.DataAccess.SO
{
    class SOKPRegistrationDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        DataTable dt;
        string query;

        public SOKPRegistrationDA(clsGlobal helper, clsAlert alert)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                Alert = alert;
                dt = new DataTable();
            }
        }

        public List<ComboBoxViewModel> GetEntity(bool all)
        {
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT ec_entity_id, ec_entity FROM ENTITY_CODES";
                query = query + " ORDER BY ec_entity_id";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["ec_entity"].ToString().Trim()}",
                             ValueMember = $"{dr["ec_entity_id"].ToString().Trim()}"
                         }).Where(item => item.ValueMember != "0").ToList();
                if (all)
                    combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetBranch(bool all)
        {
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT bc_branch_id, bc_branch FROM BRANCH_CODES";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["bc_branch"].ToString().Trim()}",
                             ValueMember = $"{dr["bc_branch_id"].ToString().Trim()}"
                         }).Where(item => item.ValueMember != "0").ToList();
                if (all)
                    combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetDivision(bool all)
        {
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT dc_division_id, dc_division FROM DIVISION_CODES";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["dc_division"].ToString().Trim()}",
                             ValueMember = $"{dr["dc_division_id"].ToString().Trim()}"
                         }).Where(item => item.ValueMember != "0").ToList();
                if (all)
                    combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetStatus(bool all)
        {
            var combo = new List<ComboBoxViewModel>();
            combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "Cancel", ValueMember = "C" });
            combo.Insert(1, new ComboBoxViewModel() { DisplayMember = "Pending", ValueMember = "P" });
            combo.Insert(2, new ComboBoxViewModel() { DisplayMember = "Ordered", ValueMember = "O" });
            combo.Insert(3, new ComboBoxViewModel() { DisplayMember = "Entering", ValueMember = "E" });
            if (all)
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });

            return combo;
        }

        public DataTable SearchData(SOKPRegistrationBL Entity)
        {
            try
            {
                query = "SELECT rm_rep_id, rm_name, kf_kp_number, kf_date_kp_out, kf_kp_form_status, kf_remark, 'M' as Type, ec_entity, bc_branch, dc_division, ec_entity_id, bc_branch_id, dc_division_id " +
                    "FROM VW_RC_REP_MASTER_FOR_NEW_SCHEMA, SO_KPO_FORM, ENTITY_CODES, BRANCH_CODES, DIVISION_CODES " +
                    "WHERE kf_rep_id = rm_rep_id AND kf_entity_id = ec_entity_id AND kf_branch_id = bc_branch_id AND kf_division_id = dc_division_id";
                if (Entity.Kf_entity_id != "0")
                    query = query + " AND kf_entity_id = '" + Entity.Kf_entity_id + "'";
                //if (clsLogin.BranchFlag == "Y" && Entity.Kf_branch_id == "0")
                //    query = query + " AND kf_branch_id in (select mp_branch from vw_USER_BRANCH_LOAD_USER WHERE mp_grp_usr='" + clsLogin.UserGroup + "')";
                if (Entity.Kf_branch_id != "0")
                    query = query + " AND kf_branch_id = '" + Entity.Kf_branch_id + "'";
                if (Entity.Kf_division_id != "0")
                    query = query + " AND kf_division_id = '" + Entity.Kf_division_id + "'";
                //if (clsLogin.Status = "Y")
                //{
                //    if (clsLogin.Types = "A")
                //        query = query + " AND rm_manager_id IN (SELECT rm_manager_id FROM BW_EPHO_SLS_ANALISA WHERE rm_periode = CONVERT(VARCHAR(6), GETDATE(), 112) AND (rm_user_ass) = '" + clsLogin.User + "')";
                //    if (clsLogin.Types = "B")
                //        query = query + " AND rm_manager_id IN (SELECT rm_manager_id FROM BW_EPHO_SLS_ANALISA WHERE rm_periode = CONVERT(VARCHAR(6), GETDATE(), 112) AND (rm_user_ss) = '" + clsLogin.User + "')";
                //    if (clsLogin.Types = "C")
                //        query = query + " AND rm_manager_id IN (SELECT rm_manager_id FROM BW_EPHO_SLS_ANALISA WHERE rm_periode = CONVERT(VARCHAR(6), GETDATE(), 112) AND (rm_user_admin) = '" + clsLogin.User + "')";
                //}
                if (!String.IsNullOrEmpty(Entity.Kf_rep_id))
                    query = query + " AND kf_rep_id = '" + Entity.Kf_rep_id + "'";
                if (Entity.Kf_kp_form_status != "0")
                    query = query + " AND kf_kp_form_status = '" + Entity.Kf_kp_form_status + "'";
                if (Entity.Kf_dateOutOf == "0")
                {
                    if (Entity.Kf_dateFrom == Entity.Kf_dateTo)
                        query = query + " AND kf_date_kp_out = '" + Entity.Kf_dateFrom + "'";
                    else
                        query = query + " AND kf_date_kp_out BETWEEN '" + Entity.Kf_dateFrom + "' AND '" + Entity.Kf_dateTo + "'";
                }
                if (!String.IsNullOrEmpty(Entity.Kf_kp_number))
                    query = query + " AND kf_kp_number LIKE '" + Entity.Kf_kp_number + "'";

                query = query + " UNION ALL ";
                query = query + "SELECT rc_rep_id, rc_rep_name, kf_kp_number, kf_date_kp_out, kf_kp_form_status, kf_remark, 'C' as Type, ec_entity, bc_branch, dc_division, ec_entity_id, bc_branch_id, dc_division_id " +
                    "FROM RC_REP_CANDIDATES, SO_KPO_FORM, ENTITY_CODES, BRANCH_CODES, DIVISION_CODES " +
                    "WHERE kf_rep_id = rc_rep_id AND kf_entity_id = ec_entity_id AND kf_branch_id = bc_branch_id AND kf_division_id = dc_division_id";
                if (Entity.Kf_entity_id != "0")
                    query = query + " AND kf_entity_id = '" + Entity.Kf_entity_id + "'";
                //if (clsLogin.BranchFlag == "Y" && Entity.Kf_branch_id == "0")
                //    query = query + " AND kf_branch_id in (select mp_branch from vw_USER_BRANCH_LOAD_USER WHERE mp_grp_usr='" + clsLogin.UserGroup + "')";
                if (Entity.Kf_branch_id != "0")
                    query = query + " AND kf_branch_id = '" + Entity.Kf_branch_id + "'";
                if (Entity.Kf_division_id != "0")
                    query = query + " AND kf_division_id = '" + Entity.Kf_division_id + "'";
                if (!String.IsNullOrEmpty(Entity.Kf_rep_id))
                    query = query + " AND kf_rep_id = '" + Entity.Kf_rep_id + "'";
                if (Entity.Kf_kp_form_status != "0")
                    query = query + " AND kf_kp_form_status = '" + Entity.Kf_kp_form_status + "'";
                if (Entity.Kf_dateOutOf == "0")
                {
                    if (Entity.Kf_dateFrom == Entity.Kf_dateTo)
                        query = query + " AND kf_date_kp_out = '" + Entity.Kf_dateFrom + "'";
                    else
                        query = query + " AND kf_date_kp_out between '" + Entity.Kf_dateFrom + "' and '" + Entity.Kf_dateTo + "'";
                }
                if (!String.IsNullOrEmpty(Entity.Kf_kp_number))
                    query = query + " AND kf_kp_number LIKE '" + Entity.Kf_kp_number + "'";

                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();

                            if (dr[dc].ToString() == "C")
                                dr[dc] = "Cancel";
                            else if (dr[dc].ToString() == "P")
                                dr[dc] = "Pending";
                            else if (dr[dc].ToString() == "O")
                                dr[dc] = "Ordered";
                            else if (dr[dc].ToString() == "E")
                                dr[dc] = "Entering";
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public void Create(SOKPRegistrationBL Entity)
        {
            try
            {
                query = "INSERT INTO SO_KPO_FORM (" +
                    "kf_kp_number, kf_rep_id, kf_entity_id, kf_branch_id, kf_division_id, kf_date_kp_out, " +
                    "kf_entry_date, kf_kp_form_status, kf_remark, kf_entry_by, kf_last_update) " +
                    "VALUES(" +
                    "@kf_kp_number, @kf_rep_id, @kf_entity_id, @kf_branch_id, @kf_division_id, @kf_date_kp_out, " +
                    "@kf_entry_date, @kf_kp_form_status, @kf_remark, @kf_entry_by, @kf_last_update)";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Create Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(SOKPRegistrationBL Entity)
        {
            try
            {
                query = "UPDATE SO_KPO_FORM SET " +
                    "kf_rep_id = @kf_rep_id, " +
                    "kf_entity_id = @kf_entity_id, " +
                    "kf_branch_id = @kf_branch_id, " +
                    "kf_division_id = @kf_division_id, " +
                    "kf_date_kp_out = @kf_date_kp_out, " +
                    "kf_entry_date = @kf_entry_date, " +
                    "kf_kp_form_status = @kf_kp_form_status, " +
                    "kf_remark = @kf_remark, " +
                    "kf_last_update = @kf_last_update " +
                    "WHERE kf_kp_number = @kf_kp_number";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Update Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(SOKPRegistrationBL Entity)
        {
            try
            {
                query = "DELETE FROM SO_KPO_FORM WHERE kf_kp_number = @kf_kp_number";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Delete Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<SqlParameterHelper> GetParam(SOKPRegistrationBL Entity)
        {
            var param = new List<SqlParameterHelper>()
            {
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_kp_number", VALUE = Entity.Kf_kp_number },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_rep_id", VALUE = Entity.Kf_rep_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_entity_id", VALUE = Entity.Kf_entity_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_branch_id", VALUE = Entity.Kf_branch_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_division_id", VALUE = Entity.Kf_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_date_kp_out", VALUE = Entity.Kf_date_kp_out },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_entry_date", VALUE = Entity.Kf_entry_date },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_kp_form_status", VALUE = Entity.Kf_kp_form_status },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_remark", VALUE = Entity.Kf_remark },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_entry_by", VALUE = Entity.Kf_entry_by },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_last_update", VALUE = Entity.Kf_last_update },
                new SqlParameterHelper() { PARAMETR_NAME = "@kf_web_so_number", VALUE = Entity.Kf_web_so_number }
            };

            return param;
        }
    }
}
