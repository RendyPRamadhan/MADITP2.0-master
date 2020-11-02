using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.AR;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.Report.AR.ARReprintSlipKuitansiProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.AR.ARKuitansiProcess
{
    public partial class AR_ReprintSlipKuitansiProcessUI : Form
    {

        private static ARReprintSlipKuitansiProcessBL Model;
        private static ARReprintSlipKuitansiProcessAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private const string MenuPrintKuitansi = "PrintKuitansi", MenuPrintListKuitansi = "PrintListKuitansi";
        private static int CurrentPage, Offset, FetchLimit, TotalPage, CurrentMaxPaging = 0;
        private static List<ARReprintSlipKuitansiProcessBL> Data;

        public AR_ReprintSlipKuitansiProcessUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(AR_ReprintSlipKuitansiProcessUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                Model = new ARReprintSlipKuitansiProcessBL();
                Helper = new clsGlobal();
                AppLogic = new ARReprintSlipKuitansiProcessAL(Helper);
                ClsEventButton = new clsEventButton();
                Data = new List<ARReprintSlipKuitansiProcessBL>();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        #region Method Non Event
        private void InitializeObject(ARReprintSlipKuitansiProcessBL Model)
        {
            ClearDataBinding();
            bindingObjReprintSlipKuitansiProcess.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            cboSearchBranch.DataBindings.Clear();
            cboSearchCollector.DataBindings.Clear();
            cboSearchDivision.DataBindings.Clear();
            cboSearchEntity.DataBindings.Clear();
            txtBoxSearchInvoiceNo.DataBindings.Clear();
            dtpProcessDateFrom.DataBindings.Clear();
            dtpProcessDateTo.DataBindings.Clear();
        }

        private void MappingDataBinding()
        {
            cboSearchBranch.DataBindings.Add("SelectedValue", bindingObjReprintSlipKuitansiProcess, "ak_branch_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cboSearchCollector.DataBindings.Add("SelectedValue", bindingObjReprintSlipKuitansiProcess, "cm_collector_name", true, DataSourceUpdateMode.OnPropertyChanged);
            cboSearchDivision.DataBindings.Add("SelectedValue", bindingObjReprintSlipKuitansiProcess, "ak_division_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cboSearchEntity.DataBindings.Add("SelectedValue", bindingObjReprintSlipKuitansiProcess, "ak_entity_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxSearchInvoiceNo.DataBindings.Add("Text", bindingObjReprintSlipKuitansiProcess, "ak_item_number", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpProcessDateFrom.DataBindings.Add("Value", bindingObjReprintSlipKuitansiProcess, "ak_processing_date_from", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpProcessDateTo.DataBindings.Add("Value", bindingObjReprintSlipKuitansiProcess, "ak_processing_date_to", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void InitializeGrid(ARReprintSlipKuitansiProcessBL Model, bool IsPaging, bool IsRetrieveDataFromDB)
        {
            try
            {
                dataGridReprintSlipKuitansiProcess.AutoGenerateColumns = false;
                List<ARReprintSlipKuitansiProcessBL> DataFromDatabase = new List<ARReprintSlipKuitansiProcessBL>();
                if (IsPaging)
                {
                    if (CurrentPage > CurrentMaxPaging && !cbCheckAll.Checked)
                    {
                        CurrentMaxPaging = CurrentPage;
                        DataFromDatabase = AppLogic.GetAllPaging(Model, Offset);
                        dataGridReprintSlipKuitansiProcess.DataSource = DataFromDatabase;
                        foreach (var item in DataFromDatabase)
                        {
                            Data.Add(item);
                        }
                    }
                    dataGridReprintSlipKuitansiProcess.DataSource = null;
                    dataGridReprintSlipKuitansiProcess.DataSource = Data.Skip(Offset).Take(FetchLimit).ToList();
                }
                else if (IsRetrieveDataFromDB)
                {
                    Data.Clear();
                    DataFromDatabase = AppLogic.GetAllPaging(Model, Offset);
                    dataGridReprintSlipKuitansiProcess.DataSource = null;
                    dataGridReprintSlipKuitansiProcess.DataSource = DataFromDatabase;
                    if (DataFromDatabase.Count != 0)
                    {
                        foreach (var item in DataFromDatabase)
                        {
                            Data.Add(item);
                        }
                    }
                    else
                    {
                        dataGridReprintSlipKuitansiProcess.DataSource = null;
                        Alert.PushAlert("Data not found", clsAlert.Type.Info);
                    }
                }

                int DataCount = AppLogic.GetAllCount(Model);
                TotalPage = (int)Math.Ceiling((double)DataCount / FetchLimit);
                if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                lblRows.Text = "Records : " + dataGridReprintSlipKuitansiProcess.Rows.Count.ToString() + " Rows";

                if (cbCheckAll.Checked)
                {
                    CurrentMaxPaging = TotalPage;
                }

                if (dataGridReprintSlipKuitansiProcess.Rows.Count != 0)
                {
                    cbCheckAll.Enabled = true;
                }
                else
                {
                    cbCheckAll.Enabled = false;
                }

                PaginationRules();
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Info);
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
                  
                    Helper.SetActive(navView);
                    GetDataComboBoxEntity();
                    GetDataComboBoxBranch();
                    GetDataComboBoxDivision();
                    GetDataComboBoxCollection();
                    ResetPaginationRules();
                    Model = new ARReprintSlipKuitansiProcessBL()
                    {
                        ak_entity_id = Model.ak_entity_id == null ? string.Empty : Model.ak_entity_id,
                        ak_branch_id = Model.ak_branch_id == null ? string.Empty : Model.ak_branch_id,
                        ak_division_id = Model.ak_division_id == null ? string.Empty : Model.ak_division_id,
                        cm_collector_name = Model.cm_collector_name == null ? string.Empty : Model.cm_collector_name,
                        ak_item_number = Model.ak_item_number == null ? string.Empty : Model.ak_item_number,
                        ak_processing_date_from = Model.ak_processing_date_from == null ? DateTime.Now.ToString() : Model.ak_processing_date_from,
                        ak_processing_date_to = Model.ak_processing_date_to == null ? DateTime.Now.ToString() : Model.ak_processing_date_to
                    };
                    InitializeObject(Model);
                    pnlPrint.Show();
                    panelView.Show();
                    break;
                case clsEventButton.EnumAction.PRINT:
                    if (FormActiveName == MenuPrintKuitansi)
                    {
                        Alert.PushAlert("Back to view menu first", clsAlert.Type.Warning);
                    }
                    else if (dataGridReprintSlipKuitansiProcess.Rows.Count == 0)
                    {
                        Alert.PushAlert("Please search data", clsAlert.Type.Warning);
                    }
                    else
                    {

                        var SelectedData = Data.Where(x => x.is_selected == true).ToList();
                        if (SelectedData.Count > 0)
                        {
                            FormActiveName = MenuPrintKuitansi;
                            Helper.SetActive(navPrint);
                            panelView.Hide();
                            pnlPrint.Show();
                            foreach (var item in SelectedData)
                            {
                                if (Convert.ToInt32(item.ak_outstanding_amount) >= 0)
                                {
                                    item.outstanding_amount_terbilang = Helper.Terbilang(Convert.ToDecimal(item.ak_outstanding_amount));
                                    var DataCustomer = AppLogic.GetDataCustomerByID(item.scm_customer_id);
                                    item.scm_address1 = DataCustomer.scm_address1;
                                    item.scm_address2 = DataCustomer.scm_address2;
                                    item.scm_address3 = DataCustomer.scm_address3;
                                    item.telp = DataCustomer.telp;
                                    item.customer_group = DataCustomer.customer_group;
                                }
                            }
                            rptARReprintSlipKuitansiProcess report = new rptARReprintSlipKuitansiProcess();
                            report.SetDataSource(SelectedData);
                            rptViewer.ReportSource = report;
                        }
                        else
                        {
                            Alert.PushAlert("Please select data", clsAlert.Type.Warning);
                        }
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

        private void GetDataComboBoxCollection()
        {
            try
            {
                var Data = AppLogic.GetComboboxCollectionMaster();
                cboSearchCollector.DataSource = Data;
                cboSearchCollector.DisplayMember = "DisplayMember";
                cboSearchCollector.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }

        }

        #endregion

        private void AR_ReprintSlipKuitansiProcessUI_KeyDown(object sender, KeyEventArgs e)
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

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void AR_ReprintSlipKuitansiProcessUI_Load(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Model = new ARReprintSlipKuitansiProcessBL()
            {
                ak_entity_id = $"{cboSearchEntity.SelectedValue}",
                ak_branch_id = $"{cboSearchBranch.SelectedValue}",
                ak_division_id = $"{cboSearchDivision.SelectedValue}",
                cm_collector_name = $"{cboSearchCollector.SelectedValue}",
                ak_item_number = txtBoxSearchInvoiceNo.Text == txtBoxSearchInvoiceNo.TiraPlaceHolder ? "" : txtBoxSearchInvoiceNo.Text,
                ak_processing_date_from = cbProcessDate.Checked ? dtpProcessDateFrom.Value.ToString() : "",
                ak_processing_date_to = cbProcessDate.Checked ? dtpProcessDateTo.Value.ToString() : ""
            };
            Data = new List<ARReprintSlipKuitansiProcessBL>();
            InitializeGrid(Model, false, true);
        }

        private void cbCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            Model = new ARReprintSlipKuitansiProcessBL()
            {
                ak_entity_id = $"{cboSearchEntity.SelectedValue}",
                ak_branch_id = $"{cboSearchBranch.SelectedValue}",
                ak_division_id = $"{cboSearchDivision.SelectedValue}",
                cm_collector_name = $"{cboSearchCollector.SelectedValue}",
                ak_item_number = txtBoxSearchInvoiceNo.Text,
                ak_processing_date_from = cbProcessDate.Checked ? dtpProcessDateFrom.Value.ToString() : "",
                ak_processing_date_to = cbProcessDate.Checked ? dtpProcessDateTo.Value.ToString() : ""
            };
            Data.Clear();
            Data = AppLogic.GetAll(Model);
            dataGridReprintSlipKuitansiProcess.DataSource = null;

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

            dataGridReprintSlipKuitansiProcess.DataSource = Data.Skip(Offset).Take(FetchLimit).ToList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGrid(Model, true, false);

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGrid(Model, true, false);

        }

        private void navPrintListKuitansi_Click(object sender, EventArgs e)
        {
            if (FormActiveName == MenuPrintKuitansi)
            {
                Alert.PushAlert("Back to view menu first", clsAlert.Type.Warning);
            }
            else if (dataGridReprintSlipKuitansiProcess.Rows.Count == 0)
            {
                Alert.PushAlert("Please search data", clsAlert.Type.Warning);
            }
            else
            {
                var Data = AppLogicGlobal.GetReport(HelperReport.REPORT_AR_REPRINT_SLIP_KUITANSI_PROCESS(Model));
                if (Data.Rows.Count > 0)
                {
                    FormActiveName = MenuPrintListKuitansi;
                    Helper.SetActive(navPrintListKuitansi);
                    panelView.Hide();
                    pnlPrint.Show();
                    string _TCode = AppLogicGlobal.GetTCode(this.Name.ToString());
                    DataTable dtCompany = AppLogicGlobal.GetCompany();

                    rptARListReprintSlipKuitansiProcess report = new rptARListReprintSlipKuitansiProcess();
                    report.SetDataSource(Data);
                    report.SetParameterValue("lblCompanyName", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); ;
                    report.SetParameterValue("lblTCode", _TCode.ToUpper());
                    report.SetParameterValue("lblBranch", $"{cboSearchBranch.SelectedValue}");
                    report.SetParameterValue("lblDivision", $"{cboSearchDivision.SelectedValue}");
                    rptViewer.ReportSource = report;
                }
            }
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.PRINT);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}