using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.RC
{
    class RCEducationBL
    {
        private int id;
        private string education_name;
        private DateTime created_at;
        private DateTime updated_at;

        public int Id { get => id; set => id = value; }
        public string Education_name { get => education_name; set => education_name = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
