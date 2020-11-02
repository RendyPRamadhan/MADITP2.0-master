using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    public class ARReprintSlipKuitansiProcessBL
    {
        private bool Is_selected;
        private string Ak_collector_id;
        private string Cm_collector_name;
        private string Scm_customer_name;
        private string Scm_address1;
        private string Scm_address2;
        private string Scm_address3;
        private string Scm_home_phone_num;
        private string Ak_so_number;
        private string Ak_item_number;
        private string Ak_seq_number;
        private string Ai_number_of_instalments;
        private string Ak_outstanding_amount;
        private string Outstanding_amount_terbilang;
        private string Sih_invoice_desc;
        private DateTime Ak_kw_date;
        private DateTime Ak_kw_visit_date;
        private string Ak_kw_printed_flag;
        private string Ak_num_of_kw_printed;
        private string Ak_processing_date_from;
        private string Ak_processing_date_to;
        private string Rm_name;
        private string Bc_address;
        private string Bc_email;
        private string Bc_phone;
        private string Bc_fax;
        private string Ak_entity_id;
        private string Ak_branch_id;
        private string Ak_division_id;
        private string Rm_rep_id;
        private string Sih_so_invoice_date;
        private string Scm_employer_phone;
        private string Scm_customer_id;
        private string Scm_billing_address_code;
        private string Bc_remark;
        private string Customer_group;
        private string Telp;

        public bool is_selected { get => Is_selected; set => Is_selected = value; }
        public string ak_collector_id { get => Ak_collector_id; set => Ak_collector_id = value; }
        public string cm_collector_name { get => Cm_collector_name; set => Cm_collector_name = value; }
        public string scm_customer_name { get => Scm_customer_name; set => Scm_customer_name = value; }
        public string scm_address1 { get => Scm_address1; set => Scm_address1 = value; }
        public string scm_address2 { get => Scm_address2; set => Scm_address2 = value; }
        public string scm_address3 { get => Scm_address3; set => Scm_address3 = value; }
        public string scm_home_phone_num { get => Scm_home_phone_num; set => Scm_home_phone_num = value; }
        public string ak_so_number { get => Ak_so_number; set => Ak_so_number = value; }
        public string ak_item_number { get => Ak_item_number; set => Ak_item_number = value; }
        public string ak_seq_number { get => Ak_seq_number; set => Ak_seq_number = value; }
        public string ai_number_of_instalments { get => Ai_number_of_instalments; set => Ai_number_of_instalments = value; }
        public string ak_outstanding_amount { get => Ak_outstanding_amount; set => Ak_outstanding_amount = value; }
        public string outstanding_amount_terbilang { get => Outstanding_amount_terbilang; set => Outstanding_amount_terbilang = value; }
        public string sih_invoice_desc { get => Sih_invoice_desc; set => Sih_invoice_desc = value; }
        public DateTime ak_kw_date { get => Ak_kw_date; set => Ak_kw_date = value; }
        public DateTime ak_kw_visit_date { get => Ak_kw_visit_date; set => Ak_kw_visit_date = value; }
        public string ak_kw_printed_flag { get => Ak_kw_printed_flag; set => Ak_kw_printed_flag = value; }
        public string ak_num_of_kw_printed { get => Ak_num_of_kw_printed; set => Ak_num_of_kw_printed = value; }
        public string ak_processing_date_from { get => Ak_processing_date_from; set => Ak_processing_date_from = value; }
        public string ak_processing_date_to { get => Ak_processing_date_to; set => Ak_processing_date_to = value; }
        public string rm_name { get => Rm_name; set => Rm_name = value; }
        public string bc_address { get => Bc_address; set => Bc_address = value; }
        public string bc_email { get => Bc_email; set => Bc_email = value; }
        public string bc_phone { get => Bc_phone; set => Bc_phone = value; }
        public string bc_fax { get => Bc_fax; set => Bc_fax = value; }
        public string ak_entity_id { get => Ak_entity_id; set => Ak_entity_id = value; }
        public string ak_branch_id { get => Ak_branch_id; set => Ak_branch_id = value; }
        public string ak_division_id { get => Ak_division_id; set => Ak_division_id = value; }
        public string rm_rep_id { get => Rm_rep_id; set => Rm_rep_id = value; }
        public string sih_so_invoice_date { get => Sih_so_invoice_date; set => Sih_so_invoice_date = value; }
        public string scm_employer_phone { get => Scm_employer_phone; set => Scm_employer_phone = value; }
        public string scm_customer_id { get => Scm_customer_id; set => Scm_customer_id = value; }
        public string scm_billing_address_code { get => Scm_billing_address_code; set => Scm_billing_address_code = value; }
        public string bc_remark { get => Bc_remark; set => Bc_remark = value; }
        public string customer_group { get => Customer_group; set => Customer_group = value; }
        public string telp { get => Telp; set => Telp = value; }
    }
}
