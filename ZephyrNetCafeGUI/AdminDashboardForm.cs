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
        public AdminDashboardForm(string authUsername, string authPassword)
        {
            AuthUsername = authUsername;
            AuthPassword = authPassword;

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
        private void TimerControlComputerActive_Tick(object sender, EventArgs e)
        {
            try
            {
                UpdateComputerActive();
                UpdateComputerItemList();
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

        private void ButtonDeleteComputer_Click(object sender, EventArgs e)
        {
            if (DataGridViewComputerItemList.SelectedRows.Count > 0)
            {

                //long s_ComputerID = DataGridViewComputerItemList.SelectedRows.;

            }

        }
    }
}
