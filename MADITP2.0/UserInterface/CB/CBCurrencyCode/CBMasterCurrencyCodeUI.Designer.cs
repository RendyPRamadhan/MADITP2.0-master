namespace MADITP2._0.UserInterface.CB.CBCurrencyCode
{
    partial class CBMasterCurrencyCodeUI
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
            this.panelView = new System.Windows.Forms.Panel();
            this.groupBoxPaging = new Tira.Component.TiraGroupBox();
            this.lblPagingInfo = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.groupBoxSearch = new Tira.Component.TiraGroupBox();
            this.txtSearchCurrCode = new Tira.Component.TiraTextBox();
            this.buttonSearch = new Tira.Component.TiraButton();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upp_rate_to_home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low_rate_to_home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdl_rate_to_home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_rate_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelFormPrint = new System.Windows.Forms.Panel();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.PanelFormCreate = new System.Windows.Forms.Panel();
            this.cbCurrType = new Tira.Component.TiraCheckBox();
            this.txtInputCurrID = new Tira.Component.TiraTextBox();
            this.txtLower = new Tira.Component.TiraTextBox();
            this.txtRemarks = new Tira.Component.TiraTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpper = new Tira.Component.TiraTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiddle = new Tira.Component.TiraTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrType = new Tira.Component.TiraTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurr = new Tira.Component.TiraTextBox();
            this.btnCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingobjCurr = new System.Windows.Forms.BindingSource(this.components);
            this.panelTopMenu.SuspendLayout();
            this.panelView.SuspendLayout();
            this.groupBoxPaging.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.PanelFormPrint.SuspendLayout();
            this.PanelFormCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingobjCurr)).BeginInit();
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
            this.panelTopMenu.Size = new System.Drawing.Size(919, 30);
            this.panelTopMenu.TabIndex = 489;
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
            this.navExport.TabIndex = 9;
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
            this.panelView.Size = new System.Drawing.Size(919, 591);
            this.panelView.TabIndex = 490;
            // 
            // groupBoxPaging
            // 
            this.groupBoxPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPaging.Controls.Add(this.lblPagingInfo);
            this.groupBoxPaging.Controls.Add(this.lblRows);
            this.groupBoxPaging.Controls.Add(this.btnPrev);
            this.groupBoxPaging.Controls.Add(this.btnNext);
            this.groupBoxPaging.Location = new System.Drawing.Point(12, 515);
            this.groupBoxPaging.Name = "groupBoxPaging";
            this.groupBoxPaging.Size = new System.Drawing.Size(895, 35);
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
            this.btnPrev.Location = new System.Drawing.Point(823, 8);
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
            this.btnNext.Location = new System.Drawing.Point(859, 8);
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
            this.groupBoxSearch.Controls.Add(this.txtSearchCurrCode);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(895, 79);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Filter";
            this.groupBoxSearch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearch.TiraTextColor = System.Drawing.Color.Black;
            // 
            // txtSearchCurrCode
            // 
            this.txtSearchCurrCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCurrCode.BackColor = System.Drawing.Color.White;
            this.txtSearchCurrCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCurrCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchCurrCode.Location = new System.Drawing.Point(25, 35);
            this.txtSearchCurrCode.MaxLength = 255;
            this.txtSearchCurrCode.Name = "txtSearchCurrCode";
            this.txtSearchCurrCode.Size = new System.Drawing.Size(765, 21);
            this.txtSearchCurrCode.TabIndex = 26;
            this.txtSearchCurrCode.Text = "Currency Code";
            this.txtSearchCurrCode.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtSearchCurrCode.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtSearchCurrCode.TiraMandatory = false;
            this.txtSearchCurrCode.TiraPlaceHolder = "Currency Code";
            this.txtSearchCurrCode.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
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
            this.buttonSearch.Location = new System.Drawing.Point(806, 33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Rotation = 0D;
            this.buttonSearch.Size = new System.Drawing.Size(70, 23);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.currency_code,
            this.currency,
            this.currency_type,
            this.upp_rate_to_home,
            this.low_rate_to_home,
            this.mdl_rate_to_home,
            this.remarks,
            this.last_rate_update,
            this.rate_update_by,
            this.creation_date,
            this.create_by});
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
            this.dgvResult.Size = new System.Drawing.Size(895, 420);
            this.dgvResult.TabIndex = 2;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // currency_code
            // 
            this.currency_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currency_code.DataPropertyName = "currency_code";
            this.currency_code.HeaderText = "currency_code";
            this.currency_code.Name = "currency_code";
            this.currency_code.ReadOnly = true;
            // 
            // currency
            // 
            this.currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currency.DataPropertyName = "currency";
            this.currency.HeaderText = "currency";
            this.currency.Name = "currency";
            this.currency.ReadOnly = true;
            // 
            // currency_type
            // 
            this.currency_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currency_type.DataPropertyName = "currency_type";
            this.currency_type.HeaderText = "currency_type";
            this.currency_type.Name = "currency_type";
            this.currency_type.ReadOnly = true;
            // 
            // upp_rate_to_home
            // 
            this.upp_rate_to_home.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.upp_rate_to_home.DataPropertyName = "upp_rate_to_home";
            this.upp_rate_to_home.HeaderText = "upp_rate_to_home";
            this.upp_rate_to_home.Name = "upp_rate_to_home";
            this.upp_rate_to_home.ReadOnly = true;
            // 
            // low_rate_to_home
            // 
            this.low_rate_to_home.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.low_rate_to_home.DataPropertyName = "low_rate_to_home";
            this.low_rate_to_home.HeaderText = "low_rate_to_home";
            this.low_rate_to_home.Name = "low_rate_to_home";
            this.low_rate_to_home.ReadOnly = true;
            // 
            // mdl_rate_to_home
            // 
            this.mdl_rate_to_home.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mdl_rate_to_home.DataPropertyName = "mdl_rate_to_home";
            this.mdl_rate_to_home.HeaderText = "mdl_rate_to_home";
            this.mdl_rate_to_home.Name = "mdl_rate_to_home";
            this.mdl_rate_to_home.ReadOnly = true;
            // 
            // remarks
            // 
            this.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "remarks";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // last_rate_update
            // 
            this.last_rate_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_rate_update.DataPropertyName = "last_rate_update";
            this.last_rate_update.HeaderText = "last_rate_update";
            this.last_rate_update.Name = "last_rate_update";
            this.last_rate_update.ReadOnly = true;
            this.last_rate_update.Visible = false;
            // 
            // rate_update_by
            // 
            this.rate_update_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rate_update_by.DataPropertyName = "rate_update_by";
            this.rate_update_by.HeaderText = "rate_update_by";
            this.rate_update_by.Name = "rate_update_by";
            this.rate_update_by.ReadOnly = true;
            // 
            // creation_date
            // 
            this.creation_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creation_date.DataPropertyName = "creation_date";
            this.creation_date.HeaderText = "creation_date";
            this.creation_date.Name = "creation_date";
            this.creation_date.ReadOnly = true;
            // 
            // create_by
            // 
            this.create_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.create_by.DataPropertyName = "create_by";
            this.create_by.HeaderText = "create_by";
            this.create_by.Name = "create_by";
            this.create_by.ReadOnly = true;
            // 
            // PanelFormPrint
            // 
            this.PanelFormPrint.BackColor = System.Drawing.Color.White;
            this.PanelFormPrint.Controls.Add(this.rptViewer);
            this.PanelFormPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormPrint.Location = new System.Drawing.Point(0, 30);
            this.PanelFormPrint.Name = "PanelFormPrint";
            this.PanelFormPrint.Size = new System.Drawing.Size(919, 591);
            this.PanelFormPrint.TabIndex = 507;
            // 
            // rptViewer
            // 
            this.rptViewer.ActiveViewIndex = -1;
            this.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(919, 591);
            this.rptViewer.TabIndex = 0;
            // 
            // PanelFormCreate
            // 
            this.PanelFormCreate.BackColor = System.Drawing.Color.White;
            this.PanelFormCreate.Controls.Add(this.cbCurrType);
            this.PanelFormCreate.Controls.Add(this.txtInputCurrID);
            this.PanelFormCreate.Controls.Add(this.txtLower);
            this.PanelFormCreate.Controls.Add(this.txtRemarks);
            this.PanelFormCreate.Controls.Add(this.label9);
            this.PanelFormCreate.Controls.Add(this.txtUpper);
            this.PanelFormCreate.Controls.Add(this.label13);
            this.PanelFormCreate.Controls.Add(this.label10);
            this.PanelFormCreate.Controls.Add(this.label5);
            this.PanelFormCreate.Controls.Add(this.txtMiddle);
            this.PanelFormCreate.Controls.Add(this.label14);
            this.PanelFormCreate.Controls.Add(this.label6);
            this.PanelFormCreate.Controls.Add(this.txtCurrType);
            this.PanelFormCreate.Controls.Add(this.label1);
            this.PanelFormCreate.Controls.Add(this.label2);
            this.PanelFormCreate.Controls.Add(this.txtCurr);
            this.PanelFormCreate.Controls.Add(this.btnCancel);
            this.PanelFormCreate.Controls.Add(this.btnSave);
            this.PanelFormCreate.Controls.Add(this.label3);
            this.PanelFormCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormCreate.Location = new System.Drawing.Point(0, 30);
            this.PanelFormCreate.Name = "PanelFormCreate";
            this.PanelFormCreate.Size = new System.Drawing.Size(919, 591);
            this.PanelFormCreate.TabIndex = 508;
            // 
            // cbCurrType
            // 
            this.cbCurrType.Location = new System.Drawing.Point(15, 150);
            this.cbCurrType.Name = "cbCurrType";
            this.cbCurrType.Size = new System.Drawing.Size(88, 20);
            this.cbCurrType.TabIndex = 540;
            this.cbCurrType.Text = "Is Home";
            this.cbCurrType.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cbCurrType.UseVisualStyleBackColor = true;
            this.cbCurrType.CheckedChanged += new System.EventHandler(this.cbCurrType_CheckedChanged);
            // 
            // txtInputCurrID
            // 
            this.txtInputCurrID.BackColor = System.Drawing.Color.White;
            this.txtInputCurrID.Enabled = false;
            this.txtInputCurrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtInputCurrID.ForeColor = System.Drawing.Color.DimGray;
            this.txtInputCurrID.Location = new System.Drawing.Point(15, 45);
            this.txtInputCurrID.MaxLength = 4;
            this.txtInputCurrID.Name = "txtInputCurrID";
            this.txtInputCurrID.Size = new System.Drawing.Size(208, 23);
            this.txtInputCurrID.TabIndex = 539;
            this.txtInputCurrID.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtInputCurrID.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtInputCurrID.TiraMandatory = false;
            this.txtInputCurrID.TiraPlaceHolder = null;
            this.txtInputCurrID.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtLower
            // 
            this.txtLower.BackColor = System.Drawing.Color.White;
            this.txtLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLower.ForeColor = System.Drawing.Color.DimGray;
            this.txtLower.Location = new System.Drawing.Point(15, 256);
            this.txtLower.MaxLength = 19;
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(208, 23);
            this.txtLower.TabIndex = 532;
            this.txtLower.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtLower.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtLower.TiraMandatory = false;
            this.txtLower.TiraPlaceHolder = null;
            this.txtLower.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRemarks.ForeColor = System.Drawing.Color.DimGray;
            this.txtRemarks.Location = new System.Drawing.Point(15, 368);
            this.txtRemarks.MaxLength = 20;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(208, 23);
            this.txtRemarks.TabIndex = 538;
            this.txtRemarks.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtRemarks.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtRemarks.TiraMandatory = false;
            this.txtRemarks.TiraPlaceHolder = null;
            this.txtRemarks.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 530;
            this.label9.Text = "Lower Rate to Home Curr";
            // 
            // txtUpper
            // 
            this.txtUpper.BackColor = System.Drawing.Color.White;
            this.txtUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtUpper.ForeColor = System.Drawing.Color.DimGray;
            this.txtUpper.Location = new System.Drawing.Point(15, 200);
            this.txtUpper.MaxLength = 19;
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(208, 23);
            this.txtUpper.TabIndex = 529;
            this.txtUpper.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtUpper.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtUpper.TiraMandatory = false;
            this.txtUpper.TiraPlaceHolder = null;
            this.txtUpper.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 536;
            this.label13.Text = "Remarks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 528;
            this.label10.Text = "Upper Rate to Home Curr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(83, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 527;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtMiddle
            // 
            this.txtMiddle.BackColor = System.Drawing.Color.White;
            this.txtMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMiddle.ForeColor = System.Drawing.Color.DimGray;
            this.txtMiddle.Location = new System.Drawing.Point(15, 312);
            this.txtMiddle.MaxLength = 19;
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(208, 23);
            this.txtMiddle.TabIndex = 535;
            this.txtMiddle.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtMiddle.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtMiddle.TiraMandatory = false;
            this.txtMiddle.TiraPlaceHolder = null;
            this.txtMiddle.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 534;
            this.label14.Text = "Middle Rate to Home Curr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 526;
            this.label6.Text = "Currency ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCurrType
            // 
            this.txtCurrType.BackColor = System.Drawing.Color.White;
            this.txtCurrType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCurrType.ForeColor = System.Drawing.Color.DimGray;
            this.txtCurrType.Location = new System.Drawing.Point(130, 151);
            this.txtCurrType.MaxLength = 6;
            this.txtCurrType.Name = "txtCurrType";
            this.txtCurrType.Size = new System.Drawing.Size(93, 23);
            this.txtCurrType.TabIndex = 524;
            this.txtCurrType.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtCurrType.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtCurrType.TiraMandatory = false;
            this.txtCurrType.TiraPlaceHolder = null;
            this.txtCurrType.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtCurrType.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(125, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 498;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 494;
            this.label2.Text = "Currency Type (Home or Foreign)";
            // 
            // txtCurr
            // 
            this.txtCurr.BackColor = System.Drawing.Color.White;
            this.txtCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCurr.ForeColor = System.Drawing.Color.DimGray;
            this.txtCurr.Location = new System.Drawing.Point(15, 94);
            this.txtCurr.MaxLength = 30;
            this.txtCurr.Name = "txtCurr";
            this.txtCurr.Size = new System.Drawing.Size(208, 23);
            this.txtCurr.TabIndex = 490;
            this.txtCurr.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtCurr.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtCurr.TiraMandatory = false;
            this.txtCurr.TiraPlaceHolder = null;
            this.txtCurr.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
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
            this.btnCancel.Location = new System.Drawing.Point(249, 364);
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
            this.btnSave.Location = new System.Drawing.Point(325, 364);
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
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Currency Description";
            // 
            // CBMasterCurrencyCodeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 621);
            this.Controls.Add(this.PanelFormCreate);
            this.Controls.Add(this.PanelFormPrint);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "CBMasterCurrencyCodeUI";
            this.Text = "CBMasterCurrencyCodeUI";
            this.panelTopMenu.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.groupBoxPaging.ResumeLayout(false);
            this.groupBoxPaging.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.PanelFormPrint.ResumeLayout(false);
            this.PanelFormCreate.ResumeLayout(false);
            this.PanelFormCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingobjCurr)).EndInit();
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
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraGroupBox groupBoxPaging;
        internal System.Windows.Forms.Label lblPagingInfo;
        internal System.Windows.Forms.Label lblRows;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private Tira.Component.TiraGroupBox groupBoxSearch;
        private Tira.Component.TiraTextBox txtSearchCurrCode;
        private Tira.Component.TiraButton buttonSearch;
        private Tira.Component.TiraDataGrid dgvResult;
        private System.Windows.Forms.Panel PanelFormPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
        private System.Windows.Forms.Panel PanelFormCreate;
        private Tira.Component.TiraCheckBox cbCurrType;
        private Tira.Component.TiraTextBox txtInputCurrID;
        private Tira.Component.TiraTextBox txtLower;
        private Tira.Component.TiraTextBox txtRemarks;
        private System.Windows.Forms.Label label9;
        private Tira.Component.TiraTextBox txtUpper;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private Tira.Component.TiraTextBox txtMiddle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private Tira.Component.TiraTextBox txtCurrType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Tira.Component.TiraTextBox txtCurr;
        private Tira.Component.TiraButton btnCancel;
        private Tira.Component.TiraButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingobjCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn upp_rate_to_home;
        private System.Windows.Forms.DataGridViewTextBoxColumn low_rate_to_home;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdl_rate_to_home;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_rate_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
    }
}