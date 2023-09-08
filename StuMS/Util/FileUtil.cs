using System.Text;
using System.Text.Json;
using StuMS.Entity;

namespace StuMS.Util;

public static class FileUtil
{
    private static readonly string StorePath = "./data.json";

    public static void Store()
    {

        var fd = new FileData
        {
            Students = StuCrud.GetStudents(),
            Courses = CourseCrud.GetCourses()
        };
        File.WriteAllText(StorePath, JsonSerializer.Serialize(fd), Encoding.UTF8);
    }

    public static void Read()
    {
        if (!File.Exists(StorePath))
        {
            return;
        }

        var j = JsonSerializer.Deserialize<FileData>(File.ReadAllText(StorePath, Encoding.UTF8));
        StuCrud.AddStudents(j.Students);
        CourseCrud.AddCourses(j.Courses);
    }
}