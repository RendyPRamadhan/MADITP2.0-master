using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.DataAccess.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.ApplicationLogic.AR
{
    public class ARListKuitansiProcessAL
    {
        private static clsGlobal Helper;
        private static ARListKuitansiProcessDA DataAccess;
        private static ARListKuitansiProcessBL Model;
        private static DataTable Data;
        private static List<ARListKuitansiProcessBL> ResultList;
        public ARListKuitansiProcessAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new ARListKuitansiProcessDA(Helper);
            Model = new ARListKuitansiProcessBL();
            Data = new DataTable();
            ResultList = new List<ARListKuitansiProcessBL>();
        }

        public List<ARListKuitansiProcessBL> GetAllPaging(ARListKuitansiProcessBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<ARListKuitansiProcessBL>(Data);
            return ResultList;
        }
        public int GetAllCount(ARListKuitansiProcessBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }

        public List<ARTdkTerprosesKwBL> GetAllDataTdkTerprosesKW(ARTdkTerprosesKwBL Model)
        {
            List<ARTdkTerprosesKwBL> Result = new List<ARTdkTerprosesKwBL>();
            Data = DataAccess.ReadTdkTerprosesKW(EnumFilter.GET_ALL, Model);
            Result = Helper.ConvertDataTableToList<ARTdkTerprosesKwBL>(Data);
            return Result;
        }

        public List<ARTdkTerprosesKwBL> GenerateDataTidakTerprosesKW(ARTdkTerprosesKwBL Model, int FlagProcess, DateTime LastDate, DateTime CurrentDate)
        {
            List<ARTdkTerprosesKwBL> Result = new List<ARTdkTerprosesKwBL>();
            Data = DataAccess.GenerateDataTidakTerprosesKW(Model, FlagProcess, LastDate,CurrentDate);
            Result = Helper.ConvertDataTableToList<ARTdkTerprosesKwBL>(Data);
            return Result;
        }
        public List<ARKwProcessFlagBL> GetAllKWProcessFlag(ARKwProcessFlagBL Model)
        {
            List<ARKwProcessFlagBL> Result = new List<ARKwProcessFlagBL>();
            Data = DataAccess.GetAllKWProcessFlag(Model);
            Result = Helper.ConvertDataTableToList<ARKwProcessFlagBL>(Data);
            return Result;
        }

        public void InsertTdkTerprosesKW(ARTdkTerprosesKwBL Model)
        {
            DataAccess.PostTdkTerprosesKW(Model);
        }

        public void DeleteTdkTerprosesKW(int Sequence)
        {
            DataAccess.DeleteTdkTerprosesKWBySequence(Sequence);
        }

        public void GenerateKW(ARKwProcessFlagBL Model, DateTime LastDate, DateTime CurrentDate, DateTime LastPeriod, DateTime CurrentPeriod, string UserID, int FlagProcess)
        {
            DataAccess.GenerateKW(Model, LastDate, CurrentDate, LastPeriod,CurrentPeriod, UserID, FlagProcess);
        }

        public void GenerateKWLast(ARKwProcessFlagBL Model, DateTime LastDate, DateTime CurrentDate, DateTime LastPeriod, DateTime CurrentPeriod, string UserID, int FlagProcess, string MaxPeriod)
        {
            DataAccess.GenerateKWLast(Model, LastDate, CurrentDate, LastPeriod,CurrentPeriod,UserID, FlagProcess,MaxPeriod);
        }

        public void UpdateKWProcessFlag()
        {
            DataAccess.UpdateKWProcessFlag();
        }

        public int GetARKuitansiCount(ARListKuitansiProcessBL Model) 
        {
            Data = DataAccess.ReadARKuitansi(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
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
    }
}
