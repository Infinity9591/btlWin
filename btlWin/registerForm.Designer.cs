namespace btlWin
{
    partial class registerForm
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
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelToLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtError = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnHideRePass = new System.Windows.Forms.Button();
            this.btnShowRePass = new System.Windows.Forms.Button();
            this.btnHidePass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(204, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(196, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(163, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(204, 156);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(163, 23);
            this.txtRepeatPassword.TabIndex = 2;
            this.txtRepeatPassword.TextChanged += new System.EventHandler(this.txtRepeatPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng kí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đã có tài khoản?";
            // 
            // labelToLogin
            // 
            this.labelToLogin.AutoSize = true;
            this.labelToLogin.Location = new System.Drawing.Point(253, 285);
            this.labelToLogin.Name = "labelToLogin";
            this.labelToLogin.Size = new System.Drawing.Size(65, 15);
            this.labelToLogin.TabIndex = 7;
            this.labelToLogin.TabStop = true;
            this.labelToLogin.Text = "Đăng nhập";
            this.labelToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelToLogin_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(175, 216);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 44);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Đăng kí";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(132, 201);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(0, 15);
            this.txtError.TabIndex = 9;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Location = new System.Drawing.Point(373, 98);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(27, 23);
            this.btnShowPass.TabIndex = 10;
            this.btnShowPass.Text = "S";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHideRePass
            // 
            this.btnHideRePass.Location = new System.Drawing.Point(373, 155);
            this.btnHideRePass.Name = "btnHideRePass";
            this.btnHideRePass.Size = new System.Drawing.Size(27, 23);
            this.btnHideRePass.TabIndex = 11;
            this.btnHideRePass.Text = "H";
            this.btnHideRePass.UseVisualStyleBackColor = true;
            this.btnHideRePass.Click += new System.EventHandler(this.btnHideRePass_Click);
            // 
            // btnShowRePass
            // 
            this.btnShowRePass.Location = new System.Drawing.Point(373, 155);
            this.btnShowRePass.Name = "btnShowRePass";
            this.btnShowRePass.Size = new System.Drawing.Size(27, 23);
            this.btnShowRePass.TabIndex = 12;
            this.btnShowRePass.Text = "S";
            this.btnShowRePass.UseVisualStyleBackColor = true;
            this.btnShowRePass.Click += new System.EventHandler(this.btnShowRePass_Click);
            // 
            // btnHidePass
            // 
            this.btnHidePass.Location = new System.Drawing.Point(373, 98);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(27, 23);
            this.btnHidePass.TabIndex = 13;
            this.btnHidePass.Text = "H";
            this.btnHidePass.UseVisualStyleBackColor = true;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // registerForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 335);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnHidePass);
            this.Controls.Add(this.btnShowRePass);
            this.Controls.Add(this.btnHideRePass);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelToLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "registerForm";
            this.Text = "Đăng kí";
            this.Load += new System.EventHandler(this.registerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtRepeatPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel labelToLogin;
        private Button btnRegister;
        private ErrorProvider errorProvider1;
        private Label txtError;
        private Button btnHidePass;
        private Button btnShowRePass;
        private Button btnHideRePass;
        private Button btnShowPass;
    }
}