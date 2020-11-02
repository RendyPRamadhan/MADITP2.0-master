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

namespace MADITP2._0.userInterface.SO.SO_CancelVerificationUI
{
    public partial class SO_CancelVerificationUI : Form
    {
        clsGlobal Helper;
        GlobalAL GlobalAL;
        clsReport clsReport;
        clsEventButton clsEventButton;
        SOVerificationProcessBL SOVerificationProcessBL;
        SOVerificatorMasterBL SOVerificatorMasterBL;
        SOCancelVerificationAL SOCancelVerificationAL;
        private string _ExistForm;
        clsAlert clsAlert;

        public SO_CancelVerificationUI()
        {

            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                GlobalAL = new GlobalAL(Helper);
                clsReport = new clsReport();
                SOCancelVerificationAL = new SOCancelVerificationAL(Helper);
                SOVerificationProcessBL = new SOVerificationProcessBL();
                SOVerificatorMasterBL = new SOVerificatorMasterBL();
                clsEventButton = new clsEventButton();
                clsAlert = new clsAlert();
            }
        }

        private void loadCollector()
        {
            cboCollector.DataSource = null;
            cboCollector.DataSource = SOCancelVerificationAL.GetCollectorToComboBox(false);
            cboCollector.ValueMember = "ValueMember";
            cboCollector.DisplayMember = "ValueMember";
            cboCollector.SelectedIndex = -1;
        }

        private DateTime getEndingDateCalenderFiscal()
        {
            DateTime _EndingDate = DateTime.Now.Date;

            DataTable dt = SOCancelVerificationAL.GetEndingDateCalenderFiscal();
            _EndingDate = Convert.ToDateTime(dt.Rows[0]["gfc_ending_date"]);

            return _EndingDate;
        }

        private void SO_CancelVerificationUI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;

            navView_Click(navView, null);
        }

        private void SO_CancelVerificationUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {
                clsEventButton clsEventButton = new clsEventButton();
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
                    case clsEventButton.EnumAction.SAVE:
                        {
                            btnProcessCancel_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.CANCEL:
                        {
                            if(pnlMemo.Visible == true)
                            {
                                btnHide_Click(null, null);
                            }

                            break;
                        }
                    case clsEventButton.EnumAction.DISPLAY:
                        {
                            btnList_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void setToolTip()
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

            ToolTip toolTipProcessCancel = new ToolTip();
            toolTipProcessCancel.ShowAlways = true;
            toolTipProcessCancel.SetToolTip(btnProcessCancel, "PROCESS CANCEL [F10]");

            ToolTip toolTipHide = new ToolTip();
            toolTipHide.ShowAlways = true;
            toolTipHide.SetToolTip(btnHide, "HIDE [F9]");

            ToolTip toolTipList = new ToolTip();
            toolTipList.ShowAlways = true;
            toolTipList.SetToolTip(btnList, "LIST [F11]");
        }

        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.SAVE);
        }

        private void navView_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {

        }

        private void navEdit_Click(object sender, EventArgs e)
        {

        }

        private void navDelete_Click(object sender, EventArgs e)
        {

        }

        private void navPrint_Click(object sender, EventArgs e)
        {

        }

        private void navExport_Click(object sender, EventArgs e)
        {

        }

        private void settingPanel(clsEventButton.EnumAction _ActionType)
        {
            switch (_ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    {
                        if (_ExistForm != "VIEW")
                        {
                            pnlView.Visible = true;

                            loadCollector();
                            dtDateOfVisit.Value = getEndingDateCalenderFiscal();
                            txtBAOfficeAddress4.Visible = false;
                            txtDAOfficeAddress4.Visible = false;
                            clear(true);

                            _ExistForm = "VIEW";
                            setToolTip();
                            Helper.SetActive(navView);
                        }

                        break;
                    }
                case clsEventButton.EnumAction.NEW:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.EDIT:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.DELETE:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.PRINT:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.EXPORT:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.EXIT:
                    {
                        Close();
                        break;
                    }
                case clsEventButton.EnumAction.SAVE:
                    {
                        ProcessCancel();
                        break;
                    }
                case clsEventButton.EnumAction.CANCEL:
                    {
                        ProcessHide();
                        break;
                    }
                case clsEventButton.EnumAction.DISPLAY:
                    {
                        ProcessDisplayList();
                        break;
                    }
                default:
                    {
                        pnlView.Visible = false;

                        _ExistForm = "VIEW";
                        setToolTip();
                        Helper.SetActive(navView);
                        break;
                    }
            }
        }

        private void ProcessDisplayList()
        {
            pnlMemo.Width = 1044;
            pnlMemo.Height = 404;

            pnlMemo.Left = 20;
            pnlMemo.Top = 217;

            pnlMemo.Visible = true;
            txtRemarks.Focus();
        }

        private void ProcessHide()
        {
            pnlMemo.Visible = false;

            pnlMemo.Width = 28;
            pnlMemo.Height = 83;

            pnlMemo.Left = 20;
            pnlMemo.Top = 217;
        }

        private void ProcessCancel()
        {
            if (txtKPNo.Text.Trim().Length > 0)
            {
                if (txtEntity.Text.Trim().Length > 0)
                {
                    if (clsDialog.ShowDialog("Are you sure to cancel Verification Status " + txtKPNo.Text.Trim() + "?") == DialogResult.Yes)
                    {
                        SOVerificationProcessBL = new SOVerificationProcessBL()
                        {
                            so_kp_no = txtKPNo.Text.Trim(),
                            verificator_id = txtVerificatorID.Text.Trim(),
                        };

                        bool _isSucess = SOCancelVerificationAL.Delete(SOVerificationProcessBL);
                        if (_isSucess == true)
                        {
                            navView_Click(null, null);
                        }
                    }
                }
                else
                {
                    clsAlert.PushAlert("You have to ENTER the KP Number!", clsAlert.Type.Error);
                    txtKPNo.Focus();
                }
            }
            else
            {
                clsAlert.PushAlert("KP Number required!", clsAlert.Type.Error);
                txtKPNo.Focus();
            }
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXIT);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.DISPLAY);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.CANCEL);
        }

        private bool ValidateKPNo()
        {
            bool _isValid = false;

            if (txtKPNo.Text.Trim().Length > 0)
            {
                DataTable dt = SOCancelVerificationAL.GetStatusKPNo(txtKPNo.Text.Trim());

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["svs_so_kp_num"].ToString() != string.Empty)
                    {                   
                        _isValid = true;
                    }
                    else
                    {
                        clsAlert.PushAlert("KP No not found or hasn't Assign!", clsAlert.Type.Error);
                        txtKPNo.Focus();
                        _isValid = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("KP Number not found!", clsAlert.Type.Error);
                    txtKPNo.Focus();
                    _isValid = false;
                }
            }

            return _isValid;
        }

        private void clear(bool _IncludeKPNo)
        {
            if (_IncludeKPNo == true)
            {
                txtKPNo.Text = string.Empty;
            }

            txtDivision.Text = string.Empty;
            dtKPDate.Value = DateTime.Now.Date;
            txtSumOfVisit.Text = string.Empty;
            txtCustID.Text = string.Empty;
            txtCustName.Text = string.Empty;
            txtRepID.Text = string.Empty;
            txtRepName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtItemSet.Text = string.Empty;
            txtSU.Text = string.Empty;
            txtBV.Text = string.Empty;
            txtPV.Text = string.Empty;
            txtPoint1.Text = string.Empty;
            txtPoint2.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtEntity.Text = string.Empty;
            txtBranch.Text = string.Empty;
            txtVerificatorID.Text = string.Empty;
            txtVerificatorName.Text = string.Empty;
            txtVerificatorName.Tag = string.Empty;
            txtProductDesc.Text = string.Empty;
            txtNoOfInstallment.Text = string.Empty;
            cboCollector.Text = string.Empty;
            cboCollector.SelectedIndex = -1;

            txtStatusVerification.Text = string.Empty;
            txtTelpHP.Text = string.Empty;
            txtTelpKantor.Text = string.Empty;
            txtTelpRumah.Text = string.Empty;

            //---------------------------------------------------------------------------
            //BILLING ADDRESS
            //Group Home
            txtBAHomeAddress1.Text = string.Empty;
            txtBAHomeAddress2.Text = string.Empty;
            txtBAHomeAddress3.Text = string.Empty;
            txtBAHomeRT.Text = string.Empty;
            txtBAHomeRW.Text = string.Empty;
            txtBAHomeZipCode.Text = string.Empty;
            txtBAHomeKelurahan.Text = string.Empty;
            txtBAHomeKecamatan.Text = string.Empty;
            txtBAHomeCity.Text = string.Empty;
            txtBAHomeProvinsi.Text = string.Empty;
            txtBAHomeCollector.Text = string.Empty;

            //Group Office
            txtBAOfficeAddress1.Text = string.Empty;
            txtBAOfficeAddress2.Text = string.Empty;
            txtBAOfficeAddress3.Text = string.Empty;
            txtBAOfficeAddress4.Text = string.Empty;
            txtBAOfficeRT.Text = string.Empty;
            txtBAOfficeRW.Text = string.Empty;
            txtBAOfficeZipCode.Text = string.Empty;
            txtBAOfficeKelurahan.Text = string.Empty;
            txtBAOfficeKecamatan.Text = string.Empty;
            txtBAOfficeCity.Text = string.Empty;
            txtBAOfficeProvinsi.Text = string.Empty;
            txtBAOfficeCollector.Text = string.Empty;

            //Group Other
            txtBAOtherAddress1.Text = string.Empty;
            txtBAOtherAddress2.Text = string.Empty;
            txtBAOtherAddress3.Text = string.Empty;
            txtBAOtherRT.Text = string.Empty;
            txtBAOtherRW.Text = string.Empty;
            txtBAOtherZipCode.Text = string.Empty;
            txtBAOtherKelurahan.Text = string.Empty;
            txtBAOtherKecamatan.Text = string.Empty;
            txtBAOtherCity.Text = string.Empty;
            txtBAOtherProvinsi.Text = string.Empty;
            txtBAOtherCollector.Text = string.Empty;

            //---------------------------------------------------------------------------
            //DELIVERY ADDRESS
            //Group Home
            txtDAHomeAddress1.Text = string.Empty;
            txtDAHomeAddress2.Text = string.Empty;
            txtDAHomeAddress3.Text = string.Empty;
            txtDAHomeRT.Text = string.Empty;
            txtDAHomeRW.Text = string.Empty;
            txtDAHomeZipCode.Text = string.Empty;
            txtDAHomeKelurahan.Text = string.Empty;
            txtDAHomeKecamatan.Text = string.Empty;
            txtDAHomeCity.Text = string.Empty;
            txtDAHomeProvinsi.Text = string.Empty;

            //Group Office
            txtDAOfficeAddress1.Text = string.Empty;
            txtDAOfficeAddress2.Text = string.Empty;
            txtDAOfficeAddress3.Text = string.Empty;
            txtDAOfficeAddress4.Text = string.Empty;
            txtDAOfficeRT.Text = string.Empty;
            txtDAOfficeRW.Text = string.Empty;
            txtDAOfficeZipCode.Text = string.Empty;
            txtDAOfficeKelurahan.Text = string.Empty;
            txtDAOfficeKecamatan.Text = string.Empty;
            txtDAOfficeCity.Text = string.Empty;
            txtDAOfficeProvinsi.Text = string.Empty;

            //Group Other
            txtDAOtherAddress1.Text = string.Empty;
            txtDAOtherAddress2.Text = string.Empty;
            txtDAOtherAddress3.Text = string.Empty;
            txtDAOtherRT.Text = string.Empty;
            txtDAOtherRW.Text = string.Empty;
            txtDAOtherZipCode.Text = string.Empty;
            txtDAOtherKelurahan.Text = string.Empty;
            txtDAOtherKecamatan.Text = string.Empty;
            txtDAOtherCity.Text = string.Empty;
            txtDAOtherProvinsi.Text = string.Empty;

            dtDateOfVisit.Value = getEndingDateCalenderFiscal();
            dtDeliveryDate.Value = getEndingDateCalenderFiscal();
            dtDueDate.Value = getEndingDateCalenderFiscal();
            dtDueDate.Value = dtDueDate.Value.AddMonths(1);

            rbBAHome.Checked = true;
            rbDAHome.Checked = true;
            rbCDSComplete.Checked = true;
            rbCVSOK.Checked = true;
        }

        private void DisplayKPNoDetail()
        {
            DataTable dt = SOCancelVerificationAL.GetKPNoDetail(txtKPNo.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                clear(false);

                txtDivision.Text = dt.Rows[0]["skh_division_id"].ToString();
                dtKPDate.Value = Convert.ToDateTime(dt.Rows[0]["svs_so_kp_date"]);
                txtSumOfVisit.Text = dt.Rows[0]["svs_number_activity"].ToString();
                txtCustID.Text = dt.Rows[0]["skh_customer_id"].ToString();
                txtCustName.Text = dt.Rows[0]["skh_customer_name"].ToString();


                txtAddress.Text = dt.Rows[0]["scm_address1"].ToString() + "   " + dt.Rows[0]["scm_address2"].ToString() + "   " + dt.Rows[0]["scm_address3"].ToString() +
                    "   RT:" + dt.Rows[0]["scm_rt"].ToString() + "   RW:" + dt.Rows[0]["scm_rw"].ToString() + "   " + dt.Rows[0]["scm_kelurahan"].ToString() +
                    "   " + dt.Rows[0]["Kecamatan"].ToString() + "   " + dt.Rows[0]["ZipCode"].ToString() + "   " + dt.Rows[0]["City"].ToString() + "   " + dt.Rows[0]["Province"].ToString();

                txtRepID.Text = dt.Rows[0]["skh_rep_id"].ToString();
                txtRepName.Text = dt.Rows[0]["rm_name"].ToString();

                txtNumber.Text = string.Format("{0:#,##0}", double.Parse(dt.Rows[0]["skh_no_detail_lines"].ToString()));
                txtItemSet.Text = string.Format("{0:#,##0}", double.Parse(dt.Rows[0]["skh_total_item_set_qty"].ToString()));
                txtSU.Text = string.Format("{0:#,##0.0}", double.Parse(dt.Rows[0]["skh_total_su"].ToString()));
                txtBV.Text = string.Format("{0:#,##0}", double.Parse(dt.Rows[0]["skh_total_bv"].ToString()));
                txtPV.Text = string.Format("{0:#,##0}", double.Parse(dt.Rows[0]["skh_total_pv"].ToString()));
                txtPoint1.Text = string.Format("{0:#,##0}", double.Parse(dt.Rows[0]["skh_total_point_1"].ToString()));
                txtPoint2.Text = string.Format("{0:#,##0}", double.Parse(dt.Rows[0]["skh_total_point_2"].ToString()));

                txtProductDesc.Text = dt.Rows[0]["skh_desc"].ToString();

                //For Phone Number
                txtTelpRumah.Text = dt.Rows[0]["scm_home_phone_num"].ToString();
                txtTelpHP.Text = dt.Rows[0]["scm_mobile_phone_num"].ToString();
                txtTelpKantor.Text = dt.Rows[0]["scm_employer_phone"].ToString();

                //-------------------------------------------------------------------------------------------------
                //FOR BILLING ADDRESS
                //Home
                txtBAHomeAddress1.Text = dt.Rows[0]["scm_address1"].ToString();
                txtBAHomeAddress2.Text = dt.Rows[0]["scm_address2"].ToString();
                txtBAHomeAddress3.Text = dt.Rows[0]["scm_address3"].ToString();
                txtBAHomeRT.Text = dt.Rows[0]["scm_rt"].ToString();
                txtBAHomeRW.Text = dt.Rows[0]["scm_rw"].ToString();

                txtBAHomeKelurahan.Text = dt.Rows[0]["scm_kelurahan"].ToString();
                txtBAHomeZipCode.Text = dt.Rows[0]["ZipCode"].ToString();
                txtBAHomeKecamatan.Text = dt.Rows[0]["Kecamatan"].ToString();
                txtBAHomeCity.Text = dt.Rows[0]["City"].ToString();
                txtBAHomeProvinsi.Text = dt.Rows[0]["Province"].ToString();
                txtBAHomeCollector.Text = dt.Rows[0]["home_collector_id"].ToString();

                //Office
                txtBAOfficeAddress1.Text = dt.Rows[0]["scm_last_employer_name"].ToString(); //Column For Company Name
                txtBAOfficeAddress2.Text = dt.Rows[0]["scm_employer_address1"].ToString();
                txtBAOfficeAddress3.Text = dt.Rows[0]["scm_employer_address2"].ToString();
                txtBAOfficeAddress4.Text = dt.Rows[0]["scm_employer_address3"].ToString();
                txtBAOfficeZipCode.Text = dt.Rows[0]["OOOO"].ToString();
                txtBAOfficeCity.Text = dt.Rows[0]["scm_employer_city"].ToString();
                txtBAOfficeProvinsi.Text = dt.Rows[0]["scm_employer_province"].ToString();
                txtBAOfficeCollector.Text = dt.Rows[0]["office_collector_id"].ToString();

                //Other
                if (dt.Rows[0]["sco_addr_type"].ToString() == "B")
                {
                    txtBAOtherAddress1.Text = dt.Rows[0]["sco_address1"].ToString();
                    txtBAOtherAddress2.Text = dt.Rows[0]["sco_address2"].ToString();
                    txtBAOtherAddress3.Text = dt.Rows[0]["sco_address3"].ToString();
                    txtBAOtherRT.Text = dt.Rows[0]["sco_rt"].ToString();
                    txtBAOtherRW.Text = dt.Rows[0]["sco_rw"].ToString();
                    txtBAOtherKelurahan.Text = dt.Rows[0]["sco_kelurahan"].ToString();
                    txtBAOtherKecamatan.Text = dt.Rows[0]["Kecamatan_Other"].ToString();
                    txtBAOtherZipCode.Text = dt.Rows[0]["Zipcode_Other"].ToString();
                    txtBAOtherCity.Text = dt.Rows[0]["City_Other"].ToString();
                    txtBAOtherProvinsi.Text = dt.Rows[0]["Provinci_Other"].ToString();
                }

                //-------------------------------------------------------------------------------------------------
                //FOR DELIVERY ADDRESS
                //Home
                txtDAHomeAddress1.Text = dt.Rows[0]["scm_address1"].ToString();
                txtDAHomeAddress2.Text = dt.Rows[0]["scm_address2"].ToString();
                txtDAHomeAddress3.Text = dt.Rows[0]["scm_address3"].ToString();
                txtDAHomeRT.Text = dt.Rows[0]["scm_rt"].ToString();
                txtDAHomeRW.Text = dt.Rows[0]["scm_rw"].ToString();
                txtDAHomeZipCode.Text = dt.Rows[0]["ZipCode"].ToString();
                txtDAHomeKelurahan.Text = dt.Rows[0]["scm_kelurahan"].ToString();
                txtDAHomeKecamatan.Text = dt.Rows[0]["Kecamatan"].ToString();
                txtDAHomeCity.Text = dt.Rows[0]["City"].ToString();
                txtDAHomeProvinsi.Text = dt.Rows[0]["Province"].ToString();

                //Office
                txtDAOfficeAddress1.Text = dt.Rows[0]["scm_last_employer_name"].ToString(); //Column For Company Name
                txtDAOfficeAddress2.Text = dt.Rows[0]["scm_employer_address1"].ToString();
                txtDAOfficeAddress3.Text = dt.Rows[0]["scm_employer_address2"].ToString();
                txtDAOfficeAddress4.Text = dt.Rows[0]["scm_employer_address3"].ToString();
                txtDAOfficeZipCode.Text = dt.Rows[0]["OOOO"].ToString();
                txtDAOfficeCity.Text = dt.Rows[0]["scm_employer_city"].ToString();
                txtDAOfficeProvinsi.Text = dt.Rows[0]["scm_employer_province"].ToString();

                //Other
                if (dt.Rows[0]["sco_addr_type"].ToString() == "D")
                {
                    txtDAOtherAddress1.Text = dt.Rows[0]["sco_address1"].ToString();
                    txtDAOtherAddress2.Text = dt.Rows[0]["sco_address2"].ToString();
                    txtDAOtherAddress3.Text = dt.Rows[0]["sco_address3"].ToString();
                    txtDAOtherRT.Text = dt.Rows[0]["sco_rt"].ToString();
                    txtDAOtherRW.Text = dt.Rows[0]["sco_rw"].ToString();
                    txtDAOtherKelurahan.Text = dt.Rows[0]["sco_kelurahan"].ToString();
                    txtDAOtherKecamatan.Text = dt.Rows[0]["Kecamatan_Other"].ToString();
                    txtDAOtherZipCode.Text = dt.Rows[0]["Zipcode_Other"].ToString();
                    txtDAOtherCity.Text = dt.Rows[0]["City_Other"].ToString();
                    txtDAOtherProvinsi.Text = dt.Rows[0]["Provinci_Other"].ToString();
                }

                txtBAOfficeZipCode.Text = dt.Rows[0]["scm_employer_zip_code"].ToString();
                txtDAOfficeZipCode.Text = dt.Rows[0]["scm_employer_zip_code"].ToString();

                //Untuk  Flag di Frame Home, Office , Other yang Billing
                if (dt.Rows[0]["scm_billing_address_code"].ToString() == "H")
                {
                    rbBAHome.Checked = true;
                }
                else if (dt.Rows[0]["scm_billing_address_code"].ToString() == "O")
                {
                    rbBAOffice.Checked = true;
                }
                else if (dt.Rows[0]["scm_billing_address_code"].ToString() == "L")
                {
                    rbBAOther.Checked = true;
                }

                //Untuk  Flag di Frame Home, Office , Other yang Delivery
                if (dt.Rows[0]["scm_delivery_address_code"].ToString() == "H")
                {
                    rbDAHome.Checked = true;
                }
                else if (dt.Rows[0]["scm_delivery_address_code"].ToString() == "O")
                {
                    rbDAOffice.Checked = true;
                }
                else if (dt.Rows[0]["scm_delivery_address_code"].ToString() == "L")
                {
                    rbDAOther.Checked = true;
                }

                
                txtVerificatorID.Text = dt.Rows[0]["svs_verificator_id"].ToString();
                txtVerificatorName.Tag = dt.Rows[0]["svs_verificator_id"].ToString();
                txtEntity.Text = dt.Rows[0]["svs_entity_id"].ToString();
                txtBranch.Text = dt.Rows[0]["svs_branch_id"].ToString();
                cboCollector.Text = dt.Rows[0]["skh_default_collector_id"].ToString().Trim();

                txtRemarks.Text = dt.Rows[0]["svs_remark_activity"].ToString();

                if (txtBAHomeCollector.Text.Trim() == string.Empty)
                {
                    txtBAHomeCollector.Text = cboCollector.Text;
                }

                if (txtBAOfficeCollector.Text.Trim() == string.Empty)
                {
                    txtBAOfficeCollector.Text = cboCollector.Text;
                }

                txtNoOfInstallment.Text = (dt.Rows[0]["skh_no_of_instalments"].ToString() != string.Empty) ? dt.Rows[0]["skh_no_of_instalments"].ToString() + " Month" : "CASH";
                dtDueDate.Value = Convert.ToDateTime(dt.Rows[0]["svs_dateofbilling"]);

                if (dt.Rows[0]["svs_dateofvisit"].ToString() != string.Empty)
                {
                    var dummyDate = dtDateOfVisit.Value.Year.ToString() + '/' + "12" + '/' + dt.Rows[0]["svs_dateofvisit"].ToString();
                    dtDateOfVisit.Value = Convert.ToDateTime(dummyDate);
                }

                if (dt.Rows[0]["svs_customer_data_status"].ToString() == "C")
                {
                    rbCDSComplete.Checked = true;
                }
                else
                {
                    rbCDSInComplete.Checked = true;
                }

                if (dt.Rows[0]["svs_status_release"].ToString().Trim() == "OKE")
                {
                    rbCVSOK.Checked = true;
                }
                else
                {
                    rbCVSDoubt.Checked = true;
                }

                dtDeliveryDate.Value = Convert.ToDateTime(dt.Rows[0]["skh_request_delivery_date"]);

                if(dt.Rows[0]["skh_status_of_verification"].ToString() == "S")
                {
                    txtStatusVerification.Text = "Suspend";
                }
                else if (dt.Rows[0]["skh_status_of_verification"].ToString() == "I")
                {
                    txtStatusVerification.Text = "In Process";
                }
                else if (dt.Rows[0]["skh_status_of_verification"].ToString() == "R")
                {
                    txtStatusVerification.Text = "Release";
                }
                else if (dt.Rows[0]["skh_status_of_verification"].ToString() == "C")
                {
                    txtStatusVerification.Text = "Cancel";
                }

                //GET VERIFICATOR NAME
                SOVerificatorMasterBL = new SOVerificatorMasterBL()
                {
                    verificator_id = txtVerificatorName.Tag.ToString()
                };
                DataTable dtVer = SOCancelVerificationAL.GetDetailVerificatorByID(EnumFilter.GET_SEARCH_ID, SOVerificatorMasterBL, 1, 1);
                if(dtVer.Rows.Count > 0)
                {
                    txtVerificatorName.Text = dtVer.Rows[0]["svm_verificator_name"].ToString();
                }

                
                DataTable dtAR = SOCancelVerificationAL.GetItemNoFromARKuitansi(txtKPNo.Text.Trim());
                if (dtAR.Rows.Count > 0)
                {
                    if (dtAR.Rows[0]["ak_item_number"].ToString().Length > 0)
                    {
                        cboCollector.Enabled = false;
                    }
                }
            }
            else
            {
                clsAlert.PushAlert("KP Number not found!", clsAlert.Type.Error);
                clear(true);
                txtKPNo.Focus();
            }
        }

        private void txtKPNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool _isValid = ValidateKPNo();
                if (_isValid == true)
                {
                    DisplayKPNoDetail();
                }
                else
                {
                    clear(true);
                }
            }
        }

        private void rbBAHome_CheckedChanged(object sender, EventArgs e)
        {
            //FlagAddrs = "Billing Home"

            groupBAHome.Visible = true;
            groupBAOffice.Visible = false;
            groupBAOther.Visible = false;

            if (chbChangeCollector.Checked == true)
            {
                if (txtBAHomeCollector.Text.Trim().Length > 0)
                {
                    cboCollector.Text = txtBAHomeCollector.Text;
                }
            }
        }

        private void rbBAOffice_CheckedChanged(object sender, EventArgs e)
        {
            //FlagAddrs = "Billing Office"

            groupBAHome.Visible = false;
            groupBAOffice.Visible = true;
            groupBAOther.Visible = false;
            txtBAOfficeAddress4.Visible = true;

            if (chbChangeCollector.Checked == true)
            {
                if (txtBAOfficeCollector.Text.Trim().Length > 0)
                {
                    cboCollector.Text = txtBAOfficeCollector.Text;
                }
            }
        }

        private void rbBAOther_CheckedChanged(object sender, EventArgs e)
        {
            //FlagAddrs = "Billing Other"

            groupBAHome.Visible = false;
            groupBAOffice.Visible = false;
            groupBAOther.Visible = true;

            if (chbChangeCollector.Checked == true)
            {
                if (txtBAOtherCollector.Text.Trim().Length > 0)
                {
                    cboCollector.Text = txtBAOtherCollector.Text;
                }
            }
        }

        private void rbDAHome_CheckedChanged(object sender, EventArgs e)
        {
            // FlagAddrsDel = "Delivery Home"

            groupDAHome.Visible = true;
            groupDAOffice.Visible = false;
            groupDAOther.Visible = false;
        }

        private void rbDAOffice_CheckedChanged(object sender, EventArgs e)
        {
            // FlagAddrsDel = "Delivery Office"

            txtDAOfficeAddress4.Visible = true;
            groupDAHome.Visible = false;
            groupDAOffice.Visible = true;
            groupDAOther.Visible = false;
        }

        private void rbDAOther_CheckedChanged(object sender, EventArgs e)
        {
            // FlagAddrsDel = "Delivery Other"

            groupDAHome.Visible = false;
            groupDAOffice.Visible = false;
            groupDAOther.Visible = true;
        }
    }
}
