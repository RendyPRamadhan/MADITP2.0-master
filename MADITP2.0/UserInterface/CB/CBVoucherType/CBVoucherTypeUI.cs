
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
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.ApplicationLogic;


namespace MADITP2._0.UserInterface.CB.CBVoucherType
{
    public partial class CBVoucherTypeUI : Form
    {
        private static GlobalAL AppLogicGlobal;
        private CBVoucherTypeAL AppLogic;
        private CBVoucherTypeBL _Model;
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
        public CBVoucherTypeUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new CBVoucherTypeBL();
                Helper = new clsGlobal();
                AppLogic = new CBVoucherTypeAL(Helper);
                ClsEventButton = new clsEventButton();
                FormMode(clsEventButton.EnumAction.VIEW);
                AppLogicGlobal = new GlobalAL(Helper);
                this.DrawFilterCombobox();
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
            _Model = new CBVoucherTypeBL();
            this.Search(ref _Model);

            InitializeGrid(_Model);
        }
        private void Search(ref CBVoucherTypeBL Model)
        {
            if (txtSearchVoucherTypeID.Text == txtSearchVoucherTypeID.TiraPlaceHolder)
            { Model.voucher_type_id = ""; }
            else { Model.voucher_type_id = txtSearchVoucherTypeID.Text; }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (CBVoucherTypeBL)bindingObjVType.DataSource;
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

        public void InitializeObject(CBVoucherTypeBL Model)
        {
            ClearDataBinding();
            bindingObjVType.DataSource = Model;
            MappingDataBinding();
        }
        public void ClearDataBinding()
        {
            txtInputVoucherTypeID.DataBindings.Clear();
            txtInputVouchetTypeDesc.DataBindings.Clear();
            cmbTranType.DataBindings.Clear();
            cbAllowTxnEntry.DataBindings.Clear();
            cbAllowAP.DataBindings.Clear();
            CBAllowAR.DataBindings.Clear();
        }

        public void MappingDataBinding()
        {
            txtInputVoucherTypeID.DataBindings.Add("Text", bindingObjVType, "voucher_type_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtInputVouchetTypeDesc.DataBindings.Add("Text", bindingObjVType, "description", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbTranType.DataBindings.Add("SelectedValue", bindingObjVType, "txn_type", true, DataSourceUpdateMode.OnPropertyChanged);

            cbAllowTxnEntry.DataBindings.Add("Text", bindingObjVType, "allow_manual_txn_entry", true, DataSourceUpdateMode.OnPropertyChanged);
            cbAllowAP.DataBindings.Add("Text", bindingObjVType, "ap_pay", true, DataSourceUpdateMode.OnPropertyChanged);
            CBAllowAR.DataBindings.Add("Text", bindingObjVType, "ar_receipt", true, DataSourceUpdateMode.OnPropertyChanged);

            if (cbAllowTxnEntry.Text == "Yes")
            { cbAllowTxnEntry.Checked = true; }
            else
            { cbAllowTxnEntry.Checked = false; }

            if (cbAllowAP.Text == "Yes")
            { cbAllowAP.Checked = true; }
            else
            { cbAllowAP.Checked = false; }

            if (CBAllowAR.Text == "Yes")
            { CBAllowAR.Checked = true; }
            else
            { CBAllowAR.Checked = false; }
        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            var Grid = dgvResult;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    ResetPaginationRules();
                    _Model = new CBVoucherTypeBL();
                    InitializeGrid(_Model);
                    panelView.BringToFront();
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    break;

                case clsEventButton.EnumAction.NEW:
                    _Model = new CBVoucherTypeBL();
                    InitializeObject(_Model);
                    PanelFormCreate.BringToFront();
                    btnSave.Text = "Save";
                    txtInputVoucherTypeID.Enabled = true;
                    cmbTranType.SelectedValue = "";
                    cbAllowAP.Text = "No";
                    CBAllowAR.Text = "No";
                    cbAllowTxnEntry.Text = "No";

                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    SQLQuery = EnumState.Create.ToString();
                    break;

                case clsEventButton.EnumAction.EDIT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        FormActiveName = clsEventButton.EnumAction.DELETE.ToString();
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
                                txtInputVoucherTypeID.Enabled = false;
                                SQLQuery = EnumState.Update.ToString();

                                var ID = dgvResult.CurrentRow.Cells["voucher_type_id"].Value.ToString();
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
                                        var ID = dgvResult.CurrentRow.Cells["voucher_type_id"].Value.ToString();

                                        var Model = new CBVoucherTypeBL();
                                        Model.voucher_type_id = ID;
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
                        _Model = new CBVoucherTypeBL();

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
                        FormActiveName = clsEventButton.EnumAction.EXPORT.ToString();
                        _Model = new CBVoucherTypeBL();

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
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_VOUCHER_TYPE);
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
        public void InitializeReport(CBVoucherTypeBL Model)
        {
            String ReportPath = "";
            cryRpt = new ReportDocument();

            DataSet data = AppLogic.GetAllPaging_DS(_Model, this.Name.ToString(), CurrentPage);

            if (data != null)
            {
                //Report Instalize
                /*
                ReportPath = Application.StartupPath + "\\Report\\rptCBVoucherType.rpt";

                cryRpt.Load(ReportPath);
                cryRpt.SetDataSource(data);
                rptViewer.ReportSource = cryRpt;
                rptViewer.Refresh();
                */
                string _TCode = AppLogicGlobal.GetTCode(this.Name.ToString());
                DataTable dtCompany = AppLogicGlobal.GetCompany();

                dtCompany.Columns.Add("mnu_menu_code");
                dtCompany.Rows[0]["mnu_menu_code"] = this.Name.ToString();
                data.Tables.Remove("Table1");
                data.Tables.Add(dtCompany);
                
                rptCBVoucherType report = new rptCBVoucherType();
                report.SetDataSource(data);
                rptViewer.ReportSource = report;
            }
        }
        private bool FormValidation(CBVoucherTypeBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.voucher_type_id))
            {
                IsValid = false;
                MessageValidation = "Voucher Type ID is required!";
            }

            if (string.IsNullOrEmpty(Model.description))
            {
                IsValid = false;
                MessageValidation = "Voucher Type Description is required!";
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

        private void cbAllowTxnEntry_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllowTxnEntry.Checked)
            { cbAllowTxnEntry.Text = "Yes"; }
            else
            { cbAllowTxnEntry.Text = "No"; }
        }

        private void cbAllowAP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllowAP.Checked)
            { cbAllowAP.Text = "Yes"; }
            else
            { cbAllowAP.Text = "No"; }
        }

        private void CBAllowAR_CheckedChanged(object sender, EventArgs e)
        {
            if (CBAllowAR.Checked)
            { CBAllowAR.Text = "Yes"; }
            else
            { CBAllowAR.Text = "No"; }
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EXPORT);
        }

        public void InitializeGrid(CBVoucherTypeBL Model)
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

            DataTable dtInputVType = new DataTable();
            DataTable dtSearchVType = new DataTable();
            dtInputVType = AppLogic.GetList_Transaction(clsEventButton.EnumAction.DISPLAY.ToString());
            dtSearchVType = AppLogic.GetList_Transaction(clsEventButton.EnumAction.SEARCH.ToString());
            if (dtInputVType != null && dtSearchVType != null)
            {
                cmbTranType.DataSource = dtInputVType;
                cmbTranType.ValueMember = "TransactionTypeID";
                cmbTranType.DisplayMember = "TransactionType";

                //cmbSearchEntity.DataSource = dtSearchVType;
                //cmbSearchEntity.ValueMember = "ec_entity_id";
                //cmbSearchEntity.DisplayMember = "ec_entity";
            }
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
    }
}
