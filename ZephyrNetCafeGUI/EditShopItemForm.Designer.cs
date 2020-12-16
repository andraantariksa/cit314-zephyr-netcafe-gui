
namespace ZephyrNetCafeGUI
{
    partial class EditShopItemForm
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
            this.ButtonSave = new System.Windows.Forms.Button();
            this.NumericPrice = new System.Windows.Forms.NumericUpDown();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(179, 97);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(116, 33);
            this.ButtonClose.TabIndex = 8;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(11, 97);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(116, 33);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Save Changes";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // NumericPrice
            // 
            this.NumericPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericPrice.Location = new System.Drawing.Point(91, 57);
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
            this.NumericPrice.TabIndex = 7;
            this.NumericPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(91, 12);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(184, 23);
            this.TextBoxName.TabIndex = 6;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPrice.Location = new System.Drawing.Point(11, 57);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(67, 17);
            this.LabelPrice.TabIndex = 4;
            this.LabelPrice.Text = "Edit Price:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelName.Location = new System.Drawing.Point(11, 13);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(74, 17);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Edit Name:";
            // 
            // EditShopItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 143);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.NumericPrice);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelName);
            this.Name = "EditShopItemForm";
            this.Text = "EditShopItemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditShopItemForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.NumericUpDown NumericPrice;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelName;
    }
}