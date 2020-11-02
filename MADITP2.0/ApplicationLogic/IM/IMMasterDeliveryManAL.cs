using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.IM
{
    class IMMasterDeliveryManAL
    {
        private string reason;
        private clsGlobal Helper;
        private IMMasterDeliveryManDA Accessor;

        public IMMasterDeliveryManAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new IMMasterDeliveryManDA(Helper);
        }

        public string Reason { get => reason; set => reason = value; }

        public bool Post(IMMasterDeliveryManBL Item)
        {
            if(Find(Item.Delivery_man_id) != null)
            {
                Reason = "ID is already used!";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Delivery_man_id))
            {
                Reason = "Delivery man ID is empty";                
            }            
            
            if (string.IsNullOrEmpty(Item.Delivery_man_name))
            {
                Reason = "Delivery man Name is empty";                
            }            
            
            if (string.IsNullOrEmpty(Item.Short_name))
            {
                Reason = "Shot name is empty";                
            }
            
            if (string.IsNullOrEmpty(Item.Entity_id))
            {
                Reason = "Entity is empty";                
            }
            
            if (string.IsNullOrEmpty(Item.Branch_id))
            {
                Reason = "Branch is empty";                
            }
            
            if (string.IsNullOrEmpty(Item.Divison_id))
            {
                Reason = "Division is empty";                
            }

            bool Info = Accessor.Post(Item);
            if (!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public bool Put(string DeliveryManID, IMMasterDeliveryManBL Item)
        {
            if (Find(DeliveryManID) == null)
            {
                Reason = "Delivery man not found!";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Delivery_man_id))
            {
                Reason = "Delivery man ID is empty";
            }

            if (string.IsNullOrEmpty(Item.Delivery_man_name))
            {
                Reason = "Delivery man Name is empty";
            }

            if (string.IsNullOrEmpty(Item.Short_name))
            {
                Reason = "Shot name is empty";
            }

            if (string.IsNullOrEmpty(Item.Entity_id))
            {
                Reason = "Entity is empty";
            }

            if (string.IsNullOrEmpty(Item.Branch_id))
            {
                Reason = "Branch is empty";
            }

            if (string.IsNullOrEmpty(Item.Divison_id))
            {
                Reason = "Division is empty";
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

        public int CountRows(IMMasterDeliveryManBL DeliveryMan = null, string Search = null)
        {
            return Accessor.CountRows(DeliveryMan, Search);
        }

        public List<IMMasterDeliveryManBL> AdvanceShowList(int Page = 1, int Perpage = (int)EnumFetchData.DefaultLimit,
            IMMasterDeliveryManBL DeliveryMan = null, string Search = null)
        {
            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, Offset, Perpage, DeliveryMan, Search);
        }

        public List<IMMasterDeliveryManBL> GetAll(string EntityID = null, string BranchID = null, string DivisionID = null, string Search = null)
        {
            return Accessor.Read(EnumFilter.GET_ALL, -1, -1,
                new IMMasterDeliveryManBL()
                {
                    Entity_id = EntityID,
                    Branch_id = BranchID,
                    Divison_id = DivisionID
                }, Search);
        }

        public IMMasterDeliveryManBL Find(string DeliveryManID)
        {
            return Accessor.Find(DeliveryManID);
        }
    }
}
