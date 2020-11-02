using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOMasterCustomerAL
    {
        private string reason;
        private clsGlobal Helper;
        private SOMasterCustomerDA Accessor;

        public SOMasterCustomerAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new SOMasterCustomerDA(Helper);
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(SOMasterCustomerBL Customer)
        {
            bool info = Accessor.Post(Customer);
            if(!info)
            {
                Reason = Accessor.Reason;
            }

            return info;
        }

        public bool Put(string CustomerId, SOMasterCustomerBL Customer)
        {
            bool info = Accessor.Put(CustomerId, Customer);
            if(!info)
            {
                Reason = Accessor.Reason;
            }

            return info;
        }

        public bool Delete(string CustomerId)
        {
            bool info = Accessor.Delete(CustomerId);
            if(!info)
            {
                Reason = Accessor.Reason;
            }

            return info;
        }

        public List<SOMasterCustomerBL> GetAll(string Search = "", string Entity = "", string Branch = "", 
            string Division = "", string Gender = "")
        {
            List<SOMasterCustomerBL> Result = Accessor.Read(Enums.EnumFilter.GET_ALL, -1, -1, Search, Entity, Branch, Division, Gender);

            Reason = Accessor.Reason;
            return Result;
        }

        public List<SOMasterCustomerBL> AdvanceShowList(int Page = 1, int Perpage = 25,
            string Search = "", string Entity = "", string Branch = "",
            string Division = "", string Gender = "")
        {
            int Offset = (Page - 1) * Perpage;
            List<SOMasterCustomerBL> Result = Accessor.Read(Enums.EnumFilter.GET_WITH_PAGING, Offset, Perpage, Search, 
                Entity, Branch, Division, Gender);

            Reason = Accessor.Reason;
            return Result;
        }

        public SOMasterCustomerBL Find(string CustomerId)
        {
            return Accessor.Find(CustomerId);
        }

        public int CountRows(string Search = "", string Entity = "", string Branch = "",
            string Division = "", string Gender = "")
        {
            int jumlah = Accessor.CountRows(Search, Entity, Branch, Division, Gender);
            Reason = Accessor.Reason = Reason;
            return jumlah;
        }
    }
}
