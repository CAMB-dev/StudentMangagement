using StuMS;
using StuMS.Entity;
using StuMS.Enum;
using StuMS.Util;
using StuMSGUI.Enum;

namespace StuMSGUI
{
    public partial class InfoWindow : Form
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private bool _userMode = false;
        private QueryMode queryMode;

        public void UseUserMode()
        {
            _userMode = true;
        }

        public void ExitUserMode()
        {
            _userMode = false;
        }

        public void Init(QueryMode queryMode, Student? student)
        {
            this.queryMode = queryMode;
            switch (queryMode)
            {
                case QueryMode.Create:
                    ModeLabel.Text += queryMode.ToString();
                    break;
                case QueryMode.Update:
                    ModeLabel.Text += queryMode.ToString();
                    StuIDTextBox.Enabled = false;

                    if (_userMode)
                    {
                        PermissionComboBox.Enabled = false;
                    }

                    if (student != null)
                    {
                        NameTextBox.Text = student.Name;
                        AgeNumeric.Value = student.Age;
                        GenderComboBox.SelectedIndex = student.Gender == Gender.Male ? 0 : 1;
                        StuIDTextBox.Text = student.StuID;
                        PermissionComboBox.SelectedIndex = student.Permission == Permission.User ? 0 : 1;
                    }
                    else
                    {
                        MessageBox.Show("Unexcepted data source", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                    break;
                case QueryMode.Query:

                    StuIDTextBox.Enabled = false;
                    AgeNumeric.Enabled = false;
                    GenderComboBox.Enabled = false;
                    NameTextBox.Enabled = false;
                    PermissionComboBox.Enabled = false;
                    PasswordTextBox.Enabled = false;

                    ModeLabel.Text += queryMode.ToString();
                    NameTextBox.Text = student.Name;
                    AgeNumeric.Value = student.Age;
                    GenderComboBox.SelectedIndex = student.Gender == Gender.Male ? 0 : 1;
                    StuIDTextBox.Text = student.StuID;
                    PermissionComboBox.SelectedIndex = student.Permission == Permission.User ? 0 : 1;
                    break;
                default: this.Close(); break;
            }
        }

        Func<int, Gender> ParseGender = x =>
        {
            return x switch
            {
                0 => Gender.Male,
                1 => Gender.Female,
                _ => Gender.Unknown
            };
        };

        Func<int, Permission> ParsePermission = x =>
        {
            return x switch
            {
                0 => Permission.User,
                1 => Permission.Administrator,
                _ => Permission.User
            };
        };

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (StuCrud.GetStudentFirstOrDefault(StuIDTextBox.Text) != null && queryMode == QueryMode.Create)
            {
                MessageBox.Show($"StuID {StuIDTextBox.Text} has been exist", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (queryMode == QueryMode.Update || queryMode == QueryMode.Create)
            {
                var temp = StuCrud.GetStudentFirstOrDefault(StuIDTextBox.Text);
                StuCrud.DeleteStudent(StuIDTextBox.Text);
                StuCrud.AddStudent(new Student
                {
                    Name = NameTextBox.Text,
                    Age = (int)AgeNumeric.Value,
                    Gender = ParseGender(GenderComboBox.SelectedIndex),
                    StuID = StuIDTextBox.Text,
                    Permission = ParsePermission(PermissionComboBox.SelectedIndex),
                    Password = PasswordTextBox.Text == "" ? temp.Password : Crypto.Md5Encrypt(PasswordTextBox.Text),
                });

                this.Close();
            }
            else
            {
                this.Close();
            }

        }

        private void InfoWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
