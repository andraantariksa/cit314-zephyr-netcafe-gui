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
    public partial class EditShopItemForm : Form
    {
        private AdminDashboardForm AdminDashboardForm;
        private string AuthUsername;
        private string AuthPassword;
        private long ProductID;

        public EditShopItemForm(string authUsername, string authPassword, long productID, AdminDashboardForm adminDashboardForm, string name, int price)
        {
            InitializeComponent();

            TextBoxName.Text = name;
            NumericPrice.Value = price;
            AuthUsername = authUsername;
            AuthPassword = authPassword;
            AdminDashboardForm = adminDashboardForm;
            ProductID = productID;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            OnClose();
        }

        private void OnClose()
        {
            AdminDashboardForm.LoadShopItemList();
            AdminDashboardForm.Show();
            Hide();
            Dispose();
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            try
            {
                var response = await $"{Constant.URL}/api/shop"
                    .PutJsonAsync(new
                    {
                        ProductID,
                        Name = TextBoxName.Text,
                        Price = (int)NumericPrice.Value,
                        AuthUsername = this.AuthUsername,
                        AuthPassword = this.AuthPassword
                    });
                MessageBox.Show("Edit success");
                TextBoxName.Text = "";
                NumericPrice.Value = 100;
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

        private void EditShopItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClose();
        }
    }
}
