using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.IM
{
    class IMTransferTypeAL
    {
        private clsGlobal Helper;
        private IMTransferTypeDA Accessor;
        private string mReason;

        public string Reason { get => mReason; set => mReason = value; }

        public IMTransferTypeAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new IMTransferTypeDA(Helper);
        }

        public Boolean Post(IMTransferTypeBL Item)
        {
            if (string.IsNullOrEmpty(Item.Transfer_txn_type_code))
            {
                Reason = "Transfer code is empty.";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Transfer_txn_type_description))
            {
                Reason = "Transfer description is empty.";
                return false;
            }

            if (string.IsNullOrEmpty(Item.System_type))
            {
                Reason = "System type is empty.";
                return false;
            }

            return Accessor.Post(Item);
        }

        public Boolean Put(string Code, IMTransferTypeBL Item)
        {
            if (string.IsNullOrEmpty(Item.Transfer_txn_type_code))
            {
                Reason = "Transfer code is empty.";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Transfer_txn_type_description))
            {
                Reason = "Transfer description is empty.";
                return false;
            }

            if (string.IsNullOrEmpty(Item.System_type))
            {
                Reason = "System type is empty.";
                return false;
            }

            return Accessor.Put(Code, Item);
        }

        public Boolean Delete(string Code)
        {
            return Accessor.Delete(Code);
        }

        public int CountRows(string search = null)
        {
            return Accessor.CountRows(search);
        }

        public List<IMTransferTypeBL> GetAll(string search = null)
        {
            if (string.IsNullOrEmpty(search))
            {
                search = string.Empty;
            }

            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, search);
        }

        public List<IMTransferTypeBL> AdvanceShowList(int page = 1, int perpage = (int)EnumFetchData.DefaultLimit, string search = null)
        {
            int offset = (page - 1) * perpage;
            if (string.IsNullOrEmpty(search))
            {
                search = string.Empty;
            }

            return Accessor.Read(EnumFilter.GET_WITH_PAGING, offset, perpage, search);
        }

        public IMTransferTypeBL GetTransferType(string Code)
        {
            return Accessor.GetTransferType(Code);
        }
    }
}
