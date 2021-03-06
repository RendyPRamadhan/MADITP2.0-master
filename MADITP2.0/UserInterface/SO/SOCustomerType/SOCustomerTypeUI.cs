﻿using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
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

namespace MADITP2._0.UserInterface.SO.SOCustomerType
{
    public partial class SOCustomerTypeUI : Form
    {
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private string _TypeID;
        private clsGlobal Helper;
        private clsAlert Alert;
        private SOCustomerTypeAL Accessor;
        private SOCustomerTypeBL _SelectedData;

        public SOCustomerTypeUI()
        {
            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Accessor = new SOCustomerTypeAL(Helper);

            InitializeComponent();
        }

        private void SOCustomerTypeUI_Load(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
            DrawDatatable();
        }

        private void DrawDatatable()
        {
            string search = null;
            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            List<SOCustomerTypeBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
            Pagination(true);
            DrawDatatable();
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

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Customer Type";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "Type ID",
                "Type Description",
                "Default Pricelist",
                "Gl Account"
            };

            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });

            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (SOCustomerTypeBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                fileContent.Append("\"" + Helper.CastToString(item.Customer_type) + "\",");
                fileContent.Append("\"" + Helper.CastToString(item.Customer_type_description) + "\",");
                fileContent.Append("\"" + Helper.CastToString(item.Default_price_list) + "\",");
                fileContent.Append("\"" + Helper.CastToString(item.Gl_account_mask) + "\",");

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

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            Helper.ResetAllFormControls(PanelFormCreate);
            PanelFormCreate.BringToFront();
        }

        void SetState(EnumState enumState)
        {
            _APPSTATE = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    txtCustomer_type.Enabled = true;
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    txtCustomer_type.Enabled = false;
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    txtCustomer_type.Enabled = false;
                    btnSave.Text = "Delete";
                    break;
                default:
                    break;
            }
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_TypeID))
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.Find(_TypeID);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Customer type not found!", clsAlert.Type.Warning);
                return;
            }

            PrepareFormControl(_SelectedData);
            PanelFormCreate.BringToFront();
            SetState(EnumState.Update);
        }

        private void PrepareFormControl(SOCustomerTypeBL Item)
        {
            txtCustomer_type.Text = Helper.CastToString(Item.Customer_type);
            txtCustomer_type_description.Text = Helper.CastToString(Item.Customer_type_description);
            cmbDefault_price_list.SelectedValue = Helper.CastToString(Item.Default_price_list);
            txtGl_account_mask.Text = Helper.CastToString(Item.Gl_account_mask);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_TypeID))
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.Find(_TypeID);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Customer type not found!", clsAlert.Type.Warning);
                return;
            }

            PrepareFormControl(_SelectedData);
            PanelFormCreate.BringToFront();
            SetState(EnumState.Delete);
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
            _SelectedData = new SOCustomerTypeBL();
            _SelectedData.Customer_type = Helper.CastToString(txtCustomer_type.Text);
            _SelectedData.Customer_type_description = Helper.CastToString(txtCustomer_type_description.Text);
            _SelectedData.Default_price_list = Helper.CastToString(cmbDefault_price_list.SelectedValue);
            _SelectedData.Gl_account_mask = Helper.CastToString(txtGl_account_mask.Text).Replace("-", "");

            bool info = Accessor.Post(_SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Success!", clsAlert.Type.Success);
            _SelectedData = null;
            navView_Click(null, null);
            btnSearch_Click(null, null);
        }

        private void HandleUpdate()
        {
            _SelectedData.Customer_type = Helper.CastToString(txtCustomer_type.Text);
            _SelectedData.Customer_type_description = Helper.CastToString(txtCustomer_type_description.Text);
            _SelectedData.Default_price_list = Helper.CastToString(cmbDefault_price_list.SelectedValue);
            _SelectedData.Gl_account_mask = Helper.CastToString(txtGl_account_mask.Text).Replace("-", "");

            bool info = Accessor.Put(_TypeID, _SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Updated!", clsAlert.Type.Success);
            _SelectedData = null;
            navView_Click(null, null);
            btnSearch_Click(null, null);
        }

        private void HandleDelete()
        {
            bool info = Accessor.Delete(_TypeID);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Deleted!", clsAlert.Type.Success);
            _SelectedData = null;
            navView_Click(null, null);
            btnSearch_Click(null, null);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView_Click(null,null);
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _TypeID = Helper.CastToString(dgvResult.Rows[e.RowIndex].Cells["Customer_type"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }
    }
}
