using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.DataAccess.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.AR
{
    public class ARPrintSlipKuitansiProcessAL
    {
        private static clsGlobal Helper;
        private static ARPrintSlipKuitansiProcessDA DataAccess;
        private static ARPrintSlipKuitansiProcessBL Model;
        private static DataTable Data;
        private static List<ARPrintSlipKuitansiProcessBL> ResultList;

        public ARPrintSlipKuitansiProcessAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new ARPrintSlipKuitansiProcessDA(Helper);
            Model = new ARPrintSlipKuitansiProcessBL();
            Data = new DataTable();
            ResultList = new List<ARPrintSlipKuitansiProcessBL>();
        }

        public List<ARPrintSlipKuitansiProcessBL> GetAll(ARPrintSlipKuitansiProcessBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model, 1, 50);
            ResultList = Helper.ConvertDataTableToList<ARPrintSlipKuitansiProcessBL>(Data);
            return ResultList;
        }

        public List<ARPrintSlipKuitansiProcessBL> GetAllPaging(ARPrintSlipKuitansiProcessBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<ARPrintSlipKuitansiProcessBL>(Data);
            return ResultList;
        }

        public int GetAllCount(ARPrintSlipKuitansiProcessBL Model)
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

        public ARPrintSlipKuitansiProcessBL GetDataCustomerByID(string scm_customer_id)
        {
            Data = DataAccess.ReadDataCustomer(scm_customer_id);
            Model = Helper.ConvertDataTableToModel<ARPrintSlipKuitansiProcessBL>(Data);
            return Model;
        }


    

    }
}
