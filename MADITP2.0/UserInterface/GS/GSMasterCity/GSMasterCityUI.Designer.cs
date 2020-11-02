namespace MADITP2._0.userInterface.GS
{
    partial class GSMasterCityUI
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
            this.navPrint = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.PanelFormList = new System.Windows.Forms.Panel();
            this.btnSearch = new Tira.Component.TiraButton();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.txtPagingInfo = new System.Windows.Forms.Label();
            this.txtFilterSearch = new Tira.Component.TiraTextBox();
            this.cmbFilterProvince = new Tira.Component.TiraComboBox();
            this.PanelFormCreate = new System.Windows.Forms.Panel();
            this.buttonCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new Tira.Component.TiraTextBox();
            this.txtKodyaKab = new Tira.Component.TiraTextBox();
            this.txtProvince = new Tira.Component.TiraTextBox();
            this.panelTopMenu.SuspendLayout();
            this.PanelFormList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.PanelFormCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.White;
            this.panelTopMenu.Controls.Add(this.navPrint);
            this.panelTopMenu.Controls.Add(this.navDelete);
            this.panelTopMenu.Controls.Add(this.navEdit);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(903, 30);
            this.panelTopMenu.TabIndex = 479;
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
            this.PanelFormList.Controls.Add(this.btnSearch);
            this.PanelFormList.Controls.Add(this.dgvResult);
            this.PanelFormList.Controls.Add(this.btnPrev);
            this.PanelFormList.Controls.Add(this.btnNext);
            this.PanelFormList.Controls.Add(this.txtPagingInfo);
            this.PanelFormList.Controls.Add(this.txtFilterSearch);
            this.PanelFormList.Controls.Add(this.cmbFilterProvince);
            this.PanelFormList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormList.Location = new System.Drawing.Point(0, 30);
            this.PanelFormList.Name = "PanelFormList";
            this.PanelFormList.Size = new System.Drawing.Size(903, 581);
            this.PanelFormList.TabIndex = 480;
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
            this.btnSearch.Location = new System.Drawing.Point(739, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(22, 78);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(817, 379);
            this.dgvResult.TabIndex = 4;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
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
            this.btnPrev.Location = new System.Drawing.Point(777, 463);
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
            this.btnNext.Location = new System.Drawing.Point(809, 464);
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
            // txtFilterSearch
            // 
            this.txtFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtFilterSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilterSearch.Location = new System.Drawing.Point(21, 20);
            this.txtFilterSearch.MaxLength = 255;
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(818, 23);
            this.txtFilterSearch.TabIndex = 1;
            this.txtFilterSearch.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtFilterSearch.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtFilterSearch.TiraMandatory = false;
            this.txtFilterSearch.TiraPlaceHolder = null;
            this.txtFilterSearch.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtFilterSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyDown);
            this.txtFilterSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyUp);
            // 
            // cmbFilterProvince
            // 
            this.cmbFilterProvince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbFilterProvince.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFilterProvince.FormattingEnabled = true;
            this.cmbFilterProvince.Location = new System.Drawing.Point(22, 49);
            this.cmbFilterProvince.Name = "cmbFilterProvince";
            this.cmbFilterProvince.Size = new System.Drawing.Size(711, 23);
            this.cmbFilterProvince.TabIndex = 0;
            this.cmbFilterProvince.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbFilterProvince.TiraPlaceHolder = null;
            // 
            // PanelFormCreate
            // 
            this.PanelFormCreate.BackColor = System.Drawing.Color.White;
            this.PanelFormCreate.Controls.Add(this.buttonCancel);
            this.PanelFormCreate.Controls.Add(this.btnSave);
            this.PanelFormCreate.Controls.Add(this.label8);
            this.PanelFormCreate.Controls.Add(this.label7);
            this.PanelFormCreate.Controls.Add(this.label6);
            this.PanelFormCreate.Controls.Add(this.txtCity);
            this.PanelFormCreate.Controls.Add(this.txtKodyaKab);
            this.PanelFormCreate.Controls.Add(this.txtProvince);
            this.PanelFormCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormCreate.Location = new System.Drawing.Point(0, 30);
            this.PanelFormCreate.Name = "PanelFormCreate";
            this.PanelFormCreate.Size = new System.Drawing.Size(903, 581);
            this.PanelFormCreate.TabIndex = 6;
            // 
            // buttonCancel
            // 
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
            this.buttonCancel.Location = new System.Drawing.Point(72, 192);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Rotation = 0D;
            this.buttonCancel.Size = new System.Drawing.Size(70, 30);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(148, 192);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kodya / Kab";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Province";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCity.ForeColor = System.Drawing.Color.DimGray;
            this.txtCity.Location = new System.Drawing.Point(22, 142);
            this.txtCity.MaxLength = 255;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(208, 23);
            this.txtCity.TabIndex = 7;
            this.txtCity.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtCity.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtCity.TiraMandatory = false;
            this.txtCity.TiraPlaceHolder = null;
            this.txtCity.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtKodyaKab
            // 
            this.txtKodyaKab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKodyaKab.ForeColor = System.Drawing.Color.DimGray;
            this.txtKodyaKab.Location = new System.Drawing.Point(22, 88);
            this.txtKodyaKab.MaxLength = 255;
            this.txtKodyaKab.Name = "txtKodyaKab";
            this.txtKodyaKab.Size = new System.Drawing.Size(208, 23);
            this.txtKodyaKab.TabIndex = 6;
            this.txtKodyaKab.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtKodyaKab.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtKodyaKab.TiraMandatory = false;
            this.txtKodyaKab.TiraPlaceHolder = null;
            this.txtKodyaKab.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtProvince.ForeColor = System.Drawing.Color.DimGray;
            this.txtProvince.Location = new System.Drawing.Point(22, 36);
            this.txtProvince.MaxLength = 255;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(208, 23);
            this.txtProvince.TabIndex = 5;
            this.txtProvince.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtProvince.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtProvince.TiraMandatory = false;
            this.txtProvince.TiraPlaceHolder = null;
            this.txtProvince.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // GSMasterCityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 611);
            this.Controls.Add(this.PanelFormCreate);
            this.Controls.Add(this.PanelFormList);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "GSMasterCityUI";
            this.Text = "Master City";
            this.Load += new System.EventHandler(this.GSMasterCityUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.PanelFormList.ResumeLayout(false);
            this.PanelFormList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.PanelFormCreate.ResumeLayout(false);
            this.PanelFormCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel PanelFormList;
        private Tira.Component.TiraButton btnSearch;
        private Tira.Component.TiraDataGrid dgvResult;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private System.Windows.Forms.Label txtPagingInfo;
        private Tira.Component.TiraTextBox txtFilterSearch;
        private Tira.Component.TiraComboBox cmbFilterProvince;
        private System.Windows.Forms.Panel PanelFormCreate;
        private Tira.Component.TiraButton buttonCancel;
        private Tira.Component.TiraButton btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Tira.Component.TiraTextBox txtCity;
        private Tira.Component.TiraTextBox txtKodyaKab;
        private Tira.Component.TiraTextBox txtProvince;
    }
}