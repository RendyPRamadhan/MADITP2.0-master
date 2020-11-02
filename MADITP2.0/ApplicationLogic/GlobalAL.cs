using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic
{
    class GlobalAL
    {
        private clsGlobal Helper;

        public GlobalAL(clsGlobal helper)
        {
            Helper = helper;
        }

        public string GetTCode(string _menuName)
        {
            return Helper.GetTCode(_menuName);
        }

        public DataTable GetCompany()
        {
            return Helper.GetCompany();
        }

        public DataTable GetReport(string _Query)
        {
            return Helper.GetReport(_Query);
        }
    }
}
