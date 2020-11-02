namespace MADITP2._0.UserInterface.IM.IMWarehouseSecurity
{
    partial class IMWarehouseSecurityUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navExport = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.PanelFormList = new System.Windows.Forms.Panel();
            this.tiraGroupBox1 = new Tira.Component.TiraGroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new Tira.Component.TiraButton();
            this.txtFilterSearch = new Tira.Component.TiraTextBox();
            this.cmbFilterUser = new Tira.Component.TiraComboBox();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.txtPagingInfo = new System.Windows.Forms.Label();
            this.PanelFormCreate = new System.Windows.Forms.Panel();
            this.tiraButton1 = new Tira.Component.TiraButton();
            this.cmbUserID = new Tira.Component.TiraComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWarehouseDescription = new Tira.Component.TiraTextBox();
            this.chkReceiptEntry = new Tira.Component.TiraCheckBox();
            this.chkShipmentEntry = new Tira.Component.TiraCheckBox();
            this.chkReleasePhisical = new Tira.Component.TiraCheckBox();
            this.chkInitialPhisical = new Tira.Component.TiraCheckBox();
            this.chkTransferAllowed = new Tira.Component.TiraCheckBox();
            this.chkInputAllowed = new Tira.Component.TiraCheckBox();
            this.buttonCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWarehouseID = new Tira.Component.TiraTextBox();
            this.panelTopMenu.SuspendLayout();
            this.PanelFormList.SuspendLayout();
            this.tiraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.PanelFormCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.White;
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navDelete);
            this.panelTopMenu.Controls.Add(this.navEdit);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(946, 30);
            this.panelTopMenu.TabIndex = 485;
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
            this.navExport.TabIndex = 7;
            this.navExport.Text = "Export";
            this.navExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navExport.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navExport.UseVisualStyleBackColor = false;
            this.navExport.Click += new System.EventHandler(this.navExport_Click);
            // 
            // navDelete
            // 
            this.navDelete.BackColor = System.Drawing.Color.White;
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
            this.navDelete.UseVisualStyleBackColor = true;
            this.navDelete.Click += new System.EventHandler(this.navDelete_Click);
            // 
            // navEdit
            // 
            this.navEdit.BackColor = System.Drawing.Color.White;
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
            this.navEdit.UseVisualStyleBackColor = true;
            this.navEdit.Click += new System.EventHandler(this.navEdit_Click);
            // 
            // navNew
            // 
            this.navNew.BackColor = System.Drawing.Color.White;
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
            this.navNew.UseVisualStyleBackColor = true;
            this.navNew.Click += new System.EventHandler(this.navNew_Click);
            // 
            // navView
            // 
            this.navView.BackColor = System.Drawing.Color.White;
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
            this.navView.UseVisualStyleBackColor = true;
            this.navView.Click += new System.EventHandler(this.navView_Click);
            // 
            // PanelFormList
            // 
            this.PanelFormList.BackColor = System.Drawing.Color.White;
            this.PanelFormList.Controls.Add(this.tiraGroupBox1);
            this.PanelFormList.Controls.Add(this.dgvResult);
            this.PanelFormList.Controls.Add(this.btnPrev);
            this.PanelFormList.Controls.Add(this.btnNext);
            this.PanelFormList.Controls.Add(this.txtPagingInfo);
            this.PanelFormList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormList.Location = new System.Drawing.Point(0, 30);
            this.PanelFormList.Name = "PanelFormList";
            this.PanelFormList.Size = new System.Drawing.Size(946, 521);
            this.PanelFormList.TabIndex = 486;
            // 
            // tiraGroupBox1
            // 
            this.tiraGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiraGroupBox1.Controls.Add(this.label20);
            this.tiraGroupBox1.Controls.Add(this.label19);
            this.tiraGroupBox1.Controls.Add(this.btnSearch);
            this.tiraGroupBox1.Controls.Add(this.txtFilterSearch);
            this.tiraGroupBox1.Controls.Add(this.cmbFilterUser);
            this.tiraGroupBox1.Location = new System.Drawing.Point(21, 6);
            this.tiraGroupBox1.Name = "tiraGroupBox1";
            this.tiraGroupBox1.Size = new System.Drawing.Size(861, 82);
            this.tiraGroupBox1.TabIndex = 5;
            this.tiraGroupBox1.TabStop = false;
            this.tiraGroupBox1.Text = "Filter";
            this.tiraGroupBox1.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraGroupBox1.TiraTextColor = System.Drawing.Color.Black;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(264, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "User";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconSize = 20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(755, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterSearch
            // 
            this.txtFilterSearch.BackColor = System.Drawing.Color.White;
            this.txtFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtFilterSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilterSearch.Location = new System.Drawing.Point(9, 50);
            this.txtFilterSearch.MaxLength = 255;
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(240, 23);
            this.txtFilterSearch.TabIndex = 3;
            this.txtFilterSearch.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtFilterSearch.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtFilterSearch.TiraMandatory = false;
            this.txtFilterSearch.TiraPlaceHolder = null;
            this.txtFilterSearch.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtFilterSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyUp);
            // 
            // cmbFilterUser
            // 
            this.cmbFilterUser.BackColor = System.Drawing.Color.White;
            this.cmbFilterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbFilterUser.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFilterUser.FormattingEnabled = true;
            this.cmbFilterUser.Location = new System.Drawing.Point(265, 50);
            this.cmbFilterUser.Name = "cmbFilterUser";
            this.cmbFilterUser.Size = new System.Drawing.Size(228, 23);
            this.cmbFilterUser.TabIndex = 2;
            this.cmbFilterUser.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbFilterUser.TiraMandatory = false;
            this.cmbFilterUser.TiraPlaceHolder = null;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvResult.ColumnHeadersHeight = 22;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column28,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(22, 94);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(860, 363);
            this.dgvResult.TabIndex = 4;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "User_id";
            this.Column28.HeaderText = "User ID";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            this.Column28.Width = 66;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Warehouse_id";
            this.Column2.HeaderText = "Warehouse ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Input_txn_allow";
            this.Column3.HeaderText = "Input Allowed";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 94;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Transfer_txn_allow";
            this.Column4.HeaderText = "Transfer Allowed";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 109;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Initial_physical";
            this.Column5.HeaderText = "Initial Physical";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 96;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Realese_physical";
            this.Column6.HeaderText = "Realese Physical";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 111;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Shipment_entry";
            this.Column7.HeaderText = "Shipment Entry";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 101;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Receipt_entry";
            this.Column8.HeaderText = "Receipt Entry";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 94;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.btnPrev.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrev.IconSize = 20;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(820, 463);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Rotation = 0D;
            this.btnPrev.Size = new System.Drawing.Size(27, 31);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.btnNext.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNext.IconSize = 20;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(852, 464);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPagingInfo
            // 
            this.txtPagingInfo.AutoSize = true;
            this.txtPagingInfo.Location = new System.Drawing.Point(18, 473);
            this.txtPagingInfo.Name = "txtPagingInfo";
            this.txtPagingInfo.Size = new System.Drawing.Size(66, 13);
            this.txtPagingInfo.TabIndex = 3;
            this.txtPagingInfo.Text = "_page_info_";
            // 
            // PanelFormCreate
            // 
            this.PanelFormCreate.Controls.Add(this.tiraButton1);
            this.PanelFormCreate.Controls.Add(this.cmbUserID);
            this.PanelFormCreate.Controls.Add(this.label4);
            this.PanelFormCreate.Controls.Add(this.txtWarehouseDescription);
            this.PanelFormCreate.Controls.Add(this.chkReceiptEntry);
            this.PanelFormCreate.Controls.Add(this.chkShipmentEntry);
            this.PanelFormCreate.Controls.Add(this.chkReleasePhisical);
            this.PanelFormCreate.Controls.Add(this.chkInitialPhisical);
            this.PanelFormCreate.Controls.Add(this.chkTransferAllowed);
            this.PanelFormCreate.Controls.Add(this.chkInputAllowed);
            this.PanelFormCreate.Controls.Add(this.buttonCancel);
            this.PanelFormCreate.Controls.Add(this.btnSave);
            this.PanelFormCreate.Controls.Add(this.label7);
            this.PanelFormCreate.Controls.Add(this.label6);
            this.PanelFormCreate.Controls.Add(this.txtWarehouseID);
            this.PanelFormCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormCreate.Location = new System.Drawing.Point(0, 30);
            this.PanelFormCreate.Name = "PanelFormCreate";
            this.PanelFormCreate.Size = new System.Drawing.Size(946, 521);
            this.PanelFormCreate.TabIndex = 487;
            // 
            // tiraButton1
            // 
            this.tiraButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tiraButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tiraButton1.FlatAppearance.BorderSize = 0;
            this.tiraButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiraButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.tiraButton1.ForeColor = System.Drawing.Color.Black;
            this.tiraButton1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.tiraButton1.IconColor = System.Drawing.Color.White;
            this.tiraButton1.IconSize = 20;
            this.tiraButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tiraButton1.Location = new System.Drawing.Point(216, 73);
            this.tiraButton1.Name = "tiraButton1";
            this.tiraButton1.Rotation = 0D;
            this.tiraButton1.Size = new System.Drawing.Size(32, 23);
            this.tiraButton1.TabIndex = 1;
            this.tiraButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tiraButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tiraButton1.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraButton1.UseVisualStyleBackColor = false;
            this.tiraButton1.Click += new System.EventHandler(this.tiraButton1_Click);
            // 
            // cmbUserID
            // 
            this.cmbUserID.BackColor = System.Drawing.Color.White;
            this.cmbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbUserID.ForeColor = System.Drawing.Color.DimGray;
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(12, 26);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(236, 23);
            this.cmbUserID.TabIndex = 106;
            this.cmbUserID.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbUserID.TiraMandatory = false;
            this.cmbUserID.TiraPlaceHolder = null;
            this.cmbUserID.SelectedIndexChanged += new System.EventHandler(this.tiraComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Warehouse Description";
            // 
            // txtWarehouseDescription
            // 
            this.txtWarehouseDescription.BackColor = System.Drawing.Color.White;
            this.txtWarehouseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtWarehouseDescription.ForeColor = System.Drawing.Color.DimGray;
            this.txtWarehouseDescription.Location = new System.Drawing.Point(267, 73);
            this.txtWarehouseDescription.MaxLength = 33;
            this.txtWarehouseDescription.Name = "txtWarehouseDescription";
            this.txtWarehouseDescription.Size = new System.Drawing.Size(240, 23);
            this.txtWarehouseDescription.TabIndex = 104;
            this.txtWarehouseDescription.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtWarehouseDescription.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtWarehouseDescription.TiraMandatory = false;
            this.txtWarehouseDescription.TiraPlaceHolder = null;
            this.txtWarehouseDescription.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtWarehouseDescription.TextChanged += new System.EventHandler(this.tiraTextBox2_TextChanged);
            // 
            // chkReceiptEntry
            // 
            this.chkReceiptEntry.Location = new System.Drawing.Point(267, 216);
            this.chkReceiptEntry.Name = "chkReceiptEntry";
            this.chkReceiptEntry.Size = new System.Drawing.Size(202, 20);
            this.chkReceiptEntry.TabIndex = 100;
            this.chkReceiptEntry.Text = "Receipt Entry";
            this.chkReceiptEntry.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkReceiptEntry.UseVisualStyleBackColor = true;
            // 
            // chkShipmentEntry
            // 
            this.chkShipmentEntry.Location = new System.Drawing.Point(267, 172);
            this.chkShipmentEntry.Name = "chkShipmentEntry";
            this.chkShipmentEntry.Size = new System.Drawing.Size(202, 20);
            this.chkShipmentEntry.TabIndex = 99;
            this.chkShipmentEntry.Text = "Shipment Entry";
            this.chkShipmentEntry.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkShipmentEntry.UseVisualStyleBackColor = true;
            // 
            // chkReleasePhisical
            // 
            this.chkReleasePhisical.Location = new System.Drawing.Point(267, 128);
            this.chkReleasePhisical.Name = "chkReleasePhisical";
            this.chkReleasePhisical.Size = new System.Drawing.Size(202, 20);
            this.chkReleasePhisical.TabIndex = 98;
            this.chkReleasePhisical.Text = "Release Phisical";
            this.chkReleasePhisical.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkReleasePhisical.UseVisualStyleBackColor = true;
            // 
            // chkInitialPhisical
            // 
            this.chkInitialPhisical.Location = new System.Drawing.Point(12, 216);
            this.chkInitialPhisical.Name = "chkInitialPhisical";
            this.chkInitialPhisical.Size = new System.Drawing.Size(202, 20);
            this.chkInitialPhisical.TabIndex = 97;
            this.chkInitialPhisical.Text = "Initial Phisical";
            this.chkInitialPhisical.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkInitialPhisical.UseVisualStyleBackColor = true;
            // 
            // chkTransferAllowed
            // 
            this.chkTransferAllowed.Location = new System.Drawing.Point(12, 172);
            this.chkTransferAllowed.Name = "chkTransferAllowed";
            this.chkTransferAllowed.Size = new System.Drawing.Size(202, 20);
            this.chkTransferAllowed.TabIndex = 96;
            this.chkTransferAllowed.Text = "Transfer Allowed";
            this.chkTransferAllowed.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkTransferAllowed.UseVisualStyleBackColor = true;
            // 
            // chkInputAllowed
            // 
            this.chkInputAllowed.Location = new System.Drawing.Point(12, 128);
            this.chkInputAllowed.Name = "chkInputAllowed";
            this.chkInputAllowed.Size = new System.Drawing.Size(202, 20);
            this.chkInputAllowed.TabIndex = 95;
            this.chkInputAllowed.Text = "Input Allowed";
            this.chkInputAllowed.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkInputAllowed.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.buttonCancel.IconColor = System.Drawing.Color.Black;
            this.buttonCancel.IconSize = 20;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(349, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Rotation = 0D;
            this.buttonCancel.Size = new System.Drawing.Size(70, 30);
            this.buttonCancel.TabIndex = 66;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 20;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(425, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(82, 30);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Warehouse ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "User ID";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.BackColor = System.Drawing.Color.White;
            this.txtWarehouseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtWarehouseID.ForeColor = System.Drawing.Color.DimGray;
            this.txtWarehouseID.Location = new System.Drawing.Point(12, 73);
            this.txtWarehouseID.MaxLength = 33;
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(198, 23);
            this.txtWarehouseID.TabIndex = 60;
            this.txtWarehouseID.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtWarehouseID.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtWarehouseID.TiraMandatory = false;
            this.txtWarehouseID.TiraPlaceHolder = null;
            this.txtWarehouseID.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtWarehouseID.TextChanged += new System.EventHandler(this.txtSAPCode_TextChanged);
            // 
            // IMWarehouseSecurityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 551);
            this.Controls.Add(this.PanelFormCreate);
            this.Controls.Add(this.PanelFormList);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "IMWarehouseSecurityUI";
            this.Text = "Warehouse Security";
            this.Load += new System.EventHandler(this.IMWarehouseSecurityUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.PanelFormList.ResumeLayout(false);
            this.PanelFormList.PerformLayout();
            this.tiraGroupBox1.ResumeLayout(false);
            this.tiraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.PanelFormCreate.ResumeLayout(false);
            this.PanelFormCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel PanelFormList;
        private Tira.Component.TiraGroupBox tiraGroupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private Tira.Component.TiraButton btnSearch;
        private Tira.Component.TiraTextBox txtFilterSearch;
        private Tira.Component.TiraComboBox cmbFilterUser;
        private Tira.Component.TiraDataGrid dgvResult;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private System.Windows.Forms.Label txtPagingInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel PanelFormCreate;
        private Tira.Component.TiraComboBox cmbUserID;
        private System.Windows.Forms.Label label4;
        private Tira.Component.TiraTextBox txtWarehouseDescription;
        private Tira.Component.TiraCheckBox chkReceiptEntry;
        private Tira.Component.TiraCheckBox chkShipmentEntry;
        private Tira.Component.TiraCheckBox chkReleasePhisical;
        private Tira.Component.TiraCheckBox chkInitialPhisical;
        private Tira.Component.TiraCheckBox chkTransferAllowed;
        private Tira.Component.TiraCheckBox chkInputAllowed;
        private Tira.Component.TiraButton buttonCancel;
        private Tira.Component.TiraButton btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Tira.Component.TiraTextBox txtWarehouseID;
        private Tira.Component.TiraButton tiraButton1;
        private Tira.Component.TiraButton navExport;
    }
}