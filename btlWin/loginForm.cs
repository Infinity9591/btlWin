using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using btlWin1;
using System.Text;
using System.IO;

namespace btlWin
{
    public partial class loginForm : Form
    {
        string filename = ("config.txt");
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string s;
        public loginForm()
        {
            InitializeComponent();
            s = File.ReadAllText(filename);
            con = new SqlConnection(s);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetIconPadding(txtUsername, 8);
                errorProvider1.SetError(txtUsername, "Nhập tên đăng nhập đi nào");
                labelError.Text = string.Empty;
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetIconPadding(txtPassword, txtUsername.Width - txtPassword.Width + 8);
                errorProvider1.SetError(txtPassword, "Nhập mật khẩu đi nào");
                labelError.Text = string.Empty;
                txtPassword.Focus();
            }
            else
            {
                errorProvider1.Clear();
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM [User] WHERE Username = '" + txtUsername.Text + "' AND Password_hash='" + txtPassword.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    main main = new main();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    labelError.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                }
                con.Close();
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnhide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnshow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void labelToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm registerForm = new registerForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

    }
}
