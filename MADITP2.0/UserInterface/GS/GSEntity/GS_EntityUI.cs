using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.Report.GS.GSEntity;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MADITP2._0.userInterface.GS.GSEntity
{
    public partial class GS_EntityUI : Form
    {
        private static GSEntityBL _Model;
        private static GSEntityAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;

        public GS_EntityUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(GS_EntityUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new GSEntityBL();
                Helper = new clsGlobal();
                AppLogic = new GSEntityAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }

        #region Method Non Event

        private void InitializeObject(GSEntityBL Model)
        {
            ClearDataBinding();
            bindingObjEntity.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            txtBoxEntityID.DataBindings.Clear();
            txtBoxEntity.DataBindings.Clear();
            txtBoxEmail.DataBindings.Clear();
            txtBoxAddress1.DataBindings.Clear();
            txtBoxAddress2.DataBindings.Clear();
            txtBoxAddress3.DataBindings.Clear();
            txtBoxCity.DataBindings.Clear();
            txtBoxPostalCode.DataBindings.Clear();
            txtBoxPhone.DataBindings.Clear();
            txtBoxFax.DataBindings.Clear();
            txtBoxUserDefined1.DataBindings.Clear();
            txtBoxUserDefined2.DataBindings.Clear();
            txtBoxPtc1.DataBindings.Clear();
            txtBoxPtc2.DataBindings.Clear();
            txtBoxTitle1.DataBindings.Clear();
            txtBoxTitle2.DataBindings.Clear();
            txtBoxNpwp.DataBindings.Clear();
            txtBoxTaxInvoiceNo.DataBindings.Clear();
            txtBoxNoPengukuhan.DataBindings.Clear();
            dtpTanggalPengukuhan.Value = DateTime.Now;
            dtpTanggalPengukuhan.DataBindings.Clear();
            txtBoxRemark.DataBindings.Clear();
            cbBranch.DataBindings.Clear();
            cbDivision.DataBindings.Clear();
            cbDepartement.DataBindings.Clear();
            cbFiller.DataBindings.Clear();
            cbDefault.DataBindings.Clear();
        }

        private void MappingDataBinding()
        {
            txtBoxEntityID.DataBindings.Add("Text", bindingObjEntity, "entity_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxEntity.DataBindings.Add("Text", bindingObjEntity, "entity", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxEmail.DataBindings.Add("Text", bindingObjEntity, "email", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress1.DataBindings.Add("Text", bindingObjEntity, "address_1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress2.DataBindings.Add("Text", bindingObjEntity, "address_2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress3.DataBindings.Add("Text", bindingObjEntity, "address_3", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxCity.DataBindings.Add("Text", bindingObjEntity, "city", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxPostalCode.DataBindings.Add("Text", bindingObjEntity, "postal_code", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxPhone.DataBindings.Add("Text", bindingObjEntity, "phone", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxFax.DataBindings.Add("Text", bindingObjEntity, "fax", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxUserDefined1.DataBindings.Add("Text", bindingObjEntity, "user_defined1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxUserDefined2.DataBindings.Add("Text", bindingObjEntity, "user_defined2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxPtc1.DataBindings.Add("Text", bindingObjEntity, "ptc1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxPtc2.DataBindings.Add("Text", bindingObjEntity, "ptc2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxTitle1.DataBindings.Add("Text", bindingObjEntity, "title1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxTitle2.DataBindings.Add("Text", bindingObjEntity, "title2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxNpwp.DataBindings.Add("Text", bindingObjEntity, "npwp", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxTaxInvoiceNo.DataBindings.Add("Text", bindingObjEntity, "tax_invoice_no", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxNoPengukuhan.DataBindings.Add("Text", bindingObjEntity, "no_pengukuhan", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxRemark.DataBindings.Add("Text", bindingObjEntity, "remark", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpTanggalPengukuhan.DataBindings.Add("Value", bindingObjEntity, "tgl_pengukuhan", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding CbBranchBind = new Binding("checked", bindingObjEntity, "branch_flag");
            CbBranchBind.Format += new ConvertEventHandler(BindingCheckBoxFromDatabase);
            Binding CbDivisionBind = new Binding("checked", bindingObjEntity, "division_flag");
            CbDivisionBind.Format += new ConvertEventHandler(BindingCheckBoxFromDatabase);
            Binding CbDepartementBind = new Binding("checked", bindingObjEntity, "department_flag");
            CbDepartementBind.Format += new ConvertEventHandler(BindingCheckBoxFromDatabase);
            Binding CbFillerBind = new Binding("checked", bindingObjEntity, "filler_flag");
            CbFillerBind.Format += new ConvertEventHandler(BindingCheckBoxFromDatabase);
            Binding CbDefaultBind = new Binding("checked", bindingObjEntity, "entity_default");
            CbDefaultBind.Format += new ConvertEventHandler(BindingCheckBoxFromDatabase);
            cbBranch.DataBindings.Add(CbBranchBind);
            cbDivision.DataBindings.Add(CbDivisionBind);
            cbDepartement.DataBindings.Add(CbDepartementBind);
            cbFiller.DataBindings.Add(CbFillerBind);
            cbDefault.DataBindings.Add(CbDefaultBind);
        }

        private bool FormValidation(GSEntityBL Model)
        {
            bool IsValid = true;
            string MessageValidation = string.Empty;

            if (string.IsNullOrEmpty(Model.entity_id))
            {
                IsValid = false;
                MessageValidation = "Entity ID is required!";
            }
            else if (string.IsNullOrEmpty(Model.entity))
            {
                IsValid = false;
                MessageValidation = "Entity is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        private void BindingCheckBoxFromDatabase(object sender, ConvertEventArgs e)
        {
            string Value = e.Value?.ToString() ?? string.Empty;

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

        private void InitializeGrid(GSEntityBL Model)
        {
            try
            {
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridEntity.AutoGenerateColumns = false;
                    dataGridEntity.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                    lblRows.Text = "Records : " + dataGridEntity.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridEntity.DataSource = null;
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
            var Grid = dataGridEntity;

            _Model = new GSEntityBL()
            {
                entity_id = $"{txtBoxSearchEntityID.Text}",
                entity = $"{txtBoxSearchEntity.Text}"
            };

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    Helper.SetActive(navView);
                    _Model = new GSEntityBL();
                    ResetPaginationRules();
                    InitializeGrid(_Model);
                    txtBoxSearchEntityID.Text = string.Empty;
                    txtBoxSearchEntity.Text = string.Empty;
                    pnlPrint.Show();
                    panelNew.Show();
                    panelView.Show();
                    break;

                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    _Model = new GSEntityBL();
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
                        else if (Grid.SelectedRows.Count == 0)
                        {
                            Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
                            Helper.SetActive(navEdit);
                            panelNew.Show();
                            panelView.Hide();
                            btnUpdate.Visible = true;
                            btnSave.Visible = false;
                            var ID = Grid.CurrentRow.Cells["entity_id"].Value.ToString();
                            var DataFromDB = AppLogic.GetByID(ID);
                            InitializeObject(DataFromDB);
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
                                    var ID = Grid.SelectedRows[i].Cells["entity_id"].Value.ToString();
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
                        var DataForPrint = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_ENTITY(_Model));
                        if (DataForPrint.Rows.Count > 0)
                        {
                            FormActiveName = clsEventButton.EnumAction.PRINT.ToString();
                            Helper.SetActive(navPrint);
                            panelNew.Hide();
                            string _TCode = AppLogicGlobal.GetTCode(this.Name.ToString());
                            DataTable dtCompany = AppLogicGlobal.GetCompany();
                            rptGSEntity report = new rptGSEntity();
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
                        FormActiveName = clsEventButton.EnumAction.EXPORT.ToString();
                        var DataForExport = AppLogicGlobal.GetReport(HelperReport.REPORT_GS_ENTITY(_Model));

                        if (DataForExport.Rows.Count > 0)
                        {
                            clsExcel clExcel = new clsExcel();
                            using (var fbd = new FolderBrowserDialog())
                            {
                                DialogResult result = fbd.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                {
                                    var path = fbd.SelectedPath;
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_ENTITY);
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

        #endregion

        private void GS_EntityUI_KeyDown(object sender, KeyEventArgs e)
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

        private void GS_EntityUI_Load(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
            KeyPreview = true;
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.NEW);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.EDIT);
        }

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGrid(_Model);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GSEntityBL Model = (GSEntityBL)bindingObjEntity.DataSource;
                var IsValid = FormValidation(Model);

                if (IsValid)
                {
                    Model.branch_flag = BindingCheckBoxFromForms(Model.branch_flag);
                    Model.division_flag = BindingCheckBoxFromForms(Model.division_flag);
                    Model.department_flag = BindingCheckBoxFromForms(Model.department_flag);
                    Model.filler_flag = BindingCheckBoxFromForms(Model.filler_flag);
                    Model.entity_default = BindingCheckBoxFromForms(Model.entity_default);

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
                GSEntityBL Model = (GSEntityBL)bindingObjEntity.DataSource;
                var IsValid = FormValidation(Model);

                if (IsValid)
                {
                    Model.branch_flag = BindingCheckBoxFromForms(Model.branch_flag);
                    Model.division_flag = BindingCheckBoxFromForms(Model.division_flag);
                    Model.department_flag = BindingCheckBoxFromForms(Model.department_flag);
                    Model.filler_flag = BindingCheckBoxFromForms(Model.filler_flag);
                    Model.entity_default = BindingCheckBoxFromForms(Model.entity_default);

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

        private void txtBoxPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Model = new GSEntityBL()
            {
                entity_id = txtBoxSearchEntityID.Text,
                entity = txtBoxSearchEntity.Text
            };
            InitializeGrid(_Model);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGrid(_Model);
        }

    }
}