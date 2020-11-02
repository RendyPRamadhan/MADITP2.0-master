using System;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.businessLogic.RC;
using MADITP2._0.ApplicationLogic.RC;
using System.Linq;
using System.Text;

namespace MADITP2._0.UserInterface.RC
{
    public partial class RCUpdateNpwpUI : Form
    {
        clsAlert Alert;
        clsGlobal Helper;
        RCRepMasterBL Entity;
        RCRepMasterAL Accessor;

        public RCUpdateNpwpUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Entity = new RCRepMasterBL();
            Accessor = new RCRepMasterAL(Helper, Alert);

            InitializeComponent();
        }

        private void RCUpdateNpwpUI_Load(object sender, EventArgs e)
        {
            panelEdit.Hide();
            navView.PerformClick();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            panelView.BringToFront();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            panelNew.BringToFront();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            var dt = tiraDataGrid1;

            if (dt.Rows.Count == 0)
                Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
            else
            {
                navView.PerformClick();
                if (dt.SelectedRows.Count > 0)
                {
                    panelEdit.Show();
                    Entity.repId = dt.CurrentRow.Cells["epcId"].Value.ToString();
                    textEpc.Text = dt.CurrentRow.Cells["epcId"].Value.ToString() + " - " + dt.CurrentRow.Cells["epcName"].Value.ToString();
                    textNpwpName.Text = dt.CurrentRow.Cells["npwpName"].Value.ToString();
                    textNpwpNumber.Text = dt.CurrentRow.Cells["npwpNumber"].Value.ToString();
                    if (dt.CurrentRow.Cells["status"].Value.ToString() ==  "Y")
                        checkBoxStatus.Checked = true;
                    else
                        checkBoxStatus.Checked = false;
                }
                else
                    Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
            }
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            Alert.PushAlert("Cannot Delete on this Menu", clsAlert.Type.Warning);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            var dt = tiraDataGrid1;

            if (dt.Rows.Count == 0)
                Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
            else
            {
                easyHTMLReports1.AddString("<h3>" + clsLogin.MENUNAME + " List</h3>");
                easyHTMLReports1.AddHorizontalRule();
                easyHTMLReports1.AddDatagridView(dt);
                easyHTMLReports1.ShowPrintPreviewDialog();
            }
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Choose location";
            sfd.DefaultExt = "csv";
            sfd.FileName = "Update NPWP";
            sfd.ShowDialog();
            if (sfd.FileName == "")
                return;

            var sb = new StringBuilder();
            var headers = tiraDataGrid1.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in tiraDataGrid1.Rows)
                sb.AppendLine(string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => "\"" + cell.Value + "\"").ToArray()));

            try
            {
                System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message, clsAlert.Type.Error);
            }
        }

        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatus.Checked)
                checkBoxStatus.Text = "Approved";
            else
                checkBoxStatus.Text = "Not Approve";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string status;
            if (checkBoxStatus.Checked)
                status = "Y";
            else
                status = "N";
            Entity.npwpFlag = status;
            Entity.npwpName = textNpwpName.Text;
            Entity.npwpNumber = textNpwpNumber.Text;
            Accessor.UpdateNpwp(Entity);
            buttonSearch.PerformClick();
            panelEdit.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelEdit.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text == textSearch.TiraPlaceHolder)
                Alert.PushAlert("REP ID Cannot Empty", clsAlert.Type.Warning);
            else if (comboBoxStatus.SelectedItem == null)
                Alert.PushAlert("Select Status NPWP", clsAlert.Type.Warning);
            else
            {
                Entity.repId = textSearch.Text;
                if (comboBoxStatus.Text != "All Status")
                {
                    if (comboBoxStatus.Text == "Approved")
                        Entity.npwpFlag = "Y";
                    else
                        Entity.npwpFlag = "N";
                }
                tiraDataGrid1.AutoGenerateColumns = false;
                tiraDataGrid1.DataSource = Accessor.SearchData(Entity);
                if (tiraDataGrid1.Rows.Count == 0)
                    Alert.PushAlert("Data Not Found, Check Rep ID", clsAlert.Type.Error);
            }
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
