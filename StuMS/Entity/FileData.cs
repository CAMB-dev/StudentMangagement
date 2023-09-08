namespace StuMS.Entity;

public class FileData
{
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Course> Courses { get; set; } = new List<Course>();
}