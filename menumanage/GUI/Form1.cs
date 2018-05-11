using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Entities;
using GUI.DataAccess;


namespace GUI
{
    public partial class Frm_QLTD : Form
    {
        NhomMonAnDAL ndao;
        List<NhomMonAnEntity> dsNhom;
        List<MonAnEntity> lstMA;
        MonAnDAL madao;
        public Frm_QLTD()
        {
            InitializeComponent();
            LoadTree();
            AnTextBoxMonAn(false);
            AnTextBoxNhomMonAn(false);
        }
        private void LoadTree()
        {
            ndao = new NhomMonAnDAL();
            dsNhom = new List<NhomMonAnEntity>();
            dsNhom = ndao.LayDanhSachNhom();
            trvNhomMA.Nodes.Clear();
            
            foreach (var item in dsNhom)
            {
                TreeNode n = new TreeNode(item.TenNhom);
                n.Tag = item.MaNhom;
                trvNhomMA.Nodes.Add(n);

            }
            trvNhomMA.ExpandAll();
        }
        private void AnTextBoxMonAn(bool khoa)
        {
            txbMaMA.Enabled = khoa;
            txbTenMA.Enabled = khoa;
            txbDonViTinh.Enabled = khoa;
            txbDonGia.Enabled = khoa;
            btnLuu.Enabled = khoa;
        }
        private void AnTextBoxNhomMonAn(bool khoa)
        {
            txtMaNhom.Enabled = khoa;
            txtTenNhom.Enabled = khoa;
        }
        private void Frm_QLTD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTDDataSet.MonAn' table. You can move, or remove it, as needed.
            this.monAnTableAdapter.Fill(this.qLTDDataSet.MonAn);

        }

        private void trvNhomMA_AfterSelect(object sender, TreeViewEventArgs e)
        {
            madao = new MonAnDAL();
            LoadDataGrid((int)e.Node.Tag);
            FormatGrid();
        }
        private void LoadDataGrid(int manhom)
        {
            lstMA = madao.LayDanhSachMonAnTheoNhom(manhom);
            dataGridView1.DataSource = lstMA;
        }
        private void FormatGrid()
        {
            if (dataGridView1.Columns["maMonAn"] != null)
                dataGridView1.Columns["maMonAn"].Visible = false;
            if (dataGridView1.Columns["tenMonAn"] != null)
            {
                dataGridView1.Columns["tenMonAn"].HeaderText = "Ten mon an";
                dataGridView1.Columns["tenMonAn"].Width = 200;
            }
            if (dataGridView1.Columns["donViTinh"] != null)
            {
                dataGridView1.Columns["donViTinh"].HeaderText = "Don Vi Tinh";
                dataGridView1.Columns["donViTinh"].Width = 150;
            }
            if (dataGridView1.Columns["donGia"] != null)
            {
                dataGridView1.Columns["donGia"].HeaderText = "Don gia";
                dataGridView1.Columns["donGia"].Width = 130;
            }
            
            if (dataGridView1.Columns["maNhom"] != null)
                dataGridView1.Columns["maNhom"].Visible = false;

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txbMaMA.Text = e.Row.Cells["maMonAn"].Value.ToString();
                txbTenMA.Text = e.Row.Cells["tenMonAn"].Value.ToString();
                txbDonGia.Text = e.Row.Cells["donGia"].Value.ToString();
                txbDonViTinh.Text = e.Row.Cells["donViTinh"].Value.ToString();
                
            }
            else
            {
                XoaTextBox();
            }
        }
        private void XoaTextBox()
        {
            txbMaMA.ResetText();
            txbTenMA.Clear();
            txbDonViTinh.Text = "";
            txbDonGia.Clear();

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            if (btnMoi.Text == "&Nhập mới")
            {
                XoaTextBox();
                txbMaMA.Focus();
                AnTextBoxMonAn(true);
                btnMoi.Text = "Bo qua";
            }
            else
            {
                AnTextBoxMonAn(false);
                btnMoi.Text = "&Nhập mới";

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "&Sửa thông tin")
            {
                AnTextBoxMonAn(true);
                txbTenMA.Focus();
                txbMaMA.Enabled = false;
                btnSua.Text = "Bo qua";
            }
            else
            {
                AnTextBoxMonAn(false);
                btnSua.Text = "&Sửa thông tin";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txbMaMA.Enabled)
            {
                //them
                try
                {
                    MonAnEntity m = new MonAnEntity(txbMaMA.Text, txbTenMA.Text, txbDonViTinh.Text, decimal.Parse(txbDonGia.Text),  (int)trvNhomMA.SelectedNode.Tag);
                    if (madao.ThemMonAn(m))
                    {
                        LoadDataGrid((int)trvNhomMA.SelectedNode.Tag);
                        AnTextBoxMonAn(false);
                        btnMoi.Text = "&Nhập mới";
                    }
                    else
                    {
                        MessageBox.Show("Khong them duoc!");
                        txbMaMA.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //sua
                try
                {
                    MonAnEntity m = new MonAnEntity(txbMaMA.Text, txbTenMA.Text, txbDonViTinh.Text, decimal.Parse(txbDonGia.Text), (int)trvNhomMA.SelectedNode.Tag);
                    if (madao.SuaMonAn(m))
                    {
                        LoadDataGrid((int)trvNhomMA.SelectedNode.Tag);
                        AnTextBoxMonAn(false);
                        btnSua.Text = "&Sửa thông tin";
                    }
                    else
                    {
                        MessageBox.Show("Khong sua duoc!");
                        txbTenMA.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                AnTextBoxNhomMonAn(true);
                txtMaNhom.Focus();
                btnThem.Text = "Luu";
                txtMaNhom.Text = "";
                txtTenNhom.Text = "";
            }
            else
            {
                //luu
                try
                {
                    NhomMonAnEntity m = new NhomMonAnEntity(int.Parse(txtMaNhom.Text), txtTenNhom.Text);
                    if (ndao.ThemNhom(m))
                    {
                        LoadTree();
                        AnTextBoxNhomMonAn(false);
                        btnThem.Text = "Thêm";
                    }
                    else
                    {
                        MessageBox.Show("Khong them duoc!");
                        txtMaNhom.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            btnThem.Text = "Thêm";
            AnTextBoxNhomMonAn(false);
        }
    }
}
