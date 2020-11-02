using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.Report.GS.GSFiscalCalendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.GS.GSFiscalCalendar
{
    public partial class GS_FiscalCalendarUI : Form
    {
        private static GSFiscalCalendarBL _Model;
        private static GSFiscalCalendarAL AppLogic;
        private static GSEntityAL AppLogicEntity;
        private static GSModuleAL AppLogicModule;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;

        public GS_FiscalCalendarUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(GS_FiscalCalendarUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new GSFiscalCalendarBL();
                Helper = new clsGlobal();
                AppLogic = new GSFiscalCalendarAL(Helper);
                AppLogicEntity = new GSEntityAL(Helper);
                AppLogicModule = new GSModuleAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        private void GS_FiscalCalendarUI_KeyDown(object sender, KeyEventArgs e)
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

        #region Method Non Event

        private void InitializeGrid(GSFiscalCalendarBL Model)
        {
            try
            {
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridFiscalCalendar.AutoGenerateColumns = false;
                    dataGridFiscalCalendar.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                    lblRows.Text = "Records : " + dataGridFiscalCalendar.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridFiscalCalendar.DataSource = null;
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
            var Grid = dataGridFiscalCalendar;

            _Model = new GSFiscalCalendarBL()
            {
                entity_id = $"{cboSearchEntity.SelectedValue}",
                group_id = $"{cboSearchModule.SelectedValue}",
                fiscal_year = $"{txtBoxSearchFiscalPeriod.Text}"
            };

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    GetDataComboBoxEntity();
                    GetDataComboBoxModule();
                    ResetPaginationRules();
                    Helper.SetActive(navView);
                    Grid.DataSource = null;
                    cboSearchEntity.SelectedValue = string.Empty;
                    cboSearchModule.SelectedValue = string.Empty;
                    txtBoxSearchFiscalPeriod.Text = string.Empty;
                    pnlPrint.Show();
                    panelNew.Show();
                    panelView.Show();
                    break;

                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    Helper.SetActive(navNew);
                    panelNew.Show();
                    panelView.Hide();
                    cboEntity.Enabled = true;
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    txtBoxFiscalPeriod.Text = string.Empty;
                    cboEntity.SelectedValue = string.Empty;
                    cboModule.SelectedValue = string.Empty;

                    List<GSFiscalCalendarBL> ListFiscalClendar = new List<GSFiscalCalendarBL>();

                    for (int i = 1; i <= 12; i++)
                    {
                        _Model = new GSFiscalCalendarBL()
                        {
                            period = i
                        };
                        ListFiscalClendar.Add(_Model);
                    }
                    dataGridFormEditor.AutoGenerateColumns = false;
                    dataGridFormEditor.DataSource = ListFiscalClendar;
                    break;

                case clsEventButton.EnumAction.EDIT:
                    if (Grid.Rows.Count == 0)
                    {
                        Alert.PushAlert("No data", clsAlert.Type.Info);
                    }
                    else if (CheckLastMenuActiveIsView())
                    {
                        FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
                        Helper.SetActive(navEdit);
                        panelNew.Show();
                        panelView.Hide();
                        btnUpdate.Visible = true;
                        btnSave.Visible = false;
                        _Model = new GSFiscalCalendarBL();
                        cboEntity.Enabled = false;
                        txtBoxFiscalPeriod.Text = txtBoxSearchFiscalPeriod.Text;
                        dataGridFormEditor.AutoGenerateColumns = false;
                        dataGridFormEditor.DataSource = Grid.DataSource;
                    }
                    break;

                case clsEventButton.EnumAction.DELETE:
                    if (CheckLastMenuActiveIsView())
                    {
                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            MessageBoxButtons ButttonDialog = MessageBoxButtons.YesNo;
                            DialogResult ResultDialog = MessageBox.Show("Are You Sure?", "Warning!", ButttonDialog);
                            if (ResultDialog == DialogResult.Yes)
                            {
                                var DataGrid = (List<GSFiscalCalendarBL>)Grid.DataSource;
                                foreach (var item in DataGrid)
                                {
                                    var Model = new GSFiscalCalendarBL();
                                    Model.group_id = item.group_id;
                                    Model.fiscal_year = item.fiscal_year;
                                    AppLogic.Delete(Model);
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
                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            var DataForPrint = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_FISCAL_CALENDAR(_Model));

                            if (DataForPrint.Rows.Count > 0)
                            {
                                FormActiveName = clsEventButton.EnumAction.PRINT.ToString();
                                Helper.SetActive(navPrint);
                                panelNew.Hide();
                                string _TCode = AppLogicGlobal.GetTCode(this.Name.ToString());
                                DataTable dtCompany = AppLogicGlobal.GetCompany();
                                rptGSFiscalCalendar report = new rptGSFiscalCalendar();
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
                            var DataForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_FISCAL_CALENDAR(_Model));

                            if (DataForExport.Rows.Count > 0)
                            {
                                clsExcel clExcel = new clsExcel();
                                using (var fbd = new FolderBrowserDialog())
                                {
                                    DialogResult result = fbd.ShowDialog();
                                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                    {
                                        var path = fbd.SelectedPath;
                                        clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_FISCAL_CALENDAR);
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

        private void GetDataComboBoxEntity()
        {
            try
            {
                var Data = AppLogicEntity.GetComboboxEntity(false);

                cboSearchEntity.DataSource = Data;
                cboSearchEntity.DisplayMember = "DisplayMember";
                cboSearchEntity.ValueMember = "ValueMember";

                cboEntity.DataSource = Data;
                cboEntity.DisplayMember = "DisplayMember";
                cboEntity.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }

        }

        private void GetDataComboBoxModule()
        {
            try
            {
                var Data = AppLogicModule.GetComboboxModule();

                cboSearchModule.DataSource = Data;
                cboSearchModule.DisplayMember = "DisplayMember";
                cboSearchModule.ValueMember = "ValueMember";

                cboModule.DataSource = Data;
                cboModule.DisplayMember = "DisplayMember";
                cboModule.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private bool FormValidation(List<GSFiscalCalendarBL> ListData)
        {
            bool IsValid = true;
            string MessageValidation = "";

            foreach (var item in ListData)
            {
                if (string.IsNullOrEmpty(item.entity_id))
                {
                    IsValid = false;
                    MessageValidation = "Entity is required!";
                }
                else if (string.IsNullOrEmpty(item.group_id))
                {
                    IsValid = false;
                    MessageValidation = "Module is required!";
                }
                else if (string.IsNullOrEmpty(item.fiscal_year))
                {
                    IsValid = false;
                    MessageValidation = "Year is required!";
                }
                else if (item.begining_date == null)
                {
                    IsValid = false;
                    MessageValidation = $"Period {item.period}, begining date is required!";
                }
                else if (item.ending_date == null)
                {
                    IsValid = false;
                    MessageValidation = $"Period {item.period}, ending date is required!";
                }

                if (!IsValid)
                {
                    Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                    break;
                }
            }
            return IsValid;
        }

        private bool SearchValidation(GSFiscalCalendarBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.entity_id))
            {
                IsValid = false;
                MessageValidation = "Please select entity";
            }
            else if (string.IsNullOrEmpty(Model.group_id))
            {
                IsValid = false;
                MessageValidation = "Please select module";
            }
            else if (string.IsNullOrEmpty(Model.fiscal_year))
            {
                IsValid = false;
                MessageValidation = "Please input fiscal year";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }
            return IsValid;
        }

        #endregion

        private void GS_FiscalCalendarUI_Load(object sender, EventArgs e)
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

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _Model = new GSFiscalCalendarBL()
            {
                entity_id = $"{cboSearchEntity.SelectedValue}",
                group_id = $"{cboSearchModule.SelectedValue}",
                fiscal_year = $"{txtBoxSearchFiscalPeriod.Text}"
            };

            var IsValid = SearchValidation(_Model);

            if (IsValid)
            {
                InitializeGrid(_Model);
            }
            else
            {
                dataGridFiscalCalendar.DataSource = null;
            }
        }

        private void dataGridFormEditor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (FormActiveName == clsEventButton.EnumAction.NEW.ToString()
                && dataGridFormEditor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var BeginDate = $"{dataGridFormEditor.Rows[e.RowIndex].Cells[1].Value}";
                var EndDate = $"{dataGridFormEditor.Rows[e.RowIndex].Cells[2].Value}";

                bool IsValid = true;
                string MessageValidation = string.Empty;

                if (e.ColumnIndex == 2 && string.IsNullOrEmpty(BeginDate))
                {
                    IsValid = false;
                    MessageValidation = "Please fill in the begin date first";
                }
                else if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) &&
                    !string.IsNullOrEmpty(EndDate) && !string.IsNullOrEmpty(BeginDate))
                {
                    if (Convert.ToDateTime(EndDate) < Convert.ToDateTime(BeginDate))
                    {
                        IsValid = false;
                        MessageValidation = "Ending date must be greater than begining date";
                    }
                }

                if (!IsValid)
                {
                    Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                    dataGridFormEditor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }
                else if (IsValid && !string.IsNullOrEmpty(EndDate) && !string.IsNullOrEmpty(BeginDate))
                {
                    dataGridFormEditor.Rows[e.RowIndex].Cells[3].Value = (int)(Convert.ToDateTime(EndDate) - Convert.ToDateTime(BeginDate)).TotalDays;
                    dataGridFormEditor.Rows[e.RowIndex].Cells[4].Value = "F";
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var SelectedEntity = cboEntity.SelectedValue.ToString();
                var SelectedModule = cboModule.SelectedValue.ToString();
                var FiscalYear = txtBoxFiscalPeriod.Text;

                var Model = new GSFiscalCalendarBL()
                {
                    entity_id = SelectedEntity,
                    group_id = SelectedModule,
                    fiscal_year = FiscalYear
                };

                var SearchData = AppLogic.GetAll(Model);

                if (SearchData.Count() != 0)
                {
                    Alert.PushAlert($"Data for entity, module and year already exists", clsAlert.Type.Error);
                }
                else
                {
                    var Data = (List<GSFiscalCalendarBL>)dataGridFormEditor.DataSource;

                    foreach (var item in Data)
                    {
                        item.entity_id = SelectedEntity;
                        item.group_id = SelectedModule;
                        item.fiscal_year = FiscalYear;
                    }

                    bool IsValid = FormValidation(Data);

                    if (IsValid)
                    {
                        foreach (var item in Data)
                        {
                            AppLogic.Insert(item);
                        }
                        Alert.PushAlert("Success insert data", clsAlert.Type.Success);
                        FormMode(clsEventButton.EnumAction.VIEW);
                    }
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
                var SelectedEntity = cboEntity.SelectedValue.ToString();
                var SelectedModule = cboModule.SelectedValue.ToString();
                var FiscalYear = txtBoxFiscalPeriod.Text;
                var Data = (List<GSFiscalCalendarBL>)dataGridFormEditor.DataSource;

                foreach (var item in Data)
                {
                    item.entity_id = SelectedEntity;
                    item.group_id = SelectedModule;
                    item.fiscal_year = FiscalYear;
                }

                bool IsValid = FormValidation(Data);

                if (IsValid)
                {
                    foreach (var item in Data)
                    {
                        AppLogic.Update(item);
                    }
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
    }
}
