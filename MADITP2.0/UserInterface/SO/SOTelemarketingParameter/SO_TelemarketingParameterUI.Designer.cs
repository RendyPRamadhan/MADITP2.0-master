namespace MADITP2._0.UserInterface.SO.SOTelemarketingParameter
{
    partial class SO_TelemarketingParameterUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navClose = new Tira.Component.TiraButton();
            this.navExport = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.panelNew = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.tabControlTelemarketingParameter = new Tira.Component.TiraTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridCallStatusSetting = new Tira.Component.TiraDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearchCSS = new Tira.Component.TiraGroupBox();
            this.btnSearchCSS = new Tira.Component.TiraButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboSearchPhase = new Tira.Component.TiraComboBox();
            this.cboSearchCategory = new Tira.Component.TiraComboBox();
            this.lblSearchPhase = new System.Windows.Forms.Label();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.tiraGroupBox4 = new Tira.Component.TiraGroupBox();
            this.lblPagingInfoCSS = new System.Windows.Forms.Label();
            this.lblRowsCSS = new System.Windows.Forms.Label();
            this.btnPrevCSS = new Tira.Component.TiraButton();
            this.btnNextCSS = new Tira.Component.TiraButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridTargetCall = new Tira.Component.TiraDataGrid();
            this.target_call = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target_call_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target_call_create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearchFAQ = new Tira.Component.TiraGroupBox();
            this.btnSaveTargetCall = new Tira.Component.TiraButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxTargetPerDay = new Tira.Component.TiraTextBox();
            this.lblTargetPerDay = new System.Windows.Forms.Label();
            this.tiraGroupBox6 = new Tira.Component.TiraGroupBox();
            this.lblPagingInfoTC = new System.Windows.Forms.Label();
            this.lblRowsTC = new System.Windows.Forms.Label();
            this.btnPrevTC = new Tira.Component.TiraButton();
            this.btnNextTC = new Tira.Component.TiraButton();
            this.lblDrop = new System.Windows.Forms.Label();
            this.cbDrop = new Tira.Component.TiraCheckBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtBoxStatusDesc = new Tira.Component.TiraTextBox();
            this.cboCategory = new Tira.Component.TiraComboBox();
            this.cboPhase = new Tira.Component.TiraComboBox();
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.btnSaveCST = new Tira.Component.TiraButton();
            this.btnCancelCST = new Tira.Component.TiraButton();
            this.btnUpdateCST = new Tira.Component.TiraButton();
            this.bindingObj = new System.Windows.Forms.BindingSource(this.components);
            this.panelTopMenu.SuspendLayout();
            this.panelNew.SuspendLayout();
            this.panelView.SuspendLayout();
            this.tabControlTelemarketingParameter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCallStatusSetting)).BeginInit();
            this.groupBoxSearchCSS.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tiraGroupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTargetCall)).BeginInit();
            this.groupBoxSearchFAQ.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tiraGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObj)).BeginInit();
            this.SuspendLayout();
            // 
            // navClose
            // 
            this.navClose.BackColor = System.Drawing.SystemColors.Control;
            this.navClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.navClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navClose.FlatAppearance.BorderSize = 0;
            this.navClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navClose.ForeColor = System.Drawing.Color.Black;
            this.navClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.navClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navClose.IconSize = 25;
            this.navClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.navClose.Location = new System.Drawing.Point(1173, 0);
            this.navClose.Name = "navClose";
            this.navClose.Rotation = 0D;
            this.navClose.Size = new System.Drawing.Size(30, 30);
            this.navClose.TabIndex = 9;
            this.navClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navClose.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navClose.UseVisualStyleBackColor = false;
            this.navClose.Click += new System.EventHandler(this.navClose_Click);
            // 
            // navExport
            // 
            this.navExport.BackColor = System.Drawing.SystemColors.Control;
            this.navExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.navExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navExport.FlatAppearance.BorderSize = 0;
            this.navExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navExport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navExport.ForeColor = System.Drawing.Color.Black;
            this.navExport.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.navExport.IconColor = System.Drawing.Color.Black;
            this.navExport.IconSize = 20;
            this.navExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navExport.Location = new System.Drawing.Point(270, 0);
            this.navExport.Name = "navExport";
            this.navExport.Rotation = 0D;
            this.navExport.Size = new System.Drawing.Size(75, 30);
            this.navExport.TabIndex = 6;
            this.navExport.Text = "Export";
            this.navExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navExport.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navExport.UseVisualStyleBackColor = false;
            this.navExport.Click += new System.EventHandler(this.navExport_Click);
            // 
            // navDelete
            // 
            this.navDelete.BackColor = System.Drawing.SystemColors.Control;
            this.navDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.navDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navDelete.FlatAppearance.BorderSize = 0;
            this.navDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navDelete.ForeColor = System.Drawing.Color.Black;
            this.navDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.navDelete.IconColor = System.Drawing.Color.Black;
            this.navDelete.IconSize = 20;
            this.navDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navDelete.Location = new System.Drawing.Point(195, 0);
            this.navDelete.Name = "navDelete";
            this.navDelete.Rotation = 0D;
            this.navDelete.Size = new System.Drawing.Size(75, 30);
            this.navDelete.TabIndex = 4;
            this.navDelete.Text = "Delete";
            this.navDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navDelete.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navDelete.UseVisualStyleBackColor = false;
            this.navDelete.Click += new System.EventHandler(this.navDelete_Click);
            // 
            // navEdit
            // 
            this.navEdit.BackColor = System.Drawing.SystemColors.Control;
            this.navEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.navEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navEdit.FlatAppearance.BorderSize = 0;
            this.navEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navEdit.ForeColor = System.Drawing.Color.Black;
            this.navEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.navEdit.IconColor = System.Drawing.Color.Black;
            this.navEdit.IconSize = 20;
            this.navEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navEdit.Location = new System.Drawing.Point(130, 0);
            this.navEdit.Name = "navEdit";
            this.navEdit.Rotation = 0D;
            this.navEdit.Size = new System.Drawing.Size(65, 30);
            this.navEdit.TabIndex = 3;
            this.navEdit.Text = "Edit";
            this.navEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navEdit.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navEdit.UseVisualStyleBackColor = false;
            this.navEdit.Click += new System.EventHandler(this.navEdit_Click);
            // 
            // navNew
            // 
            this.navNew.BackColor = System.Drawing.SystemColors.Control;
            this.navNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.navNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navNew.FlatAppearance.BorderSize = 0;
            this.navNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navNew.ForeColor = System.Drawing.Color.Black;
            this.navNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.navNew.IconColor = System.Drawing.Color.Black;
            this.navNew.IconSize = 20;
            this.navNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navNew.Location = new System.Drawing.Point(65, 0);
            this.navNew.Name = "navNew";
            this.navNew.Rotation = 0D;
            this.navNew.Size = new System.Drawing.Size(65, 30);
            this.navNew.TabIndex = 2;
            this.navNew.Text = "New";
            this.navNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navNew.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navNew.UseVisualStyleBackColor = false;
            this.navNew.Click += new System.EventHandler(this.navNew_Click);
            // 
            // navView
            // 
            this.navView.BackColor = System.Drawing.SystemColors.Control;
            this.navView.Dock = System.Windows.Forms.DockStyle.Left;
            this.navView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navView.FlatAppearance.BorderSize = 0;
            this.navView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navView.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navView.ForeColor = System.Drawing.Color.Black;
            this.navView.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.navView.IconColor = System.Drawing.Color.Black;
            this.navView.IconSize = 20;
            this.navView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navView.Location = new System.Drawing.Point(0, 0);
            this.navView.Name = "navView";
            this.navView.Rotation = 0D;
            this.navView.Size = new System.Drawing.Size(65, 30);
            this.navView.TabIndex = 1;
            this.navView.Text = "View";
            this.navView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navView.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navView.UseVisualStyleBackColor = false;
            this.navView.Click += new System.EventHandler(this.navView_Click);
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopMenu.Controls.Add(this.navClose);
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navDelete);
            this.panelTopMenu.Controls.Add(this.navEdit);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1203, 30);
            this.panelTopMenu.TabIndex = 16;
            // 
            // panelNew
            // 
            this.panelNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNew.BackColor = System.Drawing.Color.White;
            this.panelNew.Controls.Add(this.panelView);
            this.panelNew.Controls.Add(this.lblDrop);
            this.panelNew.Controls.Add(this.cbDrop);
            this.panelNew.Controls.Add(this.lblCategory);
            this.panelNew.Controls.Add(this.txtBoxStatusDesc);
            this.panelNew.Controls.Add(this.cboCategory);
            this.panelNew.Controls.Add(this.cboPhase);
            this.panelNew.Controls.Add(this.lblStatusDesc);
            this.panelNew.Controls.Add(this.lblPhase);
            this.panelNew.Controls.Add(this.btnSaveCST);
            this.panelNew.Controls.Add(this.btnCancelCST);
            this.panelNew.Controls.Add(this.btnUpdateCST);
            this.panelNew.Location = new System.Drawing.Point(0, 30);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(1203, 717);
            this.panelNew.TabIndex = 356;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.tabControlTelemarketingParameter);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1203, 717);
            this.panelView.TabIndex = 12;
            // 
            // tabControlTelemarketingParameter
            // 
            this.tabControlTelemarketingParameter.ActiveIndicator = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tabControlTelemarketingParameter.ActiveTab = System.Drawing.Color.White;
            this.tabControlTelemarketingParameter.ActiveText = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(15)))));
            this.tabControlTelemarketingParameter.AlternativeTab = System.Drawing.Color.Empty;
            this.tabControlTelemarketingParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlTelemarketingParameter.Background = System.Drawing.Color.White;
            this.tabControlTelemarketingParameter.BackgroundTab = System.Drawing.Color.White;
            this.tabControlTelemarketingParameter.Border = System.Drawing.Color.White;
            this.tabControlTelemarketingParameter.BorderEdges = false;
            this.tabControlTelemarketingParameter.BorderSize = 1;
            this.tabControlTelemarketingParameter.CanDrag = false;
            this.tabControlTelemarketingParameter.Controls.Add(this.tabPage1);
            this.tabControlTelemarketingParameter.Controls.Add(this.tabPage2);
            this.tabControlTelemarketingParameter.Divider = System.Drawing.Color.Silver;
            this.tabControlTelemarketingParameter.DividerSize = 2;
            this.tabControlTelemarketingParameter.InActiveIndicator = System.Drawing.Color.Silver;
            this.tabControlTelemarketingParameter.InActiveTab = System.Drawing.Color.White;
            this.tabControlTelemarketingParameter.InActiveText = System.Drawing.Color.Black;
            this.tabControlTelemarketingParameter.IndicatorSize = 6;
            this.tabControlTelemarketingParameter.Location = new System.Drawing.Point(9, 15);
            this.tabControlTelemarketingParameter.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlTelemarketingParameter.Name = "tabControlTelemarketingParameter";
            this.tabControlTelemarketingParameter.Padding = new System.Drawing.Point(0, 0);
            this.tabControlTelemarketingParameter.SelectedIndex = 0;
            this.tabControlTelemarketingParameter.Size = new System.Drawing.Size(1185, 693);
            this.tabControlTelemarketingParameter.TabIndex = 0;
            this.tabControlTelemarketingParameter.SelectedIndexChanged += new System.EventHandler(this.tabControlTelemarketingParameter_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridCallStatusSetting);
            this.tabPage1.Controls.Add(this.groupBoxSearchCSS);
            this.tabPage1.Controls.Add(this.tiraGroupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1177, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Call Status Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridCallStatusSetting
            // 
            this.dataGridCallStatusSetting.AllowUserToAddRows = false;
            this.dataGridCallStatusSetting.AllowUserToDeleteRows = false;
            this.dataGridCallStatusSetting.AllowUserToOrderColumns = true;
            this.dataGridCallStatusSetting.AllowUserToResizeColumns = false;
            this.dataGridCallStatusSetting.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridCallStatusSetting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCallStatusSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCallStatusSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridCallStatusSetting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridCallStatusSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCallStatusSetting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCallStatusSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCallStatusSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCallStatusSetting.ColumnHeadersHeight = 22;
            this.dataGridCallStatusSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCallStatusSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.phase,
            this.status_desc,
            this.category,
            this.drop});
            this.dataGridCallStatusSetting.EnableHeadersVisualStyles = false;
            this.dataGridCallStatusSetting.Location = new System.Drawing.Point(2, 221);
            this.dataGridCallStatusSetting.Name = "dataGridCallStatusSetting";
            this.dataGridCallStatusSetting.ReadOnly = true;
            this.dataGridCallStatusSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCallStatusSetting.RowHeadersVisible = false;
            this.dataGridCallStatusSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCallStatusSetting.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCallStatusSetting.RowTemplate.Height = 25;
            this.dataGridCallStatusSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCallStatusSetting.Size = new System.Drawing.Size(1175, 396);
            this.dataGridCallStatusSetting.TabIndex = 14;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 41;
            // 
            // phase
            // 
            this.phase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phase.DataPropertyName = "parameter_code";
            this.phase.HeaderText = "PHASE";
            this.phase.Name = "phase";
            this.phase.ReadOnly = true;
            // 
            // status_desc
            // 
            this.status_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_desc.DataPropertyName = "parameter_desc";
            this.status_desc.HeaderText = "STATUS DESC";
            this.status_desc.Name = "status_desc";
            this.status_desc.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "parameter_category";
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // drop
            // 
            this.drop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drop.DataPropertyName = "parameter_drop";
            this.drop.HeaderText = "DROP";
            this.drop.Name = "drop";
            this.drop.ReadOnly = true;
            // 
            // groupBoxSearchCSS
            // 
            this.groupBoxSearchCSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchCSS.Controls.Add(this.btnSearchCSS);
            this.groupBoxSearchCSS.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSearchCSS.Location = new System.Drawing.Point(11, 7);
            this.groupBoxSearchCSS.Name = "groupBoxSearchCSS";
            this.groupBoxSearchCSS.Size = new System.Drawing.Size(1164, 208);
            this.groupBoxSearchCSS.TabIndex = 13;
            this.groupBoxSearchCSS.TabStop = false;
            this.groupBoxSearchCSS.Text = "Filter";
            this.groupBoxSearchCSS.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearchCSS.TiraTextColor = System.Drawing.Color.Black;
            // 
            // btnSearchCSS
            // 
            this.btnSearchCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearchCSS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchCSS.FlatAppearance.BorderSize = 0;
            this.btnSearchCSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCSS.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchCSS.ForeColor = System.Drawing.Color.White;
            this.btnSearchCSS.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchCSS.IconColor = System.Drawing.Color.White;
            this.btnSearchCSS.IconSize = 16;
            this.btnSearchCSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCSS.Location = new System.Drawing.Point(1086, 167);
            this.btnSearchCSS.Name = "btnSearchCSS";
            this.btnSearchCSS.Rotation = 0D;
            this.btnSearchCSS.Size = new System.Drawing.Size(70, 23);
            this.btnSearchCSS.TabIndex = 22;
            this.btnSearchCSS.Text = "Search";
            this.btnSearchCSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchCSS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCSS.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearchCSS.UseVisualStyleBackColor = false;
            this.btnSearchCSS.Click += new System.EventHandler(this.btnSearchCST_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cboSearchPhase, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboSearchCategory, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblSearchPhase, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSearchCategory, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1149, 142);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // cboSearchPhase
            // 
            this.cboSearchPhase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchPhase.BackColor = System.Drawing.Color.White;
            this.cboSearchPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchPhase.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchPhase.FormattingEnabled = true;
            this.cboSearchPhase.Location = new System.Drawing.Point(3, 24);
            this.cboSearchPhase.Name = "cboSearchPhase";
            this.cboSearchPhase.Size = new System.Drawing.Size(1143, 23);
            this.cboSearchPhase.TabIndex = 23;
            this.cboSearchPhase.Text = "Phase";
            this.cboSearchPhase.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchPhase.TiraMandatory = false;
            this.cboSearchPhase.TiraPlaceHolder = "Phase";
            // 
            // cboSearchCategory
            // 
            this.cboSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchCategory.BackColor = System.Drawing.Color.White;
            this.cboSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchCategory.FormattingEnabled = true;
            this.cboSearchCategory.Location = new System.Drawing.Point(3, 94);
            this.cboSearchCategory.Name = "cboSearchCategory";
            this.cboSearchCategory.Size = new System.Drawing.Size(1143, 23);
            this.cboSearchCategory.TabIndex = 25;
            this.cboSearchCategory.Text = "Category";
            this.cboSearchCategory.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchCategory.TiraMandatory = false;
            this.cboSearchCategory.TiraPlaceHolder = "Category";
            // 
            // lblSearchPhase
            // 
            this.lblSearchPhase.AutoSize = true;
            this.lblSearchPhase.Location = new System.Drawing.Point(3, 0);
            this.lblSearchPhase.Name = "lblSearchPhase";
            this.lblSearchPhase.Size = new System.Drawing.Size(37, 13);
            this.lblSearchPhase.TabIndex = 26;
            this.lblSearchPhase.Text = "Phase";
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Location = new System.Drawing.Point(3, 70);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(49, 13);
            this.lblSearchCategory.TabIndex = 27;
            this.lblSearchCategory.Text = "Category";
            // 
            // tiraGroupBox4
            // 
            this.tiraGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiraGroupBox4.Controls.Add(this.lblPagingInfoCSS);
            this.tiraGroupBox4.Controls.Add(this.lblRowsCSS);
            this.tiraGroupBox4.Controls.Add(this.btnPrevCSS);
            this.tiraGroupBox4.Controls.Add(this.btnNextCSS);
            this.tiraGroupBox4.Location = new System.Drawing.Point(0, 623);
            this.tiraGroupBox4.Name = "tiraGroupBox4";
            this.tiraGroupBox4.Size = new System.Drawing.Size(1175, 35);
            this.tiraGroupBox4.TabIndex = 12;
            this.tiraGroupBox4.TabStop = false;
            this.tiraGroupBox4.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraGroupBox4.TiraTextColor = System.Drawing.Color.Black;
            // 
            // lblPagingInfoCSS
            // 
            this.lblPagingInfoCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPagingInfoCSS.AutoSize = true;
            this.lblPagingInfoCSS.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagingInfoCSS.Location = new System.Drawing.Point(8, 14);
            this.lblPagingInfoCSS.Name = "lblPagingInfoCSS";
            this.lblPagingInfoCSS.Size = new System.Drawing.Size(38, 13);
            this.lblPagingInfoCSS.TabIndex = 72;
            this.lblPagingInfoCSS.Text = "label4";
            // 
            // lblRowsCSS
            // 
            this.lblRowsCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowsCSS.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCSS.ForeColor = System.Drawing.Color.Black;
            this.lblRowsCSS.Location = new System.Drawing.Point(151, 14);
            this.lblRowsCSS.Name = "lblRowsCSS";
            this.lblRowsCSS.Size = new System.Drawing.Size(106, 13);
            this.lblRowsCSS.TabIndex = 71;
            this.lblRowsCSS.Text = "Records : 0";
            this.lblRowsCSS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPrevCSS
            // 
            this.btnPrevCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevCSS.BackColor = System.Drawing.Color.White;
            this.btnPrevCSS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevCSS.FlatAppearance.BorderSize = 0;
            this.btnPrevCSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevCSS.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrevCSS.ForeColor = System.Drawing.Color.Black;
            this.btnPrevCSS.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.btnPrevCSS.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrevCSS.IconSize = 20;
            this.btnPrevCSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevCSS.Location = new System.Drawing.Point(1103, 8);
            this.btnPrevCSS.Name = "btnPrevCSS";
            this.btnPrevCSS.Rotation = 0D;
            this.btnPrevCSS.Size = new System.Drawing.Size(30, 25);
            this.btnPrevCSS.TabIndex = 74;
            this.btnPrevCSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevCSS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevCSS.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrevCSS.UseVisualStyleBackColor = false;
            this.btnPrevCSS.Click += new System.EventHandler(this.btnPrevCSS_Click);
            // 
            // btnNextCSS
            // 
            this.btnNextCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextCSS.BackColor = System.Drawing.Color.White;
            this.btnNextCSS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNextCSS.FlatAppearance.BorderSize = 0;
            this.btnNextCSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCSS.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNextCSS.ForeColor = System.Drawing.Color.Black;
            this.btnNextCSS.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.btnNextCSS.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNextCSS.IconSize = 20;
            this.btnNextCSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextCSS.Location = new System.Drawing.Point(1139, 8);
            this.btnNextCSS.Name = "btnNextCSS";
            this.btnNextCSS.Rotation = 0D;
            this.btnNextCSS.Size = new System.Drawing.Size(30, 25);
            this.btnNextCSS.TabIndex = 73;
            this.btnNextCSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextCSS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNextCSS.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNextCSS.UseVisualStyleBackColor = false;
            this.btnNextCSS.Click += new System.EventHandler(this.btnNextCSS_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridTargetCall);
            this.tabPage2.Controls.Add(this.groupBoxSearchFAQ);
            this.tabPage2.Controls.Add(this.tiraGroupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1177, 664);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Target Call";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridTargetCall
            // 
            this.dataGridTargetCall.AllowUserToAddRows = false;
            this.dataGridTargetCall.AllowUserToDeleteRows = false;
            this.dataGridTargetCall.AllowUserToOrderColumns = true;
            this.dataGridTargetCall.AllowUserToResizeColumns = false;
            this.dataGridTargetCall.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridTargetCall.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridTargetCall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTargetCall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridTargetCall.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridTargetCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTargetCall.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridTargetCall.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTargetCall.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTargetCall.ColumnHeadersHeight = 22;
            this.dataGridTargetCall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridTargetCall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.target_call,
            this.target_call_flag,
            this.target_call_create_date});
            this.dataGridTargetCall.EnableHeadersVisualStyles = false;
            this.dataGridTargetCall.Location = new System.Drawing.Point(2, 131);
            this.dataGridTargetCall.Name = "dataGridTargetCall";
            this.dataGridTargetCall.ReadOnly = true;
            this.dataGridTargetCall.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridTargetCall.RowHeadersVisible = false;
            this.dataGridTargetCall.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridTargetCall.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridTargetCall.RowTemplate.Height = 25;
            this.dataGridTargetCall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTargetCall.Size = new System.Drawing.Size(1175, 483);
            this.dataGridTargetCall.TabIndex = 17;
            // 
            // target_call
            // 
            this.target_call.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.target_call.DataPropertyName = "parameter_desc";
            this.target_call.HeaderText = "TARGET CALL / DAY";
            this.target_call.Name = "target_call";
            this.target_call.ReadOnly = true;
            // 
            // target_call_flag
            // 
            this.target_call_flag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.target_call_flag.DataPropertyName = "parameter_drop";
            this.target_call_flag.HeaderText = "FLAG";
            this.target_call_flag.Name = "target_call_flag";
            this.target_call_flag.ReadOnly = true;
            // 
            // target_call_create_date
            // 
            this.target_call_create_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.target_call_create_date.DataPropertyName = "create_date";
            this.target_call_create_date.HeaderText = "CREATE DATE";
            this.target_call_create_date.Name = "target_call_create_date";
            this.target_call_create_date.ReadOnly = true;
            // 
            // groupBoxSearchFAQ
            // 
            this.groupBoxSearchFAQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchFAQ.Controls.Add(this.btnSaveTargetCall);
            this.groupBoxSearchFAQ.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSearchFAQ.Location = new System.Drawing.Point(11, 7);
            this.groupBoxSearchFAQ.Name = "groupBoxSearchFAQ";
            this.groupBoxSearchFAQ.Size = new System.Drawing.Size(1164, 118);
            this.groupBoxSearchFAQ.TabIndex = 16;
            this.groupBoxSearchFAQ.TabStop = false;
            this.groupBoxSearchFAQ.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearchFAQ.TiraTextColor = System.Drawing.Color.Black;
            // 
            // btnSaveTargetCall
            // 
            this.btnSaveTargetCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTargetCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSaveTargetCall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveTargetCall.FlatAppearance.BorderSize = 0;
            this.btnSaveTargetCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTargetCall.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSaveTargetCall.ForeColor = System.Drawing.Color.White;
            this.btnSaveTargetCall.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveTargetCall.IconColor = System.Drawing.Color.White;
            this.btnSaveTargetCall.IconSize = 16;
            this.btnSaveTargetCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTargetCall.Location = new System.Drawing.Point(1088, 75);
            this.btnSaveTargetCall.Name = "btnSaveTargetCall";
            this.btnSaveTargetCall.Rotation = 0D;
            this.btnSaveTargetCall.Size = new System.Drawing.Size(70, 23);
            this.btnSaveTargetCall.TabIndex = 22;
            this.btnSaveTargetCall.Text = "Save";
            this.btnSaveTargetCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTargetCall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveTargetCall.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSaveTargetCall.UseVisualStyleBackColor = false;
            this.btnSaveTargetCall.Click += new System.EventHandler(this.btnSaveTargetCall_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtBoxTargetPerDay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTargetPerDay, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 65);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // txtBoxTargetPerDay
            // 
            this.txtBoxTargetPerDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTargetPerDay.BackColor = System.Drawing.Color.White;
            this.txtBoxTargetPerDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxTargetPerDay.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxTargetPerDay.Location = new System.Drawing.Point(3, 22);
            this.txtBoxTargetPerDay.MaxLength = 255;
            this.txtBoxTargetPerDay.Name = "txtBoxTargetPerDay";
            this.txtBoxTargetPerDay.Size = new System.Drawing.Size(1143, 21);
            this.txtBoxTargetPerDay.TabIndex = 23;
            this.txtBoxTargetPerDay.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxTargetPerDay.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxTargetPerDay.TiraMandatory = false;
            this.txtBoxTargetPerDay.TiraPlaceHolder = "";
            this.txtBoxTargetPerDay.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtBoxTargetPerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTargetPerDay_KeyPress);
            // 
            // lblTargetPerDay
            // 
            this.lblTargetPerDay.AutoSize = true;
            this.lblTargetPerDay.Location = new System.Drawing.Point(3, 0);
            this.lblTargetPerDay.Name = "lblTargetPerDay";
            this.lblTargetPerDay.Size = new System.Drawing.Size(79, 13);
            this.lblTargetPerDay.TabIndex = 24;
            this.lblTargetPerDay.Text = "Target Per Day";
            // 
            // tiraGroupBox6
            // 
            this.tiraGroupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiraGroupBox6.Controls.Add(this.lblPagingInfoTC);
            this.tiraGroupBox6.Controls.Add(this.lblRowsTC);
            this.tiraGroupBox6.Controls.Add(this.btnPrevTC);
            this.tiraGroupBox6.Controls.Add(this.btnNextTC);
            this.tiraGroupBox6.Location = new System.Drawing.Point(0, 620);
            this.tiraGroupBox6.Name = "tiraGroupBox6";
            this.tiraGroupBox6.Size = new System.Drawing.Size(1175, 35);
            this.tiraGroupBox6.TabIndex = 15;
            this.tiraGroupBox6.TabStop = false;
            this.tiraGroupBox6.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraGroupBox6.TiraTextColor = System.Drawing.Color.Black;
            // 
            // lblPagingInfoTC
            // 
            this.lblPagingInfoTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPagingInfoTC.AutoSize = true;
            this.lblPagingInfoTC.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagingInfoTC.Location = new System.Drawing.Point(8, 14);
            this.lblPagingInfoTC.Name = "lblPagingInfoTC";
            this.lblPagingInfoTC.Size = new System.Drawing.Size(38, 13);
            this.lblPagingInfoTC.TabIndex = 72;
            this.lblPagingInfoTC.Text = "label6";
            // 
            // lblRowsTC
            // 
            this.lblRowsTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowsTC.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsTC.ForeColor = System.Drawing.Color.Black;
            this.lblRowsTC.Location = new System.Drawing.Point(151, 14);
            this.lblRowsTC.Name = "lblRowsTC";
            this.lblRowsTC.Size = new System.Drawing.Size(106, 13);
            this.lblRowsTC.TabIndex = 71;
            this.lblRowsTC.Text = "Records : 0";
            this.lblRowsTC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPrevTC
            // 
            this.btnPrevTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevTC.BackColor = System.Drawing.Color.White;
            this.btnPrevTC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevTC.FlatAppearance.BorderSize = 0;
            this.btnPrevTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevTC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrevTC.ForeColor = System.Drawing.Color.Black;
            this.btnPrevTC.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.btnPrevTC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrevTC.IconSize = 20;
            this.btnPrevTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevTC.Location = new System.Drawing.Point(1103, 8);
            this.btnPrevTC.Name = "btnPrevTC";
            this.btnPrevTC.Rotation = 0D;
            this.btnPrevTC.Size = new System.Drawing.Size(30, 25);
            this.btnPrevTC.TabIndex = 74;
            this.btnPrevTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevTC.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrevTC.UseVisualStyleBackColor = false;
            this.btnPrevTC.Click += new System.EventHandler(this.btnPrevTC_Click);
            // 
            // btnNextTC
            // 
            this.btnNextTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextTC.BackColor = System.Drawing.Color.White;
            this.btnNextTC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNextTC.FlatAppearance.BorderSize = 0;
            this.btnNextTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNextTC.ForeColor = System.Drawing.Color.Black;
            this.btnNextTC.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.btnNextTC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNextTC.IconSize = 20;
            this.btnNextTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextTC.Location = new System.Drawing.Point(1139, 8);
            this.btnNextTC.Name = "btnNextTC";
            this.btnNextTC.Rotation = 0D;
            this.btnNextTC.Size = new System.Drawing.Size(30, 25);
            this.btnNextTC.TabIndex = 73;
            this.btnNextTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNextTC.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNextTC.UseVisualStyleBackColor = false;
            this.btnNextTC.Click += new System.EventHandler(this.btnNextTC_Click);
            // 
            // lblDrop
            // 
            this.lblDrop.AutoSize = true;
            this.lblDrop.Location = new System.Drawing.Point(30, 143);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(30, 13);
            this.lblDrop.TabIndex = 387;
            this.lblDrop.Text = "Drop";
            // 
            // cbDrop
            // 
            this.cbDrop.Location = new System.Drawing.Point(146, 143);
            this.cbDrop.Name = "cbDrop";
            this.cbDrop.Size = new System.Drawing.Size(100, 20);
            this.cbDrop.TabIndex = 386;
            this.cbDrop.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cbDrop.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 101);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 385;
            this.lblCategory.Text = "Category";
            // 
            // txtBoxStatusDesc
            // 
            this.txtBoxStatusDesc.BackColor = System.Drawing.Color.White;
            this.txtBoxStatusDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxStatusDesc.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxStatusDesc.Location = new System.Drawing.Point(146, 67);
            this.txtBoxStatusDesc.MaxLength = 255;
            this.txtBoxStatusDesc.Name = "txtBoxStatusDesc";
            this.txtBoxStatusDesc.Size = new System.Drawing.Size(401, 23);
            this.txtBoxStatusDesc.TabIndex = 382;
            this.txtBoxStatusDesc.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxStatusDesc.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxStatusDesc.TiraMandatory = false;
            this.txtBoxStatusDesc.TiraPlaceHolder = null;
            this.txtBoxStatusDesc.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.White;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(146, 105);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(401, 23);
            this.cboCategory.TabIndex = 380;
            this.cboCategory.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboCategory.TiraMandatory = false;
            this.cboCategory.TiraPlaceHolder = null;
            // 
            // cboPhase
            // 
            this.cboPhase.BackColor = System.Drawing.Color.White;
            this.cboPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboPhase.ForeColor = System.Drawing.Color.DimGray;
            this.cboPhase.FormattingEnabled = true;
            this.cboPhase.Location = new System.Drawing.Point(146, 30);
            this.cboPhase.Name = "cboPhase";
            this.cboPhase.Size = new System.Drawing.Size(401, 23);
            this.cboPhase.TabIndex = 378;
            this.cboPhase.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboPhase.TiraMandatory = false;
            this.cboPhase.TiraPlaceHolder = null;
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.AutoSize = true;
            this.lblStatusDesc.Location = new System.Drawing.Point(30, 67);
            this.lblStatusDesc.Name = "lblStatusDesc";
            this.lblStatusDesc.Size = new System.Drawing.Size(65, 13);
            this.lblStatusDesc.TabIndex = 372;
            this.lblStatusDesc.Text = "Status Desc";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(30, 30);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(37, 13);
            this.lblPhase.TabIndex = 371;
            this.lblPhase.Text = "Phase";
            // 
            // btnSaveCST
            // 
            this.btnSaveCST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSaveCST.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveCST.FlatAppearance.BorderSize = 0;
            this.btnSaveCST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCST.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSaveCST.ForeColor = System.Drawing.Color.White;
            this.btnSaveCST.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveCST.IconColor = System.Drawing.Color.White;
            this.btnSaveCST.IconSize = 20;
            this.btnSaveCST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCST.Location = new System.Drawing.Point(466, 177);
            this.btnSaveCST.Name = "btnSaveCST";
            this.btnSaveCST.Rotation = 0D;
            this.btnSaveCST.Size = new System.Drawing.Size(80, 30);
            this.btnSaveCST.TabIndex = 39;
            this.btnSaveCST.Text = "Save";
            this.btnSaveCST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveCST.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSaveCST.UseVisualStyleBackColor = false;
            this.btnSaveCST.Click += new System.EventHandler(this.btnSaveCST_Click);
            // 
            // btnCancelCST
            // 
            this.btnCancelCST.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelCST.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelCST.FlatAppearance.BorderSize = 0;
            this.btnCancelCST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCST.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelCST.ForeColor = System.Drawing.Color.Black;
            this.btnCancelCST.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelCST.IconColor = System.Drawing.Color.Black;
            this.btnCancelCST.IconSize = 20;
            this.btnCancelCST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelCST.Location = new System.Drawing.Point(380, 177);
            this.btnCancelCST.Name = "btnCancelCST";
            this.btnCancelCST.Rotation = 0D;
            this.btnCancelCST.Size = new System.Drawing.Size(80, 30);
            this.btnCancelCST.TabIndex = 40;
            this.btnCancelCST.Text = "Cancel";
            this.btnCancelCST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelCST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelCST.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnCancelCST.UseVisualStyleBackColor = false;
            this.btnCancelCST.Click += new System.EventHandler(this.btnCancelCST_Click);
            // 
            // btnUpdateCST
            // 
            this.btnUpdateCST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnUpdateCST.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateCST.FlatAppearance.BorderSize = 0;
            this.btnUpdateCST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCST.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdateCST.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCST.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnUpdateCST.IconColor = System.Drawing.Color.White;
            this.btnUpdateCST.IconSize = 20;
            this.btnUpdateCST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCST.Location = new System.Drawing.Point(466, 177);
            this.btnUpdateCST.Name = "btnUpdateCST";
            this.btnUpdateCST.Rotation = 0D;
            this.btnUpdateCST.Size = new System.Drawing.Size(80, 30);
            this.btnUpdateCST.TabIndex = 41;
            this.btnUpdateCST.Text = "Update";
            this.btnUpdateCST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateCST.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnUpdateCST.UseVisualStyleBackColor = false;
            this.btnUpdateCST.Click += new System.EventHandler(this.btnUpdateCST_Click);
            // 
            // SO_TelemarketingParameterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 747);
            this.Controls.Add(this.panelNew);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "SO_TelemarketingParameterUI";
            this.Text = "SO_TelemarketingParameterUI";
            this.Load += new System.EventHandler(this.SO_TelemarketingParameterUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.tabControlTelemarketingParameter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCallStatusSetting)).EndInit();
            this.groupBoxSearchCSS.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tiraGroupBox4.ResumeLayout(false);
            this.tiraGroupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTargetCall)).EndInit();
            this.groupBoxSearchFAQ.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tiraGroupBox6.ResumeLayout(false);
            this.tiraGroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Tira.Component.TiraButton navClose;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.Label lblDrop;
        private Tira.Component.TiraCheckBox cbDrop;
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraTabControl tabControlTelemarketingParameter;
        private System.Windows.Forms.TabPage tabPage1;
        private Tira.Component.TiraDataGrid dataGridCallStatusSetting;
        private Tira.Component.TiraGroupBox groupBoxSearchCSS;
        private Tira.Component.TiraComboBox cboSearchCategory;
        private Tira.Component.TiraComboBox cboSearchPhase;
        private Tira.Component.TiraButton btnSearchCSS;
        private Tira.Component.TiraGroupBox tiraGroupBox4;
        internal System.Windows.Forms.Label lblPagingInfoCSS;
        internal System.Windows.Forms.Label lblRowsCSS;
        private Tira.Component.TiraButton btnPrevCSS;
        private Tira.Component.TiraButton btnNextCSS;
        private System.Windows.Forms.TabPage tabPage2;
        private Tira.Component.TiraDataGrid dataGridTargetCall;
        private Tira.Component.TiraGroupBox groupBoxSearchFAQ;
        private Tira.Component.TiraTextBox txtBoxTargetPerDay;
        private Tira.Component.TiraButton btnSaveTargetCall;
        private Tira.Component.TiraGroupBox tiraGroupBox6;
        internal System.Windows.Forms.Label lblPagingInfoTC;
        internal System.Windows.Forms.Label lblRowsTC;
        private Tira.Component.TiraButton btnPrevTC;
        private Tira.Component.TiraButton btnNextTC;
        private System.Windows.Forms.Label lblCategory;
        private Tira.Component.TiraTextBox txtBoxStatusDesc;
        private Tira.Component.TiraComboBox cboCategory;
        private Tira.Component.TiraComboBox cboPhase;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Label lblPhase;
        private Tira.Component.TiraButton btnSaveCST;
        private Tira.Component.TiraButton btnCancelCST;
        private Tira.Component.TiraButton btnUpdateCST;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn phase;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn drop;
        private System.Windows.Forms.DataGridViewTextBoxColumn target_call;
        private System.Windows.Forms.DataGridViewTextBoxColumn target_call_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn target_call_create_date;
        private System.Windows.Forms.BindingSource bindingObj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSearchPhase;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTargetPerDay;
    }
}