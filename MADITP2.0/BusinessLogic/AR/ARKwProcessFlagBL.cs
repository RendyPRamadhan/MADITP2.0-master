using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    public class ARKwProcessFlagBL
    {
        private string kpf_entity;
        private string kpf_branch;
        private string kpf_division;
        private string Last_period_process;
        private string Current_period_process;
        private int Year_last;
        private int Year_current;
        private string kw_flag_process;

        public string entity { get => kpf_entity; set => kpf_entity = value; }
        public string branch { get => kpf_branch; set => kpf_branch = value; }
        public string division { get => kpf_division; set => kpf_division = value; }
        public string last_period_process { get => Last_period_process; set => Last_period_process = value; }
        public string current_period_process { get => Current_period_process; set => Current_period_process = value; }
        public int year_last { get => Year_last; set => Year_last = value; }
        public int year_current { get => Year_current; set => Year_current = value; }
        public string flag_process { get => kw_flag_process; set => kw_flag_process = value; }
    }
}
