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

namespace btlWin
{
    public partial class registerForm : Form
    {
        string filename = "config.txt";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public registerForm()
        {
            InitializeComponent();
            string s = File.ReadAllText(filename);
            con = new SqlConnection(s);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm loginForm = new loginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(txtUsername, "Nhập tên đăng nhập đi nào");
                txtError.Text = string.Empty;
            }
            else if (txtPassword.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetIconPadding(txtPassword, txtUsername.Width - txtPassword.Width + 8);
                errorProvider1.SetError(txtPassword, "Nhập mật khẩu đi nào");
                txtError.Text = string.Empty;

            }
            else if (txtPassword.Text.Length < 6)
            {
                errorProvider1.Clear();
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetIconPadding(txtPassword, txtUsername.Width - txtPassword.Width + 8);
                errorProvider1.SetError(txtPassword, "Mật khẩu không nhỏ hơn 6 kí tự");
                txtError.Text = string.Empty;

            }
            else if (txtRepeatPassword.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetIconPadding(txtRepeatPassword, txtUsername.Width - txtPassword.Width + 8);
                errorProvider1.SetError(txtRepeatPassword, "Nhập mật khẩu đi nào");
                txtError.Text = string.Empty;

            }
            else if (txtPassword.Text != txtRepeatPassword.Text)
            {
                errorProvider1.Clear();
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetIconPadding(txtRepeatPassword, txtUsername.Width - txtPassword.Width + 8);
                errorProvider1.SetError(txtRepeatPassword, "Mật khẩu nhập lại không đúng");
                txtError.Text = string.Empty;

            }
            else
            {
                errorProvider1.Clear();
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM [User] WHERE Username = '" + txtUsername.Text + "'";

                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "SELECT COUNT(ID) FROM [User]";
                Int32 count = (Int32)comm.ExecuteScalar();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    txtError.Text = "Tên đăng nhập đã tồn tại";
                }
                else
                {
                    dr.Close();
                    SqlCommand command = new SqlCommand();
                    command.Connection = con;
                    command.CommandText = "INSERT INTO [User] VALUES (@ID, @Username, @Password_hash)";
                    command.Parameters.AddWithValue("ID", count + 1);
                    command.Parameters.AddWithValue("Username", txtUsername.Text);
                    command.Parameters.AddWithValue("Password_hash", txtPassword.Text);
                    command.ExecuteNonQuery();
                    var rs = MessageBox.Show("Đăng kí thành công!", "Success", MessageBoxButtons.OK);
                    if (rs == DialogResult.OK)
                    {
                        this.Visible = false;
                        loginForm loginForm = new loginForm();
                        loginForm.ShowDialog();
                    }
                }
                con.Close();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            txtRepeatPassword.PasswordChar = '*';
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnShowRePass_Click(object sender, EventArgs e)
        {
            if (txtRepeatPassword.PasswordChar == '*')
            {
                btnHideRePass.BringToFront();
                txtRepeatPassword.PasswordChar = '\0';
            }
        }

        private void btnHideRePass_Click(object sender, EventArgs e)
        {
            if (txtRepeatPassword.PasswordChar == '\0')
            {
                btnShowRePass.BringToFront();
                txtRepeatPassword.PasswordChar = '*';
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
