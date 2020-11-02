using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    class CBARCollectionDepositEntryVoucherDistTxnBL
    {
        public string cbv_bank_id { get; set; }
        public string cbv_sub_bank_id { get; set; }
        public string cbv_voucher_type { get; set; }
        public double cbv_seq_no { get; set; }
        public double cbv_index_no { get; set; }
        public string cbv_bank_txn_type { get; set; }
        public string cbv_voucher_ref { get; set; }
        public string cbv_receipt_paid_codes { get; set; }
        public string cbv_receipt_paid_to_name { get; set; }
        public string cbv_entity { get; set; }
        public string cbv_branch { get; set; }
        public string cbv_division { get; set; }
        public string cbv_department { get; set; }
        public string cbv_major1 { get; set; }
        public string cbv_major2 { get; set; }
        public string cbv_minor { get; set; }
        public string cbv_analysis { get; set; }
        public string cbv_filler { get; set; }
        public string cbv_add_book_id { get; set; }
        public string cbv_txn_description { get; set; }
        public string cbv_txn_dr_cr { get; set; }
        public DateTime cbv_txn_date { get; set; }
        public Double cbv_txn_base_ammount { get; set; }
        public DateTime cbv_entry_date { get; set; }
        public string cbv_gl_interface_status { get; set; }
        public DateTime cbv_gl_effective_date { get; set; }
        public int cbv_gl_fiscal_period { get; set; } 
        public string cbv_gl_fiscal_year { get; set; }
        public string cbv_gl_batch_id { get; set; }
        public string cbv_gl_journal_id { get; set; }
        public int cbv_gl_journal_index { get; set; }
        public string cbv_gl_batch_source { get; set; }
        public string cbv_gl_journal_type { get; set; }
        public DateTime cbv_date_interfaced { get; set; }
        public string cbv_interfaced_user { get; set; }
        public string cbv_cash_id { get; set; }
        public string cbv_upload_flag { get; set; }
        public DateTime cbv_upload_date { get; set; }
        public DateTime cbv_period_week_from { get; set; }
        public DateTime cbv_period_week_to { get; set; }
    }
}
