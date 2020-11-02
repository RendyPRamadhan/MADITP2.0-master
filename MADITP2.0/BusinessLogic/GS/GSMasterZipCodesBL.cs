using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.businessLogic.GS
{
    class GSMasterZipCodesBL
    {
        private int id;
        private string zip_code;
        private string kelurahan;
        private string kecamatan;
        private int? city;
        private string area_code;
        private string sts_update;
        private int web_subdistrict_id;

        public string Zip_code { get => zip_code; set => zip_code = value; }
        public string Kelurahan { get => kelurahan; set => kelurahan = value; }
        public string Kecamatan { get => kecamatan; set => kecamatan = value; }
        public int? City { get => city; set => city = value; }
        public string Area_code { get => area_code; set => area_code = value; }
        public string Sts_update { get => sts_update; set => sts_update = value; }
        public int Web_subdistrict_id { get => web_subdistrict_id; set => web_subdistrict_id = value; }
        public int ID { get => id; set => id = value; }
    }
}
