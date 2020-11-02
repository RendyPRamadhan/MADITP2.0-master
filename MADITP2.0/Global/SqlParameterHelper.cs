using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.Global
{
    class SqlParameterHelper
    {
        string _NAME;
        public string PARAMETR_NAME
        {
            get { return _NAME; }
            set { _NAME = value; }
        }
        object _VALUE;
        public object VALUE
        {
            get { return _VALUE; }
            set { _VALUE = value; }
        }
    }
}
