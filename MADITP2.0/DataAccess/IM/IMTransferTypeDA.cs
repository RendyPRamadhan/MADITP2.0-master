using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows;

namespace MADITP2._0.DataAccess.IM
{
    class IMTransferTypeDA
    {
        private clsGlobal Helper;
        private string mReason;

        public string Reason { get => mReason; set => mReason = value; }

        public IMTransferTypeDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public Boolean Post(IMTransferTypeBL Item) 
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Transfer_txn_type_code", VALUE = Item.Transfer_txn_type_code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Transfer_txn_type_description", VALUE = Item.Transfer_txn_type_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@With_transit_warehouse", VALUE = Item.With_transit_warehouse },
                    new SqlParameterHelper(){PARAMETR_NAME = "@System_type", VALUE = Item.System_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Confirmation_transfer_required", VALUE = Item.Confirmation_transfer_required },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_out_from_org_wh", VALUE = Item.Txn_type_out_from_org_wh },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_in_to_transit_wh", VALUE = Item.Txn_type_in_to_transit_wh },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_out_from_transit_wh", VALUE = Item.Txn_type_out_from_transit_wh },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_in_to_destination_wh", VALUE = Item.Txn_type_in_to_destination_wh },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_out_from_transit_ex_pod", VALUE = Item.Txn_type_out_from_transit_ex_pod },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_into_or_wh_ex_pod", VALUE = Item.Txn_type_into_or_wh_ex_pod }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_IM_TRANSFER_TXN_TYPE", sqlParameter);
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

        public Boolean Put(string Code, IMTransferTypeBL Item) 
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Transfer_txn_type_code", VALUE = Code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Transfer_txn_type_description", VALUE = Item.Transfer_txn_type_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@With_transit_warehouse", VALUE = Item.With_transit_warehouse },
                    new SqlParameterHelper(){PARAMETR_NAME = "@System_type", VALUE = Item.System_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Confirmation_transfer_required", VALUE = Item.Confirmation_transfer_required },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_out_from_org_wh", VALUE = Item.Txn_type_out_from_org_wh },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_in_to_transit_wh", VALUE = Item.Txn_type_in_to_transit_wh },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_out_from_transit_wh", VALUE = Item.Txn_type_out_from_transit_wh },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_in_to_destination_wh", VALUE = Item.Txn_type_in_to_destination_wh },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_out_from_transit_ex_pod", VALUE = Item.Txn_type_out_from_transit_ex_pod },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Txn_type_into_or_wh_ex_pod", VALUE = Item.Txn_type_into_or_wh_ex_pod }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_IM_TRANSFER_TXN_TYPE", sqlParameter);
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

        public Boolean Delete(string Code) 
        {
            string sql = "delete from IM_TRANSFER_TXN_TYPE where ttt_transfer_txn_type_code = @code";
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

        public int CountRows(string search = null)
        {
            if (search == null)
            {
                search = "";
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Transfer_txn_type_code) as jumlah from FUNCTION_IM_TRANSFER_TXN_TYPE_GET_ALL(-1, -1, '{search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }

        public List<IMTransferTypeBL> Read(EnumFilter filter, int offset, int perpage, string search = null) 
        {
            DataTable dt = new DataTable();
            if (search == null)
            {
                search = "";
            }

            List<IMTransferTypeBL> result = new List<IMTransferTypeBL>();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_TRANSFER_TXN_TYPE_GET_ALL(-1, -1, '{search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_TRANSFER_TXN_TYPE_GET_ALL({offset}, {perpage}, '{search}')");
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
                result = Helper.ConvertDataTableToList<IMTransferTypeBL>(dt);
            }

            return result;
        }

        public IMTransferTypeBL GetTransferType(string Code)
        {
            IMTransferTypeBL result = new IMTransferTypeBL();
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_TRANSFER_TXN_TYPE_GET('{Code}')");
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            try
            {
                result = Helper.ConvertDataTableToModel<IMTransferTypeBL>(dt);
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
