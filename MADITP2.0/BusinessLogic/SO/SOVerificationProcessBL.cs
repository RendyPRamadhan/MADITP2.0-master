using System;

namespace MADITP2._0.businessLogic.SO
{
    public class SOVerificationProcessBL
    {
        public string entity_id { get; set; }

        public string branch_id { get; set; }

        public string division_id { get; set; }

        public string verificator_id { get; set; }

        public string so_kp_no { get; set; }

        public DateTime so_kp_date { get; set; }

        public DateTime assignment_date { get; set; }

        public string verification_status { get; set; }

        public string cancellation_reason { get; set; }

        public DateTime lastdate_status_change { get; set; }

        public string customer_id { get; set; }

        public string delivery_address_code { get; set; }

        public string billing_address_code { get; set; }

        public string sales_type { get; set; }

        public string payment_type { get; set; }

        public DateTime dateofbilling { get; set; }

        public string dateofvisit { get; set; }

        public string customer_data_status { get; set; }

        public string dp_status { get; set; }

        public int number_activity { get; set; }

        public double qualifier_harta_value { get; set; }

        public double qualifier_karakter_value { get; set; }

        public double qualifier_status_value { get; set; }

        public double qualifier_lokasi_value { get; set; }

        public double qualifier_kondisi_value { get; set; }

        public double qualifier_total_value { get; set; }

        public string remark_activity { get; set; }

        public string status_release { get; set; }

        public string remark { get; set; }

        public DateTime date_verif_release { get; set; }

        public string type_of_activity { get; set; }

        public string customer_name { get; set; }

        public DateTime so_kp_date_from { get; set; }

        public DateTime so_kp_date_until { get; set; }
    }
}
