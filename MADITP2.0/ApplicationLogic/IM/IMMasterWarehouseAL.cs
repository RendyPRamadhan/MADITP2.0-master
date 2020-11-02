using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.IM
{
    class IMMasterWarehouseAL
    {
        private IMMasterWarehouseDA Accessor;
        private clsGlobal Helper;
        private string Reason;

        public string GetReason()
        {
            return Reason;
        }

        public void SetReason(string m)
        {
            Reason = m;
        }

        public IMMasterWarehouseAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new IMMasterWarehouseDA(Helper);
        }

        public Boolean Post(IMMasterWarehouseBL item) 
        {
            if (string.IsNullOrEmpty(item.warehouse_id))
            {
                SetReason("Warehouse ID is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.warehouse_description))
            {
                SetReason("Warehouse description is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.city))
            {
                SetReason("Warehouse city is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.province))
            {
                SetReason("Warehouse province is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.phone))
            {
                SetReason("Warehouse phone is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.gl_account))
            {
                SetReason("GL Account is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.gl_entity))
            {
                SetReason("GL Entity is empty!");
                return false;
            }

            Boolean info = Accessor.Post(item);
            if (!info)
            {
                SetReason(Accessor.Reason);
            }

            return info;
        }

        public Boolean Put(string wh_warehouse_id, IMMasterWarehouseBL item) 
        {
            if (string.IsNullOrEmpty(item.warehouse_description))
            {
                SetReason("Warehouse description is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.city))
            {
                SetReason("Warehouse city is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.province))
            {
                SetReason("Warehouse province is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.gl_account))
            {
                SetReason("GL Account is empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.gl_entity))
            {
                SetReason("GL Entity is empty!");
                return false;
            }

            Boolean info = Accessor.Put(wh_warehouse_id, item);
            if (!info)
            {
                SetReason(Accessor.Reason);
            }

            return info;
        }

        public Boolean Delete(string wh_warehouse_id) 
        {
            Boolean info = Accessor.Delete(wh_warehouse_id);
            if (!info)
            {
                SetReason(Accessor.Reason);
            }

            return info;
        }

        public List<IMMasterWarehouseBL> AdvanceShowList(int page = 1, int perpage = (int)EnumFetchData.DefaultLimit, IMMasterWarehouseBL wh = null, string search = null) 
        {
            int offset = (page - 1) * perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, offset, perpage, wh, search);
        }

        public int CountRows(IMMasterWarehouseBL wh = null, string search = null) 
        {
            List<IMMasterWarehouseBL> item = Accessor.Read(EnumFilter.GET_COUNT_ROWS, -1, -1, wh, search);
            return item.Count;
        }

        public IMMasterWarehouseBL GetWarehouse(string warehouse_id) {
            return Accessor.GetWarehouse(warehouse_id);
        }

        public List<string> GetListCities()
        {
            return Accessor.GetListCities();
        }

        public Boolean isExists(string warehouse_id)
        {
            return Accessor.isExists(warehouse_id);
        }
    }
}
