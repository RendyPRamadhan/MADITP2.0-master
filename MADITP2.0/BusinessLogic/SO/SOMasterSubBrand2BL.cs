using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    public class SOMasterSubBrand2BL
    {
        private string Brand_id;
        private string SubBrand_id1;
        private string SubBrand_id2;
        private string Description;
        private string BRAND;
        private string SUBBRAND1;

        public string brand { get => Brand_id; set => Brand_id = value; }
        public string subbrand1 { get => Brand_id; set => Brand_id = value; }

        public string subbrand2_id { get => SubBrand_id2; set => SubBrand_id2 = value; }
        public string subbrand2_description { get => Description; set => Description = value; }
        public string brand_id { get => Brand_id; set => Brand_id = value; }
        public string subbrand1_id { get => SubBrand_id1; set => SubBrand_id1 = value; }

    }
}
