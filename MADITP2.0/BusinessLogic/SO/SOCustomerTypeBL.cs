
namespace MADITP2._0.BusinessLogic.SO
{
    class SOCustomerTypeBL
    {
        private string mCustomer_type;
        private string mCustomer_type_description;
        private string mDefault_price_list;
        private string mGl_account_mask;

        public string Customer_type { get => mCustomer_type; set => mCustomer_type = value; }
        public string Customer_type_description { get => mCustomer_type_description; set => mCustomer_type_description = value; }
        public string Default_price_list { get => mDefault_price_list; set => mDefault_price_list = value; }
        public string Gl_account_mask { get => mGl_account_mask; set => mGl_account_mask = value; }
    }
}
