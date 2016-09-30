using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    class StudentContainer
    {
        private static StudentContainer studentContainer = null;
        List<Student> studentList { get; }

        private StudentContainer() { }

        public StudentContainer getInstance()
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

    }
}
