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
    class CBMasterCashBankAL
    {
        private static clsGlobal Helper;
        private static CBMasterCashBankDA DataAccess;
        private static CBMasterCashBankBL Model;
        private static DataTable Data;
        private static List<CBMasterCashBankBL> ResultList;

        public CBMasterCashBankAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new CBMasterCashBankDA(Helper);
            Model = new CBMasterCashBankBL();
            Data = new DataTable();
            ResultList = new List<CBMasterCashBankBL>();
        }


        public DataTable GetAllPaging(CBMasterCashBankBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            //ResultList = Helper.ConvertDataTableToList<CBMasterCashCodeBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(CBMasterCashBankBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(CBMasterCashBankBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public CBMasterCashBankBL GetByID_Model_HEADER(string ID)
        {
            Model = new CBMasterCashBankBL();
            Model.bm_bank_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<CBMasterCashBankBL>(Data);
            return Model;
        }

        ////////////////////////////Detail////////////////////////////
        public DataTable GetAllPaging_Detail(CBMasterCashBankBL Model, int CurrentPage)
        {
            Data = DataAccess.Read_Detail(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            //ResultList = Helper.ConvertDataTableToList<CBMasterCashCodeBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount_Detail(CBMasterCashBankBL Model)
        {
            Data = DataAccess.Read_Detail(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }

        public void CMD_Detail(CBMasterCashBankBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD_Detail(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public CBMasterCashBankBL GetByID_Model_Detail(string ID)
        {
            Model = new CBMasterCashBankBL();
            Model.bm_bank_id = ID;
            Data = DataAccess.Read_Detail(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<CBMasterCashBankBL>(Data);
            return Model;
        }

        public DataTable GetList_BankGroup(string Event)
        {
            return DataAccess.GetList_BankGroup(Event);
        }

        public DataTable GetList_BankType(string Event)
        {
            return DataAccess.GetList_BankType(Event);
        }
    }
}
