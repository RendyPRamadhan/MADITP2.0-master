using MADITP2._0.businessLogic.GS;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;

namespace MADITP2._0.ApplicationLogic.GS
{
    class GSMasterCityAL
    {
        private clsGlobal Helper;
        private GSMasterCityDA Accessor;
        private GSMasterZipCodesAL MasterZipCodes;
        private string Reason;

        /// <summary>
        /// Application logic for table CITY_CODES 
        /// 
        /// Param `masterZipCodes` is nullable. You can't use delete feature if `masterZipCodes` set as null.
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="masterZipCodes"></param>
        public GSMasterCityAL(clsGlobal helper, GSMasterZipCodesAL masterZipCodes = null)
        {
            Helper = helper;
            Accessor = new GSMasterCityDA(helper);
            MasterZipCodes = masterZipCodes;
        }

        public Boolean Post(GSMasterCityBL item)
        {
            return Accessor.Post(item);
        }

        public Boolean Put(int PrimaryKey, GSMasterCityBL item)
        {
            return Accessor.Put(PrimaryKey, item);
        }

        public Boolean Delete(int city_id)
        {
            if(MasterZipCodes == null)
            {
                Reason = "Unable to use delete function!";
                return false;
            }

            if (MasterZipCodes.GetByCityID(city_id) != null)
            {
                Reason = "Delete failed! Selected city is used in Master Zip Codes.";
                return false;
            }

            return Accessor.Delete(city_id);
        }

        public DataTable Read(
            EnumFilter filter,
            GSMasterCityBL masterCity = null,
            int page = 1,
            int perpage = (int)EnumFetchData.DefaultLimit,
            string search = null)
        {
            return Accessor.Read(filter, masterCity, page, perpage, search);
        }

        public DataTable AdvanceShowList(int page, int perpage = (int)EnumFetchData.DefaultLimit, string province = null, string search = null)
        {
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, new GSMasterCityBL() { Province = province }, page, perpage, search);
        }

        public DataTable CountRows(string province = null, string search = null)
        {
            return Accessor.Read(EnumFilter.GET_COUNT_ROWS, new GSMasterCityBL() { Province = province }, -1, -1, search);
        }

        public string GetReason()
        {
            if (!string.IsNullOrEmpty(Accessor.GetReason()))
            {
                return Accessor.GetReason();
            }

            return Reason;
        }

        public int GetSequence()
        {
            return Accessor.GetSequence();
        }

        public GSMasterCityBL GetCity(int city_id)
        {
            DataTable dt = Accessor.Read(EnumFilter.GET_SEARCH_ID, new GSMasterCityBL() { City_id = city_id });
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            var item = dt.Rows[0];
            GSMasterCityBL data = new GSMasterCityBL()
            {
                City = Helper.CastToString(item["cc_city"]),
                City_id = Helper.CastToInt(item["cc_city_id"]),
                Kodya_kabupaten = Helper.CastToString(item["cc_kodya_kabupaten"]),
                Province = Helper.CastToString(item["cc_province"])
            };

            return data;
        }

        public List<string> GetProvices()
        {
            return Accessor.GetProvices();
        }

        public List<string> GetKabupaten(string province = null)
        {
            return Accessor.GetKabupaten(province);
        }

        public List<GSMasterCityBL> GetCities(string kodya_kabupaten = null)
        {
            return Accessor.GetCities(kodya_kabupaten);
        }
    }
}
