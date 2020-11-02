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
using MADITP2._0.ApplicationLogic.CB;
using MADITP2._0.BusinessLogic.CB;
using CrystalDecisions.CrystalReports.Engine;
using MADITP2._0.Report.CB;

namespace MADITP2._0.UserInterface.CB.CBCurrencyCode
{
    public partial class CBMasterCurrencyCodeUI : Form
    {
        private CBMasterCurrencyCodeAL AppLogic;
        private CBMasterCurrencyCodeBL _Model;
        private clsGlobal Helper = new clsGlobal();
        private clsAlert Alert = new clsAlert();
        //private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private int _APPSTATE;
        private string IDHome;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;
        private static string FormActiveName;
        private static string SQLQuery;
        private static clsEventButton ClsEventButton;
        ReportDocument cryRpt;
        public CBMasterCurrencyCodeUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new CBMasterCurrencyCodeBL();
                Helper = new clsGlobal();
                AppLogic = new CBMasterCurrencyCodeAL(Helper);
                ClsEventButton = new clsEventButton();
                FormMode(clsEventButton.EnumAction.VIEW);
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Model = new CBMasterCurrencyCodeBL();

            if(txtSearchCurrCode.Text == txtSearchCurrCode.TiraPlaceHolder)
            { _Model.currency_code = ""; }
            else { _Model.currency_code = txtSearchCurrCode.Text; }
            
            InitializeGrid(_Model);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (CBMasterCurrencyCodeBL)bindingobjCurr.DataSource;
                bool IsValid = FormValidation(Model);
                string IDHomes = "";

                if (IsValid)
                {
                    AppLogic.CMD(Model, SQLQuery, ref IDHomes);
                    if (SQLQuery == EnumState.Create.ToString())
                        Alert.PushAlert("Success Insert data - Your Home Currency = " + IDHomes, clsAlert.Type.Success);
                    else if (SQLQuery == EnumState.Update.ToString())
                        Alert.PushAlert("Success Update data - Your Home Currency = " + IDHomes, clsAlert.Type.Success);
                    else if (SQLQuery == EnumState.Delete.ToString())
                        Alert.PushAlert("Success Delete data - Your Home Currency = " + IDHomes, clsAlert.Type.Success);

                    FormMode(clsEventButton.EnumAction.VIEW);
                }
            }
            catch (Exception ex)
            {
                if(ex.Message.ToString() == "There is no row at position 0.")
                { Alert.PushAlert("Currency home not set" , clsAlert.Type.Info); }
                else 
                { Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error); }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Pagination(true);
            InitializeGrid(_Model);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
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







        public void InitializeObject(CBMasterCurrencyCodeBL Model)
        {
            ClearDataBinding();
            bindingobjCurr.DataSource = Model;
            MappingDataBinding();
        }
        public void ClearDataBinding()
        {
            txtInputCurrID.DataBindings.Clear();
            txtCurr.DataBindings.Clear();
            txtCurrType.DataBindings.Clear();
            txtUpper.DataBindings.Clear();
            txtLower.DataBindings.Clear();
            txtMiddle.DataBindings.Clear();
            txtRemarks.DataBindings.Clear();
            cbCurrType.DataBindings.Clear();
        }

        public void MappingDataBinding()
        {
            txtInputCurrID.DataBindings.Add("Text", bindingobjCurr, "currency_code", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCurr.DataBindings.Add("Text", bindingobjCurr, "currency", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCurrType.DataBindings.Add("Text", bindingobjCurr, "currency_type", true, DataSourceUpdateMode.OnPropertyChanged);

            txtUpper.DataBindings.Add("Text", bindingobjCurr, "upp_rate_to_home", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLower.DataBindings.Add("Text", bindingobjCurr, "low_rate_to_home", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMiddle.DataBindings.Add("Text", bindingobjCurr, "mdl_rate_to_home", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRemarks.DataBindings.Add("Text", bindingobjCurr, "remarks", true, DataSourceUpdateMode.OnPropertyChanged);

            if (txtCurrType.Text == "H")
            { cbCurrType.Checked = true; }
            else
            { cbCurrType.Checked = false; }

        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            var Grid = dgvResult;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    ResetPaginationRules();
                    _Model = new CBMasterCurrencyCodeBL();
                    InitializeGrid(_Model);
                    panelView.BringToFront();
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    break;

                case clsEventButton.EnumAction.NEW:
                    _Model = new CBMasterCurrencyCodeBL();
                    InitializeObject(_Model);
                    PanelFormCreate.BringToFront();
                    btnSave.Text = "Save";
                    txtInputCurrID.Enabled = true;

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
                                txtInputCurrID.Enabled = false;
                                SQLQuery = EnumState.Update.ToString();

                                var ID = dgvResult.CurrentRow.Cells["currency_code"].Value.ToString();
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
                        FormActiveName = clsEventButton.EnumAction.DELETE.ToString();
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
                                        var ID = dgvResult.CurrentRow.Cells["currency_code"].Value.ToString();

                                        var Model = new CBMasterCurrencyCodeBL();
                                        Model.currency_code = ID;
                                        AppLogic.CMD(Model, SQLQuery, ref IDHome);

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
                        _Model = new CBMasterCurrencyCodeBL();

                        if (txtSearchCurrCode.Text == txtSearchCurrCode.TiraPlaceHolder)
                        { txtSearchCurrCode.Text = ""; }
                        _Model.currency_code = txtSearchCurrCode.Text;

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
                        FormActiveName = clsEventButton.EnumAction.EXPORT.ToString();
                        _Model = new CBMasterCurrencyCodeBL();

                        if (txtSearchCurrCode.Text == txtSearchCurrCode.TiraPlaceHolder)
                        { txtSearchCurrCode.Text = ""; }
                        _Model.currency_code = txtSearchCurrCode.Text;

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
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_CURRENCY_CODE);
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
        public void InitializeReport(CBMasterCurrencyCodeBL Model)
        {
            String ReportPath = "";
            cryRpt = new ReportDocument();

            DataSet data = AppLogic.GetAllPaging_DS(_Model, this.Name.ToString(), CurrentPage);

            if (data != null)
            {
                //Report Instalize
                /* ReportPath = Application.StartupPath + "\\Report\\rptCBMasterCurrencyCode.rpt";

                 cryRpt.Load(ReportPath);
                 cryRpt.SetDataSource(data);
                 rptViewer.ReportSource = cryRpt;
                 rptViewer.Refresh();
                */
                rptCBMasterCurrencyCode report = new rptCBMasterCurrencyCode();
                report.SetDataSource(data);
                rptViewer.ReportSource = report;
                rptViewer.Refresh();
            }
        }
        private bool FormValidation(CBMasterCurrencyCodeBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.currency_code))
            {
                IsValid = false;
                MessageValidation = "Currency Code is required!";
            }

            if (string.IsNullOrEmpty(Model.currency))
            {
                IsValid = false;
                MessageValidation = "Currency Description is required!";
            }


            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        private void cbCurrType_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCurrType.Checked)
            { txtCurrType.Text = "H"; }
            else
            { txtCurrType.Text = "F"; }
        }

        private void txtUpper_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUpper_Validated(object sender, EventArgs e)
        {

        }

        private void txtLower_Validated(object sender, EventArgs e)
        {

        }

        private void navExport_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EXPORT);
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

        public void InitializeGrid(CBMasterCurrencyCodeBL Model)
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


    }

}
