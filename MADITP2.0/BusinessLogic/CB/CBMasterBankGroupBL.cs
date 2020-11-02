using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    public class CBMasterBankGroupBL
    {
        private string GROUP_ID;
        private string GROUP;
        private string USER_DEFINE1;
        private string USER_DEFINE2;
        private string LAST_UPDATE;
        private string USER_ID;
        public string group_id { get => GROUP_ID; set => GROUP_ID = value; }
        public string groups { get => GROUP; set => GROUP = value; }
        public string user_define1 { get => USER_DEFINE1; set => USER_DEFINE1 = value; }
        public string user_define2 { get => USER_DEFINE2; set => USER_DEFINE2 = value; }
        public string last_update { get => LAST_UPDATE; set => LAST_UPDATE = value; }
        public string user_id { get => USER_ID; set => USER_ID = value; }
   
    }
}
