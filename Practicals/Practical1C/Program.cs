/*
 * Practical No 1:
 * C] Create an application that receives the (Student Id, Student Name, Course Name,
 * Date Of Birth) information from a set of student. The application should also display
 * the information of all the students once the data is entered.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical1C
{
    public struct Student
    {
        public String StudentID;
        public String StudentName;
        public String CourseName;
        public String DOB;
    };

    class Program
    {
        public static void Main(string[] args)
        {

            List<Object> StudentRecords = new List<Object>();
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("Welcome to Student Recorde Application");
                Console.WriteLine(" 1] Record Student ");
                Console.WriteLine(" 2] Exit ");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1 :
                        Student student = new Student();
                        Console.Clear();
                        Console.WriteLine("---- Student Record ----");
                        Console.Write("Enter Student ID : ");
                        student.StudentID =  Console.ReadLine();
                        Console.Write("Enter Student Name : ");
                        student.StudentName =  Console.ReadLine();
                        Console.Write("Enter Course Name : ");
                        student.CourseName =  Console.ReadLine();
                        Console.Write("Enter Date of Birth : ");
                        Console.WriteLine();
                        student.DOB =  Console.ReadLine();
                        StudentRecords.Add(student);
                        break;

                    case 2:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("No Options Found");
                        Console.WriteLine("Press any key ..");
                        Console.ReadKey();
                        break;
                }

            }

            Console.Clear();
            Console.WriteLine("Printing Records");

            foreach(Student student in StudentRecords)
            {
                Console.WriteLine("X----------------------------------------X");
                Console.WriteLine("Student ID     : " + student.StudentID);
                Console.WriteLine("Student Name   : " + student.StudentName);
                Console.WriteLine("Course Name    : " + student.CourseName);
                Console.WriteLine("Date of Birth  : " + student.DOB);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exist...");
            Console.ReadKey();
        }
    }
}
