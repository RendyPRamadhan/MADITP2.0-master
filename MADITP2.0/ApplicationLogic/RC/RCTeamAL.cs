using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.DataAccess.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.RC
{
    class RCTeamAL
    {
        private clsGlobal Helper;
        private RCTeamDA Accessor;
        private string reason;

        public RCTeamAL(clsGlobal mHelper)
        {
            Helper = mHelper;
            Accessor = new RCTeamDA(Helper);
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(RCTeamBL Item)
        {
            if (Item is null)
            {
                Reason = "Item is null";
                return false;
            }

            if(string.IsNullOrEmpty(Item.Description))
            {
                Reason = "Description is empty";
                return false;
            }

            bool Info = Accessor.Post(Item);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public bool Put(string Id, RCTeamBL Item)
        {
            if (Item is null)
            {
                Reason = "Item is null";
                return false;
            }

            if (string.IsNullOrEmpty(Id))
            {
                Reason = "Id is empty";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Description))
            {
                Reason = "Description is empty";
                return false;
            }

            bool Info = Accessor.Put(Id, Item);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public bool Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                Reason = "Id is empty";
                return false;
            }

            bool Info = Accessor.Delete(Id);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public List<RCTeamBL> AdvanceShowList(int Page = 1, int Perpage = (int)EnumFetchData.DefaultLimit, string Search = null) 
        {
            if(Search is null)
            {
                Search = "";
            }

            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, Offset, Perpage, Search);
        }

        public List<RCTeamBL> GetAll(string Search = null)
        {
            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, Search);
        }

        public RCTeamBL Find(string Id)
        {
            return Accessor.Find(Id);
        }

        public int CountRows(string Search = null)
        {
            if (Search == null)
            {
                Search = "";
            }

            return Accessor.CountRows(Search);
        }
    }
}
