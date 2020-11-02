using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    public class CBMasterCurrencyCodeBL
    {
        private string CURRENCY_CODE;
        private string CURRENCY;
        private string CURRENCY_TYPE;
        private double UPP_RATE_TO_HOME;
        private double LOW_RATE_TO_HOME;
        private double MDL_RATE_TO_HOME;
        private string REMARKS;
        private string LAST_RATE_UPDATE;
        private string RATE_UPDATE_BY;
        private string CREATION_DATE;
        private string CREATE_BY;
        private Int32 ISSUCCESS;


        public string currency_code { get => CURRENCY_CODE; set => CURRENCY_CODE = value; }
        public string currency { get => CURRENCY; set => CURRENCY = value; }
        public string currency_type { get => CURRENCY_TYPE; set => CURRENCY_TYPE = value; }
        public double upp_rate_to_home { get => UPP_RATE_TO_HOME; set => UPP_RATE_TO_HOME = value; }
        public double low_rate_to_home { get => LOW_RATE_TO_HOME; set => LOW_RATE_TO_HOME = value; }
        public double mdl_rate_to_home { get => MDL_RATE_TO_HOME; set => MDL_RATE_TO_HOME = value; }

        public string rate_update_by { get => RATE_UPDATE_BY; set => RATE_UPDATE_BY = value; }
        public string creation_date { get => CREATION_DATE; set => CREATION_DATE = value; }
        public string create_by { get => CREATE_BY; set => CREATE_BY = value; }

        public string remarks { get => REMARKS; set => REMARKS = value; }
        public string last_rate_update { get => LAST_RATE_UPDATE; set => LAST_RATE_UPDATE = value; }
        public Int32 issuccess { get => ISSUCCESS; set => ISSUCCESS = value; }

    }
}
