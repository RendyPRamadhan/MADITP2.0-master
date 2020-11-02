using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.businessLogic.RC;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MADITP2._0.userInterface.RC
{
    public partial class RCMasterLevelUI : Form
    {
        private SOMasterDivisionDA MasterDivision;
        private RCMasterLevelAL Accessor;
        private RCMasterLevelBL _SelectedData;
        private clsGlobal Helper;
        private clsAlert Alert;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;

        public RCMasterLevelUI()
        {
            _FetchLimit = 20;
            _CurrentPage = 1;
            _TotalPage = 0;

            InitializeComponent();
        }

        private void SetState(EnumState enumState)
        {
            this._APPSTATE = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    btnSave.Text = "Delete";
                    break;
                default:
                    break;
            }
        }

        private void RCMasterLevelUI_Load(object sender, EventArgs e)
        {
            Helper = new clsGlobal();
            Accessor = new RCMasterLevelAL(Helper);
            Alert = new clsAlert();
            MasterDivision = new SOMasterDivisionDA();

            DrawDatatable();
            DrawBreakLevelCombobox();
            DrawStatusRepCombobox();
            DrawAchievementTypeCombobox();
            DrawCertHoldCombobox();
            DrawDivisionCombobox();
            DrawDivisionFilterCombobox();

            PanelFormList.BringToFront();
        }

        private void Pagination(Boolean onloading = false)
        {
            if (_TotalPage == 0)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                return;
            }

            if (_TotalPage == _CurrentPage)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                if (_CurrentPage > 1)
                {
                    btnPrev.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = false;

                return;
            }

            if (_CurrentPage < 2)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }

            return;
        }

        private void DrawDatatable()
        {
            RCMasterLevelBL mLevel = null;
            string search = null;
            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            if(cmbFilterDivision.SelectedValue != null)
            {
                mLevel = new RCMasterLevelBL()
                {
                    Lc_division_id = cmbFilterDivision.SelectedValue.ToString()
                };
            }

            DataTable dt = Accessor.Read(EnumFilter.GET_WITH_PAGING, mLevel, _CurrentPage, _FetchLimit, search);
            dgvResult.Columns.Clear();
            dgvResult.DataSource = dt;

            DataTable rslt = Accessor.Read(EnumFilter.GET_COUNT_ROWS, mLevel, _CurrentPage, _FetchLimit, search);
            _TotalPage = (int) Math.Ceiling(Convert.ToDouble(rslt.Rows[0]["jumlah"]) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;

            Pagination();
        }

        private void FormFilterHandler()
        {
            _CurrentPage = 1;
            Pagination(true);
            DrawDatatable();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _CurrentPage--;
            Pagination(true);
            DrawDatatable();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _CurrentPage++;
            Pagination(true);
            DrawDatatable();
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _SelectedData = new RCMasterLevelBL();
                    _SelectedData.Lc_id = Convert.ToInt32(dgvResult.Rows[e.RowIndex].Cells["lc_id"].Value);
                    _SelectedData.Lc_level_id = Convert.ToString(dgvResult.Rows[e.RowIndex].Cells["lc_level_id"].Value);
                    _SelectedData.Lc_level_description = Convert.ToString(dgvResult.Rows[e.RowIndex].Cells["lc_level_description"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormFilterHandler();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            Helper.ResetAllFormControls(PanelFormCreate);
            Helper.ResetAllFormControls(tabPage1);
            Helper.ResetAllFormControls(tabPage2);
            SetState(EnumState.Create);
            PanelFormCreate.BringToFront();
        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back && txtFilterSearch.Text == string.Empty)
            {
                FormFilterHandler();
            }
        }

        private void PanelFormCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(_APPSTATE == EnumState.Create)
            {
                ActionInsertLevelCode();
                return;
            }

            if (_APPSTATE == EnumState.Update)
            {
                try
                {
                    ActionUpdateLevelCode();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                    Alert.PushAlert(err.Message.ToString(), clsAlert.Type.Error);
                }
                return;
            }

            if (_APPSTATE == EnumState.Delete)
            {
                Boolean info = Accessor.Delete(_SelectedData.Lc_id);
                if (info == false)
                {
                    Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                    return;
                }

                Alert.PushAlert("Deleted!", clsAlert.Type.Success);
                DrawDatatable();

                _SelectedData = null;
                PanelFormList.BringToFront();
                return;
            }

            Alert.PushAlert("Invalid APPSTATE", clsAlert.Type.Error);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Update);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Choose the data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.GetLevelCode(_SelectedData.Lc_id);
            if (_SelectedData == null)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            PrepareFormEditing(_SelectedData);
        }

        private void PrepareFormEditing(RCMasterLevelBL levelCode)
        {
            txtLevelID.Text = levelCode.Lc_level_id;
            txtLevelDescription.Text = levelCode.Lc_level_description;
            txtCHWAmount.Text = levelCode.Lc_cwh_amount.ToString();
            txtUserDefined1.Text = levelCode.Lc_user_defined_1.ToString();
            txtUserDefined2.Text = levelCode.Lc_user_defined_2;
            txtTotalSU.Text = levelCode.Lc_q_total_su.ToString();
            txtTotalSet.Text = levelCode.Lc_q_total_set.ToString();
            txtTotalSalesValue.Text = levelCode.Lc_q_total_sales_value.ToString();
            txtTotalPV.Text = levelCode.Lc_q_total_pv.ToString();
            txtTotalBV.Text = levelCode.Lc_q_total_bv.ToString();
            txtTotalReqruited.Text = levelCode.Lc_q_total_member_recruited.ToString();
            txtTotalDirectMember.Text = levelCode.Lc_q_total_direct_member.ToString();
            txtTotolNewCustomer.Text = levelCode.Lc_q_total_new_customer.ToString();
            txtTotalPoint1.Text = Convert.ToString(levelCode.Lc_q_total_point_1);
            txtTotalPoint2.Text = Convert.ToString(levelCode.Lc_q_total_point_2);
            txtLengthPeriode.Text = levelCode.Lc_q_within_length_of_period.ToString();
            txtMinAchievement.Text = levelCode.Lc_q_min_achievement_per_month.ToString();

            cmbAchievementType.SelectedValue = levelCode.Lc_q_achievement_type.Trim();
            cmbBreakLevel.SelectedValue = levelCode.Lc_break_level.Trim();
            cmbCertHold.SelectedValue = levelCode.Lc_q_certificate_hold.Trim();
            cmbStatusRep.SelectedValue = levelCode.Lc_status.Trim();
            cmbDivision.SelectedValue = levelCode.Lc_division_id.Trim();

            PanelFormCreate.BringToFront();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Delete);
            if(_SelectedData == null)
            {
                Alert.PushAlert("Choose the data from the table!", clsAlert.Type.Warning);
                return;
            }

            RCMasterLevelBL levelCode = Accessor.GetLevelCode(_SelectedData.Lc_id);
            if (levelCode == null)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            PrepareFormEditing(levelCode);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView_Click(null, null);
        }

        private void ActionInsertLevelCode()
        {
            if (string.IsNullOrEmpty(cmbDivision.SelectedValue.ToString()))
            {
                Alert.PushAlert("Division is empty!", clsAlert.Type.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                Alert.PushAlert("Level ID is empty!", clsAlert.Type.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtLevelDescription.Text))
            {
                Alert.PushAlert("Level description is empty!", clsAlert.Type.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbBreakLevel.SelectedValue.ToString()))
            {
                Alert.PushAlert("Break level is empty!", clsAlert.Type.Warning);
                return;
            }


            if (string.IsNullOrEmpty(cmbStatusRep.SelectedValue.ToString()))
            {
                Alert.PushAlert("Status Rep is empty!", clsAlert.Type.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtCHWAmount.Text))
            {
                Alert.PushAlert("CHW amount is empty!", clsAlert.Type.Warning);
                return;
            }

            RCMasterLevelBL item = new RCMasterLevelBL();
            item.Lc_division_id = cmbDivision.SelectedValue.ToString();

            item.Lc_level_id = txtLevelID.Text;
            item.Lc_level_description = txtLevelDescription.Text;

            item.Lc_break_level = cmbBreakLevel.SelectedValue.ToString();
            item.Lc_status = cmbStatusRep.SelectedValue.ToString();

            item.Lc_cwh_amount = Helper.CastToInt(txtCHWAmount.Text);
            item.Lc_user_defined_1 = Helper.CastToInt(txtUserDefined1.Text);
            item.Lc_user_defined_2 = txtUserDefined2.Text.ToString();
            item.Lc_date_created = DateTime.Now;
            item.Lc_last_date_update = DateTime.Now;

            item.Lc_user_id = clsLogin.USERID;
            item.Lc_q_achievement_type = cmbAchievementType.SelectedValue.ToString();

            item.Lc_q_total_su = Helper.CastToInt(txtTotalSU.Text);
            item.Lc_q_total_set = Helper.CastToInt(txtTotalSet.Text);
            item.Lc_q_total_sales_value = Helper.CastToInt(txtTotalSalesValue.Text);
            item.Lc_q_total_pv = Helper.CastToInt(txtTotalPV.Text);
            item.Lc_q_total_bv = Helper.CastToInt(txtTotalBV.Text);
            item.Lc_q_total_member_recruited = Helper.CastToInt(txtTotalReqruited.Text);
            item.Lc_q_total_direct_member = Helper.CastToInt(txtTotalDirectMember.Text);
            item.Lc_q_total_new_customer = Helper.CastToInt(txtTotolNewCustomer.Text);
            item.Lc_q_total_point_1 = Helper.CastToInt(txtTotalPoint1.Text);
            item.Lc_q_total_point_2 = Helper.CastToInt(txtTotalPoint2.Text);
            item.Lc_q_within_length_of_period = Helper.CastToInt(txtLengthPeriode.Text);
            item.Lc_q_min_achievement_per_month = Helper.CastToInt(txtMinAchievement.Text);

            item.Lc_q_certificate_hold = cmbCertHold.SelectedValue.ToString();

            btnSave.Enabled = false;
            Boolean info = Accessor.Post(item);
            if (!info)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                btnSave.Enabled = true;
                return;
            }

            _SelectedData = null;
            Helper.ResetAllFormControls(PanelFormCreate);

            btnSave.Enabled = true;
            Alert.PushAlert("Success", clsAlert.Type.Success);
            PanelFormList.BringToFront();
            DrawDatatable();
        }

        private void ActionUpdateLevelCode()
        {
            if (string.IsNullOrEmpty(cmbDivision.SelectedValue.ToString()))
            {
                Alert.PushAlert("Division is empty!", clsAlert.Type.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtLevelID.Text))
            {
                Alert.PushAlert("Level ID is empty!", clsAlert.Type.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtLevelDescription.Text))
            {
                Alert.PushAlert("Level description is empty!", clsAlert.Type.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbBreakLevel.SelectedValue.ToString()))
            {
                Alert.PushAlert("Break level is empty!", clsAlert.Type.Warning);
                return;
            }


            if (string.IsNullOrEmpty(cmbStatusRep.SelectedValue.ToString()))
            {
                Alert.PushAlert("Status Rep is empty!", clsAlert.Type.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtCHWAmount.Text))
            {
                Alert.PushAlert("CHW amount is empty!", clsAlert.Type.Warning);
                return;
            }

            RCMasterLevelBL item = _SelectedData;
            item.Lc_division_id = cmbDivision.SelectedValue.ToString();

            item.Lc_level_id = txtLevelID.Text;
            item.Lc_level_description = txtLevelDescription.Text;

            item.Lc_break_level = cmbBreakLevel.SelectedValue.ToString();
            item.Lc_status = cmbStatusRep.SelectedValue.ToString();

            item.Lc_cwh_amount = Helper.CastToInt(txtCHWAmount.Text);
            item.Lc_user_defined_1 = Helper.CastToInt(txtUserDefined1.Text);
            item.Lc_user_defined_2 = txtUserDefined2.Text.ToString();
            item.Lc_last_date_update = DateTime.Now;

            item.Lc_user_id = clsLogin.USERID;
            item.Lc_q_achievement_type = cmbAchievementType.SelectedValue.ToString();

            item.Lc_q_total_su = Helper.CastToInt(txtTotalSU.Text);
            item.Lc_q_total_set = Helper.CastToInt(txtTotalSet.Text);
            item.Lc_q_total_sales_value = Helper.CastToInt(txtTotalSalesValue.Text);
            item.Lc_q_total_pv = Helper.CastToInt(txtTotalPV.Text);
            item.Lc_q_total_bv = Helper.CastToInt(txtTotalBV.Text);
            item.Lc_q_total_member_recruited = Helper.CastToInt(txtTotalReqruited.Text);
            item.Lc_q_total_direct_member = Helper.CastToInt(txtTotalDirectMember.Text);
            item.Lc_q_total_new_customer = Helper.CastToInt(txtTotolNewCustomer.Text);
            item.Lc_q_total_point_1 = Helper.CastToInt(txtTotalPoint1.Text);
            item.Lc_q_total_point_2 = Helper.CastToInt(txtTotalPoint2.Text);
            item.Lc_q_within_length_of_period = Helper.CastToInt(txtLengthPeriode.Text);
            item.Lc_q_min_achievement_per_month = Helper.CastToInt(txtMinAchievement.Text);

            item.Lc_q_certificate_hold = cmbCertHold.SelectedValue.ToString();

            btnSave.Enabled = false;
            Boolean info = Accessor.Put(item.Lc_id, item);
            if (!info)
            {
                btnSave.Enabled = true;
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Helper.ResetAllFormControls(PanelFormCreate);

            btnSave.Enabled = true;
            Alert.PushAlert("Success", clsAlert.Type.Success);
            PanelFormList.BringToFront();
            DrawDatatable();
        }

        private void DrawBreakLevelCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            ds.Insert(1, new ComboBoxViewModel() { DisplayMember = "Yes", ValueMember = "Y" });
            ds.Insert(2, new ComboBoxViewModel() { DisplayMember = "No", ValueMember = "N" });

            cmbBreakLevel.DataSource = ds;
            cmbBreakLevel.DisplayMember = "DisplayMember";
            cmbBreakLevel.ValueMember = "ValueMember";
        }

        private void DrawStatusRepCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            ds.Insert(1, new ComboBoxViewModel() { DisplayMember = "R | Rep", ValueMember = "R" });
            ds.Insert(2, new ComboBoxViewModel() { DisplayMember = "M | Manager", ValueMember = "M" });

            cmbStatusRep.DataSource = ds;
            cmbStatusRep.DisplayMember = "DisplayMember";
            cmbStatusRep.ValueMember = "ValueMember";
        }

        private void DrawAchievementTypeCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            ds.Insert(1, new ComboBoxViewModel() { DisplayMember = "GS | Group Selling", ValueMember = "GS" });
            ds.Insert(2, new ComboBoxViewModel() { DisplayMember = "PS | Personal Selling", ValueMember = "PS" });
            ds.Insert(3, new ComboBoxViewModel() { DisplayMember = "DS | Direct Selling", ValueMember = "DS" });

            cmbAchievementType.DataSource = ds;
            cmbAchievementType.DisplayMember = "DisplayMember";
            cmbAchievementType.ValueMember = "ValueMember";
        }

        private void DrawCertHoldCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            ds.Insert(1, new ComboBoxViewModel() { DisplayMember = "BSS", ValueMember = "BSS" });
            ds.Insert(2, new ComboBoxViewModel() { DisplayMember = "MDP", ValueMember = "MDP" });
            ds.Insert(3, new ComboBoxViewModel() { DisplayMember = "OCT", ValueMember = "OCT" });
            ds.Insert(3, new ComboBoxViewModel() { DisplayMember = "OT", ValueMember = "OT" });
            ds.Insert(3, new ComboBoxViewModel() { DisplayMember = "PDP", ValueMember = "PDP" });
            ds.Insert(3, new ComboBoxViewModel() { DisplayMember = "POS", ValueMember = "POS" });
            ds.Insert(3, new ComboBoxViewModel() { DisplayMember = "SOP", ValueMember = "SOP" });

            cmbCertHold.DataSource = ds;
            cmbCertHold.DisplayMember = "DisplayMember";
            cmbCertHold.ValueMember = "ValueMember";
        }

        private void DrawDivisionFilterCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            DataTable data = MasterDivision.Read(EnumFilter.GET_ALL, null);
            int index = 1;

            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            foreach (DataRow item in data.Rows)
            {
                ds.Insert(index, new ComboBoxViewModel() { DisplayMember = Convert.ToString(item["division_name"]).Trim(), ValueMember = Convert.ToString(item["division_code"]).Trim() });
                index++;
            }

            cmbFilterDivision.DataSource = ds;
            cmbFilterDivision.DisplayMember = "DisplayMember";
            cmbFilterDivision.ValueMember = "ValueMember";
        }

        private void DrawDivisionCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            DataTable data = MasterDivision.Read(EnumFilter.GET_ALL, null);
            int index = 1;

            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            foreach (DataRow item in data.Rows)
            {
                ds.Insert(index, new ComboBoxViewModel() { DisplayMember = Convert.ToString(item["division_name"]).Trim(), ValueMember = Convert.ToString(item["division_code"]).Trim() });
                index++;
            }

            cmbDivision.DataSource = ds;
            cmbDivision.DisplayMember = "DisplayMember";
            cmbDivision.ValueMember = "ValueMember";
        }

        private void txtFilterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }

            btnSearch_Click(null, null);
        }
    }
}
