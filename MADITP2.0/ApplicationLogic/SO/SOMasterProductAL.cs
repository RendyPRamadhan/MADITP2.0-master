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

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOMasterProductAL
    {
        private static clsGlobal Helper;
        private static SOMasterProductDA DataAccess;
        private static SOMasterProductBL Model;
        private static DataTable Data;
        //private static CLS Data;
        private static List<SOMasterProductBL> ResultList;

        public SOMasterProductAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOMasterProductDA(Helper);
            Model = new SOMasterProductBL();
            Data = new DataTable();
            ResultList = new List<SOMasterProductBL>();
        }
        public DataTable GetAllPaging(SOMasterProductBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<SOMasterProductBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(SOMasterProductBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }
        public DataTable GetByID(string ProductID)
        {
            Model.product_id = ProductID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            return Data;
        }
        public void CMD(SOMasterProductBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);

            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");


        }
        public DataTable GetList_ProductGroup(string Event)
        {
            return DataAccess.GetList_ProductGroup(Event);
        }

        public DataTable GetList_ProductSubGroup(string Event, string GroupID)
        {
            return DataAccess.GetList_ProductSubGroup(Event, GroupID);
        }

        public DataTable GetList_ProductType(string Event)
        {
            return DataAccess.GetList_ProductType(Event);
        }

        public DataTable GetList_ProductStatus(string Event)
        {
            return DataAccess.GetList_ProductStatus(Event);
        }

        //////////
        public DataTable GetList_JenisProduct(string Event)
        {
            return DataAccess.GetList_JenisProduct(Event);
        }

        public DataTable GetList_DivisiProduct(string Event)
        {
            return DataAccess.GetList_DivisiProduct(Event);
        }

        public DataTable GetList_CommissionType(string Event)
        {
            return DataAccess.GetList_CommissionType(Event);
        }
        public DataTable GetList_DivisionType2(string Event)
        {
            return DataAccess.GetList_DivisionType2(Event);
        }

        public DataTable GetList_DiscountProduct(string Event)
        {
            return DataAccess.GetList_DiscountProduct(Event);
        }

        public DataTable GetList_Tax(string Event)
        {
            return DataAccess.GetList_Tax(Event);
        }

        public DataTable GetList_Vendor(string Event)
        {
            return DataAccess.GetList_Vendor(Event);
        }

        public DataTable GetList_UOM(string Event)
        {
            return DataAccess.GetList_UOM(Event);
        }

        public DataTable GetList_ControlFlag(string Event)
        {
            return DataAccess.GetList_ControlFlag(Event);
        }
        public DataTable GetList_ConstrainFlag(string Event)
        {
            return DataAccess.GetList_ConstrainFlag(Event);
        }

        public DataTable GetList_UnitHongkong(string Event)
        {
            return DataAccess.GetList_UnitHongkong(Event);
        }
    }
}
