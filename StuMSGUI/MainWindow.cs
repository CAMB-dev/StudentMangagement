using StuMS;
using StuMS.Entity;
using StuMS.Enum;
using StuMS.Util;
using StuMSGUI.Enum;
using StuMSGUI.Util;

namespace StuMSGUI
{
    public partial class MainWindow : Form
    {
        internal static Permission _permission = Permission.User;
        internal static Student _loginStudent = null;
        private TabPage _userTabPage;
        private TabPage _adminTabPage;

        public void RefreshStuListView()
        {
            StuListView.Items.Clear();

            foreach (var item in StuCrud.GetStudents())
            {
                StuListView.Items.Add(
                    new ListViewItem(
                        new string[] {
                                "",
                                item.Name,
                                item.Age.ToString(),
                                item.Gender.ToString(),
                                item.StuID,
                                item.Permission.ToString(),
                                string.Join(",", item.Courses)
                        }
                        )
                    );
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            _userTabPage = OperationTabControl.TabPages[0];
            _adminTabPage = OperationTabControl.TabPages[1];
            OperationTabControl.TabPages.Clear();
            Login login = new Login();
            login.ShowDialog();
            PermissionLabel.Text += _permission.ToString();
            if (_permission == Permission.Administrator)
            {
                OperationTabControl.TabPages.Add(_adminTabPage);
                OperationTabControl.Left *= 2;
                OperationTabControl.Top *= 2;
                StuListView.Size = new Size(StuListView.Width * 2, StuListView.Height * 2);
                this.Size = new Size(this.Size.Width * 2, this.Size.Height * 2);
                OperationTabControl.Size = new Size(OperationTabControl.Width * 2, OperationTabControl.Height * 2);

                QueryBtn.Visible = true;
                ModifyBtn.Visible = true;
                DeleteBtn.Visible = true;
                AddBtn.Visible = true;
                CourseManageBtn.Visible = true;
                ScoreBtn.Visible = true;

                RefreshStuListView();
            }
            else
            {
                OperationTabControl.TabPages.Add(_userTabPage);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Init(QueryMode.Create, null);
            infoWindow.ShowDialog();
            RefreshStuListView();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (StuListView.SelectedItems == null || StuListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Invalid Select", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in StuListView.SelectedItems)
            {
                var stuid = item.SubItems[4].Text;
                StuCrud.DeleteStudent(stuid);
            }

            RefreshStuListView();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (StuListView.SelectedItems == null || StuListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Invalid Select", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InfoWindow infoWindow = new InfoWindow();
            if (StuListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("You select more than 1 student, only the fisrt one will be modified.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var stu = StuCrud.GetStudentFirstOrDefault(StuListView.SelectedItems[0].SubItems[4].Text);

            infoWindow.Init(QueryMode.Update, stu);
            infoWindow.ShowDialog();
            RefreshStuListView();
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            if (StuListView.SelectedItems == null || StuListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Invalid Select", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StuListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("You select more than 1 student, only the fisrt one will be queried.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var stu = StuCrud.GetStudentFirstOrDefault(StuListView.SelectedItems[0].SubItems[4].Text);

            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Init(QueryMode.Query, stu);
            infoWindow.ShowDialog();
        }

        private void ScoreBtn_Click(object sender, EventArgs e)
        {
            if (StuListView.SelectedItems == null || StuListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Invalid Select", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StuListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("You select more than 1 student, only the fisrt one will be queried.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ScoreManagementWindow scoreManagementWindow = new ScoreManagementWindow();
            ScoreManagementWindow.SetStudent(StuCrud.GetStudentFirstOrDefault(StuListView.SelectedItems[0].SubItems[4].Text));
            scoreManagementWindow.ShowDialog();
        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {
            if (StuListView.SelectedItems == null || StuListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Invalid Select", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StuListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("You select more than 1 student, only the fisrt one will be queried.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var stu = StuCrud.GetStudentFirstOrDefault(StuListView.SelectedItems[0].SubItems[4].Text);
            CourseWindow courseWindow = new CourseWindow();
            courseWindow.Init(stu);
            courseWindow.ShowDialog();
            RefreshStuListView();
        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileUtil.Store();
        }

        private void EditProfileBtn_Click(object sender, EventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.UseUserMode();
            infoWindow.Init(QueryMode.Update, _loginStudent);
            infoWindow.ShowDialog();
        }

        private void QueryScoreBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ScoreUtil.GenerateScoreString(_loginStudent.Score), "Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CourseManageBtn_Click(object sender, EventArgs e)
        {
            CourseManagementWindow courseManagementWindow = new CourseManagementWindow();
            courseManagementWindow.ShowDialog();
        }

    }
}
