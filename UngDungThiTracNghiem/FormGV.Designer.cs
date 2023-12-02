namespace UngDungThiTracNghiem
{
    partial class FormGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_sinhvien = new System.Windows.Forms.DataGridView();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.txt_TenGV = new System.Windows.Forms.TextBox();
            this.p_suadiem = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_dangnhap = new System.Windows.Forms.Panel();
            this.l_submatkhau = new System.Windows.Forms.Label();
            this.btn_dangnhap_gv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_ms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GioiTInh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaLopGacThi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).BeginInit();
            this.p_suadiem.SuspendLayout();
            this.p_dangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sinhvien
            // 
            this.dgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinhvien.Location = new System.Drawing.Point(16, 237);
            this.dgv_sinhvien.Name = "dgv_sinhvien";
            this.dgv_sinhvien.RowHeadersWidth = 51;
            this.dgv_sinhvien.RowTemplate.Height = 24;
            this.dgv_sinhvien.Size = new System.Drawing.Size(907, 302);
            this.dgv_sinhvien.TabIndex = 1;
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Enabled = false;
            this.txt_MaGV.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGV.Location = new System.Drawing.Point(269, 60);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(157, 22);
            this.txt_MaGV.TabIndex = 2;
            this.txt_MaGV.TextChanged += new System.EventHandler(this.msgv_TextChanged);
            // 
            // txt_TenGV
            // 
            this.txt_TenGV.Enabled = false;
            this.txt_TenGV.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenGV.Location = new System.Drawing.Point(269, 108);
            this.txt_TenGV.Name = "txt_TenGV";
            this.txt_TenGV.Size = new System.Drawing.Size(277, 22);
            this.txt_TenGV.TabIndex = 2;
            // 
            // p_suadiem
            // 
            this.p_suadiem.Controls.Add(this.label9);
            this.p_suadiem.Controls.Add(this.label8);
            this.p_suadiem.Controls.Add(this.txt_MaLopGacThi);
            this.p_suadiem.Controls.Add(this.label7);
            this.p_suadiem.Controls.Add(this.txt_GioiTInh);
            this.p_suadiem.Controls.Add(this.label1);
            this.p_suadiem.Controls.Add(this.txt_NgaySinh);
            this.p_suadiem.Controls.Add(this.label6);
            this.p_suadiem.Controls.Add(this.label5);
            this.p_suadiem.Controls.Add(this.txt_MaGV);
            this.p_suadiem.Controls.Add(this.dgv_sinhvien);
            this.p_suadiem.Controls.Add(this.txt_TenGV);
            this.p_suadiem.Location = new System.Drawing.Point(12, 12);
            this.p_suadiem.Name = "p_suadiem";
            this.p_suadiem.Size = new System.Drawing.Size(934, 556);
            this.p_suadiem.TabIndex = 3;
            this.p_suadiem.Paint += new System.Windows.Forms.PaintEventHandler(this.p_suadiem_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên giáo viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã số giáo viên:";
            // 
            // p_dangnhap
            // 
            this.p_dangnhap.Controls.Add(this.l_submatkhau);
            this.p_dangnhap.Controls.Add(this.btn_dangnhap_gv);
            this.p_dangnhap.Controls.Add(this.label4);
            this.p_dangnhap.Controls.Add(this.label3);
            this.p_dangnhap.Controls.Add(this.label2);
            this.p_dangnhap.Controls.Add(this.tb_mk);
            this.p_dangnhap.Controls.Add(this.tb_ms);
            this.p_dangnhap.Location = new System.Drawing.Point(9, 9);
            this.p_dangnhap.Name = "p_dangnhap";
            this.p_dangnhap.Size = new System.Drawing.Size(906, 426);
            this.p_dangnhap.TabIndex = 4;
            this.p_dangnhap.Paint += new System.Windows.Forms.PaintEventHandler(this.p_dangnhap_Paint);
            // 
            // l_submatkhau
            // 
            this.l_submatkhau.AutoSize = true;
            this.l_submatkhau.Location = new System.Drawing.Point(320, 275);
            this.l_submatkhau.Name = "l_submatkhau";
            this.l_submatkhau.Size = new System.Drawing.Size(0, 16);
            this.l_submatkhau.TabIndex = 4;
            // 
            // btn_dangnhap_gv
            // 
            this.btn_dangnhap_gv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap_gv.Location = new System.Drawing.Point(275, 329);
            this.btn_dangnhap_gv.Name = "btn_dangnhap_gv";
            this.btn_dangnhap_gv.Size = new System.Drawing.Size(164, 55);
            this.btn_dangnhap_gv.TabIndex = 3;
            this.btn_dangnhap_gv.Text = "ĐĂNG NHẬP";
            this.btn_dangnhap_gv.UseVisualStyleBackColor = true;
            this.btn_dangnhap_gv.Click += new System.EventHandler(this.btn_dangnhap_gv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "MẬT KHẨU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "MÃ SỐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÍ SINH VIÊN";
            // 
            // tb_mk
            // 
            this.tb_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mk.Location = new System.Drawing.Point(323, 234);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(337, 38);
            this.tb_mk.TabIndex = 0;
            this.tb_mk.TextChanged += new System.EventHandler(this.tb_mk_TextChanged);
            // 
            // tb_ms
            // 
            this.tb_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ms.Location = new System.Drawing.Point(323, 148);
            this.tb_ms.Name = "tb_ms";
            this.tb_ms.Size = new System.Drawing.Size(337, 38);
            this.tb_ms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày sinh";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Enabled = false;
            this.txt_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaySinh.Location = new System.Drawing.Point(269, 167);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(157, 22);
            this.txt_NgaySinh.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giới tính:";
            // 
            // txt_GioiTInh
            // 
            this.txt_GioiTInh.Enabled = false;
            this.txt_GioiTInh.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTInh.Location = new System.Drawing.Point(746, 65);
            this.txt_GioiTInh.Name = "txt_GioiTInh";
            this.txt_GioiTInh.Size = new System.Drawing.Size(157, 22);
            this.txt_GioiTInh.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(645, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã lớp gác thi:";
            // 
            // txt_MaLopGacThi
            // 
            this.txt_MaLopGacThi.Enabled = false;
            this.txt_MaLopGacThi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLopGacThi.Location = new System.Drawing.Point(746, 111);
            this.txt_MaLopGacThi.Name = "txt_MaLopGacThi";
            this.txt_MaLopGacThi.Size = new System.Drawing.Size(157, 22);
            this.txt_MaLopGacThi.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(349, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Thông tin giáo viên gác thi";
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 580);
            this.Controls.Add(this.p_suadiem);
            this.Controls.Add(this.p_dangnhap);
            this.Name = "FormGV";
            this.Text = "FormGV";
            this.Load += new System.EventHandler(this.FormGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).EndInit();
            this.p_suadiem.ResumeLayout(false);
            this.p_suadiem.PerformLayout();
            this.p_dangnhap.ResumeLayout(false);
            this.p_dangnhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_sinhvien;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.TextBox txt_TenGV;
        private System.Windows.Forms.Panel p_suadiem;
        private System.Windows.Forms.Panel p_dangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.Button btn_dangnhap_gv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_submatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GioiTInh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaLopGacThi;
        private System.Windows.Forms.Label label9;
    }
}