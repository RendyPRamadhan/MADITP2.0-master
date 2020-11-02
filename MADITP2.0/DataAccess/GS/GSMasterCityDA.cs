using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace MADITP2._0.DataAccess.GS
{
    class GSMasterCityDA
    {
        private clsGlobal Helper;
        private string Reason;

        public GSMasterCityDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public Boolean Post(GSMasterCityBL item)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@city_id", VALUE = item.City_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@city", VALUE = item.City },
                    new SqlParameterHelper(){PARAMETR_NAME = "@province", VALUE = item.Province },
                    new SqlParameterHelper(){PARAMETR_NAME = "@kodya_kabupaten", VALUE = item.Kodya_kabupaten } 
                };
                var result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_MASTER_CITY", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "The Level is already exist!";
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
        
        public Boolean Put(int PrimaryKey, GSMasterCityBL item)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@city_id", VALUE = PrimaryKey },
                    new SqlParameterHelper(){PARAMETR_NAME = "@city", VALUE = item.City },
                    new SqlParameterHelper(){PARAMETR_NAME = "@province", VALUE = item.Province },
                    new SqlParameterHelper(){PARAMETR_NAME = "@kodya_kabupaten", VALUE = item.Kodya_kabupaten }
                };
                var result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_MASTER_CITY", sqlParameter);
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
        
        public Boolean Delete(int city_id)
        {
            try 
            {
                string sql = $"delete from CITY_CODES where cc_city_id = '{city_id}'";
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

        public DataTable Read(
            EnumFilter filter,
            GSMasterCityBL masterCity = null,
            int page = 0,
            int perpage = (int)EnumFetchData.DefaultLimit,
            string search = null)
        {
            DataTable result = new DataTable();
            string Province = null;
            string sql = null;
            int offset = (page - 1) * perpage;

            try
            {
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        result = Helper.ExecuteQuery($"SELECT * from FUNCTION_GET_MASTER_CITY_ALL(-1, -1, '', '')");
                        break;

                    case EnumFilter.GET_SEARCH_ID:
                        result = Helper.ExecuteQuery($"SELECT * FROM FUNCTION_GET_MASTER_CITY('{masterCity.City_id}','')");
                        break;

                    case EnumFilter.GET_SEARCH_NAME:
                        result = Helper.ExecuteQuery($"SELECT * FROM FUNCTION_GET_MASTER_CITY('','{masterCity.City}')");
                        break;

                    case EnumFilter.GET_WITH_PAGING:
                        if (masterCity != null && !string.IsNullOrEmpty(masterCity.Province))
                        {
                            Province = masterCity.Province;
                        }

                        sql = $"select * from FUNCTION_GET_MASTER_CITY_ALL({offset}, {perpage}, '{Province}', '{search}')";
                        result = Helper.ExecuteQuery(sql);
                        break;

                    case EnumFilter.GET_COUNT_ROWS:
                        if (masterCity != null && !string.IsNullOrEmpty(masterCity.Province))
                        {
                            Province = masterCity.Province;
                        }

                        sql = $"select count(cc_city_id) as jumlah from FUNCTION_GET_MASTER_CITY_ALL(-1, -1, '{Province}', '{search}')";
                        result = Helper.ExecuteQuery(sql);
                        break;
                }
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            return result;
        }

        public List<string> GetProvices()
        {
            List<string> Provinces = new List<string>();
            string sql = "select DISTINCT cc.cc_province from CITY_CODES cc";
            DataTable dt = Helper.ExecuteQuery(sql);
            if(dt.Rows.Count == 0)
            {
                return Provinces;
            }

            foreach(DataRow item in dt.Rows)
            {
                Provinces.Add(item["cc_province"].ToString().Trim());
            }

            return Provinces;
        }

        public List<string> GetKabupaten(string province = null)
        {
            DataTable dt = new DataTable();
            List<string> Provinces = new List<string>();
            string sql = "select DISTINCT trim(cc.cc_kodya_kabupaten) as cc_kodya_kabupaten from CITY_CODES cc ";
            if (!string.IsNullOrEmpty(province))
            {
                sql += "where trim(cc.cc_province) = trim(@province)";
                List<SqlParameterHelper> sqlp = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper() { PARAMETR_NAME = "@province", VALUE = province }
                };

                dt = Helper.ExecuteQuery(sql, sqlp);
            } 
            else
            {
                dt = Helper.ExecuteQuery(sql);
            }

            if (dt.Rows.Count == 0)
            {
                return Provinces;
            }

            foreach (DataRow item in dt.Rows)
            {
                Provinces.Add(item["cc_kodya_kabupaten"].ToString());
            }

            return Provinces;
        }

        public List<GSMasterCityBL> GetCities(string kodya_kabupaten = null)
        {
            DataTable dt = new DataTable();
            List<GSMasterCityBL> Cities = new List<GSMasterCityBL>();
            string sql = "select * from CITY_CODES cc ";
            if (!string.IsNullOrEmpty(kodya_kabupaten))
            {
                sql += "where trim(cc.cc_kodya_kabupaten) = trim(@kodya_kabupaten)";
                List<SqlParameterHelper> sqlp = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper() { PARAMETR_NAME = "@kodya_kabupaten", VALUE = kodya_kabupaten }
                };

                dt = Helper.ExecuteQuery(sql, sqlp);
            }
            else
            {
                dt = Helper.ExecuteQuery(sql);
            }

            if (dt.Rows.Count == 0)
            {
                return Cities;
            }

            foreach (DataRow item in dt.Rows)
            {
                Cities.Add(new GSMasterCityBL() {
                    City_id = Convert.ToInt32(item["cc_city_id"]),
                    City = item["cc_city"].ToString().Trim(),
                    Province = item["Cc_province"].ToString().Trim(),
                    Kodya_kabupaten = item["Cc_kodya_kabupaten"].ToString().Trim(),
                    Wh_otc = item["Cc_wh_otc"].ToString().Trim(),
                    Survey = item["Cc_survey"].ToString().Trim(),
                    Latitude = item["Cc_latitude"].ToString().Trim(),
                    Longitude = item["Cc_longitude"].ToString().Trim(),
                    City_merge = item["Cc_city_merge"].ToString().Trim()
                });
            }

            return Cities;
        }

        public string GetReason()
        {
            return Reason;
        }

        public int GetSequence()
        {
            string sql = "select max(cc_city_id) as num from CITY_CODES cc";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0 || result.Rows[0]["num"] == null)
            {
                return 1;
            }

            int num = Convert.ToInt32(result.Rows[0]["num"]);
            return (num + 1);
        }
    }
}
