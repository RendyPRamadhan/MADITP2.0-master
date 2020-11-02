using MADITP2._0.businessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.RC
{
    /// <summary>
    /// Do not access this model directly, use via RCMasterLevelAL instead.
    /// </summary>
    class RCMasterLevelDA
    {
        private clsGlobal Helper;
        private string reason;

        /// <summary>
        /// Get reason of why current process is failed
        /// </summary>
        public string Reason { get => reason; set => reason = value; }

        public RCMasterLevelDA(clsGlobal helper)
        {
            Helper = helper;
        }

        /// <summary>
        /// Read data from RC_LEVEL_CODE. 
        /// Implemented filter: GET_ALL, GET_SEARCH_ID, GET_SEARCH_NAME, GET_WITH_PAGING
        /// </summary>
        public DataTable Read(
            EnumFilter filter, 
            RCMasterLevelBL masterLevel = null, 
            int offset = 0, 
            int perpage = (int)EnumFetchData.DefaultLimit,
            string search = null)
        {
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT * from FUNCTION_GET_RC_LEVEL_ALL(-1, -1, '', '')");
                        break;

                    case EnumFilter.GET_SEARCH_ID:
                        result = Helper.ExecuteQuery($"SELECT * FROM FUNCTION_GET_RC_LEVEL('{masterLevel.Lc_id}','')");
                        break;

                    case EnumFilter.GET_SEARCH_NAME:
                        result = Helper.ExecuteQuery($"SELECT * FROM FUNCTION_GET_RC_LEVEL('','{masterLevel.Lc_level_description}')");
                        break;

                    case EnumFilter.GET_WITH_PAGING:
                        string divisionID = null;
                        if(masterLevel != null && (masterLevel.Lc_division_id != null || masterLevel.Lc_division_id != string.Empty))
                        {
                            divisionID = masterLevel.Lc_division_id;
                        }

                        result = AdvanceShowList(offset, perpage, divisionID, search);
                        break;
                    
                    case EnumFilter.GET_COUNT_ROWS:
                        string mdivisionID = null;
                        if (masterLevel != null && (masterLevel.Lc_division_id != null || masterLevel.Lc_division_id != string.Empty))
                        {
                            mdivisionID = masterLevel.Lc_division_id;
                        }

                        result = CountRows(mdivisionID, search);
                        break;
                }
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            return result;
        }

        public Boolean Post(RCMasterLevelBL Entity)
        {
            try 
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_division_id", VALUE = Entity.Lc_division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_level_id", VALUE = Entity.Lc_level_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_level_description", VALUE = Entity.Lc_level_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_break_level", VALUE = Entity.Lc_break_level },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_status", VALUE = Entity.Lc_status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_cwh_amount", VALUE = Entity.Lc_cwh_amount },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_user_defined_1", VALUE = Entity.Lc_user_defined_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_user_defined_2", VALUE = Entity.Lc_user_defined_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_date_created", VALUE = Entity.Lc_date_created },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_last_date_update", VALUE = Entity.Lc_last_date_update },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_user_id", VALUE = Entity.Lc_user_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_achievement_type", VALUE = Entity.Lc_q_achievement_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_su", VALUE = Entity.Lc_q_total_su },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_set", VALUE = Entity.Lc_q_total_set },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_sales_value", VALUE = Entity.Lc_q_total_sales_value },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_pv", VALUE = Entity.Lc_q_total_pv },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_bv", VALUE = Entity.Lc_q_total_bv },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_member_recruited", VALUE = Entity.Lc_q_total_member_recruited },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_direct_member", VALUE = Entity.Lc_q_total_direct_member },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_new_customer", VALUE = Entity.Lc_q_total_new_customer },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_point_1", VALUE = Entity.Lc_q_total_point_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_point_2", VALUE = Entity.Lc_q_total_point_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_within_length_of_period", VALUE = Entity.Lc_q_within_length_of_period },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_min_achievement_per_month", VALUE = Entity.Lc_q_min_achievement_per_month },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_certificate_hold", VALUE= Entity.Lc_q_certificate_hold }
                };

                var result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_LEVEL", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Save data failed";
                    return false;
                }
            }
            catch (Exception e)
            {
                Helper.RollbackTrans();
                Console.WriteLine(e.StackTrace);
                Reason = e.Message.ToString();
                return false;
            }

            return true;
        }

        public Boolean Put(int PrimaryKey, RCMasterLevelBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_id", VALUE = Entity.Lc_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_division_id", VALUE = Entity.Lc_division_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_level_id", VALUE = Entity.Lc_level_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_level_description", VALUE = Entity.Lc_level_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_break_level", VALUE = Entity.Lc_break_level },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_status", VALUE = Entity.Lc_status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_cwh_amount", VALUE = Entity.Lc_cwh_amount },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_user_defined_1", VALUE = Entity.Lc_user_defined_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_user_defined_2", VALUE = Entity.Lc_user_defined_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_date_created", VALUE = Entity.Lc_date_created },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_last_date_update", VALUE = Entity.Lc_last_date_update },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_user_id", VALUE = Entity.Lc_user_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_achievement_type", VALUE = Entity.Lc_q_achievement_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_su", VALUE = Entity.Lc_q_total_su },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_set", VALUE = Entity.Lc_q_total_set },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_sales_value", VALUE = Entity.Lc_q_total_sales_value },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_pv", VALUE = Entity.Lc_q_total_pv },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_bv", VALUE = Entity.Lc_q_total_bv },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_member_recruited", VALUE = Entity.Lc_q_total_member_recruited },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_direct_member", VALUE = Entity.Lc_q_total_direct_member },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_new_customer", VALUE = Entity.Lc_q_total_new_customer },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_point_1", VALUE = Entity.Lc_q_total_point_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_total_point_2", VALUE = Entity.Lc_q_total_point_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_within_length_of_period", VALUE = Entity.Lc_q_within_length_of_period },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_min_achievement_per_month", VALUE = Entity.Lc_q_min_achievement_per_month },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lc_q_certificate_hold", VALUE= Entity.Lc_q_certificate_hold }
                };

                var result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_LEVEL", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Update data failed";
                    return false;
                }
            }
            catch (Exception e)
            {
                Helper.RollbackTrans();
                Console.WriteLine(e.StackTrace);
                Reason = e.Message.ToString();
                return false;
            }

            return true;
        }

        public Boolean Delete(int PrimaryKey)
        {
            string sql = $"DELETE FROM RC_LEVEL_CODE WHERE lc_id = '{PrimaryKey}';";
            try
            {
                Helper.BeginTrans();
                Helper.ExecuteTrans(sql);
                Helper.CommitTrans();
            }
            catch (Exception e)
            {
                Helper.RollbackTrans();
                Console.WriteLine(e.StackTrace);
                Reason = e.Message.ToString();
                return false;
            }

            return true;
        }

        private DataTable AdvanceShowList(int offset = 0, int perpage = (int)EnumFetchData.DefaultLimit, string divisionID = null, string search = null)
        {
            if(search == null)
            {
                search = "";
            }
            
            if(divisionID == null)
            {
                divisionID = "";
            }

            DataTable dt = Helper.ExecuteQuery($"SELECT * FROM FUNCTION_GET_RC_LEVEL_ALL('{offset}','{perpage}', '{divisionID}', '{search}')");
            return dt;
        }

        private DataTable CountRows(string divisionID = null, string search = null)
        {
            string sql = $"SELECT count(lc_level_id) as jumlah FROM RC_LEVEL_CODE ";
            if(!string.IsNullOrEmpty(divisionID) || !string.IsNullOrEmpty(search))
            {
                sql += $"where ";
            }

            if (!string.IsNullOrEmpty(divisionID))
            {
                sql += $"lc_division_id = '{divisionID}' ";
            }

            if (!string.IsNullOrEmpty(search))
            {
                if (!string.IsNullOrEmpty(divisionID))
                {
                    sql += $"and ";
                }

                sql += $"lower(lc_level_description) like lower('%{search}%') ";
            }

            DataTable dt = Helper.ExecuteQuery(sql);
            return dt;
        }

        public DataTable GetLevelsByDivision(string division) 
        {
            var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@division", VALUE = division }
            };

            DataTable dt = Helper.ExecuteQuery($"SELECT DISTINCT lc_level_id, lc_level_description FROM FUNCTION_GET_RC_LEVEL_ALL(-1,-1, @division, '')", 
                sqlParameter);
            return dt;
        }
    }
}
