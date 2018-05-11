namespace GUI
{
    partial class Frm_QLTD
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnCancer = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.txbDonViTinh = new System.Windows.Forms.TextBox();
            this.txbTenMA = new System.Windows.Forms.TextBox();
            this.txbMaMA = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblTenMA = new System.Windows.Forms.Label();
            this.lblMonanid = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.lblTennhom = new System.Windows.Forms.Label();
            this.lblManhom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trvNhomMA = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLTDDataSet = new GUI.QLTDDataSet();
            this.monAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monAnTableAdapter = new GUI.QLTDDataSetTableAdapters.MonAnTableAdapter();
            this.maMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monAnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(614, 460);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(505, 460);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.Text = "Save";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(392, 460);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(75, 23);
            this.btnMoi.TabIndex = 39;
            this.btnMoi.Text = "Nhap moi";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnCancer
            // 
            this.btnCancer.Location = new System.Drawing.Point(168, 460);
            this.btnCancer.Name = "btnCancer";
            this.btnCancer.Size = new System.Drawing.Size(75, 23);
            this.btnCancer.TabIndex = 38;
            this.btnCancer.Text = "CANCEL";
            this.btnCancer.UseVisualStyleBackColor = true;
            this.btnCancer.Click += new System.EventHandler(this.btnCancer_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(72, 460);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "ADD";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbDonGia
            // 
            this.txbDonGia.Location = new System.Drawing.Point(416, 417);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(273, 20);
            this.txbDonGia.TabIndex = 36;
            // 
            // txbDonViTinh
            // 
            this.txbDonViTinh.Location = new System.Drawing.Point(416, 381);
            this.txbDonViTinh.Name = "txbDonViTinh";
            this.txbDonViTinh.Size = new System.Drawing.Size(273, 20);
            this.txbDonViTinh.TabIndex = 35;
            // 
            // txbTenMA
            // 
            this.txbTenMA.Location = new System.Drawing.Point(416, 349);
            this.txbTenMA.Name = "txbTenMA";
            this.txbTenMA.Size = new System.Drawing.Size(273, 20);
            this.txbTenMA.TabIndex = 34;
            // 
            // txbMaMA
            // 
            this.txbMaMA.Location = new System.Drawing.Point(416, 313);
            this.txbMaMA.Name = "txbMaMA";
            this.txbMaMA.Size = new System.Drawing.Size(273, 20);
            this.txbMaMA.TabIndex = 33;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(300, 420);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(44, 13);
            this.lblDonGia.TabIndex = 32;
            this.lblDonGia.Text = "Don gia";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(300, 384);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(58, 13);
            this.lblDVT.TabIndex = 31;
            this.lblDVT.Text = "Don vi tinh";
            // 
            // lblTenMA
            // 
            this.lblTenMA.AutoSize = true;
            this.lblTenMA.Location = new System.Drawing.Point(300, 352);
            this.lblTenMA.Name = "lblTenMA";
            this.lblTenMA.Size = new System.Drawing.Size(64, 13);
            this.lblTenMA.TabIndex = 30;
            this.lblTenMA.Text = "Ten mon an";
            // 
            // lblMonanid
            // 
            this.lblMonanid.AutoSize = true;
            this.lblMonanid.Location = new System.Drawing.Point(300, 316);
            this.lblMonanid.Name = "lblMonanid";
            this.lblMonanid.Size = new System.Drawing.Size(60, 13);
            this.lblMonanid.TabIndex = 29;
            this.lblMonanid.Text = "Ma mon an";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(105, 415);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(138, 20);
            this.txtTenNhom.TabIndex = 28;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(105, 379);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(138, 20);
            this.txtMaNhom.TabIndex = 27;
            // 
            // lblTennhom
            // 
            this.lblTennhom.AutoSize = true;
            this.lblTennhom.Location = new System.Drawing.Point(12, 418);
            this.lblTennhom.Name = "lblTennhom";
            this.lblTennhom.Size = new System.Drawing.Size(55, 13);
            this.lblTennhom.TabIndex = 26;
            this.lblTennhom.Text = "Ten nhom";
            // 
            // lblManhom
            // 
            this.lblManhom.AutoSize = true;
            this.lblManhom.Location = new System.Drawing.Point(12, 382);
            this.lblManhom.Name = "lblManhom";
            this.lblManhom.Size = new System.Drawing.Size(51, 13);
            this.lblManhom.TabIndex = 25;
            this.lblManhom.Text = "Ma nhom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thong tin mon an";
            // 
            // trvNhomMA
            // 
            this.trvNhomMA.Location = new System.Drawing.Point(12, 12);
            this.trvNhomMA.Name = "trvNhomMA";
            this.trvNhomMA.Size = new System.Drawing.Size(231, 344);
            this.trvNhomMA.TabIndex = 22;
            this.trvNhomMA.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvNhomMA_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonAnDataGridViewTextBoxColumn,
            this.tenMonAnDataGridViewTextBoxColumn,
            this.donViTinhDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.maNhomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.monAnBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(250, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 249);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // qLTDDataSet
            // 
            this.qLTDDataSet.DataSetName = "QLTDDataSet";
            this.qLTDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monAnBindingSource
            // 
            this.monAnBindingSource.DataMember = "MonAn";
            this.monAnBindingSource.DataSource = this.qLTDDataSet;
            // 
            // monAnTableAdapter
            // 
            this.monAnTableAdapter.ClearBeforeFill = true;
            // 
            // maMonAnDataGridViewTextBoxColumn
            // 
            this.maMonAnDataGridViewTextBoxColumn.DataPropertyName = "maMonAn";
            this.maMonAnDataGridViewTextBoxColumn.HeaderText = "maMonAn";
            this.maMonAnDataGridViewTextBoxColumn.Name = "maMonAnDataGridViewTextBoxColumn";
            // 
            // tenMonAnDataGridViewTextBoxColumn
            // 
            this.tenMonAnDataGridViewTextBoxColumn.DataPropertyName = "tenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.HeaderText = "tenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.Name = "tenMonAnDataGridViewTextBoxColumn";
            // 
            // donViTinhDataGridViewTextBoxColumn
            // 
            this.donViTinhDataGridViewTextBoxColumn.DataPropertyName = "donViTinh";
            this.donViTinhDataGridViewTextBoxColumn.HeaderText = "donViTinh";
            this.donViTinhDataGridViewTextBoxColumn.Name = "donViTinhDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "donGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "donGia";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // maNhomDataGridViewTextBoxColumn
            // 
            this.maNhomDataGridViewTextBoxColumn.DataPropertyName = "maNhom";
            this.maNhomDataGridViewTextBoxColumn.HeaderText = "maNhom";
            this.maNhomDataGridViewTextBoxColumn.Name = "maNhomDataGridViewTextBoxColumn";
            // 
            // Frm_QLTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnCancer);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbDonGia);
            this.Controls.Add(this.txbDonViTinh);
            this.Controls.Add(this.txbTenMA);
            this.Controls.Add(this.txbMaMA);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.lblTenMA);
            this.Controls.Add(this.lblMonanid);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.lblTennhom);
            this.Controls.Add(this.lblManhom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trvNhomMA);
            this.Name = "Frm_QLTD";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Frm_QLTD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monAnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnCancer;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.TextBox txbDonViTinh;
        private System.Windows.Forms.TextBox txbTenMA;
        private System.Windows.Forms.TextBox txbMaMA;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblTenMA;
        private System.Windows.Forms.Label lblMonanid;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label lblTennhom;
        private System.Windows.Forms.Label lblManhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trvNhomMA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLTDDataSet qLTDDataSet;
        private System.Windows.Forms.BindingSource monAnBindingSource;
        private QLTDDataSetTableAdapters.MonAnTableAdapter monAnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomDataGridViewTextBoxColumn;
    }
}

