using System;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.businessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using System.Linq;
using System.Text;

namespace MADITP2._0.UserInterface.SO
{
    public partial class SOKPTypeUI : Form
    {
        clsAlert Alert;
        clsGlobal Helper;
        SOOrderTypeBL Entity;
        SOOrderTypeAL Accessor;

        public SOKPTypeUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Entity = new SOOrderTypeBL();
            Accessor = new SOOrderTypeAL(Helper, Alert);

            InitializeComponent();
        }

        private void SOKPTypeUI_Load(object sender, EventArgs e)
        {
            LoadData();
            ComboBoxDetail();
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
            navView.PerformClick();
            panelEdit.Show();
            var dt = tiraDataGrid1;
            orderType.Text = dt.CurrentRow.Cells["ot_order_type"].Value.ToString();
            orderTypeDesc.Text = dt.CurrentRow.Cells["ot_desc"].Value.ToString();
            defPriceList.SelectedValue = dt.CurrentRow.Cells["ot_default_price_list"].Value.ToString();
            transType.SelectedValue = dt.CurrentRow.Cells["ot_transaction_type"].Value.ToString();
            invType.SelectedValue = dt.CurrentRow.Cells["ot_invoice_type"].Value.ToString();
            invenTrans.SelectedValue = dt.CurrentRow.Cells["ot_inventory_txn_type"].Value.ToString();
            nonInvenTrans.SelectedValue = dt.CurrentRow.Cells["ot_non_inventory_txn_type"].Value.ToString();
            bonusType.SelectedValue = dt.CurrentRow.Cells["ot_bonus_txn_type"].Value.ToString();
            editPrice.Checked = dt.CurrentRow.Cells["ot_edit_price_allowed"].Value.ToString() == "Y" ? true : false;
            editOrder.Checked = dt.CurrentRow.Cells["ot_order_allowed"].Value.ToString() == "Y" ? true : false;
            editDate.Checked = dt.CurrentRow.Cells["ot_edit_date_allowed"].Value.ToString() == "Y" ? true : false;
            editAfterRelease.Checked = dt.CurrentRow.Cells["ot_edit_after_release_allowed"].Value.ToString() == "Y" ? true : false;
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            navView.PerformClick();
            Entity.orderType = tiraDataGrid1.CurrentRow.Cells["ot_order_type"].Value.ToString();
            if (clsDialog.ShowDialog($"Are you sure want delete Order Type {Entity.orderType} ?") == DialogResult.Yes)
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
            sfd.FileName = "KP Type";
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Entity.orderType = orderType.Text;
            Entity.orderTypeDesc = orderTypeDesc.Text;
            Entity.defaultPriceList = defPriceList.SelectedValue.ToString();
            Entity.transactionType = transType.SelectedValue.ToString();
            Entity.invoiceType = invType.SelectedValue.ToString();
            Entity.inventoryType = invenTrans.SelectedValue.ToString();
            Entity.nonInventoryType = nonInvenTrans.SelectedValue.ToString();
            Entity.bonusType = bonusType.SelectedValue.ToString();
            Entity.editPrice = editPrice.Checked ? "Y" : "N";
            Entity.editOrder = editOrder.Checked ? "Y" : "N";
            Entity.editDate = editDate.Checked ? "Y" : "N";
            Entity.editAfterRelease = editAfterRelease.Checked ? "Y" : "N";
            Accessor.Update(Entity);
            LoadData();
            panelEdit.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelEdit.Hide();
            navView.PerformClick();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            editPrice.Text = editPrice.Checked ? "Yes" : "No";
            editOrder.Text = editOrder.Checked ? "Yes" : "No";
            editDate.Text = editDate.Checked ? "Yes" : "No";
            editAfterRelease.Text = editAfterRelease.Checked ? "Yes" : "No";

            editPriceNew.Text = editPriceNew.Checked ? "Yes" : "No";
            editOrderNew.Text = editOrderNew.Checked ? "Yes" : "No";
            editDateNew.Text = editDateNew.Checked ? "Yes" : "No";
            editAfterReleaseNew.Text = editAfterReleaseNew.Checked ? "Yes" : "No";
        }

        private void LoadData()
        {
            tiraDataGrid1.AutoGenerateColumns = false;
            tiraDataGrid1.DataSource = Accessor.Read();
        }

        private void ComboBoxDetail()
        {
            defPriceList.DataSource = Accessor.GetPriceList();
            defPriceList.DisplayMember = "DisplayMember";
            defPriceList.ValueMember = "ValueMember";
        
            transType.DataSource = Accessor.GetTransaction();
            transType.DisplayMember = "DisplayMember";
            transType.ValueMember = "ValueMember";
        
            invenTrans.DataSource = Accessor.GetTransactionType();
            invenTrans.DisplayMember = "DisplayMember";
            invenTrans.ValueMember = "ValueMember";

            nonInvenTrans.DataSource = Accessor.GetTransactionType();
            nonInvenTrans.DisplayMember = "DisplayMember";
            nonInvenTrans.ValueMember = "ValueMember";

            bonusType.DataSource = Accessor.GetTransactionType();
            bonusType.DisplayMember = "DisplayMember";
            bonusType.ValueMember = "ValueMember";

            invType.DataSource = Accessor.GetInvoiceType();
            invType.DisplayMember = "DisplayMember";
            invType.ValueMember = "ValueMember";

            defPriceListNew.DataSource = Accessor.GetPriceList();
            defPriceListNew.DisplayMember = "DisplayMember";
            defPriceListNew.ValueMember = "ValueMember";

            transTypeNew.DataSource = Accessor.GetTransaction();
            transTypeNew.DisplayMember = "DisplayMember";
            transTypeNew.ValueMember = "ValueMember";

            invenTransNew.DataSource = Accessor.GetTransactionType();
            invenTransNew.DisplayMember = "DisplayMember";
            invenTransNew.ValueMember = "ValueMember";

            nonInvenTransNew.DataSource = Accessor.GetTransactionType();
            nonInvenTransNew.DisplayMember = "DisplayMember";
            nonInvenTransNew.ValueMember = "ValueMember";

            bonusTypeNew.DataSource = Accessor.GetTransactionType();
            bonusTypeNew.DisplayMember = "DisplayMember";
            bonusTypeNew.ValueMember = "ValueMember";

            invTypeNew.DataSource = Accessor.GetInvoiceType();
            invTypeNew.DisplayMember = "DisplayMember";
            invTypeNew.ValueMember = "ValueMember";
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            Entity.orderType = orderTypeNew.Text;
            Entity.orderTypeDesc = orderTypeDescNew.Text;
            Entity.defaultPriceList = defPriceListNew.SelectedValue.ToString();
            Entity.transactionType = transTypeNew.SelectedValue.ToString();
            Entity.invoiceType = invTypeNew.SelectedValue.ToString();
            Entity.inventoryType = invenTransNew.SelectedValue.ToString();
            Entity.nonInventoryType = nonInvenTransNew.SelectedValue.ToString();
            Entity.bonusType = bonusTypeNew.SelectedValue.ToString();
            Entity.editPrice = editPriceNew.Checked ? "Y" : "N";
            Entity.editOrder = editOrderNew.Checked ? "Y" : "N";
            Entity.editDate = editDateNew.Checked ? "Y" : "N";
            Entity.editAfterRelease = editAfterReleaseNew.Checked ? "Y" : "N";
            Accessor.Create(Entity);
            navView.PerformClick();
            LoadData();
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
