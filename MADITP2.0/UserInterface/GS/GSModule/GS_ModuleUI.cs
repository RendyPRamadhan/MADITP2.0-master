using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.Report.GS.GSModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.GS.GSModule
{
    public partial class GS_ModuleUI : Form
    {
        private static GSModuleBL _Model;
        private static GSModuleAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;

        public GS_ModuleUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(GS_ModuleUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new GSModuleBL();
                Helper = new clsGlobal();
                AppLogic = new GSModuleAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        private void GS_ModuleUI_KeyDown(object sender, KeyEventArgs e)
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
                    case clsEventButton.EnumAction.NEW:
                        {
                            navNew_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.EDIT:
                        {
                            navEdit_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.DELETE:
                        {
                            navDelete_Click(null, null);
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
                            btnSearch_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.SAVE:
                        {
                            btnSave_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.CANCEL:
                        {
                            btnCancel_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        #region Method Non Event

        private void InitializeObject(GSModuleBL Model)
        {
            ClearDataBinding();
            bindingObjModule.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            txtBoxModuleID.DataBindings.Clear();
            txtBoxDescription.DataBindings.Clear();
        }

        private void MappingDataBinding()
        {
            txtBoxModuleID.DataBindings.Add("Text", bindingObjModule, "module_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxDescription.DataBindings.Add("Text", bindingObjModule, "description", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void InitializeGrid(GSModuleBL Model)
        {
            try
            {
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridModule.AutoGenerateColumns = false;
                    dataGridModule.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                    lblRows.Text = "Records : " + dataGridModule.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridModule.DataSource = null;
                    Alert.PushAlert("Data not found", clsAlert.Type.Info);
                }

            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
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
            var Grid = dataGridModule;

            _Model = new GSModuleBL()
            {
                module_id = $"{txtBoxSearchModuleID.Text}",
                description = $"{txtBoxSearchDescription.Text}"
            };

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    Helper.SetActive(navView);
                    ResetPaginationRules();
                    _Model = new GSModuleBL();
                    InitializeGrid(_Model);
                    txtBoxSearchDescription.Text = string.Empty;
                    txtBoxSearchModuleID.Text = string.Empty;
                    pnlPrint.Show();
                    panelNew.Show();
                    panelView.Show();
                    break;

                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    Helper.SetActive(navNew);
                    _Model = new GSModuleBL();
                    InitializeObject(_Model);
                    panelNew.Show();
                    panelView.Hide();
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    break;

                case clsEventButton.EnumAction.EDIT:
                    if (CheckLastMenuActiveIsView())
                    {
                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else if (Grid.SelectedRows.Count > 1)
                        {
                            Alert.PushAlert("Please Dont Select Multiple Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            panelNew.Show();
                            panelView.Hide();
                            btnUpdate.Visible = true;
                            btnSave.Visible = false;
                            FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
                            Helper.SetActive(navEdit);
                            var ID = Grid.CurrentRow.Cells["module_id"].Value.ToString();
                            var Data = AppLogic.GetByID(ID);
                            InitializeObject(Data);
                        }
                    }
                    break;

                case clsEventButton.EnumAction.DELETE:
                    if (CheckLastMenuActiveIsView())
                    {
                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else if (Grid.SelectedRows.Count == 0)
                        {
                            Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            MessageBoxButtons ButttonDialog = MessageBoxButtons.YesNo;
                            DialogResult ResultDialog = MessageBox.Show("Are You Sure?", "Warning!", ButttonDialog);
                            if (ResultDialog == DialogResult.Yes)
                            {
                                for (int i = 0; i < Grid.SelectedRows.Count; i++)
                                {
                                    var ID = Grid.SelectedRows[i].Cells["module_id"].Value.ToString();
                                    AppLogic.Delete(ID);
                                }
                                Alert.PushAlert("Success Delete Data", clsAlert.Type.Success);
                                FormMode(clsEventButton.EnumAction.VIEW);
                            }
                        }
                    }
                    break;

                case clsEventButton.EnumAction.PRINT:
                    if (CheckLastMenuActiveIsView())
                    {
                        var DataForPrint = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_MODULE(_Model));

                        if (DataForPrint.Rows.Count > 0)
                        {
                            FormActiveName = clsEventButton.EnumAction.PRINT.ToString();
                            Helper.SetActive(navPrint);
                            panelNew.Hide();
                            string _TCode = AppLogicGlobal.GetTCode(this.Name.ToString());
                            DataTable dtCompany = AppLogicGlobal.GetCompany();
                            rptGSModule report = new rptGSModule();
                            report.SetDataSource(DataForPrint);
                            report.SetParameterValue("lblCompanyName", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); ;
                            report.SetParameterValue("lblTCode", _TCode.ToUpper());
                            rptViewer.ReportSource = report;
                        }
                        else
                        {
                            Alert.PushAlert("Data not found", clsAlert.Type.Info);
                        }
                    }
                    break;

                case clsEventButton.EnumAction.EXPORT:
                    if (CheckLastMenuActiveIsView())
                    {
                        var DataForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_MODULE(_Model));

                        if (DataForExport.Rows.Count > 0)
                        {
                            clsExcel clExcel = new clsExcel();
                            using (var fbd = new FolderBrowserDialog())
                            {
                                DialogResult result = fbd.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                {
                                    var path = fbd.SelectedPath;
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_MODULE);
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

        private bool FormValidation(GSModuleBL Model)
        {
            bool IsValid = true;
            string MessageValidation = string.Empty;

            if (string.IsNullOrEmpty(Model.module_id))
            {
                IsValid = false;
                MessageValidation = "Module ID is required!";
            }
            else if (string.IsNullOrEmpty(Model.description))
            {
                IsValid = false;
                MessageValidation = "Description is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        #endregion

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.NEW);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.EDIT);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.DELETE);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.PRINT);
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.EXPORT);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Model = new GSModuleBL()
            {
                module_id = txtBoxSearchModuleID.Text,
                description = txtBoxSearchDescription.Text
            };
            InitializeGrid(_Model);
        }

        private void GS_ModuleUI_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (GSModuleBL)bindingObjModule.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    AppLogic.Insert(Model);
                    Alert.PushAlert("Success insert data", clsAlert.Type.Success);
                    FormMode(clsEventButton.EnumAction.VIEW);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (GSModuleBL)bindingObjModule.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    AppLogic.Update(Model);
                    Alert.PushAlert("Success update data", clsAlert.Type.Success);
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
            FormMode(clsEventButton.EnumAction.VIEW);
        }
    }
}
