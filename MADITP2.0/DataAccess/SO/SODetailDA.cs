using System;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.BusinessLogic.SO;

namespace MADITP2._0.DataAccess.SO
{
    class SODetailDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        DataTable dt;
        string query;

        public SODetailDA(clsGlobal helper, clsAlert alert)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                Alert = alert;
                dt = new DataTable();
            }
        }

        public List<ComboBoxViewModel> GetEntity()
        {
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT ec_entity_id, ec_entity FROM ENTITY_CODES ORDER BY ec_entity_id";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["ec_entity"].ToString().Trim()}",
                             ValueMember = $"{dr["ec_entity_id"].ToString().Trim()}"
                         }).Where(item => item.ValueMember != "0").ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetBranch()
        {
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT bc_branch_id, bc_branch FROM BRANCH_CODES";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["bc_branch"].ToString().Trim()}",
                             ValueMember = $"{dr["bc_branch_id"].ToString().Trim()}"
                         }).Where(item => item.ValueMember != "0").ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetDivision()
        {
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT dc_division_id, dc_division FROM DIVISION_CODES";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["dc_division"].ToString().Trim()}",
                             ValueMember = $"{dr["dc_division_id"].ToString().Trim()}"
                         }).Where(item => item.ValueMember != "0").ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetOrderType()
        {
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT ot_order_type, ot_desc FROM SO_ORDER_TYPE ORDER BY ot_desc";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["ot_desc"].ToString().Trim()}",
                             ValueMember = $"{dr["ot_order_type"].ToString().Trim()}"
                         }).Where(item => item.ValueMember != "0").ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public List<ComboBoxViewModel> GetWarehouse()
        {
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT IM_WAREHOUSE_SECURITY.ws_warehouse_id, IM_WAREHOUSE.wh_warehouse_description " +
                    "FROM IM_WAREHOUSE INNER JOIN IM_WAREHOUSE_SECURITY ON " +
                    "IM_WAREHOUSE.wh_warehouse_id = IM_WAREHOUSE_SECURITY.ws_warehouse_id " +
                    //"WHERE IM_WAREHOUSE_SECURITY.ws_user_id = '" + clsLogin.USERID.Trim() + "' AND " +
                    "WHERE IM_WAREHOUSE_SECURITY.ws_user_id = 'admin' AND " +
                    "IM_WAREHOUSE.wh_manual_transaction_entry_allowed = 'Y'";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["ws_warehouse_id"].ToString().Trim()} - {dr["wh_warehouse_description"].ToString().Trim()}",
                             ValueMember = $"{dr["ws_warehouse_id"].ToString().Trim()}"
                         }).Where(item => item.ValueMember != "0").ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "All", ValueMember = "0" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public DataTable SearchData(SODetailBL Entity)
        {
            try
            {
                query = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS no, skh_branch_id, skh_division_id, skh_so_kp_date, skh_order_type, skh_so_kp_number, rm_name, " +
                    "skh_customer_name, skh_sales_type, skh_total_disc_amount, skh_status_of_so_kp, skh_status_of_verification, " +
                    "skh_status_of_invoice, skh_status_of_delivery, skh_status_of_dp, skh_status_of_cod, skh_total_item_set_qty, " +
                    "skh_total_su, skh_total_bv, skh_total_pv, skh_total_point_1, skh_total_point_2 " +
                    "FROM SO_KP_HEADER INNER JOIN RC_REP_MASTER ON SO_KP_HEADER.skh_rep_id = RC_REP_MASTER.rm_rep_id " +
                    "WHERE skh_so_kp_number IS NOT NULL ";
                if (Entity.Skh_so_kp_number != null)
                    query = query + "AND skh_so_kp_number = '" + Entity.Skh_so_kp_number + "' ";
                if (Entity.Skh_rep_id != null)
                    query = query + "AND skh_rep_id = '" + Entity.Skh_rep_id + "' ";
                if (Entity.Skh_mgr_rep_id != null)
                    query = query + "AND skh_mgr_rep_id = '" + Entity.Skh_mgr_rep_id + "' ";
                if (Entity.Skh_entity_id != "0")
                    query = query + "AND skh_entity_id = '" + Entity.Skh_entity_id + "' ";
                if (Entity.Skh_branch_id != "0")
                    query = query + "AND skh_branch_id = '" + Entity.Skh_branch_id + "' ";
                if (Entity.Skh_division_id != "0")
                    query = query + "AND skh_division_id = '" + Entity.Skh_division_id + "' ";
                if (Entity.Skh_order_type != null)
                    query = query + "AND skh_order_type = '" + Entity.Skh_order_type + "' ";
                if (Entity.Skh_sales_type != null)
                    query = query + "AND skh_sales_type = '" + Entity.Skh_sales_type + "' ";
                if (Entity.Skh_status_of_so_kp != null)
                    query = query + "AND skh_status_of_so_kp = '" + Entity.Skh_status_of_so_kp + "' ";
                if (Entity.Skh_status_of_verification != null)
                    query = query + "AND skh_status_of_verification = '" + Entity.Skh_status_of_verification + "' ";
                if (Entity.Skh_status_of_invoice != null)
                    query = query + "AND skh_status_of_invoice = '" + Entity.Skh_status_of_invoice + "' ";
                if (Entity.Skh_status_of_delivery != null)
                    query = query + "AND skh_status_of_delivery = '" + Entity.Skh_status_of_delivery + "' ";
                if (Entity.Skh_status_of_dp != null)
                    query = query + "AND skh_status_of_dp = '" + Entity.Skh_status_of_dp + "' ";
                if (Entity.Skh_status_of_cod != null)
                    query = query + "AND skh_status_of_cod = '" + Entity.Skh_status_of_cod + "' ";
                if (Entity.Skh_deliver_from_warehouse_id != null)
                    query = query + "AND skh_deliver_from_warehouse_id = '" + Entity.Skh_deliver_from_warehouse_id + "' ";
                if (Entity.DateFrom != null && Entity.DateTo != null)
                    query = query + "AND skh_so_kp_date BETWEEN '" + Entity.DateFrom + "' AND '" + Entity.DateTo + "' ";
                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable ProductData(SODetailBL Entity)
        {
            try
            {
                query = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS no, skd_line_type, skd_product_id, pm_product_description, " +
                    "skd_unit_measure, skd_qty_ordered, skd_qty_shipped_up_to_date, skd_unit_price, skd_qty_ordered * skd_unit_price AS amount, " +
                    "skd_detail_line_su, skd_detail_line_bv, skd_detail_line_pv, skd_detail_line_p1, skd_detail_line_p2 " +
                    "FROM SO_KP_DETAIL INNER JOIN IM_PRODUCT_MASTER ON SO_KP_DETAIL.skd_product_id = IM_PRODUCT_MASTER.pm_product_id " +
                    "WHERE skd_so_kp_num = '" + Entity.Skd_so_kp_num + "'";
                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Product Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable Report1(SODetailBL Entity)
        {
            try
            {
                query = "SELECT * FROM vw_DATA_BULKORDER_BONUS WHERE 1 = 1 ";
                if (Entity.DateFrom != null && Entity.DateTo != null)
                    query = query + "AND CAST(CONVERT(VARCHAR(8),TglKP,112) AS DATETIME) BETWEEN '" + Entity.DateFrom + "' AND '" + Entity.DateTo + "' ";
                if (Entity.Skh_deliver_from_warehouse_id != null)
                    query = query + "AND WH = '" + Entity.Skh_deliver_from_warehouse_id + "' ";
                if (Entity.Skh_so_kp_number != null)
                    query = query + "AND NoKP = '" + Entity.Skh_so_kp_number + "' ";
                if (Entity.Skh_branch_id != "0")
                    query = query + "AND Branch = '" + Entity.Skh_branch_id + "' ";
                if (Entity.Skh_status_of_delivery != null)
                    query = query + "AND StsDelivery = '" + Entity.Skh_status_of_delivery + "' ";
                query = query + "ORDER BY TglKP DESC";
                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Report Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable Report2(SODetailBL Entity)
        {
            try
            {
                query = "SELECT * FROM VW_DATA_EDC WHERE 1 = 1 ";
                if (Entity.DateFrom != null && Entity.DateTo != null)
                    query = query + "AND CAST(CONVERT(VARCHAR(8),TglKP,112) AS DATETIME) BETWEEN '" + Entity.DateFrom + "' AND '" + Entity.DateTo + "' ";
                if (Entity.Skh_deliver_from_warehouse_id != null)
                    query = query + "AND WH = '" + Entity.Skh_deliver_from_warehouse_id + "' ";
                query = query + "ORDER BY skh_branch_id, skh_so_kp_number ASC";
                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Report Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable Report3(SODetailBL Entity)
        {
            try
            {
                query = "SELECT * FROM vs_data_Unshipment WHERE 1 = 1 ";
                if (Entity.DateFrom != null && Entity.DateTo != null)
                    query = query + "AND CAST(CONVERT(VARCHAR(8),TglKP,112) AS DATETIME) BETWEEN '" + Entity.DateFrom + "' AND '" + Entity.DateTo + "' ";
                query = query + "ORDER BY Branch, No_KP ASC";
                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Report Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable Report4(SODetailBL Entity)
        {
            try
            {
                query = "SELECT skh_branch_id, skh_so_kp_number, sih_so_invoice_number, rm_name, skh_customer_name, skh_sales_type, " +
                    "kf_date_kp_out, skh_status_of_so_kp, skh_so_kp_date, skh_status_of_verification, svs_date_verif_release, skh_status_of_invoice, " +
                    "sih_so_invoice_date, DelParsial, skh_status_of_delivery, tglDelivery, ssh_pod_date, diff_date, skh_status_of_dp, " +
                    "skh_total_item_set_qty, skh_total_pv, skh_total_point_1, skh_desc, ssh_pending, ssh_pending_item, ssh_pending2, ssh_pending_item2, " +
                    "ProductPending, skh_deliver_from_warehouse_id, scm_address1, scm_address2, scm_address3, ks_source, skh_kpo_notes " +
                    "FROM VW_SO_KP_LOG_BOOK WHERE 1 = 1 ";
                if (Entity.Skh_so_kp_number != null)
                    query = query + "AND skh_so_kp_number = '" + Entity.Skh_so_kp_number + "' ";
                if (Entity.Skh_rep_id != null)
                    query = query + "AND skh_rep_id = '" + Entity.Skh_rep_id + "' ";
                if (Entity.Skh_mgr_rep_id != null)
                    query = query + "AND skh_mgr_rep_id = '" + Entity.Skh_mgr_rep_id + "' ";
                if (Entity.Skh_branch_id != "0")
                    query = query + "AND skh_branch_id = '" + Entity.Skh_branch_id + "' ";
                if (Entity.Skh_division_id != "0")
                    query = query + "AND skh_division_id = '" + Entity.Skh_division_id + "' ";
                if (Entity.Skh_order_type != null)
                    query = query + "AND skh_order_type = '" + Entity.Skh_order_type + "' ";
                if (Entity.Skh_sales_type != null)
                    query = query + "AND skh_sales_type = '" + Entity.Skh_sales_type + "' ";
                if (Entity.Skh_status_of_so_kp != null)
                    query = query + "AND skh_status_of_so_kp = '" + Entity.Skh_status_of_so_kp + "' ";
                if (Entity.Skh_status_of_verification != null)
                    query = query + "AND skh_status_of_verification = '" + Entity.Skh_status_of_verification + "' ";
                if (Entity.Skh_status_of_invoice != null)
                    query = query + "AND skh_status_of_invoice = '" + Entity.Skh_status_of_invoice + "' ";
                if (Entity.Skh_status_of_delivery != null)
                    query = query + "AND skh_status_of_delivery = '" + Entity.Skh_status_of_delivery + "' ";
                if (Entity.Skh_status_of_dp != null)
                    query = query + "AND skh_status_of_dp = '" + Entity.Skh_status_of_dp + "' ";
                if (Entity.Skh_status_of_cod != null)
                    query = query + "AND skh_status_of_cod = '" + Entity.Skh_status_of_cod + "' ";
                if (Entity.Skh_deliver_from_warehouse_id != null)
                    query = query + "AND skh_deliver_from_warehouse_id = '" + Entity.Skh_deliver_from_warehouse_id + "' ";
                if (Entity.Ssh_pending != null)
                    query = query + "AND ssh_pending = '" + Entity.Ssh_pending + "' ";
                if (Entity.Ssh_pending2 != null)
                    query = query + "AND ssh_pending2 = '" + Entity.Ssh_pending2 + "' ";
                if (Entity.DateFrom != null && Entity.DateTo != null)
                    query = query + "AND CAST(CONVERT(VARCHAR(8),TglKP,112) AS DATETIME) BETWEEN '" + Entity.DateFrom + "' AND '" + Entity.DateTo + "' ";
                query = query + "ORDER BY skh_so_kp_date";
                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Report Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable Report5(SODetailBL Entity)
        {
            try
            {
                query = "SELECT IM_WAREHOUSE_SECURITY.ws_warehouse_id, IM_WAREHOUSE.wh_warehouse_description " +
                    "FROM IM_WAREHOUSE INNER JOIN IM_WAREHOUSE_SECURITY ON IM_WAREHOUSE.wh_warehouse_id = IM_WAREHOUSE_SECURITY.ws_warehouse_id " +
                    "WHERE IM_WAREHOUSE_SECURITY.ws_user_id = '" + clsLogin.USERID.Trim()+ "' AND " +
                    "IM_WAREHOUSE.wh_manual_transaction_entry_allowed = 'Y'";
                dt = Helper.ExecDT(query);
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        if (dc.DataType == typeof(string))
                        {
                            object obj = dr[dc];
                            if (!Convert.IsDBNull(obj) && obj != null)
                                dr[dc] = obj.ToString().Trim();
                        }
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Report Not Found", clsAlert.Type.Error);
            }

            return dt;
        }
    }
}
