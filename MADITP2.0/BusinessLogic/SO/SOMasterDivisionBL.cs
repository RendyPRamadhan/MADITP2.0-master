using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOMasterDivisionBL
    {
        private int division_id;
        private string division_code;
        private string division_name;
        private string division_account;
        private string division_rpt_desc;
        private string division_flag_cek_lunas_ontime;
        private int division_syarat_min_su;
        private int division_pembagi_value;
        private int division_tipe_komisi_cash;
        private int division_tipe_komisi_credit;
        private int division_auto_proces_kp;
        private DateTime division_auto_process_kp_date;
        private string divison_sap_code;
        private DateTime division_created_at;
        private DateTime division_updated_at;


        public int Division_id { get => division_id; set => division_id = value; }
        public string Division_code { get => division_code; set => division_code = value; }
        public string Division_name { get => division_name; set => division_name = value; }
        public string Division_account { get => division_account; set => division_account = value; }
        public string Division_rpt_desc { get => division_rpt_desc; set => division_rpt_desc = value; }
        public string Division_flag_cek_lunas_ontime { get => division_flag_cek_lunas_ontime; set => division_flag_cek_lunas_ontime = value; }
        public int Division_syarat_min_su { get => division_syarat_min_su; set => division_syarat_min_su = value; }
        public int Division_pembagi_value { get => division_pembagi_value; set => division_pembagi_value = value; }
        public int Division_tipe_komisi_cash { get => division_tipe_komisi_cash; set => division_tipe_komisi_cash = value; }
        public int Division_tipe_komisi_credit { get => division_tipe_komisi_credit; set => division_tipe_komisi_credit = value; }
        public int Division_auto_proces_kp { get => division_auto_proces_kp; set => division_auto_proces_kp = value; }
        public DateTime Division_auto_process_kp_date { get => division_auto_process_kp_date; set => division_auto_process_kp_date = value; }
        public string Divison_sap_code { get => divison_sap_code; set => divison_sap_code = value; }
        public DateTime Division_created_at { get => division_created_at; set => division_created_at = value; }
        public DateTime Division_updated_at { get => division_updated_at; set => division_updated_at = value; }
    }
}
