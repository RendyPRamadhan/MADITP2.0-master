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
using MADITP2._0.BusinessLogic.AR;

namespace MADITP2._0.ApplicationLogic.AR
{
    class ARCreditLimitAL
    {
        private static clsGlobal Helper;
        private static ARCreditLimitDA DataAccess;
        private static ARCreditLimitBL Model;
        private static DataTable Data;
        private static List<ARCreditLimitBL> ResultList;
        private static DataSet DS;

        public ARCreditLimitAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new ARCreditLimitDA(Helper);
            Model = new ARCreditLimitBL();
            Data = new DataTable();
            ResultList = new List<ARCreditLimitBL>();
        }

        public DataTable GetAllPaging(ARCreditLimitBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            //ResultList = Helper.ConvertDataTableToList<CBMasterCashCodeBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(ARCreditLimitBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(ARCreditLimitBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public ARCreditLimitBL GetByID_Model(string ID, string branch, string periode_year, string group_product)
        {
            Model = new ARCreditLimitBL();
            Model.rep_id = ID;
            Model.rep_branch = branch;
            Model.periode_year = periode_year;
            Model.division = group_product;

            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<ARCreditLimitBL>(Data);
            return Model;
        }
        public DataTable GetList_branch(string Event)
        {
            return DataAccess.GetList_branch(Event);
        }
        public DataTable GetList_division(string Event)
        {
            return DataAccess.GetList_division(Event);
        }

        public DataTable GetList_Rep(string Event, string BranchID, string DivID)
        {
            return DataAccess.GetList_Rep(Event, BranchID, DivID);
        }
        public DataSet GetAllPaging_DS(ARCreditLimitBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
