using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    public class ARCreditLimitBL
    {
        private string CLH_PERIODE_YEAR;
        private string CLH_REP_ID;
        private string CLH_GROUP_PRODUCT;
        private string CREDITLIMIT;

        private string CLH_REP_BRANCH;
        private string CLH_TOTAL_SALES_Q4;
        private double CLH_CREDIT_LIMIT;
        private string CLH_TOTAL_CREDIT_USED;
        private string CLH_TOTAL_DEPOSITED;
        private string CLH_OUTSTANDING_DEPOSIT;
        private string RM_NAME;

        public string rep_branch { get => CLH_REP_BRANCH; set => CLH_REP_BRANCH = value; }
        public string rep_id { get => CLH_REP_ID; set => CLH_REP_ID = value; }
        public string rep_name { get => RM_NAME; set => RM_NAME = value; }
        public string division { get => CLH_GROUP_PRODUCT; set => CLH_GROUP_PRODUCT = value; }

        
        
        public string total_amount_q4 { get => CLH_TOTAL_SALES_Q4; set => CLH_TOTAL_SALES_Q4 = value; }
        public double credit_limit { get => CLH_CREDIT_LIMIT; set => CLH_CREDIT_LIMIT = value; }
        public string total_credit_used { get => CLH_TOTAL_CREDIT_USED; set => CLH_TOTAL_CREDIT_USED = value; }
        public string total_deposited { get => CLH_TOTAL_DEPOSITED; set => CLH_TOTAL_DEPOSITED = value; }
        public string available { get => CLH_OUTSTANDING_DEPOSIT; set => CLH_OUTSTANDING_DEPOSIT = value; }
        
        public string periode_year { get => CLH_PERIODE_YEAR; set => CLH_PERIODE_YEAR = value; }
        public string CreditLimit { get => CREDITLIMIT; set => CREDITLIMIT = value; }

    }
}
