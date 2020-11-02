namespace MADITP2._0.UserInterface.SO
{
    partial class SOKPSourceUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navClose = new Tira.Component.TiraButton();
            this.navExport = new Tira.Component.TiraButton();
            this.navPrint = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.panelView = new System.Windows.Forms.Panel();
            this.tiraDataGrid1 = new Tira.Component.TiraDataGrid();
            this.ks_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ks_source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ks_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.buttonCancel = new Tira.Component.TiraButton();
            this.buttonSave = new Tira.Component.TiraButton();
            this.kpGroup = new Tira.Component.TiraComboBox();
            this.kpId = new Tira.Component.TiraTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kpDesc = new Tira.Component.TiraTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopMenu.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiraDataGrid1)).BeginInit();
            this.panelEditor.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTopMenu.Size = new System.Drawing.Size(800, 30);
            this.panelTopMenu.TabIndex = 2;
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
            this.navClose.Location = new System.Drawing.Point(770, 0);
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
            // panelView
            // 
            this.panelView.Controls.Add(this.tiraDataGrid1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 30);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(800, 420);
            this.panelView.TabIndex = 3;
            // 
            // tiraDataGrid1
            // 
            this.tiraDataGrid1.AllowUserToAddRows = false;
            this.tiraDataGrid1.AllowUserToDeleteRows = false;
            this.tiraDataGrid1.AllowUserToOrderColumns = true;
            this.tiraDataGrid1.AllowUserToResizeColumns = false;
            this.tiraDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tiraDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tiraDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiraDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tiraDataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tiraDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tiraDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tiraDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tiraDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tiraDataGrid1.ColumnHeadersHeight = 27;
            this.tiraDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tiraDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ks_id,
            this.ks_source,
            this.ks_group});
            this.tiraDataGrid1.EnableHeadersVisualStyles = false;
            this.tiraDataGrid1.Location = new System.Drawing.Point(12, 6);
            this.tiraDataGrid1.Name = "tiraDataGrid1";
            this.tiraDataGrid1.ReadOnly = true;
            this.tiraDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tiraDataGrid1.RowHeadersVisible = false;
            this.tiraDataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.tiraDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tiraDataGrid1.RowTemplate.Height = 25;
            this.tiraDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tiraDataGrid1.Size = new System.Drawing.Size(776, 350);
            this.tiraDataGrid1.TabIndex = 0;
            // 
            // ks_id
            // 
            this.ks_id.DataPropertyName = "ks_id";
            this.ks_id.HeaderText = "KP ID";
            this.ks_id.Name = "ks_id";
            this.ks_id.ReadOnly = true;
            this.ks_id.Width = 56;
            // 
            // ks_source
            // 
            this.ks_source.DataPropertyName = "ks_source";
            this.ks_source.HeaderText = "KP DESCRIPTION";
            this.ks_source.Name = "ks_source";
            this.ks_source.ReadOnly = true;
            this.ks_source.Width = 114;
            // 
            // ks_group
            // 
            this.ks_group.DataPropertyName = "ks_group";
            this.ks_group.HeaderText = "KP GROUP";
            this.ks_group.Name = "ks_group";
            this.ks_group.ReadOnly = true;
            this.ks_group.Width = 83;
            // 
            // panelEditor
            // 
            this.panelEditor.Controls.Add(this.buttonCancel);
            this.panelEditor.Controls.Add(this.buttonSave);
            this.panelEditor.Controls.Add(this.kpGroup);
            this.panelEditor.Controls.Add(this.kpId);
            this.panelEditor.Controls.Add(this.label4);
            this.panelEditor.Controls.Add(this.kpDesc);
            this.panelEditor.Controls.Add(this.label3);
            this.panelEditor.Controls.Add(this.label1);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditor.Location = new System.Drawing.Point(0, 30);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(800, 420);
            this.panelEditor.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.buttonCancel.IconColor = System.Drawing.Color.Black;
            this.buttonCancel.IconSize = 20;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(244, 132);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Rotation = 0D;
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 53;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.buttonSave.IconColor = System.Drawing.Color.White;
            this.buttonSave.IconSize = 20;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(330, 132);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Rotation = 0D;
            this.buttonSave.Size = new System.Drawing.Size(80, 30);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // kpGroup
            // 
            this.kpGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.kpGroup.ForeColor = System.Drawing.Color.DimGray;
            this.kpGroup.FormattingEnabled = true;
            this.kpGroup.Location = new System.Drawing.Point(12, 103);
            this.kpGroup.Name = "kpGroup";
            this.kpGroup.Size = new System.Drawing.Size(398, 23);
            this.kpGroup.TabIndex = 51;
            this.kpGroup.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.kpGroup.TiraPlaceHolder = null;
            // 
            // kpId
            // 
            this.kpId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.kpId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kpId.ForeColor = System.Drawing.Color.DimGray;
            this.kpId.Location = new System.Drawing.Point(12, 20);
            this.kpId.MaxLength = 255;
            this.kpId.Name = "kpId";
            this.kpId.ReadOnly = true;
            this.kpId.Size = new System.Drawing.Size(398, 23);
            this.kpId.TabIndex = 50;
            this.kpId.TiraBorderColor = System.Drawing.Color.Silver;
            this.kpId.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.kpId.TiraMandatory = true;
            this.kpId.TiraPlaceHolder = null;
            this.kpId.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "KP Source Group";
            // 
            // kpDesc
            // 
            this.kpDesc.BackColor = System.Drawing.Color.White;
            this.kpDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kpDesc.ForeColor = System.Drawing.Color.DimGray;
            this.kpDesc.Location = new System.Drawing.Point(12, 61);
            this.kpDesc.MaxLength = 255;
            this.kpDesc.Name = "kpDesc";
            this.kpDesc.Size = new System.Drawing.Size(398, 23);
            this.kpDesc.TabIndex = 47;
            this.kpDesc.TiraBorderColor = System.Drawing.Color.Silver;
            this.kpDesc.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.kpDesc.TiraMandatory = false;
            this.kpDesc.TiraPlaceHolder = null;
            this.kpDesc.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "KP Source Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "KP Source ID";
            // 
            // SOKPSourceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelEditor);
            this.Controls.Add(this.panelTopMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SOKPSourceUI";
            this.Text = "SOKPSourceUI";
            this.Load += new System.EventHandler(this.SOKPSourceUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tiraDataGrid1)).EndInit();
            this.panelEditor.ResumeLayout(false);
            this.panelEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navClose;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraDataGrid tiraDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ks_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ks_source;
        private System.Windows.Forms.DataGridViewTextBoxColumn ks_group;
        private System.Windows.Forms.Panel panelEditor;
        private Tira.Component.TiraComboBox kpGroup;
        private Tira.Component.TiraTextBox kpId;
        private System.Windows.Forms.Label label4;
        private Tira.Component.TiraTextBox kpDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Tira.Component.TiraButton buttonCancel;
        private Tira.Component.TiraButton buttonSave;
    }
}