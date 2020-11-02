using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    class IMTransactionTypeBL
    {
        private string txn_type_code;
        private string txn_type_description;
        private string allow_inventory_txn_entry;
        private string allow_negative_qty_entry;
        private string negate_qty_entered;
        private string allow_change_date;
        private string promth_cost_field;
        private string update_qty_on_hand;
        private string update_stock_movement;
        private string interface_to_gl;
        private string gl_txn_type;
        private string in_out_flag;
        private string group_acc;

        public string Txn_type_code { get => txn_type_code; set => txn_type_code = value; }
        public string Txn_type_description { get => txn_type_description; set => txn_type_description = value; }
        public string Allow_inventory_txn_entry { get => allow_inventory_txn_entry; set => allow_inventory_txn_entry = value; }
        public string Allow_negative_qty_entry { get => allow_negative_qty_entry; set => allow_negative_qty_entry = value; }
        public string Negate_qty_entered { get => negate_qty_entered; set => negate_qty_entered = value; }
        public string Allow_change_date { get => allow_change_date; set => allow_change_date = value; }
        public string Promth_cost_field { get => promth_cost_field; set => promth_cost_field = value; }
        public string Update_qty_on_hand { get => update_qty_on_hand; set => update_qty_on_hand = value; }
        public string Update_stock_movement { get => update_stock_movement; set => update_stock_movement = value; }
        public string Interface_to_gl { get => interface_to_gl; set => interface_to_gl = value; }
        public string Gl_txn_type { get => gl_txn_type; set => gl_txn_type = value; }
        public string In_out_flag { get => in_out_flag; set => in_out_flag = value; }
        public string Group_acc { get => group_acc; set => group_acc = value; }
    }
}
