using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net;

namespace btlWin1
{
    public partial class main : Form
    {

        string filename = "config.txt";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public main()
        {
            InitializeComponent();
            string s = File.ReadAllText(filename);
            con = new SqlConnection(s);
        }

        private void main_Load(object sender, EventArgs e)
        {
            DataTable dtClass = new DataTable();
            DataTable dt = new DataTable();
            DataTable dtClassCBox = new DataTable();
            DataTable dtClasscBoxSearch = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from studentview", con);
                SqlDataAdapter daClass = new SqlDataAdapter("select * from classview", con);
                SqlDataAdapter daClassCBox = new SqlDataAdapter("select * from Class", con);
                SqlDataAdapter daClassCBoxSearch = new SqlDataAdapter("select * from Class", con);
                da.Fill(dt);
                daClass.Fill(dtClass);
                daClassCBox.Fill(dtClassCBox);
                daClassCBoxSearch.Fill(dtClasscBoxSearch);

                cBoxClass.DisplayMember = "ClassName";
                cBoxClass.ValueMember = "Class";
                cBoxClass.DataSource = dtClassCBox;

                cBoxSearchClass.DisplayMember = "ClassName";
                cBoxSearchClass.ValueMember = "Class";
                cBoxSearchClass.DataSource = dtClasscBoxSearch;

                gridviewClass.DataSource = dtClass;
                gridviewClass.Columns[0].Width = 50;
                gridviewClass.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridviewClass.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridviewClass.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridviewClass.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                gridviewdssv.DataSource = dt;
                gridviewdssv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridviewdssv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridviewdssv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridviewdssv.Columns["STT"].Width = 50;
                gridviewdssv.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

                txtCount.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cBoxGender.Items.Clear();
            cBoxGender.Items.Add("Nam");
            cBoxGender.Items.Add("Nữ");

            foreach (DataGridViewTextBoxColumn item in gridviewdssv.Columns)
            {
                if (item.Name != "STT")
                    cBoxFilter.Items.Add(item.Name);
            }

            foreach (TextBoxBase i in grbthongtin.Controls.OfType<TextBoxBase>())
            {
                i.ReadOnly = true;
            }

            foreach (ComboBox i in grbthongtin.Controls.OfType<ComboBox>())
            {
                i.Enabled = false;
            }

            foreach (DateTimePicker i in grbthongtin.Controls.OfType<DateTimePicker>())
            {
                i.Enabled = false;
            }

            foreach (TextBoxBase i in groupBox3.Controls.OfType<TextBoxBase>())
            {
                i.ReadOnly = true;
            }

            dateTimePickerBirth.CustomFormat = "dd/MM/yyyy";
            dateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirth.Text = string.Empty;
            txtSearch.Show();
            cBoxSearch.Hide();
            cBoxSearchClass.Hide();
            dateTimePickerBirthFrom.Hide();
            dateTimePickerBirthTo.Hide();
            cBoxGPAFrom.Hide();
            cBoxGPATo.Hide();
            dateTimePickerBirthFrom.CustomFormat = "dd/MM/yyyy";
            dateTimePickerBirthFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthTo.CustomFormat = "dd/MM/yyyy";
            dateTimePickerBirthTo.Format = DateTimePickerFormat.Custom;
            btnSave.Enabled = false;
            txtSearch.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmdDel = new SqlCommand();
                cmdDel.Connection = con;
                cmdDel.CommandType = CommandType.Text;
                int r = gridviewdssv.CurrentCell.RowIndex;
                string strMaSV = gridviewdssv.Rows[r].Cells[1].Value.ToString();
                cmdDel.CommandText = "DELETE FROM [Student] WHERE ID='" + strMaSV + "'";
                cmdDel.ExecuteNonQuery();
                main_Load(sender, e);
            }
            catch (SqlException)
            {

                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại", "Thông báo");
            }
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cBoxFilter.Items.Clear();
            cBoxFilter.Text = string.Empty;

            txtSearch.Clear();
            txtStudentID.Clear();
            txtName.Clear();
            cBoxGender.Items.Clear();
            cBoxSearch.Items.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtBranch.Clear();
            txtGPA.Clear();
            main_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (TextBoxBase i in grbthongtin.Controls.OfType<TextBoxBase>())
            {
                if (i.Name != "txtBranch")
                {
                    i.ReadOnly = false;
                }

            }

            foreach (ComboBox i in grbthongtin.Controls.OfType<ComboBox>())
            {
                i.Enabled = true;
            }

            foreach (DateTimePicker i in grbthongtin.Controls.OfType<DateTimePicker>())
            {
                i.Enabled = true;
            }
            btnSave.Enabled = true;
        }

        private void gridviewdssv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtBranch.Clear();
            txtGPA.Clear();

            int r = gridviewdssv.CurrentRow.Index;
            string? strMSV = gridviewdssv.Rows[r].Cells[1].Value.ToString();
            txtStudentID.Text = strMSV;

            string? strName = gridviewdssv.Rows[r].Cells[2].Value.ToString();
            txtName.Text = strName;

            string? strGender = gridviewdssv.Rows[r].Cells[3].Value.ToString();
            cBoxGender.Text = strGender;

            DateTime? strBirth = Convert.ToDateTime(gridviewdssv.Rows[r].Cells[4].Value.ToString());
            dateTimePickerBirth.Text = strBirth.ToString();

            string? strPhone = gridviewdssv.Rows[r].Cells[5].Value.ToString();
            txtPhone.Text = strPhone;

            string? strEmail = gridviewdssv.Rows[r].Cells[6].Value.ToString();
            txtEmail.Text = strEmail;

            string? strAddress = gridviewdssv.Rows[r].Cells[7].Value.ToString();
            txtAddress.Text = strAddress;

            string? strClass = gridviewdssv.Rows[r].Cells[8].Value.ToString();
            cBoxClass.Text = strClass;

            string? strBranch = gridviewdssv.Rows[r].Cells[9].Value.ToString();
            txtBranch.Text = strBranch;

            string? strGPA = gridviewdssv.Rows[r].Cells[10].Value.ToString();
            txtGPA.Text = strGPA;
        }

        private void cBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? strName = cBoxClass.Text.ToString();
            char[] ch = strName.ToCharArray();

            string? strCheck = "";
            if (strName.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    strCheck += ch[i];
                }
            }
            //label11.Text = strName;
            if (strCheck == "CNT")
            {
                txtBranch.Text = "Công Nghệ Thông Tin";
            }
            if (strCheck == "KPM")
            {
                txtBranch.Text = "Công Nghệ Phần Mềm";
            }
            if (strCheck == "TTM")
            {
                txtBranch.Text = "Truyền thông & Mạng máy tính";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmdUpdateStudent = new SqlCommand();
            cmdUpdateStudent.Connection = con;
            string? strMSV = txtStudentID.Text;
            string? strName = txtName.Text;
            DateTime dateTime = dateTimePickerBirth.Value;
            string? strPhone = txtPhone.Text;
            string? strGender = cBoxGender.SelectedItem.ToString();
            cBoxGender.Items.Clear();
            string? strEmail = txtEmail.Text;
            string? strAddress = txtAddress.Text;
            float? strGPA = float.Parse(txtGPA.Text);
            cmdUpdateStudent.CommandText = "SELECT * FROM [Student] WHERE ID = '" + strMSV + "'";
            dr = cmdUpdateStudent.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "UPDATE Student SET [Name] = N'" + strName + "' , Sex =N'" + strGender + "' , Birth ='" + dateTime + "' , Email =' " + strEmail + "' , [Address] =N'" + strAddress + "' , Phone ='" + strPhone + "', GPA ='" + strGPA + "' , ClassID = '" + (cBoxClass.SelectedIndex + 1) + "' WHERE ID = '" + strMSV + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                dr.Close();
                MessageBox.Show("Sinh viên có mã sinh viên này không tồn tại", "Thông báo");
            }
            con.Close();
            txtStudentID.Text = string.Empty;
            txtName.Text = string.Empty;
            dateTimePickerBirth.Value = DateTime.Now;
            cBoxGender.Items.Clear();
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtGPA.Text = string.Empty;

            main_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.ShowDialog();
        }

        private void cBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? strFilter = (string?)cBoxFilter.Text.ToString();

            if (strFilter == "Mã sinh viên")
            {
                txtSearch.Show();
                txtSearch.Text = string.Empty;
                cBoxSearch.Hide();
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearch.Items.Clear();
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();
                txtSearch.Enabled = true;

            }
            else if (strFilter == "Tên")
            {
                txtSearch.Show();
                txtSearch.Text = string.Empty;

                cBoxSearch.Hide();
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearch.Items.Clear();
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();
                txtSearch.Enabled = true;

            }
            else if (strFilter == "Giới tính")
            {
                txtSearch.Hide();
                cBoxSearch.Show();
                cBoxSearch.Items.Clear();
                cBoxSearch.Text = string.Empty;

                cBoxSearch.Items.Add("Nam");
                cBoxSearch.Items.Add("Nữ");
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();

            }
            else if (strFilter == "Ngày sinh")
            {
                txtSearch.Hide();
                cBoxSearch.Hide();
                dateTimePickerBirthFrom.Show();
                dateTimePickerBirthTo.Show();
                dateTimePickerBirthFrom.CustomFormat = "dd/MM/yyyy";
                dateTimePickerBirthFrom.Format = DateTimePickerFormat.Custom;
                dateTimePickerBirthTo.CustomFormat = "dd/MM/yyyy";
                dateTimePickerBirthTo.Format = DateTimePickerFormat.Custom;
                cBoxSearch.Items.Clear();
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();

            }
            else if (strFilter == "Số điện thoại")
            {
                txtSearch.Show();
                txtSearch.Text = string.Empty;

                cBoxSearch.Hide();
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearch.Items.Clear();
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();
                txtSearch.Enabled = true;

            }
            else if (strFilter == "Email")
            {
                txtSearch.Show();
                cBoxSearch.Hide();
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearch.Items.Clear();
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();
                txtSearch.Enabled = true;

            }
            else if (strFilter == "Địa chỉ")
            {
                txtSearch.Show();
                txtSearch.Text = string.Empty;

                cBoxSearch.Hide();
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearch.Items.Clear();
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();
                txtSearch.Enabled = true;

            }
            else if (strFilter == "Lớp")
            {
                txtSearch.Hide();
                cBoxSearch.Hide();
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearch.Items.Clear();
                cBoxSearchClass.Show();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();
            }
            else if (strFilter == "Khoa")
            {
                txtSearch.Hide();
                cBoxSearch.Show();
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearch.Items.Clear();
                cBoxSearch.Text = string.Empty;
                cBoxSearch.Items.Add("Công Nghệ Thông Tin");
                cBoxSearch.Items.Add("Công Nghệ Phần Mềm");
                cBoxSearch.Items.Add("Truyền thông & Mạng máy tính");
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Hide();
                cBoxGPATo.Hide();
            }
            else if (strFilter == "Điểm trung bình")
            {
                dateTimePickerBirthFrom.Hide();
                dateTimePickerBirthTo.Hide();
                cBoxSearch.Items.Clear();
                cBoxSearchClass.Hide();
                cBoxGPAFrom.Show();
                cBoxGPATo.Show();
                txtSearch.Hide();
                cBoxSearch.Hide();
                cBoxGPAFrom.Items.Add(">=0");
                cBoxGPAFrom.Items.Add(">=3");
                cBoxGPAFrom.Items.Add(">=5");
                cBoxGPAFrom.Items.Add(">=6.5");
                cBoxGPAFrom.Items.Add(">=8");
                cBoxGPATo.Items.Add("<=3");
                cBoxGPATo.Items.Add("<=5");
                cBoxGPATo.Items.Add("<=6.5");
                cBoxGPATo.Items.Add("<=8");
                cBoxGPATo.Items.Add("<=10");
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string? strFilter = (string?)cBoxFilter.Text.ToString();
            DataTable dtSearch = new DataTable();
            string? strCheck = txtSearch.Text.ToString();
            if (strFilter == "Mã sinh viên")
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Mã sinh viên] LIKE '%" + strCheck + "%'", con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            if (strFilter == "Tên")
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Tên] LIKE N'%" + strCheck + "%'", con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            if (strFilter == "Số điện thoại")
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Số điện thoại] LIKE '%" + strCheck + "%'", con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            if (strFilter == "Email")
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Email] LIKE '%" + strCheck + "%'", con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            if (strFilter == "Địa chỉ")
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Địa chỉ] LIKE N'%" + strCheck + "%'", con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
        }

        private void cBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string? strFilter = (string?)cBoxFilter.Text.ToString();
            DataTable dtSearch = new DataTable();
            string? strCBoxCheck = cBoxSearch.Text.ToString();
            if (strFilter == "Giới tính")
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Giới tính] = N'" + strCBoxCheck + "'", con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            if (strFilter == "Khoa")
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Khoa] = N'" + strCBoxCheck + "'", con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }

            con.Close();
        }

        public DateTime dateTimeFrom, dateTimeTo;
        private void dateTimePickerBirthFrom_ValueChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dtSearch = new DataTable();
            dateTimeFrom = dateTimePickerBirthFrom.Value;
            dateTimeTo = dateTimePickerBirthTo.Value;
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Ngày sinh] >= '" + dateTimeFrom + "' AND [Ngày sinh] <= '" + dateTimeTo + "'", con);
            daSearch.Fill(dtSearch);
            gridviewdssv.DataSource = dtSearch;
            con.Close();
        }

        private void dateTimePickerBirthTo_ValueChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dtSearch = new DataTable();
            dateTimeTo = dateTimePickerBirthTo.Value;
            dateTimeFrom = dateTimePickerBirthFrom.Value;
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Ngày sinh] >= '" + dateTimeFrom + "' AND [Ngày sinh] <= '" + dateTimeTo + "'", con);
            daSearch.Fill(dtSearch);
            gridviewdssv.DataSource = dtSearch;
            con.Close();
        }

        private void cBoxSearchClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string? strFilter = (string?)cBoxFilter.Text.ToString();
            DataTable dtSearch = new DataTable();
            if (strFilter == "Lớp")
            {
                string? strCBoxCheck = cBoxSearchClass.Text.ToString();

                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Lớp] = '" + strCBoxCheck + "'", con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            con.Close();
        }

        string strGPAFrom = "", strGPATo = "";
        char[] chFrom, chTo;
        private void cBoxGPAFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            chFrom = cBoxGPAFrom.Text.ToString().ToCharArray();
            for (int i = 2; i < chFrom.Length; i++)
            {
                strGPAFrom += chFrom[i];
            }
            DataTable dtSearch = new DataTable();
            if (cBoxGPATo.Text == String.Empty)
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Điểm trung bình] >= " + strGPAFrom, con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            else
            {
                chTo = cBoxGPATo.Text.ToString().ToCharArray();
                for (int i = 2; i < chFrom.Length; i++)
                {
                    strGPATo += chTo[i];
                }
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Điểm trung bình] >= " + strGPAFrom + " AND [Điểm trung bình] <=" + strGPATo, con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            con.Close();
        }

        private void cBoxGPATo_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            chTo = cBoxGPATo.Text.ToString().ToCharArray();
            for (int i = 2; i < chTo.Length; i++)
            {
                strGPATo += chTo[i];
            }
            DataTable dtSearch = new DataTable();
            if (cBoxGPAFrom.Text == String.Empty)
            {
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Điểm trung bình] <= " + strGPATo, con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            else
            {
                chFrom = cBoxGPAFrom.Text.ToString().ToCharArray();
                for (int i = 2; i < chFrom.Length; i++)
                {
                    strGPAFrom += chFrom[i];
                }
                SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM studentview WHERE [Điểm trung bình] >= " + strGPAFrom + " AND [Điểm trung bình] <=" + strGPATo, con);
                daSearch.Fill(dtSearch);
                gridviewdssv.DataSource = dtSearch;
            }
            con.Close();
        }

        private void gridviewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();

            if (e.RowIndex >= 0)
            {
                gridviewClass.CurrentRow.Selected = true;
                txtClassSTT.Text = (e.RowIndex + 1).ToString();
                txtClassID.Text = gridviewClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtClassName.Text = gridviewClass.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtClassMa.Text = gridviewClass.Rows[e.RowIndex].Cells[2].Value.ToString();
                string currentbrand = gridviewClass.Rows[e.RowIndex].Cells["Mã Lớp"].Value.ToString();

                SqlCommand dem = new SqlCommand("select coalesce ((select COUNT(*) from class inner join student on Class.ID = Student.ClassID where ClassName = '" + currentbrand + "' group by ClassName), 0)", con);

                txtNumberSV.Text = dem.ExecuteScalar().ToString();

            }

            con.Close();

        }

        private void btnclassadd_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Thêm mới một lớp";
            label19.Dock = DockStyle.Fill;
            label19.TextAlign = ContentAlignment.MiddleCenter;
            label19.AutoSize = false;
            label19.Font = new Font("Times New Roman", 18, FontStyle.Italic);
        }

        private void btnClassUpdate_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Sửa Dữ liệu lớp";
            label19.Dock = DockStyle.Fill;
            label19.TextAlign = ContentAlignment.MiddleCenter;
            label19.AutoSize = false;
            label19.Font = new Font("Times New Roman", 18, FontStyle.Italic);
        }

        private void btnClassDel_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Xóa đi một lớp. \r\n Lưu ý: chỉ có thể xóa khi lớp không có sinh viên";
            label19.Dock = DockStyle.Fill;
            label19.TextAlign = ContentAlignment.MiddleCenter;
            label19.AutoSize = false;
            label19.Font = new Font("Times New Roman", 18, FontStyle.Italic);
        }

        private void btnClassSave_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Lưu thay đổi";
            label19.Dock = DockStyle.Fill;
            label19.TextAlign = ContentAlignment.MiddleCenter;
            label19.AutoSize = false;
            label19.Font = new Font("Times New Roman", 18, FontStyle.Italic);
        }

        private void btnClassRefresh_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Làm mới dữ liệu";
            label19.Dock = DockStyle.Fill;
            label19.TextAlign = ContentAlignment.MiddleCenter;
            label19.AutoSize = false;
            label19.Font = new Font("Times New Roman", 18, FontStyle.Italic);
        }

        private void btnClassCancel_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Hủy thao tác sửa";
            label19.Dock = DockStyle.Fill;
            label19.TextAlign = ContentAlignment.MiddleCenter;
            label19.AutoSize = false;
            label19.Font = new Font("Times New Roman", 18, FontStyle.Italic);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cBoxFilter.Items.Clear();
            cBoxFilter.Text = string.Empty;
            txtSearch.Clear();
            txtStudentID.Clear();
            txtName.Clear();
            cBoxGender.Items.Clear();
            cBoxSearch.Items.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtBranch.Clear();
            txtGPA.Clear();
            main_Load(sender, e);

        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            foreach (TextBoxBase i in groupBox3.Controls.OfType<TextBoxBase>())
            {
                if (i.Name != "txtNumberSV" && i.Name != "txtClassSTT" && i.Name != "txtClassID")
                {
                    i.ReadOnly = false;
                }
            }
            btnClassSave.Enabled = true;
        }

        private void btnClassSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmdUpdateClass = new SqlCommand();
            cmdUpdateClass.Connection = con;
            string strName = txtClassName.Text.ToString();
            string strBranch = txtClassMa.Text.ToString();
            string strID = txtClassID.Text.ToString();
            cmdUpdateClass.CommandText = "SELECT * FROM [Class] WHERE ID = '" + strID + "'";
            dr = cmdUpdateClass.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "UPDATE [Class] SET ClassName = N'" + strName + "', BranchName = N'" + strBranch + "' WHERE ID = '" + strID + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK);
            }
            con.Close();

            txtClassMa.Text = string.Empty;
            txtClassName.Text = string.Empty;
            txtClassID.Text = string.Empty;
            txtClassSTT.Text = string.Empty;
            main_Load(sender, e);
        }

        private void btnClassRefresh_Click(object sender, EventArgs e)
        {
            txtClassMa.Text = string.Empty;
            txtClassName.Text = string.Empty;
            txtClassID.Text = string.Empty;
            txtClassSTT.Text = string.Empty;
            main_Load(sender, e);
        }

        private void btnClassCancel_Click(object sender, EventArgs e)
        {
            txtClassMa.Text = string.Empty;
            txtClassName.Text = string.Empty;
            txtClassID.Text = string.Empty;
            txtClassSTT.Text = string.Empty;
            main_Load(sender, e);
        }
    }
}