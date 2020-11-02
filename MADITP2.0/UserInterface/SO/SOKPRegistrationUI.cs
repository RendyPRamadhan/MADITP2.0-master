using System;
using System.Windows.Forms;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using System.Drawing;
using MADITP2._0.login;
using System.Linq;
using System.Text;

namespace MADITP2._0.UserInterface.SO
{
    public partial class SOKPRegistrationUI : Form
    {
        private int AppState;
        clsAlert Alert;
        clsGlobal Helper;
        clsRepMaster RepMaster;
        SOKPRegistrationBL Entity;
        SOKPRegistrationAL Accessor;
        public SOKPRegistrationUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Entity = new SOKPRegistrationBL();
            Accessor = new SOKPRegistrationAL(Helper, Alert);
            RepMaster = new clsRepMaster();

            InitializeComponent();
        }

        private void SOKPRegistrationUI_Load(object sender, EventArgs e)
        {
            navView.PerformClick();
            dateOfOut.Checked = true;
            ComboBoxGroup();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            panelView.BringToFront();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            Helper.SetActive(sender);
            Helper.ResetAllFormControls(panelEditor);
            panelEditor.BringToFront();
            repId.ReadOnly = false;
            entity_f.SelectedValue = "52";
            division.SelectedValue = "TR";
            kpNo.Text = "TR";
            kpNo.ReadOnly = false;
            kpNo.BackColor = Color.White;
            kpDate.Enabled = true;
            kpDate.Value = DateTime.Now;
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            var dt = tiraDataGrid1;
            if (dt.Rows.Count == 0)
            {
                Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                return;
            }
            if (dt.CurrentRow.Cells["kf_kp_form_status"].Value.ToString() == "Ordered")
            {
                Alert.PushAlert("Order Status Not Allowed Edit", clsAlert.Type.Warning);
                return;
            }
            SetState(EnumState.Update);
            Helper.SetActive(sender);
            Helper.ResetAllFormControls(panelEditor);
            panelEditor.BringToFront();
            repId.ReadOnly = true;
            kpNo.ReadOnly = true;
            kpNo.BackColor = SystemColors.Control;
            kpDate.Enabled = false;

            repId.Text = dt.CurrentRow.Cells["rm_rep_id"].Value.ToString();
            repName.Text = dt.CurrentRow.Cells["rm_name"].Value.ToString();
            entity_f.SelectedValue = dt.CurrentRow.Cells["ec_entity_id"].Value.ToString();
            branch.SelectedValue = dt.CurrentRow.Cells["bc_branch_id"].Value.ToString();
            division.SelectedValue = dt.CurrentRow.Cells["dc_division_id"].Value.ToString();
            kpNo.Text = dt.CurrentRow.Cells["kf_kp_number"].Value.ToString();
            kpDate.Value = Convert.ToDateTime(dt.CurrentRow.Cells["kf_date_kp_out"].Value.ToString());
            remark.Text = dt.CurrentRow.Cells["kf_remark"].Value.ToString();
            string status = dt.CurrentRow.Cells["kf_kp_form_status"].Value.ToString();
            switch (status)
            {
                case "Cancel":
                    kpStatus.SelectedValue = "C";
                    break;
                case "Pending":
                    kpStatus.SelectedValue = "P";
                    break;
                case "Ordered":
                    kpStatus.SelectedValue = "O";
                    break;
                case "Entering":
                    kpStatus.SelectedValue = "E";
                    break;
            }
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            var dt = tiraDataGrid1;
            if (dt.Rows.Count == 0)
            {
                Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                return;
            }
            if (dt.CurrentRow.Cells["kf_kp_form_status"].Value.ToString() == "Ordered")
            {
                Alert.PushAlert("Order Status Not Allowed Delete", clsAlert.Type.Warning);
                return;
            }
            navView.PerformClick();
            Entity.Kf_kp_number = dt.CurrentRow.Cells["kf_kp_number"].Value.ToString();
            if (clsDialog.ShowDialog($"Are you sure want delete KP Number {Entity.Kf_kp_number} ?") == DialogResult.Yes)
            {
                Accessor.Delete(Entity);
                buttonSearch.PerformClick();
            }
        }

        private void navPrint_Click(object sender, EventArgs e)
        {

        }

        private void navExport_Click(object sender, EventArgs e)
        {
            var dt = tiraDataGrid1;

            if (dt.Rows.Count == 0)
            {
                Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Choose location";
            sfd.DefaultExt = "csv";
            sfd.FileName = "KP Registration";
            sfd.ShowDialog();
            if (sfd.FileName == "")
                return;

            var sb = new StringBuilder();
            var headers = dt.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dt.Rows)
                sb.AppendLine(string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => "\"" + cell.Value + "\"").ToArray()));

            try
            {
                System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message, clsAlert.Type.Error);
            }

            Alert.PushAlert("CSV File Saved", clsAlert.Type.Success);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filterRep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (filterRep.Text.Length.Equals(0))
                    Alert.PushAlert("REP ID Cannot Empty", clsAlert.Type.Warning);
                else
                    buttonSearch.PerformClick();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (filterRep.Text.Length.Equals(0))
                Alert.PushAlert("REP ID Cannot Empty", clsAlert.Type.Warning);
            else
            {
                Entity.Kf_entity_id = filterEntity.SelectedValue.ToString();
                Entity.Kf_branch_id = filterBranch.SelectedValue.ToString();
                Entity.Kf_division_id = filterDivision.SelectedValue.ToString();
                Entity.Kf_kp_form_status = filterStatus.SelectedValue.ToString();
                Entity.Kf_kp_number = filterKp.Text;
                Entity.Kf_rep_id = filterRep.Text;
                Entity.Kf_dateOutOf = dateOfOut.Checked ? "1" : "0";
                if (dateOfOut.Checked == false)
                {
                    Entity.Kf_dateFrom = dateTimePicker1.Value.ToString();
                    Entity.Kf_dateTo = dateTimePicker2.Value.ToString();
                }
                tiraDataGrid1.AutoGenerateColumns = false;
                tiraDataGrid1.DataSource = Accessor.SearchData(Entity);
                if (tiraDataGrid1.Rows.Count == 0)
                    Alert.PushAlert("Data Not Found, Check REP ID", clsAlert.Type.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            Entity.Kf_rep_id = repId.Text;
            Entity.Kf_kp_number = kpNo.Text;
            Entity.Kf_entity_id = entity_f.SelectedValue.ToString();
            Entity.Kf_branch_id = branch.SelectedValue.ToString();
            Entity.Kf_division_id = division.SelectedValue.ToString();
            Entity.Kf_date_kp_out = kpDate.Value.ToString();
            Entity.Kf_kp_form_status = kpStatus.SelectedValue.ToString();
            Entity.Kf_remark = remark.Text;
            Entity.Kf_entry_by = clsLogin.USERID;
            Entity.Kf_entry_date = datetime.ToString("yyyy-MM-dd HH:mm:ss");
            Entity.Kf_last_update = datetime.ToString("yyyy-MM-dd HH:mm:ss");
            if (AppState == (int)EnumState.Create)
            {
                Accessor.Create(Entity);
                navView.PerformClick();
                filterKp.Text = Entity.Kf_kp_number;
                filterRep.Text = Entity.Kf_rep_id;
                buttonSearch.PerformClick();
                return;
            }

            if (AppState == (int)EnumState.Update)
            {
                Accessor.Update(Entity);
                navView.PerformClick();
                buttonSearch.PerformClick();
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView.PerformClick();
            Helper.ResetAllFormControls(panelEditor);
        }

        private void dateOfOut_CheckedChanged(object sender, EventArgs e)
        {
            if (dateOfOut.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }

        private void SetState(EnumState enumState)
        {
            switch (enumState)
            {
                case EnumState.Create:
                    AppState = (int)EnumState.Create;
                    buttonSave.Text = "Save";
                    break;
                case EnumState.Update:
                    AppState = (int)EnumState.Update;
                    buttonSave.Text = "Update";
                    break;
                default:
                    AppState = 404;
                    this.Enabled = false;
                    break;
            }
        }

        private void ComboBoxGroup()
        {
            filterEntity.DataSource = Accessor.GetEntity(true);
            filterEntity.DisplayMember = "DisplayMember";
            filterEntity.ValueMember = "ValueMember";

            filterBranch.DataSource = Accessor.GetBranch(true);
            filterBranch.DisplayMember = "DisplayMember";
            filterBranch.ValueMember = "ValueMember";

            filterDivision.DataSource = Accessor.GetDivision(true);
            filterDivision.DisplayMember = "DisplayMember";
            filterDivision.ValueMember = "ValueMember";
            
            filterStatus.DataSource = Accessor.GetStatus(true);
            filterStatus.DisplayMember = "DisplayMember";
            filterStatus.ValueMember = "ValueMember";

            entity_f.DataSource = Accessor.GetEntity(false);
            entity_f.DisplayMember = "DisplayMember";
            entity_f.ValueMember = "ValueMember";

            branch.DataSource = Accessor.GetBranch(false);
            branch.DisplayMember = "DisplayMember";
            branch.ValueMember = "ValueMember";

            division.DataSource = Accessor.GetDivision(false);
            division.DisplayMember = "DisplayMember";
            division.ValueMember = "ValueMember";

            kpStatus.DataSource = Accessor.GetStatus(false);
            kpStatus.DisplayMember = "DisplayMember";
            kpStatus.ValueMember = "ValueMember";
        }

        private void buttonRep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(managerId.Text))
            {
                Alert.PushAlert("Select Manager ID Please", clsAlert.Type.Info);
                return;
            }

            RepMaster.type = "epc";
            RepMaster.manager = managerId.Text;
            if (RepMaster.ShowDialog() == DialogResult.OK)
            {
                repId.Text = RepMaster.id;
                repName.Text = RepMaster.name;
            }
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            RepMaster.type = "manager";
            if (RepMaster.ShowDialog() == DialogResult.OK)
            {
                managerId.Text = RepMaster.id;
                managerName.Text = RepMaster.name;
                repId.Text = string.Empty;
                repName.Text = string.Empty;
            }
        }
    }
}
