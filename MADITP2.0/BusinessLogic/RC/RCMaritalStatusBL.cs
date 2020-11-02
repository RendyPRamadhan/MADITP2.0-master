using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.RC
{
    class RCMaritalStatusBL
    {
        private int id;
        private string marital_status;
        private DateTime created_at;
        private DateTime updated_at;

        public int Id { get => id; set => id = value; }
        public string Marital_status { get => marital_status; set => marital_status = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
