using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOCustomerGroupBL
    {
        private string customer_group_id;
        private string customer_group_description;
        private string default_price_list;
        private string gl_account_mask;

        public string Customer_group_id { get => customer_group_id; set => customer_group_id = value; }
        public string Customer_group_description { get => customer_group_description; set => customer_group_description = value; }
        public string Default_price_list { get => default_price_list; set => default_price_list = value; }
        public string Gl_account_mask { get => gl_account_mask; set => gl_account_mask = value; }
    }
}
