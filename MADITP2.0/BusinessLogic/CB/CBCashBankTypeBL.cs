using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
   public class CBCashBankTypeBL
    {
        private string BANK_TYPE_ID;
        private string BANK_TYPE;
        private string ALLOW_MANUAL_TXN_ENTRY;
        private string ALLOW_AP;
        private string ALLOW_AR;

        private string LAST_UPDATE;
        private string USER_ID;


        public string bank_type_id { get => BANK_TYPE_ID; set => BANK_TYPE_ID = value; }
        public string bank_type { get => BANK_TYPE; set => BANK_TYPE = value; }
        public string allow_manual_txn_entry { get => ALLOW_MANUAL_TXN_ENTRY; set => ALLOW_MANUAL_TXN_ENTRY = value; }
        public string allow_ap { get => ALLOW_AP; set => ALLOW_AP = value; }
        public string allow_ar { get => ALLOW_AR; set => ALLOW_AR = value; }
        public string last_update { get => LAST_UPDATE; set => LAST_UPDATE = value; }
        public string user_id { get => USER_ID; set => USER_ID = value; }
    }
}
