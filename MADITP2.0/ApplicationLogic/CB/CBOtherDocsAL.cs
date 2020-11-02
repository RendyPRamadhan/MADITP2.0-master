using MADITP2._0.DataAccess.CB;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MADITP2._0.ApplicationLogic.CB
{
    class CBOtherDocsAL
    {
        private clsGlobal Helper;
        private CBOtherDocsDA Model;
        private clsAlert clsAlert;

        public CBOtherDocsAL(clsGlobal helper)
        {
            Helper = helper;
            Model = new CBOtherDocsDA();
            clsAlert = new clsAlert();
        }

        public List<ComboBoxViewModel> GetBankToComboBox(bool _isAll)
        {
            return Model.GetMasterBankToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetVoucherTypeToComboBox(bool _isAll)
        {
            return Model.GetVoucherTypeToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetBankSubIDToComboBox(bool _isAll, string _BankID)
        {
            return Model.GetBankSubIDToComboBox(_isAll, _BankID);
        }

        public DataTable GetFiscalYear(string _EntityID)
        {
            return Model.GetFiscalYear(_EntityID);
        }
    }
}
