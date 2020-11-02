using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    public class ARMasterCollectorBL
    {
        private string COLLECTOR_ID;
        private string COLLECTOR_NAME;
        private string COLLECTOR_ACTIVE_FLAG;
        private string DEFAULT_AREA_CODE;
        private string AREA_;
        private string COLLECTOR_LEVEL;

        private string GROUP_HEAD_ID;
        private string GROUPHEADNAME_;
        private string BANK_NAME;
        private string BANK_ACCOUNT_NUMBER;
        private string INCENTIVE_AMOUNT_KW1;
        private string INCENTIVE_AMOUNT_KW2;
        private string INCENTIVE_AMOUNT_KW3;
        private string PENALTY_AMOUNT_KW;
        private string REMARKS;
        private string ENTITY_ID;
        private string BRANCH_ID;
        private string DIVISION_ID;

        public string collector_id { get => COLLECTOR_ID; set => COLLECTOR_ID = value; }
        public string collector_name { get => COLLECTOR_NAME; set => COLLECTOR_NAME = value; }
        public string entity_id { get => ENTITY_ID; set => ENTITY_ID = value; }
        public string branch_id { get => BRANCH_ID; set => BRANCH_ID = value; }
        public string division_id { get => DIVISION_ID; set => DIVISION_ID = value; }


        public string collector_active_flag { get => COLLECTOR_ACTIVE_FLAG; set => COLLECTOR_ACTIVE_FLAG = value; }
        public string default_area_code { get => DEFAULT_AREA_CODE; set => DEFAULT_AREA_CODE = value; }
        
        public string collector_level { get => COLLECTOR_LEVEL; set => COLLECTOR_LEVEL = value; }
        public string group_head_id { get => GROUP_HEAD_ID; set => GROUP_HEAD_ID = value; }
        
        public string bank_name { get => BANK_NAME; set => BANK_NAME = value; }
        public string bank_account_number { get => BANK_ACCOUNT_NUMBER; set => BANK_ACCOUNT_NUMBER = value; }
        public string remarks { get => REMARKS; set => REMARKS = value; }
        public string incentive_amount_kw1 { get => INCENTIVE_AMOUNT_KW1; set => INCENTIVE_AMOUNT_KW1 = value; }
        public string incentive_amount_kw2 { get => INCENTIVE_AMOUNT_KW2; set => INCENTIVE_AMOUNT_KW2 = value; }

       
        public string penalty_amount_kw { get => PENALTY_AMOUNT_KW; set => PENALTY_AMOUNT_KW = value; }
        public string incentive_amount_kw3 { get => INCENTIVE_AMOUNT_KW3; set => INCENTIVE_AMOUNT_KW3 = value; }

        public string Area { get => AREA_; set => AREA_ = value; }
        public string GroupHeadName { get => GROUPHEADNAME_; set => GROUPHEADNAME_ = value; }

        
    }
}
