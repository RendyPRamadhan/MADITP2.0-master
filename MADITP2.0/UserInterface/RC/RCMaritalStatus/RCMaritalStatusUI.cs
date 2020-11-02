using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.RC.RCMaritalStatus
{
    public partial class RCMaritalStatusUI : Form
    {
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private int _MaritalId;
        private clsGlobal Helper;
        private clsAlert Alert;
        private RCMaritalStatusAL Accessor;
        private RCMaritalStatusBL _MaritalStatus;

        public RCMaritalStatusUI()
        {
            InitializeComponent();

            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new RCMaritalStatusAL(Helper);

            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
        }

        private void RCMaritalStatusUI_Load(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
            Pagination(true);
            DrawDatatable();
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

        private void DrawDatatable()
        {
            string search = null;
            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            List<RCMaritalStatusBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search);
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
            if(txtFilterSearch.Text.Length == 0 && e.KeyCode == Keys.Back)
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
            saveFileDialog1.FileName = "Master Marital Status";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "ID",
                "Marital Status",
                "Created At",
                "Updated At",
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (RCMaritalStatusBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                fileContent.Append("\"" + item.Id + "\",");
                fileContent.Append("\"" + item.Marital_status + "\",");
                fileContent.Append("\"" + item.Created_at + "\",");
                fileContent.Append("\"" + item.Updated_at + "\",");

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

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _MaritalId = Helper.CastToInt(dgvResult.Rows[e.RowIndex].Cells["Id"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            PanelFormCreate.BringToFront();
            Helper.ResetAllFormControls(PanelFormCreate);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            _MaritalStatus = Accessor.Find(_MaritalId);
            if(_MaritalStatus is null)
            {
                Alert.PushAlert("Marital status not found", clsAlert.Type.Error);
            }

            SetState(EnumState.Update);
            txtMaritalStatus.Text = _MaritalStatus.Marital_status;
            PanelFormCreate.BringToFront();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            _MaritalStatus = Accessor.Find(_MaritalId);
            if (_MaritalStatus is null)
            {
                Alert.PushAlert("Marital status not found", clsAlert.Type.Error);
            }

            SetState(EnumState.Delete);
            txtMaritalStatus.Text = _MaritalStatus.Marital_status;
            PanelFormCreate.BringToFront();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_APPSTATE == EnumState.Create)
            {
                _MaritalStatus = new RCMaritalStatusBL();
                _MaritalStatus.Marital_status = Helper.CastToString(txtMaritalStatus.Text);
                bool info = Accessor.Post(_MaritalStatus);
                if (!info)
                {
                    Alert.PushAlert(Accessor.Reason, clsAlert.Type.Warning);
                    return;
                }

                Alert.PushAlert("Created!", clsAlert.Type.Success);
                navView_Click(null, null);
                btnSearch_Click(null, null);
                return;
            }

            if (_APPSTATE == EnumState.Update)
            {
                _MaritalStatus.Marital_status = Helper.CastToString(txtMaritalStatus.Text);
                bool info = Accessor.Put(_MaritalId, _MaritalStatus);
                if (!info)
                {
                    Alert.PushAlert(Accessor.Reason, clsAlert.Type.Warning);
                    return;
                }

                Alert.PushAlert("Updated!", clsAlert.Type.Success);
                navView_Click(null, null);
                btnSearch_Click(null, null);
                return;
            }

            if (_APPSTATE == EnumState.Delete)
            {
                bool info = Accessor.Delete(_MaritalId);
                if (!info)
                {
                    Alert.PushAlert(Accessor.Reason, clsAlert.Type.Warning);
                    return;
                }

                Alert.PushAlert("Deleted!", clsAlert.Type.Success);
                navView_Click(null, null);
                btnSearch_Click(null, null);
                return;
            }
        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }
    }
}
