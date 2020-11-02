using MADITP2._0.businessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System.Data;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOOrderTypeAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        SOOrderTypeDA Accessor;

        public SOOrderTypeAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new SOOrderTypeDA(Helper, Alert);
        }

        public DataTable Read()
        {
            return Accessor.Read();
        }

        public List<ComboBoxViewModel> GetTransaction()
        {
            var combo = new List<ComboBoxViewModel>();
            combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "Select Type", ValueMember = "" });
            combo.Insert(1, new ComboBoxViewModel() { DisplayMember = "Debit", ValueMember = "D" });
            combo.Insert(2, new ComboBoxViewModel() { DisplayMember = "Credit", ValueMember = "C" });
            return combo;
        }

        public List<ComboBoxViewModel> GetPriceList()
        {
            return Accessor.GetPriceList();
        }

        public List<ComboBoxViewModel> GetTransactionType()
        {
            return Accessor.GetTransactionType();
        }

        public List<ComboBoxViewModel> GetInvoiceType()
        {
            return Accessor.GetInvoiceType();
        }

        public void Update(SOOrderTypeBL Entity)
        {
            Accessor.Update(Entity);
        }

        public void Create(SOOrderTypeBL Entity)
        {
            Accessor.Create(Entity);
        }

        public void Delete(SOOrderTypeBL Entity)
        {
            Accessor.Delete(Entity);
        }
    }
}
