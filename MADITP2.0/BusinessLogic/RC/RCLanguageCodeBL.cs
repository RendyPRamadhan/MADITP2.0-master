using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.RC
{
    class RCLanguageCodeBL
    {
        private int languange_id;
        private string language;

        public int Id { get => languange_id; set => languange_id = value; }
        public string Language { get => language; set => language = value; }
    }
}
