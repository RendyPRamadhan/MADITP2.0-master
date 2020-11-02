using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;

namespace MADITP2._0.DataAccess.RC
{
    class RCRepTypeDA
    {
        private string reason;
        private clsGlobal Helper;

        public RCRepTypeDA(clsGlobal mHelper)
        {
            Helper = mHelper;
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(RCRepTypeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_type_id", VALUE = Item.Rep_type_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_type_description", VALUE = Item.Rep_type_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_1", VALUE = Item.Udf_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_2", VALUE = Item.Udf_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_3", VALUE = Item.Udf_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_4", VALUE = Item.Udf_4 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_5", VALUE = Item.Udf_5 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_mask", VALUE = Item.Gl_acc_mask },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_entity_id", VALUE = Item.Gl_acc_entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_branch_init", VALUE = Item.Gl_acc_branch_init },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_div_id", VALUE = Item.Gl_acc_div_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_dept_id", VALUE = Item.Gl_acc_dept_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_major1", VALUE = Item.Gl_major1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_major2", VALUE = Item.Gl_major2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_minor", VALUE = Item.Gl_minor },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_analisys", VALUE = Item.Gl_analisys },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_filler", VALUE = Item.Gl_filler },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Remark", VALUE = Item.Remark },
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_REP_TYPE", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Insert failed!";
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

        public bool Put(string Id, RCRepTypeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_type_id", VALUE = Item.Rep_type_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_type_description", VALUE = Item.Rep_type_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_1", VALUE = Item.Udf_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_2", VALUE = Item.Udf_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_3", VALUE = Item.Udf_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_4", VALUE = Item.Udf_4 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Udf_5", VALUE = Item.Udf_5 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_mask", VALUE = Item.Gl_acc_mask },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_entity_id", VALUE = Item.Gl_acc_entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_branch_init", VALUE = Item.Gl_acc_branch_init },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_div_id", VALUE = Item.Gl_acc_div_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_acc_dept_id", VALUE = Item.Gl_acc_dept_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_major1", VALUE = Item.Gl_major1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_major2", VALUE = Item.Gl_major2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_minor", VALUE = Item.Gl_minor },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_analisys", VALUE = Item.Gl_analisys },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_filler", VALUE = Item.Gl_filler },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Remark", VALUE = Item.Remark },
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_REP_TYPE", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Update failed!";
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

        public bool Delete(string Id)
        {
            string sql = "delete from RC_TYPE where trim(rt_rep_type_id) = trim(@Id)";
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id", VALUE = Id}
                };

                Helper.BeginTrans();
                Helper.ExecuteTrans(sql, sqlParameter);
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

        public List<RCRepTypeBL> Read(EnumFilter Filter, int Offset = 0, int FetchLimit = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            List<RCRepTypeBL> Result = new List<RCRepTypeBL>();
            DataTable dt = new DataTable();

            try
            {
                switch (Filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_REP_TYPE_GET_ALL(-1, -1, '{Search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_REP_TYPE_GET_ALL({Offset}, {FetchLimit}, '{Search}')");
                        break;
                }
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message.ToString());
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                Result = Helper.ConvertDataTableToList<RCRepTypeBL>(dt);
            }

            return Result;
        }

        public RCRepTypeBL Find(string Id)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_REP_TYPE_GET('{Id}')");
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<RCRepTypeBL>(dt);
        }

        public int CountRows(string Search = null)
        {
            if (Search == null)
            {
                Search = "";
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Id) as jumlah from FUNCTION_RC_TEAM_GET_ALL(-1, -1, '{Search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }
    }
}
