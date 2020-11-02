using System;
using System.Data;
using System.ComponentModel;
using MADITP2._0.Global;
using MADITP2._0.Enums;
using MADITP2._0.BusinessLogic.GS;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using MADITP2._0.login;

namespace MADITP2._0.DataAccess.GS
{
    class GSUserManagementDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        private clsLogin _clsLogin = new clsLogin();
        DataTable dt;
        string SQLstr;
        
        public GSUserManagementDA(clsGlobal helper, clsAlert alert)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                Alert = alert;
                dt = new DataTable();
            }
        }

        public DataTable GetUserGroup(string UserID = null, string Name = null,string Search =null)
        {
            SQLstr = "exec sp_GS_USER_MANAGEMENT_GET_LIST 'G','" + UserID + "','" + Name + "','" + Search + "' ";
            try
            {
                dt = Helper.ExecDT(SQLstr);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (SystemException dex)
            {
                MessageBox.Show(dex.Message.ToString());
            }

            return dt;
        }

        public GSUserManagementBL.GSUserGroup SearchUserGroup(string UserID = null, string Name = null, string Search = null)
        {
            GSUserManagementBL.GSUserGroup EntityUserGroup = null;
            SQLstr = "exec sp_GS_USER_MANAGEMENT_GET_LIST 'G','" + UserID + "','" + Name + "','" + Search + "' ";
            try
            {
                DataTable dt = Helper.ExecDT(SQLstr);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data not found");
                    return EntityUserGroup;
                }
                EntityUserGroup = new GSUserManagementBL.GSUserGroup();
                EntityUserGroup.group_id = Helper.CastToString(dt.Rows[0]["gug_group_id"]);
                EntityUserGroup.group_desc = Helper.CastToString(dt.Rows[0]["gug_group_desc"]);
                EntityUserGroup.entity_id = Helper.CastToString(dt.Rows[0]["uge_entity_id"]);
            }
            catch (SystemException dex)
            {
                MessageBox.Show(dex.Message.ToString());
            }

            return EntityUserGroup;
        }
        public GSUserManagementBL.GSUsers SearchUser(string UserID = null, string Name = null, string Search = null)
        {
            string dePass;
            GSUserManagementBL.GSUsers EntityUser = null;
            SQLstr = "exec sp_GS_USER_MANAGEMENT_GET_LIST 'U','" + UserID + "','" + Name + "','" + Search + "' ";
            try
            {
                DataTable dt = Helper.ExecDT(SQLstr);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data not found");
                    return EntityUser;
                }
                dePass = clsCryptoEngine.Decrypt(Helper.CastToString(dt.Rows[0]["usr_password"]), "sblw-3hn8-sqoy19");
                EntityUser = new GSUserManagementBL.GSUsers();
                EntityUser.group_user_id = Helper.CastToString(dt.Rows[0]["usr_group_user_id"]);
                EntityUser.user_id = Helper.CastToString(dt.Rows[0]["usr_user_id"]);
                EntityUser.name = Helper.CastToString(dt.Rows[0]["usr_name"]);
                EntityUser.description = Helper.CastToString(dt.Rows[0]["usr_description"]);
                EntityUser.password = dePass;
                EntityUser.status = Helper.CastToString(dt.Rows[0]["usr_status"]);
                EntityUser.entity_id = Helper.CastToString(dt.Rows[0]["gue_entity_id"]);
            }
            catch (SystemException dex)
            {
                MessageBox.Show(dex.Message.ToString());
            }

            return EntityUser;
        }

        public DataTable GetUser(string UserID = null, string Name = null, string Search = null)
        {
            SQLstr = "exec sp_GS_USER_MANAGEMENT_GET_LIST 'U','" + UserID + "','" + Name + "','" + Search + "' ";
            try
            {
                dt = Helper.ExecDT(SQLstr);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (SystemException dex)
            {
                MessageBox.Show(dex.Message.ToString());
            }

            return dt;
        }
        public DataTable GetUserGroupBranch(string _GroupID_Selected)
        {
            try
            {
                SQLstr = "select * from vw_GS_USER_MANAGEMENT_USER_GROUP_BRANCH ";
                if (_GroupID_Selected != null)
                {
                    SQLstr = SQLstr + " where gug_group_id = '" + _GroupID_Selected + "'";
                }
                dt = Helper.ExecDT(SQLstr);
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
        public DataTable GetUserBranch(string _UserID_Selected)
        {
            try
            {
                SQLstr = "select * from vw_GS_USER_MANAGEMENT_USER_BRANCH ";
                if (_UserID_Selected != null)
                {
                    SQLstr = SQLstr + " where usr_user_id = '" + _UserID_Selected + "'";
                }
                dt = Helper.ExecDT(SQLstr);
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

        public DataTable SaveCheck(string _GroupID_Selected,int grid,int state)
        {
            try
            {
                SQLstr = "exec sp_GS_USER_MANAGEMENT_SAVE_USER_GROUP_CHECK '" + state + "','" + grid + "','" + _GroupID_Selected + "' ";
                dt = Helper.ExecDT(SQLstr);
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

        public Boolean Save(GSUserManagementBL.GSUsers EntityUser, string[] BranchID, int state, string type,int grid)
        {
            if (grid == 0)
            {
                if (state == 0)
                {
                    if (type == "P")
                    {
                        List<SqlParameterHelper> sqlp = new List<SqlParameterHelper>()
                        {
                            new SqlParameterHelper() { PARAMETR_NAME = "@STATE", VALUE = 0},
                            new SqlParameterHelper() { PARAMETR_NAME = "@TYPE", VALUE = type},
                            new SqlParameterHelper() { PARAMETR_NAME = "@IDX", VALUE = 0 },
                            new SqlParameterHelper() { PARAMETR_NAME = "@GROUPID", VALUE = EntityUser.group_user_id },
                            new SqlParameterHelper() { PARAMETR_NAME = "@GROUPDESC", VALUE = EntityUser.group_user_desc},
                            new SqlParameterHelper() { PARAMETR_NAME = "@GROUPENTITY", VALUE = EntityUser.entity_id}
                        };
                        string sql = "exec sp_GS_USER_MANAGEMENT_SAVE_USER_GROUP @STATE,@TYPE, " +
                           "@IDX, @GROUPID,@GROUPDESC,@GROUPENTITY ";
                        try
                        {
                            Helper.BeginTrans();
                            Helper.ExecuteTrans(sql, sqlp);
                            Helper.CommitTrans();
                        }
                        catch (Exception e)
                        {
                            Helper.RollbackTrans();
                            Console.WriteLine(e.StackTrace);
                            MessageBox.Show(e.Message.ToString());
                            return false;
                        }
                    }
                    else if (type == "B")
                    {
                        for (int i = 0; i < BranchID.Length; i++)
                        {
                            string sql = "exec sp_GS_USER_MANAGEMENT_SAVE_USER_GROUP " + state + ",'" + type + "'," + i + ", " +
                           "'" + EntityUser.group_user_id + "','" + EntityUser.group_user_desc + "','" + EntityUser.entity_id + "','" + BranchID[i] + "'";
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
                                MessageBox.Show(e.Message.ToString());
                                return false;
                            }
                        }
                    }
                    else if (type == "M")
                    {
                        for (int i = 0; i < BranchID.Length; i++)
                        {
                            string[] split = BranchID[i].Split('|');
                            string sql = "exec sp_GS_USER_MANAGEMENT_SAVE_USER_GROUP " + state + ",'" + type + "'," + i + ", " +
                           "'" + EntityUser.group_user_id + "', '" + EntityUser.group_user_desc + "','" + EntityUser.entity_id + "','" + split[0] + "','" + split[1] + "','" + split[2] + "','" + split[3] + "','" + split[4] + "','" + split[5] + "','" + split[6] + "'";
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
                                MessageBox.Show(e.Message.ToString());
                                return false;
                            }
                        }
                    }
                }
            }
            else if (grid == 1)
            {
                if (state == 0)
                {
                    if (type == "P")
                    {
                        string enPass;
                        enPass = clsCryptoEngine.Encrypt(EntityUser.password.ToString().Trim(), "sblw-3hn8-sqoy19");
                        List<SqlParameterHelper> sqlp = new List<SqlParameterHelper>()
                        {
                            new SqlParameterHelper() { PARAMETR_NAME = "@STATE", VALUE = 0},
                            new SqlParameterHelper() { PARAMETR_NAME = "@TYPE", VALUE = type},
                            new SqlParameterHelper() { PARAMETR_NAME = "@IDX", VALUE = 0 },
                            new SqlParameterHelper() { PARAMETR_NAME = "@GROUPID", VALUE = EntityUser.group_user_id },
                            new SqlParameterHelper() { PARAMETR_NAME = "@USERID", VALUE = EntityUser.user_id},
                            new SqlParameterHelper() { PARAMETR_NAME = "@NAME", VALUE = EntityUser.name},
                            new SqlParameterHelper() { PARAMETR_NAME = "@DESCRIPTION", VALUE = EntityUser.description},
                            new SqlParameterHelper() { PARAMETR_NAME = "@PASSWORD", VALUE = enPass},
                            new SqlParameterHelper() { PARAMETR_NAME = "@STATUS", VALUE = EntityUser.status},
                            new SqlParameterHelper() { PARAMETR_NAME = "@CREATEDBY", VALUE = clsLogin.USERID}
                        };
                        string sql = "exec sp_GS_USER_MANAGEMENT_SAVE_USER @STATE,@TYPE, " +
                           "@IDX, @GROUPID,@USERID,@NAME,@DESCRIPTION,@PASSWORD,@STATUS,'','','','','','','','',@CREATEDBY ";
                        try
                        {
                            Helper.BeginTrans();
                            Helper.ExecuteTrans(sql, sqlp);
                            Helper.CommitTrans();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.StackTrace);
                            MessageBox.Show(e.Message.ToString());
                            return false;
                        }
                    }
                    else if (type == "B")
                    {
                        for (int i = 0; i < BranchID.Length; i++)
                        {
                            string sql = "exec sp_GS_USER_MANAGEMENT_SAVE_USER " + state + ",'" + type + "'," + i + ", " +
                           "'" + EntityUser.group_user_id + "','" + EntityUser.user_id + "','','','','','','" + BranchID[i] + "'";
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
                                MessageBox.Show(e.Message.ToString());
                                return false;
                            }
                        }
                    }
                    else if (type == "M")
                    {
                        for (int i = 0; i < BranchID.Length; i++)
                        {
                            string[] split = BranchID[i].Split('|');
                            string sql = "exec sp_GS_USER_MANAGEMENT_SAVE_USER " + state + ",'" + type + "'," + i + ", " +
                           "'" + EntityUser.group_user_id + "', '" + EntityUser.user_id + "','','','','','','" + split[0] + "','" + split[1] + "','" + split[2] + "','" + split[3] + "','" + split[4] + "','" + split[5] + "','" + split[6] + "'";
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
                                MessageBox.Show(e.Message.ToString());
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void Delete(string _GroupID_Selected, int state,int type)
        {
            try
            {
                SQLstr = "exec sp_GS_USER_MANAGEMENT_DELETE_USER_GROUP '" + type + "','" + state + "','" + _GroupID_Selected + "'";

                Helper.BeginTrans();
                Helper.ExecuteTrans(SQLstr);
                Helper.CommitTrans();
                Alert.PushAlert("Delete Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<ComboBoxViewModel> GetModuls()
        {
            //DataTable dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                SQLstr = "SELECT * FROM MODULE_CODES ";

                dt = Helper.ExecDT(SQLstr);
                //Data = Read(EnumFilter.GET_ALL, Model);
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["module_id"]}" + " ~ " + $"{dr["description"]}",
                              ValueMember = $"{dr["module_id"]}"
                          }).ToList();
                //result.Insert(1, new ComboBoxViewModel());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetEntities()
        {
            //DataTable dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                SQLstr = "SELECT * FROM GS_ENTITY_CODES ";

                dt = Helper.ExecDT(SQLstr);
                //Data = Read(EnumFilter.GET_ALL, Model);
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["gec_entity_id"]}" + " ~ " + $"{dr["gec_entity"]}",
                              ValueMember = $"{dr["gec_entity_id"]}"
                          }).ToList();
                //result.Insert(1, new ComboBoxViewModel());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public DataTable getMenu(GSUserManagementBL.GSModul EntityModul, string _GroupID_Selected)
        {
            try
            {
                SQLstr = "select mnu_menu_code,mnu_menu_name,flag_menu,flag_add,flag_edit,flag_delete,flag_print,flag_export " +
                    "from vw_GS_USER_MANAGEMENT_USER_GROUP_MENU where gug_group_id = '" + _GroupID_Selected + "' ";
                if (EntityModul.modul_id != null)
                {
                    SQLstr = SQLstr + " and mnu_group_id = '" + EntityModul.modul_id + "'";
                }
                dt = Helper.ExecDT(SQLstr);

            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable getMenuUser(GSUserManagementBL.GSModul EntityModul, string _UserID_Selected)
        {
            try
            {
                SQLstr = "select mnu_menu_code,mnu_menu_name,flag_menu,flag_menu_group,flag_add,flag_edit,flag_delete,flag_print,flag_export " +
                    "from vw_GS_USER_MANAGEMENT_USER_MENU where usr_user_id = '" + _UserID_Selected + "' ";
                if (EntityModul.modul_id != null)
                {
                    SQLstr = SQLstr + " and mnu_group_id = '" + EntityModul.modul_id + "'";
                }
                dt = Helper.ExecDT(SQLstr);

            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public List<GSUserManagementBL.GSMenuOtoration> GetUserGroupMenu(string _GroupID_Selected)
        {

            List<GSUserManagementBL.GSMenuOtoration> _UserGroupMenu = new List<GSUserManagementBL.GSMenuOtoration>();

            SQLstr = "select gug_group_id,mnu_group_id,mnu_menu_code,mnu_menu_name,flag_menu,flag_add,flag_edit,flag_delete,flag_print,flag_export " +
                   "from vw_GS_USER_MANAGEMENT_USER_GROUP_MENU where gug_group_id = '" + _GroupID_Selected + "' ";

            dt = Helper.ExecuteQuery(SQLstr);

            if (dt.Rows.Count == 0)
            {
                return _UserGroupMenu;
            }

            foreach (DataRow item in dt.Rows)
            {
                _UserGroupMenu.Add(new GSUserManagementBL.GSMenuOtoration()
                {
                    group_user = item["gug_group_id"].ToString().Trim(),
                    group_menu = item["mnu_group_id"].ToString().Trim(),
                    menu_code = item["mnu_menu_code"].ToString().Trim(),
                    menu_desc = item["mnu_menu_name"].ToString().Trim(),
                    flag_menu = item["flag_menu"].ToString().Trim(),
                    flag_new = item["flag_add"].ToString().Trim(),
                    flag_edit = item["flag_edit"].ToString().Trim(),
                    flag_delete = item["flag_delete"].ToString().Trim(),
                    flag_print = item["flag_print"].ToString().Trim(),
                    flag_export = item["flag_export"].ToString().Trim()
                });
            }

                return _UserGroupMenu;
        }
        public List<GSUserManagementBL.GSUsers> GetListUsers()
        {
            List<GSUserManagementBL.GSUsers> result = new List<GSUserManagementBL.GSUsers>();
            string sql = "SELECT * FROM vw_USERS";
            DataTable dt = Helper.ExecuteQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return result;
            }

            foreach (DataRow dr in dt.Rows)
            {
                GSUserManagementBL.GSUsers user = new GSUserManagementBL.GSUsers();
                user.user_id = Helper.CastToString(dr["usr_user_id"]);
                user.name = Helper.CastToString(dr["usr_name"]);
                user.group_user_id = Helper.CastToString(dr["usr_group_user_id"]);
                user.description = Helper.CastToString(dr["usr_description"]);
                user.status = Helper.CastToString(dr["usr_status"]);

                result.Add(user);
            }

            return result;
        }
    }
}
