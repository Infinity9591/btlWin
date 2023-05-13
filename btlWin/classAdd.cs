using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlWin1
{
    public partial class classAdd : Form
    {
        string filename = "config.txt";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public classAdd()
        {
            InitializeComponent();
            string s = File.ReadAllText(filename);
            con = new SqlConnection(s);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string? strMa = txtClassMa.Text;
            string? strName = txtClassName.Text;
            SqlCommand cmdCount = new SqlCommand();
            cmdCount.Connection = con;
            cmdCount.CommandText = "SELECT MAX(ID) FROM [Class]";
            Int32 count = (Int32)cmdCount.ExecuteScalar();
            if (strName == "" || strMa == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin lớp");
            }
            else
            {
                cmd.CommandText = "SELECT * FROM [Class] WHERE ClassName = '" + strName + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    labelError.Text = "Mã lớp đã tồn tại";
                }
                else
                {
                    dr.Close();
                    SqlCommand command = new SqlCommand();
                    command.Connection = con;
                    command.CommandText = "INSERT INTO [Class] VALUES (@ID, @ClassName, @BranchName)";
                    command.Parameters.AddWithValue("ID", count + 1);
                    command.Parameters.AddWithValue("ClassName", strName);
                    command.Parameters.AddWithValue("BranchName", strMa);
                    command.ExecuteNonQuery();
                    var rs = MessageBox.Show("Thêm lớp thành công!", "Success", MessageBoxButtons.OK);
                    if (rs == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            con.Close();
        }

        private void classAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            string? strName = txtClassName.Text;
            char[] ch = strName.ToCharArray();
            string check = "";
            if (strName.Length > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    check += ch[i];
                }
            }
            if (strName.Length > 3)
            {
                if (check == "CNT")
                {
                    txtClassMa.Text = "Công Nghệ Thông Tin";
                }
                if (check == "KPM")
                {
                    txtClassMa.Text = "Công Nghệ Phần Mềm";
                }
                if (check == "TTM")
                {
                    txtClassMa.Text = "Truyền thông & Mạng máy tính";
                }
            }
        }
    }
}
