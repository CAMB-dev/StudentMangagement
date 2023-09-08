using StuMS;
using StuMS.Entity;

namespace StuMSGUI
{
    public partial class CourseManagementWindow : Form
    {
        public CourseManagementWindow()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            _courses = CourseCrud.GetCourses();
            _nowPage = 1;
            CounterLabel.Text = $"{1}/{_courses.Count}";
            if (_courses.Count != 0)
            {
                CourseNameTextBox.Text = _courses[_nowPage - 1].Name;
                TimeNumeric.Value = _courses[_nowPage - 1].CourseTime;
                ScoreNumeric.Value = _courses[_nowPage - 1].CourseStudyScore;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CourseNameTextBox.Text = string.Empty;
            TimeNumeric.Value = 0;
            ScoreNumeric.Value = 0;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CourseNameTextBox.Text))
            {
                MessageBox.Show("Course name cannot be empty.", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CourseCrud.DeleteCourse(CourseNameTextBox.Text);
            CourseCrud.AddCourse(new Course
            {
                Name = CourseNameTextBox.Text,
                CourseTime = (int)TimeNumeric.Value,
                CourseStudyScore = ScoreNumeric.Value,
            });

            Refresh();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CourseNameTextBox.Text))
            {
                MessageBox.Show("Course name cannot be empty.", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CourseCrud.DeleteCourse(CourseNameTextBox.Text);
            Refresh();
            MessageBox.Show("done");
        }

        private int _nowPage;
        private List<Course> _courses;

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (_nowPage == 1)
            {
                MessageBox.Show("no less than 1");
                return;
            }
            if (_courses.Count != 0)
            {
                _nowPage--;
                CourseNameTextBox.Text = _courses[_nowPage - 1].Name;
                TimeNumeric.Value = _courses[_nowPage - 1].CourseTime;
                ScoreNumeric.Value = _courses[_nowPage - 1].CourseStudyScore;
            }

            CounterLabel.Text = $"{_nowPage}/{_courses.Count}";
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (_nowPage == _courses.Count)
            {
                MessageBox.Show($"no more than {_courses.Count}");
                return;
            }
            if (_courses.Count != 0)
            {
                _nowPage++;
                CourseNameTextBox.Text = _courses[_nowPage - 1].Name;
                TimeNumeric.Value = _courses[_nowPage - 1].CourseTime;
                ScoreNumeric.Value = _courses[_nowPage - 1].CourseStudyScore;
            }

            CounterLabel.Text = $"{_nowPage}/{_courses.Count}";

        }

        private void CourseManagementWindow_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
