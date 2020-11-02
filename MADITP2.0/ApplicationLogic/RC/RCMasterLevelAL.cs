using MADITP2._0.businessLogic.RC;
using MADITP2._0.DataAccess.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;

namespace MADITP2._0.ApplicationLogic.RC
{
    class RCMasterLevelAL
    {
        private clsGlobal Helper;
        private RCMasterLevelDA Model;
        private string reason;

        public RCMasterLevelAL(clsGlobal helper)
        {
            Helper = helper;
            Model = new RCMasterLevelDA(Helper);
        }

        public DataTable Read(
            EnumFilter filter,
            RCMasterLevelBL masterLevel = null,
            int page = 1,
            int perpage = (int)EnumFetchData.DefaultLimit,
            string search = null)
        {
            int offset = (page - 1) * perpage;
            return Model.Read(filter, masterLevel, offset, perpage, search);
        }

        public RCMasterLevelBL GetLevelCode(int lc_id)
        {
            RCMasterLevelBL item = new RCMasterLevelBL();
            item.Lc_id = lc_id;
            DataTable dt = Model.Read(EnumFilter.GET_SEARCH_ID, item);
            if(dt.Rows.Count == 0)
            {
                SetReason("Level Code not found!");
                return null;
            }

            DataRow data = dt.Rows[0];
            item.Lc_id = Convert.ToInt32(data["lc_id"]);
            item.Lc_division_id = data["lc_division_id"].ToString().Trim();
            item.Lc_level_id = data["lc_level_id"].ToString().Trim();
            item.Lc_level_description = data["lc_level_description"].ToString().Trim();
            item.Lc_break_level = data["lc_break_level"].ToString().Trim();
            item.Lc_status = data["lc_status"].ToString().Trim();
            item.Lc_cwh_amount = Convert.ToInt32(data["lc_cwh_amount"]);
            item.Lc_user_defined_1 = Convert.ToInt32(data["lc_user_defined_1"]);
            item.Lc_user_defined_2 = data["lc_user_defined_2"].ToString().Trim();
            item.Lc_date_created = (DateTime) data["lc_date_created"];
            item.Lc_last_date_update = (DateTime) data["lc_last_date_update"];
            item.Lc_user_id = data["lc_user_id"].ToString().Trim();
            item.Lc_q_achievement_type = data["lc_q_achievement_type"].ToString().Trim();
            item.Lc_q_total_su = Convert.ToInt32(data["lc_q_total_su"]);
            item.Lc_q_total_set = Convert.ToInt32(data["lc_q_total_set"]);
            item.Lc_q_total_sales_value = Convert.ToInt32(data["lc_q_total_sales_value"]);
            item.Lc_q_total_pv = Convert.ToInt32(data["lc_q_total_pv"]);
            item.Lc_q_total_bv = Convert.ToInt32(data["lc_q_total_bv"]);
            item.Lc_q_total_member_recruited = Convert.ToInt32(data["lc_q_total_member_recruited"]);
            item.Lc_q_total_direct_member = Convert.ToInt32(data["lc_q_total_direct_member"]);
            item.Lc_q_total_new_customer = Convert.ToInt32(data["lc_q_total_new_customer"]);
            item.Lc_q_total_point_1 = Convert.ToInt32(data["lc_q_total_point_1"]);
            item.Lc_q_total_point_2 = Convert.ToInt32(data["lc_q_total_point_2"]);
            item.Lc_q_within_length_of_period = Convert.ToInt32(data["lc_q_within_length_of_period"]);
            item.Lc_q_min_achievement_per_month = Convert.ToInt32(data["lc_q_min_achievement_per_month"]);
            item.Lc_q_certificate_hold = data["lc_q_certificate_hold"].ToString().Trim();
            item.Lc_m_achievement_type = data["lc_m_achievement_type"].ToString().Trim();
            item.Lc_m_total_su = Convert.ToInt32(data["lc_m_total_su"]);
            item.Lc_m_total_set = Convert.ToInt32(data["lc_m_total_set"]);
            item.Lc_m_total_sales_value = Convert.ToInt32(data["lc_m_total_sales_value"]);
            item.Lc_m_total_pv = Convert.ToInt32(data["lc_m_total_pv"]);
            item.Lc_m_total_bv = Convert.ToInt32(data["lc_m_total_bv"]);
            item.Lc_m_total_member_recruited = Convert.ToInt32(data["lc_m_total_member_recruited"]);
            item.Lc_m_total_direct_member = Convert.ToInt32(data["lc_m_total_direct_member"]);
            item.Lc_m_total_new_customers = Convert.ToInt32(data["lc_m_total_new_customers"]);
            item.Lc_m_total_point_1 = Convert.ToInt32(data["lc_m_total_point_1"]);
            item.Lc_m_total_point_2 = Convert.ToInt32(data["lc_m_total_point_2"]);
            item.Lc_m_within_length_of_period = Convert.ToInt32(data["lc_m_within_length_of_period"]);
            item.Lc_m_min_achievement_per_month = Convert.ToInt32(data["lc_m_min_achievement_per_month"]);
            item.Lc_m_default_candidates_flag = data["lc_m_default_candidates_flag"].ToString().Trim();
            item.Lc_q_period_recruit = (data["lc_q_period_recruit"] == DBNull.Value) ? 0 : Convert.ToInt32(data["lc_q_period_recruit"]);
            item.Lc_m_period_recruit = (data["lc_m_period_recruit"] == DBNull.Value) ? 0 : Convert.ToInt32(data["lc_m_period_recruit"]);

            return item;
        }

        public Boolean Post(RCMasterLevelBL item)
        {
            if(string.IsNullOrEmpty(item.Lc_level_id))
            {
                SetReason("Level ID is empty");
                return false;
            }

            if(string.IsNullOrEmpty(item.Lc_level_description))
            {
                SetReason("Level description is empty");
                return false;
            }

            if (string.IsNullOrEmpty(item.Lc_level_description))
            {
                SetReason("Level description is empty");
                return false;
            }

            if (string.IsNullOrEmpty(item.Lc_break_level))
            {
                SetReason("Break level is empty");
                return false;
            }

            return Model.Post(item);
        }

        public Boolean Put(int primaryKey, RCMasterLevelBL item)
        {
            return Model.Put(primaryKey, item);
        }

        public Boolean Delete(int primaryKey)
        {
            return Model.Delete(primaryKey);
        }

        /// <summary>
        /// Get list of master level code as ComboBoxViewModel
        /// </summary>
        /// <returns></returns>
        public List<ComboBoxViewModel> GetListAsCombobox(bool DisplayAsValue = false)
        {
            List<ComboBoxViewModel> result = new List<ComboBoxViewModel>();
            try
            {
                int index = 0;
                DataTable dt = Model.Read(EnumFilter.GET_ALL);
                foreach (DataRow row in dt.Rows)
                {
                    ComboBoxViewModel cvm = new ComboBoxViewModel()
                    {
                        DisplayMember = $"{row["lc_level_id"]} - {row["lc_level_description"]}",
                        ValueMember = DisplayAsValue ? Helper.CastToString(row["lc_level_description"]) : $"{ row["lc_level_id"]}"
                    };

                    result.Insert(index, cvm);
                    index++;
                }                

                result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                SetReason(e.Message.ToString());
            }

            return result;
        }

        public void SetReason(string reason)
        {
            this.reason = reason;
        }

        public string GetReason()
        {
            return (this.reason == null) ? Model.Reason : this.reason;
        }

        public DataTable GetLevelsByDivision(string division) 
        {
            return Model.GetLevelsByDivision(division);
        }
    }
}
