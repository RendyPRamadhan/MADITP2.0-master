using System;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.businessLogic.SO;

namespace MADITP2._0.DataAccess.SO
{
    class SOOrderTypeDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        DataTable dt;
        string query;

        public SOOrderTypeDA(clsGlobal helper, clsAlert alert)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                Alert = alert;
                dt = new DataTable();
            }
        }

        public DataTable Read()
        {
            try
            {
                query = "SELECT * FROM SO_ORDER_TYPE";
                dt = Helper.ExecDT(query);
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public List<ComboBoxViewModel> GetPriceList()
        {
            var dt = new DataTable();
            var combo = new List<ComboBoxViewModel>();
            DateTime datetime = DateTime.Now;
            string now = datetime.ToString("yyyy-MM-dd");
            try
            {
                query = "SELECT DISTINCT plh_price_list_code FROM IM_PRICE_LIST_HEADER WHERE plh_type = 'GEN' OR (plh_status = 'A' AND (plh_starting_date <= '" + now + "' AND plh_expire_date <= '" + now + "'))";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["plh_price_list_code"]}",
                             ValueMember = $"{dr["plh_price_list_code"]}"
                         }).ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "Select Price List", ValueMember = "" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetTransactionType()
        {
            var dt = new DataTable();
            var combo = new List<ComboBoxViewModel>();
            DateTime datetime = DateTime.Now;
            string now = datetime.ToString("yyyy-MM-dd");
            try
            {
                query = "SELECT DISTINCT tt_txn_type_code, tt_txn_type_description FROM IM_TXN_TYPE ORDER BY tt_txn_type_code ASC";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["tt_txn_type_code"]} - {dr["tt_txn_type_description"]}",
                             ValueMember = $"{dr["tt_txn_type_code"]}"
                         }).ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "Select Type", ValueMember = "" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetInvoiceType()
        {
            var dt = new DataTable();
            var combo = new List<ComboBoxViewModel>();
            DateTime datetime = DateTime.Now;
            string now = datetime.ToString("yyyy-MM-dd");
            try
            {
                query = "SELECT DISTINCT sit_invoice_type, sit_invoice_type_description FROM SO_INVOICE_TYPE";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["sit_invoice_type"].ToString().Trim()} - {dr["sit_invoice_type_description"]}",
                             ValueMember = $"{dr["sit_invoice_type"].ToString().Trim()}"
                         }).ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "Select Type", ValueMember = "" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        private List<SqlParameterHelper> GetParam(SOOrderTypeBL Entity)
        {
            var param = new List<SqlParameterHelper>()
            {
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_desc", VALUE = Entity.orderTypeDesc },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_transaction_type", VALUE = Entity.transactionType },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_edit_price_allowed", VALUE = Entity.editPrice },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_edit_date_allowed", VALUE = Entity.editDate },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_order_allowed", VALUE = Entity.editOrder },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_edit_after_release_allowed", VALUE = Entity.editAfterRelease },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_default_price_list", VALUE = Entity.defaultPriceList },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_non_inventory_txn_type", VALUE = Entity.nonInventoryType },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_inventory_txn_type", VALUE = Entity.inventoryType },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_bonus_txn_type", VALUE = Entity.bonusType },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_invoice_type", VALUE = Entity.invoiceType },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_order_type", VALUE = Entity.orderType }
            };

            return param;
        }

        public void Update(SOOrderTypeBL Entity)
        {
            try
            {
                query = "UPDATE SO_ORDER_TYPE SET " +
                    "ot_desc = @ot_desc, " +
                    "ot_transaction_type = @ot_transaction_type, " +
                    "ot_edit_price_allowed = @ot_edit_price_allowed, " +
                    "ot_edit_date_allowed = @ot_edit_date_allowed, " +
                    "ot_order_allowed = @ot_order_allowed, " +
                    "ot_edit_after_release_allowed = @ot_edit_after_release_allowed, " +
                    "ot_default_price_list = @ot_default_price_list, " +
                    "ot_non_inventory_txn_type = @ot_non_inventory_txn_type, " +
                    "ot_inventory_txn_type = @ot_inventory_txn_type, " +
                    "ot_bonus_txn_type = @ot_bonus_txn_type, " +
                    "ot_invoice_type = @ot_invoice_type " +
                    "WHERE ot_order_type = @ot_order_type";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Update Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Create(SOOrderTypeBL Entity)
        {
            try
            {
                query = "INSERT INTO SO_ORDER_TYPE (" +
                    "ot_order_type, ot_desc, ot_transaction_type, ot_edit_price_allowed, ot_edit_date_allowed, " +
                    "ot_order_allowed, ot_edit_after_release_allowed, ot_default_price_list, ot_non_inventory_txn_type," +
                    "ot_inventory_txn_type, ot_bonus_txn_type, ot_invoice_type) VALUES(" +
                    "@ot_order_type, @ot_desc, @ot_transaction_type, @ot_edit_price_allowed, @ot_edit_date_allowed, " +
                    "@ot_order_allowed, @ot_edit_after_release_allowed, @ot_default_price_list, @ot_non_inventory_txn_type," +
                    "@ot_inventory_txn_type, @ot_bonus_txn_type, @ot_invoice_type)";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Create Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(SOOrderTypeBL Entity)
        {
            try
            {
                query = "DELETE FROM SO_ORDER_TYPE WHERE ot_order_type = @ot_order_type";

                Helper.BeginTrans();
                Helper.ExecuteTrans(query, GetParam(Entity));
                Helper.CommitTrans();
                Alert.PushAlert("Delete Success", clsAlert.Type.Success);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
