using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.ApplicationLogic.IM
{
    class IMTukarBarangAL
    {
        private static clsGlobal Helper;
        private static IMTukarBarangDA DataAccess;
        private static IMTukarBarangBL ResultModel;
        private static DataTable Data;
        private static List<IMTukarBarangBL> ResultList;
        private static readonly string TxnTypeIn = "RBT", TxnTypeOut = "TBR";
        private static readonly string CurrentUserID = clsLogin.USERID;

        public IMTukarBarangAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new IMTukarBarangDA(Helper);
            ResultModel = new IMTukarBarangBL();
            Data = new DataTable();
            ResultList = new List<IMTukarBarangBL>();
        }
        public List<IMTukarBarangBL> GetAll(IMTukarBarangBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model);
            ResultList = Helper.ConvertDataTableToList<IMTukarBarangBL>(Data);
            return ResultList;
        }

        public List<IMTukarBarangBL> GetAllPaging(IMTukarBarangBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<IMTukarBarangBL>(Data);
            return ResultList;
        }

        public int GetAllCount(IMTukarBarangBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }
        public string Insert(IMTukarBarangBL DataHeader, List<IMTukarBarangBL> ListData, List<IMMasterWarehouseBL> ListWarehouse, string SequenceIDIn, string SequenceIDOut)
        {
            var Table = new DataTable();
            Table.Columns.Add("index", typeof(int));
            Table.Columns.Add("warehouse_id", typeof(string));
            Table.Columns.Add("product_id", typeof(string));
            Table.Columns.Add("txn_date", typeof(DateTime));
            Table.Columns.Add("txn_type_code", typeof(string));
            Table.Columns.Add("sequence_id", typeof(string));
            Table.Columns.Add("txn_quantity", typeof(int));
            Table.Columns.Add("txn_cost_value", typeof(decimal));
            Table.Columns.Add("txn_reference", typeof(string));
            Table.Columns.Add("txn_description", typeof(string));
            Table.Columns.Add("[user_id]", typeof(string));
            Table.Columns.Add("allow_update_stock_balance", typeof(string));
            Table.Columns.Add("allow_update_stock_movement", typeof(string));
            Table.Columns.Add("digital", typeof(string));

            int Index = 1;
            foreach (var item in ListData.Where(x => !string.IsNullOrEmpty(x.product_id)).ToList())
            {
                if (item.txn_type_code == TxnTypeOut)
                {
                    item.warehouse_id = DataHeader.warehouse_id_out;
                }
                else
                {
                    item.warehouse_id = DataHeader.warehouse_id_in;
                }
                item.txn_reference = DataHeader.txn_reference;
                item.memo = DataHeader.memo;
                item.txn_date = DataHeader.txn_date;

                var DataTxn = GetTxnType(item.txn_type_code.Trim()).FirstOrDefault();
                var DataWarehouse = ListWarehouse.Where(x => x.warehouse_id.Trim() == item.warehouse_id.Trim()).FirstOrDefault();

                Table.Rows.Add(
                    Index, 
                    item.warehouse_id, 
                    item.product_id, 
                    item.txn_date, 
                    item.txn_type_code, 
                    item.txn_type_code == TxnTypeOut ? SequenceIDOut : SequenceIDIn, 
                    item.txn_quantity, 
                    item.unit_cost, 
                    item.txn_reference, 
                    item.memo, 
                    CurrentUserID, 
                    DataTxn.Update_qty_on_hand, 
                    DataTxn.Update_stock_movement, 
                    DataWarehouse.digital == null ? "N" : DataWarehouse.digital);
                Index += 1;
            }

            return DataAccess.Post(Table, SequenceIDIn, SequenceIDOut, DataHeader.warehouse_id_in,DataHeader.warehouse_id_out);
        }

        public DataTable ReadGSGenHarcoded()
        {
            Data = DataAccess.ReadGSGenHarcoded();
            return Data;
        }

        public List<IMTransactionTypeBL> GetTxnType(string TxnType)
        {
            Data = DataAccess.GetTxnType(TxnType);
            var Result = Helper.ConvertDataTableToList<IMTransactionTypeBL>(Data);
            return Result;
        }

        public bool IsUserWarehouse(string UserID)
        {
            bool Result = true;
            string Data = DataAccess.IsUserWarehouse(UserID);

            if (Data == "N")
                Result = false;

            return Result;
        }

        public bool IsUserTbrRbt(string UserID)
        {
            bool Result = true;
            string Data = DataAccess.IsUserWarehouse(UserID);

            if (Data == "N")
                Result = false;

            return Result;
        }

    }
}