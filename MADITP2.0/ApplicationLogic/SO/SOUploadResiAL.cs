using System.Collections.Generic;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.BusinessLogic.SO;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOUploadResiAL
    {
        private static clsGlobal Helper;
        private static SOUploadResiDA DataAccess;
        private static SOUploadResiBL Model;
        private static DataTable Data;
        private static List<SOUploadResiBL> ResultList;
        private static DataSet DS;

        public SOUploadResiAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOUploadResiDA(Helper);
            Model = new SOUploadResiBL();
            Data = new DataTable();
            ResultList = new List<SOUploadResiBL>();
        }
        public DataTable GetAllPaging(SOUploadResiBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            return Data;
        }

        public int GetAllCount(SOUploadResiBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0][0];
        }
        public void CMD(SOUploadResiBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }
      

    }
}
