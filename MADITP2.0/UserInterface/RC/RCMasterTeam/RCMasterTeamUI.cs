using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.BusinessLogic.RC;
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

namespace MADITP2._0.UserInterface.RC.RCMasterTeam
{
    public partial class RCMasterTeamUI : Form
    {
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private string _TeamId;
        private clsGlobal Helper;
        private clsAlert Alert;
        private RCTeamAL Accessor;
        private RCTeamBL _Team;

        public RCMasterTeamUI()
        {
            InitializeComponent();

            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new RCTeamAL(Helper);
        }

        private void navView_Click(object sender, EventArgs e)
        {
            SetState(EnumState.view);
            PanelFormList.BringToFront();
        }

        private void RCMasterTeamUI_Load(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
            Pagination(true);
            DrawDatatable();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            Helper.ResetAllFormControls(PanelFormCreate);
            SetState(EnumState.Create);
            PanelFormCreate.BringToFront();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_TeamId))
            {
                Alert.PushAlert("Click data from the table please.", clsAlert.Type.Warning);
                return;
            }

            _Team = Accessor.Find(_TeamId);
            if(_Team is null)
            {
                Alert.PushAlert("Team not found", clsAlert.Type.Error);
                return;
            }

            prepareFormControl(_Team);
            SetState(EnumState.Update);
            PanelFormCreate.BringToFront();
        }

        private void prepareFormControl(RCTeamBL Team)
        {
            txtCode.Text = Team.Id;
            txtDescription.Text = Team.Description;
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_TeamId))
            {
                Alert.PushAlert("Click data from the table please.", clsAlert.Type.Warning);
                return;
            }

            _Team = Accessor.Find(_TeamId);
            if (_Team is null)
            {
                Alert.PushAlert("Team not found", clsAlert.Type.Error);
                return;
            }

            prepareFormControl(_Team);
            SetState(EnumState.Delete);
            PanelFormCreate.BringToFront();
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Master Team";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "ID",
                "Description",
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (RCTeamBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                fileContent.Append("\"" + item.Id + "\",");
                fileContent.Append("\"" + item.Description + "\",");

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

        private void SetState(EnumState enumState)
        {
            _APPSTATE = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    txtCode.Enabled = true;
                    btnSave.Text = "Save";
                    break;
                case EnumState.Update:
                    txtCode.Enabled = false;
                    btnSave.Text = "Update";
                    break;
                case EnumState.Delete:
                    txtCode.Enabled = false;
                    btnSave.Text = "Delete";
                    break;
                default:
                    break;
            }
        }

        private void DrawDatatable()
        {
            string search = null;
            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            List<RCTeamBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search);
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

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _TeamId = Helper.CastToString(dgvResult.Rows[e.RowIndex].Cells["Id"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Pagination(true);
            DrawDatatable();
        }

        private void txtFilterSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void txtFilterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void PanelFormList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_APPSTATE == EnumState.Create)
            {
                handleCreate();
            }

            if (_APPSTATE == EnumState.Update)
            {
                handleUpdate();
            }

            if (_APPSTATE == EnumState.Delete)
            {
                handleDelete();
            }
        }

        private void handleCreate()
        {
            _Team = new RCTeamBL();
            _Team.Id = txtCode.Text;
            _Team.Description = txtDescription.Text;

            bool info = Accessor.Post(_Team);
            if(!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            btnSearch_Click(null, null);
            navView_Click(null, null);
            Alert.PushAlert("Saved!", clsAlert.Type.Success);
        }

        private void handleUpdate()
        {
            _Team.Id = txtCode.Text;
            _Team.Description = txtDescription.Text;

            bool info = Accessor.Put(_TeamId, _Team);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            btnSearch_Click(null, null);
            navView_Click(null, null);
            Alert.PushAlert("Updated!", clsAlert.Type.Success);
        }

        private void handleDelete()
        {
            bool info = Accessor.Delete(_TeamId);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            btnSearch_Click(null, null);
            navView_Click(null, null);
            Alert.PushAlert("Deleted!", clsAlert.Type.Success);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView_Click(null, null);
        }
    }
}
