using MADITP2._0.businessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOCancelVerificationAL
    {
        private clsGlobal Helper;
        private SOCancelVerificationDA Model;
        private SOVerificationProcessDA ModelVerificationProcess;
        private SOVerificatorMasterDA ModelVerificatorMaster;
        private clsAlert clsAlert;

        public SOCancelVerificationAL(clsGlobal helper)
        {
            Helper = helper;
            Model = new SOCancelVerificationDA(Helper);
            ModelVerificationProcess = new SOVerificationProcessDA(Helper);
            ModelVerificatorMaster = new SOVerificatorMasterDA(helper);
            clsAlert = new clsAlert();
        }

        public List<ComboBoxViewModel> GetCollectorToComboBox(bool _IsAll)
        {
            return ModelVerificationProcess.GetCollectorToComboBox(_IsAll);
        }

        public DataTable GetEndingDateCalenderFiscal()
        {
            return ModelVerificationProcess.GetEndingDateCalenderFiscal();
        }

        public DataTable GetStatusKPNo(string _KPNo)
        {
            return Model.GetStatusKPNo(_KPNo);
        }

        public DataTable GetKPNoDetail(string _KPNo)
        {
            return Model.GetKPNoDetail(_KPNo);
        }

        public DataTable GetDetailVerificatorByID(EnumFilter filter, SOVerificatorMasterBL clsBO, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            return ModelVerificatorMaster.Read(filter, clsBO, currentPage, fetchLimit);
        }

        public DataTable GetItemNoFromARKuitansi(string _KPNo)
        {
            return ModelVerificationProcess.GetItemNoFromARKuitansi(_KPNo);
        }

        public bool Delete(SOVerificationProcessBL clsBO)
        {
            bool _result = Model.Delete(clsBO);
            if (_result == true)
            {
                clsAlert.PushAlert("Cancelled Sucessfully!", clsAlert.Type.Success);
            }
            else
            {
                clsAlert.PushAlert("Error System, Failed to Canceling!", clsAlert.Type.Error);
                _result = false;
            }

            return _result;
        }
    }
}
