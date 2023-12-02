using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UngDungThiTracNghiem
{
    public partial class FormSV : Form
    {
        SqlServerFactory server;
        UDTTNDataContext db;
        private List<CauHoi> list;
        private int currentQuestionIndex = 0;
        int diem = 0;
        private List<Button> buttons;
        private int selectedAnswerIndex = -1;
        private bool isAnswerSelected = false;
        private List<string> danhsachcautrl;

        string masosv;
        public FormSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = getListQuestion();
            danhsachcautrl = new List<string>();
            server = new SqlServerFactory();
            db = new UDTTNDataContext();
            p_xacnhanthongtin.Visible = false;
            p_thi.Visible = false;
            p_login.Visible = true;
            tb_mssv.Focus();
            var listcd = from s in db.MonHocs
                         select new
                         {
                             MaMH = s.MaMH,
                             TenMH = s.TenMH,
                         };
            cbb_monthi.DataSource = listcd;
            cbb_monthi.DisplayMember = "TenMH";
            cbb_monthi.ValueMember = "MaMH";


        }

        private EventHandler Btn_cauhoi_click(int index)
        {
            return (sender, e) => ShowAction(index);
        }

        private void ShowAction(int index)
        {
            List<CauHoi> list = getListQuestion();
            isAnswerSelected = false;
            selectedAnswerIndex = -1;
            l_cau.Text = "Cau " + (index + 1).ToString();
            l_cauhoi.Text = list[index].NoiDungCauHoi;
            rb_1.Text = list[index].CauTrl1;
            rb_2.Text = list[index].CauTrl2;
            rb_3.Text = list[index].CauTrl3;
            rb_4.Text = list[index].CauTrl4;
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
                        masosv = tb_mssv.Text;
                    }
                }
            }
            else l_submatkhau.Text = "Tài khoản hoặc mật khẩu chưa đúng";
            server.con.Close();
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
                if (cbb_monthi != null && cbb_monthi.SelectedValue != null)
                {

                    var num = cbb_monthi.SelectedValue.ToString();
                    p_login.Visible = false;
                    p_xacnhanthongtin.Visible = false;
                    p_thi.Visible = true;
                    t_clock.Start();
                    if (num == "MH001")
                    {
                        l_title.Text = "He Quan Tri Co So Du Lieu";
                    }
                    else
                    {
                        l_title.Text = "Tai Chinh Ke Toan";
                    }
                    btn_cautruocdo.Visible = false;

                   
                    List<CauHoi> list = getListQuestion();
                    var cauhoidautien = list.ElementAt(0);
                    l_cau.Text = "Cau 1";
                    l_cauhoi.Text = cauhoidautien.NoiDungCauHoi;
                    rb_1.Text = cauhoidautien.CauTrl1;
                    rb_2.Text = cauhoidautien.CauTrl2;
                    rb_3.Text = cauhoidautien.CauTrl3;
                    rb_4.Text = cauhoidautien.CauTrl4;

                    

                }

            }
            
        }
        public List<CauHoi> getListQuestion()
        {
            List<CauHoi> listcauhoi = new List<CauHoi>();
            if (cbb_monthi != null && cbb_monthi.SelectedValue != null)
            {

                var num = cbb_monthi.SelectedValue.ToString();
                //var ran = new Random();
                //int ran_num = ran.Next(1, 4);
                //if (ran_num == 2)
                //{
                //    ran_num = 3;
                //};
                int ran_num = 1;
                if (num == "MH002")
                {
                    ran_num = 3;
                }

                string made = "De0" + ran_num.ToString();
                string query = "SELECT Cauhoi.macauhoi, CauHoi.NoiDungCauHoi , CauHoi.CauTrl1, CauHoi.CauTrl2 , CauHoi.CauTrl3,CauHoi.CauTrl4,CauTrlDung, Diem FROM ChiTietCauHoiDe JOIN CauHoi ON ChiTietCauHoiDe.MaCauHoi = CauHoi.MaCauHoi JOIN De ON ChiTietCauHoiDe.MaDe = De.MaDe JOIN MonHoc ON De.MaMH = MonHoc.MaMH WHERE MonHoc.MaMH =@mamh AND De.MaDe = @made";
                SqlCommand cmd = server.GetCommand(query,
                    new Dictionary<string, object>
                    {
                        {"@mamh", num},
                    {"@made",made }
                    });
                server.con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CauHoi c = new CauHoi();
                        c.NoiDungCauHoi = reader["NoiDungCauHoi"].ToString();
                        c.MaCauHoi = reader["MaCauHoi"].ToString();
                        c.CauTrl1 = reader["CauTrl1"].ToString();
                        c.CauTrl2 = reader["CauTrl2"].ToString();
                        c.CauTrl3 = reader["CauTrl3"].ToString();
                        c.CauTrl4 = reader["CauTrl4"].ToString();
                        c.CauTrlDung = reader["CauTrlDung"].ToString();
                        c.Diem = int.Parse(reader["Diem"].ToString());
                        listcauhoi.Add(c);
                    }
                }
                server.con.Close();
            }
            return listcauhoi;
        }

        private void p_thi_Paint(object sender, PaintEventArgs e)
        {


        }

        private void l_clock_Click(object sender, EventArgs e)
        {
            

        }
        List<string> danhsachvitricautrl=new List<string>();
        private void btn_cautieptheo_Click(object sender, EventArgs e)
        {
            List<CauHoi> list = getListQuestion();
            if (!rb_1.Checked && !rb_2.Checked && !rb_3.Checked && !rb_4.Checked)
            {
                l_subcauhoi.Text = "Hãy chọn đáp án";
                l_subcauhoi.ForeColor = Color.Red;
            }
            else
            {
                rb_1.Checked=false;
                rb_2.Checked=false;
                rb_3.Checked=false;
                rb_4.Checked=false;
                l_subcauhoi.Visible = false;
                if (currentQuestionIndex < list.Count - 1)
                {
                    currentQuestionIndex++;
                    ShowAction(currentQuestionIndex);
                    btn_cautruocdo.Visible = true;
                    if (currentQuestionIndex == list.Count - 1)
                    {

                        btn_cautieptheo.Visible = false;
                    }
                    else btn_cautieptheo.Visible = true;
                    if (rb_1.Checked)
                    {
                        danhsachcautrl.Add(rb_1.Text);
                        danhsachvitricautrl.Add(rb_1.Text);
                    }
                    else if (rb_2.Checked)
                    {
                        danhsachcautrl.Add(rb_2.Text);
                        danhsachvitricautrl.Add(rb_2.Text);

                    }
                    else if (rb_3.Checked)
                    {
                        danhsachcautrl.Add(rb_3.Text);
                        danhsachvitricautrl.Add(rb_3.Text);

                    }
                    else
                    {
                        danhsachcautrl.Add(rb_4.Text);
                        danhsachvitricautrl.Add(rb_4.Text);

                    }

                }
            }
        }





        private void l_cauhoi_Click(object sender, EventArgs e)
        {

        }

        private void btn_cautruocdo_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void btn_cautruocdo_Click(object sender, EventArgs e)
        {
            list = getListQuestion();
            if (currentQuestionIndex > 0)
            {
                btn_cautieptheo.Visible = true;
                btn_cautruocdo.Visible = true;
                currentQuestionIndex--;



                l_cau.Text = "Cau " + (currentQuestionIndex + 1).ToString();
                l_cauhoi.Text = list[currentQuestionIndex].NoiDungCauHoi.ToString();
                rb_1.Text = list[currentQuestionIndex].CauTrl1.ToString();
                rb_2.Text = list[currentQuestionIndex].CauTrl2.ToString();
                rb_3.Text = list[currentQuestionIndex].CauTrl3.ToString();
                rb_4.Text = list[currentQuestionIndex].CauTrl4.ToString();
                if (rb_1.Text.CompareTo(danhsachvitricautrl[currentQuestionIndex]) == 0)
                {
                    rb_1.Checked = true;
                }else if (rb_2.Text.CompareTo(danhsachvitricautrl[currentQuestionIndex]) == 0)
                {
                    rb_2.Checked = true;

                }
                else if (rb_3.Text.CompareTo(danhsachvitricautrl[currentQuestionIndex]) == 0)
                {
                    rb_3.Checked = true;
                }else if (rb_4.Text.CompareTo(danhsachvitricautrl[currentQuestionIndex]) == 0)
                {
                    rb_4.Checked = true;
                }


            }
            else btn_cautruocdo.Visible = false;
        }




        private void btn_nopbai_Click(object sender, EventArgs e)
        {
            if (rb_1.Checked)
            {
                danhsachcautrl.Add(rb_1.Text);
            }
            else if (rb_2.Checked)
            {
                danhsachcautrl.Add(rb_2.Text);
            }
            else if (rb_3.Checked)
            {
                danhsachcautrl.Add(rb_3.Text);
            }
            else danhsachcautrl.Add(rb_4.Text);


            p_xacnhanthongtin.Visible = false;
            p_login.Visible = false;
            p_thi.Visible = false;

            var list = getListQuestion();
            double? tongdiem = 0;
            for(int i = 0; i < list.Count - 1; i++)
            {
                
                for(int j = 0; j < list.Count - 1; j++)
                {
                    if (danhsachcautrl[i].CompareTo(list[j].CauTrlDung) == 0)
                    {
                        tongdiem += list[j].Diem;
                    }
                }
            }
            MessageBox.Show("Điểm của b: " + tongdiem.ToString());
            Close();
            int soluongmakq = db.KetQuas.Count();
            KetQua a = new KetQua();
            a.MaSV = masosv;
            a.Diem = tongdiem;
            a.MaKQ = "KQ" + (soluongmakq + 1).ToString();
            db.KetQuas.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        
        private void tb_mssv_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_matkhau_TextChanged_1(object sender, EventArgs e)
        {
            tb_matkhau.PasswordChar = '*';
        }

        private void cbb_chedo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_1.Checked)
            {
                rb_1.FlatAppearance.BorderColor = Color.Green;
                isAnswerSelected = true;
                selectedAnswerIndex = 0;
            }
        }

        private void rb_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_2.Checked)
            {
                rb_2.FlatAppearance.BorderColor = Color.Green;
                isAnswerSelected = true;
                selectedAnswerIndex = 1;
            }
        }

        private void rb_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_3.Checked)
            {
                rb_3.FlatAppearance.BorderColor = Color.Green;
                isAnswerSelected = true;
                selectedAnswerIndex = 2;
            }
        }

        private void rb_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_4.Checked)
            {
                rb_4.FlatAppearance.BorderColor = Color.Green;
                isAnswerSelected = true;
                selectedAnswerIndex = 3;
            }
        }

        private void p_button_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            Close();
        }
        int totalsecond = 60 * 60;
        private void t_clock_click(object sender, EventArgs e)
        {
            l_clock.Text = "60:00";
            if(totalsecond > 0)
            {
                totalsecond--;
                int minites = totalsecond / 60;
                int second = totalsecond - (minites * 60);
                l_clock.Text=minites.ToString()+":"+second.ToString();
                l_clock.ForeColor=Color.Red;
            }
            else
            {
                this.t_clock.Stop();
                MessageBox.Show("Hết thời gian");
            }
        }
    }
}
