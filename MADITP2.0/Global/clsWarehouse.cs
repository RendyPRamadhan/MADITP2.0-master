using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Forms;
using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.login;

namespace MADITP2._0.Global
{
    public partial class clsWarehouse : Form
    {
        Form Background = new Form();
        clsGlobal Helper;
        private IMMasterWarehouseBL warehouse;
        private IMMasterWarehouseAL WHAccessor;

        internal IMMasterWarehouseBL Warehouse { get => warehouse; set => warehouse = value; }

        public clsWarehouse(clsGlobal helper)
        {
            InitializeComponent();
            this.Text = string.Empty;
            Helper = helper;
            WHAccessor = new IMMasterWarehouseAL(Helper);
        }

        private void clsWarehouse_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            dg.AutoGenerateColumns = false;
            dg.DataSource = DrawResource();

            Background.Opacity = .60d;
            Background.BackColor = Color.Black;
            Background.WindowState = FormWindowState.Maximized;
            Background.FormBorderStyle = FormBorderStyle.None;
            Background.ShowInTaskbar = false;
            Background.TopMost = true;
            Background.Show();

            this.Owner = Background;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            IMMasterWarehouseBL item = new IMMasterWarehouseBL();
            item.warehouse_id = Helper.CastToString(dg.CurrentRow.Cells["warehouse_id"].Value);
            item.warehouse_description = Helper.CastToString(dg.CurrentRow.Cells["warehouse_description"].Value);
            this.DialogResult = DialogResult.OK;
            this.Hide();

            Warehouse = item;
            Background.Hide();
        }

        private void find_TextChanged(object sender, EventArgs e)
        {
            dg.DataSource = DrawResource();
        }

        private void dg_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OK.PerformClick();
        }

        private List<IMMasterWarehouseBL> DrawResource() {
            string search = null;

            if (string.IsNullOrEmpty(find.Text)) 
            {
                return new List<IMMasterWarehouseBL>();
            }

            if (Helper.CastToString(find.Text).Length < 3)
            {
                return new List<IMMasterWarehouseBL>();
            }

            search = Helper.CastToString(find.Text);
            return WHAccessor.AdvanceShowList(0, 20, null, search);
        }

    }
}
