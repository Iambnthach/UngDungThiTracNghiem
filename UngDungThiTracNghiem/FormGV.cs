using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormGV()
        {
            InitializeComponent();
        }

        private void FormGV_Load(object sender, EventArgs e)
        {

            db=new UDTTNDataContext();
            p_dangnhap.Visible = true;
            p_suadiem.Visible = false;
            tb_ms.Focus();
        }

        private void btn_dangnhap_gv_Click(object sender, EventArgs e)
        {
            var list = from s in db.SinhViens
                       from r in db.KetQuas
                       where s.MaSV == r.MaSV
                       select new
                       {
                           MaSo = s.MaSV,
                           Hoten = s.TenSV,
                           Diem=r.Diem
                       };
            dgv_sinhvien.DataSource = list;
            var giaovien = (from s in db.GiaoViens
                          where s.MaGV == tb_ms.Text
                          where s.MatKhau==tb_mk.Text
                          select s).FirstOrDefault();
        
            if (giaovien!=null)
            {
                p_suadiem.Visible=true;
                p_dangnhap.Visible=false;
            }
            else
            {
                l_submatkhau.Text = "HÃY NHẬP ĐÚNG MẬT KHẨU";
            }
        }

        private void tb_mk_TextChanged(object sender, EventArgs e)
        {
            tb_mk.PasswordChar = '*';
        }

        private void p_suadiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
