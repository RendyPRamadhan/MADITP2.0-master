using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    class IMTransferTypeBL
    {
        private string ttt_transfer_txn_type_code;
        private string ttt_transfer_txn_type_description;
        private string ttt_with_transit_warehouse;
        private string ttt_system_type;
        private string ttt_confirmation_transfer_required;
        private string ttt_txn_type_out_from_org_wh;
        private string ttt_txn_type_in_to_transit_wh;
        private string ttt_txn_type_out_from_transit_wh;
        private string ttt_txn_type_in_to_destination_wh;
        private string ttt_txn_type_out_from_transit_ex_pod;
        private string ttt_txn_type_into_or_wh_ex_pod;

        public string Transfer_txn_type_code { get => ttt_transfer_txn_type_code; set => ttt_transfer_txn_type_code = value; }
        public string Transfer_txn_type_description { get => ttt_transfer_txn_type_description; set => ttt_transfer_txn_type_description = value; }
        public string With_transit_warehouse { get => ttt_with_transit_warehouse; set => ttt_with_transit_warehouse = value; }
        public string System_type { get => ttt_system_type; set => ttt_system_type = value; }
        public string Confirmation_transfer_required { get => ttt_confirmation_transfer_required; set => ttt_confirmation_transfer_required = value; }
        public string Txn_type_out_from_org_wh { get => ttt_txn_type_out_from_org_wh; set => ttt_txn_type_out_from_org_wh = value; }
        public string Txn_type_in_to_transit_wh { get => ttt_txn_type_in_to_transit_wh; set => ttt_txn_type_in_to_transit_wh = value; }
        public string Txn_type_out_from_transit_wh { get => ttt_txn_type_out_from_transit_wh; set => ttt_txn_type_out_from_transit_wh = value; }
        public string Txn_type_in_to_destination_wh { get => ttt_txn_type_in_to_destination_wh; set => ttt_txn_type_in_to_destination_wh = value; }
        public string Txn_type_out_from_transit_ex_pod { get => ttt_txn_type_out_from_transit_ex_pod; set => ttt_txn_type_out_from_transit_ex_pod = value; }
        public string Txn_type_into_or_wh_ex_pod { get => ttt_txn_type_into_or_wh_ex_pod; set => ttt_txn_type_into_or_wh_ex_pod = value; }
    }
}
