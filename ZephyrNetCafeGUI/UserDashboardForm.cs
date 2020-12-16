using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZephyrNetCafeGUI
{

    public partial class UserDashboardForm : Form
    {
        public int m_Duration;
        public string m_Username { get; private set; }
        public string m_Password { get; private set; }
        private long m_UserID { get; set; }
        public long m_UsageID { get; private set; }
        public long m_PCID { get; private set; }
        public List<Tuple<Transaction, List<TransactionItem>>> m_TransactionTuples { get; private set; }
        public Form m_LoginForm { get; private set; }

        public UserDashboardForm(string username, string password, long pcid, Form loginForm)
        {
            InitializeComponent();

            m_Username = username;
            m_Password = password;
            m_PCID = pcid;
            m_LoginForm = loginForm;
        }

        public class ComputerUsageField
        {
            public long ComputerUsageID { set; get; }
        }

        public class UserDataField
        {
            public string Username { set; get; }
            public long ID { set; get; }
            public int Duration { set; get; }
        }

        public class UserEditField
        {
            public long UserID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public byte Role { get; set; }
            public string AuthUsername { get; set; }
            public string AuthPassword { get; set; }
        }

        public class Item
        {
            public long ID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public byte IsDeleted { get; set; }
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                var user = await $"{Constant.URL}/api/user/single/{m_Username}"
                    .GetJsonAsync<UserDataField>();
                if (user != null)
                {
                    m_UserID = user.ID;
                    if (user.Duration == 0)
                    {
                        Logout();
                    }
                    m_Duration = user.Duration;
                }
                var response = await $"{Constant.URL}/api/computerusage"
                    .PostJsonAsync(new
                    {
                        UserID = user.ID,
                        ComputerID = m_PCID
                    })
                    .ReceiveJson<ComputerUsageField>();
                m_UsageID = response.ComputerUsageID;

                LabelWelcomeUser.Text = $"Welcome, user {m_Username}";
                LabelDuration.Text = $":{m_Duration}";

                LoadUserTransaction();
                LoadShopItems();
            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
                Logout();
            }
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

        private async void LoadUserTransaction()
        {
            try
            {
                m_TransactionTuples = await $"{Constant.URL}/api/transaction/{m_Username}"
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

        private void Logout()
        {
            m_LoginForm.Show();
            Dispose();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }

        private async void TimerControlDuration_Tick(object sender, EventArgs e)
        {
            try
            {
                var dur = await $"{Constant.URL}/api/user/durationreduce"
                    .PostJsonAsync(new
                    {
                        ReducedDuration = 1,
                        AuthUsername = m_Username,
                        AuthPassword = m_Password
                    });
                var usage = await $"{Constant.URL}/api/computerusage"
                    .PutJsonAsync(new
                    {
                        ComputerUsageID = m_UsageID
                    });
            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
                Logout();
            }

            m_Duration -= 1;
            LabelDuration.Text = $":{m_Duration}";
            if (m_Duration == 0)
            {
                TimerControlDuration.Stop();
                Logout();
            }
        }

        private void DataGridViewTransactions_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
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
