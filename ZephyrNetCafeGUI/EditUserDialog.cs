using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using Flurl.Http;
using System.Windows.Forms;

namespace ZephyrNetCafeGUI
{
    public partial class EditUserDialog : UserControl
    {
        public AdminDashboardForm AdminForm { set; get; }
        private string AuthUsername { set; get; }
        private string AuthPassword { set; get; }
        private long UserID { set; get; }
        public EditUserDialog(string authname, string authpass, long userid, string name, string email, string role)
        {
            AuthPassword = authname;
            AuthPassword = authpass;
            UserID = userid;
            TextBoxName.Text = $"{name}";
            TextBoxEmail.Text = $"{email}";
            ComboBoxRole.Text = $"{role}";
            InitializeComponent();
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonSave.Enabled = false;
                var response = await $"{Constant.URL}/api/user"
                    .PutJsonAsync(new
                    {
                        UserID = this.UserID,
                        Name = TextBoxName.Text,
                        Email = TextBoxEmail.Text,
                        Role = (byte)ComboBoxRole.SelectedIndex,
                        AuthUsername = this.AuthUsername,
                        AuthPassword = this.AuthPassword
                    });
                if (response.StatusCode == 200)
                {
                    MessageBox.Show("Successfully edit!");
                }
            }
            catch (FlurlHttpException exc)
            {
                ButtonSave.Enabled = true;
                MessageBox.Show(exc.Message);
            }
        }

        private void ComboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = true;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = true;
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            try
            {
                AdminForm.Enabled = true;
                AdminForm.UpdateUserList();
                this.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
