using StuMS;
using StuMS.Entity;
using System.Data;

namespace StuMSGUI
{
    public partial class ScoreModifyWindow : Form
    {
        public ScoreModifyWindow()
        {
            InitializeComponent();
        }

        private Student student;
        private List<Course> course = CourseCrud.GetCourses();

        public void Init(Student stu)
        {
            this.student = stu;
        }

        private void ScoreModifyWindow_Load(object sender, EventArgs e)
        {
            StuLabel.Text += student.Name;
            CourseComboBox.Items.AddRange(student.Courses.Select(x => x.Name).ToArray());
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ca = student.Courses.Where(
                x => x.Name == CourseComboBox.SelectedItem.ToString()
                ).ToArray();

            if (ca.Length != 0)
            {
                var s = student.Score.Where(x => x.Course == ca[0]).ToArray();
                if (s.Length == 0)
                {
                    student.Score.Add(new Score
                    {
                        Course = ca[0]
                    });
                }
                else
                {
                    ScoreNumeric.Value = s[0].CourseScore;
                }
            }
        }

        private void ScoreNumeric_ValueChanged(object sender, EventArgs e)
        {
            student.Score.ForEach(x =>
            {
                if (x.Course.Name == CourseComboBox.SelectedItem)
                {
                    x.CourseScore = ScoreNumeric.Value;
                }
            });
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ScoreManagementWindow.SetStudent(student);
            this.Close();
        }
    }
}
