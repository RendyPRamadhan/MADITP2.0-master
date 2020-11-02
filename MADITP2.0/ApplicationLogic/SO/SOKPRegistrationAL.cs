using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System.Data;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOKPRegistrationAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        SOKPRegistrationDA Accessor;

        public SOKPRegistrationAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new SOKPRegistrationDA(Helper, Alert);
        }

        public List<ComboBoxViewModel> GetEntity(bool all)
        {
            return Accessor.GetEntity(all);
        }

        public List<ComboBoxViewModel> GetBranch(bool all)
        {
            return Accessor.GetBranch(all);
        }

        public List<ComboBoxViewModel> GetDivision(bool all)
        {
            return Accessor.GetDivision(all);
        }

        public List<ComboBoxViewModel> GetStatus(bool all)
        {
            return Accessor.GetStatus(all);
        }

        public DataTable SearchData(SOKPRegistrationBL Entity)
        {
            return Accessor.SearchData(Entity);
        }

        public void Create(SOKPRegistrationBL Entity)
        {
            Accessor.Create(Entity);
        }

        public void Update(SOKPRegistrationBL Entity)
        {
            Accessor.Update(Entity);
        }

        public void Delete(SOKPRegistrationBL Entity)
        {
            Accessor.Delete(Entity);
        }
    }
}
