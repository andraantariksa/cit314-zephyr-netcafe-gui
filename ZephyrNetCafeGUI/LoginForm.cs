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
            ButtonLogin.Enabled = false;

            var result = await $"{Constant.URL}/api/user/auth"
                .AllowAnyHttpStatus()
                .PostJsonAsync(new
                {
                    Username = TextBoxUsername.Text,
                    Password = TextBoxPassword.Text
                });
            switch (result.StatusCode)
            {
                case 403:
                    MessageBox.Show("Username or password does not match");
                    break;
                case 200:
                    var dashboardForm = new DashboardForm();
                    dashboardForm.Show();
                    Hide();

                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }

            ButtonLogin.Enabled = true;
        }
    }
}
