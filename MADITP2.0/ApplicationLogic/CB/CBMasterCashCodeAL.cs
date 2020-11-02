using System.Collections.Generic;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MADITP2._0.DataAccess.CB;
using MADITP2._0.BusinessLogic.CB;

namespace MADITP2._0.ApplicationLogic.CB
{
    class CBMasterCashCodeAL
    {
        private static clsGlobal Helper;
        private static CBMasterCashCodeDA DataAccess;
        private static CBMasterCashCodeBL Model;
        private static DataTable Data;
        private static List<CBMasterCashCodeBL> ResultList;
        private static DataSet DS;

        public CBMasterCashCodeAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new CBMasterCashCodeDA(Helper);
            Model = new CBMasterCashCodeBL();
            Data = new DataTable();
            ResultList = new List<CBMasterCashCodeBL>();
        }

        public DataTable GetAllPaging(CBMasterCashCodeBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            //ResultList = Helper.ConvertDataTableToList<CBMasterCashCodeBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(CBMasterCashCodeBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(CBMasterCashCodeBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public CBMasterCashCodeBL GetByID_Model(string ID)
        {
            Model = new CBMasterCashCodeBL();
            Model.cash_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<CBMasterCashCodeBL>(Data);
            return Model;
        }

        public DataSet GetAllPaging_DS(CBMasterCashCodeBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }

    }
}
