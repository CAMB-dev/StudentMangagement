namespace StuMSGUI
{
    partial class InfoWindow
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
            ModeLabel = new Label();
            label2 = new Label();
            NameTextBox = new TextBox();
            StuIDTextBox = new TextBox();
            label3 = new Label();
            GenderComboBox = new ComboBox();
            AgeNumeric = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            PermissionComboBox = new ComboBox();
            label6 = new Label();
            OkBtn = new Button();
            label8 = new Label();
            PasswordTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AgeNumeric).BeginInit();
            SuspendLayout();
            // 
            // ModeLabel
            // 
            ModeLabel.AutoSize = true;
            ModeLabel.Location = new Point(19, 13);
            ModeLabel.Margin = new Padding(5, 0, 5, 0);
            ModeLabel.Name = "ModeLabel";
            ModeLabel.Size = new Size(65, 24);
            ModeLabel.TabIndex = 0;
            ModeLabel.Text = "Mode:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 79);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(193, 79);
            NameTextBox.Margin = new Padding(5, 4, 5, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(482, 30);
            NameTextBox.TabIndex = 2;
            // 
            // StuIDTextBox
            // 
            StuIDTextBox.Location = new Point(193, 246);
            StuIDTextBox.Margin = new Padding(5, 4, 5, 4);
            StuIDTextBox.Name = "StuIDTextBox";
            StuIDTextBox.Size = new Size(482, 30);
            StuIDTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 137);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 24);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderComboBox.Location = new Point(193, 133);
            GenderComboBox.Margin = new Padding(5, 4, 5, 4);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(222, 32);
            GenderComboBox.TabIndex = 5;
            // 
            // AgeNumeric
            // 
            AgeNumeric.Location = new Point(193, 192);
            AgeNumeric.Margin = new Padding(5, 4, 5, 4);
            AgeNumeric.Name = "AgeNumeric";
            AgeNumeric.Size = new Size(189, 30);
            AgeNumeric.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 195);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 24);
            label4.TabIndex = 11;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 250);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 24);
            label5.TabIndex = 10;
            label5.Text = "StuID";
            // 
            // PermissionComboBox
            // 
            PermissionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PermissionComboBox.FormattingEnabled = true;
            PermissionComboBox.Items.AddRange(new object[] { "User", "Administrator" });
            PermissionComboBox.Location = new Point(193, 302);
            PermissionComboBox.Margin = new Padding(5, 4, 5, 4);
            PermissionComboBox.Name = "PermissionComboBox";
            PermissionComboBox.Size = new Size(222, 32);
            PermissionComboBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 306);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 24);
            label6.TabIndex = 12;
            label6.Text = "Permission";
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(317, 445);
            OkBtn.Margin = new Padding(5, 4, 5, 4);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(118, 32);
            OkBtn.TabIndex = 14;
            OkBtn.Text = "ok";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 361);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 24);
            label8.TabIndex = 17;
            label8.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(193, 361);
            PasswordTextBox.Margin = new Padding(5, 4, 5, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(482, 30);
            PasswordTextBox.TabIndex = 18;
            // 
            // InfoWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 520);
            Controls.Add(PasswordTextBox);
            Controls.Add(label8);
            Controls.Add(OkBtn);
            Controls.Add(PermissionComboBox);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(AgeNumeric);
            Controls.Add(GenderComboBox);
            Controls.Add(StuIDTextBox);
            Controls.Add(label3);
            Controls.Add(NameTextBox);
            Controls.Add(label2);
            Controls.Add(ModeLabel);
            Margin = new Padding(5, 4, 5, 4);
            Name = "InfoWindow";
            Text = "UpdateWindow";
            Load += InfoWindow_Load;
            ((System.ComponentModel.ISupportInitialize)AgeNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox NameTextBox;
        private TextBox StuIDTextBox;
        private Label label3;
        private ComboBox GenderComboBox;
        private NumericUpDown AgeNumeric;
        private Label label4;
        private Label label5;
        private ComboBox PermissionComboBox;
        private Label label6;
        private Button OkBtn;
        private Label label8;
        private TextBox PasswordTextBox;
        private Label ModeLabel;
    }
}