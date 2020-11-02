using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using System.Configuration;
using System.Threading.Tasks;
using System.ComponentModel;
using MADITP2._0.Global;

namespace MADITP2._0.login
{   
    public class clsLogin
    {
        //clsGlobal _clsGlobal = new clsGlobal();
        clsGlobal Helper = null;

        private  string mUSERID;
        public static string USERID;
        public static string USERPASSWORD;
        public static int FLAGPASSWORD;
        public static int FLAGVALIDASI;
        public static string FLAGSTATUS;
        public static string FORMPASSWORD;
        public static bool BTNNEW;
        public static bool BTNEDIT;
        public static bool BTNDELETE;
        public static bool BTNPRINT;
        public static bool BTNEXPORT;
        public static string MENUID;
        public static string MENUNAME;
        public static string GROUPMENUID;
        //public static bool ISADMIN;
        public static string FORMNAME;
        public static string FORMLOAD;

        public string USRID
        {
            get { return mUSERID; }
            set { this.mUSERID = value; }
        }

        public clsLogin()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
            }

        }

        public void LoginUser(string user_id,string user_pass)
        {
            USERID= string.Empty;
            USERPASSWORD = string.Empty;
            FLAGVALIDASI = 0;
            FLAGSTATUS = "N";
            try
            {
                var result = Helper.ExecuteQuery($"SELECT  usr_user_id, usr_password,usr_status,usr_validation,usr_group_user_id FROM FUNCTION_GS_LOGIN_USER ('{user_id.Trim()}','{user_pass}')");
                USERID = result.Rows[0].ItemArray.ElementAt(0).ToString();
                USRID = result.Rows[0].ItemArray.ElementAt(0).ToString();
                if (result.Rows[0].ItemArray.ElementAt(1).ToString() == "")
                {
                    USERPASSWORD = "";
                }
                else 
                { 
                     USERPASSWORD = result.Rows[0].ItemArray.ElementAt(1).ToString();
                }
                if (result.Rows[0].ItemArray.ElementAt(3).ToString() == "")
                {
                    FLAGVALIDASI = 0;
                }
                else
                {
                    FLAGVALIDASI = Convert.ToInt32(result.Rows[0].ItemArray.ElementAt(3).ToString());
                }
                FLAGSTATUS = result.Rows[0].ItemArray.ElementAt(2).ToString();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
        }

        public void AccessUser(string form_name, string menu_id)
        {
            string strSQL = "";

            //set kosong
            FLAGPASSWORD = 0;
            FORMPASSWORD = "";

            BTNNEW = false;
            BTNEDIT = false;
            BTNDELETE = false;
            BTNPRINT = false;
            BTNEXPORT = false;

            MENUID = "";
            MENUNAME = "";
            GROUPMENUID = "";
            FORMNAME = "";
            FORMLOAD = "";

            using (SqlConnection cnData = new SqlConnection(clsGlobal.ConnectionString))
            {
                strSQL = "select gmu_user_id, " +
                      "mnu_group_id," +
                      "gmu_menu_id, " +
                      "mnu_menu_name, " +
                      "isnull(gmu_flag_add,'N') f_add, " +
                      "isnull(gmu_flag_edit,'N') f_edit, " +
                      "isnull(gmu_flag_delete,'N') f_delete, " +
                      "isnull(gmu_flag_print,'N') f_print," +
                      "isnull(gmu_flag_export,'N') f_export," +
                      "isnull(mnu_password_flag,'0') f_password, " +
                      "isnull(mnu_form_name,'')form_name, " +
                      "mnu_menu_type " +
                      "from GS_MENU_USERS " +
                      "inner join GS_MENUS on gmu_menu_id=mnu_menu_code " +
                      "where gmu_user_id = '" + USERID + "' and gmu_menu_id = '" + menu_id +"' ";

                SqlCommand cmd = new SqlCommand(strSQL, cnData);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["mnu_menu_type"].ToString().Trim() == "C")
                    {
                        FLAGPASSWORD = Convert.ToInt32(ds.Tables[0].Rows[0]["f_password"].ToString());
                        //FORMPASSWORD = ds.Tables[0].Rows[0]["gh_password"].ToString();

                        if (ds.Tables[0].Rows[0]["f_add"].ToString().ToUpper() == "Y")
                        { BTNNEW = true; }
                        else { BTNNEW = false; }
                        if (ds.Tables[0].Rows[0]["f_edit"].ToString().ToUpper() == "Y")
                        { BTNEDIT = true; }
                        else { BTNEDIT = false; }
                        if (ds.Tables[0].Rows[0]["f_delete"].ToString().ToUpper() == "Y")
                        { BTNDELETE = true; }
                        else { BTNDELETE = false; }
                        if (ds.Tables[0].Rows[0]["f_print"].ToString().ToUpper() == "Y")
                        { BTNPRINT = true; }
                        else { BTNPRINT = false; }
                        if (ds.Tables[0].Rows[0]["f_export"].ToString().ToUpper() == "Y")
                        { BTNEXPORT = true; }
                        else { BTNEXPORT = false; }

                        MENUID = ds.Tables[0].Rows[0]["gmu_menu_id"].ToString().Trim();
                        MENUNAME = ds.Tables[0].Rows[0]["mnu_menu_name"].ToString().Trim();
                        GROUPMENUID = ds.Tables[0].Rows[0]["mnu_group_id"].ToString().Trim();

                        FORMNAME = ds.Tables[0].Rows[0]["form_name"].ToString().Trim();
                        FORMLOAD = ds.Tables[0].Rows[0]["form_name"].ToString().Trim();
                    }
                }
            }
        }
    }
}
