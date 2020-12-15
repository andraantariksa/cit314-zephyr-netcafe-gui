using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;

namespace ZephyrNetCafeGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            var userUsername = TextBoxUsername.Text;
            var userPassword = TextBoxPassword.Text;

            var result = await $"{Constant.URL}/api/user/auth"
                .AllowAnyHttpStatus()
                .PostJsonAsync(new
                {
                    Username = userUsername,
                    Password = userPassword
                });
            switch (result.StatusCode)
            {
                case 403:
                    MessageBox.Show("Username or password does not match");
                    break;
                case 200:
                    var dashboardForm = new DashboardForm(userUsername, userPassword);
                    dashboardForm.Show();
                    Hide();

                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }

            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
