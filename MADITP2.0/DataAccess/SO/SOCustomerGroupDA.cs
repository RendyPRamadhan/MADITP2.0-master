using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;

namespace MADITP2._0.DataAccess.SO
{
    class SOCustomerGroupDA
    {
        private clsGlobal Helper;
        private string reason;

        public string Reason { get => reason; set => reason = value; }

        public SOCustomerGroupDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public bool Post(SOCustomerGroupBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_group_id", VALUE = Item.Customer_group_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_group_description", VALUE = Item.Customer_group_description},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Default_price_list", VALUE = Item.Default_price_list},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_account_mask", VALUE = Item.Gl_account_mask}
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_SO_CUSTOMER_GROUP", sqlParameter);
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

        public bool Put(string Code, SOCustomerGroupBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_group_id", VALUE = Code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_group_description", VALUE = Item.Customer_group_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Default_price_list", VALUE = Item.Default_price_list },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_account_mask", VALUE = Item.Gl_account_mask }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_SO_CUSTOMER_GROUP", sqlParameter);
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

        public bool Delete(string Code)
        {
            string sql = "delete from SO_CUSTOMER_GROUP where scg_customer_group_id = @Code";
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Code", VALUE = Code}
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

        public int CountRows(string Search = null)
        {
            if (Search == null)
            {
                Search = "";
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Customer_group_id) as jumlah from " +
                $"FUNCTION_SO_CUSTOMER_GROUP_GET_ALL(-1, -1, '{Search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }

        public List<SOCustomerGroupBL> Read(EnumFilter filter, int Offset = 0, int Perpage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            DataTable dt = new DataTable();
            if (Search == null)
            {
                Search = "";
            }

            List<SOCustomerGroupBL> result = new List<SOCustomerGroupBL>();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_SO_CUSTOMER_GROUP_GET_ALL(-1, -1, '{Search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_SO_CUSTOMER_GROUP_GET_ALL({Offset}, {Perpage}, '{Search}')");
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
                result = Helper.ConvertDataTableToList<SOCustomerGroupBL>(dt);
            }

            return result;
        }

        public SOCustomerGroupBL Find(string DeliveryManID)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_SO_CUSTOMER_GROUP_GET('{DeliveryManID}')");
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<SOCustomerGroupBL>(dt);
        }
    }
}
