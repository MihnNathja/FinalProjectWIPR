namespace FinalProject
{
    partial class FTrangChu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpCongViec = new System.Windows.Forms.FlowLayoutPanel();
            this.ucCongViec1 = new FinalProject.ucCongViec();
            this.ucCongViec2 = new FinalProject.ucCongViec();
            this.ucCongViec3 = new FinalProject.ucCongViec();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbDiaDiem = new System.Windows.Forms.ComboBox();
            this.cbbKinhNghiem = new System.Windows.Forms.ComboBox();
            this.cbbTienLuong = new System.Windows.Forms.ComboBox();
            this.pcUserAvatar = new System.Windows.Forms.PictureBox();
            this.flpCongViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 648);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-50, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Việc Làm";
            // 
            // flpCongViec
            // 
            this.flpCongViec.Controls.Add(this.ucCongViec1);
            this.flpCongViec.Controls.Add(this.ucCongViec2);
            this.flpCongViec.Controls.Add(this.ucCongViec3);
            this.flpCongViec.Location = new System.Drawing.Point(15, 114);
            this.flpCongViec.Name = "flpCongViec";
            this.flpCongViec.Size = new System.Drawing.Size(1355, 528);
            this.flpCongViec.TabIndex = 12;
            // 
            // ucCongViec1
            // 
            this.ucCongViec1.Location = new System.Drawing.Point(3, 3);
            this.ucCongViec1.Name = "ucCongViec1";
            this.ucCongViec1.Size = new System.Drawing.Size(939, 125);
            this.ucCongViec1.TabIndex = 0;
            // 
            // ucCongViec2
            // 
            this.ucCongViec2.Location = new System.Drawing.Point(3, 134);
            this.ucCongViec2.Name = "ucCongViec2";
            this.ucCongViec2.Size = new System.Drawing.Size(939, 125);
            this.ucCongViec2.TabIndex = 1;
            // 
            // ucCongViec3
            // 
            this.ucCongViec3.Location = new System.Drawing.Point(3, 265);
            this.ucCongViec3.Name = "ucCongViec3";
            this.ucCongViec3.Size = new System.Drawing.Size(939, 125);
            this.ucCongViec3.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(998, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbbDiaDiem
            // 
            this.cbbDiaDiem.FormattingEnabled = true;
            this.cbbDiaDiem.Items.AddRange(new object[] {
            "Tất cả các tỉnh/thành phố",
            "Hà Nội",
            "Thành phố Hồ Chí Minh"});
            this.cbbDiaDiem.Location = new System.Drawing.Point(337, 33);
            this.cbbDiaDiem.Name = "cbbDiaDiem";
            this.cbbDiaDiem.Size = new System.Drawing.Size(221, 24);
            this.cbbDiaDiem.TabIndex = 2;
            // 
            // cbbKinhNghiem
            // 
            this.cbbKinhNghiem.FormattingEnabled = true;
            this.cbbKinhNghiem.Items.AddRange(new object[] {
            "Tất cả kinh nghiệm",
            "Chưa có kinh nghiệm",
            "Dưới 1 năm kinh nghiệm",
            "1 năm",
            "2 năm",
            "3 năm",
            "4 năm",
            "5 năm",
            "Trên 5 năm"});
            this.cbbKinhNghiem.Location = new System.Drawing.Point(566, 33);
            this.cbbKinhNghiem.Name = "cbbKinhNghiem";
            this.cbbKinhNghiem.Size = new System.Drawing.Size(175, 24);
            this.cbbKinhNghiem.TabIndex = 3;
            // 
            // cbbTienLuong
            // 
            this.cbbTienLuong.FormattingEnabled = true;
            this.cbbTienLuong.Items.AddRange(new object[] {
            "Tất cả mức lương",
            "Dưới 10 triệu",
            "10 - 20 triệu",
            "20 - 30 triệu",
            "30 - 40 triệu",
            "40 - 50 triệu",
            "Trên 50 triệu"});
            this.cbbTienLuong.Location = new System.Drawing.Point(747, 33);
            this.cbbTienLuong.Name = "cbbTienLuong";
            this.cbbTienLuong.Size = new System.Drawing.Size(227, 24);
            this.cbbTienLuong.TabIndex = 13;
            // 
            // pcUserAvatar
            // 
            this.pcUserAvatar.Image = global::FinalProject.Properties.Resources.profile;
            this.pcUserAvatar.Location = new System.Drawing.Point(1211, 12);
            this.pcUserAvatar.Name = "pcUserAvatar";
            this.pcUserAvatar.Size = new System.Drawing.Size(68, 61);
            this.pcUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcUserAvatar.TabIndex = 14;
            this.pcUserAvatar.TabStop = false;
            this.pcUserAvatar.Click += new System.EventHandler(this.pcUserAvatar_Click);
            // 
            // FTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 683);
            this.Controls.Add(this.pcUserAvatar);
            this.Controls.Add(this.cbbTienLuong);
            this.Controls.Add(this.cbbKinhNghiem);
            this.Controls.Add(this.cbbDiaDiem);
            this.Controls.Add(this.flpCongViec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FTrangChu";
            this.Text = "FTrangChu";
            this.Load += new System.EventHandler(this.FTrangChu_Load);
            this.flpCongViec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcUserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpCongViec;
        private ucCongViec ucCongViec1;
        private ucCongViec ucCongViec2;
        private ucCongViec ucCongViec3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbDiaDiem;
        private System.Windows.Forms.ComboBox cbbKinhNghiem;
        private System.Windows.Forms.ComboBox cbbTienLuong;
        private System.Windows.Forms.PictureBox pcUserAvatar;
    }
}