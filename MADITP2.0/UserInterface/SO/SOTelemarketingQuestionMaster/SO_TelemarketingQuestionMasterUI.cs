using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.SO.SOTelemarketingQuestionMaster
{
    public partial class SO_TelemarketingQuestionMasterUI : Form
    {
        private static SOTelemarketingQuestionMasterBL _Model;
        private static SOTelemarketingQuestionMasterAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName, TabActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;
        private static readonly string QuestionListCode = "QUL", FaqCode = "FAQ";
        private static readonly string CurrentUserID = clsLogin.USERID;


        public SO_TelemarketingQuestionMasterUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(SO_TelemarketingQuestionMasterUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new SOTelemarketingQuestionMasterBL();
                Helper = new clsGlobal();
                AppLogic = new SOTelemarketingQuestionMasterAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        #region Method Non Event
        private void InitializeObject(SOTelemarketingQuestionMasterBL Model)
        {
            bindingObj.DataSource = Model;
            ClearDataBinding();
            MappingDataBinding();
        }

        private void MappingDataBinding()
        {
            if (TabActiveName == QuestionListCode)
            {
                //Question List
                cboQuestionSegmentQL.DataBindings.Add("SelectedValue", bindingObj, "question_segment", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBoxQuestionQL.DataBindings.Add("Text", bindingObj, "question_desc", true, DataSourceUpdateMode.OnPropertyChanged);
                cboTypeQL.DataBindings.Add("SelectedValue", bindingObj, "question_type", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBoxQuestionItemQL.DataBindings.Add("Text", bindingObj, "question_item", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBoxIDQL.DataBindings.Add("Text", bindingObj, "question_id", true, DataSourceUpdateMode.OnPropertyChanged);
                cboQuestionFlagQL.DataBindings.Add("SelectedValue", bindingObj, "question_flag", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBoxQuestionNoQL.DataBindings.Add("Text", bindingObj, "question_no", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {
                //FAQ
                cboQuestionSegmentFAQ.DataBindings.Add("SelectedValue", bindingObj, "question_segment", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBoxQuestionFAQ.DataBindings.Add("Text", bindingObj, "question_desc", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBoxAnswerFAQ.DataBindings.Add("Text", bindingObj, "question_item", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBoxIDFAQ.DataBindings.Add("Text", bindingObj, "question_id", true, DataSourceUpdateMode.OnPropertyChanged);
                cboQuestionFlagFAQ.DataBindings.Add("SelectedValue", bindingObj, "question_flag", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBoxQuestionNoFAQ.DataBindings.Add("Text", bindingObj, "question_no", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void ClearDataBinding()
        {
            if (TabActiveName == QuestionListCode)
            {
                //Question List
                cboQuestionSegmentQL.DataBindings.Clear();
                txtBoxQuestionQL.DataBindings.Clear();
                cboTypeQL.DataBindings.Clear();
                txtBoxQuestionItemQL.DataBindings.Clear();
                txtBoxIDQL.DataBindings.Clear();
                cboQuestionFlagQL.DataBindings.Clear();
                txtBoxQuestionNoQL.DataBindings.Clear();
            }
            else
            {
                //FAQ
                cboQuestionSegmentFAQ.DataBindings.Clear();
                txtBoxQuestionFAQ.DataBindings.Clear();
                txtBoxAnswerFAQ.DataBindings.Clear();
                txtBoxIDFAQ.DataBindings.Clear();
                cboQuestionFlagFAQ.DataBindings.Clear();
                txtBoxQuestionNoFAQ.DataBindings.Clear();
            }
        }

        private void InitializeGridQuestionList(SOTelemarketingQuestionMasterBL Model)
        {
            try
            {
                Model.question_code = string.IsNullOrEmpty(Model.question_code) || Model.question_code.Contains("FAQ") ? QuestionListCode : Model.question_code;
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridQuestionList.AutoGenerateColumns = false;
                    dataGridQuestionList.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfoQL.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfoQL.Text = "Pages : - "; }
                    lblRowsQL.Text = "Records : " + dataGridQuestionList.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridQuestionList.DataSource = null;
                    Alert.PushAlert("Data not found", clsAlert.Type.Info);
                }

            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void InitializeGridFAQ(SOTelemarketingQuestionMasterBL Model)
        {
            try
            {
                Model.question_code = string.IsNullOrEmpty(Model.question_code) || Model.question_code.Contains("QUL") ? FaqCode : Model.question_code;
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridFAQ.AutoGenerateColumns = false;
                    dataGridFAQ.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfoFAQ.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfoFAQ.Text = "Pages : - "; }
                    lblRowsFAQ.Text = "Records : " + dataGridFAQ.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridFAQ.DataSource = null;
                    Alert.PushAlert("Data not found", clsAlert.Type.Info);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void PaginationRules()
        {
            if (TotalPage == 0)
            {
                btnNextQL.Enabled = false;
                btnPrevQL.Enabled = false;
                btnNextFAQ.Enabled = false;
                btnPrevFAQ.Enabled = false;
            }
            else if (TotalPage == CurrentPage)
            {
                btnNextQL.Enabled = false;
                btnPrevQL.Enabled = false;
                btnNextFAQ.Enabled = false;
                btnPrevFAQ.Enabled = false;
                if (CurrentPage > 1)
                {
                    btnPrevQL.Enabled = true;
                    btnPrevFAQ.Enabled = true;
                }
            }
            else if (CurrentPage < 2)
            {
                btnPrevQL.Enabled = false;
                btnNextQL.Enabled = true;
                btnPrevFAQ.Enabled = false;
                btnNextFAQ.Enabled = true;
            }
            else
            {
                btnPrevQL.Enabled = true;
                btnNextQL.Enabled = true;
                btnPrevFAQ.Enabled = true;
                btnNextFAQ.Enabled = true;
            }
        }

        private void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
        }

        private bool CheckLastMenuActiveIsView()
        {
            bool Result = true;

            if (FormActiveName != clsEventButton.EnumAction.VIEW.ToString())
            {
                Result = false;
                Alert.PushAlert("Back to view menu first", clsAlert.Type.Warning);
            }

            return Result;
        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            var Grid = TabActiveName == QuestionListCode ? dataGridQuestionList : dataGridFAQ;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    Helper.SetActive(navView);
                    ResetPaginationRules();
                    GetDataComboBoxQuestionSegment();
                    GetDataComboBoxQuestionType();
                    GetDataComboBoxQuestionFlag();
                    ResetComboxBox();
                    _Model = new SOTelemarketingQuestionMasterBL();
                    if (TabActiveName == QuestionListCode)
                    {
                        InitializeGridQuestionList(_Model);
                    }
                    else
                    {
                        InitializeGridFAQ(_Model);
                    }
                    panelNewFAQ.Show();
                    panelView.Show();
                    break;

                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    Helper.SetActive(navNew);
                    ResetComboxBox();
                    btnGenerateID.Enabled = true;
                    btnGenerateQL.Enabled = true;
                    _Model = new SOTelemarketingQuestionMasterBL()
                    {
                        question_segment = string.Empty,
                        question_type = string.Empty,
                        question_flag = string.Empty
                    };
                    InitializeObject(_Model);
                    if (TabActiveName == QuestionListCode)
                    {
                        panelNewQuestionList.Show();
                        panelView.Hide();
                        panelNewFAQ.Hide();
                    }
                    else
                    {
                        panelNewFAQ.Show();
                        panelView.Hide();
                    }
                    break;

                case clsEventButton.EnumAction.EDIT:
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
                            string ID = Grid.CurrentRow.Cells[TabActiveName == QuestionListCode ? "tqm_id" : "faq_tqm_id"].Value.ToString();
                            var Data = AppLogic.GetByID(ID);
                            ClearDataBinding();
                            bindingObj.DataSource = Data;
                            MappingDataBinding();
                            if (TabActiveName == QuestionListCode)
                            {
                                panelNewQuestionList.Show();
                                panelView.Hide();
                                panelNewFAQ.Hide();
                                btnSaveQL.Visible = false;
                            }
                            else
                            {
                                panelNewFAQ.Show();
                                panelView.Hide();
                                btnSaveFAQ.Visible = false;
                            }
                        }
                    }
                    break;

                case clsEventButton.EnumAction.DELETE:
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
                                    string ID = Grid.CurrentRow.Cells[TabActiveName == QuestionListCode ? "tqm_id" : "faq_tqm_id"].Value.ToString();
                                    AppLogic.Delete(ID);
                                }
                                Alert.PushAlert("Success Delete Data", clsAlert.Type.Success);
                                FormMode(clsEventButton.EnumAction.VIEW);
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
                            var DatasForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_SO_TELEMARKETING_QUESTION_MASTER(_Model));

                            if (DatasForExport.Rows.Count > 0)
                            {
                                clsExcel clExcel = new clsExcel();
                                using (var fbd = new FolderBrowserDialog())
                                {
                                    DialogResult result = fbd.ShowDialog();
                                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                    {
                                        var path = fbd.SelectedPath;

                                        DataTable DatatableForExport = new DataTable();
                                        DatatableForExport.Columns.Add("ID", typeof(string));
                                        DatatableForExport.Columns.Add("Question", typeof(string));
                                        if (TabActiveName == QuestionListCode)
                                        {
                                            DatatableForExport.Columns.Add("Type", typeof(string));
                                            DatatableForExport.Columns.Add("Question Item", typeof(string));
                                        }
                                        else
                                        {
                                            DatatableForExport.Columns.Add("Answer", typeof(string));
                                        }

                                        DatatableForExport.Columns.Add("Number", typeof(string));
                                        DatatableForExport.Columns.Add("Flag", typeof(string));

                                        foreach (DataRow item in DatasForExport.Rows)
                                        {
                                            if (TabActiveName == QuestionListCode)
                                            {
                                                DatatableForExport.Rows.Add(
                                              Helper.CastToString(item["question_id"]),
                                              Helper.CastToString(item["question_desc"]),
                                              Helper.CastToString(item["question_type"]),
                                              Helper.CastToString(item["question_item"]),
                                              Helper.CastToString(item["question_no"]),
                                              Helper.CastToString(item["question_flag"]));
                                            }
                                            else
                                            {
                                                DatatableForExport.Rows.Add(
                                            Helper.CastToString(item["question_id"]),
                                            Helper.CastToString(item["question_desc"]),
                                            Helper.CastToString(item["question_item"]),
                                            Helper.CastToString(item["question_no"]),
                                            Helper.CastToString(item["question_flag"]));
                                            }

                                        }
                                        DatasForExport = DatatableForExport;
                                        clExcel.ExportToExcel(path, DatasForExport, EnumExcel.REPORT_TELEMARKETING_QUESTION_MASTER);
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

        private void ResetComboxBox()
        {
            cboSearchQuestionSegmentQL.SelectedIndex = 0;
            cboSearchQuestionSegmentFAQ.SelectedIndex = 0;
            cboQuestionSegmentQL.SelectedIndex = 0;
            cboQuestionSegmentFAQ.SelectedIndex = 0;
            cboSearchTypeQL.SelectedIndex = 0;
            cboTypeQL.SelectedIndex = 0;
            cboSearchQuestionFlagQL.SelectedIndex = 0;
            cboSearchQuestionFlagFAQ.SelectedIndex = 0;
            cboQuestionFlagQL.SelectedIndex = 0;
            cboQuestionFlagFAQ.SelectedIndex = 0;
        }

        private void GetDataComboBoxQuestionSegment()
        {
            var Data = AppLogic.GetComboboxQuestionSegment();

            cboSearchQuestionSegmentQL.DataSource = Data;
            cboSearchQuestionSegmentQL.DisplayMember = "DisplayMember";
            cboSearchQuestionSegmentQL.ValueMember = "ValueMember";

            cboSearchQuestionSegmentFAQ.DataSource = Data;
            cboSearchQuestionSegmentFAQ.DisplayMember = "DisplayMember";
            cboSearchQuestionSegmentFAQ.ValueMember = "ValueMember";

            cboQuestionSegmentQL.DataSource = Data;
            cboQuestionSegmentQL.DisplayMember = "DisplayMember";
            cboQuestionSegmentQL.ValueMember = "ValueMember";

            cboQuestionSegmentFAQ.DataSource = Data;
            cboQuestionSegmentFAQ.DisplayMember = "DisplayMember";
            cboQuestionSegmentFAQ.ValueMember = "ValueMember";
        }

        private void GetDataComboBoxQuestionType()
        {
            var Data = AppLogic.GetComboboxQuestionType();

            cboSearchTypeQL.DataSource = Data;
            cboSearchTypeQL.DisplayMember = "DisplayMember";
            cboSearchTypeQL.ValueMember = "ValueMember";

            cboTypeQL.DataSource = Data;
            cboTypeQL.DisplayMember = "DisplayMember";
            cboTypeQL.ValueMember = "ValueMember";
        }

        private void GetDataComboBoxQuestionFlag()
        {
            var Data = AppLogic.GetComboboxQuestionFlag();

            cboSearchQuestionFlagQL.DataSource = Data;
            cboSearchQuestionFlagQL.DisplayMember = "DisplayMember";
            cboSearchQuestionFlagQL.ValueMember = "ValueMember";

            cboSearchQuestionFlagFAQ.DataSource = Data;
            cboSearchQuestionFlagFAQ.DisplayMember = "DisplayMember";
            cboSearchQuestionFlagFAQ.ValueMember = "ValueMember";

            cboQuestionFlagQL.DataSource = Data;
            cboQuestionFlagQL.DisplayMember = "DisplayMember";
            cboQuestionFlagQL.ValueMember = "ValueMember";

            cboQuestionFlagFAQ.DataSource = Data;
            cboQuestionFlagFAQ.DisplayMember = "DisplayMember";
            cboQuestionFlagFAQ.ValueMember = "ValueMember";
        }

        private bool FormValidation(SOTelemarketingQuestionMasterBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.question_segment))
            {
                IsValid = false;
                MessageValidation = "Question segment is required!";
            }
            else if (string.IsNullOrEmpty(Model.question_desc))
            {
                IsValid = false;
                MessageValidation = "Question is required!";
            }
            else if (string.IsNullOrEmpty(Model.question_type) && TabActiveName == QuestionListCode)
            {
                IsValid = false;
                MessageValidation = "Type is required!";
            }
            else if (string.IsNullOrEmpty(Model.question_item) && Model.question_type == "DDL")
            {
                IsValid = false;
                MessageValidation = TabActiveName == QuestionListCode ? "Question item is required!" : "Answer is required!";
            }
            else if (string.IsNullOrEmpty(Model.question_id))
            {
                IsValid = false;
                MessageValidation = "ID is required!";
            }
            else if (string.IsNullOrEmpty(Model.question_flag))
            {
                IsValid = false;
                MessageValidation = "Question flag is required!";
            }
            else if (Model.question_no == 0)
            {
                IsValid = false;
                MessageValidation = "Question no is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        private bool GenerateQuestionID()
        {
            bool IsSucces = false;
            try
            {
                var Model = (SOTelemarketingQuestionMasterBL)bindingObj.DataSource;

                if (Model != null)
                {
                    Model.question_type = TabActiveName == FaqCode ? $"{Model.question_segment}FAQ" : Model.question_type;

                    if (string.IsNullOrEmpty(Model.question_segment))
                    {
                        Alert.PushAlert("Please select question segment", clsAlert.Type.Error);
                    }
                    else if (string.IsNullOrEmpty(Model.question_type))
                    {
                        Alert.PushAlert("Please select question type", clsAlert.Type.Error);
                    }
                    else
                    {
                        var question_code_temp = TabActiveName == QuestionListCode ? QuestionListCode : FaqCode;
                        Model.question_code = $"{Model.question_segment}{question_code_temp}";
                        var question_id_temp = $"{Model.question_code}{Model.question_type}";
                        Model.question_id = AppLogic.GenerateNumberQuestionID(question_id_temp);
                        InitializeObject(Model);
                        IsSucces = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }

            return IsSucces;
        }


        #endregion

        private void SO_TelemarketingQuestionMasterUI_KeyDown(object sender, KeyEventArgs e)
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

        private void SO_TelemarketingQuestionMasterUI_Load(object sender, EventArgs e)
        {

            TabActiveName = QuestionListCode;
            FormMode(clsEventButton.EnumAction.VIEW);
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

        private void btnSearchQL_Click(object sender, EventArgs e)
        {
            _Model = new SOTelemarketingQuestionMasterBL()
            {
                question_code = $"{cboSearchQuestionSegmentQL.SelectedValue}{QuestionListCode}",
                question_type = $"{cboSearchTypeQL.SelectedValue}",
                question_flag = $"{cboSearchQuestionFlagQL.SelectedValue}"
            };

            InitializeGridQuestionList(_Model);
        }

        private void btnSearchFAQ_Click(object sender, EventArgs e)
        {
            _Model = new SOTelemarketingQuestionMasterBL()
            {
                question_code = $"{cboSearchQuestionSegmentFAQ.SelectedValue}{FaqCode}",
                question_flag = $"{cboSearchQuestionFlagFAQ.SelectedValue}"
            };

            InitializeGridFAQ(_Model);
        }

        private void btnSaveFAQ_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (SOTelemarketingQuestionMasterBL)bindingObj.DataSource;
                Model.question_code = $"{Model.question_segment}{FaqCode}";
                Model.create_by = CurrentUserID;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
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

        private void btnUpdateFAQ_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (SOTelemarketingQuestionMasterBL)bindingObj.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
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

        private void btnCancelFAQ_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void cboTypeQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Model = (SOTelemarketingQuestionMasterBL)bindingObj.DataSource;
            if (Model != null)
            {
                if (Model.question_type == "TXT")
                {
                    lblQuestionItemQL.Visible = false;
                    txtBoxQuestionItemQL.Visible = false;
                    lblMandatoryQuestionItem.Visible = false;
                }
                else
                {
                    lblQuestionItemQL.Visible = true;
                    txtBoxQuestionItemQL.Visible = true;
                    lblMandatoryQuestionItem.Visible = true;

                }
                txtBoxQuestionItemQL.Text = string.Empty;
                btnGenerateQL.Enabled = true;
                txtBoxIDQL.Text = string.Empty;
            }
        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            var IsSuccesGenerate = GenerateQuestionID();
            if (IsSuccesGenerate)
            {
                btnGenerateID.Enabled = false;
            }
        }

        private void txtBoxQuestionNoFAQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                Alert.PushAlert("Please input number only", clsAlert.Type.Info);
            }
        }

        private void txtBoxQuestionNoQL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                Alert.PushAlert("Please input number only", clsAlert.Type.Info);
            }
        }

        private void btnNextQL_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGridQuestionList(_Model);
        }

        private void btnPrevQL_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGridQuestionList(_Model);
        }

        private void btnNextFAQ_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGridFAQ(_Model);
        }

        private void btnPrevFAQ_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGridFAQ(_Model);
        }

        private void btnGenerateQL_Click(object sender, EventArgs e)
        {
            var IsSuccesGenerate = GenerateQuestionID();
            if (IsSuccesGenerate)
            {
                btnGenerateQL.Enabled = false;
            }
        }

        private void btnSaveQL_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (SOTelemarketingQuestionMasterBL)bindingObj.DataSource;
                Model.question_code = $"{Model.question_segment}{QuestionListCode}";
                Model.create_by = CurrentUserID;
                if (Model.question_type == "TXT")
                {
                    Model.question_item = " ";
                }
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    AppLogic.Insert(Model);
                    Alert.PushAlert("Success insert data", clsAlert.Type.Success);
                    FormMode(clsEventButton.EnumAction.VIEW);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnUpdateQL_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (SOTelemarketingQuestionMasterBL)bindingObj.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    AppLogic.Update(Model);
                    Alert.PushAlert("Success update data", clsAlert.Type.Success);
                    FormMode(clsEventButton.EnumAction.VIEW);

                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnCancelQL_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);

        }

        private void tabControlTelemarketingQuestionMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlTelemarketingQuestionMaster.SelectedIndex == 0)
            {
                TabActiveName = QuestionListCode;
            }
            else
            {
                TabActiveName = FaqCode;
            }
            FormMode(clsEventButton.EnumAction.VIEW);
        }

    }
}
