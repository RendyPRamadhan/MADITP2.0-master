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
using MADITP2._0.Global;
using MADITP2._0.login;
using System.Net.NetworkInformation;
using System.Net;
using System.Reflection;
using Tira.Component;

namespace MADITP2._0.Global
{
    public class clsGlobal
    {
        public static string DIR_REG_CONNECTION = "HKEY_CURRENT_USER\\SOFTWARE\\TiraSnDNetConnection\\";
        public static String hostName = "";
        public static String descripsi = "";
        public static String IP = "";
        public static int MODE_TRX = 0; //0 = select, 1 = new, 2 = edit, 3 = delete
        public static int TRX_SELECT = 0;
        public static int TRX_NEW = 1;
        public static int TRX_EDIT = 2;
        public static int TRX_DELETE = 3;
        //public static string ENTITYID = "01";
        public static string ENTITYID;
        public static string ENTITYDESC;
        public static string BRANCHID;
        public static string BRANCHDESC;
        public static string DIR_APP_CURRENT = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static string FOL_INI = "INI";
        public static string FILE_INI = "APP.INI";

        public static string APP_MSG_CAPTION = "Application Message";
        public static string APP_MSG_CAPTION_DELETE = "Delete Confirmation";

        public String NodeName;
        public String NodeGroup;

        public static string KEY_REG;
        public static string KEY_DESC;
        //public static string CONNECTION_STRING;
        //public static string APPNAME, EXISTBRANCH, EXISTDIVISION, EXISTENTITY, DBDESC;

        public int SqlCommandTimeOut { get; private set; } = 100;
        public static string ConnectionString = string.Empty;

        //public static string CONNECTION_STRING = "Data Source=10.88.37.17;Initial Catalog=BOOK_DEV2;User ID=sa;Password=N3wm4d1tp12#$";
        public static string APPNAME = "MADITP 2.0";


        public clsGlobal()
        {
            ReadSetting();
        }

        void ReadSetting()
        {
            try
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
                hostName = Dns.GetHostName();
                IPHostEntry myIP = Dns.GetHostEntry(hostName);
                IPAddress[] address = myIP.AddressList;

                for (int i = 0; i < address.Length; i++)
                {
                    descripsi = descripsi + "# " + address[i].ToString();
                }
                IP = address[3].ToString() + "-" + address[4].ToString();
            }
            catch (Exception es)
            {
                //throw es;
            }
        }

        public static void DoGetHostEntry(string hostname)
        {
            IPHostEntry host = Dns.GetHostEntry(hostname);

            foreach (IPAddress address in host.AddressList)
            {
                Console.WriteLine($"    {address}");
            }
        }

        public SqlConnection Connect = new SqlConnection();
        public SqlTransaction tr;
        public bool TIRA_REGISTRY()
        {
            bool connValid = false;

            if (CheckConnection())
            {
                if (KEY_REG == "")
                {
                    if (GetKeyReg(KEY_DESC) == false)
                    {
                        MessageBox.Show("Connection string not found, please contact your Administrator.", clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        connValid = false;
                        return false;
                    }
                }
                connValid = true;

            }
            return connValid;
        }

        public bool CheckConnection()
        {
            KEY_REG = Registry.GetValue(@"" + DIR_REG_CONNECTION + "TiraSnDNet_Setting\\Setting", "ApplyConnKey", "").ToString();
            KEY_DESC = Registry.GetValue(@"" + DIR_REG_CONNECTION + "TiraSnDNet_Setting\\Setting", "ApplyConnDesc", "").ToString();

            Registry.SetValue(@"" + DIR_REG_CONNECTION + "TiraSnDNet_Setting\\Setting", "ApplyConnKey", "");
            Registry.SetValue(@"" + DIR_REG_CONNECTION + "TiraSnDNet_Setting\\Setting", "ApplyConnDesc", "");

            //MessageBox.Show("KEY_REG1 " + KEY_REG, clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            string strPath;
            strPath = DIR_APP_CURRENT + "\\" + FOL_INI;
            CreateFolder(strPath);

            //creat textfile
            strPath = strPath + "\\" + FILE_INI;
            if (!File.Exists(strPath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(strPath))
                {
                    sw.WriteLine("[APP]");
                    sw.WriteLine("AppName=" + KEY_DESC + "");
                }
            }
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(strPath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Substring(0, 1) != "[")
                    {
                        if (s.Substring(0, 1) != ";")
                        {
                            KEY_DESC = s.Substring(8, s.Length - 8).Trim();
                        }
                    }
                }
            }

            //MessageBox.Show("KEY_DESC1 " + KEY_DESC, clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (KEY_DESC == "")
            {
                MessageBox.Show("Connection string is nothing, please contact your Administrator.", clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        public clsGlobal viewNode(String Node)
        {
            string SQLstr;
            string myNode = "";

            this.NodeName = "";
            this.NodeGroup = "";

            using (SqlConnection cnData = new SqlConnection(ConnectionString))
            {
                SQLstr = "select gmu_menu_id "
                                + "FROM GS_MENU_USERS "
                                + "where gmu_user_id = '" + clsLogin.USERID + "' "
                                + "and gmu_menu_id = '" + Node + "' ";

                cnData.Open();
                SqlDataAdapter da = new SqlDataAdapter(SQLstr, cnData);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                foreach (DataRow dr in dt.Rows)
                {
                    myNode = dr["gmu_menu_id"].ToString();
                    this.NodeName = dr["gmu_menu_id"].ToString();
                    this.NodeGroup = dr["gmu_menu_id"].ToString();
                }
                cnData.Close();
                return this;
            }
        }

        public string ApplMessage(int err_code)
        {
            string strSQL = "";
            string strMsg = "";

            strSQL = "SELECT gh_sys, gh_function_name, gh_sequence_no, gh_function_desc, gh_min_seq_no " +
                "FROM GS_GEN_HARDCODED WITH(NOLOCK) " +
                "WHERE gh_sys = 'MG' " +
                "AND gh_sequence_no = " + err_code + " ";

            using (SqlConnection cnData = new SqlConnection(ConnectionString))
            {
                cnData.Open();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cnData);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cnData.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    strMsg = ds.Tables[0].Rows[0]["gh_function_desc"].ToString().Trim();
                }
            }
            return strMsg;
        }

        public void GetEntityByUser(string user_id)
        {
            string strSQL = "";
            strSQL = "select gue_user_id, gue_entity_id, gec_entity from GS_USER_ENTITY u WITH(NOLOCK) " +
                    "inner join GS_ENTITY_CODES e WITH(NOLOCK)on u.gue_entity_id = e.gec_entity_id " +
                    "where gue_user_id = '" + user_id + "'";

            if (ExecDT(strSQL).Rows.Count > 0)
            {
                ENTITYID = ExecDT(strSQL).Rows[0]["gue_entity_id"].ToString().Trim();
                ENTITYDESC = ExecDT(strSQL).Rows[0]["gec_entity"].ToString().Trim();
            }
        }

        public void GetBranchByUser(string user_id)
        {
            string strSQL = "";
            strSQL = "select ue_user_id, ue_entity_id, br_branch_id, br_branch_desc from GL_USER_ENTITY u WITH(NOLOCK) " +
                    "inner join GS_BRANCH WITH(NOLOCK)on ue_entity_id = br_gl_entity_initial " +
                    "where ue_user_id = '" + user_id + "'";

            if (ExecDT(strSQL).Rows.Count > 0)
            {
                BRANCHID = ExecDT(strSQL).Rows[0]["br_branch_id"].ToString().Trim();
                BRANCHDESC = ExecDT(strSQL).Rows[0]["br_branch_desc"].ToString().Trim();
            }
        }

        public DataTable GetEntityBranch()
        {
            string strSQL = "";
            DataTable dt;
            strSQL = "SELECT ge_entity_id, ge_entity,br_branch_desc FROM GS_ENTITY WITH(NOLOCK) " +
                        "left join GS_BRANCH WITH(NOLOCK) on br_gl_entity_initial = ge_entity_id";

            using (SqlConnection cnData = new SqlConnection(ConnectionString))
            {
                cnData.Open();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cnData);
                dt = new DataTable();
                da.Fill(dt);
                cnData.Close();
            }

            return dt;
        }

        public void TIRAConnection()
        {
            try
            {
                Connect.Close();
                Connect = new SqlConnection(ConnectionString);
                Connect.Open();

            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message, clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string DateToDB(string sDate)
        {
            string date_to_db;
            date_to_db = Convert.ToDateTime(sDate).ToString("yyyy-MM-dd");

            return date_to_db;
        }

        public DataTable ExecDT(string query)
        {
            TIRAConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            da.Fill(dt);
            Connect.Close(); //for least connection        

            return dt;
        }

        public string GetFieldValue(string query)
        {
            TIRAConnection();

            string sValue = "";
            SqlCommand cmd = new SqlCommand(query, Connect);
            object obj = cmd.ExecuteScalar();
            if (obj != null)
            {
                sValue = obj.ToString().Trim();
            }

            Connect.Close();
            return sValue;
        }

        public void BeginTrans()
        {
            TIRAConnection();
            tr = Connect.BeginTransaction(IsolationLevel.Serializable);
        }

        internal void ExecuteTrans(string query, List<SqlParameterHelper> SqlParam = null)
        {
            SqlCommand cmd = new SqlCommand(query, Connect, tr);
            if (SqlParam != null)
            {
                foreach (var param in SqlParam)
                {
                    var v = (param.VALUE == null) ? DBNull.Value : param.VALUE;
                    cmd.Parameters.AddWithValue(param.PARAMETR_NAME, v);
                }
            }

            cmd.ExecuteNonQuery();
            cmd.Dispose(); //for least connection   
        }

        public void CommitTrans()
        {
            tr.Commit();
            tr.Dispose(); //for least connection   
            Connect.Close(); //for least connection   
        }

        public void RollbackTrans()
        {
            tr.Rollback();
            tr.Dispose(); //for least connection   
            Connect.Close(); //for least connection   
        }

        public void Execute(string query)
        {
            TIRAConnection();
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.ExecuteNonQuery();
            cmd.Dispose(); //for least connection      
            Connect.Close(); //for least connection      
        }

        public void CreateFolder(string str_path)
        {
            if (!Directory.Exists(str_path))
            {
                Directory.CreateDirectory(str_path);
            }
        }

        private bool GetKeyReg(string key_desc)
        {
            bool keyFound = false;
            string connDesc, connReg, checkConnReg;
            int _countConn = 0;

            using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\TiraSnDNetConnection\TiraSnDNet_Setting\Setting\"))
            {
                if (Key != null)
                {
                    _countConn = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\TiraSnDNetConnection\TiraSnDNet_Setting\Setting\", "CountConn", "NULL").ToString());
                }
            }

            if (_countConn > 0)
            {
                for (int i = 1; i <= _countConn; i++)
                {
                    checkConnReg = "SOFTWARE\\TiraSnDNetConnection\\TiraNet" + i + "\\Conn\\";

                    using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"" + checkConnReg + ""))
                        if (Key != null)
                        {
                            connReg = DIR_REG_CONNECTION + "TiraNet" + i + "\\Conn\\";
                            connDesc = Registry.GetValue(@"" + connReg + "", "ConnDesc", "NULL").ToString();
                            if (connDesc.ToUpper() == KEY_DESC.ToUpper())
                            {
                                KEY_REG = "TiraNet" + i;
                                keyFound = true;
                                break;
                            }
                        }
                }
            }
            return keyFound;
        }

        public void FormatNumericAndComma(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        //public void ProgressWorkerMethod(object sender, Jacksonsoft.WaitWindowEventArgs e)
        //{
        //    //Stopwatch sw = new Stopwatch();
        //    //int countProc;
        //    //sw.Start();
        //    //sw.Stop();  

        //    //	Do something
        //    for (int progress = 1; progress <= 100; progress++)
        //    {
        //        System.Threading.Thread.Sleep(10);

        //        //	Update the wait window message
        //        e.Window.Message = string.Format("Please wait ... {0}%", progress.ToString().PadLeft(3));
        //    }

        //    //	Use the arguments sent in
        //    if (e.Arguments.Count > 0)
        //    {
        //        //	Set the result to return
        //        e.Result = e.Arguments[0].ToString();
        //    }
        //    else
        //    {
        //        //	Set the result to return
        //        e.Result = "Successfully.";
        //    }

        //}

        public string DayToIndonesia(string hari)
        {
            string day_to_indonesia = "";

            switch (hari)
            {
                case "Sunday":
                    day_to_indonesia = "Minggu";
                    break;
                case "Monday":
                    day_to_indonesia = "Senin";
                    break;
                case "Tuesday":
                    day_to_indonesia = "Selasa";
                    break;
                case "Wednesday":
                    day_to_indonesia = "Rabu";
                    break;
                case "Thursday":
                    day_to_indonesia = "Kamis";
                    break;
                case "Friday":
                    day_to_indonesia = "Jumat";
                    break;
                case "Saturday":
                    day_to_indonesia = "Sabtu";
                    break;
            }

            return day_to_indonesia;
        }

        public void GridColorCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.Aqua;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }
        }

        public void GridNumbering(DataGridView dgv, object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        public void FormSize(Form frm, int width_value, int height_value)
        {
            if (frm.Width < width_value)
            {
                frm.Width = width_value;
            }

            if (frm.Height < height_value)
            {
                frm.Height = height_value;
            }
        }

        public void ButtonAccess(ToolStripButton b_new, ToolStripButton b_edit, ToolStripButton b_delete, ToolStripButton b_print)
        {
            b_new.Enabled = clsLogin.BTNNEW;
            b_edit.Enabled = clsLogin.BTNEDIT;
            b_delete.Enabled = clsLogin.BTNDELETE;
            b_print.Enabled = clsLogin.BTNPRINT;
        }

        public void NumericOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public DataTable FillComboBoxYesNo(ComboBox cmb)
        {
            TIRAConnection();
            string qry;
            qry = "SELECT gh_function_code, gh_function_desc " +
                "FROM GS_GEN_HARDCODED WITH(NOLOCK) " +
                "WHERE gh_sys = 'H' AND gh_function_name = 'YN' ";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qry, Connect);
            da.Fill(dt);

            cmb.DataSource = dt;
            cmb.ValueMember = "gh_function_code";
            cmb.DisplayMember = "gh_function_desc";
            //cmb.SelectedIndex = -1;

            Connect.Close();
            return dt;
        }

        public void CheckBoxCaption(CheckBox objCheck, string caption_true, string caption_false)
        {
            if (objCheck.Checked)
            {
                objCheck.Text = caption_true;
            }
            else
            {
                objCheck.Text = caption_false;
            }
        }

        public void CheckBoxChecked(CheckBox objCheck, bool valCheck)
        {
            if (valCheck)
            {
                objCheck.Checked = true;
            }
            else
            {
                objCheck.Checked = false;
            }
        }

        public string CheckBoxValueYN(CheckBox objCheck)
        {
            string cValue = "N";

            if (objCheck.Checked)
            {
                cValue = "Y";
            }
            else
            {
                cValue = "N";
            }
            return cValue;
        }

        public string AngkaToBulan(int bulan)
        {
            string angka_to_bulan = "";

            switch (bulan)
            {
                case 1:
                    angka_to_bulan = "January";
                    break;
                case 2:
                    angka_to_bulan = "February";
                    break;
                case 3:
                    angka_to_bulan = "March";
                    break;
                case 4:
                    angka_to_bulan = "April";
                    break;
                case 5:
                    angka_to_bulan = "May";
                    break;
                case 6:
                    angka_to_bulan = "June";
                    break;
                case 7:
                    angka_to_bulan = "July";
                    break;
                case 8:
                    angka_to_bulan = "August";
                    break;
                case 9:
                    angka_to_bulan = "September";
                    break;
                case 10:
                    angka_to_bulan = "October";
                    break;
                case 11:
                    angka_to_bulan = "November";
                    break;
                case 12:
                    angka_to_bulan = "December";
                    break;
            }

            return angka_to_bulan;
        }

        public string BulanToAngka(string namabulan)
        {
            string bulan_to_angka = "0";

            switch (namabulan)
            {
                case "January":
                    bulan_to_angka = "1";
                    break;
                case "February":
                    bulan_to_angka = "2";
                    break;
                case "March":
                    bulan_to_angka = "3";
                    break;
                case "April":
                    bulan_to_angka = "4";
                    break;
                case "May":
                    bulan_to_angka = "5";
                    break;
                case "June":
                    bulan_to_angka = "6";
                    break;
                case "July":
                    bulan_to_angka = "7";
                    break;
                case "August":
                    bulan_to_angka = "8";
                    break;
                case "September":
                    bulan_to_angka = "9";
                    break;
                case "October":
                    bulan_to_angka = "10";
                    break;
                case "November":
                    bulan_to_angka = "11";
                    break;
                case "December":
                    bulan_to_angka = "12";
                    break;
            }

            return bulan_to_angka;
        }

        public string GetWorkingDay() //Tgl Gudang
        {
            string sWorkDate = "";

            DataTable dt = ExecDT("select gh_function_code from GS_GEN_HARDCODED WITH(NOLOCK) where gh_function_name = 'MAINWHLOC'");
            if (dt.Rows.Count > 0)
            {
                sWorkDate = GetFieldValue("select wh_loc_last_work_date from IM_WH_LOC WITH(NOLOCK) " +
                            "Where wh_loc_id1 = '" + Split(dt.Rows[0]["gh_function_code"].ToString(), '|')[0] + "' " +
                            "and wh_loc_id2 = '" + Split(dt.Rows[0]["gh_function_code"].ToString(), '|')[1] + "'");
            }

            return sWorkDate;
        }

        public string[] Split(string s_value, char s_separator)
        {
            string[] strSplit = s_value.Split(s_separator);
            return strSplit;
        }

        internal DataTable ExecuteQuery(string query, List<SqlParameterHelper> SqlParam = null)
        {
            DataTable result = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (SqlParam != null)
                    {
                        foreach (var param in SqlParam)
                        {
                            var v = (param.VALUE == null) ? DBNull.Value : param.VALUE;
                            cmd.Parameters.AddWithValue(param.PARAMETR_NAME, v);
                        }
                    }

                    cmd.CommandTimeout = SqlCommandTimeOut;
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(result);
                    }
                }
            }
            return result;
        }

        internal DataSet ExecuteQuery_DS(string query, List<SqlParameterHelper> SqlParam = null)
        {
            DataSet result = new DataSet();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (SqlParam != null)
                    {
                        foreach (var param in SqlParam)
                        {
                            var v = (param.VALUE == null) ? DBNull.Value : param.VALUE;
                            cmd.Parameters.AddWithValue(param.PARAMETR_NAME, v);
                        }
                    }

                    cmd.CommandTimeout = SqlCommandTimeOut;
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(result);
                    }
                }
            }
            return result;
        }

        internal int ExecuteNonQuery(string query)
        {
            int result = 0;
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandTimeout = SqlCommandTimeOut;
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }

        internal DataTableCollection ExecuteStoreProcedure(string storeProcedure, List<SqlParameterHelper> parameterHelper)
        {
            DataSet dataset = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = new SqlCommand(storeProcedure, conn);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.CommandTimeout = SqlCommandTimeOut;
                    if (parameterHelper != null)
                    {
                        foreach (var item in parameterHelper)
                        {
                            adapter.SelectCommand.Parameters.AddWithValue(
                                item.PARAMETR_NAME
                                , item.VALUE == null ? DBNull.Value : item.VALUE
                                );
                        }
                    }
                    adapter.Fill(dataset);
                }
                return dataset.Tables;
            }

        }

        /// <summary>
        /// cast object to string with nullPointerException already handled.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string CastToString(Object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return string.Empty;
            }

            return obj.ToString().Trim();
        }

        public DateTime? CastToDatetime(Object obj)
        {
            if (obj == DBNull.Value || obj == null)
            {
                return null;
            }

            return Convert.ToDateTime(obj);
        }

        public int CastToInt(Object obj)
        {
            if (obj == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(obj);
        }

        public void ResetAllFormControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is MaskedTextBox)
                {
                    MaskedTextBox maskedTxt = (MaskedTextBox)control;
                    maskedTxt.Clear();
                }
            }
        }
        public void getComboUser(ComboBox UserEntities, ComboBox UserBranches)
        {
            var DataUser = new clsLogLoginDA();

            UserEntities.DataSource = DataUser.GetEntity();
            UserEntities.DisplayMember = "DisplayMember";
            UserEntities.ValueMember = "ValueMember";

            UserBranches.DataSource = DataUser.GetBranch();
            UserBranches.DisplayMember = "DisplayMember";
            UserBranches.ValueMember = "ValueMember";
        }

        public void getAccessMenu(Button New, Button Edit, Button Delete, Button Print, Button Export)
        {

            New.Enabled = clsLogin.BTNNEW;
            Edit.Enabled = clsLogin.BTNEDIT;
            Delete.Enabled = clsLogin.BTNDELETE;
            Print.Enabled = clsLogin.BTNPRINT;
            Export.Enabled = clsLogin.BTNEXPORT;
        }

        public List<T> ConvertDataTableToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        public T ConvertDataTableToModel<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data.FirstOrDefault();
        }

        public DataTable ConvertListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }

            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        public T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {

                        dynamic Value;

                        if (DBNull.Value.Equals(dr[column.ColumnName]))
                        {
                            if (pro.PropertyType.Name == typeof(Nullable<>).Name)
                            {
                                Value = null;
                            }
                            else
                            {
                                Value = GetDefaultValueByDataType(pro.PropertyType);
                            }
                        }
                        else
                        {
                            if (pro.PropertyType.Name == typeof(Nullable<>).Name)
                            {
                                Value = dr[column.ColumnName];
                            }
                            else
                            {
                                Value = Convert.ChangeType(dr[column.ColumnName], pro.PropertyType);
                            }
                        }

                        pro.SetValue(obj, Value, null);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return obj;
        }

        public string Terbilang(Decimal d)
        {
            string[] satuan = new string[10] { "nol", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan" };
            string[] belasan = new string[10] { "sepuluh", "sebelas", "dua belas", "tiga belas", "empat belas", "lima belas", "enam belas", "tujuh belas", "delapan belas", "sembilan belas" };
            string[] puluhan = new string[10] { "", "", "dua puluh", "tiga puluh", "empat puluh", "lima puluh", "enam puluh", "tujuh puluh", "delapan puluh", "sembilan puluh" };
            string[] ribuan = new string[5] { "", "ribu", "juta", "milyar", "triliyun" };

            string strHasil = "";
            Decimal frac = d - Decimal.Truncate(d);

            if (Decimal.Compare(frac, 0.0m) != 0)
                strHasil = Terbilang(Decimal.Round(frac * 100)) + " sen";
            else
                strHasil = "rupiah";
            int xDigit = 0;
            int xPosisi = 0;

            string strTemp = Decimal.Truncate(d).ToString();
            for (int i = strTemp.Length; i > 0; i--)
            {
                string tmpx = "";
                xDigit = Convert.ToInt32(strTemp.Substring(i - 1, 1));
                xPosisi = (strTemp.Length - i) + 1;
                switch (xPosisi % 3)
                {
                    case 1:
                        bool allNull = false;
                        if (i == 1)
                            tmpx = satuan[xDigit] + " ";
                        else if (strTemp.Substring(i - 2, 1) == "1")
                            tmpx = belasan[xDigit] + " ";
                        else if (xDigit > 0)
                            tmpx = satuan[xDigit] + " ";
                        else
                        {
                            allNull = true;
                            if (i > 1)
                                if (strTemp.Substring(i - 2, 1) != "0")
                                    allNull = false;
                            if (i > 2)
                                if (strTemp.Substring(i - 3, 1) != "0")
                                    allNull = false;
                            tmpx = "";
                        }

                        if ((!allNull) && (xPosisi > 1))
                            if ((strTemp.Length == 4) && (strTemp.Substring(0, 1) == "1"))
                                tmpx = "se" + ribuan[(int)Decimal.Round(xPosisi / 3m)] + " ";
                            else
                                tmpx = tmpx + ribuan[(int)Decimal.Round(xPosisi / 3)] + " ";
                        strHasil = tmpx + strHasil;
                        break;
                    case 2:
                        if (xDigit > 0)
                            strHasil = puluhan[xDigit] + " " + strHasil;
                        break;
                    case 0:
                        if (xDigit > 0)
                            if (xDigit == 1)
                                strHasil = "seratus " + strHasil;
                            else
                                strHasil = satuan[xDigit] + " ratus " + strHasil;
                        break;
                }
            }
            strHasil = strHasil.Trim().ToLower();
            if (strHasil.Length > 0)
            {
                strHasil = strHasil.Substring(0, 1).ToUpper() +
                  strHasil.Substring(1, strHasil.Length - 1);
            }
            return strHasil;
        }

        public object GetDefaultValueByDataType(Type t)
        {
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }

        private TiraButton button;

        public void SetActive(object sender)
        {
            if (sender != null)
            {
                SetInActive();
                button = (TiraButton)sender;
                button.BackColor = Color.White;
                //button.ForeColor = Color.FromArgb(239, 104, 36);
                //button.IconColor = Color.FromArgb(239, 104, 36);
                /*border.BackColor = Color.FromArgb(239, 104, 36);
                border.Location = new Point(button.Location.X, 27);
                border.Size = new Size(button.Width, 3);
                border.Visible = true;
                border.BringToFront();*/
            }
        }

        private void SetInActive()
        {
            if (button != null)
            {
                button.BackColor = SystemColors.Control;
                //button.ForeColor = Color.Black;
                //button.IconColor = Color.Black;
            }
        }

        public string GetTCode(string _menuName)
        {
            string strSQL = "";

            strSQL = "select mnu_menu_code from GS_MENUS where mnu_form_name = '" + _menuName + "'";

            DataTable dt = ExecDT(strSQL);
            string result = dt.Rows[0]["mnu_menu_code"].ToString();

            return result;
        }

        public DataTable GetCompany()
        {
            string strSQL = "";

            strSQL = "select c_company, c_address_1, c_address_2, c_address_3, c_city, c_postal_code, c_phone, c_fax from COMPANY";
            DataTable result = ExecDT(strSQL);

            return result;
        }

        public DataTable GetReport(string _Query)
        {
            DataTable result = new DataTable();
            if (_Query != "")
            {
                result = ExecDT(_Query);
            }

            return result;
        }
    }
}
