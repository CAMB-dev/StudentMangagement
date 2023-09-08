namespace StuMS.Entity;

public class Course
{
    public string Name { get; set; } = String.Empty;
    public int CourseTime { get; set; }
    public decimal CourseStudyScore { get; set; }

    public override string ToString()
    {
        return this.Name;
    }
}