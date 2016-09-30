using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator idGenerator = null;
        private int studentId;

        private StudentIdGenerator()
        {
            studentId = 0;
        }

        public static StudentIdGenerator getInstance()
        {
            if(idGenerator == null)
            {
                idGenerator = new StudentIdGenerator();
                return idGenerator;
            }
            return idGenerator;
        }

        public int generateStudentId()
        {
            return studentId++; //Return then increment
        }

    }
}
