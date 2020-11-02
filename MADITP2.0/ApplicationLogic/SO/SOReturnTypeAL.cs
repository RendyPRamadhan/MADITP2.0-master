using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System.Data;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOReturnTypeAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        SOReturnTypeDA Accessor;

        public SOReturnTypeAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new SOReturnTypeDA(Helper, Alert);
        }

        public DataTable Read()
        {
            return Accessor.Read();
        }

        public void Create(SOReturnTypeBL Entity)
        {
            Accessor.Create(Entity);
        }

        public void Update(SOReturnTypeBL Entity)
        {
            Accessor.Update(Entity);
        }

        public void Delete(SOReturnTypeBL Entity)
        {
            Accessor.Delete(Entity);
        }
    }
}
