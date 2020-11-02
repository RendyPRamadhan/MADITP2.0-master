using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.businessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.Report.SO;
using MADITP2._0.UserInterface.SO.SOVerificationProcess;
using MADITP2._0.ApplicationLogic;
using System.Collections;
using System.Web.Caching;

namespace MADITP2._0.userInterface.SO.SO_VerificationProcessUI
{
    public partial class SO_VerificationProcessUI : Form
    {
        clsGlobal Helper;
        GlobalAL GlobalAL;
        clsReport clsReport;
        SOVerificationProcessBL SOVerificationProcessBL;
        SOVerificationProcessAL SOVerificationProcessAL;
        SOVerificatorMasterDA SOVerificatorMasterDA;
        SOVerificatorMasterBL SOVerificatorMasterBL;
        SOVerificatorMasterAL SOVerificatorMasterAL;
        //GSEntityDA GSEntityDA = new GSEntityDA();
        //GSBranchDA GSBranchDA = new GSBranchDA();
        clsAlert clsAlert;
        clsPopUpCustomer clsPopUpCustomer;
        private int _CurrentPage, _CurrentPageKp, _FetchLimit, _TotalPage, _TotalPageKp;
        private int _CurrentPageVs, _CurrentPageActivity, _TotalPageVs, _TotalPageActivity;
        private int _CurrentPageSor, _TotalPageSor, _RowPrintSOR;
        private string _UserEntityID, _UserEntity, _UserBranchID, _UserDivisionID, _UserGroupID, _ExistForm, _ExistMenu;
        private bool _isLoadEditorVsaEditor, _isLoadEditorVsEditor, _loadVSDetailKP;
        public string VsEventType, SorEventType;
        private ArrayList _SelectedKPNoArray = new ArrayList();
        private DataTable dtPrintSOR = new DataTable();

        public SO_VerificationProcessUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                GlobalAL = new GlobalAL(Helper);
                clsReport = new clsReport();
                SOVerificationProcessAL = new SOVerificationProcessAL(Helper);
                SOVerificatorMasterDA = new SOVerificatorMasterDA(Helper);
                SOVerificatorMasterBL = new SOVerificatorMasterBL();
                SOVerificatorMasterAL = new SOVerificatorMasterAL(Helper);
                SOVerificationProcessBL = new SOVerificationProcessBL();
                clsAlert = new clsAlert();
                clsPopUpCustomer = new clsPopUpCustomer();
            }
        }

        private void clearView()
        {
            cboEntityVsa.SelectedIndex = 0;
            cboBranchVsa.SelectedIndex = 0;
            cboVerificatorVsa.SelectedIndex = 0;
            txtKPNoVsa.Text = string.Empty;

            grdVSA.DataSource = null;
            lblPagingInfoVsa.Text = "Pages : - ";
            lblRowsVSA.Text = "Records : 0";

            grdKP.DataSource = null;
            lblPagingInfoKP.Text = "Pages : - ";
            lblRowsKP.Text = "Records : 0";
        }

        private void clearViewVs()
        {
            cboEntityVs.SelectedIndex = 0;
            cboBranchVs.SelectedIndex = 0;
            cboDivisionVs.SelectedIndex = 0;
            cboVerifierNameVs.SelectedIndex = 0;
            cboVerificationStatusVs.SelectedIndex = 0;
            cboDPStatusVs.SelectedIndex = 0;
            cboActivityVs.SelectedIndex = 0;
            txtKPNoVs.Text = string.Empty;
            dtFromKPDateVs.Value = DateTime.Now;
            dtUntilKPDateVs.Value = DateTime.Now;
            chbKPDateVs.Checked = true;
            dtAssignDateVs.Value = DateTime.Now;
            chbAssignDateVs.Checked = true;
            txtCustCodeVs.Text = string.Empty;
            txtCustNameVs.Text = string.Empty;

            grdVS.DataSource = null;
            lblPagingInfoVs.Text = "Pages : - ";
            lblRowsVs.Text = "Records : 0";

            grdActivity.DataSource = null;
            lblPagingInfoKP.Text = "Pages : - ";
            lblRowsActivity.Text = "Records : 0";
        }

        private void ClearEditorVsa()
        {
            cboVerificatorID.SelectedIndex = 0;
            txtKPNo.Text = string.Empty;
            dtAssignDate.Value = DateTime.Now.Date;
            txtDivision.Text = string.Empty;
            txtCustomerType.Text = string.Empty;

            dtKPDate.Value = DateTime.Now.Date;
            txtTypeSales.Text = string.Empty;
            txtLamaKredit.Text = string.Empty;
            txtTotalSU.Text = string.Empty;
            txtUangMuka.Text = string.Empty;
            txtCOD.Text = string.Empty;
            txtAngsuran.Text = string.Empty;
            txtTotalItem.Text = string.Empty;
            txtTotalNet.Text = string.Empty;
            txtDesc.Text = string.Empty;

            txtRepID.Text = string.Empty;
            txtRepName.Text = string.Empty;
            txtCustID.Text = string.Empty;
            txtCustName.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtAddress3.Text = string.Empty;
            txtRT.Text = string.Empty;
            txtRW.Text = string.Empty;
            txtKeluarhan.Text = string.Empty;
            txtKecamatan.Text = string.Empty;
            txtKota.Text = string.Empty;

            txtKPNo.Focus();
        }

        private void ClearEditorVs(bool _withCboVerificatorID)
        {
            if(_withCboVerificatorID == true)
            {
                cboVerificatorIDVSEditor.SelectedIndex = 0;
            }

            txtKPValueVSEditor.Text = string.Empty;
            dtKPDateVSEditor.Value = DateTime.Now.Date;
            txtRepIDVSEditor.Text = string.Empty;
            txtCustIDVSEditor.Text = string.Empty;
            txtCustNameVSEditor.Text = string.Empty;
            txtMemoVSEditor.Text = string.Empty;
            txtKPOnlineNoteVSEditor.Text = "KP ONLINE NOTES" + Environment.NewLine +
                                           "----------------------" + Environment.NewLine;
            txtVisaAutoVSEditor.Text = string.Empty;

            grdVisitingActivity.Rows.Clear();
            addRowsGrdVisitingActivity();

            fillgrdQualifierDetail(txtCustIDVSEditor.Text.Trim().ToString());

        }

        private void loadVSADetail(string _VerificatorID)
        {
            if (_isLoadEditorVsaEditor == false)
            {
                SOVerificatorMasterBL.verificator_id = _VerificatorID;
                DataTable dt = SOVerificationProcessAL.getVerificatorDetail(EnumFilter.GET_SEARCH_ID, SOVerificatorMasterBL);

                cboVerificatorID.SelectedValue = _VerificatorID;
                txtVerificatorName.Text = dt.Rows[0]["svm_verificator_name"].ToString();
                txtEntity.Text = dt.Rows[0]["ec_entity"].ToString();
                txtEntity.Tag = dt.Rows[0]["svm_entity_id"].ToString();
                txtBranch.Text = dt.Rows[0]["bc_branch"].ToString();
                txtBranch.Tag = dt.Rows[0]["svm_branch_id"].ToString();
            }
        }

        private void loadVSVerificatorIDDetail(string _ExForm)
        {
            if (_isLoadEditorVsEditor == false)
            {
                SOVerificatorMasterBL.verificator_id = cboVerificatorIDVSEditor.SelectedValue.ToString();
                DataTable dt = SOVerificationProcessAL.getVerificatorDetail(EnumFilter.GET_SEARCH_ID, SOVerificatorMasterBL);

                txtVerificatorNameVSEditor.Text = dt.Rows[0]["svm_verificator_name"].ToString();
                txtEntityVSEditor.Text = dt.Rows[0]["ec_entity"].ToString();
                txtEntityVSEditor.Tag = dt.Rows[0]["svm_entity_id"].ToString();
                txtBranchVSEditor.Text = dt.Rows[0]["bc_branch"].ToString();
                txtBranchVSEditor.Tag = dt.Rows[0]["svm_branch_id"].ToString();
                txtDivisionVSEditor.Text = dt.Rows[0]["dc_division"].ToString();
                txtDivisionVSEditor.Tag = dt.Rows[0]["svm_division_id"].ToString();

                //LOAD KP NO INTO COMBO BOX
                AddCboKPNoVSEditor(_ExForm);

                if (VsEventType == "ADD")
                {
                    ClearEditorVs(false);
                }
                else
                {
                    //cboKPNoVSEditor.SelectedValue = getKPNo(_ExistMenu);
                    cboKPNoVSEditor.Text = getKPNo(_ExistMenu).ToString();
                    cboKPNoVSEditor_SelectedIndexChanged(null, null);
                }
            }
        }

        private void AddCboKPNoVSEditor(string _DataType)
        {
            cboKPNoVSEditor.DataSource = null;
            cboKPNoVSEditor.DataSource = SOVerificationProcessAL.GetSOKPNumberToComboBoxVSEditor(_DataType, cboVerificatorIDVSEditor.SelectedValue.ToString());
            cboKPNoVSEditor.ValueMember = "ValueMember";
            cboKPNoVSEditor.DisplayMember = "DisplayMember";
            cboKPNoVSEditor.SelectedIndex = -1;
        }

        private bool DrawPropertyVSAEditor(string _VerificatorID)
        {
            bool _Result = false;
            try
            {
                //Get Header
                loadVSADetail(_VerificatorID);
                //Get Detail
                DisplayKPNoDetail("EDIT");

                _Result = true;
            }
            catch (Exception)
            {
                _Result = false;
            }


            return _Result;
        }

        private bool DrawPropertyVSEditor(string _ExFrom, string _VerificatorID)
        {
            bool _Result = false;
            try
            {
                //Get Header
                cboVerificatorIDVSEditor.SelectedValue = _VerificatorID;
                loadVSVerificatorIDDetail(_ExFrom);

                _Result = true;
            }
            catch (Exception)
            {
                _Result = false;
            }


            return _Result;
        }

        private void addRowsGrdVisitingActivity()
        {
            grdVisitingActivity.Rows.Add("", "", "", "", "", false);
        }

        private void loadCollector()
        {
            cboCollectorSorEditor.DataSource = null;
            cboCollectorSorEditor.DataSource = SOVerificationProcessAL.GetCollectorToComboBox(false);
            cboCollectorSorEditor.ValueMember = "ValueMember";
            cboCollectorSorEditor.DisplayMember = "ValueMember";
            cboCollectorSorEditor.SelectedIndex = -1;
        }

        private void clearSorEditor(bool _IncludeKPNo)
        {
            if(_IncludeKPNo == true)
            {
                txtKPNoSorEditor.Text = string.Empty;
            }

            txtDivisionSorEditor.Text = string.Empty;
            dtKPDateSorEditor.Value = DateTime.Now.Date;
            txtSumOfVisitSorEditor.Text = string.Empty;
            txtCustIDSorEditor.Text = string.Empty;
            txtCustNameSorEditor.Text = string.Empty;
            txtRepIDSorEditor.Text = string.Empty;
            txtRepNameSorEditor.Text = string.Empty;
            txtAddressSorEditor.Text = string.Empty;
            txtNumberSorEditor.Text = string.Empty;
            txtItemSetSorEditor.Text = string.Empty;
            txtSUSorEditor.Text = string.Empty;
            txtBVSorEditor.Text = string.Empty;
            txtPVSorEditor.Text = string.Empty;
            txtPoint1SorEditor.Text = string.Empty;
            txtPoint2SorEditor.Text = string.Empty;
            txtRemarksSorEditor.Text = string.Empty;
            txtEntitySorEditor.Text = string.Empty;
            txtBranchSorEditor.Text = string.Empty;
            txtVerificatorSorEditor.Text = string.Empty;
            txtVerificatorSorEditor.Tag = string.Empty;
            txtProductDescSorEditor.Text = string.Empty;
            txtNoOfInstallmentSorEditor.Text = string.Empty;
            cboCollectorSorEditor.Text = string.Empty;
            cboCollectorSorEditor.SelectedIndex = -1;

            txtTelpHPSorEditor.Text = string.Empty;
            txtTelpKantorSorEditor.Text = string.Empty;
            txtTelpRumahSorEditor.Text = string.Empty;

            //---------------------------------------------------------------------------
            //BILLING ADDRESS
            //Group Home
            txtBAHomeAddress1SorEditor.Text = string.Empty;
            txtBAHomeAddress2SorEditor.Text = string.Empty;
            txtBAHomeAddress3SorEditor.Text = string.Empty;
            txtBAHomeRTSorEditor.Text = string.Empty;
            txtBAHomeRWSorEditor.Text = string.Empty;
            txtBAHomeZipCodeSorEditor.Text = string.Empty;
            txtBAHomeKelurahanSorEditor.Text = string.Empty;
            txtBAHomeKecamatanSorEditor.Text = string.Empty;
            txtBAHomeCitySorEditor.Text = string.Empty;
            txtBAHomeProvinsiSorEditor.Text = string.Empty;
            txtBAHomeCollectorSorEditor.Text = string.Empty;

            //Group Office
            txtBAOfficeAddress1SorEditor.Text = string.Empty;
            txtBAOfficeAddress2SorEditor.Text = string.Empty;
            txtBAOfficeAddress3SorEditor.Text = string.Empty;
            txtBAOfficeAddress4SorEditor.Text = string.Empty;
            txtBAOfficeRTSorEditor.Text = string.Empty;
            txtBAOfficeRWSorEditor.Text = string.Empty;
            txtBAOfficeZipCodeSorEditor.Text = string.Empty;
            txtBAOfficeKelurahanSorEditor.Text = string.Empty;
            txtBAOfficeKecamatanSorEditor.Text = string.Empty;
            txtBAOfficeCitySorEditor.Text = string.Empty;
            txtBAOfficeProvinsiSorEditor.Text = string.Empty;
            txtBAOfficeCollectorSorEditor.Text = string.Empty;

            //Group Other
            txtBAOtherAddress1SorEditor.Text = string.Empty;
            txtBAOtherAddress2SorEditor.Text = string.Empty;
            txtBAOtherAddress3SorEditor.Text = string.Empty;
            txtBAOtherRTSorEditor.Text = string.Empty;
            txtBAOtherRWSorEditor.Text = string.Empty;
            txtBAOtherZipCodeSorEditor.Text = string.Empty;
            txtBAOtherKelurahanSorEditor.Text = string.Empty;
            txtBAOtherKecamatanSorEditor.Text = string.Empty;
            txtBAOtherCitySorEditor.Text = string.Empty;
            txtBAOtherProvinsiSorEditor.Text = string.Empty;
            txtBAOtherCollectorSorEditor.Text = string.Empty;

            //---------------------------------------------------------------------------
            //DELIVERY ADDRESS
            //Group Home
            txtDAHomeAddress1SorEditor.Text = string.Empty;
            txtDAHomeAddress2SorEditor.Text = string.Empty;
            txtDAHomeAddress3SorEditor.Text = string.Empty;
            txtDAHomeRTSorEditor.Text = string.Empty;
            txtDAHomeRWSorEditor.Text = string.Empty;
            txtDAHomeZipCodeSorEditor.Text = string.Empty;
            txtDAHomeKelurahanSorEditor.Text = string.Empty;
            txtDAHomeKecamatanSorEditor.Text = string.Empty;
            txtDAHomeCitySorEditor.Text = string.Empty;
            txtDAHomeProvinsiSorEditor.Text = string.Empty;

            //Group Office
            txtDAOfficeAddress1SorEditor.Text = string.Empty;
            txtDAOfficeAddress2SorEditor.Text = string.Empty;
            txtDAOfficeAddress3SorEditor.Text = string.Empty;
            txtDAOfficeAddress4SorEditor.Text = string.Empty;
            txtDAOfficeRTSorEditor.Text = string.Empty;
            txtDAOfficeRWSorEditor.Text = string.Empty;
            txtDAOfficeZipCodeSorEditor.Text = string.Empty;
            txtDAOfficeKelurahanSorEditor.Text = string.Empty;
            txtDAOfficeKecamatanSorEditor.Text = string.Empty;
            txtDAOfficeCitySorEditor.Text = string.Empty;
            txtDAOfficeProvinsiSorEditor.Text = string.Empty;

            //Group Other
            txtDAOtherAddress1SorEditor.Text = string.Empty;
            txtDAOtherAddress2SorEditor.Text = string.Empty;
            txtDAOtherAddress3SorEditor.Text = string.Empty;
            txtDAOtherRTSorEditor.Text = string.Empty;
            txtDAOtherRWSorEditor.Text = string.Empty;
            txtDAOtherZipCodeSorEditor.Text = string.Empty;
            txtDAOtherKelurahanSorEditor.Text = string.Empty;
            txtDAOtherKecamatanSorEditor.Text = string.Empty;
            txtDAOtherCitySorEditor.Text = string.Empty;
            txtDAOtherProvinsiSorEditor.Text = string.Empty;

            dtDateOfVisitSorEditor.Value = getEndingDateCalenderFiscal();
            dtDeliveryDateSorEditor.Value = getEndingDateCalenderFiscal();
            dtDueDateSorEditor.Value = getEndingDateCalenderFiscal();
            dtDueDateSorEditor.Value = dtDueDateSorEditor.Value.AddMonths(1);

            rbBAHomeSorEditor.Checked = true;
            rbDAHomeSorEditor.Checked = true;
            rbCDSCompleteSorEditor.Checked = true;
            rbCVSOKSorEditor.Checked = true;
        }

        private bool ValidateKPNoSorEditor()
        {
            bool _isValid = false;

            if(txtKPNoSorEditor.Text.Trim().Length > 0)
            {
                DataTable dt = SOVerificationProcessAL.GetStatusKPNoSalesOrderRelease(txtKPNoSorEditor.Text.Trim());

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["svs_so_kp_num"].ToString() != string.Empty)
                    {
                        if (dt.Rows[0]["svs_verification_status"].ToString() == "I")
                        {
                            _isValid = true;
                        }
                        else
                        {
                            clsAlert.PushAlert("Status of Verification Must Be In Processed!", clsAlert.Type.Error);
                            txtKPNo.Focus();
                            _isValid = false;
                        }
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

        private void DisplayKPNoDetailSorEditor()
        {
            string _VerStatus = string.Empty;
            if(SorEventType == "ADD")
            {
                _VerStatus = "I";
            }
            else
            {
                _VerStatus = "R";
            }

            DataTable dt = SOVerificationProcessAL.GetKPNoDetailSalesOrderRelease(txtKPNoSorEditor.Text.Trim(), _VerStatus);

            if (dt.Rows.Count > 0)
            {
                clearSorEditor(false);

                foreach(DataRow dr in dt.Rows)
                {
                    txtDivisionSorEditor.Text = dr["skh_division_id"].ToString();
                    dtKPDateSorEditor.Value = Convert.ToDateTime(dr["svs_so_kp_date"]);
                    txtSumOfVisitSorEditor.Text = dr["svs_number_activity"].ToString();
                    txtCustIDSorEditor.Text = dr["skh_customer_id"].ToString();
                    txtCustNameSorEditor.Text = dr["skh_customer_name"].ToString();

                    txtAddressSorEditor.Text = dr["scm_address1"].ToString() + "   " + dr["scm_address2"].ToString() + "   " + dr["scm_address3"].ToString() +
                        "   RT:" + dr["scm_rt"].ToString() + "   RW:" + dr["scm_rw"].ToString() + "   " + dr["scm_kelurahan"].ToString() +
                        "   " + dr["Kecamatan"].ToString() + "   " + dr["ZipCode"].ToString() + "   " + dr["City"].ToString() + "   " + dr["Province"].ToString();

                    txtRepIDSorEditor.Text = dr["skh_rep_id"].ToString();
                    txtRepNameSorEditor.Text = dr["rm_name"].ToString();

                    txtNumberSorEditor.Text = string.Format("{0:#,##0}", double.Parse(dr["skh_no_detail_lines"].ToString()));
                    txtItemSetSorEditor.Text = string.Format("{0:#,##0}", double.Parse(dr["skh_total_item_set_qty"].ToString()));
                    txtSUSorEditor.Text = string.Format("{0:#,##0.0}", double.Parse(dr["skh_total_su"].ToString()));
                    txtBVSorEditor.Text = string.Format("{0:#,##0}", double.Parse(dr["skh_total_bv"].ToString()));
                    txtPVSorEditor.Text = string.Format("{0:#,##0}", double.Parse(dr["skh_total_pv"].ToString()));
                    txtPoint1SorEditor.Text = string.Format("{0:#,##0}", double.Parse(dr["skh_total_point_1"].ToString()));
                    txtPoint2SorEditor.Text = string.Format("{0:#,##0}", double.Parse(dr["skh_total_point_2"].ToString()));

                    txtProductDescSorEditor.Text = dr["skh_desc"].ToString();

                    //For Phone Number
                    txtTelpRumahSorEditor.Text = dr["scm_home_phone_num"].ToString();
                    txtTelpHPSorEditor.Text = dr["scm_mobile_phone_num"].ToString();
                    txtTelpKantorSorEditor.Text = dr["scm_employer_phone"].ToString();

                    //-------------------------------------------------------------------------------------------------
                    //FOR BILLING ADDRESS
                    //Home
                    txtBAHomeAddress1SorEditor.Text = dr["scm_address1"].ToString();
                    txtBAHomeAddress2SorEditor.Text = dr["scm_address2"].ToString();
                    txtBAHomeAddress3SorEditor.Text = dr["scm_address3"].ToString();
                    txtBAHomeRTSorEditor.Text = dr["scm_rt"].ToString();
                    txtBAHomeRWSorEditor.Text = dr["scm_rw"].ToString();

                    txtBAHomeKelurahanSorEditor.Text = dr["scm_kelurahan"].ToString();
                    txtBAHomeZipCodeSorEditor.Text = dr["ZipCode"].ToString();
                    txtBAHomeKecamatanSorEditor.Text = dr["Kecamatan"].ToString();
                    txtBAHomeCitySorEditor.Text = dr["City"].ToString();
                    txtBAHomeProvinsiSorEditor.Text = dr["Province"].ToString();
                    txtBAHomeCollectorSorEditor.Text = dr["ac_collector_id_home"].ToString();

                    //Office
                    txtBAOfficeAddress1SorEditor.Text = dr["scm_last_employer_name"].ToString(); //Column For Company Name
                    txtBAOfficeAddress2SorEditor.Text = dr["scm_employer_address1"].ToString();
                    txtBAOfficeAddress3SorEditor.Text = dr["scm_employer_address2"].ToString();
                    txtBAOfficeAddress4SorEditor.Text = dr["scm_employer_address3"].ToString();
                    txtBAOfficeZipCodeSorEditor.Text = dr["ZCode"].ToString();
                    txtBAOfficeCitySorEditor.Text = dr["scm_employer_city"].ToString();
                    txtBAOfficeProvinsiSorEditor.Text = dr["scm_employer_province"].ToString();
                    txtBAOfficeCollectorSorEditor.Text = dr["ac_collector_id_office"].ToString();

                    //Other
                    if (dr["sco_addr_type"].ToString() == "B")
                    {
                        txtBAOtherAddress1SorEditor.Text = dr["sco_address1"].ToString();
                        txtBAOtherAddress2SorEditor.Text = dr["sco_address2"].ToString();
                        txtBAOtherAddress3SorEditor.Text = dr["sco_address3"].ToString();
                        txtBAOtherRTSorEditor.Text = dr["sco_rt"].ToString();
                        txtBAOtherRWSorEditor.Text = dr["sco_rw"].ToString();
                        txtBAOtherKelurahanSorEditor.Text = dr["sco_kelurahan"].ToString();
                        txtBAOtherKecamatanSorEditor.Text = dr["Kecamatan_Other"].ToString();
                        txtBAOtherZipCodeSorEditor.Text = dr["Zipcode_Other"].ToString();
                        txtBAOtherCitySorEditor.Text = dr["City_Other"].ToString();
                        txtBAOtherProvinsiSorEditor.Text = dr["Provinci_Other"].ToString();
                    }

                    //-------------------------------------------------------------------------------------------------
                    //FOR DELIVERY ADDRESS
                    //Home
                    txtDAHomeAddress1SorEditor.Text = dr["scm_address1"].ToString();
                    txtDAHomeAddress2SorEditor.Text = dr["scm_address2"].ToString();
                    txtDAHomeAddress3SorEditor.Text = dr["scm_address3"].ToString();
                    txtDAHomeRTSorEditor.Text = dr["scm_rt"].ToString();
                    txtDAHomeRWSorEditor.Text = dr["scm_rw"].ToString();
                    txtDAHomeZipCodeSorEditor.Text = dr["ZipCode"].ToString();
                    txtDAHomeKelurahanSorEditor.Text = dr["scm_kelurahan"].ToString();
                    txtDAHomeKecamatanSorEditor.Text = dr["Kecamatan"].ToString();
                    txtDAHomeCitySorEditor.Text = dr["City"].ToString();
                    txtDAHomeProvinsiSorEditor.Text = dr["Province"].ToString();

                    //Office
                    txtDAOfficeAddress1SorEditor.Text = dr["scm_last_employer_name"].ToString(); //Column For Company Name
                    txtDAOfficeAddress2SorEditor.Text = dr["scm_employer_address1"].ToString();
                    txtDAOfficeAddress3SorEditor.Text = dr["scm_employer_address2"].ToString();
                    txtDAOfficeAddress4SorEditor.Text = dr["scm_employer_address3"].ToString();
                    txtDAOfficeZipCodeSorEditor.Text = dr["ZCode"].ToString();
                    txtDAOfficeCitySorEditor.Text = dr["scm_employer_city"].ToString();
                    txtDAOfficeProvinsiSorEditor.Text = dr["scm_employer_province"].ToString();

                    //Other
                    if (dr["sco_addr_type"].ToString() == "D")
                    {
                        txtDAOtherAddress1SorEditor.Text = dr["sco_address1"].ToString();
                        txtDAOtherAddress2SorEditor.Text = dr["sco_address2"].ToString();
                        txtDAOtherAddress3SorEditor.Text = dr["sco_address3"].ToString();
                        txtDAOtherRTSorEditor.Text = dr["sco_rt"].ToString();
                        txtDAOtherRWSorEditor.Text = dr["sco_rw"].ToString();
                        txtDAOtherKelurahanSorEditor.Text = dr["sco_kelurahan"].ToString();
                        txtDAOtherKecamatanSorEditor.Text = dr["Kecamatan_Other"].ToString();
                        txtDAOtherZipCodeSorEditor.Text = dr["Zipcode_Other"].ToString();
                        txtDAOtherCitySorEditor.Text = dr["City_Other"].ToString();
                        txtDAOtherProvinsiSorEditor.Text = dr["Provinci_Other"].ToString();
                    }

                    txtBAOfficeZipCodeSorEditor.Text = dr["scm_employer_zip_code"].ToString();
                    txtDAOfficeZipCodeSorEditor.Text = dr["scm_employer_zip_code"].ToString();

                    //Untuk  Flag di Frame Home, Office , Other yang Billing
                    if (dr["scm_billing_address_code"].ToString() == "H")
                    {
                        rbBAHomeSorEditor.Checked = true;
                    }
                    else if (dr["scm_billing_address_code"].ToString() == "O")
                    {
                        rbBAOfficeSorEditor.Checked = true;
                    }
                    else if (dr["scm_billing_address_code"].ToString() == "L")
                    {
                        rbBAOtherSorEditor.Checked = true;
                    }

                    //Untuk  Flag di Frame Home, Office , Other yang Delivery
                    if (dr["scm_delivery_address_code"].ToString() == "H")
                    {
                        rbDAHomeSorEditor.Checked = true;
                    }
                    else if (dr["scm_delivery_address_code"].ToString() == "O")
                    {
                        rbDAOfficeSorEditor.Checked = true;
                    }
                    else if (dr["scm_delivery_address_code"].ToString() == "L")
                    {
                        rbDAOtherSorEditor.Checked = true;
                    }

                    txtVerificatorSorEditor.Text = dr["svm_verificator_name"].ToString();
                    txtVerificatorSorEditor.Tag = dr["svs_verificator_id"].ToString();
                    txtEntitySorEditor.Text = dr["svs_entity_id"].ToString();
                    txtBranchSorEditor.Text = dr["svs_branch_id"].ToString();
                    cboCollectorSorEditor.Text = dr["skh_default_collector_id"].ToString().Trim();

                    txtRemarksSorEditor.Text = dr["svs_remark_activity"].ToString();

                    if (txtBAHomeCollectorSorEditor.Text.Trim() == string.Empty)
                    {
                        txtBAHomeCollectorSorEditor.Text = cboCollectorSorEditor.Text;
                    }

                    if (txtBAOfficeCollectorSorEditor.Text.Trim() == string.Empty)
                    {
                        txtBAOfficeCollectorSorEditor.Text = cboCollectorSorEditor.Text;
                    }

                    txtNoOfInstallmentSorEditor.Text = (dr["skh_no_of_instalments"].ToString() != string.Empty) ? dr["skh_no_of_instalments"].ToString() + " Month" : "CASH";

                    if (SorEventType == "EDIT")
                    {
                        dtDueDateSorEditor.Value = Convert.ToDateTime(dr["svs_dateofbilling"]);

                        if (dr["svs_dateofvisit"].ToString() != string.Empty)
                        {
                            var dummyDate = dtDateOfVisitSorEditor.Value.Year.ToString() + '/' + "12" + '/' + dr["svs_dateofvisit"].ToString();
                            dtDateOfVisitSorEditor.Value = Convert.ToDateTime(dummyDate);
                        }

                        if (dr["svs_customer_data_status"].ToString() == "C")
                        {
                            rbCDSCompleteSorEditor.Checked = true;
                        }
                        else
                        {
                            rbCDSInCompleteSorEditor.Checked = true;
                        }

                        if (dr["svs_status_release"].ToString().Trim() == "OKE")
                        {
                            rbCVSOKSorEditor.Checked = true;
                        }
                        else
                        {
                            rbCVSDoubtSorEditor.Checked = true;
                        }

                        dtDeliveryDateSorEditor.Value = Convert.ToDateTime(dr["skh_request_delivery_date"]);

                        DataTable dtAR = SOVerificationProcessAL.GetItemNoFromARKuitansi(txtKPNoSorEditor.Text.Trim());
                        if (dtAR.Rows.Count > 0)
                        {
                            if (dtAR.Rows[0]["ak_item_number"].ToString().Length > 0)
                            {
                                cboCollectorSorEditor.Enabled = false;
                            }
                        }
                    }
                }
            }
            else
            {
                clsAlert.PushAlert("KP Number not found!", clsAlert.Type.Error);
                clearSorEditor(true);
                txtKPNoSorEditor.Focus();
            }
        }

        private DateTime getEndingDateCalenderFiscal()
        {
            DateTime _EndingDate = DateTime.Now.Date;

            DataTable dt = SOVerificationProcessAL.GetEndingDateCalenderFiscal();
            _EndingDate = Convert.ToDateTime(dt.Rows[0]["gfc_ending_date"]);

            return _EndingDate;
        }

        private void settingPanel(clsEventButton.EnumAction _ActionType)
        {
            switch (_ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    {
                        if (_ExistForm != "VIEW")
                        {
                            txtKPNoVsa.Focus();
                            pnlView.Visible = true;

                            if(tabVerificatationProcess.SelectedTab.Name == "tabVSA")
                            {
                                tabVerificatationProcess.SelectedIndex = 0;
                            }
                            else if(tabVerificatationProcess.SelectedTab.Name == "tabVS")
                            {
                                tabVerificatationProcess.SelectedIndex = 1;
                            }
                            else
                            {
                                tabVerificatationProcess.SelectedIndex = 2;
                            }

                            pnlVerificatorShceduleAssignmentEditor.Visible = false;
                            pnlVerificationStatusEditor.Visible = false;
                            pnlDelete.Visible = false;
                            pnlSalesOrderReleaseEditor.Visible = false;
                            pnlPrint.Visible = false;

                            _ExistForm = "VIEW";
                            setToolTip();
                            Helper.SetActive(navView);
                        }

                        break;
                    }
                case clsEventButton.EnumAction.NEW:
                    {
                        if (_ExistForm != "NEW")
                        {
                            switch (_ExistMenu)
                            {
                                case "tabVSA":
                                    {
                                        loadCboVerificatorEditor(_ExistMenu);
                                        ClearEditorVsa();

                                        //Load Property Editor
                                        _isLoadEditorVsaEditor = false;
                                        string _verID = string.Empty;
                                        _verID = (getVerificatorID(_ExistMenu).ToString() != string.Empty) ? getVerificatorID(_ExistMenu).ToString() : cboVerificatorID.SelectedValue.ToString();                                        
                                        loadVSADetail(_verID);

                                        btnSave.Text = "SAVE";
                                        txtKPNo.ReadOnly = false;
                                        txtKPNo.Focus();
                                        pnlView.Visible = false;
                                        pnlVerificatorShceduleAssignmentEditor.Visible = true;
                                        pnlVerificationStatusEditor.Visible = false;
                                        pnlDelete.Visible = false;
                                        pnlSalesOrderReleaseEditor.Visible = false;
                                        pnlPrint.Visible = false;

                                        _ExistForm = "NEW";
                                        setToolTip();
                                        Helper.SetActive(navNew);

                                        break;
                                    }
                                case "tabVS":
                                    {
                                        loadCboVerificatorEditor(_ExistMenu);
                                        ClearEditorVs(true);

                                        btnSaveVSEditor.Text = "SAVE";
                                        cboKPNoVSEditor.Focus();
                                        pnlView.Visible = false;
                                        pnlVerificatorShceduleAssignmentEditor.Visible = false;
                                        pnlVerificationStatusEditor.Visible = true;
                                        tabVSEditor.SelectedIndex = 0;
                                        pnlDelete.Visible = false;
                                        pnlSalesOrderReleaseEditor.Visible = false;
                                        pnlPrint.Visible = false;
                                        VsEventType = "ADD";

                                        cboVerificatorIDVSEditor.Enabled = true;
                                        cboKPNoVSEditor.Enabled = true;

                                        //SET COMBO BOX AND DETAIL VERIFICATOR ID
                                        _isLoadEditorVsEditor = false;
                                        loadVSVerificatorIDDetail("NEW");

                                        //SET QUALIFICATION HEADER
                                        loadGrdResultQualificationHeader();
                                        //SET QUALIFICATION VALUE AND TOTAL VALUE IN QUALIFICATION HEADER
                                        GetQualifierValue(cboVerificatorIDVSEditor.SelectedValue.ToString(), cboKPNoVSEditor.Text.Trim());

                                        //SET QUALIFICATION DETAIL
                                        loadGrdResultQualificationDetail();
                                        //SET QUALIFICATION DETAIL BY ID CUSTOMER
                                        fillgrdQualifierDetail(txtCustIDVSEditor.Text.Trim().ToString());

                                        _ExistForm = "NEW";
                                        setToolTip();
                                        Helper.SetActive(navNew);

                                        break;
                                    }
                                case "tabSOR":
                                    {
                                        loadCollector();

                                        clearSorEditor(true);

                                        dtDateOfVisitSorEditor.Value = getEndingDateCalenderFiscal();
                                        dtDeliveryDateSorEditor.Value = getEndingDateCalenderFiscal();
                                        dtDueDateSorEditor.Value = getEndingDateCalenderFiscal();
                                        dtDueDateSorEditor.Value = dtDueDateSorEditor.Value.AddMonths(1);

                                        groupBAHome.Visible = true;
                                        groupBAOffice.Visible = false;
                                        groupBAOther.Visible = false;

                                        groupDAHome.Visible = true;
                                        groupDAOffice.Visible = false;
                                        groupDAOther.Visible = false;

                                        txtBAOfficeAddress4SorEditor.Visible = false;
                                        txtDAOfficeAddress4SorEditor.Visible = false;

                                        pnlView.Visible = false;
                                        pnlVerificatorShceduleAssignmentEditor.Visible = false;
                                        pnlVerificationStatusEditor.Visible = false;
                                        tabVSEditor.SelectedIndex = 0;
                                        pnlDelete.Visible = false;
                                        pnlSalesOrderReleaseEditor.Visible = true;
                                        pnlPrint.Visible = false;
                                        SorEventType = "ADD";

                                        pnlMemo.Visible = false;
                                        txtKPNoSorEditor.ReadOnly = false;
                                        txtKPNoSorEditor.Focus();

                                        _ExistForm = "NEW";
                                        setToolTip();
                                        Helper.SetActive(navNew);

                                        break;
                                    }
                            }
                        }
                        break;
                    }
                case clsEventButton.EnumAction.EDIT:
                    {
                        if (_ExistForm == "VIEW")
                        {                   
                            switch (_ExistMenu)
                            {
                                case "tabVSA":
                                    {
                                        if (grdVSA.Rows.Count > 0 && grdKP.Rows.Count > 0)
                                        {
                                            if (getVerificatorID(_ExistMenu).ToString() != string.Empty)
                                            {
                                                loadCboVerificatorEditor(_ExistMenu);

                                                _isLoadEditorVsaEditor = false;
                                                bool _result = DrawPropertyVSAEditor(getVerificatorID(_ExistMenu).ToString());
                                                if (_result == true)
                                                {
                                                    btnSave.Text = "UPDATE";
                                                    txtKPNo.ReadOnly = true;
                                                    txtKPNo.Focus();
                                                    pnlView.Visible = false;
                                                    pnlVerificatorShceduleAssignmentEditor.Visible = true;
                                                    pnlVerificationStatusEditor.Visible = false;
                                                    pnlDelete.Visible = false;
                                                    pnlSalesOrderReleaseEditor.Visible = false;
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
                                            else
                                            {
                                                clsAlert.PushAlert("Select Data First!", clsAlert.Type.Error);
                                            }
                                        }
                                        else
                                        {
                                            clsAlert.PushAlert("Select Data First!", clsAlert.Type.Error);
                                        }
                                        break;
                                    }
                                case "tabVS":
                                    {
                                        if (grdVS.Rows.Count > 0 && grdActivity.Rows.Count > 0)
                                        {
                                            if (getVerificationStatus(_ExistMenu) == "I")
                                            {
                                                VsEventType = "EDIT";
                                            }
                                            else if (getVerificationStatus(_ExistMenu) == "R")
                                            {
                                                //FOR JUST EDIT REMARK THAT STATUS IS RELEASED
                                                VsEventType = "EDITR";
                                            }

                                            if (getVerificatorID(_ExistMenu).ToString() != string.Empty)
                                            {
                                                loadCboVerificatorEditor(_ExistMenu);

                                                _isLoadEditorVsEditor = false;
                                                bool _result = DrawPropertyVSEditor("EDIT", getVerificatorID(_ExistMenu).ToString());
                                                if (_result == true)
                                                {
                                                    btnSaveVSEditor.Text = "UPDATE";
                                                    pnlView.Visible = false;
                                                    pnlVerificatorShceduleAssignmentEditor.Visible = false;
                                                    pnlVerificationStatusEditor.Visible = true;
                                                    pnlPrint.Visible = false;

                                                    cboKPNoVSEditor.SelectedValue = getKPNo(_ExistMenu).ToString();
                                                    cboVerificatorIDVSEditor.Enabled = false;
                                                    pnlDelete.Visible = false;
                                                    pnlSalesOrderReleaseEditor.Visible = false;
                                                    cboKPNoVSEditor.Enabled = false;

                                                    //SET QUALIFICATION HEADER
                                                    loadGrdResultQualificationHeader();
                                                    //SET QUALIFICATION VALUE AND TOTAL VALUE IN QUALIFICATION HEADER
                                                    GetQualifierValue(cboVerificatorIDVSEditor.SelectedValue.ToString(), cboKPNoVSEditor.Text.Trim());

                                                    //SET QUALIFICATION DETAIL
                                                    loadGrdResultQualificationDetail();
                                                    //SET QUALIFICATION DETAIL BY ID CUSTOMER
                                                    fillgrdQualifierDetail(txtCustIDVSEditor.Text.Trim().ToString());

                                                    _ExistForm = "EDIT";
                                                    setToolTip();
                                                    Helper.SetActive(navEdit);
                                                }
                                                else
                                                {
                                                    clsAlert.PushAlert("Verificator ID not found!", clsAlert.Type.Error);
                                                }
                                            }
                                            else
                                            {
                                                clsAlert.PushAlert("Select Data First!", clsAlert.Type.Error);
                                            }
                                        }
                                        else
                                        {
                                            clsAlert.PushAlert("Select Data First!", clsAlert.Type.Error);
                                        }
                                        break;
                                    }
                                case "tabSOR":
                                    {
                                        if (grdSOR.Rows.Count > 0)
                                        {
                                            //load value
                                            if (getVerificationStatusSOR() == "R")
                                            {
                                                string _KPNoSor = getKPNo(_ExistMenu).ToString();
                                                if(_KPNoSor.Length > 0)
                                                {
                                                    loadCollector();
                                                    clearSorEditor(true);

                                                    dtDateOfVisitSorEditor.Value = getEndingDateCalenderFiscal();
                                                    dtDeliveryDateSorEditor.Value = getEndingDateCalenderFiscal();
                                                    dtDueDateSorEditor.Value = getEndingDateCalenderFiscal();
                                                    dtDueDateSorEditor.Value = dtDueDateSorEditor.Value.AddMonths(1);

                                                    groupBAHome.Visible = true;
                                                    groupBAOffice.Visible = false;
                                                    groupBAOther.Visible = false;

                                                    groupDAHome.Visible = true;
                                                    groupDAOffice.Visible = false;
                                                    groupDAOther.Visible = false;

                                                    txtBAOfficeAddress4SorEditor.Visible = false;
                                                    txtDAOfficeAddress4SorEditor.Visible = false;

                                                    pnlView.Visible = false;
                                                    pnlVerificatorShceduleAssignmentEditor.Visible = false;
                                                    pnlVerificationStatusEditor.Visible = false;
                                                    tabVSEditor.SelectedIndex = 0;
                                                    pnlDelete.Visible = false;
                                                    pnlSalesOrderReleaseEditor.Visible = true;
                                                    pnlPrint.Visible = false;
                                                    SorEventType = "EDIT";

                                                    pnlMemo.Visible = false;
                                                    txtKPNoSorEditor.Text = _KPNoSor;
                                                    //Load Data KP
                                                    DisplayKPNoDetailSorEditor();
                                                    txtKPNoSorEditor.ReadOnly = true;

                                                    _ExistForm = "EDIT";
                                                    setToolTip();
                                                    Helper.SetActive(navEdit);
                                                }
                                                else
                                                {
                                                    clsAlert.PushAlert("KP Number not found!", clsAlert.Type.Error);
                                                }
                                            }
                                            else
                                            {
                                                clsAlert.PushAlert("The Verification Status Must Be Released!", clsAlert.Type.Error);
                                            }
                                        }
                                        else
                                        {
                                            clsAlert.PushAlert("Select Data First!", clsAlert.Type.Error);
                                        }
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            if (_ExistForm != "EDIT")
                            {
                                clsAlert.PushAlert("Select Data on View Menu First!", clsAlert.Type.Error);
                            }
                        }
                        break;
                    }
                case clsEventButton.EnumAction.DELETE:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            switch (_ExistMenu)
                            {
                                case "tabVSA":
                                    {
                                        //nothing action
                                        break;
                                    }
                                case "tabVS":
                                    {
                                        if (grdVS.Rows.Count > 0)
                                        {
                                            if (getVerificationStatus(_ExistMenu).ToString() == "I")
                                            {
                                                pnlView.Visible = false;
                                                pnlVerificatorShceduleAssignmentEditor.Visible = false;
                                                pnlVerificationStatusEditor.Visible = false;
                                                pnlDelete.Visible = true;
                                                pnlSalesOrderReleaseEditor.Visible = false;
                                                pnlPrint.Visible = false;

                                                clearDelete();

                                                txtKPNoDelete.Text = getKPNo(_ExistMenu).ToString();
                                                txtVerificatorIDDelete.Text = getVerificatorID(_ExistMenu).ToString();
                                                txtVerificatorNameDelete.Text = getVerificatorName(_ExistMenu).ToString();
                                                loadCboCancelReason();

                                                _ExistForm = "DELETE";
                                                setToolTip();
                                                Helper.SetActive(navDelete);
                                            }
                                            else
                                            {
                                                clsAlert.PushAlert("The status must be in process!", clsAlert.Type.Error);
                                            }
                                        }
                                        else
                                        {
                                            clsAlert.PushAlert("Select Data First!", clsAlert.Type.Error);
                                        }

                                        break;
                                    }
                                case "tabSOR":
                                    {
                                        if (grdSOR.Rows.Count > 0)
                                        {
                                            if (getVerificationStatus(_ExistMenu).ToString() == "R")
                                            {
                                                if(getInvoiceStatus().ToString() == "S" || getInvoiceStatus().ToString() == "C")
                                                {
                                                    pnlView.Visible = false;
                                                    pnlVerificatorShceduleAssignmentEditor.Visible = false;
                                                    pnlVerificationStatusEditor.Visible = false;
                                                    pnlDelete.Visible = true;
                                                    pnlSalesOrderReleaseEditor.Visible = false;
                                                    pnlPrint.Visible = false;

                                                    clearDelete();

                                                    txtKPNoDelete.Text = getKPNo(_ExistMenu).ToString();
                                                    txtVerificatorIDDelete.Text = getVerificatorID(_ExistMenu).ToString();
                                                    //get verificator name
                                                    SOVerificatorMasterBL = new SOVerificatorMasterBL()
                                                    {
                                                        verificator_id = getVerificatorID(_ExistMenu).ToString()
                                                    };

                                                    DataTable dt = SOVerificationProcessAL.GetDataVerificatorSor(EnumFilter.GET_SEARCH_ID, SOVerificatorMasterBL, 0, 0);
                                                    if(dt.Rows.Count > 0)
                                                    {
                                                        txtVerificatorNameDelete.Text = dt.Rows[0]["svm_verificator_name"].ToString();
                                                    }

                                                    loadCboCancelReason();

                                                    _ExistForm = "DELETE";
                                                    setToolTip();
                                                    Helper.SetActive(navDelete);
                                                }
                                                else
                                                {
                                                    clsAlert.PushAlert("The Invoice Status Must Be Suspend or Cancel!", clsAlert.Type.Error);
                                                }
                                            }
                                            else
                                            {
                                                clsAlert.PushAlert("The Verification Status Must Be Released!", clsAlert.Type.Error);
                                            }
                                        }
                                        else
                                        {
                                            clsAlert.PushAlert("Select Data First!", clsAlert.Type.Error);
                                        }

                                        break;
                                    }
                            }
                        }
                        else
                        {
                            if (_ExistForm != "DELETE")
                            {
                                clsAlert.PushAlert("Select Data on View Menu First!", clsAlert.Type.Error);
                            }
                        }

                        break;
                    }
                case clsEventButton.EnumAction.PRINT:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            switch (_ExistMenu)
                            {
                                case "tabVSA":
                                    {
                                        bool _result = PrintReport(_ExistMenu);
                                        if (_result == true)
                                        {
                                            pnlView.Visible = false;
                                            pnlVerificatorShceduleAssignmentEditor.Visible = false;
                                            pnlVerificationStatusEditor.Visible = false;
                                            pnlDelete.Visible = false;
                                            pnlSalesOrderReleaseEditor.Visible = false;
                                            pnlPrint.Visible = true;

                                            _ExistForm = "PRINT";
                                            setToolTip();
                                            Helper.SetActive(navPrint);
                                        }

                                        break;
                                    }
                                case "tabVS":
                                    {
                                        bool _result = PrintReport(_ExistMenu);
                                        if (_result == true)
                                        {
                                            pnlView.Visible = false;
                                            pnlVerificatorShceduleAssignmentEditor.Visible = false;
                                            pnlVerificationStatusEditor.Visible = false;
                                            pnlDelete.Visible = false;
                                            pnlSalesOrderReleaseEditor.Visible = false;
                                            pnlPrint.Visible = true;

                                            _ExistForm = "PRINT";
                                            setToolTip();
                                            Helper.SetActive(navPrint);
                                        }
                                            
                                        break;
                                    }
                                case "tabSOR":
                                    {
                                        string _IsAssignDate = (chbAssignDateVs.Checked == true) ? "1" : "0";

                                        SOVerificationProcessBL = new SOVerificationProcessBL()
                                        {
                                            so_kp_no = txtKPNoSor.Text.Trim().ToString(),
                                            entity_id = cboEntitySor.SelectedValue.ToString().Trim(),
                                            branch_id = cboBranchSor.SelectedValue.ToString().Trim(),
                                            division_id = cboDivisionSor.SelectedValue.ToString().Trim(),
                                            verificator_id = cboVerificatorIDSor.SelectedValue.ToString().Trim(),
                                            verification_status = cboVerificationStatusSor.Text.ToString().Trim(),
                                            customer_name = txtCustNameSor.Text.Trim(),
                                            assignment_date = dtAssignDateVs.Value
                                        };

                                        dtPrintSOR = GlobalAL.GetReport(clsReport.REPORT_SO_SALES_ORDER_RELEASE(SOVerificationProcessBL, _IsAssignDate));
                                        if(dtPrintSOR.Rows.Count > 0)
                                        {
                                            if (printDialog1.ShowDialog() == DialogResult.OK)
                                            {
                                                _RowPrintSOR = 0;
                                                printDocument1.Print();
                                            }
                                        }

                                        break;
                                    }
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Back to View Menu First!", clsAlert.Type.Error);
                        }
                        break;
                    }
                case clsEventButton.EnumAction.EXPORT:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            switch (_ExistMenu)
                            {
                                case "tabVSA":
                                    {
                                        SOVerificationProcessBL = new SOVerificationProcessBL()
                                        {
                                            entity_id = cboEntityVsa.SelectedValue.ToString().ToUpper(),
                                            branch_id = cboBranchVsa.SelectedValue.ToString().ToUpper(),
                                            verificator_id = cboVerificatorVsa.SelectedValue.ToString().ToUpper(),
                                            so_kp_no = txtKPNoVsa.Text.Trim().ToUpper()
                                        };

                                        DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_VERIFICATION_SCHEDULE_ASSIGNMENT(SOVerificationProcessBL));
                                        if (dt.Rows.Count > 0)
                                        {
                                            clsExcel clExcel = new clsExcel();
                                            using (var fbd = new FolderBrowserDialog())
                                            {
                                                DialogResult result = fbd.ShowDialog();
                                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                                {
                                                    var path = fbd.SelectedPath;
                                                    clExcel.ExportToExcel(path, dt, EnumExcel.REPORT_VERIFICATOR_SCHEDULE_ASSIGNMENT);
                                                    MessageBox.Show("The data successfully generated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    Helper.SetActive(navView);
                                                }
                                            }
                                        }
                                        break;
                                    }
                                case "tabVS":
                                    {
                                        if (chbPrintedForm.Checked == true)
                                        {
                                            //GET DATA KP NO SELECTED
                                            string _SelectKPNo = string.Empty;

                                            foreach (var item in _SelectedKPNoArray)
                                            {
                                                if (_SelectKPNo == string.Empty)
                                                {
                                                    _SelectKPNo = "'" + item.ToString().Trim() + "'";
                                                }
                                                else
                                                {
                                                    _SelectKPNo = _SelectKPNo + "," + "'" + item.ToString().Trim() + "'";
                                                }
                                            }

                                            DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_VERIFICATION_STATUS_DELIVERY_CONFIRMATION(_SelectKPNo));

                                            if (dt.Rows.Count > 0)
                                            {
                                                clsExcel clExcel = new clsExcel();
                                                using (var fbd = new FolderBrowserDialog())
                                                {
                                                    DialogResult result = fbd.ShowDialog();
                                                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                                    {
                                                        var path = fbd.SelectedPath;
                                                        clExcel.ExportToExcel(path, dt, EnumExcel.REPORT_VERIFICATION_STATUS_DELIVERY_CONFIRMATION);
                                                        MessageBox.Show("The data successfully generated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                        Helper.SetActive(navView);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            //SET DATE KP FROM AND DATE KP UNTIL
                                            string dtFrom = Convert.ToString(dtFromKPDateVs.Value.Date);
                                            string dtUntil = Convert.ToString(dtUntilKPDateVs.Value.Date);

                                            dtFrom = dtFrom.Substring(0, (Convert.ToInt32(dtFrom.Length) - 9));
                                            dtUntil = dtUntil.Substring(0, (Convert.ToInt32(dtUntil.Length) - 9));

                                            dtFrom = dtFrom + " " + "00:00:00";
                                            dtUntil = dtUntil + " " + "23:59:01";

                                            //SET VERIFIER NAME
                                            string _VerifierName = string.Empty;
                                            if (cboVerifierNameVs.Text != "ALL")
                                            {
                                                int idx = cboVerifierNameVs.Text.ToString().IndexOf("-");
                                                _VerifierName = cboVerifierNameVs.Text.ToString().Substring(0, (idx - 1));
                                            }
                                            else
                                            {
                                                _VerifierName = cboVerifierNameVs.Text.ToString();
                                            }

                                            string _IsKPDate = (chbKPDateVs.Checked == true) ? "1" : "0";
                                            string _IsAssignDate = (chbAssignDateVs.Checked == true) ? "1" : "0";

                                            SOVerificationProcessBL = new SOVerificationProcessBL()
                                            {
                                                so_kp_no = txtKPNoVs.Text.Trim().ToString(),
                                                entity_id = cboEntityVs.SelectedValue.ToString().Trim(),
                                                branch_id = cboBranchVs.SelectedValue.ToString().Trim(),
                                                division_id = cboDivisionVs.SelectedValue.ToString().Trim(),
                                                verification_status = cboVerificationStatusVs.Text.ToString().Trim(),
                                                dp_status = cboDPStatusVs.Text.ToString().Trim(),
                                                type_of_activity = cboActivityVs.Text.ToString().Trim(),
                                                so_kp_date_from = Convert.ToDateTime(dtFrom),
                                                so_kp_date_until = Convert.ToDateTime(dtUntil),
                                                assignment_date = dtAssignDateVs.Value
                                            };

                                            DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_VERIFICATION_STATUS(SOVerificationProcessBL, _VerifierName, _IsKPDate, _IsAssignDate));
                                            if (dt.Rows.Count > 0)
                                            {
                                                clsExcel clExcel = new clsExcel();
                                                using (var fbd = new FolderBrowserDialog())
                                                {
                                                    DialogResult result = fbd.ShowDialog();
                                                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                                    {
                                                        var path = fbd.SelectedPath;
                                                        clExcel.ExportToExcel(path, dt, EnumExcel.REPORT_VERIFICATION_STATUS);
                                                        MessageBox.Show("The data successfully generated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                        Helper.SetActive(navView);
                                                    }
                                                }
                                            }
                                        }
                                            
                                        break;
                                    }
                                case "tabSOR":
                                    {
                                        string _IsAssignDate = (chbAssignDateVs.Checked == true) ? "1" : "0";

                                        SOVerificationProcessBL = new SOVerificationProcessBL()
                                        {
                                            so_kp_no = txtKPNoSor.Text.Trim().ToString(),
                                            entity_id = cboEntitySor.SelectedValue.ToString().Trim(),
                                            branch_id = cboBranchSor.SelectedValue.ToString().Trim(),
                                            division_id = cboDivisionSor.SelectedValue.ToString().Trim(),
                                            verificator_id = cboVerificatorIDSor.SelectedValue.ToString().Trim(),
                                            verification_status = cboVerificationStatusSor.Text.ToString().Trim(),
                                            customer_name = txtCustNameSor.Text.Trim(),
                                            assignment_date = dtAssignDateVs.Value
                                        };

                                        DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_SALES_ORDER_RELEASE(SOVerificationProcessBL, _IsAssignDate));
                                        if (dt.Rows.Count > 0)
                                        {
                                            clsExcel clExcel = new clsExcel();
                                            using (var fbd = new FolderBrowserDialog())
                                            {
                                                DialogResult result = fbd.ShowDialog();
                                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                                {
                                                    var path = fbd.SelectedPath;
                                                    clExcel.ExportToExcel(path, dt, EnumExcel.REPORT_SALES_ORDER_RELEASE);
                                                    MessageBox.Show("The data successfully generated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    Helper.SetActive(navView);
                                                }
                                            }
                                        }
                                        break;
                                    }
                            }

                            Helper.SetActive(navView);
                        }
                        else
                        {
                            clsAlert.PushAlert("Back to View Menu First!", clsAlert.Type.Error);
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
                        Close();
                        break;
                    }
                default:
                {
                    txtKPNoVsa.Focus();
                    pnlView.Visible = true;
                    pnlVerificatorShceduleAssignmentEditor.Visible = false;
                    pnlPrint.Visible = false;
                    _ExistForm = "VIEW";
                    setToolTip();
                    break;
                }
            }
        }

        private bool PrintReport(string _ExMenu)
        {
            bool _Result = false;

            try
            {
                // GET DATA FOR PROCESS EDITING
                if (_ExMenu == "tabVSA")
                {
                    SOVerificationProcessBL = new SOVerificationProcessBL()
                    {
                        entity_id = cboEntityVsa.SelectedValue.ToString().ToUpper(),
                        branch_id = cboBranchVsa.SelectedValue.ToString().ToUpper(),
                        verificator_id = cboVerificatorVsa.SelectedValue.ToString().ToUpper(),
                        so_kp_no = txtKPNoVsa.Text.Trim().ToUpper()
                    };

                    DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_VERIFICATION_SCHEDULE_ASSIGNMENT(SOVerificationProcessBL));
                    if (dt.Rows.Count > 0)
                    {
                        //get TCode menu
                        string _TCode = GlobalAL.GetTCode(this.Name.ToString());
                        DataTable dtCompany = GlobalAL.GetCompany();

                        rptSOVerificatorScheduleAssignment rptSOVerificatorScheduleAssignment = new rptSOVerificatorScheduleAssignment();
                        rptSOVerificatorScheduleAssignment.SetDataSource(dt);
                        rptSOVerificatorScheduleAssignment.SetParameterValue("lblCompany", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); ;
                        rptSOVerificatorScheduleAssignment.SetParameterValue("lblTCode", _TCode.ToUpper());
                        rptViewerVsa.ReportSource = rptSOVerificatorScheduleAssignment;

                        _Result = true;
                    }
                }
                else if (_ExMenu == "tabVS")
                {
                    if (chbPrintedForm.Checked == true)
                    {
                        if (grdVS.Rows.Count > 0)
                        {                            
                            //GET DATA KP NO SELECTED
                            string _SelectKPNo = string.Empty;

                            foreach (var item in _SelectedKPNoArray)
                            {
                                if (_SelectKPNo == string.Empty)
                                {
                                    _SelectKPNo = "'" + item.ToString().Trim() + "'";
                                }
                                else
                                {
                                    _SelectKPNo = _SelectKPNo + "," + "'" + item.ToString().Trim() + "'";
                                }
                            }

                            DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_VERIFICATION_STATUS_DELIVERY_CONFIRMATION(_SelectKPNo));
                            if (dt.Rows.Count > 0)
                            {
                                //get TCode menu
                                string _TCode = GlobalAL.GetTCode(this.Name.ToString());
                                DataTable dtCompany = GlobalAL.GetCompany();

                                rptSOVerificationStatusDeliveryConfirmation rptSOVerificationStatusDeliveryConfirmation = new rptSOVerificationStatusDeliveryConfirmation();
                                rptSOVerificationStatusDeliveryConfirmation.SetDataSource(dt);
                                rptSOVerificationStatusDeliveryConfirmation.SetParameterValue("lblCompany", dtCompany.Rows[0]["c_company"].ToString().ToUpper()); ;
                                rptSOVerificationStatusDeliveryConfirmation.SetParameterValue("lblTCode", _TCode.ToUpper());
                                rptViewerVsa.ReportSource = rptSOVerificationStatusDeliveryConfirmation;

                                _Result = true;
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Select KP Number first!", clsAlert.Type.Error);
                        }
                    }
                    else
                    {
                        //SET DATE KP FROM AND DATE KP UNTIL
                        string dtFrom = Convert.ToString(dtFromKPDateVs.Value.Date);
                        string dtUntil = Convert.ToString(dtUntilKPDateVs.Value.Date);

                        dtFrom = dtFrom.Substring(0, (Convert.ToInt32(dtFrom.Length) - 9));
                        dtUntil = dtUntil.Substring(0, (Convert.ToInt32(dtUntil.Length) - 9));

                        dtFrom = dtFrom + " " + "00:00:00";
                        dtUntil = dtUntil + " " + "23:59:01";

                        //SET VERIFIER NAME
                        string _VerifierName = string.Empty;
                        if (cboVerifierNameVs.Text != "ALL")
                        {
                            int idx = cboVerifierNameVs.Text.ToString().IndexOf("-");
                            _VerifierName = cboVerifierNameVs.Text.ToString().Substring(0, (idx - 1));
                        }
                        else
                        {
                            _VerifierName = cboVerifierNameVs.Text.ToString();
                        }

                        string _IsKPDate = (chbKPDateVs.Checked == true) ? "1" : "0";
                        string _IsAssignDate = (chbAssignDateVs.Checked == true) ? "1" : "0";

                        SOVerificationProcessBL = new SOVerificationProcessBL()
                        {
                            so_kp_no = txtKPNoVs.Text.Trim().ToString(),
                            entity_id = cboEntityVs.SelectedValue.ToString().Trim(),
                            branch_id = cboBranchVs.SelectedValue.ToString().Trim(),
                            division_id = cboDivisionVs.SelectedValue.ToString().Trim(),
                            verification_status = cboVerificationStatusVs.Text.ToString().Trim(),
                            dp_status = cboDPStatusVs.Text.ToString().Trim(),
                            type_of_activity = cboActivityVs.Text.ToString().Trim(),
                            so_kp_date_from = Convert.ToDateTime(dtFrom),
                            so_kp_date_until = Convert.ToDateTime(dtUntil),
                            assignment_date = dtAssignDateVs.Value
                        };

                        DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_VERIFICATION_STATUS(SOVerificationProcessBL, _VerifierName, _IsKPDate, _IsAssignDate));
                        if (dt.Rows.Count > 0)
                        {
                            rptSOVerificationStatus rptSOVerificationStatus = new rptSOVerificationStatus();
                            rptSOVerificationStatus.SetDataSource(dt);
                            rptSOVerificationStatus.SetParameterValue("Entity", cboEntityVs.Text.ToString());
                            rptSOVerificationStatus.SetParameterValue("Branch", cboBranchVs.Text.ToString());
                            rptSOVerificationStatus.SetParameterValue("Division", cboDivisionVs.Text.ToString());
                            rptSOVerificationStatus.SetParameterValue("VerifierName", cboVerifierNameVs.Text.ToString());
                            rptSOVerificationStatus.SetParameterValue("StatusOfVerification", cboVerificationStatusVs.Text.ToString());
                            rptSOVerificationStatus.SetParameterValue("StatusOfDP", cboDPStatusVs.Text.ToString());

                            if (chbAssignDateVs.Checked == true)
                            {
                                rptSOVerificationStatus.SetParameterValue("AssignDate", "ALL");
                            }
                            else
                            {
                                rptSOVerificationStatus.SetParameterValue("AssignDate", dtAssignDate.Value.Date.ToString("dd-MMM-yyyy"));
                            }

                            rptSOVerificationStatus.SetParameterValue("Activity", cboActivityVs.Text.ToString());

                            if (chbKPDateVs.Checked == true)
                            {
                                rptSOVerificationStatus.SetParameterValue("KPDateFrom", "ALL");
                                rptSOVerificationStatus.SetParameterValue("KPDateTo", "ALL");
                            }
                            else
                            {
                                rptSOVerificationStatus.SetParameterValue("KPDateFrom", dtFromKPDateVs.Value.Date.ToString("dd-MMM-yyyy"));
                                rptSOVerificationStatus.SetParameterValue("KPDateTo", dtUntilKPDateVs.Value.Date.ToString("dd-MMM-yyyy"));
                            }

                            rptViewerVsa.ReportSource = rptSOVerificationStatus;

                            _Result = true;
                        }
                        else
                        {
                            clsAlert.PushAlert("Data not found!", clsAlert.Type.Error);
                        }
                    }
                }
            }
            catch(Exception)
            {
                clsAlert.PushAlert("Error Loading Data!", clsAlert.Type.Error);
                _Result = false;
            }

            return _Result;
        }

        public void PrintSOR(PaintEventArgs e)
        {
            string _IsAssignDate = (chbAssignDateVs.Checked == true) ? "1" : "0";

            SOVerificationProcessBL = new SOVerificationProcessBL()
            {
                so_kp_no = txtKPNoSor.Text.Trim().ToString(),
                entity_id = cboEntitySor.SelectedValue.ToString().Trim(),
                branch_id = cboBranchSor.SelectedValue.ToString().Trim(),
                division_id = cboDivisionSor.SelectedValue.ToString().Trim(),
                verificator_id = cboVerificatorIDSor.SelectedValue.ToString().Trim(),
                verification_status = cboVerificationStatusSor.Text.ToString().Trim(),
                customer_name = txtCustNameSor.Text.Trim(),
                assignment_date = dtAssignDateVs.Value
            };

            DataTable dt = GlobalAL.GetReport(clsReport.REPORT_SO_SALES_ORDER_RELEASE(SOVerificationProcessBL, _IsAssignDate));
            if (dt.Rows.Count > 0)
            {
                // Create font and brush.
                Font _Font = new Font("Calibri", 9);
                SolidBrush _ColorFont = new SolidBrush(Color.Black);

                foreach (DataRow dr in dt.Rows)
                {
                    // Create point for upper-left corner of drawing.
                    PointF _Point = new PointF(150.0F, 150.0F);

                    // Draw string to screen.
                    e.Graphics.DrawString(dr["svs_so_kp_num"].ToString(), _Font, _ColorFont, _Point);
                }
            }
        }

        private string getVerificationStatus(string _ExMenu)
        {
            string _VerStatus = string.Empty;

            if (_ExMenu == "tabVS")
            {
                if (grdVS.Rows.Count > 0)
                {
                    int i;
                    i = grdVS.CurrentCell.RowIndex;
                    _VerStatus = grdVS["svs_verification_status_vs", i].Value.ToString().Substring(0, 1);
                }
            }
            else if (_ExMenu == "tabSOR")
            {
                if (grdSOR.Rows.Count > 0)
                {
                    int i;
                    i = grdSOR.CurrentCell.RowIndex;
                    _VerStatus = grdSOR["svs_verification_status_sor", i].Value.ToString().Substring(0, 1);
                }
            }

            return _VerStatus;
        }

        private string getInvoiceStatus()
        {
            string _InvStatus = string.Empty;

            if (grdSOR.Rows.Count > 0)
            {
                int i;
                i = grdSOR.CurrentCell.RowIndex;
                _InvStatus = grdSOR["skh_status_of_invoice_sor", i].Value.ToString().Substring(0, 1);
            }

            return _InvStatus;
        }

        private string getVerificationStatusSOR()
        {
            string _VerStatus = string.Empty;

            if (grdSOR.Rows.Count > 0)
            {
                int i;
                i = grdSOR.CurrentCell.RowIndex;
                _VerStatus = grdSOR["svs_verification_status_sor", i].Value.ToString().Substring(0, 1);
            }

            return _VerStatus;
        }

        private string getVerificatorID(string _ExMenu)
        {
            string _VerificatorID = string.Empty;
            if (_ExMenu == "tabVSA")
            {
                if (grdVSA.Rows.Count > 0)
                {
                    int i;
                    i = grdVSA.CurrentCell.RowIndex;
                    _VerificatorID = grdVSA["svm_verificator_id", i].Value.ToString();
                }
            }
            else if (_ExMenu == "tabVS")
            {
                if (grdVS.Rows.Count > 0)
                {
                    int i;
                    i = grdVS.CurrentCell.RowIndex;
                    _VerificatorID = grdVS["svs_verificator_id_vs", i].Value.ToString();
                }
            }
            else if (_ExMenu == "tabSOR")
            {
                if (grdSOR.Rows.Count > 0)
                {
                    int i;
                    i = grdSOR.CurrentCell.RowIndex;
                    _VerificatorID = grdSOR["svs_verificator_id_sor", i].Value.ToString();
                }
            }
            
            return _VerificatorID;
        }

        private string getMemo()
        {
            string _Memo = string.Empty;
            if (grdSOR.Rows.Count > 0)
            {
                int i;
                i = grdSOR.CurrentCell.RowIndex;
                _Memo = grdSOR["svs_remark_activity_sor", i].Value.ToString();
            }

            return _Memo;
        }

        private string getVerificatorName(string _ExMenu)
        {
            string _VerificatorName = string.Empty;
            if (_ExMenu == "tabVSA")
            {

            }
            else if (_ExMenu == "tabVS")
            {
                if (grdVS.Rows.Count > 0)
                {
                    int i;
                    i = grdVS.CurrentCell.RowIndex;
                    _VerificatorName = grdVS["svm_verificator_name_vs", i].Value.ToString();
                }
            }

            return _VerificatorName;
        }

        private string getKPNo(string _ExMenu)
        {
            string _KPNo = string.Empty;
            if (_ExMenu == "tabVSA")
            {
                if (grdKP.Rows.Count > 0)
                {
                    int i;
                    i = grdKP.CurrentCell.RowIndex;
                    _KPNo = grdKP["svs_so_kp_num", i].Value.ToString();
                }
            }
            else if(_ExMenu == "tabVS")
            {
                if (grdVS.Rows.Count > 0)
                {
                    int i;
                    i = grdVS.CurrentCell.RowIndex;
                    _KPNo = grdVS["svs_so_kp_num_vs", i].Value.ToString();
                }
            }
            else if (_ExMenu == "tabSOR")
            {
                if (grdSOR.Rows.Count > 0)
                {
                    int i;
                    i = grdSOR.CurrentCell.RowIndex;
                    _KPNo = grdSOR["svs_so_kp_num_sor", i].Value.ToString();
                }
            }

            return _KPNo;
        }

        private DateTime getAssignDate(string _ExMenu)
        {
            DateTime _AssignDate = DateTime.Now.Date;
            if (_ExMenu == "tabVSA")
            {
                if (grdKP.Rows.Count > 0)
                {
                    int i;
                    i = grdKP.CurrentCell.RowIndex;
                    _AssignDate = Convert.ToDateTime(grdKP["svs_assignment_date", i].Value);
                }
            }

            return _AssignDate;
        }

        private DateTime getAssignDate()
        {
            DateTime _AssignDate = DateTime.Now.Date;
            if (grdKP.Rows.Count > 0)
            {
                int i;
                i = grdKP.CurrentCell.RowIndex;
                _AssignDate = Convert.ToDateTime(grdKP["svs_assignment_date", i].Value);
            }
            return _AssignDate;
        }

        private void loadCboEntity()
        {
            //Load menu verificator shcedule assignment
            cboEntityVsa.DataSource = SOVerificationProcessAL.GetEntity(true);
            cboEntityVsa.ValueMember = "ValueMember";
            cboEntityVsa.DisplayMember = "DisplayMember";

            if(_UserEntityID.Trim() != "0") 
            {
                cboEntityVsa.Enabled = false;
                cboEntityVsa.SelectedValue = _UserEntityID;
            } 
            else 
            {
                cboEntityVsa.Enabled = true;
                cboEntityVsa.SelectedIndex = 0;
            }

            //Load menu verification status
            cboEntityVs.DataSource = SOVerificationProcessAL.GetEntity(true);
            cboEntityVs.ValueMember = "ValueMember";
            cboEntityVs.DisplayMember = "DisplayMember";

            if (_UserEntityID.Trim() != "0")
            {
                cboEntityVs.Enabled = false;
                cboEntityVs.SelectedValue = _UserEntityID;
            }
            else
            {
                cboEntityVs.Enabled = true;
                cboEntityVs.SelectedIndex = 0;
            }

            ////Load menu sales order release
            cboEntitySor.DataSource = SOVerificationProcessAL.GetEntity(true);
            cboEntitySor.ValueMember = "ValueMember";
            cboEntitySor.DisplayMember = "DisplayMember";

            if (_UserEntityID.Trim() != "0")
            {
                cboEntitySor.Enabled = false;
                cboEntitySor.SelectedValue = _UserEntityID;
            }
            else
            {
                cboEntitySor.Enabled = true;
                cboEntitySor.SelectedIndex = 0;
            }
        }

        private void loadCboBranch()
        {
            //Load menu verificator shcedule assignment
            cboBranchVsa.DataSource = SOVerificationProcessAL.GetBranch(true);
            cboBranchVsa.ValueMember = "ValueMember";
            cboBranchVsa.DisplayMember = "DisplayMember";

            if (_UserBranchID.Trim() != "0")
            {
                cboBranchVsa.Enabled = false;
                cboBranchVsa.SelectedValue = _UserBranchID.Trim();
            }
            else
            {
                cboBranchVsa.Enabled = true;
                cboBranchVsa.SelectedIndex = 0;
            }

            //Load menu verification status
            cboBranchVs.DataSource = SOVerificationProcessAL.GetBranch(true);
            cboBranchVs.ValueMember = "ValueMember";
            cboBranchVs.DisplayMember = "DisplayMember";

            if (_UserBranchID.Trim() != "0")
            {
                cboBranchVs.Enabled = false;
                cboBranchVs.SelectedValue = _UserBranchID.Trim();
            }
            else
            {
                cboBranchVs.Enabled = true;
                cboBranchVs.SelectedIndex = 0;
            }

            ////Load menu sales order release
            cboBranchSor.DataSource = SOVerificationProcessAL.GetBranch(true);
            cboBranchSor.ValueMember = "ValueMember";
            cboBranchSor.DisplayMember = "DisplayMember";

            if (_UserBranchID.Trim() != "0")
            {
                cboBranchSor.Enabled = false;
                cboBranchSor.SelectedValue = _UserBranchID.Trim();
            }
            else
            {
                cboBranchSor.Enabled = true;
                cboBranchSor.SelectedIndex = 0;
            }
        }

        private void loadCboVerificatorView()
        {
            SOVerificatorMasterBL = new SOVerificatorMasterBL()
            {
                active_flag = "A"
            };

            //Load menu verificator shcedule assignment
            cboVerificatorVsa.DataSource = SOVerificationProcessAL.GetVerificatorToComboBox(SOVerificatorMasterBL, true);
            cboVerificatorVsa.ValueMember = "ValueMember";
            cboVerificatorVsa.DisplayMember = "DisplayMember";

            //Load menu verificator verification status
            cboVerifierNameVs.DataSource = SOVerificationProcessAL.GetVerificatorToComboBox(SOVerificatorMasterBL, true);
            cboVerifierNameVs.ValueMember = "ValueMember";
            cboVerifierNameVs.DisplayMember = "DisplayMember";

            //Load menu verificator sales order release
            //_isLoadEditorVsEditor = true;
            cboVerificatorIDSor.DataSource = SOVerificationProcessAL.GetVerificatorToComboBoxByUserProperty(true, _UserEntityID, _UserBranchID, "");
            cboVerificatorIDSor.ValueMember = "ValueMember";
            cboVerificatorIDSor.DisplayMember = "DisplayMember";
        }

        private void loadCboVerificatorEditor(string _ExMenu)
        {
            if(_ExMenu == "tabVSA")
            {
                if(cboVerificatorID.Items.Count == 0)
                {
                    //Load menu verificator shcedule assignment editor
                    _isLoadEditorVsaEditor = true;
                    cboVerificatorID.DataSource = SOVerificationProcessAL.GetVerificatorToComboBoxByUserProperty(false, _UserEntityID, _UserBranchID, cboVerificatorVsa.SelectedValue.ToString());
                    cboVerificatorID.ValueMember = "ValueMember";
                    cboVerificatorID.DisplayMember = "ValueMember";
                    cboVerificatorID.SelectedIndex = 0;
                }
            }
            else if (_ExMenu == "tabVS")
            {
                //Load menu verificator verification status editor
                _isLoadEditorVsEditor = true;
                cboVerificatorIDVSEditor.DataSource = null;
                cboVerificatorIDVSEditor.DataSource = SOVerificationProcessAL.GetVerificatorToComboBoxByUserProperty(false, _UserEntityID, _UserBranchID, cboVerifierNameVs.SelectedValue.ToString());
                cboVerificatorIDVSEditor.ValueMember = "ValueMember";
                cboVerificatorIDVSEditor.DisplayMember = "ValueMember";
                cboVerificatorIDVSEditor.SelectedIndex = 0;
            }
        }

        private void loadCboDivision()
        {
            //Load menu verification status
            cboDivisionVs.DataSource = SOVerificationProcessAL.GetDivision(true);
            cboDivisionVs.ValueMember = "ValueMember";
            cboDivisionVs.DisplayMember = "DisplayMember";

            if (_UserDivisionID.Trim() != "0")
            {
                cboDivisionVs.Enabled = false;
                cboDivisionVs.SelectedValue = _UserDivisionID;
            }
            else
            {
                cboDivisionVs.Enabled = true;
                cboDivisionVs.SelectedIndex = 0;
            }

            //Load menu verification status
            cboDivisionSor.DataSource = SOVerificationProcessAL.GetDivision(true);
            cboDivisionSor.ValueMember = "ValueMember";
            cboDivisionSor.DisplayMember = "DisplayMember";

            if (_UserDivisionID.Trim() != "0")
            {
                cboDivisionSor.Enabled = false;
                cboDivisionSor.SelectedValue = _UserDivisionID;
            }
            else
            {
                cboDivisionSor.Enabled = true;
                cboDivisionSor.SelectedIndex = 0;
            }
        }

        private void loadCboVerificationStatus(ComboBox cmb)
        {
            //Load menu verification status
            cmb.Items.Add("ALL");
            cmb.Items.Add("Suspend");
            cmb.Items.Add("In Process");
            cmb.Items.Add("Release");
            cmb.Items.Add("Cancel");
            cmb.SelectedIndex = 0;
        }

        private void loadCboDPStatus()
        {
            //Load menu verification status
            cboDPStatusVs.Items.Add("ALL");
            cboDPStatusVs.Items.Add("Suspend");
            cboDPStatusVs.Items.Add("Registered");
            cboDPStatusVs.Items.Add("Deposited");
            cboDPStatusVs.Items.Add("None");
            cboDPStatusVs.SelectedIndex = 0;
        }

        private void loadCboActivity()
        {
            //Load menu verification status
            cboActivityVs.Items.Clear();
            cboActivityVs.Items.Add("ALL");
            cboActivityVs.Items.Add("Phone");
            cboActivityVs.Items.Add("Visit");
            cboActivityVs.Items.Add("Other");
            cboActivityVs.SelectedIndex = 0;

            //Load for grid menu verification status editor
            var Items = new[] {
                new {Value = "P", Display = "Phone", ToolTip = "Phone" },
                new { Value = "V", Display = "Visit", ToolTip = "Visit" },
                new { Value = "O", Display = "Other", ToolTip = "Other" }
            };

            grdCboActivity.DataSource = new BindingSource(Items, String.Empty);
            grdCboActivity.ValueMember = "Value";
            grdCboActivity.DisplayMember = "Display";
            grdCboActivity.DataPropertyName = "Value";
        }

        private void loadCboCancelReason()
        {
            cboCancelReason.DataSource = SOVerificationProcessAL.GetReasonCodesToComboBox();
            cboCancelReason.ValueMember = "ValueMember";
            cboCancelReason.DisplayMember = "DisplayMember";
            cboCancelReason.SelectedIndex = -1;
        }

        private void fillgrdQualifierDetail(string _CustID)
        {
            DataTable dt = SOVerificationProcessAL.GetVerificationCustomer(_CustID);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataGridViewRow row in grdQualifierDetail.Rows)
                    {
                        if (dr["svc_group_id"].ToString() + dr["svc_detail_id"].ToString() == row.Cells["sqh_qualifier_id"].Value.ToString() + row.Cells["sqd_qualifier_index_num"].Value.ToString())
                        {
                            row.Cells["grdStatus"].Value = (dr["svc_status"].ToString() == "Y") ? true : false;
                            row.Cells["grdValue"].Value = dr["svc_values"];
                            row.Cells["grdDesc"].Value = dr["svc_remarks"].ToString();
                        }
                    }
                }
            }
        }

        private void loadGrdResultQualificationHeader()
        {
            DataTable dt = SOVerificationProcessAL.GetQualificationHeader();
            if(dt.Rows.Count > 0)
            {
                grdQualifierHeader.DataSource = dt;
                grdQualifierHeader.AutoGenerateColumns = false;
            }
        }

        private void loadGrdResultQualificationDetail()
        {
            DataTable dtDetail = SOVerificationProcessAL.GetQualificationDetail();
            if (dtDetail.Rows.Count > 0)
            {
                grdQualifierDetail.DataSource = dtDetail;
                grdQualifierDetail.AutoGenerateColumns = false;
                grdQualifierDetail.Columns["sqh_qualifier_id"].Visible = false;
                grdQualifierDetail.Columns["sqd_qualifier_index_num"].Visible = false;
            }
        }

        private void GetQualifierValue(string _VerID, string _KPNo)
        {
            DataTable dt = SOVerificationProcessAL.GetQualifierValue(_VerID, _KPNo);
            if (dt.Rows.Count > 0)
            {
                int a = 1;
                foreach (DataGridViewRow row in grdQualifierHeader.Rows)
                {
                    if (a == 1)
                    {
                        row.Cells["grdRCValue"].Value = dt.Rows[0]["svs_qualifier_harta_value"];
                    }
                    else if (a == 2)
                    {
                        row.Cells["grdRCValue"].Value = dt.Rows[0]["svs_qualifier_karakter_value"];
                    }
                    else if (a == 3)
                    {
                        row.Cells["grdRCValue"].Value = dt.Rows[0]["svs_qualifier_status_value"];
                    }
                    else if (a == 4)
                    {
                        row.Cells["grdRCValue"].Value = dt.Rows[0]["svs_qualifier_lokasi_value"];
                    }
                    else
                    {
                        row.Cells["grdRCValue"].Value = dt.Rows[0]["svs_qualifier_kondisi_value"];
                    }

                    a++;

                    Double _TotalValue = Convert.ToDouble(row.Cells["sqh_coefficient_value"].Value) * Convert.ToDouble(row.Cells["grdRCValue"].Value);
                    row.Cells["grdRCTotalValue"].Value = _TotalValue;

                    lblTotalResultQualificationVal.Text = getTotalValue().ToString();
                }
            }
        }

        private void GetQualificationActivity(string _VerID, string _KPNo)
        {
            try
            {
                DataTable dt = SOVerificationProcessAL.GetQualificationActivity(_VerID, _KPNo);
                if (dt.Rows.Count > 0)
                {
                    grdVisitingActivity.Rows.Clear();

                    int no = 1;
                    foreach (DataRow row in dt.Rows)
                    {
                        grdVisitingActivity.Rows.Add(no, row["sva_activity_date"], Convert.ToDateTime(row["sva_activity_time"]), "", row["sva_comment"].ToString());

                        DataGridViewComboBoxCell comboBoxCell = (grdVisitingActivity.Rows[no - 1].Cells[3] as DataGridViewComboBoxCell);
                        comboBoxCell.Value = row["sva_type_of_activity"].ToString();
                        no++;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void GetMemoAndNoteVisitingActivity(string _VerID, string _KPNo)
        {
            DataTable dt = SOVerificationProcessAL.GetMemoVisitingActivity(_VerID, _KPNo);
            txtMemoVSEditor.Text = "";
            if (dt.Rows.Count > 0)
            {
                txtMemoVSEditor.Text = dt.Rows[0]["svs_remark_activity"].ToString();
            }

            txtKPOnlineNoteVSEditor.Text = "KP ONLINE NOTES" + Environment.NewLine +
                                           "----------------------" + Environment.NewLine;
            DataTable dtNotes = SOVerificationProcessAL.GetNotesVisitingActivity(_KPNo);
            if (dtNotes.Rows.Count > 0)
            {
                txtKPOnlineNoteVSEditor.Text = "KP ONLINE NOTES" + Environment.NewLine +
                                               "----------------------" + Environment.NewLine +
                                               dtNotes.Rows[0]["skh_kpo_notes"].ToString().ToUpper();
            }
        }

        private void PaginationKp(Boolean onloading = false)
        {
            if (_TotalPageKp == 0)
            {
                btnNextKp.Enabled = false;
                btnPrevKp.Enabled = false;
                return;
            }

            if (_TotalPageKp == _CurrentPageKp)
            {
                btnNextKp.Enabled = false;
                btnPrevKp.Enabled = false;
                if (_CurrentPageKp > 1)
                {
                    btnPrevKp.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrevKp.Enabled = false;
                btnNextKp.Enabled = false;

                return;
            }

            if (_CurrentPageKp < 2)
            {
                btnPrevKp.Enabled = false;
                btnNextKp.Enabled = true;
            }
            else
            {
                btnPrevKp.Enabled = true;
                btnNextKp.Enabled = true;
            }

            return;
        }

        private void Pagination(Boolean onloading = false)
        {
            if (_TotalPage == 0)
            {
                btnNextVsa.Enabled = false;
                btnPrevVsa.Enabled = false;
                return;
            }

            if (_TotalPage == _CurrentPage)
            {
                btnNextVsa.Enabled = false;
                btnPrevVsa.Enabled = false;
                if (_CurrentPage > 1)
                {
                    btnPrevVsa.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrevVsa.Enabled = false;
                btnNextVsa.Enabled = false;

                return;
            }

            if (_CurrentPage < 2)
            {
                btnPrevVsa.Enabled = false;
                btnNextVsa.Enabled = true;
            }
            else
            {
                btnPrevVsa.Enabled = true;
                btnNextVsa.Enabled = true;
            }

            return;
        }

        private void PaginationVs(Boolean onloading = false)
        {
            if (_TotalPageVs == 0)
            {
                btnNextVs.Enabled = false;
                btnPrevVs.Enabled = false;
                return;
            }

            if (_TotalPageVs == _CurrentPageVs)
            {
                btnNextVs.Enabled = false;
                btnPrevVs.Enabled = false;
                if (_CurrentPageVs > 1)
                {
                    btnPrevVs.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrevVs.Enabled = false;
                btnNextVs.Enabled = false;

                return;
            }

            if (_CurrentPageVs < 2)
            {
                btnPrevVs.Enabled = false;
                btnNextVs.Enabled = true;
            }
            else
            {
                btnPrevVs.Enabled = true;
                btnNextVs.Enabled = true;
            }

            return;
        }

        private void PaginationActivity(Boolean onloading = false)
        {
            if (_TotalPageActivity == 0)
            {
                btnNextActivity.Enabled = false;
                btnPrevActivity.Enabled = false;
                return;
            }

            if (_TotalPageActivity == _CurrentPageActivity)
            {
                btnNextActivity.Enabled = false;
                btnPrevActivity.Enabled = false;
                if (_CurrentPageActivity > 1)
                {
                    btnPrevActivity.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrevActivity.Enabled = false;
                btnNextActivity.Enabled = false;

                return;
            }

            if (_CurrentPageActivity < 2)
            {
                btnPrevActivity.Enabled = false;
                btnNextActivity.Enabled = true;
            }
            else
            {
                btnPrevActivity.Enabled = true;
                btnNextActivity.Enabled = true;
            }

            return;
        }

        private void PaginationSor(Boolean onloading = false)
        {
            if (_TotalPageSor == 0)
            {
                btnNextSor.Enabled = false;
                btnPrevSor.Enabled = false;
                return;
            }

            if (_TotalPageSor == _CurrentPageSor)
            {
                btnNextSor.Enabled = false;
                btnPrevSor.Enabled = false;
                if (_CurrentPageSor > 1)
                {
                    btnPrevSor.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrevSor.Enabled = false;
                btnNextSor.Enabled = false;

                return;
            }

            if (_CurrentPageSor < 2)
            {
                btnPrevSor.Enabled = false;
                btnNextSor.Enabled = true;
            }
            else
            {
                btnPrevSor.Enabled = true;
                btnNextSor.Enabled = true;
            }

            return;
        }

        private void DrawDatatableKp()
        {
            //GET DATA FOR GRID
            SOVerificationProcessBL = new SOVerificationProcessBL()
            {
                verificator_id = getVerificatorID(_ExistMenu).ToString(),
                so_kp_no = txtKPNoVsa.Text.Trim()
            };

            DataTable dt = SOVerificationProcessAL.ReadKp(EnumFilter.GET_WITH_PAGING, SOVerificationProcessBL, _CurrentPageKp, _FetchLimit);
            grdKP.AutoGenerateColumns = false;
            grdKP.DataSource = dt;
            grdKP.Columns["svs_so_kp_date"].DefaultCellStyle.Format = "dd MMM yyyy";
            grdKP.Columns["svs_assignment_date"].DefaultCellStyle.Format = "dd MMM yyyy";

            //GET COUNT FOR PAGING
            DataTable dtCount = SOVerificationProcessAL.ReadKp(EnumFilter.GET_COUNT_ROWS, SOVerificationProcessBL, _CurrentPageKp, _FetchLimit);
            _TotalPageKp = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
            lblPagingInfoKP.Text = (Convert.ToInt32(_TotalPageKp) > 0) ? "Pages : " + _CurrentPageKp.ToString() + " / " + _TotalPageKp : "Pages : - ";
            lblRowsKP.Text = "Records : " + grdKP.Rows.Count.ToString() + " Rows";
            PaginationKp();
        }

        private void DrawDatatableVsa()
        {
            //GET DATA FOR GRID
            SOVerificationProcessBL = new SOVerificationProcessBL()
            {
                entity_id = cboEntityVsa.SelectedValue.ToString(),
                branch_id = cboBranchVsa.SelectedValue.ToString(),
                verificator_id = cboVerificatorVsa.SelectedValue.ToString(),
                so_kp_no = txtKPNoVsa.Text.Trim()
            };

            bool _StateCboEntity, _StateCboBranch;

            if (cboEntityVsa.Enabled == true){ _StateCboEntity = true; } else { _StateCboEntity = false; }
            if (cboBranchVsa.Enabled == true) { _StateCboBranch = true; } else { _StateCboBranch = false; }

            DataTable dt = SOVerificationProcessAL.ReadVsa(EnumFilter.GET_WITH_PAGING, SOVerificationProcessBL, _CurrentPage, _FetchLimit, _StateCboEntity, _StateCboBranch, clsLogin.USERID.ToString());
            grdVSA.AutoGenerateColumns = false;
            grdVSA.DataSource = dt;

            //GET COUNT FOR PAGING
            DataTable dtCount = SOVerificationProcessAL.ReadVsa(EnumFilter.GET_COUNT_ROWS, SOVerificationProcessBL, _CurrentPage, _FetchLimit, _StateCboEntity, _StateCboBranch, clsLogin.USERID.ToString());
            _TotalPage = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
            lblPagingInfoVsa.Text = (Convert.ToInt32(_TotalPage) > 0) ? "Pages : " + _CurrentPage.ToString() + " / " + _TotalPage : "Pages : - ";
            lblRowsVSA.Text = "Records : " + grdVSA.Rows.Count.ToString() + " Rows";
            Pagination();
        }

        private void DrawDatatableVsKP()
        {
            //GET DATA FOR GRID
            SOVerificationProcessBL = new SOVerificationProcessBL()
            {
                entity_id = cboEntityVs.SelectedValue.ToString(),
                branch_id = cboBranchVs.SelectedValue.ToString(),
                division_id = cboDivisionVs.SelectedValue.ToString(),
                so_kp_no = txtKPNoVs.Text.Trim(),
                verificator_id = cboVerifierNameVs.SelectedValue.ToString(),
                verification_status = cboVerificationStatusVs.Text.Trim(),
                dp_status = cboDPStatusVs.Text.Trim(),
                type_of_activity = cboActivityVs.Text.Trim(),
                customer_id = txtCustCodeVs.Text.Trim(),
                customer_name = txtCustNameVs.Text.Trim(),
                so_kp_date_from = dtFromKPDateVs.Value.Date,
                so_kp_date_until = dtUntilKPDateVs.Value.Date,
                assignment_date = dtAssignDateVs.Value.Date
            };

            bool _StateCboEntityVs, _StateCboBranchVs, _StateCboDivisionVs;

            _StateCboEntityVs = (cboEntityVs.Enabled == true) ? true : false;
            _StateCboBranchVs = (cboBranchVs.Enabled == true) ? true : false;
            _StateCboDivisionVs = (cboDivisionVs.Enabled == true) ? true : false;

            DataTable dt = SOVerificationProcessAL.ReadVs(EnumFilter.GET_WITH_PAGING, SOVerificationProcessBL, _CurrentPageVs, _FetchLimit, _StateCboEntityVs, _StateCboBranchVs, _StateCboDivisionVs, clsLogin.USERID.ToString(), Convert.ToBoolean(chbKPDateVs.CheckState), Convert.ToBoolean(chbAssignDateVs.CheckState));
            grdVS.AutoGenerateColumns = false;
            grdVS.DataSource = dt;

            //GET COUNT FOR PAGING
            DataTable dtCount = SOVerificationProcessAL.ReadVs(EnumFilter.GET_COUNT_ROWS, SOVerificationProcessBL, _CurrentPageVs, _FetchLimit, _StateCboEntityVs, _StateCboBranchVs, _StateCboDivisionVs, clsLogin.USERID.ToString(), Convert.ToBoolean(chbKPDateVs.CheckState), Convert.ToBoolean(chbAssignDateVs.CheckState));
            _TotalPageVs = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
            lblPagingInfoVs.Text = (Convert.ToInt32(_TotalPageVs) > 0) ? "Pages : " + _CurrentPageVs.ToString() + " / " + _TotalPageVs : "Pages : - ";
            lblRowsVs.Text = "Records : " + grdVS.Rows.Count.ToString() + " Rows";
            PaginationVs();
        }

        private void DrawDatatableVsActivity()
        {
            //GET DATA FOR GRID
            SOVerificationProcessBL = new SOVerificationProcessBL()
            {
                verificator_id = getVerificatorID(_ExistMenu).ToString(),
                so_kp_no = getKPNo(_ExistMenu).ToString(),
                type_of_activity = cboActivityVs.Text.Trim()
            };

            DataTable dt = SOVerificationProcessAL.ReadActivity(EnumFilter.GET_WITH_PAGING, SOVerificationProcessBL, _CurrentPageActivity, _FetchLimit);
            grdActivity.AutoGenerateColumns = false;
            grdActivity.DataSource = dt;

            //GET COUNT FOR PAGING
            DataTable dtCount = SOVerificationProcessAL.ReadActivity(EnumFilter.GET_COUNT_ROWS, SOVerificationProcessBL, _CurrentPageActivity, _FetchLimit);
            _TotalPageActivity = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
            lblPagingInfoActivity.Text = (Convert.ToInt32(_TotalPageActivity) > 0) ? "Pages : " + _CurrentPageActivity.ToString() + " / " + _TotalPageActivity : "Pages : - ";
            lblRowsActivity.Text = "Records : " + grdActivity.Rows.Count.ToString() + " Rows";
            PaginationActivity();
        }

        private void LoadCheckedGridVS()
        {
            foreach (DataGridViewRow row in grdVS.Rows)
            {
                foreach (var item in _SelectedKPNoArray)
                {
                    if (row.Cells["svs_so_kp_num_vs"].Value.ToString().Trim() == item.ToString())
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["grdSelect_vs"];
                        chk.Value = Convert.ToBoolean(chk.TrueValue);
                    }

                }
            }
        }

        private void DrawDatatableSor()
        {
            //GET DATA FOR GRID
            SOVerificationProcessBL = new SOVerificationProcessBL()
            {
                entity_id = cboEntitySor.SelectedValue.ToString(),
                branch_id = cboBranchSor.SelectedValue.ToString(),
                division_id = cboDivisionSor.SelectedValue.ToString(),
                verificator_id = cboVerificatorIDSor.SelectedValue.ToString(),
                verification_status = cboVerificationStatusSor.Text.Trim(),
                so_kp_no = txtKPNoSor.Text.Trim(),
                assignment_date = dtAssignDateSor.Value.Date,
                customer_name = txtCustNameSor.Text.Trim()
            };

            bool _StateCboEntitySor, _StateCboBranchSor, _StateCboDivisionSor;

            _StateCboEntitySor = (cboEntitySor.Enabled == true) ? true : false;
            _StateCboBranchSor = (cboBranchSor.Enabled == true) ? true : false;
            _StateCboDivisionSor = (cboDivisionSor.Enabled == true) ? true : false;

            DataTable dt = SOVerificationProcessAL.ReadSor(EnumFilter.GET_WITH_PAGING, SOVerificationProcessBL, _CurrentPageSor, _FetchLimit, _StateCboEntitySor, _StateCboBranchSor, _StateCboDivisionSor, clsLogin.USERID.ToString(), Convert.ToBoolean(chbAssignDateSor.CheckState));
            grdSOR.AutoGenerateColumns = false;
            grdSOR.DataSource = dt;

            //GET COUNT FOR PAGING
            DataTable dtCount = SOVerificationProcessAL.ReadSor(EnumFilter.GET_COUNT_ROWS, SOVerificationProcessBL, _CurrentPageSor, _FetchLimit, _StateCboEntitySor, _StateCboBranchSor, _StateCboDivisionSor, clsLogin.USERID.ToString(), Convert.ToBoolean(chbAssignDateSor.CheckState));
            _TotalPageSor = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
            lblPagingInfoSor.Text = (Convert.ToInt32(_TotalPageSor) > 0) ? "Pages : " + _CurrentPageSor.ToString() + " / " + _TotalPageSor : "Pages : - ";
            lblRowsSor.Text = "Records : " + grdSOR.Rows.Count.ToString() + " Rows";
            PaginationSor();
        }

        private void DrawDatatable()
        {
            DrawDatatableVsa();
            DrawDatatableKp();
        }

        private void DrawDatatableVs()
        {
            DrawDatatableVsKP();
            DrawDatatableVsActivity();
        }

        private void SettingVariable(bool _IsAll)
        {
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            if(_IsAll == true)
            {
                //FOR DATA VSA HEADER
                _CurrentPage = 1;
                _TotalPage = 0;
            }

            //FOR DATA VSA DETAIL
            _CurrentPageKp = 1;
            _TotalPageKp = 0;
        }

        private void SettingVariableVs(bool _IsAll)
        {
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            if (_IsAll == true)
            {
                //FOR DATA VS HEADER
                _CurrentPageVs = 1;
                _TotalPageVs = 0;
            }

            //FOR DATA VS DETAIL
            _CurrentPageActivity = 1;
            _TotalPageActivity = 0;
        }

        private void SettingVariableSor()
        {
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            _CurrentPageSor = 1;
            _TotalPageSor = 0;
        }

        private void getPropertyUser()
        {
            DataTable dt = SOVerificationProcessAL.GetPropertyUser();
            _UserEntityID = dt.Rows[0]["usr_entity_id"].ToString();
            _UserEntity = dt.Rows[0]["ec_entity"].ToString();
            _UserBranchID = dt.Rows[0]["usr_branch_id"].ToString();
            _UserDivisionID = dt.Rows[0]["usr_Division_id"].ToString();
            _UserGroupID = dt.Rows[0]["usr_group_id"].ToString();
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

            ToolTip toolTipSearch = new ToolTip();
            toolTipSearch.ShowAlways = true;
            toolTipSearch.SetToolTip(btnSearchVSA, "SEARCH [F6]");

            ToolTip toolTipCancel = new ToolTip();
            toolTipCancel.ShowAlways = true;
            toolTipCancel.SetToolTip(btnCancel, "CANCEL [F9]");

            ToolTip toolTipSave = new ToolTip();
            toolTipSave.ShowAlways = true;
            if (_ExistForm == "NEW")
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

            // Verification Status
            //------------------------------------------------------------------

            ToolTip toolTipSearchVS = new ToolTip();
            toolTipSearchVS.ShowAlways = true;
            toolTipSearchVS.SetToolTip(btnSearchVS, "SEARCH [F6]");

            ToolTip toolTipEditMemoVS = new ToolTip();
            toolTipEditMemoVS.ShowAlways = true;
            toolTipEditMemoVS.SetToolTip(btnEditMemo, "EDIT MEMO [F11]");

            ToolTip toolTipBrowseVS = new ToolTip();
            toolTipBrowseVS.ShowAlways = true;
            toolTipBrowseVS.SetToolTip(btnBrowseVs, "BROWSE [F7]");

            ToolTip toolTipCancelVSEditor = new ToolTip();
            toolTipCancelVSEditor.ShowAlways = true;
            toolTipCancelVSEditor.SetToolTip(btnCancelVSEditor, "CANCEL [F9]");

            ToolTip toolTipSaveVSEditor = new ToolTip();
            toolTipSaveVSEditor.ShowAlways = true;
            if (_ExistForm == "NEW")
            {
                toolTipSaveVSEditor.SetToolTip(btnSaveVSEditor, "SAVE [F10]");
            }
            else if (_ExistForm == "EDIT")
            {
                toolTipSaveVSEditor.SetToolTip(btnSave, "UPDATE [F10]");
            }
            else if (_ExistForm == "DELETE")
            {
                toolTipSaveVSEditor.SetToolTip(btnSave, "DELETE [F10]");
            }

            ToolTip toolTipCancelDeleteVs = new ToolTip();
            toolTipCancelDeleteVs.ShowAlways = true;
            toolTipCancelDeleteVs.SetToolTip(btnCancelDelete, "CANCEL [F9]");

            ToolTip toolTipDeleteVs = new ToolTip();
            toolTipDeleteVs.ShowAlways = true;
            toolTipDeleteVs.SetToolTip(btnDelete, "DELETE [F10]");

            // Sales Order Release
            //------------------------------------------------------------------
            ToolTip toolTipSearchSOR = new ToolTip();
            toolTipSearchSOR.ShowAlways = true;
            toolTipSearchSOR.SetToolTip(btnSearchSor, "SEARCH [F6]");

            ToolTip toolTipDisplayMemoSor = new ToolTip();
            toolTipDisplayMemoSor.ShowAlways = true;
            toolTipDisplayMemoSor.SetToolTip(btnDisplayMemoSor, "DISPLAY MEMO [F11]");

            ToolTip toolTipCancelSorEditor = new ToolTip();
            toolTipCancelSorEditor.ShowAlways = true;
            toolTipCancelSorEditor.SetToolTip(btnCancelSorEditor, "CANCEL [F9]");

            ToolTip toolTipReleaseSorEditor = new ToolTip();
            toolTipReleaseSorEditor.ShowAlways = true;
            toolTipReleaseSorEditor.SetToolTip(btnReleaseSorEditor, "RELEASE [F10]");

            ToolTip toolTipListSorEditor = new ToolTip();
            toolTipListSorEditor.ShowAlways = true;
            toolTipListSorEditor.SetToolTip(btnListSorEditor, "LIST [F11]");
        }

        private void SO_VerificationProcessUI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;

            getPropertyUser();

            loadCboEntity();
            loadCboBranch();
            loadCboVerificatorView();
            loadCboDivision();
            loadCboVerificationStatus(cboVerificationStatusVs);
            loadCboDPStatus();
            loadCboActivity();
            loadCboVerificationStatus(cboVerificationStatusSor);

            _ExistMenu = tabVerificatationProcess.SelectedTab.Name.ToString();
            navView_Click(navView, null);
        }

        private void navView_Click(object sender, EventArgs e)
        {
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

        private void btnSearchVSA_Click(object sender, EventArgs e)
        {
            SettingVariable(true);
            Pagination(true);
            DrawDatatable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.VIEW);
        }

        private bool checkValidation()
        {
            bool _isPassed = false;
            if(txtVerificatorName.Text.Trim().Length > 0)
            {
                if (txtEntity.Text.Trim().Length > 0)
                {
                    if (txtBranch.Text.Trim().Length > 0)
                    {
                        if (txtKPNo.Text.Trim().Length > 0)
                        {
                            if (txtRepID.Text.Trim().Length > 0)
                            {
                                _isPassed = true;
                            }
                            else
                            {
                                clsAlert.PushAlert("Detail KP No Required!", clsAlert.Type.Error);
                                txtKPNo.Focus();
                                _isPassed = false;
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("KP No Required!", clsAlert.Type.Error);
                            txtKPNo.Focus();
                            _isPassed = false;
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Branch Required!", clsAlert.Type.Error);
                        cboVerificatorID.Focus();
                        _isPassed = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("KPEntity Required!", clsAlert.Type.Error);
                    cboVerificatorID.Focus();
                    _isPassed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("Verificator Name Required!", clsAlert.Type.Error);
                cboVerificatorID.Focus();
                _isPassed = false;
            }

            return _isPassed;
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXIT);
        }

        private void cboVerificatorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadVSADetail(cboVerificatorID.SelectedValue.ToString());
        }

        //Setting for new row datagrid
        private void grdVisitingActivity_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (grdVisitingActivity.Rows.Count == 1)
            {
                (sender as DataGridView).Rows[0].Cells[0].Value = 1;
            }
            else if (grdVisitingActivity.Rows.Count > 1)
            {
                (sender as DataGridView).Rows[e.Row.Index].Cells[0].Value = e.Row.Index + 1;
            }
        }

        private void btnSearchVS_Click(object sender, EventArgs e)
        {
            SettingVariableVs(true);
            PaginationVs(true);
            DrawDatatableVs();
            _SelectedKPNoArray.Clear();

        }

        private double getTotalValue()
        {
            double _totaValue = 0;

            foreach (DataGridViewRow row in grdQualifierHeader.Rows)
            {
                double _Value = (row.Cells["grdRCTotalValue"].Value == null || Convert.ToString(row.Cells["grdRCTotalValue"].Value) == "") ? 0 : Convert.ToDouble(row.Cells["grdRCTotalValue"].Value);
                _totaValue = _totaValue + _Value;
            }

            return _totaValue;
        }

        private void grdQualifierHeader_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grdQualifierHeader.Columns[e.ColumnIndex].Name.ToString() == "grdRCValue")
            {
                if(grdQualifierHeader.CurrentCell.Value != null)
                {
                    string _valMaxRange = grdQualifierHeader.Rows[e.RowIndex].Cells["sqh_Point_Range"].Value.ToString().Substring(4, 2).ToString();
                    string _valMinRange = grdQualifierHeader.Rows[e.RowIndex].Cells["sqh_Point_Range"].Value.ToString().Substring(0, 1).ToString();
                    int _value = (grdQualifierHeader.CurrentCell.Value == DBNull.Value) ? 0 : Convert.ToInt32(grdQualifierHeader.CurrentCell.Value);

                    if (_value == 0)
                    {
                        grdQualifierHeader.Rows[e.RowIndex].Cells["grdRCTotalValue"].Value = 0;
                        grdQualifierHeader.Rows[e.RowIndex].Cells["grdRCValue"].Value = 0;
                    }
                    else if (Convert.ToInt32(_valMinRange) <= _value && Convert.ToInt32(_valMaxRange) >= _value)
                    {
                        Double _TotalValue = Convert.ToDouble(grdQualifierHeader.Rows[e.RowIndex].Cells["sqh_coefficient_value"].Value) * _value;
                        grdQualifierHeader.Rows[e.RowIndex].Cells["grdRCTotalValue"].Value = _TotalValue;
                    }
                    else
                    {
                        clsAlert.PushAlert("The value must be between range!", clsAlert.Type.Error);
                        grdQualifierHeader.Rows[e.RowIndex].Cells["grdRCTotalValue"].Value = 0;
                        grdQualifierHeader.Rows[e.RowIndex].Cells["grdRCValue"].Value = 0;
                    }           
                }
                else
                {
                    grdQualifierHeader.Rows[e.RowIndex].Cells["grdRCTotalValue"].Value = 0;
                }

                lblTotalResultQualificationVal.Text = getTotalValue().ToString();
            }
        }

        private void grdQualifierHeader_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnValue_KeyPress);
            if (grdQualifierHeader.CurrentCell.ColumnIndex == 0)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnValue_KeyPress);
                }
            }
        }

        private void ColumnValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grdQualifierDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnValueQualifierDetail_KeyPress);
            if (grdQualifierDetail.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnValueQualifierDetail_KeyPress);
                }
            }
        }

        private void ColumnValueQualifierDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPrevVs_Click(object sender, EventArgs e)
        {
            _CurrentPageVs--;
            PaginationVs(true);
            DrawDatatableVs();
            _CurrentPageActivity = 1;
            DrawDatatableVsActivity();
            LoadCheckedGridVS();
        }

        private void btnNextVs_Click(object sender, EventArgs e)
        {
            _CurrentPageVs++;
            PaginationVs(true);
            DrawDatatableVs();
            DrawDatatableVsActivity();
            LoadCheckedGridVS();
        }

        private void btnPrevActivity_Click(object sender, EventArgs e)
        {
            _CurrentPageActivity--;
            PaginationActivity(true);
            DrawDatatableVsActivity();
        }

        private void tabVerificatationProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ExistMenu = tabVerificatationProcess.SelectedTab.Name.ToString();
        }

        private void btnCancelVSEditor_Click(object sender, EventArgs e)
        {
            SettingVariableVs(true);
            settingPanel(clsEventButton.EnumAction.VIEW);
        }

        private bool checkValidationVSEditor()
        {
            bool _isPassed = false;
            if (cboVerificatorIDVSEditor.SelectedValue.ToString().Length > 0)
            {
                if (cboKPNoVSEditor.Text.Trim().Length > 0)
                {
                    if (txtKPValueVSEditor.Text.Trim().Length > 0)
                    {
                        _isPassed = true;
                    }
                    else
                    {
                        clsAlert.PushAlert("Detail KP Number Required!", clsAlert.Type.Error);
                        cboKPNoVSEditor.Focus();
                        _isPassed = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("KP Number Required!", clsAlert.Type.Error);
                    cboKPNoVSEditor.Focus();
                    _isPassed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("Verificator ID Required!", clsAlert.Type.Error);
                cboVerificatorIDVSEditor.Focus();
                _isPassed = false;
            }

            return _isPassed;
        }

        private bool checkValidationVSEditorActivity()
        {
            bool _isPassed = false;
            int _RowCount = 0;

            foreach (DataGridViewRow row in grdVisitingActivity.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["grdChbDelete"];
                if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                {
                    _RowCount++;

                    if (Convert.ToString(row.Cells["grdDtDate"].Value) != "")
                    {
                        if (Convert.ToString(row.Cells["grdDtTime"].Value) != "")
                        {
                            if (Convert.ToString(row.Cells["grdCboActivity"].Value) != "")
                            {
                                _isPassed = true;
                            }
                            else
                            {
                                clsAlert.PushAlert("Activity on Visiting Activity line " + row.Cells["grdTxtNo"].Value.ToString() + " can't be null!", clsAlert.Type.Error);
                                _isPassed = false;
                                break;
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Time on Visiting Activity line " + row.Cells["grdTxtNo"].Value.ToString() + " can't be null!", clsAlert.Type.Error);
                            _isPassed = false;
                            break;
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Date on Visiting Activity line " + row.Cells["grdTxtNo"].Value.ToString() + " can't be null!", clsAlert.Type.Error);
                        _isPassed = false;
                        break;
                    }
                }
            }

            if(_RowCount == 0)
            {
                clsAlert.PushAlert("Insert data on Visiting Activity, Please!", clsAlert.Type.Error);
                _isPassed = false;
            }

            return _isPassed;
        }

        private void btnSaveVSEditor_Click(object sender, EventArgs e)
        {
            if (checkValidationVSEditor() == true)
            {
                if (checkValidationVSEditorActivity() == true)
                {
                    SOVerificationProcessBL = new SOVerificationProcessBL()
                    {
                        customer_id = txtCustIDVSEditor.Text.Trim(),
                        entity_id = txtEntityVSEditor.Tag.ToString(),
                        branch_id = txtBranchVSEditor.Tag.ToString(),
                        division_id = txtDivisionVSEditor.Tag.ToString(),
                        verificator_id = cboVerificatorIDVSEditor.SelectedValue.ToString(),
                        so_kp_no = cboKPNoVSEditor.Text.Trim(),
                        qualifier_total_value = Convert.ToInt32(lblTotalResultQualificationVal.Text),
                        remark_activity = txtMemoVSEditor.Text.Trim()
                    };

                    if (_ExistForm == "NEW")
                    {
                        if (clsDialog.ShowDialog("Save New Verification Status ?") == DialogResult.Yes)
                        {
                            bool _isSucess = SOVerificationProcessAL.PostVS(grdQualifierDetail, grdVisitingActivity, grdQualifierHeader, SOVerificationProcessBL, txtVisaAutoVSEditor.Text.Trim());
                            if (_isSucess == true)
                            {
                                ClearEditorVs(true);
                                cboVerificatorIDVSEditor.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (clsDialog.ShowDialog("Update Verification Status " + cboKPNoVSEditor.Text.Trim() + " ?") == DialogResult.Yes)
                        {
                            if(VsEventType == "EDIT")
                            {
                                bool _isSucess = SOVerificationProcessAL.PutVS(grdVisitingActivity, SOVerificationProcessBL, txtVisaAutoVSEditor.Text.Trim());
                                if (_isSucess == true)
                                {
                                    ClearEditorVs(true);
                                    //clearViewVs();
                                    tabVerificatationProcess.SelectedIndex = 1;
                                    btnSearchVS_Click(null, null);
                                    navView_Click(null, null);
                                }
                            }
                            else if(VsEventType == "EDITR")
                            {
                                bool _isSucess = SOVerificationProcessAL.PutReleaseVS(grdQualifierDetail, grdVisitingActivity, grdQualifierHeader, SOVerificationProcessBL, txtVisaAutoVSEditor.Text.Trim());
                                if (_isSucess == true)
                                {
                                    ClearEditorVs(true);
                                    //clearViewVs();
                                    tabVerificatationProcess.SelectedIndex = 1;
                                    btnSearchVS_Click(null, null);
                                    navView_Click(null, null);
                                }
                            }
                        }
                    }

                }
            }
        }

        void grdVisitingActivity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (grdVisitingActivity.CurrentCell.ColumnIndex == 4)
                {
                    addRowsGrdVisitingActivity();
                }
            }
        }

        private void grdVisitingActivity_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.PreviewKeyDown -= new PreviewKeyDownEventHandler(grdVisitingActivity_PreviewKeyDown);
            if (grdVisitingActivity.CurrentCell.ColumnIndex == 4)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.PreviewKeyDown += new PreviewKeyDownEventHandler(grdVisitingActivity_PreviewKeyDown);
                }
            }
        }

        private void btnCancelDelete_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.VIEW);
        }

        private bool checkDelete()
        {
            bool _isPassed = false;

            if(txtKPNoDelete.Text.Trim().Length > 0)
            {
                if (txtVerificatorIDDelete.Text.Trim().Length > 0)
                {
                    if (txtVerificatorNameDelete.Text.Trim().Length > 0)
                    {
                        if (cboCancelReason.Text.Trim().Length > 0)
                        {
                            _isPassed = true;
                        }
                        else
                        {
                            clsAlert.PushAlert("Reason Required!", clsAlert.Type.Error);
                            cboCancelReason.Focus();
                            _isPassed = false;
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Verificator Name Required!", clsAlert.Type.Error);
                        txtVerificatorNameDelete.Focus();
                        _isPassed = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("Verificator ID Required!", clsAlert.Type.Error);
                    txtVerificatorIDDelete.Focus();
                    _isPassed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("KP Number Required!", clsAlert.Type.Error);
                txtKPNoDelete.Focus();
                _isPassed = false;
            }

            return _isPassed;
        }

        private void clearDelete()
        {
            txtKPNoDelete.Text = string.Empty;
            txtVerificatorIDDelete.Text = string.Empty;
            txtVerificatorNameDelete.Text = string.Empty;
            cboCancelReason.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(checkDelete() == true)
            {
                if(_ExistMenu == "tabVS")
                {
                    if (clsDialog.ShowDialog("Delete Verification Status " + txtKPNoDelete.Text.Trim() + " ? ") == DialogResult.Yes)
                    {
                        bool _stillRelease = false;
                        if (clsDialog.ShowDialog("Do You Want The KP STATUS " + txtKPNoDelete.Text.Trim() + " still : RELEASE ? ") == DialogResult.Yes)
                        {
                            _stillRelease = true;
                        }

                        SOVerificationProcessBL = new SOVerificationProcessBL()
                        {
                            verificator_id = txtVerificatorIDDelete.Text,
                            so_kp_no = txtKPNoDelete.Text,
                            cancellation_reason = cboCancelReason.Text
                        };

                        bool _isSucess = SOVerificationProcessAL.DeleteVs(SOVerificationProcessBL, _stillRelease);
                        if (_isSucess == true)
                        {
                            clearDelete();
                            navView_Click(null, null);
                            btnSearchVS_Click(null, null);
                        }
                    }
                }
                else if(_ExistMenu == "tabSOR")
                {
                    if (clsDialog.ShowDialog("Delete Sales Order Release " + txtKPNoDelete.Text.Trim() + " ? ") == DialogResult.Yes)
                    {
                        bool _stillRelease = false;
                        if (clsDialog.ShowDialog("Do You Want The KP STATUS " + txtKPNoDelete.Text.Trim() + " still : RELEASE ? ") == DialogResult.Yes)
                        {
                            _stillRelease = true;
                        }

                        SOVerificationProcessBL = new SOVerificationProcessBL()
                        {
                            verificator_id = txtVerificatorIDDelete.Text,
                            so_kp_no = txtKPNoDelete.Text,
                            cancellation_reason = cboCancelReason.Text
                        };

                        bool _isSucess = SOVerificationProcessAL.DeleteSor(SOVerificationProcessBL, _stillRelease);
                        if (_isSucess == true)
                        {
                            clearDelete();
                            navView_Click(null, null);
                            btnSearchSor_Click(null, null);
                        }
                    }
                }
            }
        }

        private void btnEditMemo_Click(object sender, EventArgs e)
        {
            if(grdVS.Rows.Count > 0)
            {
                SO_DialogEditMemo frm = new SO_DialogEditMemo();
                frm._MenuName = tabVerificatationProcess.SelectedTab.Name;
                frm._VerID = getVerificatorID(_ExistMenu).ToString();
                frm._VerName = getVerificatorName(_ExistMenu).ToString();
                frm._KPNo = getKPNo(_ExistMenu).ToString();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnSearchVS_Click(null, null);
                }
            }
            else
            {
                clsAlert.PushAlert("Please select data first!", clsAlert.Type.Error);
            }
        }

        private void btnSearchSor_Click(object sender, EventArgs e)
        {
            SettingVariableSor();
            PaginationSor(true);
            DrawDatatableSor();
        }

        private void btnNextActivity_Click(object sender, EventArgs e)
        {
            _CurrentPageActivity++;
            PaginationActivity(true);
            DrawDatatableVsActivity();
        }

        private void grdVS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DrawDatatableVsActivity();
            }
        }

        private void txtKPNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool _isValid = ValidateKPNo();
                if (_isValid == true)
                {
                    DisplayKPNoDetail("NEW");
                }
                else
                {
                    ClearEditorVsa();
                }
            }
        }

        private void chbAssignDateSor_CheckedChanged(object sender, EventArgs e)
        {
            dtAssignDateSor.Enabled = (chbAssignDateSor.Checked == true) ? false : true;
        }

        private void btnNextSor_Click(object sender, EventArgs e)
        {
            _CurrentPageSor++;
            PaginationSor(true);
            DrawDatatableSor();
        }

        private void btnPrevSor_Click(object sender, EventArgs e)
        {
            _CurrentPageSor--;
            PaginationSor(true);
            DrawDatatableSor();
        }

        private void btnDisplayMemoSor_Click(object sender, EventArgs e)
        {
            if(grdSOR.Rows.Count > 0)
            {
                SO_DialogEditMemo frm = new SO_DialogEditMemo();
                frm._MenuName = tabVerificatationProcess.SelectedTab.Name;
                frm._Memo = getMemo().ToString();
                frm.ShowDialog();
            }
            else
            {
                clsAlert.PushAlert("Please select data first!", clsAlert.Type.Error);
            }
        }

        private void rbBAHomeSorEditor_CheckedChanged(object sender, EventArgs e)
        {
            //FlagAddrs = "Billing Home"

            groupBAHome.Visible = true;
            groupBAOffice.Visible = false;
            groupBAOther.Visible = false;

            if(chbChangeCollectorSoeEditor.Checked == true)
            {
                if(txtBAHomeCollectorSorEditor.Text.Trim().Length > 0)
                {
                    cboCollectorSorEditor.Text = txtBAHomeCollectorSorEditor.Text;
                }
            }
        }

        private void rbBAOfficeSorEditor_CheckedChanged(object sender, EventArgs e)
        {
            //FlagAddrs = "Billing Office"

            groupBAHome.Visible = false;
            groupBAOffice.Visible = true;
            groupBAOther.Visible = false;
            txtBAOfficeAddress4SorEditor.Visible = true;

            if (chbChangeCollectorSoeEditor.Checked == true)
            {
                if (txtBAOfficeCollectorSorEditor.Text.Trim().Length > 0)
                {
                    cboCollectorSorEditor.Text = txtBAOfficeCollectorSorEditor.Text;
                }
            }
        }

        private void rbBAOtherSorEditor_CheckedChanged(object sender, EventArgs e)
        {
            //FlagAddrs = "Billing Other"

            groupBAHome.Visible = false;
            groupBAOffice.Visible = false;
            groupBAOther.Visible = true;

            if (chbChangeCollectorSoeEditor.Checked == true)
            {
                if (txtBAOtherCollectorSorEditor.Text.Trim().Length > 0)
                {
                    cboCollectorSorEditor.Text = txtBAOtherCollectorSorEditor.Text;
                }
            }
        }

        private void rbDAHomeSorEditor_CheckedChanged(object sender, EventArgs e)
        {
            // FlagAddrsDel = "Delivery Home"

            groupDAHome.Visible = true;
            groupDAOffice.Visible = false;
            groupDAOther.Visible = false;
        }

        private void rbDAOfficeSorEditor_CheckedChanged(object sender, EventArgs e)
        {
            // FlagAddrsDel = "Delivery Office"

            txtDAOfficeAddress4SorEditor.Visible = true;
            groupDAHome.Visible = false;
            groupDAOffice.Visible = true;
            groupDAOther.Visible = false;
        }

        private void rbDAOtherSorEditor_CheckedChanged(object sender, EventArgs e)
        {
            // FlagAddrsDel = "Delivery Other"

            groupDAHome.Visible = false;
            groupDAOffice.Visible = false;
            groupDAOther.Visible = true;
        }

        private void chbChangeCollectorSoeEditor_CheckedChanged(object sender, EventArgs e)
        {
            string _CollectorIDOld = "";
            if(cboCollectorSorEditor.Text.Trim().Length > 0)
            {
                _CollectorIDOld = cboCollectorSorEditor.Text;
            }

            if(chbChangeCollectorSoeEditor.Checked == true)
            {
                if(rbBAOfficeSorEditor.Checked == true)
                {
                    if(txtBAOfficeCollectorSorEditor.Text.Trim().Length > 0)
                    {
                        cboCollectorSorEditor.Text = txtBAOfficeCollectorSorEditor.Text;
                    }
                }
                else if (rbBAHomeSorEditor.Checked == true)
                {
                    if (txtBAHomeCollectorSorEditor.Text.Trim().Length > 0)
                    {
                        cboCollectorSorEditor.Text = txtBAHomeCollectorSorEditor.Text;
                    }
                }
            }
            else
            {
                cboCollectorSorEditor.Text = _CollectorIDOld;
            }
        }

        private void btnCancelSorEditor_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.VIEW);
        }

        private void btnBAEditSorEditor_Click(object sender, EventArgs e)
        {
            if(txtKPNoSorEditor.Text.Trim().Length > 0 && txtEntitySorEditor.Text.Trim().Length > 0)
            {
                SO_DialogEditCustomerAddress frm = new SO_DialogEditCustomerAddress();

                frm._Flag = "BILLING";
                frm._CustID = txtCustIDSorEditor.Text;
                frm._CustName = txtCustNameSorEditor.Text;

                if (rbBAHomeSorEditor.Checked == true)
                {
                    frm._SubFlag = "HOME";
                    frm._Title = "EDIT CUSTOMER HOME ADDRESS";
                    frm._Address1 = txtBAHomeAddress1SorEditor.Text;
                    frm._Address2 = txtBAHomeAddress2SorEditor.Text;
                    frm._Address3 = txtBAHomeAddress3SorEditor.Text;
                    frm._RT = txtBAHomeRTSorEditor.Text;
                    frm._RW = txtBAHomeRWSorEditor.Text;
                    frm._ZipCode = txtBAHomeZipCodeSorEditor.Text;
                    frm._Kel = txtBAHomeKelurahanSorEditor.Text;
                    frm._Kec = txtBAHomeKecamatanSorEditor.Text;
                    frm._City = txtBAHomeCitySorEditor.Text;
                    frm._Prov = txtBAHomeProvinsiSorEditor.Text;

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txtCustNameSorEditor.Text = frm._CustName;

                        //UPDATE BILLING ADDRESS
                        txtBAHomeAddress1SorEditor.Text = frm._Address1;
                        txtBAHomeAddress2SorEditor.Text = frm._Address2;
                        txtBAHomeAddress3SorEditor.Text = frm._Address3;
                        txtBAHomeRTSorEditor.Text = frm._RT;
                        txtBAHomeRWSorEditor.Text = frm._RW;
                        txtBAHomeZipCodeSorEditor.Text = frm._ZipCode;
                        txtBAHomeKelurahanSorEditor.Text = frm._Kel;
                        txtBAHomeKecamatanSorEditor.Text = frm._Kec;
                        txtBAHomeCitySorEditor.Text = frm._City;
                        txtBAHomeProvinsiSorEditor.Text = frm._Prov;

                        //UPDATE DELIVERY ADDRESS
                        txtDAHomeAddress1SorEditor.Text = frm._Address1;
                        txtDAHomeAddress2SorEditor.Text = frm._Address2;
                        txtDAHomeAddress3SorEditor.Text = frm._Address3;
                        txtDAHomeRTSorEditor.Text = frm._RT;
                        txtDAHomeRWSorEditor.Text = frm._RW;
                        txtDAHomeZipCodeSorEditor.Text = frm._ZipCode;
                        txtDAHomeKelurahanSorEditor.Text = frm._Kel;
                        txtDAHomeKecamatanSorEditor.Text = frm._Kec;
                        txtDAHomeCitySorEditor.Text = frm._City;
                        txtDAHomeProvinsiSorEditor.Text = frm._Prov;
                    }
                }
                else if (rbBAOfficeSorEditor.Checked == true)
                {
                    frm._SubFlag = "OFFICE";
                    frm._Title = "EDIT CUSTOMER OFFICE ADDRESS";
                    frm._Company = txtBAOfficeAddress1SorEditor.Text;
                    frm._Address1 = txtBAOfficeAddress2SorEditor.Text;
                    frm._Address2 = txtBAOfficeAddress3SorEditor.Text;
                    frm._Address3 = txtBAOfficeAddress4SorEditor.Text;
                    frm._RT = txtBAOfficeRTSorEditor.Text;
                    frm._RW = txtBAOfficeRWSorEditor.Text;
                    frm._ZipCode = txtBAOfficeZipCodeSorEditor.Text;
                    frm._Kec = txtBAOfficeKecamatanSorEditor.Text;
                    frm._City = txtBAOfficeCitySorEditor.Text;
                    frm._Prov = txtBAOfficeProvinsiSorEditor.Text;

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txtCustNameSorEditor.Text = frm._CustName;

                        //UPDATE BILLING ADDRESS
                        txtBAOfficeAddress1SorEditor.Text = frm._Company;
                        txtBAOfficeAddress2SorEditor.Text = frm._Address1;
                        txtBAOfficeAddress3SorEditor.Text = frm._Address2;
                        txtBAOfficeAddress4SorEditor.Text = frm._Address3;
                        //txtBAOfficeRTSorEditor.Text = frm._RT;
                        //txtBAOfficeRWSorEditor.Text = frm._RW;
                        txtBAOfficeZipCodeSorEditor.Text = frm._ZipCode;
                        txtBAOfficeKecamatanSorEditor.Text = frm._Kec;
                        txtBAOfficeCitySorEditor.Text = frm._City;
                        txtBAOfficeProvinsiSorEditor.Text = frm._Prov;

                        //UPDATE DELIVERY ADDRESS
                        txtDAOfficeAddress1SorEditor.Text = frm._Company;
                        txtDAOfficeAddress2SorEditor.Text = frm._Address1;
                        txtDAOfficeAddress3SorEditor.Text = frm._Address2;
                        txtDAOfficeAddress4SorEditor.Text = frm._Address3;
                        //txtDAOfficeRTSorEditor.Text = frm._RT;
                        //txtDAOfficeRWSorEditor.Text = frm._RW
                        txtDAOfficeZipCodeSorEditor.Text = frm._ZipCode;
                        txtDAOfficeKecamatanSorEditor.Text = frm._Kec;
                        txtDAOfficeCitySorEditor.Text = frm._City;
                        txtDAOfficeProvinsiSorEditor.Text = frm._Prov;
                    }
                }
                else if (rbBAOtherSorEditor.Checked == true)
                {
                    frm._SubFlag = "OTHER";
                    frm._Title = "EDIT CUSTOMER OTHER ADDRESS";
                    frm._Address1 = txtBAOtherAddress1SorEditor.Text;
                    frm._Address2 = txtBAOtherAddress2SorEditor.Text;
                    frm._Address3 = txtBAOtherAddress3SorEditor.Text;
                    frm._RT = txtBAOtherRTSorEditor.Text;
                    frm._RW = txtBAOtherRWSorEditor.Text;
                    frm._ZipCode = txtBAOtherZipCodeSorEditor.Text;
                    frm._Kel = txtBAOtherKelurahanSorEditor.Text;
                    frm._Kec = txtBAOtherKecamatanSorEditor.Text;
                    frm._City = txtBAOtherCitySorEditor.Text;
                    frm._Prov = txtBAOtherProvinsiSorEditor.Text;

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txtCustNameSorEditor.Text = frm._CustName;

                        //UPDATE BILLING ADDRESS
                        txtBAOtherAddress1SorEditor.Text = frm._Address1;
                        txtBAOtherAddress2SorEditor.Text = frm._Address2;
                        txtBAOtherAddress3SorEditor.Text = frm._Address3;
                        txtBAOtherRTSorEditor.Text = frm._RT;
                        txtBAOtherRWSorEditor.Text = frm._RW;
                        txtBAOtherZipCodeSorEditor.Text = frm._ZipCode;
                        txtBAOtherKelurahanSorEditor.Text = frm._Kel;
                        txtBAOtherKecamatanSorEditor.Text = frm._Kec;
                        txtBAOtherCitySorEditor.Text = frm._City;
                        txtBAOtherProvinsiSorEditor.Text = frm._Prov;

                        //2 = PROCESS WITH ADD TYPE D SUCESS
                        if (frm._AddTypeD == "2")
                        {
                            //UPDATE DELIVERY ADDRESS
                            txtDAOtherAddress1SorEditor.Text = frm._Address1;
                            txtDAOtherAddress2SorEditor.Text = frm._Address2;
                            txtDAOtherAddress3SorEditor.Text = frm._Address3;
                            txtDAOtherRTSorEditor.Text = frm._RT;
                            txtDAOtherRWSorEditor.Text = frm._RW;
                            txtDAOtherZipCodeSorEditor.Text = frm._ZipCode;
                            txtDAOtherKelurahanSorEditor.Text = frm._Kel;
                            txtDAOtherKecamatanSorEditor.Text = frm._Kec;
                            txtDAOtherCitySorEditor.Text = frm._City;
                            txtDAOtherProvinsiSorEditor.Text = frm._Prov;
                        }
                    }
                }
            }
        }

        private void btnDAEditSorEditor_Click(object sender, EventArgs e)
        {
            SO_DialogEditCustomerAddress frm = new SO_DialogEditCustomerAddress();

            frm._Flag = "DELIVERY";
            frm._CustID = txtCustIDSorEditor.Text;
            frm._CustName = txtCustNameSorEditor.Text;

            if (rbDAHomeSorEditor.Checked == true)
            {
                frm._SubFlag = "HOME";
                frm._Title = "EDIT CUSTOMER HOME ADDRESS";
                frm._Address1 = txtDAHomeAddress1SorEditor.Text;
                frm._Address2 = txtDAHomeAddress2SorEditor.Text;
                frm._Address3 = txtDAHomeAddress3SorEditor.Text;
                frm._RT = txtDAHomeRTSorEditor.Text;
                frm._RW = txtDAHomeRWSorEditor.Text;
                frm._ZipCode = txtDAHomeZipCodeSorEditor.Text;
                frm._Kel = txtDAHomeKelurahanSorEditor.Text;
                frm._Kec = txtDAHomeKecamatanSorEditor.Text;
                frm._City = txtDAHomeCitySorEditor.Text;
                frm._Prov = txtDAHomeProvinsiSorEditor.Text;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtCustNameSorEditor.Text = frm._CustName;

                    //UPDATE DELIVERY ADDRESS
                    txtDAHomeAddress1SorEditor.Text = frm._Address1;
                    txtDAHomeAddress2SorEditor.Text = frm._Address2;
                    txtDAHomeAddress3SorEditor.Text = frm._Address3;
                    txtDAHomeRTSorEditor.Text = frm._RT;
                    txtDAHomeRWSorEditor.Text = frm._RW;
                    txtDAHomeZipCodeSorEditor.Text = frm._ZipCode;
                    txtDAHomeKelurahanSorEditor.Text = frm._Kel;
                    txtDAHomeKecamatanSorEditor.Text = frm._Kec;
                    txtDAHomeCitySorEditor.Text = frm._City;
                    txtDAHomeProvinsiSorEditor.Text = frm._Prov;
                }
            }
            else if (rbDAOfficeSorEditor.Checked == true)
            {
                frm._SubFlag = "OFFICE";
                frm._Title = "EDIT CUSTOMER OFFICE ADDRESS";
                frm._Company = txtDAOfficeAddress1SorEditor.Text;
                frm._Address1 = txtDAOfficeAddress2SorEditor.Text;
                frm._Address2 = txtDAOfficeAddress3SorEditor.Text;
                frm._Address3 = txtDAOfficeAddress4SorEditor.Text;
                frm._RT = txtDAOfficeRTSorEditor.Text;
                frm._RW = txtDAOfficeRWSorEditor.Text;
                frm._ZipCode = txtDAOfficeZipCodeSorEditor.Text;
                frm._Kec = txtDAOfficeKecamatanSorEditor.Text;
                frm._City = txtDAOfficeCitySorEditor.Text;
                frm._Prov = txtDAOfficeProvinsiSorEditor.Text;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtCustNameSorEditor.Text = frm._CustName;

                    //UPDATE BILLING ADDRESS
                    txtBAOfficeAddress1SorEditor.Text = frm._Company;
                    txtBAOfficeAddress2SorEditor.Text = frm._Address1;
                    txtBAOfficeAddress3SorEditor.Text = frm._Address2;
                    txtBAOfficeAddress4SorEditor.Text = frm._Address3;

                    //UPDATE DELIVERY ADDRESS
                    txtDAOfficeAddress1SorEditor.Text = frm._Company;
                    txtDAOfficeAddress2SorEditor.Text = frm._Address1;
                    txtDAOfficeAddress3SorEditor.Text = frm._Address2;
                    txtDAOfficeAddress4SorEditor.Text = frm._Address3;
                    txtDAOfficeZipCodeSorEditor.Text = frm._ZipCode;
                    txtDAOfficeCitySorEditor.Text = frm._City;
                    txtDAOfficeProvinsiSorEditor.Text = frm._Prov;
                }
            }
            else if (rbDAOtherSorEditor.Checked == true)
            {
                frm._SubFlag = "OTHER";
                frm._Title = "EDIT CUSTOMER OTHER ADDRESS";
                frm._Address1 = txtDAOtherAddress1SorEditor.Text;
                frm._Address2 = txtDAOtherAddress2SorEditor.Text;
                frm._Address3 = txtDAOtherAddress3SorEditor.Text;
                frm._RT = txtDAOtherRTSorEditor.Text;
                frm._RW = txtDAOtherRWSorEditor.Text;
                frm._ZipCode = txtDAOtherZipCodeSorEditor.Text;
                frm._Kel = txtDAOtherKelurahanSorEditor.Text;
                frm._Kec = txtDAOtherKecamatanSorEditor.Text;
                frm._City = txtDAOtherCitySorEditor.Text;
                frm._Prov = txtDAOtherProvinsiSorEditor.Text;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtCustNameSorEditor.Text = frm._CustName;

                    //UPDATE DELIVERY ADDRESS
                    txtDAOtherAddress1SorEditor.Text = frm._Address1;
                    txtDAOtherAddress2SorEditor.Text = frm._Address2;
                    txtDAOtherAddress3SorEditor.Text = frm._Address3;
                    txtDAOtherRTSorEditor.Text = frm._RT;
                    txtDAOtherRWSorEditor.Text = frm._RW;
                    txtDAOtherZipCodeSorEditor.Text = frm._ZipCode;
                    txtDAOtherKelurahanSorEditor.Text = frm._Kel;
                    txtDAOtherKecamatanSorEditor.Text = frm._Kec;
                    txtDAOtherCitySorEditor.Text = frm._City;
                    txtDAOtherProvinsiSorEditor.Text = frm._Prov;
                }
            }
        }

        private bool ValidateKPSor()
        {
            bool _isPassed = false;

            if(txtKPNoSorEditor.Text.Trim().Length > 0)
            {
                DataTable dt = SOVerificationProcessAL.ValidateKPNoSOR(txtKPNoSorEditor.Text.Trim());
                if(dt.Rows.Count > 0)
                {
                    if(dt.Rows[0]["svs_so_kp_num"].ToString() != string.Empty)
                    {
                        if (dt.Rows[0]["svs_verification_status"].ToString() == "I")
                        {
                            _isPassed = true;
                        }
                        else
                        {
                            clsAlert.PushAlert("The status of verification must be In Processed!", clsAlert.Type.Error);
                            _isPassed = false;
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("The KP No is not found or hasn't Assign!", clsAlert.Type.Error);
                        _isPassed = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("The KP Number not found!", clsAlert.Type.Error);
                    _isPassed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("The KP No required!", clsAlert.Type.Error);
                _isPassed = false;
            }

            return _isPassed;
        }

        private bool ValidateSaveSor()
        {
            bool _isPassed = false;

            if(dtDueDateSorEditor.Value.Date > dtDeliveryDateSorEditor.Value.Date)
            {
                if (dtDueDateSorEditor.Value < dtDeliveryDateSorEditor.Value.AddMonths(2))
                {
                    if (txtRemarksSorEditor.Text.Trim().Length > 0)
                    {
                        _isPassed = true;
                    }
                    else
                    {
                        if (clsDialog.ShowDialog("The memo still blank, do you want to fill it ?") == DialogResult.No)
                        {
                            _isPassed = true;
                        }
                        else
                        {
                            btnListSorEditor_Click(null, null);
                            _isPassed = false;
                        }
                    }
                }
                else
                {
                    clsAlert.PushAlert("Due date month can't be over than 2 months from delivery date!", clsAlert.Type.Error);
                    _isPassed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("Due date can't be smaller than delivery date!", clsAlert.Type.Error);
                _isPassed = false;
            }


            if(_isPassed == true)
            {
                if (txtKPNoSorEditor.Text.Trim().Length != 0 && txtEntitySorEditor.Text.Trim().Length != 0)
                {
                    if (cboCollectorSorEditor.Text.Trim().Length > 0)
                    {
                        if(SorEventType == "ADD")
                        {
                            //FOR NEW
                            if(ValidateKPSor() == true)
                            {
                                _isPassed = true;
                            }
                            else
                            {
                                _isPassed = false;
                            }
                        }
                        else
                        {
                            //FOR EDIT
                            _isPassed = true;
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("The Collector ID required!", clsAlert.Type.Error);
                        _isPassed = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("You have to enter the KP Number!", clsAlert.Type.Error);
                    _isPassed = false;
                }
            }

            return _isPassed;
        }

        private void btnListSorEditor_Click(object sender, EventArgs e)
        {
            pnlMemo.Width = 1047;
            pnlMemo.Height = 400;
            pnlMemo.Left = 20;
            pnlMemo.Top = 202;

            pnlMemo.Visible = true;
            txtRemarksSorEditor.Focus();
        }

        private void btnReleaseSorEditor_Click(object sender, EventArgs e)
        {
            if(ValidateSaveSor() == true)
            {
                string VBilAddr = string.Empty;
                if (rbBAHomeSorEditor.Checked == true)
                {
                    VBilAddr = "H";
                }
                else if (rbBAOfficeSorEditor.Checked == true)
                {
                    VBilAddr = "O";
                }
                else if (rbBAOtherSorEditor.Checked == true)
                {
                    VBilAddr = "L";
                }

                string VDelAddr = string.Empty;
                if (rbDAHomeSorEditor.Checked == true)
                {
                    VDelAddr = "H";
                }
                else if (rbDAOfficeSorEditor.Checked == true)
                {
                    VDelAddr = "O";
                }
                else if (rbDAOtherSorEditor.Checked == true)
                {
                    VDelAddr = "L";
                }

                string VStat = string.Empty;
                if (rbCDSCompleteSorEditor.Checked == true)
                {
                    VStat = "C";
                }
                else if (rbCDSInCompleteSorEditor.Checked == true)
                {
                    VStat = "U";
                }

                string VStatRelease = string.Empty;
                if (rbCVSOKSorEditor.Checked == true)
                {
                    VStatRelease = "OKE";
                }
                else if (rbCVSDoubtSorEditor.Checked == true)
                {
                    VStatRelease = "DOUBT";
                }

                string VFlagEdit = string.Empty;
                if (SorEventType == "ADD")
                {
                    VFlagEdit = "A";
                }
                else if (SorEventType == "EDIT")
                {
                    VFlagEdit = "E";
                }

                SOVerificationProcessBL = new SOVerificationProcessBL()
                {
                    verificator_id = txtVerificatorSorEditor.Tag.ToString(),
                    so_kp_no = txtKPNoSorEditor.Text.Trim(),
                    billing_address_code = VBilAddr,
                    delivery_address_code = VDelAddr,
                    dateofbilling = dtDueDateSorEditor.Value,
                    customer_data_status = VStat,
                    dateofvisit = dtDateOfVisitSorEditor.Value.Day.ToString(),//pastikan 2 angka
                    status_release = VStatRelease,
                    remark = txtRemarksSorEditor.Text.Trim(),//cek originalnya
                    customer_id = txtCustIDSorEditor.Text.Trim()
                };

                if (_ExistForm == "NEW")
                {
                    if (clsDialog.ShowDialog("Save New Sales Order Release ?") == DialogResult.Yes)
                    {
                        bool _isSucess = SOVerificationProcessAL.PostSOR(SOVerificationProcessBL, dtDeliveryDateSorEditor.Value, cboCollectorSorEditor.Text.Trim(), VFlagEdit, clsLogin.USERID, txtTelpRumahSorEditor.Text.Trim(), txtTelpHPSorEditor.Text.Trim(), txtTelpKantorSorEditor.Text.Trim());
                        if (_isSucess == true)
                        {
                            clearSorEditor(true);
                            txtKPNoSor.Focus();
                        }
                    }
                }
                else
                {
                    if (clsDialog.ShowDialog("Update Sales Order Release " + txtKPNoSorEditor.Text.Trim() + " ?") == DialogResult.Yes)
                    {
                        bool _isSucess = SOVerificationProcessAL.PutSOR(SOVerificationProcessBL, dtDeliveryDateSorEditor.Value, cboCollectorSorEditor.Text.Trim(), VFlagEdit, clsLogin.USERID, txtTelpRumahSorEditor.Text.Trim(), txtTelpHPSorEditor.Text.Trim(), txtTelpKantorSorEditor.Text.Trim());
                        if (_isSucess == true)
                        {
                            clearSorEditor(true);
                            navView_Click(null, null);
                        }
                    }
                }
            }
        }

        private void btnHideSorEditor_Click(object sender, EventArgs e)
        {
            pnlMemo.Visible = false;

            pnlMemo.Width = 30;
            pnlMemo.Height = 49;

            pnlMemo.Left = 933;
            pnlMemo.Top = 592;
        }

        private void dtDeliveryDateSorEditor_ValueChanged(object sender, EventArgs e)
        {
            dtDueDateSorEditor.Value = dtDeliveryDateSorEditor.Value.AddMonths(1);
        }

        private void grdVS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (grdVS.Columns[e.ColumnIndex].Name.Contains("grdSelect_vs"))
                {
                    int i;
                    i = grdVS.CurrentCell.RowIndex;

                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grdVS["grdSelect_vs", i];
                    if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                    {
                        //ADD TO ARRAY VARIABLE
                        _SelectedKPNoArray.Add(grdVS["svs_so_kp_num_vs", i].Value.ToString().Trim());
                    }
                    else
                    {
                        //REMOVE TO ARRAY VARIABLE
                        _SelectedKPNoArray.Remove(grdVS["svs_so_kp_num_vs", i].Value.ToString().Trim());
                    }
                }
            }
        }

        private void txtKPNoSorEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool _isValid = ValidateKPNoSorEditor();
                if (_isValid == true)
                {
                    DisplayKPNoDetailSorEditor();
                }
                else
                {
                    clearSorEditor(true);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            switch (_ExistMenu)
            {
                case "tabSOR":
                    {                   
                        if (dtPrintSOR.Rows.Count > 0)
                        {
                            int _Count = 1;
                            for (int i = 0; i < dtPrintSOR.Rows.Count; i++)
                            {
                                if(_RowPrintSOR == i)
                                {
                                    //COORDINATES SATUAN MM ON C# INCHI IN VB6

                                    //NO KP
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["svs_so_kp_num"].ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(102, 67));

                                    // Printer.CurrentX = 4
                                    // Printer.CurrentY = 2.7
                                    // Printer.Print SqlData(ConnDS, 1)

                                    //NAMA BA
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["rm_name"].ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(102, 84));

                                    // Printer.CurrentX = 4
                                    // Printer.CurrentY = 3.3
                                    // Printer.Print SqlData(ConnDS, 2)

                                    //NAMA CUSTOMER
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["scm_customer_name"].ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(102, 97));

                                    // Printer.CurrentX = 4
                                    // Printer.CurrentY = 3.8
                                    // Printer.Print SqlData(ConnDS, 3)

                                    //ALAMAT RUMAH 1
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["scm_address1"].ToString() + " " + dtPrintSOR.Rows[i]["scm_address2"].ToString(), new Font("Calibri", 8, FontStyle.Regular), Brushes.Black, new Point(3, 140));

                                    // Printer.FontSize = 8
                                    // Printer.CurrentX = 0.1
                                    // Printer.CurrentY = 5.5
                                    // Printer.Print SqlData(ConnDS, 4) +" " + SqlData(ConnDS, 5)

                                    //ALAMAT KANTOR 1
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["scm_employer_address1"].ToString() + " " + dtPrintSOR.Rows[i]["scm_employer_address2"].ToString(), new Font("Calibri", 8, FontStyle.Regular), Brushes.Black, new Point(267, 140));

                                    // Printer.FontSize = 8
                                    // Printer.CurrentX = 10.5
                                    // Printer.CurrentY = 5.5
                                    // Printer.Print SqlData(ConnDS, 9) +" " + SqlData(ConnDS, 10)

                                    //ALAMAT RUMAH 2
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["scm_address3"].ToString(), new Font("Calibri", 8, FontStyle.Regular), Brushes.Black, new Point(3, 165));

                                    // Printer.FontSize = 8
                                    // Printer.CurrentX = 0.1
                                    // Printer.CurrentY = 6.5
                                    // Printer.Print SqlData(ConnDS, 6)

                                    //ALAMAT KANTOR 2
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["scm_employer_address3"].ToString(), new Font("Calibri", 8, FontStyle.Regular), Brushes.Black, new Point(267, 165));

                                    // Printer.FontSize = 8
                                    // Printer.CurrentX = 10.5
                                    // Printer.CurrentY = 6.5
                                    // Printer.Print SqlData(ConnDS, 11)

                                    //TELP HOME
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["scm_home_phone_num"].ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(36, 180));

                                    // Printer.FontSize = 10
                                    // Printer.CurrentX = 1.4
                                    // Printer.CurrentY = 7.1
                                    // Printer.Print SqlData(ConnDS, 7)

                                    //TELP HP
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["scm_mobile_phone_num"].ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(160, 180));

                                    // Printer.FontSize = 10
                                    // Printer.CurrentX = 6.3
                                    // Printer.CurrentY = 7.1
                                    // Printer.Print SqlData(ConnDS, 8)

                                    //TELP KANTOR
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["scm_employer_phone"].ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(300, 180));

                                    // Printer.FontSize = 10
                                    // Printer.CurrentX = 11.8
                                    // Printer.CurrentY = 7.1
                                    // Printer.Print SqlData(ConnDS, 12)

                                    //SERI BUKU
                                    e.Graphics.DrawString(dtPrintSOR.Rows[i]["skh_desc"].ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(89, 361));

                                    // Printer.FontSize = 10
                                    // Printer.CurrentX = 3.5
                                    // Printer.CurrentY = 14.2
                                    // Printer.Print SqlData(ConnDS, 18)

                                    if (dtPrintSOR.Rows[i]["skh_sales_type"].ToString() == "CR")
                                    {
                                        //CREDIT
                                        e.Graphics.DrawString(dtPrintSOR.Rows[i]["skh_no_of_instalments"].ToString(), new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(104, 386));

                                        // Printer.FontSize = 11
                                        // Printer.CurrentX = 4.1
                                        // Printer.CurrentY = 15.2
                                        // Printer.Print CInt(val(SqlData(ConnDS, 17)))

                                        //UANG MUKA
                                        e.Graphics.DrawString(dtPrintSOR.Rows[i]["dp_cod_amount"].ToString(), new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(102, 411));

                                        // Printer.CurrentX = 4
                                        // Printer.CurrentY = 16.2
                                        // Printer.Print SqlData(ConnDS, 13)
                                    }
                                    else
                                    {
                                        //CASH
                                        e.Graphics.DrawString(dtPrintSOR.Rows[i]["skh_total_inv_amount"].ToString(), new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(391, 399));

                                        // Printer.CurrentX = 15.4
                                        // Printer.CurrentY = 15.7
                                        // Printer.Print CDbl(val(SqlData(ConnDS, 16)))

                                        //UANG MUKA
                                        e.Graphics.DrawString(dtPrintSOR.Rows[i]["dp_cod_amount"].ToString(), new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(391, 411));

                                        // Printer.CurrentX = 15.4
                                        // Printer.CurrentY = 16.2
                                        // Printer.Print CDbl(val(SqlData(ConnDS, 13)))

                                        //SISA
                                        e.Graphics.DrawString(Convert.ToString(Convert.ToInt64(dtPrintSOR.Rows[i]["skh_total_inv_amount"]) - Convert.ToInt64(dtPrintSOR.Rows[i]["dp_cod_amount"])), new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(391, 424));

                                        // Printer.CurrentX = 15.4
                                        // Printer.CurrentY = 16.7
                                        // Printer.Print val(SqlData(ConnDS, 16)) -val(SqlData(ConnDS, 13))
                                    }

                                    _Count++;

                                    if (_Count <= dtPrintSOR.Rows.Count)
                                    {
                                        _RowPrintSOR++;
                                        e.HasMorePages = true;
                                        return;
                                    }
                                }

                            }
                        }

                        break;
                    }
            }
        }

        private void grdVSA_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SettingVariable(false);
                DrawDatatableKp();
            }
        }

        private void SO_VerificationProcessUI_KeyDown(object sender, KeyEventArgs e)
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
                    case clsEventButton.EnumAction.SEARCH:
                        {
                            if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabVSA"])
                            {
                                btnSearchVSA_Click(null, null);
                            }
                            else if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabVS"])
                            {
                                btnSearchVS_Click(null, null);
                            }
                            else if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabSOR"])
                            {
                                btnSearchSor_Click(null, null);
                            }
                            break;
                        }
                    case clsEventButton.EnumAction.BROWSE:
                        {
                            if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabVS"])
                            {
                                btnBrowseVs_Click(null, null);
                            }
                            break;
                        }
                    case clsEventButton.EnumAction.DISPLAY:
                        {
                            if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabVS"])
                            {
                                btnEditMemo_Click(null, null);
                            }
                            else if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabSOR"])
                            {
                                if(pnlSalesOrderReleaseEditor.Visible == true)
                                {
                                    btnListSorEditor_Click(null, null);
                                }
                                else
                                {
                                    btnDisplayMemoSor_Click(null, null);
                                }
                                
                            }
                            break;
                        }
                    case clsEventButton.EnumAction.SAVE:
                        {
                            if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabVSA"])
                            {
                                btnSave_Click(null, null);
                            }
                            break;
                        }

                    case clsEventButton.EnumAction.CANCEL:
                        {
                            if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabVSA"])
                            {
                                btnCancel_Click(null, null);
                            }
                            else if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabVS"])
                            {
                                if(_ExistForm == "NEW" || _ExistForm == "EDIT")
                                {
                                    btnCancelVSEditor_Click(null, null);
                                }
                                else if (_ExistForm == "DELETE")
                                {
                                    btnCancelDelete_Click(null, null);
                                }

                            }
                            else if (tabVerificatationProcess.SelectedTab == tabVerificatationProcess.TabPages["tabSOR"])
                            {
                                btnCancelSorEditor_Click(null, null);
                            }
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void cboKPNoVSEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboKPNoVSEditor_SelectedIndexChanged(null, null);
            }
        }

        private void cboKPNoVSEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loadVSDetailKP == true)
            {
                DataTable dt = SOVerificationProcessAL.GetSOKPNumberDetailVsEditor(cboKPNoVSEditor.Text, cboVerificatorIDVSEditor.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    dtKPDateVSEditor.Value = Convert.ToDateTime(dt.Rows[0]["skh_so_kp_date"]);
                    txtKPValueVSEditor.Text = string.Format("{0:#,##0.00}", double.Parse(dt.Rows[0]["skh_total_inv_amount"].ToString()));
                    txtRepIDVSEditor.Text = dt.Rows[0]["skh_rep_id"].ToString();
                    txtCustIDVSEditor.Text = dt.Rows[0]["skh_customer_id"].ToString();
                    txtCustNameVSEditor.Text = dt.Rows[0]["skh_customer_name"].ToString();
                    txtDivisionVSEditor.Tag = dt.Rows[0]["skh_division_id"].ToString();
                    txtEntityVSEditor.Tag = dt.Rows[0]["svm_entity_id"].ToString();
                    txtBranchVSEditor.Tag = dt.Rows[0]["svm_branch_id"].ToString();
                    txtVisaAutoVSEditor.Text = dt.Rows[0]["scm_visa_auto"].ToString();
                    if (dt.Rows[0]["skh_kpo_notes"] != null && dt.Rows[0]["skh_kpo_notes"].ToString() != string.Empty)
                    {
                        txtKPOnlineNoteVSEditor.Text = "KP ONLINE NOTES" + Environment.NewLine +
                                                        "----------------------" + Environment.NewLine +
                                                        dt.Rows[0]["skh_kpo_notes"].ToString().ToUpper();
                    }

                }
                else
                {
                    dtKPDateVSEditor.Value = Convert.ToDateTime(DateTime.Now.Date);
                    txtKPValueVSEditor.Text = string.Empty;
                    txtRepIDVSEditor.Text = string.Empty;
                    txtCustIDVSEditor.Text = string.Empty;
                    txtCustNameVSEditor.Text = string.Empty;
                    txtVisaAutoVSEditor.Text = string.Empty;
                    txtKPOnlineNoteVSEditor.Text = "KP ONLINE NOTES" + Environment.NewLine +
                                                        "----------------------" + Environment.NewLine;
                }

                if (VsEventType == "ADD")
                {
                    //SET QUALIFICATION VALUE AND TOTAL VALUE IN QUALIFICATION HEADER
                    GetQualifierValue(cboVerificatorIDVSEditor.SelectedValue.ToString(), cboKPNoVSEditor.Text.Trim());
                }

                //SET VISITING ACTIVITY
                GetQualificationActivity(cboVerificatorIDVSEditor.SelectedValue.ToString(), cboKPNoVSEditor.Text.Trim());
                //SET MEMO AND NOTES
                GetMemoAndNoteVisitingActivity(cboVerificatorIDVSEditor.SelectedValue.ToString(), cboKPNoVSEditor.Text.Trim());

                tabVSEditor.SelectedIndex = 0;
            }
        }

        private void cboVerificatorIDVSEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _loadVSDetailKP = false;
            loadVSVerificatorIDDetail(_ExistForm);
            _loadVSDetailKP = true;
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXPORT);
        }

        private void btnBrowseVs_Click(object sender, EventArgs e)
        {
            if(txtCustCodeVs.Text.Trim().Length >= 3)
            {
                clsPopUpCustomer._ParamCust = txtCustCodeVs.Text.Trim();
                if (clsPopUpCustomer.ShowDialog() == DialogResult.OK)
                {
                    txtCustCodeVs.Text = clsPopUpCustomer._CustomerID.ToString();
                    txtCustNameVs.Text = clsPopUpCustomer._CustomerName.ToString();
                }
            }
            else
            {
                clsAlert.PushAlert("Input Customer Code / Name Min. 3 Character!", clsAlert.Type.Error);
                txtCustCodeVs.Focus();
            }
        }

        private void chbKPDate_CheckedChanged(object sender, EventArgs e)
        {
            if(chbKPDateVs.Checked == true)
            {
                dtFromKPDateVs.Enabled = false;
                dtUntilKPDateVs.Enabled = false;
            }
            else
            {
                dtFromKPDateVs.Enabled = true;
                dtUntilKPDateVs.Enabled = true;
            }
        }

        private void chbAssignDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAssignDateVs.Checked == true)
            {
                dtAssignDateVs.Enabled = false;
            }
            else
            {
                dtAssignDateVs.Enabled = true;
            }
        }

        private bool checkValidationEdit()
        {
            bool _isPassed = false;

            if (dtAssignDate.Value.ToString("dd MMM yyyy") != getAssignDate().ToString("dd MMM yyyy") || cboVerificatorID.SelectedValue.ToString() != getVerificatorID(_ExistMenu).ToString())
            {
                _isPassed = true;
            }
            else
            {
                clsAlert.PushAlert("Assign Date or Verificator ID Must be Different!", clsAlert.Type.Error);
                cboVerificatorID.Focus();
                _isPassed = false;
            }

            return _isPassed;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(checkValidation() == true && ValidateKPNo() == true )
            {
                SOVerificationProcessBL = new SOVerificationProcessBL()
                {
                    verificator_id = cboVerificatorID.SelectedValue.ToString(),
                    so_kp_no = txtKPNo.Text.Trim(),
                    assignment_date = dtAssignDate.Value
                };

                if (_ExistForm == "NEW")
                {
                    if (clsDialog.ShowDialog("Save New Verification Schedule Assignment ?") == DialogResult.Yes)
                    {
                        bool _isSucess = SOVerificationProcessAL.Post(SOVerificationProcessBL);
                        if (_isSucess == true)
                        {
                            ClearEditorVsa();
                            txtKPNo.Focus();
                        }
                    }
                }
                else
                {
                    if(checkValidationEdit() == true)
                    {
                        if (clsDialog.ShowDialog("Update Verification Schedule Assignment " + txtKPNo.Text.Trim() + " ?") == DialogResult.Yes)
                        {
                            string _VerificatorIDOld = getVerificatorID(_ExistMenu);
                            bool _isSucess = SOVerificationProcessAL.Put(_VerificatorIDOld, SOVerificationProcessBL);
                            if (_isSucess == true)
                            {
                                btnSearchVSA_Click(null, null);
                                navView_Click(null, null);
                                ClearEditorVsa();
                            }
                        }
                    }     
                }
            }
        }

        private bool ValidateKPNo()
        {
            bool _isValid = false;

            DataTable dt = SOVerificationProcessAL.ValidateSOKPNumberVSA(txtKPNo.Text.Trim());

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["skh_so_kp_number"].ToString() != string.Empty)
                {
                    if (dt.Rows[0]["skh_entity_id"].ToString() == txtEntity.Tag.ToString())
                    {
                        if (cboVerificatorID.SelectedValue.ToString().Trim() == "VALDO")
                        {
                            if (dt.Rows[0]["skh_status_of_so_kp"].ToString() == "R")
                            {
                                if (_ExistForm == "NEW")
                                {
                                    if (dt.Rows[0]["skh_status_of_verification"].ToString() == "U" && dt.Rows[0]["skh_status_of_verification"].ToString() == "C")
                                    {
                                        clsAlert.PushAlert("Status of Verification have Assigned!", clsAlert.Type.Error);
                                        txtKPNo.Focus();
                                        _isValid = false;
                                    }
                                    else
                                    {
                                        _isValid = true;
                                    }
                                }
                                else
                                {
                                    _isValid = true;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Status of KP must be Relesead!", clsAlert.Type.Error);
                                txtKPNo.Focus();
                                _isValid = false;
                            }
                        }
                        else
                        {
                            if (dt.Rows[0]["skh_branch_id"].ToString() == txtBranch.Tag.ToString())
                            {
                                if (dt.Rows[0]["skh_status_of_so_kp"].ToString() == "R")
                                {
                                    if (_ExistForm == "NEW")
                                    {
                                        if (dt.Rows[0]["skh_status_of_verification"].ToString() == "U" && dt.Rows[0]["skh_status_of_verification"].ToString() == "C")
                                        {
                                            clsAlert.PushAlert("Status of Verification have Assigned!", clsAlert.Type.Error);
                                            txtKPNo.Focus();
                                            _isValid = false;
                                        }
                                        else
                                        {
                                            _isValid = true;
                                        }
                                    }
                                    else
                                    {
                                        _isValid = true;
                                    }
                                }
                                else
                                {
                                    clsAlert.PushAlert("Status of KP must be Relesead!", clsAlert.Type.Error);
                                    txtKPNo.Focus();
                                    _isValid = false;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Branch KP No's different with Branch Verificator!", clsAlert.Type.Error);
                                txtKPNo.Focus();
                                _isValid = false;
                            }
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Entity KP No's different with Entity Verificator!", clsAlert.Type.Error);
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
            else
            {
                clsAlert.PushAlert("KP Number not found!", clsAlert.Type.Error);
                txtKPNo.Focus();
                _isValid = false;
            }

            return _isValid;
        }

        private void DisplayKPNoDetail(string _DataType)
        {
            DataTable dt;
            string _KPNo = string.Empty;
            if (_DataType == "NEW")
            {
                 dt = SOVerificationProcessAL.GetSOKPNumberDetailVSA(_DataType, txtKPNo.Text.Trim(), txtEntity.Tag.ToString(), cboVerificatorID.SelectedValue.ToString(), txtBranch.Tag.ToString());
            }
            else
            {
                _KPNo = getKPNo(_ExistMenu);
                dt = SOVerificationProcessAL.GetSOKPNumberDetailVSA(_DataType, _KPNo, txtEntity.Tag.ToString(), cboVerificatorID.SelectedValue.ToString(), txtBranch.Tag.ToString());
            }

            if(dt.Rows.Count > 0)
            {
                if(_DataType != "NEW")
                {
                    txtKPNo.Text = getKPNo(_ExistMenu);
                    txtKPNo.ReadOnly = true;
                }

                dtAssignDate.Value = Convert.ToDateTime(getAssignDate(_ExistMenu));
                dtKPDate.Value = Convert.ToDateTime(dt.Rows[0]["skh_so_kp_date"]);
                txtTypeSales.Text = dt.Rows[0]["skh_sales_type"].ToString();
                txtTotalItem.Text = dt.Rows[0]["skh_total_item_set_qty"].ToString();
                txtTotalNet.Text = dt.Rows[0]["skh_total_inv_amount"].ToString();
                txtRepID.Text = dt.Rows[0]["skh_rep_id"].ToString();
                txtCustID.Text = dt.Rows[0]["skh_customer_id"].ToString();
                txtCustName.Text = dt.Rows[0]["skh_customer_name"].ToString();
                txtAddress1.Text = dt.Rows[0]["skh_customer_address1"].ToString();
                txtAddress2.Text = dt.Rows[0]["skh_customer_address2"].ToString();
                txtAddress3.Text = dt.Rows[0]["skh_customer_address3"].ToString();
                txtRT.Text = dt.Rows[0]["skh_rt"].ToString();
                txtRW.Text = dt.Rows[0]["skh_rw"].ToString();
                txtKeluarhan.Text = dt.Rows[0]["skh_kelurahan"].ToString();
                txtKecamatan.Text = dt.Rows[0]["skh_kecamatan"].ToString();
                txtKota.Text = dt.Rows[0]["skh_city"].ToString();
                txtDivision.Text = dt.Rows[0]["skh_division_id"].ToString();
                txtDesc.Text = dt.Rows[0]["skh_desc"].ToString();
                txtLamaKredit.Text = dt.Rows[0]["skh_no_of_instalments"].ToString();
                txtTotalSU.Text = dt.Rows[0]["skh_total_su"].ToString();
                txtRepName.Text = dt.Rows[0]["rm_name"].ToString();
                txtUangMuka.Text = dt.Rows[0]["skh_dp_amount"].ToString();
                txtCOD.Text = dt.Rows[0]["skh_cod_amount"].ToString();
                txtAngsuran.Text =  dt.Rows[0]["skh_instalment_amount_per_month"].ToString();

                if(dt.Rows[0]["scm_customer_group"].ToString() != "CUST")
                {
                    txtCustomerType.Text = "Customer : " + dt.Rows[0]["scm_customer_group"].ToString();
                }
            }
            else
            {
                txtKPNo.Text = _KPNo;

                //clsAlert.PushAlert("KP Number not found!", clsAlert.Type.Error);
                //ClearEditorVsa();
                //txtKPNo.Focus();
            }
        }

        private void btnPrevKp_Click(object sender, EventArgs e)
        {
            _CurrentPageKp--;
            PaginationKp(true);
            DrawDatatableKp();
        }

        private void btnNextKp_Click(object sender, EventArgs e)
        {
            _CurrentPageKp++;
            PaginationKp(true);
            DrawDatatableKp();
        }

        private void btnPrevVsa_Click(object sender, EventArgs e)
        {
            _CurrentPage--;
            Pagination(true);
            DrawDatatableVsa();
            _CurrentPageKp = 1;
            DrawDatatableKp();
        }

        private void btnNextVsa_Click(object sender, EventArgs e)
        {
            _CurrentPage++;
            Pagination(true);
            DrawDatatableVsa();
            DrawDatatableKp();
        }
    }
}
