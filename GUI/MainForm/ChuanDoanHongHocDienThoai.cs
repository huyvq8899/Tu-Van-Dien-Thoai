using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuanDoanHongHocDienThoai.GUI;

namespace ChuanDoanHongHocDienThoai
{
    public partial class _frmChuanDoanHongHocDienThoai : Form
    {
        #region Field
        private bool _isMousePress=false;
        private Point _lastPoint;
        public static string _quyen = string.Empty;
        #endregion Field

        #region Constructor
        public _frmChuanDoanHongHocDienThoai()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnLblCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnFrmChuanDoanBenhTimLoad(object sender, EventArgs e)
        {
            _pnlRight.Controls.Clear();
            TrangChu trangChu = new TrangChu();
            _pnlRight.Controls.Add(trangChu);
            trangChu.Show();

            lblInformation.Text = @"Chức năng: Tư vấn mua điện thoại";
            
        }
        private void OnBtnChuanDoanClick(object sender, EventArgs e)
        {
            OnFrmChuanDoanBenhTimLoad(sender, e);
        }

        private void OnBtnDangNhapLick(object sender, EventArgs e)
        {
            _pnlRight.Controls.Clear();
            DangNhap dangNhap = new DangNhap();
            _pnlRight.Controls.Add(dangNhap);
            dangNhap.Show();

            lblInformation.Text = @"Chức năng: Đăng nhập hệ thống";
        }
        private void OnQuanLySuKienClick(object sender, EventArgs e)
        {
            _pnlRight.Controls.Clear();
            SuKien suKien = new SuKien();
            _pnlRight.Controls.Add(suKien);
            suKien.Show();

            lblInformation.Text = @"Chức năng: Quản lý sự kiện";
        }
        private void OnQuanLyKetLuanClick(object sender, EventArgs e)
        {
            _pnlRight.Controls.Clear();
            KetLuan ketLuan = new KetLuan();
            _pnlRight.Controls.Add(ketLuan);
            ketLuan.Show();

            lblInformation.Text = @"Chức năng: Quản lý kết luận";
        }

        private void OnQuanLyTapLuatClick(object sender, EventArgs e)
        {
            _pnlRight.Controls.Clear();
            Luat luat = new Luat();
            _pnlRight.Controls.Add(luat);
            luat.Show();

            lblInformation.Text = @"Chức năng: Quản lý tập luật";
        }

        private void OnBtnGioiThieuClick(object sender, EventArgs e)
        {
            _pnlRight.Controls.Clear();
            GioiThieu gioiThieu = new GioiThieu();
            _pnlRight.Controls.Add(gioiThieu);
            gioiThieu.Show();

            lblInformation.Text = @"Chức năng: Giới thiệu chương trình";
        }
        private void OnLblCloseMouseMove(object sender, MouseEventArgs e)
        {
            _lblClose.BackColor = Color.Firebrick;
        }

        private void OnLblCloseMouseLeave(object sender, EventArgs e)
        {
            _lblClose.BackColor = Color.WhiteSmoke;
        }

        private void OnLblMinMaxMouseMove(object sender, MouseEventArgs e)
        {
            _lblMiniMax.BackColor = Color.White;
        }

        private void OnLblMinMaxMouseLeave(object sender, EventArgs e)
        {
             _lblMiniMax.BackColor = Color.WhiteSmoke;
        }

        private void OnBtnChuanDoanMouseMove(object sender, MouseEventArgs e)
        {
            _btnChuanDoan.BackgroundImage = Properties.Resources.background;
        }

        private void OnBtnChuanDoanMouseLeave(object sender, EventArgs e)
        {
            _btnChuanDoan.BackgroundImage = Properties.Resources.background_top;
        }
        private void OnBtnDangNhapMouseMove(object sender, MouseEventArgs e)
        {
            _pnlRight.BackgroundImage = Properties.Resources.background;
        }

        private void OnBtnDangNhapMouseLeave(object sender, EventArgs e)
        {
            _pnlRight.BackgroundImage = Properties.Resources.background_top;
        }

        private void OnBtnQuanLySuKienMouseMove(object sender, MouseEventArgs e)
        {
            _btnQuanLySuKien.BackgroundImage = Properties.Resources.background;
        }

        private void OnBtnQuanLySuKienMouseLeave(object sender, EventArgs e)
        {
            _btnQuanLySuKien.BackgroundImage = Properties.Resources.background_top;
        }

        private void OnBtnQuanLyTapLuatMouseMove(object sender, MouseEventArgs e)
        {
            _btnQuanLyTapLuat.BackgroundImage = Properties.Resources.background;
        }

        private void OnBtnQuanLyTapLuatMouseLeave(object sender, EventArgs e)
        {
            _btnQuanLyTapLuat.BackgroundImage = Properties.Resources.background_top;
        }

        private void OnBtnGioiThieuMouseMove(object sender, MouseEventArgs e)
        {
            _btnGioiThieu.BackgroundImage = Properties.Resources.background;
        }

        private void OnBtnGioiThieuMouseLeave(object sender, EventArgs e)
        {
            _btnGioiThieu.BackgroundImage = Properties.Resources.background_top;
        }

        private void OnLblMiniMaxClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnPnlTopMouseMove(object sender, MouseEventArgs e)
        {
            if (_isMousePress)
            {
                Point currenPoint = e.Location;
                Point mainLocation = this.Location;
                int scaleX = currenPoint.X - _lastPoint.X;
                int scaleY = currenPoint.Y - _lastPoint.Y;
                this.Location = new Point(mainLocation.X + scaleX, mainLocation.Y + scaleY);
            }
        }

        private void OnPnlTopMouseUp(object sender, MouseEventArgs e)
        {
            _isMousePress = false;
        }
        private void OnPnlTopMouseDown(object sender, MouseEventArgs e)
        {
            _isMousePress = true;
            _lastPoint = e.Location;
        }
        #endregion Event

        private void _pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
