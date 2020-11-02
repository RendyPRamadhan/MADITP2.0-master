using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.IM.IMTransferType
{
    public partial class IMTransferTypeUI : Form
    {
        private clsGlobal Helper;
        private clsAlert Alert;
        private string _TypeCode;
        private IMTransferTypeBL _SelectedData;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private IMTransferTypeAL Accessor; 

        public IMTransferTypeUI()
        {
            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new IMTransferTypeAL(Helper);

            InitializeComponent();
        }

        private void DrawDatatable()
        {
            string search = null;
            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            List<IMTransferTypeBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search);
            dgvResult.AutoGenerateColumns = false;
            dgvResult.DataSource = source;

            int rows = Accessor.CountRows(search);
            _TotalPage = (int)Math.Ceiling(Convert.ToDouble(rows) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;
            if (rows == 0)
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

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void IMTransferTypeUI_Load(object sender, EventArgs e)
        {
            DrawDatatable();
            DrawComboboxSystemType();
            PanelFormList.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Pagination(true);
            DrawDatatable();
        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtFilterSearch.Text == string.Empty)
            {
                btnSearch_Click(null, null);
            }
        }

        private void txtFilterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
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

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            _SelectedData = null;
            Helper.ResetAllFormControls(PanelFormCreate);
            PanelFormCreate.BringToFront();
        }

        void SetState(EnumState enumState)
        {
            _APPSTATE = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    txtTransferTypeID.Enabled = true;
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    txtTransferTypeID.Enabled = false;
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    btnSave.Text = "Delete";
                    break;
                default:
                    break;
            }
        }

        private void prepareFormControl(IMTransferTypeBL Item)
        {
            txtTransferTypeID.Text = Item.Transfer_txn_type_code;
            txtTransferDescription.Text = Item.Transfer_txn_type_description;
            txtTypeOutOrg.Text = Item.Txn_type_out_from_org_wh;
            txtTypeInTransit.Text = Item.Txn_type_in_to_transit_wh;
            txtTypeOutTransit.Text = Item.Txn_type_out_from_transit_wh;
            txtTypeInDestination.Text = Item.Txn_type_in_to_destination_wh;
            txtTypeOutTransitExPOD.Text = Item.Txn_type_out_from_transit_ex_pod;
            txtTypeInOrgExPOD.Text = Item.Txn_type_into_or_wh_ex_pod;
            chkWithTransit.Checked = (Item.With_transit_warehouse == "Y") ? true : false;
            cmbSystemType.SelectedValue = Item.System_type;
            chkConfirmTransferRequired.Checked = (Item.Confirmation_transfer_required == "Y") ? true : false;
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_TypeCode))
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            IMTransferTypeBL item = Accessor.GetTransferType(_TypeCode);
            if(item == null)
            {
                Alert.PushAlert("Transfer type not found!", clsAlert.Type.Warning);
                return;
            }

            SetState(EnumState.Update);
            prepareFormControl(item);
            PanelFormCreate.BringToFront();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_TypeCode))
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            IMTransferTypeBL item = Accessor.GetTransferType(_TypeCode);
            if (item == null)
            {
                Alert.PushAlert("Transfer type not found!", clsAlert.Type.Warning);
                return;
            }

            SetState(EnumState.Delete);
            prepareFormControl(item);
            PanelFormCreate.BringToFront();
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _TypeCode = Helper.CastToString(dgvResult.Rows[e.RowIndex].Cells["Transfer_txn_type_code"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void DrawComboboxSystemType()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Add(new ComboBoxViewModel()
            {
                DisplayMember = "- Choose -",
                ValueMember = "",
            });
            ds.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Online",
                ValueMember = "O",
            });
            ds.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Batch",
                ValueMember = "B",
            });

            cmbSystemType.DataSource = ds;
            cmbSystemType.ValueMember = "ValueMember";
            cmbSystemType.DisplayMember = "DisplayMember";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EnumState.Create == _APPSTATE)
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

        private void HandleDataCreated() {
            try
            {
                _SelectedData = new IMTransferTypeBL();
                _SelectedData.Transfer_txn_type_code = Helper.CastToString(txtTransferTypeID.Text);
                _SelectedData.Transfer_txn_type_description = Helper.CastToString(txtTransferDescription.Text);
                _SelectedData.With_transit_warehouse = chkWithTransit.Checked ? "Y" : "N";
                _SelectedData.System_type = Helper.CastToString(cmbSystemType.SelectedValue);
                _SelectedData.Confirmation_transfer_required = chkConfirmTransferRequired.Checked ? "Y" : "N";
                _SelectedData.Txn_type_out_from_org_wh = Helper.CastToString(txtTypeOutOrg.Text);
                _SelectedData.Txn_type_in_to_transit_wh = Helper.CastToString(txtTypeInTransit.Text);
                _SelectedData.Txn_type_out_from_transit_wh = Helper.CastToString(txtTypeOutTransit.Text);
                _SelectedData.Txn_type_in_to_destination_wh = Helper.CastToString(txtTypeInDestination.Text);
                _SelectedData.Txn_type_out_from_transit_ex_pod = Helper.CastToString(txtTypeOutTransitExPOD.Text);
                _SelectedData.Txn_type_into_or_wh_ex_pod = Helper.CastToString(txtTypeInOrgExPOD.Text);
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

        private void HandleUpdate() 
        {
            try
            {
                _SelectedData = new IMTransferTypeBL();
                _SelectedData.Transfer_txn_type_code = Helper.CastToString(txtTransferTypeID.Text);
                _SelectedData.Transfer_txn_type_description = Helper.CastToString(txtTransferDescription.Text);
                _SelectedData.With_transit_warehouse = chkWithTransit.Checked ? "Y" : "N";
                _SelectedData.System_type = Helper.CastToString(cmbSystemType.SelectedValue);
                _SelectedData.Confirmation_transfer_required = chkConfirmTransferRequired.Checked ? "Y" : "N";
                _SelectedData.Txn_type_out_from_org_wh = Helper.CastToString(txtTypeOutOrg.Text);
                _SelectedData.Txn_type_in_to_transit_wh = Helper.CastToString(txtTypeInTransit.Text);
                _SelectedData.Txn_type_out_from_transit_wh = Helper.CastToString(txtTypeOutTransit.Text);
                _SelectedData.Txn_type_in_to_destination_wh = Helper.CastToString(txtTypeInDestination.Text);
                _SelectedData.Txn_type_out_from_transit_ex_pod = Helper.CastToString(txtTypeOutTransitExPOD.Text);
                _SelectedData.Txn_type_into_or_wh_ex_pod = Helper.CastToString(txtTypeInOrgExPOD.Text);
            }
            catch (Exception e)
            {
                Alert.PushAlert(e.Message, clsAlert.Type.Error);
                Console.WriteLine(e.StackTrace);
                return;
            }

            bool info = Accessor.Put(_TypeCode, _SelectedData);
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

        private void HandleDelete() 
        {
            bool info = Accessor.Delete(_TypeCode);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Deleted!", clsAlert.Type.Success);
            PanelFormList.BringToFront();
            btnSearch_Click(null, null);
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Transfer Type";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "Code",
                "Description",
                "With Transit",
                "System Type",
                "TF Confir Required",
                "IM Tran Type Out from Org WH",
                "IM Tran Type In to Transit WH",
                "IM Tran Type Out from Transit WH",
                "IM Tran Type In to Destination WH",
                "IM Tran Type Out from Transit Ex POD",
                "IM Tran Type In to Org WH ex POD",
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (IMTransferTypeBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                fileContent.Append("\"" + item.Transfer_txn_type_code + "\",");
                fileContent.Append("\"" + item.Transfer_txn_type_description + "\",");
                fileContent.Append("\"" + item.With_transit_warehouse + "\",");
                fileContent.Append("\"" + item.System_type + "\",");
                fileContent.Append("\"" + item.Confirmation_transfer_required + "\",");
                fileContent.Append("\"" + item.Txn_type_out_from_org_wh + "\",");
                fileContent.Append("\"" + item.Txn_type_in_to_transit_wh+ "\",");
                fileContent.Append("\"" + item.Txn_type_out_from_transit_wh+ "\",");
                fileContent.Append("\"" + item.Txn_type_in_to_destination_wh + "\",");
                fileContent.Append("\"" + item.Txn_type_out_from_transit_ex_pod+ "\",");
                fileContent.Append("\"" + item.Txn_type_into_or_wh_ex_pod+ "\",");

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
    }
}
