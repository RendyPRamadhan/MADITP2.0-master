using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    class CBARCollectionDepositEntryVoucherTxnBL
    {
        public string vt_bank_id { get; set; }
        public string vt_bank_sub_id { get; set; }
        public string vt_voucher_type { get; set; }
        public double vt_voucher_seq { get; set; }
        public string vt_bank_txn_type { get; set; }
        public string vt_voucher_ref { get; set; }
        public string vt_receipt_paid_code { get; set; }
        public string vt_receipt_paid_to_name { get; set; }
        public string vt_txn_description { get; set; }
        public string vt_bank_account_number { get; set; }
        public DateTime vt_txn_date { get; set; }
        public string vt_gl_entity { get; set; } 
        public string vt_gl_branch { get; set; }
        public string vt_gl_division { get; set; }
        public string vt_gl_department { get; set; }
        public string vt_gl_major1 { get; set; }
        public string vt_gl_major2 { get; set; }
        public string vt_gl_minor { get; set; }
        public string vt_gl_analysis { get; set; }
        public string vt_gl_filler { get; set; }
        public string vt_cheque_giro_number { get; set; }
        public string vt_cheque_giro_reference { get; set; }
        public DateTime vt_cheque_giro_date { get; set; }
        public string vt_original_cheque_currency { get; set; }
        public double vt_original_cheque_amount { get; set; }
        public double vt_current_rate { get; set; }
        public double vt_txn_base_amount { get; set; }
        public string vt_cash_code { get; set; }
        public double vt_no_of_distribution_line { get; set; }
        public DateTime vt_entry_date { get; set; }
        public string vt_user_id { get; set; }
        public double vt_voided_voucher_id { get; set; }
        public DateTime vt_date_voided { get; set; }
        public string vt_voided_by { get; set; }
        public string vt_gl_interface_status { get; set; }
        public DateTime vt_gl_effective_date { get; set; }
        public string vt_gl_fiscal_period { get; set; }
        public string vt_gl_fiscal_year { get; set; }
        public string vt_gl_batch_id { get; set; }
        public string vt_gl_journal_id { get; set; }
        public string vt_gl_batch_source { get; set; }
        public string vt_gl_journal_type { get; set; }
        public DateTime vt_date_interface { get; set; }
        public string vt_interfaced_by { get; set; }
        public double vt_settlement_seq { get; set; }
    }
}
