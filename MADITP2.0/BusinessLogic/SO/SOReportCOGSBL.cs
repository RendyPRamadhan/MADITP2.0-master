using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    public class SOReportCOGSBL
    {
        private string PRINCIPAL;
        private string KODE_PRODUCT;
        private string PRODUCT;
        private string COGS;
        private string PERIODE;
        public string principal { get => PRINCIPAL; set => PRINCIPAL = value; }
        public string kode_product { get => KODE_PRODUCT; set => KODE_PRODUCT = value; }
        public string product { get => PRODUCT; set => PRODUCT = value; }
        public string cogs { get => COGS; set => COGS = value; }
        public string periode { get => PERIODE; set => PERIODE = value; }
    }
}
