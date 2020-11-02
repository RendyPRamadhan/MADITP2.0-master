using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.Global
{
    public partial class clsPopUpBA : Form
    {
        private string SQL_BA;
        private clsGlobal Helper;
        private clsAlert Alert;
        private string baRepId;
        private string baManagerId;
        private string bamanagerName;
        private string baBranchId;

        public string BaManagerId { get => baManagerId; set => baManagerId = value; }
        public string BamanagerName { get => bamanagerName; set => bamanagerName = value; }
        public string BaBranchId { get => baBranchId; set => baBranchId = value; }
        public string BaRepId { get => baRepId; set => baRepId = value; }

        public clsPopUpBA(clsGlobal helper, clsAlert alert)
        {
            InitializeComponent();

            SQL_BA = "SELECT trim(RC_REP_MASTER.rm_branch_id) as Branch_Id, " +
                "case when RC_REP_MASTER.rm_current_position IN('EPD','GEPD','VPD','GVPD') " +
                "THEN trim(RC_REP_MASTER.rm_rep_id) " +
                "ELSE trim(RC_REP_MASTER.rm_manager_id) " +
                "END Manager_Id, " +
                "trim(RC_REP_MASTER.rm_rep_id) as Rep_Id, " +
                "RC_REP_MASTER.rm_name, case when RC_REP_MASTER.rm_current_position IN('EPD','GEPD','VPD','GVPD') " +
                "THEN trim(RC_REP_MASTER.rm_name) " +
                "ELSE trim(RC_REP_MASTER_1.rm_name) " +
                "END AS Manager_Name " +
                "FROM VW_RC_REP_MASTER_FOR_NEW_SCHEMA RC_REP_MASTER " +
                "INNER JOIN RC_REP_MASTER RC_REP_MASTER_1 ON RC_REP_MASTER.rm_manager_id = RC_REP_MASTER_1.rm_rep_id " +
                "WHERE RC_REP_MASTER.rm_current_position IN('EPC','EPD','GEPD','VPC','VPD','GVPD')";

            Alert = alert;
            Helper = helper;
        }

        private void DrawDatatable()
        {
            List<SqlParameterHelper> sqlParam = new List<SqlParameterHelper>();
            DataTable result = new DataTable();
            if(txtSearch.Text.Length > 0)
            {
                var sqlExec = "";
                sqlParam.Add(new SqlParameterHelper() { PARAMETR_NAME = "@Search", VALUE = "%" + txtSearch.Text + "%" });
                sqlExec = SQL_BA + " and (lower(RC_REP_MASTER.rm_name) like lower(@Search) or lower(RC_REP_MASTER_1.rm_name) like lower(@Search))";

                try
                {
                    result = Helper.ExecuteQuery(sqlExec, sqlParam);
                }
                catch (Exception e)
                {
                    Alert.PushAlert(e.Message, clsAlert.Type.Error);
                    Console.WriteLine(e.StackTrace);
                }
            } 
            else
            {
                try
                {
                    result = Helper.ExecuteQuery(SQL_BA);
                }
                catch(Exception e)
                {
                    Alert.PushAlert(e.Message, clsAlert.Type.Error);
                    Console.WriteLine(e.StackTrace);
                }

            }

            dgvResult.DataSource = result;
        }

        private void clsPopUpBA_Load(object sender, EventArgs e)
        {
            DrawDatatable();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DrawDatatable();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BaManagerId))
            {
                Alert.PushAlert("Please, click atleast one data from the table!", clsAlert.Type.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    BaBranchId = Helper.CastToString(dgvResult.CurrentRow.Cells["Branch_Id"].Value);
                    BaRepId = Helper.CastToString(dgvResult.CurrentRow.Cells["Rep_Id"].Value);
                    BaManagerId = Helper.CastToString(dgvResult.CurrentRow.Cells["Manager_Id"].Value);
                    BamanagerName = Helper.CastToString(dgvResult.CurrentRow.Cells["Manager_Name"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
            }
        }
    }
}
