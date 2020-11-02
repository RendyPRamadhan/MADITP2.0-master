using MADITP2._0.businessLogic.RC;
using MADITP2._0.DataAccess.RC;
using MADITP2._0.Global;
using System.Data;
using System.Collections.Generic;
using MADITP2._0.Enums;
using System;
using MADITP2._0.BusinessLogic.RC;

namespace MADITP2._0.ApplicationLogic.RC
{
    class RCRepMasterAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        RCRepMasterDA Accessor;
        private string reason;

        public string Reason { get => reason; set => reason = value; }

        public RCRepMasterAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new RCRepMasterDA(Helper, Alert);
        }

        public DataTable SearchData(RCRepMasterBL Entity)
        {
            return Accessor.SearchData(Entity);
        }

        public void UpdateAccount(RCRepMasterBL Entity)
        {
            Accessor.UpdateAccount(Entity);
        }

        public void UpdateNpwp(RCRepMasterBL Entity)
        {
            Accessor.UpdateNpwp(Entity);
        }

        public List<ComboBoxViewModel> GetBank()
        {
            return Accessor.GetBank();
        }

        public bool Post(RCRepMasterBL Item, RCRelativeBL Relative = null) 
        {
            if (string.IsNullOrEmpty(Item.repId))
            {
                Reason = "Rep ID is empty";
                Alert.PushAlert(Reason, clsAlert.Type.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(Item.name))
            {
                Reason = "Name is empty";
                Alert.PushAlert(Reason, clsAlert.Type.Warning);
                return false;
            }

            bool info = Accessor.Post(Item);
            if (!info)
            {
                Reason = Accessor.Reason;
            } else
            {
                if(Relative != null)
                {
                    RCRelativeAL RelativeAccessor = new RCRelativeAL(Helper);
                    info = RelativeAccessor.Post(Relative);
                    if (!info)
                    {
                        Reason = RelativeAccessor.Reason;
                    }
                }
            }

            return info;
        }

        /// <summary>
        /// Update rep master, update relative jika relative id bukan 0. jika 
        /// relative id = 0, maka relative di create
        /// </summary>
        /// <param name="RepId"></param>
        /// <param name="Item"></param>
        /// <param name="Relative"></param>
        /// <returns></returns>
        public bool Put(string RepId, RCRepMasterBL Item, RCRelativeBL Relative = null)
        {
            if (string.IsNullOrEmpty(RepId))
            {
                Reason = "Rep ID is empty";
                Alert.PushAlert(Reason, clsAlert.Type.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(Item.name))
            {
                Reason = "Name is empty";
                Alert.PushAlert(Reason, clsAlert.Type.Warning);
                return false;
            }

            if(Relative != null && Relative.Rep_Id == null)
            {
                Reason = "Relative Rep_Id is empty";
                Alert.PushAlert(Reason, clsAlert.Type.Warning);
                return false;
            }

            Item.Entry_date = DateTime.Now;
            bool info = Accessor.Put(RepId, Item);
            if (!info)
            {
                Reason = Accessor.Reason;
            }
            else
            {
                if (Relative != null && Relative.Id == 0)
                {
                    RCRelativeAL RelativeAccessor = new RCRelativeAL(Helper);
                    info = RelativeAccessor.Post(Relative);
                    if (!info)
                    {
                        Reason = RelativeAccessor.Reason;
                    }
                }

                if (Relative != null && Relative.Id != 0)
                {
                    RCRelativeAL RelativeAccessor = new RCRelativeAL(Helper);
                    info = RelativeAccessor.Put(Relative.Id, Relative);
                    if (!info)
                    {
                        Reason = RelativeAccessor.Reason;
                    }
                }
            }

            return info;
        }

        public bool Delete(string RepId)
        {
            return Accessor.Delete(RepId);
        }

        public RCRepMasterBL Find(string RepId)
        {
            return Accessor.Find(RepId);
        }

        public List<RCRepMasterBL> GetAll(
            string Search = null,
            string RepLevel = "",
            string RecruterId = "",
            string ManagerId = "",
            string EntityId = "",
            string BranchId = "",
            string DivisionId = "",
            string Gender = "",
            string ActiveFlag = "",
            int? MaritalStatus = null,
            DateTime? filterStartJoinDate = null,
            DateTime? filterEndJoinDate = null)
        {
            string StartJoinDate = "";
            string EndJoinDate = "";
            if (filterStartJoinDate != null)
            {
                StartJoinDate = filterStartJoinDate?.ToString("yyyy-MM-dd");
                EndJoinDate = filterEndJoinDate?.ToString("yyyy-MM-dd");
            }

            return Accessor.Read(EnumFilter.GET_ALL, -1, -1, Search, RepLevel, RecruterId, ManagerId, EntityId, 
                BranchId, DivisionId, Gender, ActiveFlag, MaritalStatus, StartJoinDate, EndJoinDate);
        }

        public List<RCRepMasterBL> AdvanceShowList(int Page = 1, int Perpage = (int)EnumFetchData.DefaultLimit, 
            string Search = null, 
            string RepLevel = "",
            string RecruterId = "",
            string ManagerId = "",
            string EntityId = "",
            string BranchId = "",
            string DivisionId = "",
            string Gender = "",
            string ActiveFlag = "",
            int? MaritalStatus = null,
            DateTime? filterStartJoinDate = null,
            DateTime? filterEndJoinDate = null)
        {
            string StartJoinDate = "";
            string EndJoinDate = "";
            if (filterStartJoinDate != null)
            {
                StartJoinDate = filterStartJoinDate?.ToString("yyyy-MM-dd");
                EndJoinDate = filterEndJoinDate?.ToString("yyyy-MM-dd");
            }

            int Offset = (Page - 1) * Perpage;
            return Accessor.Read(EnumFilter.GET_WITH_PAGING, 
                Offset, Perpage, Search, RepLevel, RecruterId, ManagerId, 
                EntityId, BranchId, DivisionId, Gender, ActiveFlag, MaritalStatus, StartJoinDate, EndJoinDate);
        }

        public int CountRows(string Search = "", string RepLevel = "", string RecruterId = "", string ManagerId = "", string EntityId = "",
            string BranchId = "", string DivisionId = "", string Gender = "", string ActiveFlag = "", int? MaritalStatus = null,
            DateTime? filterStartJoinDate = null,
            DateTime? filterEndJoinDate = null)
        {
            string StartJoinDate = "";
            string EndJoinDate = "";
            if (filterStartJoinDate != null)
            {
                StartJoinDate = filterStartJoinDate?.ToString("yyyy-MM-dd");
                EndJoinDate = filterEndJoinDate?.ToString("yyyy-MM-dd");
            }

            return Accessor.CountRows(Search, RepLevel, RecruterId, ManagerId, EntityId, 
                BranchId, DivisionId, Gender, 
                ActiveFlag, MaritalStatus, StartJoinDate, EndJoinDate);
        }
    }
}
