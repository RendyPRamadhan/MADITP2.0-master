using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    class IMMasterProductSubGroupBL
    {
        private string Group_id;
        private string SubGroup_id;
        private string Description;
        private string GLAccount;
        private int UserDefineField1;
        private string UserDefineField2;
        private string UserDefineField3;

        public string group_id { get => Group_id; set => Group_id = value; }
        public string subgroup_id { get => SubGroup_id; set => SubGroup_id = value; }
        public string description { get => Description; set => Description = value; }
        public string glAccount { get => GLAccount; set => GLAccount = value; }
        public int userdefinefield1 { get => UserDefineField1; set => UserDefineField1 = value; }
        public string userdefinefield2 { get => UserDefineField2; set => UserDefineField2 = value; }
        public string userdefinefield3 { get => UserDefineField3; set => UserDefineField3 = value; }
    }
}
