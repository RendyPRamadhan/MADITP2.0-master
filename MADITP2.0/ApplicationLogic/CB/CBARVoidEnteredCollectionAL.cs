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
    class CBARVoidEnteredCollectionAL
    {
        private CBARVoidEnteredCollectionDA Model;
        private SOVerificatorMasterDA ModelVerificatorMaster;

        public CBARVoidEnteredCollectionAL(clsGlobal helper)
        {
            Model = new CBARVoidEnteredCollectionDA(helper);
            ModelVerificatorMaster = new SOVerificatorMasterDA(helper);
        }

        public DataTable Read(EnumFilter filter, CBARCollectionDepositEntryBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, string _VoucherNo = "")
        {
            return Model.Read(filter, clsBL, currentPage, fetchLimit, _VoucherNo);
        }

        public bool PostADDSQLSTR(CBARCollectionDepositEntryVoucherTxnBL clsBL)
        {
            //CHECK
            bool _result = false;
            return _result = Model.PostADDSQLSTR(clsBL);
        }

        public bool PostDistributionSQL(CBARCollectionDepositEntryVoucherDistTxnBL clsBL)
        {
            //CHECK
            bool _result = false;
            return _result = Model.PostDistributionSQL(clsBL);
        }

        public bool PostEditCBBankAccMasterTxn(string _FiscalYear, string _BankID, string _BankSubID, string _VarMonth, double _VarValue, string _VarReceiptDisbursement)
        {
            //CHECK
            bool _result = false;
            return _result = Model.PostEditCBBankAccMasterTxn(_FiscalYear, _BankID, _BankSubID, _VarMonth, _VarValue, _VarReceiptDisbursement);
        }

        public bool PostEditDownPaymentDP(string _KPOrderNo, double _AmountDeposit, string _VoucherType, string _VoucherNo, string _VoucherRef, DateTime _VoucherDate, string _DepositBy)
        {
            //CHECK
            bool _result = false;
            return _result = Model.PostEditDownPaymentDP(_KPOrderNo, _AmountDeposit, _VoucherType, _VoucherNo, _VoucherRef, _VoucherDate, _DepositBy);
        }

        public bool PostEditDownPaymentCOD(string _KPOrderNo, double _AmountDeposit, string _VoucherType, string _VoucherNo, string _VoucherRef, DateTime _VoucherDate, string _DepositBy)
        {
            //CHECK
            bool _result = false;
            return _result = Model.PostEditDownPaymentCOD(_KPOrderNo, _AmountDeposit, _VoucherType, _VoucherNo, _VoucherRef, _VoucherDate, _DepositBy);
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

        public List<ComboBoxViewModel> GetCollectorToComboBox(bool _isAll)
        {
            return Model.GetCollectorToComboBox(_isAll);
        }

        public List<ComboBoxViewModel> GetBankToComboBox(bool _isAll)
        {
            return Model.GetBankToComboBox(_isAll);
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

        public DataTable GetSelectGeneralFiscalCalenderOpen(string _GroupID, string _EntityID)
        {
            return Model.GetSelectGeneralFiscalCalenderOpen(_GroupID, _EntityID);
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

        public DataTable GetCheckTypeVoucher(string _VoucherNo)
        {
            return Model.GetCheckTypeVoucher(_VoucherNo);
        }

        public DataTable GetSumTxnBaseAmount(string _BankID, string _BankSubID, string _VoucherSeq)
        {
            return Model.GetSumTxnBaseAmount(_BankID, _BankSubID, _VoucherSeq);
        }
    }
}
