using System;
using System.Windows.Forms;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.login;
using System.Linq;
using System.Text;

namespace MADITP2._0.UserInterface.SO
{
    public partial class SOReturnTypeUI : Form
    {
        private int AppState;
        clsAlert Alert;
        clsGlobal Helper;
        SOReturnTypeBL Entity;
        SOReturnTypeAL Accessor;
        public SOReturnTypeUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Entity = new SOReturnTypeBL();
            Accessor = new SOReturnTypeAL(Helper, Alert);

            InitializeComponent();
        }

        private void SOReturnTypeUI_Load(object sender, EventArgs e)
        {
            navView.PerformClick();
            LoadData();
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
            Helper.ResetAllFormControls(privilige);
            panelEditor.BringToFront();
            returnType.ReadOnly = false;
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Update);
            Helper.SetActive(sender);
            panelEditor.BringToFront();
            returnType.ReadOnly = true;

            var dt = tiraDataGrid1;
            returnType.Text = dt.CurrentRow.Cells["ot_return_type"].Value.ToString();
            desc.Text = dt.CurrentRow.Cells["ot_desc"].Value.ToString();
            invType.Text = dt.CurrentRow.Cells["ot_invoice_type"].Value.ToString();
            invReturnType.Text = dt.CurrentRow.Cells["ot_inv_return_txn_type"].Value.ToString();
            returnGroup.Text = dt.CurrentRow.Cells["ot_return_group"].Value.ToString();
            updateStock.Checked = dt.CurrentRow.Cells["ot_update_stock_allowed"].Value.ToString() == "Y" ? true : false;
            updateStockP.Checked = dt.CurrentRow.Cells["ot_update_stock_allowed_pengganti"].Value.ToString() == "Y" ? true : false;
            updateAch.Checked = dt.CurrentRow.Cells["ot_update_achievement"].Value.ToString() == "Y" ? true : false;
            updateAchP.Checked = dt.CurrentRow.Cells["ot_update_acheivement_allowed_pengganti"].Value.ToString() == "Y" ? true : false;
            receiptWarehouse.Checked = dt.CurrentRow.Cells["ot_check_receipt_warehouse"].Value.ToString() == "Y" ? true : false;
            createNewKP.Checked = dt.CurrentRow.Cells["ot_create_kp_baru"].Value.ToString() == "Y" ? true : false;
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            navView.PerformClick();
            Entity.Ot_return_type = tiraDataGrid1.CurrentRow.Cells["ot_return_type"].Value.ToString();
            if (clsDialog.ShowDialog($"Are you sure want delete Return Type {Entity.Ot_return_type} ?") == DialogResult.Yes)
            {
                Accessor.Delete(Entity);
                LoadData();
            }
        }

        private void navPrint_Click(object sender, EventArgs e)
        {

        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Choose location";
            sfd.DefaultExt = "csv";
            sfd.FileName = "Return Type";
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

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Entity.Ot_return_type = returnType.Text;
            Entity.Ot_desc = desc.Text;
            Entity.Ot_invoice_type = invType.Text;
            Entity.Ot_inv_return_txn_type = invReturnType.Text;
            Entity.Ot_return_group = returnGroup.Text;
            Entity.Ot_update_stock_allowed = updateStock.Checked ? "Y" : "N";
            Entity.Ot_update_stock_allowed_pengganti = updateStockP.Checked ? "Y" : "N";
            Entity.Ot_update_achievement = updateAch.Checked ? "Y" : "N";
            Entity.Ot_update_acheivement_allowed_pengganti = updateAchP.Checked ? "Y" : "N";
            Entity.Ot_check_receipt_warehouse = receiptWarehouse.Checked ? "Y" : "N";
            Entity.Ot_create_kp_baru = createNewKP.Checked ? "Y" : "N";

            if (AppState == (int)EnumState.Create)
            {
                Accessor.Create(Entity);
                LoadData();
                navView.PerformClick();
                return;
            }

            if (AppState == (int)EnumState.Update)
            {
                DateTime datetime = DateTime.Now;
                Entity.Ot_last_update = datetime.ToString("yyyy-MM-dd HH:mm:ss");
                Entity.Ot_update_by = clsLogin.USERID;

                Accessor.Update(Entity);
                LoadData();
                navView.PerformClick();
                return;
            }

            Alert.PushAlert("Invalid APPSTATE. Current state : " + AppState, clsAlert.Type.Error);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView.PerformClick();
            Helper.ResetAllFormControls(panelEditor);
            Helper.ResetAllFormControls(privilige);
        }

        private void LoadData()
        {
            tiraDataGrid1.AutoGenerateColumns = false;
            tiraDataGrid1.DataSource = Accessor.Read();
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

        private void CheckedChanged(object sender, EventArgs e)
        {
            updateStock.Text = updateStock.Checked ? "Yes" : "No";
            updateStockP.Text = updateStockP.Checked ? "Yes" : "No";
            updateAch.Text = updateAch.Checked ? "Yes" : "No";
            updateAchP.Text = updateAchP.Checked ? "Yes" : "No";
            receiptWarehouse.Text = receiptWarehouse.Checked ? "Yes" : "No";
            createNewKP.Text = createNewKP.Checked ? "Yes" : "No";
        }
    }
}
