using System.Data;
using System.Data.SqlClient;

namespace btlWin1
{
    public partial class add : Form
    {
        string filename = "config.txt";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public add()
        {
            InitializeComponent();
            string s = File.ReadAllText(filename);
            con = new SqlConnection(s);
        }

        private void add_Load(object sender, EventArgs e)
        {
            DataTable dtClass = new DataTable();
            try
            {
                SqlDataAdapter daClass = new SqlDataAdapter("select * from Class", con);
                daClass.Fill(dtClass);
                cBoxClass.DisplayMember = "ClassName";
                cBoxClass.ValueMember = "Class";
                cBoxClass.DataSource = dtClass;
            }
            catch
            {

            }
            dateTimePickerBirth.CustomFormat = "dd/MM/yyyy";
            dateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirth.Text = string.Empty;
            cBoxGender.Items.Add("Nam");
            cBoxGender.Items.Add("Nữ");
            cBoxGender.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();

            con.Open();
            cmd.Connection = con;
            string? strMSV = txtStudentID.Text;
            string? strName = txtName.Text;
            string? strPhone = txtPhone.Text;
            string? strGender = cBoxGender.SelectedItem.ToString();
            DateTime dateTime = dateTimePickerBirth.Value;
            string? strEmail = txtEmail.Text;
            string? strAddress = txtAddress.Text;
            int? idClass = (cBoxClass.SelectedIndex + 1);
            string strGPA = (txtGPA.Text);
            if (strMSV == "" || strName == "" || strPhone == "" || strGender == "" || strGPA == "" || strEmail == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin sinh viên");
            } 
            else
            {
                cmd.CommandText = "SELECT * FROM [Student] WHERE ID = '" + strMSV + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    labelError.Text = "Mã sinh viên đã tồn tại";
                }
                else
                {
                    dr.Close();
                    SqlCommand command = new SqlCommand();
                    command.Connection = con;
                    command.CommandText = "INSERT INTO [Student] VALUES (@ID, @Name, @Sex, @Birth, @Phone, @Email, @Address, @GPA, @ClassID)";
                    command.Parameters.AddWithValue("ID", strMSV);
                    command.Parameters.AddWithValue("Name", strName);
                    command.Parameters.AddWithValue("Sex", strGender);
                    command.Parameters.AddWithValue("Birth", dateTime);
                    command.Parameters.AddWithValue("Phone", strPhone);
                    command.Parameters.AddWithValue("Email", strEmail);
                    command.Parameters.AddWithValue("Address", strAddress);
                    command.Parameters.AddWithValue("GPA", strGPA);
                    command.Parameters.AddWithValue("ClassID", idClass);
                    command.ExecuteNonQuery();
                    var rs = MessageBox.Show("Thêm sinh viên thành công!", "Success", MessageBoxButtons.OK);
                    if (rs == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            
            con.Close();
            
        }

        private void cBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strClass = cBoxClass.Text.ToString();
            char[] ch = strClass.ToCharArray();

            string? strCheck = "";
            if (strClass.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    strCheck += ch[i];
                }
            }
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
    }
}
