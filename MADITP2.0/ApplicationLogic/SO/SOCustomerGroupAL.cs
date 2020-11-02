using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.IM
{
    class SOCustomerGroupAL
    {
        private string reason;
        private clsGlobal Helper;
        private SOCustomerGroupDA Accessor;

        public SOCustomerGroupAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new SOCustomerGroupDA(Helper);
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(SOCustomerGroupBL Item)
        {
            if(Find(Item.Customer_group_id) != null)
            {
                Reason = "ID is already used!";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Customer_group_description))
            {
                Reason = "Description is empty";                
            }            
            
            if (string.IsNullOrEmpty(Item.Default_price_list))
            {
                Reason = "Price list is empty";                
            }            
            
            bool Info = Accessor.Post(Item);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public bool Put(string Code, SOCustomerGroupBL Item)
        {
            if (string.IsNullOrEmpty(Code))
            {
                Reason = "Group ID is empty";
            }

            if (Find(Code) == null)
            {
                Reason = "Delivery man not found!";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Customer_group_description))
            {
                Reason = "Description is empty";
            }

            if (string.IsNullOrEmpty(Item.Customer_group_id))
            {
                Reason = "Group ID is empty";
            }

            if (string.IsNullOrEmpty(Item.Default_price_list))
            {
                Reason = "Price list is empty";
            }

            bool Info = Accessor.Put(Code, Item);
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
            return Accessor.CountRows(Search);
        }

        public List<SOCustomerGroupBL> AdvanceShowList(int Page = 1, int Perpage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, Offset, Perpage, Search);
        }

        public List<SOCustomerGroupBL> GetAll(string Search = null)
        {
            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, Search);
        }

        public SOCustomerGroupBL Find(string Code)
        {
            return Accessor.Find(Code);
        }
    }
}
