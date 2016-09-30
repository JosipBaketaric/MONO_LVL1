using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Code;

namespace Project.App
{
    class Program
    {

        static void Main(string[] args)
        {
            string input;
            string response;

            do
            {
                Console.Write("\nOperation: ");
                input = Console.ReadLine();
                input = input.ToUpper();

                response = Validation.getInstance().validateOperation(input);

                if (response == Operations.validationOK)
                {
                    if (input == Operations.display)
                        displayStudents();
                    else
                        enlistStudent();
                }
                else
                {
                    Console.Write("\n" + response);
                }
            }
            while (input == Operations.enlist || !response.Equals(Operations.validationOK));

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
           
        }

        static void enlistStudent()
        {
            string firstName;
            string lastName;
            string gpa;
            float fGpa;
            string response;

            do
            {
                Console.Write("\n" + "Student");
                Console.Write("\n" + "First name: ");
                firstName = Console.ReadLine();
                response = Validation.getInstance().validateStrings(firstName);

                if (!response.Equals(Operations.validationOK))
                {
                    Console.Write("\n" + response);
                    continue;
                }
                    

            }
            while (!response.Equals(Operations.validationOK) );

            do
            {
                Console.Write("\n" + "Last name: ");
                lastName = Console.ReadLine();
                response = Validation.getInstance().validateStrings(lastName);

                if (!response.Equals(Operations.validationOK))
                {
                    Console.Write("\n" + response);
                    continue;
                }

            }
            while (!response.Equals(Operations.validationOK));

            do
            {
                Console.Write("\n" + "GPA: ");
                gpa = Console.ReadLine();
                response = Validation.getInstance().validateGpa(gpa);

                if (!response.Equals(Operations.validationOK))
                {
                    Console.Write("\n" + response);
                    continue;
                }

            }
            while (!response.Equals(Operations.validationOK));

            float.TryParse(gpa,out fGpa);

            Student student = new Student();
            student.firstName = firstName;
            student.lastName = lastName;
            student.gpa = fGpa;
            student.id = StudentIdGenerator.getInstance().generateStudentId();

            StudentContainer.getInstance().enlistStudent(student);
        }
        
                    

        static void displayStudents()
        {
            int counter = 0;
            List<Student> studentList = StudentContainer.getInstance().getList();

            if (!studentList.Any())
            {
                Console.Write("\n No students enlisted.");
                return;
            }

            Console.Write("\n" + "Students in a system:");

            foreach (Student student in studentList)
            {
                Console.Write("\n" +  ++counter + ". " + student.lastName + ", " + student.firstName + " - " + student.gpa + "\n");
            }

        }

    }
}
