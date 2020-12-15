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
    public partial class AddComputerDialog : UserControl
    {
        public AdminDashboardForm AdminForm { set; get; }
        private string AuthUsername { set; get; }
        private string AuthPassword { set; get; }
        public AddComputerDialog(string authname, string authpass)
        {
            AuthPassword = authname;
            AuthPassword = authpass;
            InitializeComponent();
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                control.Enabled = false;
            }
            try
            {
                var response = await $"{Constant.URL}/api/"
                    .PostJsonAsync(new
                    {
                        Name = TextBoxComputerName.Text,
                        Spec = RichTextBoxComputerSpec.Text,
                        AuthUsername = this.AuthUsername,
                        AuthPassword = this.AuthPassword
                    });
                if (response.StatusCode == 200)
                {
                    MessageBox.Show("Succesfully added in Database!");
                }
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            try
            {
                AdminForm.Enabled = true;
                AdminForm.UpdateComputerActive();
                AdminForm.UpdateComputerItemList();
                this.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}
