namespace MADITP2._0.Global
{
    partial class clsPopUpProduct
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
            this.dataGridProduct = new Tira.Component.TiraDataGrid();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlView = new System.Windows.Forms.Panel();
            this.txtBoxSearch = new Tira.Component.TiraTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navClose = new Tira.Component.TiraButton();
            this.title = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.btnOk = new Tira.Component.TiraButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.pnlView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AllowUserToOrderColumns = true;
            this.dataGridProduct.AllowUserToResizeColumns = false;
            this.dataGridProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridProduct.ColumnHeadersHeight = 22;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_description});
            this.dataGridProduct.EnableHeadersVisualStyles = false;
            this.dataGridProduct.Location = new System.Drawing.Point(2, 31);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridProduct.RowHeadersVisible = false;
            this.dataGridProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProduct.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridProduct.RowTemplate.Height = 25;
            this.dataGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduct.Size = new System.Drawing.Size(795, 318);
            this.dataGridProduct.TabIndex = 59;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            this.dataGridProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellDoubleClick);
            // 
            // product_id
            // 
            this.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_id.DataPropertyName = "pm_product_id";
            this.product_id.HeaderText = "PRODUCT ID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // product_description
            // 
            this.product_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_description.DataPropertyName = "pm_product_description";
            this.product_description.HeaderText = "PRODUCT DESCRIPTION";
            this.product_description.Name = "product_description";
            this.product_description.ReadOnly = true;
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Controls.Add(this.txtBoxSearch);
            this.pnlView.Controls.Add(this.panel1);
            this.pnlView.Controls.Add(this.label52);
            this.pnlView.Controls.Add(this.btnOk);
            this.pnlView.Controls.Add(this.dataGridProduct);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(800, 380);
            this.pnlView.TabIndex = 74;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSearch.Location = new System.Drawing.Point(99, 353);
            this.txtBoxSearch.MaxLength = 255;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(642, 24);
            this.txtBoxSearch.TabIndex = 60;
            this.txtBoxSearch.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxSearch.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxSearch.TiraMandatory = true;
            this.txtBoxSearch.TiraPlaceHolder = null;
            this.txtBoxSearch.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.navClose);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 162;
            // 
            // navClose
            // 
            this.navClose.BackColor = System.Drawing.Color.White;
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
            this.navClose.TabIndex = 10;
            this.navClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navClose.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navClose.UseVisualStyleBackColor = false;
            this.navClose.Click += new System.EventHandler(this.navClose_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(3, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(108, 15);
            this.title.TabIndex = 2;
            this.title.Text = "SEARCH PRODUCT";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(5, 359);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(87, 13);
            this.label52.TabIndex = 58;
            this.label52.Text = "Find ID Or Desc";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnOk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnOk.IconSize = 20;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(747, 353);
            this.btnOk.Name = "btnOk";
            this.btnOk.Rotation = 0D;
            this.btnOk.Size = new System.Drawing.Size(50, 25);
            this.btnOk.TabIndex = 106;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // clsPopUpProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.ControlBox = false;
            this.Controls.Add(this.pnlView);
            this.Name = "clsPopUpProduct";
            this.Text = "clsPopUpProduct";
            this.Load += new System.EventHandler(this.clsPopUpProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tira.Component.TiraDataGrid dataGridProduct;
        private System.Windows.Forms.Panel pnlView;
        private Tira.Component.TiraTextBox txtBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        internal System.Windows.Forms.Label label52;
        private Tira.Component.TiraButton btnOk;
        private Tira.Component.TiraButton navClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_description;
    }
}