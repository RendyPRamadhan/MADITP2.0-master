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
namespace MADITP2._0.login
{
    class clsLogLoginDA
    {
        clsGlobal Helper = null;
        string SQLstr;

        public  clsLogLoginDA()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
            }

        }

        public void Post(clsLogLoginBO dataMember)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@usr_user_id", VALUE = dataMember.login.USRID.ToString() },
                    new SqlParameterHelper(){PARAMETR_NAME = "@ket", VALUE= dataMember.Keterangan },
                new SqlParameterHelper(){PARAMETR_NAME = "@log", VALUE= dataMember.LogStatus },
                new SqlParameterHelper(){PARAMETR_NAME = "@ip", VALUE= dataMember.IP },
                new SqlParameterHelper(){PARAMETR_NAME = "@host", VALUE= dataMember.Host },
                new SqlParameterHelper(){PARAMETR_NAME = "@version", VALUE= dataMember.Version }};
                var result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_GS_LOG_USER", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The User is already exist!!");
            }
            catch (Exception es)
            {
                throw es;
            }
        }

        public void Put(clsLogLoginBO dataMember)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@USERS", VALUE = dataMember.login.USRID.ToString() },
                    new SqlParameterHelper(){PARAMETR_NAME = "@FLAG", VALUE= (dataMember.Flag.ToString()) },
                new SqlParameterHelper(){PARAMETR_NAME = "@ip", VALUE= dataMember.IP }};
                var result = Helper.ExecuteStoreProcedure("sp_INSERT_GS_UPDATE_USERS", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The User is already exist!!");
            }
            catch (Exception es)
            {
                throw es;
            }
        }
        public List<ComboBoxViewModel> GetBranch()
        {
            DataTable Data = new DataTable();
            clsLogLoginBO.BranchUser Model = new clsLogLoginBO.BranchUser();
            var result = new List<ComboBoxViewModel>();
            try
            {
                SQLstr = "SELECT * FROM vw_USER_BRANCHES ";
                if (clsLogin.USERID != null)
                {
                    SQLstr = SQLstr + " where gub_user_id = '" + clsLogin.USERID + "'";
                }
                Data = Helper.ExecDT(SQLstr);
                //Data = Read(EnumFilter.GET_ALL, Model);
                result = (from DataRow dr in Data.Rows
                          where dr.Field<string>("gub_branch_id") != "0"
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["bc_branch"]}",
                              ValueMember = $"{dr["gub_branch_id"]}"
                          }).ToList();
                result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public List<ComboBoxViewModel> GetEntity()
        {
            DataTable Data = new DataTable();
            clsLogLoginBO.BranchUser Model = new clsLogLoginBO.BranchUser();
            var result = new List<ComboBoxViewModel>();
            try
            {
                SQLstr = "SELECT * FROM vw_USER_ENTITIES ";
                if (clsLogin.USERID != null)
                {
                    SQLstr = SQLstr + " where gue_user_id = '" + clsLogin.USERID + "'";
                }
                Data = Helper.ExecDT(SQLstr);
                //Data = Read(EnumFilter.GET_ALL, Model);
                result = (from DataRow dr in Data.Rows
                          where dr.Field<string>("gec_entity_id") != "0"
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["gec_entity"]}",
                              ValueMember = $"{dr["gec_entity_id"]}"
                          }).ToList();
                result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
