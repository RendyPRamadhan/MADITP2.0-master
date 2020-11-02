using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    public class ARTdkTerprosesKwBL
    {
        private string ai_so_number;
        private string ai_item_number;
        private string ai_seq_number;
        private string ai_customer_id;
        private string ai_entity_id;
        private string ai_branch_id;
        private string ai_division_id;
        private string ai_item_description;
        private string ai_invoice_header_flag;
        private string ai_artxn_type;
        private string ai_txn_date;
        private string ai_term_of_payment;
        private string ai_date_of_visit;
        private string ai_date_of_due;
        private string ai_due_date;
        private string ai_original_invoice_amount;
        private string ai_dp_amount;
        private string ai_cod_amount;
        private string ai_item_amount;
        private string ai_total_amount_in_kw;
        private string ai_total_amount_paid;
        private string ai_outstanding_amount;
        private string ai_number_of_instalments;
        private string ai_last_kw_generated_number;
        private string ai_last_kw_generated_date;
        private string ai_billing_date;
        private string ai_period_start_of_instal;
        private string ai_year_start_of_instal;
        private string ai_instal_amount_per_month;
        private string ai_instal_payment_type;
        private string ai_instal_card_type;
        private string ai_instal_bank;
        private string ai_collector_id;
        private string ai_rep_id;
        private string ai_area_code;
        private string ai_verifikator_id;
        private int Seq;
        private string Alasan;
        private string svs_dateofbilling;

        public string so_number { get => ai_so_number; set => ai_so_number = value; }
        public string item_number { get => ai_item_number; set => ai_item_number = value; }
        public string seq_number { get => ai_seq_number; set => ai_seq_number = value; }
        public string customer_id { get => ai_customer_id; set => ai_customer_id = value; }
        public string entity_id { get => ai_entity_id; set => ai_entity_id = value; }
        public string branch_id { get => ai_branch_id; set => ai_branch_id = value; }
        public string division_id { get => ai_division_id; set => ai_division_id = value; }
        public string item_description { get => ai_item_description; set => ai_item_description = value; }
        public string invoice_header_flag { get => ai_invoice_header_flag; set => ai_invoice_header_flag = value; }
        public string artxn_type { get => ai_artxn_type; set => ai_artxn_type = value; }
        public string txn_date { get => ai_txn_date; set => ai_txn_date = value; }
        public string term_of_payment { get => ai_term_of_payment; set => ai_term_of_payment = value; }
        public string date_of_visit { get => ai_date_of_visit; set => ai_date_of_visit = value; }
        public string date_of_due { get => ai_date_of_due; set => ai_date_of_due = value; }
        public string due_date { get => ai_due_date; set => ai_due_date = value; }
        public string original_invoice_amount { get => ai_original_invoice_amount; set => ai_original_invoice_amount = value; }
        public string dp_amount { get => ai_dp_amount; set => ai_dp_amount = value; }
        public string cod_amount { get => ai_cod_amount; set => ai_cod_amount = value; }
        public string item_amount { get => ai_item_amount; set => ai_item_amount = value; }
        public string total_amount_in_kw { get => ai_total_amount_in_kw; set => ai_total_amount_in_kw = value; }
        public string total_amount_paid { get => ai_total_amount_paid; set => ai_total_amount_paid = value; }
        public string outstanding_amount { get => ai_outstanding_amount; set => ai_outstanding_amount = value; }
        public string number_of_instalments { get => ai_number_of_instalments; set => ai_number_of_instalments = value; }
        public string last_kw_generated_number { get => ai_last_kw_generated_number; set => ai_last_kw_generated_number = value; }
        public string last_kw_generated_date { get => ai_last_kw_generated_date; set => ai_last_kw_generated_date = value; }
        public string billing_date { get => ai_billing_date; set => ai_billing_date = value; }
        public string period_start_of_instal { get => ai_period_start_of_instal; set => ai_period_start_of_instal = value; }
        public string year_start_of_instal { get => ai_year_start_of_instal; set => ai_year_start_of_instal = value; }
        public string instal_amount_per_month { get => ai_instal_amount_per_month; set => ai_instal_amount_per_month = value; }
        public string instal_payment_type { get => ai_instal_payment_type; set => ai_instal_payment_type = value; }
        public string instal_card_type { get => ai_instal_card_type; set => ai_instal_card_type = value; }
        public string instal_bank { get => ai_instal_bank; set => ai_instal_bank = value; }
        public string collector_id { get => ai_collector_id; set => ai_collector_id = value; }
        public string rep_id { get => ai_rep_id; set => ai_rep_id = value; }
        public string area_code { get => ai_area_code; set => ai_area_code = value; }
        public string verifikator_id { get => ai_verifikator_id; set => ai_verifikator_id = value; }
        public int seq { get => Seq; set => Seq = value; }
        public string alasan { get => Alasan; set => Alasan = value; }
        public string dateofbilling { get => svs_dateofbilling; set => svs_dateofbilling = value; }
    }
}
