using System;

namespace MADITP2._0.businessLogic.SO
{
    public class SOMasterPrincipalBL
    {
        private int smp_id;
        private string smp_name;
        private string smp_desc;
        private string smp_created_at;
        private string smp_updated_at;

 
        public int principal_id { get => smp_id; set => smp_id = value; }
        public string principal_name { get => smp_name; set => smp_name = value; }
        public string principal_desc { get => smp_desc; set => smp_desc = value; }
        public string principal_created_at { get => smp_created_at; set => smp_created_at = value; }
        public string principal_updated_at { get => smp_updated_at; set => smp_updated_at = value; }
    }
}
