using System;

namespace coreConsoleProject
{
    public class Student
    {
        // Data members
        int studentId;
        string studentName;

        // Member function to accept details
        public void AcceptDetails()
        {
            Console.WriteLine("Enter student ID:");
            studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student name:");
            studentName = Console.ReadLine();
        }

        // Member function to display details
        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }
    }
}
