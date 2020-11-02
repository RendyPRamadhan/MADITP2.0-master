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
    class RCReligionDA
    {
        private string reason;
        private clsGlobal Helper;

        public RCReligionDA(clsGlobal mHelper)
        {
            Helper = mHelper;
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(RCReligionBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Religion", VALUE = Item.Religion }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_RELIGION", sqlParameter);
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

        public bool Put(int Id, RCReligionBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id", VALUE = Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Religion", VALUE = Item.Religion }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_RELIGION", sqlParameter);
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
            string sql = "delete from TBL_RELIGIONS where id = @Id";
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

        public List<RCReligionBL> Read(EnumFilter Filter, int Offset = 0, int FetchLimit = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            List<RCReligionBL> Result = new List<RCReligionBL>();
            DataTable dt = new DataTable();

            try
            {
                switch (Filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_RELIGION_GET_ALL(-1, -1, '{Search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_RELIGION_GET_ALL({Offset}, {FetchLimit}, '{Search}')");
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
                Result = Helper.ConvertDataTableToList<RCReligionBL>(dt);
            }

            return Result;
        }

        public RCReligionBL Find(int Id)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_RELIGION_GET({Id})");
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<RCReligionBL>(dt);
        }

        public int CountRows(string Search = null)
        {
            if (Search == null)
            {
                Search = "";
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Id) as jumlah from FUNCTION_RC_RELIGION_GET_ALL(-1, -1, '{Search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }
    }
}
