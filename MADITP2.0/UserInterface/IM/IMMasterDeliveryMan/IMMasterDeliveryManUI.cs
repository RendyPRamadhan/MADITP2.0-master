using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.IM.IMMasterDeliveryMan
{
    public partial class IMMasterDeliveryManUI : Form
    {
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private string _DeliveryManID;
        private clsGlobal Helper;
        private clsAlert Alert;
        private IMMasterDeliveryManAL Accessor;
        private GSEntityAL EntityAccessor;
        private GSBranchAL BranchAccessor;
        private SOMasterDivisionDA DivisionAccessor;
        private IMMasterDeliveryManBL _SelectedData;

        public IMMasterDeliveryManUI()
        {
            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new IMMasterDeliveryManAL(Helper);
            EntityAccessor = new GSEntityAL(Helper);
            BranchAccessor = new GSBranchAL(Helper);
            DivisionAccessor = new SOMasterDivisionDA();

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

            IMMasterDeliveryManBL ObjectFilter = new IMMasterDeliveryManBL()
            {
                Entity_id = Helper.CastToString(cmbFilterEntity.SelectedValue),
                Branch_id = Helper.CastToString(cmbFilterBranch.SelectedValue),
                Divison_id = Helper.CastToString(cmbFilterDivision.SelectedValue)
            };

            List<IMMasterDeliveryManBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, ObjectFilter, search);
            dgvResult.AutoGenerateColumns = false;
            dgvResult.DataSource = source;

            int rows = Accessor.CountRows(ObjectFilter, search);
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

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            PanelFormCreate.BringToFront();
            Helper.ResetAllFormControls(PanelFormCreate);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_DeliveryManID))
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.Find(_DeliveryManID);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Delivery man not found!", clsAlert.Type.Warning);
                return;
            }

            SetState(EnumState.Update);
            PanelFormCreate.BringToFront();
            prepareFormControll(_SelectedData);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Delete);
            PanelFormCreate.BringToFront();
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
            _SelectedData = new IMMasterDeliveryManBL();
            _SelectedData.Entity_id = Helper.CastToString(cmbEntityID.SelectedValue);
            _SelectedData.Branch_id = Helper.CastToString(cmbBranchID.SelectedValue);
            _SelectedData.Divison_id = Helper.CastToString(cmbDivisionID.SelectedValue);
            _SelectedData.Delivery_man_id = Helper.CastToString(txtDelivery_man_id.Text);
            _SelectedData.Delivery_man_name = Helper.CastToString(txtDelivery_man_name.Text);
            _SelectedData.Short_name = Helper.CastToString(txtDelivery_man_short_name.Text);
            _SelectedData.Sim_number = Helper.CastToString(txtSim_number.Text);
            _SelectedData.User_id = clsLogin.USERID;

            bool Info = Accessor.Post(_SelectedData);
            if (!Info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Created!", clsAlert.Type.Success);
            btnSearch_Click(null, null);
        }

        private void HandleUpdate() 
        {
            _SelectedData.Entity_id = Helper.CastToString(cmbEntityID.SelectedValue);
            _SelectedData.Branch_id = Helper.CastToString(cmbBranchID.SelectedValue);
            _SelectedData.Divison_id = Helper.CastToString(cmbDivisionID.SelectedValue);
            _SelectedData.Delivery_man_id = Helper.CastToString(txtDelivery_man_id.Text);
            _SelectedData.Delivery_man_name= Helper.CastToString(txtDelivery_man_name.Text);
            _SelectedData.Short_name = Helper.CastToString(txtDelivery_man_short_name.Text);
            _SelectedData.Sim_number = Helper.CastToString(txtSim_number.Text);
            _SelectedData.Vehicle_police_number = Helper.CastToString(txtVehicle_police_number.Text);

            bool Info = Accessor.Put(_DeliveryManID, _SelectedData);
            if (!Info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Alert.PushAlert("Updated!", clsAlert.Type.Success);
            btnSearch_Click(null, null);
        }

        private void HandleDelete() 
        {
            bool Info = Accessor.Delete(_DeliveryManID);
            if (!Info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Alert.PushAlert("Deleted!", clsAlert.Type.Success);
            btnSearch_Click(null, null);
        }

        void SetState(EnumState enumState)
        {
            _APPSTATE = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    txtDelivery_man_id.Enabled = true;
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    txtDelivery_man_id.Enabled = false;
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    txtDelivery_man_id.Enabled = false;
                    btnSave.Text = "Delete";
                    break;
                default:
                    break;
            }
        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void IMMasterDeliveryManUI_Load(object sender, EventArgs e)
        {
            DrawDatatable();
            DrawComboboxes();
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
                    _DeliveryManID = Helper.CastToString(dgvResult.Rows[e.RowIndex].Cells["Delivery_man_id"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void prepareFormControll(IMMasterDeliveryManBL Item)
        {
            cmbEntityID.SelectedValue = Helper.CastToString(Item.Entity_id);
            cmbBranchID.SelectedValue = Helper.CastToString(Item.Branch_id);
            cmbDivisionID.SelectedValue = Helper.CastToString(Item.Divison_id);

            txtDelivery_man_id.Text = Helper.CastToString(Item.Delivery_man_id);
            txtDelivery_man_name.Text = Helper.CastToString(Item.Delivery_man_name);
            txtDelivery_man_short_name.Text = Helper.CastToString(Item.Short_name);
            txtSim_number.Text = Helper.CastToString(Item.Sim_number);
            txtVehicle_police_number.Text = Helper.CastToString(Item.Vehicle_police_number);
        }

        private void DrawComboboxes()
        {
            cmbFilterBranch.DataSource = BranchAccessor.GetComboboxBranch(false);
            cmbFilterBranch.ValueMember = "ValueMember";
            cmbFilterBranch.DisplayMember = "DisplayMember";

            cmbFilterEntity.DataSource = EntityAccessor.GetComboboxEntity(false);
            cmbFilterEntity.ValueMember = "ValueMember";
            cmbFilterEntity.DisplayMember = "DisplayMember";

            cmbFilterDivision.DataSource = DivisionAccessor.GetComboboxDivision(false);
            cmbFilterDivision.ValueMember = "ValueMember";
            cmbFilterDivision.DisplayMember = "DisplayMember";

            cmbDivisionID.DataSource = DivisionAccessor.GetComboboxDivision(false);
            cmbDivisionID.ValueMember = "ValueMember";
            cmbDivisionID.DisplayMember = "DisplayMember";
            
            cmbBranchID.DataSource = BranchAccessor.GetComboboxBranch(false);
            cmbBranchID.ValueMember = "ValueMember";
            cmbBranchID.DisplayMember = "DisplayMember";

            cmbEntityID.DataSource = EntityAccessor.GetComboboxEntity(false);
            cmbEntityID.ValueMember = "ValueMember";
            cmbEntityID.DisplayMember = "DisplayMember";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
            Pagination(true);
            DrawDatatable();
            PanelFormList.BringToFront();
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Delivery Man";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "Delivery Man ID",
                "Name",
                "Short Name",
                "Entity",
                "Branch",
                "Division",
                "License Number",
                "User ID",
                "Police Number",
                "Last Update"
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (IMMasterDeliveryManBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                fileContent.Append("\"" + item.Delivery_man_id + "\",");
                fileContent.Append("\"" + item.Delivery_man_name + "\",");
                fileContent.Append("\"" + item.Short_name + "\",");
                fileContent.Append("\"" + item.Entity_id + "\",");
                fileContent.Append("\"" + item.Branch_id + "\",");
                fileContent.Append("\"" + item.Divison_id + "\",");
                fileContent.Append("\"" + item.Sim_number + "\",");
                fileContent.Append("\"" + item.User_id + "\",");
                fileContent.Append("\"" + item.Vehicle_police_number + "\",");
                fileContent.Append("\"" + item.Entry_last_update_date + "\",");

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
