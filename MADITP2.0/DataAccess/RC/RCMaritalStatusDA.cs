using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MADITP2._0.DataAccess.RC
{
    class RCMaritalStatusDA
    {
        private string reason;
        private clsGlobal Helper;

        public RCMaritalStatusDA(clsGlobal mHelper)
        {
            Helper = mHelper;
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(RCMaritalStatusBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Marital_status", VALUE = Item.Marital_status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Created_at", VALUE = DateTime.Now },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Updated_at", VALUE = DateTime.Now },
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_MARITAL_STATUS", sqlParameter);
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

        public bool Put(int Id, RCMaritalStatusBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id", VALUE = Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Marital_status", VALUE = Item.Marital_status },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Updated_at", VALUE = DateTime.Now }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_MARITAL_STATUS", sqlParameter);
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

        public bool Delete(int Id)
        {
            string sql = "delete from RC_MARITAL_STATUS where id = @Id";
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

        public List<RCMaritalStatusBL> Read(EnumFilter Filter, int Offset = 0, int FetchLimit = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            List<RCMaritalStatusBL> Result = new List<RCMaritalStatusBL>();
            DataTable dt = new DataTable();
            List<SqlParameterHelper> SqlParameter = new List<SqlParameterHelper>() {
                new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = -1 },
                new SqlParameterHelper(){PARAMETR_NAME = "@FetchLimit", VALUE = -1 },
                new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = "" }
            };

            try
            {
                if(Filter == EnumFilter.GET_WITH_PAGING)
                {
                    SqlParameter = new List<SqlParameterHelper>() {
                        new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = Offset },
                        new SqlParameterHelper(){PARAMETR_NAME = "@FetchLimit", VALUE = FetchLimit },
                        new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search }
                    };
                }

                dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_MARITAL_STATUS_GET_ALL(@Offset, @FetchLimit, @Search)", SqlParameter);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message.ToString());
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                Result = Helper.ConvertDataTableToList<RCMaritalStatusBL>(dt);
            }

            return Result;
        }

        public RCMaritalStatusBL Find(int Id)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_MARITAL_STATUS_GET({Id})");
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<RCMaritalStatusBL>(dt);
        }

        public int CountRows(string Search = null)
        {
            if (Search == null)
            {
                Search = "";
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Id) as jumlah from FUNCTION_RC_MARITAL_STATUS_GET_ALL(-1, -1, '{Search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }
    }
}
