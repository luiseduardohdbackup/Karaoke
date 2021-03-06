using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BKIT.Model;
using BKIT.Entities;
namespace Karaoke.MDIForms
{
    public partial class frmDieuChinhTonKho : DevExpress.XtraEditors.XtraForm
    {
        public frmDieuChinhTonKho()
        {
            InitializeComponent();
        }

        private void frmDieuChinhTonKho_Load(object sender, EventArgs e)
        {
            loadAllPhieuDieuChinh();
            loadSanPham();
        }

        private void loadAllPhieuDieuChinh()
        {
            DataSet ds = new DataAccess().getAllPhieuDieuChinhTonKho();
            if (ds == null || ds.Tables[0].Rows.Count<0)
            {
                return;
            }
            gcDieuChinhTonKho.DataSource = ds.Tables[0];
        }

        private void loadSanPham()
        {
            cboSanPham.Properties.Items.Clear();
            DataSet ds = new DataAccess().getAllSanPham();
            if (ds == null || ds.Tables[0].Rows.Count<0)
            {
                return;
            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboSanPham.Properties.Items.Add(ds.Tables[0].Rows[i]["TenSanPham"].ToString());
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboSanPham.SelectedText))
                {
                    MessageBox.Show("Chọn sản phẩm để điều chỉnh tồn kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataSet ds = new DataAccess().getIDSanPhamByTenSP(cboSanPham.SelectedText);
                if (ds == null || ds.Tables[0].Rows.Count < 0 || string.IsNullOrEmpty(ds.Tables[0].Rows[0][0].ToString()))
                {
                    // bi loi...
                }
                PhieuDieuChinhTonKho obj = new PhieuDieuChinhTonKho();
                obj.IDSanpham = Convert.ToInt32(ds.Tables[0].Rows[0]["IDSanPham"]);
                obj.SoluongDC = Convert.ToInt32(txtSoLuongDC.Text);
                obj.GhiChu = txtGhiChu.Text;
                new DataAccess().insertPhieuDieuChinhTonKho(obj);            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadAllPhieuDieuChinh();
        }
    }
}