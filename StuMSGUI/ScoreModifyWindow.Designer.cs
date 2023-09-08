namespace StuMSGUI
{
    partial class ScoreModifyWindow
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
            OkBtn = new Button();
            CourseComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ScoreNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ScoreNumeric).BeginInit();
            SuspendLayout();
            // 
            // StuLabel
            // 
            StuLabel.AutoSize = true;
            StuLabel.Location = new Point(12, 9);
            StuLabel.Name = "StuLabel";
            StuLabel.Size = new Size(47, 24);
            StuLabel.TabIndex = 0;
            StuLabel.Text = "Stu: ";
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(299, 222);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(112, 34);
            OkBtn.TabIndex = 1;
            OkBtn.Text = "ok";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // CourseComboBox
            // 
            CourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Location = new Point(248, 60);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(327, 32);
            CourseComboBox.TabIndex = 2;
            CourseComboBox.SelectedIndexChanged += CourseComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 63);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 3;
            label2.Text = "Course";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 137);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 4;
            label3.Text = "Score";
            // 
            // ScoreNumeric
            // 
            ScoreNumeric.DecimalPlaces = 2;
            ScoreNumeric.Location = new Point(248, 137);
            ScoreNumeric.Name = "ScoreNumeric";
            ScoreNumeric.Size = new Size(327, 30);
            ScoreNumeric.TabIndex = 5;
            ScoreNumeric.ValueChanged += ScoreNumeric_ValueChanged;
            // 
            // ScoreModifyWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 284);
            Controls.Add(ScoreNumeric);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CourseComboBox);
            Controls.Add(OkBtn);
            Controls.Add(StuLabel);
            Name = "ScoreModifyWindow";
            Text = "ScoreModifyWindow";
            Load += ScoreModifyWindow_Load;
            ((System.ComponentModel.ISupportInitialize)ScoreNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StuLabel;
        private Button OkBtn;
        private ComboBox CourseComboBox;
        private Label label2;
        private Label label3;
        private NumericUpDown ScoreNumeric;
    }
}