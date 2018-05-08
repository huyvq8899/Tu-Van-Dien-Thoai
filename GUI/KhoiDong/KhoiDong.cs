using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanDoanHongHocDienThoai.GUI
{
    public partial class KhoiDong : Form
    {
        #region Constructor
        public KhoiDong()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void KhoiDong_Load(object sender, EventArgs e)
        {
            timeProgress.Enabled = true;
        }
        private void timeProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                timeProgress.Stop();

                this.Hide();
                _frmChuanDoanHongHocDienThoai chuanDoanHongHocDienThoai = new _frmChuanDoanHongHocDienThoai();
                chuanDoanHongHocDienThoai.Show();
            }

            else
            {
                progressBar.Value += 1;
            }
        }
        #endregion Event
    }
}
