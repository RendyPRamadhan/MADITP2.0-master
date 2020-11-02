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
    class RCLanguageCodeDA
    {
        private string reason;
        private clsGlobal Helper;

        public RCLanguageCodeDA(clsGlobal mHelper)
        {
            Helper = mHelper;
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(RCLanguageCodeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id", VALUE = Item.Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Language", VALUE = Item.Language}
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_LANGUAGE", sqlParameter);
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

        public bool Put(string Id, RCLanguageCodeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id", VALUE = Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Language", VALUE = Item.Language }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_LANGUAGE", sqlParameter);
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
            string sql = "delete from LANGUAGE_CODES where languange_id = @Id";
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

        public List<RCLanguageCodeBL> Read(EnumFilter Filter, int Offset = 0, int FetchLimit = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            List<RCLanguageCodeBL> Result = new List<RCLanguageCodeBL>();
            DataTable dt = new DataTable();
            List<SqlParameterHelper> SqlParameter = new List<SqlParameterHelper>() {
                new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = -1 },
                new SqlParameterHelper(){PARAMETR_NAME = "@FetchLimit", VALUE = -1 },
                new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = "" }
            };

            try
            {
                if (Filter == EnumFilter.GET_WITH_PAGING)
                {
                    SqlParameter = new List<SqlParameterHelper>() {
                        new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = Offset },
                        new SqlParameterHelper(){PARAMETR_NAME = "@FetchLimit", VALUE = FetchLimit },
                        new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search }
                    };
                }

                dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_LANGUAGE_GET_ALL(@Offset, @FetchLimit, @Search)", SqlParameter);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message.ToString());
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                Result = Helper.ConvertDataTableToList<RCLanguageCodeBL>(dt);
            }

            return Result;
        }

        public RCLanguageCodeBL Find(string Id)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_LANGUAGE_GET('{Id}')");
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<RCLanguageCodeBL>(dt);
        }

        public int CountRows(string Search = null)
        {
            if (Search == null)
            {
                Search = "";
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Id) as jumlah from FUNCTION_RC_LANGUAGE_GET_ALL(-1, -1, '{Search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }
    }
}
