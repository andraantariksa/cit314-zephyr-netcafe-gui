
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
            this.ColumnItemComputerIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
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
            this.TabControlComputer.SuspendLayout();
            this.TabPageComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerActive)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlComputer
            // 
            this.TabControlComputer.Controls.Add(this.TabPageComputer);
            this.TabControlComputer.Controls.Add(this.tabPage3);
            this.TabControlComputer.Controls.Add(this.tabPage2);
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
            this.ColumnItemComputerSpec,
            this.ColumnItemComputerIsDeleted});
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
            // ColumnItemComputerIsDeleted
            // 
            this.ColumnItemComputerIsDeleted.HeaderText = "IsDeleted";
            this.ColumnItemComputerIsDeleted.Name = "ColumnItemComputerIsDeleted";
            this.ColumnItemComputerIsDeleted.ReadOnly = true;
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
            this.LabelWelcomeAdmin.Location = new System.Drawing.Point(30, 23);
            this.LabelWelcomeAdmin.Name = "LabelWelcomeAdmin";
            this.LabelWelcomeAdmin.Size = new System.Drawing.Size(122, 15);
            this.LabelWelcomeAdmin.TabIndex = 0;
            this.LabelWelcomeAdmin.Text = "Welcome, Manager x!";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.vScrollBar3);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1254, 737);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shop Items Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(1083, 56);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(17, 439);
            this.vScrollBar3.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(749, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 37);
            this.button5.TabIndex = 2;
            this.button5.Text = "Add Item";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(868, 511);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "Edit Item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(987, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(33, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1067, 439);
            this.dataGridView2.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Shop Items Management";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.vScrollBar2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 737);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(1082, 61);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 448);
            this.vScrollBar2.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(867, 515);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 37);
            this.button6.TabIndex = 4;
            this.button6.Text = "Edit User";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(986, 515);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 37);
            this.button7.TabIndex = 5;
            this.button7.Text = "Delete User";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(29, 61);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1070, 448);
            this.dataGridView4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Management";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.vScrollBar1);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1254, 737);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transaction Report Management";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1078, 67);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 485);
            this.vScrollBar1.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(33, 67);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1062, 485);
            this.dataGridView3.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Transaction Report Management";
            // 
            // TimerControlComputerActive
            // 
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
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 673);
            this.Controls.Add(this.TabControlComputer);
            this.Name = "AdminDashboardForm";
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.EnabledChanged += new System.EventHandler(this.AdminDashboardForm_EnabledChanged);
            this.TabControlComputer.ResumeLayout(false);
            this.TabPageComputer.ResumeLayout(false);
            this.TabPageComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComputerActive)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlComputer;
        private System.Windows.Forms.TabPage TabPageComputer;
        private System.Windows.Forms.Label LabelActiveComputer;
        private System.Windows.Forms.Label LabelWelcomeAdmin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Timer TimerControlComputerActive;
        private System.Windows.Forms.DataGridView DataGridViewComputerActive;
        private System.Windows.Forms.Label LabelComputerItem;
        private System.Windows.Forms.DataGridView DataGridViewComputerItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemComputerIsDeleted;
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
    }
}