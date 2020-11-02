using MADITP2._0.DataAccess.RC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.businessLogic.RC
{
    class RCMasterODTBL
    {
        private int id;
        private string branch_id;
        private string division_id;
        private string rep_id;
        private string rep_name;
        private DateTime? tgl_oct;
        private string nama_peserta;
        private string alamat;
        private string telp_peserta;
        private string lulus;
        private string keterangan;
        private DateTime? user_date;
        private string user_entry;
        private string active;
        private string trainer;
        private string oct_type;
        private string lulus_bop;
        private DateTime? tgl_bop;
        private string lulus_ppq;
        private DateTime? tgl_ppq;
        private string lulus_intervw;
        private DateTime? tgl_intervw;
        private string intervw_by;
        private string oct_rep_id;
        private string oct_hanphone_peserta;
        private string status_pernikahan;
        private string rek_bca;
        private string agama;
        private string jenis_kelamin;
        private string tempat_lahir;
        private DateTime? tanggal_lahir;
        private string kota_domisili;
        private string kode_pos;
        private string hidden_row;
        private string roprincipal;
        private string pemilik_npwp;
        private string identitas_oct;
        private string manager_id;
        private string manager_name;
        private string principal;
        private string npwp;
        private string active_flag;
        private string is_odt;
        private string toko_online;

        public int Id { get => id; set => id = value; }
        public string Branch_Id { get => branch_id; set => branch_id = value; }
        public string Division_Id { get => division_id; set => division_id = value; }
        public string Rep_Id { get => rep_id; set => rep_id = value; }
        public string Rep_Name { get => rep_name; set => rep_name = value; }
        public DateTime? Tgl_Oct { get => tgl_oct; set => tgl_oct = value; }
        public string Nama_Peserta { get => nama_peserta; set => nama_peserta = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Telp_Peserta { get => telp_peserta; set => telp_peserta = value; }
        public string Lulus { get => lulus; set => lulus = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }
        public DateTime? User_Date { get => user_date; set => user_date = value; }
        public string User_Entry { get => user_entry; set => user_entry = value; }
        public string Active { get => active; set => active = value; }
        public string Trainer { get => trainer; set => trainer = value; }
        public string Oct_Type { get => oct_type; set => oct_type = value; }
        public string Lulus_Bop { get => lulus_bop; set => lulus_bop = value; }
        public DateTime? Tgl_Bop { get => tgl_bop; set => tgl_bop = value; }
        public string Lulus_Ppq { get => lulus_ppq; set => lulus_ppq = value; }
        public DateTime? Tgl_Ppq { get => tgl_ppq; set => tgl_ppq = value; }
        public string Lulus_Intervw { get => lulus_intervw; set => lulus_intervw = value; }
        public DateTime? Tgl_Intervw { get => tgl_intervw; set => tgl_intervw = value; }
        public string Intervw_By { get => intervw_by; set => intervw_by = value; }
        public string Oct_Rep_Id { get => oct_rep_id; set => oct_rep_id = value; }
        public string Oct_Hanphone_Peserta { get => oct_hanphone_peserta; set => oct_hanphone_peserta = value; }
        public string Status_Pernikahan { get => status_pernikahan; set => status_pernikahan = value; }
        public string Rek_Bca { get => rek_bca; set => rek_bca = value; }
        public string Agama { get => agama; set => agama = value; }
        public string Jenis_Kelamin { get => jenis_kelamin; set => jenis_kelamin = value; }
        public string Tempat_Lahir { get => tempat_lahir; set => tempat_lahir = value; }
        public DateTime? Tanggal_Lahir { get => tanggal_lahir; set => tanggal_lahir = value; }
        public string Kota_Domisili { get => kota_domisili; set => kota_domisili = value; }
        public string Kode_Pos { get => kode_pos; set => kode_pos = value; }
        public string Hidden_Row { get => hidden_row; set => hidden_row = value; }
        public string RoPrincipal { get => roprincipal; set => roprincipal = value; }
        public string Pemilik_Npwp { get => pemilik_npwp; set => pemilik_npwp = value; }
        public string Identitas_Oct { get => identitas_oct; set => identitas_oct = value; }
        public string Manager_Id { get => manager_id; set => manager_id = value; }
        public string Manager_Name { get => manager_name; set => manager_name = value; }
        public string Principal { get => principal; set => principal = value; }
        public string Npwp { get => npwp; set => npwp = value; }
        public string Active_Flag { get => active_flag; set => active_flag = value; }
        public string Is_Odt { get => is_odt; set => is_odt = value; }
        public string Toko_Online { get => toko_online; set => toko_online = value; }
    }
}
