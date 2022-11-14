using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanDoanHongHocDienThoai.GUI
{
    public partial class DangNhap : UserControl
    {
        #region Constructor
        public DangNhap()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnBtnDangNhapClick(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "admin")
            {
                _frmChuanDoanHongHocDienThoai._quyen = txtTenDangNhap.Text.Trim();
                MessageBox.Show("Đăng nhập thành công, mời thực hiện các chức năng của mình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập, mời đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap.Focus();
            }
        }
        #endregion Event
    }
}
