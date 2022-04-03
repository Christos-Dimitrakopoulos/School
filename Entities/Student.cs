using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfPrivateSchool.Entities
{
    public class Student
    {
        public Student()
        {

        }

        public Student(int id, string firstName, string lastName, DateTime dateOfBirth, double fees)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Fees = fees;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Fees { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

        public void Print()
        {
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
            Console.WriteLine($"|{ID,-5}|{FirstName,-15}|{LastName,-15}|{DateOfBirth.ToShortDateString(),-15}|{Fees,-15}|");
        }

        public void PrintStudentsFullName()
        {
            Console.WriteLine($"|{"",-15}|{FirstName,-15}|{LastName,-15}|");
        }

        //Method For StudentsPerCoursePerAssignment
        public void PrintStudentsFullName1()
        {
            Console.WriteLine($"|{ "",-15}|{ FirstName,-15}|{ LastName,-15}|{"",-30}|{"",-30}|");
        }
    }
}
