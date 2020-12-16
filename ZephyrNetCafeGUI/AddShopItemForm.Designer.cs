
namespace ZephyrNetCafeGUI
{
    partial class AddShopItemForm
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
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.NumericPrice = new System.Windows.Forms.NumericUpDown();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(179, 83);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(99, 38);
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(19, 83);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(99, 38);
            this.ButtonAdd.TabIndex = 12;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // NumericPrice
            // 
            this.NumericPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericPrice.Location = new System.Drawing.Point(110, 54);
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
            this.NumericPrice.TabIndex = 10;
            this.NumericPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(110, 13);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(180, 23);
            this.TextBoxName.TabIndex = 9;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(17, 56);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(33, 15);
            this.LabelPrice.TabIndex = 6;
            this.LabelPrice.Text = "Price";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(17, 16);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(66, 15);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "Item Name";
            // 
            // AddShopItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 135);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.NumericPrice);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelName);
            this.Name = "AddShopItemForm";
            this.Text = "AddItemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddShopItemForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.NumericUpDown NumericPrice;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelName;
    }
}