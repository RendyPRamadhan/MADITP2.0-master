using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.CB
{
    class CBOtherDocsDA
    {
        clsGlobal Helper = null;
        clsAlert clsAlert;

        public CBOtherDocsDA()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                clsAlert = new clsAlert();
            }
        }

        public CBOtherDocsDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public List<ComboBoxViewModel> GetMasterBankToComboBox(bool _isAll)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT bm_bank_id, bm_bank FROM [FUNCTION_CB_GET_BANK_MASTER]() ORDER BY bm_bank");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["bm_bank"]}",
                              ValueMember = $"{dr["bm_bank_id"]}"
                          }).ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL BANK", ValueMember = "ALL" });
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
                dt = Helper.ExecuteQuery($"SELECT cb_voucher_type_id, cb_description, cb_txn_type FROM [FUNCTION_CB_GET_VOUCHER_TYPE]() ORDER BY cb_voucher_type_id");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["cb_description"]}",
                              ValueMember = $"{dr["cb_voucher_type_id"]}"
                          }).ToList();
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL VOUCHER", ValueMember = "ALL" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetBankSubIDToComboBox(bool _isAll, string _BankID)
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                if(_BankID != "ALL")
                {
                    dt = Helper.ExecuteQuery($"SELECT bam_bank_account_no, bam_bank_account, bam_bank_sub_id FROM [FUNCTION_CB_GET_BANK_SUB_ID_PRINT]('{ _BankID }') ORDER BY bam_bank_sub_id");
                    result = (from DataRow dr in dt.Rows
                              select new ComboBoxViewModel()
                              {
                                  DisplayMember = $"{dr["bam_bank_account"]}",
                                  ValueMember = $"{dr["bam_bank_account_no"]}"
                              }).ToList();
                }
                
                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL BANK SUB", ValueMember = "ALL" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetFiscalYear(string _EntityID)
        {
            var dt = new DataTable();
            try
            {
                dt = Helper.ExecuteQuery($"SELECT gfc_fiscal_year FROM [FUNCTION_CB_GET_YEAR_CALENDER_FISCAL]('{ _EntityID }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return dt;
        }
    }
}
