using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZephyrNetCafeGUI
{
    public partial class AdminDashboardForm : Form
    {
        private string AuthUsername;
        private string AuthPassword;

        public AdminDashboardForm(string authUsername, string authPassword)
        {
            AuthUsername = authUsername;
            AuthPassword = authPassword;

            InitializeComponent();

            LabelWelcomeAdmin.Text = $"Welcome, Staff {AuthUsername}!";
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
