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

namespace MADITP2._0.UserInterface.SO.SOReportCOGS
{
    public partial class SOReportCOGSUI : Form
    {
        private SOReportCOGSAL AppLogic;
        private SOReportCOGSBL _Model;
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
        public SOReportCOGSUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new SOReportCOGSBL();
                Helper = new clsGlobal();
                AppLogic = new SOReportCOGSAL(Helper);
                ClsEventButton = new clsEventButton();
                DrawFilterCombobox();
                FormMode(clsEventButton.EnumAction.VIEW);
            }
        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.PRINT);
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EXPORT);
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
            _Model = new SOReportCOGSBL();
            this.Search(ref _Model);

            InitializeGrid(_Model);
        }
        private void Search(ref SOReportCOGSBL Model)
        {
            if (cmbSearchPrincipal.SelectedValue.ToString() == "0")
            { _Model.principal = ""; }
            else
            { _Model.principal = cmbSearchPrincipal.SelectedValue.ToString(); }


            if (cmbSearchProduct.SelectedValue.ToString() == "0")
            { _Model.product = ""; }
            else
            { _Model.product = cmbSearchProduct.SelectedValue.ToString(); }

            _Model.periode = dtpPeriod.Value.ToString();

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
            var Grid = dgvResult;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    ResetPaginationRules();
                    _Model = new SOReportCOGSBL();
                    InitializeGrid(_Model);
                    PanelFormList.BringToFront();
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    break;

                case clsEventButton.EnumAction.NEW:
                    
                    break;

                case clsEventButton.EnumAction.EDIT:
                   
                    break;

                case clsEventButton.EnumAction.DELETE:
                   
                    break;

                case clsEventButton.EnumAction.PRINT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        PanelFormPrint.BringToFront();
                        _Model = new SOReportCOGSBL();

                        this.Search(ref _Model);

                        InitializeReport(_Model);
                    }
                    break;

                case clsEventButton.EnumAction.EXPORT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        _Model = new SOReportCOGSBL();

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
                    break;
            }
        }

        public void InitializeReport(SOReportCOGSBL Model)
        {
            String ReportPath = "";
            cryRpt = new ReportDocument();

            DataSet data = AppLogic.GetAllPaging_DS(_Model, this.Name.ToString(), CurrentPage);

            if (data != null)
            {
                //Report Instalize
                ReportPath = Application.StartupPath + "\\Report\\rptARMasterCollector.rpt";

                cryRpt.Load(ReportPath);
                cryRpt.SetDataSource(data);
                rptViewer.ReportSource = cryRpt;
                rptViewer.Refresh();
            }
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
        public void InitializeGrid(SOReportCOGSBL Model)
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
            DataTable dtSearchPrincipal = new DataTable();
            dtSearchPrincipal = AppLogic.GetList_Principal(clsEventButton.EnumAction.SEARCH.ToString());

            if (dtSearchPrincipal != null)
            {
                cmbSearchPrincipal.DataSource = dtSearchPrincipal;
                cmbSearchPrincipal.ValueMember = "gp_product_group_id";
                cmbSearchPrincipal.DisplayMember = "gp_group_description";

            }

            DataTable dtSearchProduct = new DataTable();
            dtSearchPrincipal = AppLogic.GetList_Product(clsEventButton.EnumAction.SEARCH.ToString());

            if (dtSearchPrincipal != null)
            {
                cmbSearchProduct.DataSource = dtSearchPrincipal;
                cmbSearchProduct.ValueMember = "product_id";
                cmbSearchProduct.DisplayMember = "product_description";

            }

            cmbSearchProduct.SelectedValue = '0';
            cmbSearchPrincipal.SelectedValue = '0';
        }
     }
}
