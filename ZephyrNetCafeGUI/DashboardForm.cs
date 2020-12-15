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
    public partial class DashboardForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public DashboardForm(string username, string password)
        {
            InitializeComponent();

            Username = username;
            Password = password;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LabelWelcomeUser.Text = $"Welcome, user {Username}";
            
        }


        private void TabControlCollection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
