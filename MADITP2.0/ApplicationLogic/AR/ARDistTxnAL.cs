using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.DataAccess.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.AR
{
    class ARDistTxnAL
    {
        private clsGlobal Helper;
        private string reason;
        private ARDistTxnDA Accessor;

        public clsGlobal Helper1 { get => Helper; set => Helper = value; }
        public string Reason { get => reason; set => reason = value; }

        public ARDistTxnAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new ARDistTxnDA(Helper);
        }

        public bool Post(ARDistTxnBL Item)
        {
            return true;
        }
        
        public bool Put(string InvoiceNo, ARDistTxnBL Item)
        {
            return true;
        }
        
        public bool Delete(string InvoiceNo)
        {
            return true;
        }

        public List<ARDistTxnBL> AdvanceShowList(int Page = 1, int Perpage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, Offset, Perpage, Search);
        }

        public int CountRows(string Search = null)
        {
            return Accessor.CountRows(Search);
        }
    }
}
