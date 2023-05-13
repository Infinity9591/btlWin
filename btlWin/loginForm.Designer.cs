namespace btlWin
{
    partial class loginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            btnLogin = new Button();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelToRegister = new LinkLabel();
            txtUsername = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            labelError = new Label();
            btnhide = new Button();
            btnshow = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(153, 170);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 44);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(190, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(142, 23);
            txtPassword.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 47);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 9;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 103);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 10;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 239);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 11;
            label3.Text = "Chưa có tài khoản?";
            // 
            // labelToRegister
            // 
            labelToRegister.AutoSize = true;
            labelToRegister.Location = new Point(229, 239);
            labelToRegister.Name = "labelToRegister";
            labelToRegister.Size = new Size(76, 15);
            labelToRegister.TabIndex = 12;
            labelToRegister.TabStop = true;
            labelToRegister.Text = "Đăng kí ngay";
            labelToRegister.LinkClicked += labelToRegister_LinkClicked;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(190, 49);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 23);
            txtUsername.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(80, 153);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 14;
            // 
            // btnhide
            // 
            btnhide.Location = new Point(338, 105);
            btnhide.Name = "btnhide";
            btnhide.Size = new Size(28, 23);
            btnhide.TabIndex = 15;
            btnhide.Text = "H";
            btnhide.UseVisualStyleBackColor = true;
            btnhide.Click += btnhide_Click;
            // 
            // btnshow
            // 
            btnshow.BackgroundImageLayout = ImageLayout.Stretch;
            btnshow.Location = new Point(338, 105);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(28, 23);
            btnshow.TabIndex = 16;
            btnshow.Text = "S";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 280);
            Controls.Add(pictureBox1);
            Controls.Add(btnshow);
            Controls.Add(btnhide);
            Controls.Add(labelError);
            Controls.Add(btnLogin);
            Controls.Add(labelToRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "loginForm";
            Text = "Đăng nhập";
            Load += loginForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel labelToRegister;
        private TextBox txtUsername;
        private ErrorProvider errorProvider1;
        private Label labelError;
        private Button btnshow;
        private Button btnhide;
        private PictureBox pictureBox1;
    }
}