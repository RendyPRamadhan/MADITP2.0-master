using MADITP2._0.businessLogic.SO;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOVerificationProcessAL
    {
        private clsGlobal Helper;
        private SOVerificationProcessDA Model;
        private SOVerificatorMasterDA ModelVerificatorMaster;
        private clsAlert clsAlert;

        public SOVerificationProcessAL(clsGlobal helper)
        {
            Helper = helper;
            Model = new SOVerificationProcessDA(Helper);
            ModelVerificatorMaster = new SOVerificatorMasterDA(Helper);
            clsAlert = new clsAlert();
        }

        public DataTable ReadVsa(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _StateCboEntity = true, bool _StateCboBranch = true, string _UserID = "")
        {
            return Model.ReadVsa(filter, clsBL, currentPage, fetchLimit, _StateCboEntity, _StateCboBranch, _UserID);
        }

        public DataTable ReadVs(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _StateCboEntity = true, bool _StateCboBranch = true, bool _StateCboDivision = true, string _UserID = "", bool _IsKPDate = true, bool _IsAssignDate = true)
        {
            return Model.ReadVs(filter, clsBL, currentPage, fetchLimit, _StateCboEntity, _StateCboBranch, _StateCboDivision, _UserID, _IsKPDate, _IsAssignDate);
        }

        public DataTable ReadSor(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _StateCboEntity = true, bool _StateCboBranch = true, bool _StateCboDivision = true, string _UserID = "", bool _IsAssignDate = true)
        {
            return Model.ReadSor(filter, clsBL, currentPage, fetchLimit, _StateCboEntity, _StateCboBranch, _StateCboDivision, _UserID, _IsAssignDate);
        }

        public DataTable ReadActivity(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            return Model.ReadActivity(filter, clsBL, currentPage, fetchLimit);
        }

        public DataTable ReadKp(EnumFilter filter, SOVerificationProcessBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            return Model.ReadKp(filter, clsBL, currentPage, fetchLimit);
        }

        public List<ComboBoxViewModel> GetVerificatorToComboBox(SOVerificatorMasterBL clsBL, bool _isAll)
        {
            return ModelVerificatorMaster.GetVerificatorToComboBox(clsBL, _isAll);
        }

        public List<ComboBoxViewModel> GetVerificatorToComboBoxByUserProperty(bool _isAll, string _UserEntity, string _UserBranch, string _VerificatorName)
        {
            return ModelVerificatorMaster.GetVerificatorToComboBoxByUserProperty(_isAll, _UserEntity, _UserBranch, _VerificatorName);
        }

        public List<ComboBoxViewModel> GetEntity(bool _isAll)
        {
            return ModelVerificatorMaster.GetEntity(_isAll);
        }

        public List<ComboBoxViewModel> GetBranch(bool _isAll)
        {
            return ModelVerificatorMaster.GetBranch(_isAll);
        }

        public List<ComboBoxViewModel> GetDivision(bool _isAll)
        {
            return ModelVerificatorMaster.GetDivision(_isAll);
        }

        public DataTable getVerificatorDetail(EnumFilter filter, SOVerificatorMasterBL clsBL)
        {
            return ModelVerificatorMaster.Read(filter, clsBL, 0, 0);
        }

        public DataTable ValidateSOKPNumberVSA(string _KPNumber)
        {
            return Model.ValidateSOKPNumberVSA(_KPNumber);
        }

        public DataTable GetSOKPNumberDetailVSA(string _DataType, string _KPNumber, string _VerificatirEntityID, string _VerificatorName, String _VerificatorBranchID)
        {
            return Model.GetSOKPNumberDetailVSA(_DataType, _KPNumber, _VerificatirEntityID, _VerificatorName, _VerificatorBranchID);
        }

        public List<ComboBoxViewModel> GetSOKPNumberToComboBoxVSEditor(string _DataType, string _VerificatirEntityID)
        {
            return Model.GetSOKPNumberToComboBoxVSEditor(_DataType, _VerificatirEntityID);
        }

        public DataTable GetSOKPNumberDetailVsEditor(string _KPNumber, string _VerificatirEntityID)
        {
            return Model.GetSOKPNumberDetailVsEditor(_KPNumber, _VerificatirEntityID);
        }

        public DataTable GetQualificationHeader()
        {
            return Model.GetQualificationHeader();
        }

        public DataTable GetQualificationDetail()
        {
            return Model.GetQualificationDetail();
        }

        public DataTable GetQualifierValue(string _VerID, string _KPNo)
        {
            return Model.GetQualifierValue(_VerID, _KPNo);
        }

        public DataTable GetQualificationActivity(string _VerID, string _KPNo)
        {
            return Model.GetQualificationActivity(_VerID, _KPNo);
        }

        public DataTable GetMemoVisitingActivity(string _VerID, string _KPNo)
        {
            return Model.GetMemoVisitingActivity(_VerID, _KPNo);
        }

        public DataTable GetNotesVisitingActivity(string _KPNo)
        {
            return Model.GetNotesVisitingActivity(_KPNo);
        }

        public DataTable GetVerificationCustomer(string _CustID)
        {
            return Model.GetVerificationCustomer(_CustID);
        }

        public List<ComboBoxViewModel> GetReasonCodesToComboBox()
        {
            return Model.GetReasonCodesToComboBox();
        }

        public List<ComboBoxViewModel> GetCollectorToComboBox(bool _IsAll)
        {
            return Model.GetCollectorToComboBox(_IsAll);
        }

        public bool Post(SOVerificationProcessBL clsBL)
        {
            bool _result = false;

            _result = Model.Post(clsBL);
            if (_result == true)
            {
                clsAlert.PushAlert("Saved Sucessfully!", clsAlert.Type.Success);
            }
            else
            {
                clsAlert.PushAlert("Error System, Failed to Saving!", clsAlert.Type.Error);
                _result = false;
            }

            return _result;
        }

        public bool PostVS(DataGridView grdVerificationCustomer, DataGridView grdVisitingActivity, DataGridView grdQualifierHeader, SOVerificationProcessBL clsBL, string _VisaAuto)
        {
            bool _result = false;

            _result = Model.PostVS(grdVerificationCustomer, grdVisitingActivity, grdQualifierHeader, clsBL,  _VisaAuto);
            if (_result == true)
            {
                clsAlert.PushAlert("Saved Sucessfully!", clsAlert.Type.Success);
            }
            else
            {
                clsAlert.PushAlert("Error System, Failed to Saving!", clsAlert.Type.Error);
                _result = false;
            }

            return _result;
        }

        public bool PutVS(DataGridView grdVisitingActivity, SOVerificationProcessBL clsBL, string _VisaAuto)
        {
            bool _result = false;

            _result = Model.PutVS(grdVisitingActivity, clsBL, _VisaAuto);
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

        public bool PutReleaseVS(DataGridView grdVerificationCustomer, DataGridView grdVisitingActivity, DataGridView grdQualifierHeader, SOVerificationProcessBL clsBL, string _VisaAuto)
        {
            bool _result = false;

            _result = Model.PutReleaseVS(grdVerificationCustomer, grdVisitingActivity, grdQualifierHeader, clsBL, _VisaAuto);
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

        public bool Put(string _VerificatorIDOld, SOVerificationProcessBL clsBL)
        {
            bool _result = Model.Put(_VerificatorIDOld, clsBL);
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

        public bool PostSOR(SOVerificationProcessBL clsBL, DateTime _DeliveryDate, string _CollID, string _FlagEdit, string _UserID, string _HomePhone, string _MobilePhone, string _EmpPhone)
        {
            bool _result = false;

            _result = Model.PostSOR(clsBL, _DeliveryDate, _CollID, _FlagEdit, _UserID, _HomePhone, _MobilePhone, _EmpPhone);
            if (_result == true)
            {
                clsAlert.PushAlert("Saved Sucessfully!", clsAlert.Type.Success);
            }
            else
            {
                clsAlert.PushAlert("Error System, Failed to Saving!", clsAlert.Type.Error);
                _result = false;
            }

            return _result;
        }

        public bool PutSOR(SOVerificationProcessBL clsBL, DateTime _DeliveryDate, string _CollID, string _FlagEdit, string _UserID, string _HomePhone, string _MobilePhone, string _EmpPhone)
        {
            bool _result = false;

            _result = Model.PostSOR(clsBL, _DeliveryDate, _CollID, _FlagEdit, _UserID, _HomePhone, _MobilePhone, _EmpPhone);
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

        public bool DeleteVs(SOVerificationProcessBL clsBO, bool _stillRelease)
        {
            bool _result = Model.DeleteVs(clsBO, _stillRelease);
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

        public bool DeleteSor(SOVerificationProcessBL clsBO, bool _stillRelease)
        {
            bool _result = Model.DeleteSor(clsBO, _stillRelease);
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

        public bool UpdateRemarks(SOVerificationProcessBL clsBO)
        {
            bool _result = Model.UpdateRemarks(clsBO);
            if (_result == true)
            {
                clsAlert.PushAlert("Updated Remarks Sucessfully!", clsAlert.Type.Success);
            }
            else
            {
                clsAlert.PushAlert("Error System, Failed to Updating!", clsAlert.Type.Error);
                _result = false;
            }

            return _result;
        }

        public bool UpdateCustomerAddressHome(SOMasterCustomerBL clsBL)
        {
            bool _result = Model.UpdateCustomerAddressHome(clsBL);
            return _result;
        }

        public bool UpdateCustomerAddressOffice(SOMasterCustomerBL clsBL)
        {
            bool _result = Model.UpdateCustomerAddressOffice(clsBL);
            return _result;
        }

        public int UpdateCustomerAddressOther(SOMasterCustomerBL clsBL, string _Kecamatan)
        {
            int _result = Model.UpdateCustomerAddressOther(clsBL, _Kecamatan);
            return _result;
        }

        public int UpdateCustomerAddressOtherDelivery(SOMasterCustomerBL clsBL, string _Kecamatan)
        {
            int _result = Model.UpdateCustomerAddressOtherDelivery(clsBL, _Kecamatan);
            return _result;
        }

        public bool TransferRemarks(SOVerificationProcessBL clsBO)
        {
            bool _result = Model.TransferRemarks(clsBO);
            if (_result == true)
            {
                clsAlert.PushAlert("Transfer Remarks Sucessfully!", clsAlert.Type.Success);
            }
            else
            {
                clsAlert.PushAlert("Error System, Failed to Transfering!", clsAlert.Type.Error);
                _result = false;
            }

            return _result;
        }

        public DataTable GetKPHeaderByKPNo(string _KPNo)
        {
            return Model.GetKPHeaderByKPNo(_KPNo);
        }

        public DataTable GetEndingDateCalenderFiscal()
        {
            return Model.GetEndingDateCalenderFiscal();
        }

        public DataTable GetStatusKPNoSalesOrderRelease(string _KPNo)
        {
            return Model.GetStatusKPNoSalesOrderRelease(_KPNo);
        }

        public DataTable GetKPNoDetailSalesOrderRelease(string _KPNo, string _VerificationStatus)
        {
            return Model.GetKPNoDetailSalesOrderRelease(_KPNo, _VerificationStatus);
        }

        public DataTable GetItemNoFromARKuitansi(string _KPNo)
        {
            return Model.GetItemNoFromARKuitansi(_KPNo);
        }

        public DataTable ValidateKPNoSOR(string _KPNo)
        {
            return Model.ValidateKPNoSOR(_KPNo);
        }

        public DataTable GetDataVerificatorSor(EnumFilter filter, SOVerificatorMasterBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            return ModelVerificatorMaster.Read(filter, clsBL, currentPage, fetchLimit);
        }

        public List<ComboBoxViewModel> GetKelurahanToComboBox(bool _isAll, string _ZipCode)
        {
            return Model.GetKelurahanToComboBox(_isAll, _ZipCode);
        }

        public DataTable GetPropertyUser()
        {
            return ModelVerificatorMaster.GetPropertyUser();
        }
    }
}
