using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.GS
{
    public class GSSequenceNumberEditorBL
    {
        private string sn_id;
        private long sn_last_number;
        private long sn_minimum;
        private long sn_maximum;

        public string id { get => sn_id; set => sn_id = value; }
        public long last_number { get => sn_last_number; set => sn_last_number = value; }
        public long minimum { get => sn_minimum; set => sn_minimum = value; }
        public long maximum { get => sn_maximum; set => sn_maximum = value; }
    }
}
