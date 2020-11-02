using MADITP2._0.businessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.DataAccess.SO
{
    public class SOMasterPrincipalDA
    {
        clsGlobal Helper = null;

        public SOMasterPrincipalDA()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
            }
        }
        public DataTable AdvanceShowList(int page = 1, int perpage = 5, string textToSearch = null)
        {
            string sqlCriteria = "";
            if (textToSearch != "" || textToSearch != null)
            {
                sqlCriteria = "where LOWER(smp.smp_name) like '%" + textToSearch + "%' ";
            }

            int offset = perpage * (page - 1);
            string sql = "select * from SO_MASTER_PRINCIPAL smp " + sqlCriteria + " order by smp.smp_id asc offset " + offset + " rows fetch next " + perpage + " row only";
            DataTable dt = this.Helper.ExecuteQuery(sql);
            return dt;
        }

        public int CountRows(string textToSearch = null)
        {
            string sqlCriteria = "";
            if (textToSearch != "" || textToSearch != null)
            {
                sqlCriteria = "where LOWER(smp.smp_name) like '%" + textToSearch + "%' ";
            }

            string sql = "select smp.smp_id from SO_MASTER_PRINCIPAL smp " + sqlCriteria;
            DataTable dt = this.Helper.ExecDT(sql);
            return dt.Rows.Count;
        }
        public DataTable Read(EnumFilter filter, SOMasterPrincipalBL MasterPrincipalBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, string search = null)
        {
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        string sql = "select * from SO_MASTER_PRINCIPAL";
                        result = Helper.ExecuteQuery(sql);
                        break;

                    case EnumFilter.GET_WITH_PAGING:
                        result = AdvanceShowList(currentPage, fetchLimit, search);
                        break;
                }
            }
            catch (SystemException e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            return result;
        }

        public List<ComboBoxViewModel> GetPrincipalName()
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Helper.ExecuteQuery("SELECT [Principal_Name] FROM [dbo].[vw_SO_MASTER_PRINCIPAL]");
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["Principal_Name"]}",
                              ValueMember = $"{dr["Principal_Name"]}"
                          }).ToList();
                result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public Boolean Add(SOMasterPrincipalBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@smp_name", VALUE= Entity.principal_name},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smp_desc", VALUE= Entity.principal_desc},
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[sp_INSERT_SO_MASTER_PRINCIPAL]", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The Level is already exist!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public int GetSequence()
        {
            string sql = "select max(smp_id) as max_smp_id from SO_MASTER_PRINCIPAL";
            DataTable result = Helper.ExecDT(sql);
            if (result.Rows.Count == 0)
            {
                return 1;
            }

            return (int)result.Rows[0]["max_smp_id"] + 1;
        }

        public SOMasterPrincipalBL GetPrincipalData(int smp_id)
        {
            SOMasterPrincipalBL Entity = null;
            string sql = "select * from SO_MASTER_PRINCIPAL where smp_id = '" + smp_id + "'";
            try
            {
                DataTable result = Helper.ExecDT(sql);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Principal Data not found");
                    return Entity;
                }

                Entity = new SOMasterPrincipalBL();
                Entity.principal_id = (int)result.Rows[0]["smp_id"];
                Entity.principal_name = Helper.CastToString(result.Rows[0]["smp_name"]);
                Entity.principal_desc = Helper.CastToString(result.Rows[0]["smp_desc"]);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            return Entity;
        }

        public Boolean Put(int smp_id,SOMasterPrincipalBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@smp_name", VALUE= Entity.principal_name},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smp_desc", VALUE= Entity.principal_desc},
                    new SqlParameterHelper() { PARAMETR_NAME = "@smp_id", VALUE = smp_id}
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[sp_UPDATE_SO_MASTER_PRINCIPAL]", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The Level is already exist!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public Boolean Delete(int smp_id, SOMasterPrincipalBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper() { PARAMETR_NAME = "@smp_id", VALUE = smp_id}
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[sp_DELETE_SO_MASTER_PRINCIPAL]", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The Level is already exist!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
    
}
