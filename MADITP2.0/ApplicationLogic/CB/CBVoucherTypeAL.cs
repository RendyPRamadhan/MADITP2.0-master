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
    class CBVoucherTypeAL
    {
        private static clsGlobal Helper;
        private static CBVoucherTypeDA DataAccess;
        private static CBVoucherTypeBL Model;
        private static DataTable Data;
        private static List<CBVoucherTypeBL> ResultList;
        private static DataSet DS;

        public CBVoucherTypeAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new CBVoucherTypeDA(Helper);
            Model = new CBVoucherTypeBL();
            Data = new DataTable();
            ResultList = new List<CBVoucherTypeBL>();
        }

        public DataTable GetAllPaging(CBVoucherTypeBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            return Data;
        }

        public int GetAllCount(CBVoucherTypeBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }


        public void CMD(CBVoucherTypeBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }

        public CBVoucherTypeBL GetByID_Model(string ID)
        {
            Model = new CBVoucherTypeBL();
            Model.voucher_type_id = ID;
           // Model.gp_batch_source = BatchSource;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<CBVoucherTypeBL>(Data);
            return Model;
        }
        public DataTable GetList_Transaction(string Event)
        {
            return DataAccess.GetList_Transaction(Event);
        }

        public DataSet GetAllPaging_DS(CBVoucherTypeBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }
    }
}
