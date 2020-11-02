namespace MADITP2._0.Global
{
    partial class clsWarehouse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.dg = new Tira.Component.TiraDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.find = new Tira.Component.TiraTextBox();
            this.OK = new FontAwesome.Sharp.IconButton();
            this.repId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 30);
            this.panel1.TabIndex = 5;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(3, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(66, 15);
            this.title.TabIndex = 2;
            this.title.Text = "Rep Master";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg.ColumnHeadersHeight = 22;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repId,
            this.repName,
            this.branch});
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Location = new System.Drawing.Point(0, 30);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg.RowHeadersVisible = false;
            this.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dg.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(475, 270);
            this.dg.TabIndex = 6;
            this.dg.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.find);
            this.panel2.Controls.Add(this.OK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 25);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find ID or Name";
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.find.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.find.ForeColor = System.Drawing.Color.DimGray;
            this.find.Location = new System.Drawing.Point(99, 1);
            this.find.MaxLength = 255;
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(320, 23);
            this.find.TabIndex = 2;
            this.find.TiraBorderColor = System.Drawing.Color.Silver;
            this.find.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.find.TiraMandatory = true;
            this.find.TiraPlaceHolder = null;
            this.find.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.find.TextChanged += new System.EventHandler(this.find_TextChanged);
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
            this.OK.Location = new System.Drawing.Point(425, 0);
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
            // repId
            // 
            this.repId.DataPropertyName = "warehouse_id";
            this.repId.HeaderText = "ID";
            this.repId.Name = "warehouse_id";
            this.repId.ReadOnly = true;
            this.repId.Width = 41;
            // 
            // repName
            // 
            this.repName.DataPropertyName = "warehouse_description";
            this.repName.HeaderText = "NAME / DESC";
            this.repName.Name = "warehouse_description";
            this.repName.ReadOnly = true;
            this.repName.Width = 98;
            // 
            // branch
            // 
            this.branch.DataPropertyName = "city";
            this.branch.HeaderText = "CITY";
            this.branch.Name = "branch";
            this.branch.ReadOnly = true;
            this.branch.Width = 51;
            // 
            // clsWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clsWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clsRepMaster";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.clsWarehouse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private Tira.Component.TiraDataGrid dg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Tira.Component.TiraTextBox find;
        private FontAwesome.Sharp.IconButton OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn repId;
        private System.Windows.Forms.DataGridViewTextBoxColumn repName;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch;
    }
}