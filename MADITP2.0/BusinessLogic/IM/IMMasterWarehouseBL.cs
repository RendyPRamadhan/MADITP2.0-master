using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    class IMMasterWarehouseBL
    {
        private string wh_warehouse_id;
        private string wh_warehouse_description;
        private string wh_address_1;
        private string wh_address_2;
        private string wh_address_3;
        private string wh_area_code;
        private string wh_city;
        private string wh_postal_code;
        private string wh_province;
        private string wh_phone;
        private string wh_fax;
        private string wh_contact_person;
        private string wh_type;
        private string wh_sales_shipment_allowed;
        private string wh_receipt_from_po_rec_allowed;
        private string wh_receipt_from_non_po_allowed;
        private string wh_manual_transaction_entry_allowed;
        private string wh_cost_revaluation_allowed;
        private string wh_transfer_transaction_allowed;
        private string wh_transit_warehouse_id;
        private string wh_damage_warehouse_id;
        private string wh_gl_entity;
        private string wh_gl_account;
        private DateTime? wh_creation_date;
        private DateTime? wh_last_update_date;
        private string wh_used_id;
        private string wh_email_address;
        private string wh_physical_count_allow;
        private string bc_sap_code;
        private string wh_upload_sap;
        private string wh_digital;
        private string wh_site_sap_code;
        private string wh_sloc_sap_code;
        private string wh_marketplace_flag;

        public string warehouse_id { get => wh_warehouse_id; set => wh_warehouse_id = value; }
        public string warehouse_description { get => wh_warehouse_description; set => wh_warehouse_description = value; }
        public string address_1 { get => wh_address_1; set => wh_address_1 = value; }
        public string address_2 { get => wh_address_2; set => wh_address_2 = value; }
        public string address_3 { get => wh_address_3; set => wh_address_3 = value; }
        public string area_code { get => wh_area_code; set => wh_area_code = value; }
        public string city { get => wh_city; set => wh_city = value; }
        public string postal_code { get => wh_postal_code; set => wh_postal_code = value; }
        public string province { get => wh_province; set => wh_province = value; }
        public string phone { get => wh_phone; set => wh_phone = value; }
        public string fax { get => wh_fax; set => wh_fax = value; }
        public string contact_person { get => wh_contact_person; set => wh_contact_person = value; }
        public string type { get => wh_type; set => wh_type = value; }
        public string sales_shipment_allowed { get => wh_sales_shipment_allowed; set => wh_sales_shipment_allowed = value; }
        public string receipt_from_po_rec_allowed { get => wh_receipt_from_po_rec_allowed; set => wh_receipt_from_po_rec_allowed = value; }
        public string receipt_from_non_po_allowed { get => wh_receipt_from_non_po_allowed; set => wh_receipt_from_non_po_allowed = value; }
        public string manual_transaction_entry_allowed { get => wh_manual_transaction_entry_allowed; set => wh_manual_transaction_entry_allowed = value; }
        public string cost_revaluation_allowed { get => wh_cost_revaluation_allowed; set => wh_cost_revaluation_allowed = value; }
        public string transfer_transaction_allowed { get => wh_transfer_transaction_allowed; set => wh_transfer_transaction_allowed = value; }
        public string transit_warehouse_id { get => wh_transit_warehouse_id; set => wh_transit_warehouse_id = value; }
        public string damage_warehouse_id { get => wh_damage_warehouse_id; set => wh_damage_warehouse_id = value; }
        public string gl_entity { get => wh_gl_entity; set => wh_gl_entity = value; }
        public string gl_account { get => wh_gl_account; set => wh_gl_account = value; }
        public DateTime? creation_date { get => wh_creation_date; set => wh_creation_date = value; }
        public DateTime? last_update_date { get => wh_last_update_date; set => wh_last_update_date = value; }
        public string used_id { get => wh_used_id; set => wh_used_id = value; }
        public string email_address { get => wh_email_address; set => wh_email_address = value; }
        public string physical_count_allow { get => wh_physical_count_allow; set => wh_physical_count_allow = value; }
        public string sap_code { get => bc_sap_code; set => bc_sap_code = value; }
        public string upload_sap { get => wh_upload_sap; set => wh_upload_sap = value; }
        public string digital { get => wh_digital; set => wh_digital = value; }
        public string site_sap_code { get => wh_site_sap_code; set => wh_site_sap_code = value; }
        public string sloc_sap_code { get => wh_sloc_sap_code; set => wh_sloc_sap_code = value; }
        public string marketplace_flag { get => wh_marketplace_flag; set => wh_marketplace_flag = value; }
    }
}
