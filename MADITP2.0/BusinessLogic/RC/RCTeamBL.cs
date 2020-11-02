using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.RC
{
    class RCTeamBL
    {
        private string rt_id;
        private string rt_desc;

        public string Id { get => rt_id; set => rt_id = value; }
        public string Description { get => rt_desc; set => rt_desc = value; }
    }
}
