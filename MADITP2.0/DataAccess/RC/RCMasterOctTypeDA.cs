using MADITP2._0.businessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.DataAccess.RC
{
    class RCMasterOctTypeDA
    {
        clsGlobal Helper = null;
        public RCMasterOctTypeDA()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
            }
        }

        public DataTable Read(EnumFilter enReadType, RCMasterOctTypeBL Entity = null)
        {
            var result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT rot_oct_type, rot_type_desc, rot_user FROM RC_OCT_TYPE");
                        break;

                    case EnumFilter.GET_SEARCH_ID:
                        result = Helper.ExecuteQuery($"SELECT rot_oct_type, rot_type_desc, rot_user FROM RC_OCT_TYPE where rot_oct_type = '{Entity.Rot_oct_type}'");
                        break;

                    case EnumFilter.GET_SEARCH_NAME:
                        result = Helper.ExecuteQuery($"SELECT rot_oct_type, rot_type_desc, rot_user FROM RC_OCT_TYPE where lower(rot_type_desc) like '%{Entity.Rot_type_desc.ToLower()}%'");
                        break;
                }


            }
            catch (SystemException dex)
            {
                MessageBox.Show(dex.Message.ToString());
            }
            return result;
        }

        public void Post(RCMasterOctTypeBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@rot_oct_type", VALUE = Entity.Rot_oct_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@rot_type_desc", VALUE= Entity.Rot_type_desc },
                    new SqlParameterHelper(){PARAMETR_NAME = "@rot_user", VALUE= Entity.Rot_user } 
                };

                DataTable checkRow = Read(EnumFilter.GET_SEARCH_NAME, Entity);
                if (checkRow.Rows.Count > 0)
                {
                    throw new Exception("The Level is already exist!!");
                }

                string sql = "insert into RC_OCT_TYPE (rot_oct_type, rot_type_desc, rot_user) values (@rot_oct_type, @rot_type_desc, @rot_user)";
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

        public void Put(RCMasterOctTypeBL Entity)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@rot_oct_type", VALUE = Entity.Rot_oct_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@rot_type_desc", VALUE= Entity.Rot_type_desc } };

                string sql = "update RC_OCT_TYPE set rot_type_desc = @rot_type_desc where rot_oct_type = @rot_oct_type";
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

        public void Delete(string id)
        {
            try
            {
                string sql = $"delete from RC_OCT_TYPE where rot_oct_type = '{ id }'";
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
                              DisplayMember = $"{dr["rot_type_desc"]}",
                              ValueMember = $"{dr["rot_oct_type"]}"
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
