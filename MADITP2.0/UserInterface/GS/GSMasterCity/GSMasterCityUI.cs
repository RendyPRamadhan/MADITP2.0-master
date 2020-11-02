using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.businessLogic.GS;
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

namespace MADITP2._0.userInterface.GS
{
    public partial class GSMasterCityUI : Form
    {
        private GSMasterZipCodesAL MasterZipCodes;
        private GSMasterCityAL Accessor;
        private GSMasterCityBL _SelectedData;
        private clsGlobal Helper;
        private clsAlert Alert;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private int _APPSTATE;

        public GSMasterCityUI()
        {
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
            _CurrentPage = 1;
            _TotalPage = 0;

            InitializeComponent();
        }

        private void GSMasterCityUI_Load(object sender, EventArgs e)
        {
            Helper = new clsGlobal();
            Alert = new clsAlert();
            MasterZipCodes = new GSMasterZipCodesAL(Helper);
            Accessor = new GSMasterCityAL(Helper, MasterZipCodes);

            DrawDatatable();
            DrawFilterProvinces();
            PanelFormList.BringToFront();
        }

        private void DrawDatatable()
        {
            string search = null;
            string Province = null;

            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }
            
            if (cmbFilterProvince.SelectedValue != null)
            {
                Province = cmbFilterProvince.SelectedValue.ToString();
            }

            DataTable dt = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, Province, search);
            dgvResult.Columns.Clear();
            dgvResult.DataSource = dt;

            DataTable rslt = Accessor.CountRows(Province, search);
            _TotalPage = (int)Math.Ceiling(Convert.ToDouble(rslt.Rows[0]["jumlah"]) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;

            Pagination();
        }

        private void DrawFilterProvinces()
        {
            List<string> provinces = Accessor.GetProvices();
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();

            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = " - Select -", ValueMember = "" });
            int index = 1;
            foreach (string item in provinces)
            {
                ds.Insert(index, new ComboBoxViewModel() { DisplayMember = item.Trim(), ValueMember = item.Trim() });
                index++;
            }

            cmbFilterProvince.DataSource = ds;
            cmbFilterProvince.DisplayMember = "DisplayMember";
            cmbFilterProvince.ValueMember= "ValueMember";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
            Pagination(true);
            DrawDatatable();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void SetState(EnumState enumState)
        {
            switch (enumState)
            {
                case EnumState.Create:
                    _APPSTATE = (int)EnumState.Create;
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    _APPSTATE = (int)EnumState.Update;
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    _APPSTATE = (int)EnumState.Delete;
                    btnSave.Text = "Delete";
                    break;
                default:
                    _APPSTATE = 404;
                    this.Enabled = false;
                    break;
            }
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    var cells = dgvResult.Rows[e.RowIndex].Cells;
                    _SelectedData = new GSMasterCityBL();
                    _SelectedData.City_id = (int)cells["cc_city_id"].Value;
                    _SelectedData.City = (string)cells["cc_city"].Value;
                    _SelectedData.Kodya_kabupaten = (string)cells["cc_kodya_kabupaten"].Value;
                    _SelectedData.Province = (string)cells["cc_province"].Value;
                }
            }
            catch (Exception es)
            {
                Alert.PushAlert(es.Message,clsAlert.Type.Error);
            }
        }

        private void actionUpdateHandler()
        {
            GSMasterCityBL itemSave = new GSMasterCityBL()
            {
                Kodya_kabupaten = txtKodyaKab.Text.Trim(),
                Province = txtProvince.Text.Trim(),
                City_id = Accessor.GetSequence(),
                City = txtCity.Text.Trim()
            };

            Boolean info = Accessor.Put(_SelectedData.City_id, itemSave);
            if (!info)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Alert.PushAlert("Success", clsAlert.Type.Success);
            PanelFormList.BringToFront();
            Helper.ResetAllFormControls(PanelFormCreate);
            DrawDatatable();
        }

        private void actionDeleteHandler()
        {
            var info = Accessor.Delete(_SelectedData.City_id);
            if (!info)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Helper.ResetAllFormControls(PanelFormCreate);
            btnSearch_Click(null, null);
            PanelFormList.BringToFront();
            Alert.PushAlert("Deleted!", clsAlert.Type.Success);
        }

        private void actionSaveHandler()
        {
            GSMasterCityBL itemSave = new GSMasterCityBL()
            {
                Kodya_kabupaten = txtKodyaKab.Text.Trim(),
                Province = txtProvince.Text.Trim(),
                City_id = Accessor.GetSequence(),
                City = txtCity.Text.Trim()
            };

            Boolean info = Accessor.Post(itemSave);
            if (!info)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            _SelectedData = null;
            Alert.PushAlert("Success", clsAlert.Type.Success);
            PanelFormList.BringToFront();
            Helper.ResetAllFormControls(PanelFormCreate);
            DrawDatatable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_APPSTATE == (int)EnumState.Create)
            {
                actionSaveHandler();
                return;
            }

            if (_APPSTATE == (int)EnumState.Update)
            {
                actionUpdateHandler();
                return;
            }

            if (_APPSTATE == (int)EnumState.Delete)
            {
                actionDeleteHandler();
                return;
            }

            Alert.PushAlert("Invalid APPSTATE", clsAlert.Type.Error);
        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            PanelFormCreate.BringToFront();
            Helper.ResetAllFormControls(PanelFormCreate);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if(_SelectedData == null)
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.GetCity(_SelectedData.City_id);
            if (_SelectedData == null)
            {
                Alert.PushAlert("City not found!", clsAlert.Type.Warning);
                return;
            }

            PrepareFormEditor(_SelectedData);
            SetState(EnumState.Update);
            PanelFormCreate.BringToFront();
        }

        private void PrepareFormEditor(GSMasterCityBL item)
        {
            txtProvince.Text = item.Province.Trim();
            txtKodyaKab.Text = item.Kodya_kabupaten.Trim();
            txtCity.Text = item.City.Trim();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (_SelectedData == null)
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.GetCity(_SelectedData.City_id);
            if (_SelectedData == null)
            {
                Alert.PushAlert("City not found!", clsAlert.Type.Warning);
                return;
            }

            PrepareFormEditor(_SelectedData);
            SetState(EnumState.Delete);
            PanelFormCreate.BringToFront();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFilterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _CurrentPage = 1;
                Pagination(true);
                DrawDatatable();
            }
        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && txtFilterSearch.Text.Length == 0)
            {
                _CurrentPage = 1;
                Pagination(true);
                DrawDatatable();
            }
        }
    }
}
