namespace ZephyrNetCafeGUI
{
    partial class AddShopItemDialog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.NumericPrice = new System.Windows.Forms.NumericUpDown();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(43, 44);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(66, 15);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Item Name";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(43, 84);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(33, 15);
            this.LabelPrice.TabIndex = 0;
            this.LabelPrice.Text = "Price";
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.Location = new System.Drawing.Point(43, 124);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(53, 15);
            this.LabelQuantity.TabIndex = 0;
            this.LabelQuantity.Text = "Quantity";
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.Location = new System.Drawing.Point(136, 122);
            this.NumericQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(120, 23);
            this.NumericQuantity.TabIndex = 1;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(136, 41);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(180, 23);
            this.TextBoxName.TabIndex = 2;
            // 
            // NumericPrice
            // 
            this.NumericPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericPrice.Location = new System.Drawing.Point(136, 82);
            this.NumericPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericPrice.Name = "NumericPrice";
            this.NumericPrice.Size = new System.Drawing.Size(120, 23);
            this.NumericPrice.TabIndex = 3;
            this.NumericPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(57, 170);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(99, 38);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(217, 170);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(99, 38);
            this.ButtonClose.TabIndex = 4;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddShopItemDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.NumericPrice);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.NumericQuantity);
            this.Controls.Add(this.LabelQuantity);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelName);
            this.Name = "AddShopItemDialog";
            this.Size = new System.Drawing.Size(375, 234);
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.NumericUpDown NumericPrice;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClose;
    }
}
