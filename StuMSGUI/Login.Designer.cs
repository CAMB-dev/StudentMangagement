namespace StuMSGUI
{
    partial class Login
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
            LoginBtn = new Button();
            UserNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(69, 246);
            LoginBtn.Margin = new Padding(5, 4, 5, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(201, 68);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(160, 80);
            UserNameTextBox.Margin = new Padding(5, 4, 5, 4);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(425, 30);
            UserNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 85);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 24);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 154);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(160, 150);
            PasswordTextBox.Margin = new Padding(5, 4, 5, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '•';
            PasswordTextBox.Size = new Size(425, 30);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.KeyPress += PasswordTextBox_KeyPress;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(394, 246);
            ExitBtn.Margin = new Padding(5, 4, 5, 4);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(193, 68);
            ExitBtn.TabIndex = 5;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 353);
            ControlBox = false;
            Controls.Add(ExitBtn);
            Controls.Add(label2);
            Controls.Add(PasswordTextBox);
            Controls.Add(label1);
            Controls.Add(UserNameTextBox);
            Controls.Add(LoginBtn);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private TextBox UserNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox PasswordTextBox;
        private Button ExitBtn;
    }
}