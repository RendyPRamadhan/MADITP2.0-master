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

namespace MADITP2._0.ApplicationLogic.IM
{
    class IMMasterProductSubGroupAL
    {
        private static clsGlobal Helper;
        private static IMMasterProductSubGroupDA DataAccess;
        private static IMMasterProductSubGroupBL Model;
        private static DataTable Data;
        private static List<IMMasterProductSubGroupBL> ResultList;

        public IMMasterProductSubGroupAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new IMMasterProductSubGroupDA(Helper);
            Model = new IMMasterProductSubGroupBL();
            Data = new DataTable();
            ResultList = new List<IMMasterProductSubGroupBL>();
        }
        public DataTable GetAllPaging(IMMasterProductSubGroupBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<IMMasterProductSubGroupBL>(Data);
           
            return Data;
        }

        public int GetAllCount(IMMasterProductSubGroupBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0][0];
        }
        public DataTable GetByID(string GroupID, string SubGroupID)
        {
            Model.group_id = GroupID;
            Model.subgroup_id = SubGroupID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            return Data;
        }
        public void CMD(IMMasterProductSubGroupBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");


        }
        public DataTable GetList_ProductGroup(string Event)
        {
            return DataAccess.GetList_ProductGroup(Event);
        }

       
    }
}
