using MADITP2._0.BusinessLogic.CB;
using MADITP2._0.DataAccess.CB;
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
    class CBARCollectionDepositEntryAL
    {
        private CBARCollectionDepositEntryDA Model;
        private SOVerificatorMasterDA ModelVerificatorMaster;
        private clsHardcoded clsHardcoded;
        private clsAlert clsAlert;

        public CBARCollectionDepositEntryAL(clsGlobal helper)
        {
            Model = new CBARCollectionDepositEntryDA(helper);
            ModelVerificatorMaster = new SOVerificatorMasterDA(helper);
            clsHardcoded = new clsHardcoded();
            clsAlert = new clsAlert();
        }

        public DataTable ReadCollectorPlan(EnumFilter filter, CBARCollectionDepositEntryBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _IsValidDate = true, string _UserLogin = "")
        {
            return Model.ReadCollectorPlan(filter, clsBL, currentPage, fetchLimit, _IsValidDate, _UserLogin);
        }

        public DataTable ReadOutstandingKW(EnumFilter filter, CBARCollectionDepositEntryBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, string _UserLogin = "")
        {
            return Model.ReadOutstandingKW(filter, clsBL, currentPage, fetchLimit, _UserLogin);
        }

        public DataTable ReadAllOutstandingItem(EnumFilter filter, CBARCollectionDepositEntryBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, string _UserLogin = "")
        {
            return Model.ReadAllOutstandingItem(filter, clsBL, currentPage, fetchLimit, _UserLogin);
        }

        public bool PostADDSQLSTR(CBARCollectionDepositEntryVoucherTxnBL clsBL)
        {
            bool _result = false;
            return _result = Model.PostADDSQLSTR(clsBL);
        }

        public bool PostDistributionSQL(CBARCollectionDepositEntryVoucherDistTxnBL clsBL)
        {
            bool _result = false;
            return _result = Model.PostDistributionSQL(clsBL);
        }

        public bool PostEditCBBankAccMasterTxn(string _FiscalYear, string _BankID, string _BankSubID, string _VarMonth, double _VarValue, string _VarReceiptDisbursement)
        {
            bool _result = false;
            return _result = Model.PostEditCBBankAccMasterTxn(_FiscalYear, _BankID, _BankSubID, _VarMonth, _VarValue, _VarReceiptDisbursement);
        }

        public bool PostEditDownPaymentDP(string _KPOrderNo, double _AmountDeposit, string _VoucherType, string _VoucherNo, string _VoucherRef, DateTime _VoucherDate, string _DepositBy)
        {
            bool _result = false;
            return _result = Model.PostEditDownPaymentDP(_KPOrderNo, _AmountDeposit, _VoucherType, _VoucherNo, _VoucherRef, _VoucherDate, _DepositBy);
        }

        public bool PostEditDownPaymentCOD(string _KPOrderNo, double _AmountDeposit, string _VoucherType, string _VoucherNo, string _VoucherRef, DateTime _VoucherDate, string _DepositBy)
        {
            bool _result = false;
            return _result = Model.PostEditDownPaymentCOD(_KPOrderNo, _AmountDeposit, _VoucherType, _VoucherNo, _VoucherRef, _VoucherDate, _DepositBy);
        }

        public DataTable GetSystemDate()
        {
            return Model.GetSystemDate();
        }

        public DataTable GetPropertyUser()
        {
            return ModelVerificatorMaster.GetPropertyUser();
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

        public List<ComboBoxViewModel> GetHardCodedPaymentType(bool _isAll)
        {
            return clsHardcoded.GetHardCodedPaymentType(_isAll);
        }

        public List<ComboBoxViewModel> GetCollectorToComboBox(bool _isAll)
        {
            return Model.GetCollectorToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetBankToComboBox(bool _isAll)
        {
            return Model.GetBankToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetVoucherTypeToComboBox(bool _isAll)
        {
            return Model.GetVoucherTypeToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetCurrCodeToComboBox(bool _isAll)
        {
            return Model.GetCurrCodeToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetBankAccountToComboBox(bool _isAll, string _BankID, string _TrxType)
        {
            return Model.GetBankAccountToComboBox(_isAll, _BankID, _TrxType);
        }

        public DataTable GetCurrCode()
        {
            return Model.GetCurrCode();
        }

        public DataTable GetGeneralFiscal(string _GroupID, string _FiscalYear, string _EntityID)
        {
            return Model.GetGeneralFiscal(_GroupID, _FiscalYear, _EntityID);
        }

        public DataTable GetSelectGeneralFiscalCalenderOpen(string _GroupID, string _EntityID)
        {
            return Model.GetSelectGeneralFiscalCalenderOpen(_GroupID, _EntityID);
        }

        public DataTable GetStructureDef(string _EntityID)
        {
            return Model.GetStructureDef(_EntityID);
        }

        public DataTable GetARGeneralParamWOStatus(CBARCollectionDepositEntryBL clsBL)
        {
            return Model.GetARGeneralParamWOStatus(clsBL);
        }

        public DataTable GetCashType(string _EntityID)
        {
            return Model.GetCashType(_EntityID);
        }

        public DataTable GetARGeneralParamCollection(CBARCollectionDepositEntryBL clsBL)
        {
            return Model.GetARGeneralParamCollection(clsBL);
        }

        public DataTable GetCheckAccountGL(CBARCollectionDepositEntryIncentivePaymentBL clsBL)
        {
            return Model.GetCheckAccountGL(clsBL);
        }

        public DataTable GetCheckAccountGLCWH(CBARCollectionDepositEntryIncentivePaymentBL clsBL)
        {
            return Model.GetCheckAccountGLCWH(clsBL);
        }

        public DataTable GetCheckAccountOK(CBARCollectionDepositEntryIncentivePaymentBL clsBL)
        {
            return Model.GetCheckAccountOK(clsBL);
        }

        public DataTable GetVoucherTypeID(string _VoucherTypeID)
        {
            return Model.GetVoucherTypeID(_VoucherTypeID);
        }

        public DataTable GetVoucherSeq(string _VoucherSeqID)
        {
            return Model.GetVoucherSeq(_VoucherSeqID);
        }

        public DataTable GetBankGLAccount(string _BankID, string _BankSubID)
        {
            return Model.GetBankGLAccount(_BankID, _BankSubID);
        }
    }
}
