using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungThiTracNghiem
{
    public partial class FormGV : Form
    {
        UDTTNDataContext db;
        SqlServerFactory server;
        public FormGV()
        {
            InitializeComponent();
        }
        private void btn_dangnhap_gv_Click(object sender, EventArgs e)
        {
            db = new UDTTNDataContext();
            var listgiaovien = (from s in db.GiaoViens
                            where s.MaGV == tb_ms.Text
                            where s.MatKhau == tb_mk.Text
                            select s);
            var giaovien=listgiaovien.FirstOrDefault();

            if (giaovien != null)
            {
                p_suadiem.Visible = true;
                p_dangnhap.Visible = false;
                txt_MaGV.Text = giaovien.MaGV;
                txt_TenGV.Text = giaovien.TenGV;
                txt_NgaySinh.Text = giaovien.NgaySinh.ToString();
                txt_GioiTInh.Text = giaovien.GioiTinh;
                txt_MaLopGacThi.Text = giaovien.MaLop;
            }
            else
            {
                l_submatkhau.Text = "HÃY NHẬP ĐÚNG MẬT KHẨU";
            }

            server = new SqlServerFactory();

            string acc = tb_ms.Text;
            string password = tb_mk.Text;
            string query_sv = "Select MaSV, TenSV, GioiTInh, MaLop from SinhVien";

            
            SqlCommand cmd_sv = server.GetCommand(query_sv, new Dictionary<string, object>
            {
            });

            server.con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query_sv,server.con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_sinhvien.DataSource = dataTable;


        }
        private void FormGV_Load(object sender, EventArgs e)
        {
            p_dangnhap.Visible = true;
            p_suadiem.Visible=false;
            tb_ms.Focus();
        }

        

        private void tb_mk_TextChanged(object sender, EventArgs e)
        {
            tb_mk.PasswordChar = '*';
        }

        private void msgv_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_suadiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_dangnhap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
