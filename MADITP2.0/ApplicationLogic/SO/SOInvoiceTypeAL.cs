using MADITP2._0.businessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System.Data;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOInvoiceTypeAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        SOInvoiceTypeDA Accessor;

        public SOInvoiceTypeAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new SOInvoiceTypeDA(Helper, Alert);
        }

        public DataTable Read()
        {
            return Accessor.Read();
        }

        public DataTable Edit(SOInvoiceTypeBL Entity)
        {
            return Accessor.Edit(Entity);
        }

        public void Create(SOInvoiceTypeBL Entity)
        {
            Accessor.Create(Entity);
        }

        public void Update(SOInvoiceTypeBL Entity)
        {
            Accessor.Update(Entity);
        }

        public void Delete(SOInvoiceTypeBL Entity)
        {
            Accessor.Delete(Entity);
        }
    }
}
