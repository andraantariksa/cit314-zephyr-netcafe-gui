
namespace ZephyrNetCafeGUI
{
    partial class AddComputerForm
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
            this.RichTextBoxComputerSpec = new System.Windows.Forms.RichTextBox();
            this.TextBoxComputerName = new System.Windows.Forms.TextBox();
            this.LabelPCName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTextBoxComputerSpec
            // 
            this.RichTextBoxComputerSpec.Location = new System.Drawing.Point(12, 71);
            this.RichTextBoxComputerSpec.Name = "RichTextBoxComputerSpec";
            this.RichTextBoxComputerSpec.Size = new System.Drawing.Size(301, 157);
            this.RichTextBoxComputerSpec.TabIndex = 3;
            this.RichTextBoxComputerSpec.Text = "";
            // 
            // TextBoxComputerName
            // 
            this.TextBoxComputerName.Location = new System.Drawing.Point(12, 27);
            this.TextBoxComputerName.Name = "TextBoxComputerName";
            this.TextBoxComputerName.Size = new System.Drawing.Size(300, 23);
            this.TextBoxComputerName.TabIndex = 4;
            // 
            // LabelPCName
            // 
            this.LabelPCName.AutoSize = true;
            this.LabelPCName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelPCName.Location = new System.Drawing.Point(12, 9);
            this.LabelPCName.Name = "LabelPCName";
            this.LabelPCName.Size = new System.Drawing.Size(96, 15);
            this.LabelPCName.TabIndex = 5;
            this.LabelPCName.Text = "Computer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Computer Spec";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAdd.Location = new System.Drawing.Point(132, 233);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(87, 34);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonClose.Location = new System.Drawing.Point(225, 234);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(88, 32);
            this.ButtonClose.TabIndex = 8;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(324, 276);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelPCName);
            this.Controls.Add(this.TextBoxComputerName);
            this.Controls.Add(this.RichTextBoxComputerSpec);
            this.Name = "AddComputerForm";
            this.Text = "Add Computer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddComputerForm_FormClosed);
            this.Load += new System.EventHandler(this.AddComputerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBoxComputerSpec;
        private System.Windows.Forms.TextBox TextBoxComputerName;
        private System.Windows.Forms.Label LabelPCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClose;
    }
}