using MADITP2._0.businessLogic.SO;
using MADITP2._0.DataAccess.GS;
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
    class SOVerificatorMasterAL
    {
        private clsGlobal Helper;
        private SOVerificatorMasterDA Model;
        //private GSEntityDA ModelEntity;
        //private GSBranchDA ModelBranch;
        private clsAlert clsAlert;

        public SOVerificatorMasterAL(clsGlobal helper)
        {
            Helper = helper;
            Model = new SOVerificatorMasterDA(Helper);
            clsAlert = new clsAlert();
        }

        public DataTable Read(EnumFilter filter, SOVerificatorMasterBL clsBO, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            return Model.Read(filter, clsBO, currentPage, fetchLimit);
        }

        public bool Post(SOVerificatorMasterBL clsBO)
        {
            bool _result = false;

            //Cek Verificator ID
            DataTable dt = Model.Read(EnumFilter.GET_SEARCH_ID, clsBO, 0, 0);
            if (dt.Rows.Count == 0)
            {
                _result = Model.Post(clsBO);
                if (_result == true)
                {
                    clsAlert.PushAlert("Saved Sucessfully!", clsAlert.Type.Success);
                }
                else
                {
                    clsAlert.PushAlert("Error System, Failed to Saving!", clsAlert.Type.Error);
                    _result = false;
                }
            }
            else
            {
                clsAlert.PushAlert("The Verificator ID is already exist!", clsAlert.Type.Error);
            }

            return _result;
        }

        public bool Put(SOVerificatorMasterBL clsBO)
        {
            bool _result = Model.Put(clsBO);
            if (_result == true)
            {
                clsAlert.PushAlert("Updated Sucessfully!", clsAlert.Type.Success);
            }
            else
            {
                clsAlert.PushAlert("Error System, Failed to Updating!", clsAlert.Type.Error);
                _result = false;
            }

            return _result;
        }

        public bool Delete(SOVerificatorMasterBL clsBO)
        {
            bool _result = Model.Delete(clsBO);
            if (_result == true)
            {
                clsAlert.PushAlert("Deleted Sucessfully!", clsAlert.Type.Success);
            }
            else
            {
                clsAlert.PushAlert("Error System, Failed to Deleting!", clsAlert.Type.Error);
                _result = false;
            }

            return _result;
        }

        public DataTable GetPropertyUser()
        {
            return Model.GetPropertyUser();
        }

        public List<ComboBoxViewModel> GetEntity(bool _isAll)
        {
            return Model.GetEntity(_isAll);
        }

        public List<ComboBoxViewModel> GetBranch(bool _isAll)
        {
            return Model.GetBranch(_isAll);
        }

        public List<ComboBoxViewModel> GetDivision(bool _isAll)
        {
            return Model.GetDivision(_isAll);
        }

        public List<ComboBoxViewModel> GetSupervisorToComboBox()
        {
            return Model.GetSupervisorToComboBox();
        }

        public DataTable GetCustomer(string _ParamCust)
        {
            return Model.GetCustomer(_ParamCust);
        }

        public DataTable GetZipCodes(string _ParamZipCode)
        {
            return Model.GetZipCodes(_ParamZipCode);
        }
    }
}
