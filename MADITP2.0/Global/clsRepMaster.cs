using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MADITP2._0.login;

namespace MADITP2._0.Global
{
    public partial class clsRepMaster : Form
    {
        Form background = new Form();
        DataView dv;
        DataTable dt;
        clsGlobal Helper;
        string query;
        public string id, name;
        public string type { get; set; }
        public string manager { get; set; }

        public clsRepMaster()
        {
            InitializeComponent();
            this.Text = string.Empty;
            Helper = new clsGlobal();
        }

        private void clsRepMaster_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            dt = GetRepMaster(type, manager);
            dg.AutoGenerateColumns = false;
            dg.DataSource = dt;
            dv = new DataView(dt);

            background.Opacity = .60d;
            background.BackColor = Color.Black;
            background.WindowState = FormWindowState.Maximized;
            background.FormBorderStyle = FormBorderStyle.None;
            background.ShowInTaskbar = false;
            background.TopMost = true;
            background.Show();
            this.Owner = background;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            id = dg.CurrentRow.Cells["repId"].Value.ToString();
            name = dg.CurrentRow.Cells["repName"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Hide();
            background.Hide();
        }

        private void find_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("rm_rep_id LIKE '%" + find.Text.Trim() + "%' OR rm_name LIKE '%" + find.Text.Trim() + "%'");
            dg.DataSource = dv;
        }

        private void dg_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OK.PerformClick();
        }

        public DataTable GetRepMaster(string type = null, string manager = null)
        {
            query = "SELECT rm_rep_id, rm_name, rm_branch_id, rm_division_id FROM VW_RC_REP_MASTER_FOR_NEW_SCHEMA " +
                "WHERE rm_rep_txn_flag = 'A' AND rm_active_flag = 'A' ";
            if (type == "manager")
                query = query + "AND rm_current_position IN ('EPD','GEPD','VPD','GVPD') ";
            if (type == "epc")
                query = query + "AND rm_current_position IN ('EPC','VPC') AND rm_manager_id = '" + manager + "'";
            //if (clsLogin.Status == "Y")
            //{
            //    if (clsLogin.Status = "A")
            //        query = query + "AND rm_manager_id IN (SELECT rm_manager_id FROM BW_EPHO_SLS_ANALISA WHERE (rm_user_ass) = '" + clsLogin.User + "') ";
            //    if (clsLogin.Status = "B")
            //        query = query + "AND rm_manager_id IN (SELECT rm_manager_id FROM BW_EPHO_SLS_ANALISA WHERE (rm_user_ss) = '" + clsLogin.User + "') ";
            //    if (clsLogin.Status = "C")
            //        query = query + "AND rm_manager_id IN (SELECT rm_manager_id FROM BW_EPHO_SLS_ANALISA WHERE (rm_user_admin) = '" + clsLogin.User + "') ";
            //}
            query = query + "ORDER BY rm_branch_id ASC, rm_name ASC";

            dt = Helper.ExecDT(query);

            return dt;
        }
    }
}
