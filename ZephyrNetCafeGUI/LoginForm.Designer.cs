
namespace ZephyrNetCafeGUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonSignup = new System.Windows.Forms.Button();
            this.TextBoxPCID = new System.Windows.Forms.TextBox();
            this.LabelPCID = new System.Windows.Forms.Label();
            this.ComboBoxAccess = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(910, 424);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(90, 40);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(688, 290);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(312, 23);
            this.TextBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(688, 339);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(312, 23);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.ButtonSignup);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 607);
            this.panel1.TabIndex = 5;
            // 
            // ButtonSignup
            // 
            this.ButtonSignup.Location = new System.Drawing.Point(99, 281);
            this.ButtonSignup.Name = "ButtonSignup";
            this.ButtonSignup.Size = new System.Drawing.Size(140, 40);
            this.ButtonSignup.TabIndex = 0;
            this.ButtonSignup.Text = "Sign Up";
            this.ButtonSignup.UseVisualStyleBackColor = true;
            this.ButtonSignup.Click += new System.EventHandler(this.ButtonSignup_Click);
            // 
            // TextBoxPCID
            // 
            this.TextBoxPCID.Location = new System.Drawing.Point(688, 380);
            this.TextBoxPCID.Name = "TextBoxPCID";
            this.TextBoxPCID.Size = new System.Drawing.Size(312, 23);
            this.TextBoxPCID.TabIndex = 6;
            // 
            // LabelPCID
            // 
            this.LabelPCID.AutoSize = true;
            this.LabelPCID.Location = new System.Drawing.Point(612, 383);
            this.LabelPCID.Name = "LabelPCID";
            this.LabelPCID.Size = new System.Drawing.Size(36, 15);
            this.LabelPCID.TabIndex = 7;
            this.LabelPCID.Text = "PC ID";
            // 
            // ComboBoxAccess
            // 
            this.ComboBoxAccess.FormattingEnabled = true;
            this.ComboBoxAccess.Items.AddRange(new object[] {
            "User",
            "Staff",
            "Admin"});
            this.ComboBoxAccess.Location = new System.Drawing.Point(688, 424);
            this.ComboBoxAccess.Name = "ComboBoxAccess";
            this.ComboBoxAccess.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxAccess.TabIndex = 8;
            this.ComboBoxAccess.Text = "User";
            this.ComboBoxAccess.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAccess_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1164, 631);
            this.Controls.Add(this.ComboBoxAccess);
            this.Controls.Add(this.LabelPCID);
            this.Controls.Add(this.TextBoxPCID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.ButtonLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonSignup;
        private System.Windows.Forms.TextBox TextBoxPCID;
        private System.Windows.Forms.Label LabelPCID;
        private System.Windows.Forms.ComboBox ComboBoxAccess;
    }
}