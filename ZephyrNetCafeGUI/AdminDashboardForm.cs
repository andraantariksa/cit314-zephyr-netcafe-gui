﻿using System;
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
            UpdateComputerActive();
            UpdateComputerItemList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public async void UpdateComputerActive()
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

        public async void UpdateComputerItemList()
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
                        comp.Spec,
                        comp.IsDeleted
                    );
                }
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public async void UpdateShopItemList()
        {
            try
            {
                var shopitemlist = await $"{Constant.URL}/api/shop"
                    .GetJsonAsync<List<ShopItemListField>>();

                DataGridViewShopItem.Rows.Clear();
                foreach (ShopItemListField shop in shopitemlist)
                {
                    DataGridViewComputerItemList.Rows.Add(
                        shop.ID,
                        shop.Name,
                        shop.Price,
                        shop.Quantity,
                        shop.IsDeleted
                    );
                }
            }
            catch (FlurlHttpException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public async void UpdateUserList()
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
                        Roles[user.Role]
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
                UpdateComputerActive();
                UpdateComputerItemList();
                UpdateShopItemList();
                UpdateUserList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                TimerControlComputerActive.Stop();
            }
        }

        private void ButtonAddComputer_Click(object sender, EventArgs e)
        {
            AddComputerDialog AddDialog = new AddComputerDialog(AuthUsername, AuthPassword);
            AddDialog.AdminForm = this;
            Enabled = false;
            AddDialog.Show();
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
            foreach (Control control in TabPageComputer.Controls)
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

            foreach (Control control in TabPageComputer.Controls)
            {
                control.Enabled = true;
            }
        }

        private void ButtonAddShopItem_Click(object sender, EventArgs e)
        {
            AddShopItemDialog AddDialog = new AddShopItemDialog(AuthUsername, AuthPassword);
            AddDialog.AdminForm = this;
            Enabled = false;
            AddDialog.Show();
        }

        private void ButtonEditShopItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewShopItem.SelectedRows.Count > 0)
            {
                long s_ProductID = (long)DataGridViewShopItem.SelectedRows[0].Cells[0].Value;
                string name = DataGridViewShopItem.SelectedRows[0].Cells[1].Value.ToString();
                int price = (int)DataGridViewShopItem.SelectedRows[0].Cells[2].Value;
                EditShopItemDialog EditDialog = new EditShopItemDialog(AuthUsername, AuthPassword, s_ProductID, name, price);
                EditDialog.AdminForm = this;
                Enabled = false;
                EditDialog.Show();
            }
            else
            {
                MessageBox.Show("Not selected!");
            }
        }

        private async void ButtonDeleteShopItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in TabPageShopItem.Controls)
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
                            AuthUsername = this.AuthUsername,
                            AuthPassword = this.AuthPassword
                        });
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

            foreach (Control control in TabPageShopItem.Controls)
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
                string name = DataGridViewUserList.SelectedRows[0].Cells[2].Value.ToString();
                string email = DataGridViewUserList.SelectedRows[0].Cells[3].Value.ToString();
                string role = DataGridViewUserList.SelectedRows[0].Cells[5].Value.ToString();
                EditUserDialog EditDialog = new EditUserDialog(AuthUsername, AuthPassword, s_UserID, name, email, role);
                EditDialog.AdminForm = this;
                Enabled = false;
                EditDialog.Show();
            }
            else
            {
                MessageBox.Show("Not selected!");
            }
        }
    }
}
