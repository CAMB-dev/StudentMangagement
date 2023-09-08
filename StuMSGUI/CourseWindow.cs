using StuMS;
using StuMS.Entity;

namespace StuMSGUI
{
    public partial class CourseWindow : Form
    {
        public CourseWindow()
        {
            InitializeComponent();
        }

        private Student student;
        private List<Course> courses = CourseCrud.GetCourses();

        public void Init(Student student)
        {
            this.student = student;
        }

        private void CourseWindow_Load(object sender, EventArgs e)
        {
            StuLabel.Text += student.Name;
            courses.ForEach(
                c =>
                {
                    CourseCheckedListBox.Items.Add(c.Name, false);
                }
                );
            student.Courses.ForEach(
                c =>
                {
                    CourseCheckedListBox.SetItemChecked(CourseCheckedListBox.Items.IndexOf(c.Name), true);
                }
                );
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            student.Courses.Clear();
            List<Course> cl = new List<Course>();
            foreach (int item in CourseCheckedListBox.CheckedIndices)
            {
                cl.Add(CourseCrud.GetCourseFirstOrDefault(CourseCheckedListBox.Items[item].ToString()));
            }
            StuCrud.UpdateStudent(student.StuID, x =>
            {
                x.Courses.AddRange(cl);
            });
            this.Close();
        }
    }
}
