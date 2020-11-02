using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOKPDetailBL
    {
        private string skd_so_kp_num;
        private int skd_so_kp_index_num;
        private DateTime skd_so_kp_date;
        private string skd_line_type;
        private string skd_product_id;
        private string skd_product_type;
        private string skd_unit_measure;
        private string skd_konversion_factor;
        private string skd_qty_ordered;
        private string skd_qty_invoiced;
        private string skd_qty_shipped_up_to_date;
        private string skd_qty_outstanding_order_shp;
        private string skd_unit_price_id;
        private string skd_unit_price;
        private string skd_total_price;
        private string skd_discount_amount;
        private string skd_net_line_amount;
        private string skd_dp_uang_muka;
        private string skd_bonus_discount_amount;
        private string skd_include_tax_flag;
        private string skd_taxable_amount_per_line;
        private string skd_tax_code;
        private string skd_gov_tax_dependent;
        private string skd_ppn_amount;
        private string skd_tax_ppn_bm;
        private string skd_cost_value;
        private string skd_detail_line_bv;
        private string skd_detail_line_pv;
        private string skd_detail_line_p1;
        private string skd_detail_line_p2;
        private string skd_total_cash_price;
        private string skd_sales_type;
        private string skd_tax_flag;
        private string skd_ppn_minus_factor;
        private string skd_status_of_delivery;
        private string skd_partial_status;
        private string skd_su_cash;
        private string skd_allocation_value_group;
        private string skd_dpp;
        private string skd_ppn;
        private string skd_sts_tax;
        private string skd_resi;
        private string skd_expedisi;
        private string skd_other_discount;
        private string skd_discount1;
        private string skd_discount_amount_with_ppn;
        private string skd_net_line_amount_with_ppn;
        private string skd_qty_plan;
        private string skd_detail_line_su_temp;
        private string skd_detail_line_su;

        public string Skd_so_kp_num { get => skd_so_kp_num; set => skd_so_kp_num = value; }
        public int Skd_so_kp_index_num { get => skd_so_kp_index_num; set => skd_so_kp_index_num = value; }
        public DateTime Skd_so_kp_date { get => skd_so_kp_date; set => skd_so_kp_date = value; }
        public string Skd_line_type { get => skd_line_type; set => skd_line_type = value; }
        public string Skd_product_id { get => skd_product_id; set => skd_product_id = value; }
        public string Skd_product_type { get => skd_product_type; set => skd_product_type = value; }
        public string Skd_unit_measure { get => skd_unit_measure; set => skd_unit_measure = value; }
        public string Skd_konversion_factor { get => skd_konversion_factor; set => skd_konversion_factor = value; }
        public string Skd_qty_ordered { get => skd_qty_ordered; set => skd_qty_ordered = value; }
        public string Skd_qty_invoiced { get => skd_qty_invoiced; set => skd_qty_invoiced = value; }
        public string Skd_qty_shipped_up_to_date { get => skd_qty_shipped_up_to_date; set => skd_qty_shipped_up_to_date = value; }
        public string Skd_qty_outstanding_order_shp { get => skd_qty_outstanding_order_shp; set => skd_qty_outstanding_order_shp = value; }
        public string Skd_unit_price_id { get => skd_unit_price_id; set => skd_unit_price_id = value; }
        public string Skd_unit_price { get => skd_unit_price; set => skd_unit_price = value; }
        public string Skd_total_price { get => skd_total_price; set => skd_total_price = value; }
        public string Skd_discount_amount { get => skd_discount_amount; set => skd_discount_amount = value; }
        public string Skd_net_line_amount { get => skd_net_line_amount; set => skd_net_line_amount = value; }
        public string Skd_dp_uang_muka { get => skd_dp_uang_muka; set => skd_dp_uang_muka = value; }
        public string Skd_bonus_discount_amount { get => skd_bonus_discount_amount; set => skd_bonus_discount_amount = value; }
        public string Skd_include_tax_flag { get => skd_include_tax_flag; set => skd_include_tax_flag = value; }
        public string Skd_taxable_amount_per_line { get => skd_taxable_amount_per_line; set => skd_taxable_amount_per_line = value; }
        public string Skd_tax_code { get => skd_tax_code; set => skd_tax_code = value; }
        public string Skd_gov_tax_dependent { get => skd_gov_tax_dependent; set => skd_gov_tax_dependent = value; }
        public string Skd_ppn_amount { get => skd_ppn_amount; set => skd_ppn_amount = value; }
        public string Skd_tax_ppn_bm { get => skd_tax_ppn_bm; set => skd_tax_ppn_bm = value; }
        public string Skd_cost_value { get => skd_cost_value; set => skd_cost_value = value; }
        public string Skd_detail_line_bv { get => skd_detail_line_bv; set => skd_detail_line_bv = value; }
        public string Skd_detail_line_pv { get => skd_detail_line_pv; set => skd_detail_line_pv = value; }
        public string Skd_detail_line_p1 { get => skd_detail_line_p1; set => skd_detail_line_p1 = value; }
        public string Skd_detail_line_p2 { get => skd_detail_line_p2; set => skd_detail_line_p2 = value; }
        public string Skd_total_cash_price { get => skd_total_cash_price; set => skd_total_cash_price = value; }
        public string Skd_sales_type { get => skd_sales_type; set => skd_sales_type = value; }
        public string Skd_tax_flag { get => skd_tax_flag; set => skd_tax_flag = value; }
        public string Skd_ppn_minus_factor { get => skd_ppn_minus_factor; set => skd_ppn_minus_factor = value; }
        public string Skd_status_of_delivery { get => skd_status_of_delivery; set => skd_status_of_delivery = value; }
        public string Skd_partial_status { get => skd_partial_status; set => skd_partial_status = value; }
        public string Skd_su_cash { get => skd_su_cash; set => skd_su_cash = value; }
        public string Skd_allocation_value_group { get => skd_allocation_value_group; set => skd_allocation_value_group = value; }
        public string Skd_dpp { get => skd_dpp; set => skd_dpp = value; }
        public string Skd_ppn { get => skd_ppn; set => skd_ppn = value; }
        public string Skd_sts_tax { get => skd_sts_tax; set => skd_sts_tax = value; }
        public string Skd_resi { get => skd_resi; set => skd_resi = value; }
        public string Skd_expedisi { get => skd_expedisi; set => skd_expedisi = value; }
        public string Skd_other_discount { get => skd_other_discount; set => skd_other_discount = value; }
        public string Skd_discount1 { get => skd_discount1; set => skd_discount1 = value; }
        public string Skd_discount_amount_with_ppn { get => skd_discount_amount_with_ppn; set => skd_discount_amount_with_ppn = value; }
        public string Skd_net_line_amount_with_ppn { get => skd_net_line_amount_with_ppn; set => skd_net_line_amount_with_ppn = value; }
        public string Skd_qty_plan { get => skd_qty_plan; set => skd_qty_plan = value; }
        public string Skd_detail_line_su_temp { get => skd_detail_line_su_temp; set => skd_detail_line_su_temp = value; }
        public string Skd_detail_line_su { get => skd_detail_line_su; set => skd_detail_line_su = value; }
    }
}
