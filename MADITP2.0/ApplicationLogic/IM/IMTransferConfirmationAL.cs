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
    class IMTransferConfirmationAL
    {
        private clsGlobal Helper;
        private IMTransferConfirmationDA Model;

        public IMTransferConfirmationAL(clsGlobal helper)
        {
            Helper = helper;
            Model = new IMTransferConfirmationDA(Helper);
        }

        public DataTable ReadHeader(EnumFilter filter, IMTransferConfirmationBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _IsDate = false, DateTime? _FromDate = null, DateTime? _ToDate = null)
        {
            return Model.ReadHeader(filter, clsBL, currentPage, fetchLimit, _IsDate, _FromDate, _ToDate);
        }

        public DataTable ReadDetail(EnumFilter filter, IMTransferConfirmationBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit)
        {
            return Model.ReadDetail(filter, clsBL, currentPage, fetchLimit);
        }

        public bool Post(List<IMTransferConfirmationBL> ArrayclsBL)
        {
            bool _result = Model.Post(ArrayclsBL);
            return _result;
        }

        public List<ComboBoxViewModel> GetTxnTypeToComboBox(string _UserID, bool _isAll)
        {
            return Model.GetTxnTypeToComboBox(_UserID, _isAll);
        }

        public List<ComboBoxViewModel> GetWarehouseFromToComboBox(bool _isAll)
        {
            return Model.GetWarehouseFromToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetWarehouseToToComboBox(bool _isAll, string _UserID)
        {
            return Model.GetWarehouseToToComboBox(_isAll, _UserID);
        }

        public DataTable GetSystemDate()
        {
            return Model.GetSystemDate();
        }

        public DataTable GetTransitWHID(string _WarehouseID)
        {
            return Model.GetTransitWHID(_WarehouseID);
        }

        public DataTable GetTransferTxnTypeByID(string _TransType)
        {
            return Model.GetTransferTxnTypeByID(_TransType);
        }
    }
}
