namespace AddressBook
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonSave;

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(16, 18);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(249, 27);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.PlaceholderText = "Name";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(16, 58);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(249, 27);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.PlaceholderText = "Email";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(16, 98);
            textBoxPhone.Margin = new Padding(4, 5, 4, 5);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(249, 27);
            textBoxPhone.TabIndex = 2;
            textBoxPhone.PlaceholderText = "Phone";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(68, 149);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 35);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 402);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
