using System;
using Flurl.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ZephyrNetCafeGUI
{
    public partial class EditShopItemDialog : UserControl
    {
        public AdminDashboardForm AdminForm { set; get; }
        private string AuthUsername { set; get; }
        private string AuthPassword { set; get; }
        private long ProductID { set; get; }
        public EditShopItemDialog(string authname, string authpass, long productid, string prodname, int price)
        {
            AuthPassword = authname;
            AuthPassword = authpass;
            ProductID = productid;
            TextBoxName.Text = $"{prodname}";
            NumericPrice.Value = (int)price;
            InitializeComponent();
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await $"{Constant.URL}/api/shop"
                    .PutJsonAsync(new 
                    {
                        ProductID = this.ProductID,
                        Name = TextBoxName.Text,
                        Price = (int)NumericPrice.Value,
                        AuthUsername = this.AuthUsername,
                        AuthPassword = this.AuthPassword
                    });
                ButtonSave.Enabled = false;
                if (response.StatusCode == 200)
                {
                    MessageBox.Show("Successfully edit!");
                }
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = true;
        }

        private void NumericPrice_ValueChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            try
            {
                AdminForm.Enabled = true;
                AdminForm.UpdateShopItemList();
                this.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
