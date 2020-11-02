namespace MADITP2._0.UserInterface.CB.CBVoucherType
{
    partial class CBVoucherTypeUI
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
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navExport = new Tira.Component.TiraButton();
            this.navPrint = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.bindingObjVType = new System.Windows.Forms.BindingSource(this.components);
            this.panelView = new System.Windows.Forms.Panel();
            this.groupBoxPaging = new Tira.Component.TiraGroupBox();
            this.lblPagingInfo = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.groupBoxSearch = new Tira.Component.TiraGroupBox();
            this.txtSearchVoucherTypeID = new Tira.Component.TiraTextBox();
            this.btnSearch = new Tira.Component.TiraButton();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.PanelFormCreate = new System.Windows.Forms.Panel();
            this.cmbTranType = new Tira.Component.TiraComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBAllowAR = new Tira.Component.TiraCheckBox();
            this.cbAllowAP = new Tira.Component.TiraCheckBox();
            this.cbAllowTxnEntry = new Tira.Component.TiraCheckBox();
            this.txtInputVoucherTypeID = new Tira.Component.TiraTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputVouchetTypeDesc = new Tira.Component.TiraTextBox();
            this.btnCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelFormPrint = new System.Windows.Forms.Panel();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucher_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allow_manual_txn_entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ap_pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar_receipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjVType)).BeginInit();
            this.panelView.SuspendLayout();
            this.groupBoxPaging.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.PanelFormCreate.SuspendLayout();
            this.PanelFormPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.White;
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navPrint);
            this.panelTopMenu.Controls.Add(this.navDelete);
            this.panelTopMenu.Controls.Add(this.navEdit);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(800, 30);
            this.panelTopMenu.TabIndex = 508;
            // 
            // navExport
            // 
            this.navExport.BackColor = System.Drawing.Color.White;
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
            this.navExport.Size = new System.Drawing.Size(71, 30);
            this.navExport.TabIndex = 8;
            this.navExport.Text = "Export";
            this.navExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navExport.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navExport.UseVisualStyleBackColor = true;
            this.navExport.Click += new System.EventHandler(this.navExport_Click);
            // 
            // navPrint
            // 
            this.navPrint.BackColor = System.Drawing.Color.White;
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
            this.navPrint.UseVisualStyleBackColor = true;
            this.navPrint.Click += new System.EventHandler(this.navPrint_Click);
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
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelView.Controls.Add(this.groupBoxPaging);
            this.panelView.Controls.Add(this.groupBoxSearch);
            this.panelView.Controls.Add(this.dgvResult);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 30);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(800, 677);
            this.panelView.TabIndex = 509;
            // 
            // groupBoxPaging
            // 
            this.groupBoxPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPaging.Controls.Add(this.lblPagingInfo);
            this.groupBoxPaging.Controls.Add(this.lblRows);
            this.groupBoxPaging.Controls.Add(this.btnPrev);
            this.groupBoxPaging.Controls.Add(this.btnNext);
            this.groupBoxPaging.Location = new System.Drawing.Point(12, 595);
            this.groupBoxPaging.Name = "groupBoxPaging";
            this.groupBoxPaging.Size = new System.Drawing.Size(776, 35);
            this.groupBoxPaging.TabIndex = 5;
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
            this.btnPrev.Location = new System.Drawing.Point(704, 8);
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
            this.btnNext.Location = new System.Drawing.Point(740, 8);
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
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.txtSearchVoucherTypeID);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(776, 79);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Filter";
            this.groupBoxSearch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearch.TiraTextColor = System.Drawing.Color.Black;
            // 
            // txtSearchVoucherTypeID
            // 
            this.txtSearchVoucherTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchVoucherTypeID.BackColor = System.Drawing.Color.White;
            this.txtSearchVoucherTypeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchVoucherTypeID.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchVoucherTypeID.Location = new System.Drawing.Point(25, 35);
            this.txtSearchVoucherTypeID.MaxLength = 255;
            this.txtSearchVoucherTypeID.Name = "txtSearchVoucherTypeID";
            this.txtSearchVoucherTypeID.Size = new System.Drawing.Size(646, 21);
            this.txtSearchVoucherTypeID.TabIndex = 26;
            this.txtSearchVoucherTypeID.Text = "Voucher Type ID";
            this.txtSearchVoucherTypeID.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtSearchVoucherTypeID.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtSearchVoucherTypeID.TiraMandatory = false;
            this.txtSearchVoucherTypeID.TiraPlaceHolder = "Voucher Type ID";
            this.txtSearchVoucherTypeID.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
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
            this.btnSearch.IconSize = 16;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(687, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.ColumnHeadersHeight = 22;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.voucher_type_id,
            this.description,
            this.txn_type,
            this.allow_manual_txn_entry,
            this.ap_pay,
            this.ar_receipt,
            this.last_update,
            this.user_id});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(12, 91);
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
            this.dgvResult.Size = new System.Drawing.Size(776, 500);
            this.dgvResult.TabIndex = 2;
            // 
            // PanelFormCreate
            // 
            this.PanelFormCreate.BackColor = System.Drawing.Color.White;
            this.PanelFormCreate.Controls.Add(this.cmbTranType);
            this.PanelFormCreate.Controls.Add(this.label7);
            this.PanelFormCreate.Controls.Add(this.CBAllowAR);
            this.PanelFormCreate.Controls.Add(this.cbAllowAP);
            this.PanelFormCreate.Controls.Add(this.cbAllowTxnEntry);
            this.PanelFormCreate.Controls.Add(this.txtInputVoucherTypeID);
            this.PanelFormCreate.Controls.Add(this.label9);
            this.PanelFormCreate.Controls.Add(this.label10);
            this.PanelFormCreate.Controls.Add(this.label5);
            this.PanelFormCreate.Controls.Add(this.label6);
            this.PanelFormCreate.Controls.Add(this.label1);
            this.PanelFormCreate.Controls.Add(this.label2);
            this.PanelFormCreate.Controls.Add(this.txtInputVouchetTypeDesc);
            this.PanelFormCreate.Controls.Add(this.btnCancel);
            this.PanelFormCreate.Controls.Add(this.btnSave);
            this.PanelFormCreate.Controls.Add(this.label3);
            this.PanelFormCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormCreate.Location = new System.Drawing.Point(0, 30);
            this.PanelFormCreate.Name = "PanelFormCreate";
            this.PanelFormCreate.Size = new System.Drawing.Size(800, 677);
            this.PanelFormCreate.TabIndex = 510;
            // 
            // cmbTranType
            // 
            this.cmbTranType.BackColor = System.Drawing.Color.White;
            this.cmbTranType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTranType.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTranType.FormattingEnabled = true;
            this.cmbTranType.Location = new System.Drawing.Point(15, 153);
            this.cmbTranType.Name = "cmbTranType";
            this.cmbTranType.Size = new System.Drawing.Size(150, 23);
            this.cmbTranType.TabIndex = 545;
            this.cmbTranType.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbTranType.TiraMandatory = false;
            this.cmbTranType.TiraPlaceHolder = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 543;
            this.label7.Text = "Transaction Type";
            // 
            // CBAllowAR
            // 
            this.CBAllowAR.Location = new System.Drawing.Point(15, 277);
            this.CBAllowAR.Name = "CBAllowAR";
            this.CBAllowAR.Size = new System.Drawing.Size(76, 20);
            this.CBAllowAR.TabIndex = 542;
            this.CBAllowAR.Text = "No";
            this.CBAllowAR.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.CBAllowAR.UseVisualStyleBackColor = true;
            this.CBAllowAR.CheckedChanged += new System.EventHandler(this.CBAllowAR_CheckedChanged);
            // 
            // cbAllowAP
            // 
            this.cbAllowAP.Location = new System.Drawing.Point(15, 238);
            this.cbAllowAP.Name = "cbAllowAP";
            this.cbAllowAP.Size = new System.Drawing.Size(76, 20);
            this.cbAllowAP.TabIndex = 541;
            this.cbAllowAP.Text = "No";
            this.cbAllowAP.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cbAllowAP.UseVisualStyleBackColor = true;
            this.cbAllowAP.CheckedChanged += new System.EventHandler(this.cbAllowAP_CheckedChanged);
            // 
            // cbAllowTxnEntry
            // 
            this.cbAllowTxnEntry.Location = new System.Drawing.Point(15, 199);
            this.cbAllowTxnEntry.Name = "cbAllowTxnEntry";
            this.cbAllowTxnEntry.Size = new System.Drawing.Size(76, 20);
            this.cbAllowTxnEntry.TabIndex = 540;
            this.cbAllowTxnEntry.Text = "No";
            this.cbAllowTxnEntry.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cbAllowTxnEntry.UseVisualStyleBackColor = true;
            this.cbAllowTxnEntry.CheckedChanged += new System.EventHandler(this.cbAllowTxnEntry_CheckedChanged);
            // 
            // txtInputVoucherTypeID
            // 
            this.txtInputVoucherTypeID.BackColor = System.Drawing.Color.White;
            this.txtInputVoucherTypeID.Enabled = false;
            this.txtInputVoucherTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtInputVoucherTypeID.ForeColor = System.Drawing.Color.DimGray;
            this.txtInputVoucherTypeID.Location = new System.Drawing.Point(15, 45);
            this.txtInputVoucherTypeID.MaxLength = 5;
            this.txtInputVoucherTypeID.Name = "txtInputVoucherTypeID";
            this.txtInputVoucherTypeID.Size = new System.Drawing.Size(208, 23);
            this.txtInputVoucherTypeID.TabIndex = 539;
            this.txtInputVoucherTypeID.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtInputVoucherTypeID.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtInputVoucherTypeID.TiraMandatory = false;
            this.txtInputVoucherTypeID.TiraPlaceHolder = null;
            this.txtInputVoucherTypeID.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 530;
            this.label9.Text = "Allow For A/R Receipt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 528;
            this.label10.Text = "Allow For A/P Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(106, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 527;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 526;
            this.label6.Text = "Voucher Type ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(148, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 498;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 494;
            this.label2.Text = "Allow Manual Txn. Entry";
            // 
            // txtInputVouchetTypeDesc
            // 
            this.txtInputVouchetTypeDesc.BackColor = System.Drawing.Color.White;
            this.txtInputVouchetTypeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtInputVouchetTypeDesc.ForeColor = System.Drawing.Color.DimGray;
            this.txtInputVouchetTypeDesc.Location = new System.Drawing.Point(15, 101);
            this.txtInputVouchetTypeDesc.MaxLength = 50;
            this.txtInputVouchetTypeDesc.Name = "txtInputVouchetTypeDesc";
            this.txtInputVouchetTypeDesc.Size = new System.Drawing.Size(208, 23);
            this.txtInputVouchetTypeDesc.TabIndex = 490;
            this.txtInputVouchetTypeDesc.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtInputVouchetTypeDesc.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtInputVouchetTypeDesc.TiraMandatory = false;
            this.txtInputVouchetTypeDesc.TiraPlaceHolder = null;
            this.txtInputVouchetTypeDesc.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconSize = 20;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(144, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(70, 30);
            this.btnCancel.TabIndex = 19;
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
            this.btnSave.Location = new System.Drawing.Point(220, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(82, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Voucher Type Description";
            // 
            // PanelFormPrint
            // 
            this.PanelFormPrint.BackColor = System.Drawing.Color.White;
            this.PanelFormPrint.Controls.Add(this.rptViewer);
            this.PanelFormPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormPrint.Location = new System.Drawing.Point(0, 30);
            this.PanelFormPrint.Name = "PanelFormPrint";
            this.PanelFormPrint.Size = new System.Drawing.Size(800, 677);
            this.PanelFormPrint.TabIndex = 511;
            // 
            // rptViewer
            // 
            this.rptViewer.ActiveViewIndex = -1;
            this.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(800, 677);
            this.rptViewer.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // voucher_type_id
            // 
            this.voucher_type_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.voucher_type_id.DataPropertyName = "voucher_type_id";
            this.voucher_type_id.HeaderText = "Voucher Type ID";
            this.voucher_type_id.Name = "voucher_type_id";
            this.voucher_type_id.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // txn_type
            // 
            this.txn_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txn_type.DataPropertyName = "txn_type";
            this.txn_type.HeaderText = "Txn Type";
            this.txn_type.Name = "txn_type";
            this.txn_type.ReadOnly = true;
            // 
            // allow_manual_txn_entry
            // 
            this.allow_manual_txn_entry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allow_manual_txn_entry.DataPropertyName = "allow_manual_txn_entry";
            this.allow_manual_txn_entry.HeaderText = "Allow Manual Txn Entry";
            this.allow_manual_txn_entry.Name = "allow_manual_txn_entry";
            this.allow_manual_txn_entry.ReadOnly = true;
            // 
            // ap_pay
            // 
            this.ap_pay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ap_pay.DataPropertyName = "ap_pay";
            this.ap_pay.HeaderText = "AP Pay";
            this.ap_pay.Name = "ap_pay";
            this.ap_pay.ReadOnly = true;
            // 
            // ar_receipt
            // 
            this.ar_receipt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ar_receipt.DataPropertyName = "ar_receipt";
            this.ar_receipt.HeaderText = "AR Receipt";
            this.ar_receipt.Name = "ar_receipt";
            this.ar_receipt.ReadOnly = true;
            // 
            // last_update
            // 
            this.last_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_update.DataPropertyName = "last_update";
            this.last_update.HeaderText = "Last Update";
            this.last_update.Name = "last_update";
            this.last_update.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "User ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // CBVoucherTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.PanelFormPrint);
            this.Controls.Add(this.PanelFormCreate);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "CBVoucherTypeUI";
            this.Text = "CBVoucherTypeUI";
            this.panelTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjVType)).EndInit();
            this.panelView.ResumeLayout(false);
            this.groupBoxPaging.ResumeLayout(false);
            this.groupBoxPaging.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.PanelFormCreate.ResumeLayout(false);
            this.PanelFormCreate.PerformLayout();
            this.PanelFormPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.BindingSource bindingObjVType;
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraGroupBox groupBoxPaging;
        internal System.Windows.Forms.Label lblPagingInfo;
        internal System.Windows.Forms.Label lblRows;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private Tira.Component.TiraGroupBox groupBoxSearch;
        private Tira.Component.TiraTextBox txtSearchVoucherTypeID;
        private Tira.Component.TiraButton btnSearch;
        private Tira.Component.TiraDataGrid dgvResult;
        private System.Windows.Forms.Panel PanelFormCreate;
        private Tira.Component.TiraComboBox cmbTranType;
        private System.Windows.Forms.Label label7;
        private Tira.Component.TiraCheckBox CBAllowAR;
        private Tira.Component.TiraCheckBox cbAllowAP;
        private Tira.Component.TiraCheckBox cbAllowTxnEntry;
        private Tira.Component.TiraTextBox txtInputVoucherTypeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Tira.Component.TiraTextBox txtInputVouchetTypeDesc;
        private Tira.Component.TiraButton btnCancel;
        private Tira.Component.TiraButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelFormPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucher_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn txn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn allow_manual_txn_entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ap_pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar_receipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
    }
}