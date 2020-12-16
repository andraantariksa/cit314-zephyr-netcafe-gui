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
    public partial class AddShopItemForm : Form
    {
        public AddShopItemForm(string authUsername, string authPassword, AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();

            AuthUsername = authUsername;
            AuthPassword = authPassword;
            AdminDashboardForm = adminDashboardForm;
        }

        private AdminDashboardForm AdminDashboardForm;
        private string AuthUsername;
        private string AuthPassword;

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }
            try
            {
                var response = await $"{Constant.URL}/api/shop"
                    .PostJsonAsync(new
                    {
                        Name = TextBoxName.Text,
                        Price = (int)NumericPrice.Value,
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
            OnClose();
        }

        private void OnClose()
        {
            AdminDashboardForm.LoadComputerActive();
            AdminDashboardForm.LoadComputerItemList();
            AdminDashboardForm.Show();
            Hide();
            Dispose();
        }

        private void AddShopItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClose();
        }
    }
}
