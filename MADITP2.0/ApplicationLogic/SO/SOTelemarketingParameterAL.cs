using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MADITP2._0.ApplicationLogic.SO
{
    public class SOTelemarketingParameterAL
    {
        private static clsGlobal Helper;
        private static SOTelemarketingParameterDA DataAccess;
        private static SOTelemarketingParameterBL Model;
        private static DataTable Data;
        private static List<SOTelemarketingParameterBL> ResultList;

        public SOTelemarketingParameterAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOTelemarketingParameterDA(Helper);
            Model = new SOTelemarketingParameterBL();
            Data = new DataTable();
            ResultList = new List<SOTelemarketingParameterBL>();
        }
        public List<SOTelemarketingParameterBL> GetAll(SOTelemarketingParameterBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model);
            ResultList = Helper.ConvertDataTableToList<SOTelemarketingParameterBL>(Data);
            return ResultList;
        }

        public SOTelemarketingParameterBL GetByID(string ID)
        {
            Model = new SOTelemarketingParameterBL()
            {
                id = ID
            };
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<SOTelemarketingParameterBL>(Data);
            return Model;
        }

        public List<SOTelemarketingParameterBL> GetAllPaging(SOTelemarketingParameterBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<SOTelemarketingParameterBL>(Data);
            return ResultList;
        }
        public int GetAllCount(SOTelemarketingParameterBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }

        public void Insert(SOTelemarketingParameterBL Model)
        {
            var IsSuccess = DataAccess.Post(Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }
        public void Update(SOTelemarketingParameterBL Model)
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

        public List<ComboBoxViewModel> GetComboboxQuestionPhase()
        {
            List<ComboBoxViewModel> Result = null;
            try
            {
                Result = new List<ComboBoxViewModel>() {
                 new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" },
                 new ComboBoxViewModel() { DisplayMember = "INFORMING", ValueMember = "INFCSTS" },
                 new ComboBoxViewModel() { DisplayMember = "FOLLOW UP 1", ValueMember = "FU1CSTS" }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public List<ComboBoxViewModel> GetComboboxQuestionCategory()
        {
            List<ComboBoxViewModel> Result = null;
            try
            {
                Result = new List<ComboBoxViewModel>() {
                 new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" },
                 new ComboBoxViewModel() { DisplayMember = "SUCCESS CALL", ValueMember = "SUCCESS CALL" },
                 new ComboBoxViewModel() { DisplayMember = "NOT SUCCESS", ValueMember = "NOT SUCCESS" }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
    }
}