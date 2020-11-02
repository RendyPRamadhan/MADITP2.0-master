using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.businessLogic.SO
{
    class SOVerificatorMasterBL
    {
        public string entity_id { get; set; }

        public string branch_id { get; set; }

        public string division_id { get; set; }

        public string verificator_id { get; set; }

        public string verificator_name { get; set; }

        public string short_name { get; set; }

        public string nik_num { get; set; }

        public string verificator_level { get; set; }

        public double max_value_for_verification { get; set; }

        public double max_num_of_kp { get; set; }

        public string default_area_id { get; set; }

        public string supervisor_id { get; set; }

        public DateTime entry_date { get; set; }

        public string user_id { get; set; }

        public string active_flag { get; set; }

    }
}
