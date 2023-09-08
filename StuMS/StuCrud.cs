using StuMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StuMS
{
    public static class StuCrud
    {
        private static List<Student> _students = new();

        // Create

        public static void AddStudents(List<Student> students)
        {
            foreach (var item in students)
            {
                AddStudent(item);
            }
        }

        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }

        // Read

        public static List<Student> GetStudents(string stuid) => _students.Where(x => x.StuID == stuid).ToList();

        public static Student? GetStudentFirstOrDefault(string stuid) => GetStudents(stuid).FirstOrDefault();

        public static List<Student> GetStudents(Func<Student, bool> pred) => _students.Where(pred).ToList();

        public static List<Student> GetStudents() { return _students; }

        // Update

        public static void UpdateStudent(string stuid, Action<Student> action)
        {
            foreach (var item in _students)
            {
                if (item.StuID == stuid)
                {
                    action(item);
                }
            }
        }

        public static void UpdateStudent(Func<Student, bool> pred, Action<Student> action)
        {
            foreach (var item in _students.Where(pred))
            {
                action(item);
            }
        }

        // Delete

        public static void DeleteStudent(string stuid)
        {
            _students.RemoveAll(x => x.StuID == stuid);
        }

        public static void DeleteStudent(Predicate<Student> pred)
        {
            _students.RemoveAll(pred);
        }

    }
}
