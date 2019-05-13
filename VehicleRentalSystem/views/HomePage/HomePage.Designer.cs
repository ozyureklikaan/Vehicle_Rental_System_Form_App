namespace VehicleRentalSystem
{
    partial class HomePage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCLICompanyName = new System.Windows.Forms.TextBox();
            this.btnSignUpCompany = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCLIPassword = new System.Windows.Forms.TextBox();
            this.btnCompanyLogIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtULIUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignUpUser = new System.Windows.Forms.Button();
            this.txtULIPassword = new System.Windows.Forms.TextBox();
            this.btnUserLogIn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCLICompanyName);
            this.groupBox2.Controls.Add(this.btnSignUpCompany);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCLIPassword);
            this.groupBox2.Controls.Add(this.btnCompanyLogIn);
            this.groupBox2.Location = new System.Drawing.Point(393, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 262);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Log In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "OR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password :";
            // 
            // txtCLICompanyName
            // 
            this.txtCLICompanyName.Location = new System.Drawing.Point(142, 49);
            this.txtCLICompanyName.Name = "txtCLICompanyName";
            this.txtCLICompanyName.Size = new System.Drawing.Size(152, 20);
            this.txtCLICompanyName.TabIndex = 6;
            // 
            // btnSignUpCompany
            // 
            this.btnSignUpCompany.Location = new System.Drawing.Point(94, 215);
            this.btnSignUpCompany.Name = "btnSignUpCompany";
            this.btnSignUpCompany.Size = new System.Drawing.Size(150, 23);
            this.btnSignUpCompany.TabIndex = 15;
            this.btnSignUpCompany.Text = "Sign Up as a Company";
            this.btnSignUpCompany.UseVisualStyleBackColor = true;
            this.btnSignUpCompany.Click += new System.EventHandler(this.BtnSignUpCompany_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Company Name :";
            // 
            // txtCLIPassword
            // 
            this.txtCLIPassword.Location = new System.Drawing.Point(142, 91);
            this.txtCLIPassword.Name = "txtCLIPassword";
            this.txtCLIPassword.Size = new System.Drawing.Size(152, 20);
            this.txtCLIPassword.TabIndex = 7;
            // 
            // btnCompanyLogIn
            // 
            this.btnCompanyLogIn.Location = new System.Drawing.Point(94, 143);
            this.btnCompanyLogIn.Name = "btnCompanyLogIn";
            this.btnCompanyLogIn.Size = new System.Drawing.Size(150, 26);
            this.btnCompanyLogIn.TabIndex = 8;
            this.btnCompanyLogIn.Text = "Log In";
            this.btnCompanyLogIn.UseVisualStyleBackColor = true;
            this.btnCompanyLogIn.Click += new System.EventHandler(this.BtnCompanyLogIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtULIUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSignUpUser);
            this.groupBox1.Controls.Add(this.txtULIPassword);
            this.groupBox1.Controls.Add(this.btnUserLogIn);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 262);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Log In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "OR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password :";
            // 
            // txtULIUsername
            // 
            this.txtULIUsername.Location = new System.Drawing.Point(142, 49);
            this.txtULIUsername.Name = "txtULIUsername";
            this.txtULIUsername.Size = new System.Drawing.Size(152, 20);
            this.txtULIUsername.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username :";
            // 
            // btnSignUpUser
            // 
            this.btnSignUpUser.Location = new System.Drawing.Point(94, 215);
            this.btnSignUpUser.Name = "btnSignUpUser";
            this.btnSignUpUser.Size = new System.Drawing.Size(150, 23);
            this.btnSignUpUser.TabIndex = 13;
            this.btnSignUpUser.Text = "Sign Up as a User";
            this.btnSignUpUser.UseVisualStyleBackColor = true;
            this.btnSignUpUser.Click += new System.EventHandler(this.BtnSignUpUser_Click);
            // 
            // txtULIPassword
            // 
            this.txtULIPassword.Location = new System.Drawing.Point(142, 91);
            this.txtULIPassword.Name = "txtULIPassword";
            this.txtULIPassword.Size = new System.Drawing.Size(152, 20);
            this.txtULIPassword.TabIndex = 7;
            // 
            // btnUserLogIn
            // 
            this.btnUserLogIn.Location = new System.Drawing.Point(94, 143);
            this.btnUserLogIn.Name = "btnUserLogIn";
            this.btnUserLogIn.Size = new System.Drawing.Size(150, 26);
            this.btnUserLogIn.TabIndex = 8;
            this.btnUserLogIn.Text = "Log In";
            this.btnUserLogIn.UseVisualStyleBackColor = true;
            this.btnUserLogIn.Click += new System.EventHandler(this.BtnUserLogIn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCLICompanyName;
        private System.Windows.Forms.Button btnSignUpCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCLIPassword;
        private System.Windows.Forms.Button btnCompanyLogIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtULIUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignUpUser;
        private System.Windows.Forms.TextBox txtULIPassword;
        private System.Windows.Forms.Button btnUserLogIn;
    }
}

