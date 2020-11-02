using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.businessLogic.SO;
using MADITP2._0.BusinessLogic.SO;
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

namespace MADITP2._0.UserInterface.SO.SOVerificationProcess
{
    public partial class SO_DialogEditCustomerAddress : Form
    {
        clsGlobal Helper;
        GlobalAL GlobalAL;
        clsAlert clsAlert;
        SOVerificatorMasterAL SOVerificatorMasterAL;
        SOVerificationProcessAL SOVerificationProcessAL;
        SOVerificationProcessBL SOVerificationProcessBL;
        SOMasterCustomerBL SOMasterCustomerBL;
        public string _CustID, _CustName, _Company, _Address1, _Address2, _Address3, _RT, _RW, _ZipCode, _Kel, _Kec, _City, _Prov, _AddTypeD;       
        public string _Title, _Flag, _SubFlag;

        public SO_DialogEditCustomerAddress()
        {
            InitializeComponent();
            Helper = new clsGlobal();
            GlobalAL = new GlobalAL(Helper);
            clsAlert = new clsAlert();
            SOVerificatorMasterAL = new SOVerificatorMasterAL(Helper);
            SOVerificationProcessAL = new SOVerificationProcessAL(Helper);
            SOVerificationProcessBL = new SOVerificationProcessBL();
            SOMasterCustomerBL = new SOMasterCustomerBL();
        }

        private void loadKeluarahan()
        {
            cboKelurahan.DataSource = null;
            cboKelurahan.DataSource = SOVerificationProcessAL.GetKelurahanToComboBox(false, txtZipCode.Text.Trim());
            cboKelurahan.ValueMember = "ValueMember";
            cboKelurahan.DisplayMember = "ValueMember";
            cboKelurahan.SelectedIndex = -1;
        }

        private void txtZipCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = SOVerificatorMasterAL.GetZipCodes(txtZipCode.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    txtKecamatan.Text = dt.Rows[0]["kecamatan"].ToString();
                    txtKecamatan.Tag = dt.Rows[0]["area_code"].ToString();
                    txtCity.Text = dt.Rows[0]["cc_city"].ToString();
                    txtProvince.Text = dt.Rows[0]["cc_province"].ToString();

                    loadKeluarahan();
                }
                else
                {
                    clsAlert.PushAlert("Zip Code not found!", clsAlert.Type.Error);
                    txtZipCode.Focus();

                    cboKelurahan.Items.Clear();
                    txtKecamatan.Text = "";
                    txtKecamatan.Tag = "";
                    txtCity.Text = "";
                    txtProvince.Text = "";
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (txtZipCode.Text.Trim().Length >= 3)
            {
                clsPopUpZipCode frm = new clsPopUpZipCode();
                frm._ParamZipCode = txtZipCode.Text.Trim();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtZipCode.Text = frm._ZipCode;
                    loadKeluarahan();
                    cboKelurahan.Text = frm._Kelurahan;
                    txtKecamatan.Text = frm._Kecamatan;
                    txtKecamatan.Tag = frm._AreaCode;
                    txtCity.Text = frm._City;
                    txtProvince.Text = frm._Province;
                }
            }
            else
            {
                clsAlert.PushAlert("Input Zip Code Min. 3 Character!", clsAlert.Type.Error);
                txtZipCode.Focus();
            }
        }

        private void EditBillingAddres()
        {
            if (clsDialog.ShowDialog("Update Customer Address ?") == DialogResult.Yes)
            {
                bool _isSucess = false;
                int _Result = 0;

                if (_SubFlag.ToUpper() == "HOME")
                {
                    SOMasterCustomerBL = new SOMasterCustomerBL()
                    {
                        Customer_Name = txtCustomerName.Text.Trim(),
                        Address1 = txtAddress1.Text.Trim(),
                        Address2 = txtAddress2.Text.Trim(),
                        Address3 = txtAddress3.Text.Trim(),
                        Rt = txtRT.Text.Trim(),
                        Rw = txtRW.Text.Trim(),
                        Kelurahan = cboKelurahan.Text.Trim(),
                        Area_Code = (txtKecamatan.Tag == null) ? "" : txtKecamatan.Tag.ToString().Trim(),
                        Zipcode = txtZipCode.Text.Trim(),
                        Customer_Id = txtCustomerID.Text.Trim(),
                    };

                    _isSucess = SOVerificationProcessAL.UpdateCustomerAddressHome(SOMasterCustomerBL);
                }
                else if (_SubFlag.ToUpper() == "OFFICE")
                {
                    SOMasterCustomerBL = new SOMasterCustomerBL()
                    {
                        Customer_Name = txtCustomerName.Text.Trim(),
                        Address1 = txtAddress1.Text.Trim(),
                        Address2 = txtAddress2.Text.Trim(),
                        Address3 = txtAddress3.Text.Trim(),
                        Zipcode = txtZipCode.Text.Trim(),
                        Employer_City = txtCity.Text.Trim(),
                        Employer_Province = txtProvince.Text.Trim(),
                        Last_Employer_Name = txtCompany.Text.Trim(),
                        Customer_Id = txtCustomerID.Text.Trim(),
                    };

                    _isSucess = SOVerificationProcessAL.UpdateCustomerAddressOffice(SOMasterCustomerBL);
                }
                else if (_SubFlag.ToUpper() == "OTHER")
                {
                    SOMasterCustomerBL = new SOMasterCustomerBL()
                    {
                        Customer_Name = txtCustomerName.Text.Trim(),
                        Address1 = txtAddress1.Text.Trim(),
                        Address2 = txtAddress2.Text.Trim(),
                        Address3 = txtAddress3.Text.Trim(),
                        Rt = txtRT.Text.Trim(),
                        Rw = txtRW.Text.Trim(),
                        Kelurahan = cboKelurahan.Text.Trim(),
                        Area_Code = (txtKecamatan.Tag == null) ? "" : txtKecamatan.Tag.ToString().Trim(),
                        Zipcode = txtZipCode.Text.Trim(),
                        Employer_City = txtCity.Text.Trim(),
                        Employer_Province = txtProvince.Text.Trim(),
                        Customer_Id = txtCustomerID.Text.Trim(),
                    };

                    _Result = SOVerificationProcessAL.UpdateCustomerAddressOther(SOMasterCustomerBL, txtKecamatan.Text.Trim());
                    //PROCESS FAILED
                    if (_Result == 0)
                    {
                        _isSucess = false;
                    }
                    //1 = PROCESS SUCESS, 2 = PROCESS WITH ADD TYPE D SUCESS
                    else if (_Result == 1 || _Result == 2)
                    {
                        _isSucess = true;
                    }
                }

                if (_isSucess == true)
                {
                    _CustID = txtCustomerID.Text.Trim();
                    _CustName = txtCustomerName.Text.Trim();
                    _Company = txtCompany.Text.Trim();
                    _Address1 = txtAddress1.Text.Trim();
                    _Address2 = txtAddress2.Text.Trim();
                    _Address3 = txtAddress3.Text.Trim();
                    _RT = txtRT.Text.Trim();
                    _RW = txtRW.Text.Trim();
                    _ZipCode = txtZipCode.Text.Trim();
                    _Kel = cboKelurahan.Text.Trim();
                    _Kec = txtKecamatan.Text.Trim();
                    _City = txtCity.Text.Trim();
                    _Prov = txtProvince.Text.Trim();
                    _AddTypeD = _Result.ToString().Trim();

                    DialogResult = DialogResult.OK;

                    clsAlert.PushAlert("Updated Customer Address Sucessfully!", clsAlert.Type.Error);
                }
                else
                {
                    clsAlert.PushAlert("Updated Customer Address Failed!", clsAlert.Type.Error);
                }
            }
        }

        private void EditDeliveryAddres()
        {
            if (clsDialog.ShowDialog("Update Customer Address ?") == DialogResult.Yes)
            {
                bool _isSucess = false;
                int _Result = 0;

                if (_SubFlag.ToUpper() == "HOME")
                {
                    SOMasterCustomerBL = new SOMasterCustomerBL()
                    {
                        Customer_Name = txtCustomerName.Text.Trim(),
                        Address1 = txtAddress1.Text.Trim(),
                        Address2 = txtAddress2.Text.Trim(),
                        Address3 = txtAddress3.Text.Trim(),
                        Rt = txtRT.Text.Trim(),
                        Rw = txtRW.Text.Trim(),
                        Kelurahan = cboKelurahan.Text.Trim(),
                        Area_Code = (txtKecamatan.Tag == null) ? "" : txtKecamatan.Tag.ToString().Trim(),
                        Zipcode = txtZipCode.Text.Trim(),
                        Customer_Id = txtCustomerID.Text.Trim(),
                    };

                    _isSucess = SOVerificationProcessAL.UpdateCustomerAddressHome(SOMasterCustomerBL);
                }
                else if (_SubFlag.ToUpper() == "OFFICE")
                {
                    SOMasterCustomerBL = new SOMasterCustomerBL()
                    {
                        Customer_Name = txtCustomerName.Text.Trim(),
                        Address1 = txtAddress1.Text.Trim(),
                        Address2 = txtAddress2.Text.Trim(),
                        Address3 = txtAddress3.Text.Trim(),
                        Zipcode = txtZipCode.Text.Trim(),
                        Employer_City = txtCity.Text.Trim(),
                        Employer_Province = txtProvince.Text.Trim(),
                        Last_Employer_Name = txtCompany.Text.Trim(),
                        Customer_Id = txtCustomerID.Text.Trim(),
                    };

                    _isSucess = SOVerificationProcessAL.UpdateCustomerAddressOffice(SOMasterCustomerBL);
                }
                else if (_SubFlag.ToUpper() == "OTHER")
                {
                    SOMasterCustomerBL = new SOMasterCustomerBL()
                    {
                        Customer_Name = txtCustomerName.Text.Trim(),
                        Address1 = txtAddress1.Text.Trim(),
                        Address2 = txtAddress2.Text.Trim(),
                        Address3 = txtAddress3.Text.Trim(),
                        Rt = txtRT.Text.Trim(),
                        Rw = txtRW.Text.Trim(),
                        Kelurahan = cboKelurahan.Text.Trim(),
                        Area_Code = (txtKecamatan.Tag == null) ? "" : txtKecamatan.Tag.ToString().Trim(),
                        Zipcode = txtZipCode.Text.Trim(),
                        Employer_City = txtCity.Text.Trim(),
                        Employer_Province = txtProvince.Text.Trim(),
                        Customer_Id = txtCustomerID.Text.Trim(),
                    };

                    _Result = SOVerificationProcessAL.UpdateCustomerAddressOtherDelivery(SOMasterCustomerBL, txtKecamatan.Text.Trim());
                    //PROCESS FAILED
                    if (_Result == 0)
                    {
                        _isSucess = false;
                    }
                    //1 = PROCESS SUCESS
                    else if (_Result == 1)
                    {
                        _isSucess = true;
                    }
                }

                if (_isSucess == true)
                {
                    _CustID = txtCustomerID.Text.Trim();
                    _CustName = txtCustomerName.Text.Trim();
                    _Company = txtCompany.Text.Trim();
                    _Address1 = txtAddress1.Text.Trim();
                    _Address2 = txtAddress2.Text.Trim();
                    _Address3 = txtAddress3.Text.Trim();
                    _RT = txtRT.Text.Trim();
                    _RW = txtRW.Text.Trim();
                    _ZipCode = txtZipCode.Text.Trim();
                    _Kel = cboKelurahan.Text.Trim();
                    _Kec = txtKecamatan.Text.Trim();
                    _City = txtCity.Text.Trim();
                    _Prov = txtProvince.Text.Trim();
                    _AddTypeD = _Result.ToString().Trim();

                    DialogResult = DialogResult.OK;

                    clsAlert.PushAlert("Updated Customer Address Sucessfully!", clsAlert.Type.Error);
                }
                else
                {
                    clsAlert.PushAlert("Updated Customer Address Failed!", clsAlert.Type.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_Flag.ToUpper() == "BILLING")
            {
                EditBillingAddres();
            }
            else
            {
                EditDeliveryAddres();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SO_DialogEditCustomerAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {
                clsEventButton clsEventButton = new clsEventButton();
                clsEventButton.EnumAction _ActionType = clsEventButton.getEventType(e.KeyCode.ToString());

                switch (_ActionType)
                {
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

        private void SetTooltip()
        {
            ToolTip toolTipSaveEditAddresCustomerSor = new ToolTip();
            toolTipSaveEditAddresCustomerSor.ShowAlways = true;
            toolTipSaveEditAddresCustomerSor.SetToolTip(btnSave, "SAVE [F10]");

            ToolTip toolTipCancelEditAddresCustomerSor = new ToolTip();
            toolTipCancelEditAddresCustomerSor.ShowAlways = true;
            toolTipCancelEditAddresCustomerSor.SetToolTip(btnCancel, "CANCEL [F9]");
        }

        private void loadData()
        {
            txtCustomerID.Text = _CustID;
            txtCustomerName.Text = _CustName;
            txtCompany.Text = _Company;
            txtAddress1.Text = _Address1;
            txtAddress2.Text = _Address2;
            txtAddress3.Text = _Address3;
            txtRT.Text = _RT;
            txtRW.Text = _RW;
            txtZipCode.Text = _ZipCode;

            if(txtZipCode.Text.Trim().Length > 0)
            {
                loadKeluarahan();
            }

            cboKelurahan.Text = _Kel;

            txtKecamatan.Text = _Kec;
            txtCompany.Text = _Company;
            txtCity.Text = _City;
            txtProvince.Text = _Prov;

            if(_SubFlag == "OFFICE")
            {
                lblRT.Visible = false;
                txtRT.Visible = false;
                lblRW.Visible = false;
                txtRW.Visible = false;
                lblKel.Visible = false;
                cboKelurahan.Visible = false;
            }
        }

        private void SO_DialogEditCustomerAddress_Load(object sender, EventArgs e)
        {
            SetTooltip();
            KeyPreview = true;

            lblTitle.Text = _Title;
            loadData();
        }

        private void btnCancelEditMemoVs_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
