using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOMasterGroupProductBL
    {
        private string gp_product_group_id;
        private string gp_group_description;
        private string gp_gl_account;
        private string gp_user_define_field1;
        private string gp_user_define_field2;
        private string gp_user_define_field3;


        public string Gp_product_group_id { get => gp_product_group_id; set => gp_product_group_id = value; }
        public string Gp_group_description { get => gp_group_description; set => gp_group_description = value; }
        public string Gp_gl_account { get => gp_gl_account; set => gp_gl_account = value; }
        public string Gp_user_define_field1 { get => gp_user_define_field1; set => gp_user_define_field1 = value; }
        public string Gp_user_define_field2 { get => gp_user_define_field2; set => gp_user_define_field2 = value; }
        public string Gp_user_define_field3 { get => gp_user_define_field3; set => gp_user_define_field3 = value; }
    }
}
