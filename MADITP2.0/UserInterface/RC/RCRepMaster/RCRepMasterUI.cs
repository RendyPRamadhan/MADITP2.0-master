using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.businessLogic.GS;
using MADITP2._0.businessLogic.RC;
using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.RC.RCRepMaster
{
    public partial class RCRepMasterUI : Form
    {
        private GSEntityAL EntityAccessor;
        private GSBranchAL BranchAccessor;
        private SOMasterDivisionDA DivisionAccessor;
        private RCRepMasterAL Accessor;
        private RCMasterLevelAL LevelAccessor;
        private RCCategoryEpcAL CategoryEpcAccessor;
        private RCMaritalStatusAL RCMaritalStatusAccessor;
        private RCTeamAL RCTeamAccessor;
        private RCLanguageCodeAL RCLanguageCodeAccessor;
        private RCEducationAL RCEducationAccessor;
        private RCReligionAL RCReligionAccessor;
        private SOMasterPrincipalDA PrincipalAccessor;
        private RCRepTypeAL RCRepTypeAccessor;
        private GSMasterZipCodesAL ZipCodesAccessor;
        private GSMasterCityAL MasterCityAccessor;
        private RCRelativeAL RelativeAccessor;
        private clsGlobal Helper;
        private clsAlert Alert;

        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private string _RepID;
        private RCRepMasterBL _SelectedData;
        private int _CityID;
        private RCRelativeBL _Relative;

        public RCRepMasterUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            EntityAccessor = new GSEntityAL(Helper);
            BranchAccessor = new GSBranchAL(Helper);
            DivisionAccessor = new SOMasterDivisionDA();
            Accessor = new RCRepMasterAL(Helper, Alert);
            LevelAccessor = new RCMasterLevelAL(Helper);
            CategoryEpcAccessor = new RCCategoryEpcAL(Helper);
            RCMaritalStatusAccessor = new RCMaritalStatusAL(Helper);
            RCTeamAccessor = new RCTeamAL(Helper);
            RCLanguageCodeAccessor = new RCLanguageCodeAL(Helper);
            RCEducationAccessor = new RCEducationAL(Helper);
            RCReligionAccessor = new RCReligionAL(Helper);
            PrincipalAccessor = new SOMasterPrincipalDA();
            RCRepTypeAccessor = new RCRepTypeAL(Helper);
            ZipCodesAccessor = new GSMasterZipCodesAL(Helper);
            MasterCityAccessor = new GSMasterCityAL(Helper);
            RelativeAccessor = new RCRelativeAL(Helper);

            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            InitializeComponent();
        }

        private void RCRepMasterUI_Load(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
            DrawComboboxes();
            DrawTeamCombobo();
            DrawReligionCombobo();
            DrawEdutcationCombobo();
            DrawLangCodeCombobo();
            DrawComboboxPrincipal();
            DrawKelurahanCombobox();

            DrawDatatable();
        }

        private void DrawKelurahanCombobox() {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            List<string> Items = ZipCodesAccessor.GetListKelurahan(_CityID);
            int index = 0;
            Items.ForEach(delegate (string Item) {
                ds.Insert(index, new ComboBoxViewModel()
                {
                    ValueMember = Helper.CastToString(Item),
                    DisplayMember = Helper.CastToString(Item)
                });
            });

            cmbSubDistrict.DataSource = ds;
            cmbSubDistrict.ValueMember = "ValueMember";
            cmbSubDistrict.DisplayMember = "DisplayMember";
        }

        private void DrawComboboxPrincipal()
        {
            var dtPrincipal = PrincipalAccessor.Read(EnumFilter.GET_ALL, null);
            var ds = new List<ComboBoxViewModel>();

            int index = 0;
            foreach(DataRow row in dtPrincipal.Rows)
            {
                ds.Insert(index, new ComboBoxViewModel() {
                    ValueMember = Helper.CastToString(row["smp_name"]),
                    DisplayMember = Helper.CastToString(row["smp_name"])
                });
                index++;
            }

            cmbPrincipal.DataSource = ds;
            cmbPrincipal.ValueMember = "ValueMember";
            cmbPrincipal.DisplayMember = "DisplayMember";
        }

        private void DrawDatatable()
        {
            string search = Helper.CastToString(txtFilterSearch.Text) != "" ? Helper.CastToString(txtFilterSearch.Text) : "";
            string entityId = Helper.CastToString(cmbFilterEntity.SelectedValue) != "" ? Helper.CastToString(cmbFilterEntity.SelectedValue) : "";
            string branchId = Helper.CastToString(cmbFilterBranch.SelectedValue) != "" ? Helper.CastToString(cmbFilterBranch.SelectedValue) : "";
            string divisionId = Helper.CastToString(cmbFilterDivision.SelectedValue) != "" ? Helper.CastToString(cmbFilterDivision.SelectedValue) : "";
            string gender = Helper.CastToString(cmbFilterGender.SelectedValue) != "" ? Helper.CastToString(cmbFilterGender.SelectedValue) : "";
            string activeFlag = Helper.CastToString(cmbFilterStatusActive.SelectedValue) != "" ? Helper.CastToString(cmbFilterStatusActive.SelectedValue) : "";
            string recruiterId = Helper.CastToString(txtFilterRecruiterID.Text) != "" ? Helper.CastToString(txtFilterRecruiterID.Text) : "";
            string managerId = Helper.CastToString(txtFilterManagerID.Text) != "" ? Helper.CastToString(txtFilterManagerID.Text) : "";
            string repLevel = Helper.CastToString(cmbFilterLevelPosition.SelectedValue) != "" ? Helper.CastToString(cmbFilterLevelPosition.SelectedValue) : "";
            int? MaritalStatus = cmbFilterMaritalStatus.SelectedIndex > 0 ? (int?)Helper.CastToInt(cmbFilterMaritalStatus.SelectedValue) : null;

            DateTime? StartDate = null;
            DateTime? EndDate = null;
            if (chkUseJoinDate.Checked)
            {
                StartDate = dtStartJoinDate.Value;
                EndDate = dtEndJoinDate.Value;
            }

            List<RCRepMasterBL> source = Accessor.AdvanceShowList(
                _CurrentPage,
                _FetchLimit,
                search,
                repLevel,
                recruiterId,
                managerId,
                entityId,
                branchId,
                divisionId,
                gender,
                activeFlag,
                MaritalStatus,
                StartDate,
                EndDate);

            dgvResult.AutoGenerateColumns = false;
            dgvResult.DataSource = source;

            int rows = Accessor.CountRows(
                search,
                repLevel,
                recruiterId,
                managerId,
                entityId,
                branchId,
                divisionId,
                gender,
                activeFlag, 
                MaritalStatus);

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

        private void DrawFilterLevel()
        {
            string Division = Helper.CastToString(cmbFilterDivision.SelectedValue);
            DataTable Levels = LevelAccessor.GetLevelsByDivision(Division);
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            ds.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "" });

            if (!string.IsNullOrEmpty(Division))
            {
                int index = 1;
                foreach (DataRow row in Levels.Rows)
                {
                    ds.Insert(index,
                        new ComboBoxViewModel()
                        {
                            DisplayMember = $"({Helper.CastToString(row["lc_level_id"])}) {Helper.CastToString(row["lc_level_description"])}",
                            ValueMember = $"{Helper.CastToString(row["lc_level_id"])}"
                        });
                    index++;
                }
            }

            cmbFilterLevelPosition.DataSource = ds;
            cmbFilterLevelPosition.DisplayMember = "DisplayMember";
            cmbFilterLevelPosition.ValueMember = "ValueMember";
        }

        private void DrawComboboxes()
        {
            //branch
            cmbFilterBranch.DataSource = BranchAccessor.GetComboboxBranch(false);
            cmbFilterBranch.ValueMember = "ValueMember";
            cmbFilterBranch.DisplayMember = "DisplayMember";

            cmbBranchID.DataSource = BranchAccessor.GetComboboxBranch(false);
            cmbBranchID.ValueMember = "ValueMember";
            cmbBranchID.DisplayMember = "DisplayMember";

            //entity
            cmbFilterEntity.DataSource = EntityAccessor.GetComboboxEntity(false);
            cmbFilterEntity.ValueMember = "ValueMember";
            cmbFilterEntity.DisplayMember = "DisplayMember";

            cmbEntityID.DataSource = EntityAccessor.GetComboboxEntity(false);
            cmbEntityID.ValueMember = "ValueMember";
            cmbEntityID.DisplayMember = "DisplayMember";

            //division
            cmbFilterDivision.DataSource = DivisionAccessor.GetComboboxDivision(false);
            cmbFilterDivision.ValueMember = "ValueMember";
            cmbFilterDivision.DisplayMember = "DisplayMember";

            cmbDivisionID.DataSource = DivisionAccessor.GetComboboxDivision(false);
            cmbDivisionID.ValueMember = "ValueMember";
            cmbDivisionID.DisplayMember = "DisplayMember";

            //marital status 
            var maritalStatusSource = new List<ComboBoxViewModel>();
            maritalStatusSource.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "" });
            List<RCMaritalStatusBL> maritals = RCMaritalStatusAccessor.GetAll();
            int index = 1;
            maritals.ForEach(delegate (RCMaritalStatusBL marital) {
                maritalStatusSource.Insert(index, new ComboBoxViewModel() { DisplayMember = marital.Marital_status, ValueMember = Helper.CastToString(marital.Id) });
                index++;
            });
            cmbFilterMaritalStatus.DataSource = maritalStatusSource;
            cmbFilterMaritalStatus.ValueMember = "ValueMember";
            cmbFilterMaritalStatus.DisplayMember = "DisplayMember";

            index = 0;
            maritalStatusSource = new List<ComboBoxViewModel>();
            maritals.ForEach(delegate (RCMaritalStatusBL marital) {
                maritalStatusSource.Insert(index, new ComboBoxViewModel() { DisplayMember = marital.Marital_status, ValueMember = Helper.CastToString(marital.Id) });
                index++;
            });
            cmbMaritalStatus.DataSource = maritalStatusSource;
            cmbMaritalStatus.ValueMember = "ValueMember";
            cmbMaritalStatus.DisplayMember = "DisplayMember";

            //status active
            var sourceStatusActive = new List<ComboBoxViewModel>();
            sourceStatusActive.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "" });
            sourceStatusActive.Insert(1, new ComboBoxViewModel() { DisplayMember = "Active", ValueMember = "A" });
            sourceStatusActive.Insert(2, new ComboBoxViewModel() { DisplayMember = "Inactive", ValueMember = "X" });
            cmbFilterStatusActive.DataSource = sourceStatusActive;
            cmbFilterStatusActive.ValueMember = "ValueMember";
            cmbFilterStatusActive.DisplayMember = "DisplayMember";

            sourceStatusActive = new List<ComboBoxViewModel>();
            sourceStatusActive.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "" });
            sourceStatusActive.Insert(1, new ComboBoxViewModel() { DisplayMember = "Active", ValueMember = "A" });
            sourceStatusActive.Insert(2, new ComboBoxViewModel() { DisplayMember = "Inactive", ValueMember = "X" });
            cmbStatusActive.DataSource = sourceStatusActive;
            cmbStatusActive.ValueMember = "ValueMember";
            cmbStatusActive.DisplayMember = "DisplayMember";

            // gender
            var sourceGender = new List<ComboBoxViewModel>();
            sourceGender.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "" });
            sourceGender.Insert(1, new ComboBoxViewModel() { DisplayMember = "Laki-laki", ValueMember = "M" });
            sourceGender.Insert(2, new ComboBoxViewModel() { DisplayMember = "Perempuan", ValueMember = "F" });
            cmbFilterGender.DataSource = sourceGender;
            cmbFilterGender.ValueMember = "ValueMember";
            cmbFilterGender.DisplayMember = "DisplayMember";

            sourceGender = new List<ComboBoxViewModel>();
            sourceGender.Insert(0, new ComboBoxViewModel() { DisplayMember = "Laki-laki", ValueMember = "M" });
            sourceGender.Insert(1, new ComboBoxViewModel() { DisplayMember = "Perempuan", ValueMember = "F" });
            cmbGender.DataSource = sourceGender;
            cmbGender.ValueMember = "ValueMember";
            cmbGender.DisplayMember = "DisplayMember";

            //graduate flag            
            var GraduateFlag = new List<ComboBoxViewModel>();
            GraduateFlag.Insert(0, new ComboBoxViewModel() { DisplayMember = "Yes", ValueMember = "Y" });
            GraduateFlag.Insert(1, new ComboBoxViewModel() { DisplayMember = "No", ValueMember = "N" });
            cmbGraduate.DataSource = GraduateFlag;
            cmbGraduate.ValueMember = "ValueMember";
            cmbGraduate.DisplayMember = "DisplayMember";

            // cwh
            var cwhSource = new List<ComboBoxViewModel>();
            cwhSource.Insert(0, new ComboBoxViewModel() { DisplayMember = "Yes", ValueMember = "Y" });
            cwhSource.Insert(1, new ComboBoxViewModel() { DisplayMember = "No", ValueMember = "N" });
            cmbCwhDeducted.DataSource = cwhSource;
            cmbCwhDeducted.ValueMember = "ValueMember";
            cmbCwhDeducted.DisplayMember = "DisplayMember";

            //postition
            var categorySource = new List<ComboBoxViewModel>();
            var epcCategory = CategoryEpcAccessor.GetAll();
            int i = 0;
            epcCategory.ForEach(delegate (RCCategoryEpcBL category)
            {
                categorySource.Insert(i, new ComboBoxViewModel() {
                    DisplayMember = category.Description,
                    ValueMember = Helper.CastToString(category.Description)
                });
                i++;
            });
            CmbPosition.DataSource = categorySource;
            CmbPosition.ValueMember = "ValueMember";
            CmbPosition.DisplayMember = "DisplayMember";

        }

        private void DrawTeamCombobo() {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            var teams = RCTeamAccessor.GetAll();
            int index = 0;
            teams.ForEach(delegate(RCTeamBL team) {
                ds.Insert(index, new ComboBoxViewModel() {
                    ValueMember= team.Id.Trim(),
                    DisplayMember= team.Description.Trim()
                });

                index++;
            });

            cmbTeam.DataSource = ds;
            cmbTeam.ValueMember = "ValueMember";
            cmbTeam.DisplayMember = "DisplayMember";
        }
        
        private void DrawReligionCombobo() {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            var religions = RCReligionAccessor.GetAll();
            int index = 0;
            religions.ForEach(delegate(RCReligionBL Religion) {
                ds.Insert(index, new ComboBoxViewModel() {
                    ValueMember= Helper.CastToString(Religion.Id),
                    DisplayMember= Religion.Religion.Trim()
                });

                index++;
            });

            cmbReligion.DataSource = ds;
            cmbReligion.ValueMember = "ValueMember";
            cmbReligion.DisplayMember = "DisplayMember";
        }
        
        private void DrawLangCodeCombobo() {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
            List<ComboBoxViewModel> ds2 = new List<ComboBoxViewModel>();
            List<ComboBoxViewModel> ds3 = new List<ComboBoxViewModel>();
             var Langs = RCLanguageCodeAccessor.GetAll();
            int index = 0;
            Langs.ForEach(delegate(RCLanguageCodeBL Lang) {
                ds.Insert(index, new ComboBoxViewModel() {
                    ValueMember= Helper.CastToString(Lang.Id),
                    DisplayMember= Lang.Language.Trim()
                });

                ds2.Insert(index, new ComboBoxViewModel() {
                    ValueMember= Helper.CastToString(Lang.Id),
                    DisplayMember= Lang.Language.Trim()
                });

                ds3.Insert(index, new ComboBoxViewModel() {
                    ValueMember= Helper.CastToString(Lang.Id),
                    DisplayMember= Lang.Language.Trim()
                });

                index++;
            });

            cmbLang1.DataSource = ds;
            cmbLang1.ValueMember = "ValueMember";
            cmbLang1.DisplayMember = "DisplayMember";
            
            cmbLang2.DataSource = ds2;
            cmbLang2.ValueMember = "ValueMember";
            cmbLang2.DisplayMember = "DisplayMember";
            
            cmbLang3.DataSource = ds3;
            cmbLang3.ValueMember = "ValueMember";
            cmbLang3.DisplayMember = "DisplayMember";
        }

        private void DrawEdutcationCombobo() {
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();
             var Educs = RCEducationAccessor.GetAll();
            int index = 0;
            Educs.ForEach(delegate(RCEducationBL Education) {
                ds.Insert(index, new ComboBoxViewModel() {
                    ValueMember= Helper.CastToString(Education.Id),
                    DisplayMember= Education.Education_name.Trim()
                });

                index++;
            });

            cmbLastFormalEdu.DataSource = ds;
            cmbLastFormalEdu.ValueMember = "ValueMember";
            cmbLastFormalEdu.DisplayMember = "DisplayMember";
        }

        private void DrawLevel() 
        {
            string Division = Helper.CastToString(cmbDivisionID.SelectedValue);
            DataTable Levels = LevelAccessor.GetLevelsByDivision(Division);
            List<ComboBoxViewModel> ds = new List<ComboBoxViewModel>();

            if (!string.IsNullOrEmpty(Division))
            {
                int index = 0;
                foreach (DataRow row in Levels.Rows)
                {
                    ds.Insert(index,
                        new ComboBoxViewModel()
                        {
                            DisplayMember = $"({Helper.CastToString(row["lc_level_id"])}) {Helper.CastToString(row["lc_level_description"])}",
                            ValueMember = $"{Helper.CastToString(row["lc_level_id"])}"
                        });
                    index++;
                }
            }

            cmbLevelPostion.DataSource = ds;
            cmbLevelPostion.DisplayMember = "DisplayMember";
            cmbLevelPostion.ValueMember = "ValueMember";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
            Pagination(true);
            DrawDatatable();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_RepID))
            {
                Alert.PushAlert("Click data from the table.", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.Find(_RepID);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Not found!", clsAlert.Type.Warning);
                return;
            }

            prepareFormControl(_SelectedData);
            SetState(EnumState.Update);
            PanelFormCreate.BringToFront();
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _RepID = Helper.CastToString(dgvResult.Rows[e.RowIndex].Cells["repId"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_RepID))
            {
                Alert.PushAlert("Click data from the table.", clsAlert.Type.Warning);
                return;
            }

            _SelectedData = Accessor.Find(_RepID);
            if (_SelectedData == null)
            {
                Alert.PushAlert("Not found!", clsAlert.Type.Warning);
                return;
            }

            prepareFormControl(_SelectedData);
            SetState(EnumState.Delete);
            PanelFormCreate.BringToFront();
        }

        void SetState(EnumState enumState)
        {
            _APPSTATE = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    txtRepId.Enabled = true;
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    txtRepId.Enabled = false;
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    txtRepId.Enabled = false;
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
            Helper.ResetAllFormControls(tabPage1);
            Helper.ResetAllFormControls(tabPage2);
            Helper.ResetAllFormControls(tabPage3);
            Helper.ResetAllFormControls(tabPage4);
            Helper.ResetAllFormControls(tiraGroupBox3);
            Helper.ResetAllFormControls(tiraGroupBox4);

            List<RCRelativeChildBL> childs = new List<RCRelativeChildBL>();
            childs.Add(new RCRelativeChildBL()
            {
                ChildName = string.Empty,
                ChildBirthDate = null,
                ChildSchoolName = string.Empty,
                ChildSchoolAddress = string.Empty,
            });
            childs.Add(new RCRelativeChildBL()
            {
                ChildName = string.Empty,
                ChildBirthDate = null,
                ChildSchoolName = string.Empty,
                ChildSchoolAddress = string.Empty,
            });
            childs.Add(new RCRelativeChildBL()
            {
                ChildName = string.Empty,
                ChildBirthDate = null,
                ChildSchoolName = string.Empty,
                ChildSchoolAddress = string.Empty,
            });
            dgvRelative.DataSource = childs;

            PanelFormCreate.BringToFront();
        }

        private void cmbFilterDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawFilterLevel();
        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilterSearch.Text))
            {
                btnSearch_Click(null, null);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(_APPSTATE == EnumState.Create)
            {
                HandleCreate();
                btnSearch_Click(null, null);
                return;
            }
            
            if(_APPSTATE == EnumState.Update)
            {
                HandleUpdate();
                btnSearch_Click(null, null);
                return;
            }
            
            if(_APPSTATE == EnumState.Delete)
            {
                HandleDelete();
                btnSearch_Click(null, null);
                return;
            }

            Alert.PushAlert("Invalid _APPSTATE", clsAlert.Type.Error);
        }

        private void HandleCreate()
        {
            _SelectedData = new RCRepMasterBL();
            _SelectedData.Entity_id = Helper.CastToString(cmbEntityID.SelectedValue);
            _SelectedData.repId = Helper.CastToString(txtRepId.Text);
            _SelectedData.branch = Helper.CastToString(cmbBranchID.SelectedValue);
            _SelectedData.Status_position = Helper.CastToString(CmbPosition.SelectedValue);
            _SelectedData.Division_id = Helper.CastToString(cmbDivisionID.SelectedValue);
            _SelectedData.Current_position = Helper.CastToString(cmbLevelPostion.SelectedValue);
            _SelectedData.name = Helper.CastToString(txtName.Text);
            _SelectedData.recruiterId = Helper.CastToString(txtRecruiterID.Text);
            _SelectedData.managerId = Helper.CastToString(txtManagerID.Text);
            _SelectedData.managerName = Helper.CastToString(txtManagerName.Text);
            _SelectedData.joinDate = (DateTime) Helper.CastToDatetime(dtJoinDate.Value);
            _SelectedData.OCT_ID = Helper.CastToString(txtOCTID.Text);
            _SelectedData.Status = Helper.CastToString(cmbStatusActive.SelectedValue);
            _SelectedData.Principal = Helper.CastToString(cmbPrincipal.SelectedValue);
            _SelectedData.Team = Helper.CastToString(cmbTeam.SelectedValue);
            _SelectedData.Short_name = Helper.CastToString(txtShortName.Text);

            ///PRESONAL TAB
            _SelectedData.Identity_no = Helper.CastToString(txtNoKtp.Text);
            _SelectedData.Kecamatan = Helper.CastToString(txtDitrict.Text);
            _SelectedData.Mobile_phone = Helper.CastToString(txtMobilePhone.Text);
            _SelectedData.Sex = Helper.CastToString(cmbGender.SelectedValue);
            _SelectedData.City = Helper.CastToString(txtCity.Text);
            _SelectedData.Phone_home = Helper.CastToString(txtHomePhone.Text);
            _SelectedData.Birth_date = (DateTime) Helper.CastToDatetime(dtBrithDate.Value);
            _SelectedData.Province = Helper.CastToString(txtProvince.Text); 
            _SelectedData.No_wa = Helper.CastToString(txtNoWA.Text);
            _SelectedData.Religion_id = Helper.CastToInt(cmbReligion.SelectedValue);
            _SelectedData.Rt = Helper.CastToString(txtRT.Text);
            _SelectedData.Rw = Helper.CastToString(txtRW.Text);
            _SelectedData.Email_address = Helper.CastToString(txtEmail.Text);
            _SelectedData.Zipcode = Helper.CastToString(txtZipCode.Text);
            _SelectedData.Home_address_1 = Helper.CastToString(txtHomeAddress1.Text);
            _SelectedData.Home_address_2 = Helper.CastToString(txtHomeAddress2.Text);
            _SelectedData.Home_address_3 = Helper.CastToString(txtHomeAddress3.Text);
            _SelectedData.Citizenship = Helper.CastToString(txtCitzenShip.Text);
            _SelectedData.Kelurahan = Helper.CastToString(cmbSubDistrict.SelectedValue);

            //OFFICE TAB
            _SelectedData.Company_name = Helper.CastToString(txtCompanyName.Text);
            _SelectedData.Company_address_1 = Helper.CastToString(txtCompanyAddress1.Text);
            _SelectedData.Company_address_2 = Helper.CastToString(txtCompanyAddress2.Text);
            _SelectedData.Company_address_3 = Helper.CastToString(txtCompanyAddress3.Text);
            _SelectedData.Company_phone = Helper.CastToString(txtCompanyPhone.Text);
            _SelectedData.Last_position = Helper.CastToString(txtCompanyLastPosition.Text);

            //ACCOUNT
            _SelectedData.accountNumber = Helper.CastToString(txtAccountNo.Text);
            _SelectedData.accountName = Helper.CastToString(txtAccountName.Text);
            _SelectedData.Bank = Helper.CastToString(txtBankName.Text);
            _SelectedData.bankId = Helper.CastToString(txtBankDescription.Text);
            _SelectedData.npwpNumber = Helper.CastToString(txtNpwpNo.Text);
            _SelectedData.npwpName = Helper.CastToString(txtNpwpName.Text);
            _SelectedData.Cmp_num = Helper.CastToString(txtCmpKpNumber.Text);
            _SelectedData.Cwh_deducted = Helper.CastToString(cmbCwhDeducted.SelectedValue);

            //RELATIVE
            if (chkMariage.Checked)
            {
                _SelectedData.Maried_date = dtMariedDate.Value;
            }
            else
            {
                _SelectedData.Maried_date = null;
            }

            _Relative = new RCRelativeBL();
            _Relative.Rep_Id = _SelectedData.repId;
            _Relative.Rel_Name = Helper.CastToString(txtRelativeName.Text);
            _Relative.Phone_Num = Helper.CastToString(txtRelativePhone.Text);
            _Relative.City = Helper.CastToString(txtRelativeCity.Text);
            _Relative.Sta = Helper.CastToString(txtRelativeStatus.Text);
            _Relative.Addr_1 = Helper.CastToString(txtRelativeAddress1.Text);
            _Relative.Addr_2 = Helper.CastToString(txtRelativeAddress2.Text);
            _Relative.Addr_3 = Helper.CastToString(txtRelativeAddress3.Text);

            _Relative.Child_1_Name = Helper.CastToString(dgvRelative.Rows[0].Cells[0].Value);
            _Relative.Dt_Of_Birth1 = (dgvRelative.Rows[0].Cells[1].Value == null) ? null : Helper.CastToDatetime(dgvRelative.Rows[0].Cells[1].Value.ToString());
            _Relative.School_Child1 = Helper.CastToString(dgvRelative.Rows[0].Cells[2].Value);
            _Relative.School_Add_Child1 = Helper.CastToString(dgvRelative.Rows[0].Cells[3].Value);

            _Relative.Child_2_Name = Helper.CastToString(dgvRelative.Rows[1].Cells[0].Value);
            _Relative.Dt_Of_Birth2 = (dgvRelative.Rows[1].Cells[1].Value == null) ? null : Helper.CastToDatetime(dgvRelative.Rows[1].Cells[1].Value.ToString());
            _Relative.School_Child2 = Helper.CastToString(dgvRelative.Rows[1].Cells[2].Value);
            _Relative.School_Add_Child2 = Helper.CastToString(dgvRelative.Rows[1].Cells[3].Value);

            _Relative.Child_3_Name = Helper.CastToString(dgvRelative.Rows[2].Cells[0].Value);
            _Relative.Dt_Of_Birth3 = (dgvRelative.Rows[2].Cells[1].Value == null) ? null : Helper.CastToDatetime(dgvRelative.Rows[2].Cells[1].Value.ToString());
            _Relative.School_Child3 = Helper.CastToString(dgvRelative.Rows[2].Cells[2].Value);
            _Relative.School_Add_Child3 = Helper.CastToString(dgvRelative.Rows[2].Cells[3].Value);

            //EDUCATION
            _SelectedData.Last_formal_education = Helper.CastToInt(cmbLastFormalEdu.SelectedValue);
            _SelectedData.Graduated_flag = Helper.CastToString(cmbGraduate.SelectedValue);
            _SelectedData.Year_graduated = Helper.CastToString(txtYearOfGraduate.Text);
            _SelectedData.Language_1 = Helper.CastToInt(cmbLang1.SelectedValue);
            _SelectedData.Language_2 = Helper.CastToInt(cmbLang2.SelectedValue);
            _SelectedData.Language_3 = Helper.CastToInt(cmbLang3.SelectedValue);

            bool Info = Accessor.Post(_SelectedData, _Relative);
            if (!Info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Success!", clsAlert.Type.Success);
            navView_Click(null, null);
        }

        private void HandleUpdate()
        {
            _SelectedData.Entity_id = Helper.CastToString(cmbEntityID.SelectedValue);
            _SelectedData.repId = Helper.CastToString(txtRepId.Text);
            _SelectedData.branch = Helper.CastToString(cmbBranchID.SelectedValue);

            _SelectedData.Status_position = Helper.CastToString(CmbPosition.SelectedValue);
            _SelectedData.Division_id = Helper.CastToString(cmbDivisionID.SelectedValue);
            _SelectedData.Current_position = Helper.CastToString(cmbLevelPostion.SelectedValue);

            _SelectedData.name = Helper.CastToString(txtName.Text);
            _SelectedData.recruiterId = Helper.CastToString(txtRecruiterID.Text);
            _SelectedData.managerId = Helper.CastToString(txtManagerID.Text);
            _SelectedData.managerName = Helper.CastToString(txtManagerName.Text);
            _SelectedData.joinDate = (DateTime)Helper.CastToDatetime(dtJoinDate.Value);
            _SelectedData.OCT_ID = Helper.CastToString(txtOCTID.Text);
            _SelectedData.Status = Helper.CastToString(cmbStatusActive.SelectedValue);
            _SelectedData.Principal = Helper.CastToString(cmbPrincipal.SelectedValue);
            _SelectedData.Team = Helper.CastToString(cmbTeam.SelectedValue);
            _SelectedData.Short_name = Helper.CastToString(txtShortName.Text);

            ///PRESONAL TAB
            _SelectedData.Identity_no = Helper.CastToString(txtNoKtp.Text);
            _SelectedData.Kecamatan = Helper.CastToString(txtDitrict.Text);
            _SelectedData.Mobile_phone = Helper.CastToString(txtMobilePhone.Text);
            _SelectedData.Sex = Helper.CastToString(cmbGender.SelectedValue);
            _SelectedData.City = Helper.CastToString(txtCity.Text);
            _SelectedData.Phone_home = Helper.CastToString(txtHomePhone.Text);
            _SelectedData.Birth_date = (DateTime)Helper.CastToDatetime(dtBrithDate.Value);
            _SelectedData.Province = Helper.CastToString(txtProvince.Text);
            _SelectedData.No_wa = Helper.CastToString(txtNoWA.Text);
            _SelectedData.Religion_id = Helper.CastToInt(cmbReligion.SelectedValue);
            _SelectedData.Rt = Helper.CastToString(txtRT.Text);
            _SelectedData.Rw = Helper.CastToString(txtRW.Text);
            _SelectedData.Email_address = Helper.CastToString(txtEmail.Text);
            _SelectedData.Zipcode = Helper.CastToString(txtZipCode.Text);
            _SelectedData.Home_address_1 = Helper.CastToString(txtHomeAddress1.Text);
            _SelectedData.Home_address_2 = Helper.CastToString(txtHomeAddress2.Text);
            _SelectedData.Home_address_3 = Helper.CastToString(txtHomeAddress3.Text);
            _SelectedData.Citizenship = Helper.CastToString(txtCitzenShip.Text);
            _SelectedData.Kelurahan = Helper.CastToString(cmbSubDistrict.SelectedValue);

            //OFFICE TAB
            _SelectedData.Company_name = Helper.CastToString(txtCompanyName.Text);
            _SelectedData.Company_address_1 = Helper.CastToString(txtCompanyAddress1.Text);
            _SelectedData.Company_address_2 = Helper.CastToString(txtCompanyAddress2.Text);
            _SelectedData.Company_address_3 = Helper.CastToString(txtCompanyAddress3.Text);
            _SelectedData.Company_phone = Helper.CastToString(txtCompanyPhone.Text);
            _SelectedData.Last_position = Helper.CastToString(txtCompanyLastPosition.Text);

            //ACCOUNT
            _SelectedData.accountNumber = Helper.CastToString(txtAccountNo.Text);
            _SelectedData.accountName = Helper.CastToString(txtAccountName.Text);
            _SelectedData.Bank = Helper.CastToString(txtBankName.Text);
            _SelectedData.bankId = Helper.CastToString(txtBankDescription.Text);
            _SelectedData.npwpNumber = Helper.CastToString(txtNpwpNo.Text);
            _SelectedData.npwpName = Helper.CastToString(txtNpwpName.Text);
            _SelectedData.Cmp_num = Helper.CastToString(txtCmpKpNumber.Text);
            _SelectedData.Cwh_deducted = Helper.CastToString(cmbCwhDeducted.SelectedValue);

            //RELATIVE
            if (chkMariage.Checked)
            {
                _SelectedData.Maried_date = dtMariedDate.Value;
            }
            else
            {
                _SelectedData.Maried_date = null;
            }

            if(_Relative == null)
            {
                _Relative = new RCRelativeBL();
                _Relative.Id = 0;
            }

            _Relative.Rep_Id = _SelectedData.repId;
            _Relative.Rel_Name = Helper.CastToString(txtRelativeName.Text);
            _Relative.Phone_Num = Helper.CastToString(txtRelativePhone.Text);
            _Relative.City = Helper.CastToString(txtRelativeCity.Text);
            _Relative.Sta = Helper.CastToString(txtRelativeStatus.Text);
            _Relative.Addr_1 = Helper.CastToString(txtRelativeAddress1.Text);
            _Relative.Addr_2 = Helper.CastToString(txtRelativeAddress2.Text);
            _Relative.Addr_3 = Helper.CastToString(txtRelativeAddress3.Text);

            _Relative.Child_1_Name = Helper.CastToString(dgvRelative.Rows[0].Cells[0].Value);
            _Relative.Dt_Of_Birth1 = (dgvRelative.Rows[0].Cells[1].Value == null) ? null : Helper.CastToDatetime(dgvRelative.Rows[0].Cells[1].Value.ToString());
            _Relative.School_Child1 = Helper.CastToString(dgvRelative.Rows[0].Cells[2].Value);
            _Relative.School_Add_Child1 = Helper.CastToString(dgvRelative.Rows[0].Cells[3].Value);

            _Relative.Child_2_Name = Helper.CastToString(dgvRelative.Rows[1].Cells[0].Value);
            _Relative.Dt_Of_Birth2 = (dgvRelative.Rows[1].Cells[1].Value == null) ? null : Helper.CastToDatetime(dgvRelative.Rows[1].Cells[1].Value.ToString());
            _Relative.School_Child2 = Helper.CastToString(dgvRelative.Rows[1].Cells[2].Value);
            _Relative.School_Add_Child2 = Helper.CastToString(dgvRelative.Rows[1].Cells[3].Value);

            _Relative.Child_3_Name = Helper.CastToString(dgvRelative.Rows[2].Cells[0].Value);
            _Relative.Dt_Of_Birth3 = (dgvRelative.Rows[2].Cells[1].Value == null) ? null : Helper.CastToDatetime(dgvRelative.Rows[2].Cells[1].Value.ToString());
            _Relative.School_Child3 = Helper.CastToString(dgvRelative.Rows[2].Cells[2].Value);
            _Relative.School_Add_Child3 = Helper.CastToString(dgvRelative.Rows[2].Cells[3].Value);

            //EDUCATION
            _SelectedData.Last_formal_education = Helper.CastToInt(cmbLastFormalEdu.SelectedValue);
            _SelectedData.Graduated_flag = Helper.CastToString(cmbGraduate.SelectedValue);
            _SelectedData.Year_graduated = Helper.CastToString(txtYearOfGraduate.Text);
            _SelectedData.Language_1 = Helper.CastToInt(cmbLang1.SelectedValue);
            _SelectedData.Language_2 = Helper.CastToInt(cmbLang2.SelectedValue);
            _SelectedData.Language_3 = Helper.CastToInt(cmbLang3.SelectedValue);

            bool Info = Accessor.Put(_RepID, _SelectedData, _Relative);
            if (!Info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Success!", clsAlert.Type.Success);
        }

        private void HandleDelete()
        {
            bool Info = Accessor.Delete(_RepID);
            if (!Info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Success!", clsAlert.Type.Success);
            navView_Click(null, null);
        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Rep Master";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "Rep ID",
                "Name",
                "Email",
                "Phone",
                "Recruiter ID",
                "Manager ID",
                "Manager Name",
                "Branch ID",
                "Division ID",
                "Entity ID",
                "Position",
                "Level",
                "Account Status",
                "Join Date",
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            string search = Helper.CastToString(txtFilterSearch.Text) != "" ? Helper.CastToString(txtFilterSearch.Text) : "";
            string entityId = Helper.CastToString(cmbFilterEntity.SelectedValue) != "" ? Helper.CastToString(cmbFilterEntity.SelectedValue) : "";
            string branchId = Helper.CastToString(cmbFilterBranch.SelectedValue) != "" ? Helper.CastToString(cmbFilterBranch.SelectedValue) : "";
            string divisionId = Helper.CastToString(cmbFilterDivision.SelectedValue) != "" ? Helper.CastToString(cmbFilterDivision.SelectedValue) : "";
            string gender = Helper.CastToString(cmbFilterGender.SelectedValue) != "" ? Helper.CastToString(cmbFilterGender.SelectedValue) : "";
            string activeFlag = Helper.CastToString(cmbFilterStatusActive.SelectedValue) != "" ? Helper.CastToString(cmbFilterStatusActive.SelectedValue) : "";
            string recruiterId = Helper.CastToString(txtFilterRecruiterID.Text) != "" ? Helper.CastToString(txtFilterRecruiterID.Text) : "";
            string managerId = Helper.CastToString(txtFilterManagerID.Text) != "" ? Helper.CastToString(txtFilterManagerID.Text) : "";
            string repLevel = Helper.CastToString(cmbFilterLevelPosition.SelectedValue) != "" ? Helper.CastToString(cmbFilterLevelPosition.SelectedValue) : "";
            int? MaritalStatus = cmbFilterMaritalStatus.SelectedIndex > 0 ? (int?)Helper.CastToInt(cmbFilterMaritalStatus.SelectedValue) : null;

            DateTime? StartDate = null;
            DateTime? EndDate = null;
            if (chkUseJoinDate.Checked)
            {
                StartDate = dtStartJoinDate.Value;
                EndDate = dtEndJoinDate.Value;
            }

            foreach (RCRepMasterBL item in Accessor.GetAll(search,repLevel,recruiterId,managerId,entityId,branchId,divisionId,gender,activeFlag,MaritalStatus,StartDate,EndDate))
            {
                fileContent.Append("\"" + item.repId + "\",");
                fileContent.Append("\"" + item.name + "\",");
                fileContent.Append("\"" + item.Email_address + "\",");
                fileContent.Append("\"" + item.Mobile_phone + "\",");
                fileContent.Append("\"" + item.recruiterId + "\",");
                fileContent.Append("\"" + item.managerId + "\",");
                fileContent.Append("\"" + item.managerName + "\",");
                fileContent.Append("\"" + item.branch + "\",");
                fileContent.Append("\"" + item.Division_id + "\",");
                fileContent.Append("\"" + item.Entity_id + "\",");
                fileContent.Append("\"" + item.Current_position + "\",");
                fileContent.Append("\"" + item.Status_position + "\",");
                fileContent.Append("\"" + item.Status + "\",");
                fileContent.Append("\"" + item.joinDate + "\",");

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);
            }

            System.IO.File.WriteAllText(saveFileDialog1.FileName, fileContent.ToString());
        }

        private void prepareFormControl(RCRepMasterBL item)
        {
            try
            {
                cmbEntityID.SelectedValue = Helper.CastToString(item.Entity_id);
                txtRepId.Text = Helper.CastToString(item.repId);
                cmbBranchID.SelectedValue = Helper.CastToString(item.branch);

                CmbPosition.SelectedValue = Helper.CastToString(item.Status_position);
                cmbDivisionID.SelectedValue = Helper.CastToString(item.Division_id);
                DrawLevel();
                cmbLevelPostion.SelectedValue = Helper.CastToString(item.Current_position);

                txtName.Text = Helper.CastToString(item.name);
                txtRecruiterID.Text = Helper.CastToString(item.recruiterId);
                txtRecruiterID_TextChanged(null, null);

                txtManagerID.Text = Helper.CastToString(item.managerId);
                txtManagerName.Text = Helper.CastToString(item.managerName);
                dtJoinDate.Value = (DateTime)item.joinDate;
                txtOCTID.Text = Helper.CastToString(item.OCT_ID);
                cmbStatusActive.SelectedValue = Helper.CastToString(item.Status);
                cmbPrincipal.SelectedValue = Helper.CastToString(item.Principal);
                cmbTeam.SelectedValue = Helper.CastToString(item.Team);
                txtShortName.Text = Helper.CastToString(item.Short_name);

                ///PRESONAL TAB
                txtNoKtp.Text = Helper.CastToString(item.Identity_no);
                txtDitrict.Text = Helper.CastToString(item.Kecamatan);
                txtMobilePhone.Text = Helper.CastToString(item.Mobile_phone);
                cmbGender.SelectedValue = Helper.CastToString(item.Sex);
                txtCity.Text = Helper.CastToString(item.City);
                txtHomePhone.Text = Helper.CastToString(item.Phone_home);
                dtBrithDate.Value = (DateTime)item.Birth_date;
                txtProvince.Text = Helper.CastToString(item.Province);
                txtNoWA.Text = Helper.CastToString(item.No_wa);
                cmbReligion.SelectedValue = Helper.CastToString(item.Religion_id);
                txtRT.Text = Helper.CastToString(item.Rt);
                txtRW.Text = Helper.CastToString(item.Rw);
                txtEmail.Text = Helper.CastToString(item.Email_address);
                txtZipCode.Text = Helper.CastToString(item.Zipcode);
                txtZipCode_KeyDown(null, null);

                txtHomeAddress1.Text = Helper.CastToString(item.Home_address_1);
                txtHomeAddress2.Text = Helper.CastToString(item.Home_address_2);
                txtHomeAddress3.Text = Helper.CastToString(item.Home_address_3);
                txtCitzenShip.Text = Helper.CastToString(item.Citizenship);
                cmbSubDistrict.SelectedValue = Helper.CastToString(item.Kelurahan);

                //OFFICE TAB
                txtCompanyName.Text = Helper.CastToString(item.Company_name);
                txtCompanyAddress1.Text = Helper.CastToString(item.Company_address_1);
                txtCompanyAddress2.Text = Helper.CastToString(item.Company_address_2);
                txtCompanyAddress3.Text = Helper.CastToString(item.Company_address_3);
                txtCompanyPhone.Text = Helper.CastToString(item.Company_phone);
                txtCompanyLastPosition.Text = Helper.CastToString(item.Last_position);

                //ACCOUNT
                txtAccountNo.Text = Helper.CastToString(item.accountNumber);
                txtAccountName.Text = Helper.CastToString(item.accountName);
                txtBankName.Text = Helper.CastToString(item.Bank);
                txtBankDescription.Text = Helper.CastToString(item.bankId);
                txtNpwpNo.Text = Helper.CastToString(item.npwpNumber);
                txtNpwpName.Text = Helper.CastToString(item.npwpName);
                txtCmpKpNumber.Text = Helper.CastToString(item.Cmp_num);
                cmbCwhDeducted.SelectedValue = Helper.CastToString(item.Cwh_deducted);

                //RELATIVE
                if(_SelectedData.Maried_date != null)
                {
                    chkMariage.Checked = true;
                    dtMariedDate.Value = (DateTime)_SelectedData.Maried_date;
                }
                else
                {
                    chkMariage.Checked = false;
                }

                _Relative = RelativeAccessor.FindByRepId(item.repId);
                if (_Relative != null)
                {
                    txtRelativeName.Text = Helper.CastToString(_Relative.Rel_Name);
                    txtRelativeStatus.Text = Helper.CastToString(_Relative.Sta);
                    txtRelativePhone.Text = Helper.CastToString(_Relative.Phone_Num);
                    txtRelativeAddress1.Text = Helper.CastToString(_Relative.Addr_1);
                    txtRelativeAddress2.Text = Helper.CastToString(_Relative.Addr_2);
                    txtRelativeAddress3.Text = Helper.CastToString(_Relative.Addr_3);
                    txtRelativeCity.Text = Helper.CastToString(_Relative.City);

                    List<RCRelativeChildBL> childs = new List<RCRelativeChildBL>();
                    childs.Add(new RCRelativeChildBL()
                    {
                        ChildName = Helper.CastToString(_Relative.Child_1_Name),
                        ChildBirthDate = Helper.CastToDatetime(_Relative.Dt_Of_Birth1),
                        ChildSchoolName = Helper.CastToString(_Relative.School_Child1),
                        ChildSchoolAddress = Helper.CastToString(_Relative.School_Add_Child1),
                    });
                    childs.Add(new RCRelativeChildBL()
                    {
                        ChildName = Helper.CastToString(_Relative.Child_2_Name),
                        ChildBirthDate = Helper.CastToDatetime(_Relative.Dt_Of_Birth2),
                        ChildSchoolName = Helper.CastToString(_Relative.School_Child2),
                        ChildSchoolAddress = Helper.CastToString(_Relative.School_Add_Child2),
                    });
                    childs.Add(new RCRelativeChildBL()
                    {
                        ChildName = Helper.CastToString(_Relative.Child_3_Name),
                        ChildBirthDate = Helper.CastToDatetime(_Relative.Dt_Of_Birth3),
                        ChildSchoolName = Helper.CastToString(_Relative.School_Child3),
                        ChildSchoolAddress = Helper.CastToString(_Relative.School_Add_Child3),
                    });

                    dgvRelative.DataSource = childs;
                }
                else
                {
                    List<RCRelativeChildBL> childs = new List<RCRelativeChildBL>();
                    childs.Add(new RCRelativeChildBL()
                    {
                        ChildName = string.Empty,
                        ChildBirthDate = null,
                        ChildSchoolName = string.Empty,
                        ChildSchoolAddress = string.Empty,
                    });
                    childs.Add(new RCRelativeChildBL()
                    {
                        ChildName = string.Empty,
                        ChildBirthDate = null,
                        ChildSchoolName = string.Empty,
                        ChildSchoolAddress = string.Empty,
                    });
                    childs.Add(new RCRelativeChildBL()
                    {
                        ChildName = string.Empty,
                        ChildBirthDate = null,
                        ChildSchoolName = string.Empty,
                        ChildSchoolAddress = string.Empty,
                    });

                    dgvRelative.DataSource = childs;
                }

                //EDUCATION
                cmbLastFormalEdu.SelectedValue = Helper.CastToString(item.Last_formal_education);
                cmbGraduate.SelectedValue = Helper.CastToString(item.Graduated_flag);
                txtYearOfGraduate.Text = Helper.CastToString(item.Year_graduated);
                cmbLang1.SelectedValue = Helper.CastToString(item.Language_1);
                cmbLang2.SelectedValue = Helper.CastToString(item.Language_2);
                cmbLang3.SelectedValue = Helper.CastToString(item.Language_3);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Alert.PushAlert(e.Message, clsAlert.Type.Warning);
            }
        }

        private void cmbDivisionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawLevel();
        }

        private void txtZipCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e is null || e.KeyCode == Keys.Enter)
            {
                _CityID = 0;
                GSMasterZipCodesBL zipcode = ZipCodesAccessor.GetByZipCode(Helper.CastToString(txtZipCode.Text));
                if (zipcode is null)
                {
                    Alert.PushAlert("Zip code not found", clsAlert.Type.Warning);
                    return;
                }

                if (zipcode.City != null)
                {
                    _CityID = (int)zipcode.City;

                    //update combo kelurahan
                    DrawKelurahanCombobox();
                    GSMasterCityBL City = MasterCityAccessor.GetCity(_CityID);
                    if (City != null)
                    {
                        txtCity.Text = City.City;
                        txtProvince.Text = City.Province;
                    }
                    else
                    {
                        Alert.PushAlert("Couldn't find city based on the given zip code!", clsAlert.Type.Warning);
                    }
                }

                txtDitrict.Text = zipcode.Kecamatan;
            }
        }

        private void txtRecruiterID_TextChanged(object sender, EventArgs e)
        {
            var Recruiter = Accessor.Find(txtRecruiterID.Text);
            if(Recruiter is null)
            {
                return;
            }

            txtRecruiterName.Text = Recruiter.name;
        }

        private void txtManagerID_TextChanged(object sender, EventArgs e)
        {
            var Manager = Accessor.Find(txtManagerID.Text);
            if (Manager is null)
            {
                return;
            }

            txtManagerName.Text = Manager.name;
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _RepID = Helper.CastToString(dgvResult.CurrentRow.Cells["repId"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
            }
        }

        private void btnOpenOctPopup_Click(object sender, EventArgs e)
        {
            clsPopUpMasterOdt popup = new clsPopUpMasterOdt(Helper, Alert);
            if(popup.ShowDialog() == DialogResult.OK)
            {
                txtOCTID.Text = popup.OctID;
                txtName.Text = popup.OctNamaPeserta;
                txtShortName.Text = popup.OctNamaPeserta;
            }
        }

        private void chkMariage_CheckedChanged(object sender, EventArgs e)
        {
            dtMariedDate.Enabled = chkMariage.Checked;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView_Click(null, null);
        }
    }
}
