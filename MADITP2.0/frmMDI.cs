using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using MADITP2._0.Global;
using MADITP2._0.login;
using System.Runtime.InteropServices;
using MADITP2._0.Properties;

namespace MADITP2._0
{
    public partial class frmMDI : Form
    {
        clsGlobal _clsGlobal = new clsGlobal();
        clsLogin _clsLogin = new clsLogin();

        DataTable dtMenu;
        SqlConnection conn;
        TreeNode mainNode = null;
        TreeNode parentNode = null;
        TreeNode childNode = null;
        TreeNode nod = new TreeNode();
        String SQLstr;
        string strParentCode;


        private int childFormNumber = 0;

        public frmMDI()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private void frmMDI_Load(object sender, EventArgs e)
        {
            //MenuStatus();
            //this.Text = clsGlobal.APPNAME + " | Version : " + Application.ProductVersion + "";

            /* pake ini lamban karena kebanyakan looping query            
            TreeViewLoad(); 
            */
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    //control.BackgroundImage = Resources.Background;
                    //control.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            TreeViewMenu();

            //ToolStriptxtMenu.Select();

            //toolStrip.Hide();
            menuStrip.Hide();
            //statusStrip1.Hide();
            SetTreeViewTheme(tvMenu.Handle);
            textMenuSearch.Focus();
            label3.Text = clsLogin.USERID;
        }

        private void TreeViewMenu()
        {

            //mainNode=tvMenu.Nodes.Add("Main Menu", "Main Menu", 0);

            conn = new SqlConnection(clsGlobal.ConnectionString);

            SQLstr = "select " +
                    "mnu_group_id," +
                    "mnu_parent_code," +
                    "mnu_menu_code," +
                    "mnu_menu_name," +
                    "mnu_menu_type," +
                    "mnu_image_id " +
                    "from GS_MENU_USERS " +
                    "left join GS_MENUS on gmu_menu_id=mnu_menu_code " +
                    "Where gmu_user_id = '" + clsLogin.USERID + "' " +
                    "order by mnu_menu_sequence asc ";

            dtMenu = _clsGlobal.ExecDT(SQLstr);

            DataView dvGroup = new DataView(dtMenu);
            DataTable dtfilGrp;

            dvGroup.RowFilter = "mnu_parent_code = '' ";
            dtfilGrp = dvGroup.ToTable();

            foreach (DataRow dr2 in dtfilGrp.Rows)
            {
                nod.Name = dr2["mnu_menu_code"].ToString().Trim();
                nod.Text = dr2["mnu_menu_name"].ToString().Trim();

                parentNode = tvMenu.Nodes.Add(nod.Name, nod.Text);

                PopulateTreeViewMenu(dr2["mnu_group_id"].ToString().Trim(), dr2["mnu_menu_code"].ToString().Trim(), parentNode);
            }

            //tvMenu.Select();
            tvMenu.EndUpdate();
            //tvMenu.Nodes[0].Expand();
            conn.Close();
        }
         
        private void PopulateTreeViewMenu(string parentId, string parentCode, TreeNode parentNode)
        {
            DataView dvParent = new DataView(dtMenu);
            DataTable dtfilPrn;

            dvParent.RowFilter = "mnu_group_id = '" + parentId + "'  and mnu_parent_code = '" + parentCode + "' ";
            dtfilPrn = dvParent.ToTable();

            foreach (DataRow dr in dtfilPrn.Rows)
            {
                nod.Name = dr["mnu_menu_code"].ToString();
                nod.Text = dr["mnu_menu_name"].ToString();
                strParentCode= dr["mnu_menu_code"].ToString();

                if (parentNode == null)
                {
                    if (dr["mnu_menu_type"].ToString() == "C")
                    {
                        childNode = parentNode.Nodes.Add(nod.Name, dr["mnu_menu_code"].ToString() + " - " + nod.Text,2);
                    }
                    else
                    {
                        childNode = parentNode.Nodes.Add(nod.Name, nod.Text);
                    }
                }
                else
                {
                    if (parentCode == dr["mnu_parent_code"].ToString())
                    {
                        if (dr["mnu_menu_type"].ToString() == "C")
                        {
                            childNode = parentNode.Nodes.Add(nod.Name, dr["mnu_menu_code"].ToString() + " - " + nod.Text,2);
                        }
                        else
                        {
                            childNode = parentNode.Nodes.Add(nod.Name, nod.Text);
                        }
                    }
                    else
                    {
                         if (dr["mnu_menu_type"].ToString() == "C")
                        {
                            childNode = parentNode.Nodes.Add(nod.Name, dr["mnu_menu_code"].ToString() + " - " + nod.Text,2);
                        }
                        else
                        {
                            childNode = parentNode.Nodes.Add(nod.Name, nod.Text);
                        }
                    }
                }

                PopulateTreeViewMenu(parentId, strParentCode, childNode);
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            //DialogResult dr;
            //dr = MessageBox.Show(_clsGlobal.ApplMessage(10003), "Application Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (dr == DialogResult.OK)
            //{
                Application.Exit();
            //}
        }

        private void tvMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TreeNode tn = this.tvMenu.SelectedNode;
                int x = tn.Bounds.X;
                int y = tn.Bounds.Y;
                //Click on the selected node
                TreeNodeMouseClickEventArgs treeNodeMouseClickEventArgs = new TreeNodeMouseClickEventArgs(tn, MouseButtons.Left, 1, x, y);
                this.tvMenu_NodeMouseDoubleClick(tn, treeNodeMouseClickEventArgs);
            }
        }

        private void tvMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int index;
            string[] splitMenuId;
            TreeNode obj = new TreeNode();
            obj = tvMenu.SelectedNode;
            if(obj == null)
            {
                return;
            }

            index = tvMenu.Nodes.IndexOf(obj);
            string str = string.Empty;
            str = index.ToString();

            splitMenuId = obj.Text.Split('-');

            if (e.Node.Name.ToString() != "")
            {
                _clsLogin.AccessUser(e.Node.Name.ToString(), splitMenuId[0].Trim());

                //if (clsLogin.FLAGPASSWORD == 1)
                //{
                //    frmPassword frmPass = new frmPassword();
                //    frmPass.ShowDialog();
                //    if (frmPass.ValidPassword)
                //    {
                //        ShowApplicationNew(e.Node.Name.ToString(), clsLogin.GROUPMENUID);
                //    }
                //}
                //else
                //{
                    ShowApplicationNew(e.Node.Name.ToString(), clsLogin.GROUPMENUID);
                //}
            }
        }
        private void ShowApplicationNew(string nodeName, string nodeGroup)
        {
            try
            {
                string registerMenu; 
                //string keyMenuId;

                registerMenu = clsGlobal.DIR_REG_CONNECTION + "TiraSnDNet_Setting\\Setting";
                //keyMenuId = "MenuID";

                string solutionName = Assembly.GetCallingAssembly().GetName().Name;

                if (clsLogin.FORMLOAD.Length > 0)
                {
                    Form currentForm = Application.OpenForms[clsLogin.FORMLOAD];

                    if (currentForm != null)
                    {
                        currentForm.Close();
                    }
                    OpenForm(clsLogin.FORMLOAD, clsLogin.MENUNAME);

                    //if (currentForm == null)
                    //{
                    //    Registry.SetValue(@"" + registerMenu + "", "" + keyMenuId + "", nodeName.ToString());
                    //    OpenForm(clsLogin.FORMLOAD);
                    //}
                    //else
                    //{
                    //    currentForm.Activate();
                    //}
                }
                //else
                //{
                //    MessageBox.Show("Invalid Application Form" + Environment.NewLine + "Please contact your Administrator", clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenForm(string FormName, string MenuName)
        {
            var _formName = (from t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                             where t.Name.Equals(FormName)
                             select t.FullName).Single();
            var _form = (Form)Activator.CreateInstance(Type.GetType(_formName));
            if (_form != null)

            _form.TopLevel = true;
            _form.MdiParent = this;
            _form.Show();
            _form.Location = new Point(0, 0);
            _form.WindowState = FormWindowState.Maximized;
            _form.Text = MenuName;

            labelMenuName.Text = MenuName;
        }

        private void ToolStriptxtMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _clsGlobal = _clsGlobal.viewNode(textMenuSearch.Text);
                String NodeName = _clsGlobal.NodeName;
                String NodeGroup = _clsGlobal.NodeGroup;

                if (NodeName != "")
                {
                    try
                    {
                        _clsLogin.AccessUser(NodeName.ToString(), textMenuSearch.Text.Trim());

                        //if (clsLogin.FLAGPASSWORD == 1)
                        //{
                        //    frmPassword frmPass = new frmPassword();
                        //    frmPass.ShowDialog();
                        //    if (frmPass.ValidPassword)
                        //    {
                        //        ShowApplicationNew(NodeName.ToString(), NodeGroup.ToString());
                        //    }
                        //}
                        //else
                        //{
                            ShowApplicationNew(NodeName.ToString(), NodeGroup.ToString());
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Unkwown TCode, please contact your Administrator", clsGlobal.APP_MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                textMenuSearch.Clear();
                textMenuSearch.TiraPlaceHolder = textMenuSearch.TiraPlaceHolder;
            }
        }

        private void navExit_Click(object sender, EventArgs e)
        {
            if (clsDialog.ShowDialog("Are you sure want exit ?") == DialogResult.Yes)
                Application.Exit();
        }

        private void navBar_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Visible)
                panelSideMenu.Hide();
            else
                panelSideMenu.Show();
        }

        private void tvMenu_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            TreeNodeStates state = e.State;
            Font font = e.Node.NodeFont ?? e.Node.TreeView.Font;
            Color fore = e.Node.ForeColor;
            if (fore == Color.Empty)
                fore = e.Node.TreeView.ForeColor;
            if (e.Node == e.Node.TreeView.SelectedNode)
            {
                fore = SystemColors.HighlightText;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(8, 102, 60)), e.Bounds);
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, fore, Color.FromArgb(8, 102, 60));
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, fore, Color.FromArgb(8, 102, 60), TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(8, 102, 60)), e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, fore, TextFormatFlags.GlyphOverhangPadding);
            }
        }

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        public static void SetTreeViewTheme(IntPtr treeHandle)
        {
            SetWindowTheme(treeHandle, "explorer", null);
        }

        private void navSetting_Click(object sender, EventArgs e)
        {
            new frmLayout1().Show();
        }

        private void navHelp_Click(object sender, EventArgs e)
        {
            new frmLayout2().Show();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*protected override void OnLoad(EventArgs e)
        {
            var mdiclient = this.Controls.OfType<MdiClient>().Single();
            this.SuspendLayout();
            mdiclient.SuspendLayout();
            var hdiff = mdiclient.Size.Width - mdiclient.ClientSize.Width;
            var vdiff = mdiclient.Size.Height - mdiclient.ClientSize.Height;
            var size = new Size(mdiclient.Width + hdiff, mdiclient.Height + vdiff);
            var location = new Point(mdiclient.Left - (hdiff / 2), mdiclient.Top - (vdiff / 2));
            mdiclient.Dock = DockStyle.None;
            mdiclient.Size = size;
            mdiclient.Location = location;
            mdiclient.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            mdiclient.ResumeLayout(true);
            this.ResumeLayout(true);
            base.OnLoad(e);
        }*/
    }
}
