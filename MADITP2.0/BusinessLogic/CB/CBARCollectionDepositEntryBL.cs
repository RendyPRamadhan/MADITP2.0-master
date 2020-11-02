using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    class CBARCollectionDepositEntryBL
    {
        public string ak_so_number { get; set; }
        public string ak_item_number { get; set; }
        public string ak_seq_number { get; set; }
        public string ak_customer_id { get; set; }
        public string ak_entity_id { get; set; }
        public string ak_branch_id { get; set; }
        public string ak_division_id { get; set; }
        public string ak_item_description { get; set; }
        public string ak_kw_amount { get; set; }
        public double ak_accumulated_amount_receipt { get; set; }
        public double ak_outstanding_amount { get; set; }
        public DateTime ak_processing_date { get; set; }
        public string ak_processed_by { get; set; }
        public DateTime ak_kw_date { get; set; }
        public DateTime ak_kw_visit_date { get; set; }
        public string ak_kw_printed_flag { get; set; }
        public double ak_num_of_kw_printed { get; set; }
        public DateTime ak_last_printed_date { get; set; }
        public string ak_collector_id { get; set; }
        public string ak_rep_id { get; set; }
        public string ak_verificator_id { get; set; }
        public string ak_area_code { get; set; }
        public string ak_kw_registered_by_collector { get; set; }
        public DateTime ak_kw_registration_entry_date { get; set; }
        public double ak_kw_registration_amount { get; set; }
        public string ak_kw_payment_type { get; set; }
        public string ak_kw_cheque_num { get; set; }
        public string ak_kw_card_type { get; set; }
        public string ak_kw_bank { get; set; }
        public DateTime ak_kw_cheque_due_date { get; set; }
        public string ak_kw_registered_by_chasier { get; set; }
        public double ak_kw_total_amount_registered { get; set; }
        public DateTime ak_kw_register_date { get; set; }
        public string ak_kw_register_by { get; set; }
        public string ak_kw_deposit_to_bank { get; set; }
        public double ak_kw_total_amount_deposit { get; set; }
        public string ak_kw_voucher_type { get; set; }
        public double ak_kw_voucher_number { get; set; }
        public string ak_kw_voucher_reference { get; set; }
        public DateTime ak_kw_voucher_date { get; set; }
        public string ak_incentive_processing_flag { get; set; }
        public string ak_period_month_processing { get; set; }
        public string ak_period_year_processing { get; set; }
        public string ak_previous_collector_assigned { get; set; }
        public DateTime ak_date_of_assignment_change { get; set; }
        public DateTime ak_date_of_last_plan_visit { get; set; }
        public string ak_flag_plan_visit { get; set; }
        public int ak_total_plan_visit { get; set; }
        public string ak_remark_plan { get; set; }
        public double ak_write_off_Amount { get; set; }
        public string ak_dlv_kw_flag { get; set; }
        public DateTime ak_dlv_kw_date { get; set; }
        public string ak_dlv_kw_id { get; set; }
    }
}
