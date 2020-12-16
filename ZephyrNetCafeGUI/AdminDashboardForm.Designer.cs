
namespace ZephyrNetCafeGUI
{
    partial class AdminDashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.TabControlComputer = new System.Windows.Forms.TabControl();
            this.TabPageComputer = new System.Windows.Forms.TabPage();
            this.ButtonDeleteComputer = new System.Windows.Forms.Button();
            this.ButtonAddComputer = new System.Windows.Forms.Button();
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
            this.LabelWelcomeAdmin = new System.Windows.Forms.Label();
            this.TabPageShopItem = new System.Windows.Forms.TabPage();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.ButtonAddShopItem = new System.Windows.Forms.Button();
            this.ButtonEditShopItem = new System.Windows.Forms.Button();
            this.ButtonDeleteShopItem = new System.Windows.Forms.Button();
            this.DataGridViewShopItem = new System.Windows.Forms.DataGridView();
            this.ColumnShopItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShopItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShopItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShopItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.TabPageUsers = new System.Windows.Forms.TabPage();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.ButtonEditUser = new System.Windows.Forms.Button();
            this.ButtonDeleteUser = new System.Windows.Forms.Button();
            this.DataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DataGridViewTransactionItems = new System.Windows.Forms.DataGridView();
            this.DataGridViewTransactionItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionItemsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionItemsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionItemsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionItemsTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.DataGridViewTransactionsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionsCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label14 = new System.Windows.Forms.Label();
            this.TimerControlComputerActive = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControlComputer.SuspendLayout();
            this.TabPageComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerActive)).BeginInit();
            this.TabPageShopItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShopItem)).BeginInit();
            this.TabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserList)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlComputer
            // 
            this.TabControlComputer.Controls.Add(this.TabPageComputer);
            this.TabControlComputer.Controls.Add(this.TabPageShopItem);
            this.TabControlComputer.Controls.Add(this.TabPageUsers);
            this.TabControlComputer.Controls.Add(this.tabPage4);
            this.TabControlComputer.Location = new System.Drawing.Point(12, 12);
            this.TabControlComputer.Name = "TabControlComputer";
            this.TabControlComputer.SelectedIndex = 0;
            this.TabControlComputer.Size = new System.Drawing.Size(1087, 600);
            this.TabControlComputer.TabIndex = 1;
            this.TabControlComputer.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabPageComputer
            // 
            this.TabPageComputer.Controls.Add(this.ButtonDeleteComputer);
            this.TabPageComputer.Controls.Add(this.ButtonAddComputer);
            this.TabPageComputer.Controls.Add(this.LabelComputerItem);
            this.TabPageComputer.Controls.Add(this.DataGridViewComputerItemList);
            this.TabPageComputer.Controls.Add(this.DataGridViewComputerActive);
            this.TabPageComputer.Controls.Add(this.LabelActiveComputer);
            this.TabPageComputer.Controls.Add(this.LabelWelcomeAdmin);
            this.TabPageComputer.Location = new System.Drawing.Point(4, 24);
            this.TabPageComputer.Name = "TabPageComputer";
            this.TabPageComputer.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageComputer.Size = new System.Drawing.Size(1079, 572);
            this.TabPageComputer.TabIndex = 0;
            this.TabPageComputer.Text = "Computer Management";
            this.TabPageComputer.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteComputer
            // 
            this.ButtonDeleteComputer.Location = new System.Drawing.Point(499, 513);
            this.ButtonDeleteComputer.Name = "ButtonDeleteComputer";
            this.ButtonDeleteComputer.Size = new System.Drawing.Size(112, 51);
            this.ButtonDeleteComputer.TabIndex = 4;
            this.ButtonDeleteComputer.Text = "Delete Computer";
            this.ButtonDeleteComputer.UseVisualStyleBackColor = true;
            this.ButtonDeleteComputer.Click += new System.EventHandler(this.ButtonDeleteComputer_Click);
            // 
            // ButtonAddComputer
            // 
            this.ButtonAddComputer.Location = new System.Drawing.Point(499, 430);
            this.ButtonAddComputer.Name = "ButtonAddComputer";
            this.ButtonAddComputer.Size = new System.Drawing.Size(112, 51);
            this.ButtonAddComputer.TabIndex = 4;
            this.ButtonAddComputer.Text = "Add Computer";
            this.ButtonAddComputer.UseVisualStyleBackColor = true;
            this.ButtonAddComputer.Click += new System.EventHandler(this.ButtonAddComputer_Click);
            // 
            // LabelComputerItem
            // 
            this.LabelComputerItem.AutoSize = true;
            this.LabelComputerItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelComputerItem.Location = new System.Drawing.Point(30, 311);
            this.LabelComputerItem.Name = "LabelComputerItem";
            this.LabelComputerItem.Size = new System.Drawing.Size(185, 25);
            this.LabelComputerItem.TabIndex = 0;
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
            this.DataGridViewComputerItemList.Location = new System.Drawing.Point(30, 339);
            this.DataGridViewComputerItemList.MultiSelect = false;
            this.DataGridViewComputerItemList.Name = "DataGridViewComputerItemList";
            this.DataGridViewComputerItemList.ReadOnly = true;
            this.DataGridViewComputerItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewComputerItemList.Size = new System.Drawing.Size(450, 225);
            this.DataGridViewComputerItemList.TabIndex = 3;
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
            this.DataGridViewComputerActive.Location = new System.Drawing.Point(30, 75);
            this.DataGridViewComputerActive.Name = "DataGridViewComputerActive";
            this.DataGridViewComputerActive.ReadOnly = true;
            this.DataGridViewComputerActive.Size = new System.Drawing.Size(955, 230);
            this.DataGridViewComputerActive.TabIndex = 3;
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
            this.LabelActiveComputer.Location = new System.Drawing.Point(30, 47);
            this.LabelActiveComputer.Name = "LabelActiveComputer";
            this.LabelActiveComputer.Size = new System.Drawing.Size(157, 25);
            this.LabelActiveComputer.TabIndex = 0;
            this.LabelActiveComputer.Text = "Active Computer";
            // 
            // LabelWelcomeAdmin
            // 
            this.LabelWelcomeAdmin.AutoSize = true;
            this.LabelWelcomeAdmin.ForeColor = System.Drawing.Color.Red;
            this.LabelWelcomeAdmin.Location = new System.Drawing.Point(30, 23);
            this.LabelWelcomeAdmin.Name = "LabelWelcomeAdmin";
            this.LabelWelcomeAdmin.Size = new System.Drawing.Size(122, 15);
            this.LabelWelcomeAdmin.TabIndex = 0;
            this.LabelWelcomeAdmin.Text = "Welcome, Manager x!";
            // 
            // TabPageShopItem
            // 
            this.TabPageShopItem.Controls.Add(this.vScrollBar3);
            this.TabPageShopItem.Controls.Add(this.ButtonAddShopItem);
            this.TabPageShopItem.Controls.Add(this.ButtonEditShopItem);
            this.TabPageShopItem.Controls.Add(this.ButtonDeleteShopItem);
            this.TabPageShopItem.Controls.Add(this.DataGridViewShopItem);
            this.TabPageShopItem.Controls.Add(this.label13);
            this.TabPageShopItem.Location = new System.Drawing.Point(4, 24);
            this.TabPageShopItem.Name = "TabPageShopItem";
            this.TabPageShopItem.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageShopItem.Size = new System.Drawing.Size(1079, 572);
            this.TabPageShopItem.TabIndex = 2;
            this.TabPageShopItem.Text = "Shop Items Management";
            this.TabPageShopItem.UseVisualStyleBackColor = true;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(1118, 45);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(17, 439);
            this.vScrollBar3.TabIndex = 3;
            // 
            // ButtonAddShopItem
            // 
            this.ButtonAddShopItem.Location = new System.Drawing.Point(740, 505);
            this.ButtonAddShopItem.Name = "ButtonAddShopItem";
            this.ButtonAddShopItem.Size = new System.Drawing.Size(113, 37);
            this.ButtonAddShopItem.TabIndex = 2;
            this.ButtonAddShopItem.Text = "Add Item";
            this.ButtonAddShopItem.UseVisualStyleBackColor = true;
            this.ButtonAddShopItem.Click += new System.EventHandler(this.ButtonAddShopItem_Click);
            // 
            // ButtonEditShopItem
            // 
            this.ButtonEditShopItem.Location = new System.Drawing.Point(859, 505);
            this.ButtonEditShopItem.Name = "ButtonEditShopItem";
            this.ButtonEditShopItem.Size = new System.Drawing.Size(113, 37);
            this.ButtonEditShopItem.TabIndex = 2;
            this.ButtonEditShopItem.Text = "Edit Item";
            this.ButtonEditShopItem.UseVisualStyleBackColor = true;
            this.ButtonEditShopItem.Click += new System.EventHandler(this.ButtonEditShopItem_Click);
            // 
            // ButtonDeleteShopItem
            // 
            this.ButtonDeleteShopItem.Location = new System.Drawing.Point(978, 505);
            this.ButtonDeleteShopItem.Name = "ButtonDeleteShopItem";
            this.ButtonDeleteShopItem.Size = new System.Drawing.Size(113, 37);
            this.ButtonDeleteShopItem.TabIndex = 2;
            this.ButtonDeleteShopItem.Text = "Delete Item";
            this.ButtonDeleteShopItem.UseVisualStyleBackColor = true;
            this.ButtonDeleteShopItem.Click += new System.EventHandler(this.ButtonDeleteShopItem_Click);
            // 
            // DataGridViewShopItem
            // 
            this.DataGridViewShopItem.AllowUserToAddRows = false;
            this.DataGridViewShopItem.AllowUserToDeleteRows = false;
            this.DataGridViewShopItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewShopItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnShopItemID,
            this.ColumnShopItemName,
            this.ColumnShopItemPrice,
            this.ColumnShopItemQuantity});
            this.DataGridViewShopItem.Location = new System.Drawing.Point(13, 46);
            this.DataGridViewShopItem.MultiSelect = false;
            this.DataGridViewShopItem.Name = "DataGridViewShopItem";
            this.DataGridViewShopItem.ReadOnly = true;
            this.DataGridViewShopItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewShopItem.Size = new System.Drawing.Size(804, 270);
            this.DataGridViewShopItem.TabIndex = 1;
            // 
            // ColumnShopItemID
            // 
            this.ColumnShopItemID.HeaderText = "Item ID";
            this.ColumnShopItemID.Name = "ColumnShopItemID";
            this.ColumnShopItemID.ReadOnly = true;
            // 
            // ColumnShopItemName
            // 
            this.ColumnShopItemName.HeaderText = "Item Name";
            this.ColumnShopItemName.Name = "ColumnShopItemName";
            this.ColumnShopItemName.ReadOnly = true;
            // 
            // ColumnShopItemPrice
            // 
            this.ColumnShopItemPrice.HeaderText = "Item Price";
            this.ColumnShopItemPrice.Name = "ColumnShopItemPrice";
            this.ColumnShopItemPrice.ReadOnly = true;
            // 
            // ColumnShopItemQuantity
            // 
            this.ColumnShopItemQuantity.HeaderText = "Quantity";
            this.ColumnShopItemQuantity.Name = "ColumnShopItemQuantity";
            this.ColumnShopItemQuantity.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(45, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Shop Items Management";
            // 
            // TabPageUsers
            // 
            this.TabPageUsers.Controls.Add(this.vScrollBar2);
            this.TabPageUsers.Controls.Add(this.ButtonEditUser);
            this.TabPageUsers.Controls.Add(this.ButtonDeleteUser);
            this.TabPageUsers.Controls.Add(this.DataGridViewUserList);
            this.TabPageUsers.Controls.Add(this.label3);
            this.TabPageUsers.Location = new System.Drawing.Point(4, 24);
            this.TabPageUsers.Name = "TabPageUsers";
            this.TabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageUsers.Size = new System.Drawing.Size(1079, 572);
            this.TabPageUsers.TabIndex = 1;
            this.TabPageUsers.Text = "User Management";
            this.TabPageUsers.UseVisualStyleBackColor = true;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(1082, 61);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 448);
            this.vScrollBar2.TabIndex = 6;
            // 
            // ButtonEditUser
            // 
            this.ButtonEditUser.Location = new System.Drawing.Point(695, 515);
            this.ButtonEditUser.Name = "ButtonEditUser";
            this.ButtonEditUser.Size = new System.Drawing.Size(113, 37);
            this.ButtonEditUser.TabIndex = 4;
            this.ButtonEditUser.Text = "Edit User";
            this.ButtonEditUser.UseVisualStyleBackColor = true;
            this.ButtonEditUser.Click += new System.EventHandler(this.ButtonEditUser_Click);
            // 
            // ButtonDeleteUser
            // 
            this.ButtonDeleteUser.Location = new System.Drawing.Point(814, 515);
            this.ButtonDeleteUser.Name = "ButtonDeleteUser";
            this.ButtonDeleteUser.Size = new System.Drawing.Size(113, 37);
            this.ButtonDeleteUser.TabIndex = 5;
            this.ButtonDeleteUser.Text = "Delete User";
            this.ButtonDeleteUser.UseVisualStyleBackColor = true;
            this.ButtonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // DataGridViewUserList
            // 
            this.DataGridViewUserList.AllowUserToAddRows = false;
            this.DataGridViewUserList.AllowUserToDeleteRows = false;
            this.DataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUserID,
            this.ColumnUserUsername,
            this.ColumnUserName,
            this.ColumnUserEmail,
            this.ColumnUserDuration,
            this.ColumnUserRole,
            this.ColumnUserPassword});
            this.DataGridViewUserList.Location = new System.Drawing.Point(29, 61);
            this.DataGridViewUserList.MultiSelect = false;
            this.DataGridViewUserList.Name = "DataGridViewUserList";
            this.DataGridViewUserList.ReadOnly = true;
            this.DataGridViewUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUserList.Size = new System.Drawing.Size(976, 448);
            this.DataGridViewUserList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Management";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DataGridViewTransactionItems);
            this.tabPage4.Controls.Add(this.DataGridViewTransactions);
            this.tabPage4.Controls.Add(this.vScrollBar1);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1079, 572);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transaction Report Management";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DataGridViewTransactionItems
            // 
            this.DataGridViewTransactionItems.AllowUserToAddRows = false;
            this.DataGridViewTransactionItems.AllowUserToDeleteRows = false;
            this.DataGridViewTransactionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTransactionItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTransactionItemsID,
            this.DataGridViewTransactionItemsName,
            this.DataGridViewTransactionItemsPrice,
            this.DataGridViewTransactionItemsQuantity,
            this.DataGridViewTransactionItemsTotalPrice});
            this.DataGridViewTransactionItems.Location = new System.Drawing.Point(293, 67);
            this.DataGridViewTransactionItems.Name = "DataGridViewTransactionItems";
            this.DataGridViewTransactionItems.ReadOnly = true;
            this.DataGridViewTransactionItems.RowTemplate.Height = 25;
            this.DataGridViewTransactionItems.Size = new System.Drawing.Size(335, 379);
            this.DataGridViewTransactionItems.TabIndex = 5;
            // 
            // DataGridViewTransactionItemsID
            // 
            this.DataGridViewTransactionItemsID.HeaderText = "ID";
            this.DataGridViewTransactionItemsID.Name = "DataGridViewTransactionItemsID";
            this.DataGridViewTransactionItemsID.ReadOnly = true;
            // 
            // DataGridViewTransactionItemsName
            // 
            this.DataGridViewTransactionItemsName.HeaderText = "Name";
            this.DataGridViewTransactionItemsName.Name = "DataGridViewTransactionItemsName";
            this.DataGridViewTransactionItemsName.ReadOnly = true;
            // 
            // DataGridViewTransactionItemsPrice
            // 
            this.DataGridViewTransactionItemsPrice.HeaderText = "Price";
            this.DataGridViewTransactionItemsPrice.Name = "DataGridViewTransactionItemsPrice";
            this.DataGridViewTransactionItemsPrice.ReadOnly = true;
            // 
            // DataGridViewTransactionItemsQuantity
            // 
            this.DataGridViewTransactionItemsQuantity.HeaderText = "Quantity";
            this.DataGridViewTransactionItemsQuantity.Name = "DataGridViewTransactionItemsQuantity";
            this.DataGridViewTransactionItemsQuantity.ReadOnly = true;
            // 
            // DataGridViewTransactionItemsTotalPrice
            // 
            this.DataGridViewTransactionItemsTotalPrice.HeaderText = "Total Price";
            this.DataGridViewTransactionItemsTotalPrice.Name = "DataGridViewTransactionItemsTotalPrice";
            this.DataGridViewTransactionItemsTotalPrice.ReadOnly = true;
            // 
            // DataGridViewTransactions
            // 
            this.DataGridViewTransactions.AllowUserToAddRows = false;
            this.DataGridViewTransactions.AllowUserToDeleteRows = false;
            this.DataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTransactionsID,
            this.DataGridViewTransactionsCreatedAt});
            this.DataGridViewTransactions.Location = new System.Drawing.Point(33, 67);
            this.DataGridViewTransactions.Name = "DataGridViewTransactions";
            this.DataGridViewTransactions.ReadOnly = true;
            this.DataGridViewTransactions.RowTemplate.Height = 25;
            this.DataGridViewTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTransactions.Size = new System.Drawing.Size(254, 379);
            this.DataGridViewTransactions.TabIndex = 4;
            this.DataGridViewTransactions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewTransactions_CellMouseClick);
            // 
            // DataGridViewTransactionsID
            // 
            this.DataGridViewTransactionsID.HeaderText = "ID";
            this.DataGridViewTransactionsID.Name = "DataGridViewTransactionsID";
            this.DataGridViewTransactionsID.ReadOnly = true;
            // 
            // DataGridViewTransactionsCreatedAt
            // 
            this.DataGridViewTransactionsCreatedAt.HeaderText = "Created At";
            this.DataGridViewTransactionsCreatedAt.Name = "DataGridViewTransactionsCreatedAt";
            this.DataGridViewTransactionsCreatedAt.ReadOnly = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1078, 67);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 485);
            this.vScrollBar1.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(33, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(292, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Transaction Report Management";
            // 
            // TimerControlComputerActive
            // 
            this.TimerControlComputerActive.Enabled = true;
            this.TimerControlComputerActive.Interval = 60000;
            this.TimerControlComputerActive.Tick += new System.EventHandler(this.TimerControlComputerActive_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Computer ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Computer Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Computer Spec";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Computer IsDeleted";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ComputerUsage ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ComputerUsage UserID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ComputerUsage ComputerID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ComputerUsage EndDate Time";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "ComputerUsage StartDate Time";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // ColumnUserID
            // 
            this.ColumnUserID.HeaderText = "User ID";
            this.ColumnUserID.Name = "ColumnUserID";
            this.ColumnUserID.ReadOnly = true;
            // 
            // ColumnUserUsername
            // 
            this.ColumnUserUsername.HeaderText = "Username";
            this.ColumnUserUsername.Name = "ColumnUserUsername";
            this.ColumnUserUsername.ReadOnly = true;
            // 
            // ColumnUserName
            // 
            this.ColumnUserName.HeaderText = "Name";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            // 
            // ColumnUserEmail
            // 
            this.ColumnUserEmail.HeaderText = "Email";
            this.ColumnUserEmail.Name = "ColumnUserEmail";
            this.ColumnUserEmail.ReadOnly = true;
            // 
            // ColumnUserDuration
            // 
            this.ColumnUserDuration.HeaderText = "Duration Remaining";
            this.ColumnUserDuration.Name = "ColumnUserDuration";
            this.ColumnUserDuration.ReadOnly = true;
            // 
            // ColumnUserRole
            // 
            this.ColumnUserRole.HeaderText = "Role";
            this.ColumnUserRole.Name = "ColumnUserRole";
            this.ColumnUserRole.ReadOnly = true;
            // 
            // ColumnUserPassword
            // 
            this.ColumnUserPassword.HeaderText = "Password";
            this.ColumnUserPassword.Name = "ColumnUserPassword";
            this.ColumnUserPassword.ReadOnly = true;
            this.ColumnUserPassword.Visible = false;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 673);
            this.Controls.Add(this.TabControlComputer);
            this.Name = "AdminDashboardForm";
            this.Text = "Manager Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.EnabledChanged += new System.EventHandler(this.AdminDashboardForm_EnabledChanged);
            this.TabControlComputer.ResumeLayout(false);
            this.TabPageComputer.ResumeLayout(false);
            this.TabPageComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerActive)).EndInit();
            this.TabPageShopItem.ResumeLayout(false);
            this.TabPageShopItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShopItem)).EndInit();
            this.TabPageUsers.ResumeLayout(false);
            this.TabPageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlComputer;
        private System.Windows.Forms.TabPage TabPageComputer;
        private System.Windows.Forms.Label LabelActiveComputer;
        private System.Windows.Forms.Label LabelWelcomeAdmin;
        private System.Windows.Forms.TabPage TabPageShopItem;
        private System.Windows.Forms.Button ButtonAddShopItem;
        private System.Windows.Forms.Button ButtonEditShopItem;
        private System.Windows.Forms.Button ButtonDeleteShopItem;
        private System.Windows.Forms.DataGridView DataGridViewShopItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage TabPageUsers;
        private System.Windows.Forms.DataGridView DataGridViewUserList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button ButtonEditUser;
        private System.Windows.Forms.Button ButtonDeleteUser;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Timer TimerControlComputerActive;
        private System.Windows.Forms.DataGridView DataGridViewComputerActive;
        private System.Windows.Forms.Label LabelComputerItem;
        private System.Windows.Forms.DataGridView DataGridViewComputerItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerIsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageEndDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiveComputerUsageStartDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button ButtonDeleteComputer;
        private System.Windows.Forms.Button ButtonAddComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShopItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShopItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShopItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShopItemQuantity;
        private System.Windows.Forms.DataGridView DataGridViewTransactionItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsTotalPrice;
        private System.Windows.Forms.DataGridView DataGridViewTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionsCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserPassword;
    }
}