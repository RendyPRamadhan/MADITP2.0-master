using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.SO;

namespace MADITP2._0.DataAccess.SO
{
    class SOReturnTypeDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        DataTable dt;
        string query;

        public SOReturnTypeDA(clsGlobal helper, clsAlert alert)
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
                query = "SELECT * FROM SO_RETURN_TYPE";
                dt = Helper.ExecDT(query);
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public void Create(SOReturnTypeBL Entity)
        {
            try
            {
                query = "INSERT INTO SO_RETURN_TYPE " +
                    "(ot_return_type, ot_desc, ot_update_stock_allowed, ot_update_achievement, ot_create_kp_baru, ot_update_stock_allowed_pengganti, " +
                    "ot_update_acheivement_allowed_pengganti, ot_invoice_type, ot_inv_return_txn_type, ot_check_receipt_warehouse, ot_return_group) " +
                    "VALUES " +
                    "(@ot_return_type, @ot_desc, @ot_update_stock_allowed, @ot_update_achievement, @ot_create_kp_baru, @ot_update_stock_allowed_pengganti, " +
                    "@ot_update_acheivement_allowed_pengganti, @ot_invoice_type, @ot_inv_return_txn_type, @ot_check_receipt_warehouse, @ot_return_group)";

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

        public void Update(SOReturnTypeBL Entity)
        {
            try
            {
                query = "UPDATE SO_RETURN_TYPE SET ot_desc = @ot_desc, " +
                    "ot_update_stock_allowed = @ot_update_stock_allowed, " +
                    "ot_update_achievement = @ot_update_achievement, " +
                    "ot_create_kp_baru = @ot_create_kp_baru, " +
                    "ot_update_stock_allowed_pengganti = @ot_update_stock_allowed_pengganti, " +
                    "ot_update_acheivement_allowed_pengganti = @ot_update_acheivement_allowed_pengganti, " +
                    "ot_invoice_type = @ot_invoice_type, " +
                    "ot_inv_return_txn_type = @ot_inv_return_txn_type, " +
                    "ot_check_receipt_warehouse = @ot_check_receipt_warehouse , " +
                    "ot_return_group = @ot_return_group, " +
                    "ot_update_by = @ot_update_by, " +
                    "ot_last_update = @ot_last_update " +
                    "WHERE ot_return_type = @ot_return_type";

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

        public void Delete(SOReturnTypeBL Entity)
        {
            try
            {
                query = "DELETE FROM SO_RETURN_TYPE WHERE ot_return_type = @ot_return_type";

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

        private List<SqlParameterHelper> GetParam(SOReturnTypeBL Entity)
        {
            var param = new List<SqlParameterHelper>()
            {
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_return_type", VALUE = Entity.Ot_return_type },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_desc", VALUE = Entity.Ot_desc },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_update_stock_allowed", VALUE = Entity.Ot_update_stock_allowed },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_update_achievement", VALUE = Entity.Ot_update_achievement },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_create_kp_baru", VALUE = Entity.Ot_create_kp_baru },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_update_stock_allowed_pengganti", VALUE = Entity.Ot_update_stock_allowed_pengganti },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_update_acheivement_allowed_pengganti", VALUE = Entity.Ot_update_acheivement_allowed_pengganti },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_invoice_type", VALUE = Entity.Ot_invoice_type },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_inv_return_txn_type", VALUE = Entity.Ot_inv_return_txn_type },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_check_receipt_warehouse", VALUE = Entity.Ot_check_receipt_warehouse },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_return_group", VALUE = Entity.Ot_return_group },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_update_by", VALUE = Entity.Ot_update_by },
                new SqlParameterHelper() { PARAMETR_NAME = "@ot_last_update", VALUE = Entity.Ot_last_update }
            };

            return param;
        }
    }
}
