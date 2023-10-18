namespace QuanLyCuaHangSach
{
    partial class Frm_KhoSach
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
            lbMaSach = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaSach = new TextBox();
            txtNameSach = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            TheLoai = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            NhaXB = new DataGridViewTextBoxColumn();
            GiaTien = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbMaSach
            // 
            lbMaSach.AutoSize = true;
            lbMaSach.BackColor = Color.Transparent;
            lbMaSach.Location = new Point(91, 51);
            lbMaSach.Name = "lbMaSach";
            lbMaSach.Size = new Size(82, 22);
            lbMaSach.TabIndex = 0;
            lbMaSach.Text = "Mã sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 87);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 128);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 0;
            label3.Text = "Thể loại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 210);
            label4.Name = "label4";
            label4.Size = new Size(118, 22);
            label4.TabIndex = 0;
            label4.Text = "Nhà xuất bản:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 87);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 0;
            label5.Text = "Số lượng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(585, 46);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 0;
            label6.Text = "Giá tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(91, 169);
            label7.Name = "label7";
            label7.Size = new Size(75, 22);
            label7.TabIndex = 0;
            label7.Text = "Tác giả:";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(224, 38);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(227, 30);
            txtMaSach.TabIndex = 1;
            // 
            // txtNameSach
            // 
            txtNameSach.Location = new Point(224, 79);
            txtNameSach.Name = "txtNameSach";
            txtNameSach.Size = new Size(227, 30);
            txtNameSach.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 30);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(227, 30);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(224, 202);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(227, 30);
            textBox5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { STT, MaSach, TenSach, TheLoai, TacGia, NhaXB, GiaTien, SoLuong });
            dataGridView1.Location = new Point(0, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1054, 219);
            dataGridView1.TabIndex = 2;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 125;
            // 
            // MaSach
            // 
            MaSach.HeaderText = "Mã Sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.Width = 125;
            // 
            // TenSach
            // 
            TenSach.HeaderText = "Tên Sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.Width = 125;
            // 
            // TheLoai
            // 
            TheLoai.HeaderText = "Thể Loại";
            TheLoai.MinimumWidth = 6;
            TheLoai.Name = "TheLoai";
            TheLoai.Width = 125;
            // 
            // TacGia
            // 
            TacGia.HeaderText = "Tác Giả";
            TacGia.MinimumWidth = 6;
            TacGia.Name = "TacGia";
            TacGia.Width = 125;
            // 
            // NhaXB
            // 
            NhaXB.HeaderText = "Nhà XB";
            NhaXB.MinimumWidth = 6;
            NhaXB.Name = "NhaXB";
            NhaXB.Width = 125;
            // 
            // GiaTien
            // 
            GiaTien.HeaderText = "Giá Tiền";
            GiaTien.MinimumWidth = 6;
            GiaTien.Name = "GiaTien";
            GiaTien.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(686, 43);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(227, 30);
            textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(686, 87);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(227, 30);
            textBox7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._013;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1054, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Frm_KhoSach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 500);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtNameSach);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(txtMaSach);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbMaSach);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_KhoSach";
            Text = "Kho Sách";
            Load += Frm_KhoSach_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMaSach;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMaSach;
        private TextBox txtNameSach;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn NhaXB;
        private DataGridViewTextBoxColumn GiaTien;
        private DataGridViewTextBoxColumn SoLuong;
        private TextBox textBox6;
        private TextBox textBox7;
        private PictureBox pictureBox1;
    }
}