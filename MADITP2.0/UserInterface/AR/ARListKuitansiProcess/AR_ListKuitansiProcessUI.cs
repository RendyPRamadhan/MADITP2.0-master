using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.AR;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.businessLogic.GS;
using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.Report.AR.ARListKuitansiProcess;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.AR.ARKuitansiProcess
{
    public partial class AR_ListKuitansiProcessUI : Form
    {
        private static ARListKuitansiProcessBL _Model;
        private static ARListKuitansiProcessAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private readonly string FormNamePrintKwTidakProses = "PrintKwTidakProses";
        private static int CurrentPage, Offset, FetchLimit, TotalPage, Sequence;
        private static readonly string CurrentUserID = clsLogin.USERID;


        public AR_ListKuitansiProcessUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(AR_PrintKuitansiProcessUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new ARListKuitansiProcessBL();
                Helper = new clsGlobal();
                AppLogic = new ARListKuitansiProcessAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        #region Method Non Event
        private void InitializeObject(ARListKuitansiProcessBL Model)
        {
            ClearDataBinding();
            bindingObjPrintKuitansiProcess.DataSource = Model;
            MappingDataBinding();
        }

        private void MappingDataBinding()
        {
            cboEntity.DataBindings.Add("SelectedValue", bindingObjPrintKuitansiProcess, "entity", true, DataSourceUpdateMode.OnPropertyChanged);
            cboBranch.DataBindings.Add("SelectedValue", bindingObjPrintKuitansiProcess, "branch", true, DataSourceUpdateMode.OnPropertyChanged);
            cboDivision.DataBindings.Add("SelectedValue", bindingObjPrintKuitansiProcess, "division", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ClearDataBinding()
        {
            cboEntity.DataBindings.Clear();
            cboBranch.DataBindings.Clear();
            cboDivision.DataBindings.Clear();
            cboKWPeriodMonth.DataBindings.Clear();
            cboKWPeriodYear.DataBindings.Clear();
        }

        private void GetDataComboBoxKWPeriodYear()
        {
            try
            {
                GSFiscalCalendarAL AppLogicFiscalCalendar = new GSFiscalCalendarAL(Helper);
                var FiscalModel = new GSFiscalCalendarBL()
                {
                    group_id = "AR"
                };
                var Data = AppLogicFiscalCalendar.GetComboboxFiscalYear(FiscalModel, 1);

                cboKWPeriodYear.DataSource = Data;
                cboKWPeriodYear.DisplayMember = "DisplayMember";
                cboKWPeriodYear.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void GetDataComboBoxKWPeriodMonth()
        {
            try
            {
                GSFiscalCalendarAL AppLogicFiscalCalendar = new GSFiscalCalendarAL(Helper);
                cboKWPeriodMonth.DataSource = AppLogicFiscalCalendar.GetComboboxMonth();
                cboKWPeriodMonth.DisplayMember = "DisplayMember";
                cboKWPeriodMonth.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void GetDataComboBoxEntity()
        {
            try
            {
                GSEntityAL AppLogicEntity = new GSEntityAL(Helper);
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

        private void GetDataComboBoxBranch()
        {
            try
            {
                GSBranchAL AppLogicBranch = new GSBranchAL(Helper);
                var Data = AppLogicBranch.GetComboboxBranch(false);

                cboSearchBranch.DataSource = Data;
                cboSearchBranch.DisplayMember = "DisplayMember";
                cboSearchBranch.ValueMember = "ValueMember";

                cboBranch.DataSource = Data;
                cboBranch.DisplayMember = "DisplayMember";
                cboBranch.ValueMember = "ValueMember";

            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void GetDataComboBoxDivision()
        {
            try
            {
                var Data = AppLogic.GetDivision();
                cboSearchDivision.DataSource = Data;
                cboSearchDivision.DisplayMember = "DisplayMember";
                cboSearchDivision.ValueMember = "ValueMember";

                cboDivision.DataSource = Data;
                cboDivision.DisplayMember = "DisplayMember";
                cboDivision.ValueMember = "ValueMember";

            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void InitializeGrid(ARListKuitansiProcessBL Model)
        {
            try
            {
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridPrintKuitansiProcess.AutoGenerateColumns = false;
                    dataGridPrintKuitansiProcess.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                    lblRows.Text = "Records : " + dataGridPrintKuitansiProcess.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridPrintKuitansiProcess.DataSource = null;
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

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            switch (ActionType)
            {

                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    Helper.SetActive(navView);
                    ResetPaginationRules();
                    InitializeGrid(_Model);
                    _Model = new ARListKuitansiProcessBL();
                    GetDataComboBoxKWPeriodYear();
                    GetDataComboBoxKWPeriodMonth();
                    GetDataComboBoxBranch();
                    GetDataComboBoxEntity();
                    GetDataComboBoxDivision();
                    pnlPrint.Show();
                    panelNew.Show();
                    panelView.Show();
                    break;

                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    Helper.SetActive(navNew);
                    _Model = new ARListKuitansiProcessBL()
                    {
                        entity = string.Empty,
                        branch = string.Empty,
                        division = string.Empty
                    };
                    cboKWPeriodMonth.SelectedValue = string.Empty;
                    cboKWPeriodYear.SelectedValue = string.Empty;
                    InitializeObject(_Model);
                    btnProcess.Visible = true;
                    progressBarProcess.Value = 0;
                    groupBoxDataTidakTerproses.Visible = false;
                    pnlPrint.Show();
                    panelNew.Show();
                    panelView.Hide();
                    break;
                case clsEventButton.EnumAction.PRINT:
                    if (FormActiveName != FormNamePrintKwTidakProses)
                    {
                        var DataForPrint = AppLogicGlobal.GetReport(HelperReport.REPORT_AR_LIST_KUITANSI_SLIP_PROCESS_ALL(_Model));
                        if (DataForPrint.Rows.Count > 0)
                        {
                            Helper.SetActive(navPrint);
                            panelView.Hide();
                            panelNew.Hide();
                            pnlPrint.Show();
                            DataTable dtCompany = AppLogicGlobal.GetCompany();
                            rptARListKuitansiProcess report = new rptARListKuitansiProcess();
                            report.SetDataSource(DataForPrint);
                            report.SetParameterValue("lblCompanyName", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); ;
                            rptViewer.ReportSource = report;
                        }
                        else
                        {
                            Alert.PushAlert("Data not found", clsAlert.Type.Info);
                        }
                    }
                    else
                    {
                        Alert.PushAlert("Back to view menu first", clsAlert.Type.Warning);
                    }
                    break;

                case clsEventButton.EnumAction.EXPORT:
                    if (FormActiveName != FormNamePrintKwTidakProses)
                    {
                        var DataForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_AR_LIST_KUITANSI_SLIP_PROCESS_ALL(_Model));

                        if (DataForExport.Rows.Count > 0)
                        {
                            clsExcel clExcel = new clsExcel();
                            using (var fbd = new FolderBrowserDialog())
                            {
                                DialogResult result = fbd.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                {
                                    var path = fbd.SelectedPath;
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_LIST_KUITANSI_SLIP_PROCESS);
                                    Alert.PushAlert("The data successfully generated", clsAlert.Type.Success);
                                }
                            }
                        }
                        else
                        {
                            Alert.PushAlert("Data not found", clsAlert.Type.Info);
                        }
                    }
                    else
                    {
                        Alert.PushAlert("Back to view menu first", clsAlert.Type.Warning);
                    }
                    break;
            }
        }

        private bool FormValidation(ARListKuitansiProcessBL Model)
        {
            bool IsValid = true;
            string MessageValidation = string.Empty;

            if (string.IsNullOrEmpty(Model.entity))
            {
                IsValid = false;
                MessageValidation = "Entity is required!";
            }
            else if (string.IsNullOrEmpty(Model.branch))
            {
                IsValid = false;
                MessageValidation = "Branch is required!";
            }
            else if (string.IsNullOrEmpty(Model.division))
            {
                IsValid = false;
                MessageValidation = "Division is required!";
            }
            else if (string.IsNullOrEmpty(cboKWPeriodMonth.SelectedValue.ToString()))
            {
                IsValid = false;
                MessageValidation = "Month is required!";
            }
            else if (string.IsNullOrEmpty(cboKWPeriodYear.SelectedValue.ToString()))
            {
                IsValid = false;
                MessageValidation = "Year is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        private bool FaliedCorrection(ARListKuitansiProcessBL Model)
        {
            bool IsNeedCorrection = false;
            int FlagProcess = 0;
            var Today = DateTime.Now;

            Sequence = Convert.ToInt32(Today.ToString("MMddhhmmss"));
            var LastDate = new DateTime(Today.Year, Today.Month, 1);
            var CurrentDate = new DateTime(Today.Year, Today.Month, 1);

            if (RbtnLastPeriod.Checked)
            {
                FlagProcess = 100;
                CurrentDate = LastDate.AddDays(-1);
                LastDate = new DateTime(1901, 1, 1);
            }
            else if (RbtnCurrentPeriod.Checked)
            {
                FlagProcess = 1;
                CurrentDate = CurrentDate.AddMonths(1).AddDays(-1);
            }

            //delete data dengan sequence baru
            AppLogic.DeleteTdkTerprosesKW(Sequence);

            var ModelTdkProsesKW = new ARTdkTerprosesKwBL()
            {
                entity_id = Model.entity,
                branch_id = Model.branch,
                division_id = Model.division
            };
            var DataTdkTerprosesKW = AppLogic.GenerateDataTidakTerprosesKW(ModelTdkProsesKW, FlagProcess, LastDate, CurrentDate);

            foreach (var item in DataTdkTerprosesKW)
            {
                //insert data dengan sequence baru
                item.seq = Sequence;
                item.alasan = "Tanggal verifikasi masih kosong";
                AppLogic.InsertTdkTerprosesKW(item);
            }

            ModelTdkProsesKW.seq = Sequence;

            //get data yang baru di insert by sequence
            var Data = AppLogic.GetAllDataTdkTerprosesKW(ModelTdkProsesKW);

            if (Data.Count > 0)
            {
                IsNeedCorrection = true;
            }

            if (IsNeedCorrection)
            {
                listViewTidakTerproses.Items.Clear();
                listViewTidakTerproses.View = View.Details;
                listViewTidakTerproses.GridLines = true;
                foreach (var item in Data)
                {
                    var Row = new string[]
                    {
                        item.customer_id,
                        item.so_number,
                        item.item_number,
                        item.alasan
                    };
                    var Lvi = new ListViewItem(Row);
                    Lvi.Tag = item;
                    listViewTidakTerproses.Items.Add(Lvi);
                }
                groupBoxDataTidakTerproses.Visible = true;

                //popup confirm
                MessageBoxButtons ButttonDialog = MessageBoxButtons.YesNo;
                DialogResult ResultDialog = MessageBox.Show("Batalkan Proses ?", "Warning!", ButttonDialog);
                if (ResultDialog == DialogResult.Yes)
                {
                    IsNeedCorrection = true;
                }
                else
                {
                    IsNeedCorrection = false;
                    groupBoxDataTidakTerproses.Visible = false;
                }
            }
            progressBarProcess.Value = 40;
            return IsNeedCorrection;
        }

        private void ProcessKW()
        {
            string MaxPeriod = $"{cboKWPeriodYear.SelectedValue}{cboKWPeriodMonth.SelectedValue}";

            AppLogic.UpdateKWProcessFlag();

            var ModelArkwProcessFlag = new ARKwProcessFlagBL()
            {
                entity = $"{cboSearchEntity.SelectedValue}",
                branch = $"{cboSearchBranch.SelectedValue}",
                division = $"{cboSearchDivision.SelectedValue}"
            };

            var Data = AppLogic.GetAllKWProcessFlag(ModelArkwProcessFlag);

            foreach (var item in Data)
            {
                DateTime LastDate = new DateTime(item.year_last, Convert.ToInt32(item.last_period_process), 1);
                DateTime CurrentDate = new DateTime(item.year_current, Convert.ToInt32(item.current_period_process), 1);

                int FlagProcess;
                if (RbtnLastPeriod.Checked)
                {
                    if (CurrentDate.ToString("yyyyMM") == LastDate.ToString("yyyyMM"))
                    {
                        CurrentDate = CurrentDate.AddDays(1).AddMonths(1);
                        LastDate = new DateTime(1901, 1, 1);
                    }
                    FlagProcess = 100;
                    AppLogic.GenerateKWLast(item, LastDate, CurrentDate,
                            new DateTime(item.year_last, Convert.ToInt32(item.last_period_process), 1),
                            new DateTime(item.year_current, Convert.ToInt32(item.current_period_process), 1),
                            CurrentUserID, FlagProcess, MaxPeriod);

                }
                else if (RbtnCurrentPeriod.Checked)
                {
                    if (CurrentDate.ToString("yyyyMM") == LastDate.ToString("yyyyMM"))
                    {
                        CurrentDate = CurrentDate.AddDays(-1).AddMonths(1);
                        FlagProcess = 1;
                        AppLogic.GenerateKW(item, LastDate, CurrentDate,
                            new DateTime(item.year_last, Convert.ToInt32(item.last_period_process), 1),
                            new DateTime(item.year_current, Convert.ToInt32(item.current_period_process), 1),
                            CurrentUserID, FlagProcess);
                    }
                }
            }
            progressBarProcess.Value = 60;
        }

        #endregion

        private void AR_PrintKuitansiProcessUI_KeyDown(object sender, KeyEventArgs e)
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
                            btnSearch_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.SAVE:
                        {
                            btnProcess_Click(null, null);
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

        private void AR_PrintKuitansiProcessUI_Load(object sender, EventArgs e)
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

        private void btnProcess_Click(object sender, EventArgs e)
        {
            progressBarProcess.Maximum = 100;
            progressBarProcess.Value = 0;

            btnProcess.Enabled = false;

            int QtyKW = 0;

            var Model = (ARListKuitansiProcessBL)bindingObjPrintKuitansiProcess.DataSource;

            try
            {
                var IsValid = FormValidation(Model);
                if (IsValid)
                {
                    var IsNeedCorrection = FaliedCorrection(Model);

                    if (IsNeedCorrection)
                    {
                        var KwTidakProses = new ARTdkTerprosesKwBL()
                        {
                            seq = Sequence
                        };
                        var Data = AppLogicGlobal.GetReport(HelperReport.REPORT_AR_KW_TIDAK_PROCESS(KwTidakProses));
                        if (Data.Rows.Count > 0)
                        {
                            Helper.SetActive(navPrint);
                            FormActiveName = FormNamePrintKwTidakProses;
                            pnlPrint.Show();
                            panelView.Hide();
                            panelNew.Hide();

                            DataTable dtCompany = AppLogicGlobal.GetCompany();
                            var report = new rptARKwTidakProcess();
                            report.SetDataSource(Data);
                            report.SetParameterValue("lblCompanyName", dtCompany.Rows[0]["c_company"].ToString().ToUpper());
                            report.SetParameterValue("lblBranchID", $"{cboBranch.SelectedValue}");
                            report.SetParameterValue("lblDivisionID", $"{cboDivision.SelectedValue}");
                            rptViewer.ReportSource = report;
                        }
                        else
                        {
                            Alert.PushAlert("Data not found", clsAlert.Type.Info);
                        }
                    }
                    else
                    {
                        QtyKW = AppLogic.GetARKuitansiCount(Model);
                        progressBarProcess.Value = 80;

                        ProcessKW();

                        QtyKW = AppLogic.GetARKuitansiCount(Model) - QtyKW;
                        progressBarProcess.Value = 100;
                        MessageBox.Show($"Kuitansi yang terproses sebanyak {QtyKW}");
                    }
                }
                progressBarProcess.Value = 0;
                btnProcess.Enabled = true;
            }
            catch (Exception ex)
            {
                progressBarProcess.Value = 0;
                btnProcess.Enabled = true;
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Model = new ARListKuitansiProcessBL()
            {
                entity = $"{cboSearchEntity.SelectedValue}",
                branch = $"{cboSearchBranch.SelectedValue}",
                division = $"{cboSearchDivision.SelectedValue}"
            };
            ResetPaginationRules();
            InitializeGrid(_Model);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }
    }
}