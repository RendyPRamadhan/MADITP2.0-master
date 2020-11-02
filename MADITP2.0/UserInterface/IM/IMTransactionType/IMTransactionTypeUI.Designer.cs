namespace MADITP2._0.UserInterface.IM.IMTransactionType
{
    partial class IMTransactionTypeUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navExport = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.PanelFormList = new System.Windows.Forms.Panel();
            this.tiraGroupBox1 = new Tira.Component.TiraGroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new Tira.Component.TiraButton();
            this.txtFilterSearch = new Tira.Component.TiraTextBox();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.Txn_type_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txn_type_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txn_type_out_from_transit_ex_pod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txn_type_into_or_wh_ex_pod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.txtPagingInfo = new System.Windows.Forms.Label();
            this.PanelFormCreate = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGl_txn_type = new Tira.Component.TiraTextBox();
            this.chkInterface_to_gl = new Tira.Component.TiraCheckBox();
            this.chkUpdate_stock_movement = new Tira.Component.TiraCheckBox();
            this.chkUpdate_qty_on_hand = new Tira.Component.TiraCheckBox();
            this.chkPromth_cost_field = new Tira.Component.TiraCheckBox();
            this.chkAllow_change_date = new Tira.Component.TiraCheckBox();
            this.chkNegate_qty_entered = new Tira.Component.TiraCheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbIn_out_flag = new Tira.Component.TiraComboBox();
            this.chkAllow_negative_qty_entry = new Tira.Component.TiraCheckBox();
            this.chkAllow_inventory_txn_entry = new Tira.Component.TiraCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTxn_type_description = new Tira.Component.TiraTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTxn_type_code = new Tira.Component.TiraTextBox();
            this.buttonCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
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
            this.panelTopMenu.Size = new System.Drawing.Size(630, 30);
            this.panelTopMenu.TabIndex = 487;
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
            this.PanelFormList.Size = new System.Drawing.Size(630, 520);
            this.PanelFormList.TabIndex = 488;
            // 
            // tiraGroupBox1
            // 
            this.tiraGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiraGroupBox1.Controls.Add(this.label19);
            this.tiraGroupBox1.Controls.Add(this.btnSearch);
            this.tiraGroupBox1.Controls.Add(this.txtFilterSearch);
            this.tiraGroupBox1.Location = new System.Drawing.Point(21, 6);
            this.tiraGroupBox1.Name = "tiraGroupBox1";
            this.tiraGroupBox1.Size = new System.Drawing.Size(597, 82);
            this.tiraGroupBox1.TabIndex = 5;
            this.tiraGroupBox1.TabStop = false;
            this.tiraGroupBox1.Text = "Filter";
            this.tiraGroupBox1.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraGroupBox1.TiraTextColor = System.Drawing.Color.Black;
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
            this.btnSearch.Location = new System.Drawing.Point(491, 50);
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
            this.txtFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSearch.BackColor = System.Drawing.Color.White;
            this.txtFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtFilterSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilterSearch.Location = new System.Drawing.Point(9, 50);
            this.txtFilterSearch.MaxLength = 255;
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(463, 23);
            this.txtFilterSearch.TabIndex = 3;
            this.txtFilterSearch.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtFilterSearch.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtFilterSearch.TiraMandatory = false;
            this.txtFilterSearch.TiraPlaceHolder = null;
            this.txtFilterSearch.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtFilterSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyDown);
            this.txtFilterSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyUp);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.ColumnHeadersHeight = 22;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Txn_type_code,
            this.Txn_type_description,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Txn_type_out_from_transit_ex_pod,
            this.Txn_type_into_or_wh_ex_pod,
            this.Column9,
            this.Column1});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(22, 94);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(596, 363);
            this.dgvResult.TabIndex = 4;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // Txn_type_code
            // 
            this.Txn_type_code.DataPropertyName = "Txn_type_code";
            this.Txn_type_code.HeaderText = "Code";
            this.Txn_type_code.Name = "Txn_type_code";
            this.Txn_type_code.ReadOnly = true;
            this.Txn_type_code.Width = 55;
            // 
            // Txn_type_description
            // 
            this.Txn_type_description.DataPropertyName = "Txn_type_description";
            this.Txn_type_description.HeaderText = "Description";
            this.Txn_type_description.Name = "Txn_type_description";
            this.Txn_type_description.ReadOnly = true;
            this.Txn_type_description.Width = 83;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Allow_inventory_txn_entry";
            this.Column2.HeaderText = "Allow Inventory Transaction Entry";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 188;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Allow_negative_qty_entry";
            this.Column3.HeaderText = "Allow Negative QTY Entry";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 153;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Negate_qty_entered";
            this.Column4.HeaderText = "Negate Qty Entry";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 111;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Allow_change_date";
            this.Column5.HeaderText = "Allow Change Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 121;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Promth_cost_field";
            this.Column6.HeaderText = "Prompth Cost Field";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 118;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Update_qty_on_hand";
            this.Column7.HeaderText = "Update Qty on Hand";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 109;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Update_stock_movement";
            this.Column8.HeaderText = "Update Stock Movement";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 149;
            // 
            // Txn_type_out_from_transit_ex_pod
            // 
            this.Txn_type_out_from_transit_ex_pod.DataPropertyName = "Interface_to_gl";
            this.Txn_type_out_from_transit_ex_pod.HeaderText = "Interface To GL";
            this.Txn_type_out_from_transit_ex_pod.Name = "Txn_type_out_from_transit_ex_pod";
            this.Txn_type_out_from_transit_ex_pod.ReadOnly = true;
            this.Txn_type_out_from_transit_ex_pod.Width = 105;
            // 
            // Txn_type_into_or_wh_ex_pod
            // 
            this.Txn_type_into_or_wh_ex_pod.DataPropertyName = "Gl_txn_type";
            this.Txn_type_into_or_wh_ex_pod.HeaderText = "Transaction Type";
            this.Txn_type_into_or_wh_ex_pod.Name = "Txn_type_into_or_wh_ex_pod";
            this.Txn_type_into_or_wh_ex_pod.ReadOnly = true;
            this.Txn_type_into_or_wh_ex_pod.Width = 113;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "In_out_flag";
            this.Column9.HeaderText = "Flag";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Group_acc";
            this.Column1.HeaderText = "GL Transaction Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnPrev.Location = new System.Drawing.Point(552, 478);
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
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnNext.Location = new System.Drawing.Point(587, 479);
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
            this.txtPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPagingInfo.AutoSize = true;
            this.txtPagingInfo.Location = new System.Drawing.Point(18, 488);
            this.txtPagingInfo.Name = "txtPagingInfo";
            this.txtPagingInfo.Size = new System.Drawing.Size(66, 13);
            this.txtPagingInfo.TabIndex = 3;
            this.txtPagingInfo.Text = "_page_info_";
            // 
            // PanelFormCreate
            // 
            this.PanelFormCreate.BackColor = System.Drawing.Color.White;
            this.PanelFormCreate.Controls.Add(this.label3);
            this.PanelFormCreate.Controls.Add(this.txtGl_txn_type);
            this.PanelFormCreate.Controls.Add(this.chkInterface_to_gl);
            this.PanelFormCreate.Controls.Add(this.chkUpdate_stock_movement);
            this.PanelFormCreate.Controls.Add(this.chkUpdate_qty_on_hand);
            this.PanelFormCreate.Controls.Add(this.chkPromth_cost_field);
            this.PanelFormCreate.Controls.Add(this.chkAllow_change_date);
            this.PanelFormCreate.Controls.Add(this.chkNegate_qty_entered);
            this.PanelFormCreate.Controls.Add(this.label9);
            this.PanelFormCreate.Controls.Add(this.cmbIn_out_flag);
            this.PanelFormCreate.Controls.Add(this.chkAllow_negative_qty_entry);
            this.PanelFormCreate.Controls.Add(this.chkAllow_inventory_txn_entry);
            this.PanelFormCreate.Controls.Add(this.label2);
            this.PanelFormCreate.Controls.Add(this.txtTxn_type_description);
            this.PanelFormCreate.Controls.Add(this.label1);
            this.PanelFormCreate.Controls.Add(this.txtTxn_type_code);
            this.PanelFormCreate.Controls.Add(this.buttonCancel);
            this.PanelFormCreate.Controls.Add(this.btnSave);
            this.PanelFormCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormCreate.Location = new System.Drawing.Point(0, 30);
            this.PanelFormCreate.Name = "PanelFormCreate";
            this.PanelFormCreate.Size = new System.Drawing.Size(630, 520);
            this.PanelFormCreate.TabIndex = 489;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "GL Transaction Type";
            // 
            // txtGl_txn_type
            // 
            this.txtGl_txn_type.BackColor = System.Drawing.Color.White;
            this.txtGl_txn_type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGl_txn_type.ForeColor = System.Drawing.Color.DimGray;
            this.txtGl_txn_type.Location = new System.Drawing.Point(259, 156);
            this.txtGl_txn_type.MaxLength = 3;
            this.txtGl_txn_type.Name = "txtGl_txn_type";
            this.txtGl_txn_type.Size = new System.Drawing.Size(150, 23);
            this.txtGl_txn_type.TabIndex = 96;
            this.txtGl_txn_type.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtGl_txn_type.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtGl_txn_type.TiraMandatory = false;
            this.txtGl_txn_type.TiraPlaceHolder = null;
            this.txtGl_txn_type.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // chkInterface_to_gl
            // 
            this.chkInterface_to_gl.Location = new System.Drawing.Point(18, 336);
            this.chkInterface_to_gl.Name = "chkInterface_to_gl";
            this.chkInterface_to_gl.Size = new System.Drawing.Size(186, 20);
            this.chkInterface_to_gl.TabIndex = 95;
            this.chkInterface_to_gl.Text = "Interface To GL";
            this.chkInterface_to_gl.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkInterface_to_gl.UseVisualStyleBackColor = true;
            // 
            // chkUpdate_stock_movement
            // 
            this.chkUpdate_stock_movement.Location = new System.Drawing.Point(18, 299);
            this.chkUpdate_stock_movement.Name = "chkUpdate_stock_movement";
            this.chkUpdate_stock_movement.Size = new System.Drawing.Size(186, 20);
            this.chkUpdate_stock_movement.TabIndex = 94;
            this.chkUpdate_stock_movement.Text = "Update Stock Movement";
            this.chkUpdate_stock_movement.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkUpdate_stock_movement.UseVisualStyleBackColor = true;
            // 
            // chkUpdate_qty_on_hand
            // 
            this.chkUpdate_qty_on_hand.Location = new System.Drawing.Point(18, 262);
            this.chkUpdate_qty_on_hand.Name = "chkUpdate_qty_on_hand";
            this.chkUpdate_qty_on_hand.Size = new System.Drawing.Size(186, 20);
            this.chkUpdate_qty_on_hand.TabIndex = 93;
            this.chkUpdate_qty_on_hand.Text = "Update Qty On Hand";
            this.chkUpdate_qty_on_hand.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkUpdate_qty_on_hand.UseVisualStyleBackColor = true;
            // 
            // chkPromth_cost_field
            // 
            this.chkPromth_cost_field.Location = new System.Drawing.Point(18, 225);
            this.chkPromth_cost_field.Name = "chkPromth_cost_field";
            this.chkPromth_cost_field.Size = new System.Drawing.Size(186, 20);
            this.chkPromth_cost_field.TabIndex = 92;
            this.chkPromth_cost_field.Text = "Prompth Cost Field";
            this.chkPromth_cost_field.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkPromth_cost_field.UseVisualStyleBackColor = true;
            // 
            // chkAllow_change_date
            // 
            this.chkAllow_change_date.Location = new System.Drawing.Point(18, 188);
            this.chkAllow_change_date.Name = "chkAllow_change_date";
            this.chkAllow_change_date.Size = new System.Drawing.Size(186, 20);
            this.chkAllow_change_date.TabIndex = 91;
            this.chkAllow_change_date.Text = "Allow Change Date";
            this.chkAllow_change_date.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkAllow_change_date.UseVisualStyleBackColor = true;
            // 
            // chkNegate_qty_entered
            // 
            this.chkNegate_qty_entered.Location = new System.Drawing.Point(18, 151);
            this.chkNegate_qty_entered.Name = "chkNegate_qty_entered";
            this.chkNegate_qty_entered.Size = new System.Drawing.Size(186, 20);
            this.chkNegate_qty_entered.TabIndex = 90;
            this.chkNegate_qty_entered.Text = "Negate Qty Entry";
            this.chkNegate_qty_entered.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkNegate_qty_entered.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Transaction Type";
            // 
            // cmbIn_out_flag
            // 
            this.cmbIn_out_flag.BackColor = System.Drawing.Color.White;
            this.cmbIn_out_flag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbIn_out_flag.ForeColor = System.Drawing.Color.DimGray;
            this.cmbIn_out_flag.FormattingEnabled = true;
            this.cmbIn_out_flag.Location = new System.Drawing.Point(259, 94);
            this.cmbIn_out_flag.Name = "cmbIn_out_flag";
            this.cmbIn_out_flag.Size = new System.Drawing.Size(150, 23);
            this.cmbIn_out_flag.TabIndex = 88;
            this.cmbIn_out_flag.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbIn_out_flag.TiraMandatory = false;
            this.cmbIn_out_flag.TiraPlaceHolder = null;
            // 
            // chkAllow_negative_qty_entry
            // 
            this.chkAllow_negative_qty_entry.Location = new System.Drawing.Point(18, 114);
            this.chkAllow_negative_qty_entry.Name = "chkAllow_negative_qty_entry";
            this.chkAllow_negative_qty_entry.Size = new System.Drawing.Size(186, 20);
            this.chkAllow_negative_qty_entry.TabIndex = 87;
            this.chkAllow_negative_qty_entry.Text = "Allow Negative Qty Entry";
            this.chkAllow_negative_qty_entry.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkAllow_negative_qty_entry.UseVisualStyleBackColor = true;
            // 
            // chkAllow_inventory_txn_entry
            // 
            this.chkAllow_inventory_txn_entry.Location = new System.Drawing.Point(18, 77);
            this.chkAllow_inventory_txn_entry.Name = "chkAllow_inventory_txn_entry";
            this.chkAllow_inventory_txn_entry.Size = new System.Drawing.Size(186, 20);
            this.chkAllow_inventory_txn_entry.TabIndex = 73;
            this.chkAllow_inventory_txn_entry.Text = "Allow Inventory Transaction Entry";
            this.chkAllow_inventory_txn_entry.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkAllow_inventory_txn_entry.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Description";
            // 
            // txtTxn_type_description
            // 
            this.txtTxn_type_description.BackColor = System.Drawing.Color.White;
            this.txtTxn_type_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTxn_type_description.ForeColor = System.Drawing.Color.DimGray;
            this.txtTxn_type_description.Location = new System.Drawing.Point(259, 37);
            this.txtTxn_type_description.MaxLength = 255;
            this.txtTxn_type_description.Name = "txtTxn_type_description";
            this.txtTxn_type_description.Size = new System.Drawing.Size(334, 23);
            this.txtTxn_type_description.TabIndex = 71;
            this.txtTxn_type_description.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTxn_type_description.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTxn_type_description.TiraMandatory = false;
            this.txtTxn_type_description.TiraPlaceHolder = null;
            this.txtTxn_type_description.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Code";
            // 
            // txtTxn_type_code
            // 
            this.txtTxn_type_code.BackColor = System.Drawing.Color.White;
            this.txtTxn_type_code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTxn_type_code.ForeColor = System.Drawing.Color.DimGray;
            this.txtTxn_type_code.Location = new System.Drawing.Point(18, 37);
            this.txtTxn_type_code.MaxLength = 255;
            this.txtTxn_type_code.Name = "txtTxn_type_code";
            this.txtTxn_type_code.Size = new System.Drawing.Size(150, 23);
            this.txtTxn_type_code.TabIndex = 69;
            this.txtTxn_type_code.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTxn_type_code.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTxn_type_code.TiraMandatory = false;
            this.txtTxn_type_code.TiraPlaceHolder = null;
            this.txtTxn_type_code.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
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
            this.buttonCancel.Location = new System.Drawing.Point(454, 474);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Rotation = 0D;
            this.buttonCancel.Size = new System.Drawing.Size(70, 30);
            this.buttonCancel.TabIndex = 68;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonCancel.UseVisualStyleBackColor = false;
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
            this.btnSave.Location = new System.Drawing.Point(530, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(82, 30);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IMTransactionTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 550);
            this.Controls.Add(this.PanelFormCreate);
            this.Controls.Add(this.PanelFormList);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "IMTransactionTypeUI";
            this.Text = "Transaction Type";
            this.Load += new System.EventHandler(this.IMTransactionTypeUI_Load);
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
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel PanelFormList;
        private Tira.Component.TiraGroupBox tiraGroupBox1;
        private System.Windows.Forms.Label label19;
        private Tira.Component.TiraButton btnSearch;
        private Tira.Component.TiraTextBox txtFilterSearch;
        private Tira.Component.TiraDataGrid dgvResult;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private System.Windows.Forms.Label txtPagingInfo;
        private System.Windows.Forms.Panel PanelFormCreate;
        private System.Windows.Forms.Label label9;
        private Tira.Component.TiraComboBox cmbIn_out_flag;
        private Tira.Component.TiraCheckBox chkAllow_negative_qty_entry;
        private Tira.Component.TiraCheckBox chkAllow_inventory_txn_entry;
        private System.Windows.Forms.Label label2;
        private Tira.Component.TiraTextBox txtTxn_type_description;
        private System.Windows.Forms.Label label1;
        private Tira.Component.TiraTextBox txtTxn_type_code;
        private Tira.Component.TiraButton buttonCancel;
        private Tira.Component.TiraButton btnSave;
        private System.Windows.Forms.Label label3;
        private Tira.Component.TiraTextBox txtGl_txn_type;
        private Tira.Component.TiraCheckBox chkInterface_to_gl;
        private Tira.Component.TiraCheckBox chkUpdate_stock_movement;
        private Tira.Component.TiraCheckBox chkUpdate_qty_on_hand;
        private Tira.Component.TiraCheckBox chkPromth_cost_field;
        private Tira.Component.TiraCheckBox chkAllow_change_date;
        private Tira.Component.TiraCheckBox chkNegate_qty_entered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txn_type_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txn_type_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txn_type_out_from_transit_ex_pod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txn_type_into_or_wh_ex_pod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}