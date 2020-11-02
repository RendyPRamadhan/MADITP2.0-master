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
    class SOMasterCategoryProductAL
    {
        private static clsGlobal Helper;
        private static SOMasterCategoryProductDA DataAccess;
        private static SOMasterCategoryProductBL Model;
        private static DataTable Data;
        private static List<SOMasterCategoryProductBL> ResultList;
        private static DataSet DS;
        public SOMasterCategoryProductAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOMasterCategoryProductDA(Helper);
            Model = new SOMasterCategoryProductBL();
            Data = new DataTable();
            ResultList = new List<SOMasterCategoryProductBL>();
        }

        public DataTable GetAllPaging(SOMasterCategoryProductBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<SOMasterCategoryProductBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(SOMasterCategoryProductBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }
   

        public void CMD(SOMasterCategoryProductBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public SOMasterCategoryProductBL GetByID_Model(string ID)
        {
            Model = new SOMasterCategoryProductBL();
            Model.category_product_id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<SOMasterCategoryProductBL>(Data);
            return Model;
        }

        public DataSet GetAllPaging_DS(SOMasterCategoryProductBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
