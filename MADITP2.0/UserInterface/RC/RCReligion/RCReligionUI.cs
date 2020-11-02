using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.RC.RCReligion
{
    public partial class RCReligionUI : Form
    {
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private int _ReligionId;
        private clsGlobal Helper;
        private clsAlert Alert;
        private RCReligionAL Accessor;
        private RCReligionBL _Religion;

        public RCReligionUI()
        {
            InitializeComponent();

            Helper = new clsGlobal();
            Alert = new clsAlert();
            Accessor = new RCReligionAL(Helper);

            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
        }

        private void RCReligionUI_Load(object sender, EventArgs e)
        {
            Pagination(true);
            DrawDatatable();

            PanelFormList.BringToFront();
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

            List<RCReligionBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search);
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

        private void navNew_Click(object sender, EventArgs e)
        {
            Helper.ResetAllFormControls(PanelFormCreate);
            PanelFormCreate.BringToFront();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            _Religion = Accessor.Find(_ReligionId);
            if(_Religion == null)
            {
                Alert.PushAlert("Religion not found!", clsAlert.Type.Error);
                return;
            }

            SetState(EnumState.Update);
            txtReligion.Text = Helper.CastToString(_Religion.Religion);
            PanelFormCreate.BringToFront();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            _Religion = Accessor.Find(_ReligionId);
            if (_Religion == null)
            {
                Alert.PushAlert("Religion not found!", clsAlert.Type.Error);
                return;
            }

            SetState(EnumState.Delete);
            txtReligion.Text = Helper.CastToString(_Religion.Religion);
            PanelFormCreate.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_APPSTATE == EnumState.Create)
            {
                bool info = Accessor.Post(new RCReligionBL() { Religion = Helper.CastToString(txtReligion.Text) });
                if (!info)
                {
                    Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                    return;
                }

                Alert.PushAlert("Created!", clsAlert.Type.Success);
                btnSearch_Click(null, null);
                navView_Click(null, null);
                return;
            }

            if (_APPSTATE == EnumState.Update)
            {
                bool info = Accessor.Put(_ReligionId, new RCReligionBL() { Religion = Helper.CastToString(txtReligion.Text) });
                if (!info)
                {
                    Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                    return;
                }

                Alert.PushAlert("Updated!", clsAlert.Type.Success);
                btnSearch_Click(null,null);
                navView_Click(null,null);
                return;
            }

            if (_APPSTATE == EnumState.Delete)
            {
                bool info = Accessor.Delete(_ReligionId);
                if (!info)
                {
                    Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                    return;
                }

                Alert.PushAlert("Deleted!", clsAlert.Type.Success);
                btnSearch_Click(null, null);
                navView_Click(null, null);
                return;
            }
        }

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView_Click(null, null);
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _ReligionId = Convert.ToInt32(dgvResult.Rows[e.RowIndex].Cells["Id"].Value);
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

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Master Religion";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "ID",
                "Religion",
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (RCReligionBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                fileContent.Append("\"" + item.Id + "\",");
                fileContent.Append("\"" + item.Religion + "\",");

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

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && txtFilterSearch.Text.Length == 0)
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
    }
}
