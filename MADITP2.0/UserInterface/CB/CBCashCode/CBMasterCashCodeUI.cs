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
using MADITP2._0.Report.CB;
using CrystalDecisions.CrystalReports.Engine;

namespace MADITP2._0.UserInterface.CB.CBCashCode
{
    public partial class CBMasterCashCodeUI : Form
    {
        private CBMasterCashCodeAL AppLogic;
        private CBMasterCashCodeBL _Model;
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
        public CBMasterCashCodeUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new CBMasterCashCodeBL();
                Helper = new clsGlobal();
                AppLogic = new CBMasterCashCodeAL(Helper);
                ClsEventButton = new clsEventButton();
                FormMode(clsEventButton.EnumAction.VIEW);
                panelView.BringToFront();
            }
        }

        private void cbCashType_CheckedChanged(object sender, EventArgs e)
        {

            if (cbCashType.Checked)
            {
                cbCashType.Text = "Is Disbursement";
                txtCashType.Text = "D";
            }
            else
            {
                cbCashType.Text = "Is Receipt";
                txtCashType.Text = "R";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Model = new CBMasterCashCodeBL();

            this.Search(ref _Model);
            InitializeGrid(_Model);
        }

        private void Search(ref CBMasterCashCodeBL Model)
        {
            if (txtSearchCashCode.Text == txtSearchCashCode.TiraPlaceHolder)
            { _Model.cash_id = ""; }
            else { _Model.cash_id = txtSearchCashCode.Text; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (CBMasterCashCodeBL)bindingCashCode.DataSource;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }






        public void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
        }

        public void InitializeObject(CBMasterCashCodeBL Model)
        {
            ClearDataBinding();
            bindingCashCode.DataSource = Model;
            MappingDataBinding();
        }
        public void ClearDataBinding()
        {
            txtInputCashID.DataBindings.Clear();
            txtCashdesc.DataBindings.Clear();
            txtSeq.DataBindings.Clear();
            txtCashType.DataBindings.Clear();
            txtUserDefField.DataBindings.Clear();
        }

        public void MappingDataBinding()
        {
            txtInputCashID.DataBindings.Add("Text", bindingCashCode, "cash_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCashdesc.DataBindings.Add("Text", bindingCashCode, "description", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSeq.DataBindings.Add("Text", bindingCashCode, "sequence_number", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCashType.DataBindings.Add("Text", bindingCashCode, "code_type", true, DataSourceUpdateMode.OnPropertyChanged);
            txtUserDefField.DataBindings.Add("Text", bindingCashCode, "user_define", true, DataSourceUpdateMode.OnPropertyChanged);

            if (txtCashType.Text == "Disbursement")
            { cbCashType.Checked = true; }
            else if (txtCashType.Text == "Receipt")
            { cbCashType.Checked = false; }
            else { cbCashType.Checked = false; }
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
            var Grid = dgvResult;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    ResetPaginationRules();
                    _Model = new CBMasterCashCodeBL();
                    InitializeGrid(_Model);
                    panelView.BringToFront();
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    break;

                case clsEventButton.EnumAction.NEW:
                    _Model = new CBMasterCashCodeBL();
                    InitializeObject(_Model);
                    PanelFormCreate.BringToFront();
                    btnSave.Text = "Save";
                    txtInputCashID.Enabled = true;

                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    SQLQuery = EnumState.Create.ToString();
                    break;

                case clsEventButton.EnumAction.EDIT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
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
                                txtInputCashID.Enabled = false;
                                SQLQuery = EnumState.Update.ToString();

                                var ID = dgvResult.CurrentRow.Cells["cash_id"].Value.ToString();
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
                   // FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
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
                                        var ID = dgvResult.CurrentRow.Cells["cash_id"].Value.ToString();

                                        var Model = new CBMasterCashCodeBL();
                                        Model.cash_id = ID;
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
                        _Model = new CBMasterCashCodeBL();

                        if (txtSearchCashCode.Text == txtSearchCashCode.TiraPlaceHolder)
                        { txtSearchCashCode.Text = ""; }
                        _Model.cash_id = txtSearchCashCode.Text;

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
                        _Model = new CBMasterCashCodeBL();

                        if (txtSearchCashCode.Text == txtSearchCashCode.TiraPlaceHolder)
                        { txtSearchCashCode.Text = ""; }
                        _Model.cash_id = txtSearchCashCode.Text;

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
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_CASH_CODE);
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
        public void InitializeReport(CBMasterCashCodeBL Model)
        {
            String ReportPath = "";
            cryRpt = new ReportDocument();

            DataSet data = AppLogic.GetAllPaging_DS(_Model, this.Name.ToString(), CurrentPage);

            if (data != null)
            {
                //Report Instalize
                //ReportPath = Application.StartupPath + "\\Report\\rptCBCashCode.rpt";

              /*  cryRpt.Load(ReportPath);
                cryRpt.SetDataSource(data);
                rptViewer.ReportSource = cryRpt;
                rptViewer.Refresh();
              */

                rptCBCashCode report = new rptCBCashCode();
                report.SetDataSource(data);
                rptViewer.ReportSource = report;
                rptViewer.Refresh();
            }
        }
        private bool FormValidation(CBMasterCashCodeBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.cash_id))
            {
                IsValid = false;
                MessageValidation = "Cash ID is required!";
            }

            if (string.IsNullOrEmpty(Model.description))
            {
                IsValid = false;
                MessageValidation = "Cash Description is required!";
            }


            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EXPORT);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelView_Paint(object sender, PaintEventArgs e)
        {

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

        public void InitializeGrid(CBMasterCashCodeBL Model)
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
