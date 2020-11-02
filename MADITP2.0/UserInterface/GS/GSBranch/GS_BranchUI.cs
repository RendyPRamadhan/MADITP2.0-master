using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.Report.GS.GSBranch;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MADITP2._0.userInterface.GS.GSBranch
{
    public partial class GS_BranchUI : Form
    {
        private static GSBranchBL _Model;
        private static GSBranchAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;

        public GS_BranchUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(GS_BranchUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new GSBranchBL();
                Helper = new clsGlobal();
                AppLogic = new GSBranchAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        #region Method Non Event
        private void InitializeObject(GSBranchBL Model)
        {
            ClearDataBinding();
            bindingObjBranch.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            txtBoxBranchID.DataBindings.Clear();
            txtBoxInitial.DataBindings.Clear();
            txtBoxBranch.DataBindings.Clear();
            txtBoxAddress1.DataBindings.Clear();
            txtBoxAddress2.DataBindings.Clear();
            txtBoxAddress3.DataBindings.Clear();
            txtBoxEmail.DataBindings.Clear();
            txtBoxPhone.DataBindings.Clear();
            txtBoxPersonToContact1.DataBindings.Clear();
            txtBoxPersonToContact2.DataBindings.Clear();
            txtBoxSapCode.DataBindings.Clear();
            txtBoxReportHeader.DataBindings.Clear();
            txtBoxBranchManager.DataBindings.Clear();
            txtBoxAdminHead.DataBindings.Clear();
            txtBoxNpwp.DataBindings.Clear();
            txtBoxKoordinatorCC.DataBindings.Clear();
            txtBoxAdminCC.DataBindings.Clear();
            txtBoxTaxInvoiceInitilNum.DataBindings.Clear();
            txtBoxNoPengukuhanPKP.DataBindings.Clear();
            txtBoxFax.DataBindings.Clear();
            txtBoxTitle1.DataBindings.Clear();
            txtBoxTitle2.DataBindings.Clear();
            txtBoxRemark.DataBindings.Clear();
            txtBoxArEntityID.DataBindings.Clear();
            txtBoxArBranchID.DataBindings.Clear();
            txtBoxArDivisionID.DataBindings.Clear();
            txtBoxArDepartementID.DataBindings.Clear();
            txtBoxArMajor1.DataBindings.Clear();
            txtBoxArMajor2.DataBindings.Clear();
            txtBoxArMinor.DataBindings.Clear();
            txtBoxArAnalisys.DataBindings.Clear();
            txtBoxArFilter.DataBindings.Clear();
            dtpTglPengukuhanPKP.DataBindings.Clear();
            cbDefaultBranch.DataBindings.Clear();
            cbPickupPointBranch.DataBindings.Clear();

        }

        private void MappingDataBinding()
        {
            txtBoxBranchID.DataBindings.Add("Text", bindingObjBranch, "branch_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxInitial.DataBindings.Add("Text", bindingObjBranch, "initial", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxBranch.DataBindings.Add("Text", bindingObjBranch, "branch", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress1.DataBindings.Add("Text", bindingObjBranch, "address", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress2.DataBindings.Add("Text", bindingObjBranch, "address2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress3.DataBindings.Add("Text", bindingObjBranch, "address3", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxEmail.DataBindings.Add("Text", bindingObjBranch, "email", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxPhone.DataBindings.Add("Text", bindingObjBranch, "phone", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxPersonToContact1.DataBindings.Add("Text", bindingObjBranch, "person_contact1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxPersonToContact2.DataBindings.Add("Text", bindingObjBranch, "person_contact2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxSapCode.DataBindings.Add("Text", bindingObjBranch, "sap_code", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxReportHeader.DataBindings.Add("Text", bindingObjBranch, "rpt_desc", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxBranchManager.DataBindings.Add("Text", bindingObjBranch, "branch_manager", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAdminHead.DataBindings.Add("Text", bindingObjBranch, "admin_head", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxNpwp.DataBindings.Add("Text", bindingObjBranch, "taxid_npwp", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxKoordinatorCC.DataBindings.Add("Text", bindingObjBranch, "koordinator_cc", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAdminCC.DataBindings.Add("Text", bindingObjBranch, "admin_cc", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxTaxInvoiceInitilNum.DataBindings.Add("Text", bindingObjBranch, "tax_inv_no", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxNoPengukuhanPKP.DataBindings.Add("Text", bindingObjBranch, "no_pengukuhan_pkp", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxFax.DataBindings.Add("Text", bindingObjBranch, "fax", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxTitle1.DataBindings.Add("Text", bindingObjBranch, "person_contact1_title", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxTitle2.DataBindings.Add("Text", bindingObjBranch, "person_contact2_title", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxRemark.DataBindings.Add("Text", bindingObjBranch, "remark", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArEntityID.DataBindings.Add("Text", bindingObjBranch, "ar_entity_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArBranchID.DataBindings.Add("Text", bindingObjBranch, "ar_branch_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArDivisionID.DataBindings.Add("Text", bindingObjBranch, "ar_division_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArDepartementID.DataBindings.Add("Text", bindingObjBranch, "ar_department_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArMajor1.DataBindings.Add("Text", bindingObjBranch, "ar_major1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArMajor2.DataBindings.Add("Text", bindingObjBranch, "ar_major2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArMinor.DataBindings.Add("Text", bindingObjBranch, "ar_minor", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArAnalisys.DataBindings.Add("Text", bindingObjBranch, "ar_analisys", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxArFilter.DataBindings.Add("Text", bindingObjBranch, "ar_filler", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpTglPengukuhanPKP.DataBindings.Add("Value", bindingObjBranch, "tgl_pengukuhan_pkp", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding CbDefaultBranchBind = new Binding("checked", bindingObjBranch, "default_branch");
            CbDefaultBranchBind.Format += new ConvertEventHandler(BindingCheckBoxFromDatabase);
            Binding CbPickupPointBranchBind = new Binding("checked", bindingObjBranch, "pup_flag");
            CbPickupPointBranchBind.Format += new ConvertEventHandler(BindingCheckBoxFromDatabase);
            cbDefaultBranch.DataBindings.Add(CbDefaultBranchBind);
            cbPickupPointBranch.DataBindings.Add(CbPickupPointBranchBind);

        }

        private void BindingCheckBoxFromDatabase(object sender, ConvertEventArgs e)
        {
            string Value = e.Value?.ToString() ?? "";

            if (Value == "Y")
                e.Value = true;
            else if (Value == "N" || string.IsNullOrEmpty(Value))
                e.Value = false;
        }

        private string BindingCheckBoxFromForms(string Flag)
        {
            if (Flag == "True")
                Flag = "Y";
            else if (Flag == "False")
                Flag = "N";

            return Flag;
        }

        private void InitializeGrid(GSBranchBL Model)
        {
            try
            {
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridBranch.AutoGenerateColumns = false;
                    dataGridBranch.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                    lblRows.Text = "Records : " + dataGridBranch.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridBranch.DataSource = null;
                    Alert.PushAlert("Data not found", clsAlert.Type.Info);
                }
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
            var Grid = dataGridBranch;

            _Model = new GSBranchBL()
            {
                branch = $"{txtBoxSearchBranch.Text}",
                branch_id = $"{txtBoxSearchBranchID.Text}",
                initial = $"{txtBoxSearchInitial.Text}"
            };

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    Helper.SetActive(navView);
                    ResetPaginationRules();
                    _Model = new GSBranchBL();
                    InitializeGrid(_Model);
                    txtBoxSearchBranch.Text = string.Empty;
                    txtBoxSearchBranchID.Text = string.Empty;
                    txtBoxSearchInitial.Text = string.Empty;
                    pnlPrint.Show();
                    panelNew.Show();
                    panelView.Show();
                    break;

                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    _Model = new GSBranchBL();
                    Helper.SetActive(navNew);
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
                            FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
                            Helper.SetActive(navEdit);
                            panelNew.Show();
                            panelView.Hide();
                            btnUpdate.Visible = true;
                            btnSave.Visible = false;
                            txtBoxBranchID.ReadOnly = true;
                            string ID = Grid.CurrentRow.Cells["branch_id"].Value.ToString();
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
                                    var ID = Grid.SelectedRows[i].Cells["branch_id"].Value.ToString();
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
                        var DataForPrint = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_BRANCH(_Model));
                       
                        if (DataForPrint.Rows.Count > 0)
                        {
                            FormActiveName = clsEventButton.EnumAction.PRINT.ToString();
                            Helper.SetActive(navPrint);
                            panelNew.Hide();
                            string _TCode = AppLogicGlobal.GetTCode(this.Name.ToString());
                            DataTable dtCompany = AppLogicGlobal.GetCompany();
                            
                            rptGSBranch report = new rptGSBranch();
                            
                            report.SetDataSource(DataForPrint);
                            report.SetParameterValue("lblCompanyName", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); 
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
                        var DataForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_BRANCH(_Model));

                        if (DataForExport.Rows.Count > 0)
                        {
                            clsExcel clExcel = new clsExcel();
                            using (var fbd = new FolderBrowserDialog())
                            {
                                DialogResult result = fbd.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                {
                                    var path = fbd.SelectedPath;
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_BRANCH);
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

        private bool FormValidation(GSBranchBL Model)
        {
            bool IsValid = true;
            string MessageValidation = string.Empty;

            if (string.IsNullOrEmpty(Model.branch_id))
            {
                IsValid = false;
                MessageValidation = "Branch ID is required!";
            }
            else if (string.IsNullOrEmpty(Model.branch))
            {
                IsValid = false;
                MessageValidation = "Branch is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        #endregion

        private void GS_BranchUI_KeyDown(object sender, KeyEventArgs e)
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

        private void GS_BranchUI_Load(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
            KeyPreview = true;
        }

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

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }
 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetPaginationRules();
            _Model = new GSBranchBL()
            {
                branch_id = txtBoxSearchBranchID.Text,
                initial = txtBoxSearchInitial.Text,
                branch = txtBoxSearchBranch.Text
            };
            InitializeGrid(_Model);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGrid(_Model);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGrid(_Model);
        }

        private void panelView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (GSBranchBL)bindingObjBranch.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    Model.default_branch = BindingCheckBoxFromForms(Model.default_branch);
                    Model.pup_flag = BindingCheckBoxFromForms(Model.pup_flag);
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
                var Model = (GSBranchBL)bindingObjBranch.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    Model.default_branch = BindingCheckBoxFromForms(Model.default_branch);
                    Model.pup_flag = BindingCheckBoxFromForms(Model.pup_flag);
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
    }
}