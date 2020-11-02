using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    public class IMStockMovementBL
    {
        private string sm_fiscal_year;
        private string sm_warehouse_id;
        private string sm_product_id;
        private int sm_opening_year_qty;
        private decimal sm_opening_year_cost;
        private int sm_total_in_qty_1;
        private int sm_total_in_qty_2;
        private int sm_total_in_qty_3;
        private int sm_total_in_qty_4;
        private int sm_total_in_qty_5;
        private int sm_total_in_qty_6;
        private int sm_total_in_qty_7;
        private int sm_total_in_qty_8;
        private int sm_total_in_qty_9;
        private int sm_total_in_qty_10;
        private int sm_total_in_qty_11;
        private int sm_total_in_qty_12;
        private decimal sm_total_in_cost_1;
        private decimal sm_total_in_cost_2;
        private decimal sm_total_in_cost_3;
        private decimal sm_total_in_cost_4;
        private decimal sm_total_in_cost_5;
        private decimal sm_total_in_cost_6;
        private decimal sm_total_in_cost_7;
        private decimal sm_total_in_cost_8;
        private decimal sm_total_in_cost_9;
        private decimal sm_total_in_cost_10;
        private decimal sm_total_in_cost_11;
        private decimal sm_total_in_cost_12;
        private int sm_total_out_qty_1;
        private int sm_total_out_qty_2;
        private int sm_total_out_qty_3;
        private int sm_total_out_qty_4;
        private int sm_total_out_qty_5;
        private int sm_total_out_qty_6;
        private int sm_total_out_qty_7;
        private int sm_total_out_qty_8;
        private int sm_total_out_qty_9;
        private int sm_total_out_qty_10;
        private int sm_total_out_qty_11;
        private int sm_total_out_qty_12;
        private decimal sm_total_out_cost_1;
        private decimal sm_total_out_cost_2;
        private decimal sm_total_out_cost_3;
        private decimal sm_total_out_cost_4;
        private decimal sm_total_out_cost_5;
        private decimal sm_total_out_cost_6;
        private decimal sm_total_out_cost_7;
        private decimal sm_total_out_cost_8;
        private decimal sm_total_out_cost_9;
        private decimal sm_total_out_cost_10;
        private decimal sm_total_out_cost_11;
        private decimal sm_total_out_cost_12;

        public string fiscal_year { get => sm_fiscal_year; set => sm_fiscal_year = value; }
        public string warehouse_id { get => sm_warehouse_id; set => sm_warehouse_id = value; }
        public string product_id { get => sm_product_id; set => sm_product_id = value; }
        public int opening_year_qty { get => sm_opening_year_qty; set => sm_opening_year_qty = value; }
        public decimal opening_year_cost { get => sm_opening_year_cost; set => sm_opening_year_cost = value; }
        public int total_in_qty_1 { get => sm_total_in_qty_1; set => sm_total_in_qty_1 = value; }
        public int total_in_qty_2 { get => sm_total_in_qty_2; set => sm_total_in_qty_2 = value; }
        public int total_in_qty_3 { get => sm_total_in_qty_3; set => sm_total_in_qty_3 = value; }
        public int total_in_qty_4 { get => sm_total_in_qty_4; set => sm_total_in_qty_4 = value; }
        public int total_in_qty_5 { get => sm_total_in_qty_5; set => sm_total_in_qty_5 = value; }
        public int total_in_qty_6 { get => sm_total_in_qty_6; set => sm_total_in_qty_6 = value; }
        public int total_in_qty_7 { get => sm_total_in_qty_7; set => sm_total_in_qty_7 = value; }
        public int total_in_qty_8 { get => sm_total_in_qty_8; set => sm_total_in_qty_8 = value; }
        public int total_in_qty_9 { get => sm_total_in_qty_9; set => sm_total_in_qty_9 = value; }
        public int total_in_qty_10 { get => sm_total_in_qty_10; set => sm_total_in_qty_10 = value; }
        public int total_in_qty_11 { get => sm_total_in_qty_11; set => sm_total_in_qty_11 = value; }
        public int total_in_qty_12 { get => sm_total_in_qty_12; set => sm_total_in_qty_12 = value; }
        public decimal total_in_cost_1 { get => sm_total_in_cost_1; set => sm_total_in_cost_1 = value; }
        public decimal total_in_cost_2 { get => sm_total_in_cost_2; set => sm_total_in_cost_2 = value; }
        public decimal total_in_cost_3 { get => sm_total_in_cost_3; set => sm_total_in_cost_3 = value; }
        public decimal total_in_cost_4 { get => sm_total_in_cost_4; set => sm_total_in_cost_4 = value; }
        public decimal total_in_cost_5 { get => sm_total_in_cost_5; set => sm_total_in_cost_5 = value; }
        public decimal total_in_cost_6 { get => sm_total_in_cost_6; set => sm_total_in_cost_6 = value; }
        public decimal total_in_cost_7 { get => sm_total_in_cost_7; set => sm_total_in_cost_7 = value; }
        public decimal total_in_cost_8 { get => sm_total_in_cost_8; set => sm_total_in_cost_8 = value; }
        public decimal total_in_cost_9 { get => sm_total_in_cost_9; set => sm_total_in_cost_9 = value; }
        public decimal total_in_cost_10 { get => sm_total_in_cost_10; set => sm_total_in_cost_10 = value; }
        public decimal total_in_cost_11 { get => sm_total_in_cost_11; set => sm_total_in_cost_11 = value; }
        public decimal total_in_cost_12 { get => sm_total_in_cost_12; set => sm_total_in_cost_12 = value; }
        public int total_out_qty_1 { get => sm_total_out_qty_1; set => sm_total_out_qty_1 = value; }
        public int total_out_qty_2 { get => sm_total_out_qty_2; set => sm_total_out_qty_2 = value; }
        public int total_out_qty_3 { get => sm_total_out_qty_3; set => sm_total_out_qty_3 = value; }
        public int total_out_qty_4 { get => sm_total_out_qty_4; set => sm_total_out_qty_4 = value; }
        public int total_out_qty_5 { get => sm_total_out_qty_5; set => sm_total_out_qty_5 = value; }
        public int total_out_qty_6 { get => sm_total_out_qty_6; set => sm_total_out_qty_6 = value; }
        public int total_out_qty_7 { get => sm_total_out_qty_7; set => sm_total_out_qty_7 = value; }
        public int total_out_qty_8 { get => sm_total_out_qty_8; set => sm_total_out_qty_8 = value; }
        public int total_out_qty_9 { get => sm_total_out_qty_9; set => sm_total_out_qty_9 = value; }
        public int total_out_qty_10 { get => sm_total_out_qty_10; set => sm_total_out_qty_10 = value; }
        public int total_out_qty_11 { get => sm_total_out_qty_11; set => sm_total_out_qty_11 = value; }
        public int total_out_qty_12 { get => sm_total_out_qty_12; set => sm_total_out_qty_12 = value; }
        public decimal total_out_cost_1 { get => sm_total_out_cost_1; set => sm_total_out_cost_1 = value; }
        public decimal total_out_cost_2 { get => sm_total_out_cost_2; set => sm_total_out_cost_2 = value; }
        public decimal total_out_cost_3 { get => sm_total_out_cost_3; set => sm_total_out_cost_3 = value; }
        public decimal total_out_cost_4 { get => sm_total_out_cost_4; set => sm_total_out_cost_4 = value; }
        public decimal total_out_cost_5 { get => sm_total_out_cost_5; set => sm_total_out_cost_5 = value; }
        public decimal total_out_cost_6 { get => sm_total_out_cost_6; set => sm_total_out_cost_6 = value; }
        public decimal total_out_cost_7 { get => sm_total_out_cost_7; set => sm_total_out_cost_7 = value; }
        public decimal total_out_cost_8 { get => sm_total_out_cost_8; set => sm_total_out_cost_8 = value; }
        public decimal total_out_cost_9 { get => sm_total_out_cost_9; set => sm_total_out_cost_9 = value; }
        public decimal total_out_cost_10 { get => sm_total_out_cost_10; set => sm_total_out_cost_10 = value; }
        public decimal total_out_cost_11 { get => sm_total_out_cost_11; set => sm_total_out_cost_11 = value; }
        public decimal total_out_cost_12 { get => sm_total_out_cost_12; set => sm_total_out_cost_12 = value; }
    }
}
