using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    public class CBMasterCashCodeBL
    {
        private Int32 CB_REPORT_SEQUENCE_NUMBER;
        private string CB_CASH_ID;
        private string CB_DESCRIPTION;
        private string CB_CODE_TYPE;
        private string CB_USER_DEFINE;
        private string CB_LAST_UPDATE;
        private string CB_USER_ID;
        

        
        public string cash_id { get => CB_CASH_ID; set => CB_CASH_ID = value; }
        public string description { get => CB_DESCRIPTION; set => CB_DESCRIPTION = value; }
        public string code_type { get => CB_CODE_TYPE; set => CB_CODE_TYPE = value; }
        public Int32 sequence_number { get => CB_REPORT_SEQUENCE_NUMBER; set => CB_REPORT_SEQUENCE_NUMBER = value; }
        public string user_define { get => CB_USER_DEFINE; set => CB_USER_DEFINE = value; }
        public string last_update { get => CB_LAST_UPDATE; set => CB_LAST_UPDATE = value; }

        public string user_id { get => CB_USER_ID; set => CB_USER_ID = value; }

       
    }
}
