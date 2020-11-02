using MADITP2._0.businessLogic.GS;
using MADITP2._0.businessLogic.RC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOKPHeaderBL
    {
        private string skh_so_kp_number;
        private DateTime skh_so_kp_date;
        private string skh_entity_id;
        private string skh_branch_id;
        private string skh_division_id;
        private string skh_rep_id;
        private string skh_recruiter_id;
        private string skh_mgr_rep_id;
        private string skh_order_type;
        private string skh_order_source;
        private string skh_customer_id;
        private string skh_customer_name;
        private string skh_customer_address1;
        private string skh_customer_address2;
        private string skh_customer_address3;
        private string skh_rt;
        private string skh_rw;
        private string skh_kelurahan;
        private string skh_kecamatan;
        private string skh_zipcode;
        private string skh_city;
        private string skh_province;
        private string skh_area_code;
        private string skh_sales_type;
        private string skh_payment_type;
        private string skh_price_list_id;
        private string skh_discount_id;
        private string skh_status_of_so_kp;
        private DateTime skh_last_records_update_date;
        private string skh_status_of_verification;
        private string skh_status_of_dp;
        private string skh_status_of_cod;
        private string skh_status_of_invoice;
        private string skh_invoice_number;
        private DateTime skh_invoice_date;
        private string skh_status_of_delivery;
        private string skh_kp_replacement;
        private int skh_no_detail_lines;
        private int skh_total_item_set_qty;
        private string skh_total_su;
        private string skh_total_bv;
        private string skh_total_pv;
        private string skh_total_point_1;
        private string skh_total_point_2;
        private string skh_unit_price;
        private string skh_total_gross_sales;
        private string skh_total_disc_amount;
        private string skh_total_line_amount;
        private string skh_total_bonus_discount;
        private string skh_total_taxable_amount;
        private string skh_inv_disc;
        private string skh_inv_disc_amount;
        private string skh_other_disc;
        private string skh_other_disc_amount;
        private string skh_total_inv_amount;
        private string skh_total_taxable_inv;
        private string skh_total_ppn_amount;
        private string skh_tax_ppn_gov;
        private string skh_tax_ppn_amount;
        private string skh_delivery_charge;
        private string skh_c_card_charge;
        private string skh_stamp_charge;
        private string skh_other_charge;
        private string skh_ppn_bm;
        private string skh_total_cost;
        private string skh_dp_amount;
        private string skh_dp_payment_type;
        private string skh_dp_cheque_giro_no;
        private string skh_dp_card_type;
        private string skh_dp_bank;
        private DateTime skh_cheque_giro_due_date;
        private string skh_cod_amount;
        private string skh_cod_payment_type;
        private string skh_cod_cheque_giro_num;
        private string skh_cod_card_type;
        private string skh_cod_bank;
        private DateTime skh_cod_cheque_giro_due_date;
        private string skh_no_of_instalments;
        private string skh_collection_visit_date;
        private string skh_period_starting_of_instalment;
        private string skh_year_starting_of_instalment;
        private string skh_instalment_amount_per_month;
        private string skh_instalment_payment_type;
        private string skh_instalment_card_type;
        private string skh_instalment_bank;
        private DateTime skh_instalment_cheque_giro_due_date;
        private string skh_deliver_from_warehouse_id;
        private int skh_last_shipment_num;
        private DateTime skh_request_delivery_date;
        private string skh_default_collector_id;
        private string skh_total_cash_price;
        private string skh_remark;
        private string skh_tax_ditanggung;
        private string skh_tax_dibayar;
        private string skh_kp_or_rtn_no;
        private string skh_tot_su_cash;
        private string skh_journal_gross_sales;
        private string skh_journal_bonus;
        private string skh_journal_disc1;
        private string skh_journal_other_disc;
        private string skh_user_id;
        private DateTime skh_delivery_date;
        private DateTime skh_create_date;
        private string skh_desc;
        private string skh_kpm;
        private string skh_jenis_set;
        private string skh_old_kp;
        private string skh_group_value;
        private int skh_group_total_kirim;
        private string skh_grouping_prd_id;
        private string skh_set_group_cash_value;
        private string skh_set_group_comm_value;
        private string skh_total_allocation_group_value;
        private string skh_kp_type;
        private string skh_arisan;
        private string skh_cod_flag;
        private string skh_print_status;
        private string skh_qty_group;
        private string skh_kpo_notes;
        private string skh_tot_dpp;
        private string skh_tot_ppn;
        private string skh_nicepay_trx_id;
        private string skh_nicepay_va;
        private string skh_nicepay_lastpay;
        private string skh_nicepay_amount;
        private string skh_nicepay_code;
        private string skh_nicepay_result;
        private string skh_transf_tm;
        private DateTime skh_nicepay_create;
        private string skh_nicepay_user;
        private string skh_transf_date;
        private string skh_paid;
        private string skh_log;
        private string skh_code_promo_general;
        private string skh_code_promo_general_amt;
        private string skh_ktp;
        private string skh_npwp;
        private string skh_ecommerce_id;
        private string skh_is_ecommerce;
        private string skh_type_order;
        private string skh_payment_type_list;
        private string skh_source_id_real;
        private string skh_nama_point;
        private string skh_phone_point;
        private string skh_address_point;
        private string skh_subdistrict_id_point;
        private string skh_tiara_address_id_point;
        private string skh_total_point;
        private string skh_postal_code_point;
        private string skh_pembulatan;
        private string skh_kpo_ecomerce_sale_id;
        private string skh_ecomerce_sales_number;
        private string skh_invoice_ref_num_gabungan;
        private string skh_add_payment_ecommerc;
        private string skh_add_ongkir_ecommerce;
        private string skh_is_arisan_web;
        private string skh_sender;
        private string skh_cara_kirim;
        private string skh_data_sending;
        private string skh_code_send;
        private string skh_shipping_fee_normal;
        private string skh_reseller_code;
        private string skh_total_point_3;
        private string skh_total_tirapoin;
        private string skh_tokopedia_cashback;
        private string skh_tokopedia_courier;
        private string skh_tokopedia_logistic_id;
        private string skh_odt_src;
        private string skh_flag_dm;
        private string skh_flag_office;
        private string skh_flag_prd_ba;
        private string skh_is_epc_dm;
        private string skh_total_point_4;
        private string skh_is_kp_tahan;
        private string skh_reason_type;
        private string skh_reason_detail;
        private RCRepMasterBL repMaster;
        private SOMasterCustomerBL customerMaster;
        private GSEntityBL entity;
        private GSBranchBL branch;

        public string Skh_so_kp_number { get => skh_so_kp_number; set => skh_so_kp_number = value; }
        public DateTime Skh_so_kp_date { get => skh_so_kp_date; set => skh_so_kp_date = value; }
        public string Skh_entity_id { get => skh_entity_id; set => skh_entity_id = value; }
        public string Skh_branch_id { get => skh_branch_id; set => skh_branch_id = value; }
        public string Skh_division_id { get => skh_division_id; set => skh_division_id = value; }
        public string Skh_rep_id { get => skh_rep_id; set => skh_rep_id = value; }
        public string Skh_recruiter_id { get => skh_recruiter_id; set => skh_recruiter_id = value; }
        public string Skh_mgr_rep_id { get => skh_mgr_rep_id; set => skh_mgr_rep_id = value; }
        public string Skh_order_type { get => skh_order_type; set => skh_order_type = value; }
        public string Skh_order_source { get => skh_order_source; set => skh_order_source = value; }
        public string Skh_customer_id { get => skh_customer_id; set => skh_customer_id = value; }
        public string Skh_customer_name { get => skh_customer_name; set => skh_customer_name = value; }
        public string Skh_customer_address1 { get => skh_customer_address1; set => skh_customer_address1 = value; }
        public string Skh_customer_address2 { get => skh_customer_address2; set => skh_customer_address2 = value; }
        public string Skh_customer_address3 { get => skh_customer_address3; set => skh_customer_address3 = value; }
        public string Skh_rt { get => skh_rt; set => skh_rt = value; }
        public string Skh_rw { get => skh_rw; set => skh_rw = value; }
        public string Skh_kelurahan { get => skh_kelurahan; set => skh_kelurahan = value; }
        public string Skh_kecamatan { get => skh_kecamatan; set => skh_kecamatan = value; }
        public string Skh_zipcode { get => skh_zipcode; set => skh_zipcode = value; }
        public string Skh_city { get => skh_city; set => skh_city = value; }
        public string Skh_province { get => skh_province; set => skh_province = value; }
        public string Skh_area_code { get => skh_area_code; set => skh_area_code = value; }
        public string Skh_sales_type { get => skh_sales_type; set => skh_sales_type = value; }
        public string Skh_payment_type { get => skh_payment_type; set => skh_payment_type = value; }
        public string Skh_price_list_id { get => skh_price_list_id; set => skh_price_list_id = value; }
        public string Skh_discount_id { get => skh_discount_id; set => skh_discount_id = value; }
        public string Skh_status_of_so_kp { get => skh_status_of_so_kp; set => skh_status_of_so_kp = value; }
        public DateTime Skh_last_records_update_date { get => skh_last_records_update_date; set => skh_last_records_update_date = value; }
        public string Skh_status_of_verification { get => skh_status_of_verification; set => skh_status_of_verification = value; }
        public string Skh_status_of_dp { get => skh_status_of_dp; set => skh_status_of_dp = value; }
        public string Skh_status_of_cod { get => skh_status_of_cod; set => skh_status_of_cod = value; }
        public string Skh_status_of_invoice { get => skh_status_of_invoice; set => skh_status_of_invoice = value; }
        public string Skh_invoice_number { get => skh_invoice_number; set => skh_invoice_number = value; }
        public DateTime Skh_invoice_date { get => skh_invoice_date; set => skh_invoice_date = value; }
        public string Skh_status_of_delivery { get => skh_status_of_delivery; set => skh_status_of_delivery = value; }
        public string Skh_kp_replacement { get => skh_kp_replacement; set => skh_kp_replacement = value; }
        public int Skh_no_detail_lines { get => skh_no_detail_lines; set => skh_no_detail_lines = value; }
        public int Skh_total_item_set_qty { get => skh_total_item_set_qty; set => skh_total_item_set_qty = value; }
        public string Skh_total_su { get => skh_total_su; set => skh_total_su = value; }
        public string Skh_total_bv { get => skh_total_bv; set => skh_total_bv = value; }
        public string Skh_total_pv { get => skh_total_pv; set => skh_total_pv = value; }
        public string Skh_total_point_1 { get => skh_total_point_1; set => skh_total_point_1 = value; }
        public string Skh_total_point_2 { get => skh_total_point_2; set => skh_total_point_2 = value; }
        public string Skh_unit_price { get => skh_unit_price; set => skh_unit_price = value; }
        public string Skh_total_gross_sales { get => skh_total_gross_sales; set => skh_total_gross_sales = value; }
        public string Skh_total_disc_amount { get => skh_total_disc_amount; set => skh_total_disc_amount = value; }
        public string Skh_total_line_amount { get => skh_total_line_amount; set => skh_total_line_amount = value; }
        public string Skh_total_bonus_discount { get => skh_total_bonus_discount; set => skh_total_bonus_discount = value; }
        public string Skh_total_taxable_amount { get => skh_total_taxable_amount; set => skh_total_taxable_amount = value; }
        public string Skh_inv_disc { get => skh_inv_disc; set => skh_inv_disc = value; }
        public string Skh_inv_disc_amount { get => skh_inv_disc_amount; set => skh_inv_disc_amount = value; }
        public string Skh_other_disc { get => skh_other_disc; set => skh_other_disc = value; }
        public string Skh_other_disc_amount { get => skh_other_disc_amount; set => skh_other_disc_amount = value; }
        public string Skh_total_inv_amount { get => skh_total_inv_amount; set => skh_total_inv_amount = value; }
        public string Skh_total_taxable_inv { get => skh_total_taxable_inv; set => skh_total_taxable_inv = value; }
        public string Skh_total_ppn_amount { get => skh_total_ppn_amount; set => skh_total_ppn_amount = value; }
        public string Skh_tax_ppn_gov { get => skh_tax_ppn_gov; set => skh_tax_ppn_gov = value; }
        public string Skh_tax_ppn_amount { get => skh_tax_ppn_amount; set => skh_tax_ppn_amount = value; }
        public string Skh_delivery_charge { get => skh_delivery_charge; set => skh_delivery_charge = value; }
        public string Skh_c_card_charge { get => skh_c_card_charge; set => skh_c_card_charge = value; }
        public string Skh_stamp_charge { get => skh_stamp_charge; set => skh_stamp_charge = value; }
        public string Skh_other_charge { get => skh_other_charge; set => skh_other_charge = value; }
        public string Skh_ppn_bm { get => skh_ppn_bm; set => skh_ppn_bm = value; }
        public string Skh_total_cost { get => skh_total_cost; set => skh_total_cost = value; }
        public string Skh_dp_amount { get => skh_dp_amount; set => skh_dp_amount = value; }
        public string Skh_dp_payment_type { get => skh_dp_payment_type; set => skh_dp_payment_type = value; }
        public string Skh_dp_cheque_giro_no { get => skh_dp_cheque_giro_no; set => skh_dp_cheque_giro_no = value; }
        public string Skh_dp_card_type { get => skh_dp_card_type; set => skh_dp_card_type = value; }
        public string Skh_dp_bank { get => skh_dp_bank; set => skh_dp_bank = value; }
        public DateTime Skh_cheque_giro_due_date { get => skh_cheque_giro_due_date; set => skh_cheque_giro_due_date = value; }
        public string Skh_cod_amount { get => skh_cod_amount; set => skh_cod_amount = value; }
        public string Skh_cod_payment_type { get => skh_cod_payment_type; set => skh_cod_payment_type = value; }
        public string Skh_cod_cheque_giro_num { get => skh_cod_cheque_giro_num; set => skh_cod_cheque_giro_num = value; }
        public string Skh_cod_card_type { get => skh_cod_card_type; set => skh_cod_card_type = value; }
        public string Skh_cod_bank { get => skh_cod_bank; set => skh_cod_bank = value; }
        public DateTime Skh_cod_cheque_giro_due_date { get => skh_cod_cheque_giro_due_date; set => skh_cod_cheque_giro_due_date = value; }
        public string Skh_no_of_instalments { get => skh_no_of_instalments; set => skh_no_of_instalments = value; }
        public string Skh_collection_visit_date { get => skh_collection_visit_date; set => skh_collection_visit_date = value; }
        public string Skh_period_starting_of_instalment { get => skh_period_starting_of_instalment; set => skh_period_starting_of_instalment = value; }
        public string Skh_year_starting_of_instalment { get => skh_year_starting_of_instalment; set => skh_year_starting_of_instalment = value; }
        public string Skh_instalment_amount_per_month { get => skh_instalment_amount_per_month; set => skh_instalment_amount_per_month = value; }
        public string Skh_instalment_payment_type { get => skh_instalment_payment_type; set => skh_instalment_payment_type = value; }
        public string Skh_instalment_card_type { get => skh_instalment_card_type; set => skh_instalment_card_type = value; }
        public string Skh_instalment_bank { get => skh_instalment_bank; set => skh_instalment_bank = value; }
        public DateTime Skh_instalment_cheque_giro_due_date { get => skh_instalment_cheque_giro_due_date; set => skh_instalment_cheque_giro_due_date = value; }
        public string Skh_deliver_from_warehouse_id { get => skh_deliver_from_warehouse_id; set => skh_deliver_from_warehouse_id = value; }
        public int Skh_last_shipment_num { get => skh_last_shipment_num; set => skh_last_shipment_num = value; }
        public DateTime Skh_request_delivery_date { get => skh_request_delivery_date; set => skh_request_delivery_date = value; }
        public string Skh_default_collector_id { get => skh_default_collector_id; set => skh_default_collector_id = value; }
        public string Skh_total_cash_price { get => skh_total_cash_price; set => skh_total_cash_price = value; }
        public string Skh_remark { get => skh_remark; set => skh_remark = value; }
        public string Skh_tax_ditanggung { get => skh_tax_ditanggung; set => skh_tax_ditanggung = value; }
        public string Skh_tax_dibayar { get => skh_tax_dibayar; set => skh_tax_dibayar = value; }
        public string Skh_kp_or_rtn_no { get => skh_kp_or_rtn_no; set => skh_kp_or_rtn_no = value; }
        public string Skh_tot_su_cash { get => skh_tot_su_cash; set => skh_tot_su_cash = value; }
        public string Skh_journal_gross_sales { get => skh_journal_gross_sales; set => skh_journal_gross_sales = value; }
        public string Skh_journal_bonus { get => skh_journal_bonus; set => skh_journal_bonus = value; }
        public string Skh_journal_disc1 { get => skh_journal_disc1; set => skh_journal_disc1 = value; }
        public string Skh_journal_other_disc { get => skh_journal_other_disc; set => skh_journal_other_disc = value; }
        public string Skh_user_id { get => skh_user_id; set => skh_user_id = value; }
        public DateTime Skh_delivery_date { get => skh_delivery_date; set => skh_delivery_date = value; }
        public DateTime Skh_create_date { get => skh_create_date; set => skh_create_date = value; }
        public string Skh_desc { get => skh_desc; set => skh_desc = value; }
        public string Skh_kpm { get => skh_kpm; set => skh_kpm = value; }
        public string Skh_jenis_set { get => skh_jenis_set; set => skh_jenis_set = value; }
        public string Skh_old_kp { get => skh_old_kp; set => skh_old_kp = value; }
        public string Skh_group_value { get => skh_group_value; set => skh_group_value = value; }
        public int Skh_group_total_kirim { get => skh_group_total_kirim; set => skh_group_total_kirim = value; }
        public string Skh_grouping_prd_id { get => skh_grouping_prd_id; set => skh_grouping_prd_id = value; }
        public string Skh_set_group_cash_value { get => skh_set_group_cash_value; set => skh_set_group_cash_value = value; }
        public string Skh_set_group_comm_value { get => skh_set_group_comm_value; set => skh_set_group_comm_value = value; }
        public string Skh_total_allocation_group_value { get => skh_total_allocation_group_value; set => skh_total_allocation_group_value = value; }
        public string Skh_kp_type { get => skh_kp_type; set => skh_kp_type = value; }
        public string Skh_arisan { get => skh_arisan; set => skh_arisan = value; }
        public string Skh_cod_flag { get => skh_cod_flag; set => skh_cod_flag = value; }
        public string Skh_print_status { get => skh_print_status; set => skh_print_status = value; }
        public string Skh_qty_group { get => skh_qty_group; set => skh_qty_group = value; }
        public string Skh_kpo_notes { get => skh_kpo_notes; set => skh_kpo_notes = value; }
        public string Skh_tot_dpp { get => skh_tot_dpp; set => skh_tot_dpp = value; }
        public string Skh_tot_ppn { get => skh_tot_ppn; set => skh_tot_ppn = value; }
        public string Skh_nicepay_trx_id { get => skh_nicepay_trx_id; set => skh_nicepay_trx_id = value; }
        public string Skh_nicepay_va { get => skh_nicepay_va; set => skh_nicepay_va = value; }
        public string Skh_nicepay_lastpay { get => skh_nicepay_lastpay; set => skh_nicepay_lastpay = value; }
        public string Skh_nicepay_amount { get => skh_nicepay_amount; set => skh_nicepay_amount = value; }
        public string Skh_nicepay_code { get => skh_nicepay_code; set => skh_nicepay_code = value; }
        public string Skh_nicepay_result { get => skh_nicepay_result; set => skh_nicepay_result = value; }
        public string Skh_transf_tm { get => skh_transf_tm; set => skh_transf_tm = value; }
        public DateTime Skh_nicepay_create { get => skh_nicepay_create; set => skh_nicepay_create = value; }
        public string Skh_nicepay_user { get => skh_nicepay_user; set => skh_nicepay_user = value; }
        public string Skh_transf_date { get => skh_transf_date; set => skh_transf_date = value; }
        public string Skh_paid { get => skh_paid; set => skh_paid = value; }
        public string Skh_log { get => skh_log; set => skh_log = value; }
        public string Skh_code_promo_general { get => skh_code_promo_general; set => skh_code_promo_general = value; }
        public string Skh_code_promo_general_amt { get => skh_code_promo_general_amt; set => skh_code_promo_general_amt = value; }
        public string Skh_ktp { get => skh_ktp; set => skh_ktp = value; }
        public string Skh_npwp { get => skh_npwp; set => skh_npwp = value; }
        public string Skh_ecommerce_id { get => skh_ecommerce_id; set => skh_ecommerce_id = value; }
        public string Skh_is_ecommerce { get => skh_is_ecommerce; set => skh_is_ecommerce = value; }
        public string Skh_type_order { get => skh_type_order; set => skh_type_order = value; }
        public string Skh_payment_type_list { get => skh_payment_type_list; set => skh_payment_type_list = value; }
        public string Skh_source_id_real { get => skh_source_id_real; set => skh_source_id_real = value; }
        public string Skh_nama_point { get => skh_nama_point; set => skh_nama_point = value; }
        public string Skh_phone_point { get => skh_phone_point; set => skh_phone_point = value; }
        public string Skh_address_point { get => skh_address_point; set => skh_address_point = value; }
        public string Skh_subdistrict_id_point { get => skh_subdistrict_id_point; set => skh_subdistrict_id_point = value; }
        public string Skh_tiara_address_id_point { get => skh_tiara_address_id_point; set => skh_tiara_address_id_point = value; }
        public string Skh_total_point { get => skh_total_point; set => skh_total_point = value; }
        public string Skh_postal_code_point { get => skh_postal_code_point; set => skh_postal_code_point = value; }
        public string Skh_pembulatan { get => skh_pembulatan; set => skh_pembulatan = value; }
        public string Skh_kpo_ecomerce_sale_id { get => skh_kpo_ecomerce_sale_id; set => skh_kpo_ecomerce_sale_id = value; }
        public string Skh_ecomerce_sales_number { get => skh_ecomerce_sales_number; set => skh_ecomerce_sales_number = value; }
        public string Skh_invoice_ref_num_gabungan { get => skh_invoice_ref_num_gabungan; set => skh_invoice_ref_num_gabungan = value; }
        public string Skh_add_payment_ecommerc { get => skh_add_payment_ecommerc; set => skh_add_payment_ecommerc = value; }
        public string Skh_add_ongkir_ecommerce { get => skh_add_ongkir_ecommerce; set => skh_add_ongkir_ecommerce = value; }
        public string Skh_is_arisan_web { get => skh_is_arisan_web; set => skh_is_arisan_web = value; }
        public string Skh_sender { get => skh_sender; set => skh_sender = value; }
        public string Skh_cara_kirim { get => skh_cara_kirim; set => skh_cara_kirim = value; }
        public string Skh_data_sending { get => skh_data_sending; set => skh_data_sending = value; }
        public string Skh_code_send { get => skh_code_send; set => skh_code_send = value; }
        public string Skh_shipping_fee_normal { get => skh_shipping_fee_normal; set => skh_shipping_fee_normal = value; }
        public string Skh_reseller_code { get => skh_reseller_code; set => skh_reseller_code = value; }
        public string Skh_total_point_3 { get => skh_total_point_3; set => skh_total_point_3 = value; }
        public string Skh_total_tirapoin { get => skh_total_tirapoin; set => skh_total_tirapoin = value; }
        public string Skh_tokopedia_cashback { get => skh_tokopedia_cashback; set => skh_tokopedia_cashback = value; }
        public string Skh_tokopedia_courier { get => skh_tokopedia_courier; set => skh_tokopedia_courier = value; }
        public string Skh_tokopedia_logistic_id { get => skh_tokopedia_logistic_id; set => skh_tokopedia_logistic_id = value; }
        public string Skh_odt_src { get => skh_odt_src; set => skh_odt_src = value; }
        public string Skh_flag_dm { get => skh_flag_dm; set => skh_flag_dm = value; }
        public string Skh_flag_office { get => skh_flag_office; set => skh_flag_office = value; }
        public string Skh_flag_prd_ba { get => skh_flag_prd_ba; set => skh_flag_prd_ba = value; }
        public string Skh_is_epc_dm { get => skh_is_epc_dm; set => skh_is_epc_dm = value; }
        public string Skh_total_point_4 { get => skh_total_point_4; set => skh_total_point_4 = value; }
        public string Skh_is_kp_tahan { get => skh_is_kp_tahan; set => skh_is_kp_tahan = value; }
        public string Skh_reason_type { get => skh_reason_type; set => skh_reason_type = value; }
        public string Skh_reason_detail { get => skh_reason_detail; set => skh_reason_detail = value; }
        public RCRepMasterBL RepMaster { get => repMaster; set => repMaster = value; }
        public GSEntityBL Entity { get => entity; set => entity = value; }
        public GSBranchBL Branch { get => branch; set => branch = value; }
        internal SOMasterCustomerBL CustomerMaster { get => customerMaster; set => customerMaster = value; }
    }
}
