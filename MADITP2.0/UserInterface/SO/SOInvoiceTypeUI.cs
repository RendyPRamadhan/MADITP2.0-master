using System;
using System.Windows.Forms;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.businessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using System.Linq;
using System.Text;

namespace MADITP2._0.UserInterface.SO
{
    public partial class SOInvoiceTypeUI : Form
    {
        private int AppState;
        clsAlert Alert;
        clsGlobal Helper;
        SOInvoiceTypeBL Entity;
        SOInvoiceTypeAL Accessor;

        public SOInvoiceTypeUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Entity = new SOInvoiceTypeBL();
            Accessor = new SOInvoiceTypeAL(Helper, Alert);

            InitializeComponent();
        }

        private void SOInvoiceType_Load(object sender, EventArgs e)
        {
            LoadData();
            navView.PerformClick();
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
            Helper.ResetAllFormControls(accountGroup);
            Helper.ResetAllFormControls(privilegeGroup);
            panelEditor.BringToFront();
            id.ReadOnly = false;
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Update);
            Helper.SetActive(sender);
            panelEditor.BringToFront();
            id.ReadOnly = true;

            Entity.sit_invoice_type = tiraDataGrid1.CurrentRow.Cells["sit_invoice_type"].Value.ToString();
            var dt = Accessor.Edit(Entity);
            id.Text = dt.Rows[0]["sit_invoice_type"].ToString().Trim();
            desc.Text = dt.Rows[0]["sit_invoice_type_description"].ToString().Trim();
            line.SelectedItem = dt.Rows[0]["sit_line_type"].ToString();
            userDefined1.Text = dt.Rows[0]["sit_user_define1"].ToString();
            userDefined2.Text = dt.Rows[0]["sit_user_define2"].ToString();
            iToGL.Checked = dt.Rows[0]["sit_interface_to_gl"].ToString() == "Y" ? true : false;
            manualEntry.Checked = dt.Rows[0]["sit_manual_entry_allowed"].ToString() == "Y" ? true : false;
            editHeader.Checked = dt.Rows[0]["sit_edit_header_allowed"].ToString() == "Y" ? true : false;
            editDetail.Checked = dt.Rows[0]["sit_edit_detail_allowed"].ToString() == "Y" ? true : false;
            ar_entity.Text = dt.Rows[0]["sit_ar_account_entity_id"].ToString();

            ar_branch.Text = dt.Rows[0]["sit_ar_account_branch_initial"].ToString().Trim();
            ar_div.Text = dt.Rows[0]["sit_ar_account_division_id"].ToString().Trim();
            ar_depart.Text = dt.Rows[0]["sit_ar_account_department_id"].ToString().Trim();
            ar_major1.Text = dt.Rows[0]["sit_ar_account_major1"].ToString();
            ar_major2.Text = dt.Rows[0]["sit_ar_account_major2"].ToString();
            ar_minor.Text = dt.Rows[0]["sit_ar_account_minor"].ToString();
            ar_analis.Text = dt.Rows[0]["sit_ar_account_analisys"].ToString();
            ar_filler.Text = dt.Rows[0]["sit_ar_account_filler"].ToString();

            gs_branch.Text = dt.Rows[0]["sit_gross_sal_ret_acc_branch_initial"].ToString().Trim();
            gs_div.Text = dt.Rows[0]["sit_gross_sal_ret_acc_division_id"].ToString().Trim();
            gs_depart.Text = dt.Rows[0]["sit_gross_sal_ret_acc_department_id"].ToString().Trim();
            gs_major1.Text = dt.Rows[0]["sit_gross_sal_ret_acc_major1"].ToString();
            gs_major2.Text = dt.Rows[0]["sit_gross_sal_ret_acc_major2"].ToString();
            gs_minor.Text = dt.Rows[0]["sit_gross_sal_ret_acc_minor"].ToString();
            gs_analis.Text = dt.Rows[0]["sit_gross_sal_ret_acc_analisys"].ToString();
            gs_filler.Text = dt.Rows[0]["sit_gross_sal_ret_acc_filler"].ToString();

            dl_branch.Text = dt.Rows[0]["sit_disc_line_acc_branch_initial"].ToString().Trim();
            dl_div.Text = dt.Rows[0]["sit_disc_line_acc_division_id"].ToString().Trim();
            dl_depart.Text = dt.Rows[0]["sit_disc_line_acc_department_id"].ToString().Trim();
            dl_major1.Text = dt.Rows[0]["sit_disc_line_acc_major1"].ToString();
            dl_major2.Text = dt.Rows[0]["sit_disc_line_acc_major2"].ToString();
            dl_minor.Text = dt.Rows[0]["sit_disc_line_acc_minor"].ToString();
            dl_analis.Text = dt.Rows[0]["sit_disc_line_acc_analisys"].ToString();
            dl_filler.Text = dt.Rows[0]["sit_disc_line_acc_filler"].ToString();

            bl_branch.Text = dt.Rows[0]["sit_bonus_line_acc_branch_initial"].ToString().Trim();
            bl_div.Text = dt.Rows[0]["sit_bonus_line_acc_division_id"].ToString().Trim();
            bl_depart.Text = dt.Rows[0]["sit_bonus_line_acc_department_id"].ToString().Trim();
            bl_major1.Text = dt.Rows[0]["sit_bonus_line_acc_major1"].ToString();
            bl_major2.Text = dt.Rows[0]["sit_bonus_line_acc_major2"].ToString();
            bl_minor.Text = dt.Rows[0]["sit_bonus_line_acc_minor"].ToString();
            bl_analis.Text = dt.Rows[0]["sit_bonus_line_acc_analisys"].ToString();
            bl_filler.Text = dt.Rows[0]["sit_bonus_line_acc_filler"].ToString();

            disc1_branch.Text = dt.Rows[0]["sit_disc1_acc_branch_initial"].ToString().Trim();
            disc1_div.Text = dt.Rows[0]["sit_disc1_acc_division_id"].ToString().Trim();
            disc1_depart.Text = dt.Rows[0]["sit_disc1_acc_department_id"].ToString().Trim();
            disc1_major1.Text = dt.Rows[0]["sit_disc1_acc_major1"].ToString();
            disc1_major2.Text = dt.Rows[0]["sit_disc1_acc_major2"].ToString();
            disc1_minor.Text = dt.Rows[0]["sit_disc1_acc_minor"].ToString();
            disc1_analis.Text = dt.Rows[0]["sit_disc1_acc_analisys"].ToString();
            disc1_filler.Text = dt.Rows[0]["sit_disc1_acc_filler"].ToString();

            disc2_branch.Text = dt.Rows[0]["sit_disc2_acc_branch_initial"].ToString().Trim();
            disc2_div.Text = dt.Rows[0]["sit_disc2_acc_division_id"].ToString().Trim();
            disc2_depart.Text = dt.Rows[0]["sit_disc2_acc_department_id"].ToString().Trim();
            disc2_major1.Text = dt.Rows[0]["sit_disc2_acc_major1"].ToString();
            disc2_major2.Text = dt.Rows[0]["sit_disc2_acc_major2"].ToString();
            disc2_minor.Text = dt.Rows[0]["sit_disc2_acc_minor"].ToString();
            disc2_analis.Text = dt.Rows[0]["sit_disc2_acc_analisys"].ToString();
            disc2_filler.Text = dt.Rows[0]["sit_disc2_acc_filler"].ToString();

            ppn_branch.Text = dt.Rows[0]["sit_ppn_tax_acc_branch_initial"].ToString().Trim();
            ppn_div.Text = dt.Rows[0]["sit_ppn_tax_acc_division_id"].ToString().Trim();
            ppn_depart.Text = dt.Rows[0]["sit_ppn_tax_acc_department_id"].ToString().Trim();
            ppn_major1.Text = dt.Rows[0]["sit_ppn_tax_acc_major1"].ToString();
            ppn_major2.Text = dt.Rows[0]["sit_ppn_tax_acc_major2"].ToString();
            ppn_minor.Text = dt.Rows[0]["sit_ppn_tax_acc_minor"].ToString();
            ppn_analis.Text = dt.Rows[0]["sit_ppn_tax_acc_analisys"].ToString();
            ppn_filler.Text = dt.Rows[0]["sit_ppn_tax_acc_filler"].ToString();

            cogs_branch.Text = dt.Rows[0]["sit_cogs_acc_branch_initial"].ToString().Trim();
            cogs_div.Text = dt.Rows[0]["sit_cogs_acc_division_id"].ToString().Trim();
            cogs_depart.Text = dt.Rows[0]["sit_cogs_acc_department_id"].ToString().Trim();
            cogs_major1.Text = dt.Rows[0]["sit_cogs_acc_major1"].ToString();
            cogs_major2.Text = dt.Rows[0]["sit_cogs_acc_major2"].ToString();
            cogs_minor.Text = dt.Rows[0]["sit_cogs_acc_minor"].ToString();
            cogs_analis.Text = dt.Rows[0]["sit_cogs_acc_analisys"].ToString();
            cogs_filler.Text = dt.Rows[0]["sit_cogs_acc_filler"].ToString();

            inven_branch.Text = dt.Rows[0]["sit_inv_uninv_acc_branch_initial"].ToString().Trim();
            inven_div.Text = dt.Rows[0]["sit_inv_uninv_acc_division_id"].ToString().Trim();
            inven_depart.Text = dt.Rows[0]["sit_inv_uninv_acc_department_id"].ToString().Trim();
            inven_major1.Text = dt.Rows[0]["sit_inv_uninv_acc_major1"].ToString();
            inven_major2.Text = dt.Rows[0]["sit_inv_uninv_acc_major2"].ToString();
            inven_minor.Text = dt.Rows[0]["sit_inv_uninv_acc_minor"].ToString();
            inven_analis.Text = dt.Rows[0]["sit_inv_uninv_acc_analisys"].ToString();
            inven_filler.Text = dt.Rows[0]["sit_inv_uninv_acc_filler"].ToString();

            cc_branch.Text = dt.Rows[0]["sit_credit_card_acc_branch_initial"].ToString().Trim();
            cc_div.Text = dt.Rows[0]["sit_credit_card_acc_division_id"].ToString().Trim();
            cc_depart.Text = dt.Rows[0]["sit_credit_card_acc_department_id"].ToString().Trim();
            cc_major1.Text = dt.Rows[0]["sit_credit_card_acc_major1"].ToString();
            cc_major2.Text = dt.Rows[0]["sit_credit_card_acc_major2"].ToString();
            cc_minor.Text = dt.Rows[0]["sit_credit_card_acc_minor"].ToString();
            cc_analis.Text = dt.Rows[0]["sit_credit_card_acc_analisys"].ToString();
            cc_filler.Text = dt.Rows[0]["sit_credit_card_acc_filler"].ToString();

            dc_branch.Text = dt.Rows[0]["sit_delivery_charge_acc_branch_initial"].ToString().Trim();
            dc_div.Text = dt.Rows[0]["sit_delivery_charge_acc_division_id"].ToString().Trim();
            dc_depart.Text = dt.Rows[0]["sit_delivery_charge_acc_department_id"].ToString().Trim();
            dc_major1.Text = dt.Rows[0]["sit_delivery_charge_acc_major1"].ToString();
            dc_major2.Text = dt.Rows[0]["sit_delivery_charge_acc_major2"].ToString();
            dc_minor.Text = dt.Rows[0]["sit_delivery_charge_acc_minor"].ToString();
            dc_analis.Text = dt.Rows[0]["sit_delivery_charge_acc_analisys"].ToString();
            dc_filler.Text = dt.Rows[0]["sit_delivery_charge_acc_filler"].ToString();

            mc_branch.Text = dt.Rows[0]["sit_materai_charge_acc_branch_initial"].ToString().Trim();
            mc_div.Text = dt.Rows[0]["sit_materai_charge_acc_division_id"].ToString().Trim();
            mc_depart.Text = dt.Rows[0]["sit_materai_charge_acc_department_id"].ToString().Trim();
            mc_major1.Text = dt.Rows[0]["sit_materai_charge_acc_major1"].ToString();
            mc_major2.Text = dt.Rows[0]["sit_materai_charge_acc_major2"].ToString();
            mc_minor.Text = dt.Rows[0]["sit_materai_charge_acc_minor"].ToString();
            mc_analis.Text = dt.Rows[0]["sit_materai_charge_acc_analisys"].ToString();
            mc_filler.Text = dt.Rows[0]["sit_materai_charge_acc_filler"].ToString();

            oc_branch.Text = dt.Rows[0]["sit_others_charge_acc_branch_initial"].ToString().Trim();
            oc_div.Text = dt.Rows[0]["sit_others_charge_acc_division_id"].ToString().Trim();
            oc_depart.Text = dt.Rows[0]["sit_others_charge_acc_department_id"].ToString().Trim();
            oc_major1.Text = dt.Rows[0]["sit_others_charge_acc_major1"].ToString();
            oc_major2.Text = dt.Rows[0]["sit_others_charge_acc_major2"].ToString();
            oc_minor.Text = dt.Rows[0]["sit_others_charge_acc_minor"].ToString();
            oc_analis.Text = dt.Rows[0]["sit_others_charge_acc_analisys"].ToString();
            oc_filler.Text = dt.Rows[0]["sit_others_charge_acc_filler"].ToString();

            ud_branch.Text = dt.Rows[0]["sit_udf_acc_branch_initial"].ToString().Trim();
            ud_div.Text = dt.Rows[0]["sit_udf_acc_division_id"].ToString().Trim();
            ud_depart.Text = dt.Rows[0]["sit_udf_acc_department_id"].ToString().Trim();
            ud_major1.Text = dt.Rows[0]["sit_udf_acc_major1"].ToString();
            ud_major2.Text = dt.Rows[0]["sit_udf_acc_major2"].ToString();
            ud_minor.Text = dt.Rows[0]["sit_udf_acc_minor"].ToString();
            ud_analis.Text = dt.Rows[0]["sit_udf_acc_analisys"].ToString();
            ud_filler.Text = dt.Rows[0]["sit_udf_acc_filler"].ToString();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            navView.PerformClick();
            Entity.sit_invoice_type = tiraDataGrid1.CurrentRow.Cells["sit_invoice_type"].Value.ToString().Trim();
            if (clsDialog.ShowDialog($"Are you sure want delete Invoice Type {Entity.sit_invoice_type} ?") == DialogResult.Yes)
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
            sfd.FileName = "Invoice Type";
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
            Entity.sit_invoice_type = id.Text;
            Entity.sit_invoice_type_description = desc.Text;
            Entity.sit_line_type = line.Text;
            Entity.sit_user_define1 = userDefined1.Text;
            Entity.sit_user_define2 = userDefined2.Text;
            Entity.sit_interface_to_gl = iToGL.Checked ? "Y" : "N";
            Entity.sit_manual_entry_allowed = manualEntry.Checked ? "Y" : "N";
            Entity.sit_edit_header_allowed = editHeader.Checked ? "Y" : "N";
            Entity.sit_edit_detail_allowed = editDetail.Checked ? "Y" : "N";
            Entity.sit_ar_account_entity_id = ar_entity.Text;

            Entity.sit_ar_account_branch_initial = ar_branch.Text;
            Entity.sit_ar_account_division_id = ar_div.Text;
            Entity.sit_ar_account_department_id = ar_depart.Text;
            Entity.sit_ar_account_major1 = ar_major1.Text;
            Entity.sit_ar_account_major2 = ar_major2.Text;
            Entity.sit_ar_account_minor = ar_minor.Text;
            Entity.sit_ar_account_analisys = ar_analis.Text;
            Entity.sit_ar_account_filler = ar_filler.Text;

            Entity.sit_gross_sal_ret_acc_branch_initial = gs_branch.Text;
            Entity.sit_gross_sal_ret_acc_division_id = gs_div.Text;
            Entity.sit_gross_sal_ret_acc_department_id = gs_depart.Text;
            Entity.sit_gross_sal_ret_acc_major1 = gs_major1.Text;
            Entity.sit_gross_sal_ret_acc_major2 = gs_major2.Text;
            Entity.sit_gross_sal_ret_acc_minor = gs_minor.Text;
            Entity.sit_gross_sal_ret_acc_analisys = gs_analis.Text;
            Entity.sit_gross_sal_ret_acc_filler = gs_filler.Text;

            Entity.sit_disc_line_acc_branch_initial = dl_branch.Text;
            Entity.sit_disc_line_acc_division_id = dl_div.Text;
            Entity.sit_disc_line_acc_department_id = dl_depart.Text;
            Entity.sit_disc_line_acc_major1 = dl_major1.Text;
            Entity.sit_disc_line_acc_major2 = dl_major2.Text;
            Entity.sit_disc_line_acc_minor = dl_minor.Text;
            Entity.sit_disc_line_acc_analisys = dl_analis.Text;
            Entity.sit_disc_line_acc_filler = dl_filler.Text;

            Entity.sit_bonus_line_acc_branch_initial = bl_branch.Text;
            Entity.sit_bonus_line_acc_division_id = bl_div.Text;
            Entity.sit_bonus_line_acc_department_id = bl_depart.Text;
            Entity.sit_bonus_line_acc_major1 = bl_major1.Text;
            Entity.sit_bonus_line_acc_major2 = bl_major2.Text;
            Entity.sit_bonus_line_acc_minor = bl_minor.Text;
            Entity.sit_bonus_line_acc_analisys = bl_analis.Text;
            Entity.sit_bonus_line_acc_filler = bl_analis.Text;

            Entity.sit_disc1_acc_branch_initial = disc1_branch.Text;
            Entity.sit_disc1_acc_division_id = disc1_div.Text;
            Entity.sit_disc1_acc_department_id = disc1_depart.Text;
            Entity.sit_disc1_acc_major1 = disc1_major1.Text;
            Entity.sit_disc1_acc_major2 = disc1_major2.Text;
            Entity.sit_disc1_acc_minor = disc1_minor.Text;
            Entity.sit_disc1_acc_analisys = disc1_analis.Text;
            Entity.sit_disc1_acc_filler = disc1_analis.Text;

            Entity.sit_disc2_acc_branch_initial = disc2_branch.Text;
            Entity.sit_disc2_acc_division_id = disc2_div.Text;
            Entity.sit_disc2_acc_department_id = disc2_depart.Text;
            Entity.sit_disc2_acc_major1 = disc2_major1.Text;
            Entity.sit_disc2_acc_major2 = disc2_major2.Text;
            Entity.sit_disc2_acc_minor = disc2_minor.Text;
            Entity.sit_disc2_acc_analisys = disc2_analis.Text;
            Entity.sit_disc2_acc_filler = disc2_analis.Text;

            Entity.sit_ppn_tax_acc_branch_initial = ppn_branch.Text;
            Entity.sit_ppn_tax_acc_division_id = ppn_div.Text;
            Entity.sit_ppn_tax_acc_department_id = ppn_depart.Text;
            Entity.sit_ppn_tax_acc_major1 = ppn_major1.Text;
            Entity.sit_ppn_tax_acc_major2 = ppn_major2.Text;
            Entity.sit_ppn_tax_acc_minor = ppn_minor.Text;
            Entity.sit_ppn_tax_acc_analisys = ppn_analis.Text;
            Entity.sit_ppn_tax_acc_filler = ppn_analis.Text;

            Entity.sit_cogs_acc_branch_initial = cogs_branch.Text;
            Entity.sit_cogs_acc_division_id = cogs_div.Text;
            Entity.sit_cogs_acc_department_id = cogs_depart.Text;
            Entity.sit_cogs_acc_major1 = cogs_major1.Text;
            Entity.sit_cogs_acc_major2 = cogs_major2.Text;
            Entity.sit_cogs_acc_minor = cogs_minor.Text;
            Entity.sit_cogs_acc_analisys = cogs_analis.Text;
            Entity.sit_cogs_acc_filler = cogs_analis.Text;

            Entity.sit_inv_uninv_acc_branch_initial = inven_branch.Text;
            Entity.sit_inv_uninv_acc_division_id = inven_div.Text;
            Entity.sit_inv_uninv_acc_department_id = inven_depart.Text;
            Entity.sit_inv_uninv_acc_major1 = inven_major1.Text;
            Entity.sit_inv_uninv_acc_major2 = inven_major2.Text;
            Entity.sit_inv_uninv_acc_minor = inven_minor.Text;
            Entity.sit_inv_uninv_acc_analisys = inven_analis.Text;
            Entity.sit_inv_uninv_acc_filler = inven_analis.Text;

            Entity.sit_credit_card_acc_branch_initial = cc_branch.Text;
            Entity.sit_credit_card_acc_division_id = cc_div.Text;
            Entity.sit_credit_card_acc_department_id = cc_depart.Text;
            Entity.sit_credit_card_acc_major1 = cc_major1.Text;
            Entity.sit_credit_card_acc_major2 = cc_major2.Text;
            Entity.sit_credit_card_acc_minor = cc_minor.Text;
            Entity.sit_credit_card_acc_analisys = cc_analis.Text;
            Entity.sit_credit_card_acc_filler = cc_analis.Text;

            Entity.sit_delivery_charge_acc_branch_initial = dc_branch.Text;
            Entity.sit_delivery_charge_acc_division_id = dc_div.Text;
            Entity.sit_delivery_charge_acc_department_id = dc_depart.Text;
            Entity.sit_delivery_charge_acc_major1 = dc_major1.Text;
            Entity.sit_delivery_charge_acc_major2 = dc_major2.Text;
            Entity.sit_delivery_charge_acc_minor = dc_minor.Text;
            Entity.sit_delivery_charge_acc_analisys = dc_analis.Text;
            Entity.sit_delivery_charge_acc_filler = dc_analis.Text;

            Entity.sit_materai_charge_acc_branch_initial = mc_branch.Text;
            Entity.sit_materai_charge_acc_division_id = mc_div.Text;
            Entity.sit_materai_charge_acc_department_id = mc_depart.Text;
            Entity.sit_materai_charge_acc_major1 = mc_major1.Text;
            Entity.sit_materai_charge_acc_major2 = mc_major2.Text;
            Entity.sit_materai_charge_acc_minor = mc_minor.Text;
            Entity.sit_materai_charge_acc_analisys = mc_analis.Text;
            Entity.sit_materai_charge_acc_filler = mc_analis.Text;

            Entity.sit_others_charge_acc_branch_initial = oc_branch.Text;
            Entity.sit_others_charge_acc_division_id = oc_div.Text;
            Entity.sit_others_charge_acc_department_id = oc_depart.Text;
            Entity.sit_others_charge_acc_major1 = oc_major1.Text;
            Entity.sit_others_charge_acc_major2 = oc_major2.Text;
            Entity.sit_others_charge_acc_minor = oc_minor.Text;
            Entity.sit_others_charge_acc_analisys = oc_analis.Text;
            Entity.sit_others_charge_acc_filler = oc_analis.Text;

            Entity.sit_udf_acc_branch_initial = ud_branch.Text;
            Entity.sit_udf_acc_division_id = ud_div.Text;
            Entity.sit_udf_acc_department_id = ud_depart.Text;
            Entity.sit_udf_acc_major1 = ud_major1.Text;
            Entity.sit_udf_acc_major2 = ud_major2.Text;
            Entity.sit_udf_acc_minor = ud_minor.Text;
            Entity.sit_udf_acc_analisys = ud_analis.Text;
            Entity.sit_udf_acc_filler = ud_analis.Text;

            if (AppState == (int)EnumState.Create)
            {
                Accessor.Create(Entity);
                LoadData();
                navView.PerformClick();
                return;
            }

            if (AppState == (int)EnumState.Update)
            {
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
            Helper.ResetAllFormControls(accountGroup);
            Helper.ResetAllFormControls(privilegeGroup);
        }

        private void LoadData()
        {
            tiraDataGrid1.AutoGenerateColumns = false;
            tiraDataGrid1.DataSource = Accessor.Read();
        }

        private void ar_entity_TextChanged(object sender, EventArgs e)
        {
            string entity = ar_entity.Text;
            gs_entity.Text = entity;
            dl_entity.Text = entity;
            bl_entity.Text = entity;
            disc1_entity.Text = entity;
            disc2_entity.Text = entity;
            ud_entity.Text = entity;
            ppn_entity.Text = entity;
            cogs_entity.Text = entity;
            inven_entity.Text = entity;
            cc_entity.Text = entity;
            dc_entity.Text = entity;
            mc_entity.Text = entity;
            oc_entity.Text = entity;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            iToGL.Text = iToGL.Checked ? "Yes" : "No";
            manualEntry.Text = manualEntry.Checked ? "Yes" : "No";
            editHeader.Text = editHeader.Checked ? "Yes" : "No";
            editDetail.Text = editDetail.Checked ? "Yes" : "No";
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
