using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.IM.IMWarehouseSecurity
{
    public partial class IMWarehouseSecurityUI : Form
    {
        private IMWarehouseSecurityAL Accessor;
        private clsGlobal Helper;
        private clsAlert Alert;
        private int? _WsID;
        private IMWarehouseSecurityBL _SelectedData;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private GSUserManagementAL GSUser;
        private clsWarehouse DialogWarehouse;

        public IMWarehouseSecurityUI()
        {
            InitializeComponent();

            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new IMWarehouseSecurityAL(Helper);
            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
            GSUser = new GSUserManagementAL(Helper, Alert);
            DialogWarehouse = new clsWarehouse(Helper);
        }

        private void IMWarehouseSecurityUI_Load(object sender, EventArgs e)
        {
            DrawDatatable();
            DrawFilterCombobox();
            DrawUserIDCombobox();

            PanelFormList.BringToFront();
        }

        private void DrawDatatable()
        {
            string search = null;
            IMWarehouseSecurityBL security = new IMWarehouseSecurityBL();

            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            if (cmbFilterUser.SelectedValue != null)
            {
                security.User_id = cmbFilterUser.SelectedValue.ToString();
            }

            List<IMWarehouseSecurityBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, security, search);
            dgvResult.AutoGenerateColumns = false;
            dgvResult.DataSource = source;

            int rows = Accessor.CountRows(security, search);
            _TotalPage = (int)Math.Ceiling(Convert.ToDouble(rows) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;
            if(rows == 0)
            {
                Alert.PushAlert("No record found!", clsAlert.Type.Info);
            }

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

        private void DrawFilterCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Add(new ComboBoxViewModel() { ValueMember = "", DisplayMember = "- filter by user -" });

            GSUser.GetListUsers().ForEach(delegate(GSUserManagementBL.GSUsers item) {
                ds.Add(new ComboBoxViewModel() { ValueMember = item.user_id, DisplayMember = item.name });
            });

            cmbFilterUser.DataSource = ds;
            cmbFilterUser.ValueMember = "ValueMember";
            cmbFilterUser.DisplayMember = "DisplayMember";
        }

        private void DrawUserIDCombobox()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Add(new ComboBoxViewModel() { ValueMember = "", DisplayMember = "- filter by user -" });

            GSUser.GetListUsers().ForEach(delegate (GSUserManagementBL.GSUsers item) {
                ds.Add(new ComboBoxViewModel() { ValueMember = Helper.CastToString(item.user_id), DisplayMember = Helper.CastToString(item.name) });
            });

            cmbUserID.DataSource = ds;
            cmbUserID.ValueMember = "ValueMember";
            cmbUserID.DisplayMember = "DisplayMember";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
            Pagination(true);
            DrawDatatable();
        }

        private void txtFilterSearch_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFilterSearch.Text == string.Empty)
            {
                btnSearch_Click(null, null);
                return;
            }
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            PanelFormCreate.BringToFront();
            Helper.ResetAllFormControls(PanelFormCreate);
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

        private void tiraComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSAPCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tiraTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tiraTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if(_WsID == null)
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.GetSecurity((int) _WsID);
            if(_SelectedData == null)
            {
                Alert.PushAlert("Warehouse Security not found!", clsAlert.Type.Error);
                return;
            }

            PrepareFormControl(_SelectedData);
            SetState(EnumState.Update);
            PanelFormCreate.BringToFront();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (_WsID == null)
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.GetSecurity((int)_WsID);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Warehouse Security not found!", clsAlert.Type.Error);
                return;
            }

            PrepareFormControl(_SelectedData);
            SetState(EnumState.Delete);
            PanelFormCreate.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(EnumState.Create == _APPSTATE)
            {
                HandleDataCreated();
                return;
            }

            if (EnumState.Update == _APPSTATE)
            {
                HandleUpdate();
                return;
            }

            if (EnumState.Delete == _APPSTATE)
            {
                HandleDelete();
                return;
            }
        }

        private void HandleDataCreated() 
        {
            try
            {
                _SelectedData.User_id = Helper.CastToString(cmbUserID.SelectedValue);
                _SelectedData.Warehouse_id = Helper.CastToString(txtWarehouseID.Text);
                _SelectedData.Input_txn_allow = chkInputAllowed.Checked ? "Y" : "N";
                _SelectedData.Initial_physical = chkInitialPhisical.Checked ? "Y" : "N";
                _SelectedData.Realese_physical = chkReleasePhisical.Checked ? "Y" : "N";
                _SelectedData.Receipt_entry = chkReceiptEntry.Checked ? "Y" : "N";
                _SelectedData.Shipment_entry = chkShipmentEntry.Checked ? "Y" : "N";
                _SelectedData.Transfer_txn_allow = chkTransferAllowed.Checked ? "Y" : "N";
            }
            catch (Exception e)
            {
                Alert.PushAlert(e.Message, clsAlert.Type.Error);
                Console.WriteLine(e.StackTrace);
                return;
            }

            bool info = Accessor.Post(_SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Alert.PushAlert("Saved!", clsAlert.Type.Success);
            PanelFormList.BringToFront();
            btnSearch_Click(null, null);
        }

        private void HandleUpdate() {
            _SelectedData.User_id = Helper.CastToString(cmbUserID.SelectedValue);
            _SelectedData.Warehouse_id = Helper.CastToString(txtWarehouseID.Text);
            _SelectedData.Input_txn_allow = chkInputAllowed.Checked ? "Y" : "N";
            _SelectedData.Initial_physical= chkInitialPhisical.Checked ? "Y" : "N";
            _SelectedData.Realese_physical = chkReleasePhisical.Checked ? "Y" : "N";
            _SelectedData.Receipt_entry = chkReceiptEntry.Checked ? "Y" : "N";
            _SelectedData.Shipment_entry = chkShipmentEntry.Checked ? "Y" : "N";
            _SelectedData.Transfer_txn_allow = chkTransferAllowed.Checked ? "Y" : "N";

            bool info = Accessor.Put((int) _WsID, _SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Alert.PushAlert("Updated!", clsAlert.Type.Success);
            PanelFormList.BringToFront();
            btnSearch_Click(null, null);
        }

        private void HandleDelete() {
            bool info = Accessor.Delete((int) _WsID);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Alert.PushAlert("Deleted!", clsAlert.Type.Success);
            PanelFormList.BringToFront();
            btnSearch_Click(null, null);
        }

        private void PrepareFormControl(IMWarehouseSecurityBL item)
        {
            IMMasterWarehouseAL mw = new IMMasterWarehouseAL(Helper);
            IMMasterWarehouseBL wh = mw.GetWarehouse(Helper.CastToString(item.Warehouse_id));
            if(wh != null)
            {
                txtWarehouseDescription.Text = wh.warehouse_description;
            }

            cmbUserID.SelectedValue = Helper.CastToString(item.User_id);
            txtWarehouseID.Text = Helper.CastToString(item.Warehouse_id);

            chkInputAllowed.Checked = (item.Input_txn_allow == "Y");
            chkTransferAllowed.Checked = (item.Transfer_txn_allow == "Y");
            chkInitialPhisical.Checked = (item.Initial_physical == "Y");
            chkReleasePhisical.Checked = (item.Realese_physical == "Y");
            chkShipmentEntry.Checked = (item.Shipment_entry == "Y");
            chkReceiptEntry.Checked = (item.Receipt_entry == "Y");
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _WsID = Convert.ToInt32(dgvResult.Rows[e.RowIndex].Cells["Id"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void tiraButton1_Click(object sender, EventArgs e)
        {
            if(DialogWarehouse.ShowDialog() == DialogResult.OK)
            {
                txtWarehouseID.Text = DialogWarehouse.Warehouse.warehouse_id;
                txtWarehouseDescription.Text = DialogWarehouse.Warehouse.warehouse_description;
            }
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "warehouse security";
            saveFileDialog1.ShowDialog();

            if(saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "ID",
                "User ID",
                "Warehouse ID",
                "Input Allowed",
                "Transfer Allowed",
                "Initial Physical",
                "Release Physical",
                "Shipment Entry",
                "Receipt Entry",
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (IMWarehouseSecurityBL item in Accessor.GetAll(new IMWarehouseSecurityBL() 
            {
                User_id = Helper.CastToString(cmbFilterUser.SelectedValue)
            }, txtFilterSearch.Text))
            {
                fileContent.Append("\"" + item.Id + "\",");
                fileContent.Append("\"" + item.User_id + "\",");
                fileContent.Append("\"" + item.Warehouse_id + "\",");
                fileContent.Append("\"" + item.Input_txn_allow + "\",");
                fileContent.Append("\"" + item.Transfer_txn_allow + "\",");
                fileContent.Append("\"" + item.Initial_physical + "\",");
                fileContent.Append("\"" + item.Realese_physical + "\",");
                fileContent.Append("\"" + item.Shipment_entry + "\",");
                fileContent.Append("\"" + item.Receipt_entry + "\",");

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);
            }

            try
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, fileContent.ToString());
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message, clsAlert.Type.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _SelectedData = null;
            PanelFormList.BringToFront();
        }
    }
}
