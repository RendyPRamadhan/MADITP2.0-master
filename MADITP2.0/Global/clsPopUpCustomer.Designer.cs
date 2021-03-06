﻿namespace MADITP2._0.UserInterface.SO.SOVerificationProcess
{
    partial class clsPopUpCustomer
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
            this.pnlView = new System.Windows.Forms.Panel();
            this.txtFind = new Tira.Component.TiraTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.btnSubmit = new Tira.Component.TiraButton();
            this.grd = new Tira.Component.TiraDataGrid();
            this.scm_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scm_customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlView.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Controls.Add(this.txtFind);
            this.pnlView.Controls.Add(this.panel1);
            this.pnlView.Controls.Add(this.label52);
            this.pnlView.Controls.Add(this.btnSubmit);
            this.pnlView.Controls.Add(this.grd);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(546, 339);
            this.pnlView.TabIndex = 73;
            this.pnlView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlView_Paint);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DimGray;
            this.txtFind.Location = new System.Drawing.Point(99, 312);
            this.txtFind.MaxLength = 255;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(391, 24);
            this.txtFind.TabIndex = 60;
            this.txtFind.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtFind.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtFind.TiraMandatory = true;
            this.txtFind.TiraPlaceHolder = null;
            this.txtFind.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 30);
            this.panel1.TabIndex = 162;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(3, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(116, 15);
            this.title.TabIndex = 2;
            this.title.Text = "SEARCH CUSTOMER";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(5, 318);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(90, 13);
            this.label52.TabIndex = 58;
            this.label52.Text = "Find ID or Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSubmit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSubmit.IconSize = 20;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Location = new System.Drawing.Point(493, 312);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Rotation = 0D;
            this.btnSubmit.Size = new System.Drawing.Size(50, 25);
            this.btnSubmit.TabIndex = 106;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmit.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AllowUserToOrderColumns = true;
            this.grd.AllowUserToResizeColumns = false;
            this.grd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd.ColumnHeadersHeight = 22;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scm_customer_id,
            this.scm_customer_name});
            this.grd.EnableHeadersVisualStyles = false;
            this.grd.Location = new System.Drawing.Point(2, 31);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd.RowHeadersVisible = false;
            this.grd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.grd.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grd.RowTemplate.Height = 25;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(541, 277);
            this.grd.TabIndex = 59;
            this.grd.DoubleClick += new System.EventHandler(this.grd_DoubleClick);
            // 
            // scm_customer_id
            // 
            this.scm_customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scm_customer_id.DataPropertyName = "scm_customer_id";
            this.scm_customer_id.HeaderText = "CUSTOMER ID";
            this.scm_customer_id.Name = "scm_customer_id";
            this.scm_customer_id.ReadOnly = true;
            // 
            // scm_customer_name
            // 
            this.scm_customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scm_customer_name.DataPropertyName = "scm_customer_name";
            this.scm_customer_name.HeaderText = "CUSTOMER NAME";
            this.scm_customer_name.Name = "scm_customer_name";
            this.scm_customer_name.ReadOnly = true;
            // 
            // clsPopUpCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 339);
            this.ControlBox = false;
            this.Controls.Add(this.pnlView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clsPopUpCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SO_frmDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clsPopUpCustomer_KeyDown);
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private Tira.Component.TiraTextBox txtFind;
        private Tira.Component.TiraDataGrid grd;
        internal System.Windows.Forms.Label label52;
        private Tira.Component.TiraButton btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn scm_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn scm_customer_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
    }
}