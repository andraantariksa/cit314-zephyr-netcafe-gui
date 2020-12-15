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

    public partial class DashboardForm : Form
    {
        public int m_Duration;
        public string m_Username { get; private set; }
        public string m_Password { get; private set; }
        private long m_UserID { get; set; }
        public long m_UsageID { get; private set; }
        public long m_PCID { get; private set; }

        public DashboardForm(string username, string password, long pcid)
        {
            InitializeComponent();

            m_Username = username;
            m_Password = password;
            m_PCID = pcid;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public class ComputerUsageField
        {
            public long ComputerID { set; get; }
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

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                var user = await $"{Constant.URL}/api/user/single/{m_Username}"
                    .GetJsonAsync<UserDataField>();
                if (user != null)
                {
                    m_UserID = user.ID;
                    m_Duration = user.Duration;
                }
                var response = await $"{Constant.URL}/api/computerusage"
                    .PostJsonAsync(new
                    {
                        UserID = user.ID,
                        ComputerID = m_PCID
                    })
                    .ReceiveJson<ComputerUsageField>();
                m_UsageID = response.ComputerID;

                LabelWelcomeUser.Text = $"Welcome, user {m_Username}";
                LabelDuration.Text = $":{m_Duration}";
                TimerControlDuration.Start();

            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
                ExitDashboard();
            }
        }

        private void Logout()
        {
            Dispose();
            ParentForm.Show();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }

        private void ExitDashboard()
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }
            Logout();
        }

        private async void TimerControlDuration_Tick(object sender, EventArgs e)
        {
            try
            {
                var usage = await $"{Constant.URL}/api/computerusage"
                    .PutJsonAsync(new
                    {
                        ComputerUsageID = m_UsageID
                    });
            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (m_Duration != 0)
            {
                try
                {
                    var dur = await $"{Constant.URL}/api/durationreduce"
                        .PostJsonAsync(new
                        {
                            ReducedDuration = 1,
                            AuthUsername = m_Username,
                            AuthPassword = m_Password
                        });
                }
                catch (FlurlHttpException ex)
                {
                    MessageBox.Show(ex.Message);
                    ExitDashboard();
                }
                m_Duration -= 1;
                LabelDuration.Text = $":{m_Duration}";
            }
            else
            {
                TimerControlDuration.Stop();
                MessageBox.Show("Your time has exceeded!");
                ExitDashboard();
            }
        }
    }
}
