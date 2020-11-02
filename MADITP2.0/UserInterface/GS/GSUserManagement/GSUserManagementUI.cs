using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.Enums;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.ApplicationLogic;
using MADITP2._0.DataAccess.GS;
using System.Windows.Navigation;

namespace MADITP2._0.UserInterface.GS.GSUserManagement
{
    public partial class GSUserManagementUI : Form
    {
        clsAlert Alert;
        clsGlobal Helper;
        GSUserManagementDA Accessor;
        GSUserManagementBL.GSUserGroup _GSUserGroup;
        GSUserManagementBL.GSUsers _GSUser;
        GSUserManagementBL.GSModul EntityModul;
        GSUserManagementAL AppLogic;
        public static string _GroupID_Selected,_UserID_Selected, FormActiveName, _GroupDesc_Selected, f_add,f_edit,f_delete,f_print,f_export;
        public static int _Grid;
        private int _APPSTATE;        

        CheckBox HeaderCheckBoxMenu = null;
        CheckBox HeaderCheckBoxBranch = null;

        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        bool IsHeaderCheckBoxClicked = false;

        public GSUserManagementUI()
        {
            InitializeComponent();
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Accessor = new GSUserManagementDA(Helper, Alert);
            AppLogic = new GSUserManagementAL(Helper, Alert);
            EntityModul = new GSUserManagementBL.GSModul();
        }

        private void GSUserManagementUI_Load(object sender, EventArgs e)
        {
            navView.PerformClick();
            SetState(EnumState.view);
            //Helper.getComboUser(this.cboEntity, this.cboBranch);
            Helper.getAccessMenu(this.navNew, this.navEdit, this.navDelete, this.navPrint, this.navExport);
            getGroupUser();
            pnlView.BringToFront();

            AddHeaderCheckBox();
            //HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBoxMenu.MouseClick += new MouseEventHandler(HeaderCheckBoxMenu_MouseClick);
            dgMenu.CellValueChanged += new DataGridViewCellEventHandler(dgMenu_CellValueChanged);

            HeaderCheckBoxBranch.MouseClick += new MouseEventHandler(HeaderCheckBoxBranch_MouseClick);
            dgBranch.CellValueChanged += new DataGridViewCellEventHandler(dgBranch_CellValueChanged);
        }

        private void getGroupUser()
        {
            string _UserID = null;
            string _Name = null;

            if (textSearchID.Text != "Search by User ID")
            {
                if (textSearchID.Text != "")
                {
                    _UserID = textSearchID.Text.ToUpper();
                }
            }

            if (txtSearchUserName.Text != "Search by Name")
            {
                if (txtSearchUserName.Text != "")
                {
                    _Name = txtSearchUserName.Text.ToUpper();
                }
            }

            dgGroupUser.AutoGenerateColumns = false;
            dgGroupUser.DataSource = Accessor.GetUserGroup(_UserID, _Name,"N");
            if (dgGroupUser.Rows.Count > 0)
            {
                DataGridViewCellEventArgs DataGridViewCellEventArgs = new DataGridViewCellEventArgs(dgGroupUser.Columns[0].Index, dgGroupUser.CurrentRow.Index);
                this.dgGroupUser_CellClick(dgGroupUser.CurrentRow.Index, DataGridViewCellEventArgs);
            }
            else
            {
                Alert.PushAlert("Goup User Not Found ", clsAlert.Type.Error);
            }
        }
        private void dgGroupUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _GroupID_Selected = dgGroupUser.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            _Grid = (int)SelectedGrid.List;
            dgUser.AutoGenerateColumns = false;
            dgUser.DataSource = Accessor.GetUser(_GroupID_Selected, null,"N");
            if (dgUser.Rows.Count == 0)
            {
                Alert.PushAlert("User Not Found", clsAlert.Type.Error);
            }            
        }

        private void dgUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _Grid = (int)SelectedGrid.Detail;
            if (dgUser.Rows.Count == 0)
            {
                Alert.PushAlert("User Not Found", clsAlert.Type.Error);
            }
            else
            {
                _UserID_Selected = dgUser.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getGroupUser();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW, sender);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.EDIT, sender);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.NEW, sender);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getUserGroupBranch()
        {
            dgBranch.AutoGenerateColumns = false;
            dgBranch.DataSource = Accessor.GetUserGroupBranch(txtEditorUserGroupID.Text.ToString().Trim());
            dgBranch.Columns[1].ReadOnly = true;
            dgBranch.Columns[2].ReadOnly = true;
            TotalCheckBoxes = dgBranch.RowCount;
        }

        public void getUserBranch()
        {
            DataTable _UserBranch = Accessor.GetUserBranch(txtEditorUserID.Text.ToString().Trim());
            dgBranch.AutoGenerateColumns = false;
            dgBranch.DataSource = _UserBranch;

            for (int i=0; i< _UserBranch.Rows.Count; i++)
            {
                if (_UserBranch.Rows[i]["flag_branch_group_user"].ToString() == "Y")
                {
                    dgBranch.Rows[i].ReadOnly = true;
                }
                else
                {
                    dgBranch.Columns[1].ReadOnly = true;
                    dgBranch.Columns[2].ReadOnly = true;
                }
            }
            TotalCheckBoxes = dgBranch.RowCount;
        }

        private void getMenu()
        {
            dgMenu.AutoGenerateColumns = false;
            dgMenu.DataSource = Accessor.getMenu(EntityModul, txtEditorUserGroupID.Text.ToString().Trim());
            dgMenu.Columns[1].ReadOnly = true;
            dgMenu.Columns[2].ReadOnly = true;
            TotalCheckBoxes = dgMenu.RowCount;
        }
        private void getMenuUser()
        {
            DataTable _UserMenu= Accessor.getMenuUser(EntityModul, txtEditorUserID.Text.ToString().Trim());
            dgMenu.AutoGenerateColumns = false;
            dgMenu.DataSource = _UserMenu;
            for (int i = 0; i < _UserMenu.Rows.Count; i++)
            {
                if (_UserMenu.Rows[i]["flag_menu_group"].ToString() == "Y")
                {
                    dgMenu.Rows[i].ReadOnly = true;
                }
                else
                {
                    dgMenu.Columns[1].ReadOnly = true;
                    dgMenu.Columns[2].ReadOnly = true;
                }
            }
            TotalCheckBoxes = dgMenu.RowCount;
        }

        public Boolean SaveCheck()
        {
            if (_APPSTATE == (int)EnumState.Update)
            {
                if (_Grid == 0)
                {
                    DataTable check = Accessor.SaveCheck(txtEditorUserGroupID.Text.ToString().Trim(), _Grid, _APPSTATE);
                    foreach (DataRow dr in check.Rows)
                    {
                        string result = dr["flag_check"].ToString();
                        if (result == "N")
                        {
                            const string message = "Please complete user group branch or menu roles !";
                            const string caption = "New user group";
                            MessageBox.Show(message, caption,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            pnlView.BringToFront();
                            getGroupUser();
                            Helper.SetActive(navView);
                            SetState(EnumState.view);
                            return true;
                        }
                    }
                }
                if (_Grid == 1)
                {
                    DataTable check = Accessor.SaveCheck(txtEditorUserID.Text.ToString().Trim(), _Grid, _APPSTATE);
                    foreach (DataRow dr in check.Rows)
                    {
                        string result = dr["flag_check"].ToString();
                        if (result == "N")
                        {
                            const string message = "Please complete user branch or menu roles !";
                            const string caption = "New user";
                            MessageBox.Show(message, caption,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            pnlView.BringToFront();
                            getGroupUser();
                            Helper.SetActive(navView);
                            SetState(EnumState.view);
                            return true;
                        }
                    }
                }
            }
            else if (_APPSTATE == (int)EnumState.Create)
            {
                if (_Grid == 0)
                {
                    if (txtEditorUserGroupID.Enabled == true)
                    {
                        DataTable check = Accessor.SaveCheck(txtEditorUserGroupID.Text.ToString().Trim(), _Grid, _APPSTATE);
                        foreach (DataRow dr in check.Rows)
                        {
                            string result = dr["flag_check"].ToString();
                            if (result == "Y")
                            {
                                const string message = "Group is already exists !";
                                const string caption = "New user group";
                                MessageBox.Show(message, caption,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Warning);
                                return false;
                            }
                            else
                            {
                                return true;                                
                            }
                        }
                    }
                    if (txtEditorUserGroupID.Enabled == false)
                    {
                        DataTable savecheck = Accessor.SaveCheck(txtEditorUserGroupID.Text.ToString().Trim(), _Grid, (int)EnumState.Update);
                        foreach (DataRow drs in savecheck.Rows)
                        {
                            string saveresult = drs["flag_check"].ToString();
                            if (saveresult == "N")
                            {
                                const string message = "Please complete user group branch or menu roles !";
                                const string caption = "New user group";
                                MessageBox.Show(message, caption,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Warning);
                                return false;
                            }
                            else
                            {
                                pnlView.BringToFront();
                                getGroupUser();
                                Helper.SetActive(navView);
                                SetState(EnumState.view);
                                return true;
                            }
                        }
                    }
                }
                if (_Grid == 1)
                {
                    if (txtEditorUserID.Enabled == true)
                    {
                        DataTable check = Accessor.SaveCheck(txtEditorUserID.Text.ToString().Trim(), _Grid, _APPSTATE);
                        foreach (DataRow dr in check.Rows)
                        {
                            string result = dr["flag_check"].ToString();
                            if (result == "Y")
                            {
                                const string message = "User is already exists !";
                                const string caption = "New user";
                                MessageBox.Show(message, caption,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Warning);
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                    if (txtEditorUserID.Enabled == false)
                    {
                        DataTable savecheck = Accessor.SaveCheck(txtEditorUserID.Text.ToString().Trim(), _Grid, (int)EnumState.Update);
                        foreach (DataRow drs in savecheck.Rows)
                        {
                            string saveresult = drs["flag_check"].ToString();
                            if (saveresult == "N")
                            {
                                const string message = "Please complete user group branch or menu roles !";
                                const string caption = "New user group";
                                MessageBox.Show(message, caption,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Warning);
                                return false;
                            }
                            else
                            {
                                pnlView.BringToFront();
                                getGroupUser();
                                Helper.SetActive(navView);
                                SetState(EnumState.view);
                                return true;
                            }
                        }
                    }
                }
            }
            return true;
        }

        private void SetState(EnumState enumState)
        {
            switch (enumState)
            {
                case EnumState.Create:
                    _APPSTATE = (int)EnumState.Create;
                    break;
                case EnumState.Update:
                    _APPSTATE = (int)EnumState.Update;
                    break;
                case EnumState.Delete:
                    _APPSTATE = (int)EnumState.Delete;
                    break;
                case EnumState.view:
                    _APPSTATE = (int)EnumState.view;
                    break;
                default:
                    _APPSTATE = 404;
                    this.Enabled = false;
                    break;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tcUserManagement.SelectedIndex == 0)
            {
                if (SaveCheck() == true)
                {
                    Save("P");
                }
            }
            else if (tcUserManagement.SelectedIndex == 1)
            {
                Save("B");
            }
            else if (tcUserManagement.SelectedIndex == 2)
            {
                Save("M");
            }
            SaveCheck();
        }

        private void Save(string type)
        {
            if (_Grid == 0)
            {
                GSUserManagementBL.GSUsers EntityUser = new GSUserManagementBL.GSUsers();
                List<string> PassingArray = new List<string>();

                if (txtEditorUserGroupID.Text == "")
                {
                    Alert.PushAlert("Group ID cannot be empty", clsAlert.Type.Warning);
                    return;
                }

                if (txtEditorUserGroupDescription.Text == "")
                {
                    Alert.PushAlert("Group Description cannot be empty", clsAlert.Type.Warning);
                    return;
                }

                EntityUser.group_user_id = txtEditorUserGroupID.Text;
                EntityUser.group_user_desc = txtEditorUserGroupDescription.Text;
                EntityUser.entity_id = cboEditorUserGroupEntity.SelectedValue.ToString().Trim();

                if (type == "P")
                {
                    PassingArray.Add("0");
                    getUserGroupBranch();
                }
                else if (type == "B")
                {
                    foreach (DataGridViewRow row in dgBranch.Rows)
                    {
                        if (((DataGridViewCheckBoxCell)row.Cells["flag_branch"]).Value.ToString() == "True" || ((DataGridViewCheckBoxCell)row.Cells["flag_branch"]).Value.ToString() == "Y")
                        {
                            PassingArray.Add(row.Cells["branch_id"].Value.ToString().Trim());
                        }
                    }
                }
                else if (type == "M")
                {
                    foreach (DataGridViewRow row in dgMenu.Rows)
                    {
                        if (((DataGridViewCheckBoxCell)row.Cells["flag_menu"]).Value.ToString() == "True" || ((DataGridViewCheckBoxCell)row.Cells["flag_menu"]).Value.ToString() == "Y")
                        {
                            if (row.Cells["flag_add"].Value.ToString().Trim() == "True" || row.Cells["flag_add"].Value.ToString().Trim() == "Y")
                            {
                                f_add = "Y";
                            }
                            else
                            {
                                f_add = "N";
                            }
                            if (row.Cells["flag_edit"].Value.ToString().Trim() == "True" || row.Cells["flag_edit"].Value.ToString().Trim() == "Y")
                            {
                                f_edit = "Y";
                            }
                            else
                            {
                                f_edit = "N";
                            }
                            if (row.Cells["flag_delete"].Value.ToString().Trim() == "True" || row.Cells["flag_delete"].Value.ToString().Trim() == "Y")
                            {
                                f_delete = "Y";
                            }
                            else
                            {
                                f_delete = "N";
                            }
                            if (row.Cells["flag_print"].Value.ToString().Trim() == "True" || row.Cells["flag_print"].Value.ToString().Trim() == "Y")
                            {
                                f_print = "Y";
                            }
                            else
                            {
                                f_print = "N";
                            }
                            if (row.Cells["flag_export"].Value.ToString().Trim() == "True" || row.Cells["flag_export"].Value.ToString().Trim() == "Y")
                            {
                                f_export = "Y";
                            }
                            else
                            {
                                f_export = "N";
                            }
                            PassingArray.Add(row.Cells["mnu_menu_code"].Value.ToString().Trim() + "|" + f_add.Trim() + "|" + f_edit.Trim() + "|" + f_delete.Trim() + "|" + f_print.Trim() + "|" + f_export.Trim() +"|"+ EntityModul.modul_id.ToString().Trim());
                        }
                    }
                }
                bool result = Accessor.Save(EntityUser, PassingArray.ToArray(), (int)EnumState.Create, type, _Grid);
                if (result == true)
                {
                    Alert.PushAlert("Data saved", clsAlert.Type.Success);
                    txtEditorUserGroupID.Enabled = false;
                    lblPnlEditor.Text = "GROUP USER NEW : " + txtEditorUserGroupID.Text.ToString();
                    if (type == "P")
                    {
                        getUserGroupBranch();
                    }
                }
                else
                {
                    Alert.PushAlert("Save failed", clsAlert.Type.Error);
                }
            }
            if (_Grid == 1)
            {
                GSUserManagementBL.GSUsers EntityUser = new GSUserManagementBL.GSUsers();
                List<string> PassingArray = new List<string>();

                if (txtEditorUserID.Text == "")
                {
                    Alert.PushAlert("User ID cannot be empty", clsAlert.Type.Warning);
                    return;
                }

                if (txtEditorUserName.Text == "")
                {
                    Alert.PushAlert("Name cannot be empty", clsAlert.Type.Warning);
                    return;
                }

                if (txtEditorUserDescription.Text == "")
                {
                    Alert.PushAlert("Description cannot be empty", clsAlert.Type.Warning);
                    return;
                }

                if (txtEditorUserPassword.Text == "")
                {
                    Alert.PushAlert("Password cannot be empty", clsAlert.Type.Warning);
                    return;
                }

                EntityUser.group_user_id = txtEditorUserGroup.Text;
                EntityUser.user_id= txtEditorUserID.Text;
                EntityUser.name= txtEditorUserName.Text;
                EntityUser.description= txtEditorUserDescription.Text;
                EntityUser.password= txtEditorUserPassword.Text;
                EntityUser.entity_id= cboEditorUserEntity.SelectedValue.ToString().Trim();
                if (cbEditorUserActive.Checked == true)
                {
                    EntityUser.status = "Y";
                }
                else
                {
                    EntityUser.status = "N";
                }

                if (type == "P")
                {
                    PassingArray.Add("0");
                }
                else if (type == "B")
                {
                    foreach (DataGridViewRow row in dgBranch.Rows)
                    {
                        if (((DataGridViewCheckBoxCell)row.Cells["flag_branch"]).Value.ToString() == "True" || ((DataGridViewCheckBoxCell)row.Cells["flag_branch"]).Value.ToString() == "Y")
                        {
                            PassingArray.Add(row.Cells["branch_id"].Value.ToString().Trim());
                        }
                    }
                }
                else if (type == "M")
                {
                    foreach (DataGridViewRow row in dgMenu.Rows)
                    {
                        if (((DataGridViewCheckBoxCell)row.Cells["flag_menu"]).Value.ToString() == "True" || ((DataGridViewCheckBoxCell)row.Cells["flag_menu"]).Value.ToString() == "Y")
                        {
                            if (row.Cells["flag_add"].Value.ToString().Trim() == "True" || row.Cells["flag_add"].Value.ToString().Trim() == "Y")
                            {
                                f_add = "Y";
                            }
                            else
                            {
                                f_add = "N";
                            }
                            if (row.Cells["flag_edit"].Value.ToString().Trim() == "True" || row.Cells["flag_edit"].Value.ToString().Trim() == "Y")
                            {
                                f_edit = "Y";
                            }
                            else
                            {
                                f_edit = "N";
                            }
                            if (row.Cells["flag_delete"].Value.ToString().Trim() == "True" || row.Cells["flag_delete"].Value.ToString().Trim() == "Y")
                            {
                                f_delete = "Y";
                            }
                            else
                            {
                                f_delete = "N";
                            }
                            if (row.Cells["flag_print"].Value.ToString().Trim() == "True" || row.Cells["flag_print"].Value.ToString().Trim() == "Y")
                            {
                                f_print = "Y";
                            }
                            else
                            {
                                f_print = "N";
                            }
                            if (row.Cells["flag_export"].Value.ToString().Trim() == "True" || row.Cells["flag_export"].Value.ToString().Trim() == "Y")
                            {
                                f_export = "Y";
                            }
                            else
                            {
                                f_export = "N";
                            }
                            PassingArray.Add(row.Cells["mnu_menu_code"].Value.ToString().Trim() + "|" + f_add.Trim() + "|" + f_edit.Trim() + "|" + f_delete.Trim() + "|" + f_print.Trim() + "|" + f_export.Trim() + "|" + EntityModul.modul_id.ToString().Trim());
                        }
                    }
                }
                bool result = Accessor.Save(EntityUser, PassingArray.ToArray(), (int)EnumState.Create, type, _Grid);
                if (result == true)
                {
                    Alert.PushAlert("Data saved", clsAlert.Type.Success);
                    txtEditorUserID.Enabled = false;
                    lblPnlEditor.Text = "USER NEW : " + txtEditorUserID.Text.ToString();
                    if (type == "P")
                    {
                        getUserBranch();
                    }
                }
                else
                {
                    Alert.PushAlert("Save failed", clsAlert.Type.Error);
                }
            }
         }

        public Boolean Delete()
        {
            if (_APPSTATE == (int)EnumState.Create)
            {
                if (_Grid == 0)
                {
                    if (txtEditorUserGroupID.Enabled == false)
                    {
                        if (clsDialog.ShowDialog($"Cancel create user group {txtEditorUserGroupID.Text.ToString().Trim()} ?") == DialogResult.Yes)
                        {
                            Accessor.Delete(txtEditorUserGroupID.Text.ToString().Trim(), _Grid, (int)EnumState.Create);
                            pnlView.BringToFront();
                            Helper.ResetAllFormControls(pnlEditorUserGroup);
                            txtEditorUserGroupID.Enabled = true;
                            getGroupUser();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (txtEditorUserGroupID.Enabled == true)
                    {
                        pnlView.BringToFront();
                        Helper.ResetAllFormControls(pnlEditorUserGroup);
                        txtEditorUserGroupID.Enabled = true;
                        getGroupUser();
                        return true;
                    }
                }
                else if (_Grid == 1)
                {
                    if (txtEditorUserID.Enabled == false)
                    {
                        if (clsDialog.ShowDialog($"Cancel create user {txtEditorUserID.Text.ToString().Trim()} ?") == DialogResult.Yes)
                        {
                            Accessor.Delete(txtEditorUserID.Text.ToString().Trim(), _Grid, (int)EnumState.Create);
                            pnlView.BringToFront();
                            Helper.ResetAllFormControls(pnlEditorUser);
                            Helper.SetActive(navView);
                            SetState(EnumState.view);
                            txtEditorUserID.Enabled = true;
                            getGroupUser();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (txtEditorUserID.Enabled == true)
                    {
                        pnlView.BringToFront();
                        Helper.ResetAllFormControls(pnlEditorUser);
                        Helper.SetActive(navView);
                        SetState(EnumState.view);
                        txtEditorUserID.Enabled = true;
                        getGroupUser();
                        return true;
                    }
                }
            }
            else if (_APPSTATE == (int)EnumState.Update)
            {
                if (_Grid == 0)
                {
                    if (txtEditorUserGroupID.Enabled == false)
                    {
                        if (clsDialog.ShowDialog($"Cancel update user group {txtEditorUserGroupID.Text.ToString().Trim()} ?") == DialogResult.Yes)
                        {
                            pnlView.BringToFront();
                            Helper.SetActive(navView);
                            SetState(EnumState.view);
                            Helper.ResetAllFormControls(pnlEditorUserGroup);
                            txtEditorUserGroupID.Enabled = true;
                            getGroupUser();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (_Grid == 1)
                {
                    if (txtEditorUserID.Enabled == false)
                    {
                        if (clsDialog.ShowDialog($"Cancel update user group {txtEditorUserID.Text.ToString().Trim()} ?") == DialogResult.Yes)
                        {
                            pnlView.BringToFront();
                            Helper.SetActive(navView);
                            SetState(EnumState.view);
                            Helper.ResetAllFormControls(pnlEditorUser);
                            txtEditorUserID.Enabled = true;
                            getGroupUser();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else if (_APPSTATE == (int)EnumState.Delete)
            {

                if (_Grid == 0)
                {
                    if (clsDialog.ShowDialog($"Delete user group {_GroupID_Selected.ToString().Trim()} ?") == DialogResult.Yes)
                    {
                        Accessor.Delete(_GroupID_Selected.ToString().Trim(), _Grid, (int)EnumState.Delete);
                        pnlView.BringToFront();
                        Helper.ResetAllFormControls(pnlEditorUserGroup);
                        txtEditorUserGroupID.Enabled = true;
                        getGroupUser();
                        SetState(EnumState.view);
                        return true;
                    }
                    else
                    {
                        SetState(EnumState.view);
                        return false;
                    }
                }
                else if (_Grid == 1)
                {
                    if (clsDialog.ShowDialog($"Delete user {_UserID_Selected.ToString().Trim()} ?") == DialogResult.Yes)
                    {
                        Accessor.Delete(_UserID_Selected.ToString().Trim(), _Grid, (int)EnumState.Delete);
                        pnlView.BringToFront();
                        Helper.ResetAllFormControls(pnlEditorUserGroup);
                        txtEditorUserGroupID.Enabled = true;
                        getGroupUser();
                        SetState(EnumState.view);
                        return true;
                    }
                    else
                    {
                        SetState(EnumState.view);
                        return false;
                    }
                }

            }

            return true;
        }

        private void cboModul_SelectedValueChanged(object sender, EventArgs e)
        {
            EntityModul.modul_id = cboModul.SelectedValue.ToString();
            HeaderCheckBoxMenu.Checked = false;
            if (_Grid == 0)
            {
                getMenu();
            }
            else if(_Grid==1)
            {
                getMenuUser();
            }
        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBoxMenu = new CheckBox();

            HeaderCheckBoxMenu.Size = new Size(15, 15);
            HeaderCheckBoxMenu.BackColor = Color.Transparent;

            this.dgMenu.Controls.Add(HeaderCheckBoxMenu);

            HeaderCheckBoxBranch = new CheckBox();

            HeaderCheckBoxBranch.Size = new Size(15, 15);
            HeaderCheckBoxBranch.BackColor = Color.Transparent;

            this.dgBranch.Controls.Add(HeaderCheckBoxBranch);

        }
        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            Rectangle oRectangle = this.dgMenu.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBoxMenu.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBoxMenu.Height) / 2 + 1;

            HeaderCheckBoxMenu.Location = oPoint;

            Rectangle oRectangleBranch = this.dgBranch.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPointBranch = new Point();
            oPointBranch.X = oRectangle.Location.X + (oRectangleBranch.Width - HeaderCheckBoxBranch.Width) / 2 + 1;
            oPointBranch.Y = oRectangle.Location.Y + (oRectangleBranch.Height - HeaderCheckBoxBranch.Height) / 2 + 1;

            HeaderCheckBoxBranch.Location = oPointBranch;
        }

        private void dgMenu_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex == -1 && e.ColumnIndex == 0)
                    ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        private void HeaderCheckBoxClickMenu(CheckBox HCheckBox)
        {
            if (_Grid == 0)
            {
                IsHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow Row in dgMenu.Rows)
                {
                    ((DataGridViewCheckBoxCell)Row.Cells["flag_menu"]).Value = HCheckBox.Checked;
                    ((DataGridViewCheckBoxCell)Row.Cells["flag_add"]).Value = HCheckBox.Checked;
                    ((DataGridViewCheckBoxCell)Row.Cells["flag_edit"]).Value = HCheckBox.Checked;
                    ((DataGridViewCheckBoxCell)Row.Cells["flag_delete"]).Value = HCheckBox.Checked;
                    ((DataGridViewCheckBoxCell)Row.Cells["flag_print"]).Value = HCheckBox.Checked;
                    ((DataGridViewCheckBoxCell)Row.Cells["flag_export"]).Value = HCheckBox.Checked;
                }
                dgMenu.RefreshEdit();

                TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

                IsHeaderCheckBoxClicked = false;
            }
        }

        private void HeaderCheckBoxMenu_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClickMenu((CheckBox)sender);
        }

        private void RowCheckBoxClickMenu(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox.ToString() != "N")
            {

                if (RCheckBox.Value.ToString()=="Y" && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBoxMenu.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBoxMenu.Checked = true;
            }
        }
        private void dgMenu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
                RowCheckBoxClickMenu((DataGridViewCheckBoxCell)dgMenu[e.ColumnIndex, e.RowIndex]);

            var check = dgMenu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (check=="N")
            {
                dgMenu.Rows[e.RowIndex].Cells["flag_add"].Value = false;
                dgMenu.Rows[e.RowIndex].Cells["flag_edit"].Value = false;
                dgMenu.Rows[e.RowIndex].Cells["flag_delete"].Value = false;
                dgMenu.Rows[e.RowIndex].Cells["flag_print"].Value = false;
                dgMenu.Rows[e.RowIndex].Cells["flag_export"].Value = false;
            }
        }

        private void dgMenu_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgMenu.CurrentCell is DataGridViewCheckBoxCell)
                dgMenu.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void HeaderCheckBoxClickBranch(CheckBox HCheckBox)
        {
            if (_Grid == 0)
            {
                IsHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow Row in dgBranch.Rows)
                    ((DataGridViewCheckBoxCell)Row.Cells["flag_branch"]).Value = HCheckBox.Checked;

                dgBranch.RefreshEdit();

                TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

                IsHeaderCheckBoxClicked = false;
            }
        }
        private void RowCheckBoxClickBranch(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox.ToString() != "N")
            {

                if (RCheckBox.Value.ToString() == "Y" && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBoxBranch.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBoxBranch.Checked = true;
            }
        }
        private void dgBranch_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (!IsHeaderCheckBoxClicked)
            //    RowCheckBoxClickBranch((DataGridViewCheckBoxCell)dgBranch[e.ColumnIndex, e.RowIndex]);
        }

        private void dgUser_Click(object sender, EventArgs e)
        {
            _Grid = (int)SelectedGrid.Detail;
        }

        private void btnPeekPassword_Click(object sender, EventArgs e)
        {
            if (btnPeekPassword.IconColor == Color.Gray)
            {
                btnPeekPassword.IconColor = Color.Orange;
                txtEditorUserPassword.PasswordChar = '\0';
            }
            else if (btnPeekPassword.IconColor == Color.Orange)
            {
                btnPeekPassword.IconColor = Color.Gray;
                txtEditorUserPassword.PasswordChar = '●';
            }
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.DELETE, sender);
        }

        private void dgBranch_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgBranch.CurrentCell is DataGridViewCheckBoxCell)
                dgBranch.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgBranch_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }
        private void HeaderCheckBoxBranch_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClickBranch((CheckBox)sender);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (tcUserManagement.SelectedIndex == 0)
            {
                if (SaveCheck() == true) 
                {
                    Save("P");
                }
            }
            else if (tcUserManagement.SelectedIndex == 1)
            {
                Save("B");
            }
            else if (tcUserManagement.SelectedIndex == 2)
            {
                Save("M");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void tcUserManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcUserManagement.SelectedIndex)
            {
                case 0:
                    {
                        //...
                        break;
                    }
                case 1:
                    {
                        dgBranch.DataSource = null;
                        if (_APPSTATE == (int)EnumState.Create)
                        {
                            if (_Grid == 0)
                            {
                                if (txtEditorUserGroupID.Enabled == true)
                                {
                                    if (txtEditorUserGroupID.Text != "" || txtEditorUserGroupDescription.Text != "")
                                    {
                                        const string message = "Apply new user group?";
                                        const string caption = "New user group";
                                        var result = MessageBox.Show(message, caption,
                                                                     MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);

                                        if (result == DialogResult.Yes)
                                        {
                                            Save("P");
                                        }
                                    }
                                }
                                else
                                {
                                    getUserGroupBranch();
                                }
                            }
                            else if (_Grid == 1)
                            {
                                getUserBranch();
                            }
                        }
                        if (_APPSTATE == (int)EnumState.Update)
                        {
                            if (_Grid == 0)
                            {
                                getUserGroupBranch();
                            }
                            else if (_Grid == 1)
                            {
                                getUserBranch();
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (_APPSTATE == (int)EnumState.Create)
                        {
                            if (_Grid == 0)
                            {
                                if (txtEditorUserGroupID.Enabled==true)
                                {
                                    if (txtEditorUserGroupID.Text != "" || txtEditorUserGroupDescription.Text != "")
                                    {
                                        const string message = "Apply new user group?";
                                        const string caption = "New user group";
                                        var result = MessageBox.Show(message, caption,
                                                                     MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);

                                        if (result == DialogResult.Yes)
                                        {
                                            Save("P");
                                        }
                                    }
                                }
                                else
                                {
                                    getMenu();
                                }
                            }
                            else if (_Grid == 1)
                            {
                                getMenuUser();
                            }
                        }
                        if (_APPSTATE == (int)EnumState.Update)
                        {
                            if (_Grid == 0)
                            {
                                getMenu();
                            }
                            else if (_Grid == 1)
                            {
                                getMenuUser();
                            }
                        }
                        break;
                    }
            }
        }

        private void FormMode(clsEventButton.EnumAction ActionType, object sender)
        {
            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    if (_Grid == 0)
                    {
                        if (txtEditorUserGroupID.Enabled == true)
                        {
                            Helper.SetActive(sender);
                            getGroupUser();
                            pnlView.BringToFront();
                            SetState(EnumState.view);
                        }
                    }
                    if (_Grid == 1)
                    {
                        if (txtEditorUserID.Enabled == true)
                        {
                            Helper.SetActive(sender);
                            getGroupUser();
                            pnlView.BringToFront();
                            SetState(EnumState.view);
                        }
                    }
                    break;
                case clsEventButton.EnumAction.NEW:
                    if (_APPSTATE != (int)EnumState.Update)
                    {
                        if (_APPSTATE != (int)EnumState.Create)
                        {
                            SetState(EnumState.Create);
                            Helper.SetActive(sender);
                            pnlEditor.BringToFront();
                            tcUserManagement.SelectedIndex = 0;
                            AppLogic.getCombo(cboModul);
                            AppLogic.getEntity(cboEditorUserEntity);
                            AppLogic.getEntity(cboEditorUserGroupEntity);
                            if (_Grid == 0)
                            {
                                pnlEditorUserGroup.BringToFront();
                                Helper.ResetAllFormControls(pnlEditorUserGroup);
                                lblPnlEditor.Text = "GROUP USER NEW";
                                txtEditorUserGroupID.Enabled = true;
                                getMenu();
                                getUserGroupBranch();
                            }
                            else if (_Grid == 1)
                            {
                                pnlEditorUser.BringToFront();
                                Helper.ResetAllFormControls(pnlEditorUser);
                                lblPnlEditor.Text = "USER NEW";
                                txtEditorUserGroup.Enabled = false;
                                txtEditorUserGroup.Text = _GroupID_Selected;
                                txtEditorUserID.Enabled = true;
                            }
                        }
                    }
                    break;
                case clsEventButton.EnumAction.EDIT:
                    if (_APPSTATE == (int)EnumState.view)
                    {
                        if (_Grid == 0)
                        {
                            if (txtEditorUserGroupID.Enabled == true)
                            {
                                var result = MessageBox.Show("Edit User Group " + _GroupID_Selected + " ? ", "User Management",
                                                                            MessageBoxButtons.OKCancel,
                                                                            MessageBoxIcon.Question);
                                if (result == DialogResult.OK)
                                {
                                    SetState(EnumState.Update);
                                    Helper.SetActive(sender);
                                    pnlEditor.BringToFront();
                                    tcUserManagement.SelectedIndex = 0;
                                    AppLogic.getCombo(cboModul);
                                    AppLogic.getEntity(cboEditorUserEntity);
                                    AppLogic.getEntity(cboEditorUserGroupEntity);
                                    _GSUserGroup = Accessor.SearchUserGroup(_GroupID_Selected, null, "Y");
                                    pnlEditorUserGroup.BringToFront();
                                    lblPnlEditor.Text = "GROUP USER EDIT : " + _GSUserGroup.group_id;
                                    txtEditorUserGroupID.Enabled = false;
                                    txtEditorUserGroupID.Text = _GSUserGroup.group_id;
                                    txtEditorUserGroupDescription.Text = _GSUserGroup.group_desc;
                                    cboEditorUserGroupEntity.SelectedValue = _GSUserGroup.entity_id;
                                    getMenu();
                                    getUserGroupBranch();
                                }
                            }
                        }
                        else if (_Grid == 1)
                        {
                            if (txtEditorUserID.Enabled == true)
                            {
                                var result = MessageBox.Show("Edit User " + _UserID_Selected + " ? ", "User Management",
                                                                            MessageBoxButtons.OKCancel,
                                                                            MessageBoxIcon.Question);
                                if (result == DialogResult.OK)
                                {
                                    SetState(EnumState.Update);
                                    Helper.SetActive(sender);
                                    pnlEditor.BringToFront();
                                    tcUserManagement.SelectedIndex = 0;
                                    AppLogic.getCombo(cboModul);
                                    AppLogic.getEntity(cboEditorUserEntity);
                                    AppLogic.getEntity(cboEditorUserGroupEntity);
                                    _GSUser = Accessor.SearchUser(_UserID_Selected, null, "Y");
                                    pnlEditorUser.BringToFront();
                                    lblPnlEditor.Text = "USER EDIT : " + _GSUser.user_id.ToString().Trim();
                                    txtEditorUserGroup.Enabled = false;
                                    txtEditorUserGroup.Text = _GSUser.group_user_id;
                                    txtEditorUserID.Enabled = false;
                                    txtEditorUserID.Text = _GSUser.user_id;
                                    txtEditorUserName.Text = _GSUser.name;
                                    txtEditorUserDescription.Text = _GSUser.description;
                                    txtEditorUserPassword.Text = _GSUser.password;
                                    cboEditorUserEntity.Text = _GSUser.entity_id;
                                    cboEditorUserEntity.SelectedValue = _GSUser.entity_id;
                                    if (_GSUser.status.ToString() == "Y")
                                    {
                                        cbEditorUserActive.Checked = true;
                                    }
                                    else
                                    {
                                        cbEditorUserActive.Checked = false;
                                    }
                                    getUserBranch();
                                }
                            }
                        }
                    }
                    break;
                case clsEventButton.EnumAction.DELETE:
                    if (_APPSTATE == (int)EnumState.view)
                    {
                        SetState(EnumState.Delete);
                        Delete();
                    }
                    break;
            }
        }
    }
}
