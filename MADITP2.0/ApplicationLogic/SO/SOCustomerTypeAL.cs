using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.IM
{
    class SOCustomerTypeAL
    {
        private string reason;
        private clsGlobal Helper;
        private SOCustomerTypeDA Accessor;

        public SOCustomerTypeAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new SOCustomerTypeDA(Helper);
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(SOCustomerTypeBL Item)
        {
            if (string.IsNullOrEmpty(Item.Customer_type))
            {
                Reason = "Customer Type is empty";
            }
            
            if(Find(Item.Customer_type) != null)
            {
                Reason = "Customer Type is already used!";
                return false;
            }
            
            if (string.IsNullOrEmpty(Item.Customer_type_description))
            {
                Reason = "Customer type description is empty";
            }            
            
            if (string.IsNullOrEmpty(Item.Default_price_list))
            {
                Reason = "Default price list is empty";
            }

            bool Info = Accessor.Post(Item);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public bool Put(string DeliveryManID, SOCustomerTypeBL Item)
        {
            if (string.IsNullOrEmpty(Item.Customer_type))
            {
                Reason = "Customer Type is empty";
            }

            if (string.IsNullOrEmpty(Item.Customer_type_description))
            {
                Reason = "Customer type description is empty";
            }

            if (string.IsNullOrEmpty(Item.Default_price_list))
            {
                Reason = "Default price list is empty";
            }

            bool Info = Accessor.Put(DeliveryManID, Item);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public bool Delete(string DeliveryManID)
        {
            if (Find(DeliveryManID) == null)
            {
                Reason = "Delivery man not found!";
                return false;
            }

            bool Info = Accessor.Delete(DeliveryManID);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public int CountRows(string Search = null)
        {
            if (Search == null)
            {
                Search = "";
            }

            return Accessor.CountRows(Search);
        }

        public List<SOCustomerTypeBL> AdvanceShowList(int Page = 1, int Perpage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, Offset, Perpage, Search);
        }

        public List<SOCustomerTypeBL> GetAll(string Search = null)
        {
            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, Search);
        }

        public SOCustomerTypeBL Find(string DeliveryManID)
        {
            return Accessor.Find(DeliveryManID);
        }
    }
}
