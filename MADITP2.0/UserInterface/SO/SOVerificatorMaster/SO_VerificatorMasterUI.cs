using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.businessLogic.SO;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.Report.SO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.userInterface.SO.SOVerificatorMaster
{
    public partial class SO_VerificatorMasterUI : Form
    {
        clsGlobal Helper;
        GlobalAL GlobalAL;
        clsReport clsReport;
        clsEventButton clsEventButton;
        SOVerificatorMasterBL SOVerificatorMasterBL;
        SOVerificatorMasterAL SOVerificatorMasterAL;
        clsAlert clsAlert;
        private int _CurrentPage, _FetchLimit, _TotalPage;
        private string _ExistForm, _UserEntityID, _UserBranchID, _UserDivisionID;

        public SO_VerificatorMasterUI()
        {

            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.SO_VerificatorMasterUI_KeyDown);
            this.txtMaxValueVerificator.KeyPress += new KeyPressEventHandler(this.txtMaxValueVerificator_KeyPress);
            this.txtMaxNumberKP.KeyPress += new KeyPressEventHandler(this.txtMaxNumberKP_KeyPress);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                GlobalAL = new GlobalAL(Helper);
                clsReport = new clsReport();
                SOVerificatorMasterAL = new SOVerificatorMasterAL(Helper);
                clsEventButton = new clsEventButton();
                clsAlert = new clsAlert();
            }
        }

        private void clearView()
        {
            txtVerificatorIDView.Text = string.Empty;
            txtVerificatorNameView.Text = string.Empty;
        }

        private void clearEditor()
        {
            if(_UserEntityID.Trim() != "0"){ cboEntity.SelectedValue = _UserEntityID; } else { cboEntity.SelectedIndex = 0; }
            if (_UserBranchID.Trim() != "0") { cboBranch.SelectedValue = _UserBranchID.Trim(); } else { cboBranch.SelectedIndex = 0; }
            if (_UserDivisionID.Trim() != "0") { cboDivision.SelectedValue = _UserDivisionID; } else { cboDivision.SelectedIndex = 0; }
            txtVerificatorIDEditor.Text = string.Empty;
            txtVerificatorNameEditor.Text = string.Empty;
            txtShortName.Text = string.Empty;
            txtNIK.Text = string.Empty;
            txtVerificatorLevel.Text = string.Empty;
            txtMaxValueVerificator.Text = string.Empty;
            txtMaxNumberKP.Text = string.Empty;
            txtDefaultCode.Text = string.Empty;
            cboSupervisor.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }

        private void SO_VerificatorMasterUI_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Tab)
            {
                clsEventButton.EnumAction _ActionType = clsEventButton.getEventType(e.KeyCode.ToString());

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
                    case clsEventButton.EnumAction.EXIT:
                        {
                            navClose_Click(null, null);
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

        private void Pagination(Boolean onloading = false)
        {
            if (_TotalPage == 0)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                return;
            }

            if (_TotalPage == _CurrentPage)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                if (_CurrentPage > 1)
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

            if (_CurrentPage < 2)
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

        private string getVerificatorID()
        {
            string _VerificatorID = string.Empty;
            if (grd.Rows.Count > 0)
            {
                int i;
                i = grd.CurrentCell.RowIndex;
                _VerificatorID = grd["svm_verificator_id", i].Value.ToString();
            }

            return _VerificatorID;
        }

        private void DrawDatatable()
        {
            //GET DATA FOR GRID
            SOVerificatorMasterBL = new SOVerificatorMasterBL()
            {
                verificator_id = txtVerificatorIDView.Text.Trim(),
                verificator_name = txtVerificatorNameView.Text.Trim()
            };

            DataTable dt = SOVerificatorMasterAL.Read(EnumFilter.GET_WITH_PAGING, SOVerificatorMasterBL, _CurrentPage, _FetchLimit);
            grd.AutoGenerateColumns = false;
            grd.DataSource = dt;

            //GET COUNT FOR PAGING
            DataTable dtCount = SOVerificatorMasterAL.Read(EnumFilter.GET_COUNT_ROWS, SOVerificatorMasterBL, _CurrentPage, _FetchLimit);
            _TotalPage = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
            if (Convert.ToInt32(_TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + _CurrentPage.ToString() + " / " + _TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
            lblRows.Text = "Records : " + grd.Rows.Count.ToString() + " Rows";
            Pagination();
        }

        private bool DrawProperty()
        {
            // GET DATA FOR PROCESS EDITING
            bool _Result = false;
            string _VerID = getVerificatorID();
            SOVerificatorMasterBL = new SOVerificatorMasterBL()
            {
                verificator_id = _VerID
            };

            DataTable dt = SOVerificatorMasterAL.Read(EnumFilter.GET_SEARCH_ID, SOVerificatorMasterBL, _CurrentPage, _FetchLimit);
            if(dt.Rows.Count > 0)
            {
                cboEntity.SelectedValue = dt.Rows[0]["svm_entity_id"].ToString();
                cboBranch.SelectedValue = dt.Rows[0]["svm_branch_id"].ToString();
                cboDivision.SelectedValue = dt.Rows[0]["svm_division_id"].ToString();
                txtVerificatorIDEditor.Text = dt.Rows[0]["svm_verificator_id"].ToString();
                txtVerificatorNameEditor.Text = dt.Rows[0]["svm_verificator_name"].ToString();
                txtShortName.Text = dt.Rows[0]["svm_short_name"].ToString();
                txtNIK.Text = dt.Rows[0]["svm_nik_num"].ToString();
                txtVerificatorLevel.Text = dt.Rows[0]["svm_verificator_level"].ToString();
                txtMaxValueVerificator.Text = dt.Rows[0]["svm_max_value_for_verification"].ToString();
                txtMaxNumberKP.Text = dt.Rows[0]["svm_max_num_of_kp"].ToString();
                txtDefaultCode.Text = dt.Rows[0]["svm_default_area_id"].ToString();
                cboSupervisor.SelectedValue = dt.Rows[0]["svm_supervisor_id"].ToString();
                if(dt.Rows[0]["svm_active_flag"].ToString().Trim() == "A") {cboStatus.SelectedIndex = 0;} else {cboStatus.SelectedIndex = 1;}

                _Result = true;
            }

            return _Result;
        }

        private bool PrintReport()
        {
            // GET DATA FOR PROCESS EDITING
            bool _Result = false;

            DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_MASTER_VERIFICATOR(txtVerificatorIDView.Text.Trim().ToUpper(), txtVerificatorNameView.Text.Trim().ToUpper()));
            if (dt.Rows.Count > 0)
            {
                //get TCode menu
                string _TCode = GlobalAL.GetTCode(this.Name.ToString());
                DataTable dtCompany = GlobalAL.GetCompany();

                rptSOVerificatorMaster rptSOVerificatorMaster = new rptSOVerificatorMaster();
                rptSOVerificatorMaster.SetDataSource(dt);
                rptSOVerificatorMaster.SetParameterValue("lblCompany", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); ;
                rptSOVerificatorMaster.SetParameterValue("lblTCode", _TCode.ToUpper());
                rptViewer.ReportSource = rptSOVerificatorMaster;

                _Result = true;
            }

            return _Result;
        }

        private void SettingVariable()
        {
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
            _CurrentPage = 1;
            _TotalPage = 0;
        }

        private void settingPanel(clsEventButton.EnumAction _ActionType)
        {
            switch (_ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    {
                        if (_ExistForm != "VIEW")
                        {
                            clearView();

                            txtVerificatorIDView.Focus();
                            pnlView.Visible = true;
                            pnlEditor.Visible = false;
                            pnlPrint.Visible = false;
                            _ExistForm = "VIEW";
                            setToolTip();

                            DrawDatatable();

                            Helper.SetActive(navView);
                        }
                        break;
                    }
                case clsEventButton.EnumAction.NEW:
                    {
                        if (_ExistForm != "NEW")
                        {
                            clearEditor();

                            btnSave.Text = "SAVE";
                            txtVerificatorIDEditor.ReadOnly = false;
                            txtVerificatorIDEditor.Focus();
                            pnlView.Visible = false;
                            pnlEditor.Visible = true;
                            pnlPrint.Visible = false;
                            _ExistForm = "NEW";
                            setToolTip();

                            Helper.SetActive(navNew);
                        }
                        break;
                    }
                case clsEventButton.EnumAction.EDIT:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            if(grd.Rows.Count > 0)
                            {
                                //load value
                                bool _result = DrawProperty();
                                if (_result == true)
                                {
                                    btnSave.Text = "UPDATE";
                                    txtVerificatorIDEditor.ReadOnly = true;
                                    txtVerificatorIDEditor.Focus();
                                    pnlView.Visible = false;
                                    pnlEditor.Visible = true;
                                    pnlPrint.Visible = false;
                                    _ExistForm = "EDIT";
                                    setToolTip();

                                    Helper.SetActive(navEdit);
                                }
                                else
                                {
                                    clsAlert.PushAlert("Verificator ID not found!", clsAlert.Type.Error);
                                }
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Select Data on View Menu First!", clsAlert.Type.Warning);
                        }
                        break;
                    }
                case clsEventButton.EnumAction.DELETE:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            if (grd.Rows.Count > 0)
                            {
                                //load value
                                bool _result = DrawProperty();
                                if (_result == true)
                                {
                                    btnSave.Text = "DELETE";
                                    txtVerificatorIDEditor.ReadOnly = true;
                                    txtVerificatorIDEditor.Focus();
                                    pnlView.Visible = false;
                                    pnlEditor.Visible = true;
                                    pnlPrint.Visible = false;
                                    _ExistForm = "DELETE";
                                    setToolTip();

                                    Helper.SetActive(navDelete);
                                }
                                else
                                {
                                    clsAlert.PushAlert("Verificator ID not found!", clsAlert.Type.Error);
                                }
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Select Data on View Menu First!", clsAlert.Type.Warning);
                        }
                        break;
                    }
                case clsEventButton.EnumAction.PRINT:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            if (grd.Rows.Count > 0)
                            {
                                bool _result = PrintReport();
                                if (_result == true)
                                {
                                    pnlView.Visible = false;
                                    pnlEditor.Visible = false;
                                    pnlPrint.Visible = true;
                                    _ExistForm = "PRINT";
                                    setToolTip();

                                    Helper.SetActive(navPrint);
                                }
                                else
                                {
                                    clsAlert.PushAlert("Error Loading Data!", clsAlert.Type.Error);
                                }
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                        }
                        break;
                    }
                case clsEventButton.EnumAction.EXPORT:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_MASTER_VERIFICATOR(txtVerificatorIDView.Text.Trim().ToUpper(), txtVerificatorNameView.Text.Trim().ToUpper()));
                            if (dt.Rows.Count > 0)
                            {
                                clsExcel clExcel = new clsExcel();
                                using (var fbd = new FolderBrowserDialog())
                                {
                                    DialogResult result = fbd.ShowDialog();
                                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                    {
                                        var path = fbd.SelectedPath;
                                        clExcel.ExportToExcel(path, dt, EnumExcel.REPORT_MASTER_VERIFICATOR);
                                        MessageBox.Show("The data successfully generated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        Helper.SetActive(navView);
                                    }
                                }
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                        }
                        break;
                    }
                case clsEventButton.EnumAction.EXIT:
                    {
                        Close();
                        break;
                    }
                case clsEventButton.EnumAction.CANCEL:
                    {
                        if (_ExistForm != "VIEW")
                        {
                            clearView();

                            txtVerificatorIDView.Focus();
                            pnlView.Visible = true;
                            pnlEditor.Visible = false;
                            pnlPrint.Visible = false;
                            _ExistForm = "VIEW";
                            setToolTip();

                            DrawDatatable();
                        }
                        break;
                    }
                default:
                    {
                        txtVerificatorIDView.Focus();
                        pnlView.Visible = true;
                        pnlEditor.Visible = false;
                        pnlPrint.Visible = false;
                        _ExistForm = "VIEW";
                        setToolTip();
                        break;
                    }
                    
            }
        }

        private void loadComboBox()
        {
            //LOAD ENTITY
            cboEntity.DataSource = SOVerificatorMasterAL.GetEntity(false);
            cboEntity.ValueMember = "ValueMember";
            cboEntity.DisplayMember = "DisplayMember";

            if (_UserEntityID.Trim() != "0")
            {
                cboEntity.Enabled = false;
                cboEntity.SelectedValue = _UserEntityID;
            }
            else
            {
                cboEntity.Enabled = true;
                cboEntity.SelectedIndex = 0;
            }

            //LOAD BRANCH
            cboBranch.DataSource = SOVerificatorMasterAL.GetBranch(false);
            cboBranch.ValueMember = "ValueMember";
            cboBranch.DisplayMember = "DisplayMember";

            if (_UserBranchID.Trim() != "0")
            {
                cboBranch.Enabled = false;
                cboBranch.SelectedValue = _UserBranchID;
            }
            else
            {
                cboBranch.Enabled = true;
                cboBranch.SelectedIndex = 0;
            }

            //LOAD DIVISION
            cboDivision.DataSource = SOVerificatorMasterAL.GetDivision(false);
            cboDivision.ValueMember = "ValueMember";
            cboDivision.DisplayMember = "DisplayMember";

            if (_UserDivisionID.Trim() != "0")
            {
                cboDivision.Enabled = false;
                cboDivision.SelectedValue = _UserDivisionID;
            }
            else
            {
                cboDivision.Enabled = true;
                cboDivision.SelectedIndex = 0;
            }

            //LOAD SUPERVISOR
            cboSupervisor.DataSource = SOVerificatorMasterAL.GetSupervisorToComboBox();
            cboSupervisor.ValueMember = "ValueMember";
            cboSupervisor.DisplayMember = "DisplayMember";

            //LOAD STATUS
            //cboStatus.Items.Add(" - Select - ");
            cboStatus.Items.Add("ACTIVE");
            cboStatus.Items.Add("NO ACTIVE");
            cboStatus.SelectedIndex = 0;
        }

        private void getPropertyUser()
        {
            DataTable dt = SOVerificatorMasterAL.GetPropertyUser();
            _UserEntityID = dt.Rows[0]["usr_entity_id"].ToString();
            _UserBranchID = dt.Rows[0]["usr_branch_id"].ToString();
            _UserDivisionID = dt.Rows[0]["usr_Division_id"].ToString();
            //_UserGroupID = dt.Rows[0]["usr_group_id"].ToString();
        }

        public void setToolTip()
        {
            ToolTip toolTipView = new ToolTip();
            toolTipView.ShowAlways = true;
            toolTipView.SetToolTip(navView, "VIEW [F12]");

            ToolTip toolTipNew = new ToolTip();
            toolTipNew.ShowAlways = true;
            toolTipNew.SetToolTip(navNew, "NEW [F1]");

            ToolTip toolTipEdit = new ToolTip();
            toolTipEdit.ShowAlways = true;
            toolTipEdit.SetToolTip(navEdit, "EDIT [F2]");

            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.ShowAlways = true;
            toolTipDelete.SetToolTip(navDelete, "DELETE [F3]");

            ToolTip toolTipPrint = new ToolTip();
            toolTipPrint.ShowAlways = true;
            toolTipPrint.SetToolTip(navPrint, "PRINT [F4]");

            ToolTip toolTipExport = new ToolTip();
            toolTipExport.ShowAlways = true;
            toolTipExport.SetToolTip(navExport, "EXPORT [F5]");

            ToolTip toolTipSearch = new ToolTip();
            toolTipSearch.ShowAlways = true;
            toolTipSearch.SetToolTip(btnSearch, "SEARCH [F6]");

            ToolTip toolTipCancel = new ToolTip();
            toolTipCancel.ShowAlways = true;
            toolTipCancel.SetToolTip(btnCancel, "CANCEL [F9]");

            ToolTip toolTipSave = new ToolTip();
            toolTipSave.ShowAlways = true;
            if(_ExistForm == "NEW")
            {
                toolTipSave.SetToolTip(btnSave, "SAVE [F10]");
            }
            else if (_ExistForm == "EDIT")
            {
                toolTipSave.SetToolTip(btnSave, "UPDATE [F10]");
            }
            else if (_ExistForm == "DELETE")
            {
                toolTipSave.SetToolTip(btnSave, "DELETE [F10]");
            }

            ToolTip toolTipExit = new ToolTip();
            toolTipExit.ShowAlways = true;
            toolTipExit.SetToolTip(navClose, "EXIT [ESC]");
        }

        private void SO_VerificatorMasterUI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;

            SettingVariable();
            getPropertyUser();
            navView_Click(navView, null);

            loadComboBox();
        }

        private bool checkValidation()
        {
            bool _isPassed = false;

            if (txtVerificatorIDEditor.Text.Trim().Length > 0)
            {
                if (txtVerificatorNameEditor.Text.Trim().Length > 0)
                {
                    if (txtShortName.Text.Trim().Length > 0)
                    {
                        if (txtNIK.Text.Trim().Length > 0)
                        {
                            if (txtVerificatorLevel.Text.Trim().Length > 0)
                            {
                                if (txtMaxValueVerificator.Text.Trim().Length > 0)
                                {
                                    if (txtMaxNumberKP.Text.Trim().Length > 0)
                                    {
                                        if (txtDefaultCode.Text.Trim().Length > 0)
                                        {
                                             _isPassed = true;
                                        }
                                        else
                                        {
                                            clsAlert.PushAlert("Default Area Code Required!", clsAlert.Type.Error);
                                            txtDefaultCode.Focus();
                                            _isPassed = false;
                                        }
                                    }
                                    else
                                    {
                                        clsAlert.PushAlert("Max. Number of KP Required!", clsAlert.Type.Error);
                                        txtMaxNumberKP.Focus();
                                        _isPassed = false;
                                    }
                                }
                                else
                                {
                                    clsAlert.PushAlert("Max. Value for Verificator Required!", clsAlert.Type.Error);
                                    txtMaxValueVerificator.Focus();
                                    _isPassed = false;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Verificator Level Required!", clsAlert.Type.Error);
                                txtVerificatorLevel.Focus();
                                _isPassed = false;
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("NIK Number Required!", clsAlert.Type.Error);
                            txtNIK.Focus();
                            _isPassed = false;
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Short Name Required!", clsAlert.Type.Error);
                        txtShortName.Focus();
                        _isPassed = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("Verificator Name Required!", clsAlert.Type.Error);
                    txtVerificatorNameEditor.Focus();
                    _isPassed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("Verificator ID Required!", clsAlert.Type.Error);
                txtVerificatorIDEditor.Focus();
                _isPassed = false;
            }

            return _isPassed;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkValidation() == true)
            {
                string _Active = string.Empty;
                if (cboStatus.SelectedIndex == 1) { _Active = "A"; } else { _Active = "N"; }

                SOVerificatorMasterBL = new SOVerificatorMasterBL()
                {
                    entity_id = cboEntity.SelectedValue.ToString(),
                    branch_id = cboBranch.SelectedValue.ToString(),
                    division_id = cboDivision.SelectedValue.ToString(),
                    verificator_id = txtVerificatorIDEditor.Text.Trim(),
                    verificator_name = txtVerificatorNameEditor.Text.Trim(),
                    short_name = txtShortName.Text.Trim(),
                    nik_num = txtNIK.Text.Trim(),
                    verificator_level = txtVerificatorLevel.Text.Trim(),
                    max_value_for_verification = Convert.ToInt64(txtMaxValueVerificator.Text.Trim()),
                    max_num_of_kp = Convert.ToInt64(txtMaxNumberKP.Text.Trim()),
                    default_area_id = txtDefaultCode.Text.Trim(),
                    supervisor_id = cboSupervisor.SelectedValue.ToString(),
                    active_flag = _Active
                };

                if (_ExistForm == "NEW")
                {
                    if (clsDialog.ShowDialog("Save New Verificator ID ?") == DialogResult.Yes)
                    {
                        bool _isSucess = SOVerificatorMasterAL.Post(SOVerificatorMasterBL);
                        if (_isSucess == true)
                        {
                            clearEditor();
                            txtVerificatorIDEditor.Focus();
                        }
                    }
                }
                else if(_ExistForm == "EDIT")
                {
                    if (clsDialog.ShowDialog("Update Verificator ID " + txtVerificatorIDEditor.Text.Trim() + " ?") == DialogResult.Yes)
                    {
                        bool _isSucess = SOVerificatorMasterAL.Put(SOVerificatorMasterBL);
                        if (_isSucess == true)
                        {
                            clearEditor();
                            navView_Click(null, null);
                        }
                    }
                }
                else if (_ExistForm == "DELETE")
                {
                    if (clsDialog.ShowDialog("Delete Verificator ID " + txtVerificatorIDEditor.Text.Trim() + " ?") == DialogResult.Yes)
                    {
                        bool _isSucess = SOVerificatorMasterAL.Delete(SOVerificatorMasterBL);
                        if (_isSucess == true)
                        {
                            clearEditor();
                            navView_Click(null, null);
                        }
                    }
                }
            }
        }

        private void navView_Click(object sender, EventArgs e)
        {
            SettingVariable();
            settingPanel(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.NEW);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EDIT);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.DELETE);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.PRINT);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
            Pagination(true);
            DrawDatatable();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _CurrentPage--;
            Pagination(true);
            DrawDatatable();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _CurrentPage++;
            Pagination(true);
            DrawDatatable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SettingVariable();
            settingPanel(clsEventButton.EnumAction.CANCEL);
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXPORT);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXIT);
        }

        private void txtMaxValueVerificator_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.NumericOnly(txtMaxValueVerificator, e);
        }

        private void txtMaxNumberKP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.NumericOnly(txtMaxNumberKP, e);
        }
    }
}
