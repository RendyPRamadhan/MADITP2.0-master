using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using ClosedXML.Excel;
using System.IO;
//using ExcelLibrary.SpreadSheet;
//using Renderers.Renderers;
using System.Collections;
using ExcelDataReader;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.ApplicationLogic;
//using CrystalDecisions.CrystalReports.Engine;

namespace MADITP2._0.UserInterface.SO.SOUploadResiPCP
{
    public partial class SOUploadResiPCPUI : Form
    {
        DataTable dt = new DataTable();
        private static GlobalAL AppLogicGlobal;
        private SOUploadResiPCPAL AppLogic;
        private SOUploadResiPCPBL _Model;
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
        DataTableCollection tableCollection;
        //ReportDocument cryRpt;
        public SOUploadResiPCPUI()
        {
            InitializeComponent();
            Alert = new clsAlert();
            _Model = new SOUploadResiPCPBL();
            Helper = new clsGlobal();
            AppLogic = new SOUploadResiPCPAL(Helper);
            ClsEventButton = new clsEventButton();
            FormMode(clsEventButton.EnumAction.VIEW);
            AppLogicGlobal = new GlobalAL(Helper);
            DrawFilterCombobox(); 
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Model = new SOUploadResiPCPBL();
            this.Search(ref _Model);

            InitializeGrid(_Model);
        }
        private void Search(ref SOUploadResiPCPBL Model)
        {
           // Model.NOKP = "";
        }

     
        private void navExport_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EXPORT);
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
                    _Model = new SOUploadResiPCPBL();
                    //InitializeGrid(_Model);
                    PanelFormView.BringToFront();
                    cmbWH.SelectedValue = "";
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    break;

                case clsEventButton.EnumAction.NEW:

                case clsEventButton.EnumAction.EDIT:


                case clsEventButton.EnumAction.DELETE:


                case clsEventButton.EnumAction.PRINT:

                case clsEventButton.EnumAction.EXPORT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        FormActiveName = clsEventButton.EnumAction.EXPORT.ToString();
                        _Model = new SOUploadResiPCPBL();

                        this.Search(ref _Model);

                        var DataForExport = AppLogic.GetAllPaging_Export(_Model, CurrentPage);

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
        public void InitializeGrid(SOUploadResiPCPBL Model)
        {
            try
            {
                DataTable data = AppLogic.GetAllPaging_Upload(_Model, CurrentPage);
                dgvResult.AutoGenerateColumns = false;
                dgvResult.DataSource = data;

                //Paging Initialize
                int DataCount = AppLogic.GetAllCount(Model);
                TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                lblRows.Text = "Records : " + dgvResult.Rows.Count.ToString() + " Rows";
               // PaginationRules();
            }
            catch (Exception ex)
            {
                Alert.PushAlert("Something wrong", clsAlert.Type.Info);
            }
        }

      

        private void DrawFilterCombobox()
        {

            DataTable dtSearchGroup = new DataTable();
            dtSearchGroup = AppLogic.GetList_warehouse(clsEventButton.EnumAction.SEARCH.ToString());
            if (dtSearchGroup != null)
            {
                cmbWH.DataSource = dtSearchGroup;
                cmbWH.ValueMember = "wh_warehouse_id";
                cmbWH.DisplayMember = "wh_description";

            }
        }
        }


 
}
