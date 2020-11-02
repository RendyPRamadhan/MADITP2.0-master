using MADITP2._0.BusinessLogic.CB;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.CB
{
    class CBARCollectionDepositEntryDA
    {
        clsGlobal Helper = null;
        clsAlert clsAlert;

        public CBARCollectionDepositEntryDA(clsGlobal helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                clsAlert = new clsAlert();
            }
        }

        public DataTable ReadCollectorPlan(EnumFilter filter, CBARCollectionDepositEntryBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, bool _isValidDate = true, string _UserLogin = "")
        {
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT NoUrut, ak_entity_id, ak_branch_id, ak_division_id, scm_customer_name, ak_so_number, ak_item_seq_number, ak_type, ak_kw_date, Outstanding, Collected, Column13, Column14, Column15, Column16, checkboxColumn FROM [FUNCTION_GET_CB_COLLECTOR_PLAN_AR_COLLECTION_DEP_ENTRY]('{ _UserLogin }', '{ clsBL.ak_entity_id }', '{ clsBL.ak_branch_id }', '{ clsBL.ak_division_id }', '{ clsBL.ak_collector_id }', '{ _isValidDate }', '{ clsBL.ak_kw_visit_date }', '{ clsBL.ak_kw_payment_type }')");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ReadOutstandingKW(EnumFilter filter, CBARCollectionDepositEntryBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, string _UserLogin = "")
        {
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT NoUrut, ak_entity_id, ak_branch_id, ak_division_id, scm_customer_name, ak_so_number, ak_item_seq_number, ak_type, ak_kw_date, Outstanding, Collected, Column13, Column14, Column15, Column16, checkboxColumn FROM [FUNCTION_GET_CB_OUTSTANDING_KW_AR_COLLECTION_DEP_ENTRY]('{ _UserLogin }', '{ clsBL.ak_entity_id }', '{ clsBL.ak_branch_id }', '{ clsBL.ak_division_id }', '{ clsBL.ak_collector_id }', '{ clsBL.ak_customer_id }', '{ clsBL.ak_item_number }')");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public DataTable ReadAllOutstandingItem(EnumFilter filter, CBARCollectionDepositEntryBL clsBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, string _UserLogin = "")
        {
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT NoUrut, ak_entity_id, ak_branch_id, ak_division_id, scm_customer_name, ak_so_number, ak_item_seq_number, ak_type, ak_kw_date, Outstanding, Collected, Column13, Column14, Column15, Column16, checkboxColumn FROM [FUNCTION_GET_CB_ALL_OUTSTANDING_ITEM_AR_COLLECTION_DEP_ENTRY]('{ _UserLogin }', '{ clsBL.ak_entity_id }', '{ clsBL.ak_branch_id }', '{ clsBL.ak_division_id }', '{ clsBL.ak_collector_id }', '{ clsBL.ak_customer_id }', '{ clsBL.ak_item_number }')");
                        break;
                }
            }
            catch (SystemException e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }

            return result;
        }

        public bool PostADDSQLSTR(CBARCollectionDepositEntryVoucherTxnBL clsBL)
        {
            bool _isSucess = false;
            try
            {

                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper { PARAMETR_NAME = "vt_bank_id_1", VALUE = clsBL.vt_bank_id },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_bank_sub_id_2", VALUE = clsBL.vt_bank_sub_id },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_voucher_type_3", VALUE = clsBL.vt_voucher_type },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_voucher_seq_4", VALUE = clsBL.vt_voucher_seq },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_bank_txn_type_5", VALUE = clsBL.vt_bank_txn_type },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_voucher_ref_6", VALUE = clsBL.vt_voucher_ref },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_receipt_paid_to_name_8", VALUE = clsBL.vt_receipt_paid_to_name },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_txn_description_9", VALUE = clsBL.vt_txn_description },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_bank_account_number_10", VALUE = clsBL.vt_bank_account_number },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_entity", VALUE = clsBL.vt_gl_entity },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_branch_11", VALUE = clsBL.vt_gl_branch },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_division_12", VALUE = clsBL.vt_gl_division },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_department_13", VALUE = clsBL.vt_gl_department },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_major1_14", VALUE = clsBL.vt_gl_major1 },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_major2_15", VALUE = clsBL.vt_gl_major2 },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_minor_16", VALUE = clsBL.vt_gl_minor },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_analysis_17", VALUE = clsBL.vt_gl_analysis },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_gl_filler_18", VALUE = clsBL.vt_gl_filler },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_cheque_giro_number_19", VALUE = clsBL.vt_cheque_giro_number },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_cheque_giro_reference_20", VALUE = clsBL.vt_cheque_giro_reference },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_cheque_giro_date_21", VALUE = clsBL.vt_cheque_giro_date },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_original_cheque_currency_22", VALUE = clsBL.vt_original_cheque_currency },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_original_cheque_amount_23", VALUE = clsBL.vt_original_cheque_amount },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_current_rate_24", VALUE = clsBL.vt_current_rate },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_txn_base_amount_25", VALUE = clsBL.vt_txn_base_amount },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_cash_code_26", VALUE = clsBL.vt_cash_code },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_no_of_distribution_line_27", VALUE = clsBL.vt_no_of_distribution_line },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_entry_date_28", VALUE = clsBL.vt_entry_date },
                    new SqlParameterHelper { PARAMETR_NAME = "vt_user_id_29", VALUE = clsBL.vt_user_id },
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_ADD_CB_VOUCHER_TXN]", sqlParameter);
                if ((int)result[2].Rows[0].ItemArray.ElementAt(0) == 1)
                {
                    _isSucess = true;
                }
            }
            catch (Exception)
            {
                _isSucess = false;
            }

            return _isSucess;
        }

        public bool PostDistributionSQL(CBARCollectionDepositEntryVoucherDistTxnBL clsBL)
        {
            bool _isSucess = false;
            try
            {

                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_bank_id_1", VALUE = clsBL.cbv_bank_id },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_sub_bank_id_2", VALUE = clsBL.cbv_sub_bank_id },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_voucher_type_3", VALUE = clsBL.cbv_voucher_type },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_seq_no_4", VALUE = clsBL.cbv_seq_no },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_bank_txn_type_6", VALUE = clsBL.cbv_bank_txn_type },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_voucher_ref_7", VALUE = clsBL.cbv_voucher_ref },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_receipt_paid_to_name_9", VALUE = clsBL.cbv_receipt_paid_to_name },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_txn_date_21", VALUE = clsBL.cbv_txn_date },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_interfaced_user_33", VALUE = clsBL.cbv_interfaced_user },
                    //new SqlParameterHelper { PARAMETR_NAME = "cbv_receipt_paid_codes_8", VALUE = clsBL.cbv_receipt_paid_codes },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_index_no_5", VALUE = clsBL.cbv_index_no },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_entity_10", VALUE = clsBL.cbv_entity },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_branch_11", VALUE = clsBL.cbv_branch },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_division_12", VALUE = clsBL.cbv_division },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_department_13", VALUE = clsBL.cbv_department },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_major1_14", VALUE = clsBL.cbv_major1 },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_major2_15", VALUE = clsBL.cbv_major2 },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_minor_16", VALUE = clsBL.cbv_minor },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_analysis_17", VALUE = clsBL.cbv_analysis },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_filler_18", VALUE = clsBL.cbv_filler },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_txn_description_19", VALUE = clsBL.cbv_txn_description },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_txn_dr_cr_20", VALUE = clsBL.cbv_txn_dr_cr },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_txn_base_ammount_22", VALUE = clsBL.cbv_txn_base_ammount },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_cash_id", VALUE = clsBL.cbv_cash_id },
                    new SqlParameterHelper { PARAMETR_NAME = "cbv_add_book_id", VALUE = clsBL.cbv_add_book_id }
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_ADD_CB_VOUCHER_DIST_TXN]", sqlParameter);
                if ((int)result[2].Rows[0].ItemArray.ElementAt(0) == 1)
                {
                    _isSucess = true;
                }
            }
            catch (Exception)
            {
                _isSucess = false;
            }

            return _isSucess;
        }

        public bool PostEditCBBankAccMasterTxn(string _FiscalYear, string _BankID, string _BankSubID, string _VarMonth, double _VarValue, string _VarReceiptDisbursement)
        {
            bool _isSucess = false;
            try
            {

                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper { PARAMETR_NAME = "bam_fiscal_year", VALUE = _FiscalYear },
                    new SqlParameterHelper { PARAMETR_NAME = "bam_bank_id", VALUE = _BankID },
                    new SqlParameterHelper { PARAMETR_NAME = "bam_bank_sub_id", VALUE = _BankSubID },
                    new SqlParameterHelper { PARAMETR_NAME = "varmonth", VALUE = _VarMonth },
                    new SqlParameterHelper { PARAMETR_NAME = "varvalue", VALUE = _VarValue },
                    new SqlParameterHelper { PARAMETR_NAME = "varreceipt_disbursement", VALUE = _VarReceiptDisbursement }    
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_EDIT_CB_BANK_ACCOUNT_MASTER_TXN]", sqlParameter);
                if ((int)result[2].Rows[0].ItemArray.ElementAt(0) == 1)
                {
                    _isSucess = true;
                }
            }
            catch (Exception)
            {
                _isSucess = false;
            }

            return _isSucess;
        }

        public bool PostEditDownPaymentDP(string _KPOrderNo, double _AmountDeposit, string _VoucherType, string _VoucherNo, string _VoucherRef, DateTime _VoucherDate, string _DepositBy)
        {
            bool _isSucess = false;
            try
            {

                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper { PARAMETR_NAME = "dp_kp_order_no_1", VALUE = _KPOrderNo },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_total_amount_deposit_3", VALUE = _AmountDeposit },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_voucher_type_4", VALUE = _VoucherType },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_voucher_no_5", VALUE = _VoucherNo },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_voucher_reference_6", VALUE = _VoucherRef },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_voucher_date_7", VALUE = _VoucherDate },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_deposit_by", VALUE = _DepositBy }
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_EDIT_CB_DOWN_PAYMENT_DP]", sqlParameter);
                if ((int)result[2].Rows[0].ItemArray.ElementAt(0) == 1)
                {
                    _isSucess = true;
                }
            }
            catch (Exception)
            {
                _isSucess = false;
            }

            return _isSucess;
        }

        public bool PostEditDownPaymentCOD(string _KPOrderNo, double _AmountDeposit, string _VoucherType, string _VoucherNo, string _VoucherRef, DateTime _VoucherDate, string _DepositBy)
        {
            bool _isSucess = false;
            try
            {

                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper { PARAMETR_NAME = "dp_kp_order_no_1", VALUE = _KPOrderNo },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_od_total_amount_deposit_3", VALUE = _AmountDeposit },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_od_voucher_type_4", VALUE = _VoucherType },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_od_voucher_no_5", VALUE = _VoucherNo },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_od_voucher_reference_6", VALUE = _VoucherRef },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_od_voucher_date_7", VALUE = _VoucherDate },
                    new SqlParameterHelper { PARAMETR_NAME = "dp_od_deposit_by", VALUE = _DepositBy }
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_EDIT_CB_DOWN_PAYMENT_COD]", sqlParameter);
                if ((int)result[2].Rows[0].ItemArray.ElementAt(0) == 1)
                {
                    _isSucess = true;
                }
            }
            catch (Exception)
            {
                _isSucess = false;
            }

            return _isSucess;
        }

        public DataTable GetSystemDate()
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT SystemDate FROM [FUNCTION_GET_SYSTEM_DATE]()");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public List<ComboBoxViewModel> GetCollectorToComboBox(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT cm_collector_id FROM [FUNCTION_CB_GET_COLLECTOR_AR_COLLECTION_DEP_ENTRY]() ORDER BY cm_collector_id");
                result = (from DataRow dr in dt.Rows
                            select new ComboBoxViewModel()
                            {
                                DisplayMember = $"{dr["cm_collector_id"]}",
                                ValueMember = $"{dr["cm_collector_id"]}"
                            }).ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "0" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetBankToComboBox(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT bm_bank_id, bm_bank FROM [FUNCTION_CB_GET_BANK_AR_COLLECTION_DEP_ENTRY]() ORDER BY bm_bank_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["bm_bank_id"]}",
                              ValueMember = $"{dr["bm_bank_id"]}"
                          }).ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "0" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetVoucherTypeToComboBox(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT cb_voucher_type_id FROM [FUNCTION_CB_GET_VOUCHER_TYPE_AR_COLLECTION_DEP_ENTRY]() ORDER BY cb_voucher_type_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["cb_voucher_type_id"]}",
                              ValueMember = $"{dr["cb_voucher_type_id"]}"
                          }).ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "0" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetBankAccountToComboBox(bool _isAll, string _BankID, string _TrxType)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT bam_bank_account_no, bam_bank_account, bam_bank_sub_id FROM [FUNCTION_CB_GET_BANK_ACCOUNT_AR_COLLECTION_DEP_ENTRY]('{ _BankID }', '{ _TrxType }') ORDER BY bam_bank_sub_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["bam_bank_sub_id"]}",
                              ValueMember = $"{dr["bam_bank_sub_id"]}"
                          }).ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "0" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetCurrCodeToComboBox(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT cc_currency_code, cc_currency FROM [FUNCTION_GET_CURRENCY_CODE]() ORDER BY cc_currency_code");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["cc_currency"]}",
                              ValueMember = $"{dr["cc_currency_code"]}"
                          }).ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "0" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetCurrCode()
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT cc_currency_code FROM [FUNCTION_GET_SELECTED_CURRENCY_CODE]()");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetGeneralFiscal(string _GroupID, string _FiscalYear, string _EntityID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT gfc_begining_date, gfc_ending_date, SysDate FROM [FUNCTION_CB_GET_GENERAL_FISCAL_AR_COLLECTION_DEP_ENTRY]('{ _GroupID }', '{ _FiscalYear }', '{ _EntityID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetSelectGeneralFiscalCalenderOpen(string _GroupID, string _EntityID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT gfc_begining_date, gfc_ending_date, curr_date FROM [FUNCTION_GET_SELECT_GENERAL_FISCAL_CALENDAR_OPEN]('{ _GroupID }', '{ _EntityID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetStructureDef(string _EntityID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_CB_GET_STRUCTURE_DEF]('{ _EntityID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetARGeneralParamWOStatus(CBARCollectionDepositEntryBL clsBL)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT gp_max_write_off_amount FROM [FUNCTION_GET_CB_SELECT_AR_GENERAL_PARAMETER_WO_STATUS]('{ clsBL.ak_entity_id }', '{ clsBL.ak_branch_id }', '{ clsBL.ak_division_id }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetCashType(string _EntityID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT gp_cashcode_incentive_collector, gp_cashcode_sales_commission, gp_cashcode_dp_uangmuka, gp_cashcode_collection FROM [FUNCTION_CB_GET_CASH_TYPE_AR_COLLECTION_DEP_ENTRY]('{ _EntityID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetARGeneralParamCollection(CBARCollectionDepositEntryBL clsBL)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_CB_SELECT_AR_GENERAL_PARAMETER_COLLECTION]('{ clsBL.ak_entity_id }', '{ clsBL.ak_branch_id }', '{ clsBL.ak_division_id }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetCheckAccountGL(CBARCollectionDepositEntryIncentivePaymentBL clsBL)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_CB_CHECK_ACCOUNT_AR_COLLECTION_DEP_ENTRY]('{ clsBL.varGL.mEntity }', '{ clsBL.varGL.mBranch }', '{ clsBL.varGL.mDivision }', '{ clsBL.varGL.mDepartment }', '{ clsBL.varGL.mMajor1 }', '{ clsBL.varGL.mMajor2 }', '{ clsBL.varGL.mMinor }', '{ clsBL.varGL.mAnalisys }', '{ clsBL.varGL.mFiller }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetCheckAccountGLCWH(CBARCollectionDepositEntryIncentivePaymentBL clsBL)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_CB_CHECK_ACCOUNT_AR_COLLECTION_DEP_ENTRY]('{ clsBL.varGLCWH.mEntity }', '{ clsBL.varGLCWH.mBranch }', '{ clsBL.varGLCWH.mDivision }', '{ clsBL.varGLCWH.mDepartment }', '{ clsBL.varGLCWH.mMajor1 }', '{ clsBL.varGLCWH.mMajor2 }', '{ clsBL.varGLCWH.mMinor }', '{ clsBL.varGLCWH.mAnalisys }', '{ clsBL.varGLCWH.mFiller }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetCheckAccountOK(CBARCollectionDepositEntryIncentivePaymentBL clsBL)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_CB_CHECK_ACCOUNT_AR_COLLECTION_DEP_ENTRY]('{ clsBL.varGLCWH.mEntity }', '{ clsBL.varGLCWH.mBranch }', '{ clsBL.varGLCWH.mDivision }', '{ clsBL.varGLCWH.mDepartment }', '{ clsBL.varGLCWH.mMajor1 }', '{ clsBL.varGLCWH.mMajor2 }', '{ clsBL.varGLCWH.mMinor }', '{ clsBL.varGLCWH.mAnalisys }', '{ clsBL.varGLCWH.mFiller }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetVoucherTypeID(string _VoucherTypeID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT cb_voucher_type_id FROM [FUNCTION_GET_SELECT_CB_VOUCHER_TYPE]('{ _VoucherTypeID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetVoucherSeq(string _VoucherSeqID)
        {
            var dt = new DataTable();
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@CBVoucherSeqID", VALUE = _VoucherSeqID }
                };

                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_CBVOUCHERSEQ]", sqlParameter);
                dt = result[0];
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }

        public DataTable GetBankGLAccount(string _BankID, string _BankSubID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_CB_GET_BANK_ACCOUNT_GL_ACCOUNT]('{ _BankID }', '{ _BankSubID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }
    }
}
