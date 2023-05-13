namespace btlWin1
{
    partial class add
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
            cBoxClass = new ComboBox();
            cBoxGender = new ComboBox();
            txtGPA = new TextBox();
            label13 = new Label();
            txtBranch = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtStudentID = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            btnAdd = new Button();
            labelError = new Label();
            dateTimePickerBirth = new DateTimePicker();
            errorGPA = new ErrorProvider(components);
            errorPhone = new ErrorProvider(components);
            errorID = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorGPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorID).BeginInit();
            SuspendLayout();
            // 
            // cBoxClass
            // 
            cBoxClass.FormattingEnabled = true;
            cBoxClass.Location = new Point(727, 32);
            cBoxClass.Name = "cBoxClass";
            cBoxClass.Size = new Size(210, 23);
            cBoxClass.TabIndex = 21;
            cBoxClass.SelectedIndexChanged += cBoxClass_SelectedIndexChanged;
            // 
            // cBoxGender
            // 
            cBoxGender.FormattingEnabled = true;
            cBoxGender.Location = new Point(425, 29);
            cBoxGender.Name = "cBoxGender";
            cBoxGender.Size = new Size(82, 23);
            cBoxGender.TabIndex = 20;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(727, 142);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(102, 23);
            txtGPA.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(669, 142);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 6;
            label13.Text = "Điểm";
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(727, 88);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(210, 23);
            txtBranch.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(669, 88);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 8;
            label12.Text = "Ngành";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(669, 35);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 9;
            label11.Text = "Lớp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(367, 32);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 10;
            label8.Text = "Giới tính";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(425, 144);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(210, 23);
            txtAddress.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(367, 147);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 11;
            label10.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(425, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(367, 91);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 12;
            label7.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(39, 150);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 7;
            label9.Text = "Năm Sinh";
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 23);
            txtName.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(39, 91);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 5;
            label6.Text = "Họ Và Tên";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(121, 29);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(96, 23);
            txtStudentID.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(39, 29);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Mã Sinh Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(979, 35);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 12;
            label1.Text = "SĐT";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(1022, 32);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 23);
            txtPhone.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1032, 109);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 56);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(1059, 88);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 23;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(121, 150);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(144, 23);
            dateTimePickerBirth.TabIndex = 24;
            // 
            // errorGPA
            // 
            errorGPA.ContainerControl = this;
            // 
            // errorPhone
            // 
            errorPhone.ContainerControl = this;
            // 
            // errorID
            // 
            errorID.ContainerControl = this;
            // 
            // add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1291, 206);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(labelError);
            Controls.Add(btnAdd);
            Controls.Add(cBoxClass);
            Controls.Add(cBoxGender);
            Controls.Add(txtGPA);
            Controls.Add(label13);
            Controls.Add(txtBranch);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(label10);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(txtStudentID);
            Controls.Add(label5);
            Name = "add";
            Text = "Thêm sinh viên";
            Load += add_Load;
            ((System.ComponentModel.ISupportInitialize)errorGPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBoxClass;
        private ComboBox cBoxGender;
        private TextBox txtGPA;
        private Label label13;
        private TextBox txtBranch;
        private Label label12;
        private Label label11;
        private Label label8;
        private TextBox txtAddress;
        private Label label10;
        private TextBox txtEmail;
        private Label label7;
        private Label label9;
        private TextBox txtName;
        private Label label6;
        private TextBox txtStudentID;
        private Label label5;
        private Label label1;
        private TextBox txtPhone;
        private Button btnAdd;
        private Label labelError;
        private DateTimePicker dateTimePickerBirth;
        private ErrorProvider errorGPA;
        private ErrorProvider errorPhone;
        private ErrorProvider errorID;
    }
}