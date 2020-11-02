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
    
    class CBGeneralParameterAL
    {
        private static clsGlobal Helper;
        private static CBGeneralParameterDA DataAccess;
        private static CBGeneralParameterBL Model;
        private static DataTable Data;
        private static List<CBGeneralParameterBL> ResultList;
        private static DataSet DS;

        public CBGeneralParameterAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new CBGeneralParameterDA(Helper);
            Model = new CBGeneralParameterBL();
            Data = new DataTable();
            ResultList = new List<CBGeneralParameterBL>();
        }

        public DataTable GetAllPaging(CBGeneralParameterBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            //ResultList = Helper.ConvertDataTableToList<CBMasterCashCodeBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(CBGeneralParameterBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(CBGeneralParameterBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public CBGeneralParameterBL GetByID_Model(string ID, string BatchSource)
        {
            Model = new CBGeneralParameterBL();
            Model.entity_id = ID;
            Model.batch_source = BatchSource;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<CBGeneralParameterBL>(Data);
            return Model;
        }
        public DataTable GetList_Entity(string Event)
        {
            return DataAccess.GetList_Entity(Event);
        }
        public DataTable GetList_BatchSource(string Event)
        {
            return DataAccess.GetList_BatchSource(Event);
        }

        public DataSet GetAllPaging_DS(CBGeneralParameterBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
