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
    class SOUnitHongkongAL
    {
        private static clsGlobal Helper;
        private static SOUnitHongkongDA DataAccess;
        private static SOUnitHongkongBL Model;
        private static DataTable Data;
        private static List<SOUnitHongkongBL> ResultList;
        private static DataSet DS;
        public SOUnitHongkongAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOUnitHongkongDA(Helper);
            Model = new SOUnitHongkongBL();
            Data = new DataTable();
            ResultList = new List<SOUnitHongkongBL>();

        }

        public DataTable GetAllPaging(SOUnitHongkongBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<SOUnitHongkongBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(SOUnitHongkongBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(SOUnitHongkongBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public SOUnitHongkongBL GetByID_Model(string DivisionID, string ProductID)
        {
            Model = new SOUnitHongkongBL();
            Model.division_id = DivisionID;
            Model.product_id = ProductID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<SOUnitHongkongBL>(Data);
            return Model;
        }

        public DataTable GetList_Division(string Event)
        {
            return DataAccess.GetList_Division(Event);
        }

        public DataSet GetAllPaging_DS(SOUnitHongkongBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
