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
    public partial class StaffDashboardForm : Form
    {
        private string AuthUsername;
        private string AuthPassword;

        public StaffDashboardForm(string authUsername, string authPassword)
        {
            AuthUsername = authUsername;
            AuthPassword = authPassword;

            InitializeComponent();

            LabelWelcomeStaff.Text = $"Welcome, Staff {AuthUsername}!";
        }

        private async void ButtonAddDuration_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            try
            {
                var addedDuration = Int64.Parse(TextBoxMinutes.Text);
                var userUsername = TextBoxUserUsername.Text;
                var result = await $"{Constant.URL}/api/user/auth"
                    .PostJsonAsync(new
                    {
                        UserUsername = userUsername,
                        AddedDuration = addedDuration,
                        AuthUsername,
                        AuthPassword
                    });
            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
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
