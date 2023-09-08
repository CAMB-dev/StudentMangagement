using StuMS.Entity;

namespace StuMS;

public static class CourseCrud
{
    private static List<Course> _courses = new();

    // Create

    public static void AddCourses(List<Course> courses)
    {
        foreach (var item in courses)
        {
            AddCourse(item);
        }
    }

    public static void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    // Read

    public static List<Course> GetCourses(string courseName) => _courses.Where(x => x.Name == courseName).ToList();

    public static Course? GetCourseFirstOrDefault(string courseName) => GetCourses(courseName).FirstOrDefault();

    public static List<Course> GetCourses(Func<Course, bool> pred) => _courses.Where(pred).ToList();

    public static List<Course> GetCourses()
    {
        return _courses;
    }

    // Update

    public static void UpdateCourse(string courseName, Action<Course> action)
    {
        foreach (var item in _courses)
        {
            if (item.Name == courseName)
            {
                action(item);
            }
        }
    }

    public static void UpdateCourse(Func<Course, bool> pred, Action<Course> action)
    {
        foreach (var item in _courses)
        {
            if (pred(item))
            {
                action(item);
            }
        }
    }

    // Delete

    public static void DeleteCourse(string courseName)
    {
        _courses.RemoveAll(x => x.Name == courseName);
    }

    public static void DeleteCourse(Predicate<Course> pred)
    {
        _courses.RemoveAll(pred);
    }
}