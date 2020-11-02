namespace MADITP2._0.businessLogic.SO
{
    public class SOOrderTypeBL
    {
        private string ot_order_type;
        private string ot_desc;
        private string ot_transaction_type;
        private string ot_edit_price_allowed;
        private string ot_edit_date_allowed;
        private string ot_order_allowed;
        private string ot_edit_after_release_allowed;
        private string ot_default_price_list;
        private string ot_non_inventory_txn_type;
        private string ot_inventory_txn_type;
        private string ot_bonus_txn_type;
        private string ot_invoice_type;
        private string ot_inventory_return_txn_type;

        public string orderType
        {
            get { return ot_order_type; }
            set { this.ot_order_type = value; }
        }

        public string orderTypeDesc
        {
            get { return ot_desc; }
            set { this.ot_desc = value; }
        }

        public string transactionType
        {
            get { return ot_transaction_type; }
            set { this.ot_transaction_type = value; }
        }

        public string editPrice
        {
            get { return ot_edit_price_allowed; }
            set { this.ot_edit_price_allowed = value; }
        }

        public string editDate
        {
            get { return ot_edit_date_allowed; }
            set { this.ot_edit_date_allowed = value; }
        }

        public string editOrder
        {
            get { return ot_order_allowed; }
            set { this.ot_order_allowed = value; }
        }

        public string editAfterRelease
        {
            get { return ot_edit_after_release_allowed; }
            set { this.ot_edit_after_release_allowed = value; }
        }

        public string defaultPriceList
        {
            get { return ot_default_price_list; }
            set { this.ot_default_price_list = value; }
        }

        public string nonInventoryType
        {
            get { return ot_non_inventory_txn_type; }
            set { this.ot_non_inventory_txn_type = value; }
        }

        public string inventoryType
        {
            get { return ot_inventory_txn_type; }
            set { this.ot_inventory_txn_type = value; }
        }

        public string bonusType
        {
            get { return ot_bonus_txn_type; }
            set { this.ot_bonus_txn_type = value; }
        }

        public string invoiceType
        {
            get { return ot_invoice_type; }
            set { this.ot_invoice_type = value; }
        }

        public string inventoryReturnType
        {
            get { return ot_inventory_return_txn_type; }
            set { this.ot_inventory_return_txn_type = value; }
        }
    }
}
