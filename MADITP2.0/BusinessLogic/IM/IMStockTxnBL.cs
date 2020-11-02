using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    public class IMStockTxnBL
    {
        private string st_warehouse_id;
        private string st_product_id;
        private DateTime? st_txn_date;
        private string st_txn_type_code;
        private int st_txn_type_seq_no;
        private int st_txn_type_index;
        private int st_txn_quantity;
        private decimal st_txn_cost_value;
        private decimal st_txn_selling_value;
        private DateTime? st_creation_date;
        private string st_txn_description;
        private string st_txn_reference;
        private string st_customer_supplier_id;
        private string st_from_warehouse_id;
        private string st_to_warehouse_id;
        private string st_gl_interface_status;
        private DateTime? st_gl_interface_date;
        private string st_user_id;
        private string st_transfer_status;
        private string st_gl_txn_type;
        private string st_interface_to_gl;
        private int st_qty_received;
        private int st_qty_pod;
        private string st_po_to_ap;

        public string warehouse_id { get => st_warehouse_id; set => st_warehouse_id = value; }
        public string product_id { get => st_product_id; set => st_product_id = value; }
        public DateTime? txn_date { get => st_txn_date; set => st_txn_date = value; }
        public string txn_type_code { get => st_txn_type_code; set => st_txn_type_code = value; }
        public int txn_type_seq_no { get => st_txn_type_seq_no; set => st_txn_type_seq_no = value; }
        public int txn_type_index { get => st_txn_type_index; set => st_txn_type_index = value; }
        public int txn_quantity { get => st_txn_quantity; set => st_txn_quantity = value; }
        public decimal txn_cost_value { get => st_txn_cost_value; set => st_txn_cost_value = value; }
        public decimal txn_selling_value { get => st_txn_selling_value; set => st_txn_selling_value = value; }
        public DateTime? creation_date { get => st_creation_date; set => st_creation_date = value; }
        public string txn_description { get => st_txn_description; set => st_txn_description = value; }
        public string txn_reference { get => st_txn_reference; set => st_txn_reference = value; }
        public string customer_supplier_id { get => st_customer_supplier_id; set => st_customer_supplier_id = value; }
        public string from_warehouse_id { get => st_from_warehouse_id; set => st_from_warehouse_id = value; }
        public string to_warehouse_id { get => st_to_warehouse_id; set => st_to_warehouse_id = value; }
        public string gl_interface_status { get => st_gl_interface_status; set => st_gl_interface_status = value; }
        public DateTime? gl_interface_date { get => st_gl_interface_date; set => st_gl_interface_date = value; }
        public string user_id { get => st_user_id; set => st_user_id = value; }
        public string transfer_status { get => st_transfer_status; set => st_transfer_status = value; }
        public string gl_txn_type { get => st_gl_txn_type; set => st_gl_txn_type = value; }
        public string interface_to_gl { get => st_interface_to_gl; set => st_interface_to_gl = value; }
        public int qty_received { get => st_qty_received; set => st_qty_received = value; }
        public int qty_pod { get => st_qty_pod; set => st_qty_pod = value; }
        public string po_to_ap { get => st_po_to_ap; set => st_po_to_ap = value; }
    }
}
