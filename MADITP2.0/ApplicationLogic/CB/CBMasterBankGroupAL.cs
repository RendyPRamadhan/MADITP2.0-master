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
    class CBMasterBankGroupAL
    {
        private static clsGlobal Helper;
        private static CBMasterBankGroupDA DataAccess;
        private static CBMasterBankGroupBL Model;
        private static DataTable Data;
        private static List<CBMasterBankGroupBL> ResultList;
        private static DataSet DS;
        public CBMasterBankGroupAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new CBMasterBankGroupDA(Helper);
            Model = new CBMasterBankGroupBL();
            Data = new DataTable();
            ResultList = new List<CBMasterBankGroupBL>();
        }

        public DataTable GetAllPaging(CBMasterBankGroupBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<CBMasterBankGroupBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(CBMasterBankGroupBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(CBMasterBankGroupBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public CBMasterBankGroupBL GetByID_Model(string ID)
        {
            Model = new CBMasterBankGroupBL();
            Model.group_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<CBMasterBankGroupBL>(Data);
            return Model;
        }

        public DataSet GetAllPaging_DS(CBMasterBankGroupBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
