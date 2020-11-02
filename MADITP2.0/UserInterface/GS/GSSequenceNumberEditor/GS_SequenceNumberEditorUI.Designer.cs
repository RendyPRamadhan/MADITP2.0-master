namespace MADITP2._0.UserInterface.GS.GSSequenceNumberEditor
{
    partial class GS_SequenceNumberEditorUI
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
            this.panelView = new System.Windows.Forms.Panel();
            this.groupBoxSearch = new Tira.Component.TiraGroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchModuleTable = new System.Windows.Forms.Label();
            this.cbSearchModuleTable = new Tira.Component.TiraComboBox();
            this.buttonSearch = new Tira.Component.TiraButton();
            this.groupBoxPaging = new Tira.Component.TiraGroupBox();
            this.lblPagingInfo = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.dataGridSequenceNumberEditor = new Tira.Component.TiraDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNew = new System.Windows.Forms.Panel();
            this.btnCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.btnUpdate = new Tira.Component.TiraButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSequenceNoIdentifier = new System.Windows.Forms.Label();
            this.txtBoxSequenceNoIdentifier = new Tira.Component.TiraTextBox();
            this.lblMandatoryBranchID = new System.Windows.Forms.Label();
            this.lblNextSequenceNumber = new System.Windows.Forms.Label();
            this.txtBoxNextSequenceNumber = new Tira.Component.TiraTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinimumNumber = new System.Windows.Forms.Label();
            this.txtBoxMinumumNumber = new Tira.Component.TiraTextBox();
            this.lblMaximumNumber = new System.Windows.Forms.Label();
            this.txtBoxMaximumNumber = new Tira.Component.TiraTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingObjSequenceNumberEditor = new System.Windows.Forms.BindingSource(this.components);
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navClose = new Tira.Component.TiraButton();
            this.navExport = new Tira.Component.TiraButton();
            this.navPrint = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelView.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxPaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSequenceNumberEditor)).BeginInit();
            this.panelNew.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjSequenceNumberEditor)).BeginInit();
            this.panelTopMenu.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.White;
            this.panelView.Controls.Add(this.groupBoxSearch);
            this.panelView.Controls.Add(this.groupBoxPaging);
            this.panelView.Controls.Add(this.dataGridSequenceNumberEditor);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1203, 717);
            this.panelView.TabIndex = 13;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 18);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1175, 144);
            this.groupBoxSearch.TabIndex = 10;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Filter";
            this.groupBoxSearch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearch.TiraTextColor = System.Drawing.Color.Black;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblSearchModuleTable, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbSearchModuleTable, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1154, 68);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // lblSearchModuleTable
            // 
            this.lblSearchModuleTable.AutoSize = true;
            this.lblSearchModuleTable.Location = new System.Drawing.Point(3, 0);
            this.lblSearchModuleTable.Name = "lblSearchModuleTable";
            this.lblSearchModuleTable.Size = new System.Drawing.Size(72, 13);
            this.lblSearchModuleTable.TabIndex = 0;
            this.lblSearchModuleTable.Text = "Module Table";
            // 
            // cbSearchModuleTable
            // 
            this.cbSearchModuleTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchModuleTable.BackColor = System.Drawing.Color.White;
            this.cbSearchModuleTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbSearchModuleTable.ForeColor = System.Drawing.Color.DimGray;
            this.cbSearchModuleTable.FormattingEnabled = true;
            this.cbSearchModuleTable.Location = new System.Drawing.Point(3, 23);
            this.cbSearchModuleTable.Name = "cbSearchModuleTable";
            this.cbSearchModuleTable.Size = new System.Drawing.Size(1148, 23);
            this.cbSearchModuleTable.TabIndex = 25;
            this.cbSearchModuleTable.Text = "Module Table";
            this.cbSearchModuleTable.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cbSearchModuleTable.TiraMandatory = false;
            this.cbSearchModuleTable.TiraPlaceHolder = "Module Table";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.White;
            this.buttonSearch.IconSize = 16;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(1092, 102);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Rotation = 0D;
            this.buttonSearch.Size = new System.Drawing.Size(70, 23);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxPaging
            // 
            this.groupBoxPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPaging.Controls.Add(this.lblPagingInfo);
            this.groupBoxPaging.Controls.Add(this.lblRows);
            this.groupBoxPaging.Controls.Add(this.btnPrev);
            this.groupBoxPaging.Controls.Add(this.btnNext);
            this.groupBoxPaging.Location = new System.Drawing.Point(12, 671);
            this.groupBoxPaging.Name = "groupBoxPaging";
            this.groupBoxPaging.Size = new System.Drawing.Size(1175, 35);
            this.groupBoxPaging.TabIndex = 12;
            this.groupBoxPaging.TabStop = false;
            this.groupBoxPaging.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxPaging.TiraTextColor = System.Drawing.Color.Black;
            // 
            // lblPagingInfo
            // 
            this.lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPagingInfo.AutoSize = true;
            this.lblPagingInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagingInfo.Location = new System.Drawing.Point(8, 14);
            this.lblPagingInfo.Name = "lblPagingInfo";
            this.lblPagingInfo.Size = new System.Drawing.Size(75, 13);
            this.lblPagingInfo.TabIndex = 72;
            this.lblPagingInfo.Text = "lblPagingInfo";
            // 
            // lblRows
            // 
            this.lblRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRows.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.ForeColor = System.Drawing.Color.Black;
            this.lblRows.Location = new System.Drawing.Point(151, 14);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(106, 13);
            this.lblRows.TabIndex = 71;
            this.lblRows.Text = "Records : 0";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.btnPrev.Location = new System.Drawing.Point(1103, 8);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Rotation = 0D;
            this.btnPrev.Size = new System.Drawing.Size(30, 25);
            this.btnPrev.TabIndex = 74;
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrev.UseVisualStyleBackColor = false;
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
            this.btnNext.Location = new System.Drawing.Point(1139, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(30, 25);
            this.btnNext.TabIndex = 73;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dataGridSequenceNumberEditor
            // 
            this.dataGridSequenceNumberEditor.AllowUserToAddRows = false;
            this.dataGridSequenceNumberEditor.AllowUserToDeleteRows = false;
            this.dataGridSequenceNumberEditor.AllowUserToOrderColumns = true;
            this.dataGridSequenceNumberEditor.AllowUserToResizeColumns = false;
            this.dataGridSequenceNumberEditor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridSequenceNumberEditor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSequenceNumberEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSequenceNumberEditor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridSequenceNumberEditor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridSequenceNumberEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSequenceNumberEditor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSequenceNumberEditor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSequenceNumberEditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSequenceNumberEditor.ColumnHeadersHeight = 22;
            this.dataGridSequenceNumberEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSequenceNumberEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.last_number,
            this.minimum,
            this.maximum});
            this.dataGridSequenceNumberEditor.EnableHeadersVisualStyles = false;
            this.dataGridSequenceNumberEditor.Location = new System.Drawing.Point(12, 168);
            this.dataGridSequenceNumberEditor.Name = "dataGridSequenceNumberEditor";
            this.dataGridSequenceNumberEditor.ReadOnly = true;
            this.dataGridSequenceNumberEditor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridSequenceNumberEditor.RowHeadersVisible = false;
            this.dataGridSequenceNumberEditor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridSequenceNumberEditor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSequenceNumberEditor.RowTemplate.Height = 25;
            this.dataGridSequenceNumberEditor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSequenceNumberEditor.Size = new System.Drawing.Size(1175, 497);
            this.dataGridSequenceNumberEditor.TabIndex = 11;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "SEQUENCE NUMBER";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // last_number
            // 
            this.last_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_number.DataPropertyName = "last_number";
            this.last_number.HeaderText = "NEXT SEQUENCE NUMBER";
            this.last_number.Name = "last_number";
            this.last_number.ReadOnly = true;
            // 
            // minimum
            // 
            this.minimum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.minimum.DataPropertyName = "minimum";
            this.minimum.HeaderText = "MINIMUM NUMBER";
            this.minimum.Name = "minimum";
            this.minimum.ReadOnly = true;
            // 
            // maximum
            // 
            this.maximum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maximum.DataPropertyName = "maximum";
            this.maximum.HeaderText = "MAXIMUM NUMBER";
            this.maximum.Name = "maximum";
            this.maximum.ReadOnly = true;
            // 
            // panelNew
            // 
            this.panelNew.BackColor = System.Drawing.Color.White;
            this.panelNew.Controls.Add(this.panelView);
            this.panelNew.Controls.Add(this.btnCancel);
            this.panelNew.Controls.Add(this.btnSave);
            this.panelNew.Controls.Add(this.btnUpdate);
            this.panelNew.Controls.Add(this.tableLayoutPanel1);
            this.panelNew.Controls.Add(this.tableLayoutPanel2);
            this.panelNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNew.Location = new System.Drawing.Point(0, 30);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(1203, 717);
            this.panelNew.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconSize = 20;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1021, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 208;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
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
            this.btnSave.Location = new System.Drawing.Point(1108, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 207;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconSize = 20;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1108, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0D;
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 209;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.lblSequenceNoIdentifier, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSequenceNoIdentifier, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMandatoryBranchID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNextSequenceNumber, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxNextSequenceNumber, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1179, 64);
            this.tableLayoutPanel1.TabIndex = 356;
            // 
            // lblSequenceNoIdentifier
            // 
            this.lblSequenceNoIdentifier.AutoSize = true;
            this.lblSequenceNoIdentifier.Location = new System.Drawing.Point(3, 0);
            this.lblSequenceNoIdentifier.Name = "lblSequenceNoIdentifier";
            this.lblSequenceNoIdentifier.Size = new System.Drawing.Size(116, 13);
            this.lblSequenceNoIdentifier.TabIndex = 202;
            this.lblSequenceNoIdentifier.Text = "Sequence No Identifier";
            // 
            // txtBoxSequenceNoIdentifier
            // 
            this.txtBoxSequenceNoIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSequenceNoIdentifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.txtBoxSequenceNoIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBoxSequenceNoIdentifier.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSequenceNoIdentifier.Location = new System.Drawing.Point(3, 22);
            this.txtBoxSequenceNoIdentifier.MaxLength = 20;
            this.txtBoxSequenceNoIdentifier.Name = "txtBoxSequenceNoIdentifier";
            this.txtBoxSequenceNoIdentifier.Size = new System.Drawing.Size(548, 21);
            this.txtBoxSequenceNoIdentifier.TabIndex = 201;
            this.txtBoxSequenceNoIdentifier.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxSequenceNoIdentifier.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxSequenceNoIdentifier.TiraMandatory = true;
            this.txtBoxSequenceNoIdentifier.TiraPlaceHolder = null;
            this.txtBoxSequenceNoIdentifier.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblMandatoryBranchID
            // 
            this.lblMandatoryBranchID.AutoSize = true;
            this.lblMandatoryBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMandatoryBranchID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.lblMandatoryBranchID.Location = new System.Drawing.Point(557, 19);
            this.lblMandatoryBranchID.Name = "lblMandatoryBranchID";
            this.lblMandatoryBranchID.Size = new System.Drawing.Size(17, 25);
            this.lblMandatoryBranchID.TabIndex = 352;
            this.lblMandatoryBranchID.Text = "*";
            // 
            // lblNextSequenceNumber
            // 
            this.lblNextSequenceNumber.AutoSize = true;
            this.lblNextSequenceNumber.Location = new System.Drawing.Point(603, 0);
            this.lblNextSequenceNumber.Name = "lblNextSequenceNumber";
            this.lblNextSequenceNumber.Size = new System.Drawing.Size(121, 13);
            this.lblNextSequenceNumber.TabIndex = 200;
            this.lblNextSequenceNumber.Text = "Next Sequence Number";
            // 
            // txtBoxNextSequenceNumber
            // 
            this.txtBoxNextSequenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNextSequenceNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.txtBoxNextSequenceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBoxNextSequenceNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxNextSequenceNumber.Location = new System.Drawing.Point(603, 22);
            this.txtBoxNextSequenceNumber.MaxLength = 255;
            this.txtBoxNextSequenceNumber.Name = "txtBoxNextSequenceNumber";
            this.txtBoxNextSequenceNumber.Size = new System.Drawing.Size(548, 21);
            this.txtBoxNextSequenceNumber.TabIndex = 199;
            this.txtBoxNextSequenceNumber.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxNextSequenceNumber.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxNextSequenceNumber.TiraMandatory = true;
            this.txtBoxNextSequenceNumber.TiraPlaceHolder = null;
            this.txtBoxNextSequenceNumber.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtBoxNextSequenceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNextSequenceNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(1157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 353;
            this.label1.Text = "*";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMinimumNumber, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxMinumumNumber, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMaximumNumber, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxMaximumNumber, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1179, 64);
            this.tableLayoutPanel2.TabIndex = 357;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(557, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 25);
            this.label3.TabIndex = 355;
            this.label3.Text = "*";
            // 
            // lblMinimumNumber
            // 
            this.lblMinimumNumber.AutoSize = true;
            this.lblMinimumNumber.Location = new System.Drawing.Point(3, 0);
            this.lblMinimumNumber.Name = "lblMinimumNumber";
            this.lblMinimumNumber.Size = new System.Drawing.Size(88, 13);
            this.lblMinimumNumber.TabIndex = 204;
            this.lblMinimumNumber.Text = "Minimum Number";
            // 
            // txtBoxMinumumNumber
            // 
            this.txtBoxMinumumNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMinumumNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.txtBoxMinumumNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBoxMinumumNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxMinumumNumber.Location = new System.Drawing.Point(3, 22);
            this.txtBoxMinumumNumber.MaxLength = 255;
            this.txtBoxMinumumNumber.Name = "txtBoxMinumumNumber";
            this.txtBoxMinumumNumber.Size = new System.Drawing.Size(548, 23);
            this.txtBoxMinumumNumber.TabIndex = 203;
            this.txtBoxMinumumNumber.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxMinumumNumber.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxMinumumNumber.TiraMandatory = true;
            this.txtBoxMinumumNumber.TiraPlaceHolder = null;
            this.txtBoxMinumumNumber.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtBoxMinumumNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMinumumNumber_KeyPress);
            // 
            // lblMaximumNumber
            // 
            this.lblMaximumNumber.AutoSize = true;
            this.lblMaximumNumber.Location = new System.Drawing.Point(603, 0);
            this.lblMaximumNumber.Name = "lblMaximumNumber";
            this.lblMaximumNumber.Size = new System.Drawing.Size(91, 13);
            this.lblMaximumNumber.TabIndex = 206;
            this.lblMaximumNumber.Text = "Maximum Number";
            // 
            // txtBoxMaximumNumber
            // 
            this.txtBoxMaximumNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMaximumNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.txtBoxMaximumNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBoxMaximumNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxMaximumNumber.Location = new System.Drawing.Point(603, 22);
            this.txtBoxMaximumNumber.MaxLength = 255;
            this.txtBoxMaximumNumber.Name = "txtBoxMaximumNumber";
            this.txtBoxMaximumNumber.Size = new System.Drawing.Size(548, 23);
            this.txtBoxMaximumNumber.TabIndex = 205;
            this.txtBoxMaximumNumber.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxMaximumNumber.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxMaximumNumber.TiraMandatory = true;
            this.txtBoxMaximumNumber.TiraPlaceHolder = null;
            this.txtBoxMaximumNumber.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtBoxMaximumNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMaximumNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(1157, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 354;
            this.label2.Text = "*";
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopMenu.Controls.Add(this.navClose);
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navPrint);
            this.panelTopMenu.Controls.Add(this.navDelete);
            this.panelTopMenu.Controls.Add(this.navEdit);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1203, 30);
            this.panelTopMenu.TabIndex = 15;
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
            this.navExport.Location = new System.Drawing.Point(335, 0);
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
            // navPrint
            // 
            this.navPrint.BackColor = System.Drawing.SystemColors.Control;
            this.navPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navPrint.FlatAppearance.BorderSize = 0;
            this.navPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navPrint.ForeColor = System.Drawing.Color.Black;
            this.navPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.navPrint.IconColor = System.Drawing.Color.Black;
            this.navPrint.IconSize = 20;
            this.navPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPrint.Location = new System.Drawing.Point(270, 0);
            this.navPrint.Name = "navPrint";
            this.navPrint.Rotation = 0D;
            this.navPrint.Size = new System.Drawing.Size(65, 30);
            this.navPrint.TabIndex = 5;
            this.navPrint.Text = "Print";
            this.navPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navPrint.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navPrint.UseVisualStyleBackColor = false;
            this.navPrint.Click += new System.EventHandler(this.navPrint_Click);
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
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.Controls.Add(this.rptViewer);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrint.Location = new System.Drawing.Point(0, 30);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(1203, 717);
            this.pnlPrint.TabIndex = 68;
            this.pnlPrint.Visible = false;
            // 
            // rptViewer
            // 
            this.rptViewer.ActiveViewIndex = -1;
            this.rptViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewer.Location = new System.Drawing.Point(7, 37);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowCloseButton = false;
            this.rptViewer.ShowLogo = false;
            this.rptViewer.Size = new System.Drawing.Size(1189, 672);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // GS_SequenceNumberEditorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 747);
            this.Controls.Add(this.panelNew);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "GS_SequenceNumberEditorUI";
            this.Text = "GS_SequenceNumberEditorUI";
            this.Load += new System.EventHandler(this.GS_SequenceNumberEditorUI_Load);
            this.panelView.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxPaging.ResumeLayout(false);
            this.groupBoxPaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSequenceNumberEditor)).EndInit();
            this.panelNew.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjSequenceNumberEditor)).EndInit();
            this.panelTopMenu.ResumeLayout(false);
            this.pnlPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraDataGrid dataGridSequenceNumberEditor;
        private Tira.Component.TiraGroupBox groupBoxSearch;
        private Tira.Component.TiraComboBox cbSearchModuleTable;
        private System.Windows.Forms.Panel panelNew;
        private Tira.Component.TiraButton buttonSearch;
        private System.Windows.Forms.BindingSource bindingObjSequenceNumberEditor;
        private Tira.Component.TiraGroupBox groupBoxPaging;
        internal System.Windows.Forms.Label lblPagingInfo;
        internal System.Windows.Forms.Label lblRows;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximum;
        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navClose;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private Tira.Component.TiraButton btnCancel;
        private Tira.Component.TiraButton btnSave;
        private Tira.Component.TiraTextBox txtBoxMaximumNumber;
        private System.Windows.Forms.Label lblMaximumNumber;
        private Tira.Component.TiraTextBox txtBoxMinumumNumber;
        private System.Windows.Forms.Label lblMinimumNumber;
        private Tira.Component.TiraTextBox txtBoxSequenceNoIdentifier;
        private System.Windows.Forms.Label lblSequenceNoIdentifier;
        private Tira.Component.TiraTextBox txtBoxNextSequenceNumber;
        private System.Windows.Forms.Label lblNextSequenceNumber;
        private Tira.Component.TiraButton btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMandatoryBranchID;
        private System.Windows.Forms.Panel pnlPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSearchModuleTable;
    }
}