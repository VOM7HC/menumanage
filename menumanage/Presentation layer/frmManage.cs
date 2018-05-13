using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;
using Data_layer;
using Business_layer;

namespace Presentation_layer
{
    public partial class frmManage : Form
    {
        NhomMonAn_Data nhomMon;
        MonAn_Data monAn;
        List<NhomObj> lstNhom;
        List<MonAnObj> lstmonAn;

        public frmManage()
        {
            InitializeComponent();
            loadTree();
            HideTextMonAn(false);
            HideTextNhom(false);
        }
        private void loadTree()
        {
            nhomMon = new NhomMonAn_Data();
            lstNhom = new List<NhomObj>();
            lstNhom = nhomMon.GetNhomMon();
            treeView.Nodes.Clear();
            foreach (var item in lstNhom)
            {
                TreeNode node = new TreeNode(item.TenNhom);
                node.Tag = item.MaNhom;
                treeView.Nodes.Add(node);
            }
            treeView.ExpandAll();
        }
        private void HideTextMonAn(bool key)
        {
            txtMaMA.Enabled = key;
            txtTenMA.Enabled = key;
            txtDV.Enabled = key;
            txtDG.Enabled = key;
            txtGC.Enabled = key;
            btnLuu.Enabled = key;
        }
        private void HideTextNhom(bool key)
        {
            txtMaNhom.Enabled = key;
            txtTenNhom.Enabled = key;
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            monAn = new MonAn_Data();
            loadDataGrid((int)e.Node.Tag);
            formatGrid();
        }
        private void loadDataGrid(int manhom)
        {
            lstmonAn = monAn.GetTheoNhom(manhom);
            dataGridView.DataSource = lstmonAn;
        }
        private void formatGrid()
        {
            if (dataGridView.Columns["maMonAn"] != null)
                dataGridView.Columns["maMonAn"].Visible = false;
            if (dataGridView.Columns["tenMonAn"] != null)
            {
                dataGridView.Columns["tenMonAn"].HeaderText = "Ten mon an";
                dataGridView.Columns["tenMonAn"].Width = 200;
            }
            if (dataGridView.Columns["donViTinh"] != null)
            {
                dataGridView.Columns["donViTinh"].HeaderText = "Don Vi Tinh";
                dataGridView.Columns["donViTinh"].Width = 150;
            }
            if (dataGridView.Columns["donGia"] != null)
            {
                dataGridView.Columns["donGia"].HeaderText = "Don gia";
                dataGridView.Columns["donGia"].Width = 130;
            }
            if (dataGridView.Columns["ghiChu"] != null)
            {
                dataGridView.Columns["ghiChu"].HeaderText = "Ghi chu";
                dataGridView.Columns["ghiChu"].Width = 220;
            }
            if (dataGridView.Columns["maNhom"] != null)
                dataGridView.Columns["maNhom"].Visible = false;
        }

        private void dataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                txtMaMA.Text = e.Row.Cells["maMonAn"].Value.ToString();
                txtTenMA.Text = e.Row.Cells["tenMonAn"].Value.ToString();
                txtDG.Text = e.Row.Cells["donGia"].Value.ToString();
                txtDV.Text = e.Row.Cells["donViTinh"].Value.ToString();
                txtGC.Text = e.Row.Cells["ghiChu"].Value.ToString();
            }
            else
                clearTextBox();
        }
        private void clearTextBox()
        {
            txtMaMA.ResetText();
            txtTenMA.Clear();
            txtDV.Text = "";
            txtGC.Clear();
            txtDG.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "&Nhập mới")
            {
                clearTextBox();
                txtMaMA.Focus();
                HideTextMonAn(true);
                btnThem.Text = "Hủy thêm";
            }
            else
            {
                HideTextMonAn(false);
                btnThem.Text = "&Nhập mới";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaMA.Enabled)
            {
                try
                {
                    MonAnObj monAnObj = new MonAnObj(txtMaMA.Text, txtTenMA.Text, txtDV.Text, decimal.Parse(txtDG.Text), txtGC.Text, (int)treeView.SelectedNode.Tag);
                    if(monAn.AddMonAn(monAnObj))
                    {
                        loadDataGrid((int)treeView.SelectedNode.Tag);
                        HideTextMonAn(false);
                        btnThem.Text = "&Nhập mới";
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được!");
                        txtMaMA.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    MonAnObj monAnObj = new MonAnObj(txtMaMA.Text, txtTenMA.Text, txtDV.Text, decimal.Parse(txtDG.Text), txtGC.Text, (int)treeView.SelectedNode.Tag);
                    if (monAn.AddMonAn(monAnObj))
                    {
                        loadDataGrid((int)treeView.SelectedNode.Tag);
                        HideTextMonAn(false);
                        btnThem.Text = "&Nhập mới";
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được!");
                        txtMaMA.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "&Sửa thông tin")
            {
                HideTextMonAn(true);
                txtTenMA.Focus();
                txtMaMA.Enabled = false;
                btnSua.Text = "Hủy sửa";
            }
            else
            {
                HideTextMonAn(false);
                btnSua.Text = "&Sửa thông tin";
            }
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            if (btnThemNhom.Text == "Thêm")
            {
                HideTextNhom(true);
                txtMaNhom.Focus();
                btnThemNhom.Text = "Lưu";
                txtMaNhom.Text = "";
                txtTenNhom.Text = "";
            }
            else
            {
                try
                {
                    NhomObj nhom = new NhomObj(int.Parse(txtMaNhom.Text), txtTenNhom.Text);
                    if (nhomMon.AddNhom(nhom))
                    {
                        loadTree();
                        HideTextNhom(false);
                        btnThemNhom.Text = "Thêm";
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được!");
                        txtMaNhom.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThemNhom.Text = "Thêm";
            HideTextNhom(false);
        }
    }
}
