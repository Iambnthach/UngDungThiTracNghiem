using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UngDungThiTracNghiem
{
    public partial class Form1 : Form
    {
        SqlServerFactory server;
        UDTTNDataContext db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SqlServerFactory();
            db = new UDTTNDataContext();
            p_xacnhanthongtin.Visible = false;
            p_thi.Visible = false;
            p_login.Visible = true;
            tb_mssv.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //btn_dangnhap.BackColor = SystemColors.GrayText;
        }

        private void btn_dangnhap_MouseEnter(object sender, EventArgs e)
        {
            btn_dangnhap.BackColor = Color.Gray;
        }

        private void btn_dangnhap_MouseLeave(object sender, EventArgs e)
        {
            btn_dangnhap.BackColor = SystemColors.Window;
        }

        private void error_tensv_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            //List<string> list = new List<string>();
            //string name = tb_tensv.Text;
            string acc = tb_mssv.Text;
            string password = tb_matkhau.Text;
            string query_sv = "Select * From SinhVien where MaSV=@StudentAcc";
            //string query_gv = "select * from teacher where Teacher_Account=@TeacherAcc";
            //string query_manage = "select * from manage where Manage_Account=@ManageAcc";
            SqlCommand cmd_sv = server.GetCommand(query_sv, new Dictionary<string, object>
            {
                {"@StudentAcc",acc }
            });
            //SqlCommand cmd_gv = server.GetCommand(query_gv, new Dictionary<string, object>
            //{
            //    {"@TeacherAcc",acc }
            //});
            //SqlCommand cmd_manage = server.GetCommand(query_manage, new Dictionary<string, object>
            //{
            //    {"@ManageAcc",acc }
            //});
            server.con.Open();
            SqlDataReader reader_sv = cmd_sv.ExecuteReader();

            //sửa lại query
            if (reader_sv.HasRows)
            {
                while (reader_sv.Read())
                {
                    string matkhau = reader_sv["MatKhau"].ToString();
                    if (matkhau == password)
                    {
                        l_submatkhau.Text = "";
                        p_login.Visible = false;
                        p_thi.Visible = false;
                        p_xacnhanthongtin.Visible = true;
                        //THONG TIN FORM XAC NHAN
                        l_hoten.Text = reader_sv["TenSV"].ToString();
                        l_mssv.Text = reader_sv["MaSV"].ToString();
                        l_gioitinh.Text = reader_sv["GioiTinh"].ToString();
                        l_ngaysinh.Text = reader_sv["NgaySinh"].ToString();
                        l_sodt.Text = reader_sv["SoDienThoai"].ToString();
                        l_gmail.Text = reader_sv["Gmail"].ToString();
                        l_diachi.Text = reader_sv["DiaChi"].ToString();
                        //list.Add(matkhau);
                        var dsmonthi = from s in db.MonHocs
                                       select new
                                       {
                                           Ten = s.TenMH,
                                           Ma = s.MaMH,
                                       };
                        cbb_monthi.DataSource = dsmonthi;
                        cbb_monthi.DisplayMember = "Ten";
                        cbb_monthi.ValueMember = "Ma";
                    }

                }
            }
            //else
            //{
            //    //reader_sv.Close();
            //    SqlDataReader reader_gv = cmd_gv.ExecuteReader();
            //    if (reader_gv.HasRows)
            //    {

            //        while (reader_gv.Read())
            //        {
            //            string matkhau = reader_sv["Teacher_Password"].ToString();
            //            list.Add(matkhau);
            //        }
            //    }
            //    else
            //    {
            //        //reader_gv.Close();
            //        SqlDataReader reader_mana = cmd_manage.ExecuteReader();
            //        if (reader_mana.HasRows)
            //        {
            //            while (reader_mana.Read())
            //            {
            //                string matkhau = reader_sv["Manage_Password"].ToString();
            //                list.Add(matkhau);
            //            }

            //        }
            else l_submatkhau.Text = "Tài khoản hoặc mật khẩu chưa đúng";
            //    }

            //}


            server.con.Close();
            //foreach (var item in list)
            //{

            //    if (item == tb_matkhau.Text)
            //    {
            //        p_login.Visible = false;
            //        p_xacnhanthongtin.Visible = true;
            //    }
            //}


        }

        private void tb_matkhau_TextChanged(object sender, EventArgs e)
        {
            tb_matkhau.PasswordChar = '*';
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            p_xacnhanthongtin.Visible = false;
            p_login.Visible = true;
            l_submonthi.Text = string.Empty;
            cbb_monthi.Text = string.Empty;
        }

        private void p_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dangnhap_MouseClick(object sender, MouseEventArgs e)
        {
            btn_dangnhap.BackColor = SystemColors.GrayText;
        }

        private void btn_back_MouseClick(object sender, MouseEventArgs e)
        {
            btn_back.BackColor = SystemColors.GrayText;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.BackColor = SystemColors.Window;
        }

        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.Gray;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void p_xacnhanthongtin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_xacnhan_MouseLeave(object sender, EventArgs e)
        {
            btn_xacnhan.BackColor = SystemColors.Window;
        }

        private void btn_xacnhan_MouseClick(object sender, MouseEventArgs e)
        {
            btn_xacnhan.BackColor = Color.Gray;
        }

        private void btn_xacnhan_DragLeave(object sender, EventArgs e)
        {

        }

        private void btn_xacnhan_MouseEnter(object sender, EventArgs e)
        {
            btn_xacnhan.BackColor = SystemColors.GrayText;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {

            if (cbb_monthi.SelectedIndex < 0)
            {
                l_submonthi.Text = "HÃY CHỌN MÔN THI";
                l_submonthi.ForeColor = Color.Red;

            }
            else
            {

                p_login.Visible = false;
                p_xacnhanthongtin.Visible = false;
                p_thi.Visible = true;

                t_clock.Start();



                //string query = "Select*from ChiTietCauHoiDe,CauHoi where ChiTietCauHoiDe.MaCauHoi=CauHoi.MaCauHoi ";
                //SqlCommand cmd = server.GetCommand(query,
                //    new Dictionary<string, object>
                //    {

                //    });
                //server.con.Open();



                //server.con.Close();
                var num = cbb_monthi.SelectedValue.ToString();


                var danhsach = (from s in db.ChiTietCauHoiDes
                                from r in db.CauHois
                                from x in db.Des
                                where s.MaCauHoi == r.MaCauHoi
                                where s.MaDe == x.MaDe
                                where x.MaMH == num
                                select r);
                var cauhoidautien = danhsach.First();
                l_cauhoi.Text = cauhoidautien.NoiDungCauHoi;
                rb_1.Text = cauhoidautien.CauTrl1;
                rb_2.Text = cauhoidautien.CauTrl2;
                rb_3.Text = cauhoidautien.CauTrl3;
                rb_4.Text = cauhoidautien.CauTrl4;
                if (num == "MH001")
                {
                    l_title.Text = "He Quan Tri Co So Du Lieu";
                }
                else
                {
                    l_title.Text = "Tai Chinh Ke Toan";
                }
                btn_cautruocdo.Visible = false;
                p_button.BorderStyle = BorderStyle.FixedSingle;
                var ylocation = 0;
                var y2location = 0;
                for (int i = 0; i < danhsach.Count() - 1; i++)
                {
                    Button btn;
                    if (i > danhsach.Count() / 2)
                    {
                        btn = new Button();
                        btn.Text = "Câu " + (i + 1).ToString();
                        btn.Name = "btn_cau" + (i + 1).ToString();
                        btn.Location = new Point(75, y2location);
                        p_button.Controls.Add(btn);
                        y2location += 28;
                    }
                    else
                    {
                        btn = new Button();
                        btn.Text = "Câu " + (i + 1).ToString();
                        btn.Name = "btn_cau" + (i + 1).ToString();
                        btn.Location = new Point(0, ylocation);
                        p_button.Controls.Add(btn);
                        ylocation += 28;
                    }

                }
            }
        }

        private void p_thi_Paint(object sender, PaintEventArgs e)
        {


        }

        private void l_clock_Click(object sender, EventArgs e)
        {
            TimeSpan time = new TimeSpan(0, 40, 0);
            l_clock.Text = time.ToString();

        }
        int i;
        private void btn_cautieptheo_Click(object sender, EventArgs e)
        {
            //var list = from s in db.CauHois
            //           select s;
            //string macauhoi;
            //if (cbb_monthi.SelectedValue.ToString() == "MH001")
            //{
            //    macauhoi = "CH1";
            //}
            //else
            //{
            //    macauhoi = "CH";
            //}
            //server = new SqlServerFactory();
            //string str = "select * from CauHoi where MaCauHoi=@MaCauHoi";
            //SqlCommand cmd = server.GetCommand(str,
            //    new Dictionary<string, object>
            //    {
            //        {"@MaCauHoi",macauhoi+ i.ToString()}
            //    }
            //);
            //server.con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        l_cau.Text = "Câu " + i.ToString();
            //        l_cauhoi.Text = reader["NoiDungCauHoi"].ToString();
            //        rb_1.Text = reader["CauTrl1"].ToString();
            //        rb_2.Text = reader["CauTrl2"].ToString();
            //        rb_3.Text = reader["CauTrl3"].ToString();
            //        rb_4.Text = reader["CauTrl4"].ToString();
            //    }
            //}
            //server.con.Close();
            //if (i == list.Count() - 1)
            //{
            //    btn_cautieptheo.Visible = false;
            //}
            //i++;
            //btn_cautruocdo.Visible = true;
        }

        private void l_cauhoi_Click(object sender, EventArgs e)
        {

        }

        private void btn_cautruocdo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_cautruocdo_Click(object sender, EventArgs e)
        {
            //string noidungcauhoi = l_cauhoi.Text;
            //string macauhoi = "";
            //string query = "select * from CauHoi where NoiDungCauHoi=@NoiDungCauHoi";
            //SqlCommand cmd = server.GetCommand(query, new Dictionary<string, object>
            //{
            //    {"@NoiDungCauHoi",noidungcauhoi}
            //});
            //server.con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        macauhoi = reader["MaCauHoi"].ToString();
            //    }
            //}
            //string macauhoimoi = macauhoi.Substring(0, 2);
            //string socauhoi = macauhoi.Substring(2, macauhoi.Length - 2);
            //if (int.Parse(socauhoi) == 0)
            //{
            //    btn_cautruocdo.Visible = false;
            //}
            //else
            //{
            //    string query2 = "Select * from CauHoi where MaCauHoi=@MaCauHoi";

            //    SqlCommand cmd2 = server.GetCommand(query2, new Dictionary<string, object>
            //    {
            //        {"@MaCauHoi", macauhoimoi+ (int.Parse(socauhoi)-1).ToString()}
            //    });
            //    reader.Close();
            //    SqlDataReader reader2 = cmd2.ExecuteReader();
            //    if (reader2.HasRows)
            //    {
            //        while (reader2.Read())
            //        {
            //            l_cau.Text = "Câu " + (int.Parse(socauhoi)-1).ToString();
            //            l_cauhoi.Text = reader2["NoiDungCauHoi"].ToString();
            //            rb_1.Text = reader2["CauTrl1"].ToString();
            //            rb_2.Text = reader2["CauTrl2"].ToString();
            //            rb_3.Text = reader2["CauTrl3"].ToString();
            //            rb_4.Text = reader2["CauTrl4"].ToString();
            //        }
            //    }
            //}
            //server.con.Close();

        }


    }
}
