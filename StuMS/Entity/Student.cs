using StuMS.Enum;

namespace StuMS.Entity;

public class Student
{
    public string Name { get; set; } = String.Empty;
    public int Age { get; set; }
    public Gender Gender { get; set; } = Gender.Unknown;
    public string StuID { get; set; } = String.Empty;
    public Permission Permission { get; set; } = Permission.User;
    public List<Course> Courses { get; set; } = new List<Course>();
    public List<Score> Score { get; set; } = new();
    public string Password { get; set; } = String.Empty;
}