using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Flurl.Http;
using System.Windows.Forms;

namespace ZephyrNetCafeGUI
{
    public partial class AdminDashboardForm : Form
    {
        private string AuthUsername;
        private string AuthPassword;
        private Form m_LoginForm;

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

        public class ShopItemListField
        {
            public long ID;
            public string Name;
            public int Price;
            public int Quantity;
            public byte IsDeleted;
        }
        public class UserListField
        {
            public long ID;
            public string Username;
            public string Name;
            public string Email;
            public string Password;
            public int Duration;
            public byte Role;
        }
        string[] Roles = {"Admin", "Staff", "User"};
        public List<Tuple<Transaction, List<TransactionItem>>> m_TransactionTuples { get; private set; }

        public AdminDashboardForm(string authUsername, string authPassword, Form loginForm)
        {
            AuthUsername = authUsername;
            AuthPassword = authPassword;
            m_LoginForm = loginForm;

            InitializeComponent();

            LabelWelcomeAdmin.Text = $"Welcome, Staff {AuthUsername}!";
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadComputerActive();
            LoadComputerItemList();
            LoadUserList();
            LoadShopItemList();
            LoadTransactionList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        public async void LoadShopItemList()
        {
            try
            {
                var shopitemlist = await $"{Constant.URL}/api/shop"
                    .GetJsonAsync<List<ShopItemListField>>();

                DataGridViewShopItem.Rows.Clear();
                foreach (ShopItemListField shop in shopitemlist)
                {
                    DataGridViewShopItem.Rows.Add(
                        shop.ID,
                        shop.Name,
                        shop.Price,
                        shop.Quantity
                    );
                }
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public async void LoadUserList()
        {
            try
            {
                var userlist = await $"{Constant.URL}/api/user"
                    .GetJsonAsync<List<UserListField>>();

                DataGridViewUserList.Rows.Clear();
                foreach (UserListField user in userlist)
                {
                    DataGridViewUserList.Rows.Add(
                        user.ID,
                        user.Username,
                        user.Name,
                        user.Email,
                        user.Duration,
                        Roles[user.Role],
                        user.Password
                    );
                }
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void TimerControlComputerActive_Tick(object sender, EventArgs e)
        {
            try
            {
                LoadComputerActive();
                LoadComputerItemList();
                LoadUserList();
                LoadShopItemList();
                LoadTransactionList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                TimerControlComputerActive.Stop();
            }
        }

        private void ButtonAddComputer_Click(object sender, EventArgs e)
        {
            Hide();
            var addComputerForm = new AddComputerForm(AuthUsername, AuthPassword, this);
            addComputerForm.Show();
        }

        private void AdminDashboardForm_EnabledChanged(object sender, EventArgs e)
        {
            try
            {
                if (Enabled == false)
                {
                    TimerControlComputerActive.Stop();
                }
                else
                {
                    TimerControlComputerActive.Start();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void ButtonDeleteComputer_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            try
            {
                if (DataGridViewComputerItemList.SelectedRows.Count > 0)
                {

                    long s_ComputerID = (long)DataGridViewComputerItemList.SelectedRows[0].Cells[0].Value;
                    var response = await $"{Constant.URL}/api/computer"
                        .SendJsonAsync(System.Net.Http.HttpMethod.Delete, new
                        {
                            ComputerID = s_ComputerID,
                            AuthUsername = this.AuthUsername,
                            AuthPassword = this.AuthPassword
                        });
                    LoadComputerItemList();
                }
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
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

        private void ButtonAddShopItem_Click(object sender, EventArgs e)
        {
            Hide();
            AddShopItemForm AddDialog = new AddShopItemForm(AuthUsername, AuthPassword, this);
            AddDialog.Show();
        }

        private void ButtonEditShopItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewShopItem.SelectedRows.Count > 0)
            {
                long s_ProductID = (long)DataGridViewShopItem.SelectedRows[0].Cells[0].Value;
                string name = (string)DataGridViewShopItem.SelectedRows[0].Cells[1].Value;
                int price = (int)DataGridViewShopItem.SelectedRows[0].Cells[2].Value;
                EditShopItemForm EditDialog = new EditShopItemForm(AuthUsername, AuthPassword, s_ProductID, this, name, price);
                EditDialog.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Not selected!");
            }
        }

        private async void ButtonDeleteShopItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            try
            {
                if (DataGridViewComputerItemList.SelectedRows.Count > 0)
                {

                    long s_ProductID = (long)DataGridViewShopItem.SelectedRows[0].Cells[0].Value;
                    var response = await $"{Constant.URL}/api/shop"
                        .SendJsonAsync(System.Net.Http.HttpMethod.Delete, new
                        {
                            ProductID = s_ProductID,
                            AuthUsername,
                            AuthPassword
                        });
                    LoadShopItemList();
                }
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

        private void Logout()
        {
            m_LoginForm.Show();
            Dispose();
        }

        private void AdminDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }
        private void ButtonEditUser_Click(object sender, EventArgs e)
        {
            if (DataGridViewUserList.SelectedRows.Count > 0)
            {
                long s_UserID = (long)DataGridViewUserList.SelectedRows[0].Cells[0].Value;
                string name = (string)DataGridViewUserList.SelectedRows[0].Cells[2].Value;
                string email = (string)DataGridViewUserList.SelectedRows[0].Cells[3].Value;
                string role = (string)DataGridViewUserList.SelectedRows[0].Cells[5].Value;
                string password = (string)DataGridViewUserList.SelectedRows[0].Cells[6].Value;
                EditUserForm EditDialog = new EditUserForm(AuthUsername, AuthPassword, s_UserID, this, name, email, role, password);
                EditDialog.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Not selected!");
            }
        }

        private async void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            try
            {
                if (DataGridViewComputerItemList.SelectedRows.Count > 0)
                {
                    long s_UserID = (long)DataGridViewUserList.SelectedRows[0].Cells[0].Value;
                    var response = await $"{Constant.URL}/api/user"
                        .SendJsonAsync(System.Net.Http.HttpMethod.Delete, new
                        {
                            UserID = s_UserID,
                            AuthUsername,
                            AuthPassword
                        });
                    LoadUserList();
                }
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

        public class Transaction
        {
            public long ID { set; get; }
            public long UserID { set; get; }
            public DateTime CreatedAt { set; get; }
        }

        public class TransactionItem
        {
            public long ID { get; set; }
            public long TransactionID { get; set; }
            public string Name { get; set; }
            public long ItemID { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
        }

        private async void LoadTransactionList()
        {
            try
            {
                m_TransactionTuples = await $"{Constant.URL}/api/transaction"
                    .GetJsonAsync<List<Tuple<Transaction, List<TransactionItem>>>>();
                foreach (Tuple<Transaction, List<TransactionItem>> transactionTuple in m_TransactionTuples)
                {
                    DataGridViewTransactions.Rows.Add(transactionTuple.Item1.ID, transactionTuple.Item1.CreatedAt);
                }
            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
                Logout();
            }
        }

        private void DataGridViewTransactions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedRow = DataGridViewTransactions.SelectedRows[0];
            var selectedRowIdx = selectedRow.Index;

            DataGridViewTransactionItems.Rows.Clear();

            var transactionItems = m_TransactionTuples[selectedRowIdx].Item2;
            foreach (TransactionItem transactionItem in transactionItems)
            {
                DataGridViewTransactionItems.Rows.Add(transactionItem.ID, transactionItem.Name, transactionItem.Price, transactionItem.Quantity, transactionItem.Price * transactionItem.Quantity);
            }
        }
    }
}
