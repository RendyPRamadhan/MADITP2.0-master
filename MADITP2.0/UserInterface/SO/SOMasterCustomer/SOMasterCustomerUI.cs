using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
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

namespace MADITP2._0.UserInterface.SO.SOMasterCustomer
{
    public partial class SOMasterCustomerUI : Form
    {
        private clsGlobal Helper;
        private clsAlert Alert;
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private EnumState _APPSTATE;
        private string _CustomerId;
        private SOMasterCustomerAL Accessor;
        private SOMasterCustomerBL _MasterCustomer;
        private GSBranchAL BranchAccessor;
        private GSEntityAL EntityAccessor;
        private SOMasterDivisionDA DivisionAccessor;

        public SOMasterCustomerUI()
        {
            InitializeComponent();

            Helper = new clsGlobal();
            Alert = new clsAlert();

            Accessor = new SOMasterCustomerAL(Helper);
            BranchAccessor = new GSBranchAL(Helper);
            EntityAccessor = new GSEntityAL(Helper);
            DivisionAccessor = new SOMasterDivisionDA();

            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;
        }

        private void SOMasterCustomerUI_Load(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
            DrawComboboxes();
            LoadData();
        }

        private void DrawComboboxes()
        {
            //branch
            cmbFilterBranch.DataSource = BranchAccessor.GetComboboxBranch(false);
            cmbFilterBranch.ValueMember = "ValueMember";
            cmbFilterBranch.DisplayMember = "DisplayMember";

            //entity
            cmbFilterEntity.DataSource = EntityAccessor.GetComboboxEntity(false);
            cmbFilterEntity.ValueMember = "ValueMember";
            cmbFilterEntity.DisplayMember = "DisplayMember";

            //division
            cmbFilterDivision.DataSource = DivisionAccessor.GetComboboxDivision(false);
            cmbFilterDivision.ValueMember = "ValueMember";
            cmbFilterDivision.DisplayMember = "DisplayMember";
        }

        private void DrawDatatable()
        {
            string search = null;
            string Entity = "";
            string Branch = "";
            string Division = "";

            if (txtFilterSearch.Text != "")
            {
                search = txtFilterSearch.Text.ToLower();
            }

            if(!string.IsNullOrEmpty(Helper.CastToString(cmbFilterBranch.SelectedValue)))
            {
                Branch = Helper.CastToString(cmbFilterBranch.SelectedValue);
            }
            
            if(!string.IsNullOrEmpty(Helper.CastToString(cmbFilterDivision.SelectedValue)))
            {
                Division = Helper.CastToString(cmbFilterDivision.SelectedValue);
            }
            
            if(!string.IsNullOrEmpty(Helper.CastToString(cmbFilterEntity.SelectedValue)))
            {
                Entity = Helper.CastToString(cmbFilterEntity.SelectedValue);
            }

            int rows = Accessor.CountRows(search, Entity, Branch, Division);
            _TotalPage = (int)Math.Ceiling(Convert.ToDouble(rows) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;
            if (rows == 0)
            {
                Alert.PushAlert("No record found!", clsAlert.Type.Info);
                return;
            }

            List<SOMasterCustomerBL> source = Accessor.AdvanceShowList(_CurrentPage, _FetchLimit, search, Entity, Branch, Division);
/*            dgvResult.AutoGenerateColumns = false;*/
            dgvResult.DataSource = source;

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

        private void navView_Click(object sender, EventArgs e)
        {
            PanelFormList.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _CurrentPage = 1;
            LoadData();
        }

        private void LoadData()
        {
            Pagination(true);
            DrawDatatable();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _CurrentPage++;
            LoadData();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _CurrentPage--;
            LoadData();
        }

        private void txtFilterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void txtFilterSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && txtFilterSearch.Text == string.Empty)
            {
                btnSearch_Click(null, null);
            }
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            PanelFormCreate.BringToFront();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
