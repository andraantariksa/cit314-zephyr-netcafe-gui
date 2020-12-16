
namespace ZephyrNetCafeGUI
{
    partial class UserDashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControlCollection = new System.Windows.Forms.TabControl();
            this.TabPageDashboard = new System.Windows.Forms.TabPage();
            this.LabelWelcomeUser = new System.Windows.Forms.Label();
            this.LabelTools = new System.Windows.Forms.Label();
            this.LabelGames = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TabPageShop = new System.Windows.Forms.TabPage();
            this.DataGridViewShop = new System.Windows.Forms.DataGridView();
            this.DataGridViewShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewShopPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPageTransaction = new System.Windows.Forms.TabPage();
            this.DataGridViewTransactionItems = new System.Windows.Forms.DataGridView();
            this.DataGridViewTransactionItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionItemsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionItemsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionItemsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionItemsTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.DataGridViewTransactionsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTransactionsCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPageHelp = new System.Windows.Forms.TabPage();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelDurationInfo = new System.Windows.Forms.Label();
            this.TimerControlDuration = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabControlCollection.SuspendLayout();
            this.TabPageDashboard.SuspendLayout();
            this.TabPageShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShop)).BeginInit();
            this.TabPageTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactions)).BeginInit();
            this.TabPageHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlCollection
            // 
            this.TabControlCollection.Controls.Add(this.TabPageDashboard);
            this.TabControlCollection.Controls.Add(this.TabPageShop);
            this.TabControlCollection.Controls.Add(this.TabPageTransaction);
            this.TabControlCollection.Controls.Add(this.TabPageHelp);
            this.TabControlCollection.Location = new System.Drawing.Point(12, 7);
            this.TabControlCollection.Name = "TabControlCollection";
            this.TabControlCollection.SelectedIndex = 0;
            this.TabControlCollection.Size = new System.Drawing.Size(619, 630);
            this.TabControlCollection.TabIndex = 19;
            // 
            // TabPageDashboard
            // 
            this.TabPageDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.TabPageDashboard.Controls.Add(this.LabelWelcomeUser);
            this.TabPageDashboard.Controls.Add(this.LabelTools);
            this.TabPageDashboard.Controls.Add(this.LabelGames);
            this.TabPageDashboard.Controls.Add(this.button12);
            this.TabPageDashboard.Controls.Add(this.button11);
            this.TabPageDashboard.Controls.Add(this.button10);
            this.TabPageDashboard.Controls.Add(this.button9);
            this.TabPageDashboard.Controls.Add(this.button8);
            this.TabPageDashboard.Controls.Add(this.button7);
            this.TabPageDashboard.Controls.Add(this.button6);
            this.TabPageDashboard.Controls.Add(this.button5);
            this.TabPageDashboard.Controls.Add(this.button4);
            this.TabPageDashboard.Controls.Add(this.button3);
            this.TabPageDashboard.Controls.Add(this.button2);
            this.TabPageDashboard.Controls.Add(this.button1);
            this.TabPageDashboard.Location = new System.Drawing.Point(4, 24);
            this.TabPageDashboard.Name = "TabPageDashboard";
            this.TabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDashboard.Size = new System.Drawing.Size(611, 602);
            this.TabPageDashboard.TabIndex = 0;
            this.TabPageDashboard.Text = "Dashboard";
            // 
            // LabelWelcomeUser
            // 
            this.LabelWelcomeUser.AutoSize = true;
            this.LabelWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelWelcomeUser.ForeColor = System.Drawing.Color.White;
            this.LabelWelcomeUser.Location = new System.Drawing.Point(8, 8);
            this.LabelWelcomeUser.Name = "LabelWelcomeUser";
            this.LabelWelcomeUser.Size = new System.Drawing.Size(142, 21);
            this.LabelWelcomeUser.TabIndex = 1;
            this.LabelWelcomeUser.Text = "Welcome, User x!";
            // 
            // LabelTools
            // 
            this.LabelTools.AutoSize = true;
            this.LabelTools.ForeColor = System.Drawing.Color.White;
            this.LabelTools.Location = new System.Drawing.Point(8, 67);
            this.LabelTools.Name = "LabelTools";
            this.LabelTools.Size = new System.Drawing.Size(34, 15);
            this.LabelTools.TabIndex = 1;
            this.LabelTools.Text = "Tools";
            // 
            // LabelGames
            // 
            this.LabelGames.AutoSize = true;
            this.LabelGames.ForeColor = System.Drawing.Color.White;
            this.LabelGames.Location = new System.Drawing.Point(8, 212);
            this.LabelGames.Name = "LabelGames";
            this.LabelGames.Size = new System.Drawing.Size(141, 15);
            this.LabelGames.TabIndex = 1;
            this.LabelGames.Text = "Recommendation Games";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button12.Location = new System.Drawing.Point(10, 94);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 75);
            this.button12.TabIndex = 15;
            this.button12.Text = "Google Chrome";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button11.Location = new System.Drawing.Point(274, 94);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 75);
            this.button11.TabIndex = 14;
            this.button11.Text = "Powerpoint";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button10.Location = new System.Drawing.Point(10, 241);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 75);
            this.button10.TabIndex = 15;
            this.button10.Text = "Valorant";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(98, 94);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 75);
            this.button9.TabIndex = 13;
            this.button9.Text = "Word";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(274, 241);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 75);
            this.button8.TabIndex = 14;
            this.button8.Text = "Dota 2";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(98, 241);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 75);
            this.button7.TabIndex = 13;
            this.button7.Text = "Point Blank";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(362, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 75);
            this.button6.TabIndex = 12;
            this.button6.Text = "Netflix";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(362, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 75);
            this.button5.TabIndex = 12;
            this.button5.Text = "CS:GO";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(186, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 75);
            this.button4.TabIndex = 11;
            this.button4.Text = "Excel";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(186, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 75);
            this.button3.TabIndex = 11;
            this.button3.Text = "Left4Dead";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(450, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 75);
            this.button2.TabIndex = 10;
            this.button2.Text = "Photoshop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(450, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 75);
            this.button1.TabIndex = 10;
            this.button1.Text = "Apex Legends";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TabPageShop
            // 
            this.TabPageShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.TabPageShop.Controls.Add(this.DataGridViewShop);
            this.TabPageShop.Location = new System.Drawing.Point(4, 24);
            this.TabPageShop.Name = "TabPageShop";
            this.TabPageShop.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageShop.Size = new System.Drawing.Size(611, 602);
            this.TabPageShop.TabIndex = 1;
            this.TabPageShop.Text = "Shop";
            // 
            // DataGridViewShop
            // 
            this.DataGridViewShop.AllowUserToAddRows = false;
            this.DataGridViewShop.AllowUserToDeleteRows = false;
            this.DataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewShopName,
            this.DataGridViewShopPrice});
            this.DataGridViewShop.Location = new System.Drawing.Point(17, 19);
            this.DataGridViewShop.Name = "DataGridViewShop";
            this.DataGridViewShop.ReadOnly = true;
            this.DataGridViewShop.RowTemplate.Height = 25;
            this.DataGridViewShop.Size = new System.Drawing.Size(255, 431);
            this.DataGridViewShop.TabIndex = 0;
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
            // TabPageTransaction
            // 
            this.TabPageTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.TabPageTransaction.Controls.Add(this.DataGridViewTransactionItems);
            this.TabPageTransaction.Controls.Add(this.DataGridViewTransactions);
            this.TabPageTransaction.Location = new System.Drawing.Point(4, 24);
            this.TabPageTransaction.Name = "TabPageTransaction";
            this.TabPageTransaction.Size = new System.Drawing.Size(611, 602);
            this.TabPageTransaction.TabIndex = 2;
            this.TabPageTransaction.Text = "Transaction";
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
            this.DataGridViewTransactionItems.Location = new System.Drawing.Point(263, 3);
            this.DataGridViewTransactionItems.Name = "DataGridViewTransactionItems";
            this.DataGridViewTransactionItems.ReadOnly = true;
            this.DataGridViewTransactionItems.RowTemplate.Height = 25;
            this.DataGridViewTransactionItems.Size = new System.Drawing.Size(335, 379);
            this.DataGridViewTransactionItems.TabIndex = 1;
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
            this.DataGridViewTransactions.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewTransactions.Name = "DataGridViewTransactions";
            this.DataGridViewTransactions.ReadOnly = true;
            this.DataGridViewTransactions.RowTemplate.Height = 25;
            this.DataGridViewTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTransactions.Size = new System.Drawing.Size(254, 379);
            this.DataGridViewTransactions.TabIndex = 0;
            this.DataGridViewTransactions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewTransactions_CellContentClick);
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
            // TabPageHelp
            // 
            this.TabPageHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.TabPageHelp.Controls.Add(this.label2);
            this.TabPageHelp.Controls.Add(this.label1);
            this.TabPageHelp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TabPageHelp.Location = new System.Drawing.Point(4, 24);
            this.TabPageHelp.Name = "TabPageHelp";
            this.TabPageHelp.Size = new System.Drawing.Size(611, 602);
            this.TabPageHelp.TabIndex = 3;
            this.TabPageHelp.Text = "Help";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDuration.ForeColor = System.Drawing.Color.OrangeRed;
            this.LabelDuration.Location = new System.Drawing.Point(763, 98);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(42, 31);
            this.LabelDuration.TabIndex = 17;
            this.LabelDuration.Text = "00";
            // 
            // LabelDurationInfo
            // 
            this.LabelDurationInfo.AutoSize = true;
            this.LabelDurationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDurationInfo.ForeColor = System.Drawing.Color.Red;
            this.LabelDurationInfo.Location = new System.Drawing.Point(638, 78);
            this.LabelDurationInfo.Name = "LabelDurationInfo";
            this.LabelDurationInfo.Size = new System.Drawing.Size(146, 16);
            this.LabelDurationInfo.TabIndex = 18;
            this.LabelDurationInfo.Text = "Minute(s) remaining:";
            // 
            // TimerControlDuration
            // 
            this.TimerControlDuration.Enabled = true;
            this.TimerControlDuration.Interval = 60000;
            this.TimerControlDuration.Tick += new System.EventHandler(this.TimerControlDuration_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Help";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Call/WA : 0822-8122-8100";
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(837, 657);
            this.Controls.Add(this.LabelDurationInfo);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.TabControlCollection);
            this.Name = "UserDashboardForm";
            this.Text = "User Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.TabControlCollection.ResumeLayout(false);
            this.TabPageDashboard.ResumeLayout(false);
            this.TabPageDashboard.PerformLayout();
            this.TabPageShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShop)).EndInit();
            this.TabPageTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactions)).EndInit();
            this.TabPageHelp.ResumeLayout(false);
            this.TabPageHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlCollection;
        private System.Windows.Forms.TabPage TabPageDashboard;
        private System.Windows.Forms.Label LabelWelcomeUser;
        private System.Windows.Forms.Label LabelTools;
        private System.Windows.Forms.Label LabelGames;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage TabPageShop;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.Label LabelDurationInfo;
        private System.Windows.Forms.TabPage TabPageTransaction;
        private System.Windows.Forms.TabPage TabPageHelp;
        private System.Windows.Forms.Timer TimerControlDuration;
        private System.Windows.Forms.DataGridView DataGridViewShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewShopPrice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView DataGridViewTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionsCreatedAt;
        private System.Windows.Forms.DataGridView DataGridViewTransactionItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTransactionItemsTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

