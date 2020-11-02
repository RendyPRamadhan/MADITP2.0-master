using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    public class CBGeneralParameterBL
    {
        private string GP_ENTITY_ID;
        private string DESCRIPTION;
        private string GP_BATCH_SOURCE;
        private string GP_CASHCODE_CASH_SALES;
        private string GP_CASHCODE_COLLECTION;
        private string GP_CASHCODE_DP_UANGMUKA;
        private string GP_CASHCODE_TRANSFER;

        private string GP_CASHCODE_OTHES;
        private string GP_CASHCODE_MPAYABLE_IMPORT;
        private string GP_CASHCODE_MPAYABLE_LOCAL;
        private string GP_CASHCODE_FASSET_PAYABLE;
        private string GP_CASHCODE_AP_NON_TRADE;
        private string GP_CASHCODE_SALES_COMMISSION;
        private string GP_CASHCODE_INCENTIVE_COLLECTOR;

        public string entity_id { get => GP_ENTITY_ID; set => GP_ENTITY_ID = value; }
        public string Entity { get => DESCRIPTION; set => DESCRIPTION = value; }
        public string batch_source { get => GP_BATCH_SOURCE; set => GP_BATCH_SOURCE = value; }
        public string cash_sales { get => GP_CASHCODE_CASH_SALES; set => GP_CASHCODE_CASH_SALES = value; }
        public string collection { get => GP_CASHCODE_COLLECTION; set => GP_CASHCODE_COLLECTION = value; }
        public string dp_uangmuka { get => GP_CASHCODE_DP_UANGMUKA; set => GP_CASHCODE_DP_UANGMUKA = value; }
        public string transfer { get => GP_CASHCODE_TRANSFER; set => GP_CASHCODE_TRANSFER = value; }

        public string others { get => GP_CASHCODE_OTHES; set => GP_CASHCODE_OTHES = value; }
        public string mpayable_import { get => GP_CASHCODE_MPAYABLE_IMPORT; set => GP_CASHCODE_MPAYABLE_IMPORT = value; }
        public string mpayable_local { get => GP_CASHCODE_MPAYABLE_LOCAL; set => GP_CASHCODE_MPAYABLE_LOCAL = value; }
        public string fasset_payable { get => GP_CASHCODE_FASSET_PAYABLE; set => GP_CASHCODE_FASSET_PAYABLE = value; }
        public string ap_non_trade { get => GP_CASHCODE_AP_NON_TRADE; set => GP_CASHCODE_AP_NON_TRADE = value; }
        public string sales_commission { get => GP_CASHCODE_SALES_COMMISSION; set => GP_CASHCODE_SALES_COMMISSION = value; }
        public string incentive_collector { get => GP_CASHCODE_INCENTIVE_COLLECTOR; set => GP_CASHCODE_INCENTIVE_COLLECTOR = value; }
    }
}
