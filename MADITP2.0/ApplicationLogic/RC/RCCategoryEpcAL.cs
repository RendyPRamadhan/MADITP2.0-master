using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.DataAccess.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.RC
{
    class RCCategoryEpcAL
    {
        private clsGlobal Helper;
        private RCCategoryEpcDA Accessor;
        private string mReason;

        public string Reason { get => string.IsNullOrEmpty(Accessor.Reason) ? mReason : Accessor.Reason ; set => mReason = value; }

        public RCCategoryEpcAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new RCCategoryEpcDA(Helper);
        }

        public Boolean Post(RCCategoryEpcBL item)
        {
            if (string.IsNullOrEmpty(item.Description))
            {
                Reason = "Description is empty!";
                return false;
            }

            return Accessor.Post(item);
        }

        public Boolean Put(int Id, RCCategoryEpcBL item)
        {
            if (string.IsNullOrEmpty(item.Description))
            {
                Reason = "Description is empty!";
                return false;
            }

            return Accessor.Put(Id, item);
        }

        public Boolean Delete(int id)
        {
            return Accessor.Delete(id);
        }

        public int CountRows(string search = null)
        {
            if (string.IsNullOrEmpty(search))
            {
                search = string.Empty;
            }

            return Accessor.CountRows(search);
        }

        public RCCategoryEpcBL GetCategoryEpc(int Id)
        {
            return Accessor.GetCategoryEpc(Id);
        }

        public List<RCCategoryEpcBL> AdvanceShowList(int page = 1, int perpage = (int)EnumFetchData.DefaultLimit, string search = null)
        {
            if (string.IsNullOrEmpty(search))
            {
                search = string.Empty;
            }

            int offset = (page - 1) * perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, offset, perpage, search);
        }

        public List<RCCategoryEpcBL> GetAll(string search = null)
        {
            if (string.IsNullOrEmpty(search))
            {
                search = string.Empty;
            }

            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, search);
        }
    }
}
