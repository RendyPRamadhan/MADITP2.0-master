using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    public class IMOtherStockTransactionEntryBL
    {
        private string Warehouse_id;
        private string Txn_type_id;
        private string Group_id;
        private string Sub_group_id;
        private string Print_date;
        private string Product_id;
        private string Range_date_from;
        private string Range_date_to;
        private string Product_description;
        private string Transaction_date;
        private string Transaction_type;
        private Int64 Sequence;
        private string Qty;
        private string Reference;
        private string Txn_date;
        private string Memo;
        private string Product_type;
        private string Unit_cost;
        private string Total_cost;
        private string Qty_on_hand;
        private string Qty_available;



        public string warehouse_id { get => Warehouse_id; set => Warehouse_id = value; }
        public string txn_type_id { get => Txn_type_id; set => Txn_type_id = value; }
        public string group_id { get => Group_id; set => Group_id = value; }
        public string sub_group_id { get => Sub_group_id; set => Sub_group_id = value; }
        public string print_date { get => Print_date; set => Print_date = value; }
        public string product_id { get => Product_id; set => Product_id = value; }
        public string range_date_from { get => Range_date_from; set => Range_date_from = value; }
        public string range_date_to { get => Range_date_to; set => Range_date_to = value; }
        public string product_description { get => Product_description; set => Product_description = value; }
        public string transaction_date { get => Transaction_date; set => Transaction_date = value; }
        public string transaction_type { get => Transaction_type; set => Transaction_type = value; }
        public Int64 sequence { get => Sequence; set => Sequence = value; }
        public string qty { get => Qty; set => Qty = value; }
        public string reference { get => Reference; set => Reference = value; }
        public string txn_date { get => Txn_date; set => Txn_date = value; }
        public string memo { get => Memo; set => Memo = value; }
        public string product_type { get => Product_type; set => Product_type = value; }
        public string unit_cost { get => Unit_cost; set => Unit_cost = value; }
        public string total_cost { get => Total_cost; set => Total_cost = value; }
        public string qty_on_hand { get => Qty_on_hand; set => Qty_on_hand = value; }
        public string qty_available { get => Qty_available; set => Qty_available = value; }
    }
}
