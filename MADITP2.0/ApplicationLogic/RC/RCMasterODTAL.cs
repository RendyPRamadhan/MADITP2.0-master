using MADITP2._0.businessLogic.RC;
using MADITP2._0.DataAccess.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System.Collections.Generic;
using System.Data;

namespace MADITP2._0.ApplicationLogic.RC
{
    class RCMasterODTAL
    {
        private clsGlobal Helper;
        private RCMasterODTDA Accessor;
        private string reason;

        public RCMasterODTAL(clsGlobal helper) 
        {
            Helper = helper;
            Accessor = new RCMasterODTDA(helper);
        }

        public bool Post(RCMasterODTBL Item) 
        {
            return Accessor.Post(Item);
        }

        public bool Put(int Id, RCMasterODTBL Item)
        {
            return Accessor.Put(Id, Item);
        }

        public bool Delete(int Id)
        {
            return Accessor.Delete(Id);
        }

        public List<RCMasterODTBL> AdvanceShowList(int page = 1, int perpage = (int)EnumFetchData.DefaultLimit, string Search = null, string ActiveFlag = "ALL")
        {
            int Offset = (page - 1) * perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, Offset, perpage, Search, ActiveFlag);
        }
        
        public List<RCMasterODTBL> GetAll(string Search = null, string ActiveFlag = "ALL")
        {
            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, Search, ActiveFlag);
        }

        public RCMasterODTBL Find(int Id)
        {
            return Accessor.Find(Id);
        }

        public int CountRows(string Search = "", string ActiveFlag = "ALL")
        {
            return Accessor.CountRows(Search, ActiveFlag);
        }

        public DataTable GetRecruiter(string RecruiterId) 
        {
            return Accessor.GetRecruiter(RecruiterId);
        }

        public string Reason { get => reason; set => reason = value; }
    }
}
