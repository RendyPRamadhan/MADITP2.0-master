using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.businessLogic.RC
{
    class RCMasterLevelBL
    {
        private int lc_id;
        private string lc_division_id;
        private string lc_level_id;
        private string lc_level_description;
        private string lc_break_level;
        private string lc_status;
        private int lc_cwh_amount;
        private int lc_user_defined_1;
        private string lc_user_defined_2;
        private DateTime lc_date_created;
        private DateTime lc_last_date_update;
        private string lc_user_id;
        private string lc_q_achievement_type;
        private Double lc_q_total_su;
        private int lc_q_total_set;
        private int lc_q_total_sales_value;
        private int lc_q_total_pv;
        private int lc_q_total_bv;
        private int lc_q_total_member_recruited;
        private int lc_q_total_direct_member;
        private int lc_q_total_new_customer;
        private int lc_q_total_point_1;
        private int lc_q_total_point_2;
        private int lc_q_within_length_of_period;
        private int lc_q_min_achievement_per_month;
        private string lc_q_certificate_hold;
        private string lc_m_achievement_type;
        private Double lc_m_total_su;
        private int lc_m_total_set;
        private int lc_m_total_sales_value;
        private int lc_m_total_pv;
        private int lc_m_total_bv;
        private int lc_m_total_member_recruited;
        private int lc_m_total_direct_member;
        private int lc_m_total_new_customers;
        private int lc_m_total_point_1;
        private int lc_m_total_point_2;
        private int lc_m_within_length_of_period;
        private int lc_m_min_achievement_per_month;
        private string lc_m_default_candidates_flag;
        private int lc_q_period_recruit;
        private int lc_m_period_recruit;

        public string Lc_division_id { get => lc_division_id; set => lc_division_id = value; }
        public string Lc_level_id { get => lc_level_id; set => lc_level_id = value; }
        public string Lc_level_description { get => lc_level_description; set => lc_level_description = value; }
        public string Lc_break_level { get => lc_break_level; set => lc_break_level = value; }
        public string Lc_status { get => lc_status; set => lc_status = value; }
        public int Lc_cwh_amount { get => lc_cwh_amount; set => lc_cwh_amount = value; }
        public int Lc_user_defined_1 { get => lc_user_defined_1; set => lc_user_defined_1 = value; }
        public string Lc_user_defined_2 { get => lc_user_defined_2; set => lc_user_defined_2 = value; }
        public DateTime Lc_date_created { get => lc_date_created; set => lc_date_created = value; }
        public DateTime Lc_last_date_update { get => lc_last_date_update; set => lc_last_date_update = value; }
        public string Lc_user_id { get => lc_user_id; set => lc_user_id = value; }
        public string Lc_q_achievement_type { get => lc_q_achievement_type; set => lc_q_achievement_type = value; }
        public double Lc_q_total_su { get => lc_q_total_su; set => lc_q_total_su = value; }
        public int Lc_q_total_set { get => lc_q_total_set; set => lc_q_total_set = value; }
        public int Lc_q_total_sales_value { get => lc_q_total_sales_value; set => lc_q_total_sales_value = value; }
        public int Lc_q_total_pv { get => lc_q_total_pv; set => lc_q_total_pv = value; }
        public int Lc_q_total_bv { get => lc_q_total_bv; set => lc_q_total_bv = value; }
        public int Lc_q_total_member_recruited { get => lc_q_total_member_recruited; set => lc_q_total_member_recruited = value; }
        public int Lc_q_total_direct_member { get => lc_q_total_direct_member; set => lc_q_total_direct_member = value; }
        public int Lc_q_total_new_customer { get => lc_q_total_new_customer; set => lc_q_total_new_customer = value; }
        public int Lc_q_total_point_1 { get => lc_q_total_point_1; set => lc_q_total_point_1 = value; }
        public int Lc_q_total_point_2 { get => lc_q_total_point_2; set => lc_q_total_point_2 = value; }
        public int Lc_q_within_length_of_period { get => lc_q_within_length_of_period; set => lc_q_within_length_of_period = value; }
        public int Lc_q_min_achievement_per_month { get => lc_q_min_achievement_per_month; set => lc_q_min_achievement_per_month = value; }
        public string Lc_q_certificate_hold { get => lc_q_certificate_hold; set => lc_q_certificate_hold = value; }
        public string Lc_m_achievement_type { get => lc_m_achievement_type; set => lc_m_achievement_type = value; }
        public double Lc_m_total_su { get => lc_m_total_su; set => lc_m_total_su = value; }
        public int Lc_m_total_set { get => lc_m_total_set; set => lc_m_total_set = value; }
        public int Lc_m_total_sales_value { get => lc_m_total_sales_value; set => lc_m_total_sales_value = value; }
        public int Lc_m_total_pv { get => lc_m_total_pv; set => lc_m_total_pv = value; }
        public int Lc_m_total_bv { get => lc_m_total_bv; set => lc_m_total_bv = value; }
        public int Lc_m_total_member_recruited { get => lc_m_total_member_recruited; set => lc_m_total_member_recruited = value; }
        public int Lc_m_total_direct_member { get => lc_m_total_direct_member; set => lc_m_total_direct_member = value; }
        public int Lc_m_total_new_customers { get => lc_m_total_new_customers; set => lc_m_total_new_customers = value; }
        public int Lc_m_total_point_1 { get => lc_m_total_point_1; set => lc_m_total_point_1 = value; }
        public int Lc_m_total_point_2 { get => lc_m_total_point_2; set => lc_m_total_point_2 = value; }
        public int Lc_m_within_length_of_period { get => lc_m_within_length_of_period; set => lc_m_within_length_of_period = value; }
        public int Lc_m_min_achievement_per_month { get => lc_m_min_achievement_per_month; set => lc_m_min_achievement_per_month = value; }
        public string Lc_m_default_candidates_flag { get => lc_m_default_candidates_flag; set => lc_m_default_candidates_flag = value; }
        public int Lc_q_period_recruit { get => lc_q_period_recruit; set => lc_q_period_recruit = value; }
        public int Lc_m_period_recruit { get => lc_m_period_recruit; set => lc_m_period_recruit = value; }
        public int Lc_id { get => lc_id; set => lc_id = value; }
    }
}
