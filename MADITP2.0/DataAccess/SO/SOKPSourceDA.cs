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
    class SOKPSourceDA
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        DataTable dt;
        string query;

        public SOKPSourceDA(clsGlobal helper, clsAlert alert)
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
                query = "SELECT * FROM SO_KP_SOURCE ORDER BY ks_id";
                dt = Helper.ExecDT(query);
            }
            catch (Exception)
            {
                Alert.PushAlert("Data Not Found", clsAlert.Type.Error);
            }

            return dt;
        }

        public List<ComboBoxViewModel> GetSourceGroup()
        {
            var dt = new DataTable();
            var combo = new List<ComboBoxViewModel>();
            try
            {
                query = "SELECT src_group, src_subgroup, src_id FROM SO_KP_SOURCE_GROUP ORDER BY src_id ";
                dt = Helper.ExecDT(query);
                combo = (from DataRow dr in dt.Rows
                         select new ComboBoxViewModel()
                         {
                             DisplayMember = $"{dr["src_subgroup"]}",
                             ValueMember = $"{dr["src_id"]}"
                         }).ToList();
                combo.Insert(0, new ComboBoxViewModel() { DisplayMember = "Select Source Group", ValueMember = "" });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combo;
        }

        public void Create(SOKPSourceBL Entity)
        {
            try
            {
                query = "INSERT INTO SO_KP_SOURCE (ks_id, ks_source) VALUES (@ks_id, @ks_source)";

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

        public void Update(SOKPSourceBL Entity)
        {
            try
            {
                query = "UPDATE SO_KP_SOURCE SET ks_source = @ks_source WHERE ks_id = @ks_id";

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

        public void Delete(SOKPSourceBL Entity)
        {
            try
            {
                query = "DELETE FROM SO_KP_SOURCE WHERE ks_id = @ks_id";

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

        private List<SqlParameterHelper> GetParam(SOKPSourceBL Entity)
        {
            var param = new List<SqlParameterHelper>()
            {
                new SqlParameterHelper() { PARAMETR_NAME = "@ks_id", VALUE = Entity.ks_id },
                new SqlParameterHelper() { PARAMETR_NAME = "@ks_source", VALUE = Entity.ks_source },
                new SqlParameterHelper() { PARAMETR_NAME = "@ks_group", VALUE = Entity.ks_group }
            };

            return param;
        }
    }
}
