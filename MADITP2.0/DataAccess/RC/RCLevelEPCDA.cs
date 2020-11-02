using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using MADITP2._0.businessLogic.RC;
using MADITP2._0.Global;
using MADITP2._0.Enums;

namespace MADITP2._0.DataAccess.RC
{
    public class RCLevelEPCDA
    {

        clsGlobal Helper = null;

        public RCLevelEPCDA()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
            }

        }

        //Get All User Manager Level (EDP and GDP)
        public List<ComboBoxViewModel> GetLevelEPC()
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery("SELECT ltrim(rtrim(lc_level_id))lc_level_id,ltrim(rtrim(lc_level_description))lc_level_description  FROM FUNCTION_GET_RC_LEVEL_ALL(-1,-1,'','')");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["lc_level_id"]} - {dr["lc_level_description"]}",
                              ValueMember = $"{dr["lc_level_id"]}"
                          }).ToList();
                result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public void Post(RCLevelEPCBO dataMember)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@mm_group", VALUE = dataMember.group_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@mm_position", VALUE= dataMember.position_id } };
                var result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_POSITION_ID", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The Level is already exist!!");
            }
            catch (Exception es)
            {
                throw es;
            }
        }

        public void Put(RCLevelEPCBO dataMember)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@mm_group", VALUE = dataMember.group_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@mm_position", VALUE= dataMember.position_id } };
                var result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_POSITION_ID", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The Level ID is doesn't exist!!");
            }
            catch (Exception es)
            {
                throw es;
            }
        }

        public void Delete(string Group_id,string Position_id)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@mm_group", VALUE= Group_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@mm_position", VALUE= Position_id }
                };
                var result = Helper.ExecuteStoreProcedure("FUNCTION_DELETE_RC_POSITION_ID", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The Level is doesn't exist or already deleted!!");
            }
            catch (Exception es)
            {
                throw es;
            }
        }

        public DataTable Read(EnumFilter enReadType,RCLevelEPCBO RCLevelEPC)
        {
            var result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT * FROM FUNCTION_GS_RC_LEVEL_EPC('','')");
                        break;

                    case EnumFilter.GET_SEARCH_ID:
                        result = Helper.ExecuteQuery($"SELECT GROUP_ID,POSITION_ID  FROM FUNCTION_GS_RC_LEVEL_EPC('{RCLevelEPC.group_id}','')");
                        break;

                    case EnumFilter.GET_ID_NAME:
                        result = Helper.ExecuteQuery($"SELECT GROUP_ID,POSITION_ID FROM FUNCTION_GS_RC_LEVEL_EPC('{RCLevelEPC.group_id}','{RCLevelEPC.position_id}')");
                        
                        break;

                    case EnumFilter.GET_SEARCH_NAME:
                        result = Helper.ExecuteQuery($"SELECT GROUP_ID,POSITION_ID FROM FUNCTION_GS_RC_LEVEL_EPC('','{RCLevelEPC.position_id}')");
                        break;

                    case EnumFilter.GET_ID_ASC:
                        result = Helper.ExecuteQuery("SELECT * FROM FUNCTION_GS_RC_LEVEL_EPC('','') order by GROUP_ID");
                        break;

                    case EnumFilter.GET_ID_DESC:
                        result = Helper.ExecuteQuery("SELECT * FROM FUNCTION_GS_RC_LEVEL_EPC('','') order by GROUP_ID DESC");
                        break;

                    case EnumFilter.GET_NAME_ASC:
                        result = Helper.ExecuteQuery("SELECT * FROM FUNCTION_GS_RC_LEVEL_EPC('','') order by POSITION_ID ASC");
                        break;

                    case EnumFilter.GET_NAME_DESC:
                        result = Helper.ExecuteQuery("SELECT * FROM FUNCTION_GS_RC_LEVEL_EPC('','') order by POSITION_ID DESC");
                        break;
                }
                

            }
            catch (SystemException dex)
            {
                MessageBox.Show(dex.Message.ToString());
            }
            return result;
        }
    }
}
