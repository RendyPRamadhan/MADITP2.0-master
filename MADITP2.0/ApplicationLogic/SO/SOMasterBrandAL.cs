using MADITP2._0.BusinessLogic.SO;
using System.Collections.Generic;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.BusinessLogic.SO;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOMasterBrandAL
    {
        private static clsGlobal Helper;
        private static SOMasterBrandDA DataAccess;
        private static SOMasterBrandBL Model;
        private static DataTable Data;
        //private static CLS Data;
        private static List<SOMasterBrandBL> ResultList;
        private static DataSet DS;

        public SOMasterBrandAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOMasterBrandDA(Helper);
            Model = new SOMasterBrandBL();
            Data = new DataTable();
            ResultList = new List<SOMasterBrandBL>();
        }

        public DataTable GetAllPaging(SOMasterBrandBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<SOMasterBrandBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(SOMasterBrandBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }
        public DataTable GetByID(string ID)
        {
            Model.brand_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            return Data;
        }
        public SOMasterBrandBL GetByID_Model(string ID)
        {
            Model = new SOMasterBrandBL();
            Model.brand_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<SOMasterBrandBL>(Data);
            return Model;
        }
        public void CMD(SOMasterBrandBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");


        }

        public DataSet GetAllPaging_DS(SOMasterBrandBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
