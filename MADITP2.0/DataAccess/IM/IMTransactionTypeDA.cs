using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;

namespace MADITP2._0.DataAccess.IM
{
    class IMTransactionTypeDA
    {
        private clsGlobal Helper;
        private string mReason;

        public string Reason { get => mReason; set => mReason = value; }

        public IMTransactionTypeDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public bool Post(IMTransactionTypeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_code", VALUE = Item.Txn_type_code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_description", VALUE = Item.Txn_type_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Allow_inventory_txn_entry", VALUE = Item.Allow_inventory_txn_entry },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Allow_negative_qty_entry", VALUE = Item.Allow_negative_qty_entry },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Negate_qty_entered", VALUE = Item.Negate_qty_entered },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Allow_change_date", VALUE = Item.Allow_change_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Promth_cost_field", VALUE = Item.Promth_cost_field },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Update_qty_on_hand", VALUE = Item.Update_qty_on_hand },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Update_stock_movement", VALUE = Item.Update_stock_movement },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Interface_to_gl", VALUE = Item.Interface_to_gl },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_txn_type", VALUE = Item.Gl_txn_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@In_out_flag", VALUE = Item.In_out_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Group_acc", VALUE = Item.Group_acc }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_IM_TRANSACTION_TYPE", sqlParameter);
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

        public bool Put(string Code, IMTransactionTypeBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_code", VALUE = Code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_description", VALUE = Item.Txn_type_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Allow_inventory_txn_entry", VALUE = Item.Allow_inventory_txn_entry },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Allow_negative_qty_entry", VALUE = Item.Allow_negative_qty_entry },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Negate_qty_entered", VALUE = Item.Negate_qty_entered },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Allow_change_date", VALUE = Item.Allow_change_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Promth_cost_field", VALUE = Item.Promth_cost_field },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Update_qty_on_hand", VALUE = Item.Update_qty_on_hand },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Update_stock_movement", VALUE = Item.Update_stock_movement },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Interface_to_gl", VALUE = Item.Interface_to_gl },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Gl_txn_type", VALUE = Item.Gl_txn_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@In_out_flag", VALUE = Item.In_out_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Group_acc", VALUE = Item.Group_acc }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_IM_TRANSACTION_TYPE", sqlParameter);
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
            string sql = "delete from IM_TXN_TYPE where tt_txn_type_code = @code";
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@code", VALUE = Code}
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

        public int CountRows(string Search = null) {
            if (Search == null)
            {
                Search = "";
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Txn_type_code) as jumlah from FUNCTION_IM_TRANSACTION_TYPE_GET_ALL(-1, -1, '{Search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }

        public List<IMTransactionTypeBL> Read(EnumFilter filter, int offset = 0, int perpage = (int) EnumFetchData.DefaultLimit, string search = null) 
        {
            DataTable dt = new DataTable();
            if (search == null)
            {
                search = "";
            }

            List<IMTransactionTypeBL> result = new List<IMTransactionTypeBL>();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_TRANSACTION_TYPE_GET_ALL(-1, -1, '{search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_TRANSACTION_TYPE_GET_ALL({offset}, {perpage}, '{search}')");
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
                result = Helper.ConvertDataTableToList<IMTransactionTypeBL>(dt);
            }

            return result;
        }

        public IMTransactionTypeBL GetTransactionType(string Code)
        {
            IMTransactionTypeBL result = new IMTransactionTypeBL();
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_TRANSACTION_TYPE_GET('{Code}')");
            if (dt.Rows.Count == 0)
            {
                Reason = "Transaction Type not found!";
                return null;
            }

            try
            {
                result = Helper.ConvertDataTableToModel<IMTransactionTypeBL>(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show(e.Message);
            }

            return result;
        }
    }
}
