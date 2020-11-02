using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MADITP2._0.ApplicationLogic
{
    class GSUserManagementAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        GSUserManagementDA Accessor;

        public GSUserManagementAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new GSUserManagementDA(Helper, Alert);
        }

        public List<GSUserManagementBL.GSMenuOtoration> GetUserGroupMenu(string UserID = null)
        {
            return Accessor.GetUserGroupMenu(UserID);
        }

        public DataTable GetUserGroup(string UserID = null, string Name = null,string Search = null)
        {
            return Accessor.GetUserGroup(UserID, Name, Search);
        }

        public DataTable GetUser(string UserID = null, string Name = null, string Search = null)
        {
            return Accessor.GetUser(UserID, Name, Search);
        }
        public DataTable GetUserBranch(string UserID = null)
        {
            return Accessor.GetUser(UserID);
        }

        public void getCombo(ComboBox GetModuls)
        {
            var DataUser = new GSUserManagementDA(Helper, Alert);

            GetModuls.DataSource = DataUser.GetModuls();
            GetModuls.DisplayMember = "DisplayMember";
            GetModuls.ValueMember = "ValueMember";
        }
        public void getEntity(ComboBox getEntity)
        {
            var DataUser = new GSUserManagementDA(Helper, Alert);

            getEntity.DataSource = DataUser.GetEntities();
            getEntity.DisplayMember = "DisplayMember";
            getEntity.ValueMember = "ValueMember";
        }

        public List<GSUserManagementBL.GSUsers> GetListUsers()
        {
            return Accessor.GetListUsers();
        }
    }
}
