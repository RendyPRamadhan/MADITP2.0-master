using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.GS
{
    public class GSUserManagementBL
    {
        public class GSUserGroup
        {
            private string gug_group_id;
            private string gug_group_desc;
            private string gug_entity_id;

            public string group_id
            {
                get { return gug_group_id; }
                set { this.gug_group_id = value; }
            }

            public string group_desc
            {
                get { return gug_group_desc; }
                set { this.gug_group_desc = value; }
            }
            public string entity_id
            {
                get { return gug_entity_id; }
                set { this.gug_entity_id = value; }
            }
        }

        public class GSUserBranch
        {
            private string gub_group_user_id;
            private string gub_user_id;
            private string gub_branch_id;
            private string gub_branch_desc;
            private string gub_flag_branch_group_user;
            private string gub_flag_branch_user;

            public string group_user_id
            {
                get { return gub_group_user_id; }
                set { this.gub_group_user_id = value; }
            }
            public string user_id
            {
                get { return gub_user_id; }
                set { this.gub_user_id = value; }
            }
            public string branch_id
            {
                get { return gub_branch_id; }
                set { this.gub_branch_id = value; }
            }

            public string branch_desc
            {
                get { return gub_branch_desc; }
                set { this.gub_branch_desc = value; }
            }
            public string flag_branch_group_user
            {
                get { return gub_flag_branch_group_user; }
                set { this.gub_flag_branch_group_user = value; }
            }
            public string flag_branch_user
            {
                get { return gub_flag_branch_user; }
                set { this.gub_flag_branch_user = value; }
            }
        }

        public class GSUsers
        {
            private string usr_group_user_id;
            private string usr_group_user_desc;
            private string usr_user_id;
            private string usr_name;
            private string usr_description;
            private string usr_password;
            private string usr_status;
            private string usr_entity_id;
            private string usr_entity;

            public string group_user_id
            {
                get { return usr_group_user_id; }
                set { this.usr_group_user_id = value; }
            }
            public string group_user_desc
            {
                get { return usr_group_user_desc; }
                set { this.usr_group_user_desc = value; }
            }
            public string user_id
            {
                get { return usr_user_id; }
                set { this.usr_user_id = value; }
            }
            public string name
            {
                get { return usr_name; }
                set { this.usr_name = value; }
            }
            public string description
            {
                get { return usr_description; }
                set { this.usr_description = value; }
            }
            public string password
            {
                get { return usr_password; }
                set { this.usr_password = value; }
            }
            public string status
            {
                get { return usr_status; }
                set { this.usr_status = value; }
            }
            public string entity_id
            {
                get { return usr_entity_id; }
                set { this.usr_entity_id = value; }
            }
            public string entity
            {
                get { return usr_entity; }
                set { this.usr_entity = value; }
            }
        }
        public class GSModul
        {
            private string mdl_modul_id;
            private string mdl_modul_desc;

            public string modul_id
            {
                get { return mdl_modul_id; }
                set { this.mdl_modul_id = value; }
            }
            public string modul_desc
            {
                get { return mdl_modul_desc; }
                set { this.mdl_modul_desc = value; }
            }
        }

        public class GSMenuOtoration
        {
            private string mnu_group_user;
            private string mnu_user;
            private string mnu_group_menu;
            private string mnu_menu_code;
            private string mnu_menu_desc;
            private string mnu_flag_menu;
            private string mnu_flag_new;
            private string mnu_flag_edit;
            private string mnu_flag_delete;
            private string mnu_flag_print;
            private string mnu_flag_export;

            public string group_user
            {
                get { return mnu_group_user; }
                set { this.mnu_group_user = value; }
            }
            public string user
            {
                get { return mnu_user; }
                set { this.mnu_user = value; }
            }
            public string group_menu
            {
                get { return mnu_group_menu; }
                set { this.mnu_group_menu = value; }
            }
            public string menu_code
            {
                get { return mnu_menu_code; }
                set { this.mnu_menu_code = value; }
            }
            public string menu_desc
            {
                get { return mnu_menu_desc; }
                set { this.mnu_menu_desc = value; }
            }
            public string flag_menu
            {
                get { return mnu_flag_menu; }
                set { this.mnu_flag_menu = value; }
            }
            public string flag_new
            {
                get { return mnu_flag_new; }
                set { this.mnu_flag_new = value; }
            }
            public string flag_edit
            {
                get { return mnu_flag_edit; }
                set { this.mnu_flag_edit = value; }
            }
            public string flag_delete
            {
                get { return mnu_flag_delete; }
                set { this.mnu_flag_delete = value; }
            }
            public string flag_print
            {
                get { return mnu_flag_print; }
                set { this.mnu_flag_print = value; }
            }
            public string flag_export
            {
                get { return mnu_flag_export; }
                set { this.mnu_flag_export = value; }
            }

        }
    }
}