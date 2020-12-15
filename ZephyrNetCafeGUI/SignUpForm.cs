using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZephyrNetCafeGUI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private async void ButtonSignup_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            var userName = TextBoxName.Text;
            var userEmail = TextBoxEmail.Text;
            var userUsername = TextBoxUsername.Text;
            var userPassword = TextBoxPassword.Text;

            var result = await $"{Constant.URL}/api/user/auth"
                .AllowAnyHttpStatus()
                .PostJsonAsync(new
                {
                    Name = userName,
                    Email = userEmail,
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
    }
}
