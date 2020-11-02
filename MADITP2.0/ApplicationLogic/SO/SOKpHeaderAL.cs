using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOKpHeaderAL
    {
        private clsGlobal Helper;
        private string reason;
        private RCRepMasterAL RepMasterAccessor;
        private GSEntityAL Entity;
        private GSBranchAL Branch;
        private SOKpHeaderDA Accessor;

        public string Reason { get => reason; set => reason = value; }

        /// <summary>
        /// Dependency RepMaster, Entity, dan Branch adalah optional
        /// dan hanya digunakan untuk method READ, dan Find (jika EagerLoading=true)
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="mRepMasterAccessor"></param>
        /// <param name="mEntityAccessor"></param>
        /// <param name="mBranchAccessor"></param>
        public SOKpHeaderAL(clsGlobal helper, RCRepMasterAL mRepMasterAccessor = null, GSEntityAL mEntityAccessor = null, GSBranchAL mBranchAccessor = null)
        {
            Helper = helper;
            RepMasterAccessor = mRepMasterAccessor;
            Entity = mEntityAccessor;
            Branch = mBranchAccessor;

            Accessor = new SOKpHeaderDA(Helper, RepMasterAccessor, Entity, Branch);
        }

        public List<SOKPHeaderBL> AdvanceShowList(int Page = 1, int Perpage = 25,
            string filterEntityID = "", string filterBranchID = "",
            string filterSalesType = "", string filterInvoiceNumber = "",
            string filterKpNumber = "", string filterKpStatus = "",
            string filterCodStatus = "", string filterVerificationStatus = "",
            string filterDeliveryStatus = "", string filterDpStatus = "",
            string filterInvoiceStatus = "", string filterKpDateStart = "",
            string filterKpDateEnd = "", string filterDeliveryDateStart = "",
            string filterDeliveryDateEnd = "")
        {
            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(Enums.EnumFilter.GET_WITH_PAGING, 
                Offset, Perpage, 
                filterEntityID, filterBranchID, 
                filterSalesType, filterInvoiceNumber, 
                filterKpNumber, filterKpStatus, 
                filterCodStatus, filterVerificationStatus, 
                filterDeliveryStatus, filterDpStatus, 
                filterInvoiceStatus, filterKpDateStart, 
                filterKpDateEnd, filterDeliveryDateStart, 
                filterDeliveryDateEnd);
        }

        public SOKPHeaderBL Find(string KpNumber, bool EagerLoding = false)
        {
            SOKPHeaderBL Item = Accessor.Find(KpNumber, EagerLoding);
            if(Item == null)
            {
                Reason = Accessor.Reason;
            }

            return Item;
        }

        public int CountRows(string filterEntityID = "", string filterBranchID = "",
            string filterSalesType = "", string filterInvoiceNumber = "",
            string filterKpNumber = "", string filterKpStatus = "",
            string filterCodStatus = "", string filterVerificationStatus = "",
            string filterDeliveryStatus = "", string filterDpStatus = "",
            string filterInvoiceStatus = "", string filterKpDateStart = "",
            string filterKpDateEnd = "", string filterDeliveryDateStart = "",
            string filterDeliveryDateEnd = "")
        {
            return Accessor.CountRows(filterEntityID, filterBranchID,
                filterSalesType,filterInvoiceNumber,
                filterKpNumber,filterKpStatus,
                filterCodStatus,filterVerificationStatus,
                filterDeliveryStatus,filterDpStatus,
                filterInvoiceStatus,filterKpDateStart,
                filterKpDateEnd,filterDeliveryDateStart,
                filterDeliveryDateEnd);
        }

        /// <summary>
        /// Module = NOPJK or PJK
        /// </summary>
        /// <param name="Module"></param>
        /// <returns></returns>
        public DataTable TaxReminder(string Module = "NOPJK")
        {
            return Accessor.TaxReminder(Module);
        }
    }
}
