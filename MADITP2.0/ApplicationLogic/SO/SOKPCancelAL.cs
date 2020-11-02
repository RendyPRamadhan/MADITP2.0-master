using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System.Data;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOKPCancelAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        SOKPCancelDA Accessor;

        public SOKPCancelAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new SOKPCancelDA(Helper, Alert);
        }

        public DataTable SearchData(SOKPCancelBL Entity)
        {
            return Accessor.SearchData(Entity);
        }

        public DataTable ReadGroup(SOKPCancelBL Entity)
        {
            return Accessor.ReadGroup(Entity);
        }

        public DataTable ReadProduct(SOKPCancelBL Entity)
        {
            return Accessor.ReadProduct(Entity);
        }

        public void Update(SOKPCancelBL Entity)
        {
            Accessor.Update(Entity);
        }
    }
}
