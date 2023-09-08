namespace StuMSGUI
{
    partial class CourseWindow
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
            CourseCheckedListBox = new CheckedListBox();
            OkBtn = new Button();
            StuLabel = new Label();
            SuspendLayout();
            // 
            // CourseCheckedListBox
            // 
            CourseCheckedListBox.FormattingEnabled = true;
            CourseCheckedListBox.Location = new Point(27, 55);
            CourseCheckedListBox.MultiColumn = true;
            CourseCheckedListBox.Name = "CourseCheckedListBox";
            CourseCheckedListBox.Size = new Size(731, 517);
            CourseCheckedListBox.TabIndex = 0;
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(342, 604);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(112, 34);
            OkBtn.TabIndex = 1;
            OkBtn.Text = "ok";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // StuLabel
            // 
            StuLabel.AutoSize = true;
            StuLabel.Location = new Point(12, 9);
            StuLabel.Name = "StuLabel";
            StuLabel.Size = new Size(47, 24);
            StuLabel.TabIndex = 2;
            StuLabel.Text = "Stu: ";
            // 
            // CourseWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 664);
            Controls.Add(StuLabel);
            Controls.Add(OkBtn);
            Controls.Add(CourseCheckedListBox);
            Name = "CourseWindow";
            Text = "CourseWindow";
            Load += CourseWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox CourseCheckedListBox;
        private Button OkBtn;
        private Label StuLabel;
    }
}