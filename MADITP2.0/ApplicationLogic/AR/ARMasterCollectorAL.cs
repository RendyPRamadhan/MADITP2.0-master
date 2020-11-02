using MADITP2._0.BusinessLogic.AR;
using System.Collections.Generic;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MADITP2._0.DataAccess.AR;

namespace MADITP2._0.ApplicationLogic.AR
{
    class ARMasterCollectorAL
    {
        private static clsGlobal Helper;
        private static ARMasterCollectorDA DataAccess;
        private static ARMasterCollectorBL Model;
        private static DataTable Data;
        private static List<ARMasterCollectorBL> ResultList;
        private static DataSet DS;

        public ARMasterCollectorAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new ARMasterCollectorDA(Helper);
            Model = new ARMasterCollectorBL();
            Data = new DataTable();
            ResultList = new List<ARMasterCollectorBL>();
        }
        public DataTable GetAllPaging(ARMasterCollectorBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<ARMasterCollectorBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(ARMasterCollectorBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0][0];
        }
        

        public ARMasterCollectorBL GetByID_Model(string ID)
        {
            Model = new ARMasterCollectorBL();
            Model.collector_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<ARMasterCollectorBL>(Data);
            return Model;
        }
        public void CMD(ARMasterCollectorBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");


        }
        public DataTable GetList_Entity(string Event)
        {
            return DataAccess.GetList_Entity(Event);
        }

        public DataTable GetList_Branch(string Event)
        {
            return DataAccess.GetList_Branch(Event);
        }

        public DataTable GetList_Division(string Event)
        {
            return DataAccess.GetList_Division(Event);
        }

        public DataTable GetList_Area(string Event)
        {
            return DataAccess.GetList_Area(Event);
        }

        public DataTable GetList_GroupHead(string Event)
        {
            return DataAccess.GetList_GroupHead(Event);
        }

        public DataSet GetAllPaging_DS(ARMasterCollectorBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }

    }
}
