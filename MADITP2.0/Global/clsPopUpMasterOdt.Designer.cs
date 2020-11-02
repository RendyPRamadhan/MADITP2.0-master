namespace MADITP2._0.Global
{
    partial class clsPopUpMasterOdt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Tira.Component.TiraTextBox();
            this.OK = new FontAwesome.Sharp.IconButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tgl_Oct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Peserta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oct_Hanphone_Peserta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Division_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rep_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rep_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvResult.ColumnHeadersHeight = 22;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tgl_Oct,
            this.Nama_Peserta,
            this.Oct_Hanphone_Peserta,
            this.Division_Id,
            this.Branch_Id,
            this.Rep_Id,
            this.Rep_Name});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(0, 32);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(575, 362);
            this.dgvResult.TabIndex = 7;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 30);
            this.panel1.TabIndex = 8;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(3, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(71, 15);
            this.title.TabIndex = 2;
            this.title.Text = "Master ODT";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.OK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 25);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find ID or Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(99, 1);
            this.txtSearch.MaxLength = 255;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(418, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtSearch.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtSearch.TiraMandatory = true;
            this.txtSearch.TiraPlaceHolder = null;
            this.txtSearch.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // OK
            // 
            this.OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.OK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.OK.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.OK.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.OK.IconSize = 20;
            this.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK.Location = new System.Drawing.Point(525, 0);
            this.OK.Name = "OK";
            this.OK.Rotation = 0D;
            this.OK.Size = new System.Drawing.Size(50, 25);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "OCT ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 66;
            // 
            // Tgl_Oct
            // 
            this.Tgl_Oct.DataPropertyName = "Tgl_Oct";
            this.Tgl_Oct.HeaderText = "TGL OCT";
            this.Tgl_Oct.Name = "Tgl_Oct";
            this.Tgl_Oct.ReadOnly = true;
            this.Tgl_Oct.Width = 73;
            // 
            // Nama_Peserta
            // 
            this.Nama_Peserta.DataPropertyName = "Nama_Peserta";
            this.Nama_Peserta.HeaderText = "NAME";
            this.Nama_Peserta.Name = "Nama_Peserta";
            this.Nama_Peserta.ReadOnly = true;
            this.Nama_Peserta.Width = 61;
            // 
            // Oct_Hanphone_Peserta
            // 
            this.Oct_Hanphone_Peserta.DataPropertyName = "Oct_Hanphone_Peserta";
            this.Oct_Hanphone_Peserta.HeaderText = "NO HP";
            this.Oct_Hanphone_Peserta.Name = "Oct_Hanphone_Peserta";
            this.Oct_Hanphone_Peserta.ReadOnly = true;
            this.Oct_Hanphone_Peserta.Width = 64;
            // 
            // Division_Id
            // 
            this.Division_Id.DataPropertyName = "Division_Id";
            this.Division_Id.HeaderText = "DIVISION";
            this.Division_Id.Name = "Division_Id";
            this.Division_Id.ReadOnly = true;
            this.Division_Id.Width = 77;
            // 
            // Branch_Id
            // 
            this.Branch_Id.DataPropertyName = "Branch_Id";
            this.Branch_Id.HeaderText = "BRANCH ID";
            this.Branch_Id.Name = "Branch_Id";
            this.Branch_Id.ReadOnly = true;
            this.Branch_Id.Width = 87;
            // 
            // Rep_Id
            // 
            this.Rep_Id.DataPropertyName = "Rep_Id";
            this.Rep_Id.HeaderText = "REP ID";
            this.Rep_Id.Name = "Rep_Id";
            this.Rep_Id.ReadOnly = true;
            this.Rep_Id.Width = 63;
            // 
            // Rep_Name
            // 
            this.Rep_Name.DataPropertyName = "Rep_Name";
            this.Rep_Name.HeaderText = "REP NAME";
            this.Rep_Name.Name = "Rep_Name";
            this.Rep_Name.ReadOnly = true;
            this.Rep_Name.Width = 83;
            // 
            // clsPopUpMasterOdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvResult);
            this.Name = "clsPopUpMasterOdt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pop up Master ODT";
            this.Load += new System.EventHandler(this.clsPopUpMasterOdt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Tira.Component.TiraDataGrid dgvResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Tira.Component.TiraTextBox txtSearch;
        private FontAwesome.Sharp.IconButton OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tgl_Oct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Peserta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oct_Hanphone_Peserta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rep_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rep_Name;
    }
}