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

        public class DurationAdded
        {
            public int OldDuration { get; set; }
            public int NewDuration { get; set; }
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
                var result = await $"{Constant.URL}/api/user/durationadd"
                    .PostJsonAsync(new
                    {
                        UserUsername = userUsername,
                        AddedDuration = addedDuration,
                        AuthUsername,
                        AuthPassword
                    })
                    .ReceiveJson<DurationAdded>();
                MessageBox.Show($"Successfully added duration from {result.OldDuration} to {result.NewDuration}");
            }
            catch (FlurlHttpException ex)
            {
                var errorResp = await ex.Call.Response.ResponseMessage.Content.ReadAsStringAsync();
                MessageBox.Show($"{ex.Message}\n{errorResp}");
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

        public class TransactionItem
        {
            public long ID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public byte IsDeleted { get; set; }
        }

        class ComboBoxItemTransactionItem
        {
            public long ItemID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private async void StaffDashboardForm_Load(object sender, EventArgs e)
        {
            ComboBoxTransactionItemList.Enabled = false;

            try
            {
                var result = await $"{Constant.URL}/api/shop"
                    .GetJsonAsync<List<TransactionItem>>();
                foreach (TransactionItem item in result)
                {
                    var comboBoxItem = new ComboBoxItemTransactionItem();
                    comboBoxItem.ItemID = item.ID;
                    comboBoxItem.Name = item.Name;
                    comboBoxItem.Price = item.Price;
                    ComboBoxTransactionItemList.Items.Add(comboBoxItem);
                }
            }
            catch (FlurlHttpException ex)
            {
                var errorResp = await ex.Call.Response.ResponseMessage.Content.ReadAsStringAsync();
                MessageBox.Show($"{ex.Message}\n{errorResp}");
            }

            ComboBoxTransactionItemList.Enabled = true;
        }

        private void ButtonTransactionAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                var quantity = Int32.Parse(TextBoxTransactionQuantity.Text);

                var selectedItem = ((ComboBoxItemTransactionItem)ComboBoxTransactionItemList.SelectedItem);
                if (selectedItem == null)
                {
                    return;
                }
                
                foreach (DataGridViewRow row in DataGridViewCart.Rows)
                {
                    if (row.Cells[0].Value.Equals(selectedItem.ItemID))
                    {
                        if (quantity == 0)
                        {
                            DataGridViewCart.Rows.RemoveAt(row.Index);
                            return;
                        }
                        row.Cells[2].Value = (int)quantity;
                        row.Cells[4].Value = (int)(quantity * selectedItem.Price);
                        return;
                    }
                }
                DataGridViewCart.Rows.Add(selectedItem.ItemID, selectedItem.Name, quantity, selectedItem.Price, quantity * selectedItem.Price);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class TransactionItemAdd
        {
            public long ItemID { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
        };

        public class TransactionAddField
        {
            public string UserUsername { get; set; }
            public List<TransactionItemAdd> Items { get; set; }
            public string AuthUsername { get; set; }
            public string AuthPassword { get; set; }
        }

        private async void ButtonTransactionCheckout_Click(object sender, EventArgs e)
        {
            var itemPurchase = new List<TransactionItemAdd>();
            foreach (DataGridViewRow row in DataGridViewCart.Rows)
            {
                var item = new TransactionItemAdd();
                item.ItemID = (long)row.Cells[0].Value;
                item.Price = (int)row.Cells[3].Value;
                item.Quantity = (int)row.Cells[2].Value;

                itemPurchase.Add(item);
            }

            var transaction = new TransactionAddField();
            transaction.UserUsername = TextBoxTransactionUserUsername.Text;
            transaction.Items = itemPurchase;
            transaction.AuthUsername = AuthUsername;
            transaction.AuthPassword = AuthPassword;

            try
            {
                var result = await $"{Constant.URL}/api/transaction"
                    .PostJsonAsync(transaction);
            }
            catch (FlurlHttpException ex)
            {
                var errorResp = await ex.Call.Response.GetStringAsync();
                MessageBox.Show($"{ex.Message}\n{errorResp}");
            }

            DataGridViewCart.Rows.Clear();
            MessageBox.Show("Transaction success");
        }
    }
}
