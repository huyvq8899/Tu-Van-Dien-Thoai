using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ChuanDoanHongHocDienThoai.GUI;
namespace ChuanDoanHongHocDienThoai.GUI.FormKQ
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public static string dapso= string.Empty;
        public Form1(string dapan)
        {
            InitializeComponent();
            dapso = dapan;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            int i;
            string chuoiketnoi = @"Server=117.7.227.159;Database=HUY_UATKiemThu999_78Invoice;User Id=sa;Password=BachKhoa@2022;MultipleActiveResultSets=true";
            con = new SqlConnection(chuoiketnoi);
            con.Open();
            string Str = "select * from DienThoai where ID = "+ dapso;
            SqlDataAdapter sda = new SqlDataAdapter(Str, con);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
            dataGridView1.DataSource = tbl;
            i = dataGridView1.CurrentRow.Index;
                Bitmap bm = new Bitmap(Application.StartupPath + "\\anh\\" + dataGridView1.Rows[i].Cells[0].Value.ToString() + ".png");
            pictureBox1.Image = bm;
               
            label1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString(); // TenDienThoai  1
            label2.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();  // DongSanPham  3
            label4.Text = dataGridView1.Rows[i].Cells[2].Value.ToString(); 
            label6.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            label8.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            label10.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            label12.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            label14.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Không lấy đc dữ liệu");
                con.Close();
            }
            


            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
