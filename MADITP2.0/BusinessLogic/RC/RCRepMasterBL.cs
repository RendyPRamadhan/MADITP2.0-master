using System;

namespace MADITP2._0.businessLogic.RC
{
    public class RCRepMasterBL
    {
        private string rm_branch_id;
        private string rm_rep_id;
        private string rm_name;
        private string rm_recruiter_id;
        private string rm_manager_id;
        private string rm_nm_Manager;
        private DateTime? rm_join_date = null;
        private string rm_bank_id;
        private string rm_account_name;
        private string rm_acc_number;
        private string rm_nama_NPWP;
        private string rm_npwp;
        private string rm_flag_npwp;
        private string entity_id;
        private string division_id;
        private string registration_id;
        private string short_name;
        private string sex;
        private int marital_status;
        private DateTime? psk_date = null;
        private string home_address_1;
        private string home_address_2;
        private string home_address_3;
        private string phone_home;
        private string kelurahan;
        private string rt;
        private string rw;
        private string zipcode;
        private string company_name;
        private string company_address_1;
        private string company_address_2;
        private string company_address_3;
        private string company_phone;
        private string birth_place;
        private DateTime? birth_date = null;
        private int religion_id;
        private string citizenship;
        private string identity_no;
        private int last_formal_education;
        private string graduated_flag;
        private string year_graduated;
        private int language_1;
        private int language_2;
        private int language_3;
        private string last_position;
        private string customer_id;
        private string group;
        private string status;
        private string current_position;
        private DateTime? date_position_change = null;
        private string last_position_level;
        private string num_rep_recruited;
        private DateTime? entry_date = null;
        private string entry_user;
        private string cwh_deducted;
        private int cwh_cummulated;
        private string active_flag;
        private string rep_type_id;
        private string rep_txn_flag;
        private DateTime? maried_date = null;
        private DateTime? nabas_date = null;
        private string team;
        private string passwd;
        private DateTime? oct_date = null;
        private string id_link;
        private string cmp_num;
        private string principal;
        private string mOCT_ID;
        private string status_position;
        private string approve;
        private string lulus;
        private string bank;
        private string city;
        private string province;
        private string kecamatan;
        private string no_wa;
        private string flag;
        private string mobile_phone_new;
        private string subdistrik_id;
        private string mobile_phone;
        private DateTime? create_npwp = null;
        private DateTime? non_active_date = null;
        private string email_address;
        private DateTime? date_pkk = null;

        public string branch { get => rm_branch_id; set => this.rm_branch_id = value; }
        public string repId { get => rm_rep_id; set => this.rm_rep_id = value; }
        public string name { get => rm_name; set => this.rm_name = value; }
        public string recruiterId { get => rm_recruiter_id; set => this.rm_recruiter_id = value; }
        public string managerId { get => rm_manager_id; set => this.rm_manager_id = value; }
        public string managerName { get => rm_nm_Manager; set => this.rm_nm_Manager = value; }
        public DateTime? joinDate { get => rm_join_date; set => this.rm_join_date = value; }
        public string bankId { get => rm_bank_id; set => this.rm_bank_id = value; }
        public string accountName { get => rm_account_name; set => this.rm_account_name = value; }
        public string accountNumber { get => rm_acc_number; set => this.rm_acc_number = value; }
        public string npwpName { get => rm_nama_NPWP; set => this.rm_nama_NPWP = value; }
        public string npwpNumber { get => rm_npwp; set => this.rm_npwp = value; }
        public string npwpFlag { get => rm_flag_npwp; set => this.rm_flag_npwp = value; }
        public string Entity_id { get => entity_id; set => entity_id = value; }
        public string Division_id { get => division_id; set => division_id = value; }
        public string Registration_id { get => registration_id; set => registration_id = value; }
        public string Short_name { get => short_name; set => short_name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Marital_status { get => marital_status; set => marital_status = value; }
        public DateTime? Psk_date { get => psk_date; set => psk_date = value; }
        public string Home_address_1 { get => home_address_1; set => home_address_1 = value; }
        public string Home_address_2 { get => home_address_2; set => home_address_2 = value; }
        public string Home_address_3 { get => home_address_3; set => home_address_3 = value; }
        public string Phone_home { get => phone_home; set => phone_home = value; }
        public string Kelurahan { get => kelurahan; set => kelurahan = value; }
        public string Rt { get => rt; set => rt = value; }
        public string Rw { get => rw; set => rw = value; }
        public string Zipcode { get => zipcode; set => zipcode = value; }
        public string Company_name { get => company_name; set => company_name = value; }
        public string Company_address_1 { get => company_address_1; set => company_address_1 = value; }
        public string Company_address_2 { get => company_address_2; set => company_address_2 = value; }
        public string Company_address_3 { get => company_address_3; set => company_address_3 = value; }
        public string Company_phone { get => company_phone; set => company_phone = value; }
        public string Birth_place { get => birth_place; set => birth_place = value; }
        public DateTime? Birth_date { get => birth_date; set => birth_date = value; }
        public int Religion_id { get => religion_id; set => religion_id = value; }
        public string Citizenship { get => citizenship; set => citizenship = value; }
        public string Identity_no { get => identity_no; set => identity_no = value; }
        public int Last_formal_education { get => last_formal_education; set => last_formal_education = value; }
        public string Graduated_flag { get => graduated_flag; set => graduated_flag = value; }
        public string Year_graduated { get => year_graduated; set => year_graduated = value; }
        public int Language_1 { get => language_1; set => language_1 = value; }
        public int Language_2 { get => language_2; set => language_2 = value; }
        public int Language_3 { get => language_3; set => language_3 = value; }
        public string Last_position { get => last_position; set => last_position = value; }
        public string Customer_id { get => customer_id; set => customer_id = value; }
        public string GroupID { get => group; set => group = value; }
        public string Status { get => status; set => status = value; }
        public string Current_position { get => current_position; set => current_position = value; }
        public DateTime? Date_position_change { get => date_position_change; set => date_position_change = value; }
        public string Last_position_level { get => last_position_level; set => last_position_level = value; }
        public string Num_rep_recruited { get => num_rep_recruited; set => num_rep_recruited = value; }
        public DateTime? Entry_date { get => entry_date; set => entry_date = value; }
        public string Entry_user { get => entry_user; set => entry_user = value; }
        public string Cwh_deducted { get => cwh_deducted; set => cwh_deducted = value; }
        public int Cwh_cummulated { get => cwh_cummulated; set => cwh_cummulated = value; }
        public string Active_flag { get => active_flag; set => active_flag = value; }
        public string Rep_type_id { get => rep_type_id; set => rep_type_id = value; }
        public string Rep_txn_flag { get => rep_txn_flag; set => rep_txn_flag = value; }
        public DateTime? Maried_date { get => maried_date; set => maried_date = value; }
        public DateTime? Nabas_date { get => nabas_date; set => nabas_date = value; }
        public string Team { get => team; set => team = value; }
        public string Passwd { get => passwd; set => passwd = value; }
        public DateTime? Oct_date { get => oct_date; set => oct_date = value; }
        public string Id_link { get => id_link; set => id_link = value; }
        public string Cmp_num { get => cmp_num; set => cmp_num = value; }
        public string Principal { get => principal; set => principal = value; }
        public string OCT_ID { get => mOCT_ID; set => mOCT_ID = value; }
        public string Status_position { get => status_position; set => status_position = value; }
        public string Approve { get => approve; set => approve = value; }
        public string Lulus { get => lulus; set => lulus = value; }
        public string Bank { get => bank; set => bank = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public string Kecamatan { get => kecamatan; set => kecamatan = value; }
        public string No_wa { get => no_wa; set => no_wa = value; }
        public string Flag { get => flag; set => flag = value; }
        public string Mobile_phone_new { get => mobile_phone_new; set => mobile_phone_new = value; }
        public string Subdistrik_id { get => subdistrik_id; set => subdistrik_id = value; }
        public string Mobile_phone { get => mobile_phone; set => mobile_phone = value; }
        public DateTime? Create_npwp { get => create_npwp; set => create_npwp = value; }
        public DateTime? Non_active_date { get => non_active_date; set => non_active_date = value; }
        public string Email_address { get => email_address; set => email_address = value; }
        public DateTime? Date_pkk { get => date_pkk; set => date_pkk = value; }
    }
}
