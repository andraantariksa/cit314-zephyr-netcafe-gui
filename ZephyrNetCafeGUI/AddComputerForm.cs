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
    public partial class AddComputerForm : Form
    {
        private AdminDashboardForm DashboardForm;
        private string AuthUsername;
        private string AuthPassword;

        public AddComputerForm(string authUsername, string authPassword, AdminDashboardForm dashboardForm)
        {
            InitializeComponent();

            AuthUsername = authUsername;
            AuthPassword = authPassword;
            DashboardForm = dashboardForm;
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            try
            {
                var response = await $"{Constant.URL}/api/computer"
                    .PostJsonAsync(new
                    {
                        Name = TextBoxComputerName.Text,
                        Spec = RichTextBoxComputerSpec.Text,
                        AuthUsername = this.AuthUsername,
                        AuthPassword = this.AuthPassword
                    });
                MessageBox.Show("Succesfully added the computer to database!");
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }

            TextBoxComputerName.Text = "";
            RichTextBoxComputerSpec.Text = "";

            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            OnClose();
        }

        private void OnClose()
        {
            DashboardForm.LoadComputerActive();
            DashboardForm.LoadComputerItemList();
            DashboardForm.Show();
            Hide();
            Dispose();
        }

        private void AddComputerForm_Load(object sender, EventArgs e)
        {

        }

        private void AddComputerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClose();
        }
    }
}
