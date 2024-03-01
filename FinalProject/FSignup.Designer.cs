namespace FinalProject
{
    partial class FSignup
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName_FSignup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword_FSignup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmPassword_FSignup = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(258, 54);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(623, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(45, 120);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(103, 20);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName_FSignup
            // 
            this.txtUserName_FSignup.Location = new System.Drawing.Point(258, 116);
            this.txtUserName_FSignup.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUserName_FSignup.Name = "txtUserName_FSignup";
            this.txtUserName_FSignup.Size = new System.Drawing.Size(623, 27);
            this.txtUserName_FSignup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // txtPassword_FSignup
            // 
            this.txtPassword_FSignup.Location = new System.Drawing.Point(258, 179);
            this.txtPassword_FSignup.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPassword_FSignup.Name = "txtPassword_FSignup";
            this.txtPassword_FSignup.PasswordChar = '*';
            this.txtPassword_FSignup.Size = new System.Drawing.Size(623, 27);
            this.txtPassword_FSignup.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirm Password";
            // 
            // txtConfirmPassword_FSignup
            // 
            this.txtConfirmPassword_FSignup.Location = new System.Drawing.Point(258, 242);
            this.txtConfirmPassword_FSignup.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtConfirmPassword_FSignup.Name = "txtConfirmPassword_FSignup";
            this.txtConfirmPassword_FSignup.PasswordChar = '*';
            this.txtConfirmPassword_FSignup.Size = new System.Drawing.Size(623, 27);
            this.txtConfirmPassword_FSignup.TabIndex = 4;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(258, 394);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(531, 48);
            this.btnSignup.TabIndex = 12;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            // 
            // cbbRole
            // 
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Items.AddRange(new object[] {
            "Employee",
            "Employer"});
            this.cbbRole.Location = new System.Drawing.Point(258, 309);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(623, 28);
            this.cbbRole.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Role";
            // 
            // FSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmPassword_FSignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword_FSignup);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName_FSignup);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FSignup";
            this.Text = "FSignup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName_FSignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword_FSignup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword_FSignup;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.Label label3;
    }
}