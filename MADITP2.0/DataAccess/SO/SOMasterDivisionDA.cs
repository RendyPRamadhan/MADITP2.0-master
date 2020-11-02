using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MADITP2._0.DataAccess.SO
{
    class SOMasterDivisionDA
    {
        clsGlobal Helper = null;

        public SOMasterDivisionDA()
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
                sqlCriteria = "where LOWER(smd.division_name) like '%" + textToSearch + "%' ";
            }

            int offset = perpage * (page - 1);
            string sql = "select * from SO_MASTER_DIVISION smd " + sqlCriteria + " order by smp.division_id asc offset " + offset + " rows fetch next " + perpage + " row only";
            DataTable dt = this.Helper.ExecuteQuery(sql);
            return dt;
        }
        public int CountRows(string textToSearch = null)
        {
            string sqlCriteria = "";
            if (textToSearch != "" || textToSearch != null)
            {
                sqlCriteria = "where LOWER(smp.division_name) like '%" + textToSearch + "%' ";
            }

            string sql = "select smp.division_id from SO_MASTER_Division smp " + sqlCriteria;
            DataTable dt = this.Helper.ExecDT(sql);
            return dt.Rows.Count;
        }

        public DataTable Read(EnumFilter filter, SOMasterDivisionBL MasterDivisionBL, int currentPage = 1, int fetchLimit = (int)EnumFetchData.DefaultLimit, string search = null)
        {
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        string sql = "select * from SO_MASTER_DIVISION";
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

        public List<ComboBoxViewModel> GetComboboxDivision(bool IsIncludeAll)
        {
            List<ComboBoxViewModel> Result = new List<ComboBoxViewModel>();
            DataTable Data = Read(EnumFilter.GET_ALL, null, 1, 50);
            Result = (from DataRow dr in Data.Rows
                      select new ComboBoxViewModel()
                      {
                          DisplayMember = Helper.CastToString(dr["division_name"]),
                          ValueMember = Helper.CastToString(dr["division_code"])
                      }).ToList();
            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });

            if (!IsIncludeAll)
            {
                Result = Result.Where(x => x.ValueMember != "0").ToList();
            }
            return Result;
        }

        public Boolean Add(SOMasterDivisionBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_code", VALUE= Entity.Division_code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_name", VALUE= Entity.Division_name},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_account", VALUE= Entity.Division_account},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_rpt_desc", VALUE= Entity.Division_rpt_desc},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_flag_cek_lunas_ontime", VALUE= Entity.Division_flag_cek_lunas_ontime},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_syarat_min_su", VALUE= Entity.Division_syarat_min_su},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_pembagi_value", VALUE= Entity.Division_pembagi_value},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_tipe_komisi_cash", VALUE= Entity.Division_tipe_komisi_cash},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_tipe_komisi_credit", VALUE= Entity.Division_tipe_komisi_credit}
                };
                var result = Helper.ExecuteStoreProcedure("sp_INSERT_SO_MASTER_DIVISION", sqlParameter);
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
            string sql = "select max(division_id) as max_smd_id from SO_MASTER_DIVISION";
            DataTable result = Helper.ExecDT(sql);
            if (result.Rows.Count == 0)
            {
                return 1;
            }

            return (int)result.Rows[0]["max_smd_id"] + 1;
        }

        public SOMasterDivisionBL GetDivisionData(int smd_id)
        {
            SOMasterDivisionBL Entity = null;
            string sql = "select * from SO_MASTER_DIVISION where division_id = '" + smd_id + "'";
            try
            {
                DataTable result = Helper.ExecDT(sql);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Principal Data not found");
                    return Entity;
                }

                Entity = new SOMasterDivisionBL();
                Entity.Division_id = (int)result.Rows[0]["division_id"];
                Entity.Division_code = Helper.CastToString(result.Rows[0]["division_code"]);
                Entity.Division_name = Helper.CastToString(result.Rows[0]["division_name"]);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            return Entity;
        }

        public Boolean Put(int smd_id, SOMasterDivisionBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_code", VALUE= Entity.Division_code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@smd_name", VALUE= Entity.Division_name},
                    new SqlParameterHelper() { PARAMETR_NAME = "@smd_id", VALUE = smd_id}
                };
                var result = Helper.ExecuteStoreProcedure("sp_UPDATE_SO_MASTER_DIVISION", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                    throw new Exception("The Level is already exist!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public Boolean Delete(int smd_id, SOMasterDivisionBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper() { PARAMETR_NAME = "@smd_id", VALUE = smd_id}
                };
                var result = Helper.ExecuteStoreProcedure("sp_DELETE_SO_MASTER_DIVISION", sqlParameter);
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
