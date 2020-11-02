using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.DataAccess.GS
{
    class GSMasterReligionDA
    {
        clsGlobal Helper = null;
        public GSMasterReligionDA()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
            }
        }

        public DataTable Read(EnumFilter enReadType, GSMasterReligionBL Entity = null)
        {
            var result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT id, religion FROM TBL_RELIGIONS");
                        break;

                    case EnumFilter.GET_SEARCH_ID:
                        result = Helper.ExecuteQuery($"SELECT id, religion FROM TBL_RELIGIONS where id = '{Entity.Id}'");
                        break;

                    case EnumFilter.GET_SEARCH_NAME:
                        result = Helper.ExecuteQuery($"SELECT id, religion FROM TBL_RELIGIONS where lower(religion) like '%{Entity.Religion.ToLower()}%'");
                        break;
                }


            }
            catch (SystemException dex)
            {
                MessageBox.Show(dex.Message.ToString());
            }
            return result;
        }

        public void Post(GSMasterReligionBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE = Entity.Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@religion", VALUE= Entity.Religion } };

                DataTable checkRow = Read(EnumFilter.GET_SEARCH_NAME, Entity);
                if(checkRow.Rows.Count > 0)
                {
                    throw new Exception("The Level is already exist!!");
                }

                string sql = "insert into TBL_RELIGIONS (id, religion) values (@id, @religion)";
                Helper.BeginTrans();
                Helper.ExecuteTrans(sql, sqlParameter);
                Helper.CommitTrans();
            }
            catch (Exception es)
            {
                Helper.RollbackTrans();
                throw es;
            }
        }

        public void Put(GSMasterReligionBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE = Entity.Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@religion", VALUE= Entity.Religion } };

                string sql = "update TBL_RELIGIONS set religion = @religion where id = @id";
                Helper.BeginTrans();
                Helper.ExecuteTrans(sql, sqlParameter);
                Helper.CommitTrans();
            }
            catch (Exception es)
            {
                Helper.RollbackTrans();
                throw es;
            }
        }

        public void Delete(int id)
        {
            try
            {
                string sql = $"update TBL_RELIGIONS set religion = @religion where id = '{ id }'";
                Helper.BeginTrans();
                Helper.ExecuteTrans(sql);
                Helper.CommitTrans();
            }
            catch (Exception es)
            {
                Helper.RollbackTrans();
                throw es;
            }
        }

        public List<ComboBoxViewModel> GetEntity()
        {
            var dt = new DataTable();
            var result = new List<ComboBoxViewModel>();
            try
            {
                dt = Read(EnumFilter.GET_ALL);
                result = (from DataRow dr in dt.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["religion"]}",
                              ValueMember = $"{dr["id"]}"
                          }).ToList();
                result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}

