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
    class CBMasterCurrencyCodeAL
    {
        private static clsGlobal Helper;
        private static CBMasterCurrencyCodeDA DataAccess;
        private static CBMasterCurrencyCodeBL Model;
        private static DataTable Data;
        private static List<CBMasterCurrencyCodeBL> ResultList;
        private static DataSet DS;
        public CBMasterCurrencyCodeAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new CBMasterCurrencyCodeDA(Helper);
            Model = new CBMasterCurrencyCodeBL();
            Data = new DataTable();
            ResultList = new List<CBMasterCurrencyCodeBL>();
        }

        public DataTable GetAllPaging(CBMasterCurrencyCodeBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<CBMasterCurrencyCodeBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(CBMasterCurrencyCodeBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(CBMasterCurrencyCodeBL Model, string SQLQuery, ref string IDHome)//Create, Modify, Delete
        {
           // var IsSuccess = 0;
            //var Data = DataAccess.CMD(Model, SQLQuery);

            Model = DataAccess.CMD_DS(Model, SQLQuery);

            IDHome = Model.currency_code;

             if (Model.issuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (Model.issuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (Model.issuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");

        }

        public CBMasterCurrencyCodeBL GetByID_Model(string ID)
        {
            Model = new CBMasterCurrencyCodeBL();
            Model.currency_code = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<CBMasterCurrencyCodeBL>(Data);
            return Model;
        }

        public DataSet GetAllPaging_DS(CBMasterCurrencyCodeBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
