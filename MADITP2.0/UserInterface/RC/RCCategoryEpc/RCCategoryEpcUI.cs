using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.RC.RCCategoryEpc
{
    public partial class RCCategoryEpcUI : Form
    {
        private clsGlobal Helper;
        private clsAlert Alert;
        private int? _CategoryID;
        private RCCategoryEpcAL Accessor;
        private RCCategoryEpcBL _SelectedData;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;

        public RCCategoryEpcUI()
        {
            Helper = new clsGlobal();
            Accessor = new RCCategoryEpcAL(Helper);
            Alert = new clsAlert();
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
            _CurrentPage = 1;

            InitializeComponent();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            DrawDatatable();
            PanelFormList.BringToFront();
        }

        private void RCCategoryEpcUI_Load(object sender, EventArgs e)
        {
            DrawDatatable();
            navView_Click(null, null);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            if(_CategoryID == null)
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Error);
                return;
            }

            SetState(EnumState.Update);
            _SelectedData = Accessor.GetCategoryEpc((int)_CategoryID);
            PrepareFormEditor(_SelectedData);
            PanelFormCreate.BringToFront();
        }

        private void DrawDatatable()
        {
            string search = null;
            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            List<RCCategoryEpcBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search);
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

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _CategoryID = Convert.ToInt32(dgvResult.Rows[e.RowIndex].Cells["Id"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Alert.PushAlert(es.Message.ToString(), clsAlert.Type.Error);
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
            Helper.ResetAllFormControls(PanelFormCreate);
            SetState(EnumState.Create);
            PanelFormCreate.BringToFront();
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

        private void PrepareFormEditor(RCCategoryEpcBL item)
        {
            txtDescription.Text = item.Description;
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            if (_CategoryID == null)
            {
                Alert.PushAlert("Select data from the table!", clsAlert.Type.Error);
                return;
            }

            SetState(EnumState.Delete);
            _SelectedData = Accessor.GetCategoryEpc((int)_CategoryID);
            PrepareFormEditor(_SelectedData);
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
            _SelectedData = new RCCategoryEpcBL();
            _SelectedData.Description = txtDescription.Text.Trim();
            _SelectedData.CreatedAt = DateTime.Now;
            _SelectedData.UpdatedAt = DateTime.Now;
            bool info = Accessor.Post(_SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Updated!", clsAlert.Type.Success);
            navView_Click(null, null);
        }

        private void HandleUpdate()
        {
            _SelectedData.Description = txtDescription.Text.Trim();
            _SelectedData.UpdatedAt = DateTime.Now;
            bool info = Accessor.Put((int)_CategoryID, _SelectedData);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Updated!", clsAlert.Type.Success);
            navView_Click(null, null);
        }

        private void HandleDelete()
        {
            bool info = Accessor.Delete((int)_CategoryID);
            if (!info)
            {
                Alert.PushAlert(Accessor.Reason, clsAlert.Type.Error);
                return;
            }

            Alert.PushAlert("Deleted!", clsAlert.Type.Success);
            navView_Click(null, null);
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Choose location";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Category EPC";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            StringBuilder fileContent = new StringBuilder();
            List<string> header = new List<string>
            {
                "ID",
                "Category Desc",
                "Created at",
                "Updated at",
            };
            header.ForEach(delegate (string col) {
                fileContent.Append("\"" + col + "\",");
            });
            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (RCCategoryEpcBL item in Accessor.GetAll(txtFilterSearch.Text))
            {
                fileContent.Append("\"" + item.Id + "\",");
                fileContent.Append("\"" + item.Description+ "\",");
                fileContent.Append("\"" + item.CreatedAt+ "\",");
                fileContent.Append("\"" + item.UpdatedAt+ "\",");

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);
            }

            System.IO.File.WriteAllText(saveFileDialog1.FileName, fileContent.ToString());
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView_Click(null, null);
        }
    }
}
