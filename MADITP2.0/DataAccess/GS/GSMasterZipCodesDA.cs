using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.DataAccess.GS
{
    internal class GSMasterZipCodesDA
    {
        private clsGlobal Helper;
        private string mReason;

        public GSMasterZipCodesDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public string Reason { get => mReason; set => mReason = value; }

        public Boolean Post(GSMasterZipCodesBL item)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@zip_code", VALUE = item.Zip_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@kecamatan", VALUE = item.Kecamatan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@kelurahan", VALUE = item.Kelurahan},
                    new SqlParameterHelper(){PARAMETR_NAME = "@city", VALUE = item.City},
                    new SqlParameterHelper(){PARAMETR_NAME = "@sts_update", VALUE = item.Sts_update},
                    new SqlParameterHelper(){PARAMETR_NAME = "@web_subdistrict_id", VALUE = item.Web_subdistrict_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@area_code", VALUE = item.Area_code}
                };
                var result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_ZIPCODES", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Zip Codes is already exist!";
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

        public Boolean Put(int id, GSMasterZipCodesBL item)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE = item.ID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@city", VALUE = item.City},
                    new SqlParameterHelper(){PARAMETR_NAME = "@zip_code", VALUE = item.Zip_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@kelurahan", VALUE = item.Kelurahan},
                    new SqlParameterHelper(){PARAMETR_NAME = "@kecamatan", VALUE = item.Kecamatan },
                    new SqlParameterHelper(){PARAMETR_NAME = "@sts_update", VALUE = item.Sts_update},
                    new SqlParameterHelper(){PARAMETR_NAME = "@web_subdistrict_id", VALUE = item.Web_subdistrict_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@area_code", VALUE = item.Area_code}
                };
                var result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_ZIPCODES", sqlParameter);
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

        public Boolean Delete(int id)
        {
            try
            {
                string sql = $"delete from ZIP_CODES where id = '{id}'";
                Helper.BeginTrans();
                Helper.ExecuteTrans(sql);
                Helper.CommitTrans();
            }
            catch (Exception e)
            {
                Helper.RollbackTrans();
                Reason = e.Message.ToString();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Get list kecamatan as list of string
        /// accept param cityId (int) as criteria
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public List<string> GetListKecamatan(int cityId = 0)
        {
            string sqlCriteria = "";
            if(cityId > 0)
            {
                sqlCriteria = $"where city = {cityId}";
            }

            List<string> kecamatan = new List<string>();
            string sql = $"select trim(kecamatan) as kecamatan from ZIP_CODES {sqlCriteria} group by trim(kecamatan)";
            DataTable dt = Helper.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                kecamatan.Add(item["kecamatan"].ToString().Trim());
            }

            return kecamatan;
        }

        public List<string> GetListKelurahan(int cityId = 0)
        {
            string sqlCriteria = "";
            if (cityId > 0)
            {
                sqlCriteria = $"where city = {cityId}";
            }

            List<string> kelurahan = new List<string>();
            string sql = $"select trim(kelurahan) as kelurahan from ZIP_CODES {sqlCriteria} group by trim(kelurahan)";
            DataTable dt = Helper.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                kelurahan.Add(item["kelurahan"].ToString().Trim());
            }

            return kelurahan;
        }

        public DataTable Read(
            EnumFilter filter,
            GSMasterZipCodesBL ZipCodes = null,
            int offset = 0,
            int perpage = (int)EnumFetchData.DefaultLimit,
            string search = null)
        {
            string kecamatan = "";
            DataTable result = new DataTable();
            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT * from FUNCTION_GET_ZIPCODES_ALL(-1, -1, '', '')");
                        break;

                    case EnumFilter.GET_SEARCH_ID:
                        result = Helper.ExecuteQuery($"SELECT * FROM FUNCTION_GET_ZIPCODES('{ZipCodes.ID}','')");
                        break;

                    case EnumFilter.GET_SEARCH_NAME:
                        result = Helper.ExecuteQuery($"SELECT * FROM FUNCTION_GET_ZIPCODES('','{ZipCodes.Zip_code}')");
                        break;

                    case EnumFilter.GET_WITH_PAGING:
                        if (ZipCodes != null && ZipCodes.Kecamatan != null)
                        {
                            kecamatan = ZipCodes.Kecamatan;
                        }

                        result = Helper.ExecuteQuery($"select * from FUNCTION_GET_ZIPCODES_ALL({offset}, {perpage}, '{kecamatan}', '{search}')");
                        break;

                    case EnumFilter.GET_COUNT_ROWS:
                        if (ZipCodes != null && ZipCodes.Kecamatan != null)
                        {
                            kecamatan = ZipCodes.Kecamatan;
                        }

                        result = Helper.ExecuteQuery($"select count(city) as jumlah from FUNCTION_GET_ZIPCODES_ALL(-1, -1, '{kecamatan}', '{search}')");
                        break;
                }
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            return result;
        }

        public GSMasterZipCodesBL GetByCityID(int city_id)
        {
            GSMasterZipCodesBL zipcodes = new GSMasterZipCodesBL();
            string sql = $"select * from ZIP_CODES where id = '{city_id}'";
            DataTable dt = Helper.ExecuteQuery(sql);
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            try {
                zipcodes = Helper.ConvertDataTableToModel<GSMasterZipCodesBL>(dt);
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }

            return zipcodes;
        }
    }
}