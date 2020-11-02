using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.AR;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.Report.AR.ARListKuitansiSlipUnprocessAll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.AR.ARListKuitansiSlipUnprocessAll
{
    public partial class AR_ListKuitansiSlipUnprocessAllUI : Form
    {
        private static ARListKuitansiSlipUnprocessAllBL Model;
        private static ARListKuitansiSlipUnprocessAllAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static int CurrentPage, Offset, FetchLimit, TotalPage, CurrentMaxPaging = 0;
        private static List<ARListKuitansiSlipUnprocessAllBL> Data;
        private static string Seq, Period, SelectedMonth, SelectedYear;
        private static readonly string CurrentUserID = clsLogin.USERID;


        public AR_ListKuitansiSlipUnprocessAllUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(AR_ListKuitansiSlipUnprocessAllUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                Model = new ARListKuitansiSlipUnprocessAllBL();
                Helper = new clsGlobal();
                AppLogic = new ARListKuitansiSlipUnprocessAllAL(Helper);
                ClsEventButton = new clsEventButton();
                Data = new List<ARListKuitansiSlipUnprocessAllBL>();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        #region Method Non Event
        public void InitializeObject(ARListKuitansiSlipUnprocessAllBL Model)
        {
            ClearDataBinding();
            bindingObjSearch.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            txtBoxSearchInvoiceNo.DataBindings.Clear();
            txtBoxSearchKpNo.DataBindings.Clear();
            cboSearchEntity.DataBindings.Clear();
            cboSearchBranch.DataBindings.Clear();
            cboSearchDivision.DataBindings.Clear();
        }

        private void MappingDataBinding()
        {
            txtBoxSearchInvoiceNo.DataBindings.Add("Text", bindingObjSearch, "invoice", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxSearchKpNo.DataBindings.Add("Text", bindingObjSearch, "kp", true, DataSourceUpdateMode.OnPropertyChanged);
            cboSearchEntity.DataBindings.Add("SelectedValue", bindingObjSearch, "entity_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cboSearchBranch.DataBindings.Add("SelectedValue", bindingObjSearch, "branch_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cboSearchDivision.DataBindings.Add("SelectedValue", bindingObjSearch, "division_id", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void InitializeGrid(ARListKuitansiSlipUnprocessAllBL Model, bool IsPaging, bool IsRetrieveDataFromDB)
        {
            try
            {
                dataGridListKuitansiSlipUnprocessAll.AutoGenerateColumns = false;

                var DataFromDatabase = new List<ARListKuitansiSlipUnprocessAllBL>();
                if (IsPaging)
                {
                    if (CurrentPage > CurrentMaxPaging && !cbCheckAll.Checked)
                    {
                        CurrentMaxPaging = CurrentPage;
                        DataFromDatabase = AppLogic.GetAllPaging(Model, Offset);
                        foreach (var item in DataFromDatabase)
                        {
                            Data.Add(item);
                        }
                    }
                    dataGridListKuitansiSlipUnprocessAll.DataSource = null;
                    dataGridListKuitansiSlipUnprocessAll.DataSource = Data.Skip(Offset).Take(FetchLimit).ToList();
                }
                else if (IsRetrieveDataFromDB)
                {
                    Data.Clear();
                    DataFromDatabase = AppLogic.GetAllPaging(Model, Offset);
                    dataGridListKuitansiSlipUnprocessAll.DataSource = null;
                    dataGridListKuitansiSlipUnprocessAll.DataSource = DataFromDatabase;
                    if (DataFromDatabase.Count != 0)
                    {
                        foreach (var item in DataFromDatabase)
                        {
                            Data.Add(item);
                        }
                    }
                    else
                    {
                        dataGridListKuitansiSlipUnprocessAll.DataSource = null;
                        Alert.PushAlert("Data not found", clsAlert.Type.Info);
                    }
                }

                int DataCount = AppLogic.GetAllCount(Model);
                TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                lblRows.Text = "Records : " + dataGridListKuitansiSlipUnprocessAll.Rows.Count.ToString() + " Rows";
                
                if (cbCheckAll.Checked)
                {
                    CurrentMaxPaging = TotalPage;
                }
                PaginationRules();

                if (dataGridListKuitansiSlipUnprocessAll.Rows.Count != 0)
                {
                    btnProcess.Enabled = true;
                    cbCheckAll.Enabled = true;
                }
                else
                {
                    btnProcess.Enabled = false;
                    cbCheckAll.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        public void PaginationRules()
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

        public void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            Model = new ARListKuitansiSlipUnprocessAllBL()
            {
                entity_id = $"{cboSearchEntity.SelectedValue}",
                branch_id = $"{cboSearchBranch.SelectedValue}",
                division_id = $"{cboSearchDivision.SelectedValue}",
                invoice = $"{txtBoxSearchInvoiceNo.Text}",
                kp = $"{txtBoxSearchKpNo.Text}",
                seq_number = Seq
            };

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    Helper.SetActive(navView);
                    if (string.IsNullOrEmpty(Seq))
                    {
                        Model = new ARListKuitansiSlipUnprocessAllBL()
                        {
                            entity_id = string.Empty,
                            branch_id = string.Empty,
                            division_id = string.Empty,
                            invoice = string.Empty,
                            kp = string.Empty,
                        };
                    }
                    else
                    {
                        CheckGenerateKW(Model);
                        ResetPaginationRules();
                        InitializeGrid(Model, false, true);
                    }
                    GetDataComboBoxEntity();
                    GetDataComboBoxBranch();
                    GetDataComboBoxDivision();
                    GetDataComboBoxMonth();
                    GetDataComboBoxYear();
                    cboSearchMonth.SelectedValue = !string.IsNullOrEmpty(SelectedMonth) ? SelectedMonth : DateTime.Now.ToString("MM");
                    InitializeObject(Model);
                    panelView.Show();
                    pnlPrint.Hide();
                    break;

                case clsEventButton.EnumAction.PRINT:
                    var DataForPrint = AppLogicGlobal.GetReport(HelperReport.REPORT_AR_LIST_KUITANSI_SLIP_UNPROCESS_ALL(Model));
                    if (DataForPrint.Rows.Count > 0)
                    {
                        Helper.SetActive(navPrint);
                        pnlPrint.Show();
                        panelView.Hide();
                        DataTable dtCompany = AppLogicGlobal.GetCompany();
                        var report = new rptARListKuitansiSlipUnprocessAll();
                        report.SetDataSource(DataForPrint);
                        report.SetParameterValue("lblCompanyName", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); ;
                        report.SetParameterValue("lblBranch", $"{cboSearchBranch.SelectedValue}");
                        report.SetParameterValue("lblDivision", $"{cboSearchDivision.SelectedValue}");
                        rptViewer.ReportSource = report;
                    }
                    else
                    {
                        Alert.PushAlert("Data not found", clsAlert.Type.Info);
                    }
                    break;

                case clsEventButton.EnumAction.EXPORT:
                    var DataForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_AR_LIST_KUITANSI_SLIP_UNPROCESS_ALL(Model));
                    if (DataForExport.Rows.Count > 0)
                    {
                        clsExcel clExcel = new clsExcel();
                        using (var fbd = new FolderBrowserDialog())
                        {
                            DialogResult result = fbd.ShowDialog();
                            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                            {
                                var path = fbd.SelectedPath;
                                clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_LIST_KUITANSI_SLIP_UNPROCESS_ALL);
                                Alert.PushAlert("The data successfully generated", clsAlert.Type.Success);
                            }
                        }
                    }
                    else
                    {
                        Alert.PushAlert("Data not found", clsAlert.Type.Info);
                    }
                    break;
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
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void GetDataComboBoxMonth()
        {
            try
            {
                var Data = AppLogic.GetComboboxMonth();

                cboSearchMonth.DataSource = Data;
                cboSearchMonth.DisplayMember = "DisplayMember";
                cboSearchMonth.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void GetDataComboBoxYear()
        {
            try
            {
                var Data = AppLogic.GetComboboxYear();

                cboSearchYear.DataSource = Data;
                cboSearchYear.DisplayMember = "DisplayMember";
                cboSearchYear.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private int CheckGenerateKW(ARListKuitansiSlipUnprocessAllBL Model)
        {
            SelectedMonth = $"{cboSearchMonth.SelectedValue}";
            SelectedYear = $"{cboSearchYear.SelectedValue}";
            Period = $"{cboSearchYear.SelectedValue}{cboSearchMonth.SelectedValue}";
            return AppLogic.CheckGenerateKW(Model, Period);
        }

        #endregion

        private void AR_ListKuitansiSlipUnprocessAllUI_KeyDown(object sender, KeyEventArgs e)
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
                            btnExecute_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void AR_ListKuitansiSlipUnprocessAllUI_Load(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGrid(Model, true, false);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            bool IsThereAnyDataSelected = Data.Where(x => x.is_selected == true).Any();

            if (IsThereAnyDataSelected)
            {
                MessageBoxButtons ButttonDialog = MessageBoxButtons.YesNo;
                DialogResult ResultDialog = MessageBox.Show($"Are you sure process {Data.Where(x => x.is_selected == true).Count()} data?", "Warning!", ButttonDialog);
                if (ResultDialog == DialogResult.Yes)
                {
                    try
                    {
                        var Insert = AppLogic.Insert(Data.Where(x => x.is_selected == true).ToList());
                        Alert.PushAlert($"{Insert}", clsAlert.Type.Success);
                        FormMode(clsEventButton.EnumAction.VIEW);
                        InitializeGrid(Model, false, true);
                    }
                    catch (Exception ex)
                    {
                        Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
                    }
                }
            }
            else
            {
                Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGrid(Model, true, false);
        }

        private void cbCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            Model = new ARListKuitansiSlipUnprocessAllBL()
            {
                entity_id = $"{cboSearchEntity.SelectedValue}",
                branch_id = $"{cboSearchBranch.SelectedValue}",
                division_id = $"{cboSearchDivision.SelectedValue}",
                invoice = $"{txtBoxSearchInvoiceNo.Text}",
                kp = $"{txtBoxSearchKpNo.Text}",
                seq_number = Seq
            };
            Data.Clear();
            Data = AppLogic.GetAll(Model);
            dataGridListKuitansiSlipUnprocessAll.DataSource = null;

            if (Data.Count != 0)
            {
                foreach (var item in Data)
                {
                    if (cbCheckAll.Checked)
                    {
                        item.is_selected = true;
                    }
                    else
                    {
                        item.is_selected = false;
                    }
                }
            }

            dataGridListKuitansiSlipUnprocessAll.DataSource = Data.Skip(Offset).Take(FetchLimit).ToList();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.PRINT);
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.EXPORT);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                cbCheckAll.Checked = false;
                CurrentMaxPaging = 0;
                btnExecute.Enabled = false;
                var today = DateTime.Now;
                Seq = string.IsNullOrEmpty(Seq) ? $"{today.ToString("MMddhhmmss")}" : Seq;
                FormMode(clsEventButton.EnumAction.VIEW);
                btnExecute.Enabled = true;
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
                btnExecute.Enabled = true;
            }

        }
    }
}
