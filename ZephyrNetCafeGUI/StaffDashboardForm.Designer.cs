
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
            this.LabelComputerItem = new System.Windows.Forms.Label();
            this.DataGridViewComputerItemList = new System.Windows.Forms.DataGridView();
            this.ColumnItemComputerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemComputerSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewComputerActive = new System.Windows.Forms.DataGridView();
            this.ColumnActiveComputerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiveComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiveComputerSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiveComputerIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiveComputerUsageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiveComputerUsageUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiveComputerUsageComputerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiveComputerUsageEndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiveComputerUsageStartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelActiveComputer = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
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
            this.DataGridViewShop = new System.Windows.Forms.DataGridView();
            this.DataGridViewShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewShopPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerActive)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShop)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1045, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage1.Controls.Add(this.LabelComputerItem);
            this.tabPage1.Controls.Add(this.DataGridViewComputerItemList);
            this.tabPage1.Controls.Add(this.DataGridViewComputerActive);
            this.tabPage1.Controls.Add(this.LabelActiveComputer);
            this.tabPage1.Controls.Add(this.vScrollBar1);
            this.tabPage1.Controls.Add(this.LabelWelcomeStaff);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            // 
            // LabelComputerItem
            // 
            this.LabelComputerItem.AutoSize = true;
            this.LabelComputerItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelComputerItem.ForeColor = System.Drawing.Color.White;
            this.LabelComputerItem.Location = new System.Drawing.Point(27, 273);
            this.LabelComputerItem.Name = "LabelComputerItem";
            this.LabelComputerItem.Size = new System.Drawing.Size(185, 25);
            this.LabelComputerItem.TabIndex = 4;
            this.LabelComputerItem.Text = "Computer Item Lists";
            // 
            // DataGridViewComputerItemList
            // 
            this.DataGridViewComputerItemList.AllowUserToAddRows = false;
            this.DataGridViewComputerItemList.AllowUserToDeleteRows = false;
            this.DataGridViewComputerItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewComputerItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemComputerID,
            this.ColumnItemComputerName,
            this.ColumnItemComputerSpec});
            this.DataGridViewComputerItemList.Location = new System.Drawing.Point(27, 301);
            this.DataGridViewComputerItemList.MultiSelect = false;
            this.DataGridViewComputerItemList.Name = "DataGridViewComputerItemList";
            this.DataGridViewComputerItemList.ReadOnly = true;
            this.DataGridViewComputerItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewComputerItemList.Size = new System.Drawing.Size(450, 225);
            this.DataGridViewComputerItemList.TabIndex = 6;
            this.DataGridViewComputerItemList.Text = "dataGridView1";
            // 
            // ColumnItemComputerID
            // 
            this.ColumnItemComputerID.HeaderText = "Computer ID";
            this.ColumnItemComputerID.Name = "ColumnItemComputerID";
            this.ColumnItemComputerID.ReadOnly = true;
            // 
            // ColumnItemComputerName
            // 
            this.ColumnItemComputerName.HeaderText = "Computer Name";
            this.ColumnItemComputerName.Name = "ColumnItemComputerName";
            this.ColumnItemComputerName.ReadOnly = true;
            // 
            // ColumnItemComputerSpec
            // 
            this.ColumnItemComputerSpec.HeaderText = "Computer Spec";
            this.ColumnItemComputerSpec.Name = "ColumnItemComputerSpec";
            this.ColumnItemComputerSpec.ReadOnly = true;
            // 
            // DataGridViewComputerActive
            // 
            this.DataGridViewComputerActive.AllowUserToAddRows = false;
            this.DataGridViewComputerActive.AllowUserToDeleteRows = false;
            this.DataGridViewComputerActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewComputerActive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnActiveComputerID,
            this.ColumnActiveComputerName,
            this.ColumnActiveComputerSpec,
            this.ColumnActiveComputerIsDeleted,
            this.ColumnActiveComputerUsageID,
            this.ColumnActiveComputerUsageUserID,
            this.ColumnActiveComputerUsageComputerID,
            this.ColumnActiveComputerUsageEndDateTime,
            this.ColumnActiveComputerUsageStartDateTime});
            this.DataGridViewComputerActive.Location = new System.Drawing.Point(27, 74);
            this.DataGridViewComputerActive.Name = "DataGridViewComputerActive";
            this.DataGridViewComputerActive.ReadOnly = true;
            this.DataGridViewComputerActive.Size = new System.Drawing.Size(955, 196);
            this.DataGridViewComputerActive.TabIndex = 7;
            this.DataGridViewComputerActive.Text = "dataGridView1";
            // 
            // ColumnActiveComputerID
            // 
            this.ColumnActiveComputerID.HeaderText = "Computer ID";
            this.ColumnActiveComputerID.Name = "ColumnActiveComputerID";
            this.ColumnActiveComputerID.ReadOnly = true;
            this.ColumnActiveComputerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnActiveComputerName
            // 
            this.ColumnActiveComputerName.HeaderText = "Computer Name";
            this.ColumnActiveComputerName.Name = "ColumnActiveComputerName";
            this.ColumnActiveComputerName.ReadOnly = true;
            this.ColumnActiveComputerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnActiveComputerSpec
            // 
            this.ColumnActiveComputerSpec.HeaderText = "Computer Spec";
            this.ColumnActiveComputerSpec.Name = "ColumnActiveComputerSpec";
            this.ColumnActiveComputerSpec.ReadOnly = true;
            this.ColumnActiveComputerSpec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnActiveComputerIsDeleted
            // 
            this.ColumnActiveComputerIsDeleted.HeaderText = "Computer IsDeleted";
            this.ColumnActiveComputerIsDeleted.Name = "ColumnActiveComputerIsDeleted";
            this.ColumnActiveComputerIsDeleted.ReadOnly = true;
            this.ColumnActiveComputerIsDeleted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnActiveComputerUsageID
            // 
            this.ColumnActiveComputerUsageID.HeaderText = "ComputerUsage ID";
            this.ColumnActiveComputerUsageID.Name = "ColumnActiveComputerUsageID";
            this.ColumnActiveComputerUsageID.ReadOnly = true;
            this.ColumnActiveComputerUsageID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnActiveComputerUsageUserID
            // 
            this.ColumnActiveComputerUsageUserID.HeaderText = "ComputerUsage UserID";
            this.ColumnActiveComputerUsageUserID.Name = "ColumnActiveComputerUsageUserID";
            this.ColumnActiveComputerUsageUserID.ReadOnly = true;
            this.ColumnActiveComputerUsageUserID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnActiveComputerUsageComputerID
            // 
            this.ColumnActiveComputerUsageComputerID.HeaderText = "ComputerUsage ComputerID";
            this.ColumnActiveComputerUsageComputerID.Name = "ColumnActiveComputerUsageComputerID";
            this.ColumnActiveComputerUsageComputerID.ReadOnly = true;
            this.ColumnActiveComputerUsageComputerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnActiveComputerUsageEndDateTime
            // 
            this.ColumnActiveComputerUsageEndDateTime.HeaderText = "ComputerUsage EndDate Time";
            this.ColumnActiveComputerUsageEndDateTime.Name = "ColumnActiveComputerUsageEndDateTime";
            this.ColumnActiveComputerUsageEndDateTime.ReadOnly = true;
            this.ColumnActiveComputerUsageEndDateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnActiveComputerUsageStartDateTime
            // 
            this.ColumnActiveComputerUsageStartDateTime.HeaderText = "ComputerUsage StartDate Time";
            this.ColumnActiveComputerUsageStartDateTime.Name = "ColumnActiveComputerUsageStartDateTime";
            this.ColumnActiveComputerUsageStartDateTime.ReadOnly = true;
            this.ColumnActiveComputerUsageStartDateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LabelActiveComputer
            // 
            this.LabelActiveComputer.AutoSize = true;
            this.LabelActiveComputer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelActiveComputer.ForeColor = System.Drawing.Color.White;
            this.LabelActiveComputer.Location = new System.Drawing.Point(27, 46);
            this.LabelActiveComputer.Name = "LabelActiveComputer";
            this.LabelActiveComputer.Size = new System.Drawing.Size(157, 25);
            this.LabelActiveComputer.TabIndex = 5;
            this.LabelActiveComputer.Text = "Active Computer";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1086, 75);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 477);
            this.vScrollBar1.TabIndex = 2;
            // 
            // LabelWelcomeStaff
            // 
            this.LabelWelcomeStaff.AutoSize = true;
            this.LabelWelcomeStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelWelcomeStaff.ForeColor = System.Drawing.Color.White;
            this.LabelWelcomeStaff.Location = new System.Drawing.Point(27, 20);
            this.LabelWelcomeStaff.Name = "LabelWelcomeStaff";
            this.LabelWelcomeStaff.Size = new System.Drawing.Size(144, 21);
            this.LabelWelcomeStaff.TabIndex = 0;
            this.LabelWelcomeStaff.Text = "Welcome, Staff x!";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
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
            this.tabPage2.Size = new System.Drawing.Size(1037, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Duration";
            // 
            // TextBoxMinutes
            // 
            this.TextBoxMinutes.Location = new System.Drawing.Point(123, 127);
            this.TextBoxMinutes.Name = "TextBoxMinutes";
            this.TextBoxMinutes.Size = new System.Drawing.Size(289, 23);
            this.TextBoxMinutes.TabIndex = 5;
            // 
            // TextBoxUserUsername
            // 
            this.TextBoxUserUsername.Location = new System.Drawing.Point(123, 76);
            this.TextBoxUserUsername.Name = "TextBoxUserUsername";
            this.TextBoxUserUsername.Size = new System.Drawing.Size(289, 23);
            this.TextBoxUserUsername.TabIndex = 4;
            // 
            // ButtonAddDuration
            // 
            this.ButtonAddDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ButtonAddDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddDuration.ForeColor = System.Drawing.Color.White;
            this.ButtonAddDuration.Location = new System.Drawing.Point(320, 173);
            this.ButtonAddDuration.Name = "ButtonAddDuration";
            this.ButtonAddDuration.Size = new System.Drawing.Size(92, 47);
            this.ButtonAddDuration.TabIndex = 2;
            this.ButtonAddDuration.Text = "Add";
            this.ButtonAddDuration.UseVisualStyleBackColor = false;
            this.ButtonAddDuration.Click += new System.EventHandler(this.ButtonAddDuration_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(46, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "3. Click \"Add\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "2. Enter amount of minutes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "1. Enter the user\'s username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Instructions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(46, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Add Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage3.Controls.Add(this.DataGridViewShop);
            this.tabPage3.Controls.Add(this.vScrollBar2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1037, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shop";
            // 
            // DataGridViewShop
            // 
            this.DataGridViewShop.AllowUserToAddRows = false;
            this.DataGridViewShop.AllowUserToDeleteRows = false;
            this.DataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewShopName,
            this.DataGridViewShopPrice});
            this.DataGridViewShop.Location = new System.Drawing.Point(33, 56);
            this.DataGridViewShop.Name = "DataGridViewShop";
            this.DataGridViewShop.ReadOnly = true;
            this.DataGridViewShop.RowTemplate.Height = 25;
            this.DataGridViewShop.Size = new System.Drawing.Size(255, 431);
            this.DataGridViewShop.TabIndex = 3;
            // 
            // DataGridViewShopName
            // 
            this.DataGridViewShopName.HeaderText = "Name";
            this.DataGridViewShopName.Name = "DataGridViewShopName";
            this.DataGridViewShopName.ReadOnly = true;
            // 
            // DataGridViewShopPrice
            // 
            this.DataGridViewShopPrice.HeaderText = "Price";
            this.DataGridViewShopPrice.Name = "DataGridViewShopPrice";
            this.DataGridViewShopPrice.ReadOnly = true;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(1083, 56);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 490);
            this.vScrollBar2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(33, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Shop Items";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
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
            this.tabPage4.Size = new System.Drawing.Size(1037, 571);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Create Transaction";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(30, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Username";
            // 
            // TextBoxTransactionUserUsername
            // 
            this.TextBoxTransactionUserUsername.Location = new System.Drawing.Point(30, 218);
            this.TextBoxTransactionUserUsername.Name = "TextBoxTransactionUserUsername";
            this.TextBoxTransactionUserUsername.Size = new System.Drawing.Size(190, 23);
            this.TextBoxTransactionUserUsername.TabIndex = 12;
            // 
            // ButtonTransactionCheckout
            // 
            this.ButtonTransactionCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ButtonTransactionCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTransactionCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTransactionCheckout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonTransactionCheckout.ForeColor = System.Drawing.Color.White;
            this.ButtonTransactionCheckout.Location = new System.Drawing.Point(66, 302);
            this.ButtonTransactionCheckout.Name = "ButtonTransactionCheckout";
            this.ButtonTransactionCheckout.Size = new System.Drawing.Size(154, 40);
            this.ButtonTransactionCheckout.TabIndex = 11;
            this.ButtonTransactionCheckout.Text = "Checkout";
            this.ButtonTransactionCheckout.UseVisualStyleBackColor = false;
            this.ButtonTransactionCheckout.Click += new System.EventHandler(this.ButtonTransactionCheckout_Click);
            // 
            // ButtonTransactionAddToCart
            // 
            this.ButtonTransactionAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ButtonTransactionAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTransactionAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTransactionAddToCart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonTransactionAddToCart.ForeColor = System.Drawing.Color.White;
            this.ButtonTransactionAddToCart.Location = new System.Drawing.Point(66, 256);
            this.ButtonTransactionAddToCart.Name = "ButtonTransactionAddToCart";
            this.ButtonTransactionAddToCart.Size = new System.Drawing.Size(154, 40);
            this.ButtonTransactionAddToCart.TabIndex = 10;
            this.ButtonTransactionAddToCart.Text = "Add to Cart";
            this.ButtonTransactionAddToCart.UseVisualStyleBackColor = false;
            this.ButtonTransactionAddToCart.Click += new System.EventHandler(this.ButtonTransactionAddToCart_Click);
            // 
            // TextBoxTransactionQuantity
            // 
            this.TextBoxTransactionQuantity.Location = new System.Drawing.Point(30, 156);
            this.TextBoxTransactionQuantity.Name = "TextBoxTransactionQuantity";
            this.TextBoxTransactionQuantity.Size = new System.Drawing.Size(190, 23);
            this.TextBoxTransactionQuantity.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(245, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity";
            // 
            // ComboBoxTransactionItemList
            // 
            this.ComboBoxTransactionItemList.FormattingEnabled = true;
            this.ComboBoxTransactionItemList.Location = new System.Drawing.Point(30, 89);
            this.ComboBoxTransactionItemList.Name = "ComboBoxTransactionItemList";
            this.ComboBoxTransactionItemList.Size = new System.Drawing.Size(190, 23);
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
            this.DataGridViewCart.Location = new System.Drawing.Point(245, 47);
            this.DataGridViewCart.Name = "DataGridViewCart";
            this.DataGridViewCart.RowTemplate.Height = 25;
            this.DataGridViewCart.Size = new System.Drawing.Size(564, 297);
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
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(30, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Add Transaction";
            // 
            // StaffDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1149, 652);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaffDashboardForm";
            this.Text = "Staff Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffDashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.StaffDashboardForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerActive)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShop)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.DataGridView DataGridViewShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewShopPrice;
        private System.Windows.Forms.Label LabelComputerItem;
        private System.Windows.Forms.DataGridView DataGridViewComputerItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerSpec;
        private System.Windows.Forms.DataGridView DataGridViewComputerActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerIsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageEndDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageStartDateTime;
        private System.Windows.Forms.Label LabelActiveComputer;
    }
}