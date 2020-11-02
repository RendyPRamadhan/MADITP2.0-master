using MADITP2._0.businessLogic.GS;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace MADITP2._0.ApplicationLogic.GS
{
    public class GSEntityAL
    {
        private static clsGlobal Helper;
        private static GSEntityDA DataAccess;
        private static GSEntityBL Model;
        private static DataTable Data;
        private static List<GSEntityBL> ResultList;
        public GSEntityAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new GSEntityDA(Helper);
            Model = new GSEntityBL();
            Data = new DataTable();
            ResultList = new List<GSEntityBL>();
        }

        public List<GSEntityBL> GetAll(GSEntityBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model, 1, 50);
            ResultList = Helper.ConvertDataTableToList<GSEntityBL>(Data);
            return ResultList;
        }

        public GSEntityBL GetByID(string ID)
        {
            Model = new GSEntityBL()
            {
                entity_id = ID
            };
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model, 1, 50);
            Model = Helper.ConvertDataTableToModel<GSEntityBL>(Data);
            return Model;
        }

        public List<GSEntityBL> GetAllPaging(GSEntityBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<GSEntityBL>(Data);
            return ResultList;
        }

        public int GetAllCount(GSEntityBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }

        public void Insert(GSEntityBL Model)
        {
            var IsSuccess = DataAccess.Post(Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }
        public void Update(GSEntityBL Model)
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

        public List<ComboBoxViewModel> GetComboboxEntity(bool IsIncludeAll)
        {
            List<ComboBoxViewModel> Result = new List<ComboBoxViewModel>();
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model, 1, 50);
            Result = (from DataRow dr in Data.Rows
                      select new ComboBoxViewModel()
                      {
                          DisplayMember = Helper.CastToString(dr["entity"]),
                          ValueMember = Helper.CastToString(dr["entity_id"])
                      }).ToList();
            Result.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });

            if (!IsIncludeAll)
            {
                Result = Result.Where(x => x.ValueMember != "0").ToList();
            }
            return Result;
        }
    }
}