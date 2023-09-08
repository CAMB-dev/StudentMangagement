using StuMS;
using StuMS.Entity;
using StuMS.Util;

namespace StuMSGUI.Util
{
    internal static class Account
    {
        public static bool AccountExist(string account)
        {
            return StuCrud.GetStudentFirstOrDefault(account) != null;
        }

        public static (bool successful, Student student) Login(string account, string passwd)
        {
            var stu = StuCrud.GetStudentFirstOrDefault(account);
            return (Crypto.Md5Encrypt(passwd) == (stu.Password ?? String.Empty), stu);
        }


    }
}
