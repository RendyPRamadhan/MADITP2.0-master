using MADITP2._0.businessLogic.GS;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;

namespace MADITP2._0.ApplicationLogic.GS
{
    class GSMasterZipCodesAL
    {
        private clsGlobal Helper;
        private GSMasterZipCodesDA Accessor;
        private string mReason;

        public GSMasterZipCodesAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new GSMasterZipCodesDA(Helper);
        }

        public string GetReason()
        {
            if (!string.IsNullOrEmpty(Accessor.Reason))
            {
                return Accessor.Reason;
            }

            return mReason;
        }

        public void SetReason(string r)
        {
            mReason = r;
        }

        public Boolean Post(GSMasterZipCodesBL item)
        {
            if (string.IsNullOrEmpty(item.Kecamatan) || string.IsNullOrWhiteSpace(item.Kecamatan))
            {
                SetReason("Kecamatan is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.Kelurahan) || string.IsNullOrWhiteSpace(item.Kelurahan))
            {
                SetReason("Kelurahan is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.Zip_code) || string.IsNullOrWhiteSpace(item.Zip_code))
            {
                SetReason("Kode pos is empty!");
                return false;
            }

            return Accessor.Post(item);
        }

        public Boolean Put(int id, GSMasterZipCodesBL item)
        {
            if (string.IsNullOrEmpty(item.Kecamatan) || string.IsNullOrWhiteSpace(item.Kecamatan))
            {
                SetReason("Kecamatan is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.Kelurahan) || string.IsNullOrWhiteSpace(item.Kelurahan))
            {
                SetReason("Kelurahan is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.Zip_code) || string.IsNullOrWhiteSpace(item.Zip_code))
            {
                SetReason("Kode pos is empty!");
                return false;
            }

            return Accessor.Put(id, item);
        }

        public Boolean Delete(int id)
        {
            return Accessor.Delete(id);
        }

        public DataTable Read(
            EnumFilter filter,
            GSMasterZipCodesBL ZipCodes = null,
            int offset = 0,
            int perpage = (int)EnumFetchData.DefaultLimit,
            string search = null)
        {
            return Accessor.Read(filter, ZipCodes, offset, perpage, search);
        }

        public DataTable CountRows(string kecamatan = null, string search = null)
        {
            GSMasterZipCodesBL zip = null;
            if (!string.IsNullOrEmpty(kecamatan))
            {
                zip = new GSMasterZipCodesBL()
                {
                    Kecamatan = kecamatan
                };
            }
            
            if (!string.IsNullOrEmpty(search))
            {
                search = "";
            }

            return Accessor.Read(EnumFilter.GET_COUNT_ROWS, zip, -1, -1, search);
        }

        public DataTable AdvanceShowList(int page, int perpage = (int)EnumFetchData.DefaultLimit, string kecamatan = null, string search = null)
        {
            GSMasterZipCodesBL zip = null;
            if (!string.IsNullOrEmpty(kecamatan))
            {
                zip = new GSMasterZipCodesBL()
                {
                    Kecamatan = kecamatan
                };
            }

            if (string.IsNullOrEmpty(search))
            {
                search = "";
            }

            int offset = (page - 1) * perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, zip, offset, perpage, search);
        }

        public List<string> GetListKecamatan(int cityID = 0)
        {
            return Accessor.GetListKecamatan(cityID);
        }

        public List<string> GetListKelurahan(int cityID = 0)
        {
            return Accessor.GetListKelurahan(cityID);
        }

        public GSMasterZipCodesBL GetByCityID(int city_id)
        {
            return Accessor.GetByCityID(city_id);
        }

        public GSMasterZipCodesBL GetByZipCode(string ZipCode)
        {
            var dt = Accessor.Read(EnumFilter.GET_SEARCH_NAME, new GSMasterZipCodesBL() {
                Zip_code = ZipCode
            });

            if(dt.Rows.Count == 0)
            {
                return null;
            }

            return Cast(dt.Rows, 0);
        }

        private GSMasterZipCodesBL Cast(DataRowCollection rows, int index = 0)
        {
            return new GSMasterZipCodesBL()
            {
                ID = Helper.CastToInt(rows[index]["id"]),
                Zip_code = Helper.CastToString(rows[index]["zip_code"]),
                Kelurahan = Helper.CastToString(rows[index]["kelurahan"]),
                Kecamatan = Helper.CastToString(rows[index]["kecamatan"]),
                City = Helper.CastToInt(rows[index]["city"]),
                Area_code = Helper.CastToString(rows[index]["area_code"]),
                Sts_update = Helper.CastToString(rows[index]["sts_update"]),
                Web_subdistrict_id = Helper.CastToInt(rows[index]["web_subdistrict_id"])
            };
        }
    }
}
