using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.businessLogic.GS
{
    public class GSEntityBL
    {
        private string gec_entity_id;
        private string gec_address_1;
        private string gec_entity;
        private string gec_address_2;
        private string gec_address_3;
        private string gec_city;
        private string gec_postal_code;
        private string gec_phone;
        private string gec_fax;
        private string gec_email;
        private string gec_ptc1;
        private string gec_title1;
        private string gec_ptc2;
        private string gec_title2;
        private string gec_npwp;
        private string gec_user_defined1;
        private string gec_user_defined2;
        private string gec_no_pengukuhan;
        private DateTime? gec_tgl_pengukuhan;
        private string gec_tax_invoice_no;
        private string gec_remark;
        private string gec_branch_flag;
        private string gec_division_flag;
        private string gec_department_flag;
        private string gec_filler_flag;
        private string gec_entity_default;

        public string entity_id { get => gec_entity_id; set => gec_entity_id = value; }
        public string address_1 { get => gec_address_1; set => gec_address_1 = value; }
        public string entity { get => gec_entity; set => gec_entity = value; }
        public string address_2 { get => gec_address_2; set => gec_address_2 = value; }
        public string address_3 { get => gec_address_3; set => gec_address_3 = value; }
        public string city { get => gec_city; set => gec_city = value; }
        public string postal_code { get => gec_postal_code; set => gec_postal_code = value; }
        public string phone { get => gec_phone; set => gec_phone = value; }
        public string fax { get => gec_fax; set => gec_fax = value; }
        public string email { get => gec_email; set => gec_email = value; }
        public string ptc1 { get => gec_ptc1; set => gec_ptc1 = value; }
        public string title1 { get => gec_title1; set => gec_title1 = value; }
        public string ptc2 { get => gec_ptc2; set => gec_ptc2 = value; }
        public string title2 { get => gec_title2; set => gec_title2 = value; }
        public string npwp { get => gec_npwp; set => gec_npwp = value; }
        public string user_defined1 { get => gec_user_defined1; set => gec_user_defined1 = value; }
        public string user_defined2 { get => gec_user_defined2; set => gec_user_defined2 = value; }
        public string no_pengukuhan { get => gec_no_pengukuhan; set => gec_no_pengukuhan = value; }
        public DateTime? tgl_pengukuhan { get => gec_tgl_pengukuhan; set => gec_tgl_pengukuhan = value; }
        public string tax_invoice_no { get => gec_tax_invoice_no; set => gec_tax_invoice_no = value; }
        public string remark { get => gec_remark; set => gec_remark = value; }
        public string branch_flag { get => gec_branch_flag; set => gec_branch_flag = value; }
        public string division_flag { get => gec_division_flag; set => gec_division_flag = value; }
        public string department_flag { get => gec_department_flag; set => gec_department_flag = value; }
        public string filler_flag { get => gec_filler_flag; set => gec_filler_flag = value; }
        public string entity_default { get => gec_entity_default; set => gec_entity_default = value; }
    }
}
