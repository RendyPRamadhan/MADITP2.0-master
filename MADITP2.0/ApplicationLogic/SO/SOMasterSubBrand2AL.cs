using MADITP2._0.BusinessLogic.IM;
using System.Collections.Generic;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.BusinessLogic.SO;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOMasterSubBrand2AL
    {
        private static clsGlobal Helper;
        private static SOMasterSubBrand2DA DataAccess;
        private static SOMasterSubBrand2BL Model;
        private static DataTable Data;
        private static List<SOMasterSubBrand2BL> ResultList;
        private static DataSet DS;

        public SOMasterSubBrand2AL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOMasterSubBrand2DA(Helper);
            Model = new SOMasterSubBrand2BL();
            Data = new DataTable();
            ResultList = new List<SOMasterSubBrand2BL>();
        }

        public DataTable GetAllPaging(SOMasterSubBrand2BL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<SOMasterSubBrand2BL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(SOMasterSubBrand2BL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }
        public SOMasterSubBrand2BL GetByID(string ID, string IDSUB1, string IDSUB2)
        {
            Model = new SOMasterSubBrand2BL();
            Model.brand_id = ID;
            Model.subbrand1_id = IDSUB1;
            Model.subbrand2_id = IDSUB2;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<SOMasterSubBrand2BL>(Data);
            return Model;
        }

        public void CMD(SOMasterSubBrand2BL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");


        }

        public DataTable GetList_Brand(string Event)
        {
            return DataAccess.GetList_Brand(Event);
        }

        public DataTable GetList_SubBrand1(string Event, string BrandID)
        {
            if (BrandID == "System.Data.DataRowView")
                BrandID = "0";
             
             return DataAccess.GetList_SubBrand1(Event, BrandID);

        }
        public DataSet GetAllPaging_DS(SOMasterSubBrand2BL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
