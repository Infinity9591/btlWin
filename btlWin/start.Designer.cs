namespace btlWin
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(216, 37);
            label1.Name = "label1";
            label1.Size = new Size(545, 49);
            label1.TabIndex = 0;
            label1.Text = "PHẦN MỀM QUẢN LÍ SINH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Exo SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(285, 96);
            label2.Name = "label2";
            label2.Size = new Size(395, 38);
            label2.TabIndex = 0;
            label2.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(348, 215);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 1;
            label3.Text = "Người thực hiện : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(394, 248);
            label4.Name = "label4";
            label4.Size = new Size(236, 25);
            label4.TabIndex = 1;
            label4.Text = "Nguyễn Trung Sơn - 90658";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(394, 273);
            label5.Name = "label5";
            label5.Size = new Size(235, 25);
            label5.TabIndex = 1;
            label5.Text = "Phan Công Lý         - 90488";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(394, 300);
            label6.Name = "label6";
            label6.Size = new Size(235, 25);
            label6.TabIndex = 1;
            label6.Text = "Cao Trần Hưng       - 90302\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(35, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(290, 147);
            label7.Name = "label7";
            label7.Size = new Size(382, 28);
            label7.TabIndex = 3;
            label7.Text = "TRƯỜNG ĐẠI HỌC HÀNG HẢI VIỆT NAM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(781, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 164);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(394, 384);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(153, 61);
            btnStart.TabIndex = 4;
            btnStart.Text = "BẮT ĐẦU";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // start
            // 
            BackColor = Color.White;
            ClientSize = new Size(988, 546);
            Controls.Add(btnStart);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "start";
            Text = "Trang bắt đầu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox2;
        private Button btnStart;
    }
}