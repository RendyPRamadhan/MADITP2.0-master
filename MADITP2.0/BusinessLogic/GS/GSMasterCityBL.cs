using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.businessLogic.GS
{
    class GSMasterCityBL
    {
        private int cc_city_id;
        private string cc_city;
        private string cc_province;
        private string cc_kodya_kabupaten;
        private string cc_wh_otc;
        private string cc_survey;
        private string cc_latitude;
        private string cc_longitude;
        private string cc_city_merge;

        public int City_id { get => cc_city_id; set => cc_city_id = value; }
        public string City { get => cc_city; set => cc_city = value; }
        public string Province { get => cc_province; set => cc_province = value; }
        public string Kodya_kabupaten { get => cc_kodya_kabupaten; set => cc_kodya_kabupaten = value; }
        public string Wh_otc { get => cc_wh_otc; set => cc_wh_otc = value; }
        public string Survey { get => cc_survey; set => cc_survey = value; }
        public string Latitude { get => cc_latitude; set => cc_latitude = value; }
        public string Longitude { get => cc_longitude; set => cc_longitude = value; }
        public string City_merge { get => cc_city_merge; set => cc_city_merge = value; }
    }
}
