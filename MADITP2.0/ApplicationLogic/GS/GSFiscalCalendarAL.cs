using MADITP2._0.businessLogic.GS;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.ApplicationLogic.GS
{
    public class GSFiscalCalendarAL
    {
        private static clsGlobal Helper;
        private static GSFiscalCalendarDA DataAccess;
        private static GSFiscalCalendarBL Model;
        private static DataTable Data;
        private static List<GSFiscalCalendarBL> ResultList;

        public GSFiscalCalendarAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new GSFiscalCalendarDA(Helper);
            Model = new GSFiscalCalendarBL();
            Data = new DataTable();
            ResultList = new List<GSFiscalCalendarBL>();
        }

        public List<GSFiscalCalendarBL> GetAll(GSFiscalCalendarBL _Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, _Model);
            ResultList = Helper.ConvertDataTableToList<GSFiscalCalendarBL>(Data);
            return ResultList;
        }

        public List<GSFiscalCalendarBL> GetAllPaging(GSFiscalCalendarBL _Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, _Model, Offset);
            ResultList = Helper.ConvertDataTableToList<GSFiscalCalendarBL>(Data);
            return ResultList;
        }

        public int GetAllCount(GSFiscalCalendarBL _Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, _Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }


        public void Insert(GSFiscalCalendarBL _Model)
        {
            var IsSuccess = DataAccess.Post(_Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }
        public void Update(GSFiscalCalendarBL _Model)
        {
            var IsSuccess = DataAccess.Put(_Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }

        public void Delete(GSFiscalCalendarBL _Model)
        {
            var IsSuccess = DataAccess.Delete(_Model);
            if (IsSuccess == 0)
                throw new Exception("Data is deleted!!");
        }

        public List<ComboBoxViewModel> GetComboboxFiscalYear(GSFiscalCalendarBL _Model, int? AddYear)
        {
            List<ComboBoxViewModel> Result = new List<ComboBoxViewModel>();
            List<string> Data = GetAll(_Model).Select(x => x.fiscal_year).Distinct().ToList();

            if (AddYear != null)
                Data.Add((Convert.ToInt32(Data.Max()) + AddYear).ToString());

            foreach (var item in Data)
            {
                Result.Add(new ComboBoxViewModel() 
                { 
                    DisplayMember = item,
                    ValueMember = item
                });
            }
           
            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            return Result;
        }

        public List<ComboBoxViewModel> GetComboboxMonth()
        {
            List<ComboBoxViewModel> Result = new List<ComboBoxViewModel>();
            List<string> Month = new List<string>() 
            { 
                "JAN","FEB","MAR","APR","MAY","JUN","JUL","AUG","SEP","OKT","NOV","DEC"
            };
            int i = 1;

            foreach (var item in Month)
            {
                Result.Add(new ComboBoxViewModel()
                {
                    DisplayMember = item,
                    ValueMember = i.ToString().Length == 1 ? $"0{i}" : i.ToString()
                });
                i++;
            }

            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            return Result;
        }
    }
}