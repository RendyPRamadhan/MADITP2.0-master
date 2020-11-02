using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.IM
{
    public partial class IMMasterWarehouseUI : Form
    {
        private IMMasterWarehouseAL Accessor;
        private clsGlobal Helper;
        private clsAlert Alert;
        private string _WhID;
        private IMMasterWarehouseBL _SelectedData;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;

        public IMMasterWarehouseUI()
        {
            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new IMMasterWarehouseAL(Helper);
            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            InitializeComponent();
        }

        private void SetState(EnumState enumState)
        {
            _APPSTATE = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    btnSave.Text = "Delete";
                    break;
                default:
                    break;
            }
        }

        private void IMMasterWarehouseUI_Load(object sender, EventArgs e)
        {
            DrawDatatable(); 
            DrawFilterCombobox();
            DrawComboboxType();
            PanelFormList.BringToFront();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            Helper.ResetAllFormControls(PanelFormCreate);
            PanelFormCreate.BringToFront();

            txtWarehouseID.Enabled = true;
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_WhID))
            {
                Alert.PushAlert("Select data from table", clsAlert.Type.Warning);
                return;
            }

            Helper.ResetAllFormControls(PanelFormCreate);
            _SelectedData = Accessor.GetWarehouse(_WhID);
            if(_SelectedData == null)
            {
                Alert.PushAlert("Warehouse not found", clsAlert.Type.Warning);
                return;
            }

            SetState(EnumState.Update);
            prepareFormControl(_SelectedData);
            PanelFormCreate.BringToFront();

            txtWarehouseID.Enabled = false;
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_WhID))
            {
                Alert.PushAlert("Select data from table", clsAlert.Type.Warning);
                return;
            }

            Helper.ResetAllFormControls(PanelFormCreate);
            _SelectedData = Accessor.GetWarehouse(_WhID);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Warehouse not found", clsAlert.Type.Warning);
                return;
            }

            SetState(EnumState.Delete);
            prepareFormControl(_SelectedData);
            PanelFormCreate.BringToFront();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void DrawDatatable()
        {
            string search = null;
            IMMasterWarehouseBL wh = new IMMasterWarehouseBL();

            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            if (cmbFilterCity.SelectedValue != null)
            {
                wh.city = cmbFilterCity.SelectedValue.ToString();
            }

            List<IMMasterWarehouseBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, wh, search);
            dgvResult.AutoGenerateColumns = false;
            dgvResult.DataSource = source;

            int rows = Accessor.CountRows(wh, search);
            _TotalPage = (int)Math.Ceiling(Convert.ToDouble(rows) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;

            Pagination();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            _CurrentPage++;
            Pagination(true);
            DrawDatatable();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _CurrentPage--;
            Pagination(true);
            DrawDatatable();
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _WhID = Helper.CastToString(dgvResult.Rows[e.RowIndex].Cells["warehouse_id"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void prepareFormControl(IMMasterWarehouseBL bindItem)
        {
            txtWarehouseID.Text = Helper.CastToString(bindItem.warehouse_id);
            txtSAPCode.Text = Helper.CastToString(bindItem.sloc_sap_code);
            txtDescription.Text = Helper.CastToString(bindItem.warehouse_description);
            txtAddress1.Text = Helper.CastToString(bindItem.address_1);
            txtAddress2.Text = Helper.CastToString(bindItem.address_2);
            txtAddress3.Text = Helper.CastToString(bindItem.address_3);
            txtAreaCode.Text = Helper.CastToString(bindItem.area_code);
            txtCity.Text = Helper.CastToString(bindItem.city);
            txtPostalCode.Text = Helper.CastToString(bindItem.postal_code);
            txtProvince.Text = Helper.CastToString(bindItem.province);
            txtPhone.Text = Helper.CastToString(bindItem.phone);
            txtFax.Text = Helper.CastToString(bindItem.fax);
            txtContactPerson.Text = Helper.CastToString(bindItem.contact_person);
            cmbType.SelectedValue = Helper.CastToString(bindItem.type);
            txtTransitWhID.Text = Helper.CastToString(bindItem.transit_warehouse_id);
            txtDamageWhID.Text = Helper.CastToString(bindItem.damage_warehouse_id);
            txtGLEntity.Text = Helper.CastToString(bindItem.gl_entity);
            txtGLAccount.Text = Helper.CastToString(bindItem.gl_account);

            if ("Y" == bindItem.sales_shipment_allowed) { 
                chkSalesShipAllowed.Checked = true;
            }

            if ("Y" == bindItem.receipt_from_po_rec_allowed) { 
                chkReceiptFromPO.Checked = true;
            }

            if ("Y" == bindItem.receipt_from_non_po_allowed) { 
                chkReceiptFromNonPO.Checked = true;
            }

            if ("Y" == bindItem.cost_revaluation_allowed)
            {
                chkCostRevaluation.Checked = true;
            }

            if ("Y" == bindItem.transfer_transaction_allowed)
            {
                chkTransferTransaction.Checked = true;
            }
            
            if ("Y" == bindItem.manual_transaction_entry_allowed)
            {
                chkManualTransaction.Checked = true;
            }
            
            if ("Y" == bindItem.digital)
            {
                chkWhDigital.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(EnumState.Create == _APPSTATE)
            {
                _SelectedData = new IMMasterWarehouseBL();
                _SelectedData.warehouse_id = Helper.CastToString(txtWarehouseID.Text);
                _SelectedData.sloc_sap_code = Helper.CastToString(txtSAPCode.Text);
                _SelectedData.warehouse_description = Helper.CastToString(txtDescription.Text);
                _SelectedData.address_1 = Helper.CastToString(txtAddress1.Text);
                _SelectedData.address_2 = Helper.CastToString(txtAddress2.Text);
                _SelectedData.address_3 = Helper.CastToString(txtAddress3.Text);
                _SelectedData.area_code = Helper.CastToString(txtAreaCode.Text);
                _SelectedData.city = Helper.CastToString(txtCity.Text);
                _SelectedData.postal_code = Helper.CastToString(txtPostalCode.Text);
                _SelectedData.phone = Helper.CastToString(txtPhone.Text);
                _SelectedData.fax = Helper.CastToString(txtFax.Text);
                _SelectedData.contact_person = Helper.CastToString(txtContactPerson.Text);
                _SelectedData.type = Helper.CastToString(cmbType.SelectedValue);
                _SelectedData.transit_warehouse_id = Helper.CastToString(txtTransitWhID.Text);
                _SelectedData.damage_warehouse_id = Helper.CastToString(txtDamageWhID.Text);
                _SelectedData.gl_entity = Helper.CastToString(txtGLEntity.Text);
                _SelectedData.gl_account = Helper.CastToString(txtGLAccount.Text);
                _SelectedData.province = Helper.CastToString(txtProvince.Text);
                _SelectedData.sales_shipment_allowed = (chkSalesShipAllowed.Checked) ? "Y" : "N";
                _SelectedData.receipt_from_po_rec_allowed = chkReceiptFromPO.Checked ? "Y" : "N";
                _SelectedData.receipt_from_non_po_allowed = chkReceiptFromNonPO.Checked ? "Y" : "N";
                _SelectedData.cost_revaluation_allowed = chkCostRevaluation.Checked ? "Y" : "N";
                _SelectedData.transfer_transaction_allowed = chkTransferTransaction.Checked ? "Y" : "N";
                _SelectedData.manual_transaction_entry_allowed = chkManualTransaction.Checked ? "Y" : "N";
                _SelectedData.digital = chkWhDigital.Checked ? "Y" : "N";

                bool info = Accessor.Post(_SelectedData);
                if (!info)
                {
                    string errMessage = string.IsNullOrEmpty(Accessor.GetReason()) ? "Entry failed" : Accessor.GetReason();
                    Alert.PushAlert(errMessage, clsAlert.Type.Error);
                    return;
                }

                Alert.PushAlert("Saved!", clsAlert.Type.Success);
                PanelFormList.BringToFront();
                btnSearch_Click(null, null);
                _SelectedData = null;
                return;
            }

            if (EnumState.Update == _APPSTATE)
            {
                _SelectedData.warehouse_id = Helper.CastToString(txtWarehouseID.Text);
                _SelectedData.warehouse_description = Helper.CastToString(txtDescription.Text);
                _SelectedData.sloc_sap_code = Helper.CastToString(txtSAPCode.Text);
                _SelectedData.address_1 = Helper.CastToString(txtAddress1.Text);
                _SelectedData.address_2 = Helper.CastToString(txtAddress2.Text);
                _SelectedData.address_3 = Helper.CastToString(txtAddress3.Text);
                _SelectedData.area_code = Helper.CastToString(txtAreaCode.Text);
                _SelectedData.city = Helper.CastToString(txtCity.Text);
                _SelectedData.postal_code = Helper.CastToString(txtPostalCode.Text);
                _SelectedData.phone = Helper.CastToString(txtPhone.Text);
                _SelectedData.fax = Helper.CastToString(txtFax.Text);
                _SelectedData.contact_person = Helper.CastToString(txtContactPerson.Text);
                _SelectedData.type = Helper.CastToString(cmbType.SelectedValue);
                _SelectedData.transit_warehouse_id = Helper.CastToString(txtTransitWhID.Text);
                _SelectedData.damage_warehouse_id = Helper.CastToString(txtDamageWhID.Text);
                _SelectedData.gl_entity = Helper.CastToString(txtGLEntity.Text);
                _SelectedData.gl_account = Helper.CastToString(txtGLAccount.Text);
                _SelectedData.province = Helper.CastToString(txtProvince.Text);
                _SelectedData.sales_shipment_allowed = (chkSalesShipAllowed.Checked) ? "Y" : "N";
                _SelectedData.receipt_from_po_rec_allowed = chkReceiptFromPO.Checked ? "Y" : "N";
                _SelectedData.receipt_from_non_po_allowed = chkReceiptFromNonPO.Checked ? "Y" : "N";
                _SelectedData.cost_revaluation_allowed = chkCostRevaluation.Checked ? "Y" : "N";
                _SelectedData.transfer_transaction_allowed = chkTransferTransaction.Checked ? "Y" : "N";
                _SelectedData.manual_transaction_entry_allowed = chkManualTransaction.Checked ? "Y" : "N";
                _SelectedData.digital = chkWhDigital.Checked ? "Y" : "N";

                bool info = Accessor.Put(_WhID, _SelectedData);
                if (!info)
                {
                    string errMessage = string.IsNullOrEmpty(Accessor.GetReason()) ? "Update failed" : Accessor.GetReason();
                    Alert.PushAlert(errMessage, clsAlert.Type.Error);
                    return;
                }

                Alert.PushAlert("Updated!", clsAlert.Type.Success);
                PanelFormList.BringToFront();
                btnSearch_Click(null, null);
                _SelectedData = null;
                return;
            }

            if (EnumState.Delete == _APPSTATE)
            {
                bool info = Accessor.Delete(_WhID);
                if (!info)
                {
                    string errMessage = string.IsNullOrEmpty(Accessor.GetReason()) ? "Delete failed" : Accessor.GetReason();
                    Alert.PushAlert(errMessage, clsAlert.Type.Error);
                    return;
                }

                Alert.PushAlert("Deleted!", clsAlert.Type.Success);
                PanelFormList.BringToFront();
                btnSearch_Click(null, null);
                _SelectedData = null;
                return;
            }

            _SelectedData = null;
            Alert.PushAlert("Invalid appstate!", clsAlert.Type.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
            Pagination(true);
            DrawDatatable();
        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilterSearch.Text))
            {
                btnSearch_Click(null, null);
            }
        }

        private void DrawFilterCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Add(new ComboBoxViewModel() { ValueMember = "", DisplayMember = "- filter by city -" });

            Accessor.GetListCities().ForEach(delegate(string city){
                ds.Add(new ComboBoxViewModel() { ValueMember = city, DisplayMember = city });
            });

            cmbFilterCity.DataSource = ds;
            cmbFilterCity.ValueMember = "ValueMember";
            cmbFilterCity.DisplayMember = "DisplayMember";
        }

        private void DrawComboboxType()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>()
            {
                new ComboBoxViewModel(){ValueMember = "B",DisplayMember = "B"},
                new ComboBoxViewModel(){ValueMember = "D",DisplayMember = "D"},
                new ComboBoxViewModel(){ValueMember = "M",DisplayMember = "M"},
                new ComboBoxViewModel(){ValueMember = "N",DisplayMember = "N"},
                new ComboBoxViewModel(){ValueMember = "T",DisplayMember = "T"},
            };

            cmbType.DataSource = ds;
            cmbType.ValueMember = "ValueMember";
            cmbType.DisplayMember = "DisplayMember";
        }
    }
}
