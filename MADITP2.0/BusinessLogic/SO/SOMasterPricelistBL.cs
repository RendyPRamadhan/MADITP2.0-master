using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOMasterPricelistBL
    {
        private string plh_entity_id;
        private string plh_division_id;
        private string plh_price_list_code;
        private string plh_type;
        private string plh_price_list_desc;
        private string plh_status;
        private int plh_base_amount_su;
        private string plh_divider;
        private string plh_starting_date;
        private string plh_expire_date;
        private float plh_total_delivery;
        private int plh_total_value;
        private string plh_web_flag;
        private string plh_voucher_flag;
        private string plh_kpo_flag;
        private string pl_entity_id;
        private string pl_division_id;
        private string pl_price_list_code;
        private string pl_product_id;
        private int pl_no_of_items;
        private int pl_unit_selling_price;
        private int pl_cash_discount_price;
        private int pl_rep_consultant_price;
        private string pl_inex_ppn;
        private int pl_ppn;
        private string pl_inex_ppn_bm;
        private int pl_ppn_bm;
        private int pl_down_payment_min_amount;
        private int pl_su_cash_sales;
        private int pl_su_credit_sales;
        private int pl_bv;
        private int pl_bv_credit;
        private int pl_pv;
        private int pl_pv_credit;
        private int pl_point_1;
        private int pl_point_2;
        private string pl_creation_date;
        private string pl_updated_date;
        private string pl_expire_date;
        private string pl_user_id;
        private string pl_ppn_lain;
        private string pl_ppn_value;

        public string Plh_entity_id { get => plh_entity_id; set => plh_entity_id = value; }
        public string Plh_division_id { get => plh_division_id; set => plh_division_id = value; }
        public string Plh_price_list_code { get => plh_price_list_code; set => plh_price_list_code = value; }
        public string Plh_type { get => plh_type; set => plh_type = value; }
        public string Plh_price_list_desc { get => plh_price_list_desc; set => plh_price_list_desc = value; }
        public string Plh_status { get => plh_status; set => plh_status = value; }
        public int Plh_base_amount_su { get => plh_base_amount_su; set => plh_base_amount_su = value; }
        public string Plh_divider { get => plh_divider; set => plh_divider = value; }
        public string Plh_starting_date { get => plh_starting_date; set => plh_starting_date = value; }
        public string Plh_expire_date { get => plh_expire_date; set => plh_expire_date = value; }
        public float Plh_total_delivery { get => plh_total_delivery; set => plh_total_delivery = value; }
        public int Plh_total_value { get => plh_total_value; set => plh_total_value = value; }
        public string Plh_web_flag { get => plh_web_flag; set => plh_web_flag = value; }
        public string Plh_voucher_flag { get => plh_voucher_flag; set => plh_voucher_flag = value; }
        public string Plh_kpo_flag { get => plh_kpo_flag; set => plh_kpo_flag = value; }
        public string Pl_entity_id { get => pl_entity_id; set => pl_entity_id = value; }
        public string Pl_division_id { get => pl_division_id; set => pl_division_id = value; }
        public string Pl_price_list_code { get => pl_price_list_code; set => pl_price_list_code = value; }
        public string Pl_product_id { get => pl_product_id; set => pl_product_id = value; }
        public int Pl_no_of_items { get => pl_no_of_items; set => pl_no_of_items = value; }
        public int Pl_unit_selling_price { get => pl_unit_selling_price; set => pl_unit_selling_price = value; }
        public int Pl_cash_discount_price { get => pl_cash_discount_price; set => pl_cash_discount_price = value; }
        public int Pl_rep_consultant_price { get => pl_rep_consultant_price; set => pl_rep_consultant_price = value; }
        public string Pl_inex_ppn { get => pl_inex_ppn; set => pl_inex_ppn = value; }
        public int Pl_ppn { get => pl_ppn; set => pl_ppn = value; }
        public string Pl_inex_ppn_bm { get => pl_inex_ppn_bm; set => pl_inex_ppn_bm = value; }
        public int Pl_ppn_bm { get => pl_ppn_bm; set => pl_ppn_bm = value; }
        public int Pl_down_payment_min_amount { get => pl_down_payment_min_amount; set => pl_down_payment_min_amount = value; }
        public int Pl_su_cash_sales { get => pl_su_cash_sales; set => pl_su_cash_sales = value; }
        public int Pl_su_credit_sales { get => pl_su_credit_sales; set => pl_su_credit_sales = value; }
        public int Pl_bv { get => pl_bv; set => pl_bv = value; }
        public int Pl_bv_credit { get => pl_bv_credit; set => pl_bv_credit = value; }
        public int Pl_pv { get => pl_pv; set => pl_pv = value; }
        public int Pl_pv_credit { get => pl_pv_credit; set => pl_pv_credit = value; }
        public int Pl_point_1 { get => pl_point_1; set => pl_point_1 = value; }
        public int Pl_point_2 { get => pl_point_2; set => pl_point_2 = value; }
        public string Pl_creation_date { get => pl_creation_date; set => pl_creation_date = value; }
        public string Pl_updated_date { get => pl_updated_date; set => pl_updated_date = value; }
        public string Pl_expire_date { get => pl_expire_date; set => pl_expire_date = value; }
        public string Pl_user_id { get => pl_user_id; set => pl_user_id = value; }
        public string Pl_ppn_lain { get => pl_ppn_lain; set => pl_ppn_lain = value; }
        public string Pl_ppn_value { get => pl_ppn_value; set => pl_ppn_value = value; }
    }
}
