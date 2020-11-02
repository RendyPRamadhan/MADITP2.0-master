namespace MADITP2._0.businessLogic.SO
{
    public class SOInvoiceTypeBL
    {
        private string _sit_invoice_type;
        private string _sit_invoice_type_description ;
        private string _sit_line_type;
        private string _sit_interface_to_gl;
        private string _sit_edit_header_allowed;
        private string _sit_edit_detail_allowed;
        private string _sit_manual_entry_allowed;
        private string _sit_ar_account_entity_id;
        private string _sit_ar_account_branch_initial;
        private string _sit_ar_account_division_id;
        private string _sit_ar_account_department_id;
        private string _sit_ar_account_major1;
        private string _sit_ar_account_major2;
        private string _sit_ar_account_minor;
        private string _sit_ar_account_analisys;
        private string _sit_ar_account_filler;
        private string _sit_gross_sal_ret_acc_entity_id;
        private string _sit_gross_sal_ret_acc_branch_initial;
        private string _sit_gross_sal_ret_acc_division_id;
        private string _sit_gross_sal_ret_acc_department_id;
        private string _sit_gross_sal_ret_acc_major1;
        private string _sit_gross_sal_ret_acc_major2;
        private string _sit_gross_sal_ret_acc_minor;
        private string _sit_gross_sal_ret_acc_analisys;
        private string _sit_gross_sal_ret_acc_filler;
        private string _sit_disc_line_acc_entity_id;
        private string _sit_disc_line_acc_branch_initial;
        private string _sit_disc_line_acc_division_id;
        private string _sit_disc_line_acc_department_id;
        private string _sit_disc_line_acc_major1;
        private string _sit_disc_line_acc_major2;
        private string _sit_disc_line_acc_minor;
        private string _sit_disc_line_acc_analisys;
        private string _sit_disc_line_acc_filler;
        private string _sit_bonus_line_acc_entity_id;
        private string _sit_bonus_line_acc_branch_initial;
        private string _sit_bonus_line_acc_division_id;
        private string _sit_bonus_line_acc_department_id;
        private string _sit_bonus_line_acc_major1;
        private string _sit_bonus_line_acc_major2;
        private string _sit_bonus_line_acc_minor;
        private string _sit_bonus_line_acc_analisys;
        private string _sit_bonus_line_acc_filler;
        private string _sit_disc1_acc_entity_id;
        private string _sit_disc1_acc_branch_initial;
        private string _sit_disc1_acc_division_id;
        private string _sit_disc1_acc_department_id;
        private string _sit_disc1_acc_major1;
        private string _sit_disc1_acc_major2;
        private string _sit_disc1_acc_minor;
        private string _sit_disc1_acc_analisys;
        private string _sit_disc1_acc_filler;
        private string _sit_disc2_acc_entity_id;
        private string _sit_disc2_acc_branch_initial;
        private string _sit_disc2_acc_division_id;
        private string _sit_disc2_acc_department_id;
        private string _sit_disc2_acc_major1;
        private string _sit_disc2_acc_major2;
        private string _sit_disc2_acc_minor;
        private string _sit_disc2_acc_analisys;
        private string _sit_disc2_acc_filler;
        private string _sit_ppn_tax_acc_entity_id;
        private string _sit_ppn_tax_acc_branch_initial;
        private string _sit_ppn_tax_acc_division_id;
        private string _sit_ppn_tax_acc_department_id;
        private string _sit_ppn_tax_acc_major1;
        private string _sit_ppn_tax_acc_major2;
        private string _sit_ppn_tax_acc_minor;
        private string _sit_ppn_tax_acc_analisys;
        private string _sit_ppn_tax_acc_filler;
        private string _sit_cogs_acc_entity_id;
        private string _sit_cogs_acc_branch_initial;
        private string _sit_cogs_acc_division_id;
        private string _sit_cogs_acc_department_id;
        private string _sit_cogs_acc_major1;
        private string _sit_cogs_acc_major2;
        private string _sit_cogs_acc_minor;
        private string _sit_cogs_acc_analisys;
        private string _sit_cogs_acc_filler;
        private string _sit_inv_uninv_acc_entity_id;
        private string _sit_inv_uninv_acc_branch_initial;
        private string _sit_inv_uninv_acc_division_id;
        private string _sit_inv_uninv_acc_department_id;
        private string _sit_inv_uninv_acc_major1;
        private string _sit_inv_uninv_acc_major2;
        private string _sit_inv_uninv_acc_minor;
        private string _sit_inv_uninv_acc_analisys;
        private string _sit_inv_uninv_acc_filler;
        private string _sit_credit_card_acc_entity_id;
        private string _sit_credit_card_acc_branch_initial;
        private string _sit_credit_card_acc_division_id;
        private string _sit_credit_card_acc_department_id;
        private string _sit_credit_card_acc_major1;
        private string _sit_credit_card_acc_major2;
        private string _sit_credit_card_acc_minor;
        private string _sit_credit_card_acc_analisys;
        private string _sit_credit_card_acc_filler;
        private string _sit_delivery_charge_acc_entity_id;
        private string _sit_delivery_charge_acc_branch_initial;
        private string _sit_delivery_charge_acc_division_id;
        private string _sit_delivery_charge_acc_department_id;
        private string _sit_delivery_charge_acc_major1;
        private string _sit_delivery_charge_acc_major2;
        private string _sit_delivery_charge_acc_minor;
        private string _sit_delivery_charge_acc_analisys;
        private string _sit_delivery_charge_acc_filler;
        private string _sit_materai_charge_acc_entity_id;
        private string _sit_materai_charge_acc_branch_initial;
        private string _sit_materai_charge_acc_division_id;
        private string _sit_materai_charge_acc_department_id;
        private string _sit_materai_charge_acc_major1;
        private string _sit_materai_charge_acc_major2;
        private string _sit_materai_charge_acc_minor;
        private string _sit_materai_charge_acc_analisys;
        private string _sit_materai_charge_acc_filler;
        private string _sit_others_charge_acc_entity_id;
        private string _sit_others_charge_acc_branch_initial;
        private string _sit_others_charge_acc_division_id;
        private string _sit_others_charge_acc_department_id;
        private string _sit_others_charge_acc_major1;
        private string _sit_others_charge_acc_major2;
        private string _sit_others_charge_acc_minor;
        private string _sit_others_charge_acc_analisys;
        private string _sit_others_charge_acc_filler;
        private string _sit_udf_acc_entity_id;
        private string _sit_udf_acc_branch_initial;
        private string _sit_udf_acc_division_id;
        private string _sit_udf_acc_department_id;
        private string _sit_udf_acc_major1;
        private string _sit_udf_acc_major2;
        private string _sit_udf_acc_minor;
        private string _sit_udf_acc_analisys;
        private string _sit_udf_acc_filler;
        private string _sit_user_define1;
        private string _sit_user_define2;

        public string sit_invoice_type
        {
            get { return _sit_invoice_type; }
            set { this._sit_invoice_type = value; }
        }
        public string sit_invoice_type_description
        {
            get { return _sit_invoice_type_description ; }
            set { this._sit_invoice_type_description = value; }
        }
        public string sit_line_type
        {
            get { return _sit_line_type; }
            set { this._sit_line_type = value; }
        }
        public string sit_interface_to_gl
        {
            get { return _sit_interface_to_gl; }
            set { this._sit_interface_to_gl = value; }
        }
        public string sit_edit_header_allowed
        {
            get { return _sit_edit_header_allowed; }
            set { this._sit_edit_header_allowed = value; }
        }
        public string sit_edit_detail_allowed
        {
            get { return _sit_edit_detail_allowed; }
            set { this._sit_edit_detail_allowed = value; }
        }
        public string sit_manual_entry_allowed
        {
            get { return _sit_manual_entry_allowed; }
            set { this._sit_manual_entry_allowed = value; }
        }
        public string sit_ar_account_entity_id
        {
            get { return _sit_ar_account_entity_id; }
            set { this._sit_ar_account_entity_id = value; }
        }
        public string sit_ar_account_branch_initial
        {
            get { return _sit_ar_account_branch_initial; }
            set { this._sit_ar_account_branch_initial = value; }
        }
        public string sit_ar_account_division_id
        {
            get { return _sit_ar_account_division_id; }
            set { this._sit_ar_account_division_id = value; }
        }
        public string sit_ar_account_department_id
        {
            get { return _sit_ar_account_department_id; }
            set { this._sit_ar_account_department_id = value; }
        }
        public string sit_ar_account_major1
        {
            get { return _sit_ar_account_major1; }
            set { this._sit_ar_account_major1 = value; }
        }
        public string sit_ar_account_major2
        {
            get { return _sit_ar_account_major2; }
            set { this._sit_ar_account_major2 = value; }
        }
        public string sit_ar_account_minor
        {
            get { return _sit_ar_account_minor; }
            set { this._sit_ar_account_minor = value; }
        }
        public string sit_ar_account_analisys
        {
            get { return _sit_ar_account_analisys; }
            set { this._sit_ar_account_analisys = value; }
        }
        public string sit_ar_account_filler
        {
            get { return _sit_ar_account_filler; }
            set { this._sit_ar_account_filler = value; }
        }
        public string sit_gross_sal_ret_acc_entity_id
        {
            get { return _sit_gross_sal_ret_acc_entity_id; }
            set { this._sit_gross_sal_ret_acc_entity_id = value; }
        }
        public string sit_gross_sal_ret_acc_branch_initial
        {
            get { return _sit_gross_sal_ret_acc_branch_initial; }
            set { this._sit_gross_sal_ret_acc_branch_initial = value; }
        }
        public string sit_gross_sal_ret_acc_division_id
        {
            get { return _sit_gross_sal_ret_acc_division_id; }
            set { this._sit_gross_sal_ret_acc_division_id = value; }
        }
        public string sit_gross_sal_ret_acc_department_id
        {
            get { return _sit_gross_sal_ret_acc_department_id; }
            set { this._sit_gross_sal_ret_acc_department_id = value; }
        }
        public string sit_gross_sal_ret_acc_major1
        {
            get { return _sit_gross_sal_ret_acc_major1; }
            set { this._sit_gross_sal_ret_acc_major1 = value; }
        }
        public string sit_gross_sal_ret_acc_major2
        {
            get { return _sit_gross_sal_ret_acc_major2; }
            set { this._sit_gross_sal_ret_acc_major2 = value; }
        }
        public string sit_gross_sal_ret_acc_minor
        {
            get { return _sit_gross_sal_ret_acc_minor; }
            set { this._sit_gross_sal_ret_acc_minor = value; }
        }
        public string sit_gross_sal_ret_acc_analisys
        {
            get { return _sit_gross_sal_ret_acc_analisys; }
            set { this._sit_gross_sal_ret_acc_analisys = value; }
        }
        public string sit_gross_sal_ret_acc_filler
        {
            get { return _sit_gross_sal_ret_acc_filler; }
            set { this._sit_gross_sal_ret_acc_filler = value; }
        }
        public string sit_disc_line_acc_entity_id
        {
            get { return _sit_disc_line_acc_entity_id; }
            set { this._sit_disc_line_acc_entity_id = value; }
        }
        public string sit_disc_line_acc_branch_initial
        {
            get { return _sit_disc_line_acc_branch_initial; }
            set { this._sit_disc_line_acc_branch_initial = value; }
        }
        public string sit_disc_line_acc_division_id
        {
            get { return _sit_disc_line_acc_division_id; }
            set { this._sit_disc_line_acc_division_id = value; }
        }
        public string sit_disc_line_acc_department_id
        {
            get { return _sit_disc_line_acc_department_id; }
            set { this._sit_disc_line_acc_department_id = value; }
        }
        public string sit_disc_line_acc_major1
        {
            get { return _sit_disc_line_acc_major1; }
            set { this._sit_disc_line_acc_major1 = value; }
        }
        public string sit_disc_line_acc_major2
        {
            get { return _sit_disc_line_acc_major2; }
            set { this._sit_disc_line_acc_major2 = value; }
        }
        public string sit_disc_line_acc_minor
        {
            get { return _sit_disc_line_acc_minor; }
            set { this._sit_disc_line_acc_minor = value; }
        }
        public string sit_disc_line_acc_analisys
        {
            get { return _sit_disc_line_acc_analisys; }
            set { this._sit_disc_line_acc_analisys = value; }
        }
        public string sit_disc_line_acc_filler
        {
            get { return _sit_disc_line_acc_filler; }
            set { this._sit_disc_line_acc_filler = value; }
        }
        public string sit_bonus_line_acc_entity_id
        {
            get { return _sit_bonus_line_acc_entity_id; }
            set { this._sit_bonus_line_acc_entity_id = value; }
        }
        public string sit_bonus_line_acc_branch_initial
        {
            get { return _sit_bonus_line_acc_branch_initial; }
            set { this._sit_bonus_line_acc_branch_initial = value; }
        }
        public string sit_bonus_line_acc_division_id
        {
            get { return _sit_bonus_line_acc_division_id; }
            set { this._sit_bonus_line_acc_division_id = value; }
        }
        public string sit_bonus_line_acc_department_id
        {
            get { return _sit_bonus_line_acc_department_id; }
            set { this._sit_bonus_line_acc_department_id = value; }
        }
        public string sit_bonus_line_acc_major1
        {
            get { return _sit_bonus_line_acc_major1; }
            set { this._sit_bonus_line_acc_major1 = value; }
        }
        public string sit_bonus_line_acc_major2
        {
            get { return _sit_bonus_line_acc_major2; }
            set { this._sit_bonus_line_acc_major2 = value; }
        }
        public string sit_bonus_line_acc_minor
        {
            get { return _sit_bonus_line_acc_minor; }
            set { this._sit_bonus_line_acc_minor = value; }
        }
        public string sit_bonus_line_acc_analisys
        {
            get { return _sit_bonus_line_acc_analisys; }
            set { this._sit_bonus_line_acc_analisys = value; }
        }
        public string sit_bonus_line_acc_filler
        {
            get { return _sit_bonus_line_acc_filler; }
            set { this._sit_bonus_line_acc_filler = value; }
        }
        public string sit_disc1_acc_entity_id
        {
            get { return _sit_disc1_acc_entity_id; }
            set { this._sit_disc1_acc_entity_id = value; }
        }
        public string sit_disc1_acc_branch_initial
        {
            get { return _sit_disc1_acc_branch_initial; }
            set { this._sit_disc1_acc_branch_initial = value; }
        }
        public string sit_disc1_acc_division_id
        {
            get { return _sit_disc1_acc_division_id; }
            set { this._sit_disc1_acc_division_id = value; }
        }
        public string sit_disc1_acc_department_id
        {
            get { return _sit_disc1_acc_department_id; }
            set { this._sit_disc1_acc_department_id = value; }
        }
        public string sit_disc1_acc_major1
        {
            get { return _sit_disc1_acc_major1; }
            set { this._sit_disc1_acc_major1 = value; }
        }
        public string sit_disc1_acc_major2
        {
            get { return _sit_disc1_acc_major2; }
            set { this._sit_disc1_acc_major2 = value; }
        }
        public string sit_disc1_acc_minor
        {
            get { return _sit_disc1_acc_minor; }
            set { this._sit_disc1_acc_minor = value; }
        }
        public string sit_disc1_acc_analisys
        {
            get { return _sit_disc1_acc_analisys; }
            set { this._sit_disc1_acc_analisys = value; }
        }
        public string sit_disc1_acc_filler
        {
            get { return _sit_disc1_acc_filler; }
            set { this._sit_disc1_acc_filler = value; }
        }
        public string sit_disc2_acc_entity_id
        {
            get { return _sit_disc2_acc_entity_id; }
            set { this._sit_disc2_acc_entity_id = value; }
        }
        public string sit_disc2_acc_branch_initial
        {
            get { return _sit_disc2_acc_branch_initial; }
            set { this._sit_disc2_acc_branch_initial = value; }
        }
        public string sit_disc2_acc_division_id
        {
            get { return _sit_disc2_acc_division_id; }
            set { this._sit_disc2_acc_division_id = value; }
        }
        public string sit_disc2_acc_department_id
        {
            get { return _sit_disc2_acc_department_id; }
            set { this._sit_disc2_acc_department_id = value; }
        }
        public string sit_disc2_acc_major1
        {
            get { return _sit_disc2_acc_major1; }
            set { this._sit_disc2_acc_major1 = value; }
        }
        public string sit_disc2_acc_major2
        {
            get { return _sit_disc2_acc_major2; }
            set { this._sit_disc2_acc_major2 = value; }
        }
        public string sit_disc2_acc_minor
        {
            get { return _sit_disc2_acc_minor; }
            set { this._sit_disc2_acc_minor = value; }
        }
        public string sit_disc2_acc_analisys
        {
            get { return _sit_disc2_acc_analisys; }
            set { this._sit_disc2_acc_analisys = value; }
        }
        public string sit_disc2_acc_filler
        {
            get { return _sit_disc2_acc_filler; }
            set { this._sit_disc2_acc_filler = value; }
        }
        public string sit_ppn_tax_acc_entity_id
        {
            get { return _sit_ppn_tax_acc_entity_id; }
            set { this._sit_ppn_tax_acc_entity_id = value; }
        }
        public string sit_ppn_tax_acc_branch_initial
        {
            get { return _sit_ppn_tax_acc_branch_initial; }
            set { this._sit_ppn_tax_acc_branch_initial = value; }
        }
        public string sit_ppn_tax_acc_division_id
        {
            get { return _sit_ppn_tax_acc_division_id; }
            set { this._sit_ppn_tax_acc_division_id = value; }
        }
        public string sit_ppn_tax_acc_department_id
        {
            get { return _sit_ppn_tax_acc_department_id; }
            set { this._sit_ppn_tax_acc_department_id = value; }
        }
        public string sit_ppn_tax_acc_major1
        {
            get { return _sit_ppn_tax_acc_major1; }
            set { this._sit_ppn_tax_acc_major1 = value; }
        }
        public string sit_ppn_tax_acc_major2
        {
            get { return _sit_ppn_tax_acc_major2; }
            set { this._sit_ppn_tax_acc_major2 = value; }
        }
        public string sit_ppn_tax_acc_minor
        {
            get { return _sit_ppn_tax_acc_minor; }
            set { this._sit_ppn_tax_acc_minor = value; }
        }
        public string sit_ppn_tax_acc_analisys
        {
            get { return _sit_ppn_tax_acc_analisys; }
            set { this._sit_ppn_tax_acc_analisys = value; }
        }
        public string sit_ppn_tax_acc_filler
        {
            get { return _sit_ppn_tax_acc_filler; }
            set { this._sit_ppn_tax_acc_filler = value; }
        }
        public string sit_cogs_acc_entity_id
        {
            get { return _sit_cogs_acc_entity_id; }
            set { this._sit_cogs_acc_entity_id = value; }
        }
        public string sit_cogs_acc_branch_initial
        {
            get { return _sit_cogs_acc_branch_initial; }
            set { this._sit_cogs_acc_branch_initial = value; }
        }
        public string sit_cogs_acc_division_id
        {
            get { return _sit_cogs_acc_division_id; }
            set { this._sit_cogs_acc_division_id = value; }
        }
        public string sit_cogs_acc_department_id
        {
            get { return _sit_cogs_acc_department_id; }
            set { this._sit_cogs_acc_department_id = value; }
        }
        public string sit_cogs_acc_major1
        {
            get { return _sit_cogs_acc_major1; }
            set { this._sit_cogs_acc_major1 = value; }
        }
        public string sit_cogs_acc_major2
        {
            get { return _sit_cogs_acc_major2; }
            set { this._sit_cogs_acc_major2 = value; }
        }
        public string sit_cogs_acc_minor
        {
            get { return _sit_cogs_acc_minor; }
            set { this._sit_cogs_acc_minor = value; }
        }
        public string sit_cogs_acc_analisys
        {
            get { return _sit_cogs_acc_analisys; }
            set { this._sit_cogs_acc_analisys = value; }
        }
        public string sit_cogs_acc_filler
        {
            get { return _sit_cogs_acc_filler; }
            set { this._sit_cogs_acc_filler = value; }
        }
        public string sit_inv_uninv_acc_entity_id
        {
            get { return _sit_inv_uninv_acc_entity_id; }
            set { this._sit_inv_uninv_acc_entity_id = value; }
        }
        public string sit_inv_uninv_acc_branch_initial
        {
            get { return _sit_inv_uninv_acc_branch_initial; }
            set { this._sit_inv_uninv_acc_branch_initial = value; }
        }
        public string sit_inv_uninv_acc_division_id
        {
            get { return _sit_inv_uninv_acc_division_id; }
            set { this._sit_inv_uninv_acc_division_id = value; }
        }
        public string sit_inv_uninv_acc_department_id
        {
            get { return _sit_inv_uninv_acc_department_id; }
            set { this._sit_inv_uninv_acc_department_id = value; }
        }
        public string sit_inv_uninv_acc_major1
        {
            get { return _sit_inv_uninv_acc_major1; }
            set { this._sit_inv_uninv_acc_major1 = value; }
        }
        public string sit_inv_uninv_acc_major2
        {
            get { return _sit_inv_uninv_acc_major2; }
            set { this._sit_inv_uninv_acc_major2 = value; }
        }
        public string sit_inv_uninv_acc_minor
        {
            get { return _sit_inv_uninv_acc_minor; }
            set { this._sit_inv_uninv_acc_minor = value; }
        }
        public string sit_inv_uninv_acc_analisys
        {
            get { return _sit_inv_uninv_acc_analisys; }
            set { this._sit_inv_uninv_acc_analisys = value; }
        }
        public string sit_inv_uninv_acc_filler
        {
            get { return _sit_inv_uninv_acc_filler; }
            set { this._sit_inv_uninv_acc_filler = value; }
        }
        public string sit_credit_card_acc_entity_id
        {
            get { return _sit_credit_card_acc_entity_id; }
            set { this._sit_credit_card_acc_entity_id = value; }
        }
        public string sit_credit_card_acc_branch_initial
        {
            get { return _sit_credit_card_acc_branch_initial; }
            set { this._sit_credit_card_acc_branch_initial = value; }
        }
        public string sit_credit_card_acc_division_id
        {
            get { return _sit_credit_card_acc_division_id; }
            set { this._sit_credit_card_acc_division_id = value; }
        }
        public string sit_credit_card_acc_department_id
        {
            get { return _sit_credit_card_acc_department_id; }
            set { this._sit_credit_card_acc_department_id = value; }
        }
        public string sit_credit_card_acc_major1
        {
            get { return _sit_credit_card_acc_major1; }
            set { this._sit_credit_card_acc_major1 = value; }
        }
        public string sit_credit_card_acc_major2
        {
            get { return _sit_credit_card_acc_major2; }
            set { this._sit_credit_card_acc_major2 = value; }
        }
        public string sit_credit_card_acc_minor
        {
            get { return _sit_credit_card_acc_minor; }
            set { this._sit_credit_card_acc_minor = value; }
        }
        public string sit_credit_card_acc_analisys
        {
            get { return _sit_credit_card_acc_analisys; }
            set { this._sit_credit_card_acc_analisys = value; }
        }
        public string sit_credit_card_acc_filler
        {
            get { return _sit_credit_card_acc_filler; }
            set { this._sit_credit_card_acc_filler = value; }
        }
        public string sit_delivery_charge_acc_entity_id
        {
            get { return _sit_delivery_charge_acc_entity_id; }
            set { this._sit_delivery_charge_acc_entity_id = value; }
        }
        public string sit_delivery_charge_acc_branch_initial
        {
            get { return _sit_delivery_charge_acc_branch_initial; }
            set { this._sit_delivery_charge_acc_branch_initial = value; }
        }
        public string sit_delivery_charge_acc_division_id
        {
            get { return _sit_delivery_charge_acc_division_id; }
            set { this._sit_delivery_charge_acc_division_id = value; }
        }
        public string sit_delivery_charge_acc_department_id
        {
            get { return _sit_delivery_charge_acc_department_id; }
            set { this._sit_delivery_charge_acc_department_id = value; }
        }
        public string sit_delivery_charge_acc_major1
        {
            get { return _sit_delivery_charge_acc_major1; }
            set { this._sit_delivery_charge_acc_major1 = value; }
        }
        public string sit_delivery_charge_acc_major2
        {
            get { return _sit_delivery_charge_acc_major2; }
            set { this._sit_delivery_charge_acc_major2 = value; }
        }
        public string sit_delivery_charge_acc_minor
        {
            get { return _sit_delivery_charge_acc_minor; }
            set { this._sit_delivery_charge_acc_minor = value; }
        }
        public string sit_delivery_charge_acc_analisys
        {
            get { return _sit_delivery_charge_acc_analisys; }
            set { this._sit_delivery_charge_acc_analisys = value; }
        }
        public string sit_delivery_charge_acc_filler
        {
            get { return _sit_delivery_charge_acc_filler; }
            set { this._sit_delivery_charge_acc_filler = value; }
        }
        public string sit_materai_charge_acc_entity_id
        {
            get { return _sit_materai_charge_acc_entity_id; }
            set { this._sit_materai_charge_acc_entity_id = value; }
        }
        public string sit_materai_charge_acc_branch_initial
        {
            get { return _sit_materai_charge_acc_branch_initial; }
            set { this._sit_materai_charge_acc_branch_initial = value; }
        }
        public string sit_materai_charge_acc_division_id
        {
            get { return _sit_materai_charge_acc_division_id; }
            set { this._sit_materai_charge_acc_division_id = value; }
        }
        public string sit_materai_charge_acc_department_id
        {
            get { return _sit_materai_charge_acc_department_id; }
            set { this._sit_materai_charge_acc_department_id = value; }
        }
        public string sit_materai_charge_acc_major1
        {
            get { return _sit_materai_charge_acc_major1; }
            set { this._sit_materai_charge_acc_major1 = value; }
        }
        public string sit_materai_charge_acc_major2
        {
            get { return _sit_materai_charge_acc_major2; }
            set { this._sit_materai_charge_acc_major2 = value; }
        }
        public string sit_materai_charge_acc_minor
        {
            get { return _sit_materai_charge_acc_minor; }
            set { this._sit_materai_charge_acc_minor = value; }
        }
        public string sit_materai_charge_acc_analisys
        {
            get { return _sit_materai_charge_acc_analisys; }
            set { this._sit_materai_charge_acc_analisys = value; }
        }
        public string sit_materai_charge_acc_filler
        {
            get { return _sit_materai_charge_acc_filler; }
            set { this._sit_materai_charge_acc_filler = value; }
        }
        public string sit_others_charge_acc_entity_id
        {
            get { return _sit_others_charge_acc_entity_id; }
            set { this._sit_others_charge_acc_entity_id = value; }
        }
        public string sit_others_charge_acc_branch_initial
        {
            get { return _sit_others_charge_acc_branch_initial; }
            set { this._sit_others_charge_acc_branch_initial = value; }
        }
        public string sit_others_charge_acc_division_id
        {
            get { return _sit_others_charge_acc_division_id; }
            set { this._sit_others_charge_acc_division_id = value; }
        }
        public string sit_others_charge_acc_department_id
        {
            get { return _sit_others_charge_acc_department_id; }
            set { this._sit_others_charge_acc_department_id = value; }
        }
        public string sit_others_charge_acc_major1
        {
            get { return _sit_others_charge_acc_major1; }
            set { this._sit_others_charge_acc_major1 = value; }
        }
        public string sit_others_charge_acc_major2
        {
            get { return _sit_others_charge_acc_major2; }
            set { this._sit_others_charge_acc_major2 = value; }
        }
        public string sit_others_charge_acc_minor
        {
            get { return _sit_others_charge_acc_minor; }
            set { this._sit_others_charge_acc_minor = value; }
        }
        public string sit_others_charge_acc_analisys
        {
            get { return _sit_others_charge_acc_analisys; }
            set { this._sit_others_charge_acc_analisys = value; }
        }
        public string sit_others_charge_acc_filler
        {
            get { return _sit_others_charge_acc_filler; }
            set { this._sit_others_charge_acc_filler = value; }
        }
        public string sit_udf_acc_entity_id
        {
            get { return _sit_udf_acc_entity_id; }
            set { this._sit_udf_acc_entity_id = value; }
        }
        public string sit_udf_acc_branch_initial
        {
            get { return _sit_udf_acc_branch_initial; }
            set { this._sit_udf_acc_branch_initial = value; }
        }
        public string sit_udf_acc_division_id
        {
            get { return _sit_udf_acc_division_id; }
            set { this._sit_udf_acc_division_id = value; }
        }
        public string sit_udf_acc_department_id
        {
            get { return _sit_udf_acc_department_id; }
            set { this._sit_udf_acc_department_id = value; }
        }
        public string sit_udf_acc_major1
        {
            get { return _sit_udf_acc_major1; }
            set { this._sit_udf_acc_major1 = value; }
        }
        public string sit_udf_acc_major2
        {
            get { return _sit_udf_acc_major2; }
            set { this._sit_udf_acc_major2 = value; }
        }
        public string sit_udf_acc_minor
        {
            get { return _sit_udf_acc_minor; }
            set { this._sit_udf_acc_minor = value; }
        }
        public string sit_udf_acc_analisys
        {
            get { return _sit_udf_acc_analisys; }
            set { this._sit_udf_acc_analisys = value; }
        }
        public string sit_udf_acc_filler
        {
            get { return _sit_udf_acc_filler; }
            set { this._sit_udf_acc_filler = value; }
        }
        public string sit_user_define1
        {
            get { return _sit_user_define1; }
            set { this._sit_user_define1 = value; }
        }
        public string sit_user_define2
        {
            get { return _sit_user_define2; }
            set { this._sit_user_define2 = value; }
        }
    }
}
