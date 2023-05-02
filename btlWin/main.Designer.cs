namespace btlWin1
{
    partial class main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            grbdanhsach = new GroupBox();
            gridviewdssv = new DataGridView();
            grbchucnang = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnReset = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            grbthongtin = new GroupBox();
            dateTimePickerBirth = new DateTimePicker();
            txtPhone = new TextBox();
            label14 = new Label();
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
            label2 = new Label();
            txtCount = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            cBoxFilter = new ComboBox();
            txtSearch = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cBoxGPATo = new ComboBox();
            cBoxGPAFrom = new ComboBox();
            cBoxSearchClass = new ComboBox();
            dateTimePickerBirthTo = new DateTimePicker();
            dateTimePickerBirthFrom = new DateTimePicker();
            cBoxSearch = new ComboBox();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label20 = new Label();
            label15 = new Label();
            txtClassID = new TextBox();
            txtNumberSV = new TextBox();
            txtClassSTT = new TextBox();
            txtClassMa = new TextBox();
            txtClassName = new TextBox();
            groupBox2 = new GroupBox();
            label19 = new Label();
            groupBox1 = new GroupBox();
            btnClassRefresh = new Button();
            gridviewClass = new DataGridView();
            btnClassDel = new Button();
            btnclassadd = new Button();
            btnClassCancel = new Button();
            btnClassUpdate = new Button();
            btnClassSave = new Button();
            grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewdssv).BeginInit();
            grbchucnang.SuspendLayout();
            grbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewClass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(389, 24);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản Lí Sinh Viên";
            // 
            // grbdanhsach
            // 
            grbdanhsach.Controls.Add(gridviewdssv);
            grbdanhsach.Location = new Point(20, 68);
            grbdanhsach.Name = "grbdanhsach";
            grbdanhsach.Size = new Size(1304, 394);
            grbdanhsach.TabIndex = 1;
            grbdanhsach.TabStop = false;
            grbdanhsach.Text = "Danh Sách Sinh Viên";
            // 
            // gridviewdssv
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridviewdssv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridviewdssv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridviewdssv.DefaultCellStyle = dataGridViewCellStyle2;
            gridviewdssv.Dock = DockStyle.Fill;
            gridviewdssv.Location = new Point(3, 19);
            gridviewdssv.MultiSelect = false;
            gridviewdssv.Name = "gridviewdssv";
            gridviewdssv.ReadOnly = true;
            gridviewdssv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridviewdssv.RowTemplate.Height = 25;
            gridviewdssv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridviewdssv.Size = new Size(1298, 372);
            gridviewdssv.TabIndex = 0;
            gridviewdssv.CellMouseClick += gridviewdssv_CellMouseClick;
            // 
            // grbchucnang
            // 
            grbchucnang.Controls.Add(btnCancel);
            grbchucnang.Controls.Add(btnSave);
            grbchucnang.Controls.Add(btnReset);
            grbchucnang.Controls.Add(btnEdit);
            grbchucnang.Controls.Add(btnDelete);
            grbchucnang.Controls.Add(btnAdd);
            grbchucnang.Location = new Point(23, 483);
            grbchucnang.Name = "grbchucnang";
            grbchucnang.Size = new Size(308, 207);
            grbchucnang.TabIndex = 2;
            grbchucnang.TabStop = false;
            grbchucnang.Text = "Chức Năng";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(46, 154);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(169, 92);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(169, 154);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 36);
            btnReset.TabIndex = 0;
            btnReset.Text = "Refresh";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(169, 28);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 36);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(46, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(46, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grbthongtin
            // 
            grbthongtin.Controls.Add(dateTimePickerBirth);
            grbthongtin.Controls.Add(txtPhone);
            grbthongtin.Controls.Add(label14);
            grbthongtin.Controls.Add(cBoxClass);
            grbthongtin.Controls.Add(cBoxGender);
            grbthongtin.Controls.Add(txtGPA);
            grbthongtin.Controls.Add(label13);
            grbthongtin.Controls.Add(txtBranch);
            grbthongtin.Controls.Add(label12);
            grbthongtin.Controls.Add(label11);
            grbthongtin.Controls.Add(label8);
            grbthongtin.Controls.Add(txtAddress);
            grbthongtin.Controls.Add(label10);
            grbthongtin.Controls.Add(txtEmail);
            grbthongtin.Controls.Add(label7);
            grbthongtin.Controls.Add(label9);
            grbthongtin.Controls.Add(txtName);
            grbthongtin.Controls.Add(label6);
            grbthongtin.Controls.Add(txtStudentID);
            grbthongtin.Controls.Add(label5);
            grbthongtin.Location = new Point(361, 483);
            grbthongtin.Name = "grbthongtin";
            grbthongtin.Size = new Size(963, 207);
            grbthongtin.TabIndex = 3;
            grbthongtin.TabStop = false;
            grbthongtin.Text = "Thông tin";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(99, 148);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(96, 23);
            dateTimePickerBirth.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(429, 33);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 23);
            txtPhone.TabIndex = 21;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(370, 36);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 20;
            label14.Text = "SĐT";
            // 
            // cBoxClass
            // 
            cBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxClass.FormattingEnabled = true;
            cBoxClass.Items.AddRange(new object[] { " " });
            cBoxClass.Location = new Point(730, 36);
            cBoxClass.Name = "cBoxClass";
            cBoxClass.Size = new Size(210, 23);
            cBoxClass.TabIndex = 3;
            cBoxClass.SelectedIndexChanged += cBoxClass_SelectedIndexChanged;
            // 
            // cBoxGender
            // 
            cBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxGender.FormattingEnabled = true;
            cBoxGender.Location = new Point(265, 148);
            cBoxGender.Name = "cBoxGender";
            cBoxGender.Size = new Size(82, 23);
            cBoxGender.TabIndex = 2;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(730, 146);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(102, 23);
            txtGPA.TabIndex = 1;
            txtGPA.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(672, 146);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 0;
            label13.Text = "Điểm";
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(730, 92);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(210, 23);
            txtBranch.TabIndex = 1;
            txtBranch.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(672, 92);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 0;
            label12.Text = "Ngành";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(672, 39);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 0;
            label11.Text = "Lớp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 151);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 0;
            label8.Text = "Giới tính";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(428, 148);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(210, 23);
            txtAddress.TabIndex = 1;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(370, 151);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 0;
            label10.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(428, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 95);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 154);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 0;
            label9.Text = "Ngày Sinh";
            // 
            // txtName
            // 
            txtName.Location = new Point(99, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 23);
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 95);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 0;
            label6.Text = "Họ Và Tên";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(99, 33);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(133, 23);
            txtStudentID.TabIndex = 1;
            txtStudentID.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 33);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 0;
            label5.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 34);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Số Lượng";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(87, 31);
            txtCount.Name = "txtCount";
            txtCount.ReadOnly = true;
            txtCount.Size = new Size(88, 23);
            txtCount.TabIndex = 2;
            txtCount.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._352137_sort_icon;
            pictureBox1.Location = new Point(818, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._285651_search_icon;
            pictureBox2.Location = new Point(1052, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(849, 39);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Lọc theo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1083, 41);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Tìm kiếm";
            // 
            // cBoxFilter
            // 
            cBoxFilter.FormattingEnabled = true;
            cBoxFilter.Location = new Point(908, 37);
            cBoxFilter.Name = "cBoxFilter";
            cBoxFilter.Size = new Size(106, 23);
            cBoxFilter.TabIndex = 7;
            cBoxFilter.SelectedIndexChanged += cBoxFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1145, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(176, 23);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-4, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1346, 731);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cBoxGPATo);
            tabPage1.Controls.Add(cBoxGPAFrom);
            tabPage1.Controls.Add(cBoxSearchClass);
            tabPage1.Controls.Add(dateTimePickerBirthTo);
            tabPage1.Controls.Add(dateTimePickerBirthFrom);
            tabPage1.Controls.Add(cBoxSearch);
            tabPage1.Controls.Add(grbchucnang);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(txtCount);
            tabPage1.Controls.Add(cBoxFilter);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(grbthongtin);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(grbdanhsach);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1338, 703);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sinh Viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cBoxGPATo
            // 
            cBoxGPATo.FormattingEnabled = true;
            cBoxGPATo.Location = new Point(1237, 38);
            cBoxGPATo.Name = "cBoxGPATo";
            cBoxGPATo.Size = new Size(84, 23);
            cBoxGPATo.TabIndex = 11;
            // 
            // cBoxGPAFrom
            // 
            cBoxGPAFrom.FormattingEnabled = true;
            cBoxGPAFrom.Location = new Point(1145, 38);
            cBoxGPAFrom.Name = "cBoxGPAFrom";
            cBoxGPAFrom.Size = new Size(86, 23);
            cBoxGPAFrom.TabIndex = 12;
            // 
            // cBoxSearchClass
            // 
            cBoxSearchClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxSearchClass.FormattingEnabled = true;
            cBoxSearchClass.Location = new Point(1145, 38);
            cBoxSearchClass.Name = "cBoxSearchClass";
            cBoxSearchClass.Size = new Size(176, 23);
            cBoxSearchClass.TabIndex = 10;
            cBoxSearchClass.SelectedIndexChanged += cBoxSearchClass_SelectedIndexChanged;
            // 
            // dateTimePickerBirthTo
            // 
            dateTimePickerBirthTo.Location = new Point(1237, 38);
            dateTimePickerBirthTo.Name = "dateTimePickerBirthTo";
            dateTimePickerBirthTo.Size = new Size(84, 23);
            dateTimePickerBirthTo.TabIndex = 10;
            dateTimePickerBirthTo.ValueChanged += dateTimePickerBirthTo_ValueChanged;
            // 
            // dateTimePickerBirthFrom
            // 
            dateTimePickerBirthFrom.Location = new Point(1145, 38);
            dateTimePickerBirthFrom.Name = "dateTimePickerBirthFrom";
            dateTimePickerBirthFrom.Size = new Size(86, 23);
            dateTimePickerBirthFrom.TabIndex = 10;
            dateTimePickerBirthFrom.ValueChanged += dateTimePickerBirthFrom_ValueChanged;
            // 
            // cBoxSearch
            // 
            cBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxSearch.FormattingEnabled = true;
            cBoxSearch.Location = new Point(1145, 38);
            cBoxSearch.Name = "cBoxSearch";
            cBoxSearch.Size = new Size(176, 23);
            cBoxSearch.TabIndex = 9;
            cBoxSearch.SelectedIndexChanged += cBoxSearch_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1338, 703);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lớp";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtClassID);
            groupBox3.Controls.Add(txtNumberSV);
            groupBox3.Controls.Add(txtClassSTT);
            groupBox3.Controls.Add(txtClassMa);
            groupBox3.Controls.Add(txtClassName);
            groupBox3.Location = new Point(216, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(887, 145);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông Tin";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(540, 68);
            label18.Name = "label18";
            label18.Size = new Size(47, 15);
            label18.TabIndex = 4;
            label18.Text = "Mã Lớp";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(280, 68);
            label17.Name = "label17";
            label17.Size = new Size(51, 15);
            label17.TabIndex = 4;
            label17.Text = "Tên  Lớp";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(132, 68);
            label16.Name = "label16";
            label16.Size = new Size(41, 15);
            label16.TabIndex = 4;
            label16.Text = "ID Lớp";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(729, 68);
            label20.Name = "label20";
            label20.Size = new Size(73, 15);
            label20.TabIndex = 4;
            label20.Text = "Số Lương SV";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 68);
            label15.Name = "label15";
            label15.Size = new Size(25, 15);
            label15.TabIndex = 4;
            label15.Text = "STT";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(132, 86);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(94, 23);
            txtClassID.TabIndex = 3;
            txtClassID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumberSV
            // 
            txtNumberSV.Location = new Point(729, 86);
            txtNumberSV.Name = "txtNumberSV";
            txtNumberSV.Size = new Size(95, 23);
            txtNumberSV.TabIndex = 2;
            txtNumberSV.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClassSTT
            // 
            txtClassSTT.Location = new Point(28, 86);
            txtClassSTT.Name = "txtClassSTT";
            txtClassSTT.Size = new Size(58, 23);
            txtClassSTT.TabIndex = 2;
            txtClassSTT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClassMa
            // 
            txtClassMa.Location = new Point(540, 86);
            txtClassMa.Name = "txtClassMa";
            txtClassMa.Size = new Size(144, 23);
            txtClassMa.TabIndex = 1;
            txtClassMa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(280, 86);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(205, 23);
            txtClassName.TabIndex = 0;
            txtClassName.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label19);
            groupBox2.Location = new Point(213, 561);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(890, 100);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chú Thích";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label19.Location = new Point(378, 35);
            label19.Name = "label19";
            label19.Size = new Size(135, 37);
            label19.TabIndex = 0;
            label19.Text = "chú thích";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClassRefresh);
            groupBox1.Controls.Add(gridviewClass);
            groupBox1.Controls.Add(btnClassDel);
            groupBox1.Controls.Add(btnclassadd);
            groupBox1.Controls.Add(btnClassCancel);
            groupBox1.Controls.Add(btnClassUpdate);
            groupBox1.Controls.Add(btnClassSave);
            groupBox1.Location = new Point(213, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(890, 300);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách";
            // 
            // btnClassRefresh
            // 
            btnClassRefresh.Location = new Point(607, 219);
            btnClassRefresh.Name = "btnClassRefresh";
            btnClassRefresh.Size = new Size(93, 49);
            btnClassRefresh.TabIndex = 0;
            btnClassRefresh.Text = "Refresh";
            btnClassRefresh.UseVisualStyleBackColor = true;
            btnClassRefresh.MouseHover += btnClassRefresh_MouseHover;
            // 
            // gridviewClass
            // 
            gridviewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewClass.Location = new Point(3, 19);
            gridviewClass.Name = "gridviewClass";
            gridviewClass.RowTemplate.Height = 25;
            gridviewClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridviewClass.Size = new Size(556, 278);
            gridviewClass.TabIndex = 7;
            gridviewClass.CellClick += gridviewClass_CellClick;
            // 
            // btnClassDel
            // 
            btnClassDel.Location = new Point(607, 137);
            btnClassDel.Name = "btnClassDel";
            btnClassDel.Size = new Size(93, 49);
            btnClassDel.TabIndex = 0;
            btnClassDel.Text = "Xóa";
            btnClassDel.UseVisualStyleBackColor = true;
            btnClassDel.MouseHover += btnClassDel_MouseHover;
            // 
            // btnclassadd
            // 
            btnclassadd.Location = new Point(607, 55);
            btnclassadd.Name = "btnclassadd";
            btnclassadd.Size = new Size(93, 49);
            btnclassadd.TabIndex = 0;
            btnclassadd.Text = "Thêm";
            btnclassadd.UseVisualStyleBackColor = true;
            btnclassadd.MouseHover += btnclassadd_MouseHover;
            // 
            // btnClassCancel
            // 
            btnClassCancel.Location = new Point(745, 219);
            btnClassCancel.Name = "btnClassCancel";
            btnClassCancel.Size = new Size(93, 49);
            btnClassCancel.TabIndex = 0;
            btnClassCancel.Text = "Hủy";
            btnClassCancel.UseVisualStyleBackColor = true;
            btnClassCancel.MouseHover += btnClassCancel_MouseHover;
            // 
            // btnClassUpdate
            // 
            btnClassUpdate.Location = new Point(745, 55);
            btnClassUpdate.Name = "btnClassUpdate";
            btnClassUpdate.Size = new Size(93, 49);
            btnClassUpdate.TabIndex = 0;
            btnClassUpdate.Text = "Sửa";
            btnClassUpdate.UseVisualStyleBackColor = true;
            btnClassUpdate.MouseHover += btnClassUpdate_MouseHover;
            // 
            // btnClassSave
            // 
            btnClassSave.Location = new Point(745, 137);
            btnClassSave.Name = "btnClassSave";
            btnClassSave.Size = new Size(93, 49);
            btnClassSave.TabIndex = 0;
            btnClassSave.Text = "Lưu";
            btnClassSave.UseVisualStyleBackColor = true;
            btnClassSave.MouseHover += btnClassSave_MouseHover;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 727);
            Controls.Add(tabControl1);
            Name = "main";
            Text = "Quản Lí";
            Load += main_Load;
            grbdanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridviewdssv).EndInit();
            grbchucnang.ResumeLayout(false);
            grbthongtin.ResumeLayout(false);
            grbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridviewClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grbdanhsach;
        private DataGridView gridviewdssv;
        private GroupBox grbchucnang;
        private GroupBox grbthongtin;
        private Button btnSave;
        private Button btnReset;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtStudentID;
        private Label label5;
        private Label label2;
        private TextBox txtCount;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private ComboBox cBoxFilter;
        private TextBox txtSearch;
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
        private ComboBox cBoxGender;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cBoxClass;
        private TextBox txtPhone;
        private Label label14;
        private ComboBox cBoxSearch;
        private DateTimePicker dateTimePickerBirth;
        private DateTimePicker dateTimePickerBirthTo;
        private DateTimePicker dateTimePickerBirthFrom;
        private ComboBox cBoxSearchClass;
        private ComboBox cBoxGPATo;
        private ComboBox cBoxGPAFrom;
        private GroupBox groupBox3;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtClassID;
        private TextBox txtClassSTT;
        private TextBox txtClassMa;
        private TextBox txtClassName;
        private GroupBox groupBox2;
        private Button btnClassRefresh;
        private Button btnClassDel;
        private Button btnClassCancel;
        private Button btnClassSave;
        private Button btnClassUpdate;
        private Button btnclassadd;
        private GroupBox groupBox1;
        private DataGridView gridviewClass;
        private Label label19;
        private Label label20;
        private TextBox txtNumberSV;
        private Button btnCancel;
    }
}