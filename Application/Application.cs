using StructureOfPrivateSchool.Database;
using StructureOfPrivateSchool.Entities;
using System;
using System.Collections.Generic;

namespace StructureOfPrivateSchool
{
    public class Application
    {
        public static void Run()
        {
            MyDatabase db = new MyDatabase();
            string input;
            do
            {
                View.Menu();
                input = Console.ReadLine();
                Console.Clear();
                Console.Beep(400, 100);
                Controller(db, input);
            } while (input != "e" && input != "E");
        }

        private static void Controller(MyDatabase db, string input)
        {
            switch (input)
            {
                case "1": InputDataMenu(db); break;
                case "2": View.Courses(db.Courses); break;
                case "3": View.Trainers(db.Trainers); break;
                case "4": View.Students(db.Students); break;
                case "5": View.Assignments(db.Assignments); break;
                case "6": View.TrainersPerCourse(db.Trainers); break;
                case "7": View.StudentsPerCourse(db.Courses); break;
                case "8": View.AssignmentsPerCourse(db.Courses); break;
                case "9": View.StudentsPerCoursePerAssignment(db.Courses); break;
                default: View.Error(); break;
            }
        }

        public static void InputDataMenu(MyDatabase db)
        {
            View.SecondMenu();
            string answer;
            answer = Console.ReadLine();
            Console.Beep(400, 100);
            switch (answer)
            {
                case "1":
                    db.Courses.Add(AddCourse(db));
                    Console.WriteLine("\n" + "Do you want to add more?" + "\n" + "press 'yes' or 'no' to continue");
                    string inputCourse = Console.ReadLine();
                    while (inputCourse == "yes")
                    {
                        Console.Clear();
                        db.Courses.Add(AddCourse(db));
                        Console.WriteLine("\n" + "Do you want to add more?" + "\n" + "press 'yes' or 'no' to continue");
                        inputCourse = Console.ReadLine();
                    };
                    Console.Clear();
                    break;
                case "2":
                    db.Trainers.Add(AddTrainer(db));
                    Console.WriteLine("\n" + "Do you want to add more?" + "\n" + "press 'yes' or 'no' to continue");
                    string inputTrainer = Console.ReadLine();
                    while (inputTrainer == "yes")
                    {
                        Console.Clear();
                        db.Trainers.Add(AddTrainer(db));
                        Console.WriteLine("\n" + "Do you want to add more?" + "\n" + "press 'yes' or 'no' to continue");
                        inputTrainer = Console.ReadLine();
                    };
                    Console.Clear();
                    break;
                case "3":
                    db.Students.Add(AddStudent(db));
                    Console.WriteLine("\n" + "Do you want to add more?" + "\n" + "press 'yes' or 'no' to continue");
                    string inputStudent = Console.ReadLine();
                    while (inputStudent == "yes")
                    {
                        Console.Clear();
                        db.Students.Add(AddStudent(db));
                        Console.WriteLine("\n" + "Do you want to add more?" + "\n" + "press 'yes' or 'no' to continue");
                        inputStudent = Console.ReadLine();
                    };
                    Console.Clear();
                    break;
                case "4":
                    db.Assignments.Add(AddAssignment(db));
                    Console.WriteLine("\n" + "Do you want to add more?" + "\n" + "press 'yes' or 'no' to continue");
                    string inputAssignment = Console.ReadLine();
                    while (inputAssignment == "yes")
                    {
                        Console.Clear();
                        db.Assignments.Add(AddAssignment(db));
                        Console.WriteLine("\n" + "Do you want to add more?" + "\n" + "press 'yes' or 'no' to continue");
                        inputAssignment = Console.ReadLine();
                    };
                    Console.Clear();
                    break;
                default: 
                    break;
            }
        }

        public static Course AddCourse(MyDatabase db)
        {
            Course course = new Course();
            int lastId = db.Courses[db.Courses.Count - 1].ID;
            course.ID = lastId + 1;
            Console.WriteLine("\n" + "Give course's title:");
            course.Title = Console.ReadLine();
            Console.WriteLine("\n" + "Give course's stream:");
            course.Stream = Console.ReadLine();
            Console.WriteLine("\n" + "Give course's type:");
            course.Type = Console.ReadLine();
            Console.WriteLine("\n" + "Give course's start date time:  e.g(5/8/2020)");
            course.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\n" + "Give course's end date time:  e.g(5/8/2020)");
            course.EndDate = Convert.ToDateTime(Console.ReadLine());

            return course;
        }

        public static Trainer AddTrainer(MyDatabase db)
        {
            Trainer trainer = new Trainer();
            int lastId = db.Trainers[db.Trainers.Count - 1].ID;
            trainer.ID = lastId + 1;
            Console.WriteLine("\n" + "Give trainer's first name:");
            trainer.FirstName = Console.ReadLine();
            Console.WriteLine("\n" + "Give trainer's last name:");
            trainer.LastName = Console.ReadLine();
            Console.WriteLine("\n" + "Choose a number for trainer's subject: 1.FrontEnd, 2.BackEnd, 3.OOP or 4.Databases");
            trainer.Subject = (Enums.Subject)Convert.ToInt32(Console.ReadLine());
            if (!Enum.IsDefined(typeof(Enums.Subject), trainer.Subject)) trainer.Subject = Enums.Subject.Unemployed;

            return trainer;
        }

        public static Student AddStudent(MyDatabase db)
        {
            Student student = new Student();
            int lastId = db.Trainers[db.Trainers.Count - 1].ID;
            student.ID = lastId + 1;
            Console.WriteLine("\n" + "Give student's first name:");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("\n" + "Give student's last name:");
            student.LastName = Console.ReadLine();
            Console.WriteLine("\n" + "Give student's date of birth:  e.g(21/10/1995)");
            student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\n" + "Give student's fees:");
            student.Fees = Convert.ToDouble(Console.ReadLine());

            return student;
        }

        public static Assignment AddAssignment(MyDatabase db)
        {
            Assignment assignment = new Assignment();
            int lastId = db.Courses[db.Courses.Count - 1].ID;
            assignment.ID = lastId + 1;
            Console.WriteLine("\n" + "Give assignment's title:");
            assignment.Title = Console.ReadLine();
            Console.WriteLine("\n" + "Give assignment's description:");
            assignment.Description = Console.ReadLine();
            Console.WriteLine("\n" + "Give assignment's date of submission:  e.g(18/10/2021)");
            assignment.SubDateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\n" + "Give assignment's oral mark:");
            assignment.OralMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + "Give assignment's total mark:");
            assignment.TotalMark = Convert.ToInt32(Console.ReadLine());

            return assignment;
        }
    }
}
