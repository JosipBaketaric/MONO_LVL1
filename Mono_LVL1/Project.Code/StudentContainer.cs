using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        private static StudentContainer studentContainer = null;
        public static List<Student> studentList = new List<Student>();

        private StudentContainer() { }

        public static StudentContainer getInstance()
        {
            if(studentContainer == null)
            {
                studentContainer = new StudentContainer();
                return studentContainer;
            }
            return studentContainer;
        }

        public void enlistStudent(Student student)
        {
            studentList.Add(student);
        }

        private void sortStudents()
        {
            if(studentList != null)
                studentList.OrderBy(x => x.lastName);
        }

        public List<Student> getList()
        {
            sortStudents();
            return studentList;
        }

    }
}
