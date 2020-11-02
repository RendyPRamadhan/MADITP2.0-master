using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.DataAccess.RC
{
    class RCCategoryEpcDA
    {
        private clsGlobal Helper;
        private string mReason;

        public string Reason { get => mReason; set => mReason = value; }

        public RCCategoryEpcDA(clsGlobal helper) 
        {
            Helper = helper;
        }

        public Boolean Post(RCCategoryEpcBL item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Description", VALUE = item.Description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@CreatedAt", VALUE = DateTime.Now },
                    new SqlParameterHelper(){PARAMETR_NAME = "@UpdatedAt", VALUE = DateTime.Now }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_CATEGORY_EPC", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Input failed!";
                    return false;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return false;
            }

            return true;
        }

        public Boolean Put(int Id, RCCategoryEpcBL item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id", VALUE = Id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Description", VALUE = item.Description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@UpdatedAt", VALUE = DateTime.Now }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_CATEGORY_EPC", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Not found!";
                    return false;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return false;
            }

            return true;
        }

        public Boolean Delete(int id)
        {
            string sql = $"DELETE FROM RC_CATEGORY_EPC WHERE id = '{id}';";
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

        public int CountRows(string search = null)
        {
            DataTable dt = Helper.ExecuteQuery($"select count(Id) as jumlah from FUNCTION_RC_CATEGORY_EPC_ALL(-1, -1, '{search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }

        public RCCategoryEpcBL GetCategoryEpc(int Id)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_CATEGORY_EPC('{Id}')");
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<RCCategoryEpcBL>(dt);
        }

        public List<RCCategoryEpcBL> Read(EnumFilter filter, int offset = 0, int perpage = (int)EnumFetchData.DefaultLimit, string search = null)
        {
            List<RCCategoryEpcBL> Output = new List<RCCategoryEpcBL>();
            DataTable dt = new DataTable();
            if (search == null)
            {
                search = "";
            }

            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_CATEGORY_EPC_ALL(-1, -1, '{search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_CATEGORY_EPC_ALL({offset}, {perpage}, '{search}')");
                        break;
                }
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Reason = ex.Message.ToString();
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                Output = Helper.ConvertDataTableToList<RCCategoryEpcBL>(dt);
            }

            return Output;
        }
    }
}
