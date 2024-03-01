namespace FinalProject
{
    partial class FDoanhNghiep
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKhaoSat = new System.Windows.Forms.Button();
            this.btnCongViecQuanTam = new System.Windows.Forms.Button();
            this.btnCongViecUngTuyen = new System.Windows.Forms.Button();
            this.btnCV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhaoSat);
            this.groupBox1.Controls.Add(this.btnCongViecQuanTam);
            this.groupBox1.Controls.Add(this.btnCongViecUngTuyen);
            this.groupBox1.Controls.Add(this.btnCV);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 569);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh Nghiệp";
            // 
            // btnKhaoSat
            // 
            this.btnKhaoSat.Location = new System.Drawing.Point(44, 433);
            this.btnKhaoSat.Name = "btnKhaoSat";
            this.btnKhaoSat.Size = new System.Drawing.Size(222, 38);
            this.btnKhaoSat.TabIndex = 4;
            this.btnKhaoSat.Text = "Khảo Sát";
            this.btnKhaoSat.UseVisualStyleBackColor = true;
            // 
            // btnCongViecQuanTam
            // 
            this.btnCongViecQuanTam.Location = new System.Drawing.Point(44, 372);
            this.btnCongViecQuanTam.Name = "btnCongViecQuanTam";
            this.btnCongViecQuanTam.Size = new System.Drawing.Size(222, 38);
            this.btnCongViecQuanTam.TabIndex = 3;
            this.btnCongViecQuanTam.Text = "Việc Làm Hết Hạn";
            this.btnCongViecQuanTam.UseVisualStyleBackColor = true;
            // 
            // btnCongViecUngTuyen
            // 
            this.btnCongViecUngTuyen.Location = new System.Drawing.Point(44, 310);
            this.btnCongViecUngTuyen.Name = "btnCongViecUngTuyen";
            this.btnCongViecUngTuyen.Size = new System.Drawing.Size(222, 38);
            this.btnCongViecUngTuyen.TabIndex = 2;
            this.btnCongViecUngTuyen.Text = "Việc Làm Đang Tuyển";
            this.btnCongViecUngTuyen.UseVisualStyleBackColor = true;
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(44, 251);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(222, 38);
            this.btnCV.TabIndex = 1;
            this.btnCV.Text = "CV Đã nhận";
            this.btnCV.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(73, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm Công Việc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FDoanhNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FDoanhNghiep";
            this.Text = "FDoanhNghiep";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKhaoSat;
        private System.Windows.Forms.Button btnCongViecQuanTam;
        private System.Windows.Forms.Button btnCongViecUngTuyen;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}