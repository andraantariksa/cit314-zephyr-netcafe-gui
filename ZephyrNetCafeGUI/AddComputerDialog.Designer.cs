namespace ZephyrNetCafeGUI
{
    partial class AddComputerDialog
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
            this.LabelPCName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxComputerName = new System.Windows.Forms.TextBox();
            this.RichTextBoxComputerSpec = new System.Windows.Forms.RichTextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelPCName
            // 
            this.LabelPCName.AutoSize = true;
            this.LabelPCName.Location = new System.Drawing.Point(24, 26);
            this.LabelPCName.Name = "LabelPCName";
            this.LabelPCName.Size = new System.Drawing.Size(96, 15);
            this.LabelPCName.TabIndex = 0;
            this.LabelPCName.Text = "Computer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Spec";
            // 
            // TextBoxComputerName
            // 
            this.TextBoxComputerName.Location = new System.Drawing.Point(126, 23);
            this.TextBoxComputerName.Name = "TextBoxComputerName";
            this.TextBoxComputerName.Size = new System.Drawing.Size(199, 23);
            this.TextBoxComputerName.TabIndex = 1;
            // 
            // RichTextBoxComputerSpec
            // 
            this.RichTextBoxComputerSpec.Location = new System.Drawing.Point(24, 104);
            this.RichTextBoxComputerSpec.Name = "RichTextBoxComputerSpec";
            this.RichTextBoxComputerSpec.Size = new System.Drawing.Size(301, 157);
            this.RichTextBoxComputerSpec.TabIndex = 2;
            this.RichTextBoxComputerSpec.Text = "";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(57, 268);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(87, 28);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(201, 267);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(88, 29);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddComputerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.RichTextBoxComputerSpec);
            this.Controls.Add(this.TextBoxComputerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelPCName);
            this.Name = "AddComputerDialog";
            this.Size = new System.Drawing.Size(342, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxComputerName;
        private System.Windows.Forms.RichTextBox RichTextBoxComputerSpec;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClose;
    }
}
