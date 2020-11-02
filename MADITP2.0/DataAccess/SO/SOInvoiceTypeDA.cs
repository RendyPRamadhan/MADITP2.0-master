using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.businessLogic.SO;

namespace MADITP2._0.DataAccess.SO
{
    class SOInvoiceTypeDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        DataTable dt;
        string query;

        public SOInvoiceTypeDA(clsGlobal helper, clsAlert alert)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                Alert = alert;
                dt = new DataTable();
            }
        }

        public DataTable Read()
        {
            try
            {
                query = "SELECT sit_invoice_type, sit_invoice_type_description, sit_line_type, sit_interface_to_gl, sit_edit_header_allowed, sit_edit_detail_allowed, sit_manual_entry_allowed, sit_user_define1, sit_user_define2, " +
                    "CONCAT(sit_ar_account_entity_id, sit_ar_account_branch_initial, sit_ar_account_division_id, sit_ar_account_department_id, sit_ar_account_major1, sit_ar_account_major2, sit_ar_account_minor, sit_ar_account_analisys, sit_ar_account_filler) AS ar_account, " +
                    "CONCAT(sit_gross_sal_ret_acc_entity_id, sit_gross_sal_ret_acc_branch_initial, sit_gross_sal_ret_acc_division_id, sit_gross_sal_ret_acc_department_id, sit_gross_sal_ret_acc_major1, sit_gross_sal_ret_acc_major2, sit_gross_sal_ret_acc_minor, sit_gross_sal_ret_acc_analisys, sit_gross_sal_ret_acc_filler) AS gs_account, " +
                    "CONCAT(sit_disc_line_acc_entity_id, sit_disc_line_acc_branch_initial, sit_disc_line_acc_division_id, sit_disc_line_acc_department_id, sit_disc_line_acc_major1, sit_disc_line_acc_major2, sit_disc_line_acc_minor, sit_disc_line_acc_analisys, sit_disc_line_acc_filler) AS disc_account, " +
                    "CONCAT(sit_bonus_line_acc_entity_id, sit_bonus_line_acc_branch_initial, sit_bonus_line_acc_division_id, sit_bonus_line_acc_department_id, sit_bonus_line_acc_major1, sit_bonus_line_acc_major2, sit_bonus_line_acc_minor, sit_bonus_line_acc_analisys, sit_bonus_line_acc_filler) AS bns_account, " +
                    "CONCAT(sit_disc1_acc_entity_id, sit_disc1_acc_branch_initial, sit_disc1_acc_division_id, sit_disc1_acc_department_id, sit_disc1_acc_major1, sit_disc1_acc_major2, sit_disc1_acc_minor, sit_disc1_acc_analisys, sit_disc1_acc_filler) AS disc1_account, " +
                    "CONCAT(sit_disc2_acc_entity_id, sit_disc2_acc_branch_initial, sit_disc2_acc_division_id, sit_disc2_acc_department_id, sit_disc2_acc_major1, sit_disc2_acc_major2, sit_disc2_acc_minor, sit_disc2_acc_analisys, sit_disc2_acc_filler) AS disc2_account, " +
                    "CONCAT(sit_ppn_tax_acc_entity_id, sit_ppn_tax_acc_branch_initial, sit_ppn_tax_acc_division_id, sit_ppn_tax_acc_department_id, sit_ppn_tax_acc_major1, sit_ppn_tax_acc_major2, sit_ppn_tax_acc_minor, sit_ppn_tax_acc_analisys, sit_ppn_tax_acc_filler) AS ppn_account, " +
                    "CONCAT(sit_cogs_acc_entity_id, sit_cogs_acc_branch_initial, sit_cogs_acc_division_id, sit_cogs_acc_department_id, sit_cogs_acc_major1, sit_cogs_acc_major2, sit_cogs_acc_minor, sit_cogs_acc_analisys, sit_cogs_acc_filler) AS cogs_account, " +
                    "CONCAT(sit_inv_uninv_acc_entity_id, sit_inv_uninv_acc_branch_initial, sit_inv_uninv_acc_division_id, sit_inv_uninv_acc_department_id, sit_inv_uninv_acc_major1, sit_inv_uninv_acc_major2, sit_inv_uninv_acc_minor, sit_inv_uninv_acc_analisys, sit_inv_uninv_acc_filler) AS inven_account, " +
                    "CONCAT(sit_credit_card_acc_entity_id, sit_credit_card_acc_branch_initial, sit_credit_card_acc_division_id, sit_credit_card_acc_department_id, sit_credit_card_acc_major1, sit_credit_card_acc_major2, sit_credit_card_acc_minor, sit_credit_card_acc_analisys, sit_credit_card_acc_filler) AS cc_account, " +
                    "CONCAT(sit_delivery_charge_acc_entity_id, sit_delivery_charge_acc_branch_initial, sit_delivery_charge_acc_division_id, sit_delivery_charge_acc_department_id, sit_delivery_charge_acc_major1, sit_delivery_charge_acc_major2, sit_delivery_charge_acc_minor, sit_delivery_charge_acc_analisys, sit_delivery_charge_acc_filler) AS dc_account, " +
                    "CONCAT(sit_materai_charge_acc_entity_id, sit_materai_charge_acc_branch_initial, sit_materai_charge_acc_division_id, sit_materai_charge_acc_department_id, sit_materai_charge_acc_major1, sit_materai_charge_acc_major2, sit_materai_charge_acc_minor, sit_materai_charge_acc_analisys, sit_materai_charge_acc_filler) AS mc_account, " +
                    "CONCAT(sit_others_charge_acc_entity_id, sit_others_charge_acc_branch_initial, sit_others_charge_acc_division_id, sit_others_charge_acc_department_id, sit_others_charge_acc_major1, sit_others_charge_acc_major2, sit_others_charge_acc_minor, sit_others_charge_acc_analisys, sit_others_charge_acc_filler) AS oc_account, " +
                    "CONCAT(sit_udf_acc_entity_id, sit_udf_acc_branch_initial, sit_udf_acc_division_id, sit_udf_acc_department_id, sit_udf_acc_major1, sit_udf_acc_major2, sit_udf_acc_minor, sit_udf_acc_analisys, sit_udf_acc_filler) AS ud_account " +
                    "FROM SO_INVOICE_TYPE";
                dt = Helper.ExecDT(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable Edit(SOInvoiceTypeBL Entity)
        {
            try
            {
                query = $"SELECT * FROM SO_INVOICE_TYPE WHERE sit_invoice_type = '{Entity.sit_invoice_type}'";
                dt = Helper.ExecDT(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Alert.PushAlert("Please Select Data", clsAlert.Type.Error);
            }

            return dt;
        }

        private List<SqlParameterHelper> GetParam(SOInvoiceTypeBL Entity)
        {
            var param = new List<SqlParameterHelper>()
            {
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_invoice_type ", VALUE = Entity.sit_invoice_type },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_invoice_type_description ", VALUE = Entity.sit_invoice_type_description },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_line_type ", VALUE = Entity.sit_line_type },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_user_define1 ", VALUE = Entity.sit_user_define1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_user_define2 ", VALUE = Entity.sit_user_define2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_interface_to_gl ", VALUE = Entity.sit_interface_to_gl },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_manual_entry_allowed ", VALUE = Entity.sit_manual_entry_allowed },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_edit_header_allowed ", VALUE = Entity.sit_edit_header_allowed },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_edit_detail_allowed ", VALUE = Entity.sit_edit_detail_allowed },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_entity_id ", VALUE = Entity.sit_ar_account_entity_id },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_branch_initial ", VALUE = Entity.sit_ar_account_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_division_id ", VALUE = Entity.sit_ar_account_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_department_id ", VALUE = Entity.sit_ar_account_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_major1 ", VALUE = Entity.sit_ar_account_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_major2 ", VALUE = Entity.sit_ar_account_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_minor ", VALUE = Entity.sit_ar_account_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_analisys ", VALUE = Entity.sit_ar_account_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ar_account_filler ", VALUE = Entity.sit_ar_account_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_gross_sal_ret_acc_branch_initial ", VALUE = Entity.sit_gross_sal_ret_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_gross_sal_ret_acc_division_id ", VALUE = Entity.sit_gross_sal_ret_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_gross_sal_ret_acc_department_id ", VALUE = Entity.sit_gross_sal_ret_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_gross_sal_ret_acc_major1 ", VALUE = Entity.sit_gross_sal_ret_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_gross_sal_ret_acc_major2 ", VALUE = Entity.sit_gross_sal_ret_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_gross_sal_ret_acc_minor ", VALUE = Entity.sit_gross_sal_ret_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_gross_sal_ret_acc_analisys ", VALUE = Entity.sit_gross_sal_ret_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_gross_sal_ret_acc_filler ", VALUE = Entity.sit_gross_sal_ret_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc_line_acc_branch_initial ", VALUE = Entity.sit_disc_line_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc_line_acc_division_id ", VALUE = Entity.sit_disc_line_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc_line_acc_department_id ", VALUE = Entity.sit_disc_line_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc_line_acc_major1 ", VALUE = Entity. sit_disc_line_acc_major1},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc_line_acc_major2 ", VALUE = Entity. sit_disc_line_acc_major2},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc_line_acc_minor ", VALUE = Entity. sit_disc_line_acc_minor},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc_line_acc_analisys ", VALUE = Entity.sit_disc_line_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc_line_acc_filler ", VALUE = Entity.sit_disc_line_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_bonus_line_acc_branch_initial ", VALUE = Entity.sit_bonus_line_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_bonus_line_acc_division_id ", VALUE = Entity.sit_bonus_line_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_bonus_line_acc_department_id ", VALUE = Entity.sit_bonus_line_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_bonus_line_acc_major1 ", VALUE = Entity.sit_bonus_line_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_bonus_line_acc_major2 ", VALUE = Entity.sit_bonus_line_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_bonus_line_acc_minor ", VALUE = Entity.sit_bonus_line_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_bonus_line_acc_analisys ", VALUE = Entity.sit_bonus_line_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_bonus_line_acc_filler ", VALUE = Entity.sit_bonus_line_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc1_acc_branch_initial ", VALUE = Entity.sit_disc1_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc1_acc_division_id ", VALUE = Entity.sit_disc1_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc1_acc_department_id ", VALUE = Entity. sit_disc1_acc_department_id},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc1_acc_major1 ", VALUE = Entity. sit_disc1_acc_major1},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc1_acc_major2 ", VALUE = Entity. sit_disc1_acc_major2},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc1_acc_minor ", VALUE = Entity. sit_disc1_acc_minor},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc1_acc_analisys ", VALUE = Entity.sit_disc1_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc1_acc_filler ", VALUE = Entity.sit_disc1_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc2_acc_branch_initial ", VALUE = Entity.sit_disc2_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc2_acc_division_id ", VALUE = Entity.sit_disc2_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc2_acc_department_id ", VALUE = Entity.sit_disc2_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc2_acc_major1 ", VALUE = Entity.sit_disc2_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc2_acc_major2 ", VALUE = Entity.sit_disc2_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc2_acc_minor ", VALUE = Entity.sit_disc2_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc2_acc_analisys ", VALUE = Entity. sit_disc2_acc_analisys},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_disc2_acc_filler ", VALUE = Entity.sit_disc2_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ppn_tax_acc_branch_initial ", VALUE = Entity.sit_ppn_tax_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ppn_tax_acc_division_id ", VALUE = Entity.sit_ppn_tax_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ppn_tax_acc_department_id ", VALUE = Entity. sit_ppn_tax_acc_department_id},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ppn_tax_acc_major1 ", VALUE = Entity.sit_ppn_tax_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ppn_tax_acc_major2 ", VALUE = Entity.sit_ppn_tax_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ppn_tax_acc_minor ", VALUE = Entity.sit_ppn_tax_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ppn_tax_acc_analisys ", VALUE = Entity. sit_ppn_tax_acc_analisys},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_ppn_tax_acc_filler ", VALUE = Entity.sit_ppn_tax_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_cogs_acc_branch_initial ", VALUE = Entity.sit_cogs_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_cogs_acc_division_id ", VALUE = Entity.sit_cogs_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_cogs_acc_department_id ", VALUE = Entity. sit_cogs_acc_department_id},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_cogs_acc_major1 ", VALUE = Entity.sit_cogs_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_cogs_acc_major2 ", VALUE = Entity. sit_cogs_acc_major2},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_cogs_acc_minor ", VALUE = Entity.sit_cogs_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_cogs_acc_analisys ", VALUE = Entity.sit_cogs_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_cogs_acc_filler ", VALUE = Entity.sit_cogs_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_inv_uninv_acc_branch_initial ", VALUE = Entity.sit_inv_uninv_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_inv_uninv_acc_division_id ", VALUE = Entity.sit_inv_uninv_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_inv_uninv_acc_department_id ", VALUE = Entity.sit_inv_uninv_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_inv_uninv_acc_major1 ", VALUE = Entity. sit_inv_uninv_acc_major1},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_inv_uninv_acc_major2 ", VALUE = Entity.sit_inv_uninv_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_inv_uninv_acc_minor ", VALUE = Entity.sit_inv_uninv_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_inv_uninv_acc_analisys ", VALUE = Entity.sit_inv_uninv_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_inv_uninv_acc_filler ", VALUE = Entity.sit_inv_uninv_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_credit_card_acc_branch_initial ", VALUE = Entity. sit_credit_card_acc_branch_initial},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_credit_card_acc_division_id ", VALUE = Entity.sit_credit_card_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_credit_card_acc_department_id ", VALUE = Entity.sit_credit_card_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_credit_card_acc_major1 ", VALUE = Entity.sit_credit_card_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_credit_card_acc_major2 ", VALUE = Entity.sit_credit_card_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_credit_card_acc_minor ", VALUE = Entity.sit_credit_card_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_credit_card_acc_analisys ", VALUE = Entity.sit_credit_card_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_credit_card_acc_filler ", VALUE = Entity.sit_credit_card_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_delivery_charge_acc_branch_initial ", VALUE = Entity.sit_delivery_charge_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_delivery_charge_acc_division_id ", VALUE = Entity.sit_delivery_charge_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_delivery_charge_acc_department_id ", VALUE = Entity.sit_delivery_charge_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_delivery_charge_acc_major1 ", VALUE = Entity.sit_delivery_charge_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_delivery_charge_acc_major2 ", VALUE = Entity.sit_delivery_charge_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_delivery_charge_acc_minor ", VALUE = Entity.sit_delivery_charge_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_delivery_charge_acc_analisys ", VALUE = Entity.sit_delivery_charge_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_delivery_charge_acc_filler ", VALUE = Entity.sit_delivery_charge_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_materai_charge_acc_branch_initial ", VALUE = Entity.sit_materai_charge_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_materai_charge_acc_division_id ", VALUE = Entity.sit_materai_charge_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_materai_charge_acc_department_id ", VALUE = Entity.sit_materai_charge_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_materai_charge_acc_major1 ", VALUE = Entity.sit_materai_charge_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_materai_charge_acc_major2 ", VALUE = Entity.sit_materai_charge_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_materai_charge_acc_minor ", VALUE = Entity.sit_materai_charge_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_materai_charge_acc_analisys ", VALUE = Entity.sit_materai_charge_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_materai_charge_acc_filler ", VALUE = Entity.sit_materai_charge_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_others_charge_acc_branch_initial ", VALUE = Entity.sit_others_charge_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_others_charge_acc_division_id ", VALUE = Entity.sit_others_charge_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_others_charge_acc_department_id ", VALUE = Entity.sit_others_charge_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_others_charge_acc_major1 ", VALUE = Entity.sit_others_charge_acc_major1 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_others_charge_acc_major2 ", VALUE = Entity.sit_others_charge_acc_major2 },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_others_charge_acc_minor ", VALUE = Entity.sit_others_charge_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_others_charge_acc_analisys ", VALUE = Entity.sit_others_charge_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_others_charge_acc_filler ", VALUE = Entity.sit_others_charge_acc_filler },

                new SqlParameterHelper() { PARAMETR_NAME = "@sit_udf_acc_branch_initial ", VALUE = Entity.sit_udf_acc_branch_initial },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_udf_acc_division_id ", VALUE = Entity.sit_udf_acc_division_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_udf_acc_department_id ", VALUE = Entity.sit_udf_acc_department_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_udf_acc_major1 ", VALUE = Entity.sit_udf_acc_major1},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_udf_acc_major2 ", VALUE = Entity.sit_udf_acc_major2},
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_udf_acc_minor ", VALUE = Entity.sit_udf_acc_minor },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_udf_acc_analisys ", VALUE = Entity.sit_udf_acc_analisys },
                new SqlParameterHelper() { PARAMETR_NAME = "@sit_udf_acc_filler ", VALUE = Entity.sit_udf_acc_filler }
            };

            return param;
        }

        public void Create(SOInvoiceTypeBL Entity)
        {
            try
            {
                query = "INSERT INTO SO_INVOICE_TYPE " +
                    "(sit_invoice_type, sit_invoice_type_description, sit_line_type, sit_interface_to_gl, sit_edit_header_allowed, sit_edit_detail_allowed, " +
                    "sit_manual_entry_allowed, sit_user_define1, sit_user_define2, sit_ar_account_entity_id, sit_ar_account_branch_initial, sit_ar_account_division_id, " +
                    "sit_ar_account_department_id, sit_ar_account_major1, sit_ar_account_major2, sit_ar_account_minor, sit_ar_account_analisys, sit_ar_account_filler, " +
                    "sit_gross_sal_ret_acc_entity_id, sit_gross_sal_ret_acc_branch_initial, sit_gross_sal_ret_acc_division_id, sit_gross_sal_ret_acc_department_id, " +
                    "sit_gross_sal_ret_acc_major1, sit_gross_sal_ret_acc_major2, sit_gross_sal_ret_acc_minor, sit_gross_sal_ret_acc_analisys, sit_gross_sal_ret_acc_filler, " +
                    "sit_disc_line_acc_entity_id, sit_disc_line_acc_branch_initial, sit_disc_line_acc_division_id, sit_disc_line_acc_department_id, sit_disc_line_acc_major1, " +
                    "sit_disc_line_acc_major2, sit_disc_line_acc_minor, sit_disc_line_acc_analisys, sit_disc_line_acc_filler, sit_bonus_line_acc_entity_id, " +
                    "sit_bonus_line_acc_branch_initial, sit_bonus_line_acc_division_id, sit_bonus_line_acc_department_id, sit_bonus_line_acc_major1, sit_bonus_line_acc_major2, " +
                    "sit_bonus_line_acc_minor, sit_bonus_line_acc_analisys, sit_bonus_line_acc_filler, sit_disc1_acc_entity_id, sit_disc1_acc_branch_initial, " +
                    "sit_disc1_acc_division_id, sit_disc1_acc_department_id, sit_disc1_acc_major1, sit_disc1_acc_major2, sit_disc1_acc_minor, sit_disc1_acc_analisys, " +
                    "sit_disc1_acc_filler, sit_disc2_acc_entity_id, sit_disc2_acc_branch_initial, sit_disc2_acc_division_id, sit_disc2_acc_department_id, sit_disc2_acc_major1, " +
                    "sit_disc2_acc_major2, sit_disc2_acc_minor, sit_disc2_acc_analisys, sit_disc2_acc_filler, sit_ppn_tax_acc_entity_id, sit_ppn_tax_acc_branch_initial, " +
                    "sit_ppn_tax_acc_division_id, sit_ppn_tax_acc_department_id, sit_ppn_tax_acc_major1, sit_ppn_tax_acc_major2, sit_ppn_tax_acc_minor, sit_ppn_tax_acc_analisys, " +
                    "sit_ppn_tax_acc_filler, sit_cogs_acc_entity_id, sit_cogs_acc_branch_initial, sit_cogs_acc_division_id, sit_cogs_acc_department_id, sit_cogs_acc_major1, " +
                    "sit_cogs_acc_major2, sit_cogs_acc_minor, sit_cogs_acc_analisys, sit_cogs_acc_filler, sit_inv_uninv_acc_entity_id, sit_inv_uninv_acc_branch_initial, " +
                    "sit_inv_uninv_acc_division_id, sit_inv_uninv_acc_department_id, sit_inv_uninv_acc_major1, sit_inv_uninv_acc_major2, sit_inv_uninv_acc_minor, " +
                    "sit_inv_uninv_acc_analisys, sit_inv_uninv_acc_filler, sit_credit_card_acc_entity_id, sit_credit_card_acc_branch_initial, sit_credit_card_acc_division_id, " +
                    "sit_credit_card_acc_department_id, sit_credit_card_acc_major1, sit_credit_card_acc_major2, sit_credit_card_acc_minor, sit_credit_card_acc_analisys, " +
                    "sit_credit_card_acc_filler, sit_delivery_charge_acc_entity_id, sit_delivery_charge_acc_branch_initial, sit_delivery_charge_acc_division_id, " +
                    "sit_delivery_charge_acc_department_id, sit_delivery_charge_acc_major1, sit_delivery_charge_acc_major2, sit_delivery_charge_acc_minor, " +
                    "sit_delivery_charge_acc_analisys, sit_delivery_charge_acc_filler, sit_materai_charge_acc_entity_id, sit_materai_charge_acc_branch_initial, " +
                    "sit_materai_charge_acc_division_id, sit_materai_charge_acc_department_id, sit_materai_charge_acc_major1, sit_materai_charge_acc_major2, " +
                    "sit_materai_charge_acc_minor, sit_materai_charge_acc_analisys, sit_materai_charge_acc_filler, sit_others_charge_acc_entity_id, " +
                    "sit_others_charge_acc_branch_initial, sit_others_charge_acc_division_id, sit_others_charge_acc_department_id, sit_others_charge_acc_major1, " +
                    "sit_others_charge_acc_major2, sit_others_charge_acc_minor, sit_others_charge_acc_analisys, sit_others_charge_acc_filler, sit_udf_acc_entity_id, " +
                    "sit_udf_acc_branch_initial, sit_udf_acc_division_id, sit_udf_acc_department_id, sit_udf_acc_major1, sit_udf_acc_major2, sit_udf_acc_minor, sit_udf_acc_analisys, sit_udf_acc_filler) " +
                    "VALUES " +
                    "(@sit_invoice_type, @sit_invoice_type_description, @sit_line_type, @sit_interface_to_gl, @sit_edit_header_allowed, @sit_edit_detail_allowed, " +
                    "@sit_manual_entry_allowed, @sit_user_define1, @sit_user_define2, @sit_ar_account_entity_id, @sit_ar_account_branch_initial, @sit_ar_account_division_id, " +
                    "@sit_ar_account_department_id, @sit_ar_account_major1, @sit_ar_account_major2, @sit_ar_account_minor, @sit_ar_account_analisys, @sit_ar_account_filler, " +
                    "@sit_ar_account_entity_id, @sit_gross_sal_ret_acc_branch_initial, @sit_gross_sal_ret_acc_division_id, @sit_gross_sal_ret_acc_department_id, " +
                    "@sit_gross_sal_ret_acc_major1, @sit_gross_sal_ret_acc_major2, @sit_gross_sal_ret_acc_minor, @sit_gross_sal_ret_acc_analisys, @sit_gross_sal_ret_acc_filler, " +
                    "@sit_ar_account_entity_id, @sit_disc_line_acc_branch_initial, @sit_disc_line_acc_division_id, @sit_disc_line_acc_department_id, @sit_disc_line_acc_major1, " +
                    "@sit_disc_line_acc_major2, @sit_disc_line_acc_minor, @sit_disc_line_acc_analisys, @sit_disc_line_acc_filler, @sit_ar_account_entity_id, " +
                    "@sit_bonus_line_acc_branch_initial, @sit_bonus_line_acc_division_id, @sit_bonus_line_acc_department_id, @sit_bonus_line_acc_major1, @sit_bonus_line_acc_major2, " +
                    "@sit_bonus_line_acc_minor, @sit_bonus_line_acc_analisys, @sit_bonus_line_acc_filler, @sit_ar_account_entity_id, @sit_disc1_acc_branch_initial, " +
                    "@sit_disc1_acc_division_id, @sit_disc1_acc_department_id, @sit_disc1_acc_major1, @sit_disc1_acc_major2, @sit_disc1_acc_minor, @sit_disc1_acc_analisys, " +
                    "@sit_disc1_acc_filler, @sit_ar_account_entity_id, @sit_disc2_acc_branch_initial, @sit_disc2_acc_division_id, @sit_disc2_acc_department_id, @sit_disc2_acc_major1, " +
                    "@sit_disc2_acc_major2, @sit_disc2_acc_minor, @sit_disc2_acc_analisys, @sit_disc2_acc_filler, @sit_ar_account_entity_id, @sit_ppn_tax_acc_branch_initial, " +
                    "@sit_ppn_tax_acc_division_id, @sit_ppn_tax_acc_department_id, @sit_ppn_tax_acc_major1, @sit_ppn_tax_acc_major2, @sit_ppn_tax_acc_minor, @sit_ppn_tax_acc_analisys, " +
                    "@sit_ppn_tax_acc_filler, @sit_ar_account_entity_id, @sit_cogs_acc_branch_initial, @sit_cogs_acc_division_id, @sit_cogs_acc_department_id, @sit_cogs_acc_major1, " +
                    "@sit_cogs_acc_major2, @sit_cogs_acc_minor, @sit_cogs_acc_analisys, @sit_cogs_acc_filler, @sit_ar_account_entity_id, @sit_inv_uninv_acc_branch_initial, " +
                    "@sit_inv_uninv_acc_division_id, @sit_inv_uninv_acc_department_id, @sit_inv_uninv_acc_major1, @sit_inv_uninv_acc_major2, @sit_inv_uninv_acc_minor, " +
                    "@sit_inv_uninv_acc_analisys, @sit_inv_uninv_acc_filler, @sit_ar_account_entity_id, @sit_credit_card_acc_branch_initial, @sit_credit_card_acc_division_id, " +
                    "@sit_credit_card_acc_department_id, @sit_credit_card_acc_major1, @sit_credit_card_acc_major2, @sit_credit_card_acc_minor, @sit_credit_card_acc_analisys, " +
                    "@sit_credit_card_acc_filler, @sit_ar_account_entity_id, @sit_delivery_charge_acc_branch_initial, @sit_delivery_charge_acc_division_id, " +
                    "@sit_delivery_charge_acc_department_id, @sit_delivery_charge_acc_major1, @sit_delivery_charge_acc_major2, @sit_delivery_charge_acc_minor, " +
                    "@sit_delivery_charge_acc_analisys, @sit_delivery_charge_acc_filler, @sit_ar_account_entity_id, @sit_materai_charge_acc_branch_initial, " +
                    "@sit_materai_charge_acc_division_id, @sit_materai_charge_acc_department_id, @sit_materai_charge_acc_major1, @sit_materai_charge_acc_major2, " +
                    "@sit_materai_charge_acc_minor, @sit_materai_charge_acc_analisys, @sit_materai_charge_acc_filler, @sit_ar_account_entity_id, " +
                    "@sit_others_charge_acc_branch_initial, @sit_others_charge_acc_division_id, @sit_others_charge_acc_department_id, @sit_others_charge_acc_major1, " +
                    "@sit_others_charge_acc_major2, @sit_others_charge_acc_minor, @sit_others_charge_acc_analisys, @sit_others_charge_acc_filler, @sit_ar_account_entity_id, " +
                    "@sit_udf_acc_branch_initial, @sit_udf_acc_division_id, @sit_udf_acc_department_id, @sit_udf_acc_major1, @sit_udf_acc_major2, @sit_udf_acc_minor, @sit_udf_acc_analisys, @sit_udf_acc_filler)";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Create Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(SOInvoiceTypeBL Entity)
        {
            try
            {
                query = "UPDATE SO_INVOICE_TYPE SET " +
                    "sit_invoice_type = @sit_invoice_type, " +
                    "sit_invoice_type_description = @sit_invoice_type_description, " +
                    "sit_line_type = @sit_line_type, " +
                    "sit_user_define1 = @sit_user_define1, " +
                    "sit_user_define2 = @sit_user_define2, " +
                    "sit_interface_to_gl = @sit_interface_to_gl, " +
                    "sit_manual_entry_allowed = @sit_manual_entry_allowed, " +
                    "sit_edit_header_allowed = @sit_edit_header_allowed, " +
                    "sit_edit_detail_allowed = @sit_edit_detail_allowed, " +

                    "sit_ar_account_entity_id = @sit_ar_account_entity_id, " +
                    "sit_gross_sal_ret_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_disc_line_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_bonus_line_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_disc1_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_disc2_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_ppn_tax_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_cogs_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_inv_uninv_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_credit_card_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_delivery_charge_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_materai_charge_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_others_charge_acc_entity_id = @sit_ar_account_entity_id, " +
                    "sit_udf_acc_entity_id = @sit_ar_account_entity_id, " +

                    "sit_ar_account_branch_initial = @sit_ar_account_branch_initial, " +
                    "sit_ar_account_division_id = @sit_ar_account_division_id, " +
                    "sit_ar_account_department_id = @sit_ar_account_department_id, " +
                    "sit_ar_account_major1 = @sit_ar_account_major1, " +
                    "sit_ar_account_major2 = @sit_ar_account_major2, " +
                    "sit_ar_account_minor = @sit_ar_account_minor, " +
                    "sit_ar_account_analisys = @sit_ar_account_analisys, " +
                    "sit_ar_account_filler = @sit_ar_account_filler, " +

                    "sit_gross_sal_ret_acc_branch_initial = @sit_gross_sal_ret_acc_branch_initial, " +
                    "sit_gross_sal_ret_acc_division_id = @sit_gross_sal_ret_acc_division_id, " +
                    "sit_gross_sal_ret_acc_department_id = @sit_gross_sal_ret_acc_department_id, " +
                    "sit_gross_sal_ret_acc_major1 = @sit_gross_sal_ret_acc_major1, " +
                    "sit_gross_sal_ret_acc_major2 = @sit_gross_sal_ret_acc_major2, " +
                    "sit_gross_sal_ret_acc_minor = @sit_gross_sal_ret_acc_minor, " +
                    "sit_gross_sal_ret_acc_analisys = @sit_gross_sal_ret_acc_analisys, " +
                    "sit_gross_sal_ret_acc_filler = @sit_gross_sal_ret_acc_filler, " +

                    "sit_disc_line_acc_branch_initial = @sit_disc_line_acc_branch_initial, " +
                    "sit_disc_line_acc_division_id = @sit_disc_line_acc_division_id, " +
                    "sit_disc_line_acc_department_id = @sit_disc_line_acc_department_id, " +
                    "sit_disc_line_acc_major1 = @sit_disc_line_acc_major1, " +
                    "sit_disc_line_acc_major2 = @sit_disc_line_acc_major2, " +
                    "sit_disc_line_acc_minor = @sit_disc_line_acc_minor, " +
                    "sit_disc_line_acc_analisys = @sit_disc_line_acc_analisys, " +
                    "sit_disc_line_acc_filler = @sit_disc_line_acc_filler, " +

                    "sit_bonus_line_acc_branch_initial = @sit_bonus_line_acc_branch_initial, " +
                    "sit_bonus_line_acc_division_id = @sit_bonus_line_acc_division_id, " +
                    "sit_bonus_line_acc_department_id = @sit_bonus_line_acc_department_id, " +
                    "sit_bonus_line_acc_major1 = @sit_bonus_line_acc_major1, " +
                    "sit_bonus_line_acc_major2 = @sit_bonus_line_acc_major2, " +
                    "sit_bonus_line_acc_minor = @sit_bonus_line_acc_minor, " +
                    "sit_bonus_line_acc_analisys = @sit_bonus_line_acc_analisys, " +
                    "sit_bonus_line_acc_filler = @sit_bonus_line_acc_filler, " +

                    "sit_disc1_acc_branch_initial = @sit_disc1_acc_branch_initial, " +
                    "sit_disc1_acc_division_id = @sit_disc1_acc_division_id, " +
                    "sit_disc1_acc_department_id = @sit_disc1_acc_department_id, " +
                    "sit_disc1_acc_major1 = @sit_disc1_acc_major1, " +
                    "sit_disc1_acc_major2 = @sit_disc1_acc_major2, " +
                    "sit_disc1_acc_minor = @sit_disc1_acc_minor, " +
                    "sit_disc1_acc_analisys = @sit_disc1_acc_analisys, " +
                    "sit_disc1_acc_filler = @sit_disc1_acc_filler, " +

                    "sit_disc2_acc_branch_initial = @sit_disc2_acc_branch_initial, " +
                    "sit_disc2_acc_division_id = @sit_disc2_acc_division_id, " +
                    "sit_disc2_acc_department_id = @sit_disc2_acc_department_id, " +
                    "sit_disc2_acc_major1 = @sit_disc2_acc_major1, " +
                    "sit_disc2_acc_major2 = @sit_disc2_acc_major2, " +
                    "sit_disc2_acc_minor = @sit_disc2_acc_minor, " +
                    "sit_disc2_acc_analisys = @sit_disc2_acc_analisys, " +
                    "sit_disc2_acc_filler = @sit_disc2_acc_filler, " +

                    "sit_ppn_tax_acc_branch_initial = @sit_ppn_tax_acc_branch_initial, " +
                    "sit_ppn_tax_acc_division_id = @sit_ppn_tax_acc_division_id, " +
                    "sit_ppn_tax_acc_department_id = @sit_ppn_tax_acc_department_id, " +
                    "sit_ppn_tax_acc_major1 = @sit_ppn_tax_acc_major1, " +
                    "sit_ppn_tax_acc_major2 = @sit_ppn_tax_acc_major2, " +
                    "sit_ppn_tax_acc_minor = @sit_ppn_tax_acc_minor, " +
                    "sit_ppn_tax_acc_analisys = @sit_ppn_tax_acc_analisys, " +
                    "sit_ppn_tax_acc_filler = @sit_ppn_tax_acc_filler, " +

                    "sit_cogs_acc_branch_initial = @sit_cogs_acc_branch_initial, " +
                    "sit_cogs_acc_division_id = @sit_cogs_acc_division_id, " +
                    "sit_cogs_acc_department_id = @sit_cogs_acc_department_id, " +
                    "sit_cogs_acc_major1 = @sit_cogs_acc_major1, " +
                    "sit_cogs_acc_major2 = @sit_cogs_acc_major2, " +
                    "sit_cogs_acc_minor = @sit_cogs_acc_minor, " +
                    "sit_cogs_acc_analisys = @sit_cogs_acc_analisys, " +
                    "sit_cogs_acc_filler = @sit_cogs_acc_filler, " +

                    "sit_inv_uninv_acc_branch_initial = @sit_inv_uninv_acc_branch_initial, " +
                    "sit_inv_uninv_acc_division_id = @sit_inv_uninv_acc_division_id, " +
                    "sit_inv_uninv_acc_department_id = @sit_inv_uninv_acc_department_id, " +
                    "sit_inv_uninv_acc_major1 = @sit_inv_uninv_acc_major1, " +
                    "sit_inv_uninv_acc_major2 = @sit_inv_uninv_acc_major2, " +
                    "sit_inv_uninv_acc_minor = @sit_inv_uninv_acc_minor, " +
                    "sit_inv_uninv_acc_analisys = @sit_inv_uninv_acc_analisys, " +
                    "sit_inv_uninv_acc_filler = @sit_inv_uninv_acc_filler, " +

                    "sit_credit_card_acc_branch_initial = @sit_credit_card_acc_branch_initial, " +
                    "sit_credit_card_acc_division_id = @sit_credit_card_acc_division_id, " +
                    "sit_credit_card_acc_department_id = @sit_credit_card_acc_department_id, " +
                    "sit_credit_card_acc_major1 = @sit_credit_card_acc_major1, " +
                    "sit_credit_card_acc_major2 = @sit_credit_card_acc_major2, " +
                    "sit_credit_card_acc_minor = @sit_credit_card_acc_minor, " +
                    "sit_credit_card_acc_analisys = @sit_credit_card_acc_analisys, " +
                    "sit_credit_card_acc_filler = @sit_credit_card_acc_filler, " +

                    "sit_delivery_charge_acc_branch_initial = @sit_delivery_charge_acc_branch_initial, " +
                    "sit_delivery_charge_acc_division_id = @sit_delivery_charge_acc_division_id, " +
                    "sit_delivery_charge_acc_department_id = @sit_delivery_charge_acc_department_id, " +
                    "sit_delivery_charge_acc_major1 = @sit_delivery_charge_acc_major1, " +
                    "sit_delivery_charge_acc_major2 = @sit_delivery_charge_acc_major2, " +
                    "sit_delivery_charge_acc_minor = @sit_delivery_charge_acc_minor, " +
                    "sit_delivery_charge_acc_analisys = @sit_delivery_charge_acc_analisys, " +
                    "sit_delivery_charge_acc_filler = @sit_delivery_charge_acc_filler, " +

                    "sit_materai_charge_acc_branch_initial = @sit_materai_charge_acc_branch_initial, " +
                    "sit_materai_charge_acc_division_id = @sit_materai_charge_acc_division_id, " +
                    "sit_materai_charge_acc_department_id = @sit_materai_charge_acc_department_id, " +
                    "sit_materai_charge_acc_major1 = @sit_materai_charge_acc_major1, " +
                    "sit_materai_charge_acc_major2 = @sit_materai_charge_acc_major2, " +
                    "sit_materai_charge_acc_minor = @sit_materai_charge_acc_minor, " +
                    "sit_materai_charge_acc_analisys = @sit_materai_charge_acc_analisys, " +
                    "sit_materai_charge_acc_filler = @sit_materai_charge_acc_filler, " +

                    "sit_others_charge_acc_branch_initial = @sit_others_charge_acc_branch_initial, " +
                    "sit_others_charge_acc_division_id = @sit_others_charge_acc_division_id, " +
                    "sit_others_charge_acc_department_id = @sit_others_charge_acc_department_id, " +
                    "sit_others_charge_acc_major1 = @sit_others_charge_acc_major1, " +
                    "sit_others_charge_acc_major2 = @sit_others_charge_acc_major2, " +
                    "sit_others_charge_acc_minor = @sit_others_charge_acc_minor, " +
                    "sit_others_charge_acc_analisys = @sit_others_charge_acc_analisys, " +
                    "sit_others_charge_acc_filler = @sit_others_charge_acc_filler, " +

                    "sit_udf_acc_branch_initial = @sit_udf_acc_branch_initial, " +
                    "sit_udf_acc_division_id = @sit_udf_acc_division_id, " +
                    "sit_udf_acc_department_id = @sit_udf_acc_department_id, " +
                    "sit_udf_acc_major1 = @sit_udf_acc_major1, " +
                    "sit_udf_acc_major2 = @sit_udf_acc_major2, " +
                    "sit_udf_acc_minor = @sit_udf_acc_minor, " +
                    "sit_udf_acc_analisys = @sit_udf_acc_analisys, " +
                    "sit_udf_acc_filler = @sit_udf_acc_filler " +

                    "WHERE sit_invoice_type = @sit_invoice_type";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Update Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(SOInvoiceTypeBL Entity)
        {
            try
            {
                query = "DELETE FROM SO_INVOICE_TYPE WHERE sit_invoice_type = @sit_invoice_type";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Delete Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
