using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BKIT.Entities;
using BKIT.Model;
namespace Karaoke.MDIForms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text;
            string password = this.txtPassword.Text;
            if (username != "" && password != "")
            {
                DataAccess da = new DataAccess();
                Nhanvien result = da.getNhanvienByUsername_Password(username, password);
                if (result != null)
                {
                    Program.userLevel = (Level)(convertLoai2Level(result.Loai));
                    Program.isLogin = true;
                    Program.IDNhanvien = result.IDNhanvien;
                    Program.username = result.Username;
                    Program.password = result.Password;
                    this.Close();
                }
                else
                {
                    lblMess.Text = "Thông tin đăng nhập không hợp lệ!";
                    txtUserName.Focus();
                }
            }
            else
            {
                lblMess.Text = "Thông tin đăng nhập không hợp lệ!";
                txtUserName.Focus();
            }
        }
        private int convertLoai2Level(string loai)
        {
            switch (loai)
            {
                case "Quản lý":
                    return 1;
                case "Người dùng":
                    return 2;
                case "Khách":
                    return 3;
                default:
                    return 3;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.isLogin = false;
            Program.IDNhanvien = -1;
            Program.userLevel = Level.Guest;
            Program.username = "Guest";
            Program.password = "123";
            this.Close();            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)        
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}