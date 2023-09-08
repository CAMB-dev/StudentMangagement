using StuMS;
using StuMS.Entity;

namespace StuMSGUI
{
    public partial class ScoreManagementWindow : Form
    {
        public ScoreManagementWindow()
        {
            InitializeComponent();
        }

        private static Student student = new Student();

        public static void SetStudent(Student stu)
        {
            student = stu;
        }

        public void Refresh()
        {
            StuListView.Items.Clear();

            SetStudent(StuCrud.GetStudentFirstOrDefault(student.StuID));

            foreach (var item in student.Score)
            {
                StuListView.Items.Add(
                    new ListViewItem(
                        new string[]
                        {
                            "",
                            item.Course.Name,
                            item.CourseScore.ToString()
                        }
                        )
                    );
            }
        }

        private void ScoreManagementWindow_Load(object sender, EventArgs e)
        {
            StuLabel.Text += student.Name;
            Refresh();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ScoreModifyWindow scoreModifyWindow = new ScoreModifyWindow();
            scoreModifyWindow.Init(student);
            scoreModifyWindow.ShowDialog();
            StuCrud.UpdateStudent(student.StuID, x =>
            {
                x = student;
            });
            Refresh();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (StuListView.SelectedItems == null || StuListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Invalid Select", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in StuListView.SelectedItems)
            {
                StuCrud.UpdateStudent(student.StuID, x =>
                {
                    x.Score.RemoveAll(y => y.Course.Name == item.SubItems[1].Text);
                });
            }

            Refresh();
        }
    }
}
