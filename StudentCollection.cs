using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace C_10
{
    public class StudentCollection<T> where T : IStudent
    {
        private List<T> students = new List<T>();
        public void Add(T student) 
        {
            students.Add(student);
        }
        public void Remove(T student)
        {
            students.Remove(student);
        }
        public void PrintAllStudents()
        {
            foreach (T student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Major: {student.Major}");
            }
        }
        public IEnumerable<T> FindStudentMajor(string major)
        {
            return students.Where(x => x.Major == major);
        }
        public T FindYoungStudent()
        {
            return students.OrderBy(x => x.Age).FirstOrDefault();
        }
        public T FindYOldStudent()
        {
            return students.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public IEnumerable<T> GetStodentSortedBy(Func<T, object> keySelector)
        {
            return students.OrderBy(keySelector);
        }

    }
}
