using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    public class SOMasterCategoryProductBL
    {
        private string ID;
        private string Description;
        public string category_product_id { get => ID; set => ID = value; }
        public string category_product_description { get => Description; set => Description = value; }
    }
}
