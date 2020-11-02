using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.DataAccess.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.ApplicationLogic.AR
{
    public class ARListKuitansiSlipUnprocessAllAL
    {
        private static clsGlobal Helper;
        private static ARListKuitansiSlipUnprocessAllDA DataAccess;
        private static ARListKuitansiSlipUnprocessAllBL Model;
        private static DataTable Data;
        private static List<ARListKuitansiSlipUnprocessAllBL> ResultList;
        private static readonly string CurrentUserID = clsLogin.USERID;


        public ARListKuitansiSlipUnprocessAllAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new ARListKuitansiSlipUnprocessAllDA(Helper);
            Model = new ARListKuitansiSlipUnprocessAllBL();
            Data = new DataTable();
            ResultList = new List<ARListKuitansiSlipUnprocessAllBL>();
        }
        public List<ARListKuitansiSlipUnprocessAllBL> GetAll(ARListKuitansiSlipUnprocessAllBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model, 1, 50);
            ResultList = Helper.ConvertDataTableToList<ARListKuitansiSlipUnprocessAllBL>(Data);
            return ResultList;
        }
        public List<ARListKuitansiSlipUnprocessAllBL> GetAllPaging(ARListKuitansiSlipUnprocessAllBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<ARListKuitansiSlipUnprocessAllBL>(Data);
            return ResultList;
        }
        public int GetAllCount(ARListKuitansiSlipUnprocessAllBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }

        public int CheckGenerateKW(ARListKuitansiSlipUnprocessAllBL Model, string Period)
        {
            return DataAccess.CheckGenerateKW(Model, Period);
        }
        public string Insert(List<ARListKuitansiSlipUnprocessAllBL> ListData)
        {
            var Result = string.Empty;

            var Table = new DataTable();
            Table.Columns.Add("index", typeof(int));
            Table.Columns.Add("entity_id", typeof(string));
            Table.Columns.Add("branch_id", typeof(string));
            Table.Columns.Add("division_id", typeof(string));
            Table.Columns.Add("txn_date", typeof(DateTime));
            Table.Columns.Add("type_period", typeof(int));
            Table.Columns.Add("tp_name", typeof(string));
            Table.Columns.Add("tp_month", typeof(int));
            Table.Columns.Add("tp_item_number", typeof(string));
            Table.Columns.Add("kp_number", typeof(string));
            Table.Columns.Add("due_date", typeof(DateTime));

            int Index = 1;
            foreach (var item in ListData)
            {
                var LastPeriod = string.IsNullOrEmpty(item.kw_period) || item.kw_period == "0" ? DateTime.Now.ToString("yyyyMM") : item.kw_period;
                var MonthLastPeriod = LastPeriod.Substring(4, 2);
                var YearLastPeriod = LastPeriod.Substring(0, 4);

                var TxnDate = $"01/{MonthLastPeriod}/{YearLastPeriod}";

                int MonthPeriodToBeProcessInt = Convert.ToInt32(MonthLastPeriod) + 1;
                string MonthPeriodToBeProcessStr = $"{MonthPeriodToBeProcessInt}";

                int YearPeriodToBeProcessInt = Convert.ToInt32(YearLastPeriod);
                string YearPeriodToBeProcessStr = YearLastPeriod;

                if (MonthPeriodToBeProcessInt < 10)
                {
                    MonthPeriodToBeProcessStr = $"0{MonthPeriodToBeProcessInt}";
                }
                else if (MonthPeriodToBeProcessInt > 12)
                {
                    MonthPeriodToBeProcessStr = $"01";
                    YearPeriodToBeProcessStr = $"{YearPeriodToBeProcessInt + 1}";
                }
              
                var PeriodToBeProcess = $"{YearPeriodToBeProcessStr}{MonthPeriodToBeProcessStr}";

                Table.Rows.Add(
                    Index,
                    item.entity_id,
                    item.branch_id,
                    item.division_id,
                    TxnDate,
                    0,
                    CurrentUserID,
                    PeriodToBeProcess,
                    item.invoice,
                    item.kp,
                    null
                    );
            }
            var Execute = DataAccess.Post(Table);

            int IndexResult = Execute.Count - 1;
            if (Convert.ToInt32(Execute[IndexResult].Rows[0].ItemArray.ElementAt(0)) == 0)
            {
                throw new Exception($"{Execute[IndexResult].Rows[0].ItemArray.ElementAt(1)}");
            }
            else
            {
                Result = $"{Execute[IndexResult].Rows[0].ItemArray.ElementAt(1)}";
            }
            return Result;

        }

        public List<ComboBoxViewModel> GetComboboxMonth()
        {
            List<ComboBoxViewModel> Result = new List<ComboBoxViewModel>();
            for (int i = 1; i <= 12; i++)
            {
                var Month = i < 10 ? $"0{i}" : $"{i}";
                Result.Add(new ComboBoxViewModel() { DisplayMember = new DateTime(DateTime.Now.Year, i, 1).ToString("MMM"), ValueMember = Month });
            }
            return Result;

        }

        public List<ComboBoxViewModel> GetComboboxYear()
        {
            var Today = DateTime.Now;
            List<ComboBoxViewModel> Result = new List<ComboBoxViewModel>()
            {
                new ComboBoxViewModel()
                {
                    DisplayMember = $"{Today.Year}",
                    ValueMember = $"{Today.Year}"
                }
            };
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
    }
}