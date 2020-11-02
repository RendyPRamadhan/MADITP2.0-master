using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
   public class CBVoucherTypeBL
    {
        private string VOUCHER_TYPE_ID;
        private string DESCRIPTION;
        private string TXN_TYPE;
        private string ALLOW_MANUAL_TXN_ENTRY;
        private string AP_PAY;

        private string AR_RECEIPT;
        private string LAST_UPDATE;
        private string USER_ID;


        public string voucher_type_id { get => VOUCHER_TYPE_ID; set => VOUCHER_TYPE_ID = value; }
        public string description { get => DESCRIPTION; set => DESCRIPTION = value; }
        public string txn_type { get => TXN_TYPE; set => TXN_TYPE = value; }
        public string allow_manual_txn_entry { get => ALLOW_MANUAL_TXN_ENTRY; set => ALLOW_MANUAL_TXN_ENTRY = value; }
        public string ap_pay { get => AP_PAY; set => AP_PAY = value; }
        public string ar_receipt { get => AR_RECEIPT; set => AR_RECEIPT = value; }
        public string last_update { get => LAST_UPDATE; set => LAST_UPDATE = value; }
        public string user_id { get => USER_ID; set => USER_ID = value; }
    }
}
