using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using ChuanDoanHongHocDienThoai.Common;

namespace ChuanDoanHongHocDienThoai.GUI
{
    public partial class KetLuan : UserControl
    {
        #region Field
        public string path = Application.StartupPath + "\\";
        private ConnectFile kn = new ConnectFile();
        private Event ev = new Event();
        bool _luu = true;
        private Event[] E = new Event[200];
        public int count_node = 0;
        #endregion Field

        #region Constructor
        public KetLuan()
        {
            InitializeComponent();

        }
        #endregion Constructor

        #region Event
        private void OnSuKienLoad(object sender, EventArgs e)
        {
        
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
           // kn.LoadToDataGridView(dgvKetLuan, path + "TrieuChung.txt");
            kn.LoadToDataGridView(dgvKetLuan, path + "MoTaKetLuan.txt");
            LoadSuKien();
        }
        /// <summary>
        /// Xử lý sự kiện btnThem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnThemClick(object sender, EventArgs e)
        {
            _luu = true;
            txtID.Focus();
            txtID.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtID.Enabled = true;
            txtMoTa.Enabled = true;
        }

        /// <summary>
        /// sử lý sự kiện btnSua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnSuaClick(object sender, EventArgs e)
        {
            _luu = false;
            txtMoTa.Focus();
            txtID.Enabled = false;
            txtMoTa.Enabled = true;
        }

        /// <summary>
        /// hàm xử lý sự kiện Luu dữ liệu vào file TrieuChung.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnLuuClick(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty || txtMoTa.Text == string.Empty)
            {
                MessageBox.Show("Không có thông tin để lưu trữ, mời nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (_luu)
                {
                    GhiFile();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnSuKienLoad(sender, e);
                    txtID.Text = string.Empty;
                    txtMoTa.Text = string.Empty;
                    txtID.Enabled = false;
                    txtMoTa.Enabled = false;
                }
                else
                {
                    SuaFile();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnSuKienLoad(sender, e);
                    txtID.Text = string.Empty;
                    txtMoTa.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// hàm sử lý sự kiện CellClick của dgvTrieuChung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDgvTrieuChungCellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvKetLuan.CurrentRow.Cells[0].Value.ToString();
            txtMoTa.Text = dgvKetLuan.CurrentRow.Cells[1].Value.ToString();
        }

        /// <summary>
        /// hàm xử lứ sự kiện xóa sự kiện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                XoaSK();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnSuKienLoad(sender, e);
                txtID.Text = string.Empty;
                txtMoTa.Text = string.Empty;
            }
        }
        #endregion Event

        #region Method
        /// <summary>
        /// hàm thực hiện ghi dữ liệu vào file TrieuChung.txt
        /// </summary>
        public void GhiFile()
        {
            FileStream fs = new FileStream(path + "MoTaKetLuan.txt", FileMode.Append, FileAccess.Write);
            StreamWriter stw = new StreamWriter(fs, Encoding.UTF8);
            stw.WriteLine(txtID.Text.Trim() + ": " + txtMoTa.Text.Trim());
            stw.Flush();
            stw.Close();
            fs.Close();
        }

        /// <summary>
        /// hàm thực hiện sửa dữ liệu trong file TrieuChung.txt
        /// </summary>
        public void SuaFile()
        {
            StreamReader sr = File.OpenText("MoTaKetLuan.txt");
            string[] tam = new string[count_node];
            ev._suKien = txtID.Text;
            ev._nguNghia = txtMoTa.Text;
            for (int i = 0; i < count_node; i++)
            {
                if (E[i]._suKien == ev._suKien)
                {
                    E[i] = ev;
                    tam[i] = txtID.Text.Trim() + ": " + txtMoTa.Text.Trim();
                    sr.ReadLine();
                }
                else
                    tam[i] = sr.ReadLine();
            }
            sr.Close();
            FileStream outtream = new FileStream("MoTaKetLuan.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(outtream, Encoding.UTF8);
            for (int i = 0; i < count_node; i++)
            {
                sw.WriteLine(tam[i]);
            }
            sw.Close();
        }

        /// <summary>
        /// hàm thực hiện xóa sự kiện trong file TrieuChung.txt
        /// </summary>
        public void XoaSK()
        {
            StreamReader sr = File.OpenText("MoTaKetLuan.txt");
            string[] tam = new string[count_node];
            Event Ev = new Event();
            Ev._suKien = txtID.Text;
            Ev._nguNghia = txtMoTa.Text;
            for (int i = 0; i < count_node; i++)
            {
                if (E[i]._suKien == Ev._suKien)
                {
                    DeleteSK(i);
                    i--;
                }
                else
                {
                    tam[i] = sr.ReadLine();
                }
            }
            sr.Close();
            FileStream fs = new FileStream("MoTaKetLuan.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            for (int i = 0; i < count_node; i++)
            {
                sw.WriteLine(tam[i]);

            }
            sw.Close();
            txtID.Clear();
            txtMoTa.Clear();
        }
        /// <summary>
        /// hàm thực hiện việc xóa dữ liệu i được lựa chọn
        /// </summary>
        /// <param name="i"></param>
        public void DeleteSK(int i)
        {
            for (int j = i; j < count_node - 1; j++)
                E[j] = E[j + 1];
            count_node--;
        }

        private int Count_SuKien()
        {
            int i = 0;
            StreamReader sr = File.OpenText("MoTaKetLuan.txt");
            while (sr.ReadLine() != null)
                i++;
            sr.Close();
            return i;
        }

        private Event Tach_SuKien(string input)
        {
            Event E = new Event();
            int length = input.Length;
            int i = 0;
            while (i < length)
            {
                while (input[i] != ':' && i < length)
                {
                    E._suKien += input[i];
                    i++;
                }
                i++;
                while (i < length)
                {
                    E._nguNghia += input[i];
                    i++;
                }
            }
            return E;
        }
        private void LoadSuKien()
        {
            count_node = Count_SuKien();
            StreamReader sr = File.OpenText("MoTaKetLuan.txt");
            string tg = "";
            for (int i = 0; i < count_node; i++)
            {
                tg = sr.ReadLine();
                E[i] = Tach_SuKien(tg);
            }
            sr.Close();
        }
        #endregion Method

    }
}
