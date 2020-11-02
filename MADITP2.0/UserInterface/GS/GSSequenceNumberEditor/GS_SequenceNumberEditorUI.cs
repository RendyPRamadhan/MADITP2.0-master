using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.Report.GS.GSSequenceNumberEditor;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.GS.GSSequenceNumberEditor
{
    public partial class GS_SequenceNumberEditorUI : Form
    {
        private static GSSequenceNumberEditorBL _Model;
        private static GSSequenceNumberEditorAL AppLogic;
        private static GSModuleAL AppLogicModule;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;

        public GS_SequenceNumberEditorUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(GS_SequenceNumberEditorUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new GSSequenceNumberEditorBL();
                Helper = new clsGlobal();
                AppLogic = new GSSequenceNumberEditorAL(Helper);
                AppLogicModule = new GSModuleAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }


        #region Method Non Event
        private void InitializeObject(GSSequenceNumberEditorBL Model)
        {
            ClearDataBinding();
            bindingObjSequenceNumberEditor.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            txtBoxSequenceNoIdentifier.DataBindings.Clear();
            txtBoxNextSequenceNumber.DataBindings.Clear();
            txtBoxMinumumNumber.DataBindings.Clear();
            txtBoxMaximumNumber.DataBindings.Clear();
        }

        private void MappingDataBinding()
        {
            txtBoxSequenceNoIdentifier.DataBindings.Add("Text", bindingObjSequenceNumberEditor, "id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxNextSequenceNumber.DataBindings.Add("Text", bindingObjSequenceNumberEditor, "last_number", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxMinumumNumber.DataBindings.Add("Text", bindingObjSequenceNumberEditor, "minimum", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxMaximumNumber.DataBindings.Add("Text", bindingObjSequenceNumberEditor, "maximum", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void InitializeGrid(GSSequenceNumberEditorBL Model)
        {
            try
            {
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridSequenceNumberEditor.AutoGenerateColumns = false;
                    dataGridSequenceNumberEditor.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                    lblRows.Text = "Records : " + dataGridSequenceNumberEditor.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridSequenceNumberEditor.DataSource = null;
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
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
            }
            else if (TotalPage == CurrentPage)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                if (CurrentPage > 1)
                {
                    btnPrev.Enabled = true;
                }
            }
            else if (CurrentPage < 2)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
        }

        private void GetDataComboBoxModule()
        {
            cbSearchModuleTable.DataSource = AppLogicModule.GetComboboxModule();
            cbSearchModuleTable.DisplayMember = "DisplayMember";
            cbSearchModuleTable.ValueMember = "ValueMember";
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
            var Grid = dataGridSequenceNumberEditor;

            _Model = new GSSequenceNumberEditorBL()
            {
                id = $"{cbSearchModuleTable.SelectedValue}"
            };

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    Helper.SetActive(navView);
                    GetDataComboBoxModule();
                    ResetPaginationRules();
                    _Model = new GSSequenceNumberEditorBL();
                    InitializeGrid(_Model);
                    cbSearchModuleTable.SelectedValue = string.Empty;
                    pnlPrint.Show();
                    panelNew.Show();
                    panelView.Show();
                    break;

                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    Helper.SetActive(navNew);
                    _Model = new GSSequenceNumberEditorBL();
                    InitializeObject(_Model);
                    panelNew.Show();
                    panelView.Hide();
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
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
                            panelNew.Show();
                            panelView.Hide();
                            btnUpdate.Visible = true;
                            btnSave.Visible = false;
                            txtBoxSequenceNoIdentifier.ReadOnly = true;
                            string ID = Grid.CurrentRow.Cells["id"].Value.ToString();
                            var DataFromDb = AppLogic.GetByID(ID);
                            InitializeObject(DataFromDb);
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
                                    var ID = Grid.SelectedRows[i].Cells["id"].Value.ToString();
                                    AppLogic.Delete(ID);
                                }
                                Alert.PushAlert("Success Delete Data", clsAlert.Type.Success);
                                FormMode(clsEventButton.EnumAction.VIEW);
                            }
                        }
                    }
                    break;

                case clsEventButton.EnumAction.PRINT:
                    if (CheckLastMenuActiveIsView())
                    {
                        var DataForPrint = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_SEQUENCE_NUMBER_EDITOR(_Model));

                        if (DataForPrint.Rows.Count > 0)
                        {
                            FormActiveName = clsEventButton.EnumAction.PRINT.ToString();
                            Helper.SetActive(navPrint);
                            panelNew.Hide();
                            string _TCode = AppLogicGlobal.GetTCode(this.Name.ToString());
                            DataTable dtCompany = AppLogicGlobal.GetCompany();

                            rptGSSequenceNumberEditor report = new rptGSSequenceNumberEditor();
                            report.SetDataSource(DataForPrint);
                            report.SetParameterValue("lblCompanyName", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); ;
                            report.SetParameterValue("lblTCode", _TCode.ToUpper());
                            rptViewer.ReportSource = report;
                        }
                        else
                        {
                            Alert.PushAlert("Data not found", clsAlert.Type.Info);
                        }
                    }
                    break;

                case clsEventButton.EnumAction.EXPORT:
                    if (CheckLastMenuActiveIsView())
                    {
                        var DataForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_SEQUENCE_NUMBER_EDITOR(_Model));

                        if (DataForExport.Rows.Count > 0)
                        {
                            clsExcel clExcel = new clsExcel();
                            using (var fbd = new FolderBrowserDialog())
                            {
                                DialogResult result = fbd.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                {
                                    var path = fbd.SelectedPath;
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_SEQUENCE_NUMBER_EDITOR);
                                    Alert.PushAlert("The data successfully generated", clsAlert.Type.Success);
                                }
                            }
                        }
                        else
                        {
                            Alert.PushAlert("Data not found", clsAlert.Type.Info);
                        }
                    }
                    break;
            }
        }

        private bool FormValidation(GSSequenceNumberEditorBL Model)
        {
            bool IsValid = true;
            string MessageValidation = string.Empty;

            if (string.IsNullOrEmpty(Model.id))
            {
                IsValid = false;
                MessageValidation = "ID is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        #endregion

        private void GS_SequenceNumberEditorUI_KeyDown(object sender, KeyEventArgs e)
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
                    case clsEventButton.EnumAction.PRINT:
                        {
                            navPrint_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.EXPORT:
                        {
                            navExport_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.SEARCH:
                        {
                            buttonSearch_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.SAVE:
                        {
                            btnSave_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.CANCEL:
                        {
                            btnCancel_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void GS_SequenceNumberEditorUI_Load(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
            KeyPreview = true;
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

        private void navPrint_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.PRINT);
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.EXPORT);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (GSSequenceNumberEditorBL)bindingObjSequenceNumberEditor.DataSource;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (GSSequenceNumberEditorBL)bindingObjSequenceNumberEditor.DataSource;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void txtBoxMaximumNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                Alert.PushAlert("Must be numeric", clsAlert.Type.Warning);
            }
        }

        private void txtBoxMinumumNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                Alert.PushAlert("Must be numeric", clsAlert.Type.Warning);
            }
        }

        private void txtBoxNextSequenceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                Alert.PushAlert("Must be numeric", clsAlert.Type.Warning);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGrid(_Model);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGrid(_Model);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var SelectedModule = cbSearchModuleTable.SelectedValue.ToString();

            _Model = new GSSequenceNumberEditorBL()
            {
                id = SelectedModule
            };
            InitializeGrid(_Model);
        }
    }
}
