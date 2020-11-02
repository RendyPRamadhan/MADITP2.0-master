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
    class CBCashBankTypeAL
    {
        private static clsGlobal Helper;
        private static CBCashBankTypeDA DataAccess;
        private static CBCashBankTypeBL Model;
        private static DataTable Data;
        private static List<CBCashBankTypeBL> ResultList;
        private static DataSet DS;

        public CBCashBankTypeAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new CBCashBankTypeDA(Helper);
            Model = new CBCashBankTypeBL();
            Data = new DataTable();
            ResultList = new List<CBCashBankTypeBL>();
        }

        public DataTable GetAllPaging(CBCashBankTypeBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            //ResultList = Helper.ConvertDataTableToList<CBMasterCashCodeBL>(Data);
            //return ResultList;
            return Data;
        }
        public DataSet GetAllPaging_DS(CBCashBankTypeBL Model,string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }

        public int GetAllCount(CBCashBankTypeBL Model)
        {

            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(CBCashBankTypeBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public CBCashBankTypeBL GetByID_Model(string ID)
        {
            Model = new CBCashBankTypeBL();
            Model.bank_type_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<CBCashBankTypeBL>(Data);
            return Model;
        }
    }
}
