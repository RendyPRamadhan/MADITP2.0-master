using System;
using System.Windows.Forms;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace MADITP2._0.UserInterface.SO
{
    public partial class SODetailUI : Form
    {
        clsAlert Alert;
        clsGlobal Helper;
        SODetailBL Entity;
        SODetailAL Accessor;

        public SODetailUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Entity = new SODetailBL();
            Accessor = new SODetailAL(Helper, Alert);

            InitializeComponent();
        }

        private void SODetailUI_Load(object sender, EventArgs e)
        {
            navView.PerformClick();
            ComboBoxGroup();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {

        }

        private void navExport_Click(object sender, EventArgs e)
        {
            EntityValue();
            DataTable dataTable = Accessor.Report1(Entity);
            Accessor.ExportExcel(dataTable, "tes");
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(kp.Text) && String.IsNullOrEmpty(repId.Text))
                Alert.PushAlert("SO / KP or Rep ID Cannot Empty", clsAlert.Type.Warning);
            else
            {
                EntityValue();
                tiraDataGrid1.AutoGenerateColumns = false;
                tiraDataGrid1.DataSource = Accessor.SearchData(Entity);
                if (tiraDataGrid1.Rows.Count > 0)
                {
                    Entity.Skd_so_kp_num = tiraDataGrid1.CurrentRow.Cells["skh_so_kp_number"].Value.ToString();
                    tiraDataGrid2.AutoGenerateColumns = false;
                    tiraDataGrid2.DataSource = Accessor.ProductData(Entity);
                    if (tiraDataGrid2.Rows.Count == 0)
                        Alert.PushAlert("Data Product Not Found", clsAlert.Type.Error);
                }
                else
                {
                    tiraDataGrid2.DataSource = null;
                    tiraDataGrid2.Rows.Clear();
                    Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
                }
            }
        }

        private void repId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSearch.PerformClick();
        }

        private void kp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSearch.PerformClick();
        }

        private void tiraDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tiraDataGrid1.Rows.Count > 0)
            {
                Entity.Skd_so_kp_num = tiraDataGrid1.CurrentRow.Cells["skh_so_kp_number"].Value.ToString();
                tiraDataGrid2.AutoGenerateColumns = false;
                tiraDataGrid2.DataSource = Accessor.ProductData(Entity);
                if (tiraDataGrid2.Rows.Count == 0)
                    Alert.PushAlert("Data Product Not Found", clsAlert.Type.Error);
            }
        }

        private void ComboBoxGroup()
        {
            entity.DataSource = Accessor.GetEntity();
            entity.DisplayMember = "DisplayMember";
            entity.ValueMember = "ValueMember";

            branch.DataSource = Accessor.GetBranch();
            branch.DisplayMember = "DisplayMember";
            branch.ValueMember = "ValueMember";

            division.DataSource = Accessor.GetDivision();
            division.DisplayMember = "DisplayMember";
            division.ValueMember = "ValueMember";

            orderType.DataSource = Accessor.GetOrderType();
            orderType.DisplayMember = "DisplayMember";
            orderType.ValueMember = "ValueMember";

            wh.DataSource = Accessor.GetWarehouse();
            wh.DisplayMember = "DisplayMember";
            wh.ValueMember = "ValueMember";

            salesType.SelectedIndex = 0;
            status.SelectedIndex = 0;
            verification.SelectedIndex = 0;
            dp.SelectedIndex = 0;
            cod.SelectedIndex = 0;
            invoice.SelectedIndex = 0;
            delivery.SelectedIndex = 0;
            sap.SelectedIndex = 0;
            pendingItem1.SelectedIndex = 0;
            pendingItem2.SelectedIndex = 0;
            printType.SelectedIndex = 0;

            kpDate.Checked = true;
        }

        private void kpDate_CheckedChanged(object sender, EventArgs e)
        {
            if (kpDate.Checked)
            {
                dateFrom.Enabled = true;
                dateTo.Enabled = true;
            }
            else
            {
                dateFrom.Enabled = false;
                dateTo.Enabled = false;
            }
        }

        private void EntityValue()
        {
            if (String.IsNullOrEmpty(kp.Text))
                Entity.Skh_so_kp_number = null;
            else
                Entity.Skh_so_kp_number = kp.Text;

            if (String.IsNullOrEmpty(repId.Text))
                Entity.Skh_rep_id = null;
            else
                Entity.Skh_rep_id = repId.Text;

            if (String.IsNullOrEmpty(managerId.Text))
                Entity.Skh_mgr_rep_id = null;
            else
                Entity.Skh_mgr_rep_id = managerId.Text;

            Entity.Skh_entity_id = entity.SelectedValue.ToString();
            Entity.Skh_branch_id = branch.SelectedValue.ToString();
            Entity.Skh_division_id = division.SelectedValue.ToString();

            if (orderType.SelectedValue.ToString() != "0")
                Entity.Skh_order_type = orderType.SelectedValue.ToString();
            else
                Entity.Skh_order_type = null;

            if (wh.SelectedValue.ToString() != "0")
                Entity.Skh_deliver_from_warehouse_id = wh.SelectedValue.ToString();
            else
                Entity.Skh_deliver_from_warehouse_id = null;

            if (pendingItem1.SelectedText != "All")
                Entity.Ssh_pending = pendingItem1.SelectedText;
            else
                Entity.Ssh_pending = null;

            if (pendingItem2.SelectedText != "All")
                Entity.Ssh_pending2 = pendingItem2.SelectedText;
            else
                Entity.Ssh_pending2 = null;

            if (salesType.SelectedText != "All")
            {
                if (salesType.SelectedText == "Cash")
                    Entity.Skh_sales_type = "CH";
                else if (salesType.SelectedText == "Credit")
                    Entity.Skh_sales_type = "CR";
                else if (salesType.SelectedText == "COD")
                    Entity.Skh_sales_type = "OD";
                else if (salesType.SelectedText == "MIX")
                    Entity.Skh_sales_type = "MX";
                else if (salesType.SelectedText == "ATB")
                    Entity.Skh_sales_type = "AT";
            }
            else
                Entity.Skh_sales_type = null;

            if (status.SelectedText != "All")
            {
                if (status.SelectedText == "Suspend")
                    Entity.Skh_status_of_so_kp = "S";
                else if (status.SelectedText == "Released")
                    Entity.Skh_status_of_so_kp = "R";
                else if (status.SelectedText == "Cancel")
                    Entity.Skh_status_of_so_kp = "C";
            }
            else
                Entity.Skh_status_of_so_kp = null;

            if (verification.SelectedText != "All")
            {
                if (verification.SelectedText == "Un Assign")
                    Entity.Skh_status_of_verification = "U";
                else if (verification.SelectedText == "In Process")
                    Entity.Skh_status_of_verification = "I";
                else if (verification.SelectedText == "Suspend")
                    Entity.Skh_status_of_verification = "S";
                else if (verification.SelectedText == "Released")
                    Entity.Skh_status_of_verification = "R";
                else if (verification.SelectedText == "Cancel")
                    Entity.Skh_status_of_verification = "C";
            }
            else
                Entity.Skh_status_of_verification = null;

            if (dp.SelectedText != "All")
            {
                if (dp.SelectedText == "Suspend")
                    Entity.Skh_status_of_dp = "S";
                else if (dp.SelectedText == "Registered")
                    Entity.Skh_status_of_dp = "R";
                else if (dp.SelectedText == "Deposited")
                    Entity.Skh_status_of_dp = "D";
                else if (dp.SelectedText == "None")
                    Entity.Skh_status_of_dp = "N";
            }
            else
                Entity.Skh_status_of_dp = null;

            if (cod.SelectedText != "All")
            {
                if (cod.SelectedText == "Suspend")
                    Entity.Skh_status_of_cod = "S";
                else if (cod.SelectedText == "Registered")
                    Entity.Skh_status_of_cod = "R";
                else if (cod.SelectedText == "Deposited")
                    Entity.Skh_status_of_cod = "D";
                else if (cod.SelectedText == "None")
                    Entity.Skh_status_of_cod = "N";
            }
            else
                Entity.Skh_status_of_cod = null;

            if (invoice.SelectedText != "All")
            {
                if (invoice.SelectedText == "Suspend")
                    Entity.Skh_status_of_invoice = "S";
                else if (invoice.SelectedText == "Processed")
                    Entity.Skh_status_of_invoice = "X";
                else if (invoice.SelectedText == "Printed")
                    Entity.Skh_status_of_invoice = "P";
                else if (invoice.SelectedText == "Cancel")
                    Entity.Skh_status_of_invoice = "C";
                else if (invoice.SelectedText == "Return")
                    Entity.Skh_status_of_invoice = "R";
            }
            else
                Entity.Skh_status_of_invoice = null;

            if (delivery.SelectedText != "All")
            {
                if (delivery.SelectedText == "Suspend")
                    Entity.Skh_status_of_delivery = "S";
                else if (delivery.SelectedText == "Time / Scheduled")
                    Entity.Skh_status_of_delivery = "T";
                else if (delivery.SelectedText == "Partial Shipment")
                    Entity.Skh_status_of_delivery = "P";
                else if (delivery.SelectedText == "Delivered (Full)")
                    Entity.Skh_status_of_delivery = "D";
            }
            else
                Entity.Skh_status_of_delivery = null;

            if (kpDate.Checked)
            {
                Entity.DateFrom = dateFrom.Value.ToString("yyyy-MM-dd");
                Entity.DateTo = dateTo.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                Entity.DateFrom = null;
                Entity.DateTo = null;
            }
        }
    }
}
