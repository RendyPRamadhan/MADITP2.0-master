using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using System.Collections.Generic;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOReportCOGSAL
    {
        private static clsGlobal Helper;
        private static SOReportCOGSDA DataAccess;
        private static SOReportCOGSBL Model;
        private static DataTable Data;
        private static List<SOReportCOGSBL> ResultList;
        private static DataSet DS;

        public SOReportCOGSAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new SOReportCOGSDA(Helper);
            Model = new SOReportCOGSBL();
            Data = new DataTable();
            ResultList = new List<SOReportCOGSBL>();
        }

        public DataTable GetAllPaging(SOReportCOGSBL Model, int CurrentPage)
        {
            Data = DataAccess.Read(EnumFilter.GET_WITH_PAGING, Model, CurrentPage);
            ResultList = Helper.ConvertDataTableToList<SOReportCOGSBL>(Data);
            //return ResultList;
            return Data;
        }

        public int GetAllCount(SOReportCOGSBL Model)
        {
            Data = DataAccess.Read(EnumFilter.GET_COUNT_ROWS, Model);
            //Int32 test = (int)Data.Rows[0][0];
            return (int)Data.Rows[0][0];
        }

        public SOReportCOGSBL GetByID_Model(string ID)
        {
            Model = new SOReportCOGSBL();
            Model.product = ID;
            Data = DataAccess.Read(EnumFilter.GET_SEARCH_ID, Model);
            Model = Helper.ConvertDataTableToModel<SOReportCOGSBL>(Data);
            return Model;
        }
        public DataSet GetAllPaging_DS(SOReportCOGSBL Model, string TCode, int CurrentPage)
        {
            DS = DataAccess.Read_DS(EnumFilter.GET_WITH_PAGING, Model, TCode, CurrentPage);
            return DS;
        }

        public DataTable GetList_Product(string Event)
        {
            return DataAccess.GetList_Product(Event);
        }
        public DataTable GetList_Principal(string Event)
        {
            return DataAccess.GetList_Principal(Event);
        }
    }
}
