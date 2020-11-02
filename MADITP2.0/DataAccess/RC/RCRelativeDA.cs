using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.RC
{
    class RCRelativeDA
    {
        private clsGlobal Helper;
        private string reason;

        public string Reason { get => reason; set => reason = value; }

        public RCRelativeDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public bool Post(RCRelativeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_Id", VALUE = Item.Rep_Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rel_Name", VALUE = Item.Rel_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Sta", VALUE = Item.Sta },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Addr_1", VALUE = Item.Addr_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Addr_2", VALUE = Item.Addr_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Addr_3", VALUE = Item.Addr_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@City", VALUE = Item.City },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Phone_Num", VALUE = Item.Phone_Num },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Child_1_Name", VALUE = Item.Child_1_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Dt_Of_Birth1", VALUE = Item.Dt_Of_Birth1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Child_2_Name", VALUE = Item.Child_2_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Dt_Of_Birth2", VALUE = Item.Dt_Of_Birth2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Child_3_Name", VALUE = Item.Child_3_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Dt_Of_Birth3", VALUE = Item.Dt_Of_Birth3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Child1", VALUE = Item.School_Child1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Child2", VALUE = Item.School_Child2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Child3", VALUE = Item.School_Child3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Add_Child1", VALUE = Item.School_Add_Child1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Add_Child2", VALUE = Item.School_Add_Child2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Add_Child3", VALUE = Item.School_Add_Child3 }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_RELATIVE", sqlParameter);
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
        
        public bool Put(int Id, RCRelativeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Id", VALUE = Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rep_Id", VALUE = Item.Rep_Id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Rel_Name", VALUE = Item.Rel_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Sta", VALUE = Item.Sta },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Addr_1", VALUE = Item.Addr_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Addr_2", VALUE = Item.Addr_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Addr_3", VALUE = Item.Addr_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@City", VALUE = Item.City },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Phone_Num", VALUE = Item.Phone_Num },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Child_1_Name", VALUE = Item.Child_1_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Dt_Of_Birth1", VALUE = Item.Dt_Of_Birth1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Child_2_Name", VALUE = Item.Child_2_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Dt_Of_Birth2", VALUE = Item.Dt_Of_Birth2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Child_3_Name", VALUE = Item.Child_3_Name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Dt_Of_Birth3", VALUE = Item.Dt_Of_Birth3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Child1", VALUE = Item.School_Child1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Child2", VALUE = Item.School_Child2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Child3", VALUE = Item.School_Child3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Add_Child1", VALUE = Item.School_Add_Child1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Add_Child2", VALUE = Item.School_Add_Child2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@School_Add_Child3", VALUE = Item.School_Add_Child3 }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_RELATIVE", sqlParameter);
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
            string sql = "delete from RC_REP_FAMILY where rf_id = @Id";
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

        public List<RCRelativeBL> Read(EnumFilter Filter, int Offset = 0, int FetchLimit = (int) EnumFetchData.DefaultLimit, string Search = "")
        {
            DataTable result = new DataTable();
            if (Filter == EnumFilter.GET_ALL) {
                Offset = -1;
                FetchLimit = -1;
            }

            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = Offset },
                    new SqlParameterHelper(){PARAMETR_NAME = "@FetchLimit", VALUE = FetchLimit },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search }
                };

                result = Helper.ExecuteQuery($"SELECT * from FUNCTION_RC_RELATIVE_GET_ALL(@Offset, @FetchLimit, @Search)", sqlParameter);
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            if (result.Rows.Count == 0)
            {
                return new List<RCRelativeBL>();
            }

            return Helper.ConvertDataTableToList<RCRelativeBL>(result);
        }

        public RCRelativeBL Find(int Id)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_RELATIVE_GET('{Id}', default)");
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<RCRelativeBL>(dt);
        }

        public RCRelativeBL FindByRepId(string RepId)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_RC_RELATIVE_GET(default, '{RepId}')");
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<RCRelativeBL>(dt);
        }

        public int CountRows(string Search = "")
        {
            DataTable result = new DataTable();
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search }
                };

                result = Helper.ExecuteQuery($"SELECT count(Id) as jumlah from FUNCTION_RC_RELATIVE_GET_ALL(-1, -1, @Search)", sqlParameter);
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            if (result.Rows.Count == 0)
            {
                return 0;
            }

            return Helper.CastToInt(result.Rows[0]["jumlah"]);
        }
    }
}
