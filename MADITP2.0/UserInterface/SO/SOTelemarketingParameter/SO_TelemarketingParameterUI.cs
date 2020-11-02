using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.SO.SOTelemarketingParameter
{
    public partial class SO_TelemarketingParameterUI : Form
    {
        private static SOTelemarketingParameterBL _Model;
        private static SOTelemarketingParameterAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName, TabActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;
        private static readonly string CallStatusSettingCode = "CALLSTAT", TargetCallCode = "TGTCALL";
        private static readonly string CurrentUserID = clsLogin.USERID;

        public SO_TelemarketingParameterUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(SO_TelemarketingParameterUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new SOTelemarketingParameterBL();
                Helper = new clsGlobal();
                AppLogic = new SOTelemarketingParameterAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        #region Method Non Event
        private void InitializeObject(SOTelemarketingParameterBL Model)
        {
            bindingObj.DataSource = Model;
            ClearDataBinding();
            MappingDataBinding();
        }

        private void MappingDataBinding()
        {
            cboPhase.DataBindings.Add("SelectedValue", bindingObj, "parameter_code", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxStatusDesc.DataBindings.Add("Text", bindingObj, "parameter_desc", true, DataSourceUpdateMode.OnPropertyChanged);
            cboCategory.DataBindings.Add("SelectedValue", bindingObj, "parameter_category", true, DataSourceUpdateMode.OnPropertyChanged);

            Binding CbDropBind = new Binding("checked", bindingObj, "parameter_drop");
            CbDropBind.Format += new ConvertEventHandler(BindingCheckBoxFromDatabase);
            cbDrop.DataBindings.Add(CbDropBind);

        }

        private void ClearDataBinding()
        {
            cboPhase.DataBindings.Clear();
            txtBoxStatusDesc.DataBindings.Clear();
            cboCategory.DataBindings.Clear();
            cbDrop.DataBindings.Clear();
        }

        private void BindingCheckBoxFromDatabase(object sender, ConvertEventArgs e)
        {
            string Value = e.Value?.ToString() ?? "";

            if (Value == "Y")
                e.Value = true;
            else if (Value == "N" || string.IsNullOrEmpty(Value))
                e.Value = false;
        }

        private string BindingCheckBoxFromForms(string Flag)
        {
            if (Flag == "True")
                Flag = "Y";
            else if (Flag == "False")
                Flag = "N";

            return Flag;
        }

        private bool FormValidation(SOTelemarketingParameterBL Model)
        {
            bool IsValid = true;
            string MessageValidation = string.Empty;

            if (string.IsNullOrEmpty(Model.parameter_code))
            {
                IsValid = false;
                MessageValidation = "Phase is required!";
            }
            else if (string.IsNullOrEmpty(Model.parameter_desc))
            {
                IsValid = false;
                MessageValidation = "Status desc is required!";
            }
            else if (string.IsNullOrEmpty(Model.parameter_category))
            {
                IsValid = false;
                MessageValidation = "Category is required!";
            }
            else if (string.IsNullOrEmpty(Model.parameter_drop))
            {
                IsValid = false;
                MessageValidation = "Drop is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        public bool CheckLastMenuActiveIsView()
        {
            bool Result = true;

            if (FormActiveName != clsEventButton.EnumAction.VIEW.ToString())
            {
                Result = false;
                Alert.PushAlert("Back to view menu first", clsAlert.Type.Warning);
            }

            return Result;
        }

        public bool CheckLastTabActiveIsCallStatusSetting()
        {
            bool Result = true;

            if (TabActiveName != CallStatusSettingCode)
            {
                Result = false;
                Alert.PushAlert("Go to tab call status setting first", clsAlert.Type.Info);
            }

            return Result;
        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            var Grid = dataGridCallStatusSetting;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    Helper.SetActive(navView);
                    GetDataComboBoxPhase();
                    GetDataComboBoxCategory();
                    ResetPaginationRules();
                    ResetComboxBox();
                    txtBoxTargetPerDay.Text = string.Empty;
                    _Model = new SOTelemarketingParameterBL();
                    if (TabActiveName == CallStatusSettingCode)
                    {
                        InitializeGridCallStatusSetting(_Model);
                    }
                    else
                    {
                        InitializeGridTargetCall(_Model);
                    }
                    panelView.Show();
                    break;

                case clsEventButton.EnumAction.NEW:
                    if (CheckLastTabActiveIsCallStatusSetting())
                    {
                        panelView.Hide();
                        FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                        Helper.SetActive(navNew);
                        ResetComboxBox();
                        _Model = new SOTelemarketingParameterBL()
                        {
                            parameter_category = string.Empty,
                            parameter_code = string.Empty
                        };
                        InitializeObject(_Model);
                    }
                    break;

                case clsEventButton.EnumAction.EDIT:
                    if (CheckLastTabActiveIsCallStatusSetting())
                    {
                        if (CheckLastMenuActiveIsView())
                        {
                            if (Grid.Rows.Count == 0)
                            {
                                Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                            }
                            else if (Grid.SelectedRows.Count > 1)
                            {
                                Alert.PushAlert("Please Dont Select Multiple Data", clsAlert.Type.Info);
                            }
                            else
                            {
                                FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
                                Helper.SetActive(navEdit);
                                btnSaveCST.Visible = false;
                                string ID = Grid.CurrentRow.Cells["ID"].Value.ToString();
                                var Data = AppLogic.GetByID(ID);
                                panelView.Hide();
                                InitializeObject(Data);
                            }
                        }
                    }
                    break;

                case clsEventButton.EnumAction.DELETE:
                    if (CheckLastTabActiveIsCallStatusSetting())
                    {
                        if (CheckLastMenuActiveIsView())
                        {
                            if (Grid.Rows.Count == 0)
                            {
                                Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                            }
                            else if (Grid.SelectedRows.Count == 0)
                            {
                                Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
                            }
                            else
                            {
                                MessageBoxButtons ButttonDialog = MessageBoxButtons.YesNo;
                                DialogResult ResultDialog = MessageBox.Show("Are You Sure?", "Warning!", ButttonDialog);
                                if (ResultDialog == DialogResult.Yes)
                                {
                                    for (int i = 0; i < Grid.SelectedRows.Count; i++)
                                    {
                                        string ID = Grid.CurrentRow.Cells["ID"].Value.ToString();
                                        AppLogic.Delete(ID);
                                    }
                                    Alert.PushAlert("Success Delete Data", clsAlert.Type.Success);
                                    FormMode(clsEventButton.EnumAction.VIEW);
                                }
                            }
                        }
                    }
                    break;

                case clsEventButton.EnumAction.EXPORT:
                    if (CheckLastMenuActiveIsView())
                    {
                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            var DataForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_SO_TELEMARKETING_PARAMETER(_Model));

                            if (DataForExport.Rows.Count > 0)
                            {
                                clsExcel clExcel = new clsExcel();
                                using (var fbd = new FolderBrowserDialog())
                                {
                                    DialogResult result = fbd.ShowDialog();
                                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                    {
                                        var path = fbd.SelectedPath;
                                        if (TabActiveName != CallStatusSettingCode)
                                        {
                                            DataTable DataTargetCall = new DataTable();
                                            DataTargetCall.Columns.Add("Target Call / Day", typeof(int));
                                            DataTargetCall.Columns.Add("Flag", typeof(string));
                                            DataTargetCall.Columns.Add("Created Date", typeof(string));

                                            foreach (DataRow item in DataForExport.Rows)
                                            {
                                                DataTargetCall.Rows.Add(
                                                    Helper.CastToInt(item["parameter_desc"]),
                                                    Helper.CastToString(item["parameter_drop"]) == "I" ? "Inactive" : "Active",
                                                    Helper.CastToString(item["create_date"])
                                                    );
                                            }
                                            DataForExport = DataTargetCall;
                                        }
                                        clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_TELEMARKETING_PARAMETER);
                                        Alert.PushAlert("The data successfully generated", clsAlert.Type.Success);
                                    }
                                }
                            }
                            else
                            {
                                Alert.PushAlert("Data not found", clsAlert.Type.Info);
                            }
                        }
                    }
                    break;
            }
        }

        private void PaginationRules()
        {
            if (TotalPage == 0)
            {
                btnNextCSS.Enabled = false;
                btnPrevCSS.Enabled = false;

                btnNextTC.Enabled = false;
                btnPrevTC.Enabled = false;
            }
            else if (TotalPage == CurrentPage)
            {
                btnNextCSS.Enabled = false;
                btnPrevCSS.Enabled = false;

                btnNextTC.Enabled = false;
                btnPrevTC.Enabled = false;

                if (CurrentPage > 1)
                {
                    btnPrevCSS.Enabled = true;
                    btnPrevTC.Enabled = true;
                }
            }
            else if (CurrentPage < 2)
            {
                btnPrevCSS.Enabled = false;
                btnNextCSS.Enabled = true;

                btnPrevTC.Enabled = false;
                btnNextTC.Enabled = true;
            }
            else
            {
                btnPrevCSS.Enabled = true;
                btnNextCSS.Enabled = true;

                btnPrevTC.Enabled = true;
                btnNextTC.Enabled = true;
            }
        }

        private void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
        }

        private void InitializeGridCallStatusSetting(SOTelemarketingParameterBL Model)
        {
            try
            {
                Model.parameter_id = string.IsNullOrEmpty(Model.parameter_id) ? CallStatusSettingCode : Model.parameter_id;
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridCallStatusSetting.AutoGenerateColumns = false;
                    dataGridCallStatusSetting.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfoCSS.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfoCSS.Text = "Pages : - "; }
                    lblRowsCSS.Text = "Records : " + dataGridCallStatusSetting.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridCallStatusSetting.DataSource = null;
                    Alert.PushAlert("Data not found", clsAlert.Type.Info);
                }
              
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void InitializeGridTargetCall(SOTelemarketingParameterBL Model)
        {
            try
            {
                Model.parameter_id = string.IsNullOrEmpty(Model.parameter_id) ? TargetCallCode : Model.parameter_id;
                var data = AppLogic.GetAllPaging(Model, Offset).OrderByDescending(x => x.create_date).ToList();
                if (data.Count > 0)
                {
                    dataGridTargetCall.AutoGenerateColumns = false;
                    dataGridTargetCall.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfoTC.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfoTC.Text = "Pages : - "; }
                    lblRowsTC.Text = "Records : " + dataGridTargetCall.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridTargetCall.DataSource = null;
                    Alert.PushAlert("Data not found", clsAlert.Type.Info);
                }
                
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Info);
            }
        }

        private void GetDataComboBoxPhase()
        {
            var Data = AppLogic.GetComboboxQuestionPhase();

            cboSearchPhase.DataSource = Data;
            cboSearchPhase.DisplayMember = "DisplayMember";
            cboSearchPhase.ValueMember = "ValueMember";

            cboPhase.DataSource = Data;
            cboPhase.DisplayMember = "DisplayMember";
            cboPhase.ValueMember = "ValueMember";
        }

        private void GetDataComboBoxCategory()
        {
            var Data = AppLogic.GetComboboxQuestionCategory();

            cboSearchCategory.DataSource = Data;
            cboSearchCategory.DisplayMember = "DisplayMember";
            cboSearchCategory.ValueMember = "ValueMember";

            cboCategory.DataSource = Data;
            cboCategory.DisplayMember = "DisplayMember";
            cboCategory.ValueMember = "ValueMember";
        }

        private void ResetComboxBox()
        {
            cboSearchCategory.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            cboSearchPhase.SelectedIndex = 0;
            cboPhase.SelectedIndex = 0;
        }

        #endregion

        private void SO_TelemarketingParameterUI_Load(object sender, EventArgs e)
        {
            TabActiveName = CallStatusSettingCode;
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void SO_TelemarketingParameterUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {
                clsEventButton.EnumAction _ActionType = ClsEventButton.getEventType(e.KeyCode.ToString());

                switch (_ActionType)
                {
                    case clsEventButton.EnumAction.VIEW:
                        {
                            navView_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.NEW:
                        {
                            navNew_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.EDIT:
                        {
                            navEdit_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.DELETE:
                        {
                            navDelete_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.EXPORT:
                        {
                            navExport_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.NEW);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.EDIT);
        }

        private void btnSearchCST_Click(object sender, EventArgs e)
        {
            _Model = new SOTelemarketingParameterBL()
            {
                parameter_code = $"{cboSearchPhase.SelectedValue}",
                parameter_category = $"{cboSearchCategory.SelectedValue}"
            };

            InitializeGridCallStatusSetting(_Model);
        }

        private void btnSaveTargetCall_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons ButttonDialog = MessageBoxButtons.YesNo;
                DialogResult ResultDialog = MessageBox.Show("Current Setting Will Be Inactive, Do You Want Continue?", "Warning!", ButttonDialog);
                if (ResultDialog == DialogResult.Yes)
                {
                    _Model = new SOTelemarketingParameterBL()
                    {
                        parameter_desc = txtBoxTargetPerDay.Text,
                        parameter_code = "INFCSTS",
                        parameter_id = "TGTCALL",
                        parameter_category = "TARGET CALL",
                        parameter_drop = "A",
                        create_by = CurrentUserID
                    };

                    AppLogic.Insert(_Model);
                    Alert.PushAlert("Success insert data", clsAlert.Type.Success);
                    navView_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnSaveCST_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (SOTelemarketingParameterBL)bindingObj.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    Model.parameter_id = "CALLSTAT";
                    Model.create_by = CurrentUserID;
                    Model.parameter_drop = BindingCheckBoxFromForms(Model.parameter_drop);
                    AppLogic.Insert(Model);
                    Alert.PushAlert("Success insert data", clsAlert.Type.Success);
                    navView_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnUpdateCST_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (SOTelemarketingParameterBL)bindingObj.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    Model.parameter_drop = BindingCheckBoxFromForms(Model.parameter_drop);
                    AppLogic.Update(Model);
                    Alert.PushAlert("Success update data", clsAlert.Type.Success);
                    navView_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnCancelCST_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void btnNextCSS_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGridCallStatusSetting(_Model);
        }

        private void btnPrevCSS_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGridCallStatusSetting(_Model);
        }

        private void btnNextTC_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGridTargetCall(_Model);
        }

        private void txtBoxTargetPerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                Alert.PushAlert("Please input number only", clsAlert.Type.Info);
            }
        }

        private void btnPrevTC_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGridTargetCall(_Model);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.DELETE);
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.EXPORT);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControlTelemarketingParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlTelemarketingParameter.SelectedIndex == 0)
            {
                TabActiveName = CallStatusSettingCode;
                FormMode(clsEventButton.EnumAction.VIEW);
                navNew.Enabled = true;
                navEdit.Enabled = true;
                navDelete.Enabled = true;
            }
            else
            {
                TabActiveName = TargetCallCode;
                FormMode(clsEventButton.EnumAction.VIEW);
                navNew.Enabled = false;
                navEdit.Enabled = false;
                navDelete.Enabled = false;
            }
        }

    }
}
