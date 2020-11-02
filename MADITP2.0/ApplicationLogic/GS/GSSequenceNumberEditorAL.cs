using MADITP2._0.businessLogic.GS;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.GS
{

    public class GSSequenceNumberEditorAL
    {
        private static clsGlobal Helper;
        private static GSSequenceNumberEditorDA DataAccess;
        private static GSSequenceNumberEditorBL Model;
        private static DataTable Data;
        private static List<GSSequenceNumberEditorBL> ResultList;

        public GSSequenceNumberEditorAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new GSSequenceNumberEditorDA(Helper);
            Model = new GSSequenceNumberEditorBL();
            Data = new DataTable();
            ResultList = new List<GSSequenceNumberEditorBL>();
        }

        public List<GSSequenceNumberEditorBL> GetAll()
        {
            Data = DataAccess.Read(EnumFilter.GET_ALL, Model);
            ResultList = Helper.ConvertDataTableToList<GSSequenceNumberEditorBL>(Data);
            return ResultList;
        }

        public GSSequenceNumberEditorBL GetByID(string ID)
        {
            Model = new GSSequenceNumberEditorBL()
            {
                id = ID
            };
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<GSSequenceNumberEditorBL>(Data);
            return Model;
        }

        public List<GSSequenceNumberEditorBL> GetAllPaging(GSSequenceNumberEditorBL Model, int Offset)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, Offset);
            ResultList = Helper.ConvertDataTableToList<GSSequenceNumberEditorBL>(Data);
            return ResultList;
        }
        public int GetAllCount(GSSequenceNumberEditorBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0].ItemArray.ElementAt(0);
        }

        public void Insert(GSSequenceNumberEditorBL Model)
        {
            var IsSuccess = DataAccess.Post(Model);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }
        public void Update(GSSequenceNumberEditorBL Model)
        {
            var IsSuccess = DataAccess.Put(Model,false);
            if (IsSuccess == 0)
                throw new Exception("Data is already exist!!");
        }

        public void Delete(string ID)
        {
            var IsSuccess = DataAccess.Delete(ID);
            if (IsSuccess == 0)
                throw new Exception("Data is deleted!!");
        }

        public void AddSequenceByID(string ID)
        {
            Model.id = ID;
            DataAccess.Put(Model,true);
        }
    }
}
