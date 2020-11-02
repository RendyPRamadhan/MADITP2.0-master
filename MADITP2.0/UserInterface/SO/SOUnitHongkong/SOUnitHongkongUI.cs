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
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.BusinessLogic.SO;
using CrystalDecisions.CrystalReports.Engine;
using MADITP2._0.Report.SO;

namespace MADITP2._0.UserInterface.SO.SOUnitHongkong
{
    public partial class SOUnitHongkongUI : Form
    {
        private SOUnitHongkongAL AppLogic;
        private SOUnitHongkongBL _Model;
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
        public SOUnitHongkongUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new SOUnitHongkongBL();
                Helper = new clsGlobal();
                AppLogic = new SOUnitHongkongAL(Helper);
                ClsEventButton = new clsEventButton();
                FormMode(clsEventButton.EnumAction.VIEW);
                this.DrawFilterCombobox();
            }
        }

        private void label6_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Model = new SOUnitHongkongBL();

            this.Search(ref _Model);

            InitializeGrid(_Model);
        }
        private void Search(ref SOUnitHongkongBL Model)
        {
            if (txtSearchProductID.Text == txtSearchProductID.TiraPlaceHolder)
            { Model.product_id = ""; }
            else { Model.product_id = txtSearchProductID.Text; }

            if (cmbSearchDivision.SelectedValue.ToString() == "0")
            { Model.division_id = ""; }
            else
            { Model.division_id = cmbSearchDivision.SelectedValue.ToString(); }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (SOUnitHongkongBL)bindingObjUHongkong.DataSource;
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









        private void DrawFilterCombobox()
        {

            DataTable dtInputDevision = new DataTable();
            DataTable dtSearchDevision = new DataTable();
            dtSearchDevision = AppLogic.GetList_Division(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputDevision = AppLogic.GetList_Division(clsEventButton.EnumAction.DISPLAY.ToString());
            if (dtInputDevision != null && dtSearchDevision != null)
            {
                cmbInputDivision.DataSource = dtInputDevision;
                cmbInputDivision.ValueMember = "cm_division_id";
                cmbInputDivision.DisplayMember = "dc_division";

                cmbSearchDivision.DataSource = dtSearchDevision;
                cmbSearchDivision.ValueMember = "cm_division_id";
                cmbSearchDivision.DisplayMember = "dc_division";
            }
        }





            public void InitializeObject(SOUnitHongkongBL Model)
        {
            ClearDataBinding();
            bindingObjUHongkong.DataSource = Model;
            MappingDataBinding();
        }
        public void ClearDataBinding()
        {
            cmbInputDivision.DataBindings.Clear();
            txtProductID.DataBindings.Clear();
            txtSalesUnit.DataBindings.Clear();
        }

        public void MappingDataBinding()
        {
            cmbInputDivision.DataBindings.Add("SelectedValue", bindingObjUHongkong, "division_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtProductID.DataBindings.Add("Text", bindingObjUHongkong, "product_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSalesUnit.DataBindings.Add("Text", bindingObjUHongkong, "buku", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            var Grid = dgvResult;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    ResetPaginationRules();
                    _Model = new SOUnitHongkongBL();
                    InitializeGrid(_Model);
                    PanelFormList.BringToFront();
                    cmbSearchDivision.SelectedValue = '0';
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    break;

                case clsEventButton.EnumAction.NEW:
                    _Model = new SOUnitHongkongBL();
                    InitializeObject(_Model);
                    PanelFormCreate.BringToFront();
                    btnSave.Text = "Save";
                    cmbInputDivision.Enabled = true;
                    txtProductID.Enabled = true;
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
                                cmbInputDivision.Enabled = false;
                                txtProductID.Enabled = false;
                                SQLQuery = EnumState.Update.ToString();

                                var DivisionID = dgvResult.CurrentRow.Cells["division_id"].Value.ToString();
                                var ProductID = dgvResult.CurrentRow.Cells["product_id"].Value.ToString();

                                var Data = AppLogic.GetByID_Model(DivisionID, ProductID);
                                cmbSearchDivision.SelectedValue = '0';
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
                                        var DivisionID = dgvResult.CurrentRow.Cells["division_id"].Value.ToString();
                                        var ProductID = dgvResult.CurrentRow.Cells["product_id"].Value.ToString();

                                        var Model = new SOUnitHongkongBL();
                                        Model.division_id = DivisionID;
                                        Model.product_id = ProductID;
                                        
                                        AppLogic.CMD(Model, SQLQuery);

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
                        _Model = new SOUnitHongkongBL();

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
                        _Model = new SOUnitHongkongBL();

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
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_MASTER_SU_HONGKONG);
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
        public void InitializeReport(SOUnitHongkongBL Model)
        {
            String ReportPath = "";
            cryRpt = new ReportDocument();

            DataSet data = AppLogic.GetAllPaging_DS(_Model, this.Name.ToString(), CurrentPage);

            if (data != null)
            {
                //Report Instalize
                /* ReportPath = Application.StartupPath + "\\Report\\rptSOUnitHongkong.rpt";

                 cryRpt.Load(ReportPath);
                 cryRpt.SetDataSource(data);
                 rptViewer.ReportSource = cryRpt;
                 rptViewer.Refresh();
                */
                rptSOUnitHongkong report = new rptSOUnitHongkong();
                report.SetDataSource(data);
                rptViewer.ReportSource = report;
                rptViewer.Refresh();

            }
        }
        private bool FormValidation(SOUnitHongkongBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.division_id))
            {
                IsValid = false;
                MessageValidation = "Division is required!";
            }
            if (string.IsNullOrEmpty(Model.product_id))
            {
                IsValid = false;
                MessageValidation = "Product is required!";
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

        public void InitializeGrid(SOUnitHongkongBL Model)
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
