namespace StuMSGUI
{
    partial class MainWindow
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
            PermissionLabel = new Label();
            OperationTabControl = new TabControl();
            tabPage1 = new TabPage();
            EditProfileBtn = new Button();
            QueryScoreBtn = new Button();
            tabPage2 = new TabPage();
            StuListView = new ListView();
            placeholder = new ColumnHeader();
            StuName = new ColumnHeader();
            Age = new ColumnHeader();
            Gender = new ColumnHeader();
            StuID = new ColumnHeader();
            Role = new ColumnHeader();
            Courses = new ColumnHeader();
            AddBtn = new Button();
            DeleteBtn = new Button();
            ModifyBtn = new Button();
            QueryBtn = new Button();
            CourseManageBtn = new Button();
            ScoreBtn = new Button();
            CourseBtn = new Button();
            OperationTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // PermissionLabel
            // 
            PermissionLabel.AutoSize = true;
            PermissionLabel.Location = new Point(19, 13);
            PermissionLabel.Margin = new Padding(5, 0, 5, 0);
            PermissionLabel.Name = "PermissionLabel";
            PermissionLabel.Size = new Size(112, 24);
            PermissionLabel.TabIndex = 0;
            PermissionLabel.Text = "Permission: ";
            // 
            // OperationTabControl
            // 
            OperationTabControl.Controls.Add(tabPage1);
            OperationTabControl.Controls.Add(tabPage2);
            OperationTabControl.Location = new Point(20, 41);
            OperationTabControl.Margin = new Padding(5, 4, 5, 4);
            OperationTabControl.Name = "OperationTabControl";
            OperationTabControl.SelectedIndex = 0;
            OperationTabControl.Size = new Size(927, 432);
            OperationTabControl.SizeMode = TabSizeMode.FillToRight;
            OperationTabControl.TabIndex = 1;
            OperationTabControl.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(EditProfileBtn);
            tabPage1.Controls.Add(QueryScoreBtn);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(919, 395);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // EditProfileBtn
            // 
            EditProfileBtn.Location = new Point(440, 158);
            EditProfileBtn.Margin = new Padding(5, 4, 5, 4);
            EditProfileBtn.Name = "EditProfileBtn";
            EditProfileBtn.Size = new Size(181, 48);
            EditProfileBtn.TabIndex = 1;
            EditProfileBtn.Text = "EditProfile";
            EditProfileBtn.UseVisualStyleBackColor = true;
            EditProfileBtn.Click += EditProfileBtn_Click;
            // 
            // QueryScoreBtn
            // 
            QueryScoreBtn.Location = new Point(225, 158);
            QueryScoreBtn.Margin = new Padding(5, 4, 5, 4);
            QueryScoreBtn.Name = "QueryScoreBtn";
            QueryScoreBtn.Size = new Size(170, 48);
            QueryScoreBtn.TabIndex = 0;
            QueryScoreBtn.Text = "QueryScore";
            QueryScoreBtn.UseVisualStyleBackColor = true;
            QueryScoreBtn.Click += QueryScoreBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(StuListView);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Margin = new Padding(5, 4, 5, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(919, 395);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Administrator";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // StuListView
            // 
            StuListView.Columns.AddRange(new ColumnHeader[] { placeholder, StuName, Age, Gender, StuID, Role, Courses });
            StuListView.FullRowSelect = true;
            StuListView.GridLines = true;
            StuListView.Location = new Point(5, 4);
            StuListView.Margin = new Padding(5, 4, 5, 4);
            StuListView.Name = "StuListView";
            StuListView.Size = new Size(903, 380);
            StuListView.TabIndex = 0;
            StuListView.UseCompatibleStateImageBehavior = false;
            StuListView.View = View.Details;
            // 
            // placeholder
            // 
            placeholder.Width = 0;
            // 
            // StuName
            // 
            StuName.Text = "Name";
            StuName.TextAlign = HorizontalAlignment.Center;
            StuName.Width = 100;
            // 
            // Age
            // 
            Age.Text = "Age";
            Age.TextAlign = HorizontalAlignment.Center;
            Age.Width = 100;
            // 
            // Gender
            // 
            Gender.Text = "Gender";
            Gender.TextAlign = HorizontalAlignment.Center;
            Gender.Width = 100;
            // 
            // StuID
            // 
            StuID.Text = "StuID";
            StuID.TextAlign = HorizontalAlignment.Center;
            StuID.Width = 100;
            // 
            // Role
            // 
            Role.Text = "Role";
            Role.TextAlign = HorizontalAlignment.Center;
            Role.Width = 120;
            // 
            // Courses
            // 
            Courses.Text = "Courses";
            Courses.TextAlign = HorizontalAlignment.Center;
            Courses.Width = 550;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(784, 17);
            AddBtn.Margin = new Padding(5, 4, 5, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(116, 45);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Visible = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(662, 17);
            DeleteBtn.Margin = new Padding(5, 4, 5, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(113, 45);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Visible = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ModifyBtn
            // 
            ModifyBtn.Location = new Point(536, 17);
            ModifyBtn.Margin = new Padding(5, 4, 5, 4);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(113, 45);
            ModifyBtn.TabIndex = 4;
            ModifyBtn.Text = "Modify";
            ModifyBtn.UseVisualStyleBackColor = true;
            ModifyBtn.Visible = false;
            ModifyBtn.Click += ModifyBtn_Click;
            // 
            // QueryBtn
            // 
            QueryBtn.Location = new Point(405, 17);
            QueryBtn.Margin = new Padding(5, 4, 5, 4);
            QueryBtn.Name = "QueryBtn";
            QueryBtn.Size = new Size(118, 45);
            QueryBtn.TabIndex = 5;
            QueryBtn.Text = "Query";
            QueryBtn.UseVisualStyleBackColor = true;
            QueryBtn.Visible = false;
            QueryBtn.Click += QueryBtn_Click;
            // 
            // CourseManageBtn
            // 
            CourseManageBtn.Location = new Point(910, 17);
            CourseManageBtn.Margin = new Padding(5, 4, 5, 4);
            CourseManageBtn.Name = "CourseManageBtn";
            CourseManageBtn.Size = new Size(267, 45);
            CourseManageBtn.TabIndex = 6;
            CourseManageBtn.Text = "Course Management";
            CourseManageBtn.UseVisualStyleBackColor = true;
            CourseManageBtn.Visible = false;
            CourseManageBtn.Click += CourseManageBtn_Click;
            // 
            // ScoreBtn
            // 
            ScoreBtn.Location = new Point(1194, 17);
            ScoreBtn.Name = "ScoreBtn";
            ScoreBtn.Size = new Size(138, 45);
            ScoreBtn.TabIndex = 7;
            ScoreBtn.Text = "Score";
            ScoreBtn.UseVisualStyleBackColor = true;
            ScoreBtn.Visible = false;
            ScoreBtn.Click += ScoreBtn_Click;
            // 
            // CourseBtn
            // 
            CourseBtn.Location = new Point(1348, 17);
            CourseBtn.Name = "CourseBtn";
            CourseBtn.Size = new Size(125, 45);
            CourseBtn.TabIndex = 8;
            CourseBtn.Text = "Course";
            CourseBtn.UseVisualStyleBackColor = true;
            CourseBtn.Click += CourseBtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 490);
            Controls.Add(CourseBtn);
            Controls.Add(ScoreBtn);
            Controls.Add(CourseManageBtn);
            Controls.Add(QueryBtn);
            Controls.Add(ModifyBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(OperationTabControl);
            Controls.Add(PermissionLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "MainWindow";
            FormClosing += MainWindow_FormClosing;
            OperationTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PermissionLabel;
        private TabControl OperationTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button EditProfileBtn;
        private Button QueryScoreBtn;
        private ListView StuListView;
        private ColumnHeader placeholder;
        private ColumnHeader StuName;
        private ColumnHeader Age;
        private ColumnHeader Gender;
        private ColumnHeader StuID;
        private ColumnHeader Courses;
        private Button AddBtn;
        private Button DeleteBtn;
        private Button ModifyBtn;
        private Button QueryBtn;
        private ColumnHeader Role;
        private Button CourseManageBtn;
        private Button ScoreBtn;
        private Button CourseBtn;
    }
}