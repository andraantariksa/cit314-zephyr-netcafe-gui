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
    public partial class EditUserForm : Form
    {
        private AdminDashboardForm AdminDashboardForm;
        private string AuthUsername;
        private string AuthPassword;
        private long UserID;

        public EditUserForm(string authUsername, string authPassword, long userID, AdminDashboardForm adminDashboardForm, string name, string email, string role, string password)
        {
            InitializeComponent();

            UserID = userID;
            AuthUsername = authUsername;
            AuthPassword = authPassword;
            AdminDashboardForm = adminDashboardForm;
            TextBoxName.Text = name;
            TextBoxEmail.Text = email;
            TextBoxPassword.Text = password;
            ComboBoxRole.Text = role;
        }

        private void OnClose()
        {
            AdminDashboardForm.LoadUserList();
            AdminDashboardForm.Show();
            Hide();
            Dispose();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            OnClose();
        }

        private void EditUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClose();
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            try
            {
                var response = await $"{Constant.URL}/api/user"
                    .PutJsonAsync(new
                    {
                        UserID,
                        Name = TextBoxName.Text,
                        Email = TextBoxEmail.Text,
                        Role = (byte)ComboBoxRole.SelectedIndex,
                        Password = TextBoxPassword.Text,
                        AuthUsername,
                        AuthPassword
                    });
                MessageBox.Show("Successfully edit!");
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }

            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
        }
    }
}
