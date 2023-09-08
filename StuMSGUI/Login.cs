using StuMS.Entity;
using StuMS.Enum;
using StuMS.Util;
using StuMSGUI.Util;

namespace StuMSGUI
{
    public partial class Login : Form
    {

        private readonly string _defaultAdmin = "admin";
        private readonly string _defaultAdminPasswd = Crypto.Md5Encrypt("admin");

        public Login()
        {
            InitializeComponent();
            FileUtil.Read();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == _defaultAdmin)
            {
                if (Crypto.Md5Encrypt(PasswordTextBox.Text) == _defaultAdminPasswd)
                {
                    MainWindow._permission = Permission.Administrator;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login denied. Incorrect username or password.");
                }
            }
            else
            {
                if (Account.AccountExist(UserNameTextBox.Text))
                {
                    (bool isLogin, Student stu) loginStatus = Account.Login(UserNameTextBox.Text, PasswordTextBox.Text);
                    if (loginStatus.isLogin)
                    {
                        MainWindow._loginStudent = loginStatus.stu;
                        MainWindow._permission = loginStatus.stu.Permission;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login denied. Incorrect username or password.");
                    }

                }
                else
                {
                    MessageBox.Show("Login denied. Incorrect username or password.");
                }
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Thread th = new(new ThreadStart(LoadSavedData));
            th.Start();
        }

        public void LoadSavedData()
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginBtn_Click(sender, e);
            }
        }
    }
}