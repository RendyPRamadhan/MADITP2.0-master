using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.DataAccess.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.RC
{
    class RCRelativeAL
    {
        private clsGlobal Helper;
        private string reason;
        private RCRelativeDA Accessor;

        public RCRelativeAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new RCRelativeDA(Helper);
        }

        public bool Post(RCRelativeBL Item)
        {
            bool info = Accessor.Post(Item);
            if(!info)
            {
                Reason = Accessor.Reason;
            }

            return info;
        }
        
        public bool Put(int Id, RCRelativeBL Item)
        {
            bool info = Accessor.Put(Id, Item);
            if(!info)
            {
                Reason = Accessor.Reason;
            }

            return info;
        }
        
        public bool Delete(int Id)
        {
            return Accessor.Delete(Id);
        }
        
        public RCRelativeBL Find(int Id)
        {
            return Accessor.Find(Id);
        }

        public RCRelativeBL FindByRepId(string RepId)
        {
            return Accessor.FindByRepId(RepId.Trim());
        }

        public int CountRows(string Search = "")
        {
            return Accessor.CountRows(Search);
        }

        public List<RCRelativeBL> AdvanceShowList(int Page = 1, int Perpage = (int)EnumFetchData.DefaultLimit, string Search = "")
        {
            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, Offset, Perpage, Search);
        }

        public string Reason { get => reason; set => reason = value; }
    }
}
