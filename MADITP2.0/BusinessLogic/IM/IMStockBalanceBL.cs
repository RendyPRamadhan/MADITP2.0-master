using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    public class IMStockBalanceBL
    {
        private string sb_warehouse_id;
        private string sb_product_id;
        private string sb_record_status;
        private string sb_stock_status;
        private int sb_min_stock_level;
        private int sb_max_stock_level;
        private int sb_qty_on_order;
        private int sb_qty_intransit;
        private int sb_qty_onhand;
        private int sb_qty_reserve_for_repack;
        private int sb_qty_reserve_for_transfer;
        private int sb_qty_reserve_for_sales_order;
        private int sb_qty_on_committed_sales_order;
        private int sb_qty_on_picking;
        private int sb_qty_on_shipment;
        private int sb_qty_on_qc_Quality_Assurance;
        private DateTime? sb_creation_date;
        private DateTime? sb_last_date_sales_shipment;
        private DateTime? sb_last_date_purchase;
        private DateTime? sb_last_date_transaction_entry;
        private DateTime? sb_last_date_physical_count;
        private int sb_min_stock_level2;
        private int sb_max_stock_level2;
        private string sb_moving_status;

        public string warehouse_id { get => sb_warehouse_id; set => sb_warehouse_id = value; }
        public string product_id { get => sb_product_id; set => sb_product_id = value; }
        public string record_status { get => sb_record_status; set => sb_record_status = value; }
        public string stock_status { get => sb_stock_status; set => sb_stock_status = value; }
        public int min_stock_level { get => sb_min_stock_level; set => sb_min_stock_level = value; }
        public int max_stock_level { get => sb_max_stock_level; set => sb_max_stock_level = value; }
        public int qty_on_order { get => sb_qty_on_order; set => sb_qty_on_order = value; }
        public int qty_intransit { get => sb_qty_intransit; set => sb_qty_intransit = value; }
        public int qty_onhand { get => sb_qty_onhand; set => sb_qty_onhand = value; }
        public int qty_reserve_for_repack { get => sb_qty_reserve_for_repack; set => sb_qty_reserve_for_repack = value; }
        public int qty_reserve_for_transfer { get => sb_qty_reserve_for_transfer; set => sb_qty_reserve_for_transfer = value; }
        public int qty_reserve_for_sales_order { get => sb_qty_reserve_for_sales_order; set => sb_qty_reserve_for_sales_order = value; }
        public int qty_on_committed_sales_order { get => sb_qty_on_committed_sales_order; set => sb_qty_on_committed_sales_order = value; }
        public int qty_on_picking { get => sb_qty_on_picking; set => sb_qty_on_picking = value; }
        public int qty_on_shipment { get => sb_qty_on_shipment; set => sb_qty_on_shipment = value; }
        public int qty_on_qc_Quality_Assurance { get => sb_qty_on_qc_Quality_Assurance; set => sb_qty_on_qc_Quality_Assurance = value; }
        public DateTime? creation_date { get => sb_creation_date; set => sb_creation_date = value; }
        public DateTime? last_date_sales_shipment { get => sb_last_date_sales_shipment; set => sb_last_date_sales_shipment = value; }
        public DateTime? last_date_purchase { get => sb_last_date_purchase; set => sb_last_date_purchase = value; }
        public DateTime? last_date_transaction_entry { get => sb_last_date_transaction_entry; set => sb_last_date_transaction_entry = value; }
        public DateTime? last_date_physical_count { get => sb_last_date_physical_count; set => sb_last_date_physical_count = value; }
        public int min_stock_level2 { get => sb_min_stock_level2; set => sb_min_stock_level2 = value; }
        public int max_stock_level2 { get => sb_max_stock_level2; set => sb_max_stock_level2 = value; }
        public string moving_status { get => sb_moving_status; set => sb_moving_status = value; }
    }
}
