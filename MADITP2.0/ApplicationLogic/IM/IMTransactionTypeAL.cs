using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System.Collections.Generic;

namespace MADITP2._0.ApplicationLogic.IM
{
    class IMTransactionTypeAL
    {
        private IMTransactionTypeDA Accessor;
        private clsGlobal Helper;
        private string mReason;

        public IMTransactionTypeAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new IMTransactionTypeDA(Helper);
        }

        public string Reason { get => mReason; set => mReason = value; }

        public bool Post(IMTransactionTypeBL Item)
        {
            if (string.IsNullOrEmpty(Item.Txn_type_code))
            {
                Reason = "Transfer type code is empty!";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Txn_type_description))
            {
                Reason = "Transfer type description is empty!";
                return false;
            }

            var check = Accessor.GetTransactionType(Item.Txn_type_code);
            if(check != null)
            {
                Reason = "Code is already used!";
                return false;
            }

            // force group_acc as OTHER
            Item.Group_acc = "OTHER";
            bool info = Accessor.Post(Item);
            if (!info)
            {
                Reason = Accessor.Reason;
            }

            return info;
        }

        public bool Put(string Code, IMTransactionTypeBL Item)
        {
            if (string.IsNullOrEmpty(Item.Txn_type_code))
            {
                Reason = "Transfer type code is empty!";
                return false;
            }

            if (string.IsNullOrEmpty(Item.Txn_type_description))
            {
                Reason = "Transfer type description is empty!";
                return false;
            }

            bool info = Accessor.Put(Code, Item);
            if (!info)
            {
                Reason = Accessor.Reason;
            }

            return info;
        }

        public bool Delete(string Code)
        {
            return Accessor.Delete(Code);
        }

        public List<IMTransactionTypeBL> AdvanceShowList(int page = 1, int perpage = (int)EnumFetchData.DefaultLimit, string search = null)
        {
            int offset = (page - 1) * perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, offset, perpage, search);
        }

        public int CountRows(string search = null)
        {
            return Accessor.CountRows(search);
        }

        public List<IMTransactionTypeBL> GetAll(string search = null)
        {
            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, search);
        }

        public IMTransactionTypeBL GetTransactionType(string Code)
        {
            return Accessor.GetTransactionType(Code);
        }
    }
}
