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
    class IMMasterProductGroupAL
    {
        private static clsGlobal Helper;
        private static IMMasterProductGroupDA DataAccess;
        private static IMMasterProductGroupBL Model;
        private static DataTable Data;
        //private static CLS Data;
        private static List<IMMasterProductGroupBL> ResultList;

        public IMMasterProductGroupAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new IMMasterProductGroupDA(Helper);
            Model = new IMMasterProductGroupBL();
            Data = new DataTable();
            ResultList = new List<IMMasterProductGroupBL>();
        }
        public DataTable GetAllPaging(IMMasterProductGroupBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<IMMasterProductGroupBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(IMMasterProductGroupBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }
        public DataTable GetByID(string ID)
        {
            Model.group_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            return Data;
        }
        public void CMD(IMMasterProductGroupBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");


        }
    }
}
