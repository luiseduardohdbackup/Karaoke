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
    public partial class frmAddUser : DevExpress.XtraEditors.XtraForm
    {
        public static Nhanvien AddedUser;

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Nhanvien emp = new Nhanvien();
            Nhanvien existEmp;
            DataAccess da = new DataAccess();
            string s;
            try
            {
                //Name
                s = txtName.Text;
                if (s == "")
                {
                    lblStatusBar.Text = "Nhập họ và tên!";
                    txtName.Focus();
                    return;
                }
                lblStatusBar.Text = "";
                emp.Ten = s;

                // Sex
                s = cboSex.Text;
                if (s == "")
                {
                    lblStatusBar.Text = "Nhập giới tính!";
                    cboSex.Focus();
                    return;
                }
                lblStatusBar.Text = "";
                emp.Gioitinh = s;
                
                // Chức vụ -optional
                emp.Chucvu = txtPosition.Text;
                
                // Dia chi
                s = txtAddress.Text;
                if (s == "")
                {
                    lblStatusBar.Text = "Nhập Địa chỉ!";
                    txtAddress.Focus();
                    return;
                }
                lblStatusBar.Text = "";
                emp.Diachi = s;
                
                //Phone -optional
                s = txtPhone.Text;
                if (s != "")
                {
                    try
                    {
                        Int32.Parse(s);
                    }
                    catch
                    {
                        lblStatusBar.Text = "Số điện thoại không hợp lệ!!!";
                        txtPhone.Focus();
                        return;
                    }
                }
                lblStatusBar.Text = "";
                emp.SoDT = s;
                
                //BirthDate
                if (cboBirthDay.Text == null || cboBirthMonth.Text == null || txtBirthYear == null)
                {
                    lblStatusBar.Text = "Nhập Ngày sinh";
                    cboBirthDay.Focus();
                    return;
                }
                lblStatusBar.Text = "";
                //s = cboBirthDay.Text + "-" + cboBirthMonth.Text + "-" + txtBirthYear.Text;
                int bYear = Convert.ToInt16(txtBirthYear.Text);
                int bMonth = cboBirthMonth.SelectedIndex + 1;
                int bDay = cboBirthDay.SelectedIndex + 1;
                try
                {
                    //emp.Ngaysinh = Convert.ToDateTime(s);
                    emp.Ngaysinh = new DateTime(bYear, bMonth, bDay);
                }
                catch
                {
                    lblStatusBar.Text = "Thông tin Ngày sinh không đúng";
                    cboBirthDay.Focus();
                    return;
                }
                lblStatusBar.Text = "";
                
                //IDUserGroup
                //s = cboUserGroupName.EditValue.ToString();
                s = cboUserGroupName.Text;
                if (s == "")
                {
                    lblStatusBar.Text = "Chọn nhóm người dùng";
                    cboUserGroupName.Focus();
                    return;
                }
                lblStatusBar.Text = "";
                emp.Loai = s;
                
                //Username
                s = txtUsername.Text;
                if (s == "")
                {
                    lblStatusBar.Text = "Nhập Tên đăng nhập";
                    txtUsername.Focus();
                    return;
                }
                lblStatusBar.Text = "";
                existEmp = da.getNhanvienbyUserName(s);
                if (existEmp != null)
                {
                    lblStatusBar.Text = "Tên đăng nhập đã tồn tại!";
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                    return;
                }
                lblStatusBar.Text = "";
                emp.Username = s;
                
                //public string Password;
                s = txtPassword.Text;
                if (s == "")
                {
                    lblStatusBar.Text = "Nhập Mật khẩu";
                    txtPassword.Focus();
                    return;
                }
                lblStatusBar.Text = "";
                emp.Password = s;
                s = txtPasswordRetype.Text;
                if (!string.Equals(emp.Password, s))
                {
                    lblStatusBar.Text = "Mật khẩu nhập lại không khớp";
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return;
                }
                lblStatusBar.Text = "";
                
                // PasswordHinh
                //emp.PasswordHint = txtPasswordHint.Text;
                
                // Avatar
                //Image imageAvatar = pictureAvatar.Image;
                //emp.Avatar = frmUserManager.StrFromImage(imageAvatar);
                
                /////////////
                if (da.insertNhanvien(emp) != -1)
                {
                    AddedUser = emp;
                    QuyenTruycap permission = frmEmployeeManager.getDefaultPermissionByGroupname(cboUserGroupName.Text);
                    emp.IDQuyenTruycap = da.insertQuyenTruycap(permission);
                    da.updateNhanvien(emp);
                    //this.Visible = false;
                    MessageBox.Show("Tạo thành công tài khoản: " + emp.Username,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                lblStatusBar.Text = ex.Message;
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            try
            {
                DataSet ds = da.getAllLoaiNhanvien();
                string UserGroupName;
                
                int intRowsCount = ds.Tables[0].Rows.Count;
                for (int i = 0; i < intRowsCount; i++)
                {
                    UserGroupName = Convert.ToString(ds.Tables[0].Rows[i]["TenLoaiNV"]);
                    cboUserGroupName.Properties.Items.Add(UserGroupName);
                }
            }
            catch (Exception ex)
            {
                lblStatusBar.Text = ex.Message;
            }
            lblStatusBar.Text = "";
        }
    }
}