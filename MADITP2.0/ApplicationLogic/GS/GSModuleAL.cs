using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.ApplicationLogic.GS
{
    public class GSModuleAL
    {
        private static clsGlobal Helper;
        private static GSModuleDA DataAccess;
        private static GSModuleBL Model;
        private static DataTable Data;
        private static List<GSModuleBL> ResultList;

        public GSModuleAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new GSModuleDA(Helper);
            Model = new GSModuleBL();
            Data = new DataTable();
            ResultList = new List<GSModuleBL>();
        }

        public List<GSModuleBL> GetAll(GSModuleBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model);
            ResultList = Helper.ConvertDataTableToList<GSModuleBL>(Data);
            return ResultList;
        }

        public GSModuleBL GetByID(string ID)
        {
            Model = new GSModuleBL()
            {
                module_id = ID
            };
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<GSModuleBL>(Data);
            return Model;
        }

        public List<GSModuleBL> GetAllPaging(GSModuleBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<GSModuleBL>(Data);
            return ResultList;
        }
        public int GetAllCount(GSModuleBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }

        public void Insert(GSModuleBL Model)
        {
            var IsSuccess = DataAccess.Post(Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }
        public void Update(GSModuleBL Model)
        {
            var IsSuccess = DataAccess.Put(Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }

        public void Delete(string ID)
        {
            var IsSuccess = DataAccess.Delete(ID);
            if (IsSuccess == 0)
                throw new Exception("Data is deleted!!");
        }

        public List<ComboBoxViewModel> GetComboboxModule()
        {
            var Result = new List<ComboBoxViewModel>();
            try
            {
                Data = DataAccess.Read(EnumFilter.GET_ALL, Model, 1, 50);
                Result = (from DataRow dr in Data.Rows
                          select new ComboBoxViewModel()
                          {
                              DisplayMember = $"{dr["module_id"]} - {dr["description"]}",
                              ValueMember = $"{dr["module_id"]}"
                          }).ToList();

                Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
    }
}
