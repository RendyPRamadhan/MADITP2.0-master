using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    class IMWarehouseTransferOutBL
    {
        public string st_warehouse_id { get; set; }
        public string st_product_id { get; set; }
        public DateTime st_txn_date { get; set; }
        public string st_txn_type_code { get; set; }
        public double st_txn_type_seq_no { get; set; }
        public int st_txn_type_index { get; set; }
        public int st_txn_quantity { get; set; }
        public double st_txn_cost_value { get; set; }
        public double st_txn_selling_value { get; set; }
        public DateTime st_creation_date { get; set; }
        public string st_txn_description { get; set; }
        public string st_txn_reference { get; set; }
        public string st_customer_supplier_id { get; set; }
        public string st_from_warehouse_id { get; set; }
        public string st_to_warehouse_id { get; set; }
        public string st_gl_interface_status { get; set; }
        public DateTime st_gl_interface_date { get; set; }
        public string st_user_id { get; set; }
        public string st_transfer_status { get; set; }
        public string st_gl_txn_type { get; set; }
        public string st_interface_to_gl { get; set; }
        public double st_qty_received { get; set; }
        public double st_qty_pod { get; set; }
        public string st_po_to_ap { get; set; }
    }
}
