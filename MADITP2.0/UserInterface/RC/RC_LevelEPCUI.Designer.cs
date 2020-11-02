namespace MADITP2._0.userInterface.RC
{
    partial class RC_LevelEPCUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RC_LevelEPCUI));
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRepId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtPosisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToOrderColumns = true;
            this.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(131, 63);
            this.dtGrid.MultiSelect = false;
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersWidth = 51;
            this.dtGrid.Size = new System.Drawing.Size(665, 357);
            this.dtGrid.TabIndex = 1;
            this.dtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellClick);
            this.dtGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellMouseLeave);
            this.dtGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGrid_CellMouseMove);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnSearch);
            this.groupBox11.Controls.Add(this.cmbFilter);
            this.groupBox11.Controls.Add(this.label84);
            this.groupBox11.Controls.Add(this.label70);
            this.groupBox11.Controls.Add(this.txt_position);
            this.groupBox11.Location = new System.Drawing.Point(131, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(665, 51);
            this.groupBox11.TabIndex = 471;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(85, 13);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(197, 21);
            this.cmbFilter.TabIndex = 430;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(17, 21);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(51, 13);
            this.label84.TabIndex = 429;
            this.label84.Text = "Group     ";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(310, 18);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(44, 13);
            this.label70.TabIndex = 417;
            this.label70.Text = "Position";
            // 
            // txt_position
            // 
            this.txt_position.BackColor = System.Drawing.Color.White;
            this.txt_position.Location = new System.Drawing.Point(360, 15);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(163, 20);
            this.txt_position.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 414);
            this.groupBox1.TabIndex = 473;
            this.groupBox1.TabStop = false;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.btn_Export);
            this.pnlStatus.Controls.Add(this.lblName);
            this.pnlStatus.Controls.Add(this.lblRepId);
            this.pnlStatus.Controls.Add(this.btnRefresh);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 426);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(800, 24);
            this.pnlStatus.TabIndex = 474;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(189, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Position:";
            // 
            // lblRepId
            // 
            this.lblRepId.AutoSize = true;
            this.lblRepId.Location = new System.Drawing.Point(3, 6);
            this.lblRepId.Name = "lblRepId";
            this.lblRepId.Size = new System.Drawing.Size(53, 13);
            this.lblRepId.TabIndex = 1;
            this.lblRepId.Text = "Group ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbGroup);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtPosisi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(131, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 414);
            this.groupBox2.TabIndex = 472;
            this.groupBox2.TabStop = false;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(246, 146);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(283, 21);
            this.cmbGroup.TabIndex = 15;
            // 
            // txtPosisi
            // 
            this.txtPosisi.Location = new System.Drawing.Point(246, 173);
            this.txtPosisi.MaxLength = 30;
            this.txtPosisi.Name = "txtPosisi";
            this.txtPosisi.Size = new System.Drawing.Size(284, 20);
            this.txtPosisi.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Grp_id";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::MADITP2._0.Properties.Resources.batal;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(492, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 48);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "BACK";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::MADITP2._0.Properties.Resources.tambah;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(577, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 48);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Export.Image = global::MADITP2._0.Properties.Resources.file_import;
            this.btn_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Export.Location = new System.Drawing.Point(649, 0);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(72, 23);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "Export";
            this.btn_Export.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Image = global::MADITP2._0.Properties.Resources.refresh_contact1924;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(727, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::MADITP2._0.Properties.Resources._6__2_;
            this.btnExit.Location = new System.Drawing.Point(33, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 33);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::MADITP2._0.Properties.Resources.Delete_Contact_4545;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(24, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 55);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(24, 173);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 55);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::MADITP2._0.Properties.Resources.Add_Contact_4545;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(24, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 55);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(24, 18);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(66, 55);
            this.btnList.TabIndex = 9;
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = global::MADITP2._0.Properties.Resources.contact_search1924;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(558, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 24);
            this.btnSearch.TabIndex = 432;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // RC_LevelEPCUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.dtGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RC_LevelEPCUI";
            this.Text = "RC_LevelEPCUI";
            this.Load += new System.EventHandler(this.RC_LevelEPCUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label70;
        public System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnList;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRepId;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbGroup;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPosisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btn_Export;
    }
}