using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOInvoiceDetailBL
    {
        private string sid_invoice_num;
        private int sid_invoice_index_num;
        private DateTime sid_invoice_date;
        private int sid_so_kp_index_num;
        private string sid_line_type;
        private string sid_product_id;
        private string sid_product_type;
        private string sid_unit_measure;
        private int sid_konversion_factor;
        private int sid_qty_ordered;
        private int sid_qty_invoiced;
        private string sid_unit_price_id;
        private int sid_unit_price;
        private int sid_total_price;
        private int sid_discount_amount;
        private int sid_net_line_amount;
        private int sid_dp_uang_muka;
        private int sid_bonus_discount_amount;
        private string sid_include_tax_flag;
        private int sid_taxable_amount_per_line;
        private string sid_tax_code;
        private string sid_gov_tax_dependent;
        private int sid_ppn_amount;
        private int sid_tax_ppn_bm;
        private int sid_invoice_line_value;
        private int sid_cost_value;
        private int sid_detail_line_bv;
        private int sid_detail_line_pv;
        private int sid_detail_line_p1;
        private int sid_detail_line_p2;
        private string sid_sales_type;
        private int sid_ppn_minus_factor;
        private int sid_su_cash;
        private int sid_allocation_value_group;
        private int sid_dpp;
        private int sid_ppn;
        private string sid_sts_tax;
        private string sid_no_pajak;
        private string sid_tax_id;
        private int sid_detail_line_su_temp;
        private int sid_detail_line_su;
        private string sid_seq_tax;
        private int sid_qty_shipped_up_to_date;
        private int sid_qty_outstanding_order_shp;
        private string sid_status_of_delivery;
        private string sid_partial_status;
        private string sid_so_kp_number;
        private int sid_qty_plan;

        public string Invoice_Num { get => sid_invoice_num; set => sid_invoice_num = value; }
        public int Invoice_Index_Num { get => sid_invoice_index_num; set => sid_invoice_index_num = value; }
        public DateTime Invoice_Date { get => sid_invoice_date; set => sid_invoice_date = value; }
        public int So_Kp_Index_Num { get => sid_so_kp_index_num; set => sid_so_kp_index_num = value; }
        public string Line_Type { get => sid_line_type; set => sid_line_type = value; }
        public string Product_Id { get => sid_product_id; set => sid_product_id = value; }
        public string Product_Type { get => sid_product_type; set => sid_product_type = value; }
        public string Unit_Measure { get => sid_unit_measure; set => sid_unit_measure = value; }
        public int Konversion_Factor { get => sid_konversion_factor; set => sid_konversion_factor = value; }
        public int Qty_Ordered { get => sid_qty_ordered; set => sid_qty_ordered = value; }
        public int Qty_Invoiced { get => sid_qty_invoiced; set => sid_qty_invoiced = value; }
        public string Unit_Price_Id { get => sid_unit_price_id; set => sid_unit_price_id = value; }
        public int Unit_Price { get => sid_unit_price; set => sid_unit_price = value; }
        public int Total_Price { get => sid_total_price; set => sid_total_price = value; }
        public int Discount_Amount { get => sid_discount_amount; set => sid_discount_amount = value; }
        public int Net_Line_Amount { get => sid_net_line_amount; set => sid_net_line_amount = value; }
        public int Dp_Uang_Muka { get => sid_dp_uang_muka; set => sid_dp_uang_muka = value; }
        public int Bonus_Discount_Amount { get => sid_bonus_discount_amount; set => sid_bonus_discount_amount = value; }
        public string Include_Tax_Flag { get => sid_include_tax_flag; set => sid_include_tax_flag = value; }
        public int Taxable_Amount_Per_Line { get => sid_taxable_amount_per_line; set => sid_taxable_amount_per_line = value; }
        public string Tax_Code { get => sid_tax_code; set => sid_tax_code = value; }
        public string Gov_Tax_Dependent { get => sid_gov_tax_dependent; set => sid_gov_tax_dependent = value; }
        public int Ppn_Amount { get => sid_ppn_amount; set => sid_ppn_amount = value; }
        public int Tax_Ppn_Bm { get => sid_tax_ppn_bm; set => sid_tax_ppn_bm = value; }
        public int Invoice_Line_Value { get => sid_invoice_line_value; set => sid_invoice_line_value = value; }
        public int Cost_Value { get => sid_cost_value; set => sid_cost_value = value; }
        public int Detail_Line_Bv { get => sid_detail_line_bv; set => sid_detail_line_bv = value; }
        public int Detail_Line_Pv { get => sid_detail_line_pv; set => sid_detail_line_pv = value; }
        public int Detail_Line_P1 { get => sid_detail_line_p1; set => sid_detail_line_p1 = value; }
        public int Detail_Line_P2 { get => sid_detail_line_p2; set => sid_detail_line_p2 = value; }
        public string Sales_Type { get => sid_sales_type; set => sid_sales_type = value; }
        public int Ppn_Minus_Factor { get => sid_ppn_minus_factor; set => sid_ppn_minus_factor = value; }
        public int Su_Cash { get => sid_su_cash; set => sid_su_cash = value; }
        public int Allocation_Value_Group { get => sid_allocation_value_group; set => sid_allocation_value_group = value; }
        public int Dpp { get => sid_dpp; set => sid_dpp = value; }
        public int Ppn { get => sid_ppn; set => sid_ppn = value; }
        public string Sts_Tax { get => sid_sts_tax; set => sid_sts_tax = value; }
        public string No_Pajak { get => sid_no_pajak; set => sid_no_pajak = value; }
        public string Tax_Id { get => sid_tax_id; set => sid_tax_id = value; }
        public int Detail_Line_Su_Temp { get => sid_detail_line_su_temp; set => sid_detail_line_su_temp = value; }
        public int Detail_Line_Su { get => sid_detail_line_su; set => sid_detail_line_su = value; }
        public string Seq_Tax { get => sid_seq_tax; set => sid_seq_tax = value; }
        public int Qty_Shipped_Up_To_Date { get => sid_qty_shipped_up_to_date; set => sid_qty_shipped_up_to_date = value; }
        public int Qty_Outstanding_Order_Shp { get => sid_qty_outstanding_order_shp; set => sid_qty_outstanding_order_shp = value; }
        public string Status_Of_Delivery { get => sid_status_of_delivery; set => sid_status_of_delivery = value; }
        public string Partial_Status { get => sid_partial_status; set => sid_partial_status = value; }
        public string So_Kp_Number { get => sid_so_kp_number; set => sid_so_kp_number = value; }
        public int Qty_Plan { get => sid_qty_plan; set => sid_qty_plan = value; }
    }
}
