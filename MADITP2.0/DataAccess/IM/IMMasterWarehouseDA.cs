using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.DataAccess.IM
{
    class IMMasterWarehouseDA
    {
        private clsGlobal Helper;
        public string Reason;

        public IMMasterWarehouseDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public Boolean Post(IMMasterWarehouseBL item)
        {
            if (isExists(item.warehouse_id))
            {
                Reason = "Warehouse ID is already exists!";
                return false;
            }

            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_warehouse_id", VALUE = item.warehouse_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_warehouse_description", VALUE = item.warehouse_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_address_1", VALUE = item.address_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_address_2", VALUE = item.address_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_address_3", VALUE = item.address_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_area_code", VALUE = item.area_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_city", VALUE = item.city },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_postal_code", VALUE = item.postal_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_province", VALUE = item.province },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_phone", VALUE = item.phone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_fax", VALUE = item.fax },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_contact_person", VALUE = item.contact_person },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_type", VALUE = item.type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_sales_shipment_allowed", VALUE = item.sales_shipment_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_receipt_from_po_rec_allowed", VALUE = item.receipt_from_po_rec_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_receipt_from_non_po_allowed", VALUE = item.receipt_from_non_po_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_manual_transaction_entry_allowed", VALUE = item.manual_transaction_entry_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_cost_revaluation_allowed", VALUE = item.cost_revaluation_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_transfer_transaction_allowed", VALUE = item.transfer_transaction_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_transit_warehouse_id", VALUE = item.transit_warehouse_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_damage_warehouse_id", VALUE = item.damage_warehouse_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_gl_entity", VALUE = item.gl_entity },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_gl_account", VALUE = item.gl_account.Replace("-", "") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_creation_date", VALUE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_last_update_date", VALUE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_used_id", VALUE = item.used_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_digital", VALUE = item.digital },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_sap_code", VALUE = item.sloc_sap_code }
                };

                var result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_IM_WAREHOUSE", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Unable to save data!";
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

        public Boolean Put(string wh_warehouse_id, IMMasterWarehouseBL item)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_warehouse_id", VALUE = wh_warehouse_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_warehouse_description", VALUE = item.warehouse_description },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_address_1", VALUE = item.address_1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_address_2", VALUE = item.address_2 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_address_3", VALUE = item.address_3 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_area_code", VALUE = item.area_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_city", VALUE = item.city },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_postal_code", VALUE = item.postal_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_province", VALUE = item.province },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_phone", VALUE = item.phone },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_fax", VALUE = item.fax },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_contact_person", VALUE = item.contact_person },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_type", VALUE = item.type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_sales_shipment_allowed", VALUE = item.sales_shipment_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_receipt_from_po_rec_allowed", VALUE = item.receipt_from_po_rec_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_receipt_from_non_po_allowed", VALUE = item.receipt_from_non_po_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_manual_transaction_entry_allowed", VALUE = item.manual_transaction_entry_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_cost_revaluation_allowed", VALUE = item.cost_revaluation_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_transfer_transaction_allowed", VALUE = item.transfer_transaction_allowed },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_transit_warehouse_id", VALUE = item.transit_warehouse_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_damage_warehouse_id", VALUE = item.damage_warehouse_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_gl_entity", VALUE = item.gl_entity },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_gl_account", VALUE = item.gl_account.Replace("-", "") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_last_update_date", VALUE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_used_id", VALUE = item.used_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_digital", VALUE = item.digital },
                    new SqlParameterHelper(){PARAMETR_NAME = "@wh_sap_code", VALUE = item.sloc_sap_code }
                };

                var result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_IM_WAREHOUSE", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Not found warehouse_id!";
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

        public Boolean Delete(string wh_warehouse_id)
        {
            string sql = $"DELETE FROM IM_WAREHOUSE WHERE wh_warehouse_id = '{wh_warehouse_id}';";
            try
            {
                Helper.BeginTrans();
                Helper.ExecuteTrans(sql);
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

        public IMMasterWarehouseBL GetWarehouse(string warehouse_id)
        {
            DataTable dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_WAREHOUSE_GET('{warehouse_id}')");
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            IMMasterWarehouseBL wh = Helper.ConvertDataTableToModel<IMMasterWarehouseBL>(dt);
            return wh;
        }

        public List<IMMasterWarehouseBL> Read(EnumFilter Filter, int offset, int perpage = (int)EnumFetchData.DefaultLimit, IMMasterWarehouseBL wh = null, string search = null)
        {
            DataTable dt = null;
            string filterCity = "";
            if(wh != null && !string.IsNullOrEmpty(wh.city))
            {
                filterCity = wh.city;
            }

            if(search == null)
            {
                search = "";
            }

            List<IMMasterWarehouseBL> result = new List<IMMasterWarehouseBL>();
            try
            {
                switch (Filter)
                {
                    case EnumFilter.GET_ALL:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_WAREHOUSE_GET_ALL(-1, -1, '', '')");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_WAREHOUSE_GET_ALL({offset}, {perpage}, '{filterCity}', '{search}')");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        dt = Helper.ExecuteQuery($"select * from FUNCTION_IM_WAREHOUSE_GET_ALL(-1, -1, '{filterCity}', '{search}')");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                result = Helper.ConvertDataTableToList<IMMasterWarehouseBL>(dt);
            }

            return result;
        }

        public List<string> GetListCities()
        {
            List<string> output = new List<string>();
            string sql = "select DISTINCT upper(iw.wh_city) as wh_city from IM_WAREHOUSE iw where iw.wh_city is not null";
            DataTable dt = Helper.ExecuteQuery(sql);
            if(dt.Rows.Count == 0)
            {
                return output;
            }

            foreach (DataRow item in dt.Rows)
            {
                output.Add(Helper.CastToString(item["wh_city"]));
            }

            return output;
        }

        public Boolean isExists(string warehouse_id)
        {
            List<SqlParameterHelper> sqlp = new List<SqlParameterHelper>(){
                    new SqlParameterHelper() { PARAMETR_NAME = "@warehouse_id", VALUE = warehouse_id }
            };

            DataTable result = Helper.ExecuteQuery($"select top 1 wh_warehouse_id from IM_WAREHOUSE where wh_warehouse_id = @warehouse_id", sqlp);
            if(result.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
