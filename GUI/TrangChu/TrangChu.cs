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
using ChuanDoanHongHocDienThoai.GUI.FormKQ;
namespace ChuanDoanHongHocDienThoai.GUI
{
    public partial class TrangChu : UserControl
    {
        #region Field
        List<string> GT = new List<string>();
        List<int> kq;
        ConnectFile kn = new ConnectFile();
        public string view;
        public string path = Application.StartupPath + "\\";
        string str = string.Empty;
        string id = string.Empty;
        string moTa = string.Empty;
        public string da;
        // int dong = 0;
        #endregion Field

        #region Constructor
        public TrangChu()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnTrangChuLoad(object sender, EventArgs e)
        {
            kn.LoadToDataGridView(dgvTrieuChung, path+ "TrieuChung.txt");
        }

        private void OnBtnChonClick(object sender, EventArgs e)
        {
            try
            {
                lstMota.Items.Add(dgvTrieuChung.CurrentRow.Cells[0].Value.ToString() + ": " + dgvTrieuChung.CurrentRow.Cells[1].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn triệu chứng, xin mời chọn triệu chứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnBtnHuyClick(object sender, EventArgs e)
        {
            try
            {
                lstMota.Items.RemoveAt(lstMota.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn dữ kiện cần xóa, mời chọn dữ kiện cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnBtnChuanDoanClick(object sender, EventArgs e)
        {
            


            if (lstMota.Items.Count == 0)
            {
                MessageBox.Show("Không có thông tin dữ kiện, không thể chuẩn đoán được loại hỏng hóc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GT = new List<string>();
                Regex RE = new Regex(": ");
                for (int i = 0; i < lstMota.Items.Count; i++)
                {
                    string[] r;
                    r = RE.Split(lstMota.Items[i].ToString());
                    GT.Add(r[0]);
                }
                
                Process xl = new Process(GT, kn.DocFile(path + "MoTaKetLuan.txt"), kn.DocFile(path + "Rules.txt"));

                kq = new List<int>();
                kq.AddRange(xl.forward_reasoning());
                if (kq.Count != 0)
                {
                    string temp = "";
                    
                    for (int i = 0; i < kq.Count; i++)
                    {
                        da = kn.DocFile(path + "MoTaKetLuan.txt").Rows[kq[i]][0].ToString();
                       for(int j= 0; j < da.Length; j++)
                        {
                            if(da[j] >='0' && da[j] <= '9')
                            {
                                temp +=da[j].ToString();
                            }
                        }

                    
                    }
                    Form1 a = new Form1(temp);
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm tương ứng với lựa chọn của bạn!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                view = xl.view;
                rtbGiaiThich.Text = view;
               
            }  
        }

        #endregion Event

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
