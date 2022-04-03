using StructureOfPrivateSchool.Database;
using StructureOfPrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace StructureOfPrivateSchool
{
    public class View
    {
        public static void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*************************");
            Console.WriteLine("Welcome to Private School");
            Console.WriteLine("*************************");
            Console.ResetColor();
            Console.WriteLine();
            Thread.Sleep(800);
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Choose an option:");
            Console.ResetColor();
            Console.WriteLine("1. Input Data");
            Console.WriteLine("2. View all Courses");
            Console.WriteLine("3. View all Trainers");
            Console.WriteLine("4. View all Students");
            Console.WriteLine("5. View all Assignments");
            Console.WriteLine("6. View all Trainers per Course");
            Console.WriteLine("7. View all Students per Course");
            Console.WriteLine("8. View all Assignments per Course");
            Console.WriteLine("9. View all Students per Course per Assignment");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + "Press e or E to EXIT the application!");
            Console.ResetColor();
        }

        public static void SecondMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Choose an option:"); ;
            Console.ResetColor();
            Console.WriteLine("1. Add a new Course");
            Console.WriteLine("2. Add a new Trainer");
            Console.WriteLine("3. Add a new Student");
            Console.WriteLine("4. Add a new Assignment");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press e or E to return to the Menu!");
            Console.ResetColor();
        }

        public static void Courses(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("All Courses" + "\n");
            Console.ResetColor();
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{ new string('-', 15) }+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"|{"ID",-5}|{"Title",-15}|{"Stream",-15}|{"Type",-15}|{"StartDate",-15}|{"EndDate",-15}|");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.Print();
            }
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{ new string('-', 15) }+");
        }

        public static void Trainers(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("All Trainers" + "\n");
            Console.ResetColor();
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"|{"ID",-5}|{"FirstName",-15}|{"LastName",-15}|{"Subject",-15}|");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                trainer.Print();
            }
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
        }

        public static void Students(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("All Students" + "\n");
            Console.ResetColor();
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"|{"ID",-5}|{"FirstName",-15}|{"LastName",-15}|{"DateOfBirth",-15}|{"Fees",-15}|");
            Console.ResetColor();
            foreach (var student in students)
            {
                student.Print();
            }
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
        }

        public static void Assignments(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("All Assignments" + "\n");
            Console.ResetColor();
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 30)}+{new string('-', 30)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"|{"ID",-5}|{"Title",-30}|{"Description",-30}|{"SubDateTime",-15}|{"OralMark",-15}|{"TotalMark",-15}|");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                assignment.Print();
            }
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 30)}+{new string('-', 30)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
        }

        public static void TrainersPerCourse(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("All Trainers per Courses" + "\n");
            Console.ResetColor();
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"|{"FirstName",-15}|{"LastName",-15}|{"Course",-15}|");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                trainer.PrintTrainersFullName();
                foreach (var course in trainer.Courses)
                {
                    course.PrintCourseTitle();
                }
            }
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+");
        }

        public static void StudentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("All Students per Courses" + "\n");
            Console.ResetColor();
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"|{"Course",-15}|{"FirstName",-15}|{"LastName",-15}|");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+");
                course.PrintCourseTitle2();
                foreach (var student in course.Students)
                {
                    student.PrintStudentsFullName();
                }
            }
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+");
        }

        public static void AssignmentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("All Assignments per Courses" + "\n");
            Console.ResetColor();
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 30)}+{new string('-', 30)}+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"|{"Course",-15}|{"Assignments",-30}|{"Description",-30}|");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{new string('-', 15)}-+{new string('-', 30)}+{new string('-', 30)}+");
                course.PrintCourseTitle1();
                foreach (var assignment in course.Assignments)
                {
                    assignment.PrintAssignmentTitleAndDescription();
                }
            }
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 30)}+{new string('-', 30)}+");
        }

        public static void StudentsPerCoursePerAssignment(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("All Students per Assignments per Course" + "\n");
            Console.ResetColor();
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 30)}+{new string('-', 30)}+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"|{"Course",-15}|{"FirstName",-15}|{"LastName",-15}|{"Assignments",-30}|{"Description",-30}|");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 30)}+{new string('-', 30)}+");
                course.PrintCourseTitle3();
                foreach (var student in course.Students)
                {
                    student.PrintStudentsFullName1();
                    foreach (var assignment in course.Assignments)
                    {
                        assignment.PrintAssignmentTitleAndDescription1();
                    }
                }
            }
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 30)}+{new string('-', 30)}+");
        }

        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Choice." + "\n" + "Please select from numbers 1-9" + "\n");
            Console.ResetColor();
        }
    }
}