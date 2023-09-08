namespace StuMSGUI
{
    partial class ScoreManagementWindow
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
            StuLabel = new Label();
            StuListView = new ListView();
            placeholder = new ColumnHeader();
            CourseName = new ColumnHeader();
            Score = new ColumnHeader();
            DelBtn = new Button();
            AddUpdateBtn = new Button();
            SuspendLayout();
            // 
            // StuLabel
            // 
            StuLabel.AutoSize = true;
            StuLabel.Location = new Point(24, 22);
            StuLabel.Name = "StuLabel";
            StuLabel.Size = new Size(47, 24);
            StuLabel.TabIndex = 0;
            StuLabel.Text = "Stu: ";
            // 
            // StuListView
            // 
            StuListView.Columns.AddRange(new ColumnHeader[] { placeholder, CourseName, Score });
            StuListView.FullRowSelect = true;
            StuListView.GridLines = true;
            StuListView.Location = new Point(24, 167);
            StuListView.Margin = new Padding(5, 4, 5, 4);
            StuListView.Name = "StuListView";
            StuListView.Size = new Size(667, 525);
            StuListView.TabIndex = 5;
            StuListView.UseCompatibleStateImageBehavior = false;
            StuListView.View = View.Details;
            // 
            // placeholder
            // 
            placeholder.Width = 0;
            // 
            // CourseName
            // 
            CourseName.Text = "CourseName";
            CourseName.TextAlign = HorizontalAlignment.Center;
            CourseName.Width = 400;
            // 
            // Score
            // 
            Score.Text = "Score";
            Score.TextAlign = HorizontalAlignment.Center;
            Score.Width = 200;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(531, 66);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(160, 34);
            DelBtn.TabIndex = 6;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // AddUpdateBtn
            // 
            AddUpdateBtn.Location = new Point(531, 17);
            AddUpdateBtn.Name = "AddUpdateBtn";
            AddUpdateBtn.Size = new Size(160, 34);
            AddUpdateBtn.TabIndex = 7;
            AddUpdateBtn.Text = "Add/Update";
            AddUpdateBtn.UseVisualStyleBackColor = true;
            AddUpdateBtn.Click += AddBtn_Click;
            // 
            // ScoreManagementWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 705);
            Controls.Add(AddUpdateBtn);
            Controls.Add(DelBtn);
            Controls.Add(StuListView);
            Controls.Add(StuLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScoreManagementWindow";
            Text = "ScoreManagementWindow";
            Load += ScoreManagementWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StuLabel;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button UpdateBtn;
        private ListView StuListView;
        private ColumnHeader placeholder;
        private ColumnHeader CourseName;
        private ColumnHeader Score;
        private ColumnHeader columnHeader1;
        private Button DelBtn;
        private Button AddUpdateBtn;
    }
}