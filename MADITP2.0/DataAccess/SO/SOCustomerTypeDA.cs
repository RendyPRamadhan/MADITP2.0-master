using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MADITP2._0.DataAccess.IM
{
    class SOCustomerTypeDA
    {
        private clsGlobal Helper;
        private string reason;

        public string Reason { get => reason; set => reason = value; }

        public SOCustomerTypeDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public bool Post(SOCustomerTypeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_type", VALUE = Item.Customer_type},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_type_description", VALUE = Item.Customer_type_description},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Default_price_list", VALUE = Item.Default_price_list},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_account_mask", VALUE = Item.Gl_account_mask}
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_SO_CUSTOMER_TYPE", sqlParameter);
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

        public bool Put(string CustomerType, SOCustomerTypeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_type", VALUE = CustomerType},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Customer_type_description", VALUE = Item.Customer_type_description},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Default_price_list", VALUE = Item.Default_price_list},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_account_mask", VALUE = Item.Gl_account_mask}
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_SO_CUSTOMER_TYPE", sqlParameter);
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
            string sql = "delete from SO_CUSTOMER_TYPE where sct_customer_type = @Code";
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
            DataTable dt = Helper.ExecuteQuery($"select count(Customer_type) as jumlah from " +
                $"FUNCTION_SO_CUSTOMER_TYPE_GET_ALL(-1, -1, '{Search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }

        public List<SOCustomerTypeBL> Read(EnumFilter filter, int Offset = 0, int Perpage = (int) EnumFetchData.DefaultLimit, string Search = null)
        {
            DataTable dt = new DataTable();
            if (Search == null)
            {
                Search = "";
            }

            List<SOCustomerTypeBL> result = new List<SOCustomerTypeBL>();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_SO_CUSTOMER_TYPE_GET_ALL(-1, -1, '{Search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_SO_CUSTOMER_TYPE_GET_ALL({Offset}, {Perpage}, '{Search}')");
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
                result = Helper.ConvertDataTableToList<SOCustomerTypeBL>(dt);
            }

            return result;
        }

        public SOCustomerTypeBL Find(string DeliveryManID)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_SO_CUSTOMER_TYPE_GET('{DeliveryManID}')");
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<SOCustomerTypeBL>(dt);
        }
    }
}
