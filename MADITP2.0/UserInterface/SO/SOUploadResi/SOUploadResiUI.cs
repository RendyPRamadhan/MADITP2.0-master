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
using CrystalDecisions.CrystalReports.Engine;
using MADITP2._0.Report.SO.SOUploadResi;

namespace MADITP2._0.UserInterface.SO.SOUploadResi
{
    public partial class SOUploadResiUI : Form
    {
        DataTable dt = new DataTable();
        private static GlobalAL AppLogicGlobal;
        private SOUploadResiAL AppLogic;
        private SOUploadResiBL _Model;
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
        ReportDocument cryRpt;
        public SOUploadResiUI()
        {
            InitializeComponent();
            //CHECK.Visible = false;
            //dt.Columns.Add("CHECK");
            Alert = new clsAlert();
            _Model = new SOUploadResiBL();
            Helper = new clsGlobal();
            AppLogic = new SOUploadResiAL(Helper);
            ClsEventButton = new clsEventButton();
            FormMode(clsEventButton.EnumAction.VIEW);
            AppLogicGlobal = new GlobalAL(Helper);
        }
        /*
        public static String StrReverse(string ToReverse)
        {
            Array arr = ToReverse.ToCharArray();
            Array.Reverse(arr);// reverse the string
            char[] c = (char[])arr;
            byte[] b = System.Text.Encoding.Default.GetBytes(c);
            return System.Text.Encoding.Default.GetString(b);

        }*/
       
        

        private void cmbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cmbSheet.SelectedItem.ToString()];
            dgvResult.DataSource = dt;
            /*if (dt != null)
            {
                List<String> resi = new list<String>();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    resi
                }
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
         
            if(chkAll.Checked)
            {
                for (Int32 i = 0; i < dgvResult.RowCount; i++)
                {
                    dt.Rows[i]["CHECK"] = true;
                }
            }
            else
            {
                for (Int32 i = 0; i < dgvResult.RowCount; i++)
                {
                    dt.Rows[i]["CHECK"] = false;
                }
            }
           
            //dgvResult.DataSource = null;
            dgvResult.DataSource = dt;

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            
            //Insertkan Data Detailnya

            try
            {
                Int32 CountTbl = dgvResult.RowCount;
                foreach (DataRow DRHeader in dt.Select("CHECK =  true"))
                {
                    _Model = new SOUploadResiBL();
                    _Model.NOKP = (DRHeader["NOKP"].ToString());
                    _Model.NOSEQ = (DRHeader["NOSEQ"].ToString());
                    _Model.NOSHP = (DRHeader["NOSHP"].ToString());
                    _Model.RESI = (DRHeader["RESI"].ToString());
                    _Model.EKSPEDISI = (DRHeader["EKSPEDISI"].ToString());


                        bool IsValid = FormValidation(_Model);

                        if (IsValid)
                        {
                            AppLogic.CMD(_Model, SQLQuery);
                            if (SQLQuery == EnumState.Create.ToString())
                                Alert.PushAlert("Success Insert data", clsAlert.Type.Success);
                            else if (SQLQuery == EnumState.Update.ToString())
                                Alert.PushAlert("Success Update data", clsAlert.Type.Success);
                            else if (SQLQuery == EnumState.Delete.ToString())
                                Alert.PushAlert("Success Delete data", clsAlert.Type.Success);

                        }
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }
        private bool FormValidation(SOUploadResiBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.NOKP))
            {
                IsValid = false;
                MessageValidation = "Nomor KP is required!";
            }

            if (string.IsNullOrEmpty(Model.NOSEQ))
            {
                IsValid = false;
                MessageValidation = "Nomor Seq is required!";
            }
            if (string.IsNullOrEmpty(Model.NOSHP))
            {
                IsValid = false;
                MessageValidation = "Nomor SHP is required!";
            }
            if (string.IsNullOrEmpty(Model.RESI))
            {
                IsValid = false;
                MessageValidation = "RESI is required!";
            }
            if (string.IsNullOrEmpty(Model.EKSPEDISI))
            {
                IsValid = false;
                MessageValidation = "Ekspedisi is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }
        public void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
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
        public void InitializeGrid(SOUploadResiBL Model)
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

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFiledialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFiledialog.ShowDialog() == DialogResult.OK)
                {
                    txtSearchBankTypeID.Text = openFiledialog.FileName;
                    using (var stream = File.Open(openFiledialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cmbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cmbSheet.Items.Add(table.TableName);//add sheet to cmb

                        }

                        dt = new DataTable();
                        dt = tableCollection["Sheet1"];
                        dt.Columns.Add("CHECK");
                        dt.Columns.Add("NUM");
                        dgvResult.DataSource = dt;
                        for (Int32 i = 0; i < dgvResult.RowCount; i++)
                        {
                            dt.Rows[i]["NUM"] = i + 1;
                        }
                        dgvResult.DataSource = dt;

                    }
                }
            }
            /*
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {


       String sR, sP;
       //String FileName;
       txtSearchBankTypeID.Text = openFileDialog1.FileName;
       FileInfo FileDetails = new FileInfo(openFileDialog1.FileName);

       sR = Class.clsGlobal.StrReverse(openFileDialog1.FileName);
       sP = openFileDialog1.FileName.Substring(0, openFileDialog1.FileName.Length - sR.IndexOf("\\"));

       //Int32 Get_Last_Slash = 0;
       //Get_Last_Slash = openFileDialog1.FileName.LastIndexOf("\\");

       //frmFileImport FrmImport = new frmFileImport(btnImportItemDefault.EditValue.ToString(), GVContRpr, frmFileImport.EnumImportType.ImportConfigEAS, this, null, "");
       //FrmImport.WindowState = FormWindowState.Maximized;
       //FrmImport.ShowDialog();
       //if (FrmImport.iReturn > 0)
       //{
       //    this.RefreshData();

       //}

       //FrmImport.Dispose();
       //FileName = openFileDialog1.FileName.Remove(0, Get_Last_Slash + 1);

       //txtFileSize.EditValue = FileDetails.Length.ToString();
       FileDetails = null;

   }
             */

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Model = new SOUploadResiBL();
            this.Search(ref _Model);

            InitializeGrid(_Model);

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

        private void Search(ref SOUploadResiBL Model)
        {
            Model.NOKP = ""; 
        }
        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            var Grid = dgvResult;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    ResetPaginationRules();
                    _Model = new SOUploadResiBL();
                    InitializeGrid(_Model);
                    PanelFormCreate.BringToFront();
                    groupBoxSelectFile.Visible = false;
                    groupBoxSearch.Visible = true;
                    GroupBoxProcess.Visible = false;

                    BRANCH.Visible = true;
                    WAREHOUSE.Visible = true;
                    DELIVERYMEN.Visible = true;
                    KP_DATE.Visible = true;
                    NO_INV.Visible = true;
                    INV_DATE.Visible = true;
                    ACT_DELIV_DATE.Visible = true;
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    break;

                case clsEventButton.EnumAction.NEW:
                    _Model = new SOUploadResiBL();
                    dgvResult.DataSource = null;
                    PanelFormCreate.BringToFront();
                    groupBoxSelectFile.Visible = true;
                    groupBoxSearch.Visible = false;
                    GroupBoxProcess.Visible = true;

                    BRANCH.Visible = false;
                    WAREHOUSE.Visible = false;
                    DELIVERYMEN.Visible = false;
                    KP_DATE.Visible = false;
                    NO_INV.Visible = false;
                    INV_DATE.Visible = false;
                    ACT_DELIV_DATE.Visible = false;


                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    SQLQuery = EnumState.Create.ToString();
                    break;

                case clsEventButton.EnumAction.EDIT:
                   

                case clsEventButton.EnumAction.DELETE:
                  

                case clsEventButton.EnumAction.PRINT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        FormActiveName = clsEventButton.EnumAction.PRINT.ToString();
                        PanelFormPrint.BringToFront();
                        _Model = new SOUploadResiBL();

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
                        _Model = new SOUploadResiBL();

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

        public void InitializeReport(SOUploadResiBL Model)
        {
            String ReportPath = "";
            cryRpt = new ReportDocument();
            DataSet data = new DataSet();
            DataTable dt = AppLogic.GetAllPaging(_Model, CurrentPage);

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
                data.Tables.Add(dt);

                //string _TCode = AppLogicGlobal.GetTCode(this.Name.ToString());
                DataTable dtCompany = AppLogicGlobal.GetCompany();

                dtCompany.Columns.Add("mnu_menu_code");
                dtCompany.Rows[0]["mnu_menu_code"] = this.Name.ToString();
                //data.Tables.Remove("Table1");
                data.Tables.Add(dtCompany);

                rptSOUploadResi report = new rptSOUploadResi();
                report.SetDataSource(data);
                rptViewer.ReportSource = report;
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

    }
}
