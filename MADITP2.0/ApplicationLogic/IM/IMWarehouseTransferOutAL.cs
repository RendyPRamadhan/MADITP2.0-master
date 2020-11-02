using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.IM
{
    class IMWarehouseTransferOutAL
    {
        private clsGlobal Helper;
        private IMWarehouseTransferOutDA Model;

        public IMWarehouseTransferOutAL(clsGlobal helper)
        {
            Helper = helper;
            Model = new IMWarehouseTransferOutDA(Helper);
        }

        public DataTable Read(EnumFilter filter, IMWarehouseTransferOutBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            return Model.Read(filter, clsBL, currentPage, fetchLimit);
        }

        public DataTable ReadDetail(EnumFilter filter, IMWarehouseTransferOutBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            return Model.ReadDetail(filter, clsBL, currentPage, fetchLimit);
        }

        public bool Post(List<IMWarehouseTransferOutBL> ArrayclsBL, bool _IsSendEmail, string _EmailTo, string _TransTypeSeqNo)
        {
            bool _result = Model.Post(ArrayclsBL, _IsSendEmail, _EmailTo, _TransTypeSeqNo);
            return _result;
        }

        public bool updateSeqNo(string _sType, string SeqNo)
        {
            bool _result = Model.updateSeqNo(_sType, SeqNo);
            return _result;
        }

        public List<ComboBoxViewModel> GetTransferTxnTypeToComboBox(string _UserID, bool _isAll)
        {
            return Model.GetTransferTxnTypeToComboBox(_UserID, _isAll);
        }

        public List<ComboBoxViewModel> GetWarehouseEditorToComboBox(string _UserID, bool _isAll)
        {
            return Model.GetWarehouseEditorToComboBox(_UserID, _isAll);
        }

        public DataTable GetTransferTxnTypeByID(string _TransType)
        {
            return Model.GetTransferTxnTypeByID(_TransType);
        }

        public DataTable GetUserWH(string _UserID)
        {
            return Model.GetUserWH(_UserID);
        }

        public List<ComboBoxViewModel> GetWarehouseWHToComboBox(bool _isAll)
        {
            return Model.GetWarehouseWHToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetWarehouseToComboBox(string _UserID, bool _isAll)
        {
            return Model.GetWarehouseToComboBox(_UserID, _isAll);
        }

        public DataTable GetWarehouseEditorByID(string _WarehouseID)
        {
            return Model.GetWarehouseEditorByID(_WarehouseID);
        }

        public DataTable GetSystemDate()
        {
            return Model.GetSystemDate();
        }

        public List<ComboBoxViewModel> GetWarehouseByIDEditor(string _WarehouseID, string _TransType, bool _isAll)
        {
            return Model.GetWarehouseByIDEditor(_WarehouseID, _TransType, _isAll);
        }

        public DataTable GetSNIDDetail(string _SNID)
        {
            return Model.GetSNIDDetail(_SNID);
        }
        public DataTable GetProductByID(string _ProductID)
        {
            return Model.GetProductByID(_ProductID);
        }

        public DataTable GetCostSTDByPID(string _ProductID)
        {
            return Model.GetCostSTDByPID(_ProductID);
        }

        public DataTable GetQtyProduct(string _ProductID, string _WarehouseID)
        {
            return Model.GetQtyProduct(_ProductID, _WarehouseID);
        }

        public DataTable GetContactPerson(string _WarehouseID)
        {
            return Model.GetContactPerson(_WarehouseID);
        }

        public DataTable GetEntityBranchDesc(string _Reference)
        {
            return Model.GetEntityBranchDesc(_Reference);
        }

        public DataTable GetEntityBranchDescOpt(string _UserID)
        {
            return Model.GetEntityBranchDescOpt(_UserID);
        }

        public DataTable GetEmailAddress(string _WarehouseFrom, string _WarehouseTo)
        {
            return Model.GetEmailAddress(_WarehouseFrom, _WarehouseTo);
        }
    }
}
