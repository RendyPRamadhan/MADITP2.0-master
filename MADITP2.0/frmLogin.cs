using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.Enums;

namespace MADITP2._0
{
    public partial class frmLogin : Form
    {
        private clsLogin _clsLogin = new clsLogin();
        private clsGlobal _clsGlobal = new clsGlobal();
        private clsLogLoginBO DataMember = new clsLogLoginBO();
        private clsLogLoginDA DataMemberCtrl = new clsLogLoginDA();
        private int counter = 0;
        private string APP_VERSION = "APP_VERSION";

        public frmLogin()
        {
            InitializeComponent();
            _clsLogin = new clsLogin();
            _clsGlobal = new clsGlobal();
        }

        private int DBAppVersion()
        {
            int db_app_version = 0;
            //int app_current_version = 0;

            //app_current_version = Convert.ToInt32(Application.ProductVersion.Replace(".", ""));

            //strSQL = "";
            //strSQL = "select gh_function_code FROM GS_GEN_HARDCODED WITH(NOLOCK) where gh_function_name='" + APP_VERSION + "'";

            //if (_clsGlobal.ExecDT(strSQL).Rows.Count > 0)
            //{
            //    db_app_version = Convert.ToInt32(_clsGlobal.ExecDT(strSQL).Rows[0]["gh_function_code"].ToString().Trim());
            //}
            //else
            //{
            //    MessageBox.Show("Parameter " + APP_VERSION + " not set.", clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            //if (db_app_version != 0 && db_app_version < app_current_version)
            //{
            //    UpdateVersion();

            //    strSQL = "";
            //    strSQL = "select gh_function_code FROM GS_GEN_HARDCODED WITH(NOLOCK) where gh_function_name='" + APP_VERSION + "'";

            //    db_app_version = Convert.ToInt32(_clsGlobal.ExecDT(strSQL).Rows[0]["gh_function_code"].ToString().Trim());
            //}

            return db_app_version;
        }

        private void UpdateVersion()
        {
            //string lastVersion;
            //lastVersion = Application.ProductVersion.Replace(".", "").Trim();
            //strSQL = "";
            //strSQL = "update GS_GEN_HARDCODED set " +
            //    "gh_function_code = '" + lastVersion + "' " +
            //    "where gh_function_name='" + APP_VERSION + "'";

            //_clsGlobal.Execute(strSQL);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                int _dbAppVersion = 0;
                int _appCurrentVersion = 0;
                string dePass = null;

                string enPass;
                enPass = clsCryptoEngine.Encrypt(txtPassword.Text, "sblw-3hn8-sqoy19");

                _dbAppVersion = DBAppVersion();
                _appCurrentVersion = Convert.ToInt32(Application.ProductVersion.Replace(".", ""));

                if ((_dbAppVersion != 0) && (_dbAppVersion != _appCurrentVersion))
                {
                    MessageBox.Show("Application version not valid." + Environment.NewLine + "Please contact your Administrator.", clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _clsLogin = new clsLogin();
                    DataSet ds = new DataSet();
                    _clsLogin.LoginUser(txtUserID.Text.Trim(), enPass);
                    counter = clsLogin.FLAGVALIDASI;
                    if (clsLogin.USERID != "")
                    {
                        //dekripsi password
                        dePass = clsCryptoEngine.Decrypt(clsLogin.USERPASSWORD, "sblw-3hn8-sqoy19");

                        if(clsLogin.FLAGVALIDASI >=3)
                        {
                            //insert log
                            var DataMember = new clsLogLoginBO();
                            var DataMemberCtrl = new clsLogLoginDA();
                            DataMember.login.USRID = txtUserID.Text;
                            DataMember.Host = clsGlobal.IP;
                            DataMember.IP = clsGlobal.hostName;
                            DataMember.Keterangan = clsGlobal.descripsi;
                            DataMember.LogStatus = "Sukses Login kedabase";
                            DataMemberCtrl.Post(DataMember);

                            MessageBox.Show("Hubungi Administrator sudah lebih 3 kali gagal", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else if (dePass == "admin")//txtPassword.Text.Trim())
                        {
                            _clsGlobal.GetEntityByUser(clsLogin.USERID);
                            //load.Visible = true;
                            //timer1.Start();
                            splash();

                            //insert log
                            var DataMember = new clsLogLoginBO();
                            var DataMemberCtrl = new clsLogLoginDA();
                            var DataUser = new clsLogLoginDA();
                            DataMember.login.USRID= txtUserID.Text;
                            DataMember.Host = clsGlobal.IP;
                            DataMember.IP = clsGlobal.hostName;
                            DataMember.Keterangan = clsGlobal.descripsi;
                            DataMember.LogStatus = "Sukses Login kedabase";
                            DataMember.Version = Application.ProductVersion;
                            DataMemberCtrl.Post(DataMember);
                            DataUser.GetBranch();
                            denied("N");

                        }
                        else
                        {
                            //insert log
                            var DataMember = new clsLogLoginBO();
                            var DataMemberCtrl = new clsLogLoginDA();
                            DataMember.login.USRID = txtUserID.Text;
                            DataMember.Host = clsGlobal.IP;
                            DataMember.IP = clsGlobal.hostName;
                            DataMember.Keterangan = clsGlobal.descripsi;
                            DataMember.LogStatus = "Gagal Login kedabase";
                            DataMember.Version = Application.ProductVersion;
                            DataMemberCtrl.Post(DataMember);

                            denied("Y");

                            txtPassword.Select();

                            MessageBox.Show("Username atau Password salah.");
                        }
                    }
                    else
                    {
                        //insert log
                        var DataMember = new clsLogLoginBO();
                        var DataMemberCtrl = new clsLogLoginDA();
                        DataMember.login.USRID = txtUserID.Text;
                        DataMember.Host = clsGlobal.IP;
                        DataMember.IP = clsGlobal.hostName;
                        DataMember.Keterangan = clsGlobal.descripsi;
                        DataMember.LogStatus = "Gagal Login kedabase";
                        DataMember.Version = Application.ProductVersion;
                        DataMemberCtrl.Post(DataMember);

                        denied("Y");

                        txtPassword.Select();

                        txtUserID.Select();

                        MessageBox.Show("Username atau Password salah.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

      

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    //SendKeys.Send("{TAB}");
                    btnLogin_Click(sender, e);
                }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = this.checkBox1.Checked ? char.MinValue : '●';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load.Value += 10;
            if (load.Value == 100)
            {
                timer1.Stop();
                this.Hide();

                txtUserID.Clear();
                txtPassword.Clear();

                frmMDI frm = new frmMDI();
                frm.Show();
                
            }
        }
        private void denied(string sflag)
        {
            try
            {
                counter += 1;
                var DataMember = new clsLogLoginBO();
                var DataMemberCtrl = new clsLogLoginDA();
                DataMember.login.USRID = txtUserID.Text;
                DataMember.Flag = sflag;
                DataMember.IP = clsGlobal.IP;
                DataMemberCtrl.Put(DataMember);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void splash()
        {
            this.Hide();
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
            frmMDI frm = new frmMDI();
            frm.Show();
        }
    }
}
