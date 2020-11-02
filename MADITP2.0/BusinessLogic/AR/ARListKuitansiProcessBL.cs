using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    public class ARListKuitansiProcessBL
    {
        private string ec_entity;
        private string bc_branch;
        private string dc_division;
        private string ar_last_period_process;
        private string ar_current_period_process;
        private string ar_year_last;
        private string ar_year_current;

        public string entity { get => ec_entity; set => ec_entity = value; }
        public string branch { get => bc_branch; set => bc_branch = value; }
        public string division { get => dc_division; set => dc_division = value; }
        public string last_period_process { get => ar_last_period_process; set => ar_last_period_process = value; }
        public string current_period_process { get => ar_current_period_process; set => ar_current_period_process = value; }
        public string year_last { get => ar_year_last; set => ar_year_last = value; }
        public string year_current { get => ar_year_current; set => ar_year_current = value; }
    }
}
