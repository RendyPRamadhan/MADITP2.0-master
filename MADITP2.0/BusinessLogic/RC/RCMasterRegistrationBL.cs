using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.businessLogic.RC
{
    class RCMasterRegistrationBL
    {
        private string rm_entity_id;
        private string rm_branch_id;
        private string rm_division_id;
        private string rm_rep_id;
        private string rm_name;
        private string rm_short_name;
        private string rm_manager_id;
        private string rm_recruiter_id;
        private string rm_sex;
        private int rm_marital_status;
        private DateTime rm_join_date;
        private string rm_no_wa;
        private string rm_mobile_phone;
        private string rm_email_address;
        private string rm_home_address_1;
        private string rm_home_address_2;
        private string rm_home_address_3;
        private string rm_phone_home;
        private string rm_kelurahan;
        private string rm_rt;
        private string rm_rw;
        private string rm_zipcode;
        private string rm_company_name;
        private string rm_company_address_1;
        private string rm_company_address_2;
        private string rm_company_address_3;
        private string rm_company_phone;
        private string rm_birth_place;
        private DateTime rm_birth_date;
        private int rm_religion_id;
        private string rm_citizenship;
        private string rm_acc_number;
        private string rm_account_name;
        private string rm_bank_id;
        private string rm_identity_no;
        private int rm_last_formal_education;
        private string rm_graduated_flag;
        private string rm_year_graduated;
        private int rm_language_1;
        private int rm_language_2;
        private int rm_language_3;
        private string rm_customer_id;
        private string rm_group;
        private string rm_status;
        private string rm_current_position;
        private string rm_last_position_level;
        private string rm_status_position;
        private DateTime rm_date_position_change;
        private DateTime rm_entry_date;
        private string rm_entry_user;
        private string rm_active_flag;
        private string rm_rep_type_id;
        private DateTime rm_maried_date;
        private DateTime rm_nabas_date;
        private string rm_team;
        private DateTime rm_oct_date;
        private string rm_npwp;
        private string rm_nm_Manager;
        private string rm_principal;
        private string rm_nama_NPWP;
        private string rm_OCT_ID;
        private string rm_approve;
        private string rm_lulus;
        private string rm_bank;
        private string rm_city;
        private string rm_provice;
        private string rm_kecamatan;
        private string rm_flag;
        private string rm_subdistrik_id;
        private DateTime rm_create_npwp;
        private string rm_flag_npwp;
        private DateTime rm_non_active_date;
        private DateTime rm_date_pkk;

        public string Rm_entity_id { get => rm_entity_id; set => rm_entity_id = value; }
        public string Rm_branch_id { get => rm_branch_id; set => rm_branch_id = value; }
        public string Rm_division_id { get => rm_division_id; set => rm_division_id = value; }
        public string Rm_rep_id { get => rm_rep_id; set => rm_rep_id = value; }
        public string Rm_name { get => rm_name; set => rm_name = value; }
        public string Rm_short_name { get => rm_short_name; set => rm_short_name = value; }
        public string Rm_manager_id { get => rm_manager_id; set => rm_manager_id = value; }
        public string Rm_recruiter_id { get => rm_recruiter_id; set => rm_recruiter_id = value; }
        public string Rm_sex { get => rm_sex; set => rm_sex = value; }
        public int Rm_marital_status { get => rm_marital_status; set => rm_marital_status = value; }
        public DateTime Rm_join_date { get => rm_join_date; set => rm_join_date = value; }
        public string Rm_no_wa { get => rm_no_wa; set => rm_no_wa = value; }
        public string Rm_mobile_phone { get => rm_mobile_phone; set => rm_mobile_phone = value; }
        public string Rm_email_address { get => rm_email_address; set => rm_email_address = value; }
        public string Rm_home_address_1 { get => rm_home_address_1; set => rm_home_address_1 = value; }
        public string Rm_home_address_2 { get => rm_home_address_2; set => rm_home_address_2 = value; }
        public string Rm_home_address_3 { get => rm_home_address_3; set => rm_home_address_3 = value; }
        public string Rm_phone_home { get => rm_phone_home; set => rm_phone_home = value; }
        public string Rm_kelurahan { get => rm_kelurahan; set => rm_kelurahan = value; }
        public string Rm_rt { get => rm_rt; set => rm_rt = value; }
        public string Rm_rw { get => rm_rw; set => rm_rw = value; }
        public string Rm_zipcode { get => rm_zipcode; set => rm_zipcode = value; }
        public string Rm_company_name { get => rm_company_name; set => rm_company_name = value; }
        public string Rm_company_address_1 { get => rm_company_address_1; set => rm_company_address_1 = value; }
        public string Rm_company_address_2 { get => rm_company_address_2; set => rm_company_address_2 = value; }
        public string Rm_company_address_3 { get => rm_company_address_3; set => rm_company_address_3 = value; }
        public string Rm_company_phone { get => rm_company_phone; set => rm_company_phone = value; }
        public string Rm_birth_place { get => rm_birth_place; set => rm_birth_place = value; }
        public DateTime Rm_birth_date { get => rm_birth_date; set => rm_birth_date = value; }
        public int Rm_religion_id { get => rm_religion_id; set => rm_religion_id = value; }
        public string Rm_citizenship { get => rm_citizenship; set => rm_citizenship = value; }
        public string Rm_acc_number { get => rm_acc_number; set => rm_acc_number = value; }
        public string Rm_account_name { get => rm_account_name; set => rm_account_name = value; }
        public string Rm_bank_id { get => rm_bank_id; set => rm_bank_id = value; }
        public string Rm_identity_no { get => rm_identity_no; set => rm_identity_no = value; }
        public int Rm_last_formal_education { get => rm_last_formal_education; set => rm_last_formal_education = value; }
        public string Rm_graduated_flag { get => rm_graduated_flag; set => rm_graduated_flag = value; }
        public string Rm_year_graduated { get => rm_year_graduated; set => rm_year_graduated = value; }
        public int Rm_language_1 { get => rm_language_1; set => rm_language_1 = value; }
        public int Rm_language_2 { get => rm_language_2; set => rm_language_2 = value; }
        public int Rm_language_3 { get => rm_language_3; set => rm_language_3 = value; }
        public string Rm_customer_id { get => rm_customer_id; set => rm_customer_id = value; }
        public string Rm_group { get => rm_group; set => rm_group = value; }
        public string Rm_status { get => rm_status; set => rm_status = value; }
        public string Rm_current_position { get => rm_current_position; set => rm_current_position = value; }
        public string Rm_last_position_level { get => rm_last_position_level; set => rm_last_position_level = value; }
        public string Rm_status_position { get => rm_status_position; set => rm_status_position = value; }
        public DateTime Rm_date_position_change { get => rm_date_position_change; set => rm_date_position_change = value; }
        public DateTime Rm_entry_date { get => rm_entry_date; set => rm_entry_date = value; }
        public string Rm_entry_user { get => rm_entry_user; set => rm_entry_user = value; }
        public string Rm_active_flag { get => rm_active_flag; set => rm_active_flag = value; }
        public string Rm_rep_type_id { get => rm_rep_type_id; set => rm_rep_type_id = value; }
        public DateTime Rm_maried_date { get => rm_maried_date; set => rm_maried_date = value; }
        public DateTime Rm_nabas_date { get => rm_nabas_date; set => rm_nabas_date = value; }
        public string Rm_team { get => rm_team; set => rm_team = value; }
        public DateTime Rm_oct_date { get => rm_oct_date; set => rm_oct_date = value; }
        public string Rm_npwp { get => rm_npwp; set => rm_npwp = value; }
        public string Rm_nm_Manager { get => rm_nm_Manager; set => rm_nm_Manager = value; }
        public string Rm_principal { get => rm_principal; set => rm_principal = value; }
        public string Rm_nama_NPWP { get => rm_nama_NPWP; set => rm_nama_NPWP = value; }
        public string Rm_OCT_ID { get => rm_OCT_ID; set => rm_OCT_ID = value; }
        public string Rm_approve { get => rm_approve; set => rm_approve = value; }
        public string Rm_lulus { get => rm_lulus; set => rm_lulus = value; }
        public string Rm_bank { get => rm_bank; set => rm_bank = value; }
        public string Rm_city { get => rm_city; set => rm_city = value; }
        public string Rm_provice { get => rm_provice; set => rm_provice = value; }
        public string Rm_kecamatan { get => rm_kecamatan; set => rm_kecamatan = value; }
        public string Rm_flag { get => rm_flag; set => rm_flag = value; }
        public string Rm_subdistrik_id { get => rm_subdistrik_id; set => rm_subdistrik_id = value; }
        public DateTime Rm_create_npwp { get => rm_create_npwp; set => rm_create_npwp = value; }
        public string Rm_flag_npwp { get => rm_flag_npwp; set => rm_flag_npwp = value; }
        public DateTime Rm_non_active_date { get => rm_non_active_date; set => rm_non_active_date = value; }
        public DateTime Rm_date_pkk { get => rm_date_pkk; set => rm_date_pkk = value; }
    }
}
