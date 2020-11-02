using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.businessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MADITP2._0.userInterface.GS
{
    public partial class GSMasterZipCodesUI : Form
    {
        private GSMasterCityAL MasterCity;
        private GSMasterZipCodesAL Accessor;
        private GSMasterZipCodesBL _SelectedData;
        private GSMasterCityBL _SelectedCity;
        private clsGlobal Helper;
        private clsAlert Alert;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;

        public GSMasterZipCodesUI()
        {
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
            _CurrentPage = 1;
            _TotalPage = 0;

            InitializeComponent();
        }

        private void GSMasterZipCodesUI_Load(object sender, EventArgs e)
        {
            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new GSMasterZipCodesAL(Helper);
            MasterCity = new GSMasterCityAL(Helper);

            DrawDatatable();
            DrawComboboxFilter();
            DrawComboboxFormCreate();
            PanelFormList.BringToFront();
        }

        private void DrawComboboxFilter()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            int index = 1;
            List<string> kecamatans = Accessor.GetListKecamatan();
            if(kecamatans.Count > 0)
            {
                foreach (string kecamatan in kecamatans)
                {
                    ds.Insert(index, new ComboBoxViewModel() { DisplayMember = kecamatan, ValueMember = kecamatan });
                    index++;
                }
            }

            cmbFilterKecamatan.ValueMember = "ValueMember";
            cmbFilterKecamatan.DisplayMember = "DisplayMember";
            cmbFilterKecamatan.DataSource = ds;
        }

        private void DrawDatatable()
        {
            string search = "";
            string kecamatan = "";

            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }
            
            if (Helper.CastToString(cmbFilterKecamatan.SelectedValue) != "")
            {
                kecamatan = cmbFilterKecamatan.SelectedValue.ToString().Trim();
            }

            DataTable dt = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, kecamatan, search);
            dgvResult.Columns.Clear();
            dgvResult.DataSource = dt;

            DataTable rslt = Accessor.CountRows(kecamatan, search);
            _TotalPage = (int)Math.Ceiling(Convert.ToDouble(rslt.Rows[0]["jumlah"]) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;

            Pagination();
        }

        private void DrawComboboxFormCreate()
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            int index = 1;
            List<string> provinces = MasterCity.GetProvices();
            if (provinces.Count > 0)
            {
                foreach (string province in provinces)
                {
                    ds.Insert(index, new ComboBoxViewModel() { DisplayMember = province, ValueMember = province });
                    index++;
                }
            }

            cmbProvince.DataSource = null;
            cmbProvince.Items.Clear();
            cmbProvince.ResetText();

            cmbProvince.ValueMember = "ValueMember";
            cmbProvince.DisplayMember = "DisplayMember";
            cmbProvince.DataSource = ds;
        }

        private void DrawComboboxCity(int? city_id = null)
        {
            if(cmbKodyaKab.SelectedValue == null || cmbKodyaKab.SelectedValue == "")
            {
                return;
            }

            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Clear();
            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            int index = 1;
            string kab = cmbKodyaKab.SelectedValue.ToString().Trim();
            List<GSMasterCityBL> provinces = MasterCity.GetCities(kab);

            if (provinces.Count > 0)
            {
                foreach (GSMasterCityBL item in provinces)
                {
                    ds.Insert(index, new ComboBoxViewModel() { DisplayMember = item.City, ValueMember = item.City_id.ToString() });
                    index++;
                }
            }

            cmbKota.DataSource = null;
            cmbKota.Items.Clear();
            cmbKota.ResetText();

            cmbKota.ValueMember = "ValueMember";
            cmbKota.DisplayMember = "DisplayMember";
            cmbKota.DataSource = ds;

            if(city_id != null)
            {
                cmbKota.SelectedValue = city_id.ToString();
            }
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
            DrawDatatable();
            Pagination(true);
        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void SetState(EnumState enumState)
        {
            switch (enumState)
            {
                case EnumState.Create:
                    _APPSTATE = EnumState.Create;
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    _APPSTATE = EnumState.Update;
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    _APPSTATE = EnumState.Delete;
                    btnSave.Text = "Delete";
                    break;
                default:
                    break;
            }
        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back && txtFilterSearch.Text.Length == 0)
            {
                btnSearch_Click(null, null);
            }
        }

        private void txtFilterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
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

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            Helper.ResetAllFormControls(PanelFormCreate);
            PanelFormCreate.BringToFront();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if(_SelectedData == null)
            {
                Alert.PushAlert("Select data from table", clsAlert.Type.Error);
                return;
            }

            _SelectedCity = MasterCity.GetCity((int)_SelectedData.City);
            if (_SelectedCity == null)
            {
                Alert.PushAlert("Province and Sub province not found", clsAlert.Type.Error);
            }

            PrepareFormEditor();
            SetState(EnumState.Update);
            PanelFormCreate.BringToFront();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (_SelectedData == null)
            {
                Alert.PushAlert("Select data from table", clsAlert.Type.Error);
                return;
            }

            _SelectedCity = MasterCity.GetCity((int)_SelectedData.City);
            if (_SelectedCity == null)
            {
                Alert.PushAlert("Province and Sub province not found", clsAlert.Type.Error);
            }

            PrepareFormEditor();
            SetState(EnumState.Delete);
            PanelFormCreate.BringToFront();
        }

        private void PrepareFormEditor()
        {
            cmbProvince.SelectedValue = _SelectedCity.Province.Trim();
            cmbKodyaKab.SelectedValue = _SelectedCity.Kodya_kabupaten.Trim();

            DrawComboboxCity(_SelectedCity.City_id);

            txtKelurahan.Text = _SelectedData.Kelurahan;
            txtKecamatan.Text = _SelectedData.Kecamatan;
            txtKodePos.Text = _SelectedData.Zip_code;
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _SelectedData = new GSMasterZipCodesBL();
                    _SelectedData.ID = Convert.ToInt32(dgvResult.Rows[e.RowIndex].Cells["id"].Value);
                    _SelectedData.City = Convert.ToInt32(dgvResult.Rows[e.RowIndex].Cells["city"].Value);
                    _SelectedData.Kecamatan = dgvResult.Rows[e.RowIndex].Cells["kecamatan"].Value.ToString();
                    _SelectedData.Kelurahan = dgvResult.Rows[e.RowIndex].Cells["kelurahan"].Value.ToString();
                    _SelectedData.Zip_code = dgvResult.Rows[e.RowIndex].Cells["zip_code"].Value.ToString();
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_APPSTATE == EnumState.Create)
            {
                try
                {
                    ActionCreateHandler();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                    Alert.PushAlert(err.Message.ToString(), clsAlert.Type.Error);
                }
                return;
            }

            if (_APPSTATE == EnumState.Update)
            {
                try
                {
                    ActionUpdateHandler();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                    Alert.PushAlert(err.Message.ToString(), clsAlert.Type.Error);
                }
                return;
            }

            if (_APPSTATE == EnumState.Delete)
            {
                try
                {
                    ActionDeleteHandler();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                    Alert.PushAlert(err.Message.ToString(), clsAlert.Type.Error);
                }
                return;
            }

            Alert.PushAlert("Invalid APPSTATE", clsAlert.Type.Error);
        }

        private void ActionCreateHandler() 
        {
            Boolean info = Accessor.Post(new GSMasterZipCodesBL()
            {
                Zip_code = txtKodePos.Text,
                City = Convert.ToInt32(cmbKota.SelectedValue),
                Kecamatan = txtKecamatan.Text,
                Kelurahan = txtKelurahan.Text
            });

            if (!info)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Success", clsAlert.Type.Success);
            Pagination(true);
            DrawDatatable();
            PanelFormList.BringToFront();
        }

        private void ActionUpdateHandler() 
        {
            _SelectedData.City = Convert.ToInt32(cmbKota.SelectedValue);
            _SelectedData.Kecamatan = txtKecamatan.Text.Trim();
            _SelectedData.Kelurahan = txtKelurahan.Text.Trim();
            _SelectedData.Zip_code = txtKodePos.Text.Trim();

            Boolean info = Accessor.Put(_SelectedData.ID, _SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            _SelectedCity = null;
            _SelectedData = null;
            Alert.PushAlert("Success!", clsAlert.Type.Success);
            Pagination(true);
            DrawDatatable();
            PanelFormList.BringToFront();
        }

        private void ActionDeleteHandler()
        {
            Boolean info = Accessor.Delete(_SelectedData.ID);
            if (!info)
            {
                Alert.PushAlert(Accessor.GetReason(), clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Success", clsAlert.Type.Success);
            Pagination(true);
            DrawDatatable();
            PanelFormList.BringToFront();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Clear();

            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            int index = 1;
            string province = cmbProvince.SelectedValue.ToString().Trim();

            List<string> provinces = MasterCity.GetKabupaten(province);
            if (provinces.Count > 0)
            {
                foreach (string item in provinces)
                {
                    ds.Insert(index, new ComboBoxViewModel() { DisplayMember = item, ValueMember = item });
                    index++;
                }
            }

            cmbKodyaKab.DataSource = null;
            cmbKodyaKab.Items.Clear();
            cmbKodyaKab.ResetText();

            cmbKodyaKab.ValueMember = "ValueMember";
            cmbKodyaKab.DisplayMember = "DisplayMember";
            cmbKodyaKab.DataSource = ds;
        }

        private void cmbKodyaKab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_SelectedData != null)
            {
                DrawComboboxCity(_SelectedData.City);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _SelectedData = null;
            _SelectedCity = null;
            Helper.ResetAllFormControls(PanelFormCreate);
            PanelFormList.BringToFront();
        }
    }
}
