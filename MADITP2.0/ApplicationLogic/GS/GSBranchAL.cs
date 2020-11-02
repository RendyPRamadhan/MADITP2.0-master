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
    public class GSBranchAL
    {
        private static clsGlobal Helper;
        private static GSBranchDA DataAccess;
        private static GSBranchBL Model;
        private static DataTable Data;
        private static List<GSBranchBL> ResultList;

        public GSBranchAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new GSBranchDA(Helper);
            Model = new GSBranchBL();
            Data = new DataTable();
            ResultList = new List<GSBranchBL>();
        }

        public List<GSBranchBL> GetAll(GSBranchBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model);
            ResultList = Helper.ConvertDataTableToList<GSBranchBL>(Data);
            return ResultList;
        }

        public GSBranchBL GetByID(string ID)
        {
            Model = new GSBranchBL()
            {
                branch_id = ID
            };
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<GSBranchBL>(Data);
            return Model;
        }

        public List<GSBranchBL> GetAllPaging(GSBranchBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<GSBranchBL>(Data);
            return ResultList;
        }

        public int GetAllCount(GSBranchBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }
        public void Insert(GSBranchBL Model)
        {
            var IsSuccess = DataAccess.Post(Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }
        public void Update(GSBranchBL Model)
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

        public List<ComboBoxViewModel> GetComboboxBranch(bool IsIncludeAll)
        {
            var Result = new List<ComboBoxViewModel>();
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model, 1, 50);
            Result = (from DataRow dr in Data.Rows
                      select new ComboBoxViewModel()
                      {
                          DisplayMember = Helper.CastToString(dr["branch"]),
                          ValueMember = Helper.CastToString(dr["branch_id"])
                      }).ToList();
            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });

            if (!IsIncludeAll)
                Result = Result.Where(x => x.ValueMember != "0").ToList();

            return Result;
        }
    }
}
