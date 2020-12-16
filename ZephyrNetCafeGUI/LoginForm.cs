using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;

namespace ZephyrNetCafeGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public class User
        {
            public enum Roles
            {
                Admin = 0,
                Staff = 1,
                Customer = 2
            };

            public long ID { get; set; }
            public string Username { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public int Duration { get; set; }
            public Roles Role { get; set; }
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            var userUsername = TextBoxUsername.Text;
            var userPassword = TextBoxPassword.Text;
            try
            {
                var user = await $"{Constant.URL}/api/user/auth"
                    .PostJsonAsync(new
                    {
                        Username = userUsername,
                        Password = userPassword
                    })
                    .ReceiveJson<User>();

                switch (ComboBoxAccess.Text)
                {
                    case "User":
                        {
                            if (user.Duration <= 0)
                            {
                                MessageBox.Show("You do not have any duration to use the computer");
                            }
                            else
                            {
                                var PCID = Int64.Parse(TextBoxPCID.Text);
                                var formDashboard = new UserDashboardForm(userUsername, userPassword, PCID, this);
                                formDashboard.Show(this);
                                Hide();
                            }
                        }
                        break;

                    case "Staff":
                        {
                            if (user.Role != User.Roles.Staff)
                            {
                                MessageBox.Show($"{user.Role} can not login as staff!");
                            }
                            else
                            {
                                var formDashboard = new StaffDashboardForm(userUsername, userPassword, this);
                                formDashboard.Show();
                                Hide();
                            }
                        }
                        break;
                    case "Admin":
                        {
                            if (user.Role != User.Roles.Admin)
                            {
                                MessageBox.Show($"{user.Role} can not login as admin!");
                            }
                            else
                            {
                                var formDashboard = new AdminDashboardForm(userUsername, userPassword, this);
                                formDashboard.Show();
                                Hide();
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("No such roles exists!");
                        break;
                }
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Wrong username or password");
                }
                else
                {
                    var errorResp = await ex.Call.Response.GetStringAsync();
                    MessageBox.Show($"{ex.Message}\n{errorResp}");
                }
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            var formSignup = new SignUpForm();
            formSignup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxAccess.SelectedIndex == 0)
            {
                TextBoxPCID.Show();
                LabelPCID.Show();
                TextBoxPCID.Enabled = true;
                LabelPCID.Enabled = true;
            }
            else
            {
                TextBoxPCID.Hide();
                LabelPCID.Hide();
                TextBoxPCID.Enabled = false;
                LabelPCID.Enabled = false;
            }
        }
    }
}
