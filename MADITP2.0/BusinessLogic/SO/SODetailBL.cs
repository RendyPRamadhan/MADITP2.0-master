using System;

namespace MADITP2._0.BusinessLogic.SO
{
    class SODetailBL
    {
        private string skh_branch_id;
        private string skh_entity_id;
        private string skh_division_id;
        private DateTime skh_so_kp_date;
        private string skh_order_type;
        private string skh_so_kp_number;
        private string rm_name;
        private string skh_customer_name;
        private string skh_sales_type;
        private string skh_total_disc_amount;
        private string skh_status_of_so_kp;
        private string skh_status_of_verification;
        private string skh_status_of_invoice;
        private string skh_status_of_delivery;
        private string skh_status_of_dp;
        private string skh_status_of_cod;
        private string skh_total_item_set_qty;
        private string skh_total_su;
        private string skh_total_bv;
        private string skh_total_pv;
        private string skh_total_point_1;
        private string skh_total_point_2;
        private string skh_rep_id;
        private string skh_mgr_rep_id;
        private string skd_line_type;
        private string skd_product_id;
        private string pm_product_description;
        private string skd_unit_measure;
        private string skd_qty_ordered;
        private string skd_qty_shipped_up_to_date;
        private string skd_unit_price;
        private string amount;
        private string skd_detail_line_su;
        private string skd_detail_line_bv;
        private string skd_detail_line_pv;
        private string skd_detail_line_p1;
        private string skd_detail_line_p2;
        private string skd_so_kp_num;
        private string dateFrom;
        private string dateTo;
        private string skh_deliver_from_warehouse_id;
        private string ssh_pending;
        private string ssh_pending2;

        public string Skh_branch_id { get => skh_branch_id; set => skh_branch_id = value; }
        public string Skh_entity_id { get => skh_entity_id; set => skh_entity_id = value; }
        public string Skh_division_id { get => skh_division_id; set => skh_division_id = value; }
        public DateTime Skh_so_kp_date { get => skh_so_kp_date; set => skh_so_kp_date = value; }
        public string Skh_order_type { get => skh_order_type; set => skh_order_type = value; }
        public string Skh_so_kp_number { get => skh_so_kp_number; set => skh_so_kp_number = value; }
        public string Rm_name { get => rm_name; set => rm_name = value; }
        public string Skh_customer_name { get => skh_customer_name; set => skh_customer_name = value; }
        public string Skh_sales_type { get => skh_sales_type; set => skh_sales_type = value; }
        public string Skh_total_disc_amount { get => skh_total_disc_amount; set => skh_total_disc_amount = value; }
        public string Skh_status_of_so_kp { get => skh_status_of_so_kp; set => skh_status_of_so_kp = value; }
        public string Skh_status_of_verification { get => skh_status_of_verification; set => skh_status_of_verification = value; }
        public string Skh_status_of_invoice { get => skh_status_of_invoice; set => skh_status_of_invoice = value; }
        public string Skh_status_of_delivery { get => skh_status_of_delivery; set => skh_status_of_delivery = value; }
        public string Skh_status_of_dp { get => skh_status_of_dp; set => skh_status_of_dp = value; }
        public string Skh_status_of_cod { get => skh_status_of_cod; set => skh_status_of_cod = value; }
        public string Skh_total_item_set_qty { get => skh_total_item_set_qty; set => skh_total_item_set_qty = value; }
        public string Skh_total_su { get => skh_total_su; set => skh_total_su = value; }
        public string Skh_total_bv { get => skh_total_bv; set => skh_total_bv = value; }
        public string Skh_total_pv { get => skh_total_pv; set => skh_total_pv = value; }
        public string Skh_total_point_1 { get => skh_total_point_1; set => skh_total_point_1 = value; }
        public string Skh_total_point_2 { get => skh_total_point_2; set => skh_total_point_2 = value; }
        public string Skh_rep_id { get => skh_rep_id; set => skh_rep_id = value; }
        public string Skh_mgr_rep_id { get => skh_mgr_rep_id; set => skh_mgr_rep_id = value; }
        public string Skd_line_type { get => skd_line_type; set => skd_line_type = value; }
        public string Pm_product_description { get => pm_product_description; set => pm_product_description = value; }
        public string Skd_unit_measure { get => skd_unit_measure; set => skd_unit_measure = value; }
        public string Skd_qty_shipped_up_to_date { get => skd_qty_shipped_up_to_date; set => skd_qty_shipped_up_to_date = value; }
        public string Amount { get => amount; set => amount = value; }
        public string Skd_detail_line_su { get => skd_detail_line_su; set => skd_detail_line_su = value; }
        public string Skd_detail_line_bv { get => skd_detail_line_bv; set => skd_detail_line_bv = value; }
        public string Skd_detail_line_pv { get => skd_detail_line_pv; set => skd_detail_line_pv = value; }
        public string Skd_detail_line_p1 { get => skd_detail_line_p1; set => skd_detail_line_p1 = value; }
        public string Skd_detail_line_p2 { get => skd_detail_line_p2; set => skd_detail_line_p2 = value; }
        public string Skd_so_kp_num { get => skd_so_kp_num; set => skd_so_kp_num = value; }
        public string DateFrom { get => dateFrom; set => dateFrom = value; }
        public string DateTo { get => dateTo; set => dateTo = value; }
        public string Skh_deliver_from_warehouse_id { get => skh_deliver_from_warehouse_id; set => skh_deliver_from_warehouse_id = value; }
        public string Ssh_pending { get => ssh_pending; set => ssh_pending = value; }
        public string Ssh_pending2 { get => ssh_pending2; set => ssh_pending2 = value; }
        public string Skd_product_id { get => skd_product_id; set => skd_product_id = value; }
        public string Skd_qty_ordered { get => skd_qty_ordered; set => skd_qty_ordered = value; }
        public string Skd_unit_price { get => skd_unit_price; set => skd_unit_price = value; }
    }
}
