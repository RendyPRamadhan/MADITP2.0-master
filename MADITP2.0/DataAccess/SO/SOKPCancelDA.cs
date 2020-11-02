using System;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.SO;

namespace MADITP2._0.DataAccess.SO
{
    class SOKPCancelDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        DataTable dt;
        string query;

        public SOKPCancelDA(clsGlobal helper, clsAlert alert)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                Alert = alert;
                dt = new DataTable();
            }
        }

        public DataTable SearchData(SOKPCancelBL Entity)
        {
            try
            {
                query = "SELECT * FROM vw_SO_KP_CANCEL WHERE skh_so_kp_number = '" + Entity.Skh_so_kp_number + "'";
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

        public DataTable ReadGroup(SOKPCancelBL Entity)
        {
            try
            {
                query = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS no, skd_product_id, skd_unit_measure, skd_product_type, skd_qty_ordered, skd_unit_price_id, " +
                    "skd_unit_price, skd_detail_line_su, skd_detail_line_bv, skd_detail_line_pv, skd_detail_line_p1, skd_detail_line_p2, " +
                    "skd_sts_tax, cast(isnull(skd_dpp,0) as int)skd_dpp, cast(isnull(skd_ppn,0) as int)skd_ppn FROM SO_KP_DETAIL " +
                    "WHERE skd_so_kp_num = '" + Entity.Skh_so_kp_number +
                    "'";
                dt = Helper.ExecDT(query);
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public DataTable ReadProduct(SOKPCancelBL Entity)
        {
            try
            {
                query = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS no, skd_product_id, skd_unit_measure, skd_product_type, skd_qty_ordered, skd_unit_price_id, " +
                    "skd_unit_price, skd_detail_line_su, skd_detail_line_bv, skd_detail_line_pv, skd_detail_line_p1, skd_detail_line_p2, " +
                    "skd_sts_tax, cast(isnull(skd_dpp,0) as int)skd_dpp, cast(isnull(skd_ppn,0) as int)skd_ppn FROM SO_KP_DETAIL " +
                    "WHERE skd_so_kp_num = '" + Entity.Skh_so_kp_number +
                    "'";
                dt = Helper.ExecDT(query);
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public void Update(SOKPCancelBL Entity)
        {
            try
            {
                query = "EXEC sp_SO_KP_CANCEL '" + Entity.Skh_so_kp_number +
                    "', '" + Entity.Skh_price_list_id +
                    "'";
                Helper.BeginTrans();
                Helper.ExecuteTrans(query);

                query = "UPDATE SO_KP_HEADER set skh_reason_type = '" + Entity.Skh_reason_type +
                    "', skh_reason_type = '" + Entity.Skh_reason_detail +
                    "' WHERE skh_so_kp_number = '" + Entity.Skh_so_kp_number +
                    "'";
                Helper.ExecuteTrans(query);
                Helper.CommitTrans();
                Alert.PushAlert("Process Cancel Success", clsAlert.Type.Success);
            }
            catch (Exception)
            {
                Helper.RollbackTrans();
                Alert.PushAlert("Process Cancel Failed", clsAlert.Type.Error);
            }
        }
    }
}
