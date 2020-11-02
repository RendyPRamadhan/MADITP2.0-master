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
using MADITP2._0.DataAccess.SO;
using MADITP2._0.BusinessLogic.SO;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOMasterSubBrand1AL
    {
        private static clsGlobal Helper;
        private static SOMasterSubBrand1DA DataAccess;
        private static SOMasterSubBrand1BL Model;
        private static DataTable Data;
        private static List<SOMasterSubBrand1BL> ResultList;
        private static DataSet DS;
        public SOMasterSubBrand1AL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOMasterSubBrand1DA(Helper);
            Model = new SOMasterSubBrand1BL();
            Data = new DataTable();
            ResultList = new List<SOMasterSubBrand1BL>();
        }

        public DataTable GetAllPaging(SOMasterSubBrand1BL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<SOMasterSubBrand1BL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(SOMasterSubBrand1BL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }
        public SOMasterSubBrand1BL GetByID(string ID, string IDSUB)
        {
            Model = new SOMasterSubBrand1BL();
            Model.brand_id = ID;
            Model.subbrand1_id = IDSUB;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<SOMasterSubBrand1BL>(Data);
            return Model;
        }
        
        public void CMD(SOMasterSubBrand1BL Model, string SQLQuery)//Create, Modify, Delete
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

        public DataSet GetAllPaging_DS(SOMasterSubBrand1BL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
