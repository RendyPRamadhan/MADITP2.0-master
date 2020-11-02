using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.DataAccess.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.RC
{
    class RCEducationAL
    {
        private clsGlobal Helper;
        private RCEducationDA Accessor;
        private string reason;

        public RCEducationAL(clsGlobal mHelper)
        {
            Helper = mHelper;
            Accessor = new RCEducationDA(Helper);
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(RCEducationBL Item)
        {
            if (Item is null)
            {
                Reason = "Item is null";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Education_name))
            {
                Reason = "Edu Name is empty";
                return false;
            }

            bool Info = Accessor.Post(Item);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public bool Put(int Id, RCEducationBL Item)
        {
            if (Item is null)
            {
                Reason = "Item is null";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Education_name))
            {
                Reason = "Edu name is empty";
                return false;
            }

            bool Info = Accessor.Put(Id, Item);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public bool Delete(int Id)
        {
            bool Info = Accessor.Delete(Id);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public List<RCEducationBL> AdvanceShowList(int Page = 1, int Perpage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            if (Search is null)
            {
                Search = "";
            }

            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, Offset, Perpage, Search);
        }

        public List<RCEducationBL> GetAll(string Search = null)
        {
            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, Search);
        }

        public RCEducationBL Find(int Id)
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
