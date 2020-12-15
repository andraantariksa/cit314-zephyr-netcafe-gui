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

            try
            {
                var result = await $"{Constant.URL}/api/user"
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
                    case 200:
                        MessageBox.Show("Signup success!");
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
        }
    }
}
