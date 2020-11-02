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
    class SOUploadResiPCPAL
    {
        private static clsGlobal Helper;
        private static SOUploadResiPCPDA DataAccess;
        private static SOUploadResiPCPBL Model;
        private static DataTable Data;
        private static List<SOUploadResiPCPBL> ResultList;
        private static DataSet DS;

        public SOUploadResiPCPAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOUploadResiPCPDA(Helper);
            Model = new SOUploadResiPCPBL();
            Data = new DataTable();
            ResultList = new List<SOUploadResiPCPBL>();
        }
        public DataTable GetAllPaging_Export(SOUploadResiPCPBL Model, int CurrentPage)
        {
            Data = DataAccess.Read_Export(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            return Data;
        }
        public DataTable GetAllPaging_Upload(SOUploadResiPCPBL Model, int CurrentPage)
        {
            Data = DataAccess.Read_Upload(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            return Data;
        }
        
        public int GetAllCount(SOUploadResiPCPBL Model)
        {
            Data = DataAccess.Read_Upload(EnumFilter.GET_COUNT_ROWS, Model);
            return (int)Data.Rows[0][0];
        }
       
        public void CMD(SOUploadResiPCPBL Model, string SQLQuery)//Create, Modify, Delete
        {
            var IsSuccess = DataAccess.CMD(Model, SQLQuery);
            if (IsSuccess == 0 && SQLQuery == EnumState.Create.ToString())
                throw new Exception("Data is already exist!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Update.ToString())
                throw new Exception("Update failed!!");
            else if (IsSuccess == 0 && SQLQuery == EnumState.Delete.ToString())
                throw new Exception("Delete failed!!");
        }
        public DataTable GetList_warehouse(string Event)
        {
            return DataAccess.GetList_warehouse(Event);
        }
    }
}
