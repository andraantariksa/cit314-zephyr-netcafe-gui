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
        private Form m_LoginForm;

        public StaffDashboardForm(string authUsername, string authPassword, Form loginForm)
        {
            AuthUsername = authUsername;
            AuthPassword = authPassword;
            m_LoginForm = loginForm;

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

            LoadShopItems();
            LoadComputerActive();
            LoadComputerItemList();

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
            public string Name { get; set; }
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
                item.Name = (string)row.Cells[1].Value;

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

        private void Logout()
        {
            m_LoginForm.Show();
            Dispose();
        }
        public class Item
        {
            public long ID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public byte IsDeleted { get; set; }
        }

        private async void LoadShopItems()
        {
            try
            {
                var shopItems = await $"{Constant.URL}/api/shop"
                        .GetJsonAsync<List<Item>>();
                DataGridViewShop.Rows.Clear();
                foreach (Item item in shopItems)
                {
                    DataGridViewShop.Rows.Add(item.Name, item.Price);
                }
            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
                Logout();
            }
        }

        public class ComputerUsageAndComputerField
        {
            public long ComputerID;
            public string ComputerName;
            public string ComputerSpec;
            public byte ComputerIsDeleted;
            public long ComputerUsageID;
            public long ComputerUsageUserID;
            public long ComputerUsageComputerID;
            public DateTime ComputerUsageEndDateTime;
            public DateTime ComputerUsageStartDateTime;
        }

        public class ComputerListField
        {
            public long ID;
            public string Name;
            public string Spec;
            public byte IsDeleted;
        }
        public async void LoadComputerActive()
        {
            try
            {
                var computerusage = await $"{Constant.URL}/api/computerusage/now"
                    .GetJsonAsync<List<ComputerUsageAndComputerField>>();
                DataGridViewComputerActive.Rows.Clear();
                foreach (ComputerUsageAndComputerField comp in computerusage)
                {
                    DataGridViewComputerActive.Rows.Add(
                        comp.ComputerID,
                        comp.ComputerName,
                        comp.ComputerSpec,
                        comp.ComputerIsDeleted,
                        comp.ComputerUsageID,
                        comp.ComputerUsageUserID,
                        comp.ComputerUsageComputerID,
                        comp.ComputerUsageEndDateTime,
                        comp.ComputerUsageStartDateTime
                    );
                }
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public async void LoadComputerItemList()
        {
            try
            {
                var computerlist = await $"{Constant.URL}/api/computer"
                    .GetJsonAsync<List<ComputerListField>>();

                DataGridViewComputerItemList.Rows.Clear();
                foreach (ComputerListField comp in computerlist)
                {
                    DataGridViewComputerItemList.Rows.Add(
                        comp.ID,
                        comp.Name,
                        comp.Spec
                    );
                }
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void StaffDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }
    }
}
