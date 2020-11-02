using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
   public class SOMasterSubBrand1BL
    {
        private string Brand_id;
        private string BRAND;
        private string SubBrand_id;
        private string Description;

        public string brand { get => BRAND; set => BRAND = value; }
        public string subbrand1_id { get => SubBrand_id; set => SubBrand_id = value; }
        public string subbrand1_description { get => Description; set => Description = value; }
        public string brand_id { get => Brand_id; set => Brand_id = value; }
    }
}
