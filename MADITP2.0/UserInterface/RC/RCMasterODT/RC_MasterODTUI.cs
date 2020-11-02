using MADITP2._0.DataAccess.RC;
using MADITP2._0.Enums;
using System;
using System.Data;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.businessLogic.RC;
using MADITP2._0.DataAccess.GS;
using System.Collections.Generic;
using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.ApplicationLogic.RC;
using System.Text;
using System.Reflection;

namespace MADITP2._0.userInterface.RC
{
    public partial class RC_MasterODTUI : Form
    {
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private int _RoIdSelected = 0;
        private int _APPSTATE;
        private RCMasterODTAL Accessor;
        private RCMasterODTBL _SelectedData;
        private clsGlobal Helper;
        private clsAlert Alert;
        private GSBranchAL BranchAL;
        private GSMasterReligionDA Religion;
        private RCMasterOctTypeDA OctType;

        public RC_MasterODTUI()
        {
            InitializeComponent();
            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new RCMasterODTAL(Helper);
            BranchAL = new GSBranchAL(Helper);
            Religion = new GSMasterReligionDA();
            OctType = new RCMasterOctTypeDA();
        }

        private void RC_MasterODTUI_Load(object sender, EventArgs e)
        {
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
            _CurrentPage = 1;
            _TotalPage = 0;

            DrawOCTCombobox();
            DrawBranchCombobox();
            DrawReligionCombobox();
            DrawGenderCombobox();
            DrawStatusCombobox();
            DrawPrincipalCombobox();

            DrawDatatable();
            Pagination();

            PanelFormList.BringToFront();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            showFormList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            Helper.ResetAllFormControls(PanelFormCreate);
            Helper.ResetAllFormControls(TabRecuiter);
            Helper.ResetAllFormControls(TabDataPeserta);
            Helper.ResetAllFormControls(TabOCT);
            Helper.ResetAllFormControls(TabBOP);
            Helper.ResetAllFormControls(TabInterview);
            showFormCreate();
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
        
        private void DrawDatatable()
        {
            string search = null;
            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            List<RCMasterODTBL> dt = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search);
            dgvResult.DataSource = dt;

            int rows = Accessor.CountRows(search);
            _TotalPage = (int)Math.Ceiling(Convert.ToDouble(rows) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;
            if (rows == 0)
            {
                Alert.PushAlert("No record found!", clsAlert.Type.Info);
            }

            Pagination();
        }

        private void DrawBranchCombobox()
        {
            cmbCabang.DataSource = BranchAL.GetComboboxBranch(true);
            cmbCabang.DisplayMember = "DisplayMember";
            cmbCabang.ValueMember = "ValueMember";

            cmbFilterCabang.DataSource = BranchAL.GetComboboxBranch(true);
            cmbFilterCabang.DisplayMember = "DisplayMember";
            cmbFilterCabang.ValueMember = "ValueMember";
        }

        private void DrawOCTCombobox()
        {
            cmbOctType.DataSource = OctType.GetEntity();
            cmbOctType.DisplayMember = "DisplayMember";
            cmbOctType.ValueMember = "ValueMember";
        }

        private void DrawReligionCombobox()
        {
            cmbAgama.DataSource = Religion.GetEntity();
            cmbAgama.DisplayMember = "DisplayMember";
            cmbAgama.ValueMember = "ValueMember";
        }

        private void DrawStatusCombobox()
        {
            List<ComboBox> cmbs = new List<ComboBox>();
            cmbs.Add(cmbStatusOCT);
            cmbs.Add(cmbStatusBOP);
            cmbs.Add(cmbStatusPPQ);
            cmbs.Add(cmbStatusInterview);

            foreach(var cmb in cmbs)
            {
                var ds = new List<ComboBoxViewModel>();
                ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
                ds.Insert(1, new ComboBoxViewModel() { DisplayMember = "Lulus", ValueMember = "Y" });
                ds.Insert(2, new ComboBoxViewModel() { DisplayMember = "Tidak lulus", ValueMember = "N" });

                cmb.DataSource = ds;
                cmb.DisplayMember = "DisplayMember";
                cmb.ValueMember = "ValueMember";
            }

            var res = new List<ComboBoxViewModel>();
            res.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            res.Insert(1, new ComboBoxViewModel() { DisplayMember = "Single", ValueMember = "1" });
            res.Insert(2, new ComboBoxViewModel() { DisplayMember = "Married", ValueMember = "2" });
            res.Insert(3, new ComboBoxViewModel() { DisplayMember = "Widowed", ValueMember = "3" });
            cmbStatusPernikahan.DataSource = res;
            cmbStatusPernikahan.DisplayMember = "DisplayMember";
            cmbStatusPernikahan.ValueMember = "ValueMember";
        }

        private void DrawGenderCombobox()
        {
            var result = new List<ComboBoxViewModel>();
            result.Insert(0, new ComboBoxViewModel() { DisplayMember = "- Select -", ValueMember = "" });
            result.Insert(1, new ComboBoxViewModel() { DisplayMember = "Perempuan", ValueMember = "M" });
            result.Insert(2, new ComboBoxViewModel() { DisplayMember = "Laki-laki", ValueMember = "F" });

            cmbJenisKelamin.DataSource = result;
            cmbJenisKelamin.DisplayMember = "DisplayMember";
            cmbJenisKelamin.ValueMember = "ValueMember";
        }

        private void DrawPrincipalCombobox()
        {
            var ListPrincipal = new List<ComboBoxViewModel>();
            ListPrincipal.Add(new ComboBoxViewModel() {
                ValueMember = "",
                DisplayMember = "- Choose -"
            });

            ListPrincipal.Add(new ComboBoxViewModel() {
                ValueMember = "AQL",
                DisplayMember = "Al Qolam"
            });

            cmbPrincipal.DataSource = ListPrincipal;
            cmbPrincipal.DisplayMember = "DisplayMember";
            cmbPrincipal.ValueMember = "ValueMember";

            ListPrincipal = new List<ComboBoxViewModel>();
            ListPrincipal.Add(new ComboBoxViewModel()
            {
                ValueMember = "",
                DisplayMember = "- Choose -"
            });

            ListPrincipal.Add(new ComboBoxViewModel()
            {
                ValueMember = "AQL",
                DisplayMember = "Al Qolam"
            });

            cmbFilterPrincipal.DataSource = ListPrincipal;
            cmbFilterPrincipal.DisplayMember = "DisplayMember";
            cmbFilterPrincipal.ValueMember = "ValueMember";
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

        private void btnCreateCancel_Click(object sender, EventArgs e)
        {
            showFormList();
        }

        private void showFormCreate()
        {
            PanelFormCreate.BringToFront();
        }

        private void showFormList()
        {
            PanelFormList.BringToFront();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Pagination(true);
            DrawDatatable();
        }

        private void SetState(EnumState enumState)
        {
            switch (enumState)
            {
                case EnumState.Create:
                    _APPSTATE = (int)EnumState.Create;
                    btnCreateSave.Text = "Save";
                    break;
                case EnumState.Update:
                    _APPSTATE = (int)EnumState.Update;
                    btnCreateSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    _APPSTATE = (int)EnumState.Delete;
                    btnCreateSave.Text = "Delete";
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
                    int ro_id = (int) dgvResult.Rows[e.RowIndex].Cells["Id"].Value;
                    _RoIdSelected = ro_id;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }

            if(txtRecruiterID.Text == "")
            {
                txtRecruiterName.Text = "";
                txtManagerID.Text = "";
                txtManagerName.Text = "";
                return;
            }

            DataTable dt = Accessor.GetRecruiter(txtRecruiterID.Text);
            if (dt.Rows.Count == 0)
            {
                Alert.PushAlert("Recruiter not found", clsAlert.Type.Error);
                return;
            }

            var item = dt.Rows[0];
            txtRecruiterName.Text = Helper.CastToString(item["rm_name"]);
            txtManagerID.Text = Helper.CastToString(item["rm_manager_id"]);
            txtManagerName.Text = Helper.CastToString(item["rm_nm_Manager"]);
        }

        private void RC_MasterODTUI_KeyDown(object sender, KeyEventArgs e)
        {
            clsEventButton clsEventButton = new clsEventButton();
            clsEventButton.EnumAction _ActionType = clsEventButton.getEventType(e.KeyCode.ToString());

            switch (_ActionType)
            {
                case clsEventButton.EnumAction.NEW:
                    {
                        Console.WriteLine("Hit");
                        btnAdd_Click(null, null);
                        break;
                    }
                case clsEventButton.EnumAction.EDIT:
                    {
                        btnAdd_Click(null, null);
                        break;
                    }
                case clsEventButton.EnumAction.DELETE:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.PRINT:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.EXIT:
                    {
                        btnExit_Click(null, null);
                        break;
                    }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _SelectedData = Accessor.Find(_RoIdSelected);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Not Found!", clsAlert.Type.Error);
                return;
            }

            SetState(EnumState.Update);
            showFormCreate();

            //header
            txtTglOct.Value = _SelectedData.Tgl_Oct.HasValue ? Convert.ToDateTime(_SelectedData.Tgl_Oct) : DateTime.FromOADate(0);
            txtDivisionID.Text = _SelectedData.Division_Id;

            //recruiter
            txtRecruiterID.Text = _SelectedData.Rep_Id;
            txtRecruiterName.Text = _SelectedData.Rep_Name;
            txtManagerID.Text = _SelectedData.Manager_Id;
            txtManagerName.Text = _SelectedData.Manager_Name;

            //peserta
            txtNamaPeserta.Text = _SelectedData.Nama_Peserta;
            txtAlamatPeserta.Text = _SelectedData.Alamat;
            txtKotaDomisili.Text = _SelectedData.Kota_Domisili;
            txtKodePos.Text = _SelectedData.Kode_Pos;
            txtIdentity.Text = _SelectedData.Identitas_Oct;
            txtTelpRumah.Text = _SelectedData.Telp_Peserta;
            txtNoHp.Text = _SelectedData.Oct_Hanphone_Peserta;
            txtTempatLahir.Text = _SelectedData.Tempat_Lahir;
            txtTglLahir.Value = _SelectedData.Tanggal_Lahir.HasValue ? Convert.ToDateTime(_SelectedData.Tanggal_Lahir) : DateTime.FromOADate(0);

            //oct
            txtKeterangOCT.Text = _SelectedData.Keterangan;
            txtTrainer.Text = _SelectedData.Trainer;

            //bop
            txtTglBOP.Value = _SelectedData.Tgl_Bop.HasValue ? Convert.ToDateTime(_SelectedData.Tgl_Bop) : DateTime.FromOADate(0);
            txtTglPPQ.Value = _SelectedData.Tgl_Ppq.HasValue ? Convert.ToDateTime(_SelectedData.Tgl_Ppq) : DateTime.FromOADate(0);

            //interview 
            txtTglInterview.Value = _SelectedData.Tgl_Intervw.HasValue ? Convert.ToDateTime(_SelectedData.Tgl_Intervw) : DateTime.FromOADate(0);
            txtInterviewDgn.Text = _SelectedData.Intervw_By;
            txtKodeBA.Text = _SelectedData.Oct_Rep_Id;

            if(_SelectedData.Principal != null)
            {
                cmbPrincipal.SelectedValue = _SelectedData.Principal;
            }

            if (_SelectedData.Agama != null)
            {
                cmbAgama.SelectedValue = _SelectedData.Agama;
            }

            if (_SelectedData.Branch_Id != null)
            {
                cmbCabang.SelectedValue = _SelectedData.Branch_Id;
            }

            if(_SelectedData.Jenis_Kelamin != null)
            {
                cmbJenisKelamin.SelectedValue = _SelectedData.Jenis_Kelamin;
            }
            
            if(_SelectedData.Lulus != null)
            {
                cmbStatusOCT.SelectedValue = _SelectedData.Lulus;
            }

            if(_SelectedData.Lulus_Bop != null)
            {
                cmbStatusBOP.SelectedValue = _SelectedData.Lulus_Bop;
            }

            if(_SelectedData.Lulus_Ppq != null)
            {
                cmbStatusPPQ.SelectedValue = _SelectedData.Lulus_Ppq;
            }

            if(_SelectedData.Lulus_Intervw != null)
            {
                cmbStatusInterview.SelectedValue = _SelectedData.Lulus_Intervw;
            }

            if(_SelectedData.Status_Pernikahan != null)
            {
                cmbStatusPernikahan.SelectedValue = _SelectedData.Status_Pernikahan;
            }
            
            if(_SelectedData.Oct_Type != null)
            {
                cmbOctType.SelectedValue = _SelectedData.Oct_Type;
            }
        }

        private Boolean CreateNew()
        {
            if (txtTglOct.Text == "")
            {
                Alert.PushAlert("Tanggal OCT tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtDivisionID.Text == "")
            {
                Alert.PushAlert("Divisi lama tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbCabang.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Cabang tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtRecruiterID.Text == "")
            {
                Alert.PushAlert("Recruiter ID tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtManagerID.Text == "")
            {
                Alert.PushAlert("Manager ID tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtNamaPeserta.Text == "")
            {
                Alert.PushAlert("Nama peserta tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtAlamatPeserta.Text == "")
            {
                Alert.PushAlert("Alamat tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtIdentity.Text == "")
            {
                Alert.PushAlert("SIM/KTP tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtNoHp.Text == "")
            {
                Alert.PushAlert("No HP peserta tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbAgama.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Agama tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbJenisKelamin.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Jenis kelamin tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtTempatLahir.Text == "")
            {
                Alert.PushAlert("Tempat lahir tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbStatusOCT.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Status OCT tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbOctType.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Type OCT tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            _SelectedData = new RCMasterODTBL();
            _SelectedData.Alamat = txtAlamatPeserta.Text;
            _SelectedData.Tgl_Oct = txtTglOct.Value;
            _SelectedData.Division_Id = txtDivisionID.Text;
            _SelectedData.Rep_Id = txtRecruiterID.Text;
            _SelectedData.Rep_Name = txtRecruiterName.Text;
            _SelectedData.Manager_Id = txtManagerID.Text;
            _SelectedData.Manager_Name = txtManagerName.Text;
            _SelectedData.Nama_Peserta = txtNamaPeserta.Text;
            _SelectedData.Alamat = txtAlamatPeserta.Text;
            _SelectedData.Kota_Domisili = txtKotaDomisili.Text;
            _SelectedData.Kode_Pos = txtKodePos.Text;
            _SelectedData.Identitas_Oct = txtIdentity.Text;
            _SelectedData.Principal = Helper.CastToString(cmbPrincipal.SelectedValue);

            _SelectedData.Branch_Id = cmbCabang.SelectedValue.ToString();
            _SelectedData.Jenis_Kelamin = cmbJenisKelamin.SelectedValue.ToString();
            _SelectedData.Agama = cmbAgama.SelectedValue.ToString();
            _SelectedData.Lulus = cmbStatusOCT.SelectedValue.ToString();
            _SelectedData.Oct_Type = cmbOctType.SelectedValue.ToString();

            _SelectedData.Telp_Peserta= txtTelpRumah.Text;
            _SelectedData.Oct_Hanphone_Peserta = txtNoHp.Text;
            _SelectedData.Tempat_Lahir = txtTempatLahir.Text;
            _SelectedData.Tanggal_Lahir = txtTglLahir.Value;
            _SelectedData.Keterangan = txtKeterangOCT.Text;
            _SelectedData.Trainer = txtTrainer.Text;
            _SelectedData.Oct_Rep_Id = txtKodeBA.Text;

            if (cmbStatusBOP.SelectedValue != null)
            {
                _SelectedData.Tgl_Bop = txtTglBOP.Value;
                _SelectedData.Lulus_Bop = cmbStatusBOP.SelectedValue.ToString();
            }

            if (cmbStatusPPQ.SelectedValue != null)
            {
                _SelectedData.Tgl_Ppq = txtTglPPQ.Value;
                _SelectedData.Lulus_Ppq = cmbStatusPPQ.SelectedValue.ToString();
            }

            if (cmbStatusInterview.SelectedValue != null)
            {
                _SelectedData.Lulus_Intervw = cmbStatusInterview.SelectedValue.ToString();
                _SelectedData.Tgl_Intervw = txtTglInterview.Value;
                _SelectedData.Intervw_By = txtInterviewDgn.Text;
            }

            if (cmbStatusPernikahan.SelectedValue != null)
            {
                _SelectedData.Status_Pernikahan = cmbStatusPernikahan.SelectedValue.ToString();
            }

            return Accessor.Post(_SelectedData);
        }

        private Boolean Update()
        {
            if (txtTglOct.Text == "")
            {
                Alert.PushAlert("Tanggal OCT tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtDivisionID.Text == "")
            {
                Alert.PushAlert("Divisi lama tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbCabang.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Cabang tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtRecruiterID.Text == "")
            {
                Alert.PushAlert("Recruiter ID tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtManagerID.Text == "")
            {
                Alert.PushAlert("Manager ID tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtNamaPeserta.Text == "")
            {
                Alert.PushAlert("Nama peserta tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtAlamatPeserta.Text == "")
            {
                Alert.PushAlert("Alamat tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtIdentity.Text == "")
            {
                Alert.PushAlert("SIM/KTP tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtNoHp.Text == "")
            {
                Alert.PushAlert("No HP peserta tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbAgama.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Agama tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbJenisKelamin.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Jenis kelamin tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (txtTempatLahir.Text == "")
            {
                Alert.PushAlert("Tempat lahir tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbStatusOCT.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Tempat lahir tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            if (cmbOctType.SelectedValue.ToString() == "")
            {
                Alert.PushAlert("Tempat lahir tidak boleh kosong", clsAlert.Type.Warning);
                return false;
            }

            _SelectedData.Alamat = txtAlamatPeserta.Text;
            _SelectedData.Tgl_Oct = txtTglOct.Value;
            _SelectedData.Division_Id = txtDivisionID.Text;
            _SelectedData.Rep_Id = txtRecruiterID.Text;
            _SelectedData.Rep_Name = txtRecruiterName.Text;
            _SelectedData.Manager_Id = txtManagerID.Text;
            _SelectedData.Manager_Name = txtManagerName.Text;
            _SelectedData.Nama_Peserta = txtNamaPeserta.Text;
            _SelectedData.Alamat = txtAlamatPeserta.Text;
            _SelectedData.Kota_Domisili = txtKotaDomisili.Text;
            _SelectedData.Kode_Pos = txtKodePos.Text;
            _SelectedData.Identitas_Oct = txtIdentity.Text;
            if (cmbStatusPernikahan.SelectedValue != null)
            {
                _SelectedData.Status_Pernikahan = cmbStatusPernikahan.SelectedValue.ToString();
            }

            _SelectedData.Branch_Id = cmbCabang.SelectedValue.ToString();
            _SelectedData.Agama = cmbAgama.SelectedValue.ToString();
            _SelectedData.Jenis_Kelamin = cmbJenisKelamin.SelectedValue.ToString();
            _SelectedData.Lulus = cmbStatusOCT.SelectedValue.ToString();
            _SelectedData.Oct_Type = cmbOctType.SelectedValue.ToString();

            _SelectedData.Telp_Peserta = txtTelpRumah.Text;
            _SelectedData.Oct_Hanphone_Peserta = txtNoHp.Text;
            _SelectedData.Tempat_Lahir = txtTempatLahir.Text;
            _SelectedData.Tanggal_Lahir = txtTglLahir.Value;
            _SelectedData.Keterangan = txtKeterangOCT.Text;
            _SelectedData.Trainer = txtTrainer.Text;
            _SelectedData.Principal = Helper.CastToString(cmbPrincipal.SelectedValue);

            if (cmbStatusBOP.SelectedValue != null)
            {
                _SelectedData.Tgl_Bop = txtTglBOP.Value;
                _SelectedData.Lulus_Bop = cmbStatusBOP.SelectedValue.ToString();
            }

            if(cmbStatusPPQ.SelectedValue != null)
            {
                _SelectedData.Tgl_Ppq = txtTglPPQ.Value;
                _SelectedData.Lulus_Ppq = cmbStatusPPQ.SelectedValue.ToString();
            }

            if(cmbStatusInterview.SelectedValue != null)
            {
                _SelectedData.Lulus_Intervw = cmbStatusInterview.SelectedValue.ToString();
                _SelectedData.Tgl_Intervw = txtTglInterview.Value;
                _SelectedData.Intervw_By = txtInterviewDgn.Text;
            }

            _SelectedData.Oct_Rep_Id = txtKodeBA.Text;
            return Accessor.Put(_RoIdSelected, _SelectedData);
        }

        private Boolean Delete(int ro_id)
        {
            return Accessor.Delete(ro_id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _SelectedData = Accessor.Find(_RoIdSelected);
            if (_SelectedData == null)
            {
                MessageBox.Show("Data is not selected");
                return;
            }

            SetState(EnumState.Delete);
            showFormCreate();

            //header
            txtTglOct.Value = _SelectedData.Tgl_Oct.HasValue ? Convert.ToDateTime(_SelectedData.Tgl_Oct) : DateTime.FromOADate(0);
            txtDivisionID.Text = _SelectedData.Division_Id;

            //recruiter
            txtRecruiterID.Text = _SelectedData.Rep_Id;
            txtRecruiterName.Text = _SelectedData.Rep_Name;
            txtManagerID.Text = _SelectedData.Manager_Id;
            txtManagerName.Text = _SelectedData.Manager_Name;

            //peserta
            txtNamaPeserta.Text = _SelectedData.Nama_Peserta;
            txtAlamatPeserta.Text = _SelectedData.Alamat;
            txtKotaDomisili.Text = _SelectedData.Kota_Domisili;
            txtKodePos.Text = _SelectedData.Kode_Pos;
            txtIdentity.Text = _SelectedData.Identitas_Oct;
            txtTelpRumah.Text = _SelectedData.Telp_Peserta;
            txtNoHp.Text = _SelectedData.Oct_Hanphone_Peserta;
            txtTempatLahir.Text = _SelectedData.Tempat_Lahir;
            txtTglLahir.Value = _SelectedData.Tanggal_Lahir.HasValue ? Convert.ToDateTime(_SelectedData.Tanggal_Lahir) : DateTime.FromOADate(0);

            //oct
            txtKeterangOCT.Text = _SelectedData.Keterangan;
            txtTrainer.Text = _SelectedData.Trainer;

            //bop
            txtTglBOP.Value = _SelectedData.Tgl_Bop.HasValue ? Convert.ToDateTime(_SelectedData.Tgl_Bop) : DateTime.FromOADate(0);
            txtTglPPQ.Value = _SelectedData.Tgl_Ppq.HasValue ? Convert.ToDateTime(_SelectedData.Tgl_Ppq) : DateTime.FromOADate(0);

            //interview 
            txtTglInterview.Value = _SelectedData.Tgl_Intervw.HasValue ? Convert.ToDateTime(_SelectedData.Tgl_Intervw) : DateTime.FromOADate(0);
            txtInterviewDgn.Text = _SelectedData.Intervw_By;
            txtKodeBA.Text = _SelectedData.Oct_Rep_Id;

            if (_SelectedData.Principal != null)
            {
                cmbPrincipal.SelectedValue = _SelectedData.Principal;
            }

            if (_SelectedData.Agama != null)
            {
                cmbAgama.SelectedValue = _SelectedData.Agama;
            }

            if (_SelectedData.Branch_Id != null)
            {
                cmbCabang.SelectedValue = _SelectedData.Branch_Id;
            }

            if (_SelectedData.Jenis_Kelamin != null)
            {
                cmbJenisKelamin.SelectedValue = _SelectedData.Jenis_Kelamin;
            }

            if (_SelectedData.Lulus != null)
            {
                cmbStatusOCT.SelectedValue = _SelectedData.Lulus;
            }

            if (_SelectedData.Lulus_Bop != null)
            {
                cmbStatusBOP.SelectedValue = _SelectedData.Lulus_Bop;
            }

            if (_SelectedData.Lulus_Ppq != null)
            {
                cmbStatusPPQ.SelectedValue = _SelectedData.Lulus_Ppq;
            }

            if (_SelectedData.Lulus_Intervw != null)
            {
                cmbStatusInterview.SelectedValue = _SelectedData.Lulus_Intervw;
            }

            if (_SelectedData.Status_Pernikahan != null)
            {
                cmbStatusPernikahan.SelectedValue = _SelectedData.Status_Pernikahan;
            }

            if (_SelectedData.Oct_Type != null)
            {
                cmbOctType.SelectedValue = _SelectedData.Oct_Type;
            }
        }

        private void btnCreateSave_Click_1(object sender, EventArgs e)
        {
            if (_APPSTATE == (int)EnumState.Create)
            {
                bool info = CreateNew();
                if (info)
                {
                    Alert.PushAlert("Data saved", clsAlert.Type.Success);
                    btnList_Click(null, null);
                    btnSearch_Click(null, null);
                }
                else
                {
                    Alert.PushAlert("Save failed", clsAlert.Type.Error);
                }
                return;
            }

            if (_APPSTATE == (int)EnumState.Update)
            {
                bool info = Update();
                if (info)
                {
                    Alert.PushAlert("Update success", clsAlert.Type.Success);
                    btnList_Click(null, null);
                    btnSearch_Click(null, null);
                }
                else
                {
                    Alert.PushAlert("Update failed", clsAlert.Type.Error);
                }
                return;
            }
            
            if (_APPSTATE == (int)EnumState.Delete)
            {
                bool info = Delete(_SelectedData.Id);
                if (info)
                {
                    Alert.PushAlert("Delete success", clsAlert.Type.Success);
                    btnList_Click(null, null);
                    btnSearch_Click(null, null);
                    return;
                }
                else
                {
                    Alert.PushAlert("Delete failed", clsAlert.Type.Error);
                    return;
                }
            }

            Alert.PushAlert("Invalid APPSTATE. Current state : " + _APPSTATE, clsAlert.Type.Error);
        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back && txtFilterSearch.Text == string.Empty)
            {
                btnSearch_Click(null, null);
                return;
            }
        }

        private void txtFilterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
                return;
            }
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Master ODT";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            Type type = typeof(RCMasterODTBL);
            List<string> header = new List<string>();
            PropertyInfo[] properties = type.GetProperties();
            foreach(var property in properties)
            {
                header.Add(property.Name);
            }

            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (RCMasterODTBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                foreach (var property in properties)
                {
                    fileContent.Append("\"" + item.GetType().GetProperty(property.Name).GetValue(item) + "\",");
                }

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

        private void ButtonGenerateBA_Click(object sender, EventArgs e)
        {
            clsPopUpBA popup = new clsPopUpBA(Helper, Alert);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                txtManagerID.Text = popup.BaManagerId;
                txtManagerName.Text = popup.BamanagerName;
            }
        }

        private void bttnGenerateOCT_Click(object sender, EventArgs e)
        {
            clsPopUpOCT popup = new clsPopUpOCT(Helper, Alert);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                txtManagerID.Text = popup.OctManagerId;
                txtManagerName.Text = popup.OctmanagerName;
                txtRecruiterID.Text = popup.OctRecruiterId;
                txtRecruiterName.Text = popup.OctRecruiterName;
            }
        }
    }
}
