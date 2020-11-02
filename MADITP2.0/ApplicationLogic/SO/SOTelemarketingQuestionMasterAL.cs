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
    public class SOTelemarketingQuestionMasterAL
    {
        private static clsGlobal Helper;
        private static SOTelemarketingQuestionMasterDA DataAccess;
        private static SOTelemarketingQuestionMasterBL Model;
        private static DataTable Data;
        private static List<SOTelemarketingQuestionMasterBL> ResultList;

        public SOTelemarketingQuestionMasterAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOTelemarketingQuestionMasterDA(Helper);
            Model = new SOTelemarketingQuestionMasterBL();
            Data = new DataTable();
            ResultList = new List<SOTelemarketingQuestionMasterBL>();
        }

        public List<SOTelemarketingQuestionMasterBL> GetAll(SOTelemarketingQuestionMasterBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model);
            ResultList = Helper.ConvertDataTableToList<SOTelemarketingQuestionMasterBL>(Data);
            return ResultList;
        }

        public SOTelemarketingQuestionMasterBL GetByID(string ID)
        {
            Model = new SOTelemarketingQuestionMasterBL();
            Model.id = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<SOTelemarketingQuestionMasterBL>(Data);
            return Model;
        }

        public List<SOTelemarketingQuestionMasterBL> GetAllPaging(SOTelemarketingQuestionMasterBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<SOTelemarketingQuestionMasterBL>(Data);
            return ResultList;
        }
        public int GetAllCount(SOTelemarketingQuestionMasterBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }

        public string GenerateNumberQuestionID(string QuestionID)
        {
            Data = DataAccess.GenerateNumberQuestionID(QuestionID);
            string Result = (string)Data.Rows[0].ItemArray.ElementAt(1);

            if ((int)Data.Rows[0].ItemArray.ElementAt(0) == 0)
                throw new Exception(Result);
            
            return Result;
        }
        public void Insert(SOTelemarketingQuestionMasterBL Model)
        {
            var IsSuccess = DataAccess.Post(Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }
        public void Update(SOTelemarketingQuestionMasterBL Model)
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

        public List<ComboBoxViewModel> GetComboboxQuestionSegment()
        {
            List<ComboBoxViewModel> Result = null;
            try
            {
                Result = new List<ComboBoxViewModel>() {
                 new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" },
                 new ComboBoxViewModel() { DisplayMember = "INFORMING", ValueMember = "INF" },
                 new ComboBoxViewModel() { DisplayMember = "FOLLOW UP 1", ValueMember = "FU1" }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
        public List<ComboBoxViewModel> GetComboboxQuestionType()
        {
            List<ComboBoxViewModel> Result = null;
            try
            {
                Result = new List<ComboBoxViewModel>() {
                 new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" },
                 new ComboBoxViewModel() { DisplayMember = "Free Text", ValueMember = "TXT" },
                 new ComboBoxViewModel() { DisplayMember = "Drop Down List", ValueMember = "DDL" }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
        public List<ComboBoxViewModel> GetComboboxQuestionFlag()
        {
            List<ComboBoxViewModel> Result = null;
            try
            {
                Result = new List<ComboBoxViewModel>() {
                 new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" },
                 new ComboBoxViewModel() { DisplayMember = "Active", ValueMember = "A" },
                 new ComboBoxViewModel() { DisplayMember = "Inactive", ValueMember = "I" }
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