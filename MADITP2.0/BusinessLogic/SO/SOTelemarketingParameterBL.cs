using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    public class SOTelemarketingParameterBL
    {
        private string ctm_id;
        private string ctm_parameter_code;
        private string ctm_parameter_id;
        private string ctm_parameter_category;
        private string ctm_parameter_desc;
        private string ctm_parameter_drop;
        private DateTime ctm_create_date;
        private string ctm_create_by;
        private string ctm_parameter_desc_pfx;

        public string id { get => ctm_id; set => ctm_id = value; }
        public string parameter_code { get => ctm_parameter_code; set => ctm_parameter_code = value; }
        public string parameter_id { get => ctm_parameter_id; set => ctm_parameter_id = value; }
        public string parameter_category { get => ctm_parameter_category; set => ctm_parameter_category = value; }
        public string parameter_desc { get => ctm_parameter_desc; set => ctm_parameter_desc = value; }
        public string parameter_drop { get => ctm_parameter_drop; set => ctm_parameter_drop = value; }
        public DateTime create_date { get => ctm_create_date; set => ctm_create_date = value; }
        public string create_by { get => ctm_create_by; set => ctm_create_by = value; }
        public string parameter_desc_pfx { get => ctm_parameter_desc_pfx; set => ctm_parameter_desc_pfx = value; }
    }
}
