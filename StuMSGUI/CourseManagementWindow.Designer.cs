namespace StuMSGUI
{
    partial class CourseManagementWindow
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PrevBtn = new Button();
            NextBtn = new Button();
            SaveBtn = new Button();
            AddBtn = new Button();
            DeleteBtn = new Button();
            ExitBtn = new Button();
            CourseNameTextBox = new TextBox();
            TimeNumeric = new NumericUpDown();
            ScoreNumeric = new NumericUpDown();
            CounterLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)TimeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScoreNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "CourseName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 66);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 1;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 110);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 2;
            label3.Text = "Score";
            // 
            // PrevBtn
            // 
            PrevBtn.Location = new Point(108, 166);
            PrevBtn.Name = "PrevBtn";
            PrevBtn.Size = new Size(32, 23);
            PrevBtn.TabIndex = 3;
            PrevBtn.Text = "<";
            PrevBtn.UseVisualStyleBackColor = true;
            PrevBtn.Click += PrevBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.Location = new Point(227, 166);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(32, 23);
            NextBtn.TabIndex = 4;
            NextBtn.Text = ">";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(251, 208);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(29, 208);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(29, 251);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(251, 251);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 8;
            ExitBtn.Text = "ok";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // CourseNameTextBox
            // 
            CourseNameTextBox.Location = new Point(130, 20);
            CourseNameTextBox.Name = "CourseNameTextBox";
            CourseNameTextBox.Size = new Size(159, 23);
            CourseNameTextBox.TabIndex = 9;
            // 
            // TimeNumeric
            // 
            TimeNumeric.Location = new Point(83, 64);
            TimeNumeric.Name = "TimeNumeric";
            TimeNumeric.Size = new Size(120, 23);
            TimeNumeric.TabIndex = 10;
            // 
            // ScoreNumeric
            // 
            ScoreNumeric.DecimalPlaces = 1;
            ScoreNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ScoreNumeric.Location = new Point(83, 108);
            ScoreNumeric.Name = "ScoreNumeric";
            ScoreNumeric.Size = new Size(120, 23);
            ScoreNumeric.TabIndex = 11;
            // 
            // CounterLabel
            // 
            CounterLabel.AutoSize = true;
            CounterLabel.Location = new Point(160, 172);
            CounterLabel.Name = "CounterLabel";
            CounterLabel.Size = new Size(37, 17);
            CounterLabel.TabIndex = 12;
            CounterLabel.Text = "-1/-1";
            // 
            // CourseManagementWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 286);
            Controls.Add(CounterLabel);
            Controls.Add(ScoreNumeric);
            Controls.Add(TimeNumeric);
            Controls.Add(CourseNameTextBox);
            Controls.Add(ExitBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(SaveBtn);
            Controls.Add(NextBtn);
            Controls.Add(PrevBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CourseManagementWindow";
            Text = "CourseManagementWindow";
            Load += CourseManagementWindow_Load;
            ((System.ComponentModel.ISupportInitialize)TimeNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScoreNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button PrevBtn;
        private Button NextBtn;
        private Button SaveBtn;
        private Button AddBtn;
        private Button DeleteBtn;
        private Button ExitBtn;
        private TextBox CourseNameTextBox;
        private NumericUpDown TimeNumeric;
        private NumericUpDown ScoreNumeric;
        private Label CounterLabel;
    }
}