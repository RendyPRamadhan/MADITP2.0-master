using MADITP2._0.BusinessLogic.IM;
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
    class IMMasterDeliveryManDA
    {
        private clsGlobal Helper;
        private string reason;

        public string Reason { get => reason; set => reason = value; }

        public IMMasterDeliveryManDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public bool Post(IMMasterDeliveryManBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Delivery_man_id", VALUE = Item.Delivery_man_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Delivery_man_name", VALUE = Item.Delivery_man_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Short_name", VALUE = Item.Short_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entity_id", VALUE = Item.Entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Branch_id", VALUE = Item.Branch_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Divison_id", VALUE = Item.Divison_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Sim_number", VALUE = Item.Sim_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@User_id", VALUE = Item.User_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Vehicle_police_number", VALUE = Item.Vehicle_police_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entry_last_update_date", VALUE = DateTime.Now }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_IM_DELIVERY_MAN", sqlParameter);
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

        public bool Put(string DeliveryManID, IMMasterDeliveryManBL Item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Delivery_man_id", VALUE = DeliveryManID},
                    new SqlParameterHelper(){PARAMETR_NAME = "@Delivery_man_name", VALUE = Item.Delivery_man_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Short_name", VALUE = Item.Short_name },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entity_id", VALUE = Item.Entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Branch_id", VALUE = Item.Branch_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Divison_id", VALUE = Item.Divison_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Sim_number", VALUE = Item.Sim_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@User_id", VALUE = Item.User_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Vehicle_police_number", VALUE = Item.Vehicle_police_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Entry_last_update_date", VALUE = DateTime.Now }
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_IM_DELIVERY_MAN", sqlParameter);
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

        public bool Delete(string DeliveryManID)
        {
            string sql = "delete from SO_DELIVERY_MAN_MASTER where sdm_delivery_man_id = @DeliveryManID";
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@DeliveryManID", VALUE = DeliveryManID}
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

        public int CountRows(IMMasterDeliveryManBL DeliveryMan = null, string Search = null)
        {
            string EntityID = "";
            string BranchID = "";
            string DivisionID = "";

            if (Search == null)
            {
                Search = "";
            }

            if(DeliveryMan != null)
            {
                EntityID = DeliveryMan.Entity_id;
                BranchID = DeliveryMan.Branch_id;
                DivisionID = DeliveryMan.Divison_id;
            }

            DataTable dt = Helper.ExecuteQuery($"select count(Delivery_man_id) as jumlah from " +
                $"FUNCTION_IM_DELIVERY_MAN_GET_ALL(-1, -1, '{EntityID}', '{BranchID}', '{DivisionID}', '{Search}')");
            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }

        public List<IMMasterDeliveryManBL> Read(EnumFilter filter, int Offset = 0, int Perpage = (int) EnumFetchData.DefaultLimit,
            IMMasterDeliveryManBL DeliveryMan = null, string Search = null)
        {
            DataTable dt = new DataTable();
            string EntityID = "";
            string BranchID = "";
            string DivisionID = "";

            if (Search == null)
            {
                Search = "";
            }

            if (DeliveryMan != null)
            {
                EntityID = DeliveryMan.Entity_id;
                BranchID = DeliveryMan.Branch_id;
                DivisionID = DeliveryMan.Divison_id;
            }

            List<IMMasterDeliveryManBL> result = new List<IMMasterDeliveryManBL>();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_IM_DELIVERY_MAN_GET_ALL(-1, -1, '{EntityID}', '{BranchID}', '{DivisionID}', '{Search}')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_IM_DELIVERY_MAN_GET_ALL({Offset}, {Perpage}, '{EntityID}', '{BranchID}', '{DivisionID}', '{Search}')");
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
                result = Helper.ConvertDataTableToList<IMMasterDeliveryManBL>(dt);
            }

            return result;
        }

        public IMMasterDeliveryManBL Find(string DeliveryManID)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from " +
                            $"FUNCTION_IM_DELIVERY_MAN_GET('{DeliveryManID}')");
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            return Helper.ConvertDataTableToModel<IMMasterDeliveryManBL>(dt);
        }
    }
}
