using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    public class SOTelemarketingQuestionMasterBL
    {
        private string tqm_id;
        private string tqm_question_segment;
        private string tqm_question_code;
        private string tqm_question_type;
        private string tqm_question_id;
        private int tqm_question_no;
        private string tqm_question_desc;
        private string tqm_question_item;
        private string tqm_question_flag;
        private DateTime tqm_create_date;
        private string tqm_create_by;

        public string id { get => tqm_id; set => tqm_id = value; }
        public string question_segment { get => tqm_question_segment; set => tqm_question_segment = value; }
        public string question_code { get => tqm_question_code; set => tqm_question_code = value; }
        public string question_type { get => tqm_question_type; set => tqm_question_type = value; }
        public string question_id { get => tqm_question_id; set => tqm_question_id = value; }
        public int question_no { get => tqm_question_no; set => tqm_question_no = value; }
        public string question_desc { get => tqm_question_desc; set => tqm_question_desc = value; }
        public string question_item { get => tqm_question_item; set => tqm_question_item = value; }
        public string question_flag { get => tqm_question_flag; set => tqm_question_flag = value; }
        public DateTime create_date { get => tqm_create_date; set => tqm_create_date = value; }
        public string create_by { get => tqm_create_by; set => tqm_create_by = value; }
    }
}
