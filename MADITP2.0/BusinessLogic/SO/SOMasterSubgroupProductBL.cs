using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOMasterSubgroupProductBL
    {
        private string sp_product_group_id;
        private string sp_product_subgroup_id;
        private string sp_product_subgroup_description;
        private string sp_gl_account;
        private string sp_user_define_field1;
        private string sp_user_define_field2;
        private string sp_user_define_field3;


        public string Sp_product_group_id { get => sp_product_group_id; set => sp_product_group_id = value; }
        public string Sp_product_subgroup_id { get => sp_product_subgroup_id; set => sp_product_subgroup_id = value; }
        public string Sp_product_subgroup_description { get => sp_product_subgroup_description; set => sp_product_subgroup_description = value; }
        public string Sp_gl_account { get => sp_gl_account; set => sp_gl_account = value; }
        public string Sp_user_define_field1 { get => sp_user_define_field1; set => sp_user_define_field1 = value; }
        public string Sp_user_define_field2 { get => sp_user_define_field2; set => sp_user_define_field2 = value; }
        public string Sp_user_define_field3 { get => sp_user_define_field3; set => sp_user_define_field3 = value; }
    }
}
