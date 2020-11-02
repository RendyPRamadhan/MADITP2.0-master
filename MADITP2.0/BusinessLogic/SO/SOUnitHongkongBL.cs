using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
   public class SOUnitHongkongBL
    {
        private string HKS_DIVISION_ID;
        private string HKS_PRODUCT_ID;
        private Double HKS_BUKU;
        public string division_id { get => HKS_DIVISION_ID; set => HKS_DIVISION_ID = value; }
        public string product_id { get => HKS_PRODUCT_ID; set => HKS_PRODUCT_ID = value; }
        public Double buku { get => HKS_BUKU; set => HKS_BUKU = value; }
    }
}
