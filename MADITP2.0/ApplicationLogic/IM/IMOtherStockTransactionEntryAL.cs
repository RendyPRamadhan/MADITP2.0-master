using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace MADITP2._0.ApplicationLogic.IM
{
    class IMOtherStockTransactionEntryAL
    {
        private static clsGlobal Helper;
        private static IMOtherStockTransactionEntryDA DataAccess;
        private static IMOtherStockTransactionEntryBL Model;
        private static DataTable Data;
        private static List<IMOtherStockTransactionEntryBL> ResultList;
        private static readonly string CurrentUserID = clsLogin.USERID;

        public IMOtherStockTransactionEntryAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new IMOtherStockTransactionEntryDA(Helper);
            Model = new IMOtherStockTransactionEntryBL();
            Data = new DataTable();
            ResultList = new List<IMOtherStockTransactionEntryBL>();
        }
        public List<IMOtherStockTransactionEntryBL> GetAll(IMOtherStockTransactionEntryBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model);
            ResultList = Helper.ConvertDataTableToList<IMOtherStockTransactionEntryBL>(Data);
            return ResultList;
        }
        public string Insert(IMOtherStockTransactionEntryBL DataHeader, List<IMOtherStockTransactionEntryBL> ListData, IMMasterWarehouseBL DataWarehouse, IMTransactionTypeBL DataTxn, string SequenceID)
        {
            var Result = string.Empty;

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
                item.reference = DataHeader.reference;
                item.memo = DataHeader.memo;
                item.txn_date = DataHeader.txn_date;
                item.warehouse_id = DataHeader.warehouse_id;
                item.txn_type_id = DataHeader.txn_type_id;

                Table.Rows.Add(
                    Index,
                    item.warehouse_id,
                    item.product_id,
                    item.txn_date,
                    item.txn_type_id,
                    SequenceID,
                    item.qty,
                    item.unit_cost,
                    item.reference,
                    item.memo,
                    CurrentUserID,
                    DataTxn.Update_qty_on_hand,
                    DataTxn.Update_stock_movement,
                    DataWarehouse.digital == null ? "N" : DataWarehouse.digital);
                Index += 1;
            }

            var Execute = DataAccess.Post(Table, SequenceID);

            if (Convert.ToInt32(Execute[0].Rows[0].ItemArray.ElementAt(0)) == 0)
            {
                throw new Exception($"{Execute[0].Rows[0].ItemArray.ElementAt(1)}");
            }
            else
            {
                Result = $"{Execute[0].Rows[0].ItemArray.ElementAt(1)}";
            }

            return Result;

        }

        public List<IMOtherStockTransactionEntryBL> GetAllPaging(IMOtherStockTransactionEntryBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<IMOtherStockTransactionEntryBL>(Data);
            return ResultList;
        }

        public int GetAllCount(IMOtherStockTransactionEntryBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }


        public List<ComboBoxViewModel> GetComboboxWarehouse(string UserID)
        {
            var Result = new List<ComboBoxViewModel>();

            IMMasterWarehouseDA WarehouseDA = new IMMasterWarehouseDA(Helper);
            IMWarehouseSecurityDA WarehouseSecurityDA = new IMWarehouseSecurityDA(Helper);

            List<IMMasterWarehouseBL> DataWarehouse = WarehouseDA.Read(EnumFilter.GET_ALL, 0, 0);
            if (string.IsNullOrEmpty(UserID))
            {
                Result = (from IMMasterWarehouseBL data in DataWarehouse
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{data.warehouse_id} - {data.warehouse_description}",
                              ValueMember = data.warehouse_id
                          }).ToList();
            }
            else
            {
                List<IMWarehouseSecurityBL> DataWarehouseSecurity = WarehouseSecurityDA.Read(EnumFilter.GET_ALL, 0, 0);
                Result = (from warehouse in DataWarehouse
                          join warehouseSecurity in DataWarehouseSecurity on warehouse.warehouse_id equals warehouseSecurity.Warehouse_id
                          where warehouse.manual_transaction_entry_allowed == "Y" && warehouseSecurity.User_id.Trim() == UserID
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{warehouse.warehouse_id} - {warehouse.warehouse_description}",
                              ValueMember = warehouse.warehouse_id
                          }).ToList();
            }

            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });

            return Result;
        }
        public List<IMMasterWarehouseBL> GetDataWarehouse()
        {
            IMMasterWarehouseDA WarehouseDA = new IMMasterWarehouseDA(Helper);
            var DataWarehouse = WarehouseDA.Read(EnumFilter.GET_ALL, 0, 0);
            return DataWarehouse;
        }

        public bool IsUserWarehouse(string UserID)
        {
            bool Result = true;
            string Data = DataAccess.IsUserWarehouse(UserID);

            if (Data == "N")
                Result = false;

            return Result;
        }

        public List<ComboBoxViewModel> GetComboboxGroup()
        {
            IMMasterProductGroupDA GroupDa = new IMMasterProductGroupDA(Helper);

            var Result = new List<ComboBoxViewModel>();
            Data = GroupDa.Read(EnumFilter.GET_ALL, new IMMasterProductGroupBL(), 0, 0);
            Result = (from DataRow dr in Data.Rows
                      select new ComboBoxViewModel()
                      {
                          DisplayMember = $"{dr["gp_product_group_id"]} - {dr["gp_group_description"]}",
                          ValueMember = Helper.CastToString(dr["gp_product_group_id"])
                      }).ToList();
            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            return Result;
        }

        public List<ComboBoxViewModel> GetComboboxSubGroup(string GroupID)
        {
            IMMasterProductSubGroupDA SubGroupDa = new IMMasterProductSubGroupDA(Helper);

            var Result = new List<ComboBoxViewModel>();
            var DataSubGroup = SubGroupDa.Read(EnumFilter.GET_ALL, new IMMasterProductSubGroupBL(), 0, 0);
            Result = (from DataRow dr in DataSubGroup.Rows
                      where Helper.CastToString(dr["sp_product_group_id"]).Trim() == GroupID
                      select new ComboBoxViewModel()
                      {
                          DisplayMember = $"{dr["sp_product_subgroup_id"]} - {dr["sp_product_subgroup_description"]}",
                          ValueMember = Helper.CastToString(dr["sp_product_subgroup_id"])
                      }).ToList();

            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            return Result;
        }

        public List<ComboBoxViewModel> GetComboboxTxnType(string UserID)
        {
            var Result = new List<ComboBoxViewModel>();
            IMTransactionTypeAL TxnTypeDA = new IMTransactionTypeAL(Helper);
            List<IMTransactionTypeBL> Data = new List<IMTransactionTypeBL>();
            if (string.IsNullOrEmpty(UserID))
            {
                Data = TxnTypeDA.GetAll();
            }
            else
            {
                Data = GetTxnTypeByUserID(UserID);
            }

            Result = (from txnType in Data
                      select new ComboBoxViewModel()
                      {
                          DisplayMember = $"{txnType.Txn_type_code} - {txnType.Txn_type_description}",
                          ValueMember = $"{txnType.Txn_type_code}"
                      }).ToList();

            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            return Result;
        }
        public List<IMTransactionTypeBL> GetTxnTypeByUserID(string UserID)
        {
            Data = DataAccess.GetTxnTypeByUserID(UserID);
            var Result = Helper.ConvertDataTableToList<IMTransactionTypeBL>(Data);
            return Result;
        }

        public IMOtherStockTransactionEntryBL GetProductByID(string Digital, string ProductID)
        {
            Data = DataAccess.GetProductByID(Digital, ProductID);
            Model = Helper.ConvertDataTableToModel<IMOtherStockTransactionEntryBL>(Data);
            return Model;
        }
        public IMOtherStockTransactionEntryBL GetUnitCostByProductID(string ProductID)
        {
            Data = DataAccess.GetUnitCostByProductID(ProductID);
            Model = Helper.ConvertDataTableToModel<IMOtherStockTransactionEntryBL>(Data);
            return Model;
        }
        public IMOtherStockTransactionEntryBL GetStockBalanceByProductIDAndWarehouseID(string ProductID, string WarehouseID)
        {
            Data = DataAccess.GetStockBalanceByProductIDAndWarehouseID(ProductID, WarehouseID);
            Model = Helper.ConvertDataTableToModel<IMOtherStockTransactionEntryBL>(Data);
            return Model;
        }
    }
}