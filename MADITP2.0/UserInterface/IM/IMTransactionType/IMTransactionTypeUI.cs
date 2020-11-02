using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.IM.IMTransactionType
{
    public partial class IMTransactionTypeUI : Form
    {
        private clsGlobal Helper;
        private clsAlert Alert;
        private string _TypeCode;
        private IMTransactionTypeBL _SelectedData;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private IMTransactionTypeAL Accessor;

        public IMTransactionTypeUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Accessor = new IMTransactionTypeAL(Helper);
            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            InitializeComponent();
        }


        private void DrawDatatable()
        {
            string search = null;
            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            List<IMTransactionTypeBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search);
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

        private void IMTransactionTypeUI_Load(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
            DrawDatatable();
            DrawcmbIn_out_flag();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
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

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _TypeCode = Helper.CastToString(dgvResult.Rows[e.RowIndex].Cells["Txn_type_code"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
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

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Transaction Type";
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
                "Allow inventory Trans Entry",
                "Allow Negative QTY Entry",
                "Negate QTY Entry",
                "Allow Change Date",
                "Prompth Cost Field",
                "Update QTY On Hand",
                "Update Stock Movement",
                "Interface to GL",
                "Transaction Type",
                "Flag",
                "GL Transaction Type",
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (IMTransactionTypeBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                fileContent.Append("\"" + item.Txn_type_code + "\",");
                fileContent.Append("\"" + item.Txn_type_description+ "\",");
                fileContent.Append("\"" + item.Allow_inventory_txn_entry + "\",");
                fileContent.Append("\"" + item.Allow_negative_qty_entry + "\",");
                fileContent.Append("\"" + item.Negate_qty_entered + "\",");
                fileContent.Append("\"" + item.Allow_change_date + "\",");
                fileContent.Append("\"" + item.Promth_cost_field + "\",");
                fileContent.Append("\"" + item.Update_qty_on_hand + "\",");
                fileContent.Append("\"" + item.Update_stock_movement + "\",");
                fileContent.Append("\"" + item.Interface_to_gl + "\",");
                fileContent.Append("\"" + item.Gl_txn_type + "\",");
                fileContent.Append("\"" + item.In_out_flag + "\",");
                fileContent.Append("\"" + item.Group_acc + "\",");

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

        void SetState(EnumState enumState)
        {
            _APPSTATE = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    txtTxn_type_code.Enabled = true;
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    txtTxn_type_code.Enabled = false;
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    btnSave.Text = "Delete";
                    break;
                default:
                    break;
            }
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            Helper.ResetAllFormControls(PanelFormCreate);
            PanelFormCreate.BringToFront();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_TypeCode))
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.GetTransactionType(_TypeCode);
            if(_SelectedData == null)
            {
                Alert.PushAlert("Transaction Type not found!", clsAlert.Type.Warning);
                return;
            }

            prepareFormControl(_SelectedData);
            PanelFormCreate.BringToFront();
            SetState(EnumState.Update);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_TypeCode))
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.GetTransactionType(_TypeCode);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Transaction Type not found!", clsAlert.Type.Warning);
                return;
            }

            prepareFormControl(_SelectedData);
            PanelFormCreate.BringToFront();
            SetState(EnumState.Delete);
        }

        private void prepareFormControl(IMTransactionTypeBL Item)
        {
            txtTxn_type_code.Text = Item.Txn_type_code;
            txtTxn_type_description.Text = Item.Txn_type_description;
            cmbIn_out_flag.SelectedValue = Item.In_out_flag;
            txtGl_txn_type.Text = Item.Gl_txn_type;

            chkAllow_inventory_txn_entry.Checked = (Item.Allow_inventory_txn_entry == "Y");
            chkAllow_negative_qty_entry.Checked = (Item.Allow_negative_qty_entry == "Y");
            chkNegate_qty_entered.Checked = (Item.Negate_qty_entered == "Y");
            chkAllow_change_date.Checked = (Item.Allow_change_date == "Y");
            chkPromth_cost_field.Checked = (Item.Promth_cost_field == "Y");
            chkUpdate_qty_on_hand.Checked = (Item.Update_qty_on_hand == "Y");
            chkUpdate_stock_movement.Checked = (Item.Update_stock_movement == "Y");
            chkInterface_to_gl.Checked = (Item.Interface_to_gl == "Y");
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

        private void HandleDataCreated() 
        {
            _SelectedData = new IMTransactionTypeBL();
            _SelectedData.Txn_type_code = Helper.CastToString(txtTxn_type_code.Text);
            _SelectedData.Txn_type_description = Helper.CastToString(txtTxn_type_description.Text);
            _SelectedData.In_out_flag = Helper.CastToString(cmbIn_out_flag.SelectedValue);
            _SelectedData.Gl_txn_type = Helper.CastToString(txtGl_txn_type.Text);
            _SelectedData.Allow_inventory_txn_entry = chkAllow_inventory_txn_entry.Checked ? "Y" : "N";
            _SelectedData.Allow_negative_qty_entry = chkAllow_negative_qty_entry.Checked ? "Y" : "N";
            _SelectedData.Negate_qty_entered = chkNegate_qty_entered.Checked ? "Y" : "N";
            _SelectedData.Allow_change_date = chkAllow_change_date.Checked ? "Y" : "N";
            _SelectedData.Promth_cost_field = chkPromth_cost_field.Checked ? "Y" : "N";
            _SelectedData.Update_qty_on_hand = chkUpdate_qty_on_hand.Checked ? "Y" : "N";
            _SelectedData.Update_stock_movement = chkUpdate_stock_movement.Checked ? "Y" : "N";
            _SelectedData.Interface_to_gl = chkInterface_to_gl.Checked ? "Y" : "N";

            bool info = Accessor.Post(_SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Success!", clsAlert.Type.Success);
            navView_Click(null, null);
            btnSearch_Click(null, null);
        }

        private void HandleUpdate() 
        {
            _SelectedData.Txn_type_description = Helper.CastToString(txtTxn_type_description.Text);
            _SelectedData.In_out_flag = Helper.CastToString(cmbIn_out_flag.SelectedValue);
            _SelectedData.Gl_txn_type = Helper.CastToString(txtGl_txn_type.Text);
            _SelectedData.Allow_inventory_txn_entry = chkAllow_inventory_txn_entry.Checked ? "Y" : "N";
            _SelectedData.Allow_negative_qty_entry = chkAllow_negative_qty_entry.Checked ? "Y" : "N";
            _SelectedData.Negate_qty_entered = chkNegate_qty_entered.Checked ? "Y" : "N";
            _SelectedData.Allow_change_date = chkAllow_change_date.Checked ? "Y" : "N";
            _SelectedData.Promth_cost_field = chkPromth_cost_field.Checked ? "Y" : "N";
            _SelectedData.Update_qty_on_hand = chkUpdate_qty_on_hand.Checked ? "Y" : "N";
            _SelectedData.Update_stock_movement = chkUpdate_stock_movement.Checked ? "Y" : "N";
            _SelectedData.Interface_to_gl = chkInterface_to_gl.Checked ? "Y" : "N";

            bool info = Accessor.Put(_TypeCode, _SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Updated!", clsAlert.Type.Success);
            navView_Click(null, null);
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
            navView_Click(null, null);
            btnSearch_Click(null, null);
        }

        private void DrawcmbIn_out_flag()
        {
            List<ComboBoxViewModel> cmb = new List<ComboBoxViewModel>();
            cmb.Add(new ComboBoxViewModel()
            {
                ValueMember = "",
                DisplayMember = "- Choose -"
            });
            cmb.Add(new ComboBoxViewModel()
            {
                ValueMember = "I",
                DisplayMember = "In"
            });
            cmb.Add(new ComboBoxViewModel()
            {
                ValueMember = "O",
                DisplayMember = "Out"
            });
            cmb.Add(new ComboBoxViewModel()
            {
                ValueMember = "B",
                DisplayMember = "Both"
            });

            cmbIn_out_flag.DataSource = cmb;
            cmbIn_out_flag.ValueMember = "ValueMember";
            cmbIn_out_flag.DisplayMember = "DisplayMember";
        }
    }
}
