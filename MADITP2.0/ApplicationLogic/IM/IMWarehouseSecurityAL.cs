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
    class IMWarehouseSecurityAL
    {
        private clsGlobal Helper;
        private IMWarehouseSecurityDA Accessor;
        private string mReason;

        public IMWarehouseSecurityAL(clsGlobal helper)
        {
            Helper = helper;
            Reason = null;
            Accessor = new IMWarehouseSecurityDA(Helper);
        }

        public string Reason { get => mReason; set => mReason = value; }

        public Boolean Post(IMWarehouseSecurityBL item)
        {
            if (string.IsNullOrEmpty(item.User_id))
            {
                Reason = "Used ID is empty!";
                return false;
            }

            if (string.IsNullOrEmpty(item.Warehouse_id))
            {
                Reason = "Warehouse is empty!";
                return false;
            }

            return Accessor.Post(item);
        }

        public Boolean Put(int Id, IMWarehouseSecurityBL item)
        {
            return Accessor.Put(Id, item);
        }

        public Boolean Delete(int Id)
        {
            return Accessor.Delete(Id);
        }

        public List<IMWarehouseSecurityBL> AdvanceShowList(int page = 1, int perpage = (int)EnumFetchData.DefaultLimit, IMWarehouseSecurityBL security = null, string search = null)
        {
            int offset = (page - 1) * perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, offset, perpage, security, search);
        }

        public List<IMWarehouseSecurityBL> GetAll(IMWarehouseSecurityBL security = null, string search = null)
        {
            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, security, search);
        }

        public int CountRows(IMWarehouseSecurityBL security = null, string search = null)
        {
            return Accessor.CountRows(security, search);
        }

        public IMWarehouseSecurityBL GetSecurity(int Id)
        {
            return Accessor.GetSecurity(Id);
        }
    }
}
