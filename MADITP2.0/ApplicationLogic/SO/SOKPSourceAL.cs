using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System.Data;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOKPSourceAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        SOKPSourceDA Accessor;

        public SOKPSourceAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new SOKPSourceDA(Helper, Alert);
        }

        public DataTable Read()
        {
            return Accessor.Read();
        }

        public void Create(SOKPSourceBL Entity)
        {
            Accessor.Create(Entity);
        }

        public void Update(SOKPSourceBL Entity)
        {
            Accessor.Update(Entity);
        }

        public void Delete(SOKPSourceBL Entity)
        {
            Accessor.Delete(Entity);
        }

        public List<ComboBoxViewModel> GetSourceGroup()
        {
            return Accessor.GetSourceGroup();
        }
    }
}
