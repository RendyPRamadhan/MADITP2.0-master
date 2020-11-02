using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.ApplicationLogic.AR;
using MADITP2._0.BusinessLogic.AR;
using CrystalDecisions.CrystalReports.Engine;
using MADITP2._0.Report.AR;
using MADITP2._0.Report.AR.ARMasterCollector;

namespace MADITP2._0.UserInterface.AR.ARMasterCollector
{
    public partial class ARMasterCollectorUI : Form
    {
        private ARMasterCollectorAL AppLogic;
        private ARMasterCollectorBL _Model;
        private clsGlobal Helper = new clsGlobal();
        private clsAlert Alert = new clsAlert();
        //private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private int _APPSTATE;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;
        private static string FormActiveName;
        private static string SQLQuery;
        private static clsEventButton ClsEventButton;
        ReportDocument cryRpt;
        public ARMasterCollectorUI()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new ARMasterCollectorBL();
                Helper = new clsGlobal();
                AppLogic = new ARMasterCollectorAL(Helper);
                ClsEventButton = new clsEventButton();
                DrawFilterCombobox();
                FormMode(clsEventButton.EnumAction.VIEW);
            }
        }

        private void tiraComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.NEW);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EDIT);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.DELETE);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.PRINT);
        }

        private void tiraButton1_Click(object sender, EventArgs e)
        {
            _Model = new ARMasterCollectorBL();
            this.Search(ref _Model);

            InitializeGrid(_Model);
        }

        private void Search(ref ARMasterCollectorBL Model)
        {
            if (cmbSearchEntity.SelectedValue.ToString() == "0")
            { _Model.entity_id = ""; }
            else
            { _Model.entity_id = cmbSearchEntity.SelectedValue.ToString(); }


            if (cmbSearchBranch.SelectedValue.ToString() == "0")
            { _Model.branch_id = ""; }
            else
            { _Model.branch_id = cmbSearchBranch.SelectedValue.ToString(); }

            if (cmbSearchDivision.SelectedValue.ToString() == "0")
            { _Model.division_id = ""; }
            else
            { _Model.division_id = cmbSearchDivision.SelectedValue.ToString(); }


            if (cmbSearchDefaultArea.SelectedValue.ToString() == "")
            { _Model.default_area_code = ""; }
            else
            { _Model.default_area_code = cmbSearchDefaultArea.SelectedValue.ToString(); }

            if (cmbSearchGroupHead.SelectedValue.ToString() == "0")
            { _Model.group_head_id = ""; }
            else
            { _Model.group_head_id = cmbSearchGroupHead.SelectedValue.ToString(); }

            if(txtSearchCollectorName.Text == txtSearchCollectorName.TiraPlaceHolder)
            {
                _Model.collector_name = "";
            }
            else { _Model.collector_name = txtSearchCollectorName.Text; }

        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Pagination(true);
            InitializeGrid(_Model);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Pagination(true);
            InitializeGrid(_Model);
        }
        public void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (ARMasterCollectorBL)bindingObjCollector.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    AppLogic.CMD(Model, SQLQuery);
                    if (SQLQuery == EnumState.Create.ToString())
                        Alert.PushAlert("Success Insert data", clsAlert.Type.Success);
                    else if (SQLQuery == EnumState.Update.ToString())
                        Alert.PushAlert("Success Update data", clsAlert.Type.Success);
                    else if (SQLQuery == EnumState.Delete.ToString())
                        Alert.PushAlert("Success Delete data", clsAlert.Type.Success);

                    FormMode(clsEventButton.EnumAction.VIEW);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        //////////////////
        public void InitializeObject(ARMasterCollectorBL Model)
        {
            ClearDataBinding();
            bindingObjCollector.DataSource = Model;
            MappingDataBinding();
        }
        public void ClearDataBinding()
        {
            cmbInputEntity.DataBindings.Clear();
            cmbInputBranch.DataBindings.Clear();
            cmbInputDivision.DataBindings.Clear();
            txtCollectorID.DataBindings.Clear();

            txtCollectorName.DataBindings.Clear();
            cmbInputArea.DataBindings.Clear();
            txtCollectorLevel.DataBindings.Clear();
            cmbInputGroupHead.DataBindings.Clear();
            txtBankName.DataBindings.Clear();
            txtBankAccount1.DataBindings.Clear();

            txtKW1.DataBindings.Clear();
            txtKW2.DataBindings.Clear();
            txtKW3.DataBindings.Clear();
            txtPenaltyAmount.DataBindings.Clear();
            txtRemarks.DataBindings.Clear();
        }

        public void MappingDataBinding()
        {
            cmbInputEntity.DataBindings.Add("SelectedValue", bindingObjCollector, "entity_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbInputBranch.DataBindings.Add("SelectedValue", bindingObjCollector, "branch_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbInputDivision.DataBindings.Add("SelectedValue", bindingObjCollector, "division_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCollectorID.DataBindings.Add("Text", bindingObjCollector, "collector_id", true, DataSourceUpdateMode.OnPropertyChanged);

            txtCollectorName.DataBindings.Add("Text", bindingObjCollector, "collector_name", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbInputArea.DataBindings.Add("SelectedValue", bindingObjCollector, "default_area_code", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCollectorLevel.DataBindings.Add("Text", bindingObjCollector, "collector_level", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbInputGroupHead.DataBindings.Add("SelectedValue", bindingObjCollector, "group_head_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBankName.DataBindings.Add("Text", bindingObjCollector, "bank_name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBankAccount1.DataBindings.Add("Text", bindingObjCollector, "bank_account_number", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKW1.DataBindings.Add("Text", bindingObjCollector, "incentive_amount_kw1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKW2.DataBindings.Add("Text", bindingObjCollector, "incentive_amount_kw2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKW3.DataBindings.Add("Text", bindingObjCollector, "incentive_amount_kw3", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPenaltyAmount.DataBindings.Add("Text", bindingObjCollector, "penalty_amount_kw", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRemarks.DataBindings.Add("Text", bindingObjCollector, "remarks", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            var Grid = dgvResult;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    ResetPaginationRules();
                    _Model = new ARMasterCollectorBL();
                    InitializeGrid(_Model);
                    PanelFormList.BringToFront();
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();

                    cmbSearchBranch.SelectedValue = "0";
                    cmbSearchDefaultArea.SelectedValue = "";
                    cmbSearchDivision.SelectedValue = "0";
                    cmbSearchEntity.SelectedValue = "0";
                    cmbSearchGroupHead.SelectedValue = "0";
                    break;

                case clsEventButton.EnumAction.NEW:
                    _Model = new ARMasterCollectorBL();
                    InitializeObject(_Model);
                    PanelFormCreate.BringToFront();
                    btnSave.Text = "Save";
                    txtCollectorID.Enabled = true;

                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    SQLQuery = EnumState.Create.ToString();
                    break;

                case clsEventButton.EnumAction.EDIT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        PanelFormCreate.BringToFront();

                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            if (Grid.SelectedRows.Count == 1)
                            {
                                btnSave.Text = "Update";
                                txtCollectorID.Enabled = false;
                                SQLQuery = EnumState.Update.ToString();

                                var ID = dgvResult.CurrentRow.Cells["collector_id"].Value.ToString();
                                var Data = AppLogic.GetByID_Model(ID);
                                //InitializeObject(Data);
                                InitializeObject(Data);
                            }
                            else if (Grid.SelectedRows.Count > 1)
                            {
                                Alert.PushAlert("Please Dont Select Multiple Data", clsAlert.Type.Info);
                            }
                            else
                            {
                                Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
                            }
                        }
                    }
                    else
                    {
                        Alert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                    }
                    FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
                    break;

                case clsEventButton.EnumAction.DELETE:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            if (Grid.SelectedRows.Count >= 1)
                            {
                                MessageBoxButtons ButttonDialog = MessageBoxButtons.YesNo;
                                DialogResult ResultDialog = MessageBox.Show("Are You Sure?", "Warning!", ButttonDialog);
                                if (ResultDialog == DialogResult.Yes)
                                {
                                    SQLQuery = EnumState.Delete.ToString();
                                    for (int i = 0; i < Grid.SelectedRows.Count; i++)
                                    {
                                        var ID = dgvResult.CurrentRow.Cells["collector_id"].Value.ToString();

                                        var Model = new ARMasterCollectorBL();
                                        Model.collector_id = ID;
                                        AppLogic.CMD(Model, SQLQuery);

                                        //InitializeObject(Data);
                                    }
                                    Alert.PushAlert("Success Delete Data", clsAlert.Type.Success);
                                    FormMode(clsEventButton.EnumAction.VIEW);
                                }
                            }
                            else
                            {
                                Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
                            }
                        }
                    }
                    else
                    {
                        Alert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                    }
                    break;

                case clsEventButton.EnumAction.PRINT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        FormActiveName = clsEventButton.EnumAction.PRINT.ToString();
                        PanelFormPrint.BringToFront();
                        _Model = new ARMasterCollectorBL();

                        this.Search(ref _Model);

                        InitializeReport(_Model);
                    }
                    else
                    {
                        Alert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                    }
                    break;

                case clsEventButton.EnumAction.EXPORT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        _Model = new ARMasterCollectorBL();

                        this.Search(ref _Model);

                        var DataForExport = AppLogic.GetAllPaging(_Model, CurrentPage);

                        if (DataForExport.Rows.Count > 0)
                        {
                            clsExcel clExcel = new clsExcel();
                            using (var fbd = new FolderBrowserDialog())
                            {
                                DialogResult result = fbd.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                {
                                    var path = fbd.SelectedPath;
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_COLLECTOR_MASTER);
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
                        Alert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                    }
                    break;
            }
        }
        public void InitializeReport(ARMasterCollectorBL Model)
        {
            String ReportPath = "";
            cryRpt = new ReportDocument();

            DataSet data = AppLogic.GetAllPaging_DS(_Model, this.Name.ToString(), CurrentPage);

            if (data != null)
            {
                //Report Instalize
                /*ReportPath = Application.StartupPath + "\\Report\\rptARMasterCollector.rpt";

                cryRpt.Load(ReportPath);
                cryRpt.SetDataSource(data);
                rptViewer.ReportSource = cryRpt;
                rptViewer.Refresh();
                */
                rptARMasterCollector report = new rptARMasterCollector();
                report.SetDataSource(data);
                rptViewer.ReportSource = report;
                rptViewer.Refresh();
            }
        }
        private bool FormValidation(ARMasterCollectorBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.collector_id))
            {
                IsValid = false;
                MessageValidation = "Collector ID is required!";
            }


            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }
        private void Pagination(Boolean onloading = false)
        {
            if (_TotalPage == 0)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                return;
            }

            if (_TotalPage == CurrentPage)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                if (CurrentPage > 1)
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

            if (CurrentPage < 2)
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

        private void navExport_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EXPORT);
        }

        public void InitializeGrid(ARMasterCollectorBL Model)
        {
            try
            {
                DataTable data = AppLogic.GetAllPaging(_Model, CurrentPage);
                dgvResult.AutoGenerateColumns = false;
                dgvResult.DataSource = data;

                //Paging Initialize
                int DataCount = AppLogic.GetAllCount(Model);
                TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                lblRows.Text = "Records : " + dgvResult.Rows.Count.ToString() + " Rows";
                PaginationRules();
            }
            catch (Exception ex)
            {
                Alert.PushAlert("Something wrong", clsAlert.Type.Info);
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
        private void DrawFilterCombobox()
        {
            DataTable dtSearchEntity = new DataTable();
            DataTable dtInputEntity = new DataTable();
            dtSearchEntity = AppLogic.GetList_Entity(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputEntity = AppLogic.GetList_Entity(clsEventButton.EnumAction.DISPLAY.ToString());

            if (dtSearchEntity != null && dtInputEntity != null)
            {
                cmbSearchEntity.DataSource = dtSearchEntity;
                cmbSearchEntity.ValueMember = "cm_entity_id";
                cmbSearchEntity.DisplayMember = "ec_entity";

                cmbInputEntity.DataSource = dtInputEntity;
                cmbInputEntity.ValueMember = "cm_entity_id";
                cmbInputEntity.DisplayMember = "ec_entity";
            }

            DataTable dtSearchBranch= new DataTable();
            DataTable dtInputBranch = new DataTable();
            dtSearchBranch = AppLogic.GetList_Branch(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputBranch = AppLogic.GetList_Branch(clsEventButton.EnumAction.DISPLAY.ToString());

            if (dtSearchBranch != null && dtInputBranch != null)
            {
                cmbSearchBranch.DataSource = dtSearchBranch;
                cmbSearchBranch.ValueMember = "cm_branch_id";
                cmbSearchBranch.DisplayMember = "bc_branch";

                cmbInputBranch.DataSource = dtInputBranch;
                cmbInputBranch.ValueMember = "cm_branch_id";
                cmbInputBranch.DisplayMember = "bc_branch";
            }

            DataTable dtSearchDivision = new DataTable();
            DataTable dtInputDivision = new DataTable();
            dtSearchDivision = AppLogic.GetList_Division(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputDivision = AppLogic.GetList_Division(clsEventButton.EnumAction.DISPLAY.ToString());

            if (dtSearchDivision != null && dtInputDivision != null)
            {
                cmbSearchDivision.DataSource = dtSearchDivision;
                cmbSearchDivision.ValueMember = "cm_division_id";
                cmbSearchDivision.DisplayMember = "dc_division";

                cmbInputDivision.DataSource = dtInputDivision;
                cmbInputDivision.ValueMember = "cm_division_id";
                cmbInputDivision.DisplayMember = "dc_division";
            }

            DataTable dtSearchArea = new DataTable();
            DataTable dtInputArea = new DataTable();
            dtSearchArea = AppLogic.GetList_Area(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputArea = AppLogic.GetList_Area(clsEventButton.EnumAction.DISPLAY.ToString());
            if (dtSearchArea != null && dtInputArea != null)
            {
                cmbSearchDefaultArea.DataSource = dtSearchArea;
                cmbSearchDefaultArea.ValueMember = "ac_area_id";
                cmbSearchDefaultArea.DisplayMember = "ac_area_description";

                cmbInputArea.DataSource = dtInputArea;
                cmbInputArea.ValueMember = "ac_area_id";
                cmbInputArea.DisplayMember = "ac_area_description";
            }

            DataTable dtSearchGroupHead = new DataTable();
            DataTable dtInputGroupHead = new DataTable();
            dtSearchGroupHead = AppLogic.GetList_GroupHead(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputGroupHead = AppLogic.GetList_GroupHead(clsEventButton.EnumAction.DISPLAY.ToString());

            if (dtSearchGroupHead != null && dtInputGroupHead != null)
            {
                cmbSearchGroupHead.DataSource = dtSearchGroupHead;
                cmbSearchGroupHead.ValueMember = "cm_collector_id";
                cmbSearchGroupHead.DisplayMember = "cm_collector_name";

                cmbInputGroupHead.DataSource = dtInputGroupHead;
                cmbInputGroupHead.ValueMember = "cm_collector_id";
                cmbInputGroupHead.DisplayMember = "cm_collector_name";
            }


        }
    }
}
