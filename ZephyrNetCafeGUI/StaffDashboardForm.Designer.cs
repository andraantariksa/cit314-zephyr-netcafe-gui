
namespace ZephyrNetCafeGUI
{
    partial class StaffDashboardForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelWelcomeStaff = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TextBoxMinutes = new System.Windows.Forms.TextBox();
            this.TextBoxUserUsername = new System.Windows.Forms.TextBox();
            this.ButtonAddDuration = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxTransactionUserUsername = new System.Windows.Forms.TextBox();
            this.ButtonTransactionCheckout = new System.Windows.Forms.Button();
            this.ButtonTransactionAddToCart = new System.Windows.Forms.Button();
            this.TextBoxTransactionQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxTransactionItemList = new System.Windows.Forms.ComboBox();
            this.DataGridViewCart = new System.Windows.Forms.DataGridView();
            this.DataGridViewCartItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCartItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCartItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCartItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCartItemTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.vScrollBar1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.LabelWelcomeStaff);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1086, 75);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 477);
            this.vScrollBar1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 477);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Active Computer";
            // 
            // LabelWelcomeStaff
            // 
            this.LabelWelcomeStaff.AutoSize = true;
            this.LabelWelcomeStaff.Location = new System.Drawing.Point(27, 20);
            this.LabelWelcomeStaff.Name = "LabelWelcomeStaff";
            this.LabelWelcomeStaff.Size = new System.Drawing.Size(99, 15);
            this.LabelWelcomeStaff.TabIndex = 0;
            this.LabelWelcomeStaff.Text = "Welcome, Staff x!";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TextBoxMinutes);
            this.tabPage2.Controls.Add(this.TextBoxUserUsername);
            this.tabPage2.Controls.Add(this.ButtonAddDuration);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Duration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBoxMinutes
            // 
            this.TextBoxMinutes.Location = new System.Drawing.Point(46, 180);
            this.TextBoxMinutes.Name = "TextBoxMinutes";
            this.TextBoxMinutes.Size = new System.Drawing.Size(289, 23);
            this.TextBoxMinutes.TabIndex = 5;
            // 
            // TextBoxUserUsername
            // 
            this.TextBoxUserUsername.Location = new System.Drawing.Point(46, 97);
            this.TextBoxUserUsername.Name = "TextBoxUserUsername";
            this.TextBoxUserUsername.Size = new System.Drawing.Size(289, 23);
            this.TextBoxUserUsername.TabIndex = 4;
            // 
            // ButtonAddDuration
            // 
            this.ButtonAddDuration.Location = new System.Drawing.Point(260, 247);
            this.ButtonAddDuration.Name = "ButtonAddDuration";
            this.ButtonAddDuration.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddDuration.TabIndex = 2;
            this.ButtonAddDuration.Text = "Add";
            this.ButtonAddDuration.UseVisualStyleBackColor = true;
            this.ButtonAddDuration.Click += new System.EventHandler(this.ButtonAddDuration_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "3. Click \"Add\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "2. Enter amount of minutes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "1. Enter the user\'s username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Instructions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Add Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.vScrollBar2);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(951, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shop";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(1083, 56);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 490);
            this.vScrollBar2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(33, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1067, 490);
            this.dataGridView2.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Shop Items";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.TextBoxTransactionUserUsername);
            this.tabPage4.Controls.Add(this.ButtonTransactionCheckout);
            this.tabPage4.Controls.Add(this.ButtonTransactionAddToCart);
            this.tabPage4.Controls.Add(this.TextBoxTransactionQuantity);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.ComboBoxTransactionItemList);
            this.tabPage4.Controls.Add(this.DataGridViewCart);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(951, 484);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transaction";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Username";
            // 
            // TextBoxTransactionUserUsername
            // 
            this.TextBoxTransactionUserUsername.Location = new System.Drawing.Point(30, 321);
            this.TextBoxTransactionUserUsername.Name = "TextBoxTransactionUserUsername";
            this.TextBoxTransactionUserUsername.Size = new System.Drawing.Size(100, 23);
            this.TextBoxTransactionUserUsername.TabIndex = 12;
            // 
            // ButtonTransactionCheckout
            // 
            this.ButtonTransactionCheckout.Location = new System.Drawing.Point(30, 232);
            this.ButtonTransactionCheckout.Name = "ButtonTransactionCheckout";
            this.ButtonTransactionCheckout.Size = new System.Drawing.Size(121, 23);
            this.ButtonTransactionCheckout.TabIndex = 11;
            this.ButtonTransactionCheckout.Text = "Checkout";
            this.ButtonTransactionCheckout.UseVisualStyleBackColor = true;
            this.ButtonTransactionCheckout.Click += new System.EventHandler(this.ButtonTransactionCheckout_Click);
            // 
            // ButtonTransactionAddToCart
            // 
            this.ButtonTransactionAddToCart.Location = new System.Drawing.Point(30, 203);
            this.ButtonTransactionAddToCart.Name = "ButtonTransactionAddToCart";
            this.ButtonTransactionAddToCart.Size = new System.Drawing.Size(121, 23);
            this.ButtonTransactionAddToCart.TabIndex = 10;
            this.ButtonTransactionAddToCart.Text = "Add to Cart";
            this.ButtonTransactionAddToCart.UseVisualStyleBackColor = true;
            this.ButtonTransactionAddToCart.Click += new System.EventHandler(this.ButtonTransactionAddToCart_Click);
            // 
            // TextBoxTransactionQuantity
            // 
            this.TextBoxTransactionQuantity.Location = new System.Drawing.Point(30, 156);
            this.TextBoxTransactionQuantity.Name = "TextBoxTransactionQuantity";
            this.TextBoxTransactionQuantity.Size = new System.Drawing.Size(121, 23);
            this.TextBoxTransactionQuantity.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity";
            // 
            // ComboBoxTransactionItemList
            // 
            this.ComboBoxTransactionItemList.FormattingEnabled = true;
            this.ComboBoxTransactionItemList.Location = new System.Drawing.Point(30, 89);
            this.ComboBoxTransactionItemList.Name = "ComboBoxTransactionItemList";
            this.ComboBoxTransactionItemList.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxTransactionItemList.TabIndex = 5;
            // 
            // DataGridViewCart
            // 
            this.DataGridViewCart.AllowUserToAddRows = false;
            this.DataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCartItemID,
            this.DataGridViewCartItemName,
            this.DataGridViewCartItemQuantity,
            this.DataGridViewCartItemPrice,
            this.DataGridViewCartItemTotalPrice});
            this.DataGridViewCart.Location = new System.Drawing.Point(157, 47);
            this.DataGridViewCart.Name = "DataGridViewCart";
            this.DataGridViewCart.RowTemplate.Height = 25;
            this.DataGridViewCart.Size = new System.Drawing.Size(564, 208);
            this.DataGridViewCart.TabIndex = 4;
            // 
            // DataGridViewCartItemID
            // 
            this.DataGridViewCartItemID.HeaderText = "Item ID";
            this.DataGridViewCartItemID.Name = "DataGridViewCartItemID";
            this.DataGridViewCartItemID.ReadOnly = true;
            // 
            // DataGridViewCartItemName
            // 
            this.DataGridViewCartItemName.HeaderText = "Name";
            this.DataGridViewCartItemName.Name = "DataGridViewCartItemName";
            this.DataGridViewCartItemName.ReadOnly = true;
            // 
            // DataGridViewCartItemQuantity
            // 
            this.DataGridViewCartItemQuantity.HeaderText = "Quantity";
            this.DataGridViewCartItemQuantity.Name = "DataGridViewCartItemQuantity";
            this.DataGridViewCartItemQuantity.ReadOnly = true;
            // 
            // DataGridViewCartItemPrice
            // 
            this.DataGridViewCartItemPrice.HeaderText = "Price";
            this.DataGridViewCartItemPrice.Name = "DataGridViewCartItemPrice";
            this.DataGridViewCartItemPrice.ReadOnly = true;
            // 
            // DataGridViewCartItemTotalPrice
            // 
            this.DataGridViewCartItemTotalPrice.HeaderText = "Total Price";
            this.DataGridViewCartItemTotalPrice.Name = "DataGridViewCartItemTotalPrice";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Add Transaction";
            // 
            // StaffDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaffDashboardForm";
            this.Text = "Staff Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffDashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.StaffDashboardForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ButtonAddDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox ox;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.TextBox TextBoxMinutes;
        private System.Windows.Forms.TextBox TextBoxUserUsername;
        private System.Windows.Forms.Label LabelWelcomeStaff;
        private System.Windows.Forms.TextBox TextB0x;
        private System.Windows.Forms.ComboBox ComboBoxTransactionItemList;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCartItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCartItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCartItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCartItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCartItemTotalPrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonTransactionAddToCart;
        private System.Windows.Forms.TextBox TextBoxTransactionQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonTransactionCheckout;
        private System.Windows.Forms.DataGridView DataGridViewCart;
        private System.Windows.Forms.TextBox TextBoxTransactionUserUsername;
        private System.Windows.Forms.Label label11;
    }
}