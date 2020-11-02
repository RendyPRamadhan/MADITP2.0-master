using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    public class IMTukarBarangBL
    {
        private string Warehouse_id;
        private string Warehouse_id_in;
        private string Warehouse_id_out;
        private string Product_id;
        private string Product_description;
        private string Product_type;
        private string Txn_date;
        private string Txn_type_code;
        private string Txn_type_seq_no;
        private string Txn_quantity;
        private string Product_group_id;
        private string Product_subgroup_id;
        private string Txn_reference;
        private string Txn_date_from;
        private string Txn_date_to;
        private string Memo;
        private string Qty_on_hand;
        private string Qty_available;
        private string Unit_cost;
        private string Total_cost;
        private bool Check;

        public string warehouse_id { get => Warehouse_id; set => Warehouse_id = value; }
        public string warehouse_id_in { get => Warehouse_id_in; set => Warehouse_id_in = value; }
        public string warehouse_id_out { get => Warehouse_id_out; set => Warehouse_id_out = value; }
        public string product_id { get => Product_id; set => Product_id = value; }
        public string product_description { get => Product_description; set => Product_description = value; }
        public string product_type { get => Product_type; set => Product_type = value; }
        public string txn_date { get => Txn_date; set => Txn_date = value; }
        public string txn_type_code { get => Txn_type_code; set => Txn_type_code = value; }
        public string txn_type_seq_no { get => Txn_type_seq_no; set => Txn_type_seq_no = value; }
        public string txn_quantity { get => Txn_quantity; set => Txn_quantity = value; }
        public string product_group_id { get => Product_group_id; set => Product_group_id = value; }
        public string product_subgroup_id { get => Product_subgroup_id; set => Product_subgroup_id = value; }
        public string txn_reference { get => Txn_reference; set => Txn_reference = value; }
        public string txn_date_from { get => Txn_date_from; set => Txn_date_from = value; }
        public string txn_date_to { get => Txn_date_to; set => Txn_date_to = value; }
        public string memo { get => Memo; set => Memo = value; }
        public string qty_on_hand { get => Qty_on_hand; set => Qty_on_hand = value; }
        public string qty_available { get => Qty_available; set => Qty_available = value; }
        public string unit_cost { get => Unit_cost; set => Unit_cost = value; }
        public string total_cost { get => Total_cost; set => Total_cost = value; }
        public bool check { get => Check; set => Check = value; }
    }
}
