using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    class IMWarehouseSecurityBL
    {
        private int ws_id;
        private string ws_user_id;
        private string ws_warehouse_id;
        private string ws_input_txn_allow;
        private string ws_transfer_txn_allow;
        private string ws_initial_physical;
        private string ws_realese_physical;
        private string ws_shipment_entry;
        private string ws_receipt_entry;

        public int Id { get => ws_id; set => ws_id = value; }
        public string User_id { get => ws_user_id; set => ws_user_id = value; }
        public string Warehouse_id { get => ws_warehouse_id; set => ws_warehouse_id = value; }
        public string Input_txn_allow { get => ws_input_txn_allow; set => ws_input_txn_allow = value; }
        public string Transfer_txn_allow { get => ws_transfer_txn_allow; set => ws_transfer_txn_allow = value; }
        public string Initial_physical { get => ws_initial_physical; set => ws_initial_physical = value; }
        public string Realese_physical { get => ws_realese_physical; set => ws_realese_physical = value; }
        public string Shipment_entry { get => ws_shipment_entry; set => ws_shipment_entry = value; }
        public string Receipt_entry { get => ws_receipt_entry; set => ws_receipt_entry = value; }
    }
}