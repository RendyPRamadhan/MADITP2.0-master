using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.DataAccess.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.ApplicationLogic.AR
{
    public class ARReprintSlipKuitansiProcessAL
    {
        private static clsGlobal Helper;
        private static ARReprintSlipKuitansiProcessDA DataAccess;
        private static ARReprintSlipKuitansiProcessBL Model;
        private static DataTable Data;
        private static List<ARReprintSlipKuitansiProcessBL> ResultList;

        public ARReprintSlipKuitansiProcessAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new ARReprintSlipKuitansiProcessDA(Helper);
            Model = new ARReprintSlipKuitansiProcessBL();
            Data = new DataTable();
            ResultList = new List<ARReprintSlipKuitansiProcessBL>();
        }

        public List<ARReprintSlipKuitansiProcessBL> GetAll(ARReprintSlipKuitansiProcessBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model, 1, 50);
            ResultList = Helper.ConvertDataTableToList<ARReprintSlipKuitansiProcessBL>(Data);
            return ResultList;
        }

        public List<ARReprintSlipKuitansiProcessBL> GetAllPaging(ARReprintSlipKuitansiProcessBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<ARReprintSlipKuitansiProcessBL>(Data);
            return ResultList;
        }

        public int GetAllCount(ARReprintSlipKuitansiProcessBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }

        public List<ComboBoxViewModel> GetComboboxCollectionMaster()
        {
            var Result = new List<ComboBoxViewModel>();
            Data = DataAccess.ReadCollectionMaster();
            Result = (from DataRow dr in Data.Rows
                      select new ComboBoxViewModel()
                      {
                          DisplayMember = $"{dr["cm_collector_name"]}",
                          ValueMember = $"{dr["cm_collector_id"]}"
                      }).ToList();
            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            return Result;
        }

        public List<ComboBoxViewModel> GetDivision()
        {
            var Result = new List<ComboBoxViewModel>();
            Data = DataAccess.GetDivision();
            Result = (from DataRow dr in Data.Rows
                      select new ComboBoxViewModel()
                      {
                          DisplayMember = $"{dr["dc_division"].ToString().Trim()}",
                          ValueMember = $"{dr["dc_division_id"].ToString().Trim()}"
                      }).Where(item => item.ValueMember != "0").ToList();
            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            return Result;
        }

        public ARReprintSlipKuitansiProcessBL GetDataCustomerByID(string scm_customer_id)
        {
            Data = DataAccess.ReadDataCustomer(scm_customer_id);
            Model = Helper.ConvertDataTableToModel<ARReprintSlipKuitansiProcessBL>(Data);
            return Model;
        }
    }
}